Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class Form1
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public Sub loaddata()
       
        
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim da As New SqlDataAdapter("select * from tgudang where kotagudang='Bandung' order by kodegudang", conn)
        ds.Clear()
        da.Fill(ds, "gudang")
        Dim report As New CrystalReport1
        report.SetDataSource(ds.Tables("gudang"))
        'report.SetParameterValue("fromDate", dtpFromPeriode.Value.ToString("dd-MM-yyyy"))
        'report.SetParameterValue("toDate", dtpToPeriode.Value.ToString("dd-MM-yyyy"))
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()

    End Sub
End Class