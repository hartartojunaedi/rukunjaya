Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmUbahHarga

    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Private Sub frmUbahHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        panggil()
    End Sub

    Sub panggil()

        command = "Select kodesparepart,namasparepart,hargaterakhir,stock,kartustok,keterangan "
        command &= " from tSparePart "
        'command &= " where b.nobm=s.nobm and b.kodesopir=sr.kodesopir and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang "
        'command &= " and s.kodesupplier=sp.kodesupplier and k.nolambung=b.nolambung and s.status='0' "
        ''jun 27 jan 2015
        'command &= " and b.nobm like '%" & txtNoBM.Text & "%'"
        'command &= " and k.nopol like '%" & txtCariNopol.Text & "%'"
        'command &= " and sr.namasopir like '%" & txtCariSopir.Text & "%'"
        'command &= " and s.tgl>=@tgl1 and s.tgl<=@tgl2"
        command &= " where kodesparepart like '%" & txtkodesparepart.Text & "%'"
        command &= " and namasparepart like '%" & txtnamasparepart.Text & "%'"
        command &= " and kartustok like '%" & txtkartustok.Text & "%'"
        command &= " order by kodesparepart asc"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show("panggil " & ex.Message)
        End Try
        '     lbljumlahrow.Text = dgvPembelianSparepart.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        'jun 27 jan 2015
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "ubahharga")
        DataGridView1.DataSource = dataset
        DataGridView1.DataMember = "ubahharga"
        lbljumlahdata.Text = dataset.Tables(0).Rows.Count
        DataGridView1.Columns("UbahHarga").DisplayIndex = 6
        'jun 27 jan 2015
        '    DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        '    DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        '    DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        '    DataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        '    DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        '    DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        panggil()

    End Sub

    Private Sub txtkodesparepart_TextChanged(sender As Object, e As EventArgs) Handles txtkodesparepart.TextChanged
        panggil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'MsgBox(e.ColumnIndex)
        If e.RowIndex >= 0 Then
            If (e.ColumnIndex = DataGridView1.Columns("UbahHarga").Index) Then
                '  frmDetailInventory.BtnSimpan.Enabled = False
                ' frmDetailInventory.btnClear.Enabled = True
                frmDetailUbahHarga.insert = False


                frmDetailUbahHarga.TxtKodeSP.Text = DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns("kodesparepart").Index).Value
                frmDetailUbahHarga.TxtNamaSparepart.Text = DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns("namasparepart").Index).Value
                frmDetailUbahHarga.txtHargaTerakhir.Text = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns("hargaterakhir").Index).Value).ToString()
                'jun 13  feb 2015
                'untuk mengatasi stock minus
                frmDetailUbahHarga.TxtKodeSP.Enabled = False


                frmDetailUbahHarga.ShowDialog()
                panggil()
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub txtnamasparepart_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnamasparepart.TextChanged
        panggil()
    End Sub

    Private Sub txtkartustok_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtkartustok.TextChanged
        panggil()
    End Sub
End Class