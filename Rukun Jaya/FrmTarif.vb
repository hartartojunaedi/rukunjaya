Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmTarif
    Dim rj As New RJCommon
    Dim dataset As New DataSet
    Dim adapter As New SqlDataAdapter
    Dim conn As New SqlConnection
    Dim init = True

    Public Sub RefreshDataset()
        Dim cmd As New SqlCommand("", conn)

        cmd.CommandText = "SELECT idborongan, namaborongan, namabarang, K.namajenis, G.namagudang as asal, V.namagudang as tujuan "
        cmd.CommandText += "FROM tHarga H, tJenisKendaraan K, tGudang G, vGudang V, tBarang B "
        cmd.CommandText += "WHERE jeniskendaraan=kodejenis and asal=G.kodegudang and tujuan=V.kodegudang and H.kodebarang=B.kodebarang"
        cmd.CommandText += " and namaborongan like @NAMA "
        cmd.Parameters.AddWithValue("@NAMA", "%" & txtCariNamaBorongan.Text & "%")
        If cmbCariKendaraan.SelectedValue <> "" Then
            cmd.CommandText += " and jeniskendaraan = @JENIS "
            cmd.Parameters.AddWithValue("@JENIS", cmbCariKendaraan.SelectedValue)
        End If
        If cmbCariNamaBarang.SelectedValue <> "" Then
            cmd.CommandText += " and H.kodebarang = @BARANG "
            cmd.Parameters.AddWithValue("@BARANG", cmbCariNamaBarang.SelectedValue)
        End If
        If cmbCariKota.SelectedValue <> "" Then
            cmd.CommandText += " and (asal = @ASAL or v.kodegudang = @TUJUAN)"
            cmd.Parameters.AddWithValue("@ASAL", cmbCariKota.SelectedValue)
            cmd.Parameters.AddWithValue("@TUJUAN", cmbCariKota.SelectedValue)
        End If




        'If (txtCariNamaBorongan.Text = "" And cmbCariKendaraan.Text = "[SEMUA]" And cmbCariNamaBrang.Text = "[SEMUA]" And cmbCariKota.Text = "[SEMUA]") Then
        '    command = "SELECT idborongan, namaborongan, namabarang, K.namajenis, G.namagudang as asal, V.namagudang as tujuan "
        '    command += "FROM tHarga H, tJenisKendaraan K, tGudang G, vGudang V, tBarang B "
        '    command += "WHERE jeniskendaraan=kodejenis and asal=G.kodegudang and tujuan=V.kodegudang and H.kodebarang=B.kodebarang"
        'ElseIf (txtCariNamaBorongan.Text = "" Or cmbCariKendaraan.Text = "[SEMUA]" or) Then

        'Else

        'End If

        dataset.Clear()

        Try
            conn.Open()
            IsiDataSet(cmd)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub IsiDataSet(ByVal cmd As SqlCommand)
        adapter.SelectCommand = cmd

        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Tarif")
        dgvMasterTarif.DataSource = dataset
        dgvMasterTarif.DataMember = "Tarif"

        lblJumlahDataOperational.Text = dgvMasterTarif.RowCount
    End Sub

    Private Sub Clear()

    End Sub

    Sub isiCmbJenisKendaraan()
        Dim query As String = "SELECT KODEJENIS, NAMAJENIS FROM TJENISKENDARAAN"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "Jenis_Kendaraan")
        Dim dr As DataRow = dataset.Tables("Jenis_Kendaraan").NewRow()
        dr("KODEJENIS") = ""
        dr("NAMAJENIS") = "[SEMUA]"
        dataset.Tables("Jenis_Kendaraan").Rows.InsertAt(dr, 0)
        With cmbCariKendaraan
            .DataSource = dataset.Tables("Jenis_Kendaraan")
            .DisplayMember = "NAMAJENIS"
            .ValueMember = "KODEJENIS"
            .SelectedIndex = 0
        End With
    End Sub

    Sub isiCmbNamaBrg()
        Dim query As String = "SELECT KODEBARANG, NAMABARANG FROM TBARANG"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "Barang")
        Dim dr As DataRow = dataset.Tables("Barang").NewRow()
        dr(0) = ""
        dr(1) = "[SEMUA]"
        dataset.Tables("Barang").Rows.InsertAt(dr, 0)
        With cmbCariNamaBarang
            .DataSource = dataset.Tables("Barang")
            .DisplayMember = "NAMABARANG"
            .ValueMember = "KODEBARANG"
            .SelectedIndex = 0
        End With
    End Sub

    Sub isiCmbGudang()
        Dim query As String = "SELECT KODEGUDANG, NAMAGUDANG FROM TGUDANG"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "GudangAsal")
        Dim dr As DataRow = dataset.Tables("GudangAsal").NewRow()
        dr(0) = ""
        dr(1) = "[SEMUA]"
        dataset.Tables("GudangAsal").Rows.InsertAt(dr, 0)
        With cmbCariKota
            .DataSource = dataset.Tables("GudangAsal")
            .DisplayMember = "NAMAGUDANG"
            .ValueMember = "KODEGUDANG"
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub FrmTarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init = True
        conn = New SqlConnection
        conn.ConnectionString = rj.getconnstr
        isiCmbGudang()
        isiCmbJenisKendaraan()
        isiCmbNamaBrg()
        RefreshDataset()
        Clear()
        init = False
    End Sub

    Private Sub btnSeacrhTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeacrhTarif.Click
        RefreshDataset()
    End Sub

    Private Sub btnTambahTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahTarif.Click
        frmDetailTarif.lblMode.Text = "tambah"
        frmDetailTarif.txtKodeBorongan.Enabled = True
        frmDetailTarif.ShowDialog()
    End Sub

    Private Sub dgvMasterOperational_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMasterTarif.CellClick
        If e.ColumnIndex = 0 Then
            frmDetailMasterOperational.lblMode.Text = "ubah"

            frmDetailTarif.txtKodeBorongan.Text = dgvMasterTarif.Rows(e.RowIndex).Cells(2).Value
            frmDetailTarif.txtKodeBorongan.Enabled = False

            frmDetailTarif.ShowDialog()
        ElseIf e.ColumnIndex = 1 Then
            Dim tempKode As String = dgvMasterTarif.Rows(e.RowIndex).Cells(2).Value

            If MsgBox("Apakah Anda Yakin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                Try
                    conn.Open()

                    Dim cmdDel As SqlCommand = New SqlCommand
                    cmdDel.Connection = conn
                    cmdDel.CommandText = "delete from tHarga where idborongan=@KODE"
                    cmdDel.Parameters.AddWithValue("@KODE", tempKode)
                    cmdDel.ExecuteNonQuery()

                    rj.isilog(rj.getusername, tempKode, "Master Tarif", "Hapus Data", "")
                    rj.shownotify("Data Berhasil Dihapus")
                    conn.Close()
                Catch ex As Exception
                    rj.shownotifyerror("Data Gagal Dihapus")
                    rj.isiErrorlog(rj.getusername, tempKode, "Master Tarif", "Hapus Data", ex.Message)
                    conn.Close()
                End Try
            End If

            RefreshDataset()
        End If
    End Sub

    Private Sub txtCariNamaBorongan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariNamaBorongan.KeyPress
        RefreshDataset()
    End Sub

    Private Sub cmbCariKota_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCariKota.SelectedValueChanged, cmbCariNamaBarang.SelectedValueChanged, cmbCariKendaraan.SelectedIndexChanged
        If Not init Then
            RefreshDataset()
        End If
    End Sub

    Private Sub cmbCariNamaBarang_SelectedValueChanged(sender As Object, e As EventArgs)
        ' RefreshDataset()
    End Sub

    Private Sub cmbCariKendaraan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCariKendaraan.SelectedValueChanged
        'RefreshDataset()
    End Sub

    Private Sub cmbCariKendaraan_SelectedIndexChanged(sender As Object, e As EventArgs)
        'RefreshDataset()
    End Sub
End Class