Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmMastersopir
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim btnUbahDgv As New DataGridViewButtonColumn()
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim ds As DataSet
    Public start = 0
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
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Public Sub refreshdata()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If

        ds = New DataSet
        Dim csstring = "case status when 0 then 'sopir aktif' when 1 then 'karyawan aktif' else 'tidak aktif' end as newstatus"
        '     adapter("select kodesopir,panggilan,namasopir,alamat,isnull(rtrw,'') as rtrw,isnull(kelurahan,'') as kelurahan,isnull(kecamatan,'') as kecamatan,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk from tsopir").Fill(ds, "tsopir")
        If ComboBox1.SelectedIndex = 0 Then
            adapter("select kodesopir,panggilan,namasopir,alamat,isnull(rtrw,'') as rtrw,isnull(kelurahan,'') as kelurahan,isnull(kecamatan,'') as kecamatan,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk,convert(varchar,tgllahir,105) as tgllahir,tempatlahir from tsopir").Fill(ds, "tsopir")
        Else
            Dim cswhere = " where status=" + (ComboBox1.SelectedIndex - 1).ToString
            adapter("select kodesopir,panggilan,namasopir,alamat,isnull(rtrw,'') as rtrw,isnull(kelurahan,'') as kelurahan,isnull(kecamatan,'') as kecamatan,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk,convert(varchar,tgllahir,105) as tgllahir,tempatlahir from tsopir " & cswhere).Fill(ds, "tsopir")
        End If
        dgvsopir.DataSource = ds.Tables("tsopir")
        dgvsopir.AutoGenerateColumns = False
        conn.Close()
    End Sub

    Private Sub frmsopir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
           
            ComboBox1.SelectedIndex = 0
            refreshdata()
            'jun 17 oktober 2014
            btnUbahDgv.FlatStyle = FlatStyle.Standard
            dgvsopir.Columns.Add(btnUbahDgv)
            btnUbahDgv.Text = "Ubah"
            btnUbahDgv.Width = 45
            btnUbahDgv.HeaderText = "Ubah"
            btnUbahDgv.UseColumnTextForButtonValue = True

            btnHapusDgv.FlatStyle = FlatStyle.Standard
            dgvsopir.Columns.Add(btnHapusDgv)
            btnHapusDgv.Width = 45
            btnHapusDgv.Text = "Hapus"
            btnHapusDgv.HeaderText = "Hapus"
            btnHapusDgv.UseColumnTextForButtonValue = True
            start = 0
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim frmDetailSopir As New frmDetailSopir
        frmDetailSopir.PictureBox1.BackgroundImage = Global.RukunJaya.My.Resources.Resources.nophoto
        frmDetailSopir.dtpsopir.Value = Now
        frmDetailSopir.cmbstatus.SelectedIndex = 0
        frmDetailSopir.ShowDialog()
    End Sub


    Private Sub dgvsopir_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsopir.CellClick
       
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click, txtcaripanggil.TextChanged, txtcarinama.TextChanged, txtcarikota.TextChanged, txtcarialamat.TextChanged
        If txtcaripanggil.Text = "" And txtcarinama.Text = "" And txtcarialamat.Text = "" And txtcarikota.Text = "" Then
            refreshdata()
        Else
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            ds = New DataSet
            Dim csstring = "case status when 0 then 'sopir aktif' when 1 then 'karyawan aktif' else 'tidak aktif' end as newstatus"
            If ComboBox1.SelectedIndex = 0 Then
                adapter("select kodesopir,panggilan,namasopir,alamat,isnull(rtrw,'') as rtrw,isnull(kelurahan,'') as kelurahan,isnull(kecamatan,'') as kecamatan,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk,convert(varchar,tgllahir,105) as tgllahir,tempatlahir from tsopir where panggilan like '%" & txtcaripanggil.Text & "%' and namasopir like '%" & txtcarinama.Text & "%' and alamat like '%" & txtcarialamat.Text & "%' and kota like '%" & txtcarikota.Text & "%'").Fill(ds, "tsopir")
            Else
                Dim cswhere = " and  status=" + (ComboBox1.SelectedIndex - 1).ToString
                adapter("select kodesopir,panggilan,namasopir,alamat,isnull(rtrw,'') as rtrw,isnull(kelurahan,'') as kelurahan,isnull(kecamatan,'') as kecamatan,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk,convert(varchar,tgllahir,105) as tgllahir,tempatlahir from tsopir where panggilan like '%" & txtcaripanggil.Text & "%' and namasopir like '%" & txtcarinama.Text & "%' and alamat like '%" & txtcarialamat.Text & "%' and kota like '%" & txtcarikota.Text & "%' " & cswhere).Fill(ds, "tsopir")
            End If
            dgvsopir.DataSource = ds.Tables("tsopir")
            dgvsopir.AutoGenerateColumns = False
            conn.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgvsopir_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsopir.CellContentClick

        If e.RowIndex > -1 And e.ColumnIndex = 14 Then
            Dim id = dgvsopir.Rows(e.RowIndex).Cells(2).Value
            Dim frmDetailSopir As New frmDetailSopir
            frmDetailSopir.txtKodeSopir.ReadOnly = True
            frmDetailSopir.btnTambah.Visible = False
            frmDetailSopir.txtKodeSopir.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("kodesopir")
            frmDetailSopir.txtPanggilan.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("panggilan")
            frmDetailSopir.txtNamaSopir.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("namasopir")
            frmDetailSopir.txtAlamat.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("Alamat")
            frmDetailSopir.txtKota.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("kota")
            frmDetailSopir.txtHP.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("hp")
            frmDetailSopir.txtrtrw.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("rtrw")
            frmDetailSopir.txtKelurahan.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("kelurahan")
            frmDetailSopir.txtKecamatan.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("kecamatan")
            frmDetailSopir.txtNoID.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("noid")
            frmDetailSopir.txtTempatLahir.Text = ds.Tables("tsopir").Rows(e.RowIndex).Item("tempatlahir")
            If ds.Tables("tsopir").Rows(e.RowIndex).Item("newstatus") = "sopir aktif" Then
                frmDetailSopir.cmbstatus.SelectedIndex = 0
            ElseIf ds.Tables("tsopir").Rows(e.RowIndex).Item("newstatus") = "karyawan aktif" Then
                frmDetailSopir.cmbstatus.SelectedIndex = 1
            ElseIf ds.Tables("tsopir").Rows(e.RowIndex).Item("newstatus") = "tidak aktif" Then
                frmDetailSopir.cmbstatus.SelectedIndex = 2
            End If
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim getdate = New SqlCommand("select tglmasuk from tsopir where kodesopir ='" & ds.Tables("tsopir").Rows(e.RowIndex).Item("KodeSopir") & "' ", conn).ExecuteScalar
            frmDetailSopir.dtpsopir.Value = getdate
            Dim getdate1 = New SqlCommand("select isnull(tgllahir,'01-01-1901') from tsopir where kodesopir ='" & ds.Tables("tsopir").Rows(e.RowIndex).Item("KodeSopir") & "' ", conn).ExecuteScalar
            frmDetailSopir.dtpTglLahir.Value = getdate1
            conn.Close()
            conn.Open()
            Dim command = New SqlCommand("select count(*) from tsopir where kodesopir='" & ds.Tables("tsopir").Rows(e.RowIndex).Item("KodeSopir") & "' and  foto  is not null", conn)
            Dim jum As Integer = command.ExecuteScalar()
            conn.Close()
            If jum > 0 Then
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If
                Dim cmd = New SqlCommand("select foto from tsopir where kodesopir='" & _
                     ds.Tables("tsopir").Rows(e.RowIndex).Item("KodeSopir") & "'", conn)

                Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
                If Not imageData Is Nothing Then
                    Using ms As New MemoryStream(imageData, 0, imageData.Length)
                        ms.Write(imageData, 0, imageData.Length)
                        frmDetailSopir.PictureBox1.BackgroundImage = Image.FromStream(ms, True)
                    End Using
                End If
                conn.Close()
            Else
                frmDetailSopir.PictureBox1.BackgroundImage = Global.RukunJaya.My.Resources.Resources.nophoto

            End If
            'frmDetailSopir.dtpsopir.Value = ds.Tables("tsopir").Rows(e.RowIndex)(8)
            frmDetailSopir.ShowDialog()

        ElseIf e.RowIndex > -1 And e.ColumnIndex = 15 Then
            'jun 13 feb 2014
            Dim id = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
            ' Dim id = dgvsopir.Rows(e.RowIndex).Cells(2).Value
            Try

                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If
                    Dim cmd = New SqlCommand("delete from tsopir where kodesopir='" & id & "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    refreshdata()
                    txtcaripanggil.Text = ""
                    _rjcommon.shownotify("Data Karyawan berhasil dihapus")
                    _rjcommon.isilog(_rjcommon.getusername, id, "Master Sopir", "Hapus Data", "")
                    conn.Close()
                End If
            Catch ex As Exception
                _rjcommon.shownotify("Data Karyawan gagal dihapus")
                _rjcommon.isiErrorlog(_rjcommon.getusername, id, "Master Sopir", "Hapus Data", ex.Message)
                conn.Close()
            End Try
        End If
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
            isikaryawan(xlworksheet, counter)
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
    Function isikaryawan(xlworksheet As Excel.Worksheet, counter As Integer) As Integer
        For i As Integer = 0 To dgvsopir.Rows.Count - 1
            xlworksheet.Cells(counter, 1) = dgvsopir.Rows(i).Cells(0).Value
            xlworksheet.Cells(counter, 2) = dgvsopir.Rows(i).Cells(2).Value
            xlworksheet.Cells(counter, 3) = dgvsopir.Rows(i).Cells(1).Value
            xlworksheet.Cells(counter, 4) = dgvsopir.Rows(i).Cells(3).Value
            xlworksheet.Cells(counter, 5) = dgvsopir.Rows(i).Cells(7).Value
            xlworksheet.Cells(counter, 6) = dgvsopir.Rows(i).Cells(8).Value
            xlworksheet.Cells(counter, 7).numberformat = "@"
            xlworksheet.Cells(counter, 7) = dgvsopir.Rows(i).Cells(11).Value
            xlworksheet.Cells(counter, 8).numberformat = "@"
            xlworksheet.Cells(counter, 8) = dgvsopir.Rows(i).Cells(12).Value
            counter += 1
        Next
                

        Return (counter)
    End Function
    Sub initheader(xlworksheet As Excel.Worksheet)
        xlworksheet.Cells(1, 1) = "MASTER KARYAWAN"
        xlworksheet.Cells(3, 1) = "Kode"
        xlworksheet.Cells(3, 2) = "Nama"
        xlworksheet.Cells(3, 3) = "Panggilan"
        xlworksheet.Cells(3, 4) = "Alamat"
        xlworksheet.Cells(3, 5) = "Kota"
        xlworksheet.Cells(3, 6) = "HP"
        xlworksheet.Cells(3, 7) = "Tanggal Masuk"
        xlworksheet.Cells(3, 8) = "Tanggal Lahir"
        'xlworksheet.Range("G:G").NumberFormat = "dd-mm-yyyy"
    End Sub

End Class
