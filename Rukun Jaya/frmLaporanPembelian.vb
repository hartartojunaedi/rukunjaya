Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary
Public Class frmLaporanPembelian

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
            cmd1.CommandText = "Select d.kodesparepart, d.nota,h.tgltransaksi,h.namatoko,h.total,h.diskon,h.grandtotal, d.jumlah,d.harga,s.namasparepart from thbeli h, tdbeli d, tSparepart S where d.nota=h.nota and s.kodesparepart=d.kodesparepart and h.tgltransaksi>=@tglawal and h.tgltransaksi<=@tglakhir" '  
            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)
            ' cmd1.Parameters.AddWithValue("@nota", txtNonota.Text)

            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "Pembelian")
            cn.Close()

            'Dim pVal, pval1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            'pVal.Value = dtpAwalPeriode.Value.Date
            'pval1.Value = dtpAKhirPeriode.Value.Date
            'Dim pField, pField1 As New CrystalDecisions.Shared.ParameterField
            'pField.Name = "PeriodeAwal"
            'pField.CurrentValues.Add(pVal)
            'pField.HasCurrentValue = True

            'pField1.Name = "PeriodeAkhir"
            'pField1.CurrentValues.Add(pval1)
            'pField1.HasCurrentValue = True
            'jun 10 feb 2015
            If ds.Tables("Pembelian").Rows.Count > 0 Then
                Dim rep As New LapPembelianSparePart
                rep.SetDataSource(ds.Tables("Pembelian"))
                'jun 10 feb 2015
                rep.SetParameterValue("PeriodeAwal", dtpAwalPeriode.Value.ToString("dd-MM-yyyy"))
                rep.SetParameterValue("PeriodeAkhir", dtpAKhirPeriode.Value.ToString("dd-MM-yyyy"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep
                'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField1)
                'frmlaporan.CrystalReportViewer1.RefreshReport()
                frmlaporan.ShowDialog()
            Else
                rj.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try


    End Sub

  
    Private Sub frmLaporanPembelian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = "01-" & DateAndTime.Today.Month - 1
        End If
    End Sub
End Class