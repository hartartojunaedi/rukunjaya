Public Class RJSecurity
    Public Function enkripsi(ByVal value As String, ByVal key As String) As String
        Dim temp As String = ""
        Dim i As Integer
        For i = 0 To value.Length - 1
            temp &= Chr(Asc(value.Substring(i, 1)) + Asc(Mid(key, i Mod key.Length + 1, 1)))
        Next
        Return temp
    End Function

    Public Function dekripsi(ByVal value As String, ByVal key As String) As String
        Dim temp As String = ""
        Dim i As Integer
        For i = 0 To value.Length - 1
            temp &= Chr(Asc(value.Substring(i, 1)) - Asc(Mid(key, i Mod key.Length + 1, 1)))
        Next
        Return temp
    End Function
End Class
