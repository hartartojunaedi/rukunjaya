Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Imports System.Globalization

Public Class frmDetilSetOngkosSupplierBorongan
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim rjl As New rjLib
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Private Sub frmDetilSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = rj.getconnstr
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
        
    End Sub

    Private Sub txtHarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtHarga_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHarga.KeyUp
        Try
            'Format String harga
            txtHarga.Text = CDbl(txtHarga.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtHarga.Select(txtHarga.Text.Length, 0)
        Catch ex As Exception
            txtHarga.Text = ""
            txtHarga.Select(txtHarga.Text.Length, 0)
        End Try
    End Sub

    Private Sub btnSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As SqlCommand = New SqlCommand
        Try
            Try
                Dim x As Double = CDbl(txtHarga.Text)
            Catch ex As Exception
                txtHarga.Text = "0"
            End Try
            If (CDbl(txtHarga.Text) > 0) Then
                cmd.Connection = cn
                cn.Open()
                'Hapus isi parameter dari cmd
                cmd.Parameters.Clear()
                'Perintah update berserta dengan parameternya
                cmd.CommandText = "UPDATE TSURATJALAN SET BORONGANSUPPLIER=@BORONGANSUPPLIER, TOTALBORONGANSUPPLIER=@TOTAL WHERE NOSURATJALAN=@SJ AND NOBM=@BM"
                cmd.Parameters.AddWithValue("@BORONGANSUPPLIER", CDbl(txtHarga.Text))
                cmd.Parameters.AddWithValue("@TOTAL", CDbl(txtHarga.Text))
                cmd.Parameters.AddWithValue("@SJ", lblSJ.Text)
                cmd.Parameters.AddWithValue("@BM", lblBM.Text)
                cmd.ExecuteNonQuery()
                'Memasukan data ke log
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                rj.isilog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Borongan", "Update Data", log)
                rj.shownotify("Data Berhasil Disimpan")
                cmd.Dispose()
                cn.Close()
                Close()
            Else
                txtHarga.Text = ""
                MsgBox("Harga tidak boleh kosong")
            End If
        Catch ex As Exception
            cmd.Dispose()
            cn.Close()
            rj.isiErrorlog(rj.getusername, lblBM.Text + lblSJ.Text, "Transaksi Set Ongkos Borongan Unit", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
        End Try
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class