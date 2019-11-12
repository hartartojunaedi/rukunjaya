Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetilBeliSparePart
    Dim er As New rjLib
    Dim rj As New RJCommon
    Dim command As String
    Dim transaction As SqlTransaction
    Public insert As Boolean
    Public varkodesparepart As String
    Dim cn As New SqlConnection
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim kodesp() As String
    Dim jmlitem() As String
    'jun 04 feb 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtNonota.Text) = "" Then
            rj.shownotifyerror("Nota Harus Diisi !")
            flag = False
        End If
        If Trim(txtNamaToko.Text) = "" Then
            flag = False
            rj.shownotifyerror("Nama Toko Harus Diisi !")
        End If
        Return flag
    End Function

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
      
        Dim row As String() = New String() {varkodesparepart, txtKodebarang.Text, nmJumlah.Value, txtHarga.Text, FormatNumber(CInt(txtHarga.Text) * nmJumlah.Value, 0)}
        ''membuat sebuah row baru. tetapi belum dimasukan ke dalam datagridvew

        If dgvdetilpembelian.RowCount = 0 Then
            dgvdetilpembelian.Rows.Add(row) ''saat rowcount=0 berarti belum ada data pada datagrid sehingga row yang telah kita buat dimasukan dalam datagridview
        Else
            Dim brgada As Boolean = False
            Dim bariske As Integer
            For i = 0 To dgvdetilpembelian.RowCount - 1
                If dgvdetilpembelian.Rows(i).Cells(0).Value = varkodesparepart Then ''apakah kode yang dimasukan sudah ada
                    brgada = True
                    bariske = i
                    Exit For
                End If
            Next

            If brgada Then
                dgvdetilpembelian.Rows(bariske).Cells(2).Value += nmJumlah.Value
                dgvdetilpembelian.Rows(bariske).Cells(3).Value = FormatNumber(txtHarga.Text, 0)
                dgvdetilpembelian.Rows(bariske).Cells(4).Value = FormatNumber(dgvdetilpembelian.Rows(bariske).Cells(3).Value * dgvdetilpembelian.Rows(bariske).Cells(2).Value, 0)
            Else
                dgvdetilpembelian.Rows.Add(row)
            End If
        End If

        hitunggrandtotalsebelumdiskon()

        ubahgrand()

        nmJumlah.Value = 1
        txtKodebarang.Text = ""
        txtHarga.Text = ""
        btnTambah.Enabled = False
    End Sub

    Sub hitunggrandtotalsebelumdiskon()
        Dim j As Integer = 0

        For i = 0 To dgvdetilpembelian.RowCount - 1
            'code ini digunakan untuk menjumlah total yang ada pda datagridview
            j = j + dgvdetilpembelian.Rows(i).Cells(4).Value
        Next
        'setelah selesai dimasukan pada sebuah label
        lblTotal.Text = FormatNumber(j, 0)
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        frmCariSparepart.mode = 1 'pembelian sparepart
        frmCariSparepart.ShowDialog()

    End Sub
    Sub loaddata()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "select namasparepart,hargaterakhir from tsparepart where kodesparepart=@kode"
        cmd.Parameters.AddWithValue("@kode", varkodesparepart)
        Dim reader As SqlDataReader
        cn.Open()
        reader = cmd.ExecuteReader()
        While reader.Read
            txtKodebarang.Text = reader.Item(0)
            txtHarga.Text = Format(reader.Item(1), 0)
        End While

        cn.Close()
    
    End Sub

    Private Sub frmDetilBeliSparePart_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox) Or Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub


    Private Sub frmDetilBeliSparePart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnTambah.Enabled = False
        BtnSimpan.Enabled = False
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        If insert = False Then
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "Select tgltransaksi,namatoko,total,diskon,grandtotal from thbeli where nota=@nota"
            cmd.Parameters.AddWithValue("@nota", txtNonota.Text)

            cn.Open()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                dtpTanggalTransaksi.Value = reader.Item(0)
                txtNamaToko.Text = reader.Item(1).ToString
                lblTotal.Text = FormatNumber(reader.Item(2), 0)
                txtDiskon.Text = FormatNumber(reader.Item(3), 0)
                lblgrandtotal.Text = FormatNumber(reader.Item(4), 0)
            End While
            cmd.Parameters.Clear()
            cn.Close()
            panggil()
        End If

    End Sub

    Sub panggil()
        Try


            Dim reader As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "Select i.kodesparepart,i.namasparepart,d.jumlah,d.harga,d.jumlah*d.harga as total from tdbeli d, tSparepart i  where i.kodesparepart=d.kodesparepart and d.nota=@nota"
            cmd.Parameters.AddWithValue("@nota", txtNonota.Text)
            cn.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
               
                Dim row As String() = New String() {reader.Item(0), reader.Item(1), reader.Item(2), FormatNumber(reader.Item(3), 0), FormatNumber(reader.Item(4), 0)}
                dgvdetilpembelian.Rows.Add(row)

            End While
            cmd.Parameters.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cn.Close()

    End Sub


    Private Sub txtDiskon_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiskon.KeyPress
        If (e.KeyChar <= ChrW(47)) Or (e.KeyChar >= ChrW(58)) Then
            If e.KeyChar = vbBack Then
            Else
                e.KeyChar = ChrW(0)
            End If
        Else
        End If

       
    End Sub


    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If ceksimpan() Then
            If CInt(lblgrandtotal.Text >= 0) Then
                If insert = True Then
                    insertbaru()
                Else
                    updatebaru()
                    Me.Close()

                End If
            Else
                MessageBox.Show("Error : Grand total minus")

            End If
        Else
            MsgBox("Ada Isian Yang Kurang")
        End If

    End Sub

    Sub updatebaru()

        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = cn
        cn.Open()
        Dim i As Integer = 0

        cmd.CommandText = "select jumlah,kodesparepart from tdbeli where nota=@kode"
        cmd.Parameters.AddWithValue("@kode", txtNonota.Text)

        Try
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                ''masi error di sini masalah e reader sama query ga mau jd 1 cmd
                ReDim Preserve jmlitem(i)
                ReDim Preserve kodesp(i)
                kodesp(i) = reader.Item(1)
                jmlitem(i) = reader.Item(0)
                i += 1
            End While
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        


        Try
            transaction = cn.BeginTransaction("SampleTransaction")
            cmd.Transaction = transaction

            For j = 0 To i - 1
                cmd.CommandText = "update tsparepart set stock=stock-@stock1 where kodesparepart=@kodesp1"
                cmd.Parameters.AddWithValue("@kodesp1", kodesp(j))
                cmd.Parameters.AddWithValue("@stock1", jmlitem(j))
                'cmd.ExecuteNonQuery()
                'ditutup karena tidak update stok 2 mei 2017
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@kode", txtNonota.Text)
                ' MsgBox("executed " & jmlitem(j) & "  " & kodesp(j))

            Next

            cmd.CommandText = "delete from tdbeli where nota=@kode"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "delete from thbeli where nota=@kode"
            cmd.ExecuteNonQuery()


            cmd.Parameters.Clear()

            cmd.CommandText = "Insert into tHbeli(nota,tgltransaksi,namatoko,total,diskon,grandtotal) values (@nota,@tgltrans,@namatoko,@total,@diskon,@grandtotal)"
            cmd.Parameters.AddWithValue("@nota", txtNonota.Text)
            cmd.Parameters.AddWithValue("@tgltrans", dtpTanggalTransaksi.Value)
            cmd.Parameters.AddWithValue("@namatoko", txtNamaToko.Text)
            cmd.Parameters.AddWithValue("@total", CInt(er.RemoveNonNumeric(lblTotal.Text)))
            cmd.Parameters.AddWithValue("@diskon", er.RemoveNonNumeric(txtDiskon.Text))
            'jun 03 feb 2015
            cmd.Parameters.AddWithValue("@grandtotal", CInt(er.RemoveNonNumeric(lblgrandtotal.Text)))
            cmd.ExecuteNonQuery()

            For i = 0 To dgvdetilpembelian.RowCount - 1
                cmd.CommandText = "Insert into tdbeli(nota,kodesparepart,jumlah,harga) values (@nota,@kodesp,@jumlah,@harga)"
                cmd.Parameters.AddWithValue("@kodesp", dgvdetilpembelian.Rows(i).Cells("Kodesparepart").Value)
                cmd.Parameters.AddWithValue("@jumlah", dgvdetilpembelian.Rows(i).Cells("jumlah").Value)
                cmd.Parameters.AddWithValue("@harga", er.RemoveNonNumeric(dgvdetilpembelian.Rows(i).Cells("Harga").Value))
                cmd.ExecuteNonQuery()


                cmd.CommandText = "Select hargaterakhir from tsparepart where kodesparepart=@kodesp"
                Dim hargadb As Integer = cmd.ExecuteScalar()



                If hargadb <> dgvdetilpembelian.Rows(i).Cells("harga").Value Then
                    cmd.CommandText = "update tsparepart set hargaterakhir=@harga where kodesparepart=@kodesp"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Insert into thistoryharga(kodesparepart,harga,tgl,jenis,ref) values (@kodesp,@harga,{fn NOW()},'Pembelian',@nota)"
                    cmd.ExecuteNonQuery()

                End If
                cmd.CommandText = "update tsparepart set stock=stock+@jumlah where kodesparepart=@kodesp"
                'cmd.ExecuteNonQuery()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nota", txtNonota.Text)
                cmd.Parameters.AddWithValue("@tgltrans", dtpTanggalTransaksi.Value)

            Next



            Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
            rj.isilog(rj.getusername, txtNonota.Text, "Transaksi Pembelian Sparepart", "Update Data", log)
            rj.shownotify("Data Berhasil Disimpan")
            transaction.Commit()
            cn.Close()

        Catch ex As Exception
            transaction.Rollback()
            cn.Close()
            '  Dim log As String = "nota = " & txtNonota.Text & vbCrLf & " nama toko =" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text & " Error message  = " & ex.Message
            rj.isiErrorlog(rj.getusername, txtNonota.Text, "Transaksi Pembelian Sparepart", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")

            'MsgBox(ex.Message)
        End Try

    End Sub



    Sub insertbaru()
   

        Dim cmd1 As SqlCommand = New SqlCommand

        cmd1.CommandText = "Select count(nota) from thbeli where nota=@nota"
        cmd1.Parameters.AddWithValue("@nota", txtNonota.Text)
        cmd1.Connection = cn

        cn.Open()
        Dim jumlah As Integer = cmd1.ExecuteScalar()
        cn.Close()

        If jumlah < 1 Then
            If txtNonota.Text.Length > 0 And txtNamaToko.Text.Length > 0 Then
                If dgvdetilpembelian.RowCount > 0 Then

                    Try
                        cn.Open()
                        transaction = cn.BeginTransaction("SampleTransaction")

                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.Transaction = transaction

                        cmd.CommandText = "Insert into tHbeli(nota,tgltransaksi,namatoko,total,diskon,grandtotal) values (@nota,@tgltrans,@namatoko,@total,@diskon,@grandtotal)"
                        cmd.Parameters.AddWithValue("@nota", txtNonota.Text)
                        cmd.Parameters.AddWithValue("@tgltrans", dtpTanggalTransaksi.Value)
                        cmd.Parameters.AddWithValue("@namatoko", txtNamaToko.Text)
                        cmd.Parameters.AddWithValue("@total", CInt(er.RemoveNonNumeric(lblTotal.Text)))
                        cmd.Parameters.AddWithValue("@diskon", er.RemoveNonNumeric(txtDiskon.Text))
                        cmd.Parameters.AddWithValue("@grandtotal", CInt(er.RemoveNonNumeric(lblgrandtotal.Text)))
                        cmd.ExecuteNonQuery()

                        For i = 0 To dgvdetilpembelian.RowCount - 1
                            cmd.CommandText = "Insert into tdbeli(nota,kodesparepart,jumlah,harga) values (@nota,@kodesp,@jumlah,@harga)"
                            cmd.Parameters.AddWithValue("@kodesp", dgvdetilpembelian.Rows(i).Cells("kodesparepart").Value)
                            cmd.Parameters.AddWithValue("@jumlah", dgvdetilpembelian.Rows(i).Cells("jumlah").Value)
                            cmd.Parameters.AddWithValue("@harga", dgvdetilpembelian.Rows(i).Cells("harga").Value)
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Select hargaterakhir from tsparepart where kodesparepart=@kodesp"
                            Dim hargadb As Integer = cmd.ExecuteScalar()

                            If hargadb <> dgvdetilpembelian.Rows(i).Cells("harga").Value Then
                                cmd.CommandText = "update tsparepart set hargaterakhir=@harga where kodesparepart=@kodesp"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "Insert into thistoryharga(kodesparepart,harga,tgl,jenis,ref) values (@kodesp,@harga,{fn NOW()},'Pembelian',@nota)"
                                cmd.ExecuteNonQuery()

                            End If

                            cmd.CommandText = "update tsparepart set stock=stock+@jumlah where kodesparepart=@kodesp"
                            'cmd.ExecuteNonQuery()
                            'tidak perlu update stok 2 mei 2017

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@nota", txtNonota.Text)
                            cmd.Parameters.AddWithValue("@tgltrans", dtpTanggalTransaksi.Value)
                        Next
                        Dim log As String = "" ''"nota = " & txtNonota.Text & vbCrLf & " nama toko =" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                        rj.isilog(rj.getusername, txtNonota.Text, "Transaksi Pembelian Sparepart", "Tambah Data", log)
                        rj.shownotify("Data Berhasil Disimpan")

                        transaction.Commit()

                    Catch ex As Exception
                        transaction.Rollback()
                        cn.Close()
                        'Dim log As String = "nota = " & txtNonota.Text & vbCrLf & " nama toko =" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text & " Error message  = " & ex.Message
                        rj.isiErrorlog(rj.getusername, txtNonota.Text, "Transaksi Pembelian Sparepart", "Tambah Data", ex.Message)
                        rj.shownotifyerror("Data Tidak Berhasil Disimpan")
                        MsgBox("Data Tidak Berhasil Disimpan ")
                        cn.Close()
                    End Try
                End If
            End If
            Me.Close()
        Else
            MsgBox("nota telah digunakan")
        End If


    End Sub

    Private Sub txtDiskon_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiskon.KeyUp
        ubahgrand()
    End Sub
    Sub ubahgrand()
        lblgrandtotal.Text = FormatNumber(CInt(er.RemoveNonNumeric(lblTotal.Text)) - CInt(er.RemoveNonNumeric(txtDiskon.Text)), 0)
        lbljumlahitem.Text = dgvdetilpembelian.RowCount
        If dgvdetilpembelian.RowCount > 0 Then
            BtnSimpan.Enabled = True
        Else
            BtnSimpan.Enabled = False
        End If
    End Sub

    Private Sub frmDetilBeliSparePart_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmPembelianSparepart.panggil()
        dgvdetilpembelian.Rows.Clear()
        txtKodebarang.Text = ""
        txtHarga.Text = ""
        txtNonota.Text = ""
        txtNamaToko.Text = ""
        txtNonota.Enabled = True

    End Sub

    Private Sub dgvdetilpembelian_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetilpembelian.CellClick
        If (e.ColumnIndex = 5) Then
            If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                dgvdetilpembelian.Rows.RemoveAt(e.RowIndex)
                hitunggrandtotalsebelumdiskon()
                ubahgrand()
            End If
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If (e.KeyChar <= ChrW(47)) Or (e.KeyChar >= ChrW(58)) Then
            If e.KeyChar = vbBack Then
            Else
                e.KeyChar = ChrW(0)
            End If
        Else
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'jun
        Close()
    End Sub
End Class