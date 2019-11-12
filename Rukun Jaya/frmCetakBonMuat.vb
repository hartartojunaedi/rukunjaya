Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmCetakBonMuat
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Public Sub loaddata()
        Dim queryload As String
        queryload = "select sj.nosuratjalan,b.noBM,b.tgl,b.nolambung,k.nopol, jk.namajenis,s.namasopir, s.panggilan "
        'jun 10 feb 2015
        queryload &= " from tsuratjalan sj,tBM b,tSopir s,tKendaraan k, tJenisKendaraan jk "
        queryload &= " where sj.nobm=b.nobm and k.nolambung=b.nolambung and b.kodesopir=s.kodesopir and jk.KodeJenis=k.jenis"
        queryload &= " and b.noBM like '%" & txtNoBM.Text & "%'"
        queryload &= " and sj.nosuratjalan like '%" & txtnosuratjalan.Text & "%'"
        queryload &= " and s.namasopir like '%" & txtSopir.Text & "%'"
        queryload &= " and k.nopol like '%" & txtNopol.Text & "%'"
        queryload &= " and b.tgl >= @tgl1 and b.tgl <= @tgl2"
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = queryload
        cmd.Parameters.AddWithValue("@tgl1", dtMulai.Value.Date)
        cmd.Parameters.AddWithValue("@tgl2", dtSampai.Value.Date)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds, "bm")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "bm"
        DataGridView1.Refresh()
        DataGridView1.Columns("tanggal").DefaultCellStyle.Format = "dd-MM-yyyy"
    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtSopir.TextChanged, txtNopol.TextChanged, txtNoBM.TextChanged, dtSampai.ValueChanged, dtMulai.ValueChanged
        loaddata()
    End Sub

    Private Sub frmCetakBonMuat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loaddata()
        dtMulai.Value = New Date(Now.Year, Now.Month, 1)
        dtSampai.Value = Now
    End Sub
    'jun 10 feb 2015
    Public Sub cetakBM(noBM As String, nosuratjalan As String)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        'Dim query As String = "select sj.*,k.nopol,s.namasopir,g.namagudang as gud"
        'query &= " from tBM b,tSuratJalan sj,tSopir s,tKendaraan k,tGudang g"
        'query &= " where g.kodegudang=sj.tujuan and sj.noBM=b.noBM and b.nolambung=k.nolambung and s.kodesopir=b.kodesopir and b.noBM=@bm and sj.nosuratjalan=@nosuratjalan"
        Dim query As String = "select mb.namabiaya,db.biaya,db.keterangan,sj.*,k.nopol,s.namasopir,g.namagudang as namagudang"
        query &= " from tBM b,tSuratJalan sj,tSopir s,tKendaraan k,tGudang g,tbiaya mb,tdetailbiaya db"
        query &= " where g.kodegudang=sj.tujuan and sj.noBM=b.noBM and b.nolambung=k.nolambung "
        query &= "  and mb.kodebiaya=db.kodebiaya and biaya>0 and db.nobm=sj.nobm and db.nosuratjalan=sj.nosuratjalan "
        query &= " and s.kodesopir=b.kodesopir and b.noBM=@bm and sj.nosuratjalan=@nosuratjalan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@bm", noBM)
        cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        da.SelectCommand = cmd
        Try
            da.Fill(ds, "bonmuat")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If ds.Tables("bonmuat").Rows.Count > 0 Then
            Dim rep As New bonMuatBaru
            rep.SetDataSource(ds.Tables("bonmuat"))
            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
        
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("cetak").Index) And e.RowIndex >= 0 Then
            cetakBM(DataGridView1.Rows(e.RowIndex).Cells("noBonMuat").Value, DataGridView1.Rows(e.RowIndex).Cells("noSuratJalan").Value)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class