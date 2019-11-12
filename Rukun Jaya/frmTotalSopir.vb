Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmTotalSopir
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New rjLib
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim ds As New DataSet
    Dim init As Boolean = True

    Private Sub hitungditerima()
        Dim plus, minus As Double
        plus = _rjlib.RemoveNonNumeric(lblborongan.Text)
        plus += _rjlib.RemoveNonNumeric(lbltambahan.Text)

        minus = _rjlib.RemoveNonNumeric(lbltotalbayarkasbon.Text)
        minus += _rjlib.RemoveNonNumeric(lblsangu.Text)
        minus += _rjlib.RemoveNonNumeric(lblklaim.Text)
        minus += _rjlib.RemoveNonNumeric(lblsolar.Text)
        minus += _rjlib.RemoveNonNumeric(lblkuli.Text)
        minus += _rjlib.RemoveNonNumeric(lblpotongan.Text)

        Try
            plus += CDbl(txttambahan.Text)
            plus += CDbl(txtTambahan1.Text)
            plus += CDbl(txtTambahan2.Text)
        Catch ex As Exception
            MsgBox("Tambahan Harus Berupa Angka !")
        End Try
        Try
            minus += CDbl(txtpotongan.Text)
        Catch ex As Exception
            MsgBox("Potongan Harus Berupa Angka !")
        End Try
        lblditerima.Text = Format(plus - minus, "n0")
    End Sub
    Private Sub clearsuratjalan()
        ds.Tables("suratjalan").Clear()
        dgvSuratJalan.DataSource = ds
        dgvSuratJalan.DataMember = "suratjalan"
        dgvSuratJalan.Refresh()
        hitungtotal()
    End Sub
    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click
        frmBrowsesopir.asal = 1
        frmBrowsesopir.ShowDialog()
        ambilsopir()
        ambilbm()
        ambilkasbon()

        clearsuratjalan()
    End Sub
    Private Sub hitungsemua()
        If init = False Then
            hitungtotal()
            hitungbayarkasbon()
            hitungditerima()
        End If
    End Sub
    Public Sub awal()
        init = True
        lblborongan.Text = "0"
        lblkuli.Text = "0"
        lblsolar.Text = "0"
        lblpotongan.Text = "0"
        lbltambahan.Text = "0"
        lblditerima.Text = "0"
        lblklaim.Text = "0"
        lbltotalbayarkasbon.Text = "0"
        txttambahan.Text = "0"
        txtpotongan.Text = "0"
        txtkodesopir.Text = ""
        lblnamasopir.Text = ""
        ds.Clear()
        dgvBiayaLain.Refresh()
        dgvBM.Refresh()
        dgvSuratJalan.Refresh()
        dtpTanggal.Value = Now
        init = False
    End Sub
    Private Sub frmTotalSopir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub frmTotalSopir_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Private Sub ambilsopir()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim cmd As New SqlCommand("", conn)
        cmd.Parameters.Clear()
        cmd.CommandText = "Select namasopir from tsopir where kodesopir='" & txtkodesopir.Text & "'"

        Try
            Dim namasopir As String = cmd.ExecuteScalar
            If namasopir = "" Then
                _rjcommon.shownotifyerror("Sopir Tidak Ditemukan")
            Else
                lblnamasopir.Text = namasopir
            End If
        Catch ex As Exception

        End Try
        conn.Close()
    End Sub
    Private Sub ambilkasbon()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim query As String = ""
        Dim ds As New DataSet
        query = " Select j.namajenis,o.kodetransaksi,tgltransaksi,harga,harga-bayar as bayarkasbon,kode,harga-bayar as sisa "
        query &= " from toperational o,tsopir s,tjenisoperational j"
        query &= " where o.kode=s.kodesopir and s.status=0 and o.jenis=j.kodejenis and j.jenis=1"
        query &= " and o.kode=@kodesopir"

        cmd.Connection = conn
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@kodesopir", txtkodesopir.Text)
        da.SelectCommand = cmd
        da.Fill(ds, "kasbon")
        dgvBiayaLain.AutoGenerateColumns = False
        dgvBiayaLain.DataSource = ds
        dgvBiayaLain.DataMember = "kasbon"
        dgvBiayaLain.Refresh()
        dgvBiayaLain.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        dgvBiayaLain.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        dgvBiayaLain.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        dgvBiayaLain.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        dgvBiayaLain.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        hitungbayarkasbon()
    End Sub

    Private Sub ambilbm()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        cmd.CommandText = " Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total"
        cmd.CommandText &= " from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j "
        cmd.CommandText &= " where k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and sj.nobm=b.nobm "
        cmd.CommandText &= " and b.status=0 and s.kodesopir='" & txtkodesopir.Text & "'"
        cmd.CommandText &= " group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"
        'status=0 artinya belum diproses totalan
        cmd.Connection = conn
        da.SelectCommand = cmd
        da.Fill(ds, "totalan")
        dgvBM.AutoGenerateColumns = False
        dgvBM.DataSource = ds
        dgvBM.DataMember = "totalan"
        dgvBM.Refresh()
        refreshsuratjalan()
        hitungsemua()
    End Sub
    Private Sub refreshsuratjalan()
        Dim query As String = "Select s.status,(s.sangu+s.bon+s.bonlain) as sangu,s.uangmakan as uangmakan,s.nobm,s.noSuratJalan,sp.namasupplier,s.solar,s.tgl, g1.namagudang as asal,g2.namagudang as tujuan,p.namaperwakilan,s.borongansopir as ongkos,s.kuli,s.klaim,s.tambahan,s.potongan "
        query &= " from tSuratJalan s,tgudang g1, tgudang g2,tperwakilan p,tsupplier sp "
        ' query &= " where s.noBM='" & dgvBM.Rows(e.RowIndex).Cells("nobm").Value & "' "
        query &= " where s.noBM='valent' "
        query &= " and p.kodeperwakilan=s.kodeperwakilan and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang and s.kodesupplier=sp.kodesupplier "
        query &= " order by s.tgl asc "
        Dim da As New SqlDataAdapter(query, conn)
        da.Fill(ds, "suratjalan")
        dgvSuratJalan.AutoGenerateColumns = False
        dgvSuratJalan.DataSource = ds
        dgvSuratJalan.DataMember = "suratjalan"
        dgvSuratJalan.Refresh()
        dgvSuratJalan.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(5).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(6).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(7).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(8).DefaultCellStyle.BackColor = Color.Silver
        dgvSuratJalan.Columns(9).DefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub txtkodesopir_Leave(sender As System.Object, e As System.EventArgs) Handles txtkodesopir.Leave
        ' ambilsopir()
        ' ambilbm()
    End Sub
    Private Sub tambahsuratjalan(nobm As String)
        Dim query As String = "Select s.status,(s.sangu+s.bon+s.bonlain) as sangu,s.uangmakan as uangmakan,(select ISNULL(sum(rupiah),0)  from tvoucherspbu spbu where spbu.nobm=s.nobm and spbu.noSuratJalan=s.nosuratjalan) as solar ,s.nobm,s.noSuratJalan,sp.namasupplier,s.tgl, g1.namagudang as asal,g2.namagudang as tujuan,p.namaperwakilan,s.borongansopir as ongkos,s.kuli,s.klaim,s.tambahan,s.potongan "
        query &= " from tSuratJalan s,tgudang g1, tgudang g2,tperwakilan p,tsupplier sp "
        query &= " where s.noBM='" & nobm & "' "
        query &= " and p.kodeperwakilan=s.kodeperwakilan and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang and s.kodesupplier=sp.kodesupplier "
        query &= " order by s.tgl asc "
        Dim cmd As New SqlCommand(query, conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim tr As DataRow = ds.Tables("suratjalan").NewRow
                tr("nobm") = nobm
                tr("sangu") = dr.Item("sangu")
                tr("status") = dr.Item("status")
                tr("tgl") = dr.Item("tgl")
                tr("NoSuratJalan") = dr.Item("NoSuratJalan")
                tr("NamaSupplier") = dr.Item("NamaSupplier")
                tr("asal") = dr.Item("asal")
                tr("uangmakan") = dr.Item("uangmakan")
                tr("tujuan") = dr.Item("tujuan")
                tr("namaperwakilan") = dr.Item("namaperwakilan")
                tr("ongkos") = dr.Item("ongkos")
                tr("kuli") = dr.Item("kuli")
                tr("klaim") = dr.Item("klaim")
                tr("solar") = dr.Item("solar")
                tr("tambahan") = dr.Item("tambahan")
                tr("potongan") = dr.Item("potongan")
                ds.Tables("suratjalan").Rows.Add(tr)
            End While
        End If
        conn.Close()
    End Sub
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        Dim a As Double
        Try
            a = CDbl(txttambahan.Text)
        Catch ex As Exception
            _rjcommon.shownotifyerror("Tambahan Harus Berupa Angka ")
            flag = False
        End Try
        Try
            a = CDbl(txtpotongan.Text)
        Catch ex As Exception
            _rjcommon.shownotifyerror("Potongan Harus Berupa Angka ")
            flag = False
        End Try
        If Trim(txtkodesopir.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Sopir Tidak Boleh Kosong")
        End If
        If Trim(txtnototalan.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nota Totalan Tidak Boleh Kosong !")
        End If
        Return flag
    End Function
    Private Sub hitungbayarkasbon()
        Dim totalbayar As Double = 0
       
        For i As Integer = 0 To dgvBiayaLain.Rows.Count - 1
            totalbayar += dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value
        Next
        lbltotalbayarkasbon.Text = Format(totalbayar, "n0")
        'hitungditerima()
    End Sub
    Private Sub hitungtotal()
        Dim totalborongan, kasbon, kuli, klaim, potongan, tambahan, solar As Double
        totalborongan = 0
        kasbon = 0
        kuli = 0
        klaim = 0
        potongan = 0
        tambahan = 0
        solar = 0
        For i As Integer = 0 To dgvSuratJalan.Rows.Count - 1
            totalborongan += dgvSuratJalan.Rows(i).Cells("ongkos").Value
            kasbon += dgvSuratJalan.Rows(i).Cells("sangu").Value
            kuli += dgvSuratJalan.Rows(i).Cells("kuli").Value
            klaim += dgvSuratJalan.Rows(i).Cells("klaim").Value
            potongan += dgvSuratJalan.Rows(i).Cells("potongan").Value
            tambahan += dgvSuratJalan.Rows(i).Cells("tambahan").Value
            solar += dgvSuratJalan.Rows(i).Cells("solar").Value
        Next
        lblborongan.Text = Format(totalborongan, "n0")
        lblsolar.Text = Format(solar, "n0")
        lblsangu.Text = Format(kasbon, "n0")
        lblkuli.Text = Format(kuli, "n0")
        lblpotongan.Text = Format(potongan, "n0")
        lbltambahan.Text = Format(tambahan, "n0")
        lblklaim.Text = Format(klaim, "n0")
    End Sub
    Private Function ceksuratjalan(nobm) As Boolean
        Dim flag As Boolean = True
        For i As Integer = 0 To ds.Tables("suratjalan").Rows.Count - 1
            If ds.Tables("suratjalan").Rows(i).Item("nobm") = nobm Then
                flag = False
            End If
        Next
        Return flag
    End Function
    Private Sub dgvBM_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentClick
        If e.ColumnIndex = 6 Then
            'button ditekan
            Dim nobm As String = dgvBM.Rows(e.RowIndex).Cells("nobm").Value
            If ceksuratjalan(nobm) Then
                tambahsuratjalan(nobm)
                hitungsemua()
            Else
                MsgBox("Surat Jalan Sudah Ditambahkan ")
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If ceksimpan() Then
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim trans As SqlTransaction = conn.BeginTransaction("totalan")
            Try
                'isi header
              
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                cmd.Connection = conn
                cmd.Transaction = trans
                cmd1.Connection = conn
                cmd1.Transaction = trans
                cmd2.Connection = conn
                cmd2.Transaction = trans
                Dim query As String = ""

                query = "insert into tHTotalan(nototalan,solar,kodesopir,totalborongan,sangu,kuli,klaim,potongan,tambahan,totalkasbon,tambahantotalan,potongantotalan,diterima,keterangan,tanggal,tambahantotalan1,tambahantotalan2) values (@nototalan,@solar,@kodesopir,@totalborongan,@sangu,@kuli,@klaim,@potongan,@tambahan,@totalkasbon,@tambahantotalan,@potongantotalan,@diterima,@keterangan,@tanggal,@tambahantotalan1,@tambahantotalan2)"
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@nototalan", txtnototalan.Text)
                cmd.Parameters.AddWithValue("@kodesopir", txtkodesopir.Text)
                cmd.Parameters.AddWithValue("@totalborongan", _rjlib.RemoveNonNumeric(lblborongan.Text))
                cmd.Parameters.AddWithValue("@sangu", _rjlib.RemoveNonNumeric(lblsangu.Text))
                cmd.Parameters.AddWithValue("@solar", _rjlib.RemoveNonNumeric(lblsolar.Text))
                cmd.Parameters.AddWithValue("@kuli", _rjlib.RemoveNonNumeric(lblkuli.Text))
                cmd.Parameters.AddWithValue("@klaim", _rjlib.RemoveNonNumeric(lblklaim.Text))
                cmd.Parameters.AddWithValue("@potongan", _rjlib.RemoveNonNumeric(lblpotongan.Text))
                cmd.Parameters.AddWithValue("@tambahan", _rjlib.RemoveNonNumeric(lbltambahan.Text))
                cmd.Parameters.AddWithValue("@totalkasbon", _rjlib.RemoveNonNumeric(lbltotalbayarkasbon.Text))
                cmd.Parameters.AddWithValue("@tambahantotalan", txttambahan.Text)
                cmd.Parameters.AddWithValue("@tambahantotalan1", txtTambahan1.Text)
                cmd.Parameters.AddWithValue("@tambahantotalan2", txtTambahan2.Text)
                cmd.Parameters.AddWithValue("@potongantotalan", txtpotongan.Text)
                cmd.Parameters.AddWithValue("@diterima", _rjlib.RemoveNonNumeric(lblditerima.Text))
                cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date)
                cmd.ExecuteNonQuery()

                'update detail surat jalan
                query = "update tsuratjalan set kuli=@kuli,klaim=@klaim,tambahan=@tambahan,potongan=@potongan where nobm=@nobm and nosuratjalan=@nosuratjalan"
                cmd.CommandText = query
                query = "insert into tDTotalanJalan(nototalan,nobm,nosuratjalan) values (@nototalan,@nobm,@nosuratjalan)"
                cmd1.CommandText = query
                query = "update tbm set status=1 where nobm=@nobm"
                cmd2.CommandText = query
                Dim i As Integer
                For i = 0 To dgvSuratJalan.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@nobm", dgvSuratJalan.Rows(i).Cells("nomorbm").Value)
                    cmd.Parameters.AddWithValue("@nosuratjalan", dgvSuratJalan.Rows(i).Cells("nosuratjalan").Value)
                    cmd.Parameters.AddWithValue("@kuli", dgvSuratJalan.Rows(i).Cells("kuli").Value)
                    cmd.Parameters.AddWithValue("@klaim", dgvSuratJalan.Rows(i).Cells("klaim").Value)
                    cmd.Parameters.AddWithValue("@tambahan", dgvSuratJalan.Rows(i).Cells("tambahan").Value)
                    cmd.Parameters.AddWithValue("@potongan", dgvSuratJalan.Rows(i).Cells("potongan").Value)
                    cmd.ExecuteNonQuery()
                    _rjcommon.isilog(_rjcommon.getusername, dgvSuratJalan.Rows(i).Cells("nosuratjalan").Value, "Transaksi Surat Jalan", "Update Data", "Update Totalan")
                    cmd1.Parameters.Clear()
                    cmd1.Parameters.AddWithValue("@nototalan", txtnototalan.Text)
                    cmd1.Parameters.AddWithValue("@nobm", dgvSuratJalan.Rows(i).Cells("nomorbm").Value)
                    cmd1.Parameters.AddWithValue("@nosuratjalan", dgvSuratJalan.Rows(i).Cells("nosuratjalan").Value)
                    cmd1.ExecuteNonQuery()
                    'update status tbm
                    cmd2.Parameters.Clear()
                    cmd2.Parameters.AddWithValue("@nobm", dgvSuratJalan.Rows(i).Cells("nomorbm").Value)
                    cmd2.ExecuteNonQuery()
                Next
                'update detail kas bon

                query = "update tOperational set bayar=bayar+@bayar where kodetransaksi=@kodetransaksi"
                cmd.CommandText = query
                query = "insert into tDTotalanBon(nototalan,kodetransaksi,bon,bayar) values (@nototalan,@kodetransaksi,@bon,@bayar)"
                cmd1.CommandText = query

                For i = 0 To dgvBiayaLain.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@kodetransaksi", dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value)
                    cmd.Parameters.AddWithValue("@bayar", dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value)
                    cmd.ExecuteNonQuery()
                    _rjcommon.isilog(_rjcommon.getusername, dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value, "Transaksi Kas Bon", "Update Data", "")

                    cmd1.Parameters.Clear()
                    cmd1.Parameters.AddWithValue("@nototalan", txtnototalan.Text)
                    cmd1.Parameters.AddWithValue("@kodetransaksi", dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value)
                    cmd1.Parameters.AddWithValue("@bon", dgvBiayaLain.Rows(i).Cells("txtbiaya").Value)
                    cmd1.Parameters.AddWithValue("@bayar", dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value)
                    cmd1.ExecuteNonQuery()
                Next

                trans.Commit()
                _rjcommon.shownotify("Data Totalan Berhasil Ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, txtnototalan.Text, "Transaksi Totalan Sopir", "Tambah Data", "")
                conn.Close()
                If MsgBox("Cetak Bon Tototalan? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    'cetak voucher
                    frmLaptotalan.cetaklaporan(txtnototalan.Text)
                End If
                Close()
            Catch ex As Exception
                trans.Rollback()
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtnototalan.Text, "Transaksi Totalan Sopir", "Tambah Data", ex.Message)
                MsgBox("Totalan Tidak Dapat Diproses")
            End Try
        Else
            MsgBox("Transaksi Tidak Bisa Disimpan ")
        End If
    End Sub
    Private Sub dgvBiayaLain_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaLain.CellValueChanged
        hitungsemua()
    End Sub
    Private Sub dgvSuratJalan_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSuratJalan.CellValueChanged
        hitungsemua()
    End Sub
    Private Sub txttambahan_Leave(sender As System.Object, e As System.EventArgs) Handles txttambahan.Leave
        hitungsemua()
    End Sub

    Private Sub txtpotongan_Leave(sender As System.Object, e As System.EventArgs) Handles txtpotongan.Leave
        hitungsemua()
    End Sub

    Private Sub lblpotongan_Click(sender As System.Object, e As System.EventArgs) Handles lblpotongan.Click

    End Sub
    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub dgvSuratJalan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSuratJalan.CellContentClick

    End Sub

    Private Sub txtTambahan1_Leave(sender As System.Object, e As System.EventArgs) Handles txtTambahan1.Leave
        hitungsemua()
    End Sub

    Private Sub txtTambahan2_Leave(sender As System.Object, e As System.EventArgs) Handles txtTambahan2.Leave
        hitungsemua()
    End Sub

    Private Sub dgvBiayaLain_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaLain.CellContentClick

    End Sub
End Class