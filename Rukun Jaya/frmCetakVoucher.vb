Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmCetakVoucher
    Dim _rjcommon As New RJCommon
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim init As Boolean = True
    Private Sub frmCetakVoucher_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox) Or Me.ActiveControl.GetType() = GetType(DateTimePicker))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Private Sub loadspbu()
        Dim dr As SqlDataReader
        Dim cmd As New SqlCommand("select namaspbu from tspbu order by namaspbu", conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        cbspbu.Items.Clear()
        cbspbu.Items.Add("[Semua]")
        dr = cmd.ExecuteReader
        While dr.Read
            cbspbu.Items.Add(dr.Item("namaspbu"))
        End While
        cbspbu.SelectedIndex = 0
        conn.Close()
    End Sub
    Private Sub loaddata()
        If init = False Then
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            Dim query As String = ""
            query = "select v.kodevoucher,v.nobm,v.nosuratjalan,s.namaspbu,k.nopol,v.liter,v.tglvoucher as tgl,v.kasbon"
            query &= " from tvoucherspbu v,tbm m,tspbu s,tkendaraan k"
            query &= " where m.nobm=v.nobm and s.kodespbu=v.kodespbu and m.nolambung=k.nolambung"
            query &= " and kodevoucher like '%" & txtnovoucher.Text & "%' and v.nobm like '%" & txtnoBm.Text & "'"
            query &= " and v.nosuratjalan like '%" & txtnosuratjalan.Text & "%' and k.nopol like '%" & txtnopol.Text & "%'"
            If cbspbu.Text <> "[Semua]" Then
                query &= " and s.namaspbu='" & cbspbu.Text & "'"
            End If
            query &= " and v.tglvoucher>=@tgl1 and v.tglvoucher<=@tgl2"

            cmd.CommandText = query
            cmd.Parameters.AddWithValue("@tgl1", dtpawal.Value.Date)
            cmd.Parameters.AddWithValue("@tgl2", dtpakhir.Value.Date)
            da.SelectCommand = cmd
            da.Fill(ds, "spbu")
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "spbu"
            DataGridView1.Refresh()
        End If
    End Sub
    Private Sub frmCetakVoucher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init = True
        dtpawal.Value = New Date(Now.Year, Now.Month, 1)
        dtpakhir.Value = Now
        loadspbu()
        init = False
        loaddata()
    End Sub


    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtnovoucher.TextChanged, txtnosuratjalan.TextChanged, txtnopol.TextChanged, txtnoBm.TextChanged, dtpawal.ValueChanged, dtpakhir.ValueChanged, cbspbu.SelectedIndexChanged
        loaddata()
    End Sub
    Public Sub cetakvoucher(nosuratjalan As String)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        Dim query As String = "select v.*,s.namaspbu,k.nopol,kj.namasopir"
        query &= " from tvoucherspbu v,tspbu s,tbm b,tkendaraan k,tsopir kj"
        query &= " where v.kodespbu = s.kodespbu And v.nobm = b.nobm "
        query &= " and b.nolambung=k.nolambung and b.kodesopir=kj.kodesopir"
        query &= " and v.nosuratjalan=@nosuratjalan"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)

        da.SelectCommand = cmd
        Try
            da.Fill(ds, "voucherspbu")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim rep As New voucherspbu
        rep.SetDataSource(ds.Tables("voucherspbu"))
        frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
        frmcetaklaporan.CrystalReportViewer1.RefreshReport()
        frmcetaklaporan.ShowDialog()
    End Sub
    Public Sub cetakvoucher(nosuratjalan As String, kodevoucher As String)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        Dim query As String = "select v.kodevoucher,v.liter,v.sisa,v.rupiahsatuan,v.rupiah,CONVERT(nvarchar(30), tglvoucher, 105) as tglvoucher,s.namaspbu,k.nopol,kj.namasopir"
        query &= " from tvoucherspbu v,tspbu s,tbm b,tkendaraan k,tsopir kj"
        query &= " where v.kodespbu = s.kodespbu And v.nobm = b.nobm "
        query &= " and b.nolambung=k.nolambung and b.kodesopir=kj.kodesopir"
        query &= " and v.nosuratjalan=@nosuratjalan and v.kodevoucher=@kodevoucher"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        cmd.Parameters.AddWithValue("@kodevoucher", kodevoucher)
        da.SelectCommand = cmd
        Try
            da.Fill(ds, "voucherspbu")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If ds.Tables("voucherspbu").Rows.Count > 0 Then
            Dim rep As New voucherspbu
            rep.SetDataSource(ds.Tables("voucherspbu"))
            frmcetaklaporan.CrystalReportViewer1.ReportSource = rep
            frmcetaklaporan.CrystalReportViewer1.RefreshReport()
            frmcetaklaporan.ShowDialog()
        Else
            _rjcommon.shownotifyerror("No Record Found To Display")
        End If
       
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 8 Then
                cetakvoucher(DataGridView1.Rows(e.RowIndex).Cells("nosuratjalan").Value, DataGridView1.Rows(e.RowIndex).Cells("kodevoucher").Value)
            End If
        End If
    End Sub
End Class