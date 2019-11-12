Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Imports Microsoft.Office.Interop

Public Class frmMutasi
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection(rj.getconnstr)
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDetilMutasi.ShowDialog()
    End Sub

    Sub panggil()
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "Select M.Nomutasi, M.tanggalMutasi, d.kodesparepart,s.namasparepart,d.jumlahsebelum,d.jumlahsesudah,d.jumlahsesudah-d.jumlahsebelum as selisih,d.keterangan from tmutasi M,tdmutasi d, tsparepart s where s.kodesparepart=d.kodesparepart and d.nomutasi=m.nomutasi and tanggalMutasi >= @tgl1 and tanggalMutasi <= @tgl2 order by nomutasi desc"

     
        cmd.Parameters.AddWithValue("@tgl1", dtMulai.Value)
        cmd.Parameters.AddWithValue("@tgl2", dtSampai.Value)

        dataset.Clear()
        Try
            cn.Open()
            isidataset(cmd)
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahrow.Text = dgvMutasi.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Mutasi")
        dgvMutasi.DataSource = dataset
        dgvMutasi.DataMember = "Mutasi"
    End Sub

    Private Sub frmMutasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtMulai.Value = Now.Date.AddDays(-(Now.Day) + 1)
        panggil()
    End Sub

    Private Sub dgvMutasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMutasi.CellClick
        If (e.ColumnIndex = 0) Then
            frmdetilhistorymutasi.nomutasi = dgvMutasi.Rows(e.RowIndex).Cells("nomutasi").Value()
            ' MsgBox(dgvMutasi.Rows(e.RowIndex).Cells("nomutasi").Value())
            frmdetilhistorymutasi.ShowDialog()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        panggil()
    End Sub


    Function isikendaraan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        For i As Integer = 0 To dgvMutasi.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvMutasi.Rows(i).Cells("Nomutasi").Value
            xlworksheet.Cells(counter, 2) = dgvMutasi.Rows(i).Cells("TanggalMutasi").Value
            xlworksheet.Cells(counter, 3) = dgvMutasi.Rows(i).Cells("Kodesparepart").Value
            xlworksheet.Cells(counter, 4) = dgvMutasi.Rows(i).Cells("NamaSparepart").Value
            xlworksheet.Cells(counter, 5) = dgvMutasi.Rows(i).Cells("JumlahSebelum").Value
            xlworksheet.Cells(counter, 6) = dgvMutasi.Rows(i).Cells("JumlahSesudah").Value
            xlworksheet.Cells(counter, 7) = dgvMutasi.Rows(i).Cells("Selisih").Value
            xlworksheet.Cells(counter, 8) = dgvMutasi.Rows(i).Cells("Keterangan").Value
            counter += 1
        Next


        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "Mutasi Sparepart"
        xlworksheet.Cells(3, 1) = "No Mutasi"
        xlworksheet.Cells(3, 2) = "Tanggal Mutasi"
        xlworksheet.Cells(3, 3) = "Kode Sparepart"
        xlworksheet.Cells(3, 4) = "Nama Sparepart"
        xlworksheet.Cells(3, 5) = "Jumlah Sebelum"
        xlworksheet.Cells(3, 6) = "Jumlah Sesudah"
        xlworksheet.Cells(3, 7) = "Selisih"
        xlworksheet.Cells(3, 8) = "Keterangan"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
End Class