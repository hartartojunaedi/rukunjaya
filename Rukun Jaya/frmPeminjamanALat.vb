Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmPeminjamanALat
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Sub panggil()

        command = "Select nopeminjaman, NamaSopir,tanggalpinjam from tHpeminjaman h, tSopir S where h.kodesopir=s.kodesopir and nopeminjaman like '%" & txtsearchno.Text & "%' and S.namasopir like '%" & txtsearchnama.Text & "%' order by tanggalpinjam desc"


        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahrow.Text = dgvPeminjaman.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "PinjamAlat")
        dgvPeminjaman.DataSource = dataset
        dgvPeminjaman.DataMember = "PinjamAlat"
    End Sub


    Private Sub frmPeminjamanALat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        panggil()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        frmdetailpeminjamanalat.ShowDialog()
    End Sub

    Private Sub dgvPeminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeminjaman.CellClick
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 0) Then '' delete
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then

                    Try
                        cn.Close()
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "delete from tdpeminjaman where nopeminjaman=@kode"
                        cmd.Parameters.AddWithValue("@kode", dgvPeminjaman.Rows(e.RowIndex).Cells("nopeminjaman").Value)
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "delete from thpeminjaman where nopeminjaman=@kode"
                        cmd.ExecuteNonQuery()

                        '   Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isilog(rj.getusername, dgvPeminjaman.Rows(e.RowIndex).Cells("nopeminjaman").Value, "Peminjaman Alat", "Hapus Data", "")
                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        'Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isiErrorlog(rj.getusername, dgvPeminjaman.Rows(e.RowIndex).Cells("nopeminjaman").Value, "Peminjaman Alat", "Hapus Data", ex.Message)
                        rj.shownotifyerror("Data Gagal Dihapus")
                        cn.Close()
                    End Try

                    cn.Close()
                    panggil()
                End If
            End If
        End If


    End Sub
End Class