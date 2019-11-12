Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmMasterOperational
    Dim rj As New RJCommon
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim conn As New SqlConnection

    Public Sub RefreshDataset()
        Dim command As String = ""
        If (txtCariNamaOp.Text = "" And cmbCariJenisOp.Text = "[SEMUA]") Then
            command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational"
            'jun 26 desember 2014
        ElseIf (txtCariNamaOp.Text <> "" And cmbCariJenisOp.Text = "[SEMUA]") Then
            command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational where namajenis like '%" & txtCariNamaOp.Text & "%' "
        Else
            command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational where namajenis like '%" & txtCariNamaOp.Text & "%' and jenis = " & cmbCariJenisOp.SelectedIndex
        End If


        'If cbkJenisOperational.Checked = False And cbkNamaOperational.Checked = False Then
        '    command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational"
        'ElseIf cbkJenisOperational.Checked And cbkNamaOperational.Checked = False Then
        '    command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational where jenis = " & cmbCariJenisOp.SelectedIndex
        'ElseIf cbkJenisOperational.Checked = False And cbkNamaOperational.Checked Then
        '    command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational where namajenis like '%" & txtCariNamaOp.Text & "%'"
        'ElseIf cbkJenisOperational.Checked And cbkNamaOperational.Checked Then
        '    command = "SELECT kodejenis, namajenis, case jenis when 1 then 'Kas Bon' else 'Biaya Lain' end as jenis, keterangan FROM tJenisOperational where namajenis like '%" & txtCariNamaOp.Text & "%' and jenis = " & cmbCariJenisOp.SelectedIndex
        'End If

        dataset.Clear()

        Try
            conn.Open()
            IsiDataSet(New SqlCommand(command, conn))
            conn.Close()
        Catch ex As Exception
            rj.isiErrorlog(rj.getusername, "Load Gridview", "Master Operational", "", ex.Message)
            rj.shownotifyerror(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub IsiDataSet(ByVal cmd As SqlCommand)
        adapter.SelectCommand = cmd

        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "JenisOperational")
        dgvMasterOperational.DataSource = dataset
        dgvMasterOperational.DataMember = "JenisOperational"

        lblJumlahDataOperational.Text = dgvMasterOperational.RowCount
    End Sub

    Private Sub Clear()
        txtCariNamaOp.Text = ""
        cmbCariJenisOp.SelectedIndex = 2
    End Sub

    Private Sub btnTambahOperational_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahOperational.Click
        frmDetailMasterOperational.lblMode.Text = "tambah"
        frmDetailMasterOperational.txtKodeJenisOperational.Enabled = True
        frmDetailMasterOperational.ShowDialog()
    End Sub

    Private Sub frmMasterOperational_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection
        conn.ConnectionString = rj.getconnstr
        Clear()
        RefreshDataset()
    End Sub

    Private Sub dgvMasterOperational_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMasterOperational.CellClick
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                frmDetailMasterOperational.lblMode.Text = "ubah"

                frmDetailMasterOperational.txtKodeJenisOperational.Text = dgvMasterOperational.Rows(e.RowIndex).Cells(2).Value
                frmDetailMasterOperational.txtKodeJenisOperational.Enabled = False
                frmDetailMasterOperational.txtNamaJenisOperational.Text = dgvMasterOperational.Rows(e.RowIndex).Cells(3).Value
                frmDetailMasterOperational.cmbJenisOperational.Text = dgvMasterOperational.Rows(e.RowIndex).Cells(4).Value
                frmDetailMasterOperational.txtKetOperational.Text = dgvMasterOperational.Rows(e.RowIndex).Cells(5).Value

                frmDetailMasterOperational.ShowDialog()
            ElseIf e.ColumnIndex = 1 Then
                Dim tempKode As String = dgvMasterOperational.Rows(e.RowIndex).Cells(2).Value

                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                    Try
                        conn.Open()

                        Dim cmdDel As SqlCommand = New SqlCommand
                        cmdDel.Connection = conn
                        cmdDel.CommandText = "delete from tJenisOperational where kodejenis=@KODE"
                        cmdDel.Parameters.AddWithValue("@KODE", tempKode)
                        cmdDel.ExecuteNonQuery()

                        rj.isilog(rj.getusername, tempKode, "Master Operasional", "Hapus Data", "")
                        rj.shownotify("Data Master Operasional Berhasil Dihapus")
                        conn.Close()
                    Catch ex As Exception
                        rj.shownotifyerror("Data Master Operasional Gagal Dihapus")
                        rj.isiErrorlog(rj.getusername, tempKode, "Master Operasional", "Hapus Data", ex.Message)
                        conn.Close()
                    End Try
                End If

                RefreshDataset()
            End If
        End If
    End Sub

    Private Sub btnSeacrhOperational_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeacrhOperational.Click, txtCariNamaOp.TextChanged
        RefreshDataset()
    End Sub

    Private Sub cmbCariJenisOp_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCariJenisOp.KeyUp
        RefreshDataset()
    End Sub

    Private Sub txtCariNamaOp_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariNamaOp.KeyUp
        RefreshDataset()
    End Sub

    Private Sub cmbCariJenisOp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCariJenisOp.SelectedIndexChanged
        RefreshDataset()
    End Sub

   
End Class