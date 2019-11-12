Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDetailLKuat
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Public simpan As Boolean
    Dim command As String

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click
        clear()
        frmCariDetilSuratJalan.ShowDialog()
    End Sub

    Sub cariurut()
        command = "Select max(idurutan) from tlkuat where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang=@kodebarang and nodo=@nodo"
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Parameters.AddWithValue("@nobm", lblNoBM.Text)
        cmd.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
        cmd.Parameters.AddWithValue("@Kodebarang", LblKodeBarang.Text)
        cmd.Parameters.AddWithValue("@nodo", lblNoDo.Text)
        cmd.CommandText = command
        cmd.Connection = cn
        cn.Open()
        Dim counter As String
        Try
            counter = cmd.ExecuteScalar
            counter = counter + 1
        Catch ex As Exception
            counter = 1
        End Try
        lblnourut.Text = counter
        cn.Close()



    End Sub
    Sub cek()
        command = "Select count(nosuratjalan) from tlkuat where  kodebarang=@kodebarang and nodo=@nodo and nosuratjalan=@nosuratjalan and nobm=@nobm "

        Dim cmd1 As SqlCommand = New SqlCommand
        cmd1.Parameters.Clear()
        cmd1.Parameters.AddWithValue("@nobm", lblNoBM.Text)
        cmd1.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
        cmd1.Parameters.AddWithValue("@Kodebarang", LblKodeBarang.Text)
        cmd1.Parameters.AddWithValue("@nodo", lblNoDo.Text)
        cmd1.Connection = cn
        cmd1.CommandText = command
        cn.Open()
        Dim jumlah As String = Convert.ToString(cmd1.ExecuteScalar())
        cn.Close()


        command = "Select jumlah from tdetailSuratjalan where  kodebarang=@kodebarang and nodo=@nodo and nosuratjalan=@nosuratjalan and nobm=@nobm "
        cmd1 = New SqlCommand
        cmd1.Parameters.Clear()
        cmd1.Parameters.AddWithValue("@nobm", lblNoBM.Text)
        cmd1.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
        cmd1.Parameters.AddWithValue("@Kodebarang", LblKodeBarang.Text)
        cmd1.Parameters.AddWithValue("@nodo", lblNoDo.Text)
        cmd1.Connection = cn
        cmd1.CommandText = command
        cn.Open()
        Dim jumlahbrg As String = Convert.ToString(cmd1.ExecuteScalar())
        cn.Close()



        If jumlah = "" Then
            lblnourut.Text = 1
        Else
            If CInt(jumlahbrg) > CInt(jumlah) Then
                cariurut()
                btnTambah.Enabled = True
            Else
                btnTambah.Enabled = False

            End If
        End If

    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click

        If simpan = True Then



            ' If jumlah > 0 Then

            '        Else

            Try
                cn.Open()

                Dim cmd As SqlCommand = New SqlCommand
                cmd.Connection = cn
                cmd.CommandText = "Insert into tLkuat(noBM,noSuratJalan,KodeBarang,noDO,IDUrutan,NoFrame,NoEngine,Kerusakan,jumlah) values (@nobm,@nosuratjalan,@kodebarang,@nodo,@idurutan,@noFrame,@noengine,@kerusakan,@jumlah)"
                cmd.Parameters.AddWithValue("@nobm", lblNoBM.Text)
                cmd.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
                cmd.Parameters.AddWithValue("@Kodebarang", LblKodeBarang.Text)
                cmd.Parameters.AddWithValue("@nodo", lblNoDo.Text)
                cmd.Parameters.AddWithValue("@idurutan", lblnourut.Text)
                cmd.Parameters.AddWithValue("@noframe", txtNoFrame.Text)
                cmd.Parameters.AddWithValue("@noengine", txtNoEngine.Text)
                cmd.Parameters.AddWithValue("@kerusakan", txtkerusakan.Text)
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text)
                cmd.ExecuteNonQuery()

                Dim log As String = ""
                rj.isilog(rj.getusername, " ", "Lkuat", "Insert Data", log)
                rj.shownotify("Data Berhasil Disimpan")

            Catch ex As Exception
                rj.isiErrorlog(rj.getusername, " ", "Lkuat", "Insert Data", ex.Message)
                rj.shownotifyerror("Data Gagal Disimpan")
                'cn.Close()
            End Try
            cn.Close()
            Me.Close()
            'End If

        Else

            Try
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand

                cmd.Connection = cn
                cmd.CommandText = "update lkuat set jumlah=@jumlah,NoFrame=@noframe,noengine=@noengine where kodebarang=@kodebarang and idurutan=@idurutan and nodo=@nodo and nosuratjalan=@nosuratjalan and nobm=@nobm"
                cmd.Parameters.AddWithValue("@nobm", lblNoBM.Text)
                cmd.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
                cmd.Parameters.AddWithValue("@Kodebarang", LblKodeBarang.Text)
                cmd.Parameters.AddWithValue("@nodo", lblNoDo.Text)
                cmd.Parameters.AddWithValue("@idurutan", lblnourut.Text)
                cmd.Parameters.AddWithValue("@noframe", txtNoFrame.Text)
                cmd.Parameters.AddWithValue("@noengine", txtNoEngine.Text)
                cmd.Parameters.AddWithValue("@kerusakan", txtkerusakan.Text)
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text)

                cmd.ExecuteNonQuery()
                rj.isilog(rj.getusername, lblNoBM.Text, "LKuat", "Tambah Data", "")
                rj.shownotify("Data Berhasil Disimpan")

            Catch ex As Exception
                rj.isiErrorlog(rj.getusername, lblNoBM.Text, "LKuat", "Tambah Data", ex.Message)
                rj.shownotifyerror("Data Gagal Disimpan")

            End Try
            cn.Close()


            Me.Close()

        End If
    End Sub

    Private Sub frmDetailLKuat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr

    End Sub

    Private Sub frmDetailLKuat_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        clear()
        frmLKuat.panggil()

    End Sub
    Sub clear()
        LblKodeBarang.Text = ""
        lblNoBM.Text = ""
        lblNamaBarang.Text = ""
        lblNoSuratJalan.Text = ""
        lblNoDo.Text = ""
        lblnourut.Text = ""
        txtkerusakan.Text = ""
        txtNoEngine.Text = ""
        txtNoFrame.Text = ""
        txtjumlah.Text = "1"
    End Sub

    Private Sub frmDetailLKuat_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class