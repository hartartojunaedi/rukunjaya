Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseBM
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    Public kode As Integer = 0
    
    Sub panggil()
        Dim command As String
        command = "Select nobm,tgl,nolambung,namasopir,keterangan from tbm,tsopir where tsopir.kodesopir = tbm.kodesopir and tgl>=@tgl1 and tgl<=@tgl2 and nobm like '%" & txtnobm.Text & "%'"
        ds.Clear()
        'jun 14 jan 2015
        Dim cmd As New SqlCommand(command, conn)
        cmd.Parameters.AddWithValue("@tgl1", dtTglAwal.Value.Date)
        cmd.Parameters.AddWithValue("@tgl2", dtTglAkhir.Value.Date)
        Try
            conn.Open()
            isidataset(cmd)
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "bm")
        dgvKendaraan.DataSource = ds
        dgvKendaraan.DataMember = "bm"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dgvKendaraan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick
        'jun 19 jan 2015
        'frmInputBM.lblnolambung.Text = dgvKendaraan.Rows(e.RowIndex).Cells("nolambung").Value
        'frmInputBM.lblnamasopir.Text = dgvKendaraan.Rows(e.RowIndex).Cells("namasopir").Value
        'frmInputBM.dtptanggal.Text = dgvKendaraan.Rows(e.RowIndex).Cells("tgl").Value
        'frmInputBM.lblketerangan.Text = dgvKendaraan.Rows(e.RowIndex).Cells("keterangan").Value
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If kode = 0 Then
                frmInputBM.txtnobm.Text = dgvKendaraan.Rows(e.RowIndex).Cells("nobm").Value
                frmInputBM.panggil()
            End If
            If kode = 1 Then
                frmRealisasi.txtNoBM.Text = dgvKendaraan.Rows(e.RowIndex).Cells("nobm").Value
                frmRealisasi.Panggil()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frmBrowseBM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtTglAwal.Value = New Date(Now.Year, Now.Month, 1, 0, 0, 1)
        dtTglAkhir.Value = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        panggil()
    End Sub
    Private Sub txtnomesin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnobm.KeyUp
        panggil()
    End Sub
    Private Sub txtnopol_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        panggil()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        panggil()
    End Sub

    Private Sub dtTglAwal_ValueChanged_1(sender As System.Object, e As System.EventArgs) Handles dtTglAwal.ValueChanged, dtTglAkhir.ValueChanged
        panggil()
    End Sub
End Class