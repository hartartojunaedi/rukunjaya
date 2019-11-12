Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDetailPerwakilan
    'Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & CurDir() & "\dbrk.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    'sambung server
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr)
    Dim comm As New SqlCommand("", conn)
    Dim dts As New DataSet
    Dim bld As New SqlCommandBuilder
    Dim adp As New SqlDataAdapter
    Dim indexedit As Integer
    'jun 2 januari 2015
    Public edit As Boolean
    Public kodeper As String
    'jun
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKode.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Perwakilan Harus Diisi !")
        End If
        If Trim(txtNama.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama Perwakilan Harus Diisi !")
        End If
        Return flag
    End Function
    Private Sub frmEditPerwakilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comm.CommandText = "select * from tperwakilan"
        adp.SelectCommand = comm
        adp.Fill(dts)
        bld = New SqlCommandBuilder(adp)

        'If frmMasterPerwakilan.edit = False Then
        If edit = False Then
            lblMode.Text = "Mode : Tambah"
            'jun 19 jan 2015
            txtKode.Enabled = True
            txtKode.Clear()
            txtNama.Clear()
            txtPengurus.Clear()
            txtAlamat.Clear()
            txtKota.Clear()
            txtTelp.Clear()
            txtHp.Clear()
            txtKeterangan.Clear()
            txtKode.Focus()
        Else
            lblMode.Text = "Mode : Edit"
            indexedit = cariindex(kodeper)
            txtKode.Text = dts.Tables(0).Rows(indexedit).Item(0).ToString
            txtNama.Text = dts.Tables(0).Rows(indexedit).Item(1).ToString
            txtPengurus.Text = dts.Tables(0).Rows(indexedit).Item(2).ToString
            txtAlamat.Text = dts.Tables(0).Rows(indexedit).Item(3).ToString
            txtKota.Text = dts.Tables(0).Rows(indexedit).Item(4).ToString
            txtTelp.Text = dts.Tables(0).Rows(indexedit).Item(5).ToString
            txtHp.Text = dts.Tables(0).Rows(indexedit).Item(6).ToString
            txtKeterangan.Text = dts.Tables(0).Rows(indexedit).Item(7).ToString
            txtKode.Enabled = False
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() then
            If edit = False Then
                Try
                    Dim roww As DataRow
                    roww = dts.Tables(0).NewRow
                    roww(0) = txtKode.Text
                    roww(1) = txtNama.Text
                    roww(2) = txtPengurus.Text
                    roww(3) = txtAlamat.Text
                    roww(4) = txtKota.Text
                    roww(5) = txtTelp.Text
                    roww(6) = txtHp.Text
                    roww(7) = txtKeterangan.Text
                    roww(8) = DateAndTime.Now
                    dts.Tables(0).Rows.Add(roww)
                    adp.Update(dts.Tables(0))
                    'MsgBox("Data Berhasil Disimpan")
                    _rjcommon.shownotify("Data Berhasil Disimpan")
                    _rjcommon.isilog(_rjcommon.getusername, txtKode.Text, "Master Perwakilan", "Tambah Data", "")

                    frmMasterPerwakilan.refreshgrid()

                Catch ex As Exception
                    'jun 17 oktober 2014
                    MsgBox("Data Tidak Berhasil Ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKode.Text, "Master Perwakilan", "Tambah Data", ex.Message)
                End Try
                txtKode.Clear()
                txtNama.Clear()
                txtPengurus.Clear()
                txtAlamat.Clear()
                txtKota.Clear()
                txtTelp.Clear()
                txtHp.Clear()
                txtKeterangan.Clear()
                Me.Close()
            Else
                Try
                    dts.Tables(0).Rows(indexedit).Item(1) = txtNama.Text
                    dts.Tables(0).Rows(indexedit).Item(2) = txtPengurus.Text
                    dts.Tables(0).Rows(indexedit).Item(3) = txtAlamat.Text
                    dts.Tables(0).Rows(indexedit).Item(4) = txtKota.Text
                    dts.Tables(0).Rows(indexedit).Item(5) = txtTelp.Text
                    dts.Tables(0).Rows(indexedit).Item(6) = txtHp.Text
                    dts.Tables(0).Rows(indexedit).Item(7) = txtKeterangan.Text
                    dts.Tables(0).Rows(indexedit).Item(9) = DateAndTime.Now
                    adp.Update(dts.Tables(0))
                    'MsgBox("Data Berhasil Diubah")
                    _rjcommon.shownotify("Data Berhasil Diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtKode.Text, "Master Perwakilan", "Update Data", "")
                    Me.Close()
                    'frmMasterPerwakilan.refreshgrid()
                Catch ex As Exception
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKode.Text, "Master Perwakilan", "Update Data", ex.Message)
                End Try
            End If
        Else
            MsgBox("Ada Isian Yang Salah !")
        End If
    End Sub

    Private Sub frmEditPerwakilan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMasterPerwakilan.edit = False
    End Sub

    Private Sub frmEditPerwakilan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Function cariindex(ByVal kode)
        Dim ind As Int16
        For i = 0 To dts.Tables(0).Rows.Count - 1
            If dts.Tables(0).Rows(i).Item(0) = kode Then
                ind = i
            End If
        Next
        Return ind
    End Function
End Class