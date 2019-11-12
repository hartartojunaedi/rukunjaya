Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailJenisMaintance
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim cekHolding As Boolean = True
    Dim cekProsentase As Boolean = True
    'jun 27 desember 2014
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeJenisMaintance.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Jenis Maintance Harus Diisi")
        End If
        'jun 13 feb 2015
        If cbkRutin.Checked Then
            If cbJenis.SelectedIndex < 0 Then
                flag = False
                _rjcommon.shownotifyerror("Jenis Maintance Harus Dipilih")
            End If
        End If
        Return flag
    End Function
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub frmDetailJenisMaintance_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If frmMasterJenisMaintance.mode = 0 Then
            txtKodeJenisMaintance.Enabled = True
            cbkRutin.Checked = False
            cbJenis.Enabled = False
            nmJumlah.Enabled = False
            txtKodeJenisMaintance.Focus()
        Else
            txtKodeJenisMaintance.Enabled = False
        End If
    End Sub

    Private Sub frmDetailJenisMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMasterJenisMaintance.kode <> "" Then
            If conn.State <> ConnectionState.Open Then
                conn.open
            End If
            Dim ds = New DataSet
            adapter("select * from tJenisMaintance where kodejenismaintance = '" & frmMasterJenisMaintance.kode & "'").Fill(ds, "tJenisMaintance")
            txtKodeJenisMaintance.Text = ds.Tables("tJenisMaintance").Rows(0).Item(0).ToString
            txtNamaPekerjaan.Text = ds.Tables("tJenisMaintance").Rows(0).Item(1).ToString
            txtKeterangan.Text = ds.Tables("tJenisMaintance").Rows(0).Item("keterangan").ToString
            cbkRutin.Checked = ds.Tables("tJenisMaintance").Rows(0).Item("rutin").ToString
            cbJenis.SelectedIndex = ds.Tables("tjenisMaintance").Rows(0).Item("jenis")
            nmJumlah.Value = ds.Tables("tjenismaintance").Rows(0).Item("jumlah")
            conn.Close()
            If cbkRutin.Checked Then
                cbJenis.Enabled = True
                nmJumlah.Enabled = True
            Else
                cbJenis.Enabled = False
                nmJumlah.Enabled = False
            End If
        Else
            txtKodeJenisMaintance.Clear()
            txtNamaPekerjaan.Clear()
            txtKeterangan.Clear()
            cbkRutin.Checked = False
            nmJumlah.Value = 1
            conn.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If frmMasterJenisMaintance.mode = 0 Then
                If ConnectionState.Open = True Then
                    conn.Close()
                Else
                    conn.Open()
                End If
                Try
                    'Dim cmd = New SqlCommand("insert into tJenisMaintance values(@a,@b,@c,@d,@f,@g)", conn)
                    'jun 17 oktober 2014
                    Dim cmd = New SqlCommand("insert into tJenisMaintance (kodejenismaintance,namapekerjaan,rutin,keterangan,jenis,jumlah)values(@kodejenismaintance,@namapekerjaan,@rutin,@keterangan,@jenis,@jumlah)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@kodejenismaintance", txtKodeJenisMaintance.Text)
                    cmd.Parameters.AddWithValue("@namapekerjaan", txtNamaPekerjaan.Text)
                    cmd.Parameters.AddWithValue("@rutin", cbkRutin.Checked)
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                    cmd.Parameters.AddWithValue("@jenis", cbJenis.SelectedIndex)
                    cmd.Parameters.AddWithValue("@jumlah", nmJumlah.Value)
                    'cmd.Parameters.AddWithValue("@f", Now)
                    'cmd.Parameters.AddWithValue("@g", Now)
                    cmd.ExecuteNonQuery()
                    _rjcommon.shownotify("Jenis Maintance berhasil ditambahkan")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeJenisMaintance.Text, "Master Maintance", "Tambah Data", "")
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Jenis Maintance gagal ditambahakan")
                    MsgBox("Jenis Maintance gagal ditambahakan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeJenisMaintance.Text, "Master Maintance", "Tambah Data", ex.Message)
                End Try
                conn.Close()
                Me.Close()
            Else
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If
                Try
                    Dim cmd = New SqlCommand("update tJenisMaintance set namapekerjaan = '" & txtNamaPekerjaan.Text & "', keterangan = '" & txtKeterangan.Text & "', rutin = '" & cbkRutin.Checked & "',jenis=" & cbJenis.SelectedIndex.ToString & ",jumlah=" & nmJumlah.Value.ToString & " where kodejenismaintance = '" & txtKodeJenisMaintance.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    _rjcommon.shownotify("Detail Jenis Maintance berhasil diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeJenisMaintance.Text, "Master Maintance", "Update Data", "")
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Jenis Maintance gagal diubah")
                    MsgBox("Jenis Maintance gagal diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeJenisMaintance.Text, "Master Maintance", "Update Data", ex.Message)
                End Try
                conn.Close()
                Me.Close()
            End If
        Else
            MsgBox("Ada Isian Yang Salah ")
        End If
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailJenisMaintance_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub lblKodeJenisMaintance_Click(sender As System.Object, e As System.EventArgs) Handles lblKodeJenisMaintance.Click

    End Sub

    Private Sub cbkRutin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbkRutin.CheckedChanged
        If cbkRutin.Checked Then
            cbJenis.Enabled = True
            nmJumlah.Enabled = True
        Else
            cbJenis.Enabled = False
            nmJumlah.Enabled = False
        End If
    End Sub
End Class