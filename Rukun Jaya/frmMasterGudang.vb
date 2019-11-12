Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmMasterGudang
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    Private Sub frmMasterGudang_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Public Sub loaddata()
        Dim da As New SqlDataAdapter("select * from tgudang order by kodegudang", conn)
        ds.Clear()
        da.Fill(ds, "gudang")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "gudang"
        DataGridView1.Refresh()
        Label1.Text = "Jumlah Data : " + ds.Tables("gudang").Rows.Count.ToString
    End Sub
    Private Sub frmMasterGudang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("ubah").Index) And e.RowIndex >= 0 Then
            frmDetailMasterGudang.txtKodeGudang.Text = DataGridView1.Rows(e.RowIndex).Cells("kodegudang").Value
            frmDetailMasterGudang.mode = 1
            frmDetailMasterGudang.ShowDialog()
            loaddata()
        Else
            If (e.ColumnIndex = DataGridView1.Columns("hapus").Index) And e.RowIndex >= 0 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ? ", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    Dim command As New SqlCommand
                    command.Connection = conn
                    command.CommandType = CommandType.Text
                    command.CommandText = "Delete tgudang where kodegudang=@kodegudang"
                    command.Parameters.Add(New SqlParameter("@kodegudang", DataGridView1.Rows(e.RowIndex).Cells("kodegudang").Value))
                    conn.Open()
                    Try
                        command.ExecuteNonQuery()
                        _rjcommon.isilog(_rjcommon.getusername, DataGridView1.Rows(e.RowIndex).Cells("kodegudang").Value, "Master Gudang", "Hapus Data", "")
                        _rjcommon.shownotify("Data Berhasil Dihapus ")
                    Catch ex As Exception
                        MsgBox("Data Tidak Dapat Dihapus", MsgBoxStyle.OkOnly, "Information")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, DataGridView1.Rows(e.RowIndex).Cells("kodegudang").Value, "Master Gudang", "Hapus Data", ex.Message)
                    End Try
                    conn.Close()
                    loaddata()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        frmDetailMasterGudang.mode = 0
        frmDetailMasterGudang.ShowDialog()
        loaddata()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class