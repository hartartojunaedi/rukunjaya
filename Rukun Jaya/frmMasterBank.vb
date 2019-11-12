Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMasterBank
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        '  frmDetailBank.btnUbahData.Enabled = False
        frmDetailBank.txtkodebank.Enabled = True
        frmDetailBank.simpan = True
        frmDetailBank.ShowDialog()
    End Sub

    Private Sub frmMasterBank_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub



    Sub panggil()
      
        command = "Select kodebank,namabank,norek,saldo,keterangan from tbank where  namabank like '%" & txtSearchnama.Text & "%' and norek like '%" & txtsearchnorek.Text & "%'"

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
        adapter.Fill(dataset, "Bank")
        dgvBank.DataSource = dataset
        dgvBank.DataMember = "Bank"
    End Sub

    Private Sub dgvBank_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBank.CellClick
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 1) Then
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then

                    Try
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "delete from tbank where kodebank=@kode "
                        cmd.Parameters.AddWithValue("@kode", dgvBank.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nama bank = " & dgvBank.Rows(e.RowIndex).Cells(2).Value & vbCrLf & " norek = " & dgvBank.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " Saldo = " & dgvBank.Rows(e.RowIndex).Cells(4).Value & vbCrLf & " Keterangan = " & dgvBank.Rows(e.RowIndex).Cells(5).Value
                        rj.isilog(rj.getusername, dgvBank.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Bank", "Hapus Data", log)

                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        rj.isiErrorlog(rj.getusername, dgvBank.Rows(e.RowIndex).Cells(2).Value.ToString, "Master Bank", "Hapus Data", ex.Message)

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


                frmDetailBank.simpan = False
                frmDetailBank.txtkodebank.Text = dgvBank.Rows(e.RowIndex).Cells(2).Value
                frmDetailBank.txtnamabank.Text = dgvBank.Rows(e.RowIndex).Cells(3).Value
                frmDetailBank.txtNoRekening.Text = dgvBank.Rows(e.RowIndex).Cells(4).Value
                frmDetailBank.txtsaldo.Text = FormatCurrency(dgvBank.Rows(e.RowIndex).Cells(5).Value, 0)
                frmDetailBank.txtKeterangan.Text = dgvBank.Rows(e.RowIndex).Cells(6).Value
                frmDetailBank.txtkodebank.Enabled = False


                frmDetailBank.ShowDialog()

            End If
        End If
    End Sub



    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtsearchnorek.TextChanged, txtSearchnama.TextChanged
        panggil()

    End Sub

    Private Sub dgvBank_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBank.CellContentClick

    End Sub
End Class