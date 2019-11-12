Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMasterDetailGrandBiaya
    Public kodebiaya As String = ""
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeBiaya.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode biaya tidak boleh kosong !")
        End If
        Return flag
    End Function
    Sub clearisi()
        txtKodeBiaya.Text = ""
        txtnamabiaya.Text = ""
        txtKodeBiaya.Enabled = True
        rbDebit.Checked = True
        txtKodeBiaya.ReadOnly = False
    End Sub
    Private Sub frmMasterDetailGrandBiaya_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnSimpan.Enabled = True
        If lblMode.Text.ToLower = "ubah" And kodebiaya <> "" Then
            txtKodeBiaya.Enabled = False
            conn.Open()
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "select * from tgrandbiaya where kodegrandbiaya=@kodegrandbiaya"
            cmd.Parameters.AddWithValue("@kodegrandbiaya", kodebiaya)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                txtKodeBiaya.Text = kodebiaya
                txtKodeBiaya.ReadOnly = True
                txtnamabiaya.Text = reader("namagrandbiaya")
                If reader("kurang") = True Then
                    rbDebit.Checked = True
                Else
                    rbkredit.Checked = True
                End If
            End While
            conn.Close()
        ElseIf lblMode.Text.ToLower = "tambah" Then
            clearisi()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If lblMode.Text.ToLower = "ubah" Then
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand("", conn)
                    cmd.Parameters.Clear()
                    cmd.CommandText = "update tgrandbiaya set namagrandbiaya=@namagrandbiaya,kurang=@kurang where kodegrandbiaya = @kodegrandbiaya"
                    cmd.Parameters.AddWithValue("@kodegrandbiaya", txtKodeBiaya.Text)
                    cmd.Parameters.AddWithValue("@namagrandbiaya", txtnamabiaya.Text)
                    cmd.Parameters.AddWithValue("@kurang", rbDebit.Checked)

                    cmd.ExecuteNonQuery()
                    'jun
                    _rjcommon.shownotify("Data Grand Biaya Berhasil Diupdate")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeBiaya.Text, "Master Grand Biaya", "Update Data", "ubah data kodebiaya = " + txtKodeBiaya.Text)
                    conn.Close()
                    Me.Close()

                    frmMasterGrandBiaya.panggil()
                Catch ex As Exception
                    _rjcommon.shownotifyerror("data tidak berhasil diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeBiaya.Text, "Master Grand Biaya", "Update Data", ex.Message)
                    conn.Close()
                End Try
            ElseIf lblMode.Text.ToLower = "tambah" Then
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand("", conn)
                    cmd.Parameters.Clear()
                    cmd.CommandText = "select count(*) from tgrandbiaya where kodegrandbiaya=@kodegrandbiaya"
                    cmd.Parameters.AddWithValue("@kodegrandbiaya", txtKodeBiaya.Text)
                    Dim i As Integer = cmd.ExecuteScalar
                    If i = 0 Then
                        cmd.Parameters.Clear()
                        cmd.CommandText = "insert into tgrandbiaya (kodegrandbiaya,namagrandbiaya,kurang) values(@kodegrandbiaya,@namagrandbiaya,@kurang)"

                        cmd.Parameters.AddWithValue("@kodegrandbiaya", txtKodeBiaya.Text)
                        cmd.Parameters.AddWithValue("@namagrandbiaya", txtnamabiaya.Text)
                        cmd.Parameters.AddWithValue("@kurang", rbDebit.Checked)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Data Master Grand Biaya Berhasil Ditambahkan")
                        _rjcommon.isilog(_rjcommon.getusername, txtKodeBiaya.Text, "Master Grand Biaya", "Tambah Data", txtKodeBiaya.Text)
                        conn.Close()
                        frmMasterGrandBiaya.panggil()
                        Me.Close()
                    End If
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Data Master Grand Biaya Tidak Berhasil Ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeBiaya.Text, "Master Grand Biaya", "Tambah Data", ex.Message)
                    conn.Close()
                End Try
            End If
        Else
            MsgBox("Ada Isian yang masih kosong !")
        End If
    End Sub
End Class