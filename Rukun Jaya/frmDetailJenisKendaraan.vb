Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailJenisKendaraan
    Dim index As Integer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    'jun 15 jan 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeJenisKendaraan.Text) = "" Then
            _rjcommon.shownotifyerror("Kode Jenis Kendaraan Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtNamaJenisKendaraan.Text) = "" Then
            _rjcommon.shownotifyerror("Nama Jenis Kendaraan Tidak Boleh Kosong !")
            flag = False
        End If
        Return flag
    End Function
    Private Sub frmDetailJenisKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        index = frmMasterJenisKendaraan.index
        init()
    End Sub

    Private Sub init()
        Try
            con = New SqlConnection
            con.ConnectionString = _rjcommon.getconnstr()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            txtKodeJenisKendaraan.Text = ""
            txtKodeJenisKendaraan.Enabled = True
            txtNamaJenisKendaraan.Text = ""
            txtKeterangan.Text = ""
            If frmMasterJenisKendaraan.updating Then
                txtKodeJenisKendaraan.Enabled = False
                txtNamaJenisKendaraan.SelectAll()
                filldata()
            Else
                txtKodeJenisKendaraan.Select()
            End If
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmMasterJenisKendaraan_Load", "frmMasterJenisKendaraan", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub filldata()
        txtKodeJenisKendaraan.Text = frmMasterJenisKendaraan.dgvMasterJenisKendaraan.Rows(index).Cells(0).Value
        txtNamaJenisKendaraan.Text = frmMasterJenisKendaraan.dgvMasterJenisKendaraan.Rows(index).Cells(1).Value
        txtKeterangan.Text = frmMasterJenisKendaraan.dgvMasterJenisKendaraan.Rows(index).Cells(2).Value
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If frmMasterJenisKendaraan.updating = False Then
                inserts()
            Else
                updates()
            End If
            frmMasterJenisKendaraan.updating = False
        Else
            MsgBox("Ada Isian Yang Kurang !")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        frmMasterJenisKendaraan.updating = False
        Me.Close()
    End Sub

    Private Sub inserts()
        Try
            'jun
            '            cmd = New SqlCommand("insert into tJenisKendaraan values(@kodejenis,@namajenis,@keterangan,'','')")
            cmd = New SqlCommand("insert into tJenisKendaraan(kodejenis,namajenis,keterangan) values (@kodejenis,@namajenis,@keterangan)")
            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodejenis", txtKodeJenisKendaraan.Text))
            cmd.Parameters.Add(New SqlParameter("@namajenis", txtNamaJenisKendaraan.Text))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, txtKodeJenisKendaraan.Text, "Master Jenis Kendaraan", "Tambah Data", "")
            _rjcommon.shownotify("Jenis Kendaraan berhasil ditambahkan")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeJenisKendaraan.Text, "Master Jenis Kendaraan", "Tambah Data", ex.Message)
            _rjcommon.shownotifyerror("Jenis Kendaraan gagal ditambahkan")
        End Try
    End Sub

    Private Sub updates()
        Try
            cmd = New SqlCommand("update tJenisKendaraan set namajenis = @namajenis, keterangan = @keterangan where kodejenis=@kodejenis")
            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlParameter("@kodejenis", txtKodeJenisKendaraan.Text))
            cmd.Parameters.Add(New SqlParameter("@namajenis", txtNamaJenisKendaraan.Text))
            cmd.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, txtKodeJenisKendaraan.Text, "Master Jenis Kendaraan", "Update Data", "")
            _rjcommon.shownotify("Jenis Kendaraan berhasil diubah")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeJenisKendaraan.Text, "Master Jenis Kendaraan", "Updates Data", ex.Message)
            _rjcommon.shownotifyerror("Jenis Kendaraan gagal diubah")
        End Try
    End Sub

    Private Sub txtKodeJenisKendaraan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKodeJenisKendaraan.KeyPress
        If ChrW(13) = e.KeyChar Then
            If Not txtNamaJenisKendaraan.Text = Nothing Then
                txtNamaJenisKendaraan.SelectAll()
            Else
                txtNamaJenisKendaraan.Select()
            End If
        End If
    End Sub

    Private Sub txtNamaJenisKendaraan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaJenisKendaraan.KeyPress
        If ChrW(13) = e.KeyChar Then
            If Not txtKeterangan.Text = Nothing Then
                txtKeterangan.SelectAll()
            Else
                txtKeterangan.Select()
            End If
        End If
    End Sub

    Private Sub frmDetailJenisKendaraan_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'jun
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class