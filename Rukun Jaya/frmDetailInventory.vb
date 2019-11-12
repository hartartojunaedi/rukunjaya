Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDetailInventory
    Dim rj As New RJCommon
    Dim rlib As New rjLib
    Dim cn As New SqlConnection
    Public insert As Boolean = True
    Dim command As String
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(TxtKodeSP.Text) = "" Then
            rj.shownotifyerror("Kode Spare Part Harus Diisi !")
            flag = False
        End If
        If Trim(TxtNamaSparepart.Text) = "" Then
            rj.shownotifyerror("Nama Spare Part Harus Diisi !")
            flag = False
        End If
        'jun 3 feb 2015
        If Trim(txtHargaTerakhir.Text) = "" Then
            flag = False
            rj.shownotifyerror("Harga Terakhir Harus Diisi ")
        End If
        Try
            Dim a As Double = CType(txtHargaTerakhir.Text, Double)
        Catch ex As Exception
            rj.shownotifyerror("Harga Terakhir Harus Berupa Angka !")
            flag = False
        End Try
        Return flag
    End Function
    Private Sub frmInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        ' cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        txtStock.Maximum = Decimal.MaxValue
        If insert Then
            TxtKodeSP.Focus()
        Else
            TxtNamaSparepart.Focus()
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If ceksimpan() Then
            If insert = True Then
                command = "Select count(kodesparepart) from tsparepart where kodesparepart='" & TxtKodeSP.Text & "'"
                Dim cmd1 As SqlCommand = New SqlCommand
                cmd1.Connection = cn
                cmd1.CommandText = command
                cn.Open()
                Dim jumlah As Integer = cmd1.ExecuteScalar()
                cn.Close()
                If jumlah > 0 Then
                    MsgBox("Kode spare part telah terpakai")
                Else
                    Try
                        cn.Open()

                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "Insert into tsparepart(kodesparepart,namasparepart,hargaterakhir,stock,keterangan,kartustok) values (@kode,@nama,@harga,@stock,@ket,@kartustok)"
                        cmd.Parameters.AddWithValue("@kode", TxtKodeSP.Text)
                        cmd.Parameters.AddWithValue("@nama", TxtNamaSparepart.Text)
                        cmd.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))
                        cmd.Parameters.AddWithValue("@stock", txtStock.Value)
                        cmd.Parameters.AddWithValue("@kartustok", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@ket", TxtKeterangan.Text)
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nama sparepart = " & TxtNamaSparepart.Text & vbCrLf & " harga terakhir =" & txtHargaTerakhir.Text & vbCrLf & " Stock = " & txtStock.Value.ToString & vbCrLf & " Keterangan = " & TxtKeterangan.Text
                        rj.isilog(rj.getusername, TxtKodeSP.Text, "Master Inventory", "Tambah Data", log)
                        rj.shownotify("Data Berhasil Disimpan")

                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, TxtKodeSP.Text, "Master Inventory", "Tambah Data", ex.Message)
                        rj.shownotifyerror("Data Gagal Disimpan")
                        cn.Close()
                    End Try
                    cn.Close()
                    Me.Close()
                End If

            Else
                Try
                    cn.Open()
                    Dim cmd As SqlCommand = New SqlCommand

                    cmd.Connection = cn
                    cmd.CommandText = "update tsparepart set kartustok=@kartustok,namasparepart=@nama,stock=@stock,keterangan=@ket where kodesparepart=@kode"
                    ' cmd.CommandText = "update tsparepart set kartustok=@kartustok,namasparepart=@nama, hargaterakhir=@harga,stock=@stock,keterangan=@ket where kodesparepart=@kode"
                    cmd.Parameters.AddWithValue("@kode", TxtKodeSP.Text)
                    cmd.Parameters.AddWithValue("@nama", TxtNamaSparepart.Text)
                    ' cmd.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))
                    cmd.Parameters.AddWithValue("@stock", txtStock.Value)
                    cmd.Parameters.AddWithValue("@kartustok", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@ket", TxtKeterangan.Text)
                    cmd.ExecuteNonQuery()

                    Dim log As String = "nama sparepart =" & TxtNamaSparepart.Text & vbCrLf & " harga terakhir =" & txtHargaTerakhir.Text & vbCrLf & " Stock =" & txtStock.Value.ToString & vbCrLf & " Keterangan =" & TxtKeterangan.Text
                    rj.isilog(rj.getusername, TxtKodeSP.Text, "Master Inventory", "Ubah Data", log)
                    rj.shownotify("Data Berhasil Diubah")


                Catch ex As Exception
                    rj.isiErrorlog(rj.getusername, TxtKodeSP.Text, "Master Inventory", "Ubah Data", ex.Message)
                    rj.shownotifyerror("Data Gagal Diubah")
                    cn.Close()
                End Try
                cn.Close()
                Me.Close()

            End If
        Else
            MsgBox("Ada Data Yang Kurang ")
        End If
    End Sub
 
    Sub clear()
        TxtKodeSP.Text = ""
        txtHargaTerakhir.Text = "0"
        TxtKeterangan.Text = ""
        TxtNamaSparepart.Text = ""
        TextBox1.Text = ""
        txtStock.Text = "0"
    End Sub


    Private Sub frmDetailInventory_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMasterInventory.panggil()
        clear()
    End Sub

    Private Sub txtHargaTerakhir_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaTerakhir.KeyPress
        If (e.KeyChar <= ChrW(47)) Or (e.KeyChar >= ChrW(58)) Then
            If e.KeyChar = vbBack Then
            Else
                e.KeyChar = ChrW(0)
            End If
        Else
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        clear()
        Me.Close()
    End Sub
End Class