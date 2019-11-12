Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary
Public Class frmLaporanPengeluaranSparePart

    Private Sub frmLaporanPengeluaranSparePart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = "01-" & DateAndTime.Today.Month - 1
        End If
    End Sub

    Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
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
            ''cmd1.CommandText = "Select M.Nomutasi, M.tanggalMutasi, d.kodesparepart,s.namasparepart,d.jumlahsebelum,d.jumlahsesudah,d.jumlahsesudah-d.jumlahsebelum as selisih,d.keterangan from tmutasi M,tdmutasi d, tsparepart s where s.kodesparepart=d.kodesparepart and d.nomutasi=m.nomutasi  and m.tanggalmutasi>=@tglawal and m.tanggalmutasi<=@tglakhir order by nomutasi desc"
            cmd1.CommandText = "select hm.tgltransaksi,hm.nota,hk.id,sp.kodesparepart,sp.namasparepart,dm.jumlah as jumlahmaasuk,dk.jumlah as jumlahkeluar from tHMasuk hm,THKeluar hk,tdMasuk dm,tdMutasiKeluar dk,tSparePart sp where  hm.tgltransaksi>=@tglawal and hm.tgltransaksi<=@tglakhir and hm.tgltransaksi = hk.tgl And hm.nota = dm.nota And hk.id = dk.id And dk.kodesparepart = dm.kodesparepart And dk.kodesparepart = sp.kodesparepart order by hm.tgltransaksi"
            ''cmd1.CommandText = "select hm.tgltransaksi,hm.nota,hk.id,sp.kodesparepart,sp.namasparepart,coalesce(dm.jumlah,0) as jumlahmaasuk, coalesce(dk.jumlah,0) as jumlahkeluar from tHMasuk hm,THKeluar hk,tdMasuk dm,tdMutasiKeluar dk,tSparePart sp where hm.tgltransaksi = hk.tgl And hm.nota = dm.nota And hk.id = dk.id And dk.kodesparepart = sp.kodesparepart"

            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)


            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "Transaksi")
            cn.Close()


            'jun 10 feb 2015
            If ds.Tables("Transaksi").Rows.Count > 0 Then
                Dim rep As New LaporanPengeluaranSparePart
                rep.SetDataSource(ds.Tables("Transaksi"))
                'jun 10 feb 2015
                rep.SetParameterValue("Mulai", dtpAwalPeriode.Value.ToString("dd-MM-yyyy"))
                rep.SetParameterValue("Sampai", dtpAKhirPeriode.Value.ToString("dd-MM-yyyy"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep

                frmlaporan.ShowDialog()
            Else
                rj.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class