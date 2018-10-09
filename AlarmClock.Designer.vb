<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlarmClock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlarmClock))
        Me.AlarmClockTabs = New System.Windows.Forms.TabControl()
        Me.ClockTab = New System.Windows.Forms.TabPage()
        Me.ClockKeypad = New CPS613_AlarmClock.Keypad()
        Me.Alarm3CheckBox = New System.Windows.Forms.CheckBox()
        Me.Alarm2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Alarm1CheckBox = New System.Windows.Forms.CheckBox()
        Me.ClockTimePanel = New CPS613_AlarmClock.TimePanel()
        Me.AlarmTab1 = New System.Windows.Forms.TabPage()
        Me.Alarm1Panel = New CPS613_AlarmClock.AlarmPanel()
        Me.AlarmTab2 = New System.Windows.Forms.TabPage()
        Me.Alarm2Panel = New CPS613_AlarmClock.AlarmPanel()
        Me.AlarmTab3 = New System.Windows.Forms.TabPage()
        Me.Alarm3Panel = New CPS613_AlarmClock.AlarmPanel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlarmClockTabs.SuspendLayout()
        Me.ClockTab.SuspendLayout()
        Me.AlarmTab1.SuspendLayout()
        Me.AlarmTab2.SuspendLayout()
        Me.AlarmTab3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlarmClockTabs
        '
        Me.AlarmClockTabs.Controls.Add(Me.ClockTab)
        Me.AlarmClockTabs.Controls.Add(Me.AlarmTab1)
        Me.AlarmClockTabs.Controls.Add(Me.AlarmTab2)
        Me.AlarmClockTabs.Controls.Add(Me.AlarmTab3)
        Me.AlarmClockTabs.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmClockTabs.Location = New System.Drawing.Point(12, 12)
        Me.AlarmClockTabs.Name = "AlarmClockTabs"
        Me.AlarmClockTabs.SelectedIndex = 0
        Me.AlarmClockTabs.Size = New System.Drawing.Size(508, 515)
        Me.AlarmClockTabs.TabIndex = 0
        '
        'ClockTab
        '
        Me.ClockTab.Controls.Add(Me.PictureBox1)
        Me.ClockTab.Controls.Add(Me.ClockKeypad)
        Me.ClockTab.Controls.Add(Me.Alarm3CheckBox)
        Me.ClockTab.Controls.Add(Me.Alarm2CheckBox)
        Me.ClockTab.Controls.Add(Me.Alarm1CheckBox)
        Me.ClockTab.Controls.Add(Me.ClockTimePanel)
        Me.ClockTab.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTab.Location = New System.Drawing.Point(4, 25)
        Me.ClockTab.Name = "ClockTab"
        Me.ClockTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ClockTab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClockTab.Size = New System.Drawing.Size(500, 486)
        Me.ClockTab.TabIndex = 0
        Me.ClockTab.Text = "Clock"
        Me.ClockTab.UseVisualStyleBackColor = True
        '
        'ClockKeypad
        '
        Me.ClockKeypad.Location = New System.Drawing.Point(65, 334)
        Me.ClockKeypad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClockKeypad.Name = "ClockKeypad"
        Me.ClockKeypad.Size = New System.Drawing.Size(357, 143)
        Me.ClockKeypad.TabIndex = 6
        '
        'Alarm3CheckBox
        '
        Me.Alarm3CheckBox.AutoSize = True
        Me.Alarm3CheckBox.Location = New System.Drawing.Point(341, 242)
        Me.Alarm3CheckBox.Name = "Alarm3CheckBox"
        Me.Alarm3CheckBox.Size = New System.Drawing.Size(68, 20)
        Me.Alarm3CheckBox.TabIndex = 5
        Me.Alarm3CheckBox.Text = "Alarm3"
        Me.Alarm3CheckBox.UseVisualStyleBackColor = True
        '
        'Alarm2CheckBox
        '
        Me.Alarm2CheckBox.AutoSize = True
        Me.Alarm2CheckBox.Location = New System.Drawing.Point(341, 204)
        Me.Alarm2CheckBox.Name = "Alarm2CheckBox"
        Me.Alarm2CheckBox.Size = New System.Drawing.Size(68, 20)
        Me.Alarm2CheckBox.TabIndex = 4
        Me.Alarm2CheckBox.Text = "Alarm2"
        Me.Alarm2CheckBox.UseVisualStyleBackColor = True
        '
        'Alarm1CheckBox
        '
        Me.Alarm1CheckBox.AutoSize = True
        Me.Alarm1CheckBox.Location = New System.Drawing.Point(341, 165)
        Me.Alarm1CheckBox.Name = "Alarm1CheckBox"
        Me.Alarm1CheckBox.Size = New System.Drawing.Size(68, 20)
        Me.Alarm1CheckBox.TabIndex = 3
        Me.Alarm1CheckBox.Text = "Alarm1"
        Me.Alarm1CheckBox.UseVisualStyleBackColor = True
        '
        'ClockTimePanel
        '
        Me.ClockTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClockTimePanel.Location = New System.Drawing.Point(77, 6)
        Me.ClockTimePanel.Name = "ClockTimePanel"
        Me.ClockTimePanel.Size = New System.Drawing.Size(362, 106)
        Me.ClockTimePanel.TabIndex = 0
        '
        'AlarmTab1
        '
        Me.AlarmTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlarmTab1.Controls.Add(Me.Alarm1Panel)
        Me.AlarmTab1.ForeColor = System.Drawing.Color.Black
        Me.AlarmTab1.Location = New System.Drawing.Point(4, 25)
        Me.AlarmTab1.Name = "AlarmTab1"
        Me.AlarmTab1.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTab1.Size = New System.Drawing.Size(500, 486)
        Me.AlarmTab1.TabIndex = 1
        Me.AlarmTab1.Text = "Alarm 1"
        Me.AlarmTab1.UseVisualStyleBackColor = True
        '
        'Alarm1Panel
        '
        Me.Alarm1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alarm1Panel.ForeColor = System.Drawing.Color.Black
        Me.Alarm1Panel.Location = New System.Drawing.Point(-5, -1)
        Me.Alarm1Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Alarm1Panel.Name = "Alarm1Panel"
        Me.Alarm1Panel.Size = New System.Drawing.Size(504, 482)
        Me.Alarm1Panel.TabIndex = 0
        '
        'AlarmTab2
        '
        Me.AlarmTab2.Controls.Add(Me.Alarm2Panel)
        Me.AlarmTab2.Location = New System.Drawing.Point(4, 25)
        Me.AlarmTab2.Name = "AlarmTab2"
        Me.AlarmTab2.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTab2.Size = New System.Drawing.Size(500, 486)
        Me.AlarmTab2.TabIndex = 2
        Me.AlarmTab2.Text = "Alarm 2"
        Me.AlarmTab2.UseVisualStyleBackColor = True
        '
        'Alarm2Panel
        '
        Me.Alarm2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alarm2Panel.Location = New System.Drawing.Point(-4, 0)
        Me.Alarm2Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Alarm2Panel.Name = "Alarm2Panel"
        Me.Alarm2Panel.Size = New System.Drawing.Size(503, 479)
        Me.Alarm2Panel.TabIndex = 0
        '
        'AlarmTab3
        '
        Me.AlarmTab3.Controls.Add(Me.Alarm3Panel)
        Me.AlarmTab3.Location = New System.Drawing.Point(4, 25)
        Me.AlarmTab3.Name = "AlarmTab3"
        Me.AlarmTab3.Padding = New System.Windows.Forms.Padding(3)
        Me.AlarmTab3.Size = New System.Drawing.Size(500, 486)
        Me.AlarmTab3.TabIndex = 3
        Me.AlarmTab3.Text = "Alarm 3"
        Me.AlarmTab3.UseVisualStyleBackColor = True
        '
        'Alarm3Panel
        '
        Me.Alarm3Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alarm3Panel.Location = New System.Drawing.Point(-4, 0)
        Me.Alarm3Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Alarm3Panel.Name = "Alarm3Panel"
        Me.Alarm3Panel.Size = New System.Drawing.Size(500, 603)
        Me.Alarm3Panel.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 97)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'AlarmClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 527)
        Me.Controls.Add(Me.AlarmClockTabs)
        Me.Name = "AlarmClock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Armen Palvetzian"
        Me.AlarmClockTabs.ResumeLayout(False)
        Me.ClockTab.ResumeLayout(False)
        Me.ClockTab.PerformLayout()
        Me.AlarmTab1.ResumeLayout(False)
        Me.AlarmTab2.ResumeLayout(False)
        Me.AlarmTab3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AlarmClockTabs As TabControl
    Friend WithEvents AlarmTab3 As TabPage
    Friend WithEvents ClockTab As TabPage
    Friend WithEvents AlarmTab1 As TabPage
    Friend WithEvents AlarmTab2 As TabPage
    Friend WithEvents ClockTimePanel As TimePanel
    Friend WithEvents Alarm3CheckBox As CheckBox
    Friend WithEvents Alarm2CheckBox As CheckBox
    Friend WithEvents Alarm1CheckBox As CheckBox
    Friend WithEvents Alarm3Panel As AlarmPanel
    Friend WithEvents Alarm2Panel As AlarmPanel
    Friend WithEvents Alarm1Panel As AlarmPanel
    Friend WithEvents ClockKeypad As Keypad
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
