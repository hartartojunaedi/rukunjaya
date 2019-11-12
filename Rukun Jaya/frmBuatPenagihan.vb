Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmBuatPenagihan
    Dim dataset As New DataSet
    Public datasetTagihan As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Public kodesupp, namasup As String
    Dim rowindex As Integer
    Sub panggil()
        clearAwal()
        clearsj()
        dataset.Clear()
        datasetTagihan.Clear()
        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn

            cmd.CommandText = "SELECT KODESUPPLIER,NAMASUPPLIER FROM TSUPPLIER"
            adapter.SelectCommand = cmd
            adapter.Fill(dataset, "supplier")
            cmbSupplier.DataSource = dataset.Tables("supplier")
            cmbSupplier.ValueMember = "kodesupplier"
            cmbSupplier.DisplayMember = "namasupplier"
            cmbSupplier.SelectedIndex = 0


            cmd.CommandText = "SELECT NOSURATJALAN AS SJ,NOBM AS BM,TOTALBORONGANSUPPLIER AS TOTAL,0.0 AS POTONGAN,0.0 AS TAMBAHAN,0.0 AS AKHIR,'' AS KETERANGAN,'Delete' as Hapus FROM tSURATJALAN WHERE 1=2"
            adapter.SelectCommand = cmd
            adapter.Fill(datasetTagihan, "tagihan")
            dgvBM.DataSource = datasetTagihan.Tables("tagihan")

            cn.Close()
            pnlSJ.Enabled = False
            pnlSupp.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            dataset.Dispose()
            adapter.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub frmSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        cn.Close()
        dtpTgl.Value = Now
        panggil()
    End Sub

    Private Sub clearAwal()
        txtKwintasi.Text = ""
        lblGrand.Text = ""
        txtTagihan.Text = ""
        datasetTagihan.Clear()
        dataset.Clear()
        pnlSJ.Enabled = False
        pnlSupp.Enabled = True
    End Sub

    Private Sub clearsj()
        lblBM.Text = ""
        lblSJ.Text = ""
        lblBiaya.Text = ""
        txtPotongan.Text = ""
        txtTambahan.Text = ""
        txtKeterangan.Text = ""
        lblBiayaAkhir.Text = ""
    End Sub


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panggil()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If lblBM.Text <> "" And lblSJ.Text <> "" Then
            Dim nr As DataRow = datasetTagihan.Tables("tagihan").NewRow
            nr.Item("SJ") = lblSJ.Text
            nr.Item("BM") = lblBM.Text
            nr.Item("TOTAL") = CDbl(lblBiaya.Text)
            Try
                nr.Item("POTONGAN") = CDbl(txtPotongan.Text)
            Catch ex As Exception
                nr.Item("POTONGAN") = 0
            End Try

            Try
                nr.Item("TAMBAHAN") = CDbl(txtTambahan.Text)
            Catch ex As Exception
                nr.Item("TAMBAHAN") = 0
            End Try

            Try
                'nr.Item("AKHIR") = CDbl(lblBiaya.Text) + nr.Item("TAMBAHAN") - nr.Item("POTONGAN")
                nr.Item("AKHIR") = CDbl(lblBiayaAkhir.Text)
            Catch ex As Exception

            End Try

            datasetTagihan.Tables("tagihan").Rows.Add(nr)
            clearsj()
        End If
        hitungGrandTotal()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        frmSerachSJBuatPenagihan.ShowDialog()
        hitungBiayaAkhir()
    End Sub

    Private Sub hitungGrandTotal()
        Dim grandTotal As Double = 0
        For j = 0 To dgvBM.RowCount - 1
            Try
                grandTotal += dgvBM.Rows(j).Cells("subtotal").Value
            Catch ex As Exception
                grandTotal += 0
            End Try
        Next
        Try
            lblGrand.Text = grandTotal.ToString("#,#")
        Catch ex As Exception
            lblGrand.Text = "0"
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        panggil()
        txtTagihan.Focus()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If (txtTagihan.Text <> "") And (LblValidator.Text = "") And (txtKwintasi.Text <> "") Then
                kodesupp = cmbSupplier.SelectedValue
                namasup = cmbSupplier.Text
                pnlSJ.Enabled = True
                pnlSupp.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub hitungBiayaAkhir()
        Dim biaya, potongan, tambahan As Double
        Try
            potongan = CDbl(txtPotongan.Text)
        Catch ex As Exception
            potongan = 0
        End Try
        Try
            tambahan = CDbl(txtTambahan.Text)
        Catch ex As Exception
            tambahan = 0
        End Try
        Try
            biaya = CDbl(lblBiaya.Text)
        Catch ex As Exception
            biaya = 0
        End Try

        lblBiayaAkhir.Text = (biaya + tambahan - potongan).ToString("#,#")
    End Sub

    

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTambahan.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTambahan.KeyUp
        Try
            'Format String Tambahan
            txtTambahan.Text = CDbl(txtTambahan.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtTambahan.Select(txtTambahan.Text.Length, 0)
            hitungBiayaAkhir()
        Catch ex As Exception
            txtTambahan.Text = ""
            hitungBiayaAkhir()
        End Try
    End Sub

    Private Sub txtPotongan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPotongan.KeyPress
        'Pengecekan number dan backspace
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPotongan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPotongan.KeyUp
        Try
            'Format String Potongan
            txtPotongan.Text = CDbl(txtPotongan.Text).ToString("#,#")
            'Mengembalikan cursor ke posisi akhir
            txtPotongan.Select(txtPotongan.Text.Length, 0)
            hitungBiayaAkhir()
        Catch ex As Exception
            txtPotongan.Text = ""
            hitungBiayaAkhir()
        End Try
    End Sub

    Private Sub dgvBM_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            Try
                If (dgvBM.Columns(e.ColumnIndex).Name = "hapus" And e.RowIndex >= 0) Then
                    datasetTagihan.Tables("tagihan").Rows(e.RowIndex).Delete()
                    hitungGrandTotal()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'MsgBox("sapi")
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvBM.CurrentCell = dgvBM.Item(0, 0)
            e.Handled = True
            SendKeys.Send(Keys.Tab)
        End If
    End Sub

    Private Sub TextBox_KeyUp_Potongan(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try

            'Format String Untuk Harga
            DirectCast(sender, TextBox).Text = CDbl(DirectCast(sender, TextBox).Text).ToString("#,#")
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            'Melakukan pengisian data ke column subtotal
            Dim tambahan, potongan As Double
            Try
                tambahan = CDbl(dgvBM.Rows(rowindex).Cells("Tambahan").Value)
            Catch ex As Exception
                tambahan = 0
            End Try
            Try
                potongan = CDbl(DirectCast(sender, TextBox).Text)
            Catch ex As Exception
                potongan = 0
                DirectCast(sender, TextBox).Text = "0"
                'Memindahkan Posisi kursor ke paling belakang
                DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            End Try
            'dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) - CDbl(DirectCast(sender, TextBox).Text) + CDbl(dgvBM.Rows(rowindex).Cells("Tambahan").Value)
            dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) + tambahan - potongan
            hitungGrandTotal()
        Catch ex As Exception
            DirectCast(sender, TextBox).Text = "0"
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            Try
                dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) - 0 + CDbl(dgvBM.Rows(rowindex).Cells("Tambahan").Value)
            Catch exx As Exception
                dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) - 0 + 0
            End Try
            hitungGrandTotal()
        End Try
    End Sub


    Private Sub TextBox_KeyUp_Tambahan(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            'Format String Untuk Harga
            DirectCast(sender, TextBox).Text = CDbl(DirectCast(sender, TextBox).Text).ToString("#,#")
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            'Melakukan pengisian data ke column subtotal
            Dim tambahan, potongan As Double
            Try
                tambahan = CDbl(DirectCast(sender, TextBox).Text)
            Catch ex As Exception
                tambahan = 0
                DirectCast(sender, TextBox).Text = "0"
                'Memindahkan Posisi kursor ke paling belakang
                DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            End Try
            Try
                potongan = CDbl(dgvBM.Rows(rowindex).Cells("Potongan").Value)
            Catch ex As Exception
                potongan = 0
            End Try

            'dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) + CDbl(DirectCast(sender, TextBox).Text) - CDbl(dgvBM.Rows(rowindex).Cells("Potongan").Value)
            dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) + tambahan + potongan
            hitungGrandTotal()
        Catch ex As Exception
            DirectCast(sender, TextBox).Text = "0"
            'Memindahkan Posisi kursor ke paling belakang
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
            Try
                dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) + 0 - CDbl(dgvBM.Rows(rowindex).Cells("Potongan").Value)
            Catch exx As Exception
                dgvBM.Rows(rowindex).Cells("subtotal").Value = CDbl(dgvBM.Rows(rowindex).Cells("biaya").Value) + 0 - 0
            End Try
            hitungGrandTotal()
        End Try
    End Sub


    Private Sub TextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Memindahkan Posisi kursor ke paling belakang
        DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).Text.Length, 0)
    End Sub

    Private Sub dgvBM_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvBM.EditingControlShowing
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        RemoveHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp_Potongan
        RemoveHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click
        RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        RemoveHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp_Tambahan
        RemoveHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click


        RemoveHandler CType(e.Control, TextBox).KeyDown, AddressOf TextBox_KeyDown
        If dgvBM.Columns(dgvBM.CurrentCell.ColumnIndex).Name = "Potongan" Then
            rowindex = dgvBM.CurrentCell.RowIndex
            'Menambahkan Event untuk pengecekan numeric
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            AddHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp_Potongan
            AddHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click

            AddHandler CType(e.Control, TextBox).KeyDown, AddressOf TextBox_KeyDown
        End If

        If dgvBM.Columns(dgvBM.CurrentCell.ColumnIndex).Name = "Tambahan" Then
            rowindex = dgvBM.CurrentCell.RowIndex
            'Menambahkan Event untuk pengecekan numeric            
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            AddHandler CType(e.Control, TextBox).KeyUp, AddressOf TextBox_KeyUp_Tambahan
            AddHandler CType(e.Control, TextBox).Click, AddressOf TextBox_Click

            AddHandler CType(e.Control, TextBox).KeyDown, AddressOf TextBox_KeyDown
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If dgvBM.Rows.Count > 0 Then
            Dim cmd As SqlCommand = New SqlCommand
            Try
                cn.Open()
                cmd.Connection = cn
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO THTAGIHAN(KODETAGIHAN,KODESUPPLIER,STATUS,TOTALTAGIHAN,TGL,NOKWINTANSI) VALUES (@KDTAG,@KDSUPP,0,@TOTAL,@TGL,@NOKW)"
                cmd.Parameters.AddWithValue("@KDTAG", txtTagihan.Text)
                cmd.Parameters.AddWithValue("@KDSUPP", kodesupp)
                cmd.Parameters.AddWithValue("@TOTAL", CDbl(lblGrand.Text))
                cmd.Parameters.AddWithValue("@TGL", dtpTgl.Value.Date)
                cmd.Parameters.AddWithValue("@NOKW", txtKwintasi.Text)
                cmd.ExecuteNonQuery()

                For i As Integer = 0 To datasetTagihan.Tables("tagihan").Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "UPDATE TSURATJALAN SET STATUS=2 WHERE NOBM=@BM AND NOSURATJALAN=@SJ"
                    cmd.Parameters.AddWithValue("@BM", datasetTagihan.Tables("tagihan").Rows(i).Item("BM"))
                    cmd.Parameters.AddWithValue("@SJ", datasetTagihan.Tables("tagihan").Rows(i).Item("SJ"))
                    cmd.ExecuteNonQuery()

                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO TDTAGIHAN(KODETAGIHAN,NOBM,NOSURATJALAN,TOTALTAGIHAN,POTONGAN,TAMBAHAN,KETERANGAN) VALUES(@KODETAG,@BM,@SJ,@TOTAL,@POTONGAN,@TAMBAHAN,@KET)"
                    cmd.Parameters.AddWithValue("@KODETAG", txtTagihan.Text)
                    cmd.Parameters.AddWithValue("@BM", datasetTagihan.Tables("tagihan").Rows(i).Item("BM"))
                    cmd.Parameters.AddWithValue("@SJ", datasetTagihan.Tables("tagihan").Rows(i).Item("SJ"))
                    cmd.Parameters.AddWithValue("@TOTAL", datasetTagihan.Tables("tagihan").Rows(i).Item("TOTAL"))
                    cmd.Parameters.AddWithValue("@POTONGAN", datasetTagihan.Tables("tagihan").Rows(i).Item("POTONGAN"))
                    cmd.Parameters.AddWithValue("@TAMBAHAN", datasetTagihan.Tables("tagihan").Rows(i).Item("TAMBAHAN"))
                    cmd.Parameters.AddWithValue("@KET", datasetTagihan.Tables("tagihan").Rows(i).Item("KETERANGAN"))
                    cmd.ExecuteNonQuery()

                Next
                'Memasukan data ke log
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                rj.isilog(rj.getusername, txtTagihan.Text, "Buat Tagihan", "Insert Data", log)
                rj.shownotify("Data Berhasil Disimpan")
                FormBuatKwitansi.txtheader.Text = txtTagihan.Text
                FormBuatKwitansi.txtKeterangan.Text = txtKeterangan.Text
                FormBuatKwitansi.txtNo.Text = txtTagihan.Text
                FormBuatKwitansi.txtNominal.Text = CDbl(lblGrand.Text)
                FormBuatKwitansi.txtPenerima.Text = namasup
                FormBuatKwitansi.txtPengirim.Text = rj.getusername
                FormBuatKwitansi.cetak()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cn.Close()
                dataset.Dispose()
                adapter.Dispose()
                cmd.Dispose()
                panggil()
            End Try
        End If
    End Sub

 
    Private Sub txtTagihan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTagihan.KeyUp
        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn

            cmd.CommandText = "SELECT KODETAGIHAN FROM THTAGIHAN WHERE KODETAGIHAN=@KODETAG"
            cmd.Parameters.AddWithValue("@KODETAG", txtTagihan.Text)
            Dim temp As SqlDataReader

            temp = cmd.ExecuteReader
            If (temp.HasRows) Then
                LblValidator.Text = "Not Valid"
            Else
                LblValidator.Text = ""
            End If
            cn.Close()
            temp.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub



    Private Sub txtTambahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTambahan.Click
        txtTambahan.Select(txtTambahan.Text.Length, 0)
    End Sub

    Private Sub txtPotongan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPotongan.Click
        txtPotongan.Select(txtTambahan.Text.Length, 0)
    End Sub

 
    Private Sub dgvBM_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBM.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True
            SendKeys.Send(Keys.Tab)
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        ' Tombol Enter Ditekan
        If keyData = Keys.Enter Or keyData = Keys.Escape Then     ' YES
            ' DiBunuh EnterNya
            Return True
        End If

        ' Pengaturan Key yang lainnya
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class