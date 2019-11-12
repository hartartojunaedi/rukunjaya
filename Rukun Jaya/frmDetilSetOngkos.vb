Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmDetilSetOngkos
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim rjl As New rjLib
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""

    Private Sub frmDetilSetOngkos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr

        panggil()
    End Sub

    Sub panggil()
        '    command = "Select s.noSuratJalan,sp.namasupplier,s.tgl, g1.namagudang as asal,g2.namagudang as tujuan,p.namaperwakilan,s.borongansopir as ongkos from tSuratJalan s,tgudang g1, tgudang g2,tperwakilan p,tsupplier sp where s.noBM='" & txtNoBM.Text & "' and p.kodeperwakilan=s.kodeperwakilan and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang and s.kodesupplier=sp.kodesupplier order by s.tgl asc"

        command = "Select s.noSuratJalan,sp.namasupplier,s.tgl, g1.namagudang as asal,g2.namagudang as tujuan,p.namaperwakilan,db.biaya as ongkos  from tSuratJalan s,tgudang g1, tgudang g2,tperwakilan p,tsupplier sp,tDetailBiaya db  where s.noBM='" & txtNoBM.Text & "' and p.kodeperwakilan=s.kodeperwakilan and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang and s.kodesupplier=sp.kodesupplier and db.nobm=s.nobm and db.nosuratjalan=s.nosuratjalan and db.kodebiaya='x001' order by s.tgl asc"
        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        '     lbljumlahrow.Text = dgvPembelianSparepart.RowCount
    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "suratjalan")
        dgvSetOngkos.DataSource = dataset
        dgvSetOngkos.DataMember = "suratjalan"
        'jun 26 jan 2015
        dgvSetOngkos.Columns(0).DefaultCellStyle.BackColor = Color.Silver
        dgvSetOngkos.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        dgvSetOngkos.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        dgvSetOngkos.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        dgvSetOngkos.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        dgvSetOngkos.Columns(5).DefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As SqlCommand = New SqlCommand
        Dim cmd1 As SqlCommand = New SqlCommand
        cmd.Connection = cn
        cmd1.Connection = cn
        cn.Open()

        Try
            For j = 0 To dgvSetOngkos.RowCount - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "update tsuratjalan set borongansopir=@borongan where nobm=@nobm and nosuratjalan=@nosuratjalan"
                cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)
                cmd.Parameters.AddWithValue("@borongan", (dgvSetOngkos.Rows(j).Cells("ongkos").Value))
                cmd.Parameters.AddWithValue("@nosuratjalan", dgvSetOngkos.Rows(j).Cells("NoSuratJalan").Value)
                cmd.ExecuteNonQuery()


                cmd1.Parameters.Clear()
                cmd1.CommandText = "update tDetailbiaya set biaya=@biaya where nobm=@nobm and nosuratjalan=@nosuratjalan and kodebiaya='x001'"
                cmd1.Parameters.AddWithValue("@nobm", txtNoBM.Text)
                cmd1.Parameters.AddWithValue("@biaya", (dgvSetOngkos.Rows(j).Cells("ongkos").Value))
                cmd1.Parameters.AddWithValue("@nosuratjalan", dgvSetOngkos.Rows(j).Cells("NoSuratJalan").Value)
                cmd1.ExecuteNonQuery()
            Next
            Dim log As String = "" ' "nota=" & txtNonota.Text & vbCrLf & " nama toko=" & txtNamaToko.Text & vbCrLf & " total =" & lblTotal.Text & vbCrLf & " grand total setelah diskon =" & lblgrandtotal.Text
            rj.isilog(rj.getusername, txtNoBM.Text, "Transaksi Set Ongkos", "Update Data", log)
            rj.shownotify("Data Berhasil Disimpan")
            'jun 26 jan 2015
            Close()
        Catch ex As Exception
            rj.isiErrorlog(rj.getusername, txtNoBM.Text, "Transaksi Set Ongkos", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
        End Try
        cn.Close()
    End Sub

    Private Sub dgvSetOngkos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSetOngkos.CellContentClick

    End Sub
End Class