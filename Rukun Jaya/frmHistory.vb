Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmHistory
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Public Sub loaddata()
        Dim ds As New DataSet
        Dim query As String
        Dim query1 As String = ""
        Dim flag As Boolean = False

        query = "select *,(case when tipeact=1 then 'Tambah' when tipeact=2 then 'Update' when tipeact=3 then 'Hapus' Else 'Other' end) as act from thistory "

        query1 &= " where tgl>=@tglawal"

        query1 &= " and tgl<=@tglakhir"
            
        If cbTransaksi.Text <> "All" Then
            query1 &= " and tipetrans='" & cbTransaksi.Text & "'"
        End If

        If cbTipe.Text <> "All" Then
            query1 &= " and tipeact=" & cbTipe.SelectedIndex
        End If
        query &= query1 + " order by tgl desc"
        'query &= " order by " + ViewState("sort")
        'MsgBox(query)
        Dim command As New SqlCommand
        command.Connection = conn
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@tglawal", dtTglAwal.Value))
        command.Parameters.Add(New SqlParameter("@tglakhir", dtTglAkhir.Value))
        Dim da As New SqlDataAdapter()
        da.SelectCommand = command
        da.Fill(ds, "history")
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "history"
        DataGridView1.Refresh()
    End Sub
    Private Sub frmHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtTglAwal.Value = New Date(Now.Year, Now.Month, Now.Day, 0, 0, 1)
        dtTglAkhir.Value = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        cbTransaksi.SelectedIndex = 0
        cbTipe.SelectedIndex = 0
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, dtTglAwal.ValueChanged, dtTglAkhir.ValueChanged, cbTransaksi.SelectedIndexChanged, cbTipe.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub dtTglAwal_ValueChanged(sender As System.Object, e As System.EventArgs)
    End Sub
End Class