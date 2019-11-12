Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary
Public Class frmLaporanPengeluaranBarang

    Private Sub frmLaporanPengeluaranBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = DateAndTime.Today.Month & "-01"
        End If
    End Sub

    Private Sub btnLihatLaporan_Click(sender As System.Object, e As System.EventArgs) Handles btnLihatLaporan.Click
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
            '            cmd1.CommandText = "Select s.kodesparepart, s.namasparepart, d.jumlah, m.tgl,s.hargaterakhir,m.kodemaintance from tmaintance m,tdetailmaintance d, tSparepart S where s.kodesparepart=d.kodesparepart and m.kodemaintance=d.kodemaintance and m.tgl>=@tglawal and m.tgl<=@tglakhir"
            cmd1.CommandText = "Select s.kodesparepart, s.namasparepart, d.jumlah, m.tgl,d.biaya as hargaterakhir,m.kodemaintance from tmaintance m,tdetailmaintance d, tSparepart S where s.kodesparepart=d.kodesparepart and m.kodemaintance=d.kodemaintance and m.tgl>=@tglawal and m.tgl<=@tglakhir"
            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)


            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "Pengeluaran")
            cn.Close()

            Dim pVal, pval1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            pVal.Value = dtpAwalPeriode.Value.Date
            pval1.Value = dtpAKhirPeriode.Value.Date
            Dim pField, pField1 As New CrystalDecisions.Shared.ParameterField
            pField.Name = "PeriodeAwal"
            pField.CurrentValues.Add(pVal)
            pField.HasCurrentValue = True

            pField1.Name = "PeriodeAkhir"
            pField1.CurrentValues.Add(pval1)
            pField1.HasCurrentValue = True

            Dim rep As New LaporanPengeluaranBarang
            rep.SetDataSource(ds.Tables("Pengeluaran"))
            frmlaporan.CrystalReportViewer1.ReportSource = rep
            'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
            'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField1)
            DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAwal"), TextObject).Text = dtpAwalPeriode.Value.ToString("dd-MM-yyyy")
            DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAkhir"), TextObject).Text = dtpAKhirPeriode.Value.ToString("dd-MM-yyyy")
            frmlaporan.CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
        frmlaporan.ShowDialog()
    End Sub
End Class