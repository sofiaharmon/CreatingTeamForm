Public Class Team
    Private Engineer As Employee
    Private TechList As New List(Of Employee)
    Private ProjName As String

    Public Sub New(ByVal e As Employee, ByVal tList As List(Of Employee), ByVal p As String)
        Engineer = e
        TechList = tList
        ProjName = p
    End Sub

    ReadOnly Property NumTechs() As Integer
        Get
            Return TechList.Count
        End Get
    End Property

    ReadOnly Property EngineerName() As String
        Get
            Return Engineer.eFirstName & " " & Engineer.eLastName
        End Get
    End Property

    ReadOnly Property Project() As String
        Get
            Return ProjName
        End Get
    End Property
End Class


Public Enum Position
    Engineer = 0
    Technician = 1
End Enum