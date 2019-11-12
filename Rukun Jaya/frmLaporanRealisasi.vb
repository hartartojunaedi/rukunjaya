Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary
Public Class frmLaporanRealisasi
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim rj As New RJCommon
    Private Function searchBM(nolambung As String, tgl As Date)
        Dim tempbm As String = ""
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If (ds.Tables(0).Rows(i).Item("tgl") < tgl) And (ds.Tables(0).Rows(i).Item("nobm") <> "") And (ds.Tables(0).Rows(i).Item("nolambung") = nolambung) Then
                tempbm = ds.Tables(0).Rows(i).Item("nobm")
            End If
        Next
        Return tempbm
    End Function
    Private Function searchnamaToko(kodesparepart As String, tgl As Date)
        Dim tempbm As String = ""
        Dim cmd As New SqlCommand("select namatoko from tdbeli d,thbeli h where d.nota=h.nota and d.kodesparepart=@kodesparepart and h.tgltransaksi<@tgl order by tgltransaksi desc")
        cmd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
        cmd.Parameters.AddWithValue("tgl", tgl)
        Dim conn As New SqlConnection
        conn.ConnectionString = rj.getconnstr
        cmd.Connection = conn
        conn.Close()
        conn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            tempbm = dr.Item("namatoko")
        End If
        conn.Close()
        Return tempbm
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim cn As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim adap1 As New SqlDataAdapter
        Try
            Dim dt As New DataTable

            cn = New SqlConnection
            cn.ConnectionString = rj.getconnstr
            cmd1.Connection = cn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "select * from vPancing"


            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "Realisasi")
            cn.Close()

            'bersihkan table row
            ds.Tables(0).Rows.Clear()

            cmd1.CommandText = "select * from vBiayaAngkut where tgl>=@tgl1 and tgl<=@tgl2 order by tgl"
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@tgl1", dtpTanggalAwal.Value)
            cmd1.Parameters.AddWithValue("@tgl2", dtpTglAkhir.Value)

            cn.Close()
            cn.Open()
            Dim dr As SqlDataReader = cmd1.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Dim newrow As DataRow = ds.Tables(0).NewRow
                    newrow("nobm") = dr.Item("nobm")
                    newrow("tgl") = dr.Item("tgl")
                    newrow("nolambung") = dr.Item("nolambung")
                    newrow("nopol") = dr.Item("nopol")
                    newrow("namatoko") = ""
                    newrow("namasparepart") = dr.Item("namabiaya")
                    newrow("jumlah") = 0
                    newrow("biaya") = 0
                    newrow("keterangan") = ""
                    newrow("debit") = 0
                    newrow("kredit") = dr.Item("biaya")
                    newrow("saldo") = 0
                    ds.Tables(0).Rows.Add(newrow)
                End While
            End If
            cn.Close()

            'pindahkan biaya

            'jun 13 feb 2015



            cmd1.CommandText = "select * from vOperationalKendaraan where tgltransaksi>=@tgl1 and tgltransaksi<=@tgl2 order by tgltransaksi"
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@tgl1", dtpTanggalAwal.Value)
            cmd1.Parameters.AddWithValue("@tgl2", dtpTglAkhir.Value)
            cn.Close()
            cn.Open()
            dr = cmd1.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Dim newrow As DataRow = ds.Tables(0).NewRow
                    newrow("nobm") = searchBM(dr.Item("nolambung"), dr.Item("tgltransaksi"))
                    newrow("tgl") = dr.Item("tgltransaksi")
                    newrow("nolambung") = dr.Item("nolambung")
                    newrow("nopol") = dr.Item("nopol")
                    newrow("namatoko") = ""
                    newrow("namasparepart") = dr.Item("keterangan")
                    newrow("jumlah") = dr.Item("Jumlah")
                    newrow("biaya") = dr.Item("harga") / dr.Item("Jumlah")
                    newrow("keterangan") = ""
                    newrow("debit") = 0
                    newrow("kredit") = dr.Item("harga")
                    newrow("saldo") = 0
                    ds.Tables(0).Rows.Add(newrow)
                End While
            End If
            cn.Close()


            cmd1.CommandText = "select * from vmaintenance where tgl>=@tgl1 and tgl<=@tgl2 order by tgl"
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@tgl1", dtpTanggalAwal.Value)
            cmd1.Parameters.AddWithValue("@tgl2", dtpTglAkhir.Value)
            cn.Close()
            cn.Open()
            dr = cmd1.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Dim newrow As DataRow = ds.Tables(0).NewRow
                    newrow("nobm") = searchBM(dr.Item("nolambung"), dr.Item("tgl"))
                    newrow("tgl") = dr.Item("tgl")
                    newrow("nolambung") = dr.Item("nolambung")
                    newrow("nopol") = dr.Item("nopol")
                    newrow("namatoko") = searchnamaToko(dr.Item("kodesparepart"), dr.Item("tgl"))
                    newrow("namasparepart") = dr.Item("namasparepart")
                    newrow("jumlah") = dr.Item("Jumlah")
                    newrow("biaya") = dr.Item("biaya") / dr.Item("Jumlah")
                    newrow("keterangan") = dr.Item("keterangan")
                    newrow("debit") = 0
                    newrow("kredit") = dr.Item("biaya")
                    newrow("saldo") = 0
                    ds.Tables(0).Rows.Add(newrow)
                End While
            End If
            cn.Close()


            cmd1.CommandText = "select r.*,k.nolambung,k.nopol from trealisasi r,tbm bm,tkendaraan k where bm.nolambung=k.nolambung and bm.nobm=r.nobm and r.tanggal>=@tgl1 and r.tanggal<=@tgl2 order by tanggal"
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@tgl1", dtpTanggalAwal.Value)
            cmd1.Parameters.AddWithValue("@tgl2", dtpTglAkhir.Value)
            cn.Close()
            cn.Open()
            dr = cmd1.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Dim newrow As DataRow = ds.Tables(0).NewRow
                    newrow("nobm") = dr.Item("nobm")
                    newrow("tgl") = dr.Item("tanggal")
                    newrow("nolambung") = dr.Item("nolambung")
                    newrow("nopol") = dr.Item("nopol")
                    newrow("namatoko") = ""
                    newrow("namasparepart") = dr.Item("keterangan")
                    newrow("jumlah") = 0
                    newrow("biaya") = 0
                    newrow("keterangan") = ""
                    newrow("debit") = dr.Item("biayadebet")
                    newrow("kredit") = dr.Item("biayakredit")
                    newrow("saldo") = 0
                    ds.Tables(0).Rows.Add(newrow)
                End While
            End If
            cn.Close()

            If ds.Tables("Realisasi").Rows.Count > 0 Then
                Dim rep As New crpRealisasi
                rep.SetDataSource(ds.Tables("Realisasi"))
                frmlaporan.CrystalReportViewer1.ReportSource = rep
                frmlaporan.CrystalReportViewer1.RefreshReport()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
        frmlaporan.ShowDialog()
    End Sub
End Class