﻿Module SoundEffects

    Public Sub PlaySoundEffect(ByVal sound As String)

        If sound = "Birds" Then
            My.Computer.Audio.Play("C:\Users\Armen\Desktop\CPS613\bird.wav")
        End If

        If sound = "Crows" Then
            My.Computer.Audio.Play("C:\Users\Armen\Desktop\CPS613\bird.wav")
        End If
        If sound = "Train" Then
            My.Computer.Audio.Play("C:\Users\Armen\Desktop\CPS613\bird.wav")
        End If
        If sound = "Boat Horn" Then
            My.Computer.Audio.Play("C:\Users\Armen\Desktop\CPS613\bird.wav")
        End If
        If sound = "Crickets" Then
            My.Computer.Audio.Play("C:\Users\Armen\Desktop\CPS613\bird.wav")
        End If

    End Sub

    Public Sub StopSoundEffect()
        My.Computer.Audio.Stop()
    End Sub

End Module
