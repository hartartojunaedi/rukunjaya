Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmTotalanAkhirNew
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New rjLib
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim ds As New DataSet
    Dim dsbiaya As New DataSet
    Dim init As Boolean = True
    Sub loaddata()
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand("", conn)
        Dim query As String = " select db.kodegrandbiaya,namagrandbiaya,keterangan,biaya as kredit,0 as debit from tdetailgrandbiaya db,tgrandbiaya b"
        query &= " where b.kodegrandbiaya = db.kodegrandbiaya And kurang = 0 and db.nogtotalan=@noGtotalan1 "
        query &= " union "
        query &= " select db.kodegrandbiaya,namagrandbiaya,keterangan,0 as kredit,biaya as debit from tdetailgrandbiaya db,tgrandbiaya b"
        query &= " where b.kodegrandbiaya = db.kodegrandbiaya And kurang = 1 and db.nogtotalan=@nogtotalan2 "
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nogtotalan1", "mecu01")
        cmd.Parameters.AddWithValue("@nogtotalan2", "mecu01")
        da.SelectCommand = cmd
        da.Fill(dsbiaya, "biaya")
        DataGridView1.DataSource = dsbiaya
        DataGridView1.DataMember = "biaya"
        DataGridView1.Refresh()
    End Sub
    Sub loadbiaya()
        Dim da As New SqlDataAdapter("Select * from tgrandbiaya order by namagrandbiaya", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tgrandbiaya")
        cmbgrandbiaya.DataSource = ds.Tables(0)
        cmbgrandbiaya.DisplayMember = "namagrandbiaya"
        cmbgrandbiaya.ValueMember = "kodegrandbiaya"
        cmbgrandbiaya.Refresh()
    End Sub
    Public Sub awal()
        init = True
        txtkodesopir.Text = ""
        init = False
    End Sub
    Private Sub ambilsopir()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        If txtkodesopir.Text <> "" Then
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
        End If

    End Sub
    Private Sub frmTotalanAkhir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        awal()
        loaddata()
        loadbiaya()

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

    Private Sub hitungbayarkasbon()
        Dim totalbayar As Double = 0

        For i As Integer = 0 To dgvBiayaLain.Rows.Count - 1
            totalbayar += dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value
        Next
        lbltotalbayarkasbon.Text = Format(totalbayar, "n0")
        hitungditerima()
    End Sub
    Private Sub cleartotalan()
        ds.Tables("totalan").Clear()
        dgtotalan.DataSource = ds
        dgtotalan.DataMember = "totalan"
        dgtotalan.Refresh()
        hitungtotal()
    End Sub
    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click
        frmBrowsesopir.asal = 2
        frmBrowsesopir.ShowDialog()
        ambilsopir()
        ambiltotalan()
        ambilkasbon()
        cleartotalan()

    End Sub

    Private Sub refreshtotalan()
        Dim query As String = "Select * "
        query &= " from tHGTotalan h,tDGTotalan d ,thtotalan ht   "
        query &= " where h.nogtotalan='valent' and h.nogtotalan=d.nogtotalan and ht.nototalan=d.nototalan "
        query &= " order by h.tanggal asc "
        Dim da As New SqlDataAdapter(query, conn)
        da.Fill(ds, "totalan")
        dgtotalan.AutoGenerateColumns = False
        dgtotalan.DataSource = ds
        dgtotalan.DataMember = "totalan"
        dgtotalan.Refresh()

    End Sub
    Public Sub ambiltotalan()
        If init = False Then
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            '          cmd.CommandText = " Select h.nototalan,h.totalborongan,(h.sangu+h.solar) as sangusolar,h.diterima,h.tanggal "
            cmd.CommandText = " Select h.nototalan,h.totalborongan,(h.sangu+h.solar) as sangusolar,h.diterima,h.tanggal "
            cmd.CommandText &= " from thtotalan h "
            cmd.CommandText &= " where h.status=0 and h.kodesopir='" & txtkodesopir.Text & "'"
            cmd.CommandText &= " order by h.tanggal"
            'status=0 artinya belum diproses totalan
            cmd.Connection = conn
            da.SelectCommand = cmd
            da.Fill(ds, "totalan")
            dgvTotalan.AutoGenerateColumns = False
            dgvTotalan.DataSource = ds
            dgvTotalan.DataMember = "totalan"
            dgvTotalan.Refresh()
            refreshtotalan()
            'hitungsemua()
        End If
    End Sub
    Private Sub txtkodesopir_Leave(sender As System.Object, e As System.EventArgs) Handles txtkodesopir.Leave
        ambilsopir()
        ambiltotalan()
        ambilkasbon()
    End Sub

    Public Function cektotalan(nototalan As String) As Boolean

        Dim flag As Boolean = True
        For i As Integer = 0 To ds.Tables("totalan").Rows.Count - 1
            If ds.Tables("totalan").Rows(i).Item("nototalan") = nototalan Then
                flag = False
            End If
        Next
        Return flag
    End Function
    Private Sub tambahtotalan(nototalan As String)
        Dim query As String = "Select h.nototalan,h.diterima "
        query &= " from thtotalan h "
        query &= " where h.nototalan='" & nototalan & "' "
        Dim cmd As New SqlCommand(query, conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim tr As DataRow = ds.Tables("totalan").NewRow
                tr("nototalan") = nototalan
                tr("diterima") = dr.Item("diterima")
                ds.Tables("totalan").Rows.Add(tr)
            End While
        End If
        conn.Close()
    End Sub
    Private Sub hitungsemua()
        If init = False Then
            hitungtotal()
            hitungbayarkasbon()
            hitungditerima()
        End If
    End Sub

    Private Sub hitungtotal()
        Dim totalditerima As Double
        totalditerima = 0
        For i As Integer = 0 To dgtotalan.Rows.Count - 1
            totalditerima += dgtotalan.Rows(i).Cells("terima").Value

        Next
        lbltotalterima.Text = Format(totalditerima, "n0")

    End Sub
    Private Sub hitungditerima()
        Dim totalditerima As Double = 0
        totalditerima = _rjlib.RemoveNonNumeric(lbltotalterima.Text)
        totalditerima -= _rjlib.RemoveNonNumeric(lbltotalbayarkasbon.Text)
        totalditerima += _rjlib.RemoveNonNumeric(txttambahan.Text)
        totalditerima -= _rjlib.RemoveNonNumeric(txtpotongan.Text)
        For i As Integer = 0 To dsbiaya.Tables("biaya").Rows.Count - 1
            totalditerima += dsbiaya.Tables("biaya").Rows(i).Item("kredit")
            totalditerima -= dsbiaya.Tables("biaya").Rows(i).Item("debit")
        Next

        lblGrandTotal.Text = Format(totalditerima, "n0")

    End Sub
    Private Sub dgvTotalan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTotalan.CellContentClick
        'MsgBox(e.ColumnIndex)
        If e.ColumnIndex = 5 Then
            'button ditekan
            Dim nototalan As String = dgvTotalan.Rows(e.RowIndex).Cells("nototalan").Value
            If cektotalan(nototalan) Then
                tambahtotalan(nototalan)
                'tambahsuratjalan(nobm)
                hitungsemua()
            Else
                MsgBox("Totalan Sudah Ditambahkan ")
            End If
        End If
    End Sub

    Private Sub txttambahan_Leave(sender As System.Object, e As System.EventArgs) Handles txttambahan.Leave
        hitungditerima()
    End Sub

    Private Sub txtpotongan_Leave(sender As System.Object, e As System.EventArgs) Handles txtpotongan.Leave
        hitungditerima()
    End Sub

    Private Sub dgvBiayaLain_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBiayaLain.CellValueChanged
        hitungsemua()
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

                query = "insert into tHGTotalan(nogtotalan,kodesopir,tanggal,status,total,tambahan,potongan,terima,bon,keterangan) values (@nogtotalan,@kodesopir,@tanggal,@status,@total,@tambahan,@potongan,@terima,@bon,@keterangan)"
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@nogtotalan", txtnototalan.Text)
                cmd.Parameters.AddWithValue("@kodesopir", txtkodesopir.Text)
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date)
                cmd.Parameters.AddWithValue("@status", 0)
                cmd.Parameters.AddWithValue("@total", _rjlib.RemoveNonNumeric(lbltotalterima.Text))
                cmd.Parameters.AddWithValue("@tambahan", _rjlib.RemoveNonNumeric(txttambahan.Text))
                cmd.Parameters.AddWithValue("@potongan", _rjlib.RemoveNonNumeric(txtpotongan.Text))
                cmd.Parameters.AddWithValue("@terima", _rjlib.RemoveNonNumeric(lblGrandTotal.Text))
                cmd.Parameters.AddWithValue("@bon", _rjlib.RemoveNonNumeric(lbltotalbayarkasbon.Text))
                cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                cmd.ExecuteNonQuery()


                'update detail surat jalan
                query = "update tHtotalan set status=1 where nototalan=@nototalan"
                cmd.CommandText = query
                query = "insert into tDGTotalan(nogtotalan,nototalan) values (@nogtotalan,@nototalan)"
                cmd1.CommandText = query

                Dim i As Integer
                For i = 0 To dgtotalan.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@nototalan", dgtotalan.Rows(i).Cells("ntotalan").Value)
                    cmd.ExecuteNonQuery()
                    _rjcommon.isilog(_rjcommon.getusername, dgtotalan.Rows(i).Cells("ntotalan").Value, "Transaksi Totalan Sopir", "Update Data", "Update Totalan")
                    cmd1.Parameters.Clear()
                    cmd1.Parameters.AddWithValue("@nogtotalan", txtnototalan.Text)
                    cmd1.Parameters.AddWithValue("@nototalan", dgtotalan.Rows(i).Cells("ntotalan").Value)
                    cmd1.ExecuteNonQuery()
                Next

                'update detail kas bon

                query = "update tOperational set bayar=bayar+@bayar where kodetransaksi=@kodetransaksi"
                cmd.CommandText = query
                query = "insert into tDTotalanBon(nogtotalan,kodetransaksi,bon,bayar) values (@nogtotalan,@kodetransaksi,@bon,@bayar)"
                cmd1.CommandText = query

                For i = 0 To dgvBiayaLain.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@kodetransaksi", dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value)
                    cmd.Parameters.AddWithValue("@bayar", dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value)
                    cmd.ExecuteNonQuery()
                    _rjcommon.isilog(_rjcommon.getusername, dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value, "Transaksi Kas Bon", "Update Data", "")

                    cmd1.Parameters.Clear()
                    cmd1.Parameters.AddWithValue("@nogtotalan", txtnototalan.Text)
                    cmd1.Parameters.AddWithValue("@kodetransaksi", dgvBiayaLain.Rows(i).Cells("kodetransaksi").Value)
                    cmd1.Parameters.AddWithValue("@bon", dgvBiayaLain.Rows(i).Cells("txtbiaya").Value)
                    cmd1.Parameters.AddWithValue("@bayar", dgvBiayaLain.Rows(i).Cells("bayarkasbon").Value)
                    cmd1.ExecuteNonQuery()
                Next

                'isi detailgrandbiaya
                Dim cmd3 As New SqlCommand
                Dim query3 As String = "insert into tdetailgrandbiaya(nogtotalan,kodegrandbiaya,biaya,keterangan) values tdetailgrandbiaya(@nogtotalan,@kodegrandbiaya,@biaya,@keterangan)"
                cmd3.Connection = conn
                cmd3.CommandText = query3

                For i = 0 To dsbiaya.Tables("biaya").Rows.Count - 1
                    cmd3.Parameters.Clear()
                    cmd3.Parameters.AddWithValue("@nogtotalan", txtnototalan.Text)
                    cmd.Parameters.AddWithValue("@kodegrandbiaya", dsbiaya.Tables("biaya").Rows(i).Item("kodegrandbiaya"))
                    cmd.Parameters.AddWithValue("@keterangan", dsbiaya.Tables("biaya").Rows(i).Item("keterangan"))
                    If dsbiaya.Tables("biaya").Rows(i).Item("kredit") = 0 Then
                        cmd.Parameters.AddWithValue("@biaya", dsbiaya.Tables("biaya").Rows(i).Item("debit"))
                    Else
                        cmd.Parameters.AddWithValue("@biaya", dsbiaya.Tables("biaya").Rows(i).Item("kredit"))
                    End If
                    cmd.ExecuteNonQuery()
                Next


                trans.Commit()
                _rjcommon.shownotify("Data Totalan Berhasil Ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, txtnototalan.Text, "Transaksi Grand Totalan Sopir", "Tambah Data", "")
                conn.Close()
                If MsgBox("Cetak Grand Tototalan? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    'cetak voucher
                    frmLapGTotalan.cetaklaporan(txtnototalan.Text)
                End If
                Close()
            Catch ex As Exception
                trans.Rollback()
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtnototalan.Text, "Transaksi Grand Totalan Sopir", "Tambah Data", ex.Message)
                MsgBox("Totalan Tidak Dapat Diproses")
            End Try
        Else
            MsgBox("Transaksi Tidak Bisa Disimpan ")
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtkodesopir_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtkodesopir.TextChanged

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Function cekkurang(kodebiaya As String) As Boolean
        Dim kurang As Boolean
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "select kurang from tgrandbiaya where kodegrandbiaya=@kodegrandbiaya"
        cmd.Parameters.AddWithValue("@kodegrandbiaya", kodebiaya)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        kurang = cmd.ExecuteScalar()
        conn.Close()
        Return kurang
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim tr As DataRow = dsbiaya.Tables("biaya").NewRow
        tr("kodegrandbiaya") = cmbgrandbiaya.SelectedValue
        tr("namagrandbiaya") = cmbgrandbiaya.Text
        If cekkurang(cmbgrandbiaya.SelectedValue) Then
            tr("debit") = txtGrandbiaya.Text
            tr("kredit") = 0
        Else
            tr("kredit") = txtGrandbiaya.Text
            tr("Debit") = 0
        End If
        tr("keterangan") = txtgrandket.Text
        dsbiaya.Tables("biaya").Rows.Add(tr)
        hitungditerima()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            dsbiaya.Tables("biaya").Rows(e.RowIndex).Delete()
            hitungditerima()
        End If
    End Sub
End Class