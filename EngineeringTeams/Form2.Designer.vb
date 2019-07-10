<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbxProjectName = New System.Windows.Forms.TextBox()
        Me.cmbEng = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxTeam = New System.Windows.Forms.ListBox()
        Me.lbxAvailable = New System.Windows.Forms.ListBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxProjectName
        '
        Me.tbxProjectName.Location = New System.Drawing.Point(31, 26)
        Me.tbxProjectName.Name = "tbxProjectName"
        Me.tbxProjectName.Size = New System.Drawing.Size(380, 38)
        Me.tbxProjectName.TabIndex = 0
        '
        'cmbEng
        '
        Me.cmbEng.FormattingEnabled = True
        Me.cmbEng.Location = New System.Drawing.Point(31, 94)
        Me.cmbEng.Name = "cmbEng"
        Me.cmbEng.Size = New System.Drawing.Size(380, 39)
        Me.cmbEng.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbxTeam)
        Me.GroupBox1.Controls.Add(Me.lbxAvailable)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 382)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Technicians"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(342, 231)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(83, 64)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "<--"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(342, 154)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 61)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "-->"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Team Members:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Available:"
        '
        'lbxTeam
        '
        Me.lbxTeam.FormattingEnabled = True
        Me.lbxTeam.ItemHeight = 31
        Me.lbxTeam.Location = New System.Drawing.Point(431, 93)
        Me.lbxTeam.Name = "lbxTeam"
        Me.lbxTeam.Size = New System.Drawing.Size(289, 283)
        Me.lbxTeam.TabIndex = 1
        '
        'lbxAvailable
        '
        Me.lbxAvailable.BackColor = System.Drawing.SystemColors.Window
        Me.lbxAvailable.FormattingEnabled = True
        Me.lbxAvailable.ItemHeight = 31
        Me.lbxAvailable.Location = New System.Drawing.Point(25, 93)
        Me.lbxAvailable.Name = "lbxAvailable"
        Me.lbxAvailable.Size = New System.Drawing.Size(306, 283)
        Me.lbxAvailable.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(445, 26)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(329, 53)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Team"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(445, 85)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(329, 54)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 564)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbEng)
        Me.Controls.Add(Me.tbxProjectName)
        Me.Name = "Form2"
        Me.Text = "Create a Team"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxProjectName As TextBox
    Friend WithEvents cmbEng As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbxTeam As ListBox
    Friend WithEvents lbxAvailable As ListBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemove As Button
End Class
