Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmbayartagihanspbu
    Dim rj As New RJCommon
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim conn As New SqlConnection
    Sub load_data()
        Dim sql As New SqlCommand("", conn)
        sql.CommandText = "select notagihan,h.kodepbu as kodespbu,s.namaspbu,tgl,nota,totalliter,totalrupiah,totalbayar,kasbontunai,grandtotal,(case when carabayar='' then 'Belum bayar' else 'Sudah Bayar' end) as status from thtagihanspbu h,tspbu s where h.kodepbu = s.kodespbu and tgl>=@awal and tgl<=@akhir and carabayar=''"
        sql.Parameters.AddWithValue("@awal", dtptglawal.Value.Date)
        sql.Parameters.AddWithValue("@akhir", dtptglakhir.Value.Date)
        Try
            conn.Open()
            dataset.Clear()
            adapter.SelectCommand = sql

            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "htagihanspbu")
            dgvtagihanspbu.DataSource = dataset
            dgvtagihanspbu.DataMember = "htagihanspbu"

            lbljumdata.Text = dgvtagihanspbu.RowCount
            conn.Close()
        Catch ex As Exception
            rj.isiErrorlog(rj.getusername, "Load Gridview", "Tagihan SPBU", "", ex.Message)
            rj.shownotifyerror(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Clear()
        dtptglakhir.Value = Date.Now
        dtptglawal.Value = New Date(Now.Year, Now.Month, 1)
        txtnotagihan.Text = ""

    End Sub
    Private Sub frmtagihanspbu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection
        conn.ConnectionString = rj.getconnstr
        Clear()
        load_data()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click, txtnotagihan.TextChanged, dtptglawal.ValueChanged, dtptglakhir.ValueChanged
     
        Try
            ' MsgBox("a")
            conn.Open()

            Dim sql As SqlCommand = New SqlCommand
            sql.Connection = conn
            sql.Parameters.Clear()
            ' sql.CommandText = "select notagihan,h.kodepbu as kodespbu,s.namaspbu,tgl,nota,totalliter,totalrupiah,harga,totalbayar,kasbontunai,grandtotal from thtagihanspbu h,tspbu s where h.kodepbu = s.kodespbu "
            sql.CommandText = "select notagihan,h.kodepbu as kodespbu,s.namaspbu,tgl,nota,totalliter,totalrupiah,totalbayar,kasbontunai,grandtotal,(case when carabayar='' then 'Belum bayar' else 'Sudah Bayar' end) as status from thtagihanspbu h,tspbu s where h.kodepbu = s.kodespbu and tgl>=@awal and tgl<=@akhir and carabayar=''"
            sql.Parameters.AddWithValue("@awal", dtptglawal.Value.Date)
            sql.Parameters.AddWithValue("@akhir", dtptglakhir.Value.Date)
            If txtnotagihan.Text <> "" Then
                sql.CommandText &= " and notagihan like '%" & txtnotagihan.Text & "%'"
            End If
            ' MsgBox(sql.CommandText)

            adapter.SelectCommand = sql
            dataset.Clear()
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "htagihanspbu")
            'DataGridView1.DataSource = dataset
            'DataGridView1.DataMember = "htagihanspbu"
            'DataGridView1.Refresh()
            dgvtagihanspbu.DataSource = dataset
            dgvtagihanspbu.DataMember = "htagihanspbu"
            dgvtagihanspbu.Refresh()
            lbljumdata.Text = dgvtagihanspbu.RowCount
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            rj.isiErrorlog(rj.getusername, "Load Gridview", "Bayar Tagihan SPBU", "", ex.Message)
            rj.shownotifyerror(ex.Message)
            conn.Close()
        End Try
    End Sub

    

    Private Sub dgvtagihanspbu_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvtagihanspbu.CellContentClick
        If e.ColumnIndex = 0 Then 'lihat data
            frmbayardetailtagihanspbu.lblmode.Text = "bayar"
            frmbayardetailtagihanspbu.dnotagihan = dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value
            frmbayardetailtagihanspbu.ShowDialog()
            load_data()

        End If
    End Sub
End Class
