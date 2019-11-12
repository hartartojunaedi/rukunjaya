Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary

Public Class frmLaporanUjiKir
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon

    Sub init()
        dtpTglAwal.Select()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmLaporanUjiKir", "Laporan Uji Kir", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub btnLihatLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLihatLaporan.Click
        btnLihatLaporan.Enabled = False
        cmd.Parameters.Clear()

        'cmd.CommandText = "select k.nolambung, nopol, tglkir as 'tanggal kir', tglkirberikutnya as 'tanggal kir berikutnya' "
        cmd.CommandText = "select u.nokir, u.nolambung, u.tglkir, u.tglkirberikutnya, u.keterangan "
        cmd.CommandText &= "from tKendaraan k, tUjiKir u "
        'cmd.CommandText &= "where k.nolambung = u.nolambung "
        If rdbKir.Checked Then
            cmd.CommandText &= "where k.nolambung = u.nolambung and tglkir between @from and @to "
        Else
            cmd.CommandText &= "where k.nolambung = u.nolambung and tglkirberikutnya between @from and @to "
        End If

        cmd.CommandText &= "order by tglkir, tglkirberikutnya"
        'MsgBox(cmd.CommandText)
        cmd.Parameters.Add(New SqlParameter("@from", dtpTglAwal.Value.ToString("yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@to", dtpTglAkhir.Value.ToString("yyyy-MM-dd")))
        Try
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            'MsgBox(dt.Rows.Count)
            Dim report As New LaporanUjiKir_
            report.SetDataSource(dt)
            DirectCast(report.ReportDefinition.ReportObjects("PeriodeAwal"), TextObject).Text = dtpTglAwal.Value.ToString("dd-MM-yyyy")
            DirectCast(report.ReportDefinition.ReportObjects("PeriodeAkhir"), TextObject).Text = dtpTglAkhir.Value.ToString("dd-MM-yyyy")
            frmcetaklaporan.CrystalReportViewer1.ReportSource = report
            frmcetaklaporan.CrystalReportViewer1.Refresh()
            frmcetaklaporan.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
            frmcetaklaporan.ShowDialog()
            dtpTglAwal.Select()
        Catch ex As Exception
            'MsgBox(ex.Message)
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLihatLaporan_Click", "Laporan Uji Kir", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        Finally
            btnLihatLaporan.Enabled = True
        End Try
    End Sub

    Private Sub frmLaporanUjiKir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection(_rjcommon.getconnstr)
        cmd = New SqlCommand("", conn)
        init()
    End Sub
End Class