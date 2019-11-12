Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmMutasiKeluar
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim btnUbahDgv As New DataGridViewButtonColumn()
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim idx
    Public start

    Sub loaddata()
        Dim da As New SqlDataAdapter("select id,nospk,convert(varchar,tgl,105) as tgltransaksi,namakaryawan from thkeluar", conn)
        Dim ds As New DataSet
        da.Fill(ds, "mutasikeluar")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "mutasikeluar"
        DataGridView1.Refresh()

    End Sub
    Private Sub frmMutasiKeluar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            btnUbahDgv.FlatStyle = FlatStyle.Flat
            DataGridView1.Columns.Add(btnUbahDgv)
            btnUbahDgv.Text = "Detail"
            btnUbahDgv.HeaderText = "Detail Data"
            btnUbahDgv.UseColumnTextForButtonValue = True

            'btnHapusDgv.FlatStyle = FlatStyle.Flat
            'DataGridView1.Columns.Add(btnHapusDgv)
            'btnHapusDgv.Text = "Hapus"
            'btnHapusDgv.HeaderText = "Hapus Data"
            'btnHapusDgv.UseColumnTextForButtonValue = True
            loaddata()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        Dim a As New frmDetailMutasiKeluar
        a.mode = 1
        a.ShowDialog()
        loaddata()
        'frmDetailMutasiKeluar.mode = 1
        'frmDetailMutasiKeluar.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If (e.ColumnIndex = 0) Then 'ubah
            Dim a As New frmDetailMutasiKeluar
            a.mode = 0
            a.TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            a.ShowDialog()
            loaddata()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContextMenuStripChanged

    End Sub
End Class