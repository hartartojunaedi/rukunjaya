Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetilMutasi
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection(rj.getconnstr)
    Dim adapter As New SqlDataAdapter
    Dim nomutasi As Integer
    Dim command As String = ""
    Dim transaction As SqlTransaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim status As Integer = -1
        If lblJumlah.Text.Length = 0 Then
            MsgBox("Pilih Barang")
        Else
            Dim kdsparepart As String
            cn.Open()
            Dim cmd As New SqlCommand("select kodesparepart from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", cn)
            kdsparepart = cmd.ExecuteScalar
            cn.Close()
            For i = 0 To dgvmutasi.RowCount - 1
                If dgvmutasi.Rows(i).Cells(0).Value = kdsparepart Then
                    status = i
                    Exit For
                End If
            Next
            If status >= 0 Then
                dgvmutasi.Rows.RemoveAt(status)

            End If
            Dim row As String() = New String() {kdsparepart, cmbNamaSparepart.Text, lblJumlah.Text, nmJumlahbaru.Value, nmJumlahbaru.Value - CDbl(lblJumlah.Text), txtketerangan.Text}
            dgvmutasi.Rows.Add(row)

        End If
    End Sub
   

    Private Sub frmDetilMutasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.Open()
        cmbNamaSparepart.Items.Clear()
        Dim authors As New AutoCompleteStringCollection
        Dim rd = New SqlCommand("select * from tsparepart", cn).ExecuteReader
        While rd.Read
            ' cmbNamaSparepart.Items.Add(rd("namasparepart"))
            authors.Add(rd("namasparepart"))
        End While
        cmbNamaSparepart.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbNamaSparepart.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbNamaSparepart.AutoCompleteCustomSource = authors
        rd.Close()
        cn.Close()
        dgvmutasi.Rows.Clear()
    End Sub

    Private Sub cmbNamaSparepart_TextChanged(sender As Object, e As EventArgs) Handles cmbNamaSparepart.TextChanged
        cn.Open()
        Dim cmd As New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", cn)
        lblJumlah.Text = cmd.ExecuteScalar

        cn.Close()
    End Sub

    Private Sub dgvmutasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmutasi.CellContentClick
        ' MsgBox(e.ColumnIndex)
        If (e.ColumnIndex = 6) Then
            If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                dgvmutasi.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If dgvmutasi.RowCount > 0 Then


                Dim cmd As New SqlCommand
                cmd.CommandText = "select coalesce(max(nomutasi)+1,1) from tmutasi"
                cmd.Connection = cn
                cn.Open()

                Dim nomutasi As String = cmd.ExecuteScalar
                transaction = cn.BeginTransaction("SampleTransaction")
                cmd.Transaction = transaction

                cmd.CommandText = "insert into tmutasi(nomutasi,tanggalmutasi,username) values (@nomutasi,@tanggalmutasi,@username)"
                cmd.Parameters.AddWithValue("@nomutasi", nomutasi)
                cmd.Parameters.AddWithValue("@tanggalmutasi", Date.Today)
                cmd.Parameters.AddWithValue("@username", rj.getusername)
                cmd.ExecuteNonQuery()


                For i = 0 To dgvmutasi.RowCount - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "insert into tdmutasi(nomutasi,kodesparepart,jumlahsebelum,jumlahsesudah,Keterangan) values (@nomutasi,@kodesparepart,@jumlahsebelum,@jumlahsesudah,@keterangan)"
                    cmd.Parameters.AddWithValue("@nomutasi", nomutasi)
                    cmd.Parameters.AddWithValue("@kodesparepart", dgvmutasi.Rows(i).Cells("Kodesparepart").Value)
                    cmd.Parameters.AddWithValue("@jumlahsebelum", CDbl(dgvmutasi.Rows(i).Cells("jumlahsebelum").Value))
                    cmd.Parameters.AddWithValue("@jumlahsesudah", CDbl(dgvmutasi.Rows(i).Cells("jumlahsesudah").Value))
                    cmd.Parameters.AddWithValue("@Keterangan", dgvmutasi.Rows(i).Cells("Keterangan").Value)

                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "update tsparepart set stock=@jumlahsesudah where kodesparepart=@kodesparepart"
                    cmd.ExecuteNonQuery()
                Next


                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                rj.isilog(rj.getusername, nomutasi, "Mutasi Sparepart", "Insert Data", log)
                rj.shownotify("Data Berhasil Disimpan")
                transaction.Commit()
                cn.Close()
                frmMutasi.panggil()
                Me.Close()
            End If

        
        Catch ex As Exception
            transaction.Rollback()
            cn.Close()
            rj.isiErrorlog(rj.getusername, nomutasi, "Mutasi Sparepart", "Insert Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
            cn.Close()
        End Try

    End Sub
End Class