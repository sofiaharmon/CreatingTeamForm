Public Class Form2
    Private availableTechList, availableEngList As List(Of Employee)
    Private TeamList As List(Of Team)
    Private addedTechList As New List(Of Employee)
    Private index As Integer

    Public Sub LoadEmployees(ByRef EngList As List(Of Employee), ByRef TechList As List(Of Employee),
                         ByRef TList As List(Of Team))
        availableEngList = EngList
        availableTechList = TechList
        TeamList = TList
        tbxProjectName.Text = "Enter the Project Name"
        cmbEng.Text = "Select an Engineer"
        updateDisplay()
    End Sub

    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If index > -1 Then
            Dim newTeam As New Team(availableEngList(index), addedTechList, tbxProjectName.Text)
            TeamList.Add(newTeam)
            availableEngList.RemoveAt(index)
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim t As Employee
        For Each t In addedTechList
            availableTechList.Add(t)
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim i As Int32 = lbxAvailable.SelectedIndex()
        addedTechList.Add(availableTechList(i))
        availableTechList.RemoveAt(i)
        updateDisplay()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim i As Int32 = lbxTeam.SelectedIndex()
        availableTechList.Add(addedTechList(i))
        addedTechList.RemoveAt(i)
        updateDisplay()
    End Sub

    Private Sub updateDisplay()
        cmbEng.Items.Clear()
        lbxAvailable.Items.Clear()
        lbxTeam.Items.Clear()
        For Each a In availableEngList
            cmbEng.Items.Add(a.eFirstName & " " & a.eLastName)
        Next
        For Each b In addedTechList
            lbxTeam.Items.Add(b.eFirstName & " " & b.eLastName)
        Next
        For Each c In availableTechList
            lbxAvailable.Items.Add(c.eFirstName & " " & c.eLastName)
        Next
    End Sub

    Private Sub cmbEng_SelectedValueChanged(ByVal sender As Object, ByVal e As _
                                        System.EventArgs) Handles cmbEng.SelectedValueChanged
        index = cmbEng.SelectedIndex
    End Sub
End Class