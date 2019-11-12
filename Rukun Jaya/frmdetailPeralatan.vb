Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmdetailPeralatan
    Dim rj As New RJCommon
    Dim rlib As New rjLib
    Dim cn As New SqlConnection
    Public simpan As Boolean
    Dim command As String


    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtIDAlat.Text) = "" Then
            rj.shownotifyerror("ID Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtnamaAlat.Text) = "" Then
            rj.shownotifyerror("Nama Alat Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtjumlah.Text) = "" Then
            rj.shownotifyerror("jumlah harus diisi ")
            flag = False
        End If
        Try
            Dim a As Double = CDbl(txtjumlah.Text)
        Catch ex As Exception
            flag = False
            rj.shownotifyerror("Jumlah Harus Berupa Angka ")
        End Try

        Return flag
    End Function
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If simpan = True Then
                command = "Select count(IDAlat) from tPeralatan where IDAlat='" & txtIDAlat.Text & "'"
                Dim cmd1 As SqlCommand = New SqlCommand
                cmd1.Connection = cn
                cmd1.CommandText = command
                cn.Open()
                Dim jumlah As Integer = cmd1.ExecuteScalar()
                cn.Close()
                If jumlah > 0 Then
                    MsgBox("ID Alat telah Terpakai")
                Else

                    Try
                        cn.Open()

                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "Insert into tPeralatan(IDAlat,NamaAlat,Jumlah,Satuan,Keterangan) values (@IDAlat,@NamaAlat,@Jumlah,@Satuan,@Keterangan)"
                        cmd.Parameters.AddWithValue("@IDAlat", txtIDAlat.Text)
                        cmd.Parameters.AddWithValue("@NamaAlat", txtnamaAlat.Text)
                        cmd.Parameters.AddWithValue("@Jumlah", txtjumlah.Text)
                        cmd.Parameters.AddWithValue("@Satuan", txtSatuan.Text)
                        cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text)
                        cmd.ExecuteNonQuery()

                        Dim log As String = ""
                        rj.isilog(rj.getusername, txtIDAlat.Text, "Master Peralatan", "Tambah Data", log)
                        rj.shownotify("Data Master Peralatan Berhasil Disimpan")

                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, txtIDAlat.Text, "Master Peralatan", "Tambah Data", ex.Message)
                        rj.shownotifyerror("Data Master Peralatan Gagal Disimpan")
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
                    cmd.CommandText = "update tperalatan set namaalat=@namaalat, jumlah=@jumlah,satuan=@satuan,keterangan=@keterangan where IDAlat=@IDAlat"
                    cmd.Parameters.AddWithValue("@IDAlat", txtIDAlat.Text)
                    cmd.Parameters.AddWithValue("@NamaAlat", txtnamaAlat.Text)
                    cmd.Parameters.AddWithValue("@Jumlah", txtjumlah.Text)
                    cmd.Parameters.AddWithValue("@Satuan", txtSatuan.Text)
                    cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text)
                    cmd.ExecuteNonQuery()

                    Dim log As String = ""
                    rj.isilog(rj.getusername, txtIDAlat.Text, "Master Peralatan", "Ubah Data", log)
                    rj.shownotify("Data Master Peralatan Berhasil Disimpan")

                Catch ex As Exception
                    rj.isiErrorlog(rj.getusername, txtIDAlat.Text, "Master Peralatan", "Ubah Data", ex.Message)
                    rj.shownotifyerror("Data Master Peralatan Gagal Disimpan")
                    cn.Close()

                End Try
                cn.Close()
                clear()
                Me.Close()

            End If
        Else
            MsgBox("Ada Isian Yang Kurang !")
        End If
    End Sub
    Sub clear()
        txtIDAlat.Text = ""
        txtnamaAlat.Text = ""
        txtjumlah.Text = "0"
        txtSatuan.Text = ""
        txtKeterangan.Text = ""
    End Sub
    Private Sub frmdetailPeralatan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMasterPeralatan.panggil()
    End Sub

    Private Sub frmdetailPeralatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        clear()
        Close()
    End Sub
End Class