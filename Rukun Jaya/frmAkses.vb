Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmAkses
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True

    Private Sub loadusername()
        Dim cmd As New SqlCommand
        Dim query As String = ""
        query = "select username,namauser from tlogin where username<>'admin' and akses<>0 order by namauser "
        cmd.Connection = conn
        cmd.CommandText = query
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "login")
        cbUsername.DataSource = ds.Tables("login")
        cbUsername.DisplayMember = "namauser"
        cbUsername.ValueMember = "username"
        cbUsername.Refresh()
        If ds.Tables("login").Rows.Count > 0 Then
            cbUsername.SelectedIndex = 0
        Else
            cbUsername.SelectedIndex = -1
        End If
        init = False
        pindah()
    End Sub

    Sub pindah()
        Try

        Dim cmd As New SqlCommand
        Dim query As String = ""
        query = "select id,jenis,title  from tmenu order by id "
        cmd.Connection = conn
        cmd.CommandText = query
        CheckedListBox1.Items.Clear()
        ListBox1.Items.Clear()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                ListBox1.Items.Add(dr.Item("id"))
                CheckedListBox1.Items.Add(dr.Item("jenis") + "/" + dr.Item("title"))
            End While
            End If
            dr.Close()
            conn.Close()
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
        Dim cmd1 As New SqlCommand
        Dim query1 As String = "select id from tmenulogin where username=@username"
        cmd1.Connection = conn
        cmd1.CommandText = query1
        cmd1.Parameters.AddWithValue("@username", cbUsername.SelectedValue)
        Dim dr1 As SqlDataReader = cmd1.ExecuteReader()
        If dr1.HasRows Then
            While dr1.Read
                CheckedListBox1.SetItemChecked(dr1.Item("id"), True)
            End While
        End If
        conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub awal()
        loadusername()
        init = False
    End Sub
    Private Sub frmAkses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init = True
        awal()
        init = False
    End Sub

    Private Sub cbUsername_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbUsername.SelectedIndexChanged
        If init = False Then
            pindah()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As New SqlCommand
        Dim query As String = "delete tmenulogin where username=@username"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@username", cbUsername.SelectedValue)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Try
            cmd.ExecuteNonQuery()
            Dim cmd1 As New SqlCommand
            Dim query1 As String = "insert into tmenulogin(username,id) values (@username,@id)"
            cmd1.Connection = conn
            cmd1.CommandText = query1
            cmd1.Parameters.AddWithValue("@username", cbUsername.SelectedValue)
            Dim param1 As New SqlParameter
            param1.ParameterName = "@id"
            cmd1.Parameters.Add(param1)
            Dim i As Integer
            For i = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemCheckState(i) = CheckState.Checked Then
                    param1.Value = i
                    cmd1.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception

        End Try
        conn.Close()
        Close()
    End Sub
End Class