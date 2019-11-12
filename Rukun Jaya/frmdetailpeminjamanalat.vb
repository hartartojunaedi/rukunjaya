Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmdetailpeminjamanalat
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New RjLibrary.rjLib
    Dim command As String
    Dim transaction As SqlTransaction
    Public insert As Boolean

    Dim cn As New SqlConnection
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim kodesp() As String
    Dim jmlitem() As String



    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim stock = 0
        Dim IDAlat = ""
        cn.Open()
        stock = New SqlCommand("select jumlah from tperalatan where Namaalat='" & cmbNamaalat.Text & "'", cn).ExecuteScalar
        IDAlat = New SqlCommand("select IDAlat from tperalatan where Namaalat='" & cmbNamaalat.Text & "'", cn).ExecuteScalar
        If stock >= nmJumlah.Value Then
            Dim row As String() = New String() {IDAlat, cmbNamaalat.Text, nmJumlah.Value}
            If dgvdetilpeminjaman.RowCount = 0 Then
                dgvdetilpeminjaman.Rows.Add(row)
            Else
                Dim brgada As Boolean = False
                Dim bariske As Integer
                For i = 0 To dgvdetilpeminjaman.RowCount - 1
                    If dgvdetilpeminjaman.Rows(i).Cells(0).Value = IDAlat Then ''apakah kode yang dimasukan sudah ada
                        brgada = True
                        bariske = i
                        Exit For
                    End If
                Next

                If brgada Then
                    dgvdetilpeminjaman.Rows(bariske).Cells(2).Value += nmJumlah.Value
                Else
                    dgvdetilpeminjaman.Rows.Add(row)
                End If
            End If
        End If
        cn.Close()

        'MsgBox(stock)

    End Sub

    Private Sub frmdetailpeminjamanalat_Load(sender As Object, e As EventArgs) Handles Me.Load
        cn = New SqlConnection
        cn.ConnectionString = _rjcommon.getconnstr
        cn.Open()
        cmbNamaalat.Items.Clear()
        Dim authors As New AutoCompleteStringCollection
        Dim rd = New SqlCommand("select * from tPeralatan", cn).ExecuteReader
        While rd.Read
            ' cmbNamaSparepart.Items.Add(rd("namasparepart"))
            authors.Add(rd("namaalat"))
            cmbNamaalat.Items.Add(rd("namaalat"))
        End While
        cmbNamaalat.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbNamaalat.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbNamaalat.AutoCompleteCustomSource = authors
        rd.Close()

        cmbnamasupir.Items.Clear()
        Dim authors2 As New AutoCompleteStringCollection
        rd = New SqlCommand("select * from tsopir", cn).ExecuteReader
        While rd.Read
            ' cmbNamaSparepart.Items.Add(rd("namasparepart"))
            authors2.Add(rd("namasopir"))
            cmbnamasupir.Items.Add(rd("namasopir"))
        End While
        cmbnamasupir.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbnamasupir.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbnamasupir.AutoCompleteCustomSource = authors2
        rd.Close()

        cn.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "select coalesce(count(nopeminjaman),0) from thpeminjaman where nopeminjaman='" & txtNonota.Text & "'"
        Dim nopeminjaman = cmd.ExecuteScalar
        If nopeminjaman > 0 Then
            MsgBox("No Peminjaman Telah terpakai")
        Else
            Try ''insert baru
                Dim kodesopir As String = ""
                kodesopir = New SqlCommand("select kodesopir from tsopir where namasopir='" & cmbnamasupir.Text & "'", cn).ExecuteScalar
                ' MsgBox(kodesopir)

                transaction = cn.BeginTransaction("SampleTransaction")
                cmd.Transaction = transaction
                cmd.Parameters.Clear()
                cmd.CommandText = "Insert into thpeminjaman(nopeminjaman,kodesopir,tanggalpinjam,Keterangan) values (@nopeminjaman,@kodesopir,@tanggalpinjam,@Keterangan)"
                cmd.Parameters.AddWithValue("@nopeminjaman", txtNonota.Text)
                cmd.Parameters.AddWithValue("@kodesopir", kodesopir)
                cmd.Parameters.AddWithValue("@tanggalpinjam", dtpTanggalTransaksi.Value)
                cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text)

                cmd.ExecuteNonQuery()

                For i = 0 To dgvdetilpeminjaman.RowCount - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "insert into tdpeminjaman(nopeminjaman,idalat,jumlah) values (@nopeminjaman,@idalat,@jumlah)"
                    cmd.Parameters.AddWithValue("@nopeminjaman", txtNonota.Text)
                    cmd.Parameters.AddWithValue("@idalat", dgvdetilpeminjaman.Rows(i).Cells(0).Value)
                    cmd.Parameters.AddWithValue("@jumlah", dgvdetilpeminjaman.Rows(i).Cells(2).Value)
                    cmd.ExecuteNonQuery()

                Next
                transaction.Commit()
                cn.Close()
                Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
                _rjcommon.isilog(_rjcommon.getusername, txtNonota.Text, "Transaksi Peminjaman Alat", "Insert Data", log)
                _rjcommon.shownotify("Data Berhasil Disimpan")
                frmPeminjamanALat.panggil()
                Me.Close()

            Catch ex As Exception
                transaction.Rollback()
                '  MsgBox(ex.Message)
                cn.Close()
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtNonota.Text, "Transaksi Peminjaman Alat", "Insert Data", ex.Message)
                _rjcommon.shownotifyerror("Data Tidak Berhasil Disimpan")

            End Try
        End If
        
    End Sub

    Private Sub cmbNamaalat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNamaalat.SelectedIndexChanged

    End Sub
End Class