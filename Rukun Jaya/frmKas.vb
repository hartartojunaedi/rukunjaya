Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmKas
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Sub loaddata()
        Dim da As New SqlDataAdapter()
        Dim command As New SqlCommand
        Dim query As String = "select * from tkas"
        query &= " where tgl>=@tgl1 and tgl<=@tgl2"
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = query
        'jun 3 feb 2015
        command.Parameters.AddWithValue("@tgl1", dtTglAwal.Value.Date)
        command.Parameters.AddWithValue("@tgl2", dtTglAkhir.Value.Date)
        da.SelectCommand = command
        ds.Clear()
        da.Fill(ds, "kas")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "kas"
        DataGridView1.Refresh()

        lblJumlahData.Text = ds.Tables("kas").Rows.Count.ToString
    End Sub
    Private Sub frmKas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        dtTglAwal.Value = New Date(Now.Year, 1, 1, 0, 0, 1)
        dtTglAkhir.Value = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)

        loaddata()
    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click
        loaddata()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmDetailKas.mode = 0 'mode insert
        frmDetailKas.ShowDialog()
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 4 Then
                frmDetailKas.mode = 1
                frmDetailKas.kodekas = DataGridView1.Item(0, e.RowIndex).Value
                'kode = dgvBarang.Item(0, e.RowIndex).Value
                frmDetailKas.ShowDialog()
                loaddata()
            End If
            If e.ColumnIndex = 5 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If
                    Try
                        Dim cmd = New SqlCommand("delete from tkas where kodekas=" & DataGridView1.Item(0, e.RowIndex).Value, conn)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Data Kas berhasil dihapus")
                        'jun 17 oktober 2014
                        _rjcommon.isilog(_rjcommon.getusername, DataGridView1.Item(0, e.RowIndex).Value, "Kas", "Hapus Data", "")
                    Catch ex As Exception
                        _rjcommon.isiErrorlog(_rjcommon.getusername, DataGridView1.Item(0, e.RowIndex).Value, "Kas", "Hapus Data", ex.Message)
                        '_rjcommon.shownotifyerror("Barang gagal dihapus")
                        MsgBox("Data Kas gagal dihapus")
                    End Try
                    conn.Close()

                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class