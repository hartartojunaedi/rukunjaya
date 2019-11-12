Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmMasterKendaraan
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    
    Sub panggil()
        Dim command As String
        command = "Select nolambung,nopol,merek,nomesin,pemilik,kodeperusahaan,tahun,namajenis,norangka,nobpkb from tkendaraan,tjeniskendaraan where  kodejenis=jenis and nopol like '%" & txtnopol.Text & "%' and nomesin like '%" & txtnomesin.Text & "%'"

        ds.Clear()
        Try
            conn.Open()
            isidataset(New SqlCommand(command, conn))
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "Kendaraan")
        dgvKendaraan.DataSource = ds
        dgvKendaraan.DataMember = "Kendaraan"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub

    

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        frmDetailMasterKendaraan.lblMode.Text = "Tambah"
        frmDetailMasterKendaraan.nolambung = ""
        frmDetailMasterKendaraan.Show()
    End Sub

    Private Sub dgvKendaraan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick
        'MsgBox(e.ColumnIndex)
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then


            If (e.ColumnIndex = 1) Then 'hapus then
                If (MessageBox.Show("Apakah yakin akan menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) _
                    = Windows.Forms.DialogResult.Yes) Then
                    'hapus data sesuai dengan data yang dipilih
                    Try

                        conn.Open()
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        cmd.CommandText = "delete from tkendaraan where nolambung=@nolambung"
                        cmd.Parameters.AddWithValue("@nolambung", dgvKendaraan.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()
                        'MsgBox("data berhasil dihapus")
                        'jun 18 oktober 2014
                        _rjcommon.shownotify("Data Kendaraaan Berhasil Dihapus")
                        conn.Close()
                        _rjcommon.isilog(_rjcommon.getusername, dgvKendaraan.Rows(e.RowIndex).Cells(2).Value, "Master Kendaraan", "Hapus Data", "")

                        panggil()
                    Catch ex As Exception
                        'jun 10-12-2014
                        MessageBox.Show("Data Tidak Berhasil Dihapus")
                        conn.Close()
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvKendaraan.Rows(e.RowIndex).Cells(2).Value, "Master Kendaraan", "Hapus Data", ex.Message)

                    End Try

                End If
            ElseIf (e.ColumnIndex = 0) Then 'ubah
                frmDetailMasterKendaraan.lblMode.Text = "Ubah"
                frmDetailMasterKendaraan.nolambung = dgvKendaraan.Rows(e.RowIndex).Cells(2).Value
                frmDetailMasterKendaraan.Show()
            End If
        End If
    End Sub

    Private Sub frmMasterKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil()
    End Sub


    Private Sub txtnomesin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomesin.KeyUp
        panggil()
    End Sub

   
    Private Sub txtnopol_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnopol.KeyUp
        panggil()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        panggil()
    End Sub

    Private Sub dgvKendaraan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellContentClick

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

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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
        For i As Integer = 0 To dgvKendaraan.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvKendaraan.Rows(i).Cells(2).Value
            xlworksheet.Cells(counter, 2) = dgvKendaraan.Rows(i).Cells(3).Value
            xlworksheet.Cells(counter, 3) = dgvKendaraan.Rows(i).Cells(4).Value
            xlworksheet.Cells(counter, 4) = dgvKendaraan.Rows(i).Cells(5).Value
            xlworksheet.Cells(counter, 5) = dgvKendaraan.Rows(i).Cells(6).Value
            xlworksheet.Cells(counter, 6) = dgvKendaraan.Rows(i).Cells(8).Value
            xlworksheet.Cells(counter, 7) = dgvKendaraan.Rows(i).Cells(9).Value
            counter += 1
        Next


        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MASTER KENDARAAN"
        xlworksheet.Cells(3, 1) = "No Lambung"
        xlworksheet.Cells(3, 2) = "Nopol"
        xlworksheet.Cells(3, 3) = "Merek"
        xlworksheet.Cells(3, 4) = "No. Mesin"
        xlworksheet.Cells(3, 5) = "Pemilik"
        xlworksheet.Cells(3, 6) = "Tahun"
        xlworksheet.Cells(3, 7) = "Jenis"
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class