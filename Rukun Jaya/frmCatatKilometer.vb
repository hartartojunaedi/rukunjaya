Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmCatatKilometer
    Dim _rjcommon As New RJCommon
    Dim ds As New DataSet
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim jumlahRow As Integer = 0
    Dim init As Boolean = True

    Public Sub loaddata()
        Dim command As New SqlCommand
        command.Connection = conn
        Dim query As String = "select tkm.nolambung as nolambung,tk.nopol as nopol,tk.Merek as Merek,tjk.namajenis as namajenis,tkm.kmlast as kmlast,tkm.kmlast as kmlastforkm,tkm.km as km,tkm.kodejenismaintance as kodejenismaintance "
        query &= " from tKendaraan tk,tKendaraanMaintance tkm,tJenisKendaraan tjk,tJenisMaintance tjm "
        query &= " where tkm.kodejenismaintance=tjm.kodejenismaintance and tkm.nolambung=tk.nolambung and tjk.KodeJenis=tk.jenis and tjm.jenis=1 and tjm.rutin=1"
        query &= " and tk.nopol like '%" & txtNopol.Text & "%'"
        If cbJenis.SelectedIndex > 0 Then
            query &= " and namajenis='" & cbJenis.Text & "'"
        End If
        If cbMerek.SelectedIndex > 0 Then
            query &= " and merek='" & cbMerek.Text & "'"
        End If
        Dim da As New SqlDataAdapter
        command.CommandText = query
        da.SelectCommand = command
        ds.Clear()
        da.Fill(ds, "kendaraan")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "kendaraan"
        DataGridView1.Refresh()
    End Sub

    Public Sub loadjenis()
        Try
            'jun 26 jan 2015
            Dim da As New SqlDataAdapter("select distinct(namajenis) from tJenisKendaraan", conn)
            Dim ds1 As New DataSet
            da.Fill(ds1)
            cbJenis.Items.Clear()
            cbJenis.Items.Add("[Semua]")
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                cbJenis.Items.Add(ds1.Tables(0).Rows(i).Item(0))
            Next
            cbJenis.SelectedIndex = 0
            'cbJenis.DataSource = ds1.Tables(0)
            'cbJenis.ValueMember = "KodeJenis"
            'cbJenis.DisplayMember = "namajenis"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loadmerek()
        Try
            'jun 26 jan 2015
            Dim da As New SqlDataAdapter("select distinct(merek) from tKendaraan", conn)
            ds = New DataSet
            da.Fill(ds)
            cbMerek.Items.Clear()
            cbMerek.Items.Add("[Semua]")
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbMerek.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next
            cbMerek.SelectedIndex = 0
            'cbMerek.DataSource = ds.Tables(0)
            'cbMerek.ValueMember = "Merek"
            'cbMerek.DisplayMember = "Merek"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCatatKilometer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        init = True
        loadjenis()
        loadmerek()
        loaddata()
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        DataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        'DataGridView1.ClearSelection()
        'DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells("km")
        'DataGridView1.
        'DataGridView1.Rows(0).Selected = True
        'DataGridView1.Rows(0).Cells("km").Selected = True
        'DataGridView1.Refresh()
        'MsgBox(DataGridView1.SelectedCells.Item(0).Value)
        init = False
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1
            Dim nolam As String
            Dim kjm As String
            Dim kmm, kmlastt As Integer
            nolam = DataGridView1.Rows(i).Cells("nolambung").Value
            kmm = DataGridView1.Rows(i).Cells("km").Value
            kmlastt = DataGridView1.Rows(i).Cells("kmlast").Value
            kjm = DataGridView1.Rows(i).Cells("kodejenismaintance").Value
            If kmm >= kmlastt Then
                'update
                Dim command As New SqlCommand
                Dim query As String = ""
                query = " update tKendaraanMaintance set km=km+@kilometer,kmlast=@kilometerlast"
                query &= " where nolambung=@nolambung and kodejenismaintance=@kodejenismaintance"
                command.Connection = conn
                command.CommandType = CommandType.Text
                command.CommandText = query
                command.Parameters.Add(New SqlParameter("@nolambung", nolam))
                command.Parameters.Add(New SqlParameter("@kilometer", kmm - kmlastt))
                command.Parameters.Add(New SqlParameter("@kilometerlast", kmm))
                command.Parameters.Add(New SqlParameter("@kodejenismaintance", kjm))
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Try

                    command.ExecuteNonQuery()
                    _rjcommon.isilog(_rjcommon.getusername, nolam, "Catat Kilometer", "Update Data", "")
                    _rjcommon.shownotify("Data Berhasil Diubah")
                    conn.Close()

                Catch ex As Exception
                    MsgBox("Data " + nolam + "Tidak Dapat Disimpan", MsgBoxStyle.OkOnly, "Information")
                    _rjcommon.isiErrorlog(_rjcommon.getusername, nolam, "Catat Kilometer", "Update Data", ex.Message)
                End Try
            Else
                _rjcommon.shownotifyerror("KM pada Nomor Lambung " + nolam + "yang dimasukkan harus lebih besar dari Km Last")
            End If
        Next
        'jun 21 jan 2015
        loaddata()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click, txtNopol.TextChanged
        'Try
        '     Dim da As New SqlDataAdapter("select tkm.nolambung as nolambung,tk.nopol as nopol,tk.Merek as Merek,tjk.namajenis as namajenis,tkm.kmlast as kmlast,tkm.kmlast as kmlastforkm,tkm.km as km,tkm.kodejenismaintance as kodejenismaintance from tKendaraan tk,tKendaraanMaintance tkm,tJenisKendaraan tjk,tJenisMaintance tjm where tkm.kodejenismaintance=tjm.kodejenismaintance and tkm.nolambung=tk.nolambung and tjk.KodeJenis=tk.jenis and tjm.jenis=1 and tjm.rutin=1 and tk.nopol like '%" & txtNopol.Text & "%'", conn)
        '     ds.Clear()
        '     da.Fill(ds, "kendaraan")
        '     DataGridView1.DataSource = ds
        '     DataGridView1.DataMember = "kendaraan"
        '     DataGridView1.Refresh()
        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try
        loaddata()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       Try
            Dim da As New SqlDataAdapter("select tkm.nolambung as nolambung,tk.nopol as nopol,tk.Merek as Merek,tjk.namajenis as namajenis,tkm.kmlast as kmlast,tkm.kmlast as kmlastforkm,tkm.km as km,tkm.kodejenismaintance as kodejenismaintance from tKendaraan tk,tKendaraanMaintance tkm,tJenisKendaraan tjk,tJenisMaintance tjm where tkm.kodejenismaintance=tjm.kodejenismaintance and tkm.nolambung=tk.nolambung and tjk.KodeJenis=tk.jenis and tjm.jenis=1 and tjm.rutin=1 and tjk.KodeJenis='" & cbJenis.SelectedValue & "'", conn)
            ds.Clear()
            da.Fill(ds, "kendaraan")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "kendaraan"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim da As New SqlDataAdapter("select tkm.nolambung as nolambung,tk.nopol as nopol,tk.Merek as Merek,tjk.namajenis as namajenis,tkm.kmlast as kmlast,tkm.kmlast as kmlastforkm,tkm.km as km,tkm.kodejenismaintance as kodejenismaintance from tKendaraan tk,tKendaraanMaintance tkm,tJenisKendaraan tjk,tJenisMaintance tjm where tkm.kodejenismaintance=tjm.kodejenismaintance and tkm.nolambung=tk.nolambung and tjk.KodeJenis=tk.jenis and tjm.jenis=1 and tjm.rutin=1 and tk.Merek='" & cbMerek.SelectedValue & "'", conn)
            ds.Clear()
            da.Fill(ds, "kendaraan")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "kendaraan"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbMerek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbJenis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbJenis.SelectedIndexChanged
        If init = False Then
            loaddata()
        End If
    End Sub

    Private Sub cbMerek_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbMerek.SelectedIndexChanged
        If init = False Then
            loaddata()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class