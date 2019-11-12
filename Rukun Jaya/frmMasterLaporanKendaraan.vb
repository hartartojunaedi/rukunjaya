Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports RjLibrary
Public Class frmMasterLaporanKendaraan
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Function cekHolding()
        Dim benar As Boolean = False
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cmd.CommandText = "select count(*) from tPerusahaan where namaPerusahaan='" & cmbPer.Text & "' and holding='True'"
            Dim hasil As Integer = cmd.ExecuteScalar
            If hasil > 0 Then
                benar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return benar
    End Function

    Public Sub loadPerusahaan()
        Try
            Dim da As New SqlDataAdapter("select namaperusahaan from tPerusahaan order by holding desc", conn)
            Dim ds1 As New DataSet
            da.Fill(ds1)
            cmbPer.Items.Clear()
            cmbPer.Items.Add("[Semua]")
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                cmbPer.Items.Add(ds1.Tables(0).Rows(i).Item(0))
            Next
            cmbPer.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("loadPerusahaan: " + ex.Message)
        End Try
    End Sub

    Private Sub btnLihatLaporan_Click(sender As System.Object, e As System.EventArgs) Handles btnLihatLaporan.Click
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT k.nolambung,k.nopol,k.Pemilik,k.Merek,k.Tahun,jk.namajenis,k.noBPKB,p.namaperusahaan,k.norangka,k.nomesin,convert(varchar,k.jatuhtempo,105) as jatuhtempo,convert(varchar,k.jatuhtempobpkb,105) as jatuhtempobpkb"
        cmd.CommandText &= " FROM tKendaraan k,tPerusahaan p,tJenisKendaraan jk"
        cmd.CommandText &= " WHERE p.kodeperusahaan=k.kodeperusahaan and jk.KodeJenis=k.jenis"
        If cmbPer.SelectedIndex > 0 And Not cekHolding() Then
            cmd.CommandText &= " AND p.namaperusahaan = @nama"
            cmd.Parameters.Add(New SqlParameter("@nama", cmbPer.Text))
        Else
            cmd.CommandText &= " ORDER BY p.holding desc"
        End If
        Try
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            Dim report As New LaporanKendaraan
            report.SetDataSource(dt)
            If cmbPer.SelectedIndex > 0 Then
                report.SetParameterValue("namapsh", cmbPer.Text)
            Else
                report.SetParameterValue("namapsh", "(semua)")
            End If
            frmcetaklaporan.CrystalReportViewer1.ReportSource = report
            frmcetaklaporan.CrystalReportViewer1.Refresh()
            frmcetaklaporan.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
            frmcetaklaporan.ShowDialog()
        Catch ex As Exception
            MsgBox("klik show : " + ex.Message)
        End Try
    End Sub

    Private Sub frmMasterLaporanKendaraan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadPerusahaan()
    End Sub
End Class