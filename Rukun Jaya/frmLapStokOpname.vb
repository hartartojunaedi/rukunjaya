Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary


Public Class frmLapStokOpname
    Dim _rjcommon As New RJCommon
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim rj As New RJCommon
        Dim cn As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim adap1 As New SqlDataAdapter
        Try
            cn = New SqlConnection
            cn.ConnectionString = rj.getconnstr
            cmd1.Connection = cn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "select kodesparepart,namasparepart,hargaterakhir,stock from tSparePart"
       

            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "StokOpname")
            cn.Close()


            'jun 13 feb 2015
            If ds.Tables("StokOpname").Rows.Count > 0 Then
                Dim rep As New LapStokOpname
                rep.SetDataSource(ds.Tables("StokOpname"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep
                frmlaporan.CrystalReportViewer1.RefreshReport()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
        frmlaporan.ShowDialog()
    End Sub
End Class