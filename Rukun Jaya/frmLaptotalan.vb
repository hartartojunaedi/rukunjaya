Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmLaptotalan
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True
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
    Private Sub frmLaptotalan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init = True
        dtpawal.Value = New Date(Now.Year, Now.Month, 1)
        dtpakhir.Value = Now
        loadsopir()
        init = False
        loaddata()
    End Sub


    Public Sub cetaklaporanbaru(nototalan As String)
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
        Dim query As String = "select sj.nobm,h.nototalan,h.potongantotalan,h.tambahantotalan,h.tambahantotalan1,h.tambahantotalan2, h.tanggal,sj.tglmuat,g.namagudang,(select ISNULL(sum(jumlah),0) from tDetailSuratJalan dsj where dsj.nobm=sj.nobm and dsj.noSuratJalan=sj.noSuratJalan) as unit,sj.tglbongkar, s.namasopir, sj.nosuratjalan,sj.tgl,sj.sangu,sj.bon,sj.bonlain,sj.borongansopir,sj.tambahan,sj.potongan,sj.kuli,sj.klaim"
        query &= " ,(select ISNULL(sum(rupiah),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as solar"
        query &= " ,(select ISNULL(sum(liter),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as liter "

        query &= " from thtotalan h, tdtotalanjalan dj, tsopir s,tsuratjalan sj,tgudang g"
        query &= " where  h.nototalan=dj.nototalan and h.kodesopir = s.kodesopir and g.kodegudang=sj.asal"
        query &= " and dj.nobm=sj.nobm and dj.nosuratjalan=sj.nosuratjalan"
        query &= " and h.nototalan=@nototalan order by tglmuat,sj.nosuratjalan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nototalan", nototalan)

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
            Dim tgltotalan As String
            Dim debitl As Double = 0
            Dim kreditl As Double = 0
            For i As Integer = 0 To DataGridView2.Rows.Count - 2
                Dim sj As String = DataGridView2.Rows(i).Cells("nosuratjalan").Value.trim(" ")
                Dim tgl As String = DataGridView2.Rows(i).Cells("tgl").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tgl").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tgl").Value.date.year
                Dim tglmuat As String = DataGridView2.Rows(i).Cells("tglmuat").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.year
                Dim tglbongkar As String = DataGridView2.Rows(i).Cells("tglbongkar").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.year
                tgltotalan = DataGridView2.Rows(i).Cells("tanggal").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.year
                ' Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl, String.Format("{0:n}", DataGridView2.Rows(i).Cells("borongansopir").Value), String.Format("{0:n}", (DataGridView2.Rows(i).Cells("sangu").Value + DataGridView2.Rows(i).Cells("bon").Value + DataGridView2.Rows(i).Cells("bonlain").Value))}
                '      Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl & "(" & tglmuat & "/" & tglbongkar & ")", "", "", "", ""}
                Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl & "(" & tglbongkar & ")", "", "", "", ""}
                tables.Rows.Add(row)
                row = New String() {"    Gudang / Unit          " & DataGridView2.Rows(i).Cells("namagudang").Value & " / " & String.Format("{0:n0}", DataGridView2.Rows(i).Cells("unit").Value), "", "", ""}
                tables.Rows.Add(row)
                Dim cmd1 As New SqlCommand
                cmd1.Connection = conn
                cmd1.CommandText = "select * from tdetailbiaya db,tbiaya b where db.kodebiaya=b.kodebiaya and nobm=@nobm and nosuratjalan=@nosuratjalan and b.kurang=0 and biaya>0"
                cmd1.Parameters.AddWithValue("@nobm", DataGridView2.Rows(i).Cells("nobm").Value.trim(" "))
                cmd1.Parameters.AddWithValue("@nosuratjalan", DataGridView2.Rows(i).Cells("nosuratjalan").Value.trim(" "))
                Dim dr As SqlDataReader
                dr = cmd1.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        kreditl = kreditl + dr.Item("biaya")
                        row = New String() {"         " & dr.Item("namabiaya"), String.Format("{0:n0}", dr.Item("biaya")), "", "", ""}
                        tables.Rows.Add(row)
                    End While
                End If

                dr.Close()
                cmd1.Parameters.Clear()
                cmd1.CommandText = "select * from tdetailbiaya db,tbiaya b where db.kodebiaya=b.kodebiaya and nobm=@nobm and nosuratjalan=@nosuratjalan and b.kurang=1 and biaya>0"
                cmd1.Parameters.AddWithValue("@nobm", DataGridView2.Rows(i).Cells("nobm").Value.trim(" "))
                cmd1.Parameters.AddWithValue("@nosuratjalan", DataGridView2.Rows(i).Cells("nosuratjalan").Value.trim(" "))
                dr = cmd1.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        debitl = debitl + dr.Item("biaya")
                        row = New String() {"            " & dr.Item("namabiaya"), "", String.Format("{0:n0}", dr.Item("biaya")), "", ""}
                        tables.Rows.Add(row)
                    End While
                End If
                dr.Close()
            Next
            Dim row1 As String() = New String() {"Diterima ", String.Format("{0:n0}", kreditl - debitl), "", "", ""}
            tables.Rows.Add(row1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If tables.Rows.Count > 0 Then
            'show lKUAT
            Dim ket As String = ""
            Dim cmd2 As New SqlCommand
            Dim query3 As String = "Select kerusakan,jumlah"
            query3 += " from tlkuat lk, tDTotalanJalan  dj"
            query3 += " where lk.nobm=dj.nobm and lk.noSuratJalan=dj.noSuratJalan and nototalan=@nototalan"
            cmd2.CommandText = query3
            cmd2.Parameters.AddWithValue("@nototalan", nototalan)
            cmd2.Connection = conn
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader
            If dr2.HasRows Then
                While dr2.Read
                    ket &= dr2.Item("kerusakan").ToString + "(" + dr2.Item("jumlah").ToString + ") "
                End While
            End If
            Dim rep As New laporantotalanBaru
            rep.SetDataSource(tables)
            DirectCast(rep.ReportDefinition.ReportObjects("NamaSopir"), TextObject).Text = ds.Tables("totalan").Rows(0).Item("namasopir").ToString
            DirectCast(rep.ReportDefinition.ReportObjects("NamaSopir1"), TextObject).Text = ds.Tables("totalan").Rows(0).Item("namasopir").ToString
            DirectCast(rep.ReportDefinition.ReportObjects("txtLKuat"), TextObject).Text = ket
            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
    End Sub

    Public Sub cetaklaporan(ByVal nototalan As String)
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
        Dim query As String = "select sj,nobm,h.nototalan,h.potongantotalan,h.tambahantotalan,h.tambahantotalan1,h.tambahantotalan2, h.tanggal,sj.tglmuat,g.namagudang,(select ISNULL(sum(jumlah),0) from tDetailSuratJalan dsj where dsj.nobm=sj.nobm and dsj.noSuratJalan=sj.noSuratJalan) as unit,sj.tglbongkar, s.namasopir, sj.nosuratjalan,sj.tgl,sj.sangu,sj.bon,sj.bonlain,sj.borongansopir,sj.tambahan,sj.potongan,sj.kuli,sj.klaim"
        query &= " ,(select ISNULL(sum(rupiah),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as solar"
        query &= " ,(select ISNULL(sum(liter),0) from tvoucherspbu spbu where spbu.nobm=sj.nobm and spbu.noSuratJalan=sj.nosuratjalan)  as liter "

        query &= " from thtotalan h, tdtotalanjalan dj, tsopir s,tsuratjalan sj,tgudang g"
        query &= " where  h.nototalan=dj.nototalan and h.kodesopir = s.kodesopir and g.kodegudang=sj.asal"
        query &= " and dj.nobm=sj.nobm and dj.nosuratjalan=sj.nosuratjalan"
        query &= " and h.nototalan=@nototalan order by sj.nosuratjalan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nototalan", nototalan)

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
            Dim tgltotalan As String
            For i As Integer = 0 To DataGridView2.Rows.Count - 2
                Dim sj As String = DataGridView2.Rows(i).Cells("nosuratjalan").Value.trim(" ")
                Dim tgl As String = DataGridView2.Rows(i).Cells("tgl").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tgl").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tgl").Value.date.year
                Dim tglmuat As String = DataGridView2.Rows(i).Cells("tglmuat").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglmuat").Value.date.year
                Dim tglbongkar As String = DataGridView2.Rows(i).Cells("tglbongkar").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tglbongkar").Value.date.year
                tgltotalan = DataGridView2.Rows(i).Cells("tanggal").Value.date.day & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.Month & "-" & DataGridView2.Rows(i).Cells("tanggal").Value.date.year
                ' Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl, String.Format("{0:n}", DataGridView2.Rows(i).Cells("borongansopir").Value), String.Format("{0:n}", (DataGridView2.Rows(i).Cells("sangu").Value + DataGridView2.Rows(i).Cells("bon").Value + DataGridView2.Rows(i).Cells("bonlain").Value))}
                Dim row As String() = New String() {"Surat Jalan no. " & sj & "/ tgl: " & tgl, String.Format("{0:n0}", DataGridView2.Rows(i).Cells("borongansopir").Value), "", "", ""}
                tables.Rows.Add(row)
                'row = New String() {"    (Tambahan,Klaim+Kuli+Potongan)", String.Format("{0:n}", DataGridView2.Rows(i).Cells("tambahan").Value), String.Format("{0:n}", (DataGridView2.Rows(i).Cells("klaim").Value + DataGridView2.Rows(i).Cells("kuli").Value + DataGridView2.Rows(i).Cells("potongan").Value))}
                row = New String() {"    Tgl Muat / Bongkar     " & tglmuat & "/" & tglbongkar, "", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("potongan").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("tambahan").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("borongansopir").Value + DataGridView2.Rows(i).Cells("tambahan").Value - DataGridView2.Rows(i).Cells("potongan").Value)}
                tables.Rows.Add(row)
                row = New String() {"    Gudang / Unit          " & DataGridView2.Rows(i).Cells("namagudang").Value & " / " & String.Format("{0:n0}", DataGridView2.Rows(i).Cells("unit").Value), "", "", ""}
                tables.Rows.Add(row)
                row = New String() {"    Sangu                  ", "", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("sangu").Value), "", ""}
                tables.Rows.Add(row)
                row = New String() {"    Solar                  ", String.Format("{0:n0}", DataGridView2.Rows(i).Cells("liter").Value), String.Format("{0:n0}", DataGridView2.Rows(i).Cells("solar").Value), "", ""}
                tables.Rows.Add(row)
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
            query = " select totalborongan,sangu,solar,kuli,tambahan,klaim,potongan,totalkasbon,tambahantotalan,tambahantotalan1,tambahantotalan2,potongantotalan,diterima from thtotalan"
            query &= " where thtotalan.nototalan=@notot"
            cmd.Parameters.Clear()
            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@notot", nototalan)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                Dim row As String() = New String() {" ", "", ""}
                tables.Rows.Add(row)
                'row = New String() {" ", "", ""}
                'tables.Rows.Add(row)
                'row = New String() {"Summary: ", "", ""}
                'tables.Rows.Add(row)
                While reader.Read
                    row = New String() {"Borongan Kotor", "", "", "", String.Format("{0:n0}", reader("totalborongan") - reader("potongan") + reader("tambahan"))}
                    tables.Rows.Add(row)
                    row = New String() {"Sangu+Solar   ", "", String.Format("{0:n0}", reader("sangu") + reader("solar")), "", ""}
                    tables.Rows.Add(row)
                    row = New String() {"Tambahan (FM)", "", "", String.Format("{0:n}", reader("tambahantotalan"))}
                    tables.Rows.Add(row)
                    row = New String() {"Tambahan BKR+Tol", "", "", String.Format("{0:n}", reader("tambahantotalan1"))}
                    tables.Rows.Add(row)
                    row = New String() {"Tambahan Lain", "", "", String.Format("{0:n}", reader("tambahantotalan2"))}
                    tables.Rows.Add(row)
                    row = New String() {"Potongan", "", String.Format("{0:n}", reader("potongantotalan")), ""}
                    tables.Rows.Add(row)
                    row = New String() {"Sisa", "", "", "", String.Format("{0:n0}", reader("diterima"))}
                    tables.Rows.Add(row)
                    'row = New String() {"Sangu + Kasbon", "0.00", String.Format("{0:n}", reader("sangu"))}
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
    Private Sub loaddata()
        If init = False Then
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim query As String = ""
            query = "select h.nototalan, s.namasopir, h.tanggal"
            query &= " from thtotalan h, tsopir s"
            query &= " where h.kodesopir = s.kodesopir"
            query &= " and nototalan like '%" & txtnototalan.Text & "%'"
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
    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click, txtnototalan.TextChanged, dtpawal.ValueChanged, dtpakhir.ValueChanged, cbsopir.SelectedIndexChanged
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                cetaklaporanbaru(DataGridView1.Rows(e.RowIndex).Cells("nototalan").Value)
            End If
        End If
    End Sub
End Class