Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMasterPerusahaan
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

    Private Sub frmMasterPerusahaan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        kode = ""
        If ConnectionState.Open = True Then
            conn.Close()
        Else
            conn.Open()
        End If

        Try
            Dim ds = New DataSet
            adapter("select kodeperusahaan, namaperusahaan, keterangan, holding, prosentase from tPerusahaan").Fill(ds, "tPerusahaan")
            dgvPerusahaan.DataSource = ds.Tables("tPerusahaan")
            adapter("select sum(prosentase) from tPerusahaan").Fill(ds, "jumlah")
            lblProsentase.Text = ds.Tables("jumlah").Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If lblProsentase.Text = "100" Then
            MsgBox("Jumlah prosentase perusahaan sudah 100%")
        Else
            mode = 0
            frmDetailPerusahaan.ShowDialog()
        End If
    End Sub

    Private Sub dgvPerusahaan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPerusahaan.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = 0 Then
                mode = 1
                kode = dgvPerusahaan.Item(2, e.RowIndex).Value
                frmDetailPerusahaan.ShowDialog()
            End If
            If e.ColumnIndex = 1 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    'If ConnectionState.Open = True Then
                    'jun 12 maret 2015
                    If conn.State <> ConnectionState.Open Then
                        '     conn.Close()
                        'Else
                        conn.Open()
                    End If
                    Try
                        Dim tempPrimary As String = dgvPerusahaan.Item(2, e.RowIndex).Value.ToString
                        Dim cmd = New SqlCommand("delete from tPerusahaan where kodeperusahaan='" & dgvPerusahaan.Item(2, e.RowIndex).Value & "'", conn)
                        cmd.ExecuteNonQuery()
                        _rjcommon.shownotify("Perusahaan berhasil dihapus")
                        'jun 16 oktober 2014
                        _rjcommon.isilog(_rjcommon.getusername, tempPrimary, "Master Perusahaan", "Hapus Data", " ")
                    Catch ex As Exception
                        '_rjcommon.shownotifyerror("Perusahaan gagal dihapus")
                        'jun 16 oktober 2014
                        MsgBox("Data Perusahaan gagal dihapus")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dgvPerusahaan.Item(2, e.RowIndex).Value.ToString, "Master Perusahaan", "Hapus Data", ex.Message)
                    End Try
                    conn.Close()
                    frmMasterPerusahaan_Activated(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub frmMasterPerusahaan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If dgvPerusahaan.Columns.Count < 7 Then
            'jun 16 oktober 2014
            'btnUbah.FlatStyle = FlatStyle.Flat
            btnUbah.FlatStyle = FlatStyle.Standard
            dgvPerusahaan.Columns.Add(btnUbah)
            btnUbah.Text = "Ubah"
            'jun 16 oktober 2014
            btnUbah.Width = 45
            btnUbah.UseColumnTextForButtonValue = True
            btnHapus.FlatStyle = FlatStyle.Standard
            'btnHapus.FlatStyle = FlatStyle.Flat
            dgvPerusahaan.Columns.Add(btnHapus)
            btnHapus.Text = "Hapus"
            'jun 16 oktober 2014
            btnHapus.Width = 45
            btnHapus.UseColumnTextForButtonValue = True

            dgvPerusahaan.ReadOnly = True
            'jun 16 oktober 2014
            dgvPerusahaan.Columns.Item(5).HeaderText = "Ubah"
            dgvPerusahaan.Columns.Item(6).HeaderText = "Hapus"
        End If
    End Sub

    Private Sub frmMasterPerusahaan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

End Class