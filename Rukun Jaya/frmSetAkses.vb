Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmSetAkses
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True
    Private Function searchhak(username As String) As String
        Dim hak As String = ""
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "Select hak from tlogin where username=@username"
        cmd.Parameters.AddWithValue("@username", username)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        hak = cmd.ExecuteScalar()
        conn.Close()
        Return hak
    End Function
    Private Function ambil() As String
        Dim hak As String = ""
        Dim i As Integer
        For i = 0 To 256
            hak = hak + "0"
        Next
        'Mid(hak, 0, 1) = IIf(cb0.Checked, "1", "0")
        hak.Remove(0, 1).Insert(0, IIf(cb0.Checked, "1", "0"))
        Mid(hak, 1, 1) = IIf(cb1.Checked, "1", "0")
        Mid(hak, 2, 1) = IIf(cb2.Checked, "1", "0")
        Mid(hak, 3, 1) = IIf(cb3.Checked, "1", "0")
        Mid(hak, 4, 1) = IIf(cb4.Checked, "1", "0")
        Mid(hak, 5, 1) = IIf(cb5.Checked, "1", "0")
        Mid(hak, 6, 1) = IIf(cb6.Checked, "1", "0")
        Mid(hak, 7, 1) = IIf(cb7.Checked, "1", "0")
        Mid(hak, 8, 1) = IIf(cb8.Checked, "1", "0")
        Mid(hak, 9, 1) = IIf(cb9.Checked, "1", "0")
        Mid(hak, 10, 1) = IIf(cb10.Checked, "1", "0")
        Mid(hak, 11, 1) = IIf(cb11.Checked, "1", "0")
        Mid(hak, 12, 1) = IIf(cb12.Checked, "1", "0")
        Mid(hak, 13, 1) = IIf(cb13.Checked, "1", "0")
        Mid(hak, 20, 1) = IIf(cb20.Checked, "1", "0")
        Mid(hak, 30, 1) = IIf(cb30.Checked, "1", "0")
        Mid(hak, 31, 1) = IIf(cb31.Checked, "1", "0")
        Mid(hak, 32, 1) = IIf(cb32.Checked, "1", "0")
        Mid(hak, 33, 1) = IIf(cb33.Checked, "1", "0")
        Mid(hak, 40, 1) = IIf(cb40.Checked, "1", "0")
        Mid(hak, 41, 1) = IIf(cb41.Checked, "1", "0")
        Mid(hak, 42, 1) = IIf(cb42.Checked, "1", "0")
        Mid(hak, 43, 1) = IIf(cb43.Checked, "1", "0")
        Mid(hak, 50, 1) = IIf(cb50.Checked, "1", "0")
        Mid(hak, 51, 1) = IIf(cb51.Checked, "1", "0")
        Mid(hak, 52, 1) = IIf(cb52.Checked, "1", "0")
        Mid(hak, 53, 1) = IIf(cb53.Checked, "1", "0")
        Mid(hak, 54, 1) = IIf(cb54.Checked, "1", "0")
        Mid(hak, 55, 1) = IIf(cb55.Checked, "1", "0")
        Mid(hak, 56, 1) = IIf(cb56.Checked, "1", "0")
        Mid(hak, 60, 1) = IIf(cb60.Checked, "1", "0")
        Mid(hak, 61, 1) = IIf(cb61.Checked, "1", "0")
        Mid(hak, 62, 1) = IIf(cb62.Checked, "1", "0")
        Mid(hak, 63, 1) = IIf(cb63.Checked, "1", "0")
        Mid(hak, 70, 1) = IIf(cb70.Checked, "1", "0")
        Mid(hak, 71, 1) = IIf(cb71.Checked, "1", "0")
        Mid(hak, 72, 1) = IIf(cb72.Checked, "1", "0")
        Mid(hak, 100, 1) = IIf(cb100.Checked, "1", "0")
        Mid(hak, 110, 1) = IIf(cb110.Checked, "1", "0")
        Mid(hak, 111, 1) = IIf(cb111.Checked, "1", "0")
        Mid(hak, 112, 1) = IIf(cb112.Checked, "1", "0")
        Mid(hak, 113, 1) = IIf(cb113.Checked, "1", "0")
        Mid(hak, 114, 1) = IIf(cb113.Checked, "1", "0")
        Mid(hak, 120, 1) = IIf(cb120.Checked, "1", "0")
        Mid(hak, 121, 1) = IIf(cb121.Checked, "1", "0")
        Mid(hak, 122, 1) = IIf(cb122.Checked, "1", "0")
        Mid(hak, 123, 1) = IIf(cb123.Checked, "1", "0")
        Mid(hak, 124, 1) = IIf(cb124.Checked, "1", "0")
        Mid(hak, 125, 1) = IIf(cb125.Checked, "1", "0")
        Mid(hak, 126, 1) = IIf(cb126.Checked, "1", "0")
        Return hak
    End Function
    Private Sub pindah()
        Dim hak As String = searchhak(cbUsername.SelectedValue)
        cb0.Checked = IIf(hak.Substring(0, 1) = "1", True, False)
        cb1.Checked = IIf(hak.Substring(1, 1) = "1", True, False)
        cb2.Checked = IIf(hak.Substring(2, 1) = "1", True, False)
        cb3.Checked = IIf(hak.Substring(3, 1) = "1", True, False)
        cb4.Checked = IIf(hak.Substring(4, 1) = "1", True, False)
        cb5.Checked = IIf(hak.Substring(5, 1) = "1", True, False)
        cb6.Checked = IIf(hak.Substring(6, 1) = "1", True, False)
        cb7.Checked = IIf(hak.Substring(7, 1) = "1", True, False)
        cb8.Checked = IIf(hak.Substring(8, 1) = "1", True, False)
        cb9.Checked = IIf(hak.Substring(9, 1) = "1", True, False)
        cb10.Checked = IIf(hak.Substring(10, 1) = "1", True, False)
        cb11.Checked = IIf(hak.Substring(11, 1) = "1", True, False)
        cb12.Checked = IIf(hak.Substring(12, 1) = "1", True, False)
        cb13.Checked = IIf(hak.Substring(13, 1) = "1", True, False)

        cb20.Checked = IIf(hak.Substring(20, 1) = "1", True, False)
        cb30.Checked = IIf(hak.Substring(30, 1) = "1", True, False)
        cb31.Checked = IIf(hak.Substring(31, 1) = "1", True, False)
        cb32.Checked = IIf(hak.Substring(32, 1) = "1", True, False)
        cb33.Checked = IIf(hak.Substring(33, 1) = "1", True, False)
        cb40.Checked = IIf(hak.Substring(40, 1) = "1", True, False)
        cb41.Checked = IIf(hak.Substring(41, 1) = "1", True, False)
        cb42.Checked = IIf(hak.Substring(42, 1) = "1", True, False)
        cb43.Checked = IIf(hak.Substring(43, 1) = "1", True, False)
        cb50.Checked = IIf(hak.Substring(50, 1) = "1", True, False)
        cb51.Checked = IIf(hak.Substring(51, 1) = "1", True, False)
        cb52.Checked = IIf(hak.Substring(52, 1) = "1", True, False)
        cb53.Checked = IIf(hak.Substring(53, 1) = "1", True, False)
        cb54.Checked = IIf(hak.Substring(54, 1) = "1", True, False)
        cb55.Checked = IIf(hak.Substring(55, 1) = "1", True, False)
        cb56.Checked = IIf(hak.Substring(56, 1) = "1", True, False)
        cb60.Checked = IIf(hak.Substring(60, 1) = "1", True, False)
        cb61.Checked = IIf(hak.Substring(61, 1) = "1", True, False)
        cb62.Checked = IIf(hak.Substring(62, 1) = "1", True, False)
        cb63.Checked = IIf(hak.Substring(63, 1) = "1", True, False)
        cb70.Checked = IIf(hak.Substring(70, 1) = "1", True, False)
        cb71.Checked = IIf(hak.Substring(71, 1) = "1", True, False)
        cb72.Checked = IIf(hak.Substring(72, 1) = "1", True, False)

        cb100.Checked = IIf(hak.Substring(100, 1) = "1", True, False)
        cb110.Checked = IIf(hak.Substring(110, 1) = "1", True, False)
        cb111.Checked = IIf(hak.Substring(111, 1) = "1", True, False)
        cb112.Checked = IIf(hak.Substring(112, 1) = "1", True, False)
        cb113.Checked = IIf(hak.Substring(113, 1) = "1", True, False)
        cb114.Checked = IIf(hak.Substring(114, 1) = "1", True, False)
        cb120.Checked = IIf(hak.Substring(120, 1) = "1", True, False)
        cb121.Checked = IIf(hak.Substring(121, 1) = "1", True, False)
        cb122.Checked = IIf(hak.Substring(122, 1) = "1", True, False)
        cb123.Checked = IIf(hak.Substring(123, 1) = "1", True, False)
        cb124.Checked = IIf(hak.Substring(124, 1) = "1", True, False)
        cb125.Checked = IIf(hak.Substring(125, 1) = "1", True, False)
        cb126.Checked = IIf(hak.Substring(126, 1) = "1", True, False)

    End Sub
    Private Sub loadusername()
        Dim cmd As New SqlCommand
        Dim query As String = ""
        query = "select username,namauser from tlogin where username<>'admin' order by namauser "
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
    Private Sub awal()
        loadusername()
        init = False
    End Sub
    Private Sub frmSetAkses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Dim hak As String = ambil()
        Dim query As String = ""
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        query = "update tlogin set hak=@hak where username=@username"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@hak", hak)
        cmd.Parameters.AddWithValue("@username", cbUsername.SelectedValue)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Try
            cmd.ExecuteNonQuery()
            _rjcommon.shownotify("Hak Akses Berhasil Diubah")
            _rjcommon.isilog(_rjcommon.getusername, cbUsername.SelectedValue, "Set Hak Akses", "Update Data", " ")

        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, cbUsername.SelectedValue, "Set Hak Akses", "Update Data", ex.Message)

        End Try
      
        conn.Close()
        Close()
    End Sub

    Private Function cekmaster() As Boolean
        Dim flag As Boolean = False
        If cb1.Checked Then flag = True
        If cb2.Checked Then flag = True
        If cb3.Checked Then flag = True
        If cb4.Checked Then flag = True
        If cb5.Checked Then flag = True
        If cb6.Checked Then flag = True
        If cb7.Checked Then flag = True
        If cb8.Checked Then flag = True
        If cb9.Checked Then flag = True
        If cb10.Checked Then flag = True
        If cb11.Checked Then flag = True
        If cb12.Checked Then flag = True
        If cb13.Checked Then flag = True
        Return flag
    End Function
    Private Sub cb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb1.CheckedChanged, cb9.CheckedChanged, cb8.CheckedChanged, cb7.CheckedChanged, cb6.CheckedChanged, cb5.CheckedChanged, cb4.CheckedChanged, cb3.CheckedChanged, cb2.CheckedChanged, cb13.CheckedChanged, cb12.CheckedChanged, cb11.CheckedChanged, cb10.CheckedChanged
        cb0.Checked = cekmaster()
    End Sub
End Class