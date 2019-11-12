Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports RjLibrary
Imports Microsoft.Office.Interop

Public Class frmMasterLaporanPengeluaran
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter

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
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmMasterLaporanPengeluaran_Load", "Master Laporan Pengeluaran", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        End Try
    End Sub

    Private Sub initCmbJenis()
        'cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational WHERE jenis=0"
        cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational "
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
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir"
        'cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir WHERE status=1"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodesopir") = ""
        dr.Item("namasopir") = "-- Semua --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbKaryawan.DataSource = dt
        cmbKaryawan.DisplayMember = "namasopir"
        cmbKaryawan.ValueMember = "kodesopir"
    End Sub

    Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
        btnLihatLaporan.Enabled = False
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, jOp.namajenis as jenis, sop.namasopir as kode, op.harga, op.keterangan FROM tOperational op"
        cmd.CommandText &= " LEFT JOIN tJenisOperational jOp ON jOp.kodejenis=op.jenis "
        cmd.CommandText &= " LEFT JOIN tSopir sop ON sop.kodesopir=op.kode "
        cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational ))"
        cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir ))"
        '      cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational WHERE jenis=0))"
        '     cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir WHERE status=1))"
        If cmbJenis.SelectedValue <> "" Then
            cmd.CommandText &= " AND jOp.kodejenis = @kodejenis "
            cmd.Parameters.Add(New SqlParameter("@kodejenis", cmbJenis.SelectedValue))
        End If
        If cmbKaryawan.SelectedValue <> "" Then
            cmd.CommandText &= " AND sop.kodesopir = @kode "
            cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
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
                Dim report As New LaporanPengeluaran
                report.SetDataSource(dt)
                report.SetParameterValue("fromDate", dtpFromPeriode.Value.ToString("dd-MM-yyyy"))
                report.SetParameterValue("toDate", dtpToPeriode.Value.ToString("dd-MM-yyyy"))
                frmLaporanPengeluaran.CrystalReportViewer1.ReportSource = report
                frmLaporanPengeluaran.CrystalReportViewer1.Refresh()
                frmLaporanPengeluaran.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If
            dtpFromPeriode.Select()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLihatLaporan_Click", "Master Laporan Pengeluaran", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        Finally
            btnLihatLaporan.Enabled = True
        End Try
    End Sub

    Private Sub frmMasterLaporanPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection(_rjcommon.getconnstr)
        cmd = New SqlCommand("", con)
        init()
    End Sub

    Private Sub dtpFromPeriode_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpFromPeriode.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpToPeriode.Focus()
        End If
    End Sub

    Private Sub dtpToPeriode_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpToPeriode.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbJenis.Focus()
        End If
    End Sub

    Private Sub cmbJenis_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbJenis.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbKaryawan.Focus()
        End If
    End Sub

    Private Sub cmbKaryawan_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbKaryawan.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnLihatLaporan.Focus()
        End If
    End Sub

    Private Sub cmbJenis_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbJenis.Validating
        If cmbJenis.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbKaryawan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbKaryawan.Validating
        If cmbKaryawan.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub removeDingSound_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFromPeriode.KeyDown, dtpToPeriode.KeyDown, cmbJenis.KeyDown, cmbKaryawan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Kas")
        dgvKasHarian.DataSource = dataset
        dgvKasHarian.DataMember = "Kas"
    End Sub
    Private Sub panggil()
      
        Dim cmd As New SqlCommand
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, jOp.namajenis as jenis, sop.namasopir as kode, op.harga, op.keterangan FROM tOperational op"
        cmd.CommandText &= " LEFT JOIN tJenisOperational jOp ON jOp.kodejenis=op.jenis "
        cmd.CommandText &= " LEFT JOIN tSopir sop ON sop.kodesopir=op.kode "
        cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational ))"
        cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir ))"
        '      cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational WHERE jenis=0))"
        '     cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir WHERE status=1))"
        If cmbJenis.SelectedValue <> "" Then
            cmd.CommandText &= " AND jOp.kodejenis = @kodejenis "
            cmd.Parameters.Add(New SqlParameter("@kodejenis", cmbJenis.SelectedValue))
        End If
        If cmbKaryawan.SelectedValue <> "" Then
            cmd.CommandText &= " AND sop.kodesopir = @kode "
            cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
        End If
        cmd.CommandText &= " ORDER BY op.tgltransaksi"
        'jun 3 feb 2015
        cmd.Parameters.Add(New SqlParameter("@from", dtpFromPeriode.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@to", dtpToPeriode.Value.Date))

        dataset.Clear()
        Try
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If
            isidataset(cmd)
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MASTER OPERATIONAL"
        xlworksheet.Cells(3, 1) = "Kode Transaksi"
        xlworksheet.Cells(3, 2) = "Tanggal"
        xlworksheet.Cells(3, 3) = "Jenis"
        xlworksheet.Cells(3, 4) = "Karyawan"
        xlworksheet.Cells(3, 5) = "Harga"
        xlworksheet.Cells(3, 6) = "Keterangan"
    End Sub

    Function isikaryawan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        For i As Integer = 0 To dgvKasHarian.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvKasHarian.Rows(i).Cells(0).Value
            xlworksheet.Cells(counter, 2) = dgvKasHarian.Rows(i).Cells(1).Value
            xlworksheet.Cells(counter, 3) = dgvKasHarian.Rows(i).Cells(2).Value
            xlworksheet.Cells(counter, 4) = dgvKasHarian.Rows(i).Cells(3).Value
            xlworksheet.Cells(counter, 5) = dgvKasHarian.Rows(i).Cells(4).Value
            xlworksheet.Cells(counter, 6) = dgvKasHarian.Rows(i).Cells(5).Value
            counter += 1
        Next


        Return (counter)
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

          
            panggil()


            If DataSet.Tables("kas").Rows.Count > 0 Then



                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    TextBox2.Text = SaveFileDialog1.FileName

                    Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
                    If xlApp Is Nothing Then
                        MessageBox.Show("Excel is not properly installed!!")
                        Return
                    End If
                    Dim xlWorkBook As Excel.Workbook
                    Dim misValue As Object = System.Reflection.Missing.Value
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    Dim xlworksheet As Excel.Worksheet
                    xlworksheet = xlWorkBook.Sheets("sheet1")
                    initheader(xlworksheet)
                    Dim counter As Integer = 4
                    isikaryawan(xlworksheet, counter)
                    '  xlWorkBook.SaveAs("d:\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
                    'Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.SaveAs(TextBox2.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
                   Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                    xlWorkBook.Close(True, misValue, misValue)
                    ' xlWorkBook.Close(True, misValue, misValue)
                    xlApp.Quit()

                    releaseObject(xlworksheet)
                    releaseObject(xlWorkBook)
                    releaseObject(xlApp)
                End If
            Else
                _rjcommon.shownotifyerror("No Record Found To Display !")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class