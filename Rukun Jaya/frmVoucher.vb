Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmVoucher
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True

    Public Sub loadSPBU()
        Try
            'jun 26 jan 2015
            Dim da As New SqlDataAdapter("select distinct(namaspbu) from tSPBU", conn)
            Dim ds1 As New DataSet
            da.Fill(ds1)
            cbSPBU.Items.Clear()
            cbSPBU.Items.Add("[Semua]")
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                cbSPBU.Items.Add(ds1.Tables(0).Rows(i).Item(0))
            Next
            cbSPBU.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loaddata()
        Try
            Dim queryload As String
            queryload = "select v.kodevoucher,s.namaspbu,v.liter,v.rupiahsatuan,v.rupiah,v.kasbon from tVoucherSPBU v,tSPBU s where v.kodespbu=s.kodespbu"
            queryload &= " and v.kodevoucher like '%" & txtVoucher.Text & "%'"
            If cbSPBU.SelectedIndex > 0 Then
                queryload &= " and s.namaspbu='" & cbSPBU.Text & "'"
            End If
            If init = False Then
                queryload &= " and v.tglvoucher >= @tgl1 and v.tglvoucher <= @tgl2"
            End If
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = queryload
            cmd.Parameters.AddWithValue("@tgl1", dtMulai.Value)
            cmd.Parameters.AddWithValue("@tgl2", dtSampai.Value)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds, "vou")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "vou"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click, txtVoucher.TextChanged, cbSPBU.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub frmVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loaddata()
        loadSPBU()
        dtMulai.Value = New Date(Now.Year, Now.Month, 1)
        dtSampai.Value = Now
        init = False
    End Sub

    Private Sub dtSampai_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtSampai.ValueChanged, dtMulai.ValueChanged
        If init = False Then
            loaddata()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("detail").Index) And e.RowIndex >= 0 Then
            Dim a As New frmDetailVoucher
            a.kodeVoucher = DataGridView1.Rows(e.RowIndex).Cells("kodeVoucher").Value
            a.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class