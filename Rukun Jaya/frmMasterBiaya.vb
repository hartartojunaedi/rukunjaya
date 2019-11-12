Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMasterBiaya
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    Sub panggil()
        Dim command As String
        command = "Select kodebiaya,namabiaya,iif(kurang=1,'Potongan','Tambahan') as kurang from tbiaya "
        ds.Clear()
        Try
            conn.Open()
            isidataset(New SqlCommand(command, conn))
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "Biaya")
        dgvBiaya.DataSource = ds
        dgvBiaya.DataMember = "Biaya"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub
    Private Sub frmMasterBiaya_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        panggil()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        FrmDetailMasterBiaya.lblMode.Text = "Tambah"
        FrmDetailMasterBiaya.kodebiaya = ""
        FrmDetailMasterBiaya.ShowDialog()
    End Sub

    Private Sub dgvBiaya_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiaya.CellClick
        If e.RowIndex >= 0 Then

            If (e.ColumnIndex = 1) Then 'hapus then
                If (MessageBox.Show("Apakah yakin akan menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) _
         = Windows.Forms.DialogResult.Yes) Then
                    'hapus data sesuai dengan data yang dipilih
                    Try

                        conn.Open()
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        cmd.CommandText = "select count(*) from tbiaya where kodebiaya=@kodebiaya and hapus=1"
                        cmd.Parameters.AddWithValue("@kodebiaya", dgvBiaya.Rows(e.RowIndex).Cells(2).Value)
                        Dim i As Integer = cmd.ExecuteScalar
                        If i = 1 Then
                            cmd.CommandText = "delete from tbiaya where kodebiaya=@kodebiaya"
                            'cmd.Parameters.AddWithValue("@kodebiaya", dgvBiaya.Rows(e.RowIndex).Cells(2).Value)
                            cmd.ExecuteNonQuery()
                            _rjcommon.shownotify("Data Master Biaya Berhasil Dihapus")
                            conn.Close()
                            _rjcommon.isilog(_rjcommon.getusername, dgvBiaya.Rows(e.RowIndex).Cells(2).Value, "Master Biaya", "Hapus Data", "")
                            panggil()
                        Else
                            MessageBox.Show("Data Tidak Boleh Dihapus")
                        End If
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Data Tidak Berhasil Dihapus")
                        conn.Close()
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvBiaya.Rows(e.RowIndex).Cells(2).Value, "Master Biaya", "Hapus Data", ex.Message)
                    End Try

                End If
            ElseIf (e.ColumnIndex = 0) Then 'ubah
                FrmDetailMasterBiaya.lblMode.Text = "Ubah"
                FrmDetailMasterBiaya.kodebiaya = dgvBiaya.Rows(e.RowIndex).Cells(2).Value
                FrmDetailMasterBiaya.ShowDialog()
            End If
        End If
    End Sub

    Private Sub dgvBiaya_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiaya.CellContentClick

    End Sub

    Private Sub dgvBiaya_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiaya.CellContextMenuStripChanged
       
    End Sub
End Class