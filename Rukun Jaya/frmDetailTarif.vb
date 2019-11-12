Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailTarif
    Dim rj As New RJCommon
    Dim conn As New SqlConnection

    Private Sub Clear()
        txtKodeBorongan.Clear()
        txtNamaBorongan.Clear()
        If cmbJenisKendaraan.Items.Count > 0 Then
            cmbJenisKendaraan.SelectedIndex = 0
        End If
        If cmbAsalGudang.Items.Count > 0 Then
            cmbAsalGudang.SelectedIndex = 0
        End If
        If cmbTujuanGudang.Items.Count > 0 Then
            cmbTujuanGudang.SelectedIndex = 0
        End If
        numHargaBorongan.Text = 0
        numHargaBoronganSopir.Text = 0
        numSangu.Text = 0
    End Sub

    'Private Sub txtHargaBorongan_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHargaBorongan.KeyUp
    'If e.KeyCode > 47 And e.KeyValue < 58 Then
    '    If e.KeyValue <> 8 Or e.KeyValue <> 13 Or e.KeyValue <> 37 Or e.KeyValue <> 38 Or e.KeyValue <> 39 Or e.KeyValue <> 40 Then
    '        e.Handled = True
    '        Label21.Text = FormatNumber(txtHargaBorongan.Text, 0)
    '    Else
    '        txtHargaBoronganSopir.Clear()
    '    End If
    'End If
    'End Sub

    Sub isiCmbJenisKendaraan()
        Dim query As String = "SELECT KODEJENIS, NAMAJENIS FROM TJENISKENDARAAN"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "Jenis_Kendaraan")
        With cmbJenisKendaraan
            .DataSource = dataset.Tables("Jenis_Kendaraan")
            .DisplayMember = "NAMAJENIS"
            .ValueMember = "KODEJENIS"
            If dataset.Tables("Jenis_Kendaraan").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        If dataset.Tables("Jenis_Kendaraan").Rows.Count <= 0 Then
            btnSimpanTarif.Enabled = False
        End If
    End Sub

    Sub isiCmbNamaBrg()
        Dim query As String = "SELECT KODEBARANG, NAMABARANG FROM TBARANG"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "Barang")
        With cmbNamaBrg
            .DataSource = dataset.Tables("Barang")
            .DisplayMember = "NAMABARANG"
            .ValueMember = "KODEBARANG"
            If dataset.Tables("Barang").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        If dataset.Tables("Barang").Rows.Count <= 0 Then
            btnSimpanTarif.Enabled = False
        End If
    End Sub

    Sub isiCmbGudang()
        Dim query As String = "SELECT KODEGUDANG, NAMAGUDANG FROM TGUDANG"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "GudangAsal")
        With cmbAsalGudang
            .DataSource = dataset.Tables("GudangAsal")
            .DisplayMember = "NAMAGUDANG"
            .ValueMember = "KODEGUDANG"
            If dataset.Tables("GudangAsal").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        If dataset.Tables("GudangAsal").Rows.Count <= 0 Then
            btnSimpanTarif.Enabled = False
        End If
    End Sub

    Sub isiCmbGudangTujuan()
        Dim query As String = "SELECT KODEGUDANG, NAMAGUDANG FROM TGUDANG"
        Dim adapt As New SqlDataAdapter(query, conn)
        Dim dataset As New DataSet
        adapt.Fill(dataset, "GudangTujuan")
        With cmbTujuanGudang
            .DataSource = dataset.Tables("GudangTujuan")
            .DisplayMember = "NAMAGUDANG"
            .ValueMember = "KODEGUDANG"
            If dataset.Tables("GudangTujuan").Rows.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
        If dataset.Tables("GudangTujuan").Rows.Count <= 0 Then
            btnSimpanTarif.Enabled = False
        End If
    End Sub

    Private Sub btnBatalTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalTarif.Click
        Clear()
        Me.Close()
    End Sub

    Private Sub frmDetailTarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New SqlConnection
        conn.ConnectionString = rj.getconnstr
        'jun 14 jan 2015
        btnSimpanTarif.Enabled = True
        isiCmbJenisKendaraan()
        isiCmbNamaBrg()
        isiCmbGudang()
        isiCmbGudangTujuan()

        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        cmd.CommandText = "SELECT * "
        cmd.CommandText += "FROM tHarga H, tJenisKendaraan K, tGudang G, vGudang V, tBarang B "
        cmd.CommandText += "WHERE jeniskendaraan=kodejenis and asal=G.kodegudang and tujuan=V.kodegudang and H.kodebarang=B.kodebarang and idborongan=@kode"

        cmd.Parameters.Clear()
        cmd.Parameters.Add(New SqlParameter("@kode", txtKodeBorongan.Text))
        Dim reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            txtKodeBorongan.Text = reader("idborongan")
            txtNamaBorongan.Text = reader("namaborongan")
            cmbJenisKendaraan.SelectedValue = reader("jeniskendaraan")
            cmbNamaBrg.SelectedValue = reader("kodebarang")
            cmbAsalGudang.SelectedValue = reader("asal")
            cmbTujuanGudang.SelectedValue = reader("tujuan")
            numHargaBorongan.Value = reader("borongan")
            numHargaBoronganSopir.Value = reader("borongansopir")
            numSangu.Value = reader("sangu")
            numOngkos.Value = reader("ongkos")
            numKuli.Value = reader("kuli")
        End If
        reader.Close()
        conn.Close()
    End Sub

    Private Sub frmDetailTarif_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Clear()
        FrmTarif.RefreshDataset()
    End Sub

    Private Sub frmDetailTarif_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub btnSimpanTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanTarif.Click
        Try
            Dim tempKode As String = txtKodeBorongan.Text

            If tempKode <> "" Then
                conn.Open()
                Dim cmd As SqlCommand = New SqlCommand
                cmd.Connection = conn

                If lblMode.Text.ToLower = "tambah" Then
                    cmd.CommandText = "INSERT INTO tHarga (idborongan,namaborongan,jeniskendaraan,asal,tujuan,kodebarang,borongan,borongansopir,sangu,ongkos,kuli) "
                    cmd.CommandText += "VALUES (@KODE,@NAMA,@JENIS,@ASAL,@TUJUAN,@BARANG,@BORONGAN,@BORONGANSOPIR,@SANGU,@ONGKOS,@KULI)"
                    cmd.Parameters.AddWithValue("@KODE", tempKode)
                    cmd.Parameters.AddWithValue("@NAMA", txtNamaBorongan.Text)
                    cmd.Parameters.AddWithValue("@JENIS", cmbJenisKendaraan.SelectedValue)
                    cmd.Parameters.AddWithValue("@ASAL", cmbAsalGudang.SelectedValue)
                    cmd.Parameters.AddWithValue("@TUJUAN", cmbTujuanGudang.SelectedValue)
                    cmd.Parameters.AddWithValue("@BARANG", cmbNamaBrg.SelectedValue)
                    cmd.Parameters.AddWithValue("@BORONGAN", numHargaBorongan.Value)
                    cmd.Parameters.AddWithValue("@BORONGANSOPIR", numHargaBoronganSopir.Value)
                    cmd.Parameters.AddWithValue("@SANGU", numSangu.Value)
                    cmd.Parameters.AddWithValue("@ONGKOS", numOngkos.Value)
                    cmd.Parameters.AddWithValue("@KULI", numKuli.Value)
                    cmd.ExecuteNonQuery()

                    rj.isilog(rj.getusername, tempKode, "Master Tarif", "Tambah Data", "")
                ElseIf lblMode.Text.ToLower = "ubah" Then
                    Try
                        cmd.CommandText = "UPDATE tHarga SET namaborongan=@NAMA, jeniskendaraan=@JENIS, "
                        cmd.CommandText += "asal=@ASAL, tujuan=@TUJUAN, kodebarang=@BARANG, borongan=@BORONGAN, "
                        cmd.CommandText += "borongansopir=@BORONGANSOPIR, SANGU=@SANGU, ONGKOS=@ONGKOS, KULI=@KULI "
                        cmd.CommandText += "WHERE idborongan=@KODE"
                        cmd.Parameters.AddWithValue("@KODE", tempKode)
                        cmd.Parameters.AddWithValue("@NAMA", txtNamaBorongan.Text)
                        cmd.Parameters.AddWithValue("@JENIS", cmbJenisKendaraan.SelectedValue)
                        cmd.Parameters.AddWithValue("@ASAL", cmbAsalGudang.SelectedValue)
                        cmd.Parameters.AddWithValue("@TUJUAN", cmbTujuanGudang.SelectedValue)
                        cmd.Parameters.AddWithValue("@BARANG", cmbNamaBrg.SelectedValue)
                        cmd.Parameters.AddWithValue("@BORONGAN", numHargaBorongan.Value)
                        cmd.Parameters.AddWithValue("@BORONGANSOPIR", numHargaBoronganSopir.Value)
                        cmd.Parameters.AddWithValue("@SANGU", numSangu.Value)
                        cmd.Parameters.AddWithValue("@ONGKOS", numOngkos.Value)
                        cmd.Parameters.AddWithValue("@KULI", numKuli.Value)
                        cmd.ExecuteNonQuery()


                        rj.isilog(rj.getusername, tempKode, "Master Tarif", "Update Data", "")
                    Catch ex As Exception
                        MsgBox(cmd.CommandText)
                    End Try

                End If

                rj.shownotify("Data Berhasil Disimpan")
                Clear()
                conn.Close()
                Me.Close()
            Else
                rj.shownotifyerror("Kode Borongan Wajib Diisi!")
                txtKodeBorongan.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            rj.shownotifyerror("Data Gagal Disimpan")
            rj.isiErrorlog(rj.getusername, txtKodeBorongan.Text, "Master Tarif", "Tambah/Update Data", ex.Message)
            conn.Close()
        End Try

    End Sub
End Class