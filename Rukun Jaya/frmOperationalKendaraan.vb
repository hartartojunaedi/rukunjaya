Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmOperationalKendaraan
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim _rjcommon As New RJCommon
    Dim rlib As New rjLib
    Dim initialisasi As Boolean = True
    Private Sub initkendaraan()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("", con)
        cmd.CommandText = "SELECT nolambung, nopol FROM tkendaraan order by nopol"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dt.NewRow
        dr.Item("nolambung") = ""
        dr.Item("nopol") = "- Semua -"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbKendaraan.DataSource = dt
        cmbKendaraan.DisplayMember = "nopol"
        cmbKendaraan.ValueMember = "nolambung"
        cmbKendaraan.Refresh()
        initialisasi = False
    End Sub
    Private Sub init()
        con = New SqlConnection
        con.ConnectionString = _rjcommon.getconnstr()
        dtpFromTglTransaksi.Value = New Date(Now.Year, Now.Month, 1)
        dtpToTglTransaksi.Value = Now.Date
        initkendaraan()
        btnFilter.PerformClick()
    End Sub
    Private Sub frmOperationalKendaraan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub AdjustColumnOrder()
        With dgvBiayaOperationalKendaraan
            .Columns("TglTransaksi").DisplayIndex = 0
            .Columns("nopol").DisplayIndex = 1
            .Columns("keterangan").DisplayIndex = 2
            .Columns("jumlah").DisplayIndex = 3
            .Columns("harga").DisplayIndex = 4
            .Columns("subtotal").DisplayIndex = 5
        End With

    End Sub
    Private Sub refreshgrid()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("", con)
        cmd.Parameters.Clear()
        ' cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, FORMAT(op.harga, 'N') as biaya, jOp.namajenis, sop.namasopir, op.keterangan FROM tOperational op"
        cmd.CommandText = "select ok.kodetransaksi,ok.tgltransaksi,ok.keterangan,ok.jumlah,ok.harga,(ok.jumlah*ok.harga) as subtotal,k.nopol,'ubah' as btn,'hapus' as btn2"
        cmd.CommandText &= " from toperationalkendaraan ok,tkendaraan k"
        cmd.CommandText &= " where ok.nolambung=k.nolambung"
        cmd.CommandText &= " and ok.tgltransaksi BETWEEN @from AND @to"
        If cmbKendaraan.SelectedValue <> "" Then
            cmd.CommandText &= " AND k.nopol = @nopol "
            cmd.Parameters.Add(New SqlParameter("@nopol", cmbKendaraan.SelectedValue))
        End If
        cmd.CommandText &= " ORDER BY ok.tgltransaksi"
        'jun 03 feb 2015
        'cmd.Parameters.Add(New SqlParameter("@from", dtpFromTglTransaksi.Value.ToString("yyyy-MM-dd")))
        'cmd.Parameters.Add(New SqlParameter("@to", dtpToTglTransaksi.Value.ToString("yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@from", dtpFromTglTransaksi.Value.Date))
        cmd.Parameters.Add(New SqlParameter("@to", dtpToTglTransaksi.Value.Date))
        Try
            dt = New DataTable
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'cmd.CommandText &= " LEFT JOIN tSopir ON kodesopir=kode"
        'AdjustColumnOrder()
        dgvBiayaOperationalKendaraan.DataSource = dt
        'refresh detil master biaya lain
        'hitung jumlah data sekarang
        lblJumlahData.Text = dt.Rows.Count
        Dim total As Decimal = 0
        For Each item As DataRow In dt.Rows
            'TODO : masih ada kesalahan
            total += Convert.ToDecimal((item.Item("subtotal")))
        Next
        lblTotalBiaya.Text = Format(total, "N")
    End Sub
    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click, dtpToTglTransaksi.ValueChanged, dtpFromTglTransaksi.ValueChanged
        If initialisasi = False Then
            refreshgrid()
        End If
    End Sub
    Private Sub hapusdata(kodetransaksi As String)
        If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Try
                cmd = New SqlCommand("", con)
                cmd.Parameters.Clear()
                cmd.CommandText = "DELETE FROM tOperationalkendaraan WHERE kodetransaksi=@kodetransaksi"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodetransaksi))
                cmd.ExecuteNonQuery()
                _rjcommon.shownotify("Operational kendaraan berhasil dihapus")
                _rjcommon.isilog(_rjcommon.getusername, kodetransaksi, "Transaksi Operational Kendaraan", "Hapus Data", "")
                refreshgrid()
            Catch ex As Exception
                MsgBox(ex.Message)
                _rjcommon.isiErrorlog(_rjcommon.getusername, kodetransaksi, "Transaksi Operational Kendaraan", "Hapus Data", ex.Message)
                _rjcommon.shownotifyerror("Hapus Data Gagal")
            End Try
        End If
    End Sub
    Private Sub dgvBiayaLain_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaOperationalKendaraan.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If e.ColumnIndex = 7 Then 'Tombol Update
            '  frmDetailBiayaLain.insert = False 'mode update
            'jun 16 feb 2015
            ' frmDetailBiayaLain.kodeTransaksi = dgvBiayaLain.Rows(e.RowIndex).Cells("txtkodetransaksi").Value
            'frmDetailBiayaLain.kodeTransaksi = dt.Rows(e.RowIndex).Item("kodetransaksi").ToString
            'frmDetailBiayaLain.ShowDialog()
            frmDetailOperationalKendaraan.insert = False 'mode update
            frmDetailOperationalKendaraan.kodeTransaksi = dgvBiayaOperationalKendaraan.Rows(e.RowIndex).Cells("txtkodetransaksi").Value
            frmDetailOperationalKendaraan.ShowDialog()
            refreshgrid()
        ElseIf e.ColumnIndex = 8 Then 'Tombol Delete
            'jun 16 feb 2015
            'DeleteData(dgvBiayaLain.Rows(e.RowIndex).Cells("txtkodetransaksi").Value)
            hapusdata(dgvBiayaOperationalKendaraan.Rows(e.RowIndex).Cells("txtkodetransaksi").Value)
        End If
    End Sub

    Private Sub dgvBiayaLain_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaOperationalKendaraan.CellContentClick

    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmDetailOperationalKendaraan.insert = True 'mode insert
        frmDetailOperationalKendaraan.ShowDialog()
        refreshgrid()
        dtpFromTglTransaksi.Focus() 'kembalikan focus ke search
    End Sub
End Class