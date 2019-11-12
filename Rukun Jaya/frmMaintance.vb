Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMaintance
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim ds As DataSet
    Dim btnUbahDgv As New DataGridViewButtonColumn()
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim idx
    Public start

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Public Sub refreshdata()
        ds = New DataSet
        adapter("select kodemaintance,nolambung,namapekerjaan,tukang,m.keterangan,m.rutin,biaya,convert(varchar,tgl,105) as tgl,km,Kerusakan,Tindakan1,Tindakan2,Tindakan3,Tindakan4,Tindakan5 from tmaintance m,tjenismaintance j where m.kodejenismaintance=j.kodejenismaintance order by m.tgl desc").Fill(ds, "tmaintance")
        dgvmastermaintance.DataSource = ds.Tables("tmaintance")
    End Sub

    Private Sub frmMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnUbahDgv.FlatStyle = FlatStyle.Flat
            dgvmastermaintance.Columns.Add(btnUbahDgv)
            btnUbahDgv.Text = "Ubah"
            btnUbahDgv.HeaderText = "Ubah Data"
            btnUbahDgv.UseColumnTextForButtonValue = True

            btnHapusDgv.FlatStyle = FlatStyle.Flat
            dgvmastermaintance.Columns.Add(btnHapusDgv)
            btnHapusDgv.Text = "Hapus"
            btnHapusDgv.HeaderText = "Hapus Data"
            btnHapusDgv.UseColumnTextForButtonValue = True
            conn.Open()
            refreshdata()
            conn.Close()
            start = 0
            cmbrutin.SelectedIndex = 0
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Private Sub dgvmastermaintance_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmastermaintance.CellClick
        ' MsgBox("hallo")
        Dim id = dgvmastermaintance.Rows(e.RowIndex).Cells(2).Value
        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            conn.Open()
            start = 1
            Dim frmDetailMaintance As New frmDetailMaintance
            frmDetailMaintance.txtKodeMaintance.ReadOnly = True
            frmDetailMaintance.btnUpdate.Visible = False
            frmDetailMaintance.txtKodeMaintance.Text = ds.Tables("tmaintance").Rows(e.RowIndex)(0)
            frmDetailMaintance.txttukang.Text = ds.Tables("tmaintance").Rows(e.RowIndex)(3)
            frmDetailMaintance.txtbiaya.Text = CInt(FormatCurrency(ds.Tables("tmaintance").Rows(e.RowIndex)(6), 0, , , ))
            frmDetailMaintance.cmbNamaPekerjaan.Text = ds.Tables("tmaintance").Rows(e.RowIndex)(2)



            frmDetailMaintance.nmpekerjaantemp = dgvmastermaintance.Rows(e.RowIndex).Cells("NamaPekerjaan").Value.ToString
            frmDetailMaintance.nopoltemp = dgvmastermaintance.Rows(e.RowIndex).Cells("nolambung").Value.ToString
            ' MsgBox(dgvmastermaintance.Rows(e.RowIndex).Cells("nolambung").Value.ToString)
            frmDetailMaintance.TextBox1.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("kerusakan").Value.ToString
            frmDetailMaintance.TextBox2.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("tindakan1").Value.ToString
            frmDetailMaintance.TextBox3.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("tindakan2").Value.ToString
            frmDetailMaintance.TextBox4.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("tindakan3").Value.ToString
            frmDetailMaintance.TextBox5.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("tindakan4").Value.ToString
            frmDetailMaintance.TextBox6.Text = dgvmastermaintance.Rows(e.RowIndex).Cells("tindakan5").Value.ToString



            frmDetailMaintance.txtkilometer.Text = ds.Tables("tmaintance").Rows(e.RowIndex)(8)

            If ds.Tables("tmaintance").Rows(e.RowIndex)(5) = "True" Then
                frmDetailMaintance.cbkrutin.Checked = True
            Else
                frmDetailMaintance.cbktidakrutin.Checked = True
            End If
            frmDetailMaintance.cmbnolambung.Items.Clear()
            Dim rd = New SqlCommand("select * from tkendaraan", conn).ExecuteReader
            While rd.Read
                frmDetailMaintance.cmbnolambung.Items.Add(rd("nopol"))
            End While
            rd.Close()
            Dim result = New SqlCommand("select nopol from tkendaraan where nolambung='" & ds.Tables("tmaintance").Rows(e.RowIndex)(1) & "'", conn).ExecuteScalar
            '  idx = frmDetailMaintance.cmbnolambung.FindString(result)
            ' MsgBox(result)
            frmDetailMaintance.nopoltemp = result

            Dim getdate = New SqlCommand("select tgl from tmaintance where kodemaintance ='" & ds.Tables("tmaintance").Rows(e.RowIndex)(0) & "' ", conn).ExecuteScalar
            frmDetailMaintance.dtptglmaintance.Value = getdate


            frmDetailMaintance.txtketerangan.Text = ds.Tables("tmaintance").Rows(e.RowIndex)(4)
            conn.Close()
            frmDetailMaintance.ShowDialog()
        ElseIf e.RowIndex > -1 And e.ColumnIndex = 1 Then
            Dim arrkode As New ArrayList
            Dim arrjum As New ArrayList
            Try
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    conn.Open()
                    Dim rd = New SqlCommand("select kodesparepart,jumlah from tdetailmaintance where kodemaintance='" & id & "'", conn).ExecuteReader
                    While rd.Read
                        arrkode.Add(rd(0))
                        arrjum.Add(rd(1))
                    End While
                    rd.Close()
                    conn.Close()

                    For i = 0 To arrkode.Count - 1
                        If arrkode(i) <> "" Then
                            conn.Open()
                            Dim stock = New SqlCommand("select stock from tsparepart where kodesparepart='" & arrkode(i) & "'", conn).ExecuteScalar
                            Dim total = stock + Int(arrjum(i))
                            Dim comd = New SqlCommand("update tsparepart set stock=@stock where kodesparepart=@kodesparepart", conn)
                            comd.Parameters.AddWithValue("@kodesparepart", arrkode(i))
                            comd.Parameters.AddWithValue("@stock", total)
                            comd.ExecuteNonQuery()
                            conn.Close()
                        End If
                    Next
                    conn.Open()
                    Dim cmd = New SqlCommand("delete from tdetailmaintance where kodemaintance='" & id & "'", conn)
                    cmd.ExecuteNonQuery()
                    cmd = New SqlCommand("delete from tmaintance where kodemaintance='" & id & "'", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    refreshdata()
                    conn.Open()
                    _rjcommon.shownotify("Transaksi Maintance berhasil dihapus")
                    _rjcommon.isilog(_rjcommon.getusername, id, "Transaksi Maintance", "Hapus Data", "")
                    conn.Close()
                End If
            Catch ex As Exception
                ex.ToString()
                _rjcommon.shownotify("Transaksi Maintance gagal dihapus")
                _rjcommon.isiErrorlog(_rjcommon.getusername, id, "Transaksi Maintance", "Hapus Data", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub frmMaintance_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        conn.Open()
        refreshdata()
        frmDetailMaintance.refreshdata()
        conn.Close()
    End Sub

    Private Sub frmMaintance_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Open()
        frmDetailMaintance.refreshdata()
        conn.Close()
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click, txttukang.TextChanged, txtnamapekerjaan.TextChanged, txtcarinolambung.TextChanged, cmbrutin.SelectedValueChanged, cbkrutin.CheckedChanged
        'If txtcarinolambung.Text = "" And txtnamapekerjaan.Text = "" And txttukang.Text = "" Then
        'refreshdata()
        'Else
        conn.Open()
        ds = New DataSet
        Dim rutinvalue As Boolean
        If cmbrutin.SelectedIndex = 0 Then rutinvalue = True
        If cmbrutin.SelectedIndex = 1 Then rutinvalue = False
        If cbkrutin.Checked = True Then
            adapter("select kodemaintance,nolambung,namapekerjaan,tukang,m.keterangan,m.rutin,biaya,convert(varchar,tgl,105) as tgl,km,Kerusakan,Tindakan1,Tindakan2,Tindakan3,Tindakan4,Tindakan5 from tmaintance m,tjenismaintance j where m.kodejenismaintance=j.kodejenismaintance and nolambung like '%" & txtcarinolambung.Text & "%' and namapekerjaan like '%" & txtnamapekerjaan.Text & "%' and tukang like '%" & txttukang.Text & "%' and m.rutin  ='" & rutinvalue & "'").Fill(ds, "tmaintance")
        Else
            adapter("select kodemaintance,nolambung,namapekerjaan,tukang,m.keterangan,m.rutin,biaya,convert(varchar,tgl,105) as tgl,km,Kerusakan,Tindakan1,Tindakan2,Tindakan3,Tindakan4,Tindakan5 from tmaintance m,tjenismaintance j where m.kodejenismaintance=j.kodejenismaintance and nolambung like '%" & txtcarinolambung.Text & "%' and namapekerjaan like '%" & txtnamapekerjaan.Text & "%' and tukang like '%" & txttukang.Text & "%'").Fill(ds, "tmaintance")
        End If

        dgvmastermaintance.DataSource = ds.Tables("tmaintance")
        conn.Close()
        'End If
    End Sub

    Private Sub dgvmastermaintance_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmastermaintance.CellContentClick

    End Sub
End Class