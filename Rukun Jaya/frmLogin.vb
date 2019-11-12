Imports RjLibrary
Public Class frmLogin
    Dim _rjcommon As New RJCommon
    Dim sukses As Boolean = False
    Public Function GetExceptionText(ByVal Ex As Exception) As String
        Dim trace As StackTrace = New StackTrace(Ex, True)
        Dim msg As String = Ex.Message & vbCrLf
        Try
            For Each frame As StackFrame In trace.GetFrames
                msg &= vbCrLf & "At " & frame.GetMethod.Name & " (" & frame.GetFileLineNumber & ")"
                Dim name As String = System.IO.Path.GetFileName(frame.GetFileName)
                If name <> "" Then msg &= " in " & name
            Next
        Catch
        End Try
        Return msg
    End Function
    Public Sub ShowExceptionDialog(ByVal Ex As Exception)
        MessageBox.Show(GetExceptionText(Ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnKeluar.Click
        If sukses Then
            _rjcommon.isilogout(txtUsername.Text)
        End If
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'backdoor
        Try
            If txtUsername.Text = "Admin" And txtPassword.Text = "Backdoor" Then
                _rjcommon.isilogin(txtUsername.Text)
                sukses = True
                frmUtama.ShowDialog()
            Else
                If _rjcommon.cekusername(txtUsername.Text, txtPassword.Text) Then
                    _rjcommon.isilogin(txtUsername.Text)
                    sukses = True
                    frmUtama.ShowDialog()
                Else
                    sukses = False
                    MsgBox("Username atau Password Salah", MsgBoxStyle.Exclamation, "Peringatan")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter And (Me.ActiveControl.GetType() = GetType(TextBox))) Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
        If e.KeyCode = Keys.F2 Then
            If Me.Height = 172 Then
                Me.Height = 141
            Else
                Me.Height = 172
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            txtconn.Text = _rjcommon.getconnstr()
            'txtUsername.Text = _rjcommon.getusername()

        Catch ex As Exception
            ShowExceptionDialog(ex)
        End Try
    End Sub

    Private Sub frmLogin_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If sukses Then
            _rjcommon.isilogout(txtUsername.Text)
        End If
    End Sub
End Class