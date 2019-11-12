Imports RjLibrary
Public Class frmParameter
    Dim _rjcommon As New RJCommon

    Private Sub frmParameter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtbbm.Text = _rjcommon.gethargabbm()
    End Sub
    Private Function ceksimpan() As Boolean
        Dim flag As Boolean = True
        Dim a As Double
        If Trim(txtbbm.Text) = "" Then
            flag = False
            _rjcommon.shownotifyerror("Harga BBM tidak Boleh Kosong")
        End If
        Try
            a = CDbl(txtbbm.Text)
        Catch ex As Exception
            flag = False
            _rjcommon.shownotifyerror("Harga BBM Harus Berupa Angka ")
        End Try
        Return flag
    End Function
    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If ceksimpan() Then
            _rjcommon.sethargabbm(txtbbm.Text)
            _rjcommon.isilog(_rjcommon.getusername, "", "Parameter", "Update Data", "")

            Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class