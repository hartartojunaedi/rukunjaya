Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailMasterKendaraan
    Public nolambung As String = ""
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)
    'jun 26 desember 2014
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtNoLambung.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("No Lambung tidak boleh kosong !")
        End If
        If Trim(txtNoPolisi.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nopol tidak boleh kosong !")
        End If
        Return flag
    End Function
    Private Sub frmDetailMasterKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSimpan.Enabled = True
        isicbjenis()
        isicbjenisbuku()
        isicbkodeperusahaan()
        If lblMode.Text.ToLower = "ubah" And nolambung <> "" Then
            txtNoLambung.Enabled = False
            conn.Open()
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "select tkendaraan.*,tJenisKendaraan.namajenis as namajenis from tkendaraan,tjeniskendaraan where tjeniskendaraan.kodejenis = tkendaraan.jenis and nolambung = @nolambung"
            cmd.Parameters.AddWithValue("@nolambung", nolambung)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                txtNoLambung.Text = nolambung
                txtNoLambung.ReadOnly = True
                cbKodePerusahaan.Text = reader("Kodeperusahaan")
                txtMerek.Text = reader("Merek")
                txtNoBPKB.Text = reader("NoBPKB")
                txtNoMesin.Text = reader("NoMesin")
                txtNoPolisi.Text = reader("NoPol")
                txtNoRangka.Text = reader("NoRangka")
                txtPemilik.Text = reader("Pemilik")
                txtTahun.Text = reader("Tahun")
                dtpJatuhTempo.Value = reader("JatuhTempo")
                'jun 26 desember 2014
                dtpBPKB.Value = reader("JatuhTempoBPKB")
                cbJenis.Text = (reader("namajenis"))
                cbJenisBuku.Text = reader("jenisbuku")
            End While
            conn.Close()
        ElseIf lblMode.Text.ToLower = "tambah" Then
            clearisi()
        End If
    End Sub
    Sub clearisi()
        cbKodePerusahaan.SelectedIndex = -1
        txtMerek.Text = ""
        txtNoBPKB.Text = ""
        txtNoLambung.Text = ""
        txtNoMesin.Text = ""
        txtNoPolisi.Text = ""
        txtNoRangka.Text = ""
        txtPemilik.Text = ""
        txtTahun.Text = ""
        dtpJatuhTempo.Value = Date.Now
        dtpBPKB.Value = Date.Now
        cbJenis.SelectedIndex = -1
        cbJenisBuku.SelectedIndex = -1
    End Sub
    Sub isicbjenis()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tjeniskendaraan"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        If tb.Rows.Count <= 0 Then
            btnSimpan.Enabled = False
        End If
        cbJenis.DataSource = tb
        cbJenis.DisplayMember = "namaJenis"
        cbJenis.ValueMember = "KodeJenis"
        cbJenis.Refresh()
        conn.Close()
      
    End Sub

    Sub isicbjenisbuku()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tjenisbuku"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        'If tb.Rows.Count <= 0 Then
        '    btnSimpan.Enabled = False
        'End If
        cbJenisBuku.DataSource = tb
        cbJenisBuku.DisplayMember = "jenisbuku"
        cbJenisBuku.ValueMember = "jenisbuku"
        cbJenisBuku.Refresh()
        conn.Close()

    End Sub
    Sub isicbkodeperusahaan()
        conn.Open()
        Dim cmd As New SqlCommand("", conn)
        ' If conn.State = ConnectionState.Closed Then
        ' End If
        cmd.CommandText = "select * from tperusahaan where holding='0' order by namaperusahaan"
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim tb As New DataTable
        tb.Load(reader)
        If tb.Rows.Count <= 0 Then
            btnSimpan.Enabled = False
        End If
        cbKodePerusahaan.DataSource = tb
        cbKodePerusahaan.DisplayMember = "namaperusahaan"
        cbKodePerusahaan.ValueMember = "Kodeperusahaan"
        cbKodePerusahaan.Refresh()
        conn.Close()
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            'cek terlebih dahulu untuk perusahaan dan jenis tidak boleh kosong
            If cbKodePerusahaan.SelectedIndex = -1 Then
                MsgBox("Data Perusahaan harus diisi")
            ElseIf cbJenis.SelectedIndex = -1 Then
                MsgBox("Data Jenis Kendaraan harus diisi")
            Else
                If lblMode.Text.ToLower = "ubah" Then
                    Try
                        conn.Open()
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        cmd.CommandText = "update tkendaraan set jenisbuku=@jenisbuku,nopol = @nopol, pemilik = @pemilik, kodeperusahaan = @kodeperusahaan, merek=@merek, tahun=@tahun, norangka=@norangka, nomesin=@nomesin,nobpkb=@nobpkb, jatuhtempo=@jatuhtempo,jatuhtempobpkb=@jatuhtempobpkb, jenis=@jenis, updatedate=@updatedate where nolambung = @nolambung"
                        cmd.Parameters.AddWithValue("@nopol", txtNoPolisi.Text)
                        cmd.Parameters.AddWithValue("@pemilik", txtPemilik.Text)
                        cmd.Parameters.AddWithValue("@kodeperusahaan", cbKodePerusahaan.SelectedValue)
                        cmd.Parameters.AddWithValue("@merek", txtMerek.Text)
                        cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
                        cmd.Parameters.AddWithValue("@norangka", txtNoRangka.Text)
                        cmd.Parameters.AddWithValue("@nomesin", txtNoMesin.Text)
                        cmd.Parameters.AddWithValue("@nobpkb", txtNoBPKB.Text)
                        cmd.Parameters.AddWithValue("@jatuhtempo", dtpJatuhTempo.Value)
                        'jun
                        cmd.Parameters.AddWithValue("@jatuhtempobpkb", dtpBPKB.Value)
                        cmd.Parameters.AddWithValue("@jenis", cbJenis.SelectedValue)
                        cmd.Parameters.AddWithValue("@jenisbuku", cbJenisBuku.SelectedValue)
                        cmd.Parameters.AddWithValue("@updatedate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@nolambung", nolambung)
                        cmd.ExecuteNonQuery()
                        'jun
                        _rjcommon.shownotify("Data Kendaraan Berhasil Diupdate")
                        _rjcommon.isilog(_rjcommon.getusername, txtNoLambung.Text, "Master Kendaraan", "Update Data", "ubah data nolambung = " + txtNoLambung.Text)
                        conn.Close()
                        Me.Close()

                        frmMasterKendaraan.panggil()
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("data tidak berhasil diubah")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtNoLambung.Text, "Master Kendaran", "Update Data", ex.Message)
                        conn.Close()
                    End Try

                ElseIf lblMode.Text.ToLower = "tambah" Then
                    Try
                        conn.Open()
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        'cek dulu apakah sudah pernah ada nomor lambung tersebut
                        cmd.CommandText = "select count(*) from tkendaraan where nolambung=@nolambung"
                        cmd.Parameters.AddWithValue("@nolambung", txtNoLambung.Text)
                        Dim i As Integer = cmd.ExecuteScalar
                        If i = 0 Then
                            cmd.Parameters.Clear()
                            'jun 18 oktober 2014
                            cmd.CommandText = "insert into tkendaraan (nolambung,nopol,pemilik,kodeperusahaan,merek,tahun,norangka,nomesin,noBPKB,jatuhtempo,jatuhtempobpkb,jenis,jenisbuku) values(@nolambung,@nopol,@pemilik,@kodeperusahaan,@merek,@tahun,@norangka,@nomesin,@nobpkb,@jatuhtempo,@jatuhtempobpkb,@jenis,@jenisbuku)"
                            'cmd.CommandText = "insert into tkendaraan values(@nolambung,@nopol,@pemilik,@kodeperusahaan,@merek,@tahun,@norangka,@nomesin,@nobpkb,@jatuhtempo,@jenis,@createdate,NULL)"

                            cmd.Parameters.AddWithValue("@nolambung", txtNoLambung.Text)
                            cmd.Parameters.AddWithValue("@nopol", txtNoPolisi.Text)
                            cmd.Parameters.AddWithValue("@pemilik", txtPemilik.Text)
                            cmd.Parameters.AddWithValue("@kodeperusahaan", cbKodePerusahaan.SelectedValue)
                            cmd.Parameters.AddWithValue("@merek", txtMerek.Text)
                            cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
                            cmd.Parameters.AddWithValue("@norangka", txtNoRangka.Text)
                            cmd.Parameters.AddWithValue("@nomesin", txtNoMesin.Text)
                            cmd.Parameters.AddWithValue("@nobpkb", txtNoBPKB.Text)
                            cmd.Parameters.AddWithValue("@jatuhtempo", dtpJatuhTempo.Value)
                            'jun
                            cmd.Parameters.AddWithValue("@jatuhtempobpkb", dtpBPKB.Value)
                            cmd.Parameters.AddWithValue("@jenis", cbJenis.SelectedValue)
                            cmd.Parameters.AddWithValue("@jenisbuku", cbJenisBuku.SelectedValue)
                            'cmd.Parameters.AddWithValue("@createdate", DateTime.Now)
                            cmd.ExecuteNonQuery()
                            _rjcommon.shownotify("Data Kendaraan Berhasil Ditambahkan")
                            _rjcommon.isilog(_rjcommon.getusername, txtNoLambung.Text, "Master Kendaraan", "Tambah Data", "tambah data nolambung = " + txtNoLambung.Text)
                            conn.Close()
                            frmMasterKendaraan.panggil()
                            Me.Close()
                        Else
                            MessageBox.Show("Data dengan no lambung tersebut sudah ada")
                        End If

                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Data Kendaraan Tidak Berhasil Ditambahkan")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtNoLambung.Text, "Master Kendaraan", "Tambah Data", ex.Message)
                        conn.Close()
                    End Try
                End If
            End If
        Else
            MsgBox("Ada Isian yang masih kosong !")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailMasterKendaraan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And ((Me.ActiveControl.GetType() = GetType(TextBox))) Or (Me.ActiveControl.GetType() = GetType(ComboBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub frmDetailMasterKendaraan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
       
    End Sub

    Private Sub txtTahun_Leave(sender As System.Object, e As System.EventArgs) Handles txtTahun.Leave
        If txtTahun.Text <> "" Then
            If IsNumeric(txtTahun.Text) = False Then
                MsgBox("Isian Harus Berupa Angka")
                txtTahun.Focus()
            End If
        End If
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub
End Class