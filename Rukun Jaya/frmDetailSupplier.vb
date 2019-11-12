Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailSupplier
    Dim _rjcommon As New RJCommon
    Dim konek As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(konek)
    Dim adap As New SqlDataAdapter
    Dim ds As New DataSet
    Dim builder As New SqlCommandBuilder
    Dim cmd As New SqlCommand("", conn)
    'jun
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKode.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Supplier Harus Diisi !")
        End If
        If Trim(txtNama.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama Supplier Harus Diisi !")
        End If
        Return flag
    End Function
    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMasterSupplier.mode = 1 Then
            lblTambah.Text = "Ubah"
            txtKode.Enabled = False
            If ConnectionState.Open = False Then
                conn.Close()
            Else
                conn.Open()
            End If
            ds = New DataSet
            'jun 13 feb 2015
            cmd.Parameters.Clear()
            cmd.CommandText = "select * from tsupplier where kodesupplier=@kodesupplier"
            cmd.Parameters.AddWithValue("@kodesupplier", frmMasterSupplier.kode)
            adap.SelectCommand = cmd
            adap.Fill(ds)
            builder = New SqlCommandBuilder(adap)
            txtKode.Text = ds.Tables(0).Rows(0).Item(0)
            txtNama.Text = ds.Tables(0).Rows(0).Item(1)
            txtAlamat.Text = ds.Tables(0).Rows(0).Item(2)
            txtKota.Text = ds.Tables(0).Rows(0).Item(3)
            txtTelepon.Text = ds.Tables(0).Rows(0).Item(4)
            'txtKode.Text = ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(0)
            'txtNama.Text = ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(1)
            'txtAlamat.Text = ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(2)
            'txtKota.Text = ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(3)
            'txtTelepon.Text = ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(4)
            If frmMasterSupplier.mode = 0 Then
                txtKode.Enabled = True
            End If
            conn.Close()

        Else
            lblTambah.Text = "Tambah"
            txtKode.Enabled = True
            txtKode.Clear()
            txtNama.Clear()
            txtAlamat.Clear()
            txtKota.Clear()
            txtTelepon.Clear()
            txtKode.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            If txtKode.Text = "" Then
                MsgBox("Kode Supplier harus diisi")
            Else
                If frmMasterSupplier.mode = 0 Then
                    ds = New DataSet
                    cmd.CommandText = "select * from tsupplier"
                    adap.SelectCommand = cmd
                    adap.Fill(ds)
                    builder = New SqlCommandBuilder(adap)

                    Dim ro As DataRow
                    ro = ds.Tables(0).NewRow
                    ro(0) = txtKode.Text
                    ro(1) = txtNama.Text
                    ro(2) = txtAlamat.Text
                    ro(3) = txtKota.Text
                    ro(4) = txtTelepon.Text
                    'ro(5) = Date.Now.Date
                    'ro(6) = Date.Now.Date

                    Try
                        ds.Tables(0).Rows.Add(ro)
                        adap.Update(ds.Tables(0))
                        frmMasterSupplier.tampil()
                        Me.Close()
                        _rjcommon.isilog(_rjcommon.getusername, txtKode.Text, "Master Supplier", "Tambah Data", "")
                        _rjcommon.shownotify("Data berhasil ditambah")
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Data Supplier tidak berhasil ditambahkan")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtKode.Text, "Master Supplier", "Tambah Data", ex.Message)
                    End Try
                Else


                    Try
                        'ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(1) = txtNama.Text
                        'ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(2) = txtAlamat.Text
                        'ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(3) = txtKota.Text
                        'ds.Tables(0).Rows(frmMasterSupplier.indekx).Item(4) = txtTelepon.Text
                        'adap.Update(ds.Tables(0))
                        'jun 24 maret 2015
                        Dim cmd As New SqlCommand
                        cmd.Connection = conn
                        cmd.CommandText = "update tsupplier set namasupplier=@namasupplier,alamatsupplier=@alamatsupplier,kotasupplier=@kotasupplier where kodesupplier=@kodesupplier"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@kodesupplier", txtKode.Text)
                        cmd.Parameters.AddWithValue("@namasupplier", txtNama.Text)
                        cmd.Parameters.AddWithValue("@alamatsupplier", txtAlamat.Text)
                        cmd.Parameters.AddWithValue("@kotasupplier", txtKota.Text)
                        If conn.State <> ConnectionState.Open Then
                            conn.Open()
                        End If
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        _rjcommon.isilog(_rjcommon.getusername, txtKode.Text, "Master Supplier", "Update Data", "")
                        _rjcommon.shownotify("Data berhasil diubah")
                        Me.Close()
                        frmMasterSupplier.tampil()
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Data Supplier tidak berhasil diubah")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, txtKode.Text, "Master Supplier", "Update Data", ex.Message)
                    End Try
                End If
            End If
        Else
            MsgBox("Inputan Ada Yang Salah !")
        End If


    End Sub

    Private Sub frmSupplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class