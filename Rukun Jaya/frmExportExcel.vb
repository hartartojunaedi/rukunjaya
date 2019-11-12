Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmExportExcel
    Dim con As SqlConnection
    Dim _rjcommon As New RJCommon
    Dim rlib As New rjLib
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
    Sub init()
        dtpAkhir.Value = Now.Date
        dtpAwal.Value = New Date(Now.Year, Now.Month, 1)
        con = New SqlConnection
        con.ConnectionString = _rjcommon.getconnstr()
    End Sub
    Private Sub frmExportExcel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init()
    End Sub
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "PENGELUARAN"
        xlworksheet.Cells(2, 1) = "Periode : " & dtpAwal.Value & " - " & dtpAkhir.Value
        xlworksheet.Cells(3, 1) = "No-SPK"
        xlworksheet.Cells(3, 2) = "Nopol"
        xlworksheet.Cells(3, 3) = "Tgl"
        xlworksheet.Cells(3, 4) = "Supplier"
        xlworksheet.Cells(3, 5) = "Tukang"
        xlworksheet.Cells(3, 6) = "Jenis Pekerjaan"
        xlworksheet.Cells(3, 7) = "Uraian"
        xlworksheet.Cells(3, 8) = "Qty"
        xlworksheet.Cells(3, 9) = "Satuan"
        xlworksheet.Cells(3, 10) = "Harga"
        xlworksheet.Cells(3, 11) = "Total"
        xlworksheet.Cells(3, 12) = "Keterangan"
        xlworksheet.Cells(3, 13) = "Keterangan Tambahan"
    End Sub
   
    Function isimaintance(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        Dim query As String = "select d.jumlah,k.nopol,h.tgl,t.hargaterakhir,jm.namapekerjaan ,d.keterangan,h.keterangan as kerjaan,t.namasparepart,h.tukang,h.kodemaintance    "
        query &= " from tDetailMaintance d,tmaintance h,tkendaraan k,tSparePart t,tJenisMaintance jm "
        query &= " where h.kodejenismaintance=jm.kodejenismaintance and d.kodemaintance = h.kodemaintance And h.nolambung = k.nolambung And d.kodesparepart = t.kodesparepart"
        query &= " and h.tgl BETWEEN  @from AND @to"
        query &= " order by h.tgl"
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = query
        cmd.Parameters.Add(New SqlParameter("@from", dtpAwal.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@to", dtpAkhir.Value.Date))
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader IsNot Nothing Then
            While reader.Read
                xlworksheet.Cells(counter, 1) = reader.Item("kodemaintance").ToString
                xlworksheet.Cells(counter, 2) = reader.Item("nopol").ToString
                xlworksheet.Cells(counter, 3) = reader.Item("tgl").ToString
                xlworksheet.Cells(counter, 4) = ""
                xlworksheet.Cells(counter, 5) = reader.Item("tukang").ToString
                xlworksheet.Cells(counter, 6) = reader.Item("namapekerjaan").ToString
                xlworksheet.Cells(counter, 7) = reader.Item("namasparepart").ToString
                xlworksheet.Cells(counter, 8) = reader.Item("jumlah").ToString
                xlworksheet.Cells(counter, 9) = ""
                xlworksheet.Cells(counter, 10) = reader.Item("hargaterakhir")
                xlworksheet.Cells(counter, 11) = ""
                xlworksheet.Cells(counter, 12) = reader.Item("kerjaan")
                xlworksheet.Cells(counter, 13) = reader.Item("keterangan")
                counter += 1
            End While
        End If
        con.Close()
        Return counter
    End Function
    Sub initheaderoperationalkendaraan(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "Operational Kendaraan"
        xlworksheet.Cells(2, 1) = "Periode : " & dtpAwal.Value & " - " & dtpAkhir.Value
        xlworksheet.Cells(3, 1) = "Kode Transaksi"
        xlworksheet.Cells(3, 2) = "Nopol"
        xlworksheet.Cells(3, 3) = "Tgl"
        xlworksheet.Cells(3, 4) = "Keterangan"
        xlworksheet.Cells(3, 5) = "Jumlah"
        xlworksheet.Cells(3, 6) = "Harga"
        xlworksheet.Cells(3, 7) = "Nama Sopir"
       
    End Sub
    Function isioperationalkendaraan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = con
        Dim query As String = "select ok.*,k.nopol,s.namasopir from toperationalkendaraan ok,tkendaraan k,tsopir s"
        query &= " where ok.nolambung=k.nolambung and s.kodesopir=ok.kodesopir and ok.tgltransaksi BETWEEN @from AND @to"
        query &= " order by ok.tgltransaksi asc"
        cmd.CommandText = query
        cmd.Parameters.Add(New SqlParameter("@from", dtpAwal.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@to", dtpAkhir.Value.Date))
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader IsNot Nothing Then
            While reader.Read
                xlworksheet.Cells(counter, 1) = reader.Item("kodetransaksi").ToString
                xlworksheet.Cells(counter, 2) = reader.Item("nopol").ToString
                xlworksheet.Cells(counter, 3) = reader.Item("tgltransaksi").ToString
                xlworksheet.Cells(counter, 4) = reader.Item("keterangan").ToString
                xlworksheet.Cells(counter, 5) = reader.Item("jumlah")
                xlworksheet.Cells(counter, 6) = reader.Item("harga")
                xlworksheet.Cells(counter, 7) = reader.Item("namasopir").ToString
                counter += 1
            End While
        End If
        con.Close()
        Return (counter)
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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

        Dim counter As Integer = 4
        If CheckBox1.Checked Then
            initheaderoperationalkendaraan(xlworksheet)
            counter = isioperationalkendaraan(xlworksheet, counter)
        End If
        If CheckBox2.Checked Then
            initheader(xlworksheet)
            counter = isimaintance(xlworksheet, counter)
        End If
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
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = SaveFileDialog1.FileName
        End If
    End Sub
End Class