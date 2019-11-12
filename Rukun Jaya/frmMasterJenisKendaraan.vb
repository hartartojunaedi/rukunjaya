Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmMasterJenisKendaraan
    Public updating As Boolean = False
    Public index As Integer
    Dim currentRow As Integer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim _rjcommon As New RJCommon
    Dim ds As DataSet
    Private Sub frmMasterJenisKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCari.Text = ""
        init()
    End Sub
    Private Sub init()
        Try
            index = -1
            currentRow = -1
            dgvMasterJenisKendaraan.Rows.Clear()
            con = New SqlConnection
            cmd = New SqlCommand
            con.ConnectionString = _rjcommon.getconnstr()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.Connection = con
            cmd.CommandText = "select kodejenis,namajenis,keterangan from tJenisKendaraan where kodejenis like '%" & txtCari.Text & "%' or namajenis like '%" & txtCari.Text & "%'"
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim row As String() = New String() {dr.GetString(0), dr.GetString(1), dr.GetString(2)}
                dgvMasterJenisKendaraan.Rows.Add(row)
            End While
            dr.Close()

            Dim btnUpdate As New DataGridViewButtonColumn()
            Dim btnDelete As New DataGridViewButtonColumn()

            If dgvMasterJenisKendaraan.ColumnCount > 3 Then
                dgvMasterJenisKendaraan.Columns.RemoveAt(4)
                dgvMasterJenisKendaraan.Columns.RemoveAt(3)
            End If

            dgvMasterJenisKendaraan.Columns.Add(btnUpdate)
            btnUpdate.HeaderText = "Ubah"
            'jun 18 oktober 2014
            btnUpdate.Width = 45
            btnUpdate.FlatStyle = FlatStyle.Standard
            btnUpdate.Text = "Ubah"
            btnUpdate.Name = "btnUbah"
            btnUpdate.UseColumnTextForButtonValue = True

            dgvMasterJenisKendaraan.Columns.Add(btnDelete)
            btnDelete.HeaderText = "Hapus"
            btnDelete.Text = "Hapus"
            btnDelete.Width = 45
            btnDelete.FlatStyle = FlatStyle.Standard
            btnDelete.Name = "btnHapus"
            btnDelete.UseColumnTextForButtonValue = True
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, "frmMasterJenisKendaraan_Load", "frmMasterJenisKendaraan", "Inisialisasi", ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMasterJenisKendaraan.CellClick
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                updating = True
                index = e.RowIndex
                frmDetailJenisKendaraan.ShowDialog()
                init()
            ElseIf e.ColumnIndex = 4 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                    currentRow = e.RowIndex
                    deletes(currentRow)
                End If
            End If
        End If
      
    End Sub

    Private Sub deletes(ByVal selectedRow As Integer)
        Try
            cmd = New SqlCommand("delete from tJenisKendaraan where kodejenis = '" & dgvMasterJenisKendaraan.Item(0, selectedRow).Value & "'")
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            _rjcommon.isilog(_rjcommon.getusername, dgvMasterJenisKendaraan.Item(0, currentRow).Value, "Master Jenis Kendaraan", "Hapus Data", "")
            _rjcommon.shownotify("Jenis Kendaraan berhasil dihapus")
            init()
        Catch ex As Exception
            _rjcommon.isiErrorlog(_rjcommon.getusername, dgvMasterJenisKendaraan.Item(0, currentRow).Value, "Master Jenis Kendaraan", "Hapus Data", ex.Message)
            _rjcommon.shownotifyerror("Jenis Kendaraan gagal dihapus")
        End Try
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        init()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        updating = False
        frmDetailJenisKendaraan.ShowDialog()
        init()
    End Sub

    Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click
        init()
    End Sub

End Class