Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseKendaraan
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter
    
    Sub panggil()
        Dim command As String
        command = "Select nolambung,nopol,merek,nomesin from tkendaraan where  nopol like '%" & txtnopol.Text & "%' and nomesin like '%" & txtnomesin.Text & "%'"

        ds.Clear()
        Try
            conn.Open()
            isidataset(New SqlCommand(command, conn))
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "Kendaraan")
        dgvKendaraan.DataSource = ds
        dgvKendaraan.DataMember = "Kendaraan"
        lblJumData.Text = ds.Tables(0).Rows.Count
    End Sub

    

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub dgvKendaraan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick
        frmbm.txtNoLambung.Text = dgvKendaraan.Rows(e.RowIndex).Cells("nolambung").Value
        frmbm.lblNoPolisi.Text = dgvKendaraan.Rows(e.RowIndex).Cells("nopol").Value
        Me.Close()

    End Sub

    Private Sub frmBrowseKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil()
    End Sub


    Private Sub txtnomesin_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnomesin.KeyUp
        panggil()
    End Sub

   
    Private Sub txtnopol_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnopol.KeyUp
        panggil()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        panggil()
    End Sub

    Private Sub dgvKendaraan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKendaraan.CellContentClick

    End Sub
End Class