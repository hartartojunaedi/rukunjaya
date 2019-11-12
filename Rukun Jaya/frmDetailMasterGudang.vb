Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailMasterGudang
    Dim _rjcommon As New RJCommon

    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Public mode As Integer
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeGudang.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Gudang Tidak Boleh Kosong !")
        End If
        Return flag
    End Function
    Private Sub loaddata(kodegudang As String)
        Dim command As New SqlCommand
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "Select * from tgudang where kodegudang=@kodegudang"
        command.Parameters.Add(New SqlParameter("@kodegudang", kodegudang))
        Dim dr As SqlDataReader
        conn.Open()
        dr = command.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtNamaGudang.Text = dr.Item("namagudang").ToString
            txtAlamatGudang.Text = dr.Item("alamatgudang").ToString
            txtKotaGudang.Text = dr.Item("kotagudang").ToString
            txtKepalaGudang.Text = dr.Item("kepalagudang").ToString
            txtTelpGudang.Text = dr.Item("telpgudang").ToString
            txtKeterangan.Text = dr.Item("keterangan").ToString
        End If
        conn.Close()
    End Sub

    Private Sub frmDetailMasterGudang_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Private Sub frmDetailMasterGudang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If mode = 0 Then
            lblMode.Text = "Mode : Tambah"
            txtKodeGudang.Text = ""
            txtNamaGudang.Text = ""
            txtAlamatGudang.Text = ""
            txtKotaGudang.Text = ""
            txtKepalaGudang.Text = ""
            txtTelpGudang.Text = ""
            txtKeterangan.Text = ""
            txtKodeGudang.Enabled = True
            txtKodeGudang.Focus()
        Else
            lblMode.Text = "Mode : Ubah"
            txtKodeGudang.Enabled = False
            loaddata(txtKodeGudang.Text)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            Dim command As New SqlCommand
            Dim query As String = ""
            If mode = 0 Then
                'insert
                query = "insert into tGudang(kodegudang,namagudang,alamatgudang,kotagudang,kepalagudang,telpgudang,keterangan) values "
                query &= " (@kodegudang,@namagudang,@alamatgudang,@kotagudang,@kepalagudang,@telpgudang,@keterangan)"
            Else
                'update
                query = " update tgudang set namagudang=@namagudang,alamatgudang=@alamatgudang "
                query &= ",kotagudang=@kotagudang,kepalagudang=@kepalagudang,telpgudang=@telpgudang,keterangan=@keterangan"
                query &= " where kodegudang=@kodegudang"
            End If
            command.Connection = conn
            command.CommandType = CommandType.Text
            command.CommandText = query
            command.Parameters.Add(New SqlParameter("@kodegudang", txtKodeGudang.Text))
            command.Parameters.Add(New SqlParameter("@namagudang", txtNamaGudang.Text))
            command.Parameters.Add(New SqlParameter("@alamatgudang", txtAlamatGudang.Text))
            command.Parameters.Add(New SqlParameter("@kotagudang", txtKotaGudang.Text))
            command.Parameters.Add(New SqlParameter("@kepalagudang", txtKepalaGudang.Text))
            command.Parameters.Add(New SqlParameter("@telpgudang", txtTelpGudang.Text))
            command.Parameters.Add(New SqlParameter("@keterangan", txtKeterangan.Text))
            conn.Open()
            Try
                command.ExecuteNonQuery()
                If mode = 0 Then
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeGudang.Text, "Master Gudang", "Tambah Data", "")
                    _rjcommon.shownotify("Data Berhasil Ditambah")
                Else
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeGudang.Text, "Master Gudang", "Update Data", "")
                    _rjcommon.shownotify("Data Berhasil Diubah")
                End If
            Catch ex As Exception
                MsgBox("Data Tidak Dapat Disimpan", MsgBoxStyle.OkOnly, "Information")
                If mode = 0 Then
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeGudang.Text, "Master Gudang", "Tambah Data", ex.Message)
                Else
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeGudang.Text, "Master Gudang", "Update Data", ex.Message)
                End If
            End Try
            conn.Close()
            Close()
        Else
            MsgBox("Ada Isian Yang Salah !")
        End If
    End Sub

    Private Sub frmDetailMasterGudang_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If mode = 0 Then
            txtKodeGudang.Focus()
        Else
            txtNamaGudang.Focus()
        End If
    End Sub
End Class