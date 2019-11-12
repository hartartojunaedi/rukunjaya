Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmBayarTagihan
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Public kodesupp, namasup As String
    Dim rowindex As Integer
    Sub panggil()
        clearAwal()
        dataset.Clear()
    End Sub

    Private Sub frmSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        cn.Close()
        dtpTgl.Value = Now
        panggil()
    End Sub

    Private Sub clearAwal()
        cmbCaraBayar.SelectedIndex = 0
        lblGrand.Text = ""
        lblTagihan.Text = ""
        lblSupp.Text = ""
        lblBiaya.Text = ""
        txtPotongan.Text = ""
        txtTambahan.Text = ""
        txtKeterangan.Text = ""
        dataset.Clear()
        pnlSupp.Enabled = True
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSerachSJPenagihan.ShowDialog()
    End Sub



    Private Sub btnCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        frmSerachSJPenagihan.ShowDialog()
        showDetail()
        Try
            hitungTotal()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub hitungTotal()
        Dim tambah, kurang As Double
        If txtPotongan.Text = "" Then
            kurang = 0
        Else
            kurang = CDbl(txtPotongan.Text)
        End If
        If txtTambahan.Text = "" Then
            tambah = 0
        Else
            tambah = CDbl(txtTambahan.Text)
        End If
        lblGrand.Text = CDbl(lblBiaya.Text) + tambah - kurang
        lblGrand.Text = CDbl(lblGrand.Text).ToString("#,#")
    End Sub


    Private Sub showDetail()
        dataset.Clear()
        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.Parameters.Clear()
            cmd.CommandText = "SELECT NOSURATJALAN AS SJ,NOBM AS BM,TOTALTAGIHAN AS TOTAL,POTONGAN, TAMBAHAN, TOTALTAGIHAN+TAMBAHAN-POTONGAN AS AKHIR,KETERANGAN FROM TDTAGIHAN WHERE KODETAGIHAN=@KODE"
            cmd.Parameters.AddWithValue("@KODE", lblTagihan.Text)
            adapter.SelectCommand = cmd
            adapter.Fill(dataset, "tagihan")
            dgvBM.DataSource = dataset.Tables("tagihan")
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            dataset.Dispose()
            adapter.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub txtTambahan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTambahan.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPotongan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPotongan.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtTambahan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTambahan.KeyUp
        Try
            'Format String harga borongan
            txtTambahan.Text = CDbl(txtTambahan.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtTambahan.Select(txtTambahan.Text.Length, 0)
            'Format String total borongan
            hitungTotal()
        Catch ex As Exception
            txtTambahan.Text = ""
            lblGrand.Text = ""
        End Try
    End Sub

    Private Sub txtPotongan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPotongan.KeyUp
        Try
            'Format String harga borongan
            txtPotongan.Text = CDbl(txtPotongan.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtPotongan.Select(txtPotongan.Text.Length, 0)
            'Format String total borongan
            hitungTotal()
        Catch ex As Exception
            txtPotongan.Text = ""
            lblGrand.Text = ""
        End Try
    End Sub

    Private Sub txtPotongan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPotongan.Click
        'Mengembalikan cursor ke posisi akhir
        txtPotongan.Select(txtPotongan.Text.Length, 0)
    End Sub

    Private Sub txtTambahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTambahan.Click
        'Mengembalikan cursor ke posisi akhir
        txtTambahan.Select(txtTambahan.Text.Length, 0)
    End Sub

    Private Sub btnSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If dgvBM.Rows.Count > 0 Then
            Dim cmd As SqlCommand = New SqlCommand
            Try
                cn.Open()
                cmd.Connection = cn
                cmd.Parameters.Clear()
                cmd.CommandText = "UPDATE THTAGIHAN SET STATUS=1, KETERANGAN=@KET, POTONGAN=@POTONGAN, TAMBAHAN=@TAMBAHAN, TOTALDITERIMA=@TOTAL, TGLBAYAR=@TGL,CARABAYAR=@CARA WHERE KODETAGIHAN=@KODE"
                cmd.Parameters.AddWithValue("@KET", txtKeterangan.Text)
                Dim tambah, kurang As Double
                If txtPotongan.Text = "" Then
                    kurang = 0
                Else
                    kurang = CDbl(txtPotongan.Text)
                End If
                If txtTambahan.Text = "" Then
                    tambah = 0
                Else
                    tambah = CDbl(txtTambahan.Text)
                End If
                cmd.Parameters.AddWithValue("@POTONGAN", kurang)
                cmd.Parameters.AddWithValue("@TAMBAHAN", tambah)
                cmd.Parameters.AddWithValue("@TOTAL", CDbl(lblGrand.Text))
                cmd.Parameters.AddWithValue("@TGL", dtpTgl.Value)
                'Keterangan Cara Bayar
                '0=Cash
                '1=Transfer
                '2=Giro
                '3=Cek
                '4=Transfer
                cmd.Parameters.AddWithValue("@CARA", cmbCaraBayar.SelectedIndex)
                cmd.Parameters.AddWithValue("@KODE", lblTagihan.Text)
                cmd.ExecuteNonQuery()

                'Memasukan data ke log
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                'rj.isilog(rj.getusername, txtTagihan.Text, "Buat Tagihan", "Insert Data", log)
                rj.shownotify("Data Berhasil Disimpan")
                cn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cn.Close()
                dataset.Dispose()
                cmd.Dispose()
                panggil()
            End Try
        End If
    End Sub

    Private Sub cmbCaraBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCaraBayar.TextChanged
        'MsgBox(cmbCaraBayar.SelectedIndex)
    End Sub
End Class