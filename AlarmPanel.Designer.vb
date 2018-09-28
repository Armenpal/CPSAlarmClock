<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.AlarmCheckBox = New System.Windows.Forms.CheckBox()
        Me.TimePanel = New CPS613_AlarmClock.TimePanel()
        Me.AlarmKeypad = New CPS613_AlarmClock.Keypad()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Items.AddRange(New Object() {"Cricket", "Ocean", "Birds", "Amazon Rain Forest", "????", "Nuclear Bomb", "Party", "Highway"})
        Me.ListBox.Location = New System.Drawing.Point(240, 137)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(120, 95)
        Me.ListBox.TabIndex = 3
        '
        'AlarmCheckBox
        '
        Me.AlarmCheckBox.AutoSize = True
        Me.AlarmCheckBox.Location = New System.Drawing.Point(240, 238)
        Me.AlarmCheckBox.Name = "AlarmCheckBox"
        Me.AlarmCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.AlarmCheckBox.TabIndex = 4
        Me.AlarmCheckBox.Text = "Alarm On"
        Me.AlarmCheckBox.UseVisualStyleBackColor = True
        '
        'TimePanel
        '
        Me.TimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimePanel.Location = New System.Drawing.Point(27, 3)
        Me.TimePanel.Name = "TimePanel"
        Me.TimePanel.Size = New System.Drawing.Size(333, 86)
        Me.TimePanel.TabIndex = 0
        '
        'AlarmKeypad
        '
        Me.AlarmKeypad.Location = New System.Drawing.Point(50, 257)
        Me.AlarmKeypad.Name = "AlarmKeypad"
        Me.AlarmKeypad.Size = New System.Drawing.Size(310, 123)
        Me.AlarmKeypad.TabIndex = 5
        '
        'AlarmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.AlarmKeypad)
        Me.Controls.Add(Me.AlarmCheckBox)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.TimePanel)
        Me.Name = "AlarmPanel"
        Me.Size = New System.Drawing.Size(403, 383)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimePanel As TimePanel
    Friend WithEvents ListBox As ListBox
    Friend WithEvents AlarmCheckBox As CheckBox
    Friend WithEvents AlarmKeypad As Keypad
End Class
