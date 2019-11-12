Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmCariSparepart
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Public mode As Integer
    Sub panggil()

        command = "Select kodesparepart,namasparepart,hargaterakhir,stock,keterangan from tsparepart where kodesparepart like '%" & txtSearchKode.Text & "%' and namasparepart like '%" & txtSearchNamaSP.Text & "%'"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "sparepart")
        dgvCariInventory.DataSource = dataset
        dgvCariInventory.DataMember = "sparepart"
    End Sub


    Private Sub frmCariSparepart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()

    End Sub

    Private Sub btncari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click, txtSearchNamaSP.TextChanged, txtSearchKode.TextChanged
        panggil()
    End Sub

    Private Sub dgvCariInventory_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCariInventory.CellDoubleClick
        Try
            If mode = 1 Then
                frmDetilBeliSparePart.varkodesparepart = dgvCariInventory.Rows(e.RowIndex).Cells(0).Value.ToString
                ' frmDetilBeliSparePart.txtKodebarang.Text = dgvCariInventory.Rows(e.RowIndex).Cells(1).Value
                'frmDetilBeliSparePart.txtHarga.Text = FormatNumber(dgvCariInventory.Rows(e.RowIndex).Cells(2).Value.ToString, 0)
                frmDetilBeliSparePart.btnTambah.Enabled = True
                frmDetilBeliSparePart.loaddata()
                '   frmdetilpembeliansparepart.varnamasparepart = dgvCariInventory.Rows(e.RowIndex).Cells(1).Value
                '  frmdetilpembeliansparepart.txtKodebarang.Text = dgvCariInventory.Rows(e.RowIndex).Cells(0).Value.ToString
                '  frmdetilpembeliansparepart.txtHarga.Text = FormatCurrency(dgvCariInventory.Rows(e.RowIndex).Cells(2).Value.ToString, 0)
                Me.Close()
            Else
                If mode = 2 Then
                    frmDetilMutasiMasuk.varkodesparepart = dgvCariInventory.Rows(e.RowIndex).Cells(0).Value.ToString
                    frmDetilMutasiMasuk.btnTambah.Enabled = True
                    frmDetilMutasiMasuk.loaddata()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        End Sub

  
    Private Sub dgvCariInventory_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCariInventory.CellContentClick

    End Sub
End Class