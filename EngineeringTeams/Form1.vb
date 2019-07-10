Public Class Form1
    Private EngList, TechList As New List(Of Employee)
    Private TeamList As New List(Of Team)

    Private Sub mnuLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLoad.Click
        Dim fName As String = ""
        Dim lName As String = ""
        Dim typ As Integer
        If (dlgLoad.ShowDialog = Windows.Forms.DialogResult.OK) Then
            FileOpen(1, dlgLoad.FileName, OpenMode.Input)
            Do Until EOF(1)
                Input(1, lName)
                Input(1, fName)
                Input(1, typ)
                If (typ = Position.Engineer) Then
                    EngList.Add(New Employee(fName, lName, Position.Engineer))
                ElseIf (typ = Position.Technician) Then
                    TechList.Add(New Employee(fName, lName, Position.Technician))
                End If
            Loop
        End If
        fillListView()
        FileClose(1)
    End Sub

    Private Sub mnuCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCreate.Click
        Me.Visible = False
        Dim frmCreate As New Form2
        frmCreate.LoadEmployees(EngList, TechList, TeamList)
        If (frmCreate.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            fillListView()
        End If
        Me.Visible = True
    End Sub

    Private Sub mnuSave_Click_1(sender As Object, e As EventArgs)
        If (dlgLoad.ShowDialog = Windows.Forms.DialogResult.OK) Then
            FileOpen(2, dlgLoad.FileName, OpenMode.Output)
            For Each a In EngList
                PrintLine(2, a.eLastName & ", " & a.eFirstName & ", " & a.ePosition)
            Next
            For Each a In TechList
                PrintLine(2, a.eLastName & ", " & a.eFirstName & ", " & a.ePosition)
            Next
        End If
        FileClose(2)
    End Sub

    Public Sub fillListView()
        lvwTeams.Items.Clear()
        Dim Emp As Employee
        For Each Emp In EngList
            Dim newrow As New ListViewItem(Emp.eFirstName & " " & Emp.eLastName)
            newrow.SubItems.Add("Engineer")
            lvwTeams.Items.Add(newrow)
        Next
        For Each Emp In TechList
            Dim newrow As New ListViewItem(Emp.eFirstName & " " & Emp.eLastName)
            newrow.SubItems.Add("Technician")
            lvwTeams.Items.Add(newrow)
        Next
    End Sub

End Class