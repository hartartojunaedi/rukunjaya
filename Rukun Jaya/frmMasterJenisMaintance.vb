Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMasterJenisMaintance
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Public mode As Integer
    Public kode As String
    Dim btnUbah As New DataGridViewButtonColumn()
    Dim btnHapus As New DataGridViewButtonColumn()

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub frmMasterJenisMaintenance_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        kode = ""
        If ConnectionState.Open = True Then
            conn.Close()
        Else
            conn.Open()
        End If
        Try
            Dim ds = New DataSet
            adapter("select kodejenismaintance, namapekerjaan, rutin, keterangan from tJenisMaintance").Fill(ds, "tJenisMaintance")
            dgvJenisMaintenance.DataSource = ds.Tables("tJenisMaintance")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        mode = 0
        frmDetailJenisMaintance.ShowDialog()
    End Sub

    Private Sub dgvJenisMaintenance_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJenisMaintenance.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 0 Then
                mode = 1
                kode = dgvJenisMaintenance.Item(2, e.RowIndex).Value
                frmDetailJenisMaintance.ShowDialog()
            End If
            If e.ColumnIndex = 1 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    'If ConnectionState.Open = True Then
                    '    conn.Close()
                    'Else
                    '    conn.Open()
                    'End If
                    'jun 20 mar 2015
                    If conn.State <> ConnectionState.Open Then
                        conn.Open()
                    End If
                    Try
                        Dim cmd = New SqlCommand("delete from tJenisMaintance where kodejenismaintance='" & dgvJenisMaintenance.Item(2, e.RowIndex).Value & "'", conn)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Jenis Maintance berhasil dihapus")
                        _rjcommon.isilog(_rjcommon.getusername, dgvJenisMaintenance.Item(2, e.RowIndex).Value, "Master Maintance", "Hapus Data", "")
                    Catch ex As Exception
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvJenisMaintenance.Item(2, e.RowIndex).Value, "Master Maintance", "hapus data", ex.Message)
                        _rjcommon.shownotifyerror("Jenis Maintenance gagal dihapus")
                        MsgBox("Jenis Maintenance gagal dihapus")
                    End Try
                    conn.Close()
                    frmMasterJenisMaintenance_Activated(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub frmMasterJenisMaintenance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If dgvJenisMaintenance.Columns.Count < 6 Then
            'jun 17 oktober 2014
            btnUbah.FlatStyle = FlatStyle.Standard
            btnUbah.Width = 45
            dgvJenisMaintenance.Columns.Add(btnUbah)
            btnUbah.Text = "Ubah"
            btnUbah.UseColumnTextForButtonValue = True

            btnHapus.FlatStyle = FlatStyle.Standard
            dgvJenisMaintenance.Columns.Add(btnHapus)
            btnHapus.Width = 45
            btnHapus.Text = "Hapus"
            btnHapus.UseColumnTextForButtonValue = True

            dgvJenisMaintenance.ReadOnly = True
            dgvJenisMaintenance.Columns.Item(4).HeaderText = "Ubah"
            dgvJenisMaintenance.Columns.Item(5).HeaderText = "Hapus"
        End If
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Button1_Click(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If ConnectionState.Open = True Then
            conn.Close()
        Else
            conn.Open()
        End If
        Try
            Dim ds = New DataSet
            adapter("select kodejenismaintance, namapekerjaan, rutin, keterangan from tJenisMaintance where upper(namapekerjaan) like '%" & txtCari.Text.ToUpper & "%'").Fill(ds, "tJenisMaintance")
            dgvJenisMaintenance.DataSource = ds.Tables("tJenisMaintance")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class