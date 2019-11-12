Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmSerachSJBuatPenagihan
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Dim listSJ As String = ""

    Sub getList()
        Dim tdataset = frmBuatPenagihan.datasetTagihan
        listSJ = "'"
        If tdataset.Tables("tagihan").Rows.Count = 0 Then
            listSJ = "''"
        Else
            For i As Integer = 0 To tdataset.Tables("tagihan").Rows.Count - 1
                If i = tdataset.Tables("tagihan").Rows.Count - 1 Then
                    listSJ &= tdataset.Tables("tagihan").Rows(i).Item("SJ").ToString().Trim & "'"
                Else
                    listSJ &= tdataset.Tables("tagihan").Rows(i).Item("SJ").ToString().Trim & "','"
                End If
            Next
        End If
    End Sub

    Sub panggil()
        dataset.Clear()
        getList()

        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "SELECT SJ.NOSURATJALAN,SJ.NOBM,SJ.TGL, TBM.NOLAMBUNG,K.NOPOL,JK.NAMAJENIS,S.NAMASUPPLIER,S.ALAMATSUPPLIER,JP.NAMAPEKERJAAN,SJ.TOTALBORONGANSUPPLIER,SJ.BORONGANSOPIR FROM TSURATJALAN SJ, TBM, TKENDARAAN K, TSUPPLIER S, TJENISKENDARAAN JK, TJENISPEKERJAAN JP WHERE SJ.NOBM=TBM.NOBM AND TBM.NOLAMBUNG=K.NOLAMBUNG AND SJ.KODESUPPLIER=S.KODESUPPLIER AND JK.KODEJENIS=K.JENIS AND JP.KODEJENIS=SJ.JENISPEKERJAAN AND SJ.TOTALBORONGANSUPPLIER>0 AND SJ.TGL >=@TGLAWAL AND SJ.TGL<=@TGLAKHIR AND SJ.NOSURATJALAN LIKE @NOSJ AND SJ.NOBM LIKE @NOBM AND S.KODESUPPLIER LIKE @KODESUPPLIER AND K.NOPOL LIKE @NOPOL AND SJ.NOSURATJALAN NOT IN(" & listSJ & ") AND SJ.STATUS<2"

            'Bagian Parameter Untuk Filter
            cmd.Parameters.AddWithValue("@TGLAWAL", dtpAwalPeriode.Value.Date)
            cmd.Parameters.AddWithValue("@TGLAKHIR", dtpAkhirPeriode.Value.Date)
            cmd.Parameters.AddWithValue("@NOSJ", "%" & txtSuratJalan.Text & "%")
            cmd.Parameters.AddWithValue("@NOBM", "%" & txtNoBM.Text & "%")
            cmd.Parameters.AddWithValue("@KODESUPPLIER", "%" & frmBuatPenagihan.kodesupp & "%")
            cmd.Parameters.AddWithValue("@NOPOL", "%" & txtCariNopol.Text & "%")

            'Bagian Untuk Menampilkan Data Di Gridview
            adapter.SelectCommand = cmd
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "setongkos")
            dgvBM.DataSource = dataset
            dgvBM.DataMember = "setongkos"
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
        dtpAwalPeriode.Value = New DateTime(Date.Now.Year, Date.Now.Month, 1)
        panggil()
    End Sub


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click, txtNoBM.TextChanged, dtpAwalPeriode.ValueChanged, dtpAkhirPeriode.ValueChanged, txtCariNopol.TextChanged, txtSuratJalan.TextChanged
        panggil()
    End Sub

    Private Sub dgvBM_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvBM.DoubleClick
        If dgvBM.CurrentRow.Index >= 0 Then
            frmBuatPenagihan.lblSJ.Text = dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("nosuratjalan").Value
            frmBuatPenagihan.lblBM.Text = dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("nobm").Value
            frmBuatPenagihan.lblBiaya.Text = CDbl(dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("TotalOngkos").Value).ToString("#,#")
            Me.Close()
        End If

    End Sub

    Private Sub dgvBM_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            frmBuatPenagihan.lblSJ.Text = dgvBM.Rows(e.RowIndex).Cells("nosuratjalan").Value
            frmBuatPenagihan.lblBM.Text = dgvBM.Rows(e.RowIndex).Cells("nobm").Value
            frmBuatPenagihan.lblBiaya.Text = CDbl(dgvBM.Rows(dgvBM.CurrentRow.Index).Cells("TotalOngkos").Value).ToString("#,#")
            Me.Close()
        End If
    End Sub

End Class