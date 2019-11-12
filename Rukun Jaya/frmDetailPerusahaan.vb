Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailPerusahaan
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim cekHolding As Boolean = True
    Dim cekProsentase As Boolean = True
    Dim prosentase As Integer

    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(txtKodePerusahaan.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Perusahaan Harus Diisi")
        End If
        If Trim(txtNamaPerusahaan.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Nama Perusahaan Harus Diisi ")
        End If
        Return flag
    End Function
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub frmDetailPerusahaan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If frmMasterPerusahaan.mode = 0 Then
            txtKodePerusahaan.Enabled = True
            txtKodePerusahaan.Focus()
        Else
            txtKodePerusahaan.Enabled = False
        End If
    End Sub

    Private Sub frmDetailPerusahaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prosentase = 0
        If frmMasterPerusahaan.kode <> "" Then
            If ConnectionState.Open = True Then
                conn.Close()
            Else
                conn.Open()
            End If
            Dim ds = New DataSet
            adapter("select * from tPerusahaan where kodeperusahaan = '" & frmMasterPerusahaan.kode & "'").Fill(ds, "tPerusahaan")
            txtKodePerusahaan.Text = ds.Tables("tPerusahaan").Rows(0).Item(0).ToString
            txtNamaPerusahaan.Text = ds.Tables("tPerusahaan").Rows(0).Item(1).ToString
            txtKeterangan.Text = ds.Tables("tPerusahaan").Rows(0).Item(2).ToString
            cbkHolding.Checked = ds.Tables("tPerusahaan").Rows(0).Item(3).ToString
            nudProsentase.Value = ds.Tables("tPerusahaan").Rows(0).Item(4).ToString
            prosentase = ds.Tables("tPerusahaan").Rows(0).Item(4)
            conn.Close()
            If cbkHolding.Checked Then
                nudProsentase.Value = 0
                nudProsentase.Enabled = False
            Else
                nudProsentase.Enabled = True
            End If
        Else
            txtKodePerusahaan.Clear()
            txtNamaPerusahaan.Clear()
            txtKeterangan.Clear()
            nudProsentase.Value = 0
            cbkHolding.Checked = False
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            'jun 12 maret 2015
            ' If nudProsentase.Value = vbEmpty Then
            If nudProsentase.Value < 0 Then
                MsgBox("Prosentase harap diisi")
            Else
                If frmMasterPerusahaan.mode = 0 Then
                    cekHolding = True
                    cekProsentase = True
                    If cbkHolding.Checked = True Then
                        If MsgBox("Perusahaan ini yang menjadi holding?", MsgBoxStyle.YesNo, "Confirmasi Holding") = MsgBoxResult.Yes Then
                            cekHolding = True
                            If ConnectionState.Open = True Then
                                conn.Close()
                            Else
                                conn.Open()
                            End If
                            Try
                                Dim cmd = New SqlCommand("update tPerusahaan set holding='false' where holding='true'", conn)
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox("Tidak dapat mengganti perusahaan holding")
                            End Try
                            conn.Close()
                        Else
                            cekHolding = False
                        End If
                    End If

                    If ConnectionState.Open = True Then
                        conn.Close()
                    Else
                        conn.Open()
                    End If
                    Dim ds = New DataSet
                    'jun 10-12-2014

                    adapter("select isnull(sum(prosentase),0) from tPerusahaan").Fill(ds, "jumlah")

                    If ds.Tables("jumlah").Rows(0).Item(0) + nudProsentase.Value > 100 Then
                        cekProsentase = False
                        MsgBox("Prsosentase melebihi 100%")
                    Else
                        cekProsentase = True
                    End If

                    conn.Close()

                    If cekHolding And cekProsentase Then
                        If ConnectionState.Open = True Then
                            conn.Close()
                        Else
                            conn.Open()
                        End If
                        Try
                            ' Dim cmd = New SqlCommand("insert into tPerusahaan values(@a,@b,@c,@d,@e,@f,@g)", conn)
                            'jun 17 oktober 2014
                            Dim cmd = New SqlCommand("insert into tPerusahaan (kodeperusahaan,namaperusahaan,keterangan,holding,prosentase)values(@kodeperusahaan,@namaperusahaan,@keterangan,@holding,@prosentase)", conn)
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@kodeperusahaan", txtKodePerusahaan.Text)
                            cmd.Parameters.AddWithValue("@namaperusahaan", txtNamaPerusahaan.Text)
                            cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)
                            cmd.Parameters.AddWithValue("@holding", cbkHolding.Checked)
                            cmd.Parameters.AddWithValue("@prosentase", nudProsentase.Value)
                            'cmd.Parameters.AddWithValue("@f", Now)
                            'cmd.Parameters.AddWithValue("@g", Now)
                            cmd.ExecuteNonQuery()
                            _rjcommon.shownotify("Perusahaan berhasil ditambahkan")
                            _rjcommon.isilog(_rjcommon.getusername, txtKodePerusahaan.Text, "Master Perusahaan", "Tambah Data", " ")
                        Catch ex As Exception
                            _rjcommon.shownotifyerror("Perusahaan gagal ditambahakan")
                            MsgBox("Perusahaan gagal ditambahakan")
                            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodePerusahaan.Text, "Master Perusahaan", "Tambah Data", ex.Message)
                        End Try
                        conn.Close()
                    End If
                    Me.Close()
                Else
                    cekHolding = True
                    cekProsentase = True
                    If cbkHolding.Checked = True Then
                        If MsgBox("Perusahaan ini yang menjadi holding?", MsgBoxStyle.YesNo, "Confirmasi Holding") = MsgBoxResult.Yes Then
                            cekHolding = True
                            If ConnectionState.Open = True Then
                                conn.Close()
                            Else
                                conn.Open()
                            End If
                            Try
                                Dim cmd = New SqlCommand("update tPerusahaan set holding='false' where holding='true'", conn)
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            conn.Close()
                        Else
                            cekHolding = False
                        End If
                    End If

                    If ConnectionState.Open = True Then
                        conn.Close()
                    Else
                        conn.Open()
                    End If
                    Dim ds = New DataSet
                    adapter("select sum(prosentase) from tPerusahaan").Fill(ds, "jumlah")
                    If ds.Tables("jumlah").Rows(0).Item(0) - prosentase + nudProsentase.Value > 100 Then
                        cekProsentase = False
                        MsgBox("Prsosentase melebihi 100%")
                    Else
                        cekProsentase = True
                    End If
                    conn.Close()

                    If cekHolding And cekProsentase Then
                        If ConnectionState.Open = True Then
                            conn.Close()
                        Else
                            conn.Open()
                        End If
                        Try
                            Dim cmd = New SqlCommand("update tPerusahaan set namaperusahaan = '" & txtNamaPerusahaan.Text & "', keterangan = '" & txtKeterangan.Text & "', holding = '" & cbkHolding.Checked & "', prosentase = " & nudProsentase.Value & " where kodeperusahaan = '" & txtKodePerusahaan.Text & "'", conn)
                            cmd.ExecuteNonQuery()
                            _rjcommon.shownotify("Detail perusahaan berhasil diubah")
                            _rjcommon.isilog(_rjcommon.getusername, txtKodePerusahaan.Text, "Master Perusahaan", "Update Data", " ")
                        Catch ex As Exception
                            _rjcommon.shownotifyerror("Perusahaan gagal diubah")
                            MsgBox("Perusahaan gagal diubah")
                            _rjcommon.isiErrorlog(_rjcommon.getusername, txtKodePerusahaan.Text, "Master Perusahaan", "Update Data", ex.Message)
                        End Try
                        conn.Close()
                    End If
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Ada Isian Yang Salah")
        End If
    End Sub

    Private Sub cbkHolding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkHolding.CheckedChanged
        If cbkHolding.Checked Then
            nudProsentase.Value = 0
            nudProsentase.Enabled = False
        Else
            nudProsentase.Value = prosentase
            nudProsentase.Enabled = True
        End If
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub nudProsentase_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nudProsentase.KeyUp
        If nudProsentase.Value < 0 Or nudProsentase.Value > 100 Then

        End If
    End Sub

    Private Sub frmDetailPerusahaan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
End Class