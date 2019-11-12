Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmBonMuat
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Public Sub loaddata()
        Dim da As New SqlDataAdapter()
        Dim command As New SqlCommand
        Dim query As String = "select m.nobm,m.nolambung,m.tgl,k.nopol,s.namasopir,s.panggilan,jk.namajenis from tbm m,tkendaraan k,tsopir s,tjeniskendaraan jk"
        query &= " where m.nolambung=k.nolambung and m.kodesopir=s.kodesopir and k.jenis=jk.kodejenis"
        'jun 14 jan 2015
        query &= " and nobm like '%" + txtNoBM.Text + "%' and nopol like '%" + txtNopol.Text + "%' and namasopir like '%" + txtSopir.Text + "%'"
        query &= " and tgl>=@tgl1 and tgl<=@tgl2"
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = query
        'jun 3 feb 2015
        command.Parameters.AddWithValue("@tgl1", dtTglAwal.Value.Date)
        command.Parameters.AddWithValue("@tgl2", dtTglAkhir.Value.Date)
        da.SelectCommand = command
        ds.Clear()
        da.Fill(ds, "bonmuat")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "bonmuat"
        DataGridView1.Refresh()

        lblJumlahData.Text = ds.Tables("bonmuat").Rows.Count.ToString
    End Sub
    Private Sub frmBonMuat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'jun 14 jan 2015
        DataGridView1.AutoGenerateColumns = False
        dtTglAwal.Value = New Date(Now.Year, Now.Month, 1, 0, 0, 1)
        dtTglAkhir.Value = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)

        loaddata()
    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click, txtNoBM.TextChanged, txtSopir.TextChanged, txtNopol.TextChanged, dtTglAwal.ValueChanged, dtTglAkhir.ValueChanged
        loaddata()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmbm.ShowDialog()
        loaddata()
    End Sub
End Class