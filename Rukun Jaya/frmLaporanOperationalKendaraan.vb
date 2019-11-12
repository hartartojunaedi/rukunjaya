Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmLaporanOperationalKendaraan
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet


    Private Sub resetdata()
        cmbnolambung.SelectedIndex = 0
    End Sub
    Private Sub frmLaporanOperationalKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        dtpTanggalAkhir.Value = Now
        dtpTanggalAwal.Value = New DateTime(Year(Now), Month(Now), 1)
        cmbNoLambung.Items.Clear()
        Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
        While rd.Read
            cmbNoLambung.Items.Add(rd("nopol"))
        End While
        rd.Close()
        conn.Close()

        resetdata()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim ds As New DataSet
        Dim rj As New RJCommon
        Dim cn As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim adap, adap1 As New SqlDataAdapter
        Try
            cn = New SqlConnection
            cn.ConnectionString = rj.getconnstr


            cmd1.Connection = cn
            cmd1.Parameters.Clear()
            ds.Tables.Clear()
            cmd1.CommandText = "Select * from tOperationalkendaraan OK,tkendaraan k where ok.tgltransaksi>=@tglawal and ok.tgltransaksi<=@tglakhir and ok.nolambung=k.nolambung and k.nopol='" & cmbNoLambung.Text & "'"
            cmd1.Parameters.AddWithValue("@tglawal", dtpTanggalAwal.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpTanggalAkhir.Value.Date)


            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "operationalkendaraan")
            cn.Close()

            Dim pVal, pval1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            pVal.Value = dtpTanggalAwal.Value.Date
            pval1.Value = dtpTanggalAkhir.Value.Date
            Dim pField, pField1 As New CrystalDecisions.Shared.ParameterField
            pField.Name = "PeriodeAwal"
            pField.CurrentValues.Add(pVal)
            pField.HasCurrentValue = True

            pField1.Name = "PeriodeAkhir"
            pField1.CurrentValues.Add(pval1)
            pField1.HasCurrentValue = True

            If ds.Tables("operationalKendaraan").Rows.Count > 0 Then


                Dim rep As New LapOperationalKendaraan
                rep.SetDataSource(ds.Tables("operationalkendaraan"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep
                'rep.SetParameterValue("fromdate", dtpTanggalAwal.Value.ToString("dd-MM-yyyy"))
                'rep.SetParameterValue("todate", dtpTanggalAkhir.Value.ToString("dd-MM-yyyy"))
                DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAwal"), TextObject).Text = dtpTanggalAwal.Value.ToString("dd-MM-yyyy")
                DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAkhir"), TextObject).Text = dtpTanggalAkhir.Value.ToString("dd-MM-yyyy")
           
                frmlaporan.CrystalReportViewer1.RefreshReport()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
            ' MsgBox(cmd1.CommandText)
        End Try
        frmlaporan.ShowDialog()
    End Sub
End Class