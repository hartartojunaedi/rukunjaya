Imports System.Data
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetailMutasiKeluar
    Public mode As Integer
    Dim _rjcommon As New RJCommon
    Dim _rjlib As New RjLibrary.rjLib
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim conntrans As New SqlConnection(_rjcommon.getconnstr())
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim ds As DataSet
    Dim status = 0
    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function
    Sub refreshdata()
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ds = New DataSet
            adapter("select kodesparepart,stock from tsparepart").Fill(ds, "tsparepart")
            dgvstock.DataSource = ds.Tables("tsparepart")

            adapter("select s.kodesparepart,s.namasparepart,d.noseri,d.jumlah,d.keterangan from tdmutasikeluar d,tsparepart s where d.kodesparepart=s.kodesparepart and d.id='" & TextBox1.Text & "'").Fill(ds, "tdetailmutasikeluar")
            DataGridView1.DataSource = ds.Tables("tdetailmutasikeluar")

            status = 0
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub loadkendaraan()
        ComboBox1.Items.Clear()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim rd = New SqlCommand("select nopol from tkendaraan order by nopol", conn).ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd.Item("nopol").ToString)
        End While
        rd.Close()
        conn.Close()
    End Sub
    Sub loadsparepart()
        cmbNamaSparepart.Items.Clear()
        Dim authors As New AutoCompleteStringCollection
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim rd = New SqlCommand("select * from tsparepart", conn).ExecuteReader
        While rd.Read
            ' cmbNamaSparepart.Items.Add(rd("namasparepart"))
            authors.Add(rd("namasparepart"))
        End While
        cmbNamaSparepart.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbNamaSparepart.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmbNamaSparepart.AutoCompleteCustomSource = authors
        rd.Close()
        btnHapusDgv.FlatStyle = FlatStyle.Flat
        DataGridView1.Columns.Add(btnHapusDgv)
        btnHapusDgv.Text = "Hapus"
        btnHapusDgv.HeaderText = "Hapus Data"
        btnHapusDgv.UseColumnTextForButtonValue = True
        DataGridView1.Visible = True
        refreshdata()
        conn.Close()
    End Sub
    Sub loaddata()
        Dim cmd As New SqlCommand("Select * from thkeluar where id='" + TextBox1.Text + "'", conn)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            TextBox2.Text = dr.Item("nospk").ToString
            TextBox3.Text = dr.Item("namakaryawan").ToString
            TextBox4.Text = dr.Item("keterangan").ToString
            DateTimePicker1.Value = dr.Item("tgl")
            ' MsgBox(dr.Item("nolambung").ToString)
            Dim cmd1 As New SqlCommand("select * from tkendaraan where nolambung=@nolambung", conn)
            cmd1.Parameters.AddWithValue("@nolambung", dr.Item("nolambung").ToString)
            Try
                dr.Close()
                Dim dr1 As SqlDataReader = cmd1.ExecuteReader

                If dr1.HasRows Then
                    dr1.Read()
                    For i As Integer = 0 To ComboBox1.Items.Count - 1
                        If ComboBox1.Items(i) = dr1.Item("nopol") Then
                            ComboBox1.SelectedIndex = i
                        End If
                    Next
                    dr1.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            

        End If
        conn.Close()
    End Sub
    Private Sub frmDetailMutasiKeluar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadsparepart()
        loadkendaraan()
        If mode = 0 Then 'edit
            btntambah.Enabled = False
            btnHapusDgv.Visible = False
            btnsimpan.Enabled = False
            loaddata()
        End If

    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs)
      
    End Sub

    Private Sub cmbNamaSparepart_Leave(sender As System.Object, e As System.EventArgs) Handles cmbNamaSparepart.Leave
        Try
            conn.Open()
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To DataGridView1.Rows.Count - 2
                If (DataGridView1.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - DataGridView1.Rows(i).Cells(3).Value
                End If
            Next
            conn.Close()
            lblsisastock.Text = sisastock
        Catch ex As Exception
            Dim sisastock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
            For i = 0 To DataGridView1.Rows.Count - 2
                If (DataGridView1.Rows(i).Cells(1).Value = cmbNamaSparepart.Text) Then
                    sisastock = sisastock - DataGridView1.Rows(i).Cells(3).Value
                End If
            Next
            lblsisastock.Text = sisastock
        End Try
    End Sub
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        If Trim(TextBox1.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Kode Mutasi Harus Diisi !")
        End If
        If Trim(TextBox2.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("No SPK !")
        End If
        Return flag
    End Function
    Public Sub addstock(ByVal kodesparepart, ByVal jumlah)
        Dim stock = New SqlCommand("select stock from tsparepart where kodesparepart='" & kodesparepart & "'", conn).ExecuteScalar
        Dim total = stock + CDbl(jumlah)
        Dim comd = New SqlCommand("update tsparepart set stock=@stock where kodesparepart=@kodesparepart", conn)
        comd.Parameters.AddWithValue("@kodesparepart", kodesparepart)
        comd.Parameters.AddWithValue("@stock", total)
        'tidak dipakai
        comd.ExecuteNonQuery()
    End Sub
    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If ceksimpan() Then
            Dim sesi As SqlTransaction
            If conntrans.State <> ConnectionState.Open Then
                conntrans.Open()
            End If
            sesi = conntrans.BeginTransaction
            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If
                Dim cmd1 As New SqlCommand
                Dim cmd4 As New SqlCommand("select nolambung from tkendaraan where nopol=@nopol", conn)
                cmd4.Parameters.AddWithValue("@nopol", ComboBox1.SelectedItem.ToString)

                Dim dr As SqlDataReader = cmd4.ExecuteReader
                Dim nolambung As String = ""
                If dr.HasRows Then
                    dr.Read()
                    nolambung = dr.Item("nolambung")
                End If
                dr.Close()
                cmd1.Connection = conn
                cmd1.CommandText = "insert into thkeluar(id,nospk,namakaryawan,tgl,keterangan,nolambung) values (@id,@nospk,@namakaryawan,@tgl,@keterangan,@nolambung) "
                cmd1.Parameters.AddWithValue("@id", TextBox1.Text)
                cmd1.Parameters.AddWithValue("@nospk", TextBox2.Text)
                cmd1.Parameters.AddWithValue("@namakaryawan", TextBox3.Text)
                cmd1.Parameters.AddWithValue("@tgl", DateTimePicker1.Value)
                cmd1.Parameters.AddWithValue("@keterangan", TextBox4.Text)
                cmd1.Parameters.AddWithValue("@nolambung", nolambung)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlCommand
                cmd2.Connection = conn
                cmd2.CommandText = "insert into tdmutasikeluar(id,kodesparepart,noseri,jumlah,keterangan) values (@id,@kodesparepart,@noseri,@jumlah,@keterangan)"
                Dim cmd3 As New SqlCommand
                cmd3.Connection = conn
                cmd3.CommandText = "update tsparepart set stock=stock-@jumlah where kodesparepart=@kodesparepart"
                For i = 0 To DataGridView1.Rows.Count - 1
                    cmd2.Parameters.Clear()
                    cmd2.Parameters.AddWithValue("@id", TextBox1.Text)
                    cmd2.Parameters.AddWithValue("@kodesparepart", DataGridView1.Rows(i).Cells(1).Value)
                    cmd2.Parameters.AddWithValue("@noseri", DataGridView1.Rows(i).Cells(3).Value)
                    cmd2.Parameters.AddWithValue("@jumlah", DataGridView1.Rows(i).Cells(4).Value)
                    cmd2.Parameters.AddWithValue("@keterangan", DataGridView1.Rows(i).Cells(5).Value)
                    cmd2.ExecuteNonQuery()
                    cmd3.Parameters.Clear()
                    cmd3.Parameters.AddWithValue("@jumlah", DataGridView1.Rows(i).Cells(4).Value)
                    cmd3.Parameters.AddWithValue("@kodesparepart", DataGridView1.Rows(i).Cells(1).Value)
                    cmd3.ExecuteNonQuery()
                Next

                Close()
                _rjcommon.shownotify("Transaksi Mutasi Keluar berhasil ditambahkan")
                _rjcommon.isilog(_rjcommon.getusername, TextBox1.Text, "Transaksi Mutasi Keluar", "Tambah Data", "")
                conn.Close()
                sesi.Commit()
            Catch ex As Exception
                _rjcommon.shownotify("Transaksi Mutasi Keluar gagal ditambahkan")
                _rjcommon.isiErrorlog(_rjcommon.getusername, TextBox1.Text, "Transaksi Mutasi Keluar", "Tambah Data", ex.Message)
                conn.Close()
                sesi.Rollback()
            End Try
        End If
    End Sub

    Private Sub btntambah_Click_1(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Dim stock = 0
        Dim kodesparepart As String
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        stock = New SqlCommand("select stock from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
        'MsgBox(stock)
        If txtJumlah.Text = "" Then
            _rjcommon.shownotifyerror("Jumlah Tidak Boleh Kosong")
            conn.Close()
            Return
        End If

        conn.Close()
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        kodesparepart = New SqlCommand("select kodesparepart from tsparepart where namasparepart='" & cmbNamaSparepart.Text & "'", conn).ExecuteScalar
        conn.Close()
        Dim check = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Rows(i).Cells(2).Value = cmbNamaSparepart.Text) And (DataGridView1.Rows(i).Cells(3).Value = txtNoSeri.Text) Then
                If stock - (DataGridView1.Rows(i).Cells(4).Value + Int(txtJumlah.Text)) >= 0 Then
                    DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value + Int(txtJumlah.Text)
                    lblsisastock.Text = Int(lblsisastock.Text) - txtJumlah.Text
                End If
                check = 1
            End If
        Next
        If check = 0 Then
            Dim prevstock = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                If (DataGridView1.Rows(i).Cells(2).Value = cmbNamaSparepart.Text) Then
                    prevstock = prevstock + DataGridView1.Rows(i).Cells(4).Value
                End If
            Next
            If (stock - (prevstock + txtJumlah.Text) >= 0) Then
                'jun 7 september 2015
                Dim data As DataRow
                data = ds.Tables("tdetailmutasikeluar").NewRow
                data.Item(0) = kodesparepart
                data.Item(1) = cmbNamaSparepart.Text
                data.Item(2) = txtNoSeri.Text
                data.Item(3) = txtJumlah.Text
                data.Item(4) = txtDetailKeterangan.Text
                data.EndEdit()
                ds.Tables("tdetailmutasikeluar").Rows.Add(data)
                lblsisastock.Text = Int(lblsisastock.Text) - txtJumlah.Text
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            ds.Tables("tdetailmutasikeluar").Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class