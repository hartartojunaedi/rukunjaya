Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailMasterOperational
    Dim rj As New RJCommon
    Dim conn As New SqlConnection
    'jun 26 desember 2014
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeJenisOperational.Text) = "" Then
            rj.shownotifyerror("Kode operasional harus diisi !")
            flag = False
        End If
        Return flag
    End Function
    Private Sub Clear()
        txtKodeJenisOperational.Text = ""
        txtNamaJenisOperational.Text = ""
        txtKetOperational.Text = ""
        cmbJenisOperational.SelectedIndex = 0
    End Sub

    Private Sub frmDetailMasterOperational_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection
        conn.ConnectionString = rj.getconnstr
    End Sub

    Private Sub btnSimpanOperational_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanOperational.Click
        If ceksimpan() Then
            Try
                Dim tempKode As String = txtKodeJenisOperational.Text

                If tempKode <> "" Then
                    conn.Open()
                    Dim cmd As SqlCommand = New SqlCommand
                    cmd.Connection = conn

                    If lblMode.Text.ToLower = "tambah" Then
                        'jun 18 oktober 2014
                        cmd.CommandText = "INSERT INTO tJenisOperational (kodejenis,namajenis,keterangan,jenis) "
                        cmd.CommandText += "VALUES (@KODE,@NAMA,@KET,@JENIS)"
                        cmd.Parameters.AddWithValue("@KODE", tempKode)
                        cmd.Parameters.AddWithValue("@NAMA", txtNamaJenisOperational.Text)
                        cmd.Parameters.AddWithValue("@KET", txtKetOperational.Text)
                        cmd.Parameters.AddWithValue("@JENIS", cmbJenisOperational.SelectedIndex)
                        cmd.ExecuteNonQuery()

                        rj.isilog(rj.getusername, tempKode, "Master Operasional", "Tambah Data", "")
                    ElseIf lblMode.Text.ToLower = "ubah" Then
                        cmd.CommandText = "UPDATE tJenisOperational SET namajenis=@NAMA, keterangan=@KET, "
                        cmd.CommandText += "jenis=@JENIS WHERE kodejenis=@KODE"
                        cmd.Parameters.AddWithValue("@KODE", tempKode)
                        cmd.Parameters.AddWithValue("@NAMA", txtNamaJenisOperational.Text)
                        cmd.Parameters.AddWithValue("@KET", txtKetOperational.Text)
                        cmd.Parameters.AddWithValue("@JENIS", cmbJenisOperational.SelectedIndex)
                        cmd.ExecuteNonQuery()

                        rj.isilog(rj.getusername, tempKode, "Master Operasional", "Update Data", "")
                    End If

                    rj.shownotify("Data Master Operasional Berhasil Disimpan")
                    Clear()
                    conn.Close()
                    Me.Close()
                Else
                    rj.shownotifyerror("Kode Jenis Wajib Diisi!")
                    txtKodeJenisOperational.Focus()
                End If
            Catch ex As Exception
                rj.shownotifyerror("Data Gagal Disimpan")
                rj.isiErrorlog(rj.getusername, txtKodeJenisOperational.Text, "Master Operational", "Update Data", ex.Message)
                conn.Close()
            End Try
        Else
            MsgBox("Isian Kurang Tepat")
        End If
    End Sub

    Private Sub btnBatalOperational_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalOperational.Click
        Clear()
        Me.Close()
    End Sub

    Private Sub frmDetailMasterOperational_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Clear()
        frmMasterOperational.RefreshDataset()
    End Sub

    Private Sub frmDetailMasterOperational_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class