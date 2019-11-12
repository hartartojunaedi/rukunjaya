Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUjiKir
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim btnUbahDgv As New DataGridViewButtonColumn()
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim ds As DataSet
    Public start = 0
    Public idx = 0

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand()
        Dim adp As New SqlDataAdapter
        cmd.Connection = conn
        cmd.CommandText = cmdstring
        If cbktglkir.Checked = True Then
            cmd.CommandText &= " and tglkir  >=@tgl1 and tglkir  <=@tgl2"
            cmd.Parameters.AddWithValue("@tgl1", dtpKir.Value.Date)
            cmd.Parameters.AddWithValue("@tgl2", dtpkir2.Value.Date)
        End If

        If cbktglkirberikutnya.Checked = True Then
            cmd.CommandText &= "and tglkirberikutnya  >=@tgl3 and tglkirberikutnya <=@tgl4 "
            cmd.Parameters.AddWithValue("@tgl3", dtpKirBerikutnya.Value.Date)
            cmd.Parameters.AddWithValue("@tgl4", dtpKirBerikutnya2.Value.Date)
        End If
        adp.SelectCommand = cmd

        Return adp
    End Function

    Public Sub refreshdata()
        conn.Open()
        ds = New DataSet
        'Dim csstring = "case status when 0 then 'sopir aktif' when 1 then 'karyawan aktif' else 'tidak aktif' end as newstatus"
        adapter("select nokir,nopol,convert(varchar,tglkir,105) as tglkir,convert(varchar,tglkirberikutnya,105) as tglkirberikutnya,keterangan from tujikir,tkendaraan where tujikir.nolambung=tkendaraan.nolambung").Fill(ds, "tujikir")
        dgvujikir.DataSource = ds.Tables("tujikir")
        conn.Close()
    End Sub

    Private Sub frmUjiKir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnUbahDgv.FlatStyle = FlatStyle.Flat
            dgvujikir.Columns.Add(btnUbahDgv)
            btnUbahDgv.Text = "Ubah"
            btnUbahDgv.HeaderText = "Ubah Data"
            btnUbahDgv.UseColumnTextForButtonValue = True

            btnHapusDgv.FlatStyle = FlatStyle.Flat
            dgvujikir.Columns.Add(btnHapusDgv)
            btnHapusDgv.Text = "Hapus"
            btnHapusDgv.HeaderText = "Hapus Data"
            btnHapusDgv.UseColumnTextForButtonValue = True

            refreshdata()
            'jun 26 jan 2015
            dtpKir.Value = New Date(Now.Year, Now.Month, 1).AddMonths(-2)
            dtpkir2.Value = Now.Date
            dtpKirBerikutnya.Value = New Date(Now.Year, Now.Month, 1)
            dtpKirBerikutnya2.Value = Now.Date
            start = 0
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub


    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click, txtcarinolambung.TextChanged, txtcarinokir.TextChanged, dtpKir.ValueChanged, dtpKirBerikutnya.ValueChanged, cbktglkirberikutnya.CheckedChanged, cbktglkir.CheckedChanged, dtpKirBerikutnya2.ValueChanged, dtpkir2.ValueChanged
        conn.Open()
        ds = New DataSet
        Dim cmdstr = "select nokir,nopol,convert(varchar,tglkir,105) as tglkir,convert(varchar,tglkirberikutnya,105) as tglkirberikutnya,keterangan from tujikir,tkendaraan where tujikir.nolambung=tkendaraan.nolambung and nokir like '%" & txtcarinokir.Text & "%' and nopol like '%" & txtcarinolambung.Text & "%'"
        'jun 26 jan 2015
        'If cbktglkir.Checked = True Then cmdstr &= " and tglkir  >= '" & dtpKir.Value.Date & "' and tglkir  <= '" & dtpkir2.Value.Date & "'"
        'If cbktglkirberikutnya.Checked = True Then cmdstr &= "and tglkirberikutnya  >= '" & dtpKirBerikutnya.Value.Date & "' and tglkirberikutnya  <= '" & dtpKirBerikutnya2.Value.Date & "'"
        adapter(cmdstr).Fill(ds, "tujikir")
        dgvujikir.DataSource = ds.Tables("tujikir")
        conn.Close()
    End Sub

    Private Sub dgvujikir_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvujikir.CellContentClick

        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            Dim id = dgvujikir.Rows(e.RowIndex).Cells(2).Value
            conn.Open()
            start = 1
            Dim frmDetailUjiKir As New frmDetailUjiKir
            frmDetailUjiKir.txtNoKir.ReadOnly = True
            frmDetailUjiKir.btnUpdate.Visible = False
            'jun 16 feb 2015
            frmDetailUjiKir.txtNoKir.Text = dgvujikir.Rows(e.RowIndex).Cells("nokir").Value
            '            frmDetailUjiKir.txtNoKir.Text = ds.Tables("tujikir").Rows(e.RowIndex)(0)
            frmDetailUjiKir.cmbnolambung.Items.Clear()
            Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
            While rd.Read
                frmDetailUjiKir.cmbnolambung.Items.Add(rd("nopol"))
            End While
            rd.Close()
            'jun 16 feb 2015
            Dim result = New SqlCommand("select nopol from tkendaraan where nolambung='" & dgvujikir.Rows(e.RowIndex).Cells("nopol").Value & "'", conn).ExecuteScalar
            idx = frmDetailUjiKir.cmbnolambung.FindString(dgvujikir.Rows(e.RowIndex).Cells("nopol").Value)
            'Dim result = New SqlCommand("select nopol from tkendaraan where nolambung='" & ds.Tables("tujikir").Rows(e.RowIndex)(1) & "'", conn).ExecuteScalar
            'idx = frmDetailUjiKir.cmbnolambung.FindString(ds.Tables("tujikir").Rows(e.RowIndex)(1))
            'jun 16 feb 2015
            Dim getdate = New SqlCommand("select tglkir from tujikir where nokir ='" & dgvujikir.Rows(e.RowIndex).Cells("nokir").Value & "' ", conn).ExecuteScalar
            '   Dim getdate = New SqlCommand("select tglkir from tujikir where nokir ='" & ds.Tables("tujikir").Rows(e.RowIndex)(0) & "' ", conn).ExecuteScalar
            frmDetailUjiKir.dtpKir.Value = getdate

            getdate = New SqlCommand("select tglkirberikutnya from tujikir where nokir ='" & dgvujikir.Rows(e.RowIndex).Cells("nokir").Value & "' ", conn).ExecuteScalar
            '            getdate = New SqlCommand("select tglkirberikutnya from tujikir where nokir ='" & ds.Tables("tujikir").Rows(e.RowIndex)(0) & "' ", conn).ExecuteScalar
            frmDetailUjiKir.dtpKirBerikutnya.Value = getdate
            'jun 16 feb 2015
            frmDetailUjiKir.txtKeterangan.Text = dgvujikir.Rows(e.RowIndex).Cells("keterangan").Value
            ' frmDetailUjiKir.txtKeterangan.Text = ds.Tables("tujikir").Rows(e.RowIndex)(4)
            conn.Close()
            frmDetailUjiKir.ShowDialog()
        ElseIf e.RowIndex > -1 And e.ColumnIndex = 1 Then
            'jun 16 feb 2015
            '            Dim id = dgvujikir.Rows(e.RowIndex).Cells(2).Value
            Dim id = dgvujikir.Rows(e.RowIndex).Cells("nokir").Value

            Try

                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    conn.Open()
                    Dim cmd = New SqlCommand("delete from tujikir where nokir='" & id & "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    refreshdata()
                    _rjcommon.shownotify("Transaksi Uji Kir berhasil dihapus")
                    _rjcommon.isilog(_rjcommon.getusername, id, "Transaksi UjiKir", "Hapus Data", "")
                    conn.Close()
                End If
            Catch ex As Exception
                _rjcommon.shownotify("Transaksi Uji Kir gagal dihapus")
                _rjcommon.isiErrorlog(_rjcommon.getusername, id, "Transaksi UjiKir", "Hapus Data", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
End Class