Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmLKuat
    Dim cn As New SqlConnection
    Dim rj As New RJCommon
    Dim command As String
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Private Sub frmLKuat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        ' cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"

        panggil()
    End Sub

    Sub panggil()

        '  command =
        dataset.Clear()
        Try
            cn.Open()
            Dim cmd1 As New SqlCommand

            cmd1.CommandText = "Select l.nobm,l.nosuratjalan,b.namabarang,l.noDO,l.idurutan,l.Kerusakan,b.kodebarang from tlkuat l,tbarang b where l.kodebarang=b.kodebarang"
            cmd1.CommandText &= " and l.nobm like @nobm and l.nosuratjalan like @nosj and b.namabarang like @namabarang"
            cmd1.Parameters.AddWithValue("@nobm", "%" + txtCariNoBM.Text + "%")
            cmd1.Parameters.AddWithValue("@nosj", "%" + txtNoSuratJalan.Text + "%")
            cmd1.Parameters.AddWithValue("@namabarang", "%" + txtNamaBarang.Text + "%")

            cmd1.Connection = cn
            adapter.SelectCommand = cmd1

            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "Dsuratjalan")
            dgvDetailSuratJalan.DataSource = dataset
            dgvDetailSuratJalan.DataMember = "Dsuratjalan"
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahrow.Text = dgvDetailSuratJalan.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)

    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtCariNoBM.TextChanged, txtNoSuratJalan.TextChanged, txtNamaBarang.TextChanged
        panggil()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmDetailLKuat.simpan = True
        frmDetailLKuat.btnTambah.Enabled = False

        frmDetailLKuat.ShowDialog()


    End Sub

    Private Sub dgvDetailSuratJalan_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetailSuratJalan.CellClick
        If (e.ColumnIndex = 0) Then
            If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                Try

                    cn.Open()
                    Dim cmd As SqlCommand = New SqlCommand


                    cmd.Connection = cn
                    cmd.CommandText = "delete from tlkuat where kodebarang=@kodebarang and nobm=@nobm and noSuratJalan=@nosj and idurutan=@nourut and nodo=@nodo and kodebarang=@kodebarang"
                    cmd.Parameters.AddWithValue("@kodebarang", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("kodebarang").Value)
                    cmd.Parameters.AddWithValue("@nodo", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("NoDO").Value)
                    cmd.Parameters.AddWithValue("@nosj", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("NoSuratJalan").Value)
                    cmd.Parameters.AddWithValue("@nobm", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("nobm").Value)
                    cmd.Parameters.AddWithValue("@nourut", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("IdUrutan").Value)
                    cmd.ExecuteNonQuery()
                    ' Dim log As String = " " & dgvMasterInventory.Rows(e.RowIndex).Cells(2).Value & vbCrLf & " harga terakhir =" & dgvMasterInventory.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " Stock =" & dgvMasterInventory.Rows(e.RowIndex).Cells(4).Value & vbCrLf & " Keterangan = " & dgvMasterInventory.Rows(e.RowIndex).Cells(5).Value
                    rj.isilog(rj.getusername, dgvDetailSuratJalan.Rows(e.RowIndex).Cells(2).Value.ToString, "Transaksi Lkuat", "Hapus Data", dgvDetailSuratJalan.Rows(e.RowIndex).Cells("kodebarang").Value & " " & dgvDetailSuratJalan.Rows(e.RowIndex).Cells("nobm").Value & " " & dgvDetailSuratJalan.Rows(e.RowIndex).Cells("NoSuratJalan").Value)

                    rj.shownotify("Data Berhasil Dihapus")
                Catch ex As Exception
                    rj.isiErrorlog(rj.getusername, "", "Transaksi LKuat", "Hapus Data", ex.Message)
                    rj.shownotifyerror("Data Gagal Dihapus")
                    cn.Close()
                End Try

                cn.Close()
                panggil()
            End If



        End If

        '
    End Sub
End Class