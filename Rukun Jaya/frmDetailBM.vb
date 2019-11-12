Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailBM
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public kodeBM As String

    Public Sub loadDetail()
        Dim da As New SqlDataAdapter("select b.tgl,b.nolambung,s.namasopir,s.panggilan,k.nopol,k.Merek,jk.namajenis from tBM b,tSopir s,tKendaraan k,tJenisKendaraan jk where b.noBM='" & kodeBM & "' and b.kodesopir=s.kodesopir and b.nolambung=k.nolambung and jk.KodeJenis=k.jenis", conn)
        ds = New DataSet
        da.Fill(ds)
        lblKodeBM.Text = kodeBM
        Dim tgl As String = (ds.Tables(0).Rows(0).Item(0)).ToString
        lblTgl.Text = tgl.Substring(0, 2) + "-" + tgl.Substring(3, 2) + "-" + tgl.Substring(6, 4)
        lblNoLambung.Text = ds.Tables(0).Rows(0).Item(1)
        lblNamaSopir.Text = ds.Tables(0).Rows(0).Item(2)
        lblPanggilan.Text = ds.Tables(0).Rows(0).Item(3)
        lblNopol.Text = ds.Tables(0).Rows(0).Item(4)
        lblMerek.Text = ds.Tables(0).Rows(0).Item(5)
        lblJenis.Text = ds.Tables(0).Rows(0).Item(6)
    End Sub

    Public Sub loaddata()
        Dim queryload As String
        queryload = "select s.noSuratJalan,su.namasupplier,p.namaperwakilan,g.namagudang as asal,gu.namagudang as tujuan from tSuratJalan s,tsupplier su,tPerwakilan p,tGudang g,tGudang gu where p.KodePerwakilan=s.kodeperwakilan and s.kodesupplier=su.kodesupplier and g.kodeGudang=s.asal and gu.kodeGudang=s.tujuan and s.noBM='" & kodeBM & "'"
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        Dim da As New SqlDataAdapter()
        cmd.CommandText = queryload
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds, "sj")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "sj"
        DataGridView1.Refresh()
    End Sub

    Private Sub frmDetailBM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loadDetail()
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("detail").Index) And e.RowIndex >= 0 Then
            Dim a As New frmDetailSJ
            a.kodeSJ = DataGridView1.Rows(e.RowIndex).Cells("noSJ").Value
            a.kodeBMdrSJ = lblKodeBM.Text
            a.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class