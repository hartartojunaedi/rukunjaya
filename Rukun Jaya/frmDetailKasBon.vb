Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailKasBon
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    Public insert As Boolean = True
    Public kodeTransaksi As String = ""
    'jun 26 desember 2014
    Private Function ceksimpan() As String
        Dim flag As Boolean = True
        If Trim(txtKodeTrans.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Transaksi Harus Diisi ")
        End If
        If cmbJenis.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Jenis Biaya Harus Diisi !")
            flag = False
        End If
        If cmbKaryawan.SelectedIndex = 0 Then
            _rjcommon.shownotifyerror("Sopir Harus Diisi !")
            flag = False
        End If
        Return flag
    End Function

    Private Function getKodeTransaksi() As String
        getKodeTransaksi = txtKodeTrans.Text
        Return getKodeTransaksi
    End Function

    Private Sub init()
        'init form
        'jun
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
            End If
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmDetailKasBon_Load", "frmDetailKasBon", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub loadDetail()
        cmd.CommandText = "SELECT op.tgltransaksi, ISNULL(op.jenis, '') as jenis, op.harga, op.keterangan, ISNULL(op.kode,'') as sopir FROM tOperational op"
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
        End If
        reader.Close()
    End Sub

    Private Sub initCmbJenis()
        cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational WHERE jenis=1"
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
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir WHERE status=0"
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
        dr.Item("namasopir") = "-- Pilih Sopir --"
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
            cmd.CommandText = "insert into tOperational(kodetransaksi, tgltransaksi, jenis, harga, keterangan, kode) values(@kodetransaksi, @tgltransaksi, @jenis, @harga, @keterangan, @kode)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodeTransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbJenis.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@jenis", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@jenis", cmbJenis.SelectedValue))
            End If
            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            If cmbKaryawan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kode", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
            End If
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Kas Bon", "Tambah data", "")
            _rjcommon.shownotify("Detail kas bon berhasil ditambahkan")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Kas Bon", "Tambah data", ex.Message)
            _rjcommon.shownotifyerror("Detail kas bon gagal ditambahkan")
        End Try
    End Sub

    Private Sub doUpdate()
        Try
            cmd.CommandText = "update tOperational set tgltransaksi=@tgltransaksi, jenis=@jenis, harga=@harga, keterangan=@keterangan, kode=@kode WHERE kodetransaksi=@kodetransaksi"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodetransaksi))
            cmd.Parameters.Add(New SqlParameter("@tgltransaksi", dtpTanggalTransaksi.Value))
            If cmbJenis.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@jenis", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@jenis", cmbJenis.SelectedValue))
            End If
            cmd.Parameters.Add(New SqlParameter("@harga", numBiaya.Value))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            If cmbKaryawan.SelectedValue = "" Then
                cmd.Parameters.Add(New SqlParameter("@kode", DBNull.Value))
            Else
                cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
            End If
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, kodeTransaksi, "Transaksi Kas Bon", "Update Data", "")
            _rjcommon.shownotify("Detail kas bon berhasil diubah")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, kodeTransaksi, "Transaksi Kas Bon", "Ubah data", ex.Message)
            _rjcommon.shownotifyerror("Detail kas bon gagal diubah")
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
            MsgBox("Ada Isian Yang Salah ")
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

End Class