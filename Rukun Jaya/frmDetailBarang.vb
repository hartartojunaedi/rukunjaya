Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailBarang
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    'jun 15 jan 2015
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodeBarang.Text) = "" Then
            _rjcommon.shownotifyerror("Kode Barang Tidak Boleh Kosong !")
            flag = False
        End If
        If Trim(txtNamaBarang.Text) = "" Then
            _rjcommon.shownotifyerror("Nama Barang Tidak Boleh Kosong !")
            flag = False
        End If
        Return flag
    End Function
    Public Sub load_jenispekerjaan()
        Dim command As New SqlCommand("Select kodejenis,namapekerjaan from tjenispekerjaan order by kodejenis", conn)
        Dim dr As SqlDataReader
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        dr = command.ExecuteReader()
        ComboBox1.Items.Clear()
        If dr.HasRows Then
            Do While dr.Read
                ComboBox1.Items.Add(dr.Item("namapekerjaan"))
            Loop
        Else
            btnSimpan.Enabled = False
        End If
        conn.Close()
    End Sub
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd

        Return adp
    End Function

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If frmMasterBarang.mode = 0 Then
                If txtKodeBarang.Text <> "" Then
                    If ConnectionState.Open = True Then
                        conn.Close()
                    Else
                        conn.Open()
                    End If
                    Try
                        'jun 17 oktober 2014
                        Dim cmd = New SqlCommand("insert into tBarang (kodebarang,namabarang,satuan,jenispekerjaan) values(@kodebarang,@namabarang,@satuan,@jenispekerjaan)", conn)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@kodebarang", txtKodeBarang.Text)
                        cmd.Parameters.AddWithValue("@namabarang", txtNamaBarang.Text)
                        cmd.Parameters.AddWithValue("@satuan", txtSatuan.Text)
                        cmd.Parameters.AddWithValue("@jenispekerjaan", ComboBox1.SelectedIndex + 1)
                        'cmd.Parameters.AddWithValue("@d", Now)
                        'cmd.Parameters.AddWithValue("@f", Now)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Barang berhasil ditambahkan")
                        _rjcommon.isilog(_rjcommon.getusername, txtKodeBarang.Text, "Master Barang", "Tambah Data", "")
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Barang gagal ditambahakan")
                        MsgBox("Barang gagal ditambahakan")
                        'jun 17 oktober 2014
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeBarang.Text, "Master Barang", "Tambah Data", ex.Message)
                    End Try
                    conn.Close()
                    Me.Close()
                Else
                    MsgBox("Kode tidak boleh kosong")
                End If
            Else
                If ConnectionState.Open = True Then
                    conn.Close()
                Else
                    conn.Open()
                End If
                Try
                    Dim cmd = New SqlCommand("update tBarang set namabarang = '" & txtNamaBarang.Text & "', satuan = '" & txtSatuan.Text & "',jenispekerjaan=" & ComboBox1.SelectedIndex + 1 & " where kodebarang = '" & txtKodeBarang.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    _rjcommon.shownotify("Detail Barang berhasil diubah")
                    _rjcommon.isilog(_rjcommon.getusername, txtKodeBarang.Text, "Master Barang", "Update Data", "")
                Catch ex As Exception
                    _rjcommon.shownotifyerror("Barang gagal diubah")
                    MsgBox("Barang gagal diubah")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodeBarang.Text, "Master Barang", "Update Data", ex.Message)
                End Try
                conn.Close()
                Me.Close()
            End If
        Else
            MsgBox("Ada Isian Yang Kurang !")
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmDetailBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'jun 26 desember 2014
        btnSimpan.Enabled = True
        load_jenispekerjaan()
        If frmMasterBarang.kode <> "" Then
            If ConnectionState.Open = True Then
                conn.Close()
            Else
                conn.Open()
            End If
            Dim ds = New DataSet

            adapter("select * from tBarang where kodebarang = '" & frmMasterBarang.kode & "'").Fill(ds, "tBarang")
            txtKodeBarang.Text = ds.Tables("tBarang").Rows(0).Item(0).ToString
            txtNamaBarang.Text = ds.Tables("tBarang").Rows(0).Item(1).ToString
            txtSatuan.Text = ds.Tables("tBarang").Rows(0).Item(2).ToString
            Dim index As Integer = CInt(ds.Tables("tbarang").Rows(0).Item("jenispekerjaan").ToString) - 1
            ComboBox1.SelectedIndex = index
            conn.Close()
            txtKodeBarang.Enabled = False
        Else
            txtKodeBarang.Enabled = True
            txtKodeBarang.Clear()
            txtNamaBarang.Clear()
            txtSatuan.Clear()
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmDetailBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class