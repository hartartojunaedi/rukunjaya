Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMasterPeralatan
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""


    Sub panggil()

        command = "Select IDAlat,NamaAlat,Jumlah,Satuan,Keterangan from tperalatan where  NamaAlat like '%" & txtCari.Text & "%'"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Inventory")
        dgvPeralatan.DataSource = dataset
        dgvPeralatan.DataMember = "Inventory"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmdetailPeralatan.simpan = True
        frmdetailPeralatan.clear()
        frmdetailPeralatan.txtIDAlat.Enabled = True
        frmdetailPeralatan.ShowDialog()
    End Sub

    Private Sub dgvPeralatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeralatan.CellClick
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 1) Then
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then

                    Try
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "delete from tPeralatan where IDAlat=@kode "
                        cmd.Parameters.AddWithValue("@kode", dgvPeralatan.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nama Alat = " & dgvPeralatan.Rows(e.RowIndex).Cells(2).Value
                        rj.isilog(rj.getusername, dgvPeralatan.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Peralatan", "Hapus Data", log)

                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, dgvPeralatan.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Peralatan", "Hapus Data", ex.Message)

                        rj.shownotifyerror("Data Gagal Dihapus")
                        cn.Close()
                    End Try

                    cn.Close()
                    panggil()
                End If
            End If

            If (e.ColumnIndex = 0) Then
                '  frmDetailBank.btnTambahData.Enabled = False
                '   frmDetailBank.btnUbahData.Enabled = True


                frmdetailPeralatan.simpan = False
                frmdetailPeralatan.txtIDAlat.Text = dgvPeralatan.Rows(e.RowIndex).Cells(2).Value
                frmdetailPeralatan.txtnamaAlat.Text = dgvPeralatan.Rows(e.RowIndex).Cells(3).Value
                frmdetailPeralatan.txtjumlah.Text = dgvPeralatan.Rows(e.RowIndex).Cells(4).Value
                frmdetailPeralatan.txtSatuan.Text = dgvPeralatan.Rows(e.RowIndex).Cells(5).Value
                frmdetailPeralatan.txtKeterangan.Text = dgvPeralatan.Rows(e.RowIndex).Cells(6).Value
                frmdetailPeralatan.txtIDAlat.Enabled = False


                frmdetailPeralatan.ShowDialog()

            End If
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        panggil()
    End Sub

    Private Sub frmMasterPeralatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub
End Class