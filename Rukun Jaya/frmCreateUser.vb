Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmCreateUser
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    'jun 03 feb 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtusername.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Username Harus Diisi ")
        End If
        If Trim(txtNamaUser.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama User Harus Diisi ")
        End If
        If Trim(txtPassword.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Password Harus Diisi ")
        End If
        Return flag
    End Function
    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            Dim query As String
            Dim command As New SqlCommand
            Dim temp As String = ""
            For i As Integer = 1 To 500
                'jun 13 feb 2015
                If cbLevel.SelectedIndex = 0 Then
                    temp &= "1"
                Else
                    temp &= "0"
                End If
            Next

            query = "insert into tlogin(username,password,namauser,akses,hak) values (@username,@password,@namauser,@akses,@hak)"
            command.Connection = conn
            command.CommandType = CommandType.Text
            command.CommandText = query
            command.Parameters.Add(New SqlParameter("@username", txtusername.Text))
            command.Parameters.Add(New SqlParameter("@password", _rjcommon.enkripsi(txtPassword.Text)))
            command.Parameters.Add(New SqlParameter("@namauser", txtNamaUser.Text))
            'TODO : hak akses belum dipersiapkan
            command.Parameters.Add(New SqlParameter("@akses", cbLevel.SelectedIndex))
            command.Parameters.Add(New SqlParameter("@hak", temp))
            conn.Open()
            Try
                command.ExecuteNonQuery()
                _rjcommon.isilog(_rjcommon.getusername, txtusername.Text, "Create User", "Tambah Data", "")
                _rjcommon.shownotify("Data Berhasil Ditambah")
            Catch ex As Exception
                MsgBox("Data Tidak Dapat Disimpan", MsgBoxStyle.OkOnly, "Information")
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtusername.Text, "Create User", "Tambah Data", ex.Message)
            End Try
            conn.Close()
            txtusername.Text = ""
            txtNamaUser.Text = ""
            txtPassword.Text = ""
            Close()
        Else
            MsgBox("Ada Isian Yang Kurang ")
        End If
    End Sub
End Class