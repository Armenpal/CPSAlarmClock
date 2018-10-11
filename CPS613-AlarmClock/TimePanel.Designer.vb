<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimePanel
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
        Me.AMRadioButton = New System.Windows.Forms.RadioButton()
        Me.PMRadioButton = New System.Windows.Forms.RadioButton()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AMRadioButton
        '
        Me.AMRadioButton.AutoSize = True
        Me.AMRadioButton.Location = New System.Drawing.Point(250, 18)
        Me.AMRadioButton.Name = "AMRadioButton"
        Me.AMRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.AMRadioButton.TabIndex = 0
        Me.AMRadioButton.TabStop = True
        Me.AMRadioButton.Text = "AM"
        Me.AMRadioButton.UseVisualStyleBackColor = True
        '
        'PMRadioButton
        '
        Me.PMRadioButton.AutoSize = True
        Me.PMRadioButton.Location = New System.Drawing.Point(250, 41)
        Me.PMRadioButton.Name = "PMRadioButton"
        Me.PMRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.PMRadioButton.TabIndex = 1
        Me.PMRadioButton.TabStop = True
        Me.PMRadioButton.Text = "PM"
        Me.PMRadioButton.UseVisualStyleBackColor = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(127, 36)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 22)
        Me.TimeLabel.TabIndex = 2
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(3, 15)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 3
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(3, 51)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TimePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.PMRadioButton)
        Me.Controls.Add(Me.AMRadioButton)
        Me.Name = "TimePanel"
        Me.Size = New System.Drawing.Size(294, 86)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AMRadioButton As RadioButton
    Friend WithEvents PMRadioButton As RadioButton
    Friend WithEvents TimeLabel As Label
    Friend WithEvents SetButton As Button
    Friend WithEvents ResetButton As Button
End Class
