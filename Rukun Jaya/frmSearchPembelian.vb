Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmSearchPembelian
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "sparepart")
        dgvPembelianSparepart.DataSource = dataset
        dgvPembelianSparepart.DataMember = "sparepart"
    End Sub
    Sub panggil()

        command = "Select h.nota,h.namatoko,h.tgltransaksi,h.total,h.diskon,h.grandtotal "
        command &= ",d.kodesparepart,d.harga,d.jumlah,sp.namasparepart,sp.stock,sp.kartustok "
        command &= "from thbeli h,tdbeli d,tsparepart sp "
        command &= "where h.nota=d.nota and  d.kodesparepart=sp.kodesparepart "
        command &= "and h.nota like '%" & txtsearchnonota.Text & "%' and namatoko like '%" & txtsearchnamatoko.Text & "%' "
        command &= "and sp.kodesparepart like '%" & TextBox3.Text & "%' "
        command &= "and sp.namasparepart like '%" & TextBox2.Text & "%' and sp.kartustok like '%" & TextBox1.Text & "%' order by tgltransaksi desc"

        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        lbljumlahrow.Text = dgvPembelianSparepart.RowCount
    End Sub
    Private Sub btnCari_Click(sender As System.Object, e As System.EventArgs) Handles btnCari.Click
        panggil()
    End Sub

    Private Sub frmSearchPembelian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        'cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()
    End Sub
End Class