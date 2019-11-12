Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary


Public Class frmSetorSuratJalan

    Private Sub frmSetorSuratJalan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        dtpAwalPeriode.Value = New DateTime(Now.Year, Now.Month, 1, 0, 0, 1)
        dtpAkhirPeriode.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        panggil()
    End Sub

    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Sub panggil()

        command = "Select s.nobm,k.nopol,s.noSuratJalan,sr.namasopir, g1.namagudang as asal,g2.namagudang as tujuan,sp.namasupplier,s.tgl "
        command &= " from tSuratJalan s,tkendaraan k,tgudang g1, tgudang g2,tsupplier sp,tsopir sr, tbm b "
        command &= " where b.nobm=s.nobm and b.kodesopir=sr.kodesopir and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang "
        command &= " and s.kodesupplier=sp.kodesupplier and k.nolambung=b.nolambung and s.status='0' "
        'jun 27 jan 2015
        command &= " and b.nobm like '%" & txtNoBM.Text & "%'"
        command &= " and k.nopol like '%" & txtCariNopol.Text & "%'"
        command &= " and sr.namasopir like '%" & txtCariSopir.Text & "%'"
        command &= " and s.tgl>=@tgl1 and s.tgl<=@tgl2"
        command &= " order by s.tgl asc"

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
        cmd1.Parameters.AddWithValue("@tgl1", dtpAwalPeriode.Value.Date)
        cmd1.Parameters.AddWithValue("@tgl2", dtpAkhirPeriode.Value.Date)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "setor")
        dgvSetorSuratJalan.DataSource = dataset
        dgvSetorSuratJalan.DataMember = "setor"
        'jun 27 jan 2015
        dgvSetorSuratJalan.Columns(8).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(1).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(2).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(3).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(4).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(5).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(6).DefaultCellStyle.BackColor = Color.Silver
        dgvSetorSuratJalan.Columns(7).DefaultCellStyle.BackColor = Color.Silver


    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = cn
        cn.Open()

        Try
            For j = 0 To dgvSetorSuratJalan.RowCount - 1
                '  MsgBox(dgvSetorSuratJalan.Rows(j).Cells("setor").Value)
                If dgvSetorSuratJalan.Rows(j).Cells("setor").Value = True Then
                    cmd.CommandText = "update tsuratjalan set status='1' where nobm=@nobm and nosuratjalan=@nosuratjalan"
                    cmd.Parameters.Clear()

                    cmd.Parameters.AddWithValue("@nobm", dgvSetorSuratJalan.Rows(j).Cells("noBM").Value)
                    cmd.Parameters.AddWithValue("@nosuratjalan", dgvSetorSuratJalan.Rows(j).Cells("nosj").Value)

                    cmd.ExecuteNonQuery()
                    rj.isilog(rj.getusername, "SJ= " & dgvSetorSuratJalan.Rows(j).Cells("nosj").Value & " No BM = " & dgvSetorSuratJalan.Rows(j).Cells("noBM").Value, "Setor Surat Jalan", "Update Data", "")
                    rj.shownotify("Data Berhasil Disimpan")
                End If


            Next
    
        Catch ex As Exception
            rj.isiErrorlog(rj.getusername, "  ", "Setor Surat Jalan", "Update Data", ex.Message)
            rj.shownotifyerror("Data Tidak Berhasil Disimpan")
        End Try
        cn.Close()
        panggil()

    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click, dtpAwalPeriode.ValueChanged, dtpAkhirPeriode.ValueChanged
        panggil()
    End Sub

    Private Sub txtNoBM_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoBM.TextChanged, txtCariSopir.TextChanged, txtCariNopol.TextChanged
        panggil()
    End Sub
End Class