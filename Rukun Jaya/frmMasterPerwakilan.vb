Imports RjLibrary

Imports System.Data
Imports System.Data.SqlClient

Public Class frmMasterPerwakilan
    'sambung server
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr)
    'Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & CurDir() & "\dbrk.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim comm As New SqlCommand("", conn)
    Dim adp As New SqlDataAdapter
    Dim dts As New DataSet
    Dim bld As New SqlCommandBuilder
    Public edit As Boolean = False
    Public indexrow As Int16
    Public kodeper As String

    Private Sub frmMasterPerwakilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tPerwakilan' table. You can move, or remove it, as needed.
        'Me.TPerwakilanTableAdapter.Fill(Me.DataSet1.tPerwakilan)
        Call loadd()

        'If conn.State <> ConnectionState.Open Then
        '    conn.Open()
        'End If
        'comm.CommandText = "select * from tPerwakilan"
        'adp.SelectCommand = comm
        'adp.Fill(DataSet1, "tPerwakilan")
        'DataGridView1.DataSource = DataSet1.Tables(0)

        DGVPerwakilan.Refresh()
    End Sub

    Sub loadd()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        'comm.CommandText = "select * from tPerwakilan"
        'adp.SelectCommand = comm
        'adp.Fill(dts)
        'DataGridView1.DataSource = dts.Tables(0)
        'DataGridView1.Refresh()
        'jun 17 oktober 2014 header rusak
        Call refreshgrid()
        'jun 2 januari 2015
        'DGVPerwakilan.Columns.RemoveAt(9)
        'DGVPerwakilan.Columns.RemoveAt(8)
        'DGVPerwakilan.Columns.RemoveAt(4)
        'DGVPerwakilan.Columns.RemoveAt(2)
        'jun
        'DGVPerwakilan.Columns.RemoveAt(1)
        'DGVPerwakilan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        DGVPerwakilan.Columns(0).Width = 80
        DGVPerwakilan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVPerwakilan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader

        Dim btn As New DataGridViewButtonColumn()
        DGVPerwakilan.Columns.Add(btn)
        btn.Width = 45
        btn.FlatStyle = FlatStyle.Standard
        btn.HeaderText = "Ubah"
        btn.Text = "Ubah"
        btn.Name = "btnUbah"
        btn.UseColumnTextForButtonValue = True

        btn = New DataGridViewButtonColumn
        DGVPerwakilan.Columns.Add(btn)
        btn.Width = 45
        btn.FlatStyle = FlatStyle.Standard
        btn.HeaderText = "Hapus"
        btn.Text = "Hapus"
        btn.Name = "btnHapus"
        btn.UseColumnTextForButtonValue = True

        DGVPerwakilan.Columns(DGVPerwakilan.ColumnCount - 2).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DGVPerwakilan.Columns(DGVPerwakilan.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
    End Sub

    Sub refreshgrid()
        dts.Clear()
        'jun 2 januari 2015
        Dim query As String = "select kodeperwakilan as Kode,namaperwakilan as Nama,Kota,Telp,HP,Keterangan from tperwakilan"
        'Dim query As String = "Select * from tperwakilan"
        comm.CommandText = query
        adp.SelectCommand = comm
        adp.Fill(dts)
        DGVPerwakilan.DataSource = dts.Tables(0)
        DGVPerwakilan.Refresh()
        lblJumlahData.Text = "Jumlah Data : " & dts.Tables(0).Rows.Count
    End Sub

    Sub cari(ByVal car)
        dts.Clear()
        Dim query As String = "select kodeperwakilan as Kode,namaperwakilan as Nama,Kota,Telp,HP,Keterangan from tperwakilan where NamaPerwakilan like '%" & car & "%'"
        comm.CommandText = query

        adp.SelectCommand = comm

        adp.Fill(dts)
        DGVPerwakilan.DataSource = dts.Tables(0)
        DGVPerwakilan.Refresh()
        lblJumlahData.Text = "Jumlah Data : " & dts.Tables(0).Rows.Count
    End Sub

    'Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim dts1 As New DataSet
    '    'Dim adp1 As New SqlDataAdapter

    '    'comm.CommandText = "select * from tPerwakilan where NamaPerwakilan like '%" & txtFilter.Text & "%'"
    '    'adp1.SelectCommand = comm
    '    'adp1.Fill(dts1)
    '    'DataGridView1.DataSource = dts1.Tables(0)
    '    'DataGridView1.Refresh()
    '    comm.CommandText = "select * from tPerwakilan where NamaPerwakilan like '%" & txtFilter.Text & "%'"
    '    adp.SelectCommand = comm
    '    adp.Fill(dts)
    '    DataGridView1.Refresh()
    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPerwakilan.CellContentClick

        'jun 13 feb 2015
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = DGVPerwakilan.ColumnCount - 2 Then
                frmDetailPerwakilan.edit = True
                indexrow = e.RowIndex
                frmDetailPerwakilan.kodeper = DGVPerwakilan.Item(0, e.RowIndex).Value
                frmDetailPerwakilan.ShowDialog()
                refreshgrid()
                'DGVPerwakilan.Refresh()
                'Call refreshgrid()
                'edit = False
            ElseIf e.ColumnIndex = DGVPerwakilan.ColumnCount - 1 Then
                If MsgBox("Apakah Anda Yakin Menghapus Data ?", MsgBoxStyle.YesNo, "Confirmasi Hapus") = MsgBoxResult.Yes Then
                    Try
                        comm.Parameters.Clear()
                        comm.CommandText = "delete from tPerwakilan where KodePerwakilan=@1"
                        ' comm.Parameters.AddWithValue("@1", dts.Tables(0).Rows(e.RowIndex).Item(0))
                        'jun 19 jan 2015
                        comm.Parameters.AddWithValue("@1", DGVPerwakilan.Rows(e.RowIndex).Cells("kode").Value)
                        comm.ExecuteNonQuery()

                        'MsgBox("Data Berhasil Dihapus")
                        _rjcommon.shownotify("Data Berhasil Dihapus")
                        _rjcommon.isilog(_rjcommon.getusername, dts.Tables(0).Rows(e.RowIndex).Item(0), "Master Perwakilan", "Hapus Data", "")
                        'jun 20 oktober 2014
                        Call refreshgrid()
                    Catch ex As Exception
                        'jun 17 oktober 2014
                        MsgBox("Data Tidak Berhasil Dihapus")
                        _rjcommon.isiErrorlog(_rjcommon.getusername, dts.Tables(0).Rows(e.RowIndex).Item(0), "Master Perwakilan", "Hapus Data", ex.Message)
                    End Try
                End If
            End If
        End If
       
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        frmDetailPerwakilan.edit = False
        frmDetailPerwakilan.ShowDialog()
        refreshgrid()
    End Sub

    Private Sub frmMasterPerwakilan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            If txtFilter.Text = "" Then
                Call refreshgrid()
            Else
                Call cari(txtFilter.Text)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If txtFilter.Text = "" Then
            Call refreshgrid()
        Else
            Call cari(txtFilter.Text)
        End If
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        If txtFilter.Text = "" Then
            Call refreshgrid()
        Else
            Call cari(txtFilter.Text)
        End If
    End Sub
End Class