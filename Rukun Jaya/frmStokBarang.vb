Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary
Public Class frmStokBarang
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection

    Sub loaddata()
        Try
            conn.ConnectionString = _rjcommon.getconnstr
            Dim cmd1 As New SqlCommand
            cmd1.Connection = conn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "select kodesparepart,namasparepart,kartustok,keterangan,stock from tSparePart"
            cmd1.CommandText &= " where kodesparepart like '%" & txtkodesparepart.Text & "%'"
            cmd1.CommandText &= " and namasparepart like '%" & txtnamasparepart.Text & "%'"
            cmd1.CommandText &= " and kartustok like '%" & txtkartustok.Text & "%'"

            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet
            da.Fill(ds, "tsparepart")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "tsparepart"
            DataGridView1.Refresh()
            lbljumlahdata.Text = ds.Tables("tsparepart").Rows.Count
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmStokBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            conn.ConnectionString = _rjcommon.getconnstr
            Dim cmd1 As New SqlCommand
            cmd1.Connection = conn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "select kodesparepart,namasparepart,kartustok,keterangan,stock from tSparePart"
            cmd1.CommandText &= " where kodesparepart like '%" & txtkodesparepart.Text & "%'"
            cmd1.CommandText &= " and namasparepart like '%" & txtnamasparepart.Text & "%'"
            cmd1.CommandText &= " and kartustok like '%" & txtkartustok.Text & "%'"

            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet
            da.Fill(ds, "tsparepart")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "tsparepart"
            DataGridView1.Refresh()

            If ds.Tables("tsparepart").Rows.Count > 0 Then
                Dim rep As New lapStokBarang
                rep.SetDataSource(ds.Tables("tsparepart"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep
                frmlaporan.CrystalReportViewer1.RefreshReport()
                frmlaporan.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class