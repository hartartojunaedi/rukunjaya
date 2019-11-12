Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Imports System.Globalization

Public Class frmDetilSetOngkosSupplierBoronganUnit
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim rjl As New rjLib
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Private Sub frmDetilSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBorongan.Text = ""
        txtHarga.Text = ""
        Try
            'Try untuk cek format tanggal bisa dilakukan
            'format tanggal
            Dim format As New DateTimeFormatInfo()
            format.ShortDatePattern = "dd-MM-yyyy"
            format.DateSeparator = "-"
            lblTgl.Text = Convert.ToDateTime(lblTgl.Text, format).ToString("dd-MMM-yyyy")
        Catch ex As Exception
            lblTgl.Text = ""
        End Try
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub

    Sub panggil()
        'cmd buat select detail isi
        Dim cmd As SqlCommand = New SqlCommand
        command = "SELECT B.NAMABARANG, B.SATUAN, DSJ.JUMLAH,DSJ.KODEBARANG,DSJ.NODO FROM TDETAILSURATJALAN DSJ, TBARANG B WHERE DSJ.KODEBARANG=B.KODEBARANG AND DSJ.NOBM=@BM AND DSJ.NOSURATJALAN=@SJ"

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
        Try
            Try
                Dim x As Double = CDbl(lblBorongan.Text)
            Catch ex As Exception
                lblBorongan.Text = "0"
            End Try
            If (CDbl(lblBorongan.Text) > 0) Then
                cmd.Connection = cn
                cn.Open()
                'Hapus isi parameter dari cmd
                cmd.Parameters.Clear()

                'Perintah update berserta dengan parameternya
                cmd.CommandText = "UPDATE TSURATJALAN SET BORONGANUNIT=@BORONGANUNIT, JUMLAHUNIT=@JUMLAH, TOTALBORONGANSUPPLIER=@TOTAL WHERE NOSURATJALAN=@SJ AND NOBM=@BM"
                cmd.Parameters.AddWithValue("@BORONGANUNIT", CDbl(txtHarga.Text))
                cmd.Parameters.AddWithValue("@JUMLAH", CInt(lblTotal.Text))
                cmd.Parameters.AddWithValue("@TOTAL", CDbl(lblBorongan.Text))
                cmd.Parameters.AddWithValue("@SJ", lblSJ.Text)
                cmd.Parameters.AddWithValue("@BM", lblBM.Text)
                cmd.ExecuteNonQuery()

                'Memasukan data ke log
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                rj.isilog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Borongan Unit", "Update Data", log)
                rj.shownotify("Data Berhasil Disimpan")
                cmd.Dispose()
                cn.Close()
                Close()
            Else
                lblBorongan.Text = ""
                MsgBox("Harga tidak boleh kosong")
            End If
        Catch ex As Exception
            cmd.Dispose()
            cn.Close()
            rj.isiErrorlog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Borongan Unit", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
        End Try

    End Sub



    Private Sub txtHarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtHarga_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHarga.KeyUp
        Try
            'Harga total borongan
            lblBorongan.Text = CDbl(lblTotal.Text) * CDbl(txtHarga.Text)
            'Format String harga borongan
            txtHarga.Text = CDbl(txtHarga.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtHarga.Select(txtHarga.Text.Length, 0)
            'Format String total borongan
            lblBorongan.Text = CDbl(lblBorongan.Text).ToString("#,#")
        Catch ex As Exception
            txtHarga.Text = ""
            lblBorongan.Text = ""
        End Try
        
    End Sub

    Private Sub txtHarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHarga.Click
        'Mengembalikan cursor ke posisi akhir
        txtHarga.Select(txtHarga.Text.Length, 0)
    End Sub


    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class