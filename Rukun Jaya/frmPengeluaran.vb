Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmPengeluaran
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Private Sub loadperusahaan()
        Dim query As String = ""
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        query = "select kodeperusahaan,namaperusahaan from tperusahaan where holding=0 order by namaperusahaan"
        cmd.Connection = conn
        cmd.CommandText = query
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cbPerusahaan.Items.Clear()
        cbPerusahaan.Items.Add("[Semua]")
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cbPerusahaan.Items.Add(dr.Item("namaperusahaan"))
            End While
        End If
        conn.Close()
        cbPerusahaan.SelectedIndex = 0
    End Sub
    Private Sub frmPengeluaran_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = New Date(Now.Year, 1, 1)
        dtpAkhir.Value = New Date(Now.Year, Now.Month, Now.Day)
        loadperusahaan()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmDetailPengeluaran.tglawal = dtpAwal.Value
        frmDetailPengeluaran.tglakhir = dtpAkhir.Value
        frmDetailPengeluaran.perusahaan = cbPerusahaan.Text
        frmDetailPengeluaran.ShowDialog()
    End Sub
End Class