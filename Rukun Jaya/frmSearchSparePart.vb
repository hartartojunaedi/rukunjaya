Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmSearchSparePart
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True

    Private Sub loadsparepart()
        Dim cmd As New SqlCommand("Select namasparepart from tsparepart order by namasparepart", conn)
        Dim dr As SqlDataReader
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cbSparePart.Items.Clear()
        cbSparePart.Items.Add("[Semua]")
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cbSparePart.Items.Add(dr.Item("namaSparepart").ToString)
            End While
        End If
        conn.Close()
        cbSparePart.SelectedIndex = 0
    End Sub
    Private Sub loaddata()
        init = False
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim query As String = ""
        cmd.Connection = conn
        query = "select m.kodemaintance,d.kodesparepart,m.tukang,m.tgl,d.noseri,s.namasparepart"
        query &= " from tmaintance m,tdetailmaintance d,tsparepart s "
        query &= " where m.kodemaintance=d.kodemaintance and d.kodesparepart=s.kodesparepart"
        query &= " and d.noseri like '%" & txtnoseri.Text & "%' "
        query &= " and m.tgl>=@tgl1 and m.tgl<=@tgl2"
        If cbSparePart.Text <> "[Semua]" Then
            query &= " and s.namasparepart like '%" & cbSparePart.Text & "%'"
        End If
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@tgl1", dtpawal.Value.Date)
        cmd.Parameters.AddWithValue("@tgl2", dtpakhir.Value.Date)
        da.SelectCommand = cmd
        da.Fill(ds, "sparepart")
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "sparepart"
        DataGridView1.Refresh()

        conn.Close()
        init = False
    End Sub
    Private Sub frmSearchSparePart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init = True
        dtpawal.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpakhir.Value = Now
        loadsparepart()
        loaddata()
        init = False
    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click, txtnoseri.TextChanged, dtpawal.ValueChanged, dtpakhir.ValueChanged, cbSparePart.SelectedIndexChanged
        If init = False Then
            loaddata()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 6 Then
            If e.RowIndex >= 0 Then
                frmdetailsearchsparepart.kodemaintance = DataGridView1.Rows(e.RowIndex).Cells("kodemaintance").Value
                frmdetailsearchsparepart.kodesparepart = DataGridView1.Rows(e.RowIndex).Cells("kodesparepart").Value
                frmdetailsearchsparepart.noseri = DataGridView1.Rows(e.RowIndex).Cells("noseri").Value
                frmdetailsearchsparepart.ShowDialog()
            End If
        End If
    End Sub
End Class