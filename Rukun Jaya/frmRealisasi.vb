Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmRealisasi
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    Public Sub panggil()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim command As String
        'jun 19 jan 2015
        command = "Select k.nopol,k.merek,tbm.status,nobm,tgl,k.nolambung,tsopir.namasopir as namasopir,keterangan "
        command &= "from tbm,tsopir,tkendaraan k "
        command &= "where tbm.nolambung=k.nolambung and tbm.kodesopir = tsopir.kodesopir and nobm ='" & txtNoBM.Text & "'"
        Dim cmd As New SqlCommand(command, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            lblnolambung.Text = reader("nolambung") & " / " & reader("nopol")
            lblnamasopir.Text = reader("namasopir")
        End While
        reader.Close()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmBrowseBM.kode = 1
        frmBrowseBM.ShowDialog()
    End Sub

    Private Sub frmRealisasi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNoBM.Text = ""
        txtKodeRealisasi.Text = ""
        txtketerangan.Text = ""
        txtdebet.Text = 0
        txtkredit.Text = 0
        dtptanggal.Value = Now
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtNoBM_Leave(sender As System.Object, e As System.EventArgs) Handles txtNoBM.Leave
        If Trim(txtNoBM.Text) <> "" Then
            panggil()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "insert into trealisasi(koderealisasi,tanggal,biayadebet,biayakredit,keterangan,nobm) values (@koderealisasi,@tanggal,@biayadebet,@biayakredit,@keterangan,@nobm)"
            cmd.Parameters.AddWithValue("@koderealisasi", txtKodeRealisasi.Text)
            cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value)
            cmd.Parameters.AddWithValue("@biayadebet", txtdebet.Text)
            cmd.Parameters.AddWithValue("@biayakredit", txtkredit.Text)
            cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
            cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)

            cmd.ExecuteNonQuery()
            _rjcommon.shownotify("Data Transaksi Realisasi Berhasil Ditambahkan")
            _rjcommon.isilog(_rjcommon.getusername, txtKodeRealisasi.Text, "Transaksi Realisasi", "Tambah Data", txtKodeRealisasi.Text)
            conn.Close()
            Me.Close()

        Catch ex As Exception
            _rjcommon.shownotifyerror("Data Master Biaya Tidak Berhasil Ditambahkan")
            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeRealisasi.Text, "Transasksi Realisasi", "Tambah Data", ex.Message)
            conn.Close()
        End Try
    End Sub
End Class