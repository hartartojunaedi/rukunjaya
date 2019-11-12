Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmPembelianSparepart
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Sub panggil()

        command = "Select nota,namatoko,tgltransaksi,total,diskon,grandtotal from thbeli where nota like '%" & txtsearchnonota.Text & "%' and namatoko like '%" & txtsearchnamatoko.Text & "%' "
        command &= " and tgltransaksi>=@tgl1 and tgltransaksi<=@tgl2 order by tgltransaksi desc"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahrow.Text = dgvPembelianSparepart.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        cmd1.Parameters.AddWithValue("@tgl1", DateTimePicker1.Value)
        cmd1.Parameters.AddWithValue("@tgl2", DateTimePicker2.Value)
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "sparepart")
        dgvPembelianSparepart.DataSource = dataset
        dgvPembelianSparepart.DataMember = "sparepart"
    End Sub
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs)
        frmCariSparepart.ShowDialog()
    End Sub

    Private Sub frmPembelianSparepart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        DateTimePicker2.Value = Now
        DateTimePicker1.Value = New Date(Year(Now), 1, 1)
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()
    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtsearchnonota.TextChanged, txtsearchnamatoko.TextChanged, DateTimePicker2.ValueChanged, DateTimePicker1.ValueChanged
        panggil()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click


        frmDetilBeliSparePart.insert = True
        frmDetilBeliSparePart.txtDiskon.Text = ""
        frmDetilBeliSparePart.txtHarga.Text = ""
        frmDetilBeliSparePart.txtNamaToko.Text = ""
        frmDetilBeliSparePart.txtNonota.Text = ""
        frmDetilBeliSparePart.lblgrandtotal.Text = ""
        frmDetilBeliSparePart.lblTotal.Text = ""

        frmDetilBeliSparePart.ShowDialog()
    End Sub

    Private Sub dgvPembelianSparepart_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPembelianSparepart.CellClick
        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = 1) Then '' delete
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                    deldetil(dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value.ToString, e.RowIndex)
                    Try
                        cn.Close()
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "delete from tdbeli where nota=@kode"
                        cmd.Parameters.AddWithValue("@kode", dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "delete from thbeli where nota=@kode"
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isilog(rj.getusername, dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value, "Pembelian Sparepart", "Hapus Data", "")
                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        'Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isiErrorlog(rj.getusername, dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value, "Pembelian Sparepart", "Hapus Data", ex.Message)
                        rj.shownotifyerror("Data Gagal Dihapus")
                        cn.Close()
                    End Try

                    cn.Close()
                    panggil()
                End If
            ElseIf (e.ColumnIndex = 0) Then
                frmDetilBeliSparePart.txtNonota.Text = dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value
                frmDetilBeliSparePart.insert = False 'untk update
                frmDetilBeliSparePart.txtNonota.Enabled = False
                frmDetilBeliSparePart.ShowDialog()
            End If
        End If
    End Sub


    Sub deldetil(kode As String, e As Integer)
        cn.Open()
        Dim kodeSP(0) As String
        Dim stokSP(0) As String
        Dim index As Integer = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "select jumlah,kodesparepart from tdbeli where nota=@kode"
            cmd.Parameters.AddWithValue("@kode", kode)
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                Try
                    ReDim Preserve kodeSP(index)
                    ReDim Preserve stokSP(index)
                    kodeSP(index) = reader.Item(1)
                    stokSP(index) = reader.Item(0)
                    index += 1

                    'Dim command As SqlCommand = New SqlCommand
                    'command.Connection = cn
                    'command.CommandText = "update from tsparepart stock=stock-@stock where kodesparepart=@kode"
                    'command.Parameters.AddWithValue("@kode", reader.Item(1))
                    'command.Parameters.AddWithValue("@stock", reader.Item(0))
                    'command.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox("dlm reader.read" & ex.Message)

                End Try
            End While
            reader.Close()

            For i = 0 To index - 1

                Dim command As SqlCommand = New SqlCommand
                command.Parameters.Clear()
                command.Connection = cn
                command.CommandText = "update tsparepart set stock=stock-@stock where kodesparepart=@kode"
                command.Parameters.AddWithValue("@kode", kodeSP(i))
                command.Parameters.AddWithValue("@stock", stokSP(i))
                'remark karena pembelian sparepart tidak update stok 2 mei 2017
                'command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("del detil " & ex.Message)
        End Try
        cn.Close()

    End Sub


    Private Sub dgvPembelianSparepart_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPembelianSparepart.CellContentClick

    End Sub
End Class