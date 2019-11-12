Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDetailMasterSPBU
    Public kodespbu As String = ""
    Dim _rjcommon As New RJCommon
    Dim koneksi As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(koneksi)

    'jun 13 feb 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeSPBU.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode SPBU Harus Diisi ")
        End If
        If Trim(txtNamaSPBU.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama SPBU Harus Diisi")
        End If
        Return flag
    End Function
    Private Sub frmDetailMasterSPBU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lblMode.Text.ToLower = "ubah" And kodespbu <> "" Then
            txtKodeSPBU.Enabled = False
            conn.Open()
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "select * from tSPBU where kodespbu = @kodespbu"
            cmd.Parameters.AddWithValue("@kodespbu", kodespbu)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                txtKodeSPBU.Text = kodespbu
                txtKodeSPBU.ReadOnly = True
                txtNamaSPBU.Text = reader("namaspbu")
                txtAlamatSPBU.Text = reader("alamatspbu")
                txtKotaSPBU.Text = reader("kotaspbu")
                txtKontakSPBU.Text = reader("kontakspbu")
                txtTelpSPBU.Text = reader("telpspbu")
                nupLimit.Value = reader("limit")
                nupSaldo.Value = reader("saldo")
            End While
            conn.Close()
        ElseIf lblMode.Text.ToLower = "tambah" Then
            clearisi()
        End If
    End Sub
    Sub clearisi()
        txtKodeSPBU.Text = ""
        txtNamaSPBU.Text = ""
        txtAlamatSPBU.Text = ""
        txtKotaSPBU.Text = ""
        txtKontakSPBU.Text = ""
        txtTelpSPBU.Text = ""
        nupLimit.Value = 0
        nupSaldo.Value = 0
    End Sub
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        'cek terlebih dahulu untuk perusahaan dan jenis tidak boleh kosong
        If ceksimpan() Then
            If txtKodeSPBU.Text = "" Then
                MsgBox("Kode SPBU harus diisi")
            Else
                If lblMode.Text.ToLower = "ubah" Then
                    Try
                        'jun 13 feb 2015
                        If conn.State <> ConnectionState.Open Then
                            conn.Open()
                        End If
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        'jun 18 oktober 2014
                        '                    cmd.CommandText = "update tSPBU set namaspbu = @namaspbu, alamatspbu = @alamatspbu, kotaspbu = @kotaspbu, kontakspbu=@kontakspbu, telpspbu=@telpspbu, limit=@limit, saldo=@saldo, updatedate=@updatedate where kodespbu = @kodespbu"
                        cmd.CommandText = "update tSPBU set namaspbu = @namaspbu, alamatspbu = @alamatspbu, kotaspbu = @kotaspbu, kontakspbu=@kontakspbu, telpspbu=@telpspbu, limit=@limit, saldo=@saldo where kodespbu = @kodespbu"

                        cmd.Parameters.AddWithValue("@namaspbu", txtNamaSPBU.Text)
                        cmd.Parameters.AddWithValue("@alamatspbu", txtAlamatSPBU.Text)
                        cmd.Parameters.AddWithValue("@kotaspbu", txtKotaSPBU.Text)
                        cmd.Parameters.AddWithValue("@kontakspbu", txtKontakSPBU.Text)
                        cmd.Parameters.AddWithValue("@telpspbu", txtTelpSPBU.Text)
                        cmd.Parameters.AddWithValue("@limit", nupLimit.Value)
                        cmd.Parameters.AddWithValue("@saldo", nupSaldo.Value)
                        '                   cmd.Parameters.AddWithValue("@updatedate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@kodespbu", kodespbu)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        _rjcommon.shownotify("Data SPBU Berhasil Diubah")

                        _rjcommon.isilog(_rjcommon.getusername, kodespbu, "Master SPBU", "Update Data", "ubah data kodespbu = " + txtKodeSPBU.Text)
                        frmMasterSPBU.panggil()
                        Me.Close()
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("data tidak berhasil diubah")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, kodespbu, "Master SPBU", "Update Data", ex.Message)

                    End Try
                    'jun 13 feb 2015
                    conn.Close()
                ElseIf lblMode.Text.ToLower = "tambah" Then
                    Try
                        'jun 13 feb 2015
                        If conn.State <> ConnectionState.Open Then
                            conn.Open()
                        End If
                        Dim cmd As New SqlCommand("", conn)
                        cmd.Parameters.Clear()
                        'cek dulu apakah sudah pernah ada nomor lambung tersebut
                        cmd.CommandText = "select count(*) from tspbu where kodespbu=@kodespbu"
                        cmd.Parameters.AddWithValue("@kodespbu", txtKodeSPBU.Text)
                        Dim i As Integer = cmd.ExecuteScalar
                        If i = 0 Then
                            cmd.Parameters.Clear()
                            'jun 18 oktober 2014
                            '                       cmd.CommandText = "insert into tspbu values(@kodespbu,@namaspbu,@alamatspbu,@kotaspbu,@kontakspbu,@telpspbu,@limit,@saldo,@createdate,NULL)"
                            cmd.CommandText = "insert into tspbu(kodespbu,namaspbu,alamatspbu,kotaspbu,kontakspbu,telpspbu,limit,saldo) values(@kodespbu,@namaspbu,@alamatspbu,@kotaspbu,@kontakspbu,@telpspbu,@limit,@saldo)"
                            cmd.Parameters.AddWithValue("@kodespbu", txtKodeSPBU.Text)
                            cmd.Parameters.AddWithValue("@namaspbu", txtNamaSPBU.Text)
                            cmd.Parameters.AddWithValue("@alamatspbu", txtAlamatSPBU.Text)
                            cmd.Parameters.AddWithValue("@kotaspbu", txtKotaSPBU.Text)
                            cmd.Parameters.AddWithValue("@kontakspbu", txtKontakSPBU.Text)
                            cmd.Parameters.AddWithValue("@telpspbu", txtTelpSPBU.Text)
                            cmd.Parameters.AddWithValue("@limit", nupLimit.Value)
                            cmd.Parameters.AddWithValue("@saldo", nupSaldo.Value)
                            ' cmd.Parameters.AddWithValue("@createdate", DateTime.Now)
                            cmd.ExecuteNonQuery()
                            _rjcommon.shownotify("Data Berhasil Ditambahkan")
                            conn.Close()
                            _rjcommon.isilog(_rjcommon.getusername, txtKodeSPBU.Text, "Master SPBU", "Tambah Data", "tambah data kodespbu = " + txtKodeSPBU.Text)
                            frmMasterSPBU.panggil()
                            Me.Close()
                        Else
                            MessageBox.Show("Data dengan kode spbu tersebut sudah ada")
                        End If

                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Data SPBU Tidak Berhasil Ditambahkan")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeSPBU.Text, "Master SPBU", "Tambah Data", ex.Message)
                        conn.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailMasterSPBU_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class