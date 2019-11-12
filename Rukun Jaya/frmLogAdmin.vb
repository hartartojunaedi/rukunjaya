Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmLogAdmin
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public Sub loaduser()
        Dim sql As String = "Select namauser,username from tlogin order by namauser"
        Dim command As New SqlCommand(sql, conn)
        Dim ds As New DataSet

        Dim da As New SqlDataAdapter(command)
        da.Fill(ds, "user")
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "namauser"
        ComboBox1.ValueMember = "username"
        ComboBox1.Refresh()
    End Sub
    Public Sub loaddata()
        Dim username As String = ComboBox1.SelectedValue
        Dim command As New SqlCommand
        Dim da As New SqlDataAdapter
        command.CommandText = "select top 20 ip,datelogin,namacomputer,datelogout,convert(varchar, datelogout-datelogin, 8) as detik from tloglogin where username=@username order by datelogin desc"
        Command.CommandType = CommandType.Text
        command.Connection = conn
        Dim param As New SqlParameter
        param.ParameterName = "@username"
        param.Value = username
        command.Parameters.Add(param)
        da.SelectCommand = command
        ds.Clear()
        da.Fill(ds, "log")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "log"
        DataGridView1.Refresh()
        ' Label1.Text = "Jumlah Data : " + ds.Tables("gudang").Rows.Count.ToString
    End Sub
    Private Sub frmLogAdmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaduser()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        loaddata()
    End Sub
End Class