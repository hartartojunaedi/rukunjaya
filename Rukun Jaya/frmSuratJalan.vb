Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmSuratJalan
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)

    'Function getkodeSupp()
    '    Dim kodesupp As String = ""
    '    Dim command As New SqlCommand
    '    Dim query As String = "select kodesupplier from tsupplier where namasupplier like '%" & txtSupp.Text & "%'"
    '    command.Connection = conn
    '    command.CommandText = query
    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If
    '    conn.Open()
    '    kodesupp = command.ExecuteScalar
    '    Return kodesupp
    'End Function

    'Function getkodePerwakilan()
    '    Dim kodePerwakilan As String = ""
    '    Dim command As New SqlCommand
    '    Dim query As String = "select KodePerwakilan from tPerwakilan where namaPerwakilan like '%" & txtPerwakilan.Text & "%'"
    '    command.Connection = conn
    '    command.CommandText = query
    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If
    '    conn.Open()
    '    kodePerwakilan = command.ExecuteScalar
    '    Return kodePerwakilan
    'End Function

    Public Sub loaddata()
        Try
            Dim queryload As String
            queryload = "select s.noSuratJalan,su.namasupplier,p.namaperwakilan,s.tgl,g.namagudang as asal,gu.namagudang as tujuan,s.noBM from tSuratJalan s,tsupplier su,tPerwakilan p,tGudang g,tGudang gu where p.KodePerwakilan=s.kodeperwakilan and s.kodesupplier=su.kodesupplier and g.kodeGudang=s.asal and gu.kodeGudang=s.tujuan"
            queryload &= " and s.noSuratJalan like '%" & txtNoSJ.Text & "%'"
            queryload &= " and su.namasupplier like '%" & txtSupp.Text & "%'"
            queryload &= " and p.namaperwakilan like '%" & txtPerwakilan.Text() & "%'"
            queryload &= " and s.tgl >= @tgl1 and s.tgl <= @tgl2"

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = queryload
            cmd.Parameters.AddWithValue("@tgl1", dtMulai.Value)
            cmd.Parameters.AddWithValue("@tgl2", dtSampai.Value)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            ds.Clear()
            da.Fill(ds, "sj")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "sj"
            DataGridView1.Refresh()
            DataGridView1.Columns("tgl").DefaultCellStyle.Format = "dd-MM-yyyy"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSuratJalan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        loaddata()
    End Sub

    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtSupp.TextChanged, txtPerwakilan.TextChanged, txtNoSJ.TextChanged, dtMulai.ValueChanged, dtSampai.ValueChanged
        loaddata()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.ColumnIndex = DataGridView1.Columns("detail").Index) And e.RowIndex >= 0 Then
            Dim a As New frmDetailSJ
            a.kodeSJ = DataGridView1.Rows(e.RowIndex).Cells("noSJ").Value
            a.kodeBMdrSJ = DataGridView1.Rows(e.RowIndex).Cells("noBM").Value
            a.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class