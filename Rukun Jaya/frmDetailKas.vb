Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailKas
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Public mode As Integer
    Public kodekas As Integer
    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Close()
    End Sub
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtnamakas.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama Kas Harus Diisi")
        End If
        If Trim(txtjumlah.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Jumlah Harus Diisi ")
        End If
        Try
            Dim temp As Double = CDbl(txtjumlah.Text)
        Catch ex As Exception
            flag = False
            _rjcommon.shownotifyerror("Harus Berupa Angka !")
        End Try
        Return flag
    End Function
    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        If ceksimpan() Then
            If mode = 0 Then 'mode simpan
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd.CommandText = "insert into tkas(namakas,tgl,jumlah,keterangan) values (@namakas,@tgl,@jumlah,@keterangan)"
                    cmd.Parameters.AddWithValue("@namakas", txtnamakas.Text)
                    cmd.Parameters.AddWithValue("@tgl", dtpTgl.Value.Date)
                    cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text)
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                    cmd.ExecuteNonQuery()
                    _rjcommon.shownotify("Data Kas berhasil ditambahkan")
                    _rjcommon.isilog(_rjcommon.getusername, txtnamakas.Text, "Kas", "Tambah Data", "")
                    conn.Close()
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Data Kas gagal ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtnamakas.Text, "Kas", "Tambah Data", ex.Message)
                    conn.Close()
                End Try

            Else
                'mode update
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd.CommandText = "update tkas set namakas=@namakas,tgl=@tgl,jumlah=@jumlah,keterangan=@keterangan where kodekas=@kodekas"
                    cmd.Parameters.AddWithValue("@namakas", txtnamakas.Text)
                    cmd.Parameters.AddWithValue("@tgl", dtpTgl.Value.Date)
                    cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text)
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                    cmd.Parameters.AddWithValue("@kodekas", kodekas)
                    cmd.ExecuteNonQuery()
                    _rjcommon.shownotify("Data Kas berhasil diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtnamakas.Text, "Kas", "Update Data", "")
                    conn.Close()
                    Close()
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Data Kas gagal diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, kodekas, "Kas", "Update Data", ex.Message)
                    conn.Close()
                End Try
            End If
        Else
            MsgBox("Isian Ada Yang Kurang Tepat")
        End If
    End Sub

    Private Sub frmDetailKas_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dtpTgl.Value = Now
        If mode = 1 Then
            'mode update
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select * from tkas where kodekas=@kodekas"
            cmd.Parameters.AddWithValue("@kodekas", kodekas)
            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txtnamakas.Text = dr.Item("namakas").ToString
                    txtKeterangan.Text = dr.Item("keterangan").ToString
                    txtjumlah.Text = CDbl(dr.Item("jumlah").ToString)
                    dtpTgl.Value = CDate(dr.Item("tgl"))
                End If
          
                conn.Close()

            Catch ex As Exception
                _rjcommon.shownotifyerror("Data Tidak Bisa Dibaca")
                conn.Close()
            End Try
        End If
    End Sub
End Class