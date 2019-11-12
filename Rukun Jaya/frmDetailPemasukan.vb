Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailPemasukan
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim total As Double = 0
    Public tglawal, tglakhir As Date
    Public perusahaan As String
    Dim dt As DataTable
    Private Function createtable() As DataTable
        Dim dt As New DataTable
        dt.TableName = "Pemasukan"
        dt.Columns.Add(New DataColumn("Tanggal", GetType(System.DateTime)))
        dt.Columns.Add(New DataColumn("Jenis", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Perusahaan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Ref", GetType(System.String)))
        dt.Columns.Add(New DataColumn("Keterangan", GetType(System.String)))
        dt.Columns.Add(New DataColumn("debet", GetType(System.Double)))
        dt.Columns.Add(New DataColumn("kredit", GetType(System.Double)))
        Return dt
    End Function

    Public Function loaddata() As DataTable
        Dim dt As DataTable = createtable()
        Dim query As String = ""
        Dim cmd As New SqlCommand

        query = "Select sj.totalborongansupplier,sp.namasupplier,b.nobm,p.namaperusahaan,k.nopol,sj.nosuratjalan,sj.tgl,g.namagudang as asal,vg.namagudang as tujuan"
        query &= " from tsupplier sp,tperusahaan p,tkendaraan k,tbm b,tsuratjalan sj,tgudang g,vgudang vg"
        query &= " where k.kodeperusahaan=p.kodeperusahaan and k.nolambung=b.nolambung"
        query &= " and b.nobm=sj.nobm and sj.asal=g.kodegudang and sj.tujuan=vg.kodegudang"
        query &= " and sj.kodesupplier=sp.kodesupplier"
        If perusahaan <> "[Semua]" Then
            query &= " and p.namaperusahaan='" & perusahaan & "'"
        End If
        cmd.Connection = conn
        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        dt.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                Dim row As DataRow = dt.NewRow
                row.Item("tanggal") = dr.Item("tgl")
                row.Item("jenis") = "Angkutan"
                row.Item("perusahaan") = dr.Item("namaperusahaan")
                row.Item("ref") = Trim(dr.Item("nobm")) & "/" & Trim(dr.Item("nosuratjalan"))
                row.Item("keterangan") = "Customer : " & Trim(dr.Item("namasupplier")) & "; Nopol : " & Trim(dr.Item("nopol")) & " ; Tujuan : " & Trim(dr.Item("asal")) & " - " & Trim(dr.Item("tujuan")) & " (Rp. " & dr.Item("totalborongansupplier").ToString("0.00") & ")"
                dt.Rows.Add(row)
            End While
        End If
        conn.Close()
        Return dt
    End Function
    Private Sub frmDetailPemasukan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class