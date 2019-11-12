Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmtagihanspbu
    Dim rj As New RJCommon
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim conn As New SqlConnection
    Sub load_data()
        Dim sql As New SqlCommand("", conn)
        sql.CommandText = "select notagihan,h.kodepbu as kodespbu,s.namaspbu,tgl,nota,totalliter,totalrupiah,harga,totalbayar,kasbontunai,grandtotal from thtagihanspbu h,tspbu s where h.kodepbu = s.kodespbu and tgl>=@awal and tgl<=@akhir"
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
            sql.CommandText = "select notagihan,h.kodepbu as kodespbu,s.namaspbu,tgl,nota,totalliter,totalrupiah,harga,totalbayar,kasbontunai,grandtotal from thtagihanspbu h,tspbu s where h.kodepbu = s.kodespbu and tgl>=@awal and tgl<=@akhir"
            sql.Parameters.AddWithValue("@awal", dtptglawal.Value.Date)
            sql.Parameters.AddWithValue("@akhir", dtptglakhir.Value.Date)
            If txtnotagihan.Text <> "" Then
                sql.CommandText &= " and notagihan like '%" & txtnotagihan.Text & "%'"
            End If
       
            adapter.SelectCommand = sql
            dataset.Clear()
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "htagihanspbu")
            dgvtagihanspbu.DataSource = dataset
            dgvtagihanspbu.DataMember = "htagihanspbu"
            dgvtagihanspbu.Refresh()
            lbljumdata.Text = dgvtagihanspbu.RowCount
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            rj.isiErrorlog(rj.getusername, "Load Gridview", "Tagihan SPBU", "", ex.Message)
            rj.shownotifyerror(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        frmdetailtagihanspbu.lblMode.Text = "tambah"
        frmdetailtagihanspbu.ShowDialog()
        load_data()
    End Sub

    Private Sub dgvtagihanspbu_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvtagihanspbu.CellContentClick
        If e.ColumnIndex = 0 Then 'lihat data
            frmdetailtagihanspbu.lblmode.Text = "view"
            frmdetailtagihanspbu.dnotagihan = dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value
            frmdetailtagihanspbu.ShowDialog()
        ElseIf e.ColumnIndex = 1 Then 'hapus data
            'cek jika carabayar dan tglbayar masih kosong berarti boleh dihapus
            If MsgBox("Apakah anda yakin hapus?", MsgBoxStyle.OkCancel, "Hapus Tagihan") = MsgBoxResult.Ok Then
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim cmd As New SqlCommand("", conn)
                cmd.Parameters.Clear()
                cmd.CommandText = "select count(*) from thtagihanspbu where notagihan=@kodetagihan and carabayar =''"
                cmd.Parameters.AddWithValue("@kodetagihan", dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value)
                Dim temp As Integer = cmd.ExecuteScalar
                If temp = 1 Then
                    Dim transaction As SqlTransaction
                    transaction = conn.BeginTransaction("SampleTransaction")
                    cmd.Transaction = transaction

                    cmd.Parameters.Clear()
                    cmd.CommandText = "select notagihan,kodevoucher,liter from tdtagihanspbu where notagihan=@notagihan"
                    cmd.Parameters.AddWithValue("@notagihan", dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value)

                    Dim ad As New SqlDataAdapter(cmd)
                    Dim ds2 As New DataSet
                    ad.Fill(ds2, "tagihan")
                    For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
                        'ubah status jadi 0 kmd hapus detailnya
                        cmd.Parameters.Clear()
                        cmd.CommandText = "update tvoucherspbu set status=0,sisa=sisa+@tagih where kodevoucher =@kode"
                        cmd.Parameters.AddWithValue("@tagih", CDbl(ds2.Tables(0).Rows(i).Item("liter").ToString))
                        cmd.Parameters.AddWithValue("@kode", ds2.Tables(0).Rows(i).Item("kodevoucher").ToString)
                        cmd.ExecuteNonQuery()

                    Next
                    cmd.Parameters.Clear()
                    cmd.CommandText = "delete from tdtagihanspbu where notagihan=@notagihan"
                    cmd.Parameters.AddWithValue("@notagihan", dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value)
                    cmd.ExecuteNonQuery()

                    'delete header
                    cmd.Parameters.Clear()
                    cmd.CommandText = "delete from thtagihanspbu where notagihan=@notagihan"
                    cmd.Parameters.AddWithValue("@notagihan", dgvtagihanspbu.Rows(e.RowIndex).Cells("notagihan").Value)
                    cmd.ExecuteNonQuery()

                    Dim log As String = "notagihan=" & txtnotagihan.Text & vbCrLf & " nonota="
                    rj.isilog(rj.getusername, txtnotagihan.Text, "Tagihan SPBU", "Hapus Data", log)
                    rj.shownotify("Data Berhasil Dihapus")
                    transaction.Commit()
                    conn.Close()
                    load_data()
                Else
                    MsgBox("Tagihan sudah dibayar")
                End If
            End If
        End If
    End Sub
End Class
