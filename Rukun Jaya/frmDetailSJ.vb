Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailSJ
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public kodeSJ As String
    Public kodeBMdrSJ As String

    Public Sub loaddata()
        Try
            Dim queryload As String
            queryload = "select v.kodevoucher,s.namaspbu,v.liter,v.rupiahsatuan,v.rupiah,v.kasbon from tVoucherSPBU v,tSPBU s where v.kodespbu=s.kodespbu and v.nobm='" & kodeBMdrSJ & "' and v.noSuratJalan='" & kodeSJ & "'"
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim da As New SqlDataAdapter()
            cmd.CommandText = queryload
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds, "vou")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "vou"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox("loaddata : " + ex.Message)
        End Try
    End Sub

    Public Sub loadDetailSJ()
        Try
            Dim queryload As String
            queryload = "select b.NamaBarang,dsj.jumlah,dsj.noDO,dsj.noShippingList"
            queryload &= " from tDetailSuratJalan dsj,tBarang b"
            queryload &= " where b.Kodebarang=dsj.kodebarang and dsj.nobm='" & kodeBMdrSJ & "' and dsj.noSuratJalan='" & kodeSJ & "'"
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim da As New SqlDataAdapter()
            cmd.CommandText = queryload
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds, "loadSJ")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "loadSJ"
            DataGridView2.Refresh()
        Catch ex As Exception
            MsgBox("loaddetailSJ : " + ex.Message)
        End Try
    End Sub

    Public Sub loadDetail()
        Try
            'jun 6 feb 2015
            '            Dim da As New SqlDataAdapter("select s.noBM,su.namasupplier,p.namaPerwakilan,g.namagudang,gu.namagudang,s.tgl,s.tgldatang,s.tglmuat,s.tglbongkar from tSuratJalan s,tsupplier su,tPerwakilan p,tGudang g,tGudang gu,tBarang b,tDetailSuratJalan dsj where s.noSuratJalan='" & kodeSJ & "' and s.kodesupplier=su.kodesupplier and p.KodePerwakilan=s.kodeperwakilan and g.kodegudang=s.asal and gu.kodegudang=s.tujuan and b.Kodebarang=dsj.kodebarang and s.noSuratJalan=dsj.noSuratJalan", conn)
            Dim da As New SqlDataAdapter("select s.noBM,su.namasupplier,p.namaPerwakilan,g.namagudang,gu.namagudang,s.tgl,s.tgldatang,s.tglmuat,s.tglbongkar,s.bon,s.bonlain,s.sangu,s.borongansopir,jp.NamaPekerjaan from tSuratJalan s,tsupplier su,tPerwakilan p,tGudang g,tGudang gu,tJenisPekerjaan jp where s.noSuratJalan='" & kodeSJ & "' and s.kodesupplier=su.kodesupplier and p.KodePerwakilan=s.kodeperwakilan and g.kodegudang=s.asal and gu.kodegudang=s.tujuan and jp.Kodejenis=s.jenispekerjaan", conn)
            ds = New DataSet
            da.Fill(ds)
            lblKodeSJ.Text = kodeSJ
            lblKodeBM.Text = ds.Tables(0).Rows(0).Item(0)
            lblSupp.Text = ds.Tables(0).Rows(0).Item(1)
            lblPerwakilan.Text = ds.Tables(0).Rows(0).Item(2)
            lblAsal.Text = ds.Tables(0).Rows(0).Item(3)
            lblTujuan.Text = ds.Tables(0).Rows(0).Item(4)

            Dim tgl As Date = CDate(ds.Tables(0).Rows(0).Item(5))
            lblTglSJ.Text = tgl.Day.ToString + "-" + tgl.Month.ToString + "-" + tgl.Year.ToString
            tgl = CDate(ds.Tables(0).Rows(0).Item(6))
            lblTglDatang.Text = tgl.Day.ToString + "-" + tgl.Month.ToString + "-" + tgl.Year.ToString
            tgl = CDate(ds.Tables(0).Rows(0).Item(7))
            lblTglMuat.Text = tgl.Day.ToString + "-" + tgl.Month.ToString + "-" + tgl.Year.ToString
            tgl = CDate(ds.Tables(0).Rows(0).Item(8))
            lblTglBongkar.Text = tgl.Day.ToString + "-" + tgl.Month.ToString + "-" + tgl.Year.ToString

            lblPekerjaan.Text = ds.Tables(0).Rows(0).Item(13)
            lblBon.Text = Format(ds.Tables(0).Rows(0).Item(9), "N0")
            lblBonLain.Text = Format(ds.Tables(0).Rows(0).Item(10), "N0")
            lblSangu.Text = Format(ds.Tables(0).Rows(0).Item(11), "N0")
            lblBoronganSopir.Text = Format(ds.Tables(0).Rows(0).Item(12), "N0")
        Catch ex As Exception
            MsgBox("loaddetail : " + ex.Message)
        End Try
    End Sub

    Private Sub frmDetailSJ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loadDetailSJ()
        loadDetail()
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("detail").Index) And e.RowIndex >= 0 Then
            Dim a As New frmDetailVoucher
            a.kodeVoucher = DataGridView1.Rows(e.RowIndex).Cells("kodeVoucher").Value
            a.ShowDialog()
        End If
    End Sub

    Private Sub lblKodeBM_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblKodeBM.LinkClicked
        Dim a As New frmDetailBM
        a.kodeBM = lblKodeBM.Text
        a.ShowDialog()
    End Sub
End Class