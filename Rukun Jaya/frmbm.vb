Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmbm
    Public nolambung As String = ""
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtNoBM.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("No BM Harus Diisi !")
        End If
        If Trim(txtNoLambung.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("No Kendaraan Harus Diisi !")
        End If
        If Trim(txtKodeSopir.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Sopir Harus Diisi !")
        End If
        Return flag
    End Function
    Sub clearisi()
        txtKeterangan.Clear()
        txtKodeSopir.Clear()
        txtNoLambung.Clear()
        txtNoBM.Clear()
        lblNamaSopir.Text = ""
        lblNoPolisi.Text = ""
        dtptanggal.Text = Date.Now
    End Sub
    Sub ambilnamasopir()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.Parameters.Clear()
        cmd.CommandText = "select namasopir from tsopir where kodesopir = @kodesopir"
        Try
            Dim namasopir As String = cmd.ExecuteScalar

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If txtNoBM.Text.Trim(" ") = "" Then
                MsgBox("No BM harus diisi", MsgBoxStyle.OkOnly, "Konfirmasi")
            ElseIf txtKodeSopir.Text.Trim(" ") = "" Then
                MsgBox("Kode Sopir harus diisi", MsgBoxStyle.OkOnly, "Konfirmasi")
            ElseIf txtNoLambung.Text.Trim(" ") = "" Then
                MsgBox("No Lambung harus diisi", MsgBoxStyle.OkOnly, "Konfirmasi")
            Else

                Try
                    conn.Open()
                    Dim cmd As New SqlCommand("", conn)
                    cmd.Parameters.Clear()
                    'cek dulu apakah sudah pernah ada nomor lambung tersebut
                    cmd.CommandText = "select count(*) from tbm where nobm=@nobm"
                    cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)
                    Dim i As Integer = cmd.ExecuteScalar
                    If i = 0 Then
                        cmd.Parameters.Clear()
                        cmd.CommandText = "insert into tbm(nobm,tgl,nolambung,kodesopir,keterangan) values(@nobm,@tgl,@nolambung,@kodesopir,@keterangan)"
                        cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)
                        cmd.Parameters.AddWithValue("@tgl", dtptanggal.Value)
                        cmd.Parameters.AddWithValue("@nolambung", txtNoLambung.Text)
                        cmd.Parameters.AddWithValue("@kodesopir", txtKodeSopir.Text)
                        cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Data BM berhasil ditambahkan")
                        _rjcommon.isilog(_rjcommon.getusername, txtNoBM.Text, "Bon Muat", "Tambah Data", "tambah data noBM = " + txtNoBM.Text)
                        'jun set ritase
                        ' _rjcommon.increaseritase(txtNoLambung.Text)
                        Me.Close()
                    Else
                        MessageBox.Show("Data dengan no BM tersebut sudah ada")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Data BM tidak berhasil ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtNoBM.Text, "Bon Muat", "Tambah Data", ex.Message)

                End Try
                conn.Close()

            End If
        Else
            MsgBox("Isian Ada Yang Kurang !")
        End If
    End Sub

    Private Sub frmtagihanspbu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearisi()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnsearchlambung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchlambung.Click
        frmBrowseKendaraan.ShowDialog()
    End Sub
    Sub autofillnopol()
        Dim command As String
        command = "Select nopol from tkendaraan where  nolambung ='" & txtNoLambung.Text & "'"

        Try
            conn.Open()
            Dim cmd As New SqlCommand(command, conn)
            lblNoPolisi.Text = cmd.ExecuteScalar
            If lblNoPolisi.Text = "" Then
                MessageBox.Show("No Lambung tidak ada")
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("No Lambung tidak ada")
        End Try

    End Sub
    Sub autofillnamasopir()
        Dim command As String
        command = "Select namasopir from tsopir where kodesopir='" & txtKodeSopir.Text & "'"

        Try
            conn.Open()
            Dim cmd As New SqlCommand(command, conn)
            lblNamaSopir.Text = cmd.ExecuteScalar
            If lblNamaSopir.Text = "" Then
                MessageBox.Show("Kode Sopir tidak ada")
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("Kode Sopir tidak ada")
        End Try

    End Sub
    Private Sub txtNoLambung_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoLambung.Leave
        autofillnopol()
    End Sub

    Private Sub btnsearchsopir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchsopir.Click
        frmBrowsesopir.asal = 0
        frmBrowsesopir.ShowDialog()
    End Sub

    Private Sub txtKodeSopir_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeSopir.Leave
        autofillnamasopir()
    End Sub

    Private Sub frmbm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox)) And (Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If

    End Sub

    Private Sub txtKodeSopir_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKodeSopir.TextChanged

    End Sub
End Class