
Public Class AlarmPanel
    Public ListboxOptions As ListBox
    Public AlarmOnCheckBox As CheckBox


    Public Sub AlarmCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AlarmCheckBox.CheckedChanged

        sender = AlarmClock.AlarmClockTabs.SelectedTab.Name

        If sender = "AlarmTab1" And AlarmCheckBox.Checked Then
            AlarmClock.Alarm1CheckBox.Checked = True
        ElseIf sender = "AlarmTab1" And AlarmCheckBox.Checked = False Then
            AlarmClock.Alarm1CheckBox.Checked = False
        End If

        If sender = "AlarmTab2" And AlarmCheckBox.Checked Then
            AlarmClock.Alarm2CheckBox.Checked = True
        ElseIf sender = "AlarmTab2" And AlarmCheckBox.Checked = False Then
            AlarmClock.Alarm2CheckBox.Checked = False
        End If

        If sender = "AlarmTab3" And AlarmCheckBox.Checked Then
            AlarmClock.Alarm3CheckBox.Checked = True
        ElseIf sender = "AlarmTab3" And AlarmCheckBox.Checked = False Then
            AlarmClock.Alarm3CheckBox.Checked = False
        End If
    End Sub
End Class
