Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMasterSupplier
    Dim _rjcommon As New RJCommon
    Dim konek As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(konek)
    Dim cmd As New SqlCommand
    Dim adap As New SqlDataAdapter
    Dim ds As New DataSet
    Dim builder As New SqlCommandBuilder
    Dim btnUbah As New DataGridViewButtonColumn()
    Dim btnHapus As New DataGridViewButtonColumn()
    Public mode As Integer
    Public kode As String
    Public indekx As Integer

    Sub tampil()
        ds = New DataSet
        cmd = New SqlCommand("select * from [tsupplier] where kodesupplier<>'valent'", conn)
        adap.SelectCommand = cmd
        adap.Fill(ds)
        dgvSupplier.DataSource = ds.Tables(0)
        dgvSupplier.Refresh()
        lblJumlahData.Text = "Jumlah Data: " & ds.Tables(0).Rows.Count

    End Sub


    Private Sub frmMasterSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dgvSupplier.Columns.Count < 9 Then
            'jun 17 oktober 2014
            btnUbah.FlatStyle = FlatStyle.Standard
            dgvSupplier.Columns.Add(btnUbah)
            btnUbah.Width = 45
            btnUbah.Text = "Ubah"
            btnUbah.UseColumnTextForButtonValue = True

            btnHapus.FlatStyle = FlatStyle.Standard
            dgvSupplier.Columns.Add(btnHapus)
            btnHapus.Width = 45
            btnHapus.Text = "Hapus"
            btnHapus.UseColumnTextForButtonValue = True

            dgvSupplier.ReadOnly = True
            dgvSupplier.Columns.Item(7).HeaderText = "Ubah"
            dgvSupplier.Columns.Item(8).HeaderText = "Hapus"
        End If
        tampil()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        mode = 0
        frmDetailSupplier.ShowDialog()
        frmDetailSupplier.lblTambah.Text = "Tambah"
    End Sub

    Private Sub dgvSupplier_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 0 Then
                mode = 1
                kode = dgvSupplier.Item(2, e.RowIndex).Value
                indekx = e.RowIndex
                frmDetailSupplier.ShowDialog()
                frmDetailSupplier.lblTambah.Text = "Ubah"
            End If
            If e.ColumnIndex = 1 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
                    If ConnectionState.Open = True Then
                        conn.Close()
                    Else
                        conn.Open()
                    End If
                    Try
                        Dim tempPrimary As String = dgvSupplier.Item(2, e.RowIndex).Value.ToString
                        Dim cmd = New SqlCommand("delete from tSupplier where kodesupplier='" & dgvSupplier.Item(2, e.RowIndex).Value & "'", conn)
                        'jun  17 oktober 2014
                        'MsgBox(dgvSupplier.Item(2, e.RowIndex).Value)
                        cmd.ExecuteNonQuery()
                        _rjcommon.isilog(_rjcommon.getusername, tempPrimary, "Master Supplier", "Hapus Data", " ")
                    Catch ex As Exception
                        _rjcommon.shownotifyerror("Data Supplier gagal dihapus")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvSupplier.Item(2, e.RowIndex).Value.ToString, "Master Supplier", "Hapus Data", ex.Message)
                    End Try
                    conn.Close()
                    tampil()
                End If
            End If
        End If
    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        If ConnectionState.Open = True Then
            conn.Close()
        Else
            conn.Open()
        End If
        Try
            Dim ds = New DataSet
            Dim cmd = New SqlCommand("select kodesupplier, namasupplier, alamatsupplier, kotasupplier, telpsupplier from tSupplier where kodesupplier<>'valent' and upper(namasupplier) like '%" & txtNama.Text.ToUpper & "%' and upper(kotasupplier) like '%" & txtKota.Text.ToUpper & "%'")
            cmd.Connection = conn
            Dim adp As New SqlDataAdapter
            adp.SelectCommand = cmd
            adp.Fill(ds, "tSupplier")
            dgvSupplier.DataSource = ds.Tables("tSupplier")
            'jun 17 oktober 2014
            lblJumlahData.Text = "Jumlah Data: " & ds.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama.TextChanged
        btnfilter_Click(sender, e)
    End Sub

    Private Sub txtKota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKota.TextChanged
        btnfilter_Click(sender, e)
    End Sub

End Class