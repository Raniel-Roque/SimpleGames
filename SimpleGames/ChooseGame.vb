Public Class ChooseGame
    'Programmer: Raniel Christian Roque
    'BSIT - 2A
    'Date: October 22 2023
    Dim Load_Game As LoadGame
    Dim Lottery_Game As Lottery
    Dim Lucky_9_Game As Lucky9
    Dim CToss_Game As CToss
    Dim JEP_Game As JEP
    'Cash Format
    Private Sub UpdateCashDisplay()
        If GlobalData.CashGlobal = 0 Then
            ToolStripMenuItem2.Text = "Cash: ₱0"
        Else
            ToolStripMenuItem2.Text = "Cash: " + Format(GlobalData.CashGlobal, "₱#,##")
        End If
    End Sub
    Private Sub ChooseGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateCashDisplay()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Go back to Loading Screen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Load_Game Is Nothing Then
                Load_Game = New LoadGame
            End If
            LoadGame.Show()
            Me.Close()
        End If
    End Sub
    'Add Cash Input
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
    Private Sub JEP_Click(sender As Object, e As EventArgs) Handles JEP.Click
        Dim result As DialogResult = MessageBox.Show("Play Jack En' Poy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If JEP_Game Is Nothing Then
                JEP_Game = New JEP
            End If
            JEP_Game.Show()
            Me.Close()
        End If
    End Sub
End Class