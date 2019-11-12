Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmDetailVoucher
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public kodeVoucher As String

    Public Sub loadDetail()
        Try
            Dim da As New SqlDataAdapter("select v.nobm,v.noSuratJalan,s.namaspbu,v.liter,v.tglvoucher,v.sisa,v.status from tVoucherSPBU v,tSPBU s where s.kodespbu=v.kodespbu and kodevoucher='" & kodeVoucher & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            lblKodeVoucher.Text = kodeVoucher
            lblKodeBM.Text = ds.Tables(0).Rows(0).Item(0)
            lblKodeSJ.Text = ds.Tables(0).Rows(0).Item(1)
            lblSPBU.Text = ds.Tables(0).Rows(0).Item(2)
            lblLiter.Text = ds.Tables(0).Rows(0).Item(3)
            Dim tgl As String = Format(ds.Tables(0).Rows(0).Item(4), "dd-MM-yyyy")
            lblTgl.Text = tgl.Substring(0, 2) + "-" + tgl.Substring(3, 2) + "-" + tgl.Substring(6, 4)
            lblSisa.Text = ds.Tables(0).Rows(0).Item(5)
            If ds.Tables(0).Rows(0).Item(6).ToString = "0" Then
                lblStatus.Text = "Open"
            ElseIf ds.Tables(0).Rows(0).Item(6).ToString = "1" Then
                lblStatus.Text = "Process"
            ElseIf ds.Tables(0).Rows(0).Item(6).ToString = "2" Then
                lblStatus.Text = "Process"
            ElseIf ds.Tables(0).Rows(0).Item(6).ToString = "3" Then
                lblStatus.Text = "Close"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmDetailVoucher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadDetail()
    End Sub

    Private Sub lblKodeBM_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblKodeBM.LinkClicked
        Dim a As New frmDetailBM
        a.kodeBM = lblKodeBM.Text
        a.ShowDialog()
    End Sub

    Private Sub lblKodeSJ_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblKodeSJ.LinkClicked
        Dim a As New frmDetailSJ
        a.kodeSJ = lblKodeSJ.Text
        a.kodeBMdrSJ = lblKodeBM.Text
        a.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnCetak.Click
        frmCetakVoucher.cetakvoucher(lblKodeSJ.Text, lblKodeVoucher.Text)
    End Sub
End Class