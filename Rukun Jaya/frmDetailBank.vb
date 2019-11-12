Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailBank
    Dim rj As New RJCommon
    Dim rlib As New rjLib
    Dim cn As New SqlConnection
    Public simpan As Boolean
    Dim command As String
    'jun 15 jan 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtkodebank.Text) = "" Then
            rj.shownotifyerror("Kode Bank Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtnamabank.Text) = "" Then
            rj.shownotifyerror("Nama Bank Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtsaldo.Text) = "" Then
            rj.shownotifyerror("Saldo harus diisi ")
            flag = False
        End If
        Try
            Dim a As Double = CDbl(txtsaldo.Text)
        Catch ex As Exception
            flag = False
            rj.shownotifyerror("Saldo Harus Berupa Angka ")
        End Try
        Try
            Dim a As Double = CType(txtsaldo.Text, Double)
        Catch ex As Exception
            rj.shownotifyerror("Saldo Harus Berupa Angka ")
            flag = False
        End Try
        Return flag
    End Function
    Private Sub btnTambahData_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If simpan = True Then
                command = "Select count(kodebank) from tbank where kodebank='" & txtkodebank.Text & "'"
                Dim cmd1 As SqlCommand = New SqlCommand
                cmd1.Connection = cn
                cmd1.CommandText = command
                cn.Open()
                Dim jumlah As Integer = cmd1.ExecuteScalar()
                cn.Close()
                If jumlah > 0 Then
                    MsgBox("Kode Bank telah Terpakai")
                Else

                    Try
                        cn.Open()

                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "Insert into tbank(kodebank,namabank,norek,saldo,Keterangan) values (@kode,@nama,@norek,@saldo,@ket)"
                        cmd.Parameters.AddWithValue("@kode", txtkodebank.Text)
                        cmd.Parameters.AddWithValue("@nama", txtnamabank.Text)
                        cmd.Parameters.AddWithValue("@norek", txtNoRekening.Text)
                        cmd.Parameters.AddWithValue("@saldo", txtsaldo.Text)
                        cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nama bank = " & txtnamabank.Text & vbCrLf & " No Rekening =" & txtNoRekening.Text & vbCrLf & " Saldo =" & txtsaldo.Text & vbCrLf & " Keterangan= " & txtKeterangan.Text
                        rj.isilog(rj.getusername, txtkodebank.Text, "Master Bank", "Tambah Data", log)
                        rj.shownotify("Data Master Bank Berhasil Disimpan")

                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, txtkodebank.Text, "Master Bank", "Tambah Data", ex.Message)
                        rj.shownotifyerror("Data Master Bank Gagal Disimpan")
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
                    cmd.CommandText = "update tbank set namabank=@nama , norek=@norek,saldo=@saldo,keterangan=@ket where kodebank=@kode"
                    cmd.Parameters.AddWithValue("@kode", txtkodebank.Text)
                    cmd.Parameters.AddWithValue("@nama", txtnamabank.Text)
                    cmd.Parameters.AddWithValue("@norek", txtNoRekening.Text)
                    'saldo masih ada rp
                    cmd.Parameters.AddWithValue("@saldo", rlib.RemoveNonNumeric(txtsaldo.Text))
                    cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                    cmd.ExecuteNonQuery()

                    Dim log As String = "nama bank = " & txtnamabank.Text & vbCrLf & " No Rekening =" & txtNoRekening.Text & vbCrLf & " Saldo =" & txtsaldo.Text & vbCrLf & " Keterangan =" & txtKeterangan.Text
                    rj.isilog(rj.getusername, txtkodebank.Text, "Master Bank", "Update Data", log)
                    rj.shownotify("Data Berhasil Disimpan")
                    ' clear()
                Catch ex As Exception
                    rj.isiErrorlog(rj.getusername, txtkodebank.Text, "Master Bank", "Update Data", ex.Message)
                    rj.shownotifyerror("Data Gagal Disimpan")
                    cn.Close()
                End Try
                cn.Close()

                '  clear()
                Me.Close()

            End If
        Else
            MsgBox("Ada Isian Yang Kurang !")
        End If
    End Sub

    Private Sub frmDetailBank_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
    End Sub

    Private Sub btnUbahData_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click

        Me.Close()

    End Sub

    Sub clear()
        txtkodebank.Text = ""
        txtnamabank.Text = ""
        txtKeterangan.Text = ""
        txtNoRekening.Text = ""
        txtsaldo.Text = ""

    End Sub

    Private Sub frmDetailBank_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        clear()
        frmMasterBank.panggil()
    End Sub

    Private Sub txtNoRekening_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoRekening.KeyPress, txtsaldo.KeyPress
        If (e.KeyChar <= ChrW(47)) Or (e.KeyChar >= ChrW(58)) Then
            If e.KeyChar = vbBack Then
            Else
                e.KeyChar = ChrW(0)
            End If
        Else
        End If
    End Sub

  
End Class