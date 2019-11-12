Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmLaporanMaintenanceKendaraan
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As New DataSet
    Dim cndString, cndStringTgl, cndStringNopol
    Dim adapter2 As New SqlDataAdapter

    Private Sub frmLaporanMaintenanceKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalAwal.Format = DateTimePickerFormat.Custom
        dtpTanggalAwal.CustomFormat = "dd - MM - yyyy"

        dtpTanggalAkhir.Format = DateTimePickerFormat.Custom
        dtpTanggalAkhir.CustomFormat = "dd - MM - yyyy"

        loadNopol()

    End Sub

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

    Sub loadNopol()
        conn.Open()

        Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
        While rd.Read
            cbNopol.Items.Add(rd("nopol"))
        End While
        rd.Close()
        conn.Close()
    End Sub



    Private Sub LihatLaporanBtn_Click(sender As Object, e As EventArgs) Handles LihatLaporanBtn.Click
        panggil()
        ''masih kosong belum ada crystal report

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter2.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter2)
        adapter2.Fill(ds, "Kendaraan")
        dgvLaporanMaintenanceKendaraan.DataSource = ds
        dgvLaporanMaintenanceKendaraan.DataMember = "Kendaraan"

    End Sub
    Sub panggil()
        Dim commandtext As String
        If cbkTanggal.Checked = False Then
            ''commandtext = "Select mn.kodemaintance,mn.nolambung,mn.kodejenismaintance,mn.tukang,mn.keterangan,mn.rutin,mn.biaya,mn.tgl,mn.km,s.namasopir,mn.tindakan1,mn.tindakan2,mn.tindakan3,mn.tindakan4,mn.tindakan5,mn.kerusakan from tMaintance mn, tSopir s where mn.nolambung = (select nolambung from tkendaraan where nopol = '" + cbNopol.SelectedItem + "') and s.kodesopir = mn.kodesopir"
            commandtext = "Select mn.kodemaintance,mn.nolambung,mn.kodejenismaintance,mn.tukang,mn.keterangan,mn.rutin,mn.biaya,mn.tgl,mn.km,s.namasopir,mn.tindakan1,mn.tindakan2,mn.tindakan3,mn.tindakan4,mn.tindakan5,mn.kerusakan from tMaintance mn LEFT JOIN tSopir s  on s.kodesopir = mn.kodesopir where mn.nolambung = (select nolambung from tkendaraan where nopol = @nopol)"

        Else
            ''commandtext = "Select mn.kodemaintance,mn.nolambung,mn.kodejenismaintance,mn.tukang,mn.keterangan,mn.rutin,mn.biaya,mn.tgl,mn.km,s.namasopir,mn.tindakan1,mn.tindakan2,mn.tindakan3,mn.tindakan4,mn.tindakan5,mn.kerusakan from tMaintance mn, tSopir s where mn.nolambung = (select nolambung from tkendaraan where nopol = '" + cbNopol.SelectedItem + "') and s.kodesopir = mn.kodesopir and mn.tgl between '" + dtpTanggalAwal.Value.Date + "' and '" + dtpTanggalAkhir.Value.Date + "'"
            '            commandtext = "Select mn.kodemaintance,mn.nolambung,mn.kodejenismaintance,mn.tukang,mn.keterangan,mn.rutin,mn.biaya,mn.tgl,mn.km,s.namasopir,mn.tindakan1,mn.tindakan2,mn.tindakan3,mn.tindakan4,mn.tindakan5,mn.kerusakan from tMaintance mn, tSopir s where mn.nolambung = (select nolambung from tkendaraan where nopol = @nopol) and s.kodesopir = mn.kodesopir and mn.tgl between @tglawal and @tglakhir"
            commandtext = "Select mn.kodemaintance,mn.nolambung,mn.kodejenismaintance,mn.tukang,mn.keterangan,mn.rutin,mn.biaya,mn.tgl,mn.km,s.namasopir,mn.tindakan1,mn.tindakan2,mn.tindakan3,mn.tindakan4,mn.tindakan5,mn.kerusakan from tMaintance mn LEFT OUTER JOIN tSopir s  on s.kodesopir = mn.kodesopir where mn.nolambung = (select nolambung from tkendaraan where nopol = @nopol) and mn.tgl between @tglawal and @tglakhir"

        End If


        Dim command = New SqlCommand(commandtext, conn)
        command.Parameters.AddWithValue("@nopol", cbNopol.SelectedItem)
        command.Parameters.AddWithValue("@tglawal", dtpTanggalAwal.Value.Date)
        command.Parameters.AddWithValue("@tglakhir", dtpTanggalAkhir.Value.Date)

        ds.Clear()
        Try
            conn.Open()
            ''isidataset(New SqlCommand(commandtext, conn))
            isidataset(command)
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub LaporanExcelButton_Click(sender As Object, e As EventArgs) Handles LaporanExcelButton.Click
        panggil()

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = SaveFileDialog1.FileName


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
            isikendaraan(xlworksheet, counter)
            '  xlWorkBook.SaveAs("d:\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
            'Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.SaveAs(TextBox1.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
           Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            ' xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlworksheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)
        End If

    End Sub

    Function isikendaraan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        'xlworksheet.Cells(1, 8) = dgvLaporanMaintenanceKendaraan.Rows(1).Cells(1).Value ''nolambung
        xlworksheet.Cells(1, 8) = dgvLaporanMaintenanceKendaraan.Rows(0).Cells(1).Value ''nolambung
        xlworksheet.Cells(1, 12) = cbNopol.SelectedItem


        For i As Integer = 0 To dgvLaporanMaintenanceKendaraan.Rows.Count - 1
            'xlworksheet.Cells(counter, 1) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(0).Value ''kodemaintenance
            'xlworksheet.Cells(counter, 2) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(2).Value ''kodejenismaintenance
            'xlworksheet.Cells(counter, 3) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(3).Value ''tukang
            'xlworksheet.Cells(counter, 4) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(4).Value ''keterangan
            'xlworksheet.Cells(counter, 5) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(5).Value ''rutin
            'xlworksheet.Cells(counter, 6) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(6).Value ''biaya
            'xlworksheet.Cells(counter, 7) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(7).Value ''tgl
            'xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(8).Value ''kodesupir
            'xlworksheet.Cells(counter, 9) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(9).Value ''KM
            'xlworksheet.Cells(counter, 10) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(10).Value ''tindakan1
            'xlworksheet.Cells(counter, 11) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(11).Value ''tindakan2
            'xlworksheet.Cells(counter, 12) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(12).Value ''tindakan3
            'xlworksheet.Cells(counter, 13) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(13).Value ''tindakan4
            'xlworksheet.Cells(counter, 14) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(14).Value ''tindakan5
            'xlworksheet.Cells(counter, 15) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(15).Value ''kerusakan


            xlworksheet.Cells(counter, 1) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(0).Value ''kodemaintenance
            'xlworksheet.Cells(counter, 2) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(2).Value ''kodejenismaintenance
            xlworksheet.Cells(counter, 2) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(3).Value ''tukang
            xlworksheet.Cells(counter, 3) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(4).Value ''keterangan
            xlworksheet.Cells(counter, 4) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(5).Value ''rutin
            '  xlworksheet.Cells(counter, 6) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(6).Value ''biaya
            xlworksheet.Cells(counter, 5) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(7).Value ''tgl
            xlworksheet.Cells(counter, 6) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(8).Value ''kodesupir
            'xlworksheet.Cells(counter, 9) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(9).Value ''KM
            xlworksheet.Cells(counter, 7) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(15).Value ''kerusakan
            xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(10).Value ''tindakan1

            If (Not dgvLaporanMaintenanceKendaraan.Rows(i).Cells(11).Value Is DBNull.Value) Then
                If (dgvLaporanMaintenanceKendaraan.Rows(i).Cells(11).Value <> "") Then
                    counter = counter + 1
                    xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(11).Value
                End If
            End If

            If (Not dgvLaporanMaintenanceKendaraan.Rows(i).Cells(12).Value Is DBNull.Value) Then
                If (dgvLaporanMaintenanceKendaraan.Rows(i).Cells(12).Value <> "") Then
                    counter = counter + 1
                    xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(12).Value
                End If
            End If

            If (Not dgvLaporanMaintenanceKendaraan.Rows(i).Cells(13).Value Is DBNull.Value) Then
                If (dgvLaporanMaintenanceKendaraan.Rows(i).Cells(13).Value <> "") Then
                    counter = counter + 1
                    xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(13).Value
                End If
            End If
            If (Not dgvLaporanMaintenanceKendaraan.Rows(i).Cells(14).Value Is DBNull.Value) Then
                If (dgvLaporanMaintenanceKendaraan.Rows(i).Cells(14).Value <> "") Then
                    counter = counter + 1
                    xlworksheet.Cells(counter, 8) = dgvLaporanMaintenanceKendaraan.Rows(i).Cells(14).Value
                End If
            End If
            counter += 1
        Next
        Return (counter)
    End Function

    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "LAPORAN MAINTENANCE KENDARAAN"

        xlworksheet.Cells(1, 6) = "No Lambung :"
        xlworksheet.Cells(1, 10) = "No Polisi :"

        'xlworksheet.Cells(3, 1) = "Kode Maintenance"
        'xlworksheet.Cells(3, 2) = "No Lambung"
        'xlworksheet.Cells(3, 3) = "Kode Jenis Maintenance"
        'xlworksheet.Cells(3, 4) = "Tukang"
        'xlworksheet.Cells(3, 5) = "Keterangan"
        'xlworksheet.Cells(3, 6) = "Rutin"
        'xlworksheet.Cells(3, 7) = "Biaya"
        'xlworksheet.Cells(3, 8) = "Tanggal"
        'xlworksheet.Cells(3, 9) = "KM"
        'xlworksheet.Cells(3, 10) = "Kode Supir"
        'xlworksheet.Cells(3, 11) = "Tindakan 1"
        'xlworksheet.Cells(3, 12) = "Tindakan 2"
        'xlworksheet.Cells(3, 13) = "Tindakan 3"
        'xlworksheet.Cells(3, 14) = "Tindakan 4"
        'xlworksheet.Cells(3, 15) = "Tindakan 5"
        'xlworksheet.Cells(3, 16) = "Kerusakan"

        'xlworksheet.Cells(3, 1) = "Kode Maintenance"
        'xlworksheet.Cells(3, 2) = "Kode Jenis Maintenance"
        'xlworksheet.Cells(3, 3) = "Tukang"
        'xlworksheet.Cells(3, 4) = "Keterangan"
        'xlworksheet.Cells(3, 5) = "Rutin"
        'xlworksheet.Cells(3, 6) = "Biaya"
        'xlworksheet.Cells(3, 7) = "Tanggal"
        'xlworksheet.Cells(3, 8) = "KM"
        'xlworksheet.Cells(3, 9) = "Kode Supir"
        'xlworksheet.Cells(3, 10) = "Tindakan 1"
        'xlworksheet.Cells(3, 11) = "Tindakan 2"
        'xlworksheet.Cells(3, 12) = "Tindakan 3"
        'xlworksheet.Cells(3, 13) = "Tindakan 4"
        'xlworksheet.Cells(3, 14) = "Tindakan 5"
        'xlworksheet.Cells(3, 15) = "Kerusakan"

        'xlworksheet.Cells(3, 1) = "Kode Maintenance"
        'xlworksheet.Cells(3, 2) = "Kode Jenis Maintenance"
        'xlworksheet.Cells(3, 3) = "Tukang"
        'xlworksheet.Cells(3, 4) = "Keterangan"
        'xlworksheet.Cells(3, 5) = "Rutin"
        'xlworksheet.Cells(3, 6) = "Biaya"
        'xlworksheet.Cells(3, 7) = "Tanggal"
        'xlworksheet.Cells(3, 8) = "KM"
        'xlworksheet.Cells(3, 9) = "Nama Supir"
        'xlworksheet.Cells(3, 10) = "Kerusakan"
        'xlworksheet.Cells(3, 11) = "Tindakan"

        xlworksheet.Cells(3, 1) = "Kode Maintenance"
        xlworksheet.Cells(3, 2) = "Tukang"
        xlworksheet.Cells(3, 3) = "Keterangan"
        xlworksheet.Cells(3, 4) = "Rutin"
        xlworksheet.Cells(3, 5) = "Tanggal"
        xlworksheet.Cells(3, 6) = "Nama Supir"
        xlworksheet.Cells(3, 7) = "Kerusakan"
        xlworksheet.Cells(3, 8) = "Tindakan"


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

    Private Sub dgvLaporanMaintenanceKendaraan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaporanMaintenanceKendaraan.CellContentClick

    End Sub
End Class