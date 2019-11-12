Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmdetailsearchsparepart
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public kodemaintance As String = ""
    Public kodesparepart As String = ""
    Public noseri As String = ""
    Private Sub loaddata()
        lblkodemaintance.Text = kodemaintance
        lblkodesparepart.Text = kodesparepart
        lblnoseri.Text = noseri

        Dim query As String = ""
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        query = "select m.keterangan,m.tgl,s.namasparepart,d.jumlah,d.biaya,m.nolambung,k.nopol,k.merek,jm.namapekerjaan,m.nolambung,m.tukang,m.km"
        query &= " from tmaintance m,tdetailmaintance d,tsparepart s,tkendaraan k,tjenismaintance jm "
        query &= " where m.kodemaintance=d.kodemaintance and d.kodesparepart=s.kodesparepart and m.nolambung=k.nolambung and m.kodejenismaintance=jm.kodejenismaintance"
        query &= " and m.kodemaintance='" & kodemaintance & "'"
        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        While dr.Read()
            lblnamasparepart.Text = dr.Item("namasparepart")
            lblkendaraan.Text = dr.Item("nolambung") & " /  " & dr.Item("nopol")
            lbltgl.Text = Format(dr.Item("tgl"), "dd-MM-yyyy")
            lbltukang.Text = dr.Item("tukang")
            lblkm.Text = Format(dr.Item("km"), "N0")
            lblpekerjaan.Text = dr.Item("namapekerjaan")
            lblketerangan.Text = dr.Item("keterangan")
            lblbiaya.Text = Format(dr.Item("jumlah"), "N0") & " / " & Format(dr.Item("biaya"), "N0")
        End While
        conn.Close()
    End Sub
    Private Sub frmdetailsearchsparepart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub lblkodemaintance_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblkodemaintance.LinkClicked

        Dim ds As New DataSet

        Dim cmdselect As String = "m.kodemaintance,k.nopol,jm.namapekerjaan,m.tukang,m.keterangan,m.rutin,m.biaya,convert(varchar,m.tgl,105) as tgl,m.km,s.namasparepart,dm.noseri,dm.jumlah,dm.biaya,dm.keterangan"
        Dim cmdString As String = "SELECT " & cmdselect & " FROM tmaintance m "
        cmdString &= "LEFT JOIN tdetailmaintance dm ON m.kodemaintance = dm.kodemaintance "
        cmdString &= "LEFT JOIN tsparepart s ON dm.kodesparepart = s.kodesparepart "
        cmdString &= "LEFT JOIN tkendaraan k ON m.nolambung = k.nolambung "
        cmdString &= "LEFT JOIN tjenismaintance jm ON m.kodejenismaintance = jm.kodejenismaintance "
        cmdString &= " where m.kodemaintance='" & kodemaintance & "'"
        Dim da As New SqlDataAdapter(cmdString, conn)
        da.Fill(ds, "tlaporanmaintance")


        Dim report As New CRLaporanMaintance
        report.SetDataSource(ds.Tables("tlaporanmaintance"))
        frmLihatLaporanMaintance.CrystalReportViewer1.ReportSource = report
        frmLihatLaporanMaintance.CrystalReportViewer1.Refresh()
        frmLihatLaporanMaintance.ShowDialog()
    End Sub
End Class