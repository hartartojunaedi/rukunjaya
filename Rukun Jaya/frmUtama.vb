Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUtama
    Dim _rjcommon As New RJCommon
    Dim _rjnotifikasi As New rjNotifikasi
    Public Function tambahspasi(s As String, n As Integer) As String
        Return _rjcommon.appendspasi(s, n)
    End Function
    Private Sub notifikasimaintance()
        Dim dtrutin As New DataTable
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim rowrutin As DataRow
        dtrutin = _rjnotifikasi.getrutinmaintance
        If dtrutin.Rows.Count > 0 Then
            'ada data maintance rutin
            For i = 0 To dtrutin.Rows.Count - 1
                rowrutin = dtrutin.Rows(i)
                Dim dt As New DataTable
                If rowrutin.Item("jenis") = 2 Then
                    dt = _rjnotifikasi.jatuhtempomaintance(rowrutin.Item("kodejenismaintance"), rowrutin.Item("jenis"), Now.AddMonths(-1 * rowrutin.Item("jumlah")))
                Else
                    dt = _rjnotifikasi.jatuhtempomaintance(rowrutin.Item("kodejenismaintance"), rowrutin.Item("jenis"), rowrutin.Item("jumlah"))
                End If
                If dt.Rows.Count > 0 Then
                    txtnotifikasi.AppendText(rowrutin.Item("NamaPekerjaan") + vbCrLf)
                    txtnotifikasi.AppendText("---------------------------" + vbCrLf)
                    Dim row As DataRow
                    Dim s As String
                    For j = 0 To dt.Rows.Count - 1
                        row = dt.Rows(j)
                        s = tambahspasi(row.Item("nolambung"), 10) + " " + tambahspasi(row.Item("nopol"), 10) + " " + tambahspasi(row.Item("merek"), 20) + " "
                        If rowrutin.Item("jenis") = 0 Then
                            'pp
                            s &= row.Item("jumlah") & " pp"
                        Else
                            If rowrutin.Item("jenis") = 1 Then
                                'km
                                s &= row.Item("km") & "km (" & row.Item("kmlast") & "km)"
                            Else
                                s &= row.Item("lastmaintance")
                            End If
                        End If
                        txtnotifikasi.AppendText(s + vbCrLf)
                    Next
                    txtnotifikasi.AppendText(vbCrLf)
                End If
            Next
        End If
    End Sub
    Private Sub notifikasi()
        Dim dt As New DataTable
        Dim i As Integer
        Dim s As String = ""
        Dim row As DataRow
        dt = _rjnotifikasi.jatuhtempostnk(Now.Date.AddDays(7))
        txtnotifikasi.Clear()
        txtnotifikasi.AppendText("STNK Jatuh Tempo" + vbCrLf)
        txtnotifikasi.AppendText("---------------------------" + vbCrLf)
        If dt.Rows.Count >= 0 Then
            For i = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                s = tambahspasi(row.Item("nolambung"), 10) + " " + tambahspasi(row.Item("nopol"), 10) + " " + tambahspasi(row.Item("merek"), 20) + " " + String.Format("{0:dd-MM-yyyy}", CType(row.Item("jatuhtempo"), Date))
                txtnotifikasi.AppendText(s + vbCrLf)
            Next
        End If
        txtnotifikasi.AppendText(vbCrLf)
        'bpkb
        dt = _rjnotifikasi.jatuhtempobpkb(Now.Date.AddDays(7))
        txtnotifikasi.AppendText("BPKB Jatuh Tempo" + vbCrLf)
        txtnotifikasi.AppendText("---------------------------" + vbCrLf)
        If dt.Rows.Count >= 0 Then
            For i = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                s = tambahspasi(row.Item("nolambung"), 10) + " " + tambahspasi(row.Item("nopol"), 10) + " " + tambahspasi(row.Item("merek"), 20) + " " + String.Format("{0:dd-MM-yyyy}", CType(row.Item("jatuhtempobpkb"), Date))
                txtnotifikasi.AppendText(s + vbCrLf)

            Next
        End If
        txtnotifikasi.AppendText(vbCrLf)
        'uji kir
        dt = _rjnotifikasi.jatuhtempokir(Now.Date.AddDays(7))
        txtnotifikasi.AppendText("Uji Kir Jatuh Tempo" + vbCrLf)
        txtnotifikasi.AppendText("---------------------------" + vbCrLf)
        If dt.Rows.Count >= 0 Then
            For i = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                s = tambahspasi(row.Item("nolambung"), 10) + " " + tambahspasi(row.Item("nopol"), 10) + " " + tambahspasi(row.Item("merek"), 20) + " " + String.Format("{0:dd-MM-yyyy}", CType(row.Item("tglkirberikutnya"), Date))
                txtnotifikasi.AppendText(s + vbCrLf)
            Next
        End If
        txtnotifikasi.AppendText(vbCrLf)
        notifikasimaintance()
    End Sub
    Sub resetmenu()
        PerusahaanToolStripMenuItem.Visible = True
        PerwakilanToolStripMenuItem.Visible = True
        JenisKendaraanToolStripMenuItem.Visible = True
        KendaraanToolStripMenuItem.Visible = True
        SopirToolStripMenuItem.Visible = True
        BankToolStripMenuItem.Visible = True
        InventoryToolStripMenuItem.Visible = True
        MaintanceToolStripMenuItem.Visible = True
        OperasionalToolStripMenuItem.Visible = True
        GudangToolStripMenuItem.Visible = True
        SPBUToolStripMenuItem.Visible = True
        SupplierToolStripMenuItem.Visible = True
        BarangToolStripMenuItem.Visible = True
        PeralatanToolStripMenuItem.Visible = True
        SparePartToolStripMenuItem.Visible = True
        BiayaLainToolStripMenuItem.Visible = True
        KasBonToolStripMenuItem.Visible = True
        OperationalKendaraanToolStripMenuItem.Visible = True
        KasHarianToolStripMenuItem.Visible = True
        MutasiMasukToolStripMenuItem.Visible = True
        MutasiKeluarToolStripMenuItem.Visible = True
        AdjustmentToolStripMenuItem16.Visible = True
        UpdateHargaToolStripMenuItem.Visible = True
        UjiKirToolStripMenuItem.Visible = True
        MaintanceToolStripMenuItem2.Visible = True
        CatatKilometerToolStripMenuItem.Visible = True
        PinjamAlatToolStripMenuItem.Visible = True
        KembaliAlatToolStripMenuItem.Visible = True
        BonMuatToolStripMenuItem1.Visible = True
        SuratJalanToolStripMenuItem1.Visible = True
        LKuatToolStripMenuItem.Visible = True
        SetorToolStripMenuItem.Visible = True
        SetOngkosToolStripMenuItem.Visible = True
        TotalanToolStripMenuItem.Visible = True
        SetOngkosToolStripMenuItem1.Visible = True
        BuatTagihanToolStripMenuItem.Visible = True
        BayarTagihanToolStripMenuItem.Visible = True
        TagihanToolStripMenuItem1.Visible = True
        BayarToolStripMenuItem.Visible = True
        SparePartToolStripMenuItem1.Visible = True
        BonMuatToolStripMenuItem.Visible = True
        SuratJalanToolStripMenuItem.Visible = True
        VoucherSPBUToolStripMenuItem.Visible = True
        LogToolStripMenuItem.Visible = True
        changepasswordMenuItem6.Visible = True
        HistoryToolStripMenuItem.Visible = True
        CreateUserToolStripMenuItem.Visible = True
        SetAksesToolStripMenuItem11.Visible = True
        LogAdminToolStripMenuItem.Visible = True
        BackupToolStripMenuItem.Visible = True
        ParameterToolStripMenuItem.Visible = True
    End Sub
    Sub disableallmenu()
        PerusahaanToolStripMenuItem.Visible = False
        PerwakilanToolStripMenuItem.Visible = False
        JenisKendaraanToolStripMenuItem.Visible = False
        KendaraanToolStripMenuItem.Visible = False
        SopirToolStripMenuItem.Visible = False
        BankToolStripMenuItem.Visible = False
        InventoryToolStripMenuItem.Visible = False
        MaintanceToolStripMenuItem.Visible = False
        OperasionalToolStripMenuItem.Visible = False
        GudangToolStripMenuItem.Visible = False
        SPBUToolStripMenuItem.Visible = False
        SupplierToolStripMenuItem.Visible = False
        BarangToolStripMenuItem.Visible = False
        PeralatanToolStripMenuItem.Visible = False
        SparePartToolStripMenuItem.Visible = False
        BiayaLainToolStripMenuItem.Visible = False
        KasBonToolStripMenuItem.Visible = False
        OperationalKendaraanToolStripMenuItem.Visible = False
        KasHarianToolStripMenuItem.Visible = False
        MutasiMasukToolStripMenuItem.Visible = False
        MutasiKeluarToolStripMenuItem.Visible = False
        AdjustmentToolStripMenuItem16.Visible = False
        UpdateHargaToolStripMenuItem.Visible = False
        UjiKirToolStripMenuItem.Visible = False
        MaintanceToolStripMenuItem2.Visible = False
        CatatKilometerToolStripMenuItem.Visible = False
        PinjamAlatToolStripMenuItem.Visible = False
        KembaliAlatToolStripMenuItem.Visible = False
        BonMuatToolStripMenuItem1.Visible = False
        SuratJalanToolStripMenuItem1.Visible = False
        LKuatToolStripMenuItem.Visible = False
        SetorToolStripMenuItem.Visible = False
        SetOngkosToolStripMenuItem.Visible = False
        TotalanToolStripMenuItem.Visible = False
        SetOngkosToolStripMenuItem1.Visible = False
        BuatTagihanToolStripMenuItem.Visible = False
        BayarTagihanToolStripMenuItem.Visible = False
        TagihanToolStripMenuItem1.Visible = False
        BayarToolStripMenuItem.Visible = False
        SparePartToolStripMenuItem1.Visible = False
        BonMuatToolStripMenuItem.Visible = False
        SuratJalanToolStripMenuItem.Visible = False
        VoucherSPBUToolStripMenuItem.Visible = False
        LogToolStripMenuItem.Visible = False
        changepasswordMenuItem6.Visible = False
        HistoryToolStripMenuItem.Visible = False
        CreateUserToolStripMenuItem.Visible = False
        SetAksesToolStripMenuItem11.Visible = False
        LogAdminToolStripMenuItem.Visible = False
        BackupToolStripMenuItem.Visible = False
        ParameterToolStripMenuItem.Visible = False
    End Sub
    Sub disablemenu(id As Integer)
        Select Case id
            Case 0
                PerusahaanToolStripMenuItem.Visible = True
            Case 1
                PerwakilanToolStripMenuItem.Visible = True
            Case 2
                JenisKendaraanToolStripMenuItem.Visible = True
            Case 3
                KendaraanToolStripMenuItem.Visible = True
            Case 4
                SopirToolStripMenuItem.Visible = True
            Case 5
                BankToolStripMenuItem.Visible = True
            Case 6
                InventoryToolStripMenuItem.Visible = True
            Case 7
                MaintanceToolStripMenuItem.Visible = True
            Case 8
                OperasionalToolStripMenuItem.Visible = True
            Case 9
                GudangToolStripMenuItem.Visible = True
            Case 10
                SPBUToolStripMenuItem.Visible = True
            Case 11
                SupplierToolStripMenuItem.Visible = True
            Case 12
                BarangToolStripMenuItem.Visible = True
            Case 13
                PeralatanToolStripMenuItem.Visible = True
            Case 16
                SparePartToolStripMenuItem.Visible = True
            Case 17
                BiayaLainToolStripMenuItem.Visible = True
            Case 18
                KasBonToolStripMenuItem.Visible = True
            Case 19
                OperationalKendaraanToolStripMenuItem.Visible = True
            Case 20
                KasHarianToolStripMenuItem.Visible = True
            Case 21
                MutasiMasukToolStripMenuItem.Visible = True
            Case 22
                MutasiKeluarToolStripMenuItem.Visible = True
            Case 23
                AdjustmentToolStripMenuItem16.Visible = True
            Case 24
                UpdateHargaToolStripMenuItem.Visible = True
            Case 25
                UjiKirToolStripMenuItem.Visible = True
            Case 26
                MaintanceToolStripMenuItem2.Visible = True
            Case 27
                CatatKilometerToolStripMenuItem.Visible = True
            Case 28
                PinjamAlatToolStripMenuItem.Visible = True
            Case 29
                KembaliAlatToolStripMenuItem.Visible = True
            Case 31
                BonMuatToolStripMenuItem1.Visible = True
            Case 32
                SuratJalanToolStripMenuItem1.Visible = True
            Case 33
                LKuatToolStripMenuItem.Visible = True
            Case 34
                SetorToolStripMenuItem.Visible = True
            Case 35
                SetOngkosToolStripMenuItem.Visible = True
            Case 36
                TotalanToolStripMenuItem.Visible = True
            Case 38
                SetOngkosToolStripMenuItem1.Visible = True
            Case 39
                BuatTagihanToolStripMenuItem.Visible = True
            Case 40
                BayarTagihanToolStripMenuItem.Visible = True
            Case 42
                TagihanToolStripMenuItem1.Visible = True
            Case 43
                BayarToolStripMenuItem.Visible = True
            Case 45
                SparePartToolStripMenuItem1.Visible = True
            Case 46
                BonMuatToolStripMenuItem.Visible = True
            Case 47
                SuratJalanToolStripMenuItem.Visible = True
            Case 48
                VoucherSPBUToolStripMenuItem.Visible = True
            Case 50
                LogToolStripMenuItem.Visible = True
            Case 51
                changepasswordMenuItem6.Visible = True
            Case 52
                HistoryToolStripMenuItem.Visible = True
            Case 53
                CreateUserToolStripMenuItem.Visible = True
            Case 54
                SetAksesToolStripMenuItem11.Visible = True
            Case 55
                LogAdminToolStripMenuItem.Visible = True
            Case 56
                BackupToolStripMenuItem.Visible = True
            Case 57
                ParameterToolStripMenuItem.Visible = True
        End Select
    End Sub
    Private Sub pasangakses()
        Dim hak As String = _rjcommon.gethakakses(_rjcommon.getusername)
        'TODO : pasang hak akses
        'MasterToolStripMenuItem.Enabled = IIf(hak.Substring(0, 1) = "1", True, False)
        'PerusahaanToolStripMenuItem.Enabled = IIf(hak.Substring(1, 1) = "1", True, False)
        'PerwakilanToolStripMenuItem.Enabled = IIf(hak.Substring(2, 1) = "1", True, False)
    End Sub

    Sub cekhak()
        Try

        disableallmenu()
        Dim rj As New RJCommon
        Dim conn As New SqlConnection
        conn.ConnectionString = rj.getconnstr
        Dim cmd As New SqlCommand("Select * from tlogin where username=@username")
        cmd.Parameters.AddWithValue("@username", rj.getusername)
            cmd.Connection = conn
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr.Item("akses") <> 0 Then
                'bukan admin
                dr.Close()
                conn.Close()
                Dim cmd1 As New SqlCommand
                Dim query1 As String = "select id from tmenulogin where username=@username"
                cmd1.Connection = conn
                cmd1.CommandText = query1
                cmd1.Parameters.AddWithValue("@username", rj.getusername)
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                Dim dr1 As SqlDataReader = cmd1.ExecuteReader
                If dr1.HasRows Then
                    While dr1.Read
                        disablemenu(dr1.Item("id"))
                    End While
                End If
            Else
                'admin
                resetmenu()
            End If
        End If
       

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = _rjcommon.getusername
        ToolStripStatusLabel2.Text = _rjcommon.gettgltime
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 40
        pasangakses()
        cekhak()
        '_rjcommon.shownotify(_rjcommon.getnoTagihanSPBU)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = _rjcommon.gettgltime
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GudangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GudangToolStripMenuItem.Click
        frmMasterGudang.ShowDialog()
    End Sub

    Private Sub BankToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BankToolStripMenuItem.Click
        frmMasterBank.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventoryToolStripMenuItem.Click
        frmMasterInventory.ShowDialog()
    End Sub

    Private Sub KendaraanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KendaraanToolStripMenuItem.Click
        frmMasterKendaraan.ShowDialog()
    End Sub

    Private Sub SPBUToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SPBUToolStripMenuItem.Click
        frmMasterSPBU.ShowDialog()
    End Sub

    Private Sub PerwakilanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PerwakilanToolStripMenuItem.Click
        Dim a As New frmMasterPerwakilan
        a.ShowDialog()
        'frmMasterPerwakilan.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        frmMasterSupplier.ShowDialog()
    End Sub

    Private Sub JenisKendaraanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JenisKendaraanToolStripMenuItem.Click
        frmMasterJenisKendaraan.ShowDialog()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogToolStripMenuItem.Click
        frmLog.ShowDialog()
    End Sub


    Private Sub LogAdminToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogAdminToolStripMenuItem.Click
        frmLogAdmin.ShowDialog()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        frmHistory.ShowDialog()
    End Sub

    Private Sub PerusahaanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmMasterPerusahaan.ShowDialog()
    End Sub

    Private Sub MaintanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaintanceToolStripMenuItem.Click
        frmMasterJenisMaintance.ShowDialog()
    End Sub

    Private Sub SopirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SopirToolStripMenuItem.Click
        frmMastersopir.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        frmMasterBarang.ShowDialog()
    End Sub

    Private Sub OperasionalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperasionalToolStripMenuItem.Click
        frmMasterOperational.ShowDialog()
    End Sub

    Private Sub BiayaLainToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BiayaLainToolStripMenuItem.Click
        FrmMasterBiayaLain.ShowDialog()
    End Sub

    Private Sub PengeluaranToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PengeluaranToolStripMenuItem.Click
        frmMasterLaporanPengeluaran.ShowDialog()
    End Sub

    Private Sub BonMuatToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BonMuatToolStripMenuItem1.Click
        frmBonMuat.ShowDialog()
    End Sub

    Private Sub MaintanceToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        frmLaporanMaintance.ShowDialog()
    End Sub

    Private Sub KasBonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KasBonToolStripMenuItem.Click
        frmMasterKasBon.ShowDialog()
    End Sub

    Private Sub SuratJalanToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SuratJalanToolStripMenuItem1.Click
        frmInputBM.ShowDialog()
    End Sub

    Private Sub KasBonToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles KasBonToolStripMenuItem1.Click
        frmMasterLaporanKasBon.ShowDialog()
    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TarifToolStripMenuItem.Click
        FrmTarif.ShowDialog()
    End Sub

    Private Sub UjiKirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UjiKirToolStripMenuItem.Click
        frmDetailUjiKir.ShowDialog()
    End Sub

    Private Sub MaintanceToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles MaintanceToolStripMenuItem2.Click
        Dim a As New frmDetailMaintance
        a.cbktidakrutin.Checked = True
        a.ShowDialog()
        'frmDetailMaintance.cbktidakrutin.Checked = True
        'frmDetailMaintance.ShowDialog()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        frmBackup.ShowDialog()
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
        frmCreateUser.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles changepasswordMenuItem6.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub SparePartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SparePartToolStripMenuItem.Click
        frmPembelianSparepart.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmLaporanMaintanceKendaraan.ShowDialog()
    End Sub

    Private Sub frmUtama_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        notifikasi()
    End Sub

    Private Sub toolbutton_ButtonClick(sender As System.Object, e As System.EventArgs) Handles toolbutton.ButtonClick
        If toolbutton.Text = "Hide" Then
            GroupBox1.Visible = False
            toolbutton.Text = "Visible"
        Else
            GroupBox1.Visible = True
            toolbutton.Text = "Hide"
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CatatKilometerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatatKilometerToolStripMenuItem.Click
        frmCatatKilometer.ShowDialog()
    End Sub


    Private Sub TotalanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalanToolStripMenuItem.Click
        ' frmTotalSopir.ShowDialog()
    End Sub

    Private Sub SetOngkosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetOngkosToolStripMenuItem.Click
        frmTransaksiSetOngkos.ShowDialog()
    End Sub

    Private Sub SetorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetorToolStripMenuItem.Click
        frmSetorSuratJalan.ShowDialog()
    End Sub

    Private Sub LKuatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LKuatToolStripMenuItem.Click
        frmLKuat.ShowDialog()
    End Sub

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        frmLaporanPembelian.ShowDialog()
    End Sub

    Private Sub ParameterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParameterToolStripMenuItem.Click
        frmParameter.ShowDialog()
    End Sub

    Private Sub SparePartToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SparePartToolStripMenuItem1.Click
        frmSearchSparePart.ShowDialog()
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuratJalanToolStripMenuItem.Click
        frmSuratJalan.ShowDialog()
    End Sub

    Private Sub VoucherSPBUToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoucherSPBUToolStripMenuItem.Click
        frmVoucher.ShowDialog()
    End Sub

    Private Sub BonMuatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BonMuatToolStripMenuItem.Click
        frmSearchBonMuat.ShowDialog()
    End Sub

    Private Sub TagihanToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TagihanToolStripMenuItem1.Click
        frmtagihanspbu.ShowDialog()
    End Sub

    Private Sub BayarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BayarToolStripMenuItem.Click
        frmbayartagihanspbu.ShowDialog()
    End Sub

    Private Sub VoucherBBMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoucherBBMToolStripMenuItem.Click
        'frmprintbonvoucher.ShowDialog()
        frmCetakVoucher.ShowDialog()
    End Sub

    Private Sub SetorSuratJalanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetorSuratJalanToolStripMenuItem.Click
        frmLaporanSuratJalan.ShowDialog()
    End Sub

    Private Sub SuratJalanToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SuratJalanToolStripMenuItem2.Click
        FrmMasterLaporanSJ.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        frmCetakBonMuat.ShowDialog()
    End Sub

    Private Sub UjiKirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles UjiKirToolStripMenuItem1.Click
        frmLaporanUjiKir.ShowDialog()
    End Sub

    Private Sub TotalanSopirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalanSopirToolStripMenuItem.Click
        frmLaptotalan.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As System.Object, e As System.EventArgs) Handles SetAksesToolStripMenuItem11.Click
        ' frmSetAkses.ShowDialog()
        frmAkses.ShowDialog()
    End Sub

    Private Sub StockBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockBarangToolStripMenuItem.Click
        frmStokBarang.ShowDialog()
    End Sub

    Private Sub TagihanSPBUToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TagihanSPBUToolStripMenuItem.Click
        frmCetaktagihanspbu.ShowDialog()
    End Sub

    Private Sub MasterKendaraanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterKendaraanToolStripMenuItem.Click
        frmMasterLaporanKendaraan.ShowDialog()
    End Sub

    Private Sub SetOngkosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SetOngkosToolStripMenuItem1.Click
        frmTransaksiSetOngkosSupplier.ShowDialog()
    End Sub

    Private Sub RugiLabaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RugiLabaToolStripMenuItem.Click
        frmPemasukan.ShowDialog()
    End Sub

    Private Sub PengeluaranToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PengeluaranToolStripMenuItem1.Click
        frmPengeluaran.ShowDialog()
    End Sub

    Private Sub RugiLabaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RugiLabaToolStripMenuItem1.Click
        frmRugiLaba.ShowDialog()
    End Sub

    Private Sub KwitansiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KwitansiToolStripMenuItem.Click
        FormBuatKwitansi.ShowDialog()
    End Sub

    Private Sub BuatTagihanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuatTagihanToolStripMenuItem.Click
        frmBuatPenagihan.ShowDialog()
    End Sub

    Private Sub BayarTagihanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BayarTagihanToolStripMenuItem.Click
        frmBayarTagihan.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem12.Click
        frmLaporanHistoryHarga.ShowDialog()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BukuToolStripMenuItem.Click
        frmLaporanBukuMuatan.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmLaporanPengeluaranBarang.ShowDialog()
    End Sub

    Private Sub OperationalKendaraanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperationalKendaraanToolStripMenuItem.Click
        frmOperationalKendaraan.ShowDialog()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        frmExportExcel.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem14.Click
        frmLaporanOperationalKendaraan.ShowDialog()

    End Sub

    Private Sub KasHarianToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KasHarianToolStripMenuItem.Click
        frmKas.ShowDialog()

    End Sub

    Private Sub KasHarianToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles KasHarianToolStripMenuItem1.Click
        frmKasHarian.ShowDialog()

    End Sub

    Private Sub MutasiMasukToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MutasiMasukToolStripMenuItem.Click
        frmMutasiMasuk.showdialog()
    End Sub

    Private Sub PeralatanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PeralatanToolStripMenuItem.Click
        frmMasterPeralatan.ShowDialog()
    End Sub

    Private Sub PinjamAlatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PinjamAlatToolStripMenuItem.Click
        frmPeminjamanALat.ShowDialog()
    End Sub

    Private Sub KembaliAlatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KembaliAlatToolStripMenuItem.Click
        frmPengembalianAlat.ShowDialog()
    End Sub

    Private Sub MutasiKeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MutasiKeluarToolStripMenuItem.Click
        frmMutasiKeluar.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As System.Object, e As System.EventArgs) Handles AdjustmentToolStripMenuItem16.Click
        frmMutasi.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        frmSearchPembelian.ShowDialog()
    End Sub

    Private Sub AssetBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssetBarangToolStripMenuItem.Click
        frmLapStokOpname.ShowDialog()
    End Sub

    Private Sub UpdaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

   

    Private Sub UpdateHargaToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles UpdateHargaToolStripMenuItem.Click
        Dim a As New frmUbahHarga
        a.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MutasiMasukToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MutasiMasukToolStripMenuItem1.Click
        frmLaporanMutasiMasuk.ShowDialog()

    End Sub

    Private Sub MutasiKeluarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MutasiKeluarToolStripMenuItem1.Click
        frmLaporanMutasiKeluar.ShowDialog()
    End Sub

    Private Sub MutasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MutasiToolStripMenuItem.Click
        frmLaporanMutasi.ShowDialog()
    End Sub

    Private Sub SameDayMutasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SameDayMutasiToolStripMenuItem.Click
        frmLaporanPengeluaranSparePart.ShowDialog()
    End Sub

    Private Sub TotalanAwalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalanAwalToolStripMenuItem.Click
        ' frmTotalSopir.ShowDialog()
        frmTotalSopirBaru.ShowDialog()
    End Sub

    Private Sub TotalanAkhirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalanAkhirToolStripMenuItem.Click
        frmTotalanAkhirNew.ShowDialog()
        'frmTotalanAkhirBaru.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem16_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem16.Click
        frmLapGTotalan.ShowDialog()
    End Sub

    Private Sub KartuKendaraanXlsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KartuKendaraanXlsToolStripMenuItem.Click
        frmLaporanMaintenanceKendaraan.ShowDialog()
    End Sub

    Private Sub BiayaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BiayaToolStripMenuItem.Click
        frmMasterBiaya.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As System.Object, e As System.EventArgs) Handles PerusahaanToolStripMenuItem.Click
        frmMasterPerusahaan.ShowDialog()

    End Sub

    Private Sub OperasionalKendaraanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperasionalKendaraanToolStripMenuItem.Click
        frmPrintOperasionalKendaraan.ShowDialog()
    End Sub

    Private Sub GrandBiayaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GrandBiayaToolStripMenuItem.Click
        frmMasterGrandBiaya.ShowDialog()

    End Sub

    Private Sub RealisasiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RealisasiToolStripMenuItem.Click
        frmRealisasi.ShowDialog()
    End Sub

    Private Sub RealisasiToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RealisasiToolStripMenuItem1.Click
        frmLaporanRealisasi.ShowDialog()
    End Sub
End Class