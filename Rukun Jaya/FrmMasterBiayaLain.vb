Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class FrmMasterBiayaLain
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dt As DataTable
    Dim _rjcommon As New RJCommon
    Dim rlib As New rjLib
    Dim initializing As Boolean = False
    Private Sub init()
        initializing = True
       
        dtpFromTglTransaksi.Select()
        
        'init form
        Try
            'jun 26 jan 2015
            con = New SqlConnection
            con.ConnectionString = _rjcommon.getconnstr()
            'con.ConnectionString = "Server=RENATO-PC\SQLEXPRESS;Database=RukunJayaDb;Integrated Security=SSPI"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand("", con)
            initCmbSopir()
            initCmbJenis()
            dtpFromTglTransaksi.Value = New DateTime(Now.Year, Now.Month, 1, 0, 0, 1)
            refreshGridView()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmMasterBiayaLain_Load", "Transaksi Biaya Operasional", "Initializing", ex.Message)
            _rjcommon.shownotifyerror("Inisialisasi gagal")
        Finally
            initializing = False
        End Try
    End Sub

    Private Sub initCmbJenis()
        cmd.CommandText = "SELECT kodejenis, namajenis FROM tJenisOperational WHERE jenis=0"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodejenis") = ""
        dr.Item("namajenis") = "-- Semua --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbJenis.DataSource = dt
        cmbJenis.DisplayMember = "namajenis"
        cmbJenis.ValueMember = "kodejenis"
    End Sub

    Private Sub initCmbSopir()
        'jun 19 april 2016 sopir dan karyawan
        cmd.CommandText = "SELECT kodesopir, namasopir FROM tSopir WHERE status=1 or status=0"
        cmd.Parameters.Clear()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim dr As DataRow = dt.NewRow
        dr.Item("kodesopir") = ""
        dr.Item("namasopir") = "-- Semua --"
        dr.EndEdit()
        dt.Rows.InsertAt(dr, 0)
        cmbKaryawan.DataSource = dt
        cmbKaryawan.DisplayMember = "namasopir"
        cmbKaryawan.ValueMember = "kodesopir"
    End Sub

    Private Sub refreshGridView()
        cmd.Parameters.Clear()
        ' cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, FORMAT(op.harga, 'N') as biaya, jOp.namajenis, sop.namasopir, op.keterangan FROM tOperational op"
        cmd.CommandText = "SELECT op.kodetransaksi, op.tgltransaksi, op.harga as biaya, jOp.namajenis, sop.namasopir, op.keterangan FROM tOperational op"
        cmd.CommandText &= " LEFT JOIN tJenisOperational jOp ON jOp.kodejenis=op.jenis "
        cmd.CommandText &= " LEFT JOIN tSopir sop ON sop.kodesopir=op.kode "
        cmd.CommandText &= " WHERE op.tgltransaksi BETWEEN @from AND @to AND (op.jenis IS NULL OR op.jenis IN(SELECT kodejenis FROM tJenisOperational WHERE jenis=0))"
        cmd.CommandText &= " AND (op.kode IS NULL OR op.kode IN(SELECT kodesopir FROM tSopir WHERE status=1 or status=0))"
        If cmbJenis.SelectedValue <> "" Then
            cmd.CommandText &= " AND jOp.kodejenis = @kodejenis "
            cmd.Parameters.Add(New SqlParameter("@kodejenis", cmbJenis.SelectedValue))
        End If
        If cmbKaryawan.SelectedValue <> "" Then
            cmd.CommandText &= " AND sop.kodesopir = @kode "
            cmd.Parameters.Add(New SqlParameter("@kode", cmbKaryawan.SelectedValue))
        End If
        cmd.CommandText &= " ORDER BY op.tgltransaksi"
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
        dgvBiayaLain.DataSource = dt
        'refresh detil master biaya lain
        'hitung jumlah data sekarang
        lblJumlahData.Text = dt.Rows.Count
        Dim total As Decimal = 0
        For Each item As DataRow In dt.Rows
            'TODO : masih ada kesalahan
            total += Convert.ToDecimal((item.Item("biaya")))
        Next
        lblTotalBiaya.Text = Format(total, "N")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmDetailBiayaLain.insert = True 'mode insert
        frmDetailBiayaLain.ShowDialog()
        refreshGridView()
        dtpFromTglTransaksi.Focus() 'kembalikan focus ke search
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        refreshGridView()
    End Sub

    Private Sub FrmMasterBiayaLain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' dtpFromTglTransaksi.Value = New Date(Now.Year, Now.Month, 1)

        init()
    End Sub

    Private Sub DeleteData(ByVal kodetransaksi As String)
        If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Try
                cmd.CommandText = "DELETE FROM tOperational WHERE kodetransaksi=@kodetransaksi"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@kodetransaksi", kodetransaksi))
                cmd.ExecuteNonQuery()
                _rjcommon.shownotify("Biaya lain berhasil dihapus")
                _rjcommon.isilog(_rjcommon.getusername, kodetransaksi, "Transaksi Biaya Operasional", "Hapus Data", "")
                refreshGridView()
            Catch ex As Exception
                MsgBox(ex.Message)
                _rjcommon.isiErrorlog(_rjcommon.getusername, kodetransaksi, "Transaksi Biaya Operasional", "Hapus Data", ex.Message)
                _rjcommon.shownotifyerror("Hapus Data Gagal")
            End Try
        End If
    End Sub

    Private Sub dgvBiayaLain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBiayaLain.CellClick
        'harus ada data yang dipilih
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        If e.ColumnIndex = 0 Then 'Tombol Update
            frmDetailBiayaLain.insert = False 'mode update
            'jun 16 feb 2015
            frmDetailBiayaLain.kodeTransaksi = dgvBiayaLain.Rows(e.RowIndex).Cells("txtkodetransaksi").Value
            'frmDetailBiayaLain.kodeTransaksi = dt.Rows(e.RowIndex).Item("kodetransaksi").ToString
            frmDetailBiayaLain.ShowDialog()
            refreshGridView()
        ElseIf e.ColumnIndex = 1 Then 'Tombol Delete
            'jun 16 feb 2015
            DeleteData(dgvBiayaLain.Rows(e.RowIndex).Cells("txtkodetransaksi").Value)
        End If
    End Sub

    Private Sub dtpFromTglTransaksi_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpFromTglTransaksi.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpToTglTransaksi.Focus()
        End If
    End Sub

    Private Sub dtpToTglTransaksi_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpToTglTransaksi.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbJenis.Focus()
        End If
    End Sub

    Private Sub cmbJenis_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbJenis.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbKaryawan.Focus()
        End If
    End Sub

    Private Sub cmbKaryawan_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbKaryawan.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnFilter.Focus()
        End If
    End Sub

    Private Sub cmbJenis_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbJenis.Validating
        If cmbJenis.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbKaryawan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbKaryawan.Validating
        If cmbKaryawan.SelectedIndex = -1 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub dtpTglTransaksi_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromTglTransaksi.ValueChanged, dtpToTglTransaksi.ValueChanged
        btnFilter.PerformClick()
    End Sub

    Private Sub cmb_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedValueChanged, cmbKaryawan.SelectedValueChanged
        If Not initializing Then
            btnFilter.PerformClick()
        End If
    End Sub

    Private Sub dgvBiayaLain_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaLain.CellContentClick

    End Sub
End Class