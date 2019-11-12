Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmSearchBonMuat
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Public Sub loaddata()
        Dim queryload As String
        queryload = "select b.noBM,b.tgl,b.nolambung,k.nopol, jk.namajenis,s.namasopir, s.panggilan from tBM b,tSopir s,tKendaraan k, tJenisKendaraan jk where k.nolambung=b.nolambung and b.kodesopir=s.kodesopir and jk.KodeJenis=k.jenis"
        queryload &= " and b.noBM like '%" & txtNoBM.Text & "%'"
        queryload &= " and s.namasopir like '%" & txtSopir.Text & "%'"
        queryload &= " and k.nopol like '%" & txtNopol.Text & "%'"
        queryload &= " and b.tgl >= @tgl1 and b.tgl <= @tgl2"
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = queryload
        cmd.Parameters.AddWithValue("@tgl1", dtMulai.Value)
        cmd.Parameters.AddWithValue("@tgl2", dtSampai.Value)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds, "bm")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "bm"
        DataGridView1.Refresh()
        DataGridView1.Columns("tanggal").DefaultCellStyle.Format = "dd-MM-yyyy"
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click, txtSopir.TextChanged, txtNopol.TextChanged, txtNoBM.TextChanged, dtSampai.ValueChanged, dtMulai.ValueChanged
        loaddata()
    End Sub

    Private Sub frmSearchBonMuat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loaddata()
        dtMulai.Value = New Date(Now.Year, Now.Month, 1)
        dtSampai.Value = Now
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("detail").Index) And e.RowIndex >= 0 Then
            Dim a As New frmDetailBM
            a.kodeBM = DataGridView1.Rows(e.RowIndex).Cells("noBonMuat").Value
            a.ShowDialog()
        End If
    End Sub
End Class