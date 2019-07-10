Public Class Employee
    Public eFirstName As String
    Public eLastName As String
    Public ePosition As Integer

    Public Sub New(ByVal first As String, ByVal last As String, ByVal p As Integer)
        eFirstName = first
        eLastName = last
        ePosition = p
    End Sub
End Class
