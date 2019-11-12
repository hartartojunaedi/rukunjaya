Imports RjLibrary
Imports System.Data
Imports System.Data.SqlClient

Public Class frmBrowsesopir
    Dim _rjcommon As New RJCommon
    Dim conn As New SqlConnection(_rjcommon.getconnstr())
    Dim btnUbahDgv As New DataGridViewButtonColumn()
    Dim btnHapusDgv As New DataGridViewButtonColumn()
    Dim ds As DataSet
    Public start = 0
    Public asal As Integer = 0

    Function adapter(ByVal cmdstring) As SqlDataAdapter
        Dim cmd = New SqlCommand(cmdstring, conn)
        Dim adp As New SqlDataAdapter
        adp.SelectCommand = cmd
        Return adp
    End Function

    Public Sub refreshdata()
        conn.Open()
        ds = New DataSet
        Dim csstring = "case status when 0 then 'sopir aktif' when 1 then 'karyawan aktif' else 'tidak aktif' end as newstatus"
        adapter("select kodesopir,panggilan,namasopir,alamat,kota,hp,noid," & csstring & ",convert(varchar,tglmasuk,105) as tglmasuk from tsopir where status=0").Fill(ds, "tsopir")
        dgvsopir.DataSource = ds.Tables("tsopir")
        conn.Close()
    End Sub

    Private Sub frmsopir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'jun 04 juni 2015
            If asal <> 0 Then
                btnUbahDgv.FlatStyle = FlatStyle.Flat
                dgvsopir.Columns.Add(btnUbahDgv)
                btnUbahDgv.Text = "Ubah"
                btnUbahDgv.UseColumnTextForButtonValue = True

                btnHapusDgv.FlatStyle = FlatStyle.Flat
                dgvsopir.Columns.Add(btnHapusDgv)
                btnHapusDgv.Text = "Hapus"
                btnHapusDgv.UseColumnTextForButtonValue = True
            End If
            refreshdata()
            start = 0
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub





    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        If txtcari.Text = "" Then
            refreshdata()
        Else
            conn.Open()
            ds = New DataSet
            adapter("select kodesopir,panggilan,namasopir,alamat,kota,hp from tsopir where namasopir like '%" & txtcari.Text & "%' and status=0").Fill(ds, "tsopir")
            dgvsopir.DataSource = ds.Tables("tsopir")
            conn.Close()
        End If
    End Sub

    Private Sub btnfilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilter.Click
        txtcari_TextChanged(sender, e)
    End Sub

    Private Sub dgvsopir_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsopir.CellClick
        If asal = 0 Then
            frmbm.txtKodeSopir.Text = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
            frmbm.lblNamaSopir.Text = dgvsopir.Rows(e.RowIndex).Cells("namasopir").Value
        Else
            If asal = 1 Then
                frmTotalSopir.txtkodesopir.Text = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
                frmTotalSopir.lblnamasopir.Text = dgvsopir.Rows(e.RowIndex).Cells("namasopir").Value
            Else
                If asal = 2 Then
                    frmTotalanAkhirNew.txtkodesopir.Text = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
                    frmTotalanAkhirNew.lblnamasopir.Text = dgvsopir.Rows(e.RowIndex).Cells("namasopir").Value
                Else
                    If asal = 3 Then
                        frmTotalSopirBaru.txtkodesopir.Text = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
                        frmTotalSopirBaru.lblnamasopir.Text = dgvsopir.Rows(e.RowIndex).Cells("namasopir").Value
                    Else
                        If asal = 4 Then
                            frmTotalanAkhirBaru.txtkodesopir.Text = dgvsopir.Rows(e.RowIndex).Cells("kodesopir").Value
                            frmTotalanAkhirBaru.lblnamasopir.Text = dgvsopir.Rows(e.RowIndex).Cells("namasopir").Value
                        End If
                    End If
                End If
            End If
        End If
        Me.Close()

    End Sub

    Private Sub dgvsopir_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsopir.CellContentClick

    End Sub
End Class
