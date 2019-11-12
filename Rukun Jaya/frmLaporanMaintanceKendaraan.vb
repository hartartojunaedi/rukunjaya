Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmLaporanMaintanceKendaraan
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim cndString, cndStringTgl, cndStringNopol

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        'jun 14 jan 2015
        If cbkTanggal.Checked Then
            'jun 04 feb 2015
            cmd.Parameters.AddWithValue("@tgl1", dtpTanggalAwal.Value.Date)
            cmd.Parameters.AddWithValue("@tgl2", dtpTanggalAkhir.Value.Date)
        End If
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub refreshdata()
        conn.Open()
        ds = New DataSet
        adapter("select kodesparepart,stock from tsparepart").Fill(ds, "tsparepart")
        conn.Close()
    End Sub

    Private Sub resetdata()
        cmbnolambung.SelectedIndex = 0
    End Sub

    Private Sub frmLaporanMaintanceKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Open()
        cmbnolambung.Items.Clear()
        Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
        While rd.Read
            cmbnolambung.Items.Add(rd("nopol"))
        End While
        rd.Close()
        conn.Close()

        refreshdata()
        resetdata()
    End Sub


    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        cndString = ""
        cndStringTgl = ""
        cndStringNopol = ""
        cbkNopol.Checked = True

        If (cbkTanggal.Checked = True) Or (cbkNopol.Checked = True) Then
            cndString = " WHERE "
        End If
        'jun 14 jan 2015
        '        If (cbkTanggal.Checked = True) Then cndStringTgl &= " m.tgl  >= '" & dtpTanggalAwal.Value.Date & "' and m.tgl  <= '" & dtpTanggalAkhir.Value.Date & "'"
        If (cbkTanggal.Checked = True) Then cndStringTgl &= " m.tgl  >=@tgl1 and m.tgl  <=@tgl2 "

        '       If (cbkNopol.Checked = True And cbkTanggal.Checked = True) Then cndStringNopol &= " AND k.nopol LIKE '%" & cmbnolambung.SelectedItem.ToString & "%'"
        If (cbkNopol.Checked = True And cbkTanggal.Checked = True) Then cndStringNopol &= " AND k.nopol='" & cmbnolambung.SelectedItem.ToString & "'"
        '        If (cbkNopol.Checked = True And cbkTanggal.Checked = False) Then cndStringNopol &= " k.nopol LIKE '%" & cmbnolambung.SelectedItem.ToString & "%'"
        If (cbkNopol.Checked = True And cbkTanggal.Checked = False) Then cndStringNopol &= " k.nopol='" & cmbnolambung.SelectedItem.ToString & "'"


        Try
            conn.Open()
            ds = New DataSet
            Dim cmdselect = "m.kodemaintance,k.nopol,jm.namapekerjaan,m.tukang,m.keterangan,m.rutin,m.biaya,convert(varchar,m.tgl,105) as tgl,m.km,s.namasparepart,dm.noseri,dm.jumlah,dm.biaya,dm.keterangan"
            '         Dim cmdselect = "m.kodemaintance,k.nopol,jm.namapekerjaan,m.tukang,m.keterangan,m.rutin,m.biaya,convert(varchar,m.tgl,105) as tgl,m.km,s.namasparepart,dm.noseri,dm.jumlah,dm.biaya,dm.keterangan,th.namatoko"
            Dim cmdString = "SELECT " & cmdselect & " FROM tmaintance m "
            cmdString &= "LEFT JOIN tdetailmaintance dm ON m.kodemaintance = dm.kodemaintance "
            cmdString &= "LEFT JOIN tsparepart s ON dm.kodesparepart = s.kodesparepart "
            cmdString &= "LEFT JOIN tkendaraan k ON m.nolambung = k.nolambung "
            cmdString &= "LEFT JOIN tjenismaintance jm ON m.kodejenismaintance = jm.kodejenismaintance "
            'cmdString &= "LEFT JOIN tdbeli td ON td.kodesparepart = s.kodesparepart "
            'cmdString &= "LEFT JOIN thbeli th ON th.nota = td.nota "

            adapter(cmdString & cndString & cndStringTgl & cndStringNopol).Fill(ds, "tlaporanmaintancekendaraan")
            ' dgvLaporanMaintance.DataSource = ds.Tables("tlaporanmaintance")
            'dgvLaporanMaintance.Refresh()
            If ds.Tables("tlaporanmaintancekendaraan").Rows.Count > 0 Then
                Dim report As New crLaporanMaintanceKendaraan
                report.SetDataSource(ds.Tables("tlaporanmaintancekendaraan"))
                frmLihatLaporanMaintance.CrystalReportViewer1.ReportSource = report
                frmLihatLaporanMaintance.CrystalReportViewer1.Refresh()
                frmLihatLaporanMaintance.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLaporan", "Master Laporan Maintance Kendaraan", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        End Try

    End Sub
End Class