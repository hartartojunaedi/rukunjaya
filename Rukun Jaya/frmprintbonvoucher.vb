Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmprintbonvoucher
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As SqlDataAdapter
    Dim cmd As New SqlCommand("", conn)


    Private Sub frmprintbonvoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlihat.Click
        conn.Open()
        'Dim cmd As New SqlCommand
        cmd.Parameters.Clear()
        cmd.CommandText = "select kodevoucher,namaspbu,liter,rupiahsatuan,rupiah,CONVERT(varchar(11),tglvoucher,103) as tglvoucher,namasopir,nopol "
        cmd.CommandText &= " from tkendaraan kend,tbm bm,tsuratjalan tsj,tvoucherspbu vouc, tspbu spbu,tperwakilan perwakilan, tsopir sopir"
        cmd.CommandText &= " where vouc.nosuratjalan=tsj.nosuratjalan and tsj.nobm=vouc.nobm and vouc.kodespbu= spbu.kodespbu"
        cmd.CommandText &= " and vouc.kodeperwakilan=perwakilan.kodeperwakilan and bm.kodesopir = sopir.kodesopir and kend.nolambung=bm.nolambung"
        cmd.CommandText &= " and bm.nobm = @nobm and tsj.nosuratjalan=@nosuratjalan"
        cmd.Parameters.AddWithValue("@nobm", txtnobm.Text)
        cmd.Parameters.AddWithValue("@nosuratjalan", txtnosj.Text)

        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(ds, "voucher")
        dgvbon.DataSource = ds.Tables("voucher")
        dgvbon.Refresh()


        conn.Close()
    End Sub

    Private Sub txtnosj_TextChanged(sender As Object, e As EventArgs) Handles txtnosj.TextChanged

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim user As String = "rukunjaya"
        Dim pwd As String = "rukunjaya123"
        Dim cmdtext As String = "select kodevoucher,namaspbu,liter,rupiahsatuan,rupiah,CONVERT(varchar(11),tglvoucher,103) as tglvoucher,namasopir,nopol "
        cmdtext &= " from tkendaraan kend,tbm bm,tsuratjalan tsj,tvoucherspbu vouc, tspbu spbu,tperwakilan perwakilan, tsopir sopir"
        cmdtext &= " where vouc.nosuratjalan=tsj.nosuratjalan and tsj.nobm=vouc.nobm and vouc.kodespbu= spbu.kodespbu"
        cmdtext &= " and vouc.kodeperwakilan=perwakilan.kodeperwakilan and bm.kodesopir = sopir.kodesopir and kend.nolambung=bm.nolambung"
        cmdtext &= " and bm.nobm = '" & txtnobm.Text & "' and tsj.nosuratjalan='" & txtnosj.Text & "'"
        Dim da As New SqlDataAdapter(cmdtext, conn)
        ds.Clear()
        da.Fill(ds, "vouchera")
        Dim report As New bonbbm
        report.SetDataSource(ds.Tables("vouchera"))
        report.SetDatabaseLogon(user, pwd)

        'report.SetParameterValue("fromDate", dtpFromPeriode.Value.ToString("dd-MM-yyyy"))
        'report.SetParameterValue("toDate", dtpToPeriode.Value.ToString("dd-MM-yyyy"))
        frmbonvoucher.CrystalReportViewer1.ReportSource = report
        frmbonvoucher.CrystalReportViewer1.Refresh()
        frmbonvoucher.Show()
    End Sub
End Class