Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLaporanMaintance
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim cndString, cndStringTgl, cndStringNopol, cndStringPekerjaan, cndStringTukang, cndStringRutin, cndStringBiaya

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        'jun 14 jan 2015
        If cbkTanggal.Checked Then
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
        cmbNamaPekerjaan.SelectedIndex = 0
        cmbRutin.SelectedIndex = 0

        cndString = ""
    End Sub

    Private Sub frmLaporanMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.Open()
        cmbnolambung.Items.Clear()
        Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
        While rd.Read
            cmbnolambung.Items.Add(rd("nopol"))
        End While
        rd.Close()

        cmbNamaPekerjaan.Items.Clear()
        rd = New SqlCommand("select * from tjenisMaintance", conn).ExecuteReader
        While rd.Read
            cmbNamaPekerjaan.Items.Add(rd("namapekerjaan"))
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
        cndStringPekerjaan = ""
        cndStringTukang = ""
        cndStringRutin = ""
        cndStringBiaya = ""

        If (cbkTanggal.Checked = True) Or (cbkNopol.Checked = True) Or (cbkPekerjaan.Checked = True) Or (cbkRutin.Checked = True) Or (cbkBiaya.Checked = True) Then
            cndString = " WHERE "
        End If
        'jun 14 jan 2015
        ' If (cbkTanggal.Checked = True) Then cndStringTgl &= " m.tgl  >= '" & dtpTanggalAwal.Value.Date & "' and m.tgl  <= '" & dtpTanggalAkhir.Value.Date & "'"
        If (cbkTanggal.Checked = True) Then cndStringTgl &= " m.tgl  >=@tgl1 and m.tgl  <=@tgl2 "

        If (cbkNopol.Checked = True And cbkTanggal.Checked = True) Then cndStringNopol &= " AND k.nopol LIKE '%" & cmbnolambung.SelectedItem.ToString & "%'"
        If (cbkNopol.Checked = True And cbkTanggal.Checked = False) Then cndStringNopol &= " k.nopol LIKE '%" & cmbnolambung.SelectedItem.ToString & "%'"

        If (cbkTukang.Checked = True) Then
            If (cbkNopol.Checked = True Or cbkTanggal.Checked = True) Then
                cndStringPekerjaan &= " AND m.tukang LIKE '%" & txtTukang.Text & "%'"
            ElseIf (cbkNopol.Checked = False And cbkTanggal.Checked = False) Then
                cndStringPekerjaan &= " m.tukang LIKE '%" & txtTukang.Text & "%'"
            End If
        End If

        If (cbkPekerjaan.Checked = True) Then
            If (cbkNopol.Checked = True Or cbkTanggal.Checked = True Or cbkTukang.Checked = True) Then
                cndStringPekerjaan &= " AND jm.namapekerjaan LIKE '%" & cmbNamaPekerjaan.SelectedItem.ToString & "%'"
            ElseIf (cbkNopol.Checked = False And cbkTanggal.Checked = False And cbkTukang.Checked = False) Then
                cndStringPekerjaan &= " jm.namapekerjaan LIKE '%" & cmbNamaPekerjaan.SelectedItem.ToString & "%'"
            End If
        End If

        Dim rutinvalue As Boolean
        If cmbRutin.SelectedIndex = 0 Then rutinvalue = True
        If cmbRutin.SelectedIndex = 1 Then rutinvalue = False

        If (cbkRutin.Checked = True) Then
            If (cbkNopol.Checked = True Or cbkTanggal.Checked = True Or cbkPekerjaan.Checked = True Or cbkTukang.Checked = True) Then
                cndStringRutin &= " AND m.rutin  ='" & rutinvalue & "'"
            ElseIf (cbkNopol.Checked = False And cbkTanggal.Checked = False And cbkPekerjaan.Checked = False And cbkTukang.Checked = False) Then
                cndStringRutin &= " m.rutin  ='" & rutinvalue & "'"
            End If
        End If

        If (cbkBiaya.Checked = True) Then
            If (cbkRutin.Checked = True Or cbkNopol.Checked = True Or cbkTanggal.Checked = True Or cbkPekerjaan.Checked = True Or cbkTukang.Checked = True) Then
                cndStringBiaya &= " AND m.biaya >=" & nmBiayaAwal.Value & " AND m.biaya <=" & nmBiayaAkhir.Value
            ElseIf (cbkRutin.Checked = False And cbkNopol.Checked = False And cbkTanggal.Checked = False And cbkPekerjaan.Checked = False And cbkTukang.Checked = False) Then
                cndStringBiaya &= " m.biaya >=" & nmBiayaAwal.Value & " AND m.biaya <=" & nmBiayaAkhir.Value
            End If
        End If

        Try
            conn.Open()
            ds = New DataSet
            Dim cmdselect = "m.kodemaintance,k.nopol,jm.namapekerjaan,m.tukang,m.keterangan,m.rutin,m.biaya,convert(varchar,m.tgl,105) as tgl,m.km,s.namasparepart,dm.noseri,dm.jumlah,dm.biaya,dm.keterangan"
            Dim cmdString = "SELECT " & cmdselect & " FROM tmaintance m "
            cmdString &= "LEFT JOIN tdetailmaintance dm ON m.kodemaintance = dm.kodemaintance "
            cmdString &= "LEFT JOIN tsparepart s ON dm.kodesparepart = s.kodesparepart "
            cmdString &= "LEFT JOIN tkendaraan k ON m.nolambung = k.nolambung "
            cmdString &= "LEFT JOIN tjenismaintance jm ON m.kodejenismaintance = jm.kodejenismaintance "

            adapter(cmdString & cndString & cndStringTgl & cndStringNopol & cndStringPekerjaan & cndStringRutin & cndStringBiaya).Fill(ds, "tlaporanmaintance")
            dgvLaporanMaintance.DataSource = ds.Tables("tlaporanmaintance")
            dgvLaporanMaintance.Refresh()
            'jun 10 feb 2015
            If ds.Tables("tlaporanmaintance").Rows.Count > 0 Then
                Dim report As New CRLaporanMaintance
                report.SetDataSource(ds.Tables("tlaporanmaintance"))
                frmLihatLaporanMaintance.CrystalReportViewer1.ReportSource = report
                frmLihatLaporanMaintance.CrystalReportViewer1.Refresh()
                frmLihatLaporanMaintance.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display !")
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLaporan", "Master Laporan Maintance", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        End Try
        
    End Sub
End Class