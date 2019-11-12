Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmTotalanAkhirBaru
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New rjLib
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim ds As New DataSet
    Dim init As Boolean = True
    Public Sub awal()
        init = True
        txtkodesopir.Text = ""
        init = False
    End Sub
    Private Sub frmTotalanAkhirBaru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub
    Private Sub ambilsopir()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        If txtkodesopir.Text <> "" Then
            Dim cmd As New SqlCommand("", conn)
            cmd.Parameters.Clear()
            cmd.CommandText = "Select namasopir from tsopir where kodesopir='" & txtkodesopir.Text & "'"

            Try
                Dim namasopir As String = cmd.ExecuteScalar
                If namasopir = "" Then
                    _rjcommon.shownotifyerror("Sopir Tidak Ditemukan")
                Else
                    lblnamasopir.Text = namasopir
                End If
            Catch ex As Exception

            End Try
            conn.Close()
        End If

    End Sub
    Private Sub cleartotalan()
        ds.Tables("totalan").Clear()
        dgtotalan.DataSource = ds
        dgtotalan.DataMember = "totalan"
        dgtotalan.Refresh()
        'hitungtotal()
    End Sub

    Public Sub ambiltotalan()
        If init = False Then
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            cmd.CommandText = " Select h.nototalan,h.diterima,h.tanggal "
            cmd.CommandText &= " from thtotalan h "
            cmd.CommandText &= " where h.status=0 and h.kodesopir='" & txtkodesopir.Text & "'"
            cmd.CommandText &= " order by h.tanggal"
            'status=0 artinya belum diproses totalan
            cmd.Connection = conn
            da.SelectCommand = cmd
            da.Fill(ds, "totalan")
            dgvTotalan.AutoGenerateColumns = False
            dgvTotalan.DataSource = ds
            dgvTotalan.DataMember = "totalan"
            dgvTotalan.Refresh()
            'refreshtotalan()
            'hitungsemua()
        End If
    End Sub
    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btncari.Click
        frmBrowsesopir.asal = 4
        frmBrowsesopir.ShowDialog()
        ambilsopir()
        ambiltotalan()
        'ambilkasbon()
        ' cleartotalan()
    End Sub
    Public Function cektotalan(nototalan As String) As Boolean

        Dim flag As Boolean = True
        For i As Integer = 0 To ds.Tables("totalan").Rows.Count - 1
            If ds.Tables("totalan").Rows(i).Item("nototalan") = nototalan Then
                flag = False
            End If
        Next
        Return flag
    End Function
    Private Sub tambahtotalan(nototalan As String)
        Dim query As String = "Select h.nototalan,h.diterima "
        query &= " from thtotalan h "
        query &= " where h.nototalan='" & nototalan & "' "
        Dim cmd As New SqlCommand(query, conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim tr As DataRow = ds.Tables("totalan").NewRow
                tr("nototalan") = nototalan
                tr("diterima") = dr.Item("diterima")
                ds.Tables("totalan").Rows.Add(tr)
            End While
        End If
        conn.Close()
    End Sub

    Private Sub hitungsemua()
        If init = False Then
            'hitungtotal()
            'hitungbayarkasbon()
            'hitungditerima()
        End If
    End Sub

    Private Sub dgvTotalan_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTotalan.CellContentClick
        If e.ColumnIndex = 53 Then
            'button ditekan
            Dim nototalan As String = dgvTotalan.Rows(e.RowIndex).Cells("nototalan").Value
            If cektotalan(nototalan) Then
                tambahtotalan(nototalan)
                'tambahsuratjalan(nobm)
                hitungsemua()
            Else
                MsgBox("Totalan Sudah Ditambahkan ")
            End If
        End If
    End Sub
End Class