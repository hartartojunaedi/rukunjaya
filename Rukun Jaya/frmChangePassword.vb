Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmChangePassword
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Dim query As String
        Dim command As New SqlCommand
       
        query = "update tlogin set password=@password where username=@username"
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@username", lblusername.Text))
        command.Parameters.Add(New SqlParameter("@password", _rjcommon.enkripsi(txtPassword.Text)))
        conn.Open()
        Try
            command.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, lblusername.Text, "Create User", "Update Data", "")
            _rjcommon.shownotify("Data Berhasil Ditambah")
        Catch ex As Exception
            MsgBox("Data Tidak Dapat Disimpan", MsgBoxStyle.OkOnly, "Information")
            _rjcommon.isiErrorlog(_rjcommon.getusername, lblusername.Text, "Create User", "Update Data", ex.Message)
        End Try
        conn.Close()
        Close()
    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblusername.Text = _rjcommon.getusername()
    End Sub
End Class