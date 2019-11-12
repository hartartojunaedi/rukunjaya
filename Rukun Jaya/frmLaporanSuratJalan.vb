Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RjLibrary


Public Class frmLaporanSuratJalan

    Private Sub frmLaporanSuratJalan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbStatus.SelectedIndex = 0
        dtpAKhirPeriode.Value = DateAndTime.Today
        If DateAndTime.Today.Month = 1 Then
            dtpAwalPeriode.Value = "01-12-" & DateAndTime.Today.Year - 1
        Else
            dtpAwalPeriode.Value = "01-" & DateAndTime.Today.Month - 1
        End If
        'CrystalReportViewer1.PrintReport()
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim rj As New RJCommon
        Dim cn As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim adap1 As New SqlDataAdapter
        Try
            cn = New SqlConnection
            cn.ConnectionString = rj.getconnstr

            'Dim command As String = ""
            'command = "Select s.nobm,k.nopol,s.noSuratJalan,sr.namasopir, g1.namagudang as asal,g2.namagudang as tujuan,sp.namasupplier,s.tgl "
            'command &= " from tSuratJalan s,tkendaraan k,tgudang g1, tgudang g2,tsupplier sp,tsopir sr, tbm b "
            'command &= " where b.nobm=s.nobm and b.kodesopir=sr.kodesopir and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang "
            'command &= " and s.kodesupplier=sp.kodesupplier and k.nolambung=b.nolambung and s.status='0' order by s.tgl asc"

            cmd1.Connection = cn
            cmd1.CommandType = CommandType.Text
            cmd1.Parameters.Clear()
            cmd1.CommandText = "select s.nobm,k.nopol,s.noSuratJalan,sr.namasopir, g1.namagudang as asal,g2.namagudang as tujuan,sp.namasupplier,s.tgl from tSuratJalan s,tkendaraan k,tgudang g1, tgudang g2,tsupplier sp,tsopir sr, tbm b where b.nobm=s.nobm and b.kodesopir=sr.kodesopir and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang  and s.kodesupplier=sp.kodesupplier and k.nolambung=b.nolambung and s.tgl>=@tglawal and s.tgl<=@tglakhir"
            'cmd1.CommandText = "select s.*,k.*,sr.*, g1.namagudang as asal,g2.namagudang as tujuan,sp.* from tSuratJalan s,tkendaraan k,tgudang g1, tgudang g2,tsupplier sp,tsopir sr, tbm b where b.nobm=s.nobm and b.kodesopir=sr.kodesopir and s.asal=g1.kodegudang and s.tujuan=g2.kodegudang  and s.kodesupplier=sp.kodesupplier and k.nolambung=b.nolambung and s.tgl>=@tglawal and s.tgl<=@tglakhir"

            cmd1.Parameters.AddWithValue("@tglawal", dtpAwalPeriode.Value.Date)
            cmd1.Parameters.AddWithValue("@tglakhir", dtpAKhirPeriode.Value.Date)

            Dim statusval As New CrystalDecisions.Shared.ParameterDiscreteValue

            If cbStatus.SelectedIndex = 0 Then
                cmd1.CommandText &= " and s.Status=1"
                statusval.Value = "Sudah Setor"
            Else
                cmd1.CommandText &= " and s.Status=0"
                statusval.Value = "Belum Setor"

            End If
            'MsgBox(cmd1.CommandText)
            adap1.SelectCommand = cmd1

            cn.Close()
            cn.Open()
            adap1.Fill(ds, "suratjalan")
            cn.Close()

            
            'Dim pVal, pval1 As New CrystalDecisions.Shared.ParameterDiscreteValue
            'pVal.Value = dtpAwalPeriode.Value.Date
            'pval1.Value = dtpAKhirPeriode.Value.Date
            'Dim pField, pField1, pfield2 As New CrystalDecisions.Shared.ParameterField
            'pField.Name = "PeriodeAwal"
            'pField.CurrentValues.Add(pVal)
            'pField.HasCurrentValue = True

            'pField1.Name = "PeriodeAkhir"
            'pField1.CurrentValues.Add(pval1)
            'pField1.HasCurrentValue = True

            'pfield2.Name = "Status Setor"
            'pfield2.CurrentValues.Add(statusval)
            'pfield2.HasCurrentValue = True


            If ds.Tables("suratJalan").Rows.Count > 0 Then
                'jun 10 feb 2015
                Dim rep As New LapSetorSuratJalan
                rep.SetDataSource(ds.Tables("suratjalan"))
                'jun 10 feb 2015
                ' rep.SetParameterValue("PeriodeAwal", dtpAwalPeriode.Value.ToString("dd-MM-yyyy"))
                'rep.SetParameterValue("PeriodeAkhir", dtpAKhirPeriode.Value.ToString("dd-MM-yyyy"))
                DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAwal"), TextObject).Text = dtpAwalPeriode.Value.ToString("dd-MM-yyyy")
                DirectCast(rep.ReportDefinition.ReportObjects("PeriodeAkhir"), TextObject).Text = dtpAKhirPeriode.Value.ToString("dd-MM-yyyy")
                DirectCast(rep.ReportDefinition.ReportObjects("Status"), TextObject).Text = Trim(statusval.Value.ToString)
                'rep.SetParameterValue("Status Setor", statusval.ToString)
                frmlaporan.CrystalReportViewer1.ReportSource = rep

                'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pField1)
                'frmlaporan.CrystalReportViewer1.ParameterFieldInfo.Add(pfield2)
                frmlaporan.CrystalReportViewer1.RefreshReport()
                frmlaporan.ShowDialog()
            Else
                rj.shownotifyerror("No Record Found To Display")
            End If
            

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try

    End Sub

 
End Class