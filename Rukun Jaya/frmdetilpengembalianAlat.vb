Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmdetilpengembalianAlat
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New RjLibrary.rjLib
    Dim command As String
    Dim transaction As SqlTransaction
    Public insert As Boolean
    Public idpinjam As String
    Dim cn As New SqlConnection
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Private Sub frmdetilpengembalianAlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = _rjcommon.getconnstr
        ' cn.Open()
        panggil()
    End Sub


    Sub panggil()

        command = "Select d.nopeminjaman, d.IDALat,p.namaalat,d.Jumlah from tdpeminjaman d, tperalatan p where d.IDAlat=p.IDAlat and nopeminjaman='" & idpinjam & "' and tanggalkembali=NULL"


        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()


            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "select h.tanggalpinjam,s.namasopir from thpeminjaman h , tsopir s where h.kodesopir=s.kodesopir and h.nopeminjaman=@nopinjam"
            cmd.Parameters.AddWithValue("@nopinjam", idpinjam)
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                Label2.Text = idpinjam.ToString
                Label3.Text = dr.Item("tanggalpinjam")
                Label5.Text = dr.Item("namasopir")
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahitem.Text = dgvdetilpeminjaman.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "PinjamAlat")
        dgvdetilpeminjaman.DataSource = dataset
        dgvdetilpeminjaman.DataMember = "PinjamAlat"

        If dataset.Tables("PinjamAlat").Rows.Count <= 0 Then
            MsgBox("Alat Sudah Dikembalikan")
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Apakah Anda Yakin Mengembalikan Alat ?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then

            Try
                cn.Close()
                cn.Open()
                Dim cmd As SqlCommand = New SqlCommand
                cmd.Connection = cn
                cmd.CommandText = "Update tdpeminjaman set tanggalkembali='" & Date.Today & "' where nopeminjaman=@kode"
                cmd.Parameters.AddWithValue("@kode", idpinjam)
                cmd.ExecuteNonQuery()
                _rjcommon.isilog(_rjcommon.getusername, idpinjam, "Transaksi Pengembalian Alat", "Update Data", "")

                Close()
                '   Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                ''    rj.isilog(rj.getusername, dgvPeminjaman.Rows(e.RowIndex).Cells("nopeminjaman").Value, "Peminjaman Alat", "Hapus Data", "")
                ' rj.shownotify("Data Berhasil dDiubah")
            Catch ex As Exception
                'Dim log As String = "nota =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(2).Value & " nama toko =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(3).Value & vbCrLf & " total =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(5).Value & vbCrLf & " grand total setelah diskon =" & dgvPembelianSparepart.Rows(e.RowIndex).Cells(6).Value
                ' rj.isiErrorlog(rj.getusername, dgvPeminjaman.Rows(e.RowIndex).Cells("nopeminjaman").Value, "Peminjaman Alat", "Hapus Data", ex.Message)
                _rjcommon.isiErrorlog(_rjcommon.getusername, idpinjam, "Transaksi Pengembalian Alat", "Update Data", ex.Message)
                _rjcommon.shownotifyerror("Data Gagal Diubah")
                cn.Close()
            End Try

            cn.Close()
            panggil()
        End If
    End Sub
End Class