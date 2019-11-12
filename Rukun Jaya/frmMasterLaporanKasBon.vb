Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports RjLibrary
Public Class frmMasterLaporanKasBon
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon

    Private Sub init()
        dtpFromPeriode.Value = New DateTime(Now.Year, Now.Month, 1, 0, 0, 1)
        dtpFromPeriode.Select()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            initCmbJenis()
            initCmbSopir()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmLaporanKasBon_Load", "Master Laporan Kas Bon", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub initCmbJenis()
        cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational WHERE jenis=1"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        Try
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodejenis") = ""
        dr.Item("namajenis") = "-- Semua --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbJenis.DataSource = dt
        cmbJenis.DisplayMember = "namajenis"
        cmbJenis.ValueMember = "kodejenis"
    End Sub

    Private Sub initCmbSopir()
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir WHERE status=0"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodesopir") = ""
        dr.Item("namasopir") = "-- Semua --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbSopir.DataSource = dt
        cmbSopir.DisplayMember = "namasopir"
        cmbSopir.ValueMember = "kodesopir"
    End Sub

    Private Sub frmLaporanKasBon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection(_rjcommon.getconnstr)
        cmd = New SqlCommand("", con)
        init()
    End Sub

    Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
        btnLihatLaporan.Enabled = False
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, jOp.namajenis as jenis, sop.namasopir as kode, op.harga, op.keterangan FROM tOperational op"
        cmd.CommandText &= " LEFT JOIN tJenisOperational jOp ON jOp.kodejenis=op.jenis "
        cmd.CommandText &= " LEFT JOIN tSopir sop ON sop.kodesopir=op.kode "
        cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational WHERE jenis=1))"
        cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir WHERE status=0))"
        If cmbJenis.SelectedValue <> "" Then
            cmd.CommandText &= " AND jOp.kodejenis = @kodejenis "
            cmd.Parameters.Add(New SqlParameter("@kodejenis", cmbJenis.SelectedValue))
        End If
        If cmbSopir.SelectedValue <> "" Then
            cmd.CommandText &= " AND sop.kodesopir = @kode "
            cmd.Parameters.Add(New SqlParameter("@kode", cmbSopir.SelectedValue))
        End If
        cmd.CommandText &= " ORDER BY op.tgltransaksi"
        'jun 3 feb 2015
        cmd.Parameters.Add(New SqlParameter("@from", dtpFromPeriode.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@to", dtpToPeriode.Value.Date))
        'cmd.Parameters.Add(New SqlParameter("@from", dtpFromPeriode.Value.ToString("yyyy-MM-dd")))
        'cmd.Parameters.Add(New SqlParameter("@to", dtpToPeriode.Value.ToString("yyyy-MM-dd")))
        Try
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)

            'jun 10 feb 2015
            If dt.Rows.Count > 0 Then
                Dim report As New LaporanKasBon
                report.SetDataSource(dt)
                report.SetParameterValue("fromDate", dtpFromPeriode.Value.ToString("dd-MM-yyyy"))
                report.SetParameterValue("toDate", dtpToPeriode.Value.ToString("dd-MM-yyyy"))
                frmLaporanKasBon.CrystalReportViewer1.ReportSource = report
                frmLaporanKasBon.CrystalReportViewer1.Refresh()
                frmLaporanKasBon.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
                frmLaporanKasBon.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If
            dtpFromPeriode.Select()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLihatLaporan_Click", "Master Laporan Kas Bon", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        Finally
            btnLihatLaporan.Enabled = True
        End Try
    End Sub

    Private Sub dtpFromPeriode_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpFromPeriode.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpToPeriode.Focus()
        End If
    End Sub

    Private Sub cmbSopir_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbSopir.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLihatLaporan.Focus()
        End If
    End Sub

    Private Sub dtpToPeriode_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpToPeriode.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbJenis.Focus()
        End If
    End Sub

    Private Sub cmbJenis_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbJenis.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbSopir.Focus()
        End If
    End Sub

    Private Sub cmbJenis_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbJenis.Validating
        If cmbJenis.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbSopir_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbSopir.Validating
        If cmbSopir.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub removeDingSound_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFromPeriode.KeyDown, dtpToPeriode.KeyDown, cmbJenis.KeyDown, cmbSopir.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

End Class