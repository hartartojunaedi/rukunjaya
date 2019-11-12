Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmCetaktagihanspbu
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True
    Private Sub frmCetakVoucher_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox) Or Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    'Private Sub loadspbu()
    '    Dim dr As SqlDataReader
    '    Dim cmd As New SqlCommand("select namaspbu from tspbu order by namaspbu", conn)
    '    If conn.State <> ConnectionState.Open Then
    '        conn.Open()
    '    End If
    '    cbspbu.Items.Clear()
    '    cbspbu.Items.Add("[Semua]")
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        cbspbu.Items.Add(dr.Item("namaspbu"))
    '    End While
    '    cbspbu.SelectedIndex = 0
    '    conn.Close()
    'End Sub
    Private Sub loaddata()
        If init = False Then
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.Parameters.Clear()
            cmd.Connection = conn
            Dim query As String = ""
            query = "select h.notagihan,h.kodepbu as kodespbu,s.namaspbu,h.tgl,h.nota,h.totalliter,h.totalrupiah,h.harga,h.totalbayar,h.kasbontunai,h.grandtotal,d.kodevoucher, d.liter, d.rupiah from thtagihanspbu h,tspbu s,tdtagihanspbu d where h.kodepbu = s.kodespbu and h.notagihan=d.notagihan "
     
            If chkperiode.Checked Then

                query &= " and h.tgl>=@tglawal and h.tgl<=@tglakhir"
                cmd.Parameters.AddWithValue("@tglawal", dtpawal.Value.Date)
                cmd.Parameters.AddWithValue("@tglakhir", dtpakhir.Value.Date)
            End If

            If chktagihan.Checked Then

                query &= " h.notagihan=@notagihan"
                cmd.Parameters.AddWithValue("@notagihan", txtnotagihan.Text)
            End If

            cmd.CommandText = query
            da.SelectCommand = cmd
            da.Fill(ds, "voucher")
             End If
    End Sub
    Private Sub frmCetakVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Public Sub cetakvoucher(ByVal notagihan As String)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        Dim query As String = ""
        cmd.CommandText = "select h.notagihan,h.kodepbu as kodespbu,s.namaspbu,convert(varchar,h.tgl,105) as tgl,h.nota,h.totalliter,h.totalrupiah,h.harga,h.totalbayar,h.kasbontunai,h.grandtotal,d.kodevoucher, d.liter, d.rupiah from thtagihanspbu h,tspbu s,tdtagihanspbu d where h.kodepbu = s.kodespbu and h.notagihan=d.notagihan "
        cmd.CommandText &= " and h.notagihan=@notagihan"
        cmd.CommandText &= " order by h.tgl"
        cmd.Parameters.AddWithValue("@notagihan", notagihan)
        da.SelectCommand = cmd
        Try
            da.Fill(ds, "voucherspbu")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim rep As New tagihanspbu
        rep.SetDataSource(ds.Tables("voucherspbu"))
        DirectCast(rep.ReportDefinition.ReportObjects("tglawal"), TextObject).Text = dtpawal.Value.ToString("dd-MM-yyyy")
        DirectCast(rep.ReportDefinition.ReportObjects("tglakhir"), TextObject).Text = dtpakhir.Value.ToString("dd-MM-yyyy")
        frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
        frmcetaklaporan.CrystalReportViewer1.RefreshReport()
        frmcetaklaporan.ShowDialog()
    End Sub
    Public Sub cetakvoucher(ByVal notagihan As String, ByVal tglawal As Date, ByVal tglakhir As Date)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        Dim query As String = ""
        cmd.CommandText = "select h.notagihan,h.kodepbu as kodespbu,s.namaspbu,convert(varchar,h.tgl,105) as tgl,h.nota,h.totalliter,h.totalrupiah,h.harga,h.totalbayar,h.kasbontunai,h.grandtotal,d.kodevoucher, d.liter, d.rupiah from thtagihanspbu h,tspbu s,tdtagihanspbu d where h.kodepbu = s.kodespbu and h.notagihan=d.notagihan "

        If chkperiode.Checked Then

            cmd.CommandText &= " and h.tgl>=@tglawal and h.tgl<=@tglakhir"
            cmd.Parameters.AddWithValue("@tglawal", tglawal)
            cmd.Parameters.AddWithValue("@tglakhir", tglakhir)
        End If

        If chktagihan.Checked Then

            cmd.CommandText &= " h.notagihan=@notagihan"
            cmd.Parameters.AddWithValue("@notagihan", notagihan)
        End If
        cmd.CommandText &= " order by h.tgl"
        da.SelectCommand = cmd
        Try
            da.Fill(ds, "voucherspbu")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'jun 13 feb 2015
        If ds.Tables("voucherspbu").Rows.Count > 0 Then
            Dim rep As New tagihanspbu
            rep.SetDataSource(ds.Tables("voucherspbu"))
            DirectCast(rep.ReportDefinition.ReportObjects("tglawal"), TextObject).Text = dtpawal.Value.ToString("dd-MM-yyyy")
            DirectCast(rep.ReportDefinition.ReportObjects("tglakhir"), TextObject).Text = dtpakhir.Value.ToString("dd-MM-yyyy")

            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.RowIndex >= 0 Then
        '    If e.ColumnIndex = 8 Then
        '        cetakvoucher(DataGridView1.Rows(e.RowIndex).Cells("nosuratjalan").Value, DataGridView1.Rows(e.RdtpowIndex).Cells("kodevoucher").Value)
        '    End If
        'End If
    End Sub

    Private Sub btnCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        cetakvoucher(txtnotagihan.Text, dtpawal.Value.Date, dtpakhir.Value.Date)
    End Sub

    Private Sub frmCetaktagihanspbu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class