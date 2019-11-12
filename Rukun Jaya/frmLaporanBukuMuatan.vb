﻿Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary

Public Class frmLaporanBukuMuatan

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
            cmd1.CommandText = "Select k.nopol,s.sangu,s.tglmuat,tglbongkar,so.namasopir,S.jenispekerjaan,(select sum(liter) from tvoucherspbu v where v.nobm=b.nobm) as liter, su.namasupplier from tsupplier su,tsopir so,tkendaraan k, tBM b,tSuratJalan S where s.tglmuat>=@tglawal and s.tglmuat<=@tglakhir and b.kodesopir=so.kodesopir and b.nolambung=k.nolambung and s.nobm=b.nobm and s.kodesupplier=su.kodesupplier and k.nopol like @nopol and SO.NamaSopir like @sopir"
            ' cmd1.CommandText = "Select k.nopol,s.sangu,s.tglmuat,tglbongkar,so.namasopir,S.jenispekerjaan, v.liter from tsopir so,tkendaraan k, tBM b,tSuratJalan S, tVoucherSPBU v where v.nobm=b.nobm and s.tglmuat>=@tglawal and s.tglmuat<=@tglakhir and b.kodesopir=so.kodesopir and b.nolambung=k.nolambung and s.nobm=b.nobm and k.nopol like @nopol and SO.NamaSopir like @sopir"
            ' cmd1.CommandText = "Select d.kodesparepart,S.Namasparepart,s.stock,s.hargaterakhir, d.tgl, d.harga from thistoryharga d,tSparepart S where d.tgl>=@tglawal and d.tgl<=@tglakhir and s.kodesparepart=d.kodesparepart"
            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@nopol", "%" + txtNopol.Text + "%")
            cmd1.Parameters.AddWithValue("@sopir", "%" + txtNamaSupir.Text + "%")
            ' cmd1.Parameters.AddWithValue("@nota", txtNonota.Text)

            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "bukumuat")
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

            Dim rep As New lapBukuMuatan
            rep.SetDataSource(ds.Tables("bukumuat"))
            frmlaporan.CrystalReportViewer1.ReportSource = rep
            DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAwal"), TextObject).Text = dtpAwalPeriode.Value.ToString("dd-MM-yyyy")
            DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAkhir"), TextObject).Text = dtpAKhirPeriode.Value.ToString("dd-MM-yyyy")
            'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
            'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField1)
            frmlaporan.CrystalReportViewer1.RefreshReport()


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
        frmlaporan.ShowDialog()
    End Sub

    Private Sub frmLaporanBukuMuatan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = DateAndTime.Today.Month & "-01"
        End If
    End Sub
End Class