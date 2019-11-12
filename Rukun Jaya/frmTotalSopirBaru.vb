Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmTotalSopirBaru
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New rjLib
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim ds As New DataSet
    Dim init As Boolean = True
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
        txtdetailbiaya.Text = ""
        ds.Clear()
        'dgvBiayaLain.Refresh()
        dgvBM.Refresh()
        dgvSuratJalan.Refresh()
        dtpTanggal.Value = Now
        clearbm()
        init = False
    End Sub
    Private Sub frmTotalSopirBaru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        awal()
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
    Private Sub clearsuratjalan()
        ds.Tables("suratjalan").Clear()
        dgvSuratJalan.DataSource = ds
        dgvSuratJalan.DataMember = "suratjalan"
        dgvSuratJalan.Refresh()
        hitungtotal()
    End Sub
    Private Sub clearbm()
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        cmd.CommandText = " Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total"
        cmd.CommandText &= " from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j "
        cmd.CommandText &= " where k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and sj.nobm=b.nobm "
        cmd.CommandText &= " and b.status=0 and s.kodesopir='valen'"
        cmd.CommandText &= " group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"
        'status=0 artinya belum diproses totalan
        cmd.Connection = conn
        da.SelectCommand = cmd
        da.Fill(ds, "totalan")
        dgvBM.AutoGenerateColumns = False
        dgvBM.DataSource = ds
        dgvBM.DataMember = "totalan"
        dgvBM.Refresh()
        'refreshsuratjalan()
        'hitungsemua()
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
        'hitungsemua()
    End Sub
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
    Private Function ratakiri(st As String, no As Integer) As String
        Dim temp As String = ""
        For i As Integer = 1 To no - st.Length
            temp += temp + " "
        Next i
        temp = st + temp
        Return temp
    End Function
    Private Function ratakanan(st As String, no As Integer) As String
        Dim temp As String = ""
        For i = 1 To no - st.Length
            temp += " " + temp
        Next
        temp = temp + st
        Return st
    End Function
    Private Sub cetakbiaya()
        txtdetailbiaya.Text = ""
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim nobmlokal, nosuratjalanlokal As String
        Dim kreditl, debitl As Double
        kreditl = 0
        debitl = 0
        For i As Integer = 0 To dgvSuratJalan.Rows.Count - 1
            nobmlokal = dgvSuratJalan.Rows(i).Cells("nomorbm").Value
            nosuratjalanlokal = dgvSuratJalan.Rows(i).Cells("nosuratjalan").Value
            'sisi kredit sopir
            Dim cmd As New SqlCommand
            Dim query As String = "select * "
            Dim dr As SqlDataReader
            txtdetailbiaya.Text += vbCrLf
            txtdetailbiaya.Text += nosuratjalanlokal + "(" + dgvSuratJalan.Rows(i).Cells("asal").Value + " - " + dgvSuratJalan.Rows(i).Cells("tujuan").Value + ")" + vbCrLf
            query += " from tbiaya b,tdetailbiaya db"
            query += " where b.kodebiaya=db.kodebiaya and nobm=@nobm and nosuratjalan=@nosuratjalan and b.kurang=0"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nobm", nobmlokal)
            cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalanlokal)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    txtdetailbiaya.Text += "  " + ratakiri(dr.Item("namabiaya"), 15) + " " + (Format(dr.Item("biaya"), "n0")) + vbCrLf
                    kreditl = kreditl + dr.Item("biaya")
                End While
            End If
            dr.Close()
            'debit sopir
            query = "select * "
            query += " from tbiaya b,tdetailbiaya db"
            query += " where b.kodebiaya=db.kodebiaya and nobm=@nobm and nosuratjalan=@nosuratjalan and b.kurang=1"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nobm", nobmlokal)
            cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalanlokal)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    txtdetailbiaya.Text += "     " + ratakiri(dr.Item("namabiaya"), 15) + "     " + (Format(dr.Item("biaya"), "n0")) + vbCrLf
                    debitl = debitl + dr.Item("biaya")
                End While
            End If
            dr.Close()

        Next
        lblkredit.Text = Format(kreditl, "N0")
        lbldebit.Text = Format(debitl, "N0")
        lblterima.Text = Format(kreditl - debitl, "N0")
        conn.Close()
    End Sub
    Private Sub hitungsemua()
        If init = False Then
            hitungtotal()
            'hitungbayarkasbon()
            hitungditerima()
        End If
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
        'dgvSuratJalan.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(5).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(6).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(7).DefaultCellStyle.BackColor = Color.Silver
        'dgvSuratJalan.Columns(8).DefaultCellStyle.BackColor = Color.Silver
        ' dgvSuratJalan.Columns(9).DefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click
        frmBrowsesopir.asal = 3
        frmBrowsesopir.ShowDialog()
        ambilsopir()
        ambilbm()
        'ambilkasbon()
        clearsuratjalan()
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

    Private Sub dgvBM_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentClick
        If e.ColumnIndex = 6 Then
            'button ditekan
            Dim nobm As String = dgvBM.Rows(e.RowIndex).Cells("nobm").Value
            If ceksuratjalan(nobm) Then
                tambahsuratjalan(nobm)
                cetakbiaya()
                'hitungsemua()
            Else
                MsgBox("Surat Jalan Sudah Ditambahkan ")
            End If
        End If
    End Sub

    Private Sub dgvSuratJalan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSuratJalan.CellContentClick
        If e.ColumnIndex = 7 Then
            frmIsiDetailBiaya.lblnoBM.Text = dgvSuratJalan.Rows(e.RowIndex).Cells("nomorbm").Value
            frmIsiDetailBiaya.lblNoSuratJalan.Text = dgvSuratJalan.Rows(e.RowIndex).Cells("nosuratjalan").Value
            frmIsiDetailBiaya.ShowDialog()
            cetakbiaya()
        End If
    End Sub

    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        Dim a As Double
        
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
    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If ceksimpan() Then
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim trans As SqlTransaction = conn.BeginTransaction("totalan")
            Try
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
                cmd.Parameters.AddWithValue("@totalborongan", 0)
                cmd.Parameters.AddWithValue("@sangu", 0)
                cmd.Parameters.AddWithValue("@solar", 0)
                cmd.Parameters.AddWithValue("@kuli", 0)
                cmd.Parameters.AddWithValue("@klaim", 0)
                cmd.Parameters.AddWithValue("@potongan", 0)
                cmd.Parameters.AddWithValue("@tambahan", 0)
                cmd.Parameters.AddWithValue("@totalkasbon", 0)
                cmd.Parameters.AddWithValue("@tambahantotalan", 0)
                cmd.Parameters.AddWithValue("@tambahantotalan1", 0)
                cmd.Parameters.AddWithValue("@tambahantotalan2", 0)
                cmd.Parameters.AddWithValue("@potongantotalan", 0)
                cmd.Parameters.AddWithValue("@diterima", _rjlib.RemoveNonNumeric(lblterima.Text))
                cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date)
                cmd.ExecuteNonQuery()

                query = "insert into tDTotalanJalan(nototalan,nobm,nosuratjalan) values (@nototalan,@nobm,@nosuratjalan)"
                cmd1.CommandText = query
                query = "update tbm set status=1 where nobm=@nobm"
                cmd2.CommandText = query
                Dim i As Integer
                For i = 0 To dgvSuratJalan.Rows.Count - 1
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

                trans.Commit()
                _rjcommon.shownotify("Data Totalan Berhasil Ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, txtnototalan.Text, "Transaksi Totalan Sopir", "Tambah Data", "")
                conn.Close()
                If MsgBox("Cetak Bon Tototalan? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    'cetak voucher
                    frmLaptotalan.cetaklaporanbaru(txtnototalan.Text)
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
End Class