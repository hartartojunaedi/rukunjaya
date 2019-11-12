Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmTransaksiSetOngkosSupplier
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Sub panggil()
        dataset.Clear()
        Dim cmd As SqlCommand = New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            If cmbStatus.SelectedIndex = 0 Then
                'Kondisi Jika Sudah Selesai
                cmd.CommandText = "SELECT SJ.NOSURATJALAN,SJ.NOBM,SJ.TGL, TBM.NOLAMBUNG,K.NOPOL,JK.NAMAJENIS,S.NAMASUPPLIER,S.ALAMATSUPPLIER,JP.NAMAPEKERJAAN,SJ.TOTALBORONGANSUPPLIER FROM TSURATJALAN SJ, TBM, TKENDARAAN K, TSUPPLIER S, TJENISKENDARAAN JK, TJENISPEKERJAAN JP WHERE SJ.NOBM=TBM.NOBM AND TBM.NOLAMBUNG=K.NOLAMBUNG AND SJ.KODESUPPLIER=S.KODESUPPLIER AND JK.KODEJENIS=K.JENIS AND JP.KODEJENIS=SJ.JENISPEKERJAAN AND SJ.TOTALBORONGANSUPPLIER>0 AND SJ.TGL >=@TGLAWAL AND SJ.TGL<=@TGLAKHIR AND SJ.NOSURATJALAN LIKE @NOSJ AND SJ.NOBM LIKE @NOBM AND S.NAMASUPPLIER LIKE @NAMASUPP AND K.NOPOL LIKE @NOPOL"
            Else
                'Kondisi Jika Belum Selesai
                cmd.CommandText = "SELECT SJ.NOSURATJALAN,SJ.NOBM,SJ.TGL, TBM.NOLAMBUNG,K.NOPOL,JK.NAMAJENIS,S.NAMASUPPLIER,S.ALAMATSUPPLIER,JP.NAMAPEKERJAAN,SJ.TOTALBORONGANSUPPLIER FROM TSURATJALAN SJ, TBM, TKENDARAAN K, TSUPPLIER S, TJENISKENDARAAN JK, TJENISPEKERJAAN JP WHERE SJ.NOBM=TBM.NOBM AND TBM.NOLAMBUNG=K.NOLAMBUNG AND SJ.KODESUPPLIER=S.KODESUPPLIER AND JK.KODEJENIS=K.JENIS AND JP.KODEJENIS=SJ.JENISPEKERJAAN AND (SJ.TOTALBORONGANSUPPLIER<=0 OR SJ.TOTALBORONGANSUPPLIER IS NULL) AND SJ.TGL >=@TGLAWAL AND SJ.TGL<=@TGLAKHIR AND SJ.NOSURATJALAN LIKE @NOSJ AND SJ.NOBM LIKE @NOBM AND S.NAMASUPPLIER LIKE @NAMASUPP AND K.NOPOL LIKE @NOPOL"
            End If

            'Bagian Parameter Untuk Filter
            cmd.Parameters.AddWithValue("@TGLAWAL", dtpAwalPeriode.Value.Date)
            cmd.Parameters.AddWithValue("@TGLAKHIR", dtpAkhirPeriode.Value.Date)
            cmd.Parameters.AddWithValue("@NOSJ", "%" & txtSuratJalan.Text & "%")
            cmd.Parameters.AddWithValue("@NOBM", "%" & txtNoBM.Text & "%")
            cmd.Parameters.AddWithValue("@NAMASUPP", "%" & txtSupp.Text & "%")
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
        'Inisialisasi Koneksi
        cn.ConnectionString = rj.getconnstr
        'Merubah ke awal tanggal bulan ini
        dtpAwalPeriode.Value = New DateTime(Date.Now.Year, Date.Now.Month, 1)
        'Merubah status combobox menjadi belum
        cmbStatus.SelectedIndex = 1
    End Sub


    Private Sub keFormBorongan(ByVal index As Integer)
        'Set isian data yang Ada pada form lain
        frmDetilSetOngkosSupplierBorongan.lblSJ.Text = dgvBM.Rows(index).Cells("NOSURATJALAN").Value
        frmDetilSetOngkosSupplierBorongan.lblBM.Text = dgvBM.Rows(index).Cells("NOBM").Value
        frmDetilSetOngkosSupplierBorongan.lblTgl.Text = dgvBM.Rows(index).Cells("TGL").FormattedValue
        frmDetilSetOngkosSupplierBorongan.lblNoLambung.Text = dgvBM.Rows(index).Cells("NOLAMBUNG").Value
        frmDetilSetOngkosSupplierBorongan.lblNoPol.Text = dgvBM.Rows(index).Cells("NOPOL").Value
        frmDetilSetOngkosSupplierBorongan.lblJK.Text = dgvBM.Rows(index).Cells("NAMAJENIS").Value
        frmDetilSetOngkosSupplierBorongan.lblSupp.Text = dgvBM.Rows(index).Cells("NAMASUPPLIER").Value
        frmDetilSetOngkosSupplierBorongan.lblJP.Text = dgvBM.Rows(index).Cells("NAMAPEKERJAAN").Value
        frmDetilSetOngkosSupplierBorongan.ShowDialog()
    End Sub



    Private Sub keFormAngkutPerUnit(ByVal index As Integer)
        'Set isian data yang Ada pada form lain
        frmDetilSetOngkosSupllierAngkutMuat.lblSJ.Text = dgvBM.Rows(index).Cells("NOSURATJALAN").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblBM.Text = dgvBM.Rows(index).Cells("NOBM").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblTgl.Text = dgvBM.Rows(index).Cells("TGL").FormattedValue
        frmDetilSetOngkosSupllierAngkutMuat.lblNoLambung.Text = dgvBM.Rows(index).Cells("NOLAMBUNG").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblNoPol.Text = dgvBM.Rows(index).Cells("NOPOL").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblJK.Text = dgvBM.Rows(index).Cells("NAMAJENIS").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblSupp.Text = dgvBM.Rows(index).Cells("NAMASUPPLIER").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblJP.Text = dgvBM.Rows(index).Cells("NAMAPEKERJAAN").Value
        frmDetilSetOngkosSupllierAngkutMuat.lblBorongan.Text = dgvBM.Rows(index).Cells("TotalOngkos").Value
        frmDetilSetOngkosSupllierAngkutMuat.ShowDialog()
    End Sub

    Private Sub keFormAngkutBoronganUnit(ByVal index As Integer)
        'Set isian data yang Ada pada form lain
        frmDetilSetOngkosSupplierBoronganUnit.lblSJ.Text = dgvBM.Rows(index).Cells("NOSURATJALAN").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblBM.Text = dgvBM.Rows(index).Cells("NOBM").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblTgl.Text = dgvBM.Rows(index).Cells("TGL").FormattedValue
        frmDetilSetOngkosSupplierBoronganUnit.lblNoLambung.Text = dgvBM.Rows(index).Cells("NOLAMBUNG").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblNoPol.Text = dgvBM.Rows(index).Cells("NOPOL").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblJK.Text = dgvBM.Rows(index).Cells("NAMAJENIS").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblSupp.Text = dgvBM.Rows(index).Cells("NAMASUPPLIER").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblJP.Text = dgvBM.Rows(index).Cells("NAMAPEKERJAAN").Value
        frmDetilSetOngkosSupplierBoronganUnit.lblBorongan.Text = dgvBM.Rows(index).Cells("TotalOngkos").Value
        frmDetilSetOngkosSupplierBoronganUnit.ShowDialog()
    End Sub

    Private Sub dgvBM_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            Try
                If IsDBNull(dgvBM.Rows(e.RowIndex).Cells("TotalOngkos").Value) Then
                    dgvBM.Rows(e.RowIndex).Cells("TotalOngkos").Value = 0
                End If

                If (dgvBM.Columns(e.ColumnIndex).Name = "SetOngkos" And e.RowIndex >= 0) Then
                    If dgvBM.Rows(e.RowIndex).Cells("TotalOngkos").Value = 0 Then
                        If dgvBM.Rows(e.RowIndex).Cells("NAMAPEKERJAAN").Value.ToString.ToUpper = "Kosongan".ToUpper Then
                            'MsgBox("4")
                        ElseIf dgvBM.Rows(e.RowIndex).Cells("NAMAPEKERJAAN").Value.ToString.ToUpper = "Borongan".ToUpper Then
                            keFormBorongan(e.RowIndex)
                        ElseIf dgvBM.Rows(e.RowIndex).Cells("NAMAPEKERJAAN").Value.ToString.ToUpper = "Borongan Unit".ToUpper Then
                            keFormAngkutBoronganUnit(e.RowIndex)
                        ElseIf dgvBM.Rows(e.RowIndex).Cells("NAMAPEKERJAAN").Value.ToString.ToUpper = "Angkut Per Unit".ToUpper Then
                            keFormAngkutPerUnit(e.RowIndex)
                        End If
                        panggil()
                    Else
                        MsgBox("Sudah Selesai")
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click, txtNoBM.TextChanged, txtSupp.TextChanged, txtCariNopol.TextChanged, dtpAwalPeriode.ValueChanged, dtpAkhirPeriode.ValueChanged, txtSuratJalan.TextChanged, cmbStatus.SelectedIndexChanged
        panggil()
    End Sub

    Private Sub dgvBM_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentClick

    End Sub
End Class