Imports RjLibrary
Imports System.Data.SqlClient

Public Class frmBackup
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public Sub backup(path As String)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = " DECLARE @name VARCHAR(50) -- database name " & vbCrLf
        query &= " DECLARE @path VARCHAR(256) -- path for backup files " + vbCrLf
        query &= " DECLARE @fileName VARCHAR(256) -- filename for backup " + vbCrLf
        query &= " DECLARE @fileDate VARCHAR(20) -- used for file name " + vbCrLf
        query &= " SET @path = '" + path + "'" + vbCrLf
        query &= " SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112) " + vbCrLf
        query &= " DECLARE db_cursor CURSOR FOR " + vbCrLf
        query &= " SELECT name " + vbCrLf
        query &= " FROM master.dbo.sysdatabases " + vbCrLf
        query &= " WHERE name NOT IN ('master','model','msdb','tempdb')  and name='RukunJayaDb' " + vbCrLf
        query &= " OPEN db_cursor " + vbCrLf
        query &= " FETCH NEXT FROM db_cursor INTO @name " + vbCrLf
        query &= " WHILE @@FETCH_STATUS = 0 " + vbCrLf
        query &= " BEGIN" + vbCrLf
        query &= " SET @fileName = @path +'\'+ @name + '_' + @fileDate + '.BAK'" + vbCrLf
        query &= " BACKUP DATABASE @name TO DISK = @fileName" + vbCrLf
        query &= " FETCH NEXT FROM db_cursor INTO @name" + vbCrLf
        query &= " END " + vbCrLf
        query &= " CLOSE db_cursor" + vbCrLf
        query &= " DEALLOCATE db_cursor" + vbCrLf

        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = query
        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            _rjcommon.shownotify("Backup Database Sukses")
            _rjcommon.isilog(_rjcommon.getusername, "", "Backup Database", "", "")
            Me.Close()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "", "Backup Database", "", ex.Message)
            MsgBox("Database tidak bisa dibackup ! Contact Administrator ")
        End Try

    End Sub
    Private Sub frmBackup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        backup(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class