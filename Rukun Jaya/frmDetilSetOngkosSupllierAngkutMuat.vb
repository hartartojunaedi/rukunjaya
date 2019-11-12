Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Imports System.Globalization

Public Class frmDetilSetOngkosSupllierAngkutMuat
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim rjl As New rjLib
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Dim rowIndex As Integer
    Dim colIndex As Integer
    Private Sub frmDetilSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'format String harga
            lblBorongan.Text = CDbl(lblBorongan.Text).ToString("#,#")
            'format tanggal
            Dim format As New DateTimeFormatInfo()
            format.ShortDatePattern = "dd-MM-yyyy"
            format.DateSeparator = "-"
            lblTgl.Text = Convert.ToDateTime(lblTgl.Text, format).ToString("dd-MMM-yyyy")
        Catch ex As Exception
            lblBorongan.Text = "0"
        End Try
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub

    Sub panggil()
        'cmd buat select detail isi
        Dim cmd As SqlCommand = New SqlCommand
        command = "SELECT B.NAMABARANG, B.SATUAN, DSJ.JUMLAH,DSJ.KODEBARANG,DSJ.NODO,ONGKOS, 0.000 AS TOTAL FROM TDETAILSURATJALAN DSJ, TBARANG B WHERE DSJ.KODEBARANG=B.KODEBARANG AND DSJ.NOBM=@BM AND DSJ.NOSURATJALAN=@SJ"

        'cmd buat dapat Jumlah total barang
        Dim cmdSum As SqlCommand = New SqlCommand
        Dim commandsum As String = "SELECT SUM(JUMLAH) FROM TDETAILSURATJALAN DSJ WHERE DSJ.NOBM=@BM AND DSJ.NOSURATJALAN=@SJ"
        dataset.Clear()
        Try
            cn.Open()
            'Inisialisi Commad untuk select detail surat jalan
            cmd.Connection = cn
            cmd.CommandText = command

            'Isi paramater dari select detail surat jalan
            cmd.Parameters.AddWithValue("@BM", lblBM.Text)
            cmd.Parameters.AddWithValue("@SJ", lblSJ.Text)
            adapter.SelectCommand = cmd

            'Memasukan data hasil select ke dataset
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "suratjalan")
            'Menampilkan data ke gridview
            dgvSetOngkos.DataSource = dataset
            dgvSetOngkos.DataMember = "suratjalan"

            'Inisialisasi command untuk sum surat jalan
            cmdSum.Connection = cn
            cmdSum.CommandText = commandsum

            'Isi paramater dari select sum detail surat jalan
            cmdSum.Parameters.AddWithValue("@BM", lblBM.Text)
            cmdSum.Parameters.AddWithValue("@SJ", lblSJ.Text)

            'Mendapatkan data dari hasil sum
            lblTotal.Text = cmdSum.ExecuteScalar.ToString

        Catch ex As Exception
            rj.shownotifyerror(ex.Message)
        Finally
            'Hapus semua komponen yang tidak dipakai lagi
            cmd.Dispose()
            adapter.Dispose()
            dataset.Dispose()
            cmdSum.Dispose()
            cn.Close()
        End Try
    End Sub



    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = cn
        Try
            Try
                Dim x As Double = CDbl(lblBorongan.Text)
            Catch ex As Exception
                lblBorongan.Text = "0"
            End Try
            If (CDbl(lblBorongan.Text) > 0) Then
                cn.Open()
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                For j = 0 To dgvSetOngkos.RowCount - 1
                    cmd.Parameters.Clear()
                    'Perintah update detailsuratjalan beserta parameternya
                    cmd.CommandText = "UPDATE TDETAILSURATJALAN SET ONGKOS=@ONGKOS WHERE KODEBARANG=@KDBARANG AND NOSURATJALAN=@SJ AND NOBM=@BM AND NODO=@DO"
                    cmd.Parameters.AddWithValue("@ONGKOS", CDbl(dgvSetOngkos.Rows(j).Cells("HARGA").Value))
                    cmd.Parameters.AddWithValue("@KDBARANG", (dgvSetOngkos.Rows(j).Cells("KODEBARANG").Value))
                    cmd.Parameters.AddWithValue("@SJ", lblSJ.Text)
                    cmd.Parameters.AddWithValue("@BM", lblBM.Text)
                    cmd.Parameters.AddWithValue("@DO", dgvSetOngkos.Rows(j).Cells("NODO").Value)
                    cmd.ExecuteNonQuery()

                Next


                'Hapus isi parameter dari cmd
                cmd.Parameters.Clear()
                'Perintah update untuk surat jalan berserta dengan parameternya
                cmd.CommandText = "UPDATE TSURATJALAN SET TOTALBORONGANSUPPLIER=@TOTAL WHERE NOSURATJALAN=@SJ AND NOBM=@BM"
                cmd.Parameters.AddWithValue("@TOTAL", CDbl(lblBorongan.Text))
                cmd.Parameters.AddWithValue("@SJ", lblSJ.Text)
                cmd.Parameters.AddWithValue("@BM", lblBM.Text)
                cmd.ExecuteNonQuery()


                rj.isilog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Angkut Per Muat", "Update Data", "")
                rj.shownotify("Data Berhasil Disimpan")
                'jun 26 jan 2015
                cmd.Dispose()
                cn.Close()
                Close()
            Else
                lblBorongan.Text = ""
                MsgBox("Harga harus diisi")
            End If
        Catch ex As Exception
            cmd.Dispose()
            cn.Close()
            rj.isiErrorlog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Angkut Per Muat", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
        End Try

    End Sub


    Private Sub dgvSetOngkos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSetOngkos.EditingControlShowing
        If dgvSetOngkos.Columns(dgvSetOngkos.CurrentCell.ColumnIndex).Name = "HARGA" Then
            colIndex = dgvSetOngkos.CurrentCell.ColumnIndex
            rowIndex = dgvSetOngkos.CurrentCell.RowIndex
            'Menambahkan Event untuk pengecekan numeric
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            RemoveHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp
            RemoveHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            AddHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp
            AddHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click
        End If
    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            'Format String Untuk Harga
            DirectCast(sender, TextBox).Text = CDbl(DirectCast(sender, TextBox).Text).ToString("#,#")
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            'Melakukan pengisian data ke column total
            dgvSetOngkos.Rows(rowIndex).Cells("TOTAL").Value = CDbl(dgvSetOngkos.Rows(rowIndex).Cells("JUMLAH").Value) * CDbl(DirectCast(sender, TextBox).Text)
            hitungGrandTotal()
        Catch ex As Exception
            DirectCast(sender, TextBox).Text = "0"
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            dgvSetOngkos.Rows(rowIndex).Cells("TOTAL").Value = CDbl(dgvSetOngkos.Rows(rowIndex).Cells("JUMLAH").Value) * CDbl(DirectCast(sender, TextBox).Text)
            hitungGrandTotal()
            lblBorongan.Text = "0"
        End Try
    End Sub

    Private Sub TextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Memindahkan Posisi kursor ke paling belakang
        DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
    End Sub


    Private Sub hitungGrandTotal()
        Dim grandTotal As Double = 0
        For j = 0 To dgvSetOngkos.RowCount - 1
            grandTotal += dgvSetOngkos.Rows(j).Cells("TOTAL").Value
        Next
        Try
            lblBorongan.Text = grandTotal.ToString("#,#")
        Catch ex As Exception
            lblBorongan.Text = "0"
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class