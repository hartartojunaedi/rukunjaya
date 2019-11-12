﻿Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmbayardetailtagihanspbu
    Public dnotagihan, dkodevoucher As String
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim row As String()
    Dim transaction As SqlTransaction
    Dim init As Boolean = True
    Sub clear()
        dtptglbayar.Value = Date.Now
        txtnotagihan.Text = ""
        txtnonota.Text = ""
        txtketerangan.Text = ""
        dtptgl.Value = Date.Now
        lblrupiah.Text = "0"
        lblkasbon.Text = "0"
        lblgrandtotal.Text = "0"
        lbltotalliter.Text = "0"
        txthargaperliter.Text = _rjcommon.gethargabbm
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        If lblmode.Text.ToLower = "tambah" Then
            cmd.CommandText = "Select dt.kodevoucher,nobm,nosuratjalan,tvoucherspbu.liter,sisa,dt.liter as tagih,rupiahsatuan,dt.rupiah,tglvoucher,kasbon from tvoucherSPBU, tdtagihanspbu dt where 0=1 and dt.kodevoucher=tvoucherspbu.kodevoucher"
        Else
            cmd.CommandText = "Select dt.kodevoucher,nobm,nosuratjalan,tvoucherspbu.liter,sisa, dt.liter as tagih,rupiahsatuan,dt.rupiah,tglvoucher,kasbon from tvoucherSPBU, tdtagihanspbu dt where dt.kodevoucher=tvoucherspbu.kodevoucher and notagihan=@notagihan"
            cmd.Parameters.AddWithValue("@notagihan", dnotagihan)
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        da.Fill(ds1, "detail")

        dgvdetail.DataSource = ds1.Tables(0)
        dgvdetail.Refresh()


        conn.Close()
    End Sub
    Sub hitung_total()
        Dim totalbayar, kasbon, grandtotal, totalliter As Long
        totalbayar = 0
        kasbon = 0
        grandtotal = 0
        totalliter = 0

        For i As Integer = 0 To dgvdetail.Rows.Count - 1

            dgvdetail.Rows(i).Cells("rupiah").Value = dgvdetail.Rows(i).Cells("tagih").Value * txthargaperliter.Text
            totalbayar += dgvdetail.Rows(i).Cells("rupiah").Value
            kasbon += dgvdetail.Rows(i).Cells("kasbon").Value
            totalliter += dgvdetail.Rows(i).Cells("tagih").Value
        Next
        grandtotal = totalbayar + kasbon
        lblrupiah.Text = totalbayar.ToString("##,#")
        lblkasbon.Text = kasbon.ToString("##,#")
        lblgrandtotal.Text = grandtotal.ToString("##,#")
        lbltotalliter.Text = totalliter.ToString("##.#")
    End Sub
    Sub cek_kodespbu()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "Select kodespbu,namaspbu from tSPBU"
        Dim adapter1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        adapter1.SelectCommand = cmd
        adapter1.Fill(ds1)

        cbspbu.DataSource = ds1.Tables(0)
        cbspbu.ValueMember = "kodespbu"
        cbspbu.DisplayMember = "namaspbu"
        ' cbspbu.SelectedIndex = -1
        conn.Close()
    End Sub
    Sub cek_kodebank()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "Select kodebank,namabank from tbank"
        Dim adapter1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        adapter1.SelectCommand = cmd
        adapter1.Fill(ds1)
        cbbank.DataSource = ds1.Tables(0)
        cbbank.ValueMember = "kodebank"
        cbbank.DisplayMember = "namabank"

        conn.Close()
    End Sub
    'Private Sub dgvdetail_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvdetail.CellEndEdit
    '    '  MsgBox(e.ColumnIndex)
    '    If e.ColumnIndex = 4 Then 'tagih diubah

    '        'cek tagih tidak boleh lebih besar dari sisa
    '        If dgvdetail.Rows(e.RowIndex).Cells("tagih").Value > dgvdetail.Rows(e.RowIndex).Cells("sisa").Value Then
    '            MsgBox("Tagih tidak boleh lebih besar dari sisa")
    '        Else
    '            'cek jika diubah sisanya lakukan perhitungan ulang pada grandtotal
    '            dgvdetail.Rows(e.RowIndex).Cells("rupiah").Value = (dgvdetail.Rows(e.RowIndex).Cells("liter").Value - dgvdetail.Rows(e.RowIndex).Cells("sisa").Value) * dgvdetail.Rows(e.RowIndex).Cells("rupiahsatuan").Value
    '            hitung_total()
    '        End If
    '    ElseIf e.ColumnIndex = 9 Then
    '        hitung_total()
    '    End If
    'End Sub
    'Function cek_tagih() As Boolean
    '    Dim kosong As Boolean = False
    '    For i As Integer = 0 To dgvdetail.Rows.Count - 1
    '        If IsNothing(dgvdetail.Rows(i).Cells("tagih").Value) Then
    '            kosong = True
    '        End If
    '    Next
    '    Return kosong
    'End Function
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim ok As Boolean = True
        'cek apakah nomor tagihan, nonota sudah diisi
        If cbbank.SelectedIndex = -1 Then
            MsgBox("Nama bank belum diisi")
        ElseIf cbcarabayar.SelectedIndex = -1 Then
            MsgBox("Cara Bayar belum diisi")
        ElseIf txttotbayar.Text = "" Then
            MsgBox("Jumlah bayar belum diisi")
        Else
            If CInt(txttotbayar.Text) > CInt(lblgrandtotal.Text) Then
                If MsgBox("Pembayaran lebih besar dari tagihan. Yakin?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then
                    ok = False
                End If
            End If
            If ok Then
                'simpan
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim cmd As New SqlCommand("", conn)
                Try
                    'MsgBox(cbspbu.SelectedValue.ToString)
                    transaction = conn.BeginTransaction("SampleTransaction")
                    cmd.Transaction = transaction
                    'insert header dulu
                    cmd.Parameters.Clear()
                    cmd.CommandText = "update thtagihanspbu set carabayar=@cara,kodebank=@kode,tglbayar=@tglbayar,noref=@noref,totalbayar=@tot where notagihan=@notagihan"
                    cmd.Parameters.AddWithValue("@notagihan", txtnotagihan.Text)
                    cmd.Parameters.AddWithValue("@tglbayar", dtptglbayar.Value)
                    cmd.Parameters.AddWithValue("@kode", cbbank.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@cara", cbcarabayar.SelectedIndex)
                    cmd.Parameters.AddWithValue("@noref", txtnoref.Text)
                    cmd.Parameters.AddWithValue("@tot", txttotbayar.Text)
                    cmd.ExecuteNonQuery()

                    'jun 20 feb 2015
                    'update saldo bank
                    _rjcommon.updatesaldo(cbbank.SelectedValue.ToString, txttotbayar.Text, False)
                    'insert detail
                    For i As Integer = 0 To dgvdetail.Rows.Count - 1
                        'ubah status jadi 3 yang artinya sudah diperiksa
                        cmd.Parameters.Clear()
                        cmd.CommandText = "update tvoucherspbu set status=3 where kodevoucher=@kodevoucher"
                        cmd.Parameters.AddWithValue("@kodevoucher", dgvdetail.Rows(i).Cells("kodevoucher").Value)
                        cmd.ExecuteNonQuery()

                    Next


                    Dim log As String = "notagihan=" & txtnotagihan.Text & vbCrLf & " grandtotal =" & lblgrandtotal.Text
                    _rjcommon.isilog(_rjcommon.getusername, txtnotagihan.Text, "Bayar Tagihan SPBU", "Tambah Data", log)
                    _rjcommon.shownotify("Data Berhasil Disimpan")
                    transaction.Commit()
                    conn.Close()
                    Me.Close()



                Catch ex As Exception
                    transaction.Rollback()
                    conn.Close()
                    '  Dim log As String = "nota = " & txtNonota.Text & vbCrLf & " nama toko =" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text & " Error message  = " & ex.Message
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtnotagihan.Text, "Bayar Tagihan SPBU", "Tambah Data", ex.Message)
                    _rjcommon.shownotifyerror("Data Tidak Berhasil Disimpan")

                    'MsgBox(ex.Message)
                End Try

            End If
            End If
    End Sub
    Sub enabled_mode(ByVal mode As Boolean)

        dgvdetail.ReadOnly = mode
        txtnotagihan.ReadOnly = mode
        txtnonota.ReadOnly = mode
        txtketerangan.ReadOnly = mode
        dtptgl.Enabled = Not mode
        txthargaperliter.Text = _rjcommon.gethargabbm
        txthargaperliter.ReadOnly = mode
        cbspbu.Enabled = Not mode

    End Sub
    Private Sub frmdetailtagihanspbu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init = True
        clear()
        cek_kodebank()
        cek_kodespbu()
        init = False

        If lblmode.Text = "bayar" Then
            load_header()
            hitung_total()
            enabled_mode(True)
            'Else
            '    enabled_mode(False)
            '    isi_detail()
        End If

    End Sub
    Sub load_header()
        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "select * from thtagihanspbu where notagihan=@notagihan"
        cmd.Parameters.AddWithValue("@notagihan", dnotagihan)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                txtnotagihan.Text = dnotagihan
                txthargaperliter.Text = reader("harga")
                txtnonota.Text = reader("nota")
                lbltotalliter.Text = reader("totalliter")
                lblgrandtotal.Text = reader("grandtotal")
                lblkasbon.Text = reader("kasbontunai")
                lblrupiah.Text = reader("totalrupiah")
                cbbank.SelectedValue = reader("kodebank")
                dtptgl.Value = reader("tgl")
                txtketerangan.Text = reader("keterangan")
            End While
        End If
        reader.Close()

    End Sub
    

    Sub isi_detail()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "Select kodevoucher,nobm,nosuratjalan,liter,0 as tagih,sisa,rupiahsatuan,rupiah,tglvoucher,kasbon from tvoucherSPBU where sisa>0 and kodespbu=@kodespbu"
        cmd.Parameters.AddWithValue("@kodespbu", cbspbu.SelectedValue)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        da.Fill(ds1, "detail")
        If ds1.Tables(0).Rows.Count >= 0 Then
            dgvdetail.DataSource = ds1.Tables(0)
            dgvdetail.Refresh()

            hitung_total()
        Else
            MsgBox("Belum ada voucher yang ditagihkan")
        End If

    End Sub
    Private Sub cbspbu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbspbu.SelectedIndexChanged
        If init = False Then
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            isi_detail()
            conn.Close()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub txttotbayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotbayar.TextChanged

    End Sub

    Private Sub txttotbayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotbayar.KeyDown
        'cek total bayar harus sama ato lebih besar dari grandtotal
        If e.KeyCode = Keys.Enter Then
            If CInt(txttotbayar.Text) < CInt(lblgrandtotal.Text) Then
                MsgBox("Total Pembayaran harus lebih besar dari grand total")
            End If
        End If
    End Sub

    Private Sub dgvdetail_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetail.CellContentClick

    End Sub
End Class