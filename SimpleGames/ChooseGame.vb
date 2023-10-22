﻿Public Class ChooseGame
    Dim Choose_Game_Main As ChooseGame
    Dim Lottery_Game As Lottery
    Dim Lucky_9_Game As Lucky9
    Dim CToss_Game As CToss
    Private Sub UpdateCashDisplay()
        If GlobalData.CashGlobal = 0 Then
            ToolStripMenuItem2.Text = "Cash: ₱0"
        Else
            ToolStripMenuItem2.Text = "Cash: " + Format(GlobalData.CashGlobal, "₱#,##")
        End If
    End Sub
    Private Sub ChooseGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
        UpdateCashDisplay()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Choose Another Game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Choose_Game_Main Is Nothing Then
                Choose_Game_Main = New ChooseGame
            End If
            Choose_Game_Main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AddCashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim inputBox As New AddCash()
        If inputBox.ShowDialog() = DialogResult.OK Then
            GlobalData.CashGlobal += ULong.Parse(inputBox.Input)
            UpdateCashDisplay()
        End If
    End Sub
    Private Sub Lucky9_Click(sender As Object, e As EventArgs) Handles Lucky9.Click
        Dim result As DialogResult = MessageBox.Show("Play Lucky 9?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Lucky_9_Game Is Nothing Then
                Lucky_9_Game = New Lucky9
            End If
            Lucky_9_Game.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Lottery_Click(sender As Object, e As EventArgs) Handles Lottery.Click
        Dim result As DialogResult = MessageBox.Show("Play Lottery?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Lottery_Game Is Nothing Then
                Lottery_Game = New Lottery
            End If
            Lottery_Game.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CToss_Click(sender As Object, e As EventArgs) Handles CToss.Click
        Dim result As DialogResult = MessageBox.Show("Play Coin Toss?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If CToss_Game Is Nothing Then
                CToss_Game = New CToss
            End If
            CToss_Game.Show()
            Me.Close()
        End If
    End Sub
End Class