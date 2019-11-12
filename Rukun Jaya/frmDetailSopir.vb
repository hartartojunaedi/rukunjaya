Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmDetailSopir
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    'jun 26 desember 2014
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeSopir.Text) = "" Then
            _rjcommon.shownotifyerror("Kode Sopir Harus Diisi !")
            flag = False
        End If
        If Trim(txtNamaSopir.Text) = "" Then
            _rjcommon.shownotifyerror("Nama Sopir Harus Diisi !")
            flag = False
        End If
        Return flag
    End Function
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If ceksimpan() Then
            Try
                'dtpsopir.Format = DateTimePickerFormat.Custom
                'dtpsopir.CustomFormat = "dd/MM/yyyy"
                conn.Open()
                Dim ms As New MemoryStream()
                PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                ' Dim cmd = New SqlCommand("insert into tsopir values (@kode,@panggilan,@nama,@alamat,@kota,@hp,@no_id,@status,@date,@create,@update)", conn)
                'jun 17 oktober 2014
                Dim cmd = New SqlCommand("insert into tsopir (kodesopir,panggilan,namasopir,alamat,rtrw,kelurahan,kecamatan,foto,kota,hp,noID,status,tglmasuk,tempatlahir,tgllahir)values (@kode,@panggilan,@nama,@alamat,@rtrw,@kelurahan,@kecamatan,@foto,@kota,@hp,@no_id,@status,@date,@tempatlahir,@tgllahir)", conn)
                cmd.Parameters.AddWithValue("@kode", txtKodeSopir.Text)
                cmd.Parameters.AddWithValue("@panggilan", txtPanggilan.Text)
                cmd.Parameters.AddWithValue("@nama", txtNamaSopir.Text)
                cmd.Parameters.AddWithValue("@hp", txtHP.Text)
                cmd.Parameters.AddWithValue("@no_id", txtNoID.Text)
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
                cmd.Parameters.AddWithValue("@rtrw", txtrtrw.Text)
                cmd.Parameters.AddWithValue("@kelurahan", txtKelurahan.Text)
                cmd.Parameters.AddWithValue("@kecamatan", txtKecamatan.Text)
                cmd.Parameters.AddWithValue("@kota", txtKota.Text)
                cmd.Parameters.AddWithValue("@status", cmbstatus.SelectedIndex)
                cmd.Parameters.AddWithValue("@date", dtpsopir.Value.Date)
                cmd.Parameters.AddWithValue("@tempatlahir", txtTempatLahir.Text)
                cmd.Parameters.AddWithValue("@tgllahir", dtpTglLahir.Value.Date)
                cmd.Parameters.AddWithValue("@foto", data)
                'jun 17 oktober 2014
                'cmd.Parameters.AddWithValue("@create", Now)
                'cmd.Parameters.AddWithValue("@update", Now)
                cmd.ExecuteNonQuery()
                frmMastersopir.refreshdata()
                _rjcommon.shownotify("Data Sopir berhasil ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, txtKodeSopir.Text, "Master Sopir", "Tambah Data", "")
                conn.Close()
                Me.Close()
            Catch ex As Exception
                _rjcommon.shownotifyerror("Data Sopir gagal ditambahkan")
                _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeSopir.Text, "Master Sopir", "Tambah Data", ex.Message)
                conn.Close()

            End Try
        Else
            MsgBox("Isian Ada Yang Kurang Tepat")
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'dtpsopir.Format = DateTimePickerFormat.Custom
            'dtpsopir.CustomFormat = "dd/MM/yyyy"
            conn.Open()
            'jun 28 jan 2015
            Dim cmd As New SqlCommand("", conn)
            If Trim(lblnamafile.Text) = "" Then
                cmd.CommandText = "update tsopir set panggilan=@panggilan,namasopir=@namasopir,alamat=@alamat,rtrw=@rtrw,kelurahan=@kelurahan,kecamatan=@kecamatan,kota=@kota,hp=@hp,NoID=@noid,status=@status,tglmasuk=@date,tempatlahir=@tempatlahir,tgllahir=@tgllahir where kodesopir=@kodesopir"
            Else
                cmd.CommandText = "update tsopir set panggilan=@panggilan,namasopir=@namasopir,alamat=@alamat,rtrw=@rtrw,kelurahan=@kelurahan,kecamatan=@kecamatan,kota=@kota,hp=@hp,NoID=@noid,status=@status,tglmasuk=@date,foto=@foto,tempatlahir=@tempatlahir,tgllahir=@tgllahir where kodesopir=@kodesopir"
            End If
            If Trim(lblnamafile.Text) <> "" Then
                'update foto
                Dim ms As New MemoryStream()
                PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                cmd.Parameters.AddWithValue("@foto", data)
            End If

            cmd.Parameters.AddWithValue("@panggilan", txtPanggilan.Text)
            cmd.Parameters.AddWithValue("@namasopir", txtNamaSopir.Text)
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@rtrw", txtrtrw.Text)
            cmd.Parameters.AddWithValue("@kelurahan", txtKelurahan.Text)
            cmd.Parameters.AddWithValue("@kecamatan", txtKecamatan.Text)
            cmd.Parameters.AddWithValue("@kota", txtKota.Text)
            cmd.Parameters.AddWithValue("@hp", txtHP.Text)
            cmd.Parameters.AddWithValue("NoID", txtNoID.Text)
            cmd.Parameters.AddWithValue("@status", cmbstatus.SelectedIndex)
            cmd.Parameters.AddWithValue("@kodesopir", txtKodeSopir.Text)
            cmd.Parameters.AddWithValue("@date", dtpsopir.Value.Date)
            cmd.Parameters.AddWithValue("@tempatlahir", txtTempatLahir.Text)
            cmd.Parameters.AddWithValue("@tgllahir", dtpTglLahir.Value.Date)

            cmd.ExecuteNonQuery()
            frmMastersopir.refreshdata()
            _rjcommon.shownotify("Data Sopir berhasil diubah")
            _rjcommon.isilog(_rjcommon.getusername, txtKodeSopir.Text, "Master Sopir", "Update Data", "")
            conn.Close()
            Me.Close()
        Catch ex As Exception
            _rjcommon.shownotify("Data Sopir gagal diubah")
            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeSopir.Text, "Master Sopir", "Update Data", ex.Message)
            conn.Close()
            Me.Close()
        End Try
    End Sub



    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailSopir_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            lblnamafile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub frmDetailSopir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbstatus.SelectedIndexChanged

    End Sub
End Class