Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailBiayaLain
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    Public insert As Boolean = True
    Public kodeTransaksi As String = ""
    'jun 26 desember 2014
    Private Function ceksimpan() As String
        Dim flag As Boolean = True
        If cmbJenis.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Jenis Biaya Harus Diisi !")
            flag = False
        End If
        If cmbKaryawan.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Karyawan Harus Diisi !")
            flag = False
        End If
        Try
            Dim a As Double = CType(numBiaya.Value, Double)
        Catch ex As Exception
            _rjcommon.shownotifyerror("Biaya Harus Berupa Angka ")
            flag = False
        End Try
        Return flag
    End Function
    Private Function getKodeTransaksi() As String
        getKodeTransaksi = txtKodeTrans.Text
        Return getKodeTransaksi
    End Function

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
            initCmbJenis()
            initCmbSopir()
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
                CheckBox1.Checked = False
                dtpTanggalTransaksi.Value = Now
            End If
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmMasterBiayaLain_Load", "frmMasterBiayaLain", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub loadDetail()
        cmd.CommandText = "SELECT isnull(op.bkk,0) as bkk,op.tgltransaksi, ISNULL(op.jenis, '') as jenis, op.harga, op.keterangan, ISNULL(op.kode,'') as sopir FROM tOperational op"
        cmd.CommandText &= " WHERE kodetransaksi=@kodetrans"
        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlParameter("@kodetrans", kodeTransaksi))
        Dim reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            dtpTanggalTransaksi.Value = reader("tgltransaksi")
            cmbJenis.SelectedValue = reader("jenis")
            cmbKaryawan.SelectedValue = reader("sopir")
            numBiaya.Value = reader("harga")
            txtKeterangan.Text = reader("keterangan")
            CheckBox1.Checked = reader("bkk")
        End If
        reader.Close()
    End Sub

    Private Sub initCmbJenis()
        cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational WHERE jenis=0"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        'jun 26 desember 2014
        'cek kalau belum ada isinya
        If dt.Rows.Count <= 0 Then
            btnSimpan.Enabled = False
        End If
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodejenis") = ""
        dr.Item("namajenis") = "-- Pilih Jenis --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbJenis.DataSource = dt
        cmbJenis.DisplayMember = "namajenis"
        cmbJenis.ValueMember = "kodejenis"
    End Sub

    Private Sub initCmbSopir()
        'jun 19 april 2016 karyawan dan sopir 1->karyawan 0 sopir
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir WHERE status=1 or status=0"
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
        dr.Item("namasopir") = "-- Pilih Karyawan --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbKaryawan.DataSource = dt
        cmbKaryawan.DisplayMember = "namasopir"
        cmbKaryawan.ValueMember = "kodesopir"
    End Sub

    Private Sub doInsert()
        kodeTransaksi = getKodeTransaksi()
        Try
            If kodeTransaksi.Trim() = "" Then
                _rjcommon.shownotifyerror("Kode Transaksi harus diisi")
                Exit Sub
            End If
            cmd.CommandText = "SELECT count(kodetransaksi) FROM tOperational WHERE kodetransaksi=@kodetrans"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetrans", txtKodeTrans.Text))
            If cmd.ExecuteScalar() > 0 Then 'jika kode sudah pernah ada di database
                _rjcommon.shownotifyerror("Kode Transaksi sudah ada")
                Exit Sub
            End If
            cmd.CommandText = "insert into tOperational(kodetransaksi, tgltransaksi, jenis, harga, keterangan, kode,bkk) values(@kodetransaksi, @tgltransaksi, @jenis, @harga, @keterangan, @kode,@bkk)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodeTransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbJenis.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@jenis", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@jenis", cmbJenis.SelectedValue))
            End If
            cmd.Parameters.Add(New SqlParameter("@bkk", CheckBox1.Checked))
            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            If cmbKaryawan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kode", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
            End If
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Biaya Operasional", "Tambah Data", "")
            _rjcommon.shownotify("Detail biaya lain berhasil ditambahkan")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Biaya Operasional", "Tambah Data", ex.Message)
            _rjcommon.shownotifyerror("Detail biaya lain gagal ditambahkan")
        End Try
    End Sub

    Private Sub doUpdate()
        Try
            cmd.CommandText = "update tOperational set bkk=@bkk,tgltransaksi=@tgltransaksi, jenis=@jenis, harga=@harga, keterangan=@keterangan, kode=@kode WHERE kodetransaksi=@kodetransaksi"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodetransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbJenis.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@jenis", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@jenis", cmbJenis.SelectedValue))
            End If
            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@bkk", CheckBox1.Checked))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            If cmbKaryawan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kode", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
            End If
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Biaya Operasional", "Update data", "")
            _rjcommon.shownotify("Detail biaya lain berhasil diubah")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Biaya Operasional", "Update Data", ex.Message)
            _rjcommon.shownotifyerror("Detail biaya lain gagal diubah")
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If insert Then
                doInsert()
            Else
                doUpdate()
            End If
        Else
            MsgBox("Jenis Transaksi atau Karyawan Belum Dipilih !")
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailBiayaLain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub dtpTanggalTransaksi_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpTanggalTransaksi.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbJenis.Focus()
        End If
    End Sub

    Private Sub cmbJenis_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbJenis.KeyUp
        If e.KeyCode = Keys.Enter Then
            numBiaya.Focus()
        End If
    End Sub

    Private Sub numHarga_KeyUp(sender As Object, e As KeyEventArgs) Handles numBiaya.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbKaryawan.Focus()
        End If
    End Sub

    Private Sub cmbSopir_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbKaryawan.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtKeterangan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = False
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub removeDingSound_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpTanggalTransaksi.KeyDown, cmbJenis.KeyDown, numBiaya.KeyDown, cmbKaryawan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cmbJenis_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbJenis.Validating
        If cmbJenis.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub



    Private Sub cmbSopir_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbKaryawan.Validating
        If cmbJenis.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtKodeTrans_KeyUp(sender As Object, e As KeyEventArgs) Handles txtKodeTrans.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpTanggalTransaksi.Focus()
        End If
    End Sub

    Private Sub frmDetailBiayaLain_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'jun 18 oktober 2014
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class