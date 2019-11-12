
Imports System.Data.SqlClient

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports RjLibrary
Imports Microsoft.Office.Interop

Public Class frmLaporanMutasiKeluar
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim dataset As New DataSet

    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Private Sub frmLaporanMutasiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = Now.Date.AddDays(-(Now.Day) + 1)
        End If
    End Sub

    Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
        'select nospk,tgl,namakaryawan,namasparepart,jumlah, noseri, d.keterangan from THKeluar h, tdMutasiKeluar d, tSparePart s where h.id=d.id and d.kodesparepart=s.kodesparepart
        Dim ds As New DataSet
        Dim rj As New RJCommon
        Dim cn As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim adap, adap1 As New SqlDataAdapter
        Try
            cn = New SqlConnection
            cn.ConnectionString = rj.getconnstr


            cmd1.Connection = cn
            cmd1.Parameters.Clear()
            ds.Tables.Clear()
            cmd1.CommandText = "select h.id,nospk,tgl,namakaryawan,namasparepart,jumlah, noseri, d.keterangan from THKeluar h, tdMutasiKeluar d, tSparePart s where h.id=d.id and d.kodesparepart=s.kodesparepart and h.tgl>=@tglawal and h.tgl<=@tglakhir"
            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)


            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "Mutasi")
            cn.Close()


            'jun 10 feb 2015
            If ds.Tables("Mutasi").Rows.Count > 0 Then
                Dim rep As New laporanMutasiKeluar
                rep.SetDataSource(ds.Tables("Mutasi"))
                'jun 10 feb 2015
                rep.SetParameterValue("Mulai", dtpAwalPeriode.Value.ToString("dd-MM-yyyy"))
                rep.SetParameterValue("Sampai", dtpAKhirPeriode.Value.ToString("dd-MM-yyyy"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep

                frmlaporan.ShowDialog()
            Else
                rj.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try




    End Sub

    Sub panggil()

        Dim cmd1 As New SqlCommand
        cmd1.Connection = conn
        cmd1.Parameters.Clear()
        ' ds.Tables.Clear()
        cmd1.CommandText = "select h.id,nospk,tgl,namakaryawan,namasparepart,jumlah, noseri, d.keterangan,isnull(k.nopol,'-') as nopol from  tdMutasiKeluar d, tSparePart s,THKeluar h left join tkendaraan k on k.nolambung=h.nolambung where h.id=d.id and d.kodesparepart=s.kodesparepart and h.tgl>=@tglawal and h.tgl<=@tglakhir order by h.id"
        cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
        cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)
        dataset.Clear()
        Try
            conn.Open()
            adapter.SelectCommand = cmd1
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "keluar")
            dgvMutasiKeluar.DataSource = dataset
            dgvMutasiKeluar.DataMember = "keluar"
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            panggil()
            If dataset.Tables("keluar").Rows.Count > 0 Then



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
            MsgBox(ex.Message & " button clicked")
        End Try
    End Sub

    Function isikaryawan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        Dim nospk As String = ""
        For i As Integer = 0 To dgvMutasiKeluar.Rows.Count - 1
           If nospk = dgvMutasiKeluar.Rows(i).Cells(0).Value Then
                xlworksheet.Cells(counter, 1) = ""
                xlworksheet.Cells(counter, 2) = ""
                xlworksheet.Cells(counter, 3) = ""
                xlworksheet.Cells(counter, 4) = ""
                xlworksheet.Cells(counter, 5) = ""
            Else
                xlworksheet.Cells(counter, 1) = dgvMutasiKeluar.Rows(i).Cells(0).Value
                xlworksheet.Cells(counter, 2) = dgvMutasiKeluar.Rows(i).Cells(1).Value
                nospk = dgvMutasiKeluar.Rows(i).Cells(0).Value
                xlworksheet.Cells(counter, 3) = dgvMutasiKeluar.Rows(i).Cells(2).Value
                xlworksheet.Cells(counter, 4) = dgvMutasiKeluar.Rows(i).Cells(3).Value
                xlworksheet.Cells(counter, 5) = dgvMutasiKeluar.Rows(i).Cells(8).Value


            End If

            xlworksheet.Cells(counter, 6) = dgvMutasiKeluar.Rows(i).Cells(4).Value
            xlworksheet.Cells(counter, 7) = dgvMutasiKeluar.Rows(i).Cells(5).Value
            xlworksheet.Cells(counter, 8) = dgvMutasiKeluar.Rows(i).Cells(6).Value
            xlworksheet.Cells(counter, 9) = dgvMutasiKeluar.Rows(i).Cells(7).Value
            counter += 1
        Next


        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MUTASI BARANG KELUAR"
        xlworksheet.Cells(3, 1) = "ID"
        xlworksheet.Cells(3, 2) = "No SPK"
        xlworksheet.Cells(3, 3) = "Tanggal"

        xlworksheet.Cells(3, 4) = "Nama Karyawan"
        xlworksheet.Cells(3, 5) = "Nopol"
        xlworksheet.Cells(3, 6) = "Nama Sparepart"
        xlworksheet.Cells(3, 7) = "Jumlah"
        xlworksheet.Cells(3, 8) = "No Seri"
        xlworksheet.Cells(3, 9) = "Keterangan"
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
End Class