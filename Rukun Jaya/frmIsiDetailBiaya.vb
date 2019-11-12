Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class frmIsiDetailBiaya
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New rjLib
    Dim connstr As String = _rjcommon.getconnstr
    Dim conn As New SqlConnection(connstr)
    Dim ds As New DataSet

    Sub loaddata()
        ds.Clear()
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand("", conn)
        Dim query As String = " select db.kodebiaya,namabiaya,keterangan,biaya as kredit,0 as debit from tdetailbiaya db,tbiaya b"
        query &= " where b.kodebiaya = db.kodebiaya And kurang = 0 and db.nobm=@nobm1 and db.nosuratjalan=@nosuratjalan1"
        query &= " union "
        query &= " select db.kodebiaya,namabiaya,keterangan,0 as kredit,biaya as debit from tdetailbiaya db,tbiaya b"
        query &= " where b.kodebiaya = db.kodebiaya And kurang = 1 and db.nobm=@nobm2 and db.nosuratjalan=@nosuratjalan2"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@nobm1", lblnoBM.Text)
        cmd.Parameters.AddWithValue("@nosuratjalan1", lblNoSuratJalan.Text)
        cmd.Parameters.AddWithValue("@nobm2", lblnoBM.Text)
        cmd.Parameters.AddWithValue("@nosuratjalan2", lblNoSuratJalan.Text)
        da.SelectCommand = cmd
        da.Fill(ds, "biaya")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "biaya"
        DataGridView1.Refresh()
    End Sub
    Sub loadbiaya()
        Dim da As New SqlDataAdapter("Select * from tbiaya order by namabiaya", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tbiaya")
        cmbbiaya.DataSource = ds.Tables(0)
        cmbbiaya.DisplayMember = "namabiaya"
        cmbbiaya.ValueMember = "kodebiaya"
        cmbbiaya.Refresh()
    End Sub
    Private Sub frmIsiDetailBiaya_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadbiaya()
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            ds.Tables("biaya").Rows(e.RowIndex).Delete()
        End If
    End Sub

    Function cekkurang(kodebiaya As String) As Boolean
        Dim kurang As Boolean
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "select kurang from tbiaya where kodebiaya=@kodebiaya"
        cmd.Parameters.AddWithValue("@kodebiaya", kodebiaya)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        kurang = cmd.ExecuteScalar()
        conn.Close()
        Return kurang
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim tr As DataRow = ds.Tables("biaya").NewRow
        tr("kodebiaya") = cmbbiaya.SelectedValue
        tr("namabiaya") = cmbbiaya.Text
        If cekkurang(cmbbiaya.SelectedValue) Then
            tr("debit") = txtbiaya.Text
            tr("kredit") = 0
        Else
            tr("kredit") = txtbiaya.Text
            tr("Debit") = 0
        End If
        tr("keterangan") = txtketerangan.Text
        ds.Tables("biaya").Rows.Add(tr)
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandText = "delete  from tdetailbiaya where nobm=@nobm and nosuratjalan=@nosuratjalan"
        cmd.Parameters.AddWithValue("@nobm", lblnoBM.Text)
        cmd.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.ExecuteNonQuery()
        For i As Integer = 0 To ds.Tables("biaya").Rows.Count - 1
            cmd.Parameters.Clear()
            cmd.CommandText = "insert into tdetailbiaya(kodebiaya,nobm,nosuratjalan,keterangan,biaya) values (@kodebiaya,@nobm,@nosuratjalan,@keterangan,@biaya) "
            cmd.Parameters.AddWithValue("@nobm", lblnoBM.Text)
            cmd.Parameters.AddWithValue("@nosuratjalan", lblNoSuratJalan.Text)
            cmd.Parameters.AddWithValue("@kodebiaya", ds.Tables("biaya").Rows(i).Item("kodebiaya"))
            cmd.Parameters.AddWithValue("@keterangan", ds.Tables("biaya").Rows(i).Item("keterangan"))
            If ds.Tables("biaya").Rows(i).Item("kredit") = 0 Then
                cmd.Parameters.AddWithValue("@biaya", ds.Tables("biaya").Rows(i).Item("debit"))
            Else
                cmd.Parameters.AddWithValue("@biaya", ds.Tables("biaya").Rows(i).Item("kredit"))
            End If
            cmd.ExecuteNonQuery()
        Next
        conn.Close()
        Close()
    End Sub
End Class