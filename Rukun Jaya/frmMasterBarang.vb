Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMasterBarang
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Public mode As Integer
    Public kode As String
    Dim btnUbah As New DataGridViewButtonColumn()
    Dim btnHapus As New DataGridViewButtonColumn()

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Private Sub frmMasterBarang_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        kode = ""
            conn.Close()
            conn.Open()
        Try
            Dim ds = New DataSet
            adapter("select kodebarang, namabarang, satuan,namapekerjaan from tBarang b,tjenispekerjaan j where b.jenispekerjaan=j.kodejenis").Fill(ds, "tBarang")
            dgvBarang.DataSource = ds.Tables("tBarang")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub frmMasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dgvBarang.Columns.Count < 5 Then
            'jun 17 oktober 2014
            dgvBarang.AutoGenerateColumns = False
            btnUbah.FlatStyle = FlatStyle.Standard
            dgvBarang.Columns.Add(btnUbah)
            btnUbah.Text = "Ubah"
            btnUbah.Width = 45
            btnUbah.UseColumnTextForButtonValue = True

            btnHapus.FlatStyle = FlatStyle.Standard
            dgvBarang.Columns.Add(btnHapus)
            btnHapus.Width = 45
            btnHapus.Text = "Hapus"
            btnHapus.UseColumnTextForButtonValue = True

            dgvBarang.ReadOnly = True
            'jun 13 feb 2015
            dgvBarang.Columns.Item(4).HeaderText = "Ubah"
            dgvBarang.Columns.Item(5).HeaderText = "Hapus"
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click, txtCari.TextChanged
        If ConnectionState.Open = True Then
            conn.Close()
        Else
            conn.Open()
        End If
        Try
            Dim ds = New DataSet
            'jun 13 feb 2015
            adapter("select kodebarang, namabarang, satuan,j.namapekerjaan from tBarang b,tjenispekerjaan j where b.jenispekerjaan=j.kodejenis and  upper(namabarang) like '%" & txtCari.Text.ToUpper & "%'").Fill(ds, "tBarang")
            dgvBarang.DataSource = ds.Tables("tBarang")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        mode = 0
        frmDetailBarang.ShowDialog()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 4 Then
                mode = 1
                kode = dgvBarang.Item(0, e.RowIndex).Value
                frmDetailBarang.ShowDialog()
            End If
            If e.ColumnIndex = 5 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    If ConnectionState.Open = True Then
                        conn.Close()
                    Else
                        conn.Open()
                    End If
                    Try
                        Dim cmd = New SqlCommand("delete from tBarang where kodebarang='" & dgvBarang.Item(0, e.RowIndex).Value.Replace(" ", "") & "'", conn)
                        'MsgBox("delete from tBarang where kodebarang='" & dgvBarang.Item(2, e.RowIndex).Value & "'")
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Barang berhasil dihapus")
                        'jun 17 oktober 2014
                        _rjcommon.isilog(_rjcommon.getusername, dgvBarang.Item(0, e.RowIndex).Value, "Master Barang", "Hapus Data", "")
                    Catch ex As Exception
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvBarang.Item(0, e.RowIndex).Value, "Master Barang", "Hapus data", ex.Message)
                        '_rjcommon.shownotifyerror("Barang gagal dihapus")
                        MsgBox("Barang gagal dihapus")
                    End Try
                    conn.Close()
                    frmMasterBarang_Activated(sender, e)
                End If
            End If
        End If
    End Sub


    Private Sub dgvBarang_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBarang.CellContentClick

    End Sub
End Class