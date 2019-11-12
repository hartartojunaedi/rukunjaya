Imports RjLibrary
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCariDetilSuratJalan
    Dim cn As New SqlConnection
    Dim rj As New RJCommon
    Dim command As String
   
    Private Sub frmCariDetilSuratJalan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        ' cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        panggil()
    End Sub


    Sub panggil()
        Dim dataset As New DataSet
        Dim adapter As New SqlDataAdapter
    
        dataset.Clear()
        Try
            cn.Open()
            Dim cmd1 As New SqlCommand
            cmd1.CommandText = " Select d.nobm,d.nosuratjalan,s.namasopir,d.nodo,k.nopol from tdetailsuratjalan d, tSuratJalan l, tBM b,tsopir s,tkendaraan k where "
            cmd1.CommandText &= " d.nobm=l.nobm and d.nosuratjalan=l.nosuratjalan and l.nobm=b.nobm and b.kodesopir=s.kodesopir and b.nolambung=k.nolambung "
            cmd1.CommandText &= " and d.nobm like @nobm and d.nosuratjalan like @nosj and s.namasopir like @namasopir"
            cmd1.Parameters.AddWithValue("@nobm", "%" + txtNoBM.Text + "%")
            cmd1.Parameters.AddWithValue("@nosj", "%" + txtNoSuratJalan.Text + "%")
            cmd1.Parameters.AddWithValue("@namasopir", "%" + txtNamaSopir.Text + "%")

            cmd1.Connection = cn
            adapter.SelectCommand = cmd1
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "suratjalan")
            dgvDetilSuratJalan.DataSource = dataset
            dgvDetilSuratJalan.DataMember = "suratjalan"
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Sub panggildetilbarang(vnobm As String, vnodo As String, vnosj As String)
        Dim datasetdetil As New DataSet
        Dim adapter As New SqlDataAdapter
        datasetdetil.Clear()
        Try
            cn.Open()
            Dim cmd1 As New SqlCommand

            cmd1.CommandText = " Select b.namabarang,d.jumlah,b.kodebarang,d.nobm,d.nosuratjalan,d.nodo from tbarang b,tdetailsuratjalan d where d.kodebarang=b.kodebarang and d.nobm=@nobm and d.nosuratjalan=@nosj and d.nodo=@nodo"
            '  cmd1.CommandText &= "  and d.nosuratjalan=@nosj and d.nodo=@nodo"
            cmd1.Parameters.AddWithValue("@nobm", vnobm)
            cmd1.Parameters.AddWithValue("@noSJ", vnosj)
            cmd1.Parameters.AddWithValue("@noDO", vnodo)

            cmd1.Connection = cn
            adapter.SelectCommand = cmd1
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(datasetdetil, "DetilSJ")
            dgvDetilBarang.DataSource = datasetdetil
            dgvDetilBarang.DataMember = "DetilSJ"
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    

    Private Sub dgvDetilSuratJalan_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetilSuratJalan.CellClick
        Dim vNoBM As String
        Dim vNoSuratJalan As String
        Dim vNoDo As String

        vNoBM = dgvDetilSuratJalan.Rows(e.RowIndex).Cells("NoBM").Value.ToString
        vNoSuratJalan = dgvDetilSuratJalan.Rows(e.RowIndex).Cells("NoSuratJalan").Value.ToString

        vNoDo = dgvDetilSuratJalan.Rows(e.RowIndex).Cells("NoDO").Value.ToString

        panggildetilbarang(vNoBM, vNoDo, vNoSuratJalan)

        '  Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click, txtNoSuratJalan.TextChanged, txtNoBM.TextChanged
        panggil()
    End Sub


    Private Sub frmCariDetilSuratJalan_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ' frmDetailLKuat.cariurut()
        ' frmDetailLKuat.cek()

    End Sub

    Private Sub dgvDetilBarang_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub dgvDetilBarang_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetilBarang.CellDoubleClick
        ' MsgBox("Hit")
        frmDetailLKuat.LblKodeBarang.Text = dgvDetilBarang.Rows(e.RowIndex).Cells("kodebarang").Value.ToString
        frmDetailLKuat.lblNoBM.Text = dgvDetilBarang.Rows(e.RowIndex).Cells("NoBonMuat").Value.ToString
        frmDetailLKuat.lblNoSuratJalan.Text = dgvDetilBarang.Rows(e.RowIndex).Cells("NoDeSuratJalan").Value.ToString
        frmDetailLKuat.lblNoDo.Text = dgvDetilBarang.Rows(e.RowIndex).Cells("nodeliveryorder").Value.ToString
        frmDetailLKuat.lblNamaBarang.Text = dgvDetilBarang.Rows(e.RowIndex).Cells("namabrg").Value.ToString
        frmDetailLKuat.cek()
        Me.Close()
    End Sub
End Class