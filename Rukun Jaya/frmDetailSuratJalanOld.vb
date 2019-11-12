Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailSuratJalanOld
    Public nobm As String = ""
    Public nosuratjalan As String = ""
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    Dim ds As New DataSet
    Dim adapter As SqlDataAdapter = New SqlDataAdapter()
    Dim adapter1 As SqlDataAdapter = New SqlDataAdapter()
    Dim transaction As SqlTransaction
    Dim lkuat As Boolean = False
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If cbnamaperwakilan.SelectedIndex = -1 Then
            _rjcommon.shownotifyerror("Data Perwakilan harus diisi")
            flag = False
        End If
        If cbnamasupplier.SelectedIndex = -1 Then
            _rjcommon.shownotifyerror("Data Supplier harus diisi")
            flag = False
        End If
        If cbgudangasal.SelectedValue = cbgudangtujuan.SelectedValue Then
            _rjcommon.shownotifyerror("Asal Dan Tujuan Tidak Boleh Sama ")
            flag = False
        End If
        If dtptglmuat.Value.Date < dtpTglJadwal.Value.Date Then
            flag = False
            _rjcommon.shownotifyerror("Tanggal Muat < Tanggal Jadwal")
        End If
        If dtptglbongkar.Value.Date < dtptglmuat.Value.Date Then
            flag = False
            _rjcommon.shownotifyerror("Tanggal Bongkar < Tanggal Muat")
        End If
        Return flag
    End Function
    Sub panggildetail()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim cmd, cmdinsert, cmdupdate As New SqlCommand("", conn)
        If (nosuratjalan = "" And lblMode.Text.ToLower = "tambah") Then
            cmd.CommandText = "select nobm,nosuratjalan,tdetailsuratjalan.kodebarang as kodebarang,namabarang,jumlah,nodo,noshippinglist from tdetailsuratjalan,tbarang where tdetailsuratjalan.kodebarang = tbarang.kodebarang and 1=2"
        Else
            cmd.Parameters.Clear()
            cmd.CommandText = "select nobm,nosuratjalan,tdetailsuratjalan.kodebarang as kodebarang,namabarang,jumlah,nodo,noshippinglist from tdetailsuratjalan,tbarang where tdetailsuratjalan.kodebarang=tbarang.kodebarang and nosuratjalan='" & nosuratjalan & "'"
            cmd.Parameters.AddWithValue("@suratjalan", nosuratjalan)

        End If

        adapter.SelectCommand = cmd

        'Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        adapter.Fill(ds, "tdetailsuratjalan")
        dgvdetailsuratjalan.DataSource = ds.Tables("tdetailsuratjalan")
        dgvdetailsuratjalan.Refresh()
        conn.Close()
        hitungtotal()
    End Sub
    Sub clearvoucher()
        txtkodevoucher.Text = ""
        txtliter.Text = "0"
        txthrgsatuan.Text = "0"
        txtkasbon.Text = "0"
        lbltotal.Text = "0"

        isicbspbu()
    End Sub
    Sub tampilvoucher()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        If (txtnosuratjalan.Text = "" And lblMode.Text.ToLower = "tambah") Then
            cmd.CommandText = "select vs.kodevoucher,vs.nobm,vs.nosuratjalan,vs.kodespbu,namaspbu,vs.kodeperwakilan,vs.liter,vs.sisa,vs.rupiahsatuan,vs.rupiah,vs.tglvoucher,vs.kasbon,vs.status from tvoucherspbu vs,tSPBU where vs.kodespbu = tSPBU.kodespbu and 1=2"
        Else
            cmd.CommandText = "select vs.kodevoucher,vs.nobm,vs.nosuratjalan,vs.kodespbu,namaspbu,vs.kodeperwakilan,vs.liter,vs.sisa,vs.rupiahsatuan,vs.rupiah,vs.tglvoucher,vs.kasbon,vs.status from tvoucherspbu vs,tSPBU where vs.kodespbu = tSPBU.kodespbu and nobm=@nobm and nosuratjalan=@nosj"
            cmd.Parameters.AddWithValue("@nobm", nobm)
            cmd.Parameters.AddWithValue("@nosj", txtnosuratjalan.Text)
        End If
        adapter1.SelectCommand = cmd

        'Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        adapter1.Fill(ds, "tvoucherspbu")
        'jun 15 jan 2015
        dgvvoucher.AutoGenerateColumns = False
        dgvvoucher.DataSource = ds.Tables("tvoucherspbu")
        dgvvoucher.Refresh()
        conn.Close()
    End Sub
    Sub hitungtotalvoucher()
        Dim total, liter As Double
        total = 0
        liter = 0
        For i As Integer = 0 To dgvvoucher.Rows.Count - 1
            total += dgvvoucher.Rows(i).Cells("rupiahsatuan").Value * dgvvoucher.Rows(i).Cells("liter").Value
            liter += dgvvoucher.Rows(i).Cells("liter").Value
        Next
        lblliter.Text = Format(liter, "##,##")
        lbltotal.Text = Format(total, "##,##")
    End Sub
    Sub cek_sudah_ada_di_lkuat(nosj As String)
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "select count(*) from tlkuat where nosuratjalan=@nosj and nobm=@nobm"
        cmd.Parameters.AddWithValue("@nosj", nosj)
        cmd.Parameters.AddWithValue("@nobm", nobm)
        Dim temp As Integer = cmd.ExecuteScalar
        If temp > 0 Then
            lkuat = True
        End If
        conn.Close()
    End Sub
    Private Sub frmDetailSuratJalan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearvoucher()
        isicbnamaperwakilan()
        isicbsupplier()
        isicbgudang(cbgudangasal)
        isicbgudang(cbgudangtujuan)
        isicbjenispekerjaan()
        cek_sudah_ada_di_lkuat(nosuratjalan)
        If lkuat Then
            pbsent.Visible = True
        Else
            pbsent.Visible = False

        End If
        If lblMode.Text.ToLower = "ubah" And nobm <> "" Then

            conn.Open()
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "select tsuratjalan.*,tperwakilan.namaperwakilan as namaperwakilan,tsupplier.namasupplier as namasupplier from tjenispekerjaan,tsuratjalan,tperwakilan,tsupplier where tsupplier.kodesupplier=tsuratjalan.kodesupplier and tsuratjalan.kodeperwakilan = tperwakilan.kodeperwakilan and nosuratjalan = @nosuratjalan and tjenispekerjaan.kodejenis=tsuratjalan.jenispekerjaan"
            cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                txtnosuratjalan.Text = nosuratjalan
                txtnosuratjalan.ReadOnly = True
                cbnamaperwakilan.Text = reader("namaperwakilan")
                cbnamasupplier.Text = reader("namasupplier")
                cbgudangasal.SelectedValue = reader("asal")
                cbgudangtujuan.SelectedValue = reader("tujuan")
                cbjenispekerjaan.SelectedValue = reader("jenispekerjaan")
                txtketerangan.Text = reader("keterangan")
                'jun 9 maret 2015
                dtptanggal.Text = reader("tgl")
                dtptglbongkar.Text = reader("tglbongkar")
                dtptgldatang.Text = reader("tgldatang")
                dtptglmuat.Text = reader("tglmuat")
                dtpTglJadwal.Text = reader("tgljadwal")
                txtsangu.Text = CInt(reader("sangu"))
                txtUM.Text = CInt(reader("uangmakan"))
                txtbon.Text = CInt(reader("bon"))
                txtbonlain.Text = CInt(reader("bonlain"))
                txtketeranganbon.Text = reader("ketbonlain")
                '13 april 2016
                txtbeban.Text = CInt(reader("beban"))
                txtketerangan.Text = reader("ketbeban")
            End While
            reader.Close()
            conn.Close()
            '  tampilvoucher()
            conn.Close()
        ElseIf lblMode.Text.ToLower = "tambah" Then
            clearisi()
        End If

        panggildetail()
        tampilvoucher()
        hitungtotalvoucher()
        If lkuat Then
            'jika sudah ada dilkuat maka dienable
            gbvoucher.Enabled = False
            gbdetail.Enabled = False
            dgvdetailsuratjalan.ReadOnly = True
            dgvvoucher.ReadOnly = True
        Else
            gbvoucher.Enabled = True
            gbdetail.Enabled = True
            'jun 21 jan 2015
            'dgvvoucher.ReadOnly = False
            dgvvoucher.ReadOnly = True
            dgvdetailsuratjalan.ReadOnly = False
        End If
    End Sub
    Sub clearisi()
        cbnamaperwakilan.SelectedIndex = -1
        cbnamasupplier.SelectedIndex = -1
        cbgudangasal.SelectedIndex = -1
        cbgudangtujuan.SelectedIndex = -1
        txtnosuratjalan.Text = ""
        txtketerangan.Text = ""
        dtptanggal.Text = Date.Now
        dtptgldatang.Text = Date.Now
        dtptglmuat.Text = Date.Now
        dtptglbongkar.Text = Date.Now
        dtpTglJadwal.Text = Date.Now
        txtnodo.Text = ""
        txtnoshippinglist.Text = ""
        txtsangu.Text = ""
        txtUM.Text = ""
        txtbon.Text = ""
        txtbonlain.Text = ""
        txtketeranganbon.Text = ""
        txtbeban.Text = ""
        txtketbeban.Text = ""
        clearisidetailsuratjalan()
    End Sub
    Sub clearisidetailsuratjalan()
        txtkodebarang.Text = ""
        txtjumlah.Text = "0"
        lblnamabarang.Text = ""
    End Sub
    Sub isicbsupplier()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tsupplier"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        cbnamasupplier.DataSource = tb
        cbnamasupplier.DisplayMember = "namaSupplier"
        cbnamasupplier.ValueMember = "KodeSupplier"
        cbnamasupplier.Refresh()
        conn.Close()
    End Sub
    Sub isicbjenispekerjaan()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tjenispekerjaan order by kodejenis desc"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        cbjenispekerjaan.DataSource = tb
        cbjenispekerjaan.DisplayMember = "namaPekerjaan"
        cbjenispekerjaan.ValueMember = "Kodejenis"
        cbjenispekerjaan.Refresh()
        conn.Close()
    End Sub
    Sub isicbspbu()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tspbu"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        cbspbu.DataSource = tb
        cbspbu.DisplayMember = "namaspbu"
        cbspbu.ValueMember = "Kodespbu"
        cbspbu.Refresh()
        conn.Close()
    End Sub
    Sub isicbgudang(cb As ComboBox)
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tgudang"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        cb.DataSource = tb
        cb.DisplayMember = "namagudang"
        cb.ValueMember = "Kodegudang"
        cb.Refresh()
        conn.Close()
    End Sub
    Sub isicbnamaperwakilan()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tperwakilan"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        cbnamaperwakilan.DataSource = tb
        cbnamaperwakilan.DisplayMember = "namaperwakilan"
        cbnamaperwakilan.ValueMember = "Kodeperwakilan"
        cbnamaperwakilan.Refresh()
        conn.Close()
    End Sub

    Private Sub updatedata()
        'jun 22 jan 2015
        'TODO : cek status voucher
        If _rjcommon.cekstatussuratjalan(txtnosuratjalan.Text) = 0 Then
            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                Else
                    conn.Close()
                    conn.Open()
                End If
                Dim cmd As New SqlCommand("", conn)
                transaction = conn.BeginTransaction("Suratjalan")
                cmd.Transaction = transaction

                cmd.Parameters.Clear()
                cmd.CommandText = "update tsuratjalan set uangmakan=@uangmakan,beban=@beban,ketbeban=@ketbeban,kodesupplier = @kodesupplier, kodeperwakilan=@kodeperwakilan,asal = @asal, jenispekerjaan=@jenis,tujuan = @tujuan, tgl=@tgl, tgldatang=@tgldatang, tglmuat=@tglmuat, tglbongkar=@tglbongkar,keterangan=@keterangan, sangu=@sangu, bon=@bon, bonlain=@bonlain, ketbonlain=@ketbonlain where nosuratjalan = @nosuratjalan and nobm=@nobm"
                cmd.Parameters.AddWithValue("@kodesupplier", cbnamasupplier.SelectedValue)
                cmd.Parameters.AddWithValue("@kodeperwakilan", cbnamaperwakilan.SelectedValue)
                cmd.Parameters.AddWithValue("@asal", cbgudangasal.SelectedValue)
                cmd.Parameters.AddWithValue("@tujuan", cbgudangtujuan.SelectedValue)
                cmd.Parameters.AddWithValue("@tgl", dtptanggal.Value)
                cmd.Parameters.AddWithValue("@jenis", cbjenispekerjaan.SelectedValue)
                cmd.Parameters.AddWithValue("@tgldatang", dtptgldatang.Value)
                cmd.Parameters.AddWithValue("@tglmuat", dtptglmuat.Value)
                cmd.Parameters.AddWithValue("@tglbongkar", dtptglbongkar.Value)
                cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                cmd.Parameters.AddWithValue("@sangu", txtsangu.Text)
                cmd.Parameters.AddWithValue("@uangmakan", txtUM.Text)
                cmd.Parameters.AddWithValue("@bon", txtbon.Text)
                cmd.Parameters.AddWithValue("@bonlain", txtbonlain.Text)
                cmd.Parameters.AddWithValue("@ketbonlain", txtketeranganbon.Text)
                cmd.Parameters.AddWithValue("@updatedate", DateTime.Now)
                cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                cmd.Parameters.AddWithValue("@nobm", nobm)
                cmd.Parameters.AddWithValue("@beban", txtbeban.Text)
                cmd.Parameters.AddWithValue("@ketbeban", txtketbeban.Text)

                cmd.ExecuteNonQuery()

                '-----ini untuk ubah detailnya
                ' hapus semua detailsuratjalan yang nobm,nosuratjalan sesuai dan belum dipakai d lkuat, kemudian tambahkan yang ada di grid

                cmd.Parameters.Clear()
                cmd.CommandText = "delete from tdetailsuratjalan where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang not in(select kodebarang from tlkuat where nobm=@nobm and nosuratjalan=@nosuratjalan)"
                cmd.Parameters.AddWithValue("@nobm", nobm)
                cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()

                For j As Integer = 0 To dgvdetailsuratjalan.RowCount - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "select count(*) from tdetailsuratjalan where nodo=@nodo and noshippinglist=@noshippinglist and nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang=@kodebarang"
                    cmd.Parameters.AddWithValue("@nobm", nobm)
                    cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                    cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@noshippinglist", dgvdetailsuratjalan.Rows(j).Cells(7).Value)

                    Dim temp As Integer = cmd.ExecuteScalar
                    If temp = 0 Then
                        cmd.Parameters.Clear()
                        cmd.CommandText = "insert into tdetailsuratjalan(nobm,nosuratjalan,kodebarang,nodo,jumlah,noshippinglist) values(@nobm,@nosuratjalan,@kodebarang,@nodo,@jumlah,@noshippinglist)"
                        cmd.Parameters.AddWithValue("@nobm", nobm)
                        cmd.Parameters.AddWithValue("@nosuratjalan", dgvdetailsuratjalan.Rows(j).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(j).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@jumlah", dgvdetailsuratjalan.Rows(j).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@noshippinglist", dgvdetailsuratjalan.Rows(j).Cells(7).Value)
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.Parameters.Clear()
                        cmd.CommandText = "update tdetailsuratjalan set nodo=@nodo,jumlah=@jumlah,noshippinglist=@noshippinglist where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang=@kodebarang"
                        cmd.Parameters.AddWithValue("@nobm", nobm)
                        cmd.Parameters.AddWithValue("@nosuratjalan", dgvdetailsuratjalan.Rows(j).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(j).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@jumlah", dgvdetailsuratjalan.Rows(j).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@noshippinglist", dgvdetailsuratjalan.Rows(j).Cells(7).Value)
                        cmd.ExecuteNonQuery()
                    End If

                Next
                '----- end of masukkan detail

                '-----ini untuk ubah vouchernya
                ' hapus semua voucher yang nobm,nosuratjalan sesuai dan belum dipakai d lkuat, kemudian tambahkan yang ada di grid
                'jun 28 jan 2015
                'belum ditagih oleh spbu
                If _rjcommon.cekvoucherbbm(nobm, txtnosuratjalan.Text) = 0 Then
                    cmd.Parameters.Clear()
                    cmd.CommandText = "delete from tvoucherspbu where nobm=@nobm and nosuratjalan=@nosuratjalan"
                    cmd.Parameters.AddWithValue("@nobm", nobm)
                    cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    For j As Integer = 0 To dgvvoucher.RowCount - 1
                        'cmd.Parameters.Clear()
                        'cmd.CommandText = "select count(*) from tdetailsuratjalan where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang=@kodebarang"
                        'cmd.Parameters.AddWithValue("@nobm", nobm)
                        'cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                        'cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                        ' Dim temp As Integer = cmd.ExecuteScalar
                        ' If temp = 0 Then
                        cmd.Parameters.Clear()
                        cmd.CommandText = "insert into tvoucherspbu(kodevoucher,nobm,nosuratjalan,kodespbu,kodeperwakilan,liter,sisa,rupiahsatuan,rupiah,tglvoucher,kasbon,status) values(@kodevoucher,@nobm,@nosuratjalan,@kodespbu,@kodeperwakilan,@liter,@sisa,@rupiahsatuan,@rupiah,@tglvoucher,@kasbon,0)"
                        cmd.Parameters.AddWithValue("@kodevoucher", dgvvoucher.Rows(j).Cells("kodevoucher").Value)
                        cmd.Parameters.AddWithValue("@nobm", nobm)
                        cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                        cmd.Parameters.AddWithValue("@kodespbu", dgvvoucher.Rows(j).Cells("kodespbu").Value)
                        cmd.Parameters.AddWithValue("@kodeperwakilan", dgvvoucher.Rows(j).Cells("kodeperwakilan").Value)
                        cmd.Parameters.AddWithValue("@liter", dgvvoucher.Rows(j).Cells("liter").Value)
                        cmd.Parameters.AddWithValue("@sisa", dgvvoucher.Rows(j).Cells("sisa").Value)
                        cmd.Parameters.AddWithValue("@rupiahsatuan", dgvvoucher.Rows(j).Cells("rupiahsatuan").Value)
                        cmd.Parameters.AddWithValue("@rupiah", dgvvoucher.Rows(j).Cells("rupiah").Value)
                        cmd.Parameters.AddWithValue("@tglvoucher", dgvvoucher.Rows(j).Cells("tglvoucher").Value)
                        cmd.Parameters.AddWithValue("@kasbon", dgvvoucher.Rows(j).Cells("kasbon").Value)

                        cmd.ExecuteNonQuery()
                        'Else
                        'cmd.Parameters.Clear()
                        'cmd.CommandText = "update tdetailsuratjalan set nodo=@nodo,jumlah=@jumlah,noshippinglist=@noshippinglist where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebarang=@kodebarang"
                        'cmd.Parameters.AddWithValue("@nobm", nobm)
                        'cmd.Parameters.AddWithValue("@nosuratjalan", dgvdetailsuratjalan.Rows(j).Cells(2).Value)
                        'cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                        'cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(j).Cells(6).Value)
                        'cmd.Parameters.AddWithValue("@jumlah", dgvdetailsuratjalan.Rows(j).Cells(5).Value)
                        'cmd.Parameters.AddWithValue("@noshippinglist", dgvdetailsuratjalan.Rows(j).Cells(7).Value)
                        '   cmd.ExecuteNonQuery()
                        '  End If

                    Next
                Else
                    _rjcommon.shownotifyerror("Voucher Tidak Bisa DiUbah Karena Sudah Dipergunakan")
                End If

                '----- end of masukkan detail
                transaction.Commit()
                'jun 21 jan 2015
                _rjcommon.shownotify("Data Surat Jalan Telah Diubah")
                _rjcommon.isilog(_rjcommon.getusername, txtnosuratjalan.Text, "Transaksi Surat Jalan", "Update Data", "")
                conn.Close()
                frmInputBM.panggil()
                Me.Close()
            Catch ex As Exception
                If conn.State = ConnectionState.Closed Then conn.Open()
                MessageBox.Show("Data Surat Jalan Tidak Berhasil Diubah")
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtnosuratjalan.Text, "Transaksi Surat Jalan ", "Update Data", ex.Message)
                transaction.Rollback()
                conn.Close()
            End Try
        Else
            MsgBox("Surat Jalan Tidak Boleh Diubah !")
        End If
    End Sub
    Private Sub tambahdata()
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim cmd As New SqlCommand("", conn)
            transaction = conn.BeginTransaction("Suratjalan")
            cmd.Transaction = transaction

            cmd.Parameters.Clear()
            'cek dulu apakah sudah pernah ada nomor lambung tersebut
            'jun 19 april
            cmd.CommandText = "select count(*) from tsuratjalan where nosuratjalan=@nosuratjalan and nobm=@nobm"
            cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
            cmd.Parameters.AddWithValue("@nobm", nobm)
            Dim i As Integer = cmd.ExecuteScalar
            If i = 0 Then
                cmd.Parameters.Clear()
                cmd.CommandText = "insert into tsuratjalan(nobm,nosuratjalan,kodesupplier,kodeperwakilan,jenispekerjaan,asal,tujuan,tgl,tgldatang,tglmuat,tglbongkar,tgljadwal,keterangan,sangu,bon,bonlain,ketbonlain,status,beban,ketbeban,uangmakan) values (@nobm,@nosuratjalan,@kodesupplier,@kodeperwakilan,@jenis,@asal,@tujuan,@tgl,@tgldatang,@tglmuat,@tglbongkar,@tgljadwal,@keterangan,@sangu,@bon,@bonlain,@ketbonlain,0,@beban,@ketbeban,@uangmakan)"
                cmd.Parameters.AddWithValue("@kodesupplier", cbnamasupplier.SelectedValue)
                cmd.Parameters.AddWithValue("@kodeperwakilan", cbnamaperwakilan.SelectedValue)
                cmd.Parameters.AddWithValue("@jenis", cbjenispekerjaan.SelectedValue)
                cmd.Parameters.AddWithValue("@asal", cbgudangasal.SelectedValue)
                cmd.Parameters.AddWithValue("@tujuan", cbgudangtujuan.SelectedValue)
                cmd.Parameters.AddWithValue("@tgl", dtptanggal.Value)
                cmd.Parameters.AddWithValue("@tgldatang", dtptgldatang.Value)
                cmd.Parameters.AddWithValue("@tglmuat", dtptglmuat.Value)
                cmd.Parameters.AddWithValue("@tglbongkar", dtptglbongkar.Value)
                cmd.Parameters.AddWithValue("@tgljadwal", dtpTglJadwal.Value)
                cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                cmd.Parameters.AddWithValue("@sangu", txtsangu.Text)
                cmd.Parameters.AddWithValue("@uangmakan", txtUM.Text)
                cmd.Parameters.AddWithValue("@bon", txtbon.Text)
                cmd.Parameters.AddWithValue("@bonlain", txtbonlain.Text)
                cmd.Parameters.AddWithValue("@ketbonlain", txtketeranganbon.Text)
                cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                cmd.Parameters.AddWithValue("@nobm", nobm)
                '13 april 2016
                cmd.Parameters.AddWithValue("@beban", txtbeban.Text)
                cmd.Parameters.AddWithValue("@ketbeban", txtketbeban.Text)
                cmd.ExecuteNonQuery()
                'jun 19 jan 2015
                'set ritase
                _rjcommon.increaseritase(nobm)
                '-----ini untuk masukkan detail
                For j As Integer = 0 To dgvdetailsuratjalan.RowCount - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "insert into tdetailsuratjalan(nobm,nosuratjalan,kodebarang,nodo,jumlah,noshippinglist) values(@nobm,@nosuratjalan,@kodebarang,@nodo,@jumlah,@noshippinglist)"
                    cmd.Parameters.AddWithValue("@nobm", nobm)
                    cmd.Parameters.AddWithValue("@nosuratjalan", dgvdetailsuratjalan.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@jumlah", dgvdetailsuratjalan.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@noshippinglist", dgvdetailsuratjalan.Rows(j).Cells(7).Value)
                    cmd.ExecuteNonQuery()
                Next
                '----- end of masukkan detail

                '-----ini untuk masukkan voucher
                For j As Integer = 0 To dgvvoucher.RowCount - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "insert into tvoucherspbu(kodevoucher,nobm,nosuratjalan,kodespbu,kodeperwakilan,liter,sisa,rupiahsatuan,rupiah,tglvoucher,kasbon,status) values(@kodevoucher,@nobm,@nosuratjalan,@kodespbu,@kodeperwakilan,@liter,@sisa,@rupiahsatuan,@rupiah,@tglvoucher,@kasbon,0)"
                    cmd.Parameters.AddWithValue("@kodevoucher", dgvvoucher.Rows(j).Cells("kodevoucher").Value)
                    cmd.Parameters.AddWithValue("@nobm", nobm)
                    cmd.Parameters.AddWithValue("@nosuratjalan", txtnosuratjalan.Text)
                    cmd.Parameters.AddWithValue("@kodespbu", dgvvoucher.Rows(j).Cells("kodespbu").Value)
                    cmd.Parameters.AddWithValue("@kodeperwakilan", dgvvoucher.Rows(j).Cells("kodeperwakilan").Value)
                    cmd.Parameters.AddWithValue("@liter", dgvvoucher.Rows(j).Cells("liter").Value)
                    cmd.Parameters.AddWithValue("@sisa", dgvvoucher.Rows(j).Cells("sisa").Value)
                    cmd.Parameters.AddWithValue("@rupiahsatuan", dgvvoucher.Rows(j).Cells("rupiahsatuan").Value)
                    cmd.Parameters.AddWithValue("@rupiah", dgvvoucher.Rows(j).Cells("rupiah").Value)
                    cmd.Parameters.AddWithValue("@tglvoucher", dgvvoucher.Rows(j).Cells("tglvoucher").Value)
                    cmd.Parameters.AddWithValue("@kasbon", dgvvoucher.Rows(j).Cells("kasbon").Value)

                    cmd.ExecuteNonQuery()

                Next
                '----- end of masukkan voucher

                _rjcommon.shownotify("Data Surat Jalan Berhasil Ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, txtnosuratjalan.Text, "Transaksi Surat Jalan", "Tambah Data", "")
                transaction.Commit()
                If MsgBox("Cetak Bon Pemuatan ? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    'cetak voucher
                    frmCetakBonMuat.cetakBM(nobm, txtnosuratjalan.Text)

                End If
                'jun 09 maret 2015
                If dgvvoucher.RowCount > 0 Then
                    If MsgBox("Cetak Voucher SPBU ? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        'cetak voucher
                        frmCetakVoucher.cetakvoucher(txtnosuratjalan.Text)
                    End If
                End If
                conn.Close()

                Me.Close()

            Else
                MessageBox.Show("Data dengan no lambung tersebut sudah ada")
            End If

        Catch ex As Exception
            If conn.State = ConnectionState.Closed Then conn.Open()
            MessageBox.Show("Data Surat Jalan Tidak Berhasil Ditambahkan,Kode : 110")
            _rjcommon.isiErrorlog(_rjcommon.getusername, txtnosuratjalan.Text, "Surat Jalan ", "Insert data", ex.Message)
            transaction.Rollback()
            conn.Close()

        End Try
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then

            If cbnamaperwakilan.SelectedIndex = -1 Then
                MsgBox("Data Perwakilan harus diisi")
            ElseIf cbnamasupplier.SelectedIndex = -1 Then
                MsgBox("Data Supplier harus diisi")
            Else
                'jun 20 jan 2015
                If lblMode.Text.ToLower = "ubah" Then
                    'mode ubah data
                    updatedata()
                ElseIf lblMode.Text.ToLower = "tambah" Then
                    'mode tambah data
                    tambahdata()
                End If
            End If
        Else
            MsgBox("Ada Isian Yang Salah ")
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailSuratJalan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.Name = "txtkodebarang")) Then
            conn.Open()

            Dim cmd As New SqlCommand("select namabarang from tbarang where kodebarang=@kode", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode", txtkodebarang.Text)
            Try
                lblnamabarang.Text = cmd.ExecuteScalar
                If lblnamabarang.Text = "" Then
                    MsgBox("Kode Barang yang dimasukkan tidak terdaftar")
                End If
            Catch
                MsgBox("Kode Barang yang dimasukkan tidak terdaftar")
            End Try
            conn.Close()
        ElseIf (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox)) And (Me.ActiveControl.GetType() = GetType(ComboBox)) And (Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True

        End If
    End Sub



    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        frmBrowseBarang.jenis = cbjenispekerjaan.SelectedValue
        frmBrowseBarang.ShowDialog()
    End Sub
    Private Function caribarang(kodebarang As String) As Boolean
        Dim flag As Boolean = True
        Dim cmd As New SqlCommand("Select count(*) from tbarang where kodebarang='" + kodebarang + "'", conn)
        conn.Open()
        Dim i As Integer = cmd.ExecuteScalar
        If i <= 0 Then
            flag = False
        End If
        conn.Close()
        Return flag
    End Function
    Private Function cekbarang(kodebarang As String, nodo As String, noship As String) As Boolean
        Dim flag As Boolean = True
        For i As Integer = 0 To ds.Tables("tdetailsuratjalan").Rows.Count - 1
            '11 maret 2016
            If kodebarang = ds.Tables("tdetailsuratjalan").Rows(i).Item("kodebarang") And nodo = ds.Tables("tdetailsuratjalan").Rows(i).Item("noDO") And noship = ds.Tables("tdetailsuratjalan").Rows(i).Item("noShippingList") Then
                flag = False
            End If
        Next
        Return flag
    End Function
    Private Sub hitungtotal()
        Dim total As Double = 0
        Dim i As Integer
        For i = 0 To ds.Tables("tdetailsuratjalan").Rows.Count - 1
            total += ds.Tables("tdetailsuratjalan").Rows(i).Item("Jumlah").ToString
        Next

        lblJumlah.Text = total 'Format(total, "##,##")
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        'jun 27 jan 2015
        If CInt(txtjumlah.Text) <= 0 Then
            MsgBox("jumlah tidak boleh kurang dari nol")
        ElseIf txtnodo.Text = "" Then
            MsgBox("nomor DO tidak boleh kosong")
            'ElseIf txtnoshippinglist.Text = "" Then
            '   MsgBox("nomor shipping list tidak boleh kosong")
        ElseIf caribarang(txtkodebarang.Text) = False Then
            MsgBox("Barang Tidak Ada")
        ElseIf cekbarang(txtkodebarang.Text, txtnodo.Text, txtnoshippinglist.Text) = False Then
            MsgBox("Barang dan No DO Sudah Dimasukkan ")
        Else
            Dim tr As DataRow = ds.Tables("tdetailsuratjalan").NewRow
            tr("nobm") = nobm
            tr("nosuratjalan") = txtnosuratjalan.Text
            tr("kodebarang") = txtkodebarang.Text
            tr("nodo") = txtnodo.Text
            tr("jumlah") = txtjumlah.Text
            tr("namabarang") = lblnamabarang.Text
            tr("noshippinglist") = txtnoshippinglist.Text
            ds.Tables("tdetailsuratjalan").Rows.Add(tr)
            clearisidetailsuratjalan()
            hitungtotal()
        End If
    End Sub

    Private Function cekvoucher(kodevoucher As String)
        Dim flag As Boolean = True
        Dim cmd As New SqlCommand("Select count(*) from tvoucherspbu where kodevoucher='" + kodevoucher + "'", conn)
        conn.Open()
        Dim i As Integer = cmd.ExecuteScalar
        If i > 0 Then
            flag = False
        End If
        conn.Close()
        Return flag
    End Function
    Private Function cekvoucherlokal(kodevoucher As String)
        Dim flag As Boolean = True
        For i As Integer = 0 To ds.Tables("tvoucherspbu").Rows.Count - 1
            If kodevoucher = ds.Tables("tvoucherspbu").Rows(i).Item("kodevoucher") Then
                flag = False
            End If
        Next
        Return flag
    End Function
    Private Function cekjumlahvoucherlokal()
        Dim flag As Boolean = True
        If ds.Tables("tvoucherspbu").Rows.Count - 1 > 1 Then
            flag = False
        End If
        Return flag
    End Function
    Private Sub btntambahvoucher_Click(sender As Object, e As EventArgs) Handles btntambahvoucher.Click
        Dim err As String = 0
        'jun 24 mar 2015
        If Trim(txtkodevoucher.Text) = "" Then
            MsgBox("No Voucher SPBU  harus diisi !", MsgBoxStyle.OkOnly, "Information")
            err = 1
        End If
        If Not IsNumeric(txtliter.Text) Or Not IsNumeric(txthrgsatuan.Text) Or Not IsNumeric(txtkasbon.Text) Then
            MsgBox("Isian harus berupa angka", MsgBoxStyle.OkOnly, "Information")
            err = 1
        End If
        If txtliter.Text <= 0 Or txthrgsatuan.Text <= 0 Then
            MsgBox("Isian tidak boleh lebih kecil atau sama dengan 0", MsgBoxStyle.OkOnly, "Information")
            err = 1
        End If
        If cekvoucherlokal(txtkodevoucher.Text) = False Then
            MsgBox("Kode Voucher Sudah Dipergunakan ")
            err = 1
        End If
        If cekvoucher(txtkodevoucher.Text) = False Then
            MsgBox("Kode Voucher Sudah Dipakai")
            err = 1
        End If
        If cekjumlahvoucherlokal() = False Then
            MsgBox("Voucher SPBU maksimal 2")
            err = 1
        End If
        If err <> 1 Then
            Dim tr As DataRow = ds.Tables("tvoucherspbu").NewRow
            tr("nobm") = nobm
            tr("nosuratjalan") = txtnosuratjalan.Text
            tr("kodevoucher") = txtkodevoucher.Text
            'jun 20 jan 2015
            tr("namaspbu") = cbspbu.Text
            tr("kodespbu") = cbspbu.SelectedValue

            tr("kodeperwakilan") = cbnamaperwakilan.SelectedValue
            tr("liter") = txtliter.Text
            tr("sisa") = txtliter.Text
            tr("rupiahsatuan") = txthrgsatuan.Text
            tr("rupiah") = txthrgsatuan.Text * txtliter.Text
            tr("tglvoucher") = dtptanggal.Value
            tr("kasbon") = txtkasbon.Text
            tr("status") = 0
            ds.Tables("tvoucherspbu").Rows.Add(tr)
            clearvoucher()
            hitungtotalvoucher()
        End If
    End Sub

    Private Sub dgvvoucher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvvoucher.CellClick
        'jun 21 jan 2015
        If (e.ColumnIndex = 12) Then
            If (MsgBox("Apakah anda yakin menghapus data voucher?", MsgBoxStyle.YesNo, "Konfirmasi hapus") = MsgBoxResult.Yes) Then
                'cek apakah sudah dipakai di lkuat
                'jun 22 jan 2015
                If _rjcommon.cekstatussuratjalan(txtnosuratjalan.Text) = 0 Then
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim cmd As New SqlCommand("", conn)
                    cmd.Parameters.Clear()
                    'jun 21 jan 2015
                    'hub voucher spbu bukan dengan lkuat tetapi dengan dtagihanspbu

                    'cmd.CommandText = "select count(*) from tlkuat where nobm=@nobm and nosuratjalan=@nosj and kodebarang=@kodebarang and nodo=@nodo"
                    'cmd.Parameters.AddWithValue("@nobm", nobm)
                    'cmd.Parameters.AddWithValue("@nosj", txtnosuratjalan.Text)
                    'cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(e.RowIndex).Cells(3).Value)
                    'cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(e.RowIndex).Cells(6).Value)
                    cmd.CommandText = "select count(*) from tdtagihanSPBU where kodevoucher=@kodevoucher"
                    cmd.Parameters.AddWithValue("@kodevoucher", dgvvoucher.Rows(e.RowIndex).Cells("kodevoucher").Value)
                    Dim i As Integer = cmd.ExecuteScalar
                    If (i > 0) Then
                        MsgBox("Voucher Tidak Dapat Dihapus Karena Sudah Dipakai", MsgBoxStyle.OkOnly, "Konfirmasi")
                    Else
                        ds.Tables("tvoucherspbu").Rows(e.RowIndex).Delete()
                    End If
                    conn.Close()

                End If
            Else
                MsgBox("Voucher Tidak Dapat Dihapus Karena Sudah Transaksi Sudah Berjalan", MsgBoxStyle.OkOnly, "Konfirmasi")
            End If
        End If
    End Sub


    Private Sub frmDetailSuratJalan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmInputBM.panggil()
    End Sub

    Private Sub dgvdetailsuratjalan_CellClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetailsuratjalan.CellClick
        If (e.ColumnIndex = 0) Then
            If (MsgBox("Apakah anda yakin menghapus data?", MsgBoxStyle.YesNo, "Konfirmasi hapus") = MsgBoxResult.Yes) Then
                'cek apakah sudah dipakai di lkuat
                'jun 22 jan 2015
                If _rjcommon.cekstatussuratjalan(txtnosuratjalan.Text) = 0 Then
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim cmd As New SqlCommand("", conn)
                    cmd.Parameters.Clear()
                    cmd.CommandText = "select count(*) from tlkuat where nobm=@nobm and nosuratjalan=@nosj and kodebarang=@kodebarang and nodo=@nodo"
                    cmd.Parameters.AddWithValue("@nobm", nobm)
                    cmd.Parameters.AddWithValue("@nosj", txtnosuratjalan.Text)
                    cmd.Parameters.AddWithValue("@kodebarang", dgvdetailsuratjalan.Rows(e.RowIndex).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@nodo", dgvdetailsuratjalan.Rows(e.RowIndex).Cells(6).Value)
                    Dim i As Integer = cmd.ExecuteScalar
                    If (i > 0) Then
                        MsgBox("Detail tidak dapat dihapus karena sudah dipakai di LKuat", MsgBoxStyle.OkOnly, "Konfirmasi")
                    Else
                        ds.Tables("tdetailsuratjalan").Rows(e.RowIndex).Delete()
                        hitungtotal()
                    End If
                    conn.Close()
                Else
                    MsgBox("Detail Tidak Bisa Dihapus Karena Transaksi Sudah Berjalan ", MsgBoxStyle.OkOnly, "Konfirmasi")
                End If
            End If
        End If
    End Sub

    Private Sub txtkodebarang_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub dgvvoucher_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvvoucher.CellContentClick

    End Sub

    Private Sub cbjenispekerjaan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbjenispekerjaan.SelectedIndexChanged

    End Sub

    Private Sub dgvdetailsuratjalan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetailsuratjalan.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUM.TextChanged

    End Sub
End Class