Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports RjLibrary
Public Class FrmMasterLaporanSJ
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Public Sub loadSupp()
        Try
            Dim da As New SqlDataAdapter("select distinct(namasupplier) from tsupplier", conn)
            Dim ds1 As New DataSet
            da.Fill(ds1)
            cmbSupp.Items.Clear()
            cmbSupp.Items.Add("[Semua]")
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                cmbSupp.Items.Add(ds1.Tables(0).Rows(i).Item(0))
            Next
            cmbSupp.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("loadSupp: " + ex.Message)
        End Try
    End Sub

    Public Sub loadStatus()
        Try
            cmbStatus.Items.Clear()
            cmbStatus.Items.Add("[Semua]")
            cmbStatus.Items.Add("Open")
            cmbStatus.Items.Add("Process")
            cmbStatus.Items.Add("Close")
            cmbStatus.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("loadStatus :" + ex.Message)
        End Try
    End Sub

    Private Sub FrmMasterLaporanSJ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadSupp()
        loadStatus()
    End Sub

    Private Sub btnLihatLaporan_Click(sender As System.Object, e As System.EventArgs) Handles btnLihatLaporan.Click
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT sj.nosuratjalan,convert(varchar,sj.tgl,105) as tgl,sj.borongansopir,sj.status,sj.tambahan,sj.totalborongansupplier,g.namagudang as asal1,vg.namagudang as tujuan1,k.nopol,s.namasupplier "
        cmd.CommandText &= " FROM tgudang g,vgudang vg,tSuratJalan sj,tBM b,tKendaraan k,tsupplier s"
        'jun 11 feb 2015
        cmd.CommandText &= " WHERE vg.kodegudang=sj.tujuan and g.kodegudang=sj.asal and sj.kodesupplier=s.kodesupplier and sj.noBM=b.noBM and b.nolambung=k.nolambung"
        If cbkPeriode.Checked Then
            cmd.CommandText &= " AND sj.tgl BETWEEN @from AND @to"
            cmd.Parameters.Add(New SqlParameter("@from", dtpFromPeriode.Value.ToString("MM-dd-yyyy")))
            cmd.Parameters.Add(New SqlParameter("@to", dtpToPeriode.Value.ToString("MM-dd-yyyy")))
        End If
        If cmbStatus.SelectedIndex > 0 And cbkStatus.Checked = True Then
            Dim stat As Integer = 0
            If cmbStatus.SelectedIndex = 1 Then
                stat = 0
            ElseIf cmbStatus.SelectedIndex = 2 Then
                stat = 1
            ElseIf cmbStatus.SelectedIndex = 3 Then
                stat = 2
            End If
            cmd.CommandText &= " AND sj.status = @stat"
            cmd.Parameters.Add(New SqlParameter("@stat", stat))
        End If
        If cmbSupp.SelectedIndex > 0 And cbkSupp.Checked = True Then
            cmd.CommandText &= " AND s.namasupplier = @nama"
            cmd.Parameters.Add(New SqlParameter("@nama", cmbSupp.Text))
        End If
        If txtNopol.Text <> "" And cbkNopol.Checked Then
            cmd.CommandText &= " AND k.nopol like '%" & txtNopol.Text & "%'"
            'cmd.Parameters.Add(New SqlParameter("@nopolisi", txtNopol.Text))
        End If
        cmd.CommandText &= " ORDER BY sj.tgl"
        Try
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                Dim report As New LaporanSuratJalan
                report.SetDataSource(dt)
                If cbkPeriode.Checked Then
                    report.SetParameterValue("mulai", dtpFromPeriode.Value.ToString("dd-MM-yyyy"))
                    report.SetParameterValue("sampai", dtpToPeriode.Value.ToString("dd-MM-yyyy"))
                Else
                    report.SetParameterValue("mulai", Now.ToString("dd-MM-yyyy"))
                    report.SetParameterValue("sampai", Now.ToString("dd-MM-yyyy"))
                End If
                frmcetaklaporan.CrystalReportViewer1.ReportSource = report
                frmcetaklaporan.CrystalReportViewer1.Refresh()
                frmcetaklaporan.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
                frmcetaklaporan.ShowDialog()
            Else
                _rjcommon.shownotifyerror("No Record Found To Display")
            End If
        Catch ex As Exception
            MsgBox("klik show : " + ex.Message)
        End Try
    End Sub
End Class