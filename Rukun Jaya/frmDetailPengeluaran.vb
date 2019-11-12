Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailPengeluaran
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public tglawal, tglakhir As Date
    Public perusahaan As String
    Dim total As Double = 0
    Dim dt As DataTable
    Private Function createtable() As DataTable
        Dim dt As New DataTable
        dt.TableName = "Pemasukan"
        dt.Columns.Add(New DataColumn("Tanggal", GetType(System.DateTime)))
        dt.Columns.Add(New DataColumn("Jenis", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Perusahaan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Ref", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Keterangan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Debet", GetType(System.Double)))
        dt.Columns.Add(New DataColumn("Kredit", GetType(System.Double)))
        Return dt
    End Function
    Public Function loaddata() As DataTable
        Dim dt As DataTable = createtable()
        Dim query As String = ""
        Dim cmd As New SqlCommand
        total = 0
        'biaya lain
        query = "Select s.namasopir,jo.namajenis,p.namaperusahaan,o.keterangan,o.kodetransaksi,o.tgltransaksi,o.harga,o.harga*p.prosentase/100 as jumlah"
        query &= " from tsopir s,tperusahaan p,tjenisoperational jo,toperational o"
        query &= " where s.kodesopir=o.kode and jo.jenis=0 and o.jenis=jo.kodejenis" 'operational bukan kas bon
        If perusahaan <> "[Semua]" Then
            query &= " and p.namaperusahaan='" & perusahaan & "'"
        Else
            query &= " and p.holding=0"
        End If
        cmd.Connection = conn
        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader
        dt.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                Dim row As DataRow = dt.NewRow
                row.Item("tanggal") = dr.Item("tgltransaksi")
                row.Item("jenis") = "Operational"
                row.Item("perusahaan") = dr.Item("namaperusahaan")
                row.Item("ref") = dr.Item("kodetransaksi")
                row.Item("keterangan") = "Rp. " & FormatNumber(dr.Item("harga"), 2, , , TriState.True) & " : " & Trim(dr.Item("namasopir")) & " (" & Trim(dr.Item("keterangan")) & ")"
                row.Item("debet") = dr.Item("jumlah")
                total += dr.Item("jumlah")
                dt.Rows.Add(row)
            End While
        End If
        conn.Close()

        'maintance
        query = "  Select p.namaperusahaan,k.nopol,jm.namapekerjaan,m.kodemaintance,m.biaya,m.tgl"
        query &= " from tperusahaan p,tkendaraan k,tmaintance m,tjenismaintance jm"
        query &= " where k.kodeperusahaan=p.kodeperusahaan and k.nolambung=m.nolambung"
        query &= " and jm.kodejenismaintance=m.kodejenismaintance"
        query &= " and m.tgl>=@tgl1 and m.tgl<=@tgl2"
        If perusahaan <> "[Semua]" Then
            query &= " and p.namaperusahaan='" & perusahaan & "'"
        End If
        query &= " order by m.tgl"
        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@tgl1", tglawal.Date)
        cmd.Parameters.AddWithValue("@tgl2", tglakhir.Date)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                Dim row As DataRow = dt.NewRow
                row.Item("tanggal") = dr.Item("tgl")
                row.Item("jenis") = "Maintenance"
                row.Item("perusahaan") = dr.Item("namaperusahaan")
                row.Item("ref") = dr.Item("kodemaintance")
                row.Item("keterangan") = "Nopol : " & Trim(dr.Item("nopol")) & " - " & dr.Item("namapekerjaan") & " (Rp. " & FormatNumber(dr.Item("biaya"), 2, , , TriState.True) & ")"
                row.Item("debet") = dr.Item("biaya")
                total += dr.Item("biaya")
                dt.Rows.Add(row)
            End While
        End If
        conn.Close()

        'spbu
        query = "  Select v.nobm,v.nosuratjalan,p.namaperusahaan,k.nopol,v.kodevoucher,s.namaspbu,v.tglvoucher,v.rupiah,v.kasbon,v.liter"
        query &= " from tbm b,tsuratjalan sj,tperusahaan p,tkendaraan k,tvoucherspbu v,tspbu s"
        query &= " where k.kodeperusahaan=p.kodeperusahaan and k.kodeperusahaan=p.kodeperusahaan"
        query &= " and v.nobm=b.nobm and v.nosuratjalan=sj.nosuratjalan and b.nobm=sj.nobm"
        query &= " and b.nolambung=k.nolambung and v.kodespbu=s.kodespbu"
        If perusahaan <> "[Semua]" Then
            query &= " and p.namaperusahaan='" & perusahaan & "'"
        End If

        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cmd.Parameters.Clear()
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                Dim row As DataRow = dt.NewRow
                row.Item("tanggal") = dr.Item("tglvoucher")
                row.Item("jenis") = "SPBU"
                row.Item("perusahaan") = dr.Item("namaperusahaan")
                row.Item("ref") = Trim(dr.Item("kodevoucher")) & "/" & Trim(dr.Item("nobm")) & "/" & Trim(dr.Item("nosuratjalan"))
                row.Item("keterangan") = "Nopol : " & Trim(dr.Item("nopol")) & " - " & dr.Item("namaspbu") & " (" & FormatNumber(dr.Item("liter"), 0, , , TriState.True) & " lt/Rp. " & FormatNumber(dr.Item("rupiah"), 2, , , TriState.True) & " + Rp." & FormatNumber(dr.Item("kasbon"), 2, , , TriState.True) & ")"
                row.Item("debet") = dr.Item("rupiah") + dr.Item("kasbon")
                total += (dr.Item("rupiah") + dr.Item("kasbon"))
                dt.Rows.Add(row)
            End While
        End If
        conn.Close()
        Return dt
    End Function
    Private Sub frmDetailPengeluaran_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Periode : " + tglawal.ToString("dd-MM-yyyy") + " s/d " + tglakhir.ToString("dd-MM-yyyy")
        Label2.Text = "Perusahaan : " + perusahaan
        dt = loaddata()
        lbltotal.Text = FormatNumber(total, 2, , , TriState.True)
        Dim v As DataView = dt.DefaultView
        v.Sort = "tanggal"
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = v
        DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class