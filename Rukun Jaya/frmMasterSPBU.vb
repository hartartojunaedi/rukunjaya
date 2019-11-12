Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmMasterSPBU
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter


    Sub panggil()
        Dim command As String
        '   command = "Select kodespbu,namaspbu,alamatspbu,kotaspbu,telpspbu,kontakspbu,limit,saldo from tSPBU where kodespbu like '%" & txtkodespbu.Text & "%' and namaspbu like '%" & txtnamaspbu.Text & "%' and alamatspbu like '%" & txtalamatspbu.Text & "%'"
        command = "Select kodespbu,namaspbu,alamatspbu,kotaspbu,telpspbu,kontakspbu,limit,saldo from tSPBU"

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
        adapter.Fill(ds, "SPBU")
        dgvSPBU.DataSource = ds
        dgvSPBU.DataMember = "SPBU"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub

    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        frmDetailMasterSPBU.lblMode.Text = "Tambah"
        frmDetailMasterSPBU.kodespbu = ""
        frmDetailMasterSPBU.Show()
    End Sub

    Private Sub frmMasterSPBU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil()
    End Sub


    Private Sub dgvSPBU_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSPBU.CellClick
        'MsgBox(e.ColumnIndex)
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 1) Then 'hapus then
                If (MessageBox.Show("Apakah yakin akan menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) _
                    = Windows.Forms.DialogResult.Yes) Then
                    'hapus data sesuai dengan data yang dipilih
                    'try catch tidak ada
                    Try
                        conn.Open()
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        cmd.CommandText = "delete from tSPBU where kodespbu=@kodespbu"
                        cmd.Parameters.AddWithValue("@kodespbu", dgvSPBU.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Data SPBU Berhasil Dihapus")
                        conn.Close()
                        _rjcommon.isilog(_rjcommon.getusername, dgvSPBU.Rows(e.RowIndex).Cells(2).Value, "Master SPBU", "Hapus Data", "hapus data kodespbu = " + dgvSPBU.Rows(e.RowIndex).Cells(2).Value)

                        panggil()
                    Catch ex As Exception
                        MsgBox("Data SPBU tidak dapat dihapus")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvSPBU.Rows(e.RowIndex).Cells(2).Value, "Master SPBU", "Hapus Data", ex.Message)

                    End Try

                End If
            ElseIf (e.ColumnIndex = 0) Then 'ubah
                frmDetailMasterSPBU.lblMode.Text = "Ubah"
                frmDetailMasterSPBU.kodespbu = dgvSPBU.Rows(e.RowIndex).Cells("kodespbu").Value
                frmDetailMasterSPBU.Show()
            End If
        End If
    End Sub

    Private Sub txtkodespbu_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        panggil()
    End Sub

    Private Sub txtkodespbu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        panggil()
    End Sub

    Private Sub dgvSPBU_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSPBU.CellContentClick

    End Sub
End Class