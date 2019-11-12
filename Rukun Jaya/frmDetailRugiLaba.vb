Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailRugiLaba
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim totalkredit As Double = 0
    Dim totaldebet As Double = 0
    Public tglawal, tglakhir As Date
    Public perusahaan As String
    Dim dt As DataTable
    Private Function createtable() As DataTable
        Dim dt As New DataTable
        dt.TableName = "Pemasukan"
        dt.Columns.Add(New DataColumn("Tanggal", GetType(System.DateTime)))
        dt.Columns.Add(New DataColumn("Jenis", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Perusahaan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Ref", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Keterangan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("debet", GetType(System.Double)))
        dt.Columns.Add(New DataColumn("kredit", GetType(System.Double)))
        Return dt
    End Function

    Private Function loaddata() As DataTable
        Dim dt As DataTable = createtable()
        Try
            Dim a As New frmDetailPengeluaran
            a.tglawal = tglawal
            a.tglakhir = tglakhir
            a.perusahaan = perusahaan
            dt.Merge(a.loaddata)
            Dim b As New frmDetailPemasukan
            b.tglawal = tglawal
            b.tglakhir = tglakhir
            b.perusahaan = perusahaan
            dt.Merge(b.loaddata())
            For i = 0 To dt.Rows.Count - 1

                If IsDBNull(dt.Rows(i).Item("debet")) = False Then
                    totaldebet += dt.Rows(i).Item("debet")
                End If
                If IsDBNull(dt.Rows(i).Item("kredit")) = False Then
                    totalkredit += dt.Rows(i).Item("kredit")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        Return dt
    End Function
    Private Sub frmDetailRugiLaba_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Periode : " + tglawal.ToString("dd-MM-yyyy") + " s/d " + tglakhir.ToString("dd-MM-yyyy")
        Label2.Text = "Perusahaan : " + perusahaan
        dt = loaddata()
        lblkredit.Text = FormatNumber(totalkredit, 2, , , TriState.True)
        lbldebet.Text = FormatNumber(totaldebet, 2, , , TriState.True)
        lblprofit.Text = FormatNumber(totalkredit - totaldebet, 2, , , TriState.True)
        DataGridView1.AutoGenerateColumns = False
        Dim v As DataView = dt.DefaultView
        v.Sort = "tanggal"
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = v
        DataGridView1.Refresh()
    End Sub
End Class