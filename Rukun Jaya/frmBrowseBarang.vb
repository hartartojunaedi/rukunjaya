Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseBarang
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    Public jenis As String
    Sub panggil()
        Dim command As New SqlCommand(" ", conn)
        command.Parameters.Clear()
        command.CommandText = "Select kodebarang,namabarang,satuan from tbarang where jenispekerjaan = @1"
        command.Parameters.AddWithValue("@1", jenis)
        If txtkodebarang.Text <> "" Then
            command.CommandText &= " and kodebarang like '%" + txtkodebarang.Text + "%'"
            '  command.Parameters.AddWithValue("@2", txtkodebarang.Text)
        End If
        If txtnamabarang.Text <> "" Then
            command.CommandText &= " and namabarang like '%" + txtnamabarang.Text + "%'"
            ' command.CommandText &= " and namabarang like '%@3%'"
            ' command.Parameters.AddWithValue("@3", txtnamabarang.Text)
        End If
       

        ds.Clear()
        Try
            conn.Open()
            isidataset(command)
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "barang")
        dgvKendaraan.DataSource = ds
        dgvKendaraan.DataMember = "barang"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub



    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dgvKendaraan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick
        'frmDetailSuratJalanOld.txtkodebarang.Text = dgvKendaraan.Rows(e.RowIndex).Cells("kodebarang").Value
        'frmDetailSuratJalanOld.lblnamabarang.Text = dgvKendaraan.Rows(e.RowIndex).Cells("namabarang").Value
        'Me.Close()
        frmDetailSuratJalan.txtkodebarang.Text = dgvKendaraan.Rows(e.RowIndex).Cells("kodebarang").Value
        frmDetailSuratJalan.lblnamabarang.Text = dgvKendaraan.Rows(e.RowIndex).Cells("namabarang").Value
        Me.Close()

    End Sub

    Private Sub frmBrowseBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil()
    End Sub


    Private Sub txtnomesin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkodebarang.KeyUp
        panggil()
    End Sub


    Private Sub txtnopol_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnamabarang.KeyUp
        panggil()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        panggil()
    End Sub

    Private Sub dgvKendaraan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellContentClick

    End Sub
End Class