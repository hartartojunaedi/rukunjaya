Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailOperationalKendaraan
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    Public insert As Boolean = True
    Public kodeTransaksi As String = ""
    Private Function ceksimpan() As String
        Dim flag As Boolean = True
        If cmbKendaraan.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Nopol Harus Diisi !")
            flag = False
        End If
        If cmbsopir.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Sopir Harus Diisi !")
            flag = False
        End If
        Try
            Dim a As Double = CType(numBiaya.Value, Double)
            Dim b As Integer = CType(numJumlah.Value, Integer)
        Catch ex As Exception
            _rjcommon.shownotifyerror("Biaya dan Jumlah Harus Berupa Angka ")
            flag = False
        End Try
        Return flag
    End Function
    Private Sub initcmbkendaraan()
        cmd.CommandText = "SELECT nopol, nolambung FROM tkendaraan order by nopol"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        'jun 26 desember 2014
        'cek kalau belum ada isinya
        If dt.Rows.Count <= 0 Then
            btnSimpan.Enabled = False
        End If
        Dim dr As DataRow = dt.NewRow
        dr.Item("nolambung") = ""
        dr.Item("nopol") = "Nopol"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbKendaraan.DataSource = dt
        cmbKendaraan.DisplayMember = "nopol"
        cmbKendaraan.ValueMember = "nolambung"
    End Sub
    Private Sub initcmbsopir()
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tsopir order by namasopir"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        'jun 26 desember 2014
        'cek kalau belum ada isinya
        If dt.Rows.Count <= 0 Then
            btnSimpan.Enabled = False
        End If
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodesopir") = ""
        dr.Item("namasopir") = "NamaSopir"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbsopir.DataSource = dt
        cmbsopir.DisplayMember = "namasopir"
        cmbsopir.ValueMember = "kodesopir"
    End Sub
    Private Sub loaddetail()
        cmd.CommandText = "SELECT ok.tgltransaksi,k.nopol,ok.keterangan,ok.jumlah,ok.harga,ok.nolambung,isnull(ok.bkk,'') as bkk,isnull(ok.kodesopir,'') as kodesopir "
        cmd.CommandText &= " from toperationalkendaraan ok,tkendaraan k"
        cmd.CommandText &= " WHERE kodetransaksi=@kodetrans and ok.nolambung=k.nolambung"
        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlParameter("@kodetrans", kodeTransaksi))
        Dim reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            dtpTanggalTransaksi.Value = reader("tgltransaksi")
            cmbKendaraan.SelectedValue = reader("nolambung")
            cmbsopir.SelectedValue = reader("kodesopir")
            CheckBox1.Checked = reader("bkk")
            numBiaya.Value = reader("harga")
            numJumlah.Value = reader("jumlah")
            txtKeterangan.Text = reader("keterangan")
        End If
        reader.Close()
    End Sub
    Private Sub init()
        'init form
        btnSimpan.Enabled = True
        txtKodeTrans.Select()
        numBiaya.Value = 0
        txtKeterangan.Text = ""
        Try
            con = New SqlConnection
            con.ConnectionString = _rjcommon.getconnstr()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand("", con)
            'inisialisasi combobox
            initcmbkendaraan()
            initcmbsopir()
            'Jika sedang dalam mode update, load isi formnya
            If Not insert Then
                txtKodeTrans.Text = kodeTransaksi
                dtpTanggalTransaksi.Select()
                txtKodeTrans.Enabled = True
                txtKodeTrans.ReadOnly = True
                loadDetail()
            Else
                txtKodeTrans.Clear()
                txtKodeTrans.Enabled = True
                txtKodeTrans.ReadOnly = False
                dtpTanggalTransaksi.Value = Now
            End If
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmDetailOperationalKendaraan_Load", "Transaksi Operational Kendaraan", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub
    Private Sub frmDetailOperationalKendaraan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init()
    End Sub
    Private Function getKodeTransaksi() As String
        getKodeTransaksi = txtKodeTrans.Text
        Return getKodeTransaksi
    End Function
    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub
    Private Sub doInsert()
        kodeTransaksi = getKodeTransaksi()
        Try
            If kodeTransaksi.Trim() = "" Then
                _rjcommon.shownotifyerror("Kode Transaksi harus diisi")
                Exit Sub
            End If
            cmd.CommandText = "SELECT count(kodetransaksi) FROM tOperationalkendaraan WHERE kodetransaksi=@kodetrans"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetrans", txtKodeTrans.Text))
            If cmd.ExecuteScalar() > 0 Then 'jika kode sudah pernah ada di database
                _rjcommon.shownotifyerror("Kode Transaksi sudah ada")
                Exit Sub
            End If
            cmd.CommandText = "insert into tOperationalkendaraan(kodetransaksi, tgltransaksi, nolambung, jumlah,harga, keterangan,kodesopir,bkk) values(@kodetransaksi, @tgltransaksi, @nolambung,@jumlah, @harga, @keterangan,@kodesopir,@bkk)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodeTransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbKendaraan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@nolambung", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@nolambung", cmbKendaraan.SelectedValue))
            End If
            If cmbsopir.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kodesopir", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kodesopir", cmbsopir.SelectedValue))
            End If
            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@jumlah", numJumlah.Value))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            cmd.Parameters.Add(New SqlParameter("@bkk", CheckBox1.Checked))

            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Operational Kendaraan", "Tambah Data", "")
            _rjcommon.shownotify("Detail operational kendaraan berhasil ditambahkan")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Operational Kendaraan", "Tambah Data", ex.Message)
            _rjcommon.shownotifyerror("Detail operational kendaraan gagal ditambahkan")
        End Try
    End Sub
    Private Sub doupdate()
        Try
            cmd.CommandText = "update tOperationalKendaraan set bkk=@bkk,kodesopir=@kodesopir,tgltransaksi=@tgltransaksi, nolambung=@nolambung, harga=@harga, jumlah=@jumlah,keterangan=@keterangan WHERE kodetransaksi=@kodetransaksi"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodeTransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbKendaraan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@nolambung", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@nolambung", cmbKendaraan.SelectedValue))
            End If
            If cmbsopir.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kodesopir", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kodesopir", cmbsopir.SelectedValue))
            End If

            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@jumlah", numJumlah.Value))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            cmd.Parameters.Add(New SqlParameter("@bkk", CheckBox1.Checked))

            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Operational Kendaraan", "Update data", "")
            _rjcommon.shownotify("Detail operational kendaraan berhasil diubah")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Operational Kendaraan", "Update Data", ex.Message)
            _rjcommon.shownotifyerror("Detail operational kendaraan gagal diubah")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If insert Then
                doInsert()
            Else
                doupdate()
            End If
        Else
            MsgBox("Nopol Belum Dipilih atau angka salah !")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class