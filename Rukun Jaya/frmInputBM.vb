Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmInputBM
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter

    Sub hitung()
        Dim total As Double = 0
        Dim cmd As New SqlCommand
        cmd.CommandText = "select isnull(sum(jumlah),0) as total from tdetailsuratjalan where nobm=@nobm"
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@nobm", txtnobm.Text)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        total = cmd.ExecuteScalar()
        conn.Close()
        lbltotalmuatan.Text = total
    End Sub
    Sub panggil()
        conn.Open()
        Dim command As String
        'jun 19 jan 2015
        command = "Select k.nopol,k.merek,tbm.status,nobm,tgl,k.nolambung,tsopir.namasopir as namasopir,keterangan "
        command &= "from tbm,tsopir,tkendaraan k "
        command &= "where tbm.nolambung=k.nolambung and tbm.kodesopir = tsopir.kodesopir and nobm ='" & txtnobm.Text & "'"
        Dim cmd As New SqlCommand(command, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            lblnolambung.Text = reader("nolambung") & " / " & reader("nopol")
            lblnamasopir.Text = reader("namasopir")
            lblketerangan.Text = reader("keterangan")
            dtptanggal.Text = reader("tgl")
            lblmerek.Text = reader("merek")
            lblstatus.Text = IIf(reader("status") = 0, "Open", "Proses")
        End While
        reader.Close()
        command = "select nosuratjalan,namasupplier,namaperwakilan,(select namagudang from tgudang where kodegudang=asal) as asal,(select namagudang from tgudang where kodegudang=tujuan) as tujuan,tsuratjalan.keterangan from tsuratjalan ,tsupplier,tperwakilan where tperwakilan.kodeperwakilan = tsuratjalan.kodeperwakilan and tsupplier.kodesupplier = tsuratjalan.kodesupplier and tsuratjalan.nobm ='" & txtnobm.Text & "'"

        ds.Clear()
        conn.Close()
        Try
            conn.Open()
            isidataset(New SqlCommand(command, conn))
            conn.Close()

        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        hitung()
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "suratjalan")
        dgvKendaraan.DataSource = ds
        dgvKendaraan.DataMember = "suratjalan"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub
    Sub clearlabel()
        txtnobm.Clear()
        lblketerangan.Text = ""
        lblnamasopir.Text = ""
        lblnolambung.Text = ""
        lblstatus.Text = ""
        lblmerek.Text = ""
    End Sub


    Public Sub New()

        InitializeComponent()

    End Sub
    Private Function cekbm(nobm As String) As Boolean
        Dim flag As Boolean = True
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "select status from tbm where nobm=@nobm"
        cmd.Parameters.AddWithValue("@nobm", nobm)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim status As Integer = cmd.ExecuteScalar()
        flag = IIf(status = 0, True, False)
        conn.Close()
        Return flag
    End Function
    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        'jun 20 jan 2015
        If Trim(txtnobm.Text) = "" Then
            MsgBox("Isi No BM terlebih dahulu")
        Else
            'baca status bm sudah dibuat totalan belum
            If cekbm(txtnobm.Text) Then
                frmDetailSuratJalan.lblMode.Text = "Tambah"
                frmDetailSuratJalan.nobm = txtnobm.Text
                frmDetailSuratJalan.Show()
            Else
                MsgBox("BM Tidak Boleh Ditambah Karena Sudah Diproses")
            End If
        End If
    End Sub

    Private Sub dgvKendaraan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick

    End Sub
    Private Sub frmInputBM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearlabel()
        panggil()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click

        frmBrowseBM.kode = 0
        frmBrowseBM.ShowDialog()
    End Sub


    Private Sub txtnobm_KeyUp(sender As Object, e As KeyEventArgs) Handles txtnobm.KeyUp
        If e.KeyCode = Keys.Enter Then
            panggil()
        End If
    End Sub

    Private Sub frmInputBM_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox)) And (Me.ActiveControl.GetType() = GetType(ComboBox)) And (Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
        '    Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtnobm_Leave(sender As Object, e As System.EventArgs) Handles txtnobm.Leave
        If Trim(txtnobm.Text) <> "" Then
            panggil()
        End If
    End Sub



    Private Sub dgvKendaraan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellContentClick
        'MsgBox(e.ColumnIndex)
        'jun 19 jan 2015
        If (e.ColumnIndex = 1) Then 'hapus then
            If (MessageBox.Show("Apakah yakin akan menghapus surat jalan serta detailnya?", "Konfirmasi", MessageBoxButtons.YesNo) _
                = Windows.Forms.DialogResult.Yes) Then
                'hapus data sesuai dengan data yang dipilih
                'hapus yang status=0
                'jun 21 jan 2015
                'jun 28 jan 2015 voucher
                If _rjcommon.cekstatusvoucherbbm(txtnobm.Text, dgvKendaraan.Rows(e.RowIndex).Cells("NoSuratJalan").Value) = 0 Then
                    If _rjcommon.cekstatussuratjalan(dgvKendaraan.Rows(e.RowIndex).Cells("NoSuratJalan").Value, txtnobm.Text) = 0 Then
                        Try
                            conn.Open()
                            Dim cmd As New SqlCommand("", conn)
                            cmd.Parameters.Clear()
                            cmd.CommandText = "delete from tdetailsuratjalan where nosuratjalan=@nosuratjalan and nobm=@nobm"
                            cmd.Parameters.AddWithValue("@nosuratjalan", dgvKendaraan.Rows(e.RowIndex).Cells(2).Value)
                            'jun 28 jan 2015
                            cmd.Parameters.AddWithValue("@nobm", txtnobm.Text)
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                            cmd.CommandText = "delete from tsuratjalan where nosuratjalan=@nosuratjalan and nobm=@nobm"
                            cmd.Parameters.AddWithValue("@nosuratjalan", dgvKendaraan.Rows(e.RowIndex).Cells(2).Value)
                            'jun 28 jan 2015
                            cmd.Parameters.AddWithValue("@nobm", txtnobm.Text)
                            cmd.ExecuteNonQuery()
                            'jun 20 jan 2015
                            _rjcommon.isilog(_rjcommon.getusername, dgvKendaraan.Rows(e.RowIndex).Cells("NoSuratJalan").Value, "Transaksi Surat Jalan", "Hapus Data", "")
                            'kurangi ritase
                            _rjcommon.decreaseritase(txtnobm.Text)
                            MsgBox("Surat Jalan Berhasil Dihapus")
                            conn.Close()
                            panggil()
                        Catch ex As Exception
                            MessageBox.Show("Surat Jalan Tidak Berhasil Dihapus")
                            conn.Close()
                            'jun 20 jan 2015
                            _rjcommon.isiErrorlog(_rjcommon.getusername, dgvKendaraan.Rows(e.RowIndex).Cells("NoSuratJalan").Value, "Transaksi Surat Jalan", "Hapus Data", ex.Message)

                        End Try
                    Else
                        MsgBox("Surat Jalan Tidak Boleh Dihapus !")
                    End If
                Else
                    MsgBox("Surat Jalan Tidak Boleh Dihapus ada voucher spbu")
                End If
            End If
        ElseIf (e.ColumnIndex = 0) Then 'detail
            frmDetailSuratJalan.lblMode.Text = "Ubah"
            frmDetailSuratJalan.nosuratjalan = dgvKendaraan.Rows(e.RowIndex).Cells("nosuratjalan").Value
            frmDetailSuratJalan.nobm = txtnobm.Text
            frmDetailSuratJalan.Show()
        End If
    End Sub
End Class