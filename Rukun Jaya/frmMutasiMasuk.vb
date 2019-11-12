Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmMutasiMasuk
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Sub panggil()

        command = "Select nota,namatoko,tgltransaksi from thMasuk where nota like '%" & txtsearchnonota.Text & "%' and namatoko like '%" & txtsearchnamatoko.Text & "%' order by tgltransaksi desc"

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
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "sparepart")
        dgvPembelianSparepart.DataSource = dataset
        dgvPembelianSparepart.DataMember = "sparepart"
    End Sub
    Private Sub frmMutasiMasuk_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()
        namaToko_autocomplete()
    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click
        panggil()
    End Sub

    Sub namaToko_autocomplete()
        cn.Open()
        Using cmd As New SqlCommand("Select Distinct(namatoko) from tHMasuk", cn)
            Using rd As SqlDataReader = cmd.ExecuteReader
                While rd.Read
                    With txtsearchnamatoko
                        .AutoCompleteMode = AutoCompleteMode.Suggest
                        .AutoCompleteCustomSource.Add(rd.Item(0))
                        .AutoCompleteSource = AutoCompleteSource.CustomSource
                    End With
                End While
                rd.Close()
            End Using
        End Using
        cn.Close()
    End Sub

    Sub deldetil(kode As String, e As Integer)
        cn.Open()
        Dim kodeSP(0) As String
        Dim stokSP(0) As String
        Dim index As Integer = 0
        Try
            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "select jumlah,kodesparepart from tdmasuk where nota=@kode"
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
                command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("del detil " & ex.Message)
        End Try
        cn.Close()

    End Sub

    Private Sub dgvPembelianSparepart_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPembelianSparepart.CellClick
        If e.RowIndex >= 0 Then
            ' If (e.ColumnIndex = 1) Then '' delete
            If (e.ColumnIndex = dgvPembelianSparepart.Columns("HapusData").Index) Then
                If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                    deldetil(dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value.ToString, e.RowIndex)
                    Try
                        cn.Close()
                        cn.Open()
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = cn
                        cmd.CommandText = "delete from tdmasuk where nota=@kode"
                        cmd.Parameters.AddWithValue("@kode", dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value)
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "delete from thmasuk where nota=@kode"
                        cmd.ExecuteNonQuery()

                        Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isilog(rj.getusername, dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value, "Mutasi Masuk Sparepart", "Hapus Data", "")
                        rj.shownotify("Data Berhasil Dihapus")
                    Catch ex As Exception
                        'Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                        rj.isiErrorlog(rj.getusername, dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value, "Mutasi Masuk Sparepart", "Hapus Data", ex.Message)
                        rj.shownotifyerror("Data Gagal Dihapus")
                        cn.Close()
                    End Try

                    cn.Close()
                    panggil()
                End If
            ElseIf (e.ColumnIndex = dgvPembelianSparepart.Columns("UbahData").Index) Then
                Dim a As New frmDetilMutasiMasuk
                a.txtNonota.Text = dgvPembelianSparepart.Rows(e.RowIndex).Cells(dgvPembelianSparepart.Columns("NoNota").Index).Value
                a.insert = False 'untk update
                a.txtNonota.Enabled = False
                a.ShowDialog()
            End If
        End If
    End Sub

    Private Sub dgvPembelianSparepart_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPembelianSparepart.CellContentClick

    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click

        frmDetilMutasiMasuk.insert = True
        frmDetilMutasiMasuk.dgvdetilpembelian.Rows.Clear()
        frmDetilMutasiMasuk.txtNamaToko.Text = ""
        frmDetilMutasiMasuk.txtNonota.Text = ""
        frmDetilMutasiMasuk.ShowDialog()
        panggil()

    End Sub
End Class