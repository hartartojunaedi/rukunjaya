Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmSerachSJPenagihan
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Dim listSJ As String = ""
    Dim listBM As String = ""


    Sub panggil()
        dataset.Clear()

        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "SELECT T.KODETAGIHAN,S.NAMASUPPLIER AS NAMA,T.TGL AS TGL, T.TOTALTAGIHAN AS TOTAL FROM THTAGIHAN T, TSUPPLIER S WHERE T.KODESUPPLIER=S.KODESUPPLIER AND T.STATUS=0 AND S.NAMASUPPLIER LIKE @NAMA AND T.KODETAGIHAN LIKE @TAGIH "
            'Bagian Parameter Untuk Filter
            cmd.Parameters.AddWithValue("@NAMA", "%" & txtSupp.Text & "%")
            cmd.Parameters.AddWithValue("@TAGIH", "%" & txtTagihan.Text & "%")

            'Bagian Untuk Menampilkan Data Di Gridview
            adapter.SelectCommand = cmd
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "TAGIHAN")
            dgvBM.DataSource = dataset
            dgvBM.DataMember = "TAGIHAN"
            dgvBM.Refresh()
        Catch ex As Exception
            rj.shownotifyerror(ex.Message)
        Finally
            'Bagian Hapus Komponen Yang Sudah Tidak Dipakai
            adapter.Dispose()
            dataset.Dispose()
            cmd.Dispose()
            cn.Close()
        End Try
    End Sub

    Private Sub frmSetOngkos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'dtpAwalPeriode.Value = "1-" & Now.Month & "-" & Now.Year
        panggil()
    End Sub


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click, txtSupp.TextChanged, txtTagihan.TextChanged
        panggil()
    End Sub

    Private Sub dgvBM_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvBM.DoubleClick
        If dgvBM.CurrentRow.Index >= 0 Then
            frmBayarTagihan.lblSupp.Text = dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("NAMA").Value
            frmBayarTagihan.lblTagihan.Text = dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("TAGIHAN").Value
            frmBayarTagihan.lblBiaya.Text = CDbl(dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("TOTAL").Value).ToString("#,#")
            Me.Close()
        End If
        'frmBuatPenagihan.lblSJ.Text=
    End Sub

    Private Sub dgvBM_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            frmBayarTagihan.lblSupp.Text = dgvBM.Rows(e.RowIndex).Cells("NAMA").Value
            frmBayarTagihan.lblTagihan.Text = dgvBM.Rows(e.RowIndex).Cells("TAGIHAN").Value
            frmBayarTagihan.lblBiaya.Text = CDbl(dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("TOTAL").Value).ToString("#,#")
            Me.Close()
        End If
    End Sub

End Class