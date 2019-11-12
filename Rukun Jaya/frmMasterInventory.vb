Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Imports Microsoft.Office.Interop

Public Class frmMasterInventory
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
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
    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmDetailInventory.TxtKodeSP.Enabled = True

        ' frmDetailInventory.BtnSimpan.Enabled = True
        ' frmDetailInventory.btnClear.Enabled = False
        frmDetailInventory.insert = True
        frmDetailInventory.ShowDialog()
        '  panggil()
    End Sub

    Private Sub frmMasterInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub

    Sub panggil()
        '   MessageBox.Show(txtSearchKode.Text)
        ' MessageBox.Show(txtSearchNamaSP.Text)
        command = "Select kodesparepart,kartustok,namasparepart,hargaterakhir,stock,keterangan from tsparepart where kodesparepart like '%" & txtSearchKode.Text & "%' and namasparepart like '%" & txtSearchNamaSP.Text & "%' and kartustok like '%" & TextBox2.Text & "%'"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "sparepart")
        dgvMasterInventory.DataSource = dataset
        dgvMasterInventory.DataMember = "sparepart"
    End Sub


    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMasterInventory.CellClick
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 1) Then
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then

                    Try
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        Dim log As String = "nama sparepart = " & dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value & vbCrLf & " harga terakhir = " & dgvMasterInventory.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " Stock = " & dgvMasterInventory.Rows(e.RowIndex).Cells(4).Value & vbCrLf & " Keterangan = " & dgvMasterInventory.Rows(e.RowIndex).Cells(5).Value
                 

                        cmd.Connection = cn
                        cmd.CommandText = "delete from tsparepart where kodesparepart=@kode "
                        cmd.Parameters.AddWithValue("@kode", dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()
                        'jun 13 feb 2015
                        rj.isilog(rj.getusername, dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Inventory", "Hapus Data", "")

                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Inventory", "Hapus Data", ex.Message)
                        rj.shownotifyerror("Data Gagal Dihapus")
                        cn.Close()
                    End Try

                    cn.Close()
                    panggil()
                End If
            End If

            If (e.ColumnIndex = 0) Then
                '  frmDetailInventory.BtnSimpan.Enabled = False
                ' frmDetailInventory.btnClear.Enabled = True
                frmDetailInventory.insert = False


                frmDetailInventory.TxtKodeSP.Text = dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value
                frmDetailInventory.TextBox1.Text = dgvMasterInventory.Rows(e.RowIndex).Cells(3).Value

                frmDetailInventory.TxtNamaSparepart.Text = dgvMasterInventory.Rows(e.RowIndex).Cells(4).Value
                frmDetailInventory.txtHargaTerakhir.Text = FormatCurrency(dgvMasterInventory.Rows(e.RowIndex).Cells(5).Value, 0)
                frmDetailInventory.txtStock.Maximum = Decimal.MaxValue
                'jun 13  feb 2015
                'untuk mengatasi stock minus
                frmDetailInventory.txtStock.Value = IIf(dgvMasterInventory.Rows(e.RowIndex).Cells(6).Value < 0, 0, dgvMasterInventory.Rows(e.RowIndex).Cells(6).Value)
                frmDetailInventory.TxtKeterangan.Text = dgvMasterInventory.Rows(e.RowIndex).Cells(7).Value
                frmDetailInventory.TxtKodeSP.Enabled = False


                frmDetailInventory.ShowDialog()

            End If
            ' panggil()
        End If
    End Sub


    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click, txtSearchNamaSP.TextChanged, txtSearchKode.TextChanged, TextBox2.TextChanged
        panggil()
    End Sub

    Private Sub dgvMasterInventory_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMasterInventory.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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
            isiinventory(xlworksheet, counter)
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

    Function isiinventory(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        For i As Integer = 0 To dgvMasterInventory.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvMasterInventory.Rows(i).Cells(3).Value
            xlworksheet.Cells(counter, 2) = dgvMasterInventory.Rows(i).Cells(2).Value.ToString()
            xlworksheet.Cells(counter, 3) = dgvMasterInventory.Rows(i).Cells(4).Value
            xlworksheet.Cells(counter, 4) = dgvMasterInventory.Rows(i).Cells(6).Value
            xlworksheet.Cells(counter, 5) = dgvMasterInventory.Rows(i).Cells(7).Value

            counter += 1
        Next


        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MASTER Sparepart"
        xlworksheet.Cells(3, 1) = "Kartu Stok"
        xlworksheet.Cells(3, 2) = "Kode"
        xlworksheet.Cells(3, 3) = "Nama"
        xlworksheet.Cells(3, 4) = "Jumlah"
        xlworksheet.Cells(3, 5) = "Keterangan"
    End Sub

End Class