Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDetailUbahHarga
    Dim rj As New RJCommon
    Dim rlib As New rjLib
    Dim cn As New SqlConnection
    Public insert As Boolean = True
    Dim command As String
    Private Sub frmDetailUbahHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        ' cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        If insert Then
            TxtKodeSP.Focus()
        Else
            TxtNamaSparepart.Focus()
        End If
    End Sub

    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True

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

    Sub clear()
        TxtKodeSP.Text = ""
        txtHargaTerakhir.Text = "0"
        TxtNamaSparepart.Text = ""
    End Sub

    Private Sub frmDetailInventory_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'frmUbahHarga.panggil()
        'clear()
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
                        cmd.CommandText = "Insert into tsparepart(kodesparepart,namasparepart,hargaterakhir,stock,keterangan) values (@kode,@nama,@harga,@stock,@ket)"
                        cmd.Parameters.AddWithValue("@kode", TxtKodeSP.Text)
                        cmd.Parameters.AddWithValue("@nama", TxtNamaSparepart.Text)
                        cmd.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))

                        cmd.ExecuteNonQuery()

                        'simpan history
                        Dim cmd2 As New SqlCommand
                        cmd2.Connection = cn
                        cmd2.CommandText = "insert into thistoryharga(kodesparepart,harga,tgl,ref,jenis) values (@kodesparepart,@harga, {fn NOW()},'-','Manual')"
                        cmd2.Parameters.AddWithValue("@kodesparepart", TxtKodeSP.Text)
                        cmd2.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))
                        cmd2.ExecuteNonQuery()

                        Dim log As String = "nama sparepart = " & TxtNamaSparepart.Text & vbCrLf & " harga terakhir =" & txtHargaTerakhir.Text & vbCrLf
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
                    cmd.CommandText = "update tsparepart set namasparepart=@nama, hargaterakhir=@harga where kodesparepart=@kode"
                    cmd.Parameters.AddWithValue("@kode", TxtKodeSP.Text)
                    cmd.Parameters.AddWithValue("@nama", TxtNamaSparepart.Text)
                    cmd.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))
                    cmd.ExecuteNonQuery()

                    'simpan history
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = cn
                    cmd2.CommandText = "insert into thistoryharga(kodesparepart,harga,tgl,ref,jenis) values (@kodesparepart,@harga, {fn NOW()},'-','Manual')"
                    cmd2.Parameters.AddWithValue("@kodesparepart", TxtKodeSP.Text)
                    cmd2.Parameters.AddWithValue("@harga", rlib.RemoveNonNumeric(txtHargaTerakhir.Text))
                    cmd2.ExecuteNonQuery()

                    Dim log As String = "nama sparepart =" & TxtNamaSparepart.Text & vbCrLf & " harga terakhir =" & txtHargaTerakhir.Text & vbCrLf
                    rj.isilog(rj.getusername, TxtKodeSP.Text, "Master Harga", "Ubah Data", log)
                    rj.shownotify("Data Berhasil Diubah")


                Catch ex As Exception
                    rj.isiErrorlog(rj.getusername, TxtKodeSP.Text, "Master Harga", "Ubah Data", ex.Message)
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


End Class