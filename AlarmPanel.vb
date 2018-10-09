
Public Class AlarmPanel

    Public Alarmsound As String

    Public Sub AnimatePicture()
        AlarmPictureBox.Enabled = True
    End Sub

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

    Public Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        sender = ListBox.SelectedItem

        Select Case sender

            Case "Birds"
                Alarmsound = "Brids"

            Case "Crows"
                Alarmsound = "Crows"

            Case "Train"
                Alarmsound = "Train"

            Case "Crickets"
                Alarmsound = "Crickets"

            Case "Boat Horn"
                Alarmsound = "Boat Horn"
        End Select
    End Sub

    Private Sub AlarmPictureBox_Click(sender As Object, e As EventArgs) Handles AlarmPictureBox.Click
        AlarmPictureBox.Enabled = False
    End Sub
End Class
