Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class frmKasHarian
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim dataset As New DataSet

    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Private Sub frmKasHarian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Year(Now)
        ComboBox1.SelectedIndex = Month(Now)
        panggil()

    End Sub

    Private Sub btnLaporan_Click(sender As System.Object, e As System.EventArgs) Handles btnLaporan.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim query As String = "select * from vkasharian where month(tgl)=@bulan and year(tgl)=@year order by tgl,nopol"
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@bulan", ComboBox1.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@year", CInt(TextBox1.Text))
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "kas")
            If ds.Tables("kas").Rows.Count > 0 Then
                Dim report As New crpKasHarian
                report.SetDataSource(ds.Tables("kas"))
                frmReportKasHarian.CrystalReportViewer1.ReportSource = report
                frmReportKasHarian.CrystalReportViewer1.Refresh()
                frmReportKasHarian.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display !")
            End If
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
            _rjcommon.isiErrorlog(_rjcommon.getusername, "btnLaporan", "Laporan Kas Harian", "Load Laporan", ex.Message)
            _rjcommon.shownotifyerror("Load laporan gagal")
        End Try
    End Sub


    Function isikaryawan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        For i As Integer = 0 To dgvKasHarian.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvKasHarian.Rows(i).Cells(0).Value
            xlworksheet.Cells(counter, 2) = dgvKasHarian.Rows(i).Cells(1).Value
            xlworksheet.Cells(counter, 3) = dgvKasHarian.Rows(i).Cells(2).Value
            xlworksheet.Cells(counter, 4) = dgvKasHarian.Rows(i).Cells(3).Value
            xlworksheet.Cells(counter, 5) = dgvKasHarian.Rows(i).Cells(4).Value
            counter += 1
        Next


        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MASTER KAS HARIAN"
        xlworksheet.Cells(3, 1) = "Tanggal"
        xlworksheet.Cells(3, 2) = "Nopol"
        xlworksheet.Cells(3, 3) = "Keterangan"
        xlworksheet.Cells(3, 4) = "Debet"
        xlworksheet.Cells(3, 5) = "Kredit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'excel
        Try

   
        panggil()
            If dataset.Tables("kas").Rows.Count > 0 Then



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

    

    Sub panggil()

        Dim command As New SqlCommand("select * from vkasharian where month(tgl)=@bulan and year(tgl)=@year order by tgl,nopol", conn)
        command.Parameters.AddWithValue("@bulan", ComboBox1.SelectedIndex + 1)
        command.Parameters.AddWithValue("@year", CInt(TextBox1.Text))
        dataset.Clear()
        Try
            conn.Open()
            isidataset(command)
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Kas")
        dgvKasHarian.DataSource = dataset
        dgvKasHarian.DataMember = "Kas"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        panggil()

    End Sub
End Class