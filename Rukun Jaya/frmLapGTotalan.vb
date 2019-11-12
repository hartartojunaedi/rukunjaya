Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmLapGTotalan
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True
    Private Sub loaddata()
        If init = False Then
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim query As String = ""
            query = "select h.nogtotalan, s.namasopir, h.tanggal"
            query &= " from thgtotalan h, tsopir s"
            query &= " where h.kodesopir = s.kodesopir"
            query &= " and nogtotalan like '%" & txtnototalan.Text & "%'"
            If cbsopir.Text <> "[Semua]" Then
                query &= " and s.namasopir='" & cbsopir.Text & "'"
            End If
            query &= " and h.tanggal>=@tgl1 and h.tanggal<=@tgl2"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@tgl1", dtpawal.Value.Date)
            cmd.Parameters.AddWithValue("@tgl2", dtpakhir.Value.Date)
            da.SelectCommand = cmd
            da.Fill(ds, "totalan")
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "totalan"
            DataGridView1.Refresh()
        End If
    End Sub
    Private Sub loadsopir()
        Dim dr As SqlDataReader
        Dim cmd As New SqlCommand("select namasopir from tsopir order by namasopir", conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cbsopir.Items.Clear()
        cbsopir.Items.Add("[Semua]")
        dr = cmd.ExecuteReader
        While dr.Read
            cbsopir.Items.Add(dr.Item("namasopir"))
        End While
        cbsopir.SelectedIndex = 0
        conn.Close()
    End Sub

    Private Sub frmLapGTotalan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init = True
        dtpawal.Value = New Date(Now.Year, Now.Month, 1)
        dtpakhir.Value = Now
        loadsopir()
        init = False
        loaddata()
    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click
        loaddata()
    End Sub

    Public Sub cetaklaporan(ByVal nogtotalan As String)
        Dim tables As New DataTable

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        If conn.State = ConnectionState.Closed Then conn.Open()
        cmd.Connection = conn
        'Dim query As String = "select h.nototalan, h.tanggal, s.namasopir, sj.nosuratjalan,sj.tgl,sj.sangu,sj.bon,sj.bonlain,sj.borongansopir,sj.tambahan,sj.potongan,sj.kuli,sj.klaim"
        'query &= " from thtotalan h,tdtotalanbon d, tdtotalanjalan dj, tsopir s,tsuratjalan sj"
        'query &= " where h.nototalan = d.nototalan and h.nototalan=dj.nototalan and h.kodesopir = s.kodesopir"
        'query &= " and dj.nobm=sj.nobm and dj.nosuratjalan=sj.nosuratjalan"
        'query &= " and h.nototalan=@nototalan order by sj.nosuratjalan"
        Dim query As String = "select hg.nogtotalan,h.nototalan,h.totalborongan,h.diterima,h.potongantotalan,h.tambahantotalan,h.tambahantotalan1,h.tambahantotalan2, h.tanggal, s.namasopir "
        ' query &= " ,(select ISNULL(sum(rupiah),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as solar"
        'query &= " ,(select ISNULL(sum(liter),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as liter "

        query &= " from  thgtotalan hg,tdgtotalan dg,thtotalan h, tsopir s "
        query &= " where h.kodesopir = s.kodesopir  "
        query &= " and   hg.noGTotalan=dg.nogtotalan and dg.nototalan=h.nototalan"
        query &= " and   hg.nogtotalan=@nototalan order by h.nototalan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nototalan", nogtotalan)

        da.SelectCommand = cmd
        Try
            da.Fill(ds, "totalan")
            DataGridView2.DataSource = ds.Tables("totalan")
            DataGridView2.Refresh()
            'ubah dalam bentuk 3 column
            tables.Columns.Add(New DataColumn("Keterangan", GetType(String)))
            tables.Columns.Add(New DataColumn("Debet", GetType(String)))
            tables.Columns.Add(New DataColumn("Kredit", GetType(String)))
            tables.Columns.Add(New DataColumn("Debet1", GetType(String)))
            tables.Columns.Add(New DataColumn("Kredit1", GetType(String)))
            For i As Integer = 0 To DataGridView2.Rows.Count - 2
                Dim sj As String = DataGridView2.Rows(i).Cells("nototalan").Value.trim(" ")
                Dim tgl As String = DataGridView2.Rows(i).Cells("tanggal").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.year
                'Dim tglmuat As String = DataGridView2.Rows(i).Cells("tglmuat").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.year
                'Dim tglbongkar As String = DataGridView2.Rows(i).Cells("tglbongkar").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.year
                'tgltotalan = DataGridView2.Rows(i).Cells("tanggal").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.year
                ' Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl, String.Format("{0:n}", DataGridView2.Rows(i).Cells("borongansopir").Value), String.Format("{0:n}", (DataGridView2.Rows(i).Cells("sangu").Value + DataGridView2.Rows(i).Cells("bon").Value + DataGridView2.Rows(i).Cells("bonlain").Value))}
                Dim row As String() = New String() {"No Totalan. " & sj & "/ tgl: " & tgl, String.Format("{0:n0}", DataGridView2.Rows(i).Cells("diterima").Value), "", "", ""}
                tables.Rows.Add(row)
                'row = New String() {"    (Tambahan,Klaim+Kuli+Potongan)", String.Format("{0:n}", DataGridView2.Rows(i).Cells("tambahan").Value), String.Format("{0:n}", (DataGridView2.Rows(i).Cells("klaim").Value + DataGridView2.Rows(i).Cells("kuli").Value + DataGridView2.Rows(i).Cells("potongan").Value))}
                ' row = New String() {"    Tgl Muat / Bongkar     " & tglmuat & "/" & tglbongkar, "", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("potongan").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("tambahan").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("borongansopir").Value + DataGridView2.Rows(i).Cells("tambahan").Value - DataGridView2.Rows(i).Cells("potongan").Value)}
                'tables.Rows.Add(row)
                'row = New String() {"    Gudang / Unit          " & DataGridView2.Rows(i).Cells("namagudang").Value & " / " & String.Format("{0:n0}", DataGridView2.Rows(i).Cells("unit").Value), "", "", ""}
                'tables.Rows.Add(row)
                'row = New String() {"    Sangu                  ", "", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("sangu").Value), "", ""}
                'tables.Rows.Add(row)
                'row = New String() {"    Solar                  ", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("liter").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("solar").Value), "", ""}
                'tables.Rows.Add(row)
            Next
            'tambah kasbon

            'query = " select bayar from tdtotalanbon"
            'query &= " where tdtotalanbon.nototalan=@notot"
            'cmd.Parameters.Clear()
            'cmd.CommandText = query
            'cmd.Parameters.AddWithValue("@notot", nototalan)
            'Dim j As Double = cmd.ExecuteScalar
            'Dim tgl1 As String = ds.Tables(0).Columns("tanggal").ToString '.day & "-" & DataGridView1.Rows(i).Cells("tanggal").Value.date.Month & "-" & DataGridView1.Rows(i).Cells("tanggal").Value.date.year
            'Dim row1 As String() = New String() {"Kasbon no totalan: " & nototalan.Trim(" ") & "/ tgl: " & tgltotalan, "0.00", String.Format("{0:n}", j)}
            'tables.Rows.Add(row1)

            'tambah summary
            query = " select * "
            query &= " from thgtotalan"
            query &= " where thgtotalan.nogtotalan=@notot"
            cmd.Parameters.Clear()
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@notot", nogtotalan)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                Dim row As String() = New String() {" ", "", ""}
                tables.Rows.Add(row)
                'row = New String() {" ", "", ""}
                'tables.Rows.Add(row)
                'row = New String() {"Summary: ", "", ""}
                'tables.Rows.Add(row)
                While reader.Read
                    row = New String() {"Total Borongan", String.Format("{0:n0}", reader("total")), "", "", ""}
                    tables.Rows.Add(row)
                    row = New String() {"Bayar Kas Bon   ", "", String.Format("{0:n0}", reader("bon")), "", ""}
                    tables.Rows.Add(row)
                    row = New String() {"Tambahan ", String.Format("{0:n0}", reader("tambahan")), "", ""}
                    tables.Rows.Add(row)
                    row = New String() {"Potongan ", "", String.Format("{0:n0}", reader("potongan")), ""}
                    tables.Rows.Add(row)
                    row = New String() {"Terima ", String.Format("{0:n0}", reader("terima")), "", ""}
                    tables.Rows.Add(row)
                    'row = New String() {"Tambahan BKR+Tol", "", "", String.Format("{0:n}", reader("tambahantotalan1"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Tambahan Lain", "", "", String.Format("{0:n}", reader("tambahantotalan2"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Potongan", "", String.Format("{0:n}", reader("potongantotalan")), ""}
                    'tables.Rows.Add(row)
                    'row = New String() {"Sisa", "", "", "", String.Format("{0:n0}", reader("diterima"))}
                    'tables.Rows.Add(row)
                    ''row = New String() {"Sangu + Kasbon", "0.00", String.Format("{0:n}", reader("sangu"))}
                    'tables.Rows.Add(row)

                    'row = New String() {"Tambahan", String.Format("{0:n}", reader("tambahan")), "0.00"}
                    'tables.Rows.Add(row)
                    'row = New String() {"Kuli", "0.00", String.Format("{0:n}", reader("kuli"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Klaim", "0.00", String.Format("{0:n}", reader("klaim"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Potongan (BBM)", "0.00", String.Format("{0:n}", reader("potongan"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Total Bayar Kasbon", "0.00", String.Format("{0:n}", reader("totalkasbon"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Tambahan Total", String.Format("{0:n}", reader("tambahantotalan")), "0.00"}
                    'tables.Rows.Add(row)
                    'row = New String() {"Potongan Total", "0.00", String.Format("{0:n}", reader("potongantotalan"))}
                    'tables.Rows.Add(row)
                    'row = New String() {"Total diterima", String.Format("{0:n}", reader("diterima")), "0.00"}
                    'tables.Rows.Add(row)
                End While
            End If
            reader.Close()
            DataGridView3.DataSource = tables
            DataGridView3.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If tables.Rows.Count > 0 Then
            Dim rep As New laporantotalan
            rep.SetDataSource(tables)
            DirectCast(rep.ReportDefinition.ReportObjects("NamaSopir"), TextObject).Text = ds.Tables("totalan").Rows(0).Item("namasopir").ToString
            DirectCast(rep.ReportDefinition.ReportObjects("NamaSopir1"), TextObject).Text = ds.Tables("totalan").Rows(0).Item("namasopir").ToString
            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                cetaklaporan(DataGridView1.Rows(e.RowIndex).Cells("nogtotalan").Value)
            End If
        End If
    End Sub
End Class