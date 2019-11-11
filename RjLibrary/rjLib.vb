Public Class rjLib
    Public Function RemoveNonNumeric(ByVal postcode As String) As String
        Dim a As String = postcode
        Dim b As String = ""
        Dim c As String = ""
        For i As Integer = 0 To a.Length - 1
            If (a(i) <= ChrW(47)) Or (a(i) >= ChrW(58)) Then
            Else
                b = b & a(i)
            End If
        Next
        c = b
        If a.Length = 0 Then
            c = "0"
        End If
        Return c
    End Function
End Class
