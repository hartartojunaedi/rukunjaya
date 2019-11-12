Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmPrintOperasionalKendaraan
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As SqlDataAdapter
    Dim cmd As New SqlCommand("", conn)
    Private Sub frmPrintOperasionalKendaraan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpTanggalAwal.Value = Now
    End Sub

    Private Sub btnLaporan_Click(sender As System.Object, e As System.EventArgs) Handles btnLaporan.Click
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
       
        Dim query As String = "select k.nopol,s.namasopir,ok.keterangan,ok.harga,ok.tgltransaksi"
        query &= " from tOperationalKendaraan ok,tKendaraan k,tsopir s"
        query &= " where ok.nolambung=k.nolambung and ok.kodesopir=s.kodesopir "
        query &= "  and ok.tgltransaksi=@tgltransaksi "
        query &= " order by nopol"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@tgltransaksi", dtpTanggalAwal.Value.Date)

        da.SelectCommand = cmd
        Try
            da.Fill(ds, "operasionalkendaraan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If ds.Tables("operasionalkendaraan").Rows.Count > 0 Then
            Dim rep As New rptOperasionalKendaraan
            rep.SetDataSource(ds.Tables("operasionalkendaraan"))
            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
    End Sub
End Class