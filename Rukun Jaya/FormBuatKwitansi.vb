Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormBuatKwitansi

    Function Terbilang(ByVal myNum As Double) As String
        Dim myString As String() = {"", "satu", "dua", "tiga", "empat", "lima", _
        "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        Dim myTmpString As String = ""
        Select Case myNum
            Case Is < 12
                myTmpString = myString(myNum)
            Case Is < 20
                myTmpString = Terbilang(myNum - 10) + " " + "belas"
            Case Is < 100
                If Microsoft.VisualBasic.Right(myNum, 1) > 0 Then
                    myTmpString = Terbilang(Int(myNum / 10)) + " " + "puluh" + " " + Terbilang(myNum Mod 10)
                Else
                    myTmpString = Terbilang(Int(myNum / 10)) + " " + "puluh"
                End If
            Case Is < 200
                myTmpString = "seratus" + " " + Terbilang(myNum - 100)
            Case Is < 1000
                myTmpString = Terbilang(Int(myNum / 100)) + " " + "ratus" + " " + Terbilang(myNum Mod 100)
            Case Is < 2000
                myTmpString = "seribu" + " " + Terbilang(myNum - 1000)
            Case Is < 1000000
                myTmpString = Terbilang(Int(myNum / 1000)) + " " + "ribu" + " " + Terbilang(myNum Mod 1000)
            Case Is < 1000000000
                myTmpString = Terbilang(Int(myNum / 1000000)) + " " + "juta" + " " + Terbilang(myNum Mod 1000000)
            Case Is < 1000000000000
                myTmpString = Terbilang(Int(myNum / 1000000000)) + " " + "milyar" + " " + Terbilang(myNum Mod 1000000000)
            Case Is < 1000000000000000
                myTmpString = Terbilang(Int(myNum / 1000000000000)) + " " + "trilyun" + " " + Terbilang(myNum Mod 1000000000000)
        End Select
        Return myTmpString
    End Function

    Public Sub cetak()
        Dim report As New kwitansi
        DirectCast(report.ReportDefinition.ReportObjects("Perusahaan"), TextObject).Text = txtheader.Text
        report.SetParameterValue("pengirim", txtPengirim.Text)
        report.SetParameterValue("penerima", txtPenerima.Text)
        report.SetParameterValue("nomor", txtNo.Text)
        report.SetParameterValue("nominal", FormatNumber(txtNominal.Text, 2, , , TriState.True))
        report.SetParameterValue("terbilang", Terbilang(txtNominal.Text) + " rupiah")
        report.SetParameterValue("ket", txtKeterangan.Text)
        frmcetaklaporan.CrystalReportViewer1.ReportSource = report
        frmcetaklaporan.CrystalReportViewer1.Refresh()
        frmcetaklaporan.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
        frmcetaklaporan.ShowDialog()
    End Sub

    Private Sub btnBuat_Click(sender As System.Object, e As System.EventArgs) Handles btnBuat.Click
        cetak()
    End Sub

    Private Sub FormBuatKwitansi_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub

    Private Sub FormBuatKwitansi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
