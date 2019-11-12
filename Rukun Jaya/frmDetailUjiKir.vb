Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDetailUjiKir
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    'jun 26 desember 2014
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtNoKir.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("No Kir Tidak Boleh Kosong")
        End If
        If cmbnolambung.SelectedIndex < 0 Then
            flag = False
            _rjcommon.shownotifyerror("Kendaraan Harus Dipilih")
        End If
        If dtpKirBerikutnya.Value < dtpKir.Value Then
            flag = False
            _rjcommon.shownotifyerror("Tanggal Uji Kir Berikutnya Harus Lebih Besar !")
        End If
        Return flag
    End Function
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub frmDetailUjiKirim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btntambah.Enabled = True
            conn.Open()
            cmbnolambung.Items.Clear()
            Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
            While rd.Read
                cmbnolambung.Items.Add(rd("nopol"))
            End While
            rd.Close()
            If cmbnolambung.Items.Count <= 0 Then
                btntambah.Enabled = False
            End If
            If frmUjiKir.start = 0 Then cmbnolambung.SelectedIndex = 0
            If frmUjiKir.start = 1 Then cmbnolambung.SelectedIndex = frmUjiKir.idx
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmUjiKir.ShowDialog()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        If ceksimpan() Then
            If txtNoKir.ReadOnly = False Then
                Try
                    conn.Open()
                    Dim nolam = New SqlCommand("select nolambung from tkendaraan where nopol='" & cmbnolambung.SelectedItem & "'", conn).ExecuteScalar
                    '                Dim cmd = New SqlCommand("insert into tujikir(nokir,nolambung,tglkir,tglkirberikutnya,keterangan,createdate,updatedate) values (@nokir,@nolam,@datekir,@datekirberikut,@keterangan,@create,@update)", conn)
                    Dim cmd = New SqlCommand("insert into tujikir(nokir,nolambung,tglkir,tglkirberikutnya,keterangan) values (@nokir,@nolam,@datekir,@datekirberikut,@keterangan)", conn)
                    cmd.Parameters.AddWithValue("@nokir", txtNoKir.Text)
                    cmd.Parameters.AddWithValue("@nolam", nolam)
                    cmd.Parameters.AddWithValue("@datekir", dtpKir.Value.Date)
                    cmd.Parameters.AddWithValue("@datekirberikut", dtpKirBerikutnya.Value.Date)
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                    'cmd.Parameters.AddWithValue("@create", Now)
                    'cmd.Parameters.AddWithValue("@update", Now)
                    cmd.ExecuteNonQuery()
                    frmUjiKir.refreshdata()
                    txtNoKir.Text = ""
                    cmbnolambung.SelectedIndex = 0
                    txtKeterangan.Text = ""
                    _rjcommon.shownotify("Transaksi Uji Kir berhasil ditambahkan")
                    _rjcommon.isilog(_rjcommon.getusername, txtNoKir.Text, "Transaksi Uji Kir", "Tambah Data", "")
                    conn.Close()
                    'jun
                    Me.Close()
                Catch ex As Exception
                    _rjcommon.shownotify("Transaksi Uji Kir gagal ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtNoKir.Text, "Transaksi Uji Kir", "Tambah Data", ex.Message)
                    conn.Close()
                End Try
            ElseIf txtNoKir.ReadOnly = True Then
                Try
                    conn.Open()
                    Dim nolam = New SqlCommand("select nolambung from tkendaraan where nopol='" & cmbnolambung.SelectedItem & "'", conn).ExecuteScalar
                    Dim cmd = New SqlCommand("update tujikir set nolambung=@nolam,tglkir=@datekir,tglkirberikutnya=@datekirberikut,keterangan=@keterangan where nokir=@nokir", conn)
                    cmd.Parameters.AddWithValue("@nokir", txtNoKir.Text)
                    cmd.Parameters.AddWithValue("@nolam", nolam)
                    cmd.Parameters.AddWithValue("@datekir", dtpKir.Value.Date)
                    cmd.Parameters.AddWithValue("@datekirberikut", dtpKirBerikutnya.Value.Date)
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                    cmd.ExecuteNonQuery()
                    frmUjiKir.refreshdata()
                    _rjcommon.shownotify("Transaksi Uji Kir berhasil diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtNoKir.Text, "Transaksi Uji Kir", "Update Data", "")
                    conn.Close()
                    Me.Close()
                Catch ex As Exception
                    _rjcommon.shownotify("Transaksi Uji Kir gagal diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtNoKir.Text, "Transaksi Uji Kir", "Update Data", ex.Message)
                    conn.Close()
                    Me.Close()
                End Try
                frmUjiKir.start = 0
                frmUjiKir.idx = 0
            End If
        Else
            MsgBox("Ada Isian Yang Salah !")
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub
End Class