Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailMaintance
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New RjLibrary.rjLib
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim conntrans As New SqlConnection(_rjcommon.getconnstr())
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim ds As DataSet
    Dim status = 0
    Public startmaintance = 0
    Public nmpekerjaantemp As String = ""
    Public nopoltemp As String = ""
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeMaintance.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Maintance Harus Diisi !")
        End If
        If Trim(txtkilometer.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kilometer Harus Diisi !")
        End If
        If Trim(txtbiaya.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Biaya Harus Diisi !")
        End If
        Try
            Dim a As Integer = CType(txtkilometer.Text, Integer)
        Catch ex As Exception
            flag = False
            _rjcommon.shownotifyerror("Kilometer Harus Diisi Angka !")
        End Try
        Try
            'jun 03 feb 2015
            Dim ab As Double = CType(txtbiaya.Text, Double)
        Catch ex As Exception
            flag = False
            _rjcommon.shownotifyerror("Biaya Harus Diisi Angka !")
        End Try
        Return flag
    End Function
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Public Sub deletestock(ByVal kodesparepart, ByVal jumlah)
        Dim stock = New SqlCommand("select stock from tsparepart where kodesparepart='" & kodesparepart & "'", conn).ExecuteScalar
        Dim total = stock - CDbl(jumlah)
        Dim comd = New SqlCommand("update tsparepart set stock=@stock where kodesparepart=@kodesparepart", conn)
        comd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
        comd.Parameters.AddWithValue("@stock", total)
        'tidak dibutuhkan
        'comd.ExecuteNonQuery()
    End Sub

    Public Sub addstock(ByVal kodesparepart, ByVal jumlah)
        Dim stock = New SqlCommand("select stock from tsparepart where kodesparepart='" & kodesparepart & "'", conn).ExecuteScalar
        Dim total = stock + CDbl(jumlah)
        Dim comd = New SqlCommand("update tsparepart set stock=@stock where kodesparepart=@kodesparepart", conn)
        comd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
        comd.Parameters.AddWithValue("@stock", total)
        'tidak dipakai
        'comd.ExecuteNonQuery()
    End Sub

    Public Sub recoverdata()
        conn.Open()
        For i = 0 To dgvstock.Rows.Count - 2
            Dim comd = New SqlCommand("update tsparepart set stock=@stock where kodesparepart=@kodesparepart", conn)
            comd.Parameters.AddWithValue("@kodesparepart", dgvstock.Rows(i).Cells(0).Value)
            comd.Parameters.AddWithValue("@stock", dgvstock.Rows(i).Cells(1).Value)
            'tidak dipakai
            'comd.ExecuteNonQuery()
        Next
        conn.Close()
    End Sub

    Sub resetfield()
        'cbkrutin.Checked = True
        txtKodeMaintance.Text = ""
        txttukang.Text = ""
        txtketerangan.Text = ""
        txtbiaya.Text = ""
        txtBiayadetail.Text = ""
        txtDetailKeterangan.Text = ""
        txtJumlah.Text = ""
        txtkilometer.Text = ""
        txtNoSeri.Text = ""
        cmbnolambung.SelectedIndex = 0
        cmbNamaPekerjaan.SelectedIndex = 0
        ' cmbNamaSparepart.SelectedIndex = 0
        ds.Tables("tdetailmaintance").Clear()
        txtketerangan.Text = ""
    End Sub

    Public Sub refreshdata()
        conn.Open()
        ds = New DataSet
        adapter("select kodesparepart,stock from tsparepart").Fill(ds, "tsparepart")
        dgvstock.DataSource = ds.Tables("tsparepart")
        If txtKodeMaintance.ReadOnly = False Then
            'jun 07 sep 2015
            adapter("select s.namasparepart,d.noseri,d.jumlah,d.biaya,d.keterangan,d.tglambil from tdetailmaintance d,tsparepart s where d.kodesparepart=s.kodesparepart and d.kodesparepart='?'").Fill(ds, "tdetailmaintance")
            dgvdetailmaintance.DataSource = ds.Tables("tdetailmaintance")
        Else
            adapter("select s.namasparepart,d.noseri,d.jumlah,d.biaya,d.keterangan,d.tglambil from tdetailmaintance d,tsparepart s where d.kodesparepart=s.kodesparepart and d.kodemaintance='" & txtKodeMaintance.Text & "'").Fill(ds, "tdetailmaintance")
            dgvdetailmaintance.DataSource = ds.Tables("tdetailmaintance")
            For i = 0 To dgvdetailmaintance.Rows.Count - 2
                Dim kodesparepart = New SqlCommand("select kodesparepart from tSparePart where namasparepart='" & dgvdetailmaintance.Rows(i).Cells(1).Value & "'", conn).ExecuteScalar
                addstock(kodesparepart, Int(dgvdetailmaintance.Rows(i).Cells(3).Value))
                ' MsgBox(kodesparepart & "-" & dgvdetailmaintance.Rows(i).Cells(3).Value)
            Next
            status = 0
        End If
        conn.Close()
    End Sub

    Private Sub cbkrutin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkrutin.CheckedChanged
        'If cbkrutin.Checked = True Then cbktidakrutin.Checked = False
        'jun 03 feb 2015
        cbktidakrutin.Checked = Not cbkrutin.Checked
    End Sub

    Private Sub cbktidakrutin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbktidakrutin.CheckedChanged
        ' If cbktidakrutin.Checked = True Then cbkrutin.Checked = False
        cbkrutin.Checked = Not cbktidakrutin.Checked
    End Sub

    Private Sub frmDetailMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            cmbnolambung.Items.Clear()
            Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
            While rd.Read
                cmbnolambung.Items.Add(rd("nopol"))
            End While
            rd.Close()

            cmbsopir.Items.Clear()
            rd = New SqlCommand("select namasopir from tsopir where status=0", conn).ExecuteReader
            While rd.Read
                cmbsopir.Items.Add(rd("namasopir"))
            End While
            rd.Close()


            cmbNamaPekerjaan.Items.Clear()
            rd = New SqlCommand("select * from tjenisMaintance", conn).ExecuteReader
            While rd.Read
                cmbNamaPekerjaan.Items.Add(rd("namapekerjaan"))
            End While
            rd.Close()

            cmbNamaSparepart.Items.Clear()
               Dim authors As New AutoCompleteStringCollection
            rd = New SqlCommand("select * from tsparepart", conn).ExecuteReader
            While rd.Read
                ' cmbNamaSparepart.Items.Add(rd("namasparepart"))
                authors.Add(rd("namasparepart"))
            End While
            cmbNamaSparepart.AutoCompleteMode = AutoCompleteMode.Suggest
            cmbNamaSparepart.AutoCompleteSource = AutoCompleteSource.CustomSource
            cmbNamaSparepart.AutoCompleteCustomSource = authors
            rd.Close()

            startmaintance = 1
            If startmaintance = 1 Then
                cmbnolambung.SelectedIndex = 0
                cmbNamaPekerjaan.SelectedIndex = 0
                cmbsopir.SelectedIndex = 0
                ' cmbNamaSparepart.SelectedIndex = 0
                'cbktidakrutin.Checked = True
            End If

            If txtKodeMaintance.ReadOnly Then
                'update 
                rd = New SqlCommand("select isnull(kodesopir,'') as kodesopir1 from tmaintance where kodemaintance='" + txtKodeMaintance.Text + "'", conn).ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    Dim kodesopir = rd("kodesopir1")
                    If kodesopir <> "" Then
                        rd.Close()
                        rd = New SqlCommand("select namasopir from tsopir where kodesopir='" + kodesopir + "'", conn).ExecuteReader
                        If rd.HasRows Then
                            rd.Read()
                            Dim posisi As Integer = -1
                            For i = 0 To cmbsopir.Items.Count - 1
                                If cmbsopir.Items(i) = rd("namasopir") Then
                                    posisi = i
                                End If

                            Next
                            cmbsopir.SelectedIndex = posisi
                        End If
                    End If
                End If
            End If
            conn.Close()
            dtpTglAmbil.Value = Now
            btnHapusDgv.FlatStyle = FlatStyle.Flat
            dgvdetailmaintance.Columns.Add(btnHapusDgv)
            btnHapusDgv.Text = "Hapus"
            btnHapusDgv.HeaderText = "Hapus Data"
            btnHapusDgv.UseColumnTextForButtonValue = True
            dgvstock.Visible = False
            refreshdata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If nmpekerjaantemp <> "" Then
            Dim index As Integer
            index = cmbNamaPekerjaan.FindString(nmpekerjaantemp)
            cmbNamaPekerjaan.SelectedIndex = index
            nmpekerjaantemp = ""
            ' MsgBox(nopoltemp)
            index = cmbnolambung.FindString(nopoltemp)
            cmbnolambung.SelectedIndex = index
            nopoltemp = ""
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim stock = 0
        conn.Open()
        stock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
        'MsgBox(stock)
        If txtJumlah.Text = "" Then
            _rjcommon.shownotifyerror("Jumlah Tidak Boleh Kosong")
            conn.Close()
            Return
        End If
        If txtBiayadetail.Text = "" Then txtBiayadetail.Text = 0
        conn.Close()
        Dim check = 0
        For i = 0 To dgvdetailmaintance.Rows.Count - 2
            If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) And (dgvdetailmaintance.Rows(i).Cells(2).Value = txtNoSeri.Text) Then
                If stock - (dgvdetailmaintance.Rows(i).Cells(3).Value + Int(txtJumlah.Text)) >= 0 Then
                    dgvdetailmaintance.Rows(i).Cells(3).Value = dgvdetailmaintance.Rows(i).Cells(3).Value + Int(txtJumlah.Text)
                    lblsisastock.Text = Int(lblsisastock.Text) - txtJumlah.Text
                End If
                check = 1
            End If
        Next
        If check = 0 Then
            Dim prevstock = 0
            For i = 0 To dgvdetailmaintance.Rows.Count - 2
                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    prevstock = prevstock + dgvdetailmaintance.Rows(i).Cells(3).Value
                End If
            Next
            If (stock - (prevstock + txtJumlah.Text) >= 0) Then
                'jun 7 september 2015
                Dim data As DataRow
                data = ds.Tables("tdetailmaintance").NewRow
                data.Item(0) = cmbNamaSparepart.Text
                data.Item(1) = txtNoSeri.Text
                data.Item(2) = txtJumlah.Text
                data.Item(3) = txtBiayadetail.Text
                data.Item(4) = txtDetailKeterangan.Text
                data.Item(5) = dtpTglAmbil.Value
                data.EndEdit()
                ds.Tables("tdetailmaintance").Rows.Add(data)
                lblsisastock.Text = Int(lblsisastock.Text) - txtJumlah.Text
            End If
        End If
    End Sub

    Private Sub dgvdetailmaintance_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetailmaintance.CellClick
        'jun 26 jan 2015
        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            Dim id = dgvdetailmaintance.Rows(e.RowIndex).Cells(3).Value
            If txtKodeMaintance.ReadOnly = True Then
                conn.Open()
                Dim kodesparepart = New SqlCommand("select kodesparepart from tSparePart where namasparepart='" & dgvdetailmaintance.Rows(e.RowIndex).Cells(1).Value & "'", conn).ExecuteScalar
                'addstock(kodesparepart, Int(dgvdetailmaintance.Rows(e.RowIndex).Cells(3).Value))
                conn.Close()
            End If
            If (dgvdetailmaintance.Rows(e.RowIndex).Cells(1).Value = cmbNamaSparepart.Text) Then
                lblsisastock.Text = Int(lblsisastock.Text) + dgvdetailmaintance.Rows(e.RowIndex).Cells(3).Value
            End If
            ds.Tables("tdetailmaintance").Rows.RemoveAt(e.RowIndex)
        End If

    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If ceksimpan() Then
            'jun
            Dim sesi As SqlTransaction
            If conntrans.State <> ConnectionState.Open Then
                conntrans.Open()
            End If
            sesi = conntrans.BeginTransaction
            If txtKodeMaintance.ReadOnly = False Then
                Try
                    conn.Open()
                    Dim carikata = New SqlCommand("select kodemaintance from tmaintance where kodemaintance='" & txtKodeMaintance.Text & "'", conn).ExecuteScalar
                    If (carikata <> "") Then
                        MsgBox("Kode Maintance sudah ada")
                        Return
                    End If
                    Dim nolam = New SqlCommand("select nolambung from tkendaraan where nopol='" & cmbnolambung.SelectedItem & "'", conn).ExecuteScalar
                    Dim kdjenismaintance = New SqlCommand("select kodejenismaintance from tjenismaintance where namapekerjaan='" & cmbNamaPekerjaan.SelectedItem & "'", conn).ExecuteScalar

                    Dim cmdsopir As New SqlCommand("select kodesopir from tsopir where namasopir=@namasopir", conn)
                    cmdsopir.Parameters.Add(New SqlParameter("@namasopir", cmbsopir.SelectedItem))
                    Dim kdsopir = cmdsopir.ExecuteScalar
                    '                 Dim kdsopir = New SqlCommand("select kodesopir from tsopir where namasopir='" & cmbsopir.SelectedItem & "'", conn).ExecuteScalar
                    Dim cmd = New SqlCommand("insert into tmaintance(kodemaintance,nolambung,kodejenismaintance,tukang,keterangan,rutin,biaya,tgl,km,createdate,updatedate,kodesopir,kerusakan,tindakan1,tindakan2,tindakan3,tindakan4,tindakan5) values (@kdmaintance,@nolam,@kdjenismaintance,@tukang,@keterangan,@rutin,@biaya,@tglmaintance,@km,@create,@update,@kodesopir,@kerusakan,@tindakan1,@tindakan2,@tindakan3,@tindakan4,@tindakan5)", conn)
                    cmd.Parameters.AddWithValue("@kdmaintance", txtKodeMaintance.Text)
                    cmd.Parameters.AddWithValue("@nolam", nolam)
                    cmd.Parameters.AddWithValue("@kdjenismaintance", kdjenismaintance)
                    cmd.Parameters.AddWithValue("@kodesopir", kdsopir)
                    cmd.Parameters.AddWithValue("@tukang", txttukang.Text)
                    cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                    cmd.Parameters.AddWithValue("@rutin", cbkrutin.Checked)
                    cmd.Parameters.AddWithValue("@biaya", _rjlib.RemoveNonNumeric(txtbiaya.Text))
                    cmd.Parameters.AddWithValue("@tglmaintance", dtptglmaintance.Value.Date)
                    cmd.Parameters.AddWithValue("@km", txtkilometer.Text)
                    cmd.Parameters.AddWithValue("@kerusakan", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@tindakan1", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@tindakan2", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@tindakan3", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@tindakan4", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@tindakan5", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@create", Now)
                    cmd.Parameters.AddWithValue("@update", Now)
                    cmd.ExecuteNonQuery()
                    'jun 27 desember  2014
                    'reset maintance
                    _rjcommon.resetmaintance(nolam, kdjenismaintance, txtkilometer.Text)
                    'jun 8 september 2015
                    For i = 0 To dgvdetailmaintance.Rows.Count - 1
                        cmd.Parameters.Clear()
                        Dim kodesparepart = New SqlCommand("select kodesparepart from tSparePart where namasparepart='" & dgvdetailmaintance.Rows(i).Cells(1).Value & "'", conn).ExecuteScalar
                        'jun 7 september 2015
                        cmd = New SqlCommand("insert into tdetailmaintance(kodemaintance,kodesparepart,noseri,jumlah,biaya,keterangan,tglambil,createdate,updatedate) values (@kdmaintance,@kodesparepart,@noseri,@jumlah,@biaya,@keterangan,@tglambil,@create,@update)", conn)
                        cmd.Parameters.AddWithValue("@kdmaintance", txtKodeMaintance.Text)
                        cmd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
                        cmd.Parameters.AddWithValue("@noseri", dgvdetailmaintance.Rows(i).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@jumlah", dgvdetailmaintance.Rows(i).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@biaya", dgvdetailmaintance.Rows(i).Cells(4).Value)
                        cmd.Parameters.AddWithValue("@keterangan", dgvdetailmaintance.Rows(i).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@tglambil", dgvdetailmaintance.Rows(i).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@create", Now)
                        cmd.Parameters.AddWithValue("@update", Now)
                        cmd.ExecuteNonQuery()
                        deletestock(kodesparepart, CDbl(dgvdetailmaintance.Rows(i).Cells(3).Value))
                    Next
                    frmMaintance.refreshdata()
                    resetfield()
                    conn.Close()
                    refreshdata()
                    conn.Open()
                    frmMaintance.refreshdata()
                    _rjcommon.shownotify("Transaksi Maintance berhasil ditambahkan")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeMaintance.Text, "Transaksi Maintance", "Tambah Data", "")
                    conn.Close()
                    sesi.Commit()
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                    _rjcommon.shownotify("Transaksi Maintance gagal ditambahkan")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeMaintance.Text, "Transaksi Maintance", "Tambah Data", ex.Message)
                    conn.Close()
                    sesi.Rollback()
                End Try
                conntrans.Close()
            ElseIf txtKodeMaintance.ReadOnly = True Then
                Try
                    conn.Open()
                    Dim cmd = New SqlCommand("delete from tdetailmaintance where kodemaintance='" & txtKodeMaintance.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    cmd = New SqlCommand("delete from tmaintance where kodemaintance='" & txtKodeMaintance.Text & "'", conn)
                    cmd.ExecuteNonQuery()

                    Dim nolam = New SqlCommand("select nolambung from tkendaraan where nopol='" & cmbnolambung.SelectedItem & "'", conn).ExecuteScalar
                    Dim kdjenismaintance = New SqlCommand("select kodejenismaintance from tjenismaintance where namapekerjaan='" & cmbNamaPekerjaan.SelectedItem & "'", conn).ExecuteScalar
                    'jun 7 september 2015
                    Dim kdsopir = New SqlCommand("select kodesopir from tsopir where namasopir='" & cmbsopir.SelectedItem & "'", conn).ExecuteScalar

                    cmd = New SqlCommand("insert into tmaintance(kodemaintance,nolambung,kodejenismaintance,tukang,keterangan,rutin,biaya,tgl,km,createdate,updatedate,kodesopir,kerusakan,tindakan1,tindakan2,tindakan3,tindakan4,tindakan5) values (@kdmaintance,@nolam,@kdjenismaintance,@tukang,@keterangan,@rutin,@biaya,@tglmaintance,@km,@create,@update,@kodesopir,@kerusakan,@tindakan1,@tindakan2,@tindakan3,@tindakan4,@tindakan5)", conn)
                    cmd.Parameters.AddWithValue("@kdmaintance", txtKodeMaintance.Text)
                    cmd.Parameters.AddWithValue("@nolam", nolam)
                    cmd.Parameters.AddWithValue("@kdjenismaintance", kdjenismaintance)
                    cmd.Parameters.AddWithValue("@tukang", txttukang.Text)
                    cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
                    cmd.Parameters.AddWithValue("@rutin", cbkrutin.Checked)
                    cmd.Parameters.AddWithValue("@biaya", _rjlib.RemoveNonNumeric(txtbiaya.Text))
                    cmd.Parameters.AddWithValue("@tglmaintance", dtptglmaintance.Value.Date)
                    cmd.Parameters.AddWithValue("@km", txtkilometer.Text)
                    cmd.Parameters.AddWithValue("@create", Now)
                    cmd.Parameters.AddWithValue("@update", Now)
                    cmd.Parameters.AddWithValue("@kodesopir", kdsopir)
                    cmd.Parameters.AddWithValue("@kerusakan", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@tindakan1", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@tindakan2", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@tindakan3", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@tindakan4", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@tindakan5", TextBox6.Text)
                    cmd.ExecuteNonQuery()
                    'jun 27 desember  2014
                    'reset maintance
                    _rjcommon.resetmaintance(nolam, kdjenismaintance, txtkilometer.Text)
                    '8 sept 2015
                    For i = 0 To dgvdetailmaintance.Rows.Count - 1
                        cmd.Parameters.Clear()
                        Dim kodesparepart = New SqlCommand("select kodesparepart from tSparePart where namasparepart='" & dgvdetailmaintance.Rows(i).Cells(1).Value & "'", conn).ExecuteScalar
                        cmd = New SqlCommand("insert into tdetailmaintance(kodemaintance,kodesparepart,noseri,jumlah,biaya,keterangan,tglambil,createdate,updatedate) values (@kdmaintance,@kodesparepart,@noseri,@jumlah,@biaya,@keterangan,@tglambil,@create,@update)", conn)
                        cmd.Parameters.AddWithValue("@kdmaintance", txtKodeMaintance.Text)
                        cmd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
                        cmd.Parameters.AddWithValue("@noseri", dgvdetailmaintance.Rows(i).Cells(2).Value)
                        cmd.Parameters.AddWithValue("@jumlah", dgvdetailmaintance.Rows(i).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@biaya", dgvdetailmaintance.Rows(i).Cells(4).Value)
                        cmd.Parameters.AddWithValue("@keterangan", dgvdetailmaintance.Rows(i).Cells(5).Value)
                        cmd.Parameters.AddWithValue("@tglambil", dgvdetailmaintance.Rows(i).Cells(6).Value)
                        cmd.Parameters.AddWithValue("@create", Now)
                        cmd.Parameters.AddWithValue("@update", Now)
                        cmd.ExecuteNonQuery()
                        deletestock(kodesparepart, Int(dgvdetailmaintance.Rows(i).Cells(3).Value))
                    Next
                    'conn.Close()
                    'refreshdata()
                    'conn.Open()
                    'frmMaintance.refreshdata()
                    status = 1
                    _rjcommon.shownotify("Transaksi Maintance berhasil diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeMaintance.Text, "Transaksi Maintance", "Ubah Data", "")
                    conn.Close()
                    sesi.Commit()
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                    _rjcommon.shownotify("Transaksi Maintance gagal diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeMaintance.Text, "Transaksi Maintance", "Ubah Data", ex.Message)
                    conn.Close()
                    sesi.Rollback()
                End Try
                conntrans.Close()
                Me.Close()
            End If
        Else
            MsgBox("Ada Isian Yang Salah !")
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim frmMaintance As New frmMaintance
        frmMaintance.ShowDialog()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If txtKodeMaintance.ReadOnly = False Then
            resetfield()
            Close()
        ElseIf txtKodeMaintance.ReadOnly = True Then
            status = 2
            Me.Close()
        End If
    End Sub

    Private Sub frmDetailMaintance_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If txtKodeMaintance.ReadOnly = False Then
        '    resetfield()
        'ElseIf txtKodeMaintance.ReadOnly = True And (status = 2 Or status = 0) Then
        '    recoverdata()
        'End If
    End Sub

    Private Sub cmbNamaSparepart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNamaSparepart.SelectedIndexChanged
        'Try
        '    conn.Open()
        '    Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.text & "'", conn).ExecuteScalar
        '    For i = 0 To dgvdetailmaintance.Rows.Count - 2
        '        If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.text) Then
        '            sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
        '        End If
        '    Next
        '    conn.Close()
        '    lblsisastock.Text = sisastock
        'Catch ex As Exception
        '    Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.SelectedItem & "'", conn).ExecuteScalar
        '    For i = 0 To dgvdetailmaintance.Rows.Count - 2
        '        If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.SelectedItem) Then
        '            sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
        '        End If
        '    Next
        '    lblsisastock.Text = sisastock
        'End Try
        'MsgBox("leave")
    End Sub

    Private Sub frmDetailMaintance_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            conn.Open()
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To dgvdetailmaintance.Rows.Count - 2
                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
                End If
            Next
            conn.Close()
            lblsisastock.Text = sisastock
        Catch ex As Exception
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To dgvdetailmaintance.Rows.Count - 2
                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
                End If
            Next
            lblsisastock.Text = sisastock
        End Try
    End Sub

    Private Sub txtJumlah_Leave(sender As Object, e As System.EventArgs) Handles txtJumlah.Leave
        'jun 24 maret 2015
        If IsNumeric(txtJumlah.Text) = False Then
            MsgBox("Jumlah harus berupa angka ")
            txtJumlah.Focus()
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtJumlah.TextChanged

    End Sub

    Private Sub txtbiaya_Leave(sender As Object, e As System.EventArgs) Handles txtbiaya.Leave
        'jun 24 maret 2015
        If IsNumeric(txtbiaya.Text) = False Then
            MsgBox("Biaya harus berupa angka ")
            txtbiaya.Focus()
        End If
    End Sub


    Private Sub cmbNamaSparepart_TextUpdate(sender As System.Object, e As System.EventArgs)

    End Sub

  

    'Private Sub cmbNamaSparepart_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbNamaSparepart.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            conn.Open()
    '            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.SelectedItem & "'", conn).ExecuteScalar
    '            For i = 0 To dgvdetailmaintance.Rows.Count - 2
    '                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.SelectedItem) Then
    '                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
    '                End If
    '            Next
    '            conn.Close()
    '            lblsisastock.Text = sisastock
    '        Catch ex As Exception
    '            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.SelectedItem & "'", conn).ExecuteScalar
    '            For i = 0 To dgvdetailmaintance.Rows.Count - 2
    '                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.SelectedItem) Then
    '                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
    '                End If
    '            Next
    '            lblsisastock.Text = sisastock
    '        End Try
    '    End If
    ' End Sub

    Private Sub cmbNamaSparepart_Leave(sender As System.Object, e As System.EventArgs) Handles cmbNamaSparepart.Leave
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To dgvdetailmaintance.Rows.Count - 1
                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
                End If
            Next
            conn.Close()
            lblsisastock.Text = sisastock
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim hargaterakhir As Integer = New SqlCommand("select hargaterakhir from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            txtBiayadetail.Text = hargaterakhir
            conn.Close()
        Catch ex As Exception
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To dgvdetailmaintance.Rows.Count - 1
                If (dgvdetailmaintance.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - dgvdetailmaintance.Rows(i).Cells(3).Value
                End If
            Next
            lblsisastock.Text = sisastock
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Dim hargaterakhir = New SqlCommand("select hargaterakhir from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            txtBiayadetail.Text = hargaterakhir
            conn.Close()
        End Try
    End Sub

    Private Sub dgvdetailmaintance_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetailmaintance.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class