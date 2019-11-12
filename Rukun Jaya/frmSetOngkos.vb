Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary

Public Class frmTransaksiSetOngkos
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection
    Dim adapter As New SqlDataAdapter
    Dim command As String = ""
    Sub panggil()

        command = "Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j where k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and b.noBM like '%" & txtNoBM.Text & "%' and s.namasopir like '%" & txtCariSopir.Text & "%' and k.nopol like '%" & txtCariNopol.Text & "%' and sj.nobm=b.nobm and b.tgl between '" & dtpAwalPeriode.Value & "' and '" & dtpAkhirPeriode.Value & "' group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"
        ' Dim a As New SqlCommand(command)

        dataset.Clear()
        Try
            cn.Open()

            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = cn
            '            cmd.CommandText = "Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j where k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and b.noBM like '%@nobm%' and s.namasopir like '%@sopir%' and k.nopol like '%@nopol%' and sj.nobm=b.nobm and b.tgl >=@tglawal and b.tgl<=@tglakhir group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"
            ' cmd.CommandText = "Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total"
            cmd.CommandText = "Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(db.biaya) as total"
            cmd.CommandText &= " from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j,tdetailbiaya db "

            cmd.CommandText &= " where db.kodebiaya='x001' and db.nosuratjalan=sj.nosuratjalan and db.nobm=sj.nobm and k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and b.noBM like '%" & txtNoBM.Text & "%' and s.namasopir like '%" & txtCariSopir.Text & "%' and k.nopol like '%" & txtCariNopol.Text & "%' and sj.nobm=b.nobm and b.tgl >=@tglawal and b.tgl<=@tglakhir"
            'jun 12 feb 2015
            'BM yang sudah diproses tidak dikeluarkan
            'cmd.CommandText &= " and b.status=0 "
            cmd.CommandText &= " group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"

            cmd.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd.Parameters.AddWithValue("@tglakhir", dtpAkhirPeriode.Value.Date)
            '  cmd.Parameters.AddWithValue("@nopol", txtCariNopol.Text)
            ' cmd.Parameters.AddWithValue("@sopir", txtCariSopir.Text)
            'cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)
            adapter.SelectCommand = cmd

            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Fill(dataset, "setongkos")
            dgvBM.DataSource = dataset
            dgvBM.DataMember = "setongkos"
            dgvBM.Refresh()

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try
        '     lbljumlahrow.Text = dgvPembelianSparepart.RowCount
    End Sub

    'Sub isidataset()
    '    Dim cmd As SqlCommand = New SqlCommand
    '    cmd.Connection = cn
    '    cmd.CommandText = "Select b.noBM,b.tgl,b.nolambung,k.nopol,j.namajenis, s.namasopir,s.panggilan,sum(sj.borongansopir) as total from tbm b,tkendaraan k, tsopir s,tsuratjalan sj, tjeniskendaraan j where k.nolambung=b.nolambung and s.kodesopir=b.kodesopir and k.jenis=j.kodejenis and b.noBM like '%@nobm%' and s.namasopir like '%@sopir%' and k.nopol like '%@nopol%' and sj.nobm=b.nobm and b.tgl between '@tglawal' and '@tglakhir' group by b.nobm,b.tgl,b.nolambung,k.nopol,j.namajenis,s.namasopir,s.panggilan"
    '    cmd.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value)
    '    cmd.Parameters.AddWithValue("@tglakhir", dtpAkhirPeriode.Value)
    '    cmd.Parameters.AddWithValue("@nopol", txtCariNopol.Text)
    '    cmd.Parameters.AddWithValue("@sopir", txtCariSopir.Text)
    '    cmd.Parameters.AddWithValue("@nobm", txtNoBM.Text)
    '    adapter.SelectCommand = cmd

    '    Dim builder As New SqlCommandBuilder(adapter)
    '    adapter.Fill(dataset, "setongkos")
    '    dgvBM.DataSource = dataset
    '    dgvBM.DataMember = "setongkos"
    'End Sub
    Private Function cekbm(nobm As String) As Boolean
        Dim flag As Boolean = True
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "select status from tbm where nobm=@nobm"
        cmd.Parameters.AddWithValue("@nobm", nobm)
        If cn.State <> ConnectionState.Open Then
            cn.Open()
        End If
        Dim status As Integer = cmd.ExecuteScalar()
        flag = IIf(status = 0, True, False)
        cn.Close()
        Return flag
    End Function
    Private Sub frmSetOngkos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cn = New SqlConnection
        cn.ConnectionString = rj.getconnstr
        ' cn.ConnectionString = "Data Source=ERIC-NB\ERIC;Initial Catalog=Rukun;Integrated Security=True"
        'dtpAwalPeriode.Value = "1-" & Now.Month & "-" & Now.Year
        'jun 10 feb 2015
        dtpAwalPeriode.Value = New Date(Now.Year, Now.Month, 1)
        dtpAkhirPeriode.Value = Now
        panggil()
    End Sub


    Private Sub dgvBM_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellClick
        If (e.ColumnIndex = 0) Then
            If cekbm(dgvBM.Rows(e.RowIndex).Cells("NoBM").Value) Then
                frmDetilSetOngkos.txtNoBM.Text = dgvBM.Rows(e.RowIndex).Cells("NoBM").Value
                frmDetilSetOngkos.ShowDialog()
                'jun 26 jan 2015
                panggil()
            Else
                MsgBox("BM Tidak Boleh DiSet Karena Sudah Diproses")
            End If
            
        End If
    End Sub

    Private Sub btnFilter_Click(sender As System.Object, e As System.EventArgs) Handles btnFilter.Click, txtNoBM.TextChanged, txtCariSopir.TextChanged, txtCariNopol.TextChanged, dtpAwalPeriode.ValueChanged, dtpAkhirPeriode.ValueChanged
        panggil()
    End Sub

    Private Sub dgvBM_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBM.CellContentClick

    End Sub
End Class