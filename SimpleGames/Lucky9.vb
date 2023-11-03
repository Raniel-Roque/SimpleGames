﻿Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
'Programmer: Raniel Christian Roque
'BSIT - 2A
'Date: October 22 2023
Public Class Lucky9
    Dim Rand As New Random()
    Dim Choose_Game_Main As ChooseGame
    Dim ComCard1, ComCard2, ComCard3, PlayerCard1, PlayerCard2, PlayerCard3, ComTotal, PlayerTotal As Integer
    Dim Cards() As Image = {
        My.Resources.ace_spades_white, My.Resources._2_spades_white, My.Resources._3_spades_white, My.Resources._4_spades_white, My.Resources._5_spades_white, My.Resources._6_spades_white, My.Resources._7_spades_white, My.Resources._8_spades_white, My.Resources._9_spades_white, My.Resources._10_spades_white,
        My.Resources.ace_diamonds_white, My.Resources._2_diamonds_white, My.Resources._3_diamonds_white, My.Resources._4_diamonds_white, My.Resources._5_diamonds_white, My.Resources._6_diamonds_white, My.Resources._7_diamonds_white, My.Resources._8_diamonds_white, My.Resources._9_diamonds_white, My.Resources._10_diamonds_white,
        My.Resources.ace_clubs_white, My.Resources._2_clubs_white, My.Resources._3_clubs_white, My.Resources._4_clubs_white, My.Resources._5_clubs_white, My.Resources._6_clubs_white, My.Resources._7_clubs_white, My.Resources._8_clubs_white, My.Resources._9_clubs_white, My.Resources._10_clubs_white,
        My.Resources.ace_hearts_white, My.Resources._2_hearts_white, My.Resources._3_hearts_white, My.Resources._4_hearts_white, My.Resources._5_hearts_white, My.Resources._6_hearts_white, My.Resources._7_hearts_white, My.Resources._8_hearts_white, My.Resources._9_hearts_white, My.Resources._10_hearts_white
    }
    Private Sub UpdateCashDisplay()
        If GlobalData.CashGlobal = 0 Then
            ToolStripMenuItem2.Text = "Cash: ₱0"
        Else
            ToolStripMenuItem2.Text = "Cash: " + Format(GlobalData.CashGlobal, "₱#,##")
        End If
    End Sub
    Private Sub ChooseGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Enter Bet"
        TextBox1.ForeColor = Color.Gray
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

    Private Sub Draw_Click(sender As Object, e As EventArgs) Handles Draw.Click
        Dim result As Integer

        If Not ULong.TryParse(TextBox1.Text, result) Then
            MessageBox.Show("Please Enter a Valid Amount", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = "Enter Bet"
            TextBox1.ForeColor = Color.Gray
            Return
        ElseIf TextBox1.Text = Nothing OrElse TextBox1.Text = "Enter Bet" OrElse TextBox1.Text = 0 Then
            MessageBox.Show("Please Bet an Amount", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = "Enter Bet"
            TextBox1.ForeColor = Color.Gray
            Return
        End If

        If (GlobalData.CashGlobal - TextBox1.Text) < 0 Then
            MessageBox.Show("Insufficient Cash", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Dim Answer As DialogResult = MessageBox.Show("Add More Cash? 
You can manually add more by clicking your cash balance.", "Add Cash", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If Answer = DialogResult.Yes Then
                Dim inputBox As New AddCash()
                If inputBox.ShowDialog() = DialogResult.OK Then
                    GlobalData.CashGlobal += ULong.Parse(inputBox.Input)
                    UpdateCashDisplay()
                End If
            End If
            Return
        End If

        GlobalData.CashGlobal -= TextBox1.Text
        UpdateCashDisplay()
        HomeToolStripMenuItem.Enabled = False
        Draw.Enabled = False
        TextBox1.ReadOnly = True

        'START OF FUNCTION
        'Randomizes Computer 1st Card
        ComCard1 = Rand.Next(0, 40)
        My.Computer.Audio.Play(My.Resources.CardFlip, AudioPlayMode.WaitToComplete)

        'Loops Until it gets a non repeated number/card
        Do While True
            ComCard2 = Rand.Next(0, 40)

            If ComCard2 <> ComCard1 Then
                Exit Do
            End If
        Loop

        Do While True
            PlayerCard1 = Rand.Next(0, 40)

            If PlayerCard1 <> ComCard1 AndAlso PlayerCard1 <> ComCard2 Then
                PlayerPic1.Image = Cards(PlayerCard1)
                Exit Do
            End If
        Loop

        Do While True
            PlayerCard2 = Rand.Next(0, 40)

            If PlayerCard2 <> ComCard1 AndAlso PlayerCard2 <> ComCard2 AndAlso PlayerCard2 <> PlayerCard1 Then
                PlayerPic2.Image = Cards(PlayerCard2)
                Exit Do
            End If
        Loop

        'Plays Thinking Music
        'Sets Carat and Pass Visible
        My.Computer.Audio.Play(My.Resources.ThinkingLucky9, AudioPlayMode.BackgroundLoop)
        Carat.Visible = True
        Pass.Visible = True
    End Sub
    Private Sub Carat_Click(sender As Object, e As EventArgs) Handles Carat.Click
        My.Computer.Audio.Play(My.Resources.CardFlip, AudioPlayMode.WaitToComplete)
        Carat.Visible = False
        Pass.Visible = False

        Do While True
            PlayerCard3 = Rand.Next(0, 40)

            If PlayerCard3 <> ComCard1 AndAlso PlayerCard3 <> ComCard2 AndAlso PlayerCard3 <> PlayerCard1 AndAlso PlayerCard3 <> PlayerCard2 Then
                PlayerPic3.Image = Cards(PlayerCard3)
                Exit Do
            End If
        Loop

        'Special Rules: If Flush (Same Type and then 2-3-4) Auto Win
        'Special Rules 2: If 3-3-3 then Auto Win
        If (PlayerCard1 = 1 AndAlso PlayerCard2 = 2 AndAlso PlayerCard3 = 3) OrElse (PlayerCard1 = 11 AndAlso PlayerCard2 = 12 AndAlso PlayerCard3 = 13) OrElse (PlayerCard1 = 21 AndAlso PlayerCard2 = 22 AndAlso PlayerCard3 = 23) OrElse (PlayerCard1 = 31 AndAlso PlayerCard2 = 32 AndAlso PlayerCard3 = 33) Then
            ComTotal = 0
            PlayerTotal = 9
            Result.Enabled = True
            Return
        ElseIf (PlayerCard1 = 2 OrElse PlayerCard1 = 12 OrElse PlayerCard1 = 22 OrElse PlayerCard1 = 32) AndAlso (PlayerCard2 = 2 OrElse PlayerCard2 = 12 OrElse PlayerCard2 = 22 OrElse PlayerCard2 = 32) AndAlso (PlayerCard3 = 2 OrElse PlayerCard3 = 12 OrElse PlayerCard3 = 22 OrElse PlayerCard3 = 32) Then
            ComTotal = 0
            PlayerTotal = 9
            Result.Enabled = True
            Return
        End If

        PlayerTotal = (PlayerCard1 + PlayerCard2 + PlayerCard3 + 3) Mod 10
        ComTotal = (ComCard1 + ComCard2 + 2) Mod 10

        ComPic1.Image = Cards(ComCard1)
        ComPic2.Image = Cards(ComCard2)

        'If ComTotal (2 Cards) is 9 then Computer Wins Over 3 Card 9
        If PlayerTotal <> 9 AndAlso ComTotal = 9 Then
            ComTotal = 9
            PlayerTotal = 0
            Result.Enabled = True
            Return
        End If

        'Comp Hits
        If (ComTotal <= PlayerTotal AndAlso ComTotal <> 9) OrElse ComTotal < 6 Then
            Do While True
                ComCard3 = Rand.Next(0, 40)

                If ComCard3 <> ComCard1 AndAlso ComCard3 <> ComCard2 AndAlso ComCard3 <> PlayerCard1 AndAlso ComCard3 <> PlayerCard2 AndAlso ComCard3 <> PlayerCard3 Then
                    ComPic3.Image = Cards(ComCard3)
                    ComTotal = (ComCard1 + ComCard2 + ComCard3 + 3) Mod 10
                    Exit Do
                End If
            Loop
        End If

        Result.Enabled = True
    End Sub
    Private Sub Pass_Click(sender As Object, e As EventArgs) Handles Pass.Click
        Carat.Visible = False
        Pass.Visible = False

        PlayerTotal = (PlayerCard1 + PlayerCard2 + 2) Mod 10
        ComTotal = (ComCard1 + ComCard2 + 2) Mod 10

        'If Player (2 Card) = 9 Then Auto Win
        If PlayerTotal = 9 AndAlso ComTotal <> 9 Then
            ComTotal = 0
            PlayerTotal = 9
            Result.Enabled = True
            Return
        End If

        'Show Computer Cards
        ComPic1.Image = Cards(ComCard1)
        ComPic2.Image = Cards(ComCard2)

        'If Com (2 Card) = 9 Then Auto Win
        'If both 9 then Tie
        'It hits when com is lower than player or total is 5 and below
        If PlayerTotal <> 9 AndAlso ComTotal = 9 Then
            ComTotal = 9
            PlayerTotal = 0
            Result.Enabled = True
            Return
        ElseIf PlayerTotal = 9 AndAlso ComTotal = 9 Then
            ComTotal = 9
            PlayerTotal = 9
            Result.Enabled = True
            Return
        ElseIf (ComTotal <= PlayerTotal AndAlso ComTotal <> 9) OrElse ComTotal < 6 Then
            My.Computer.Audio.Play(My.Resources.CardFlip, AudioPlayMode.WaitToComplete)
            Do While True
                ComCard3 = Rand.Next(0, 40)

                If ComCard3 <> ComCard1 AndAlso ComCard3 <> ComCard2 AndAlso ComCard3 <> PlayerCard1 AndAlso ComCard3 <> PlayerCard2 Then
                    ComPic3.Image = Cards(ComCard3)
                    ComTotal = (ComCard1 + ComCard2 + ComCard3 + 3) Mod 10
                    Exit Do
                End If
            Loop
        End If

        'Sound Results
        Result.Enabled = True
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Draw.Visible = True
        Draw.Enabled = True
        Reset.Visible = False

        ComTotal = Nothing
        PlayerTotal = Nothing
        ComCard1 = Nothing
        ComCard2 = Nothing
        ComCard3 = Nothing
        PlayerCard1 = Nothing
        PlayerCard2 = Nothing
        PlayerCard3 = Nothing
        ComPic1.Image = My.Resources.back_blue_basic_white
        ComPic2.Image = My.Resources.back_blue_basic_white
        ComPic3.Image = My.Resources.back_blue_basic_white
        PlayerPic1.Image = My.Resources.back_blue_basic_white
        PlayerPic2.Image = My.Resources.back_blue_basic_white
        PlayerPic3.Image = My.Resources.back_blue_basic_white
        Draw.Enabled = True
    End Sub
    Private Sub Result_Tick(sender As Object, e As EventArgs) Handles Result.Tick
        If ComTotal = PlayerTotal Then
            GlobalData.CashGlobal += TextBox1.Text
            My.Computer.Audio.Play(My.Resources.TiedGame, AudioPlayMode.WaitToComplete)
        ElseIf ComTotal > PlayerTotal Then
            My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.WaitToComplete)
        ElseIf ComTotal < PlayerTotal Then
            GlobalData.CashGlobal += TextBox1.Text * 3
            My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
        End If

        HomeToolStripMenuItem.Enabled = True
        My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
        UpdateCashDisplay()
        Reset.Visible = True
        Draw.Visible = False
        Result.Enabled = False
        TextBox1.ReadOnly = False
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Enter Bet" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = Nothing Then
            TextBox1.Text = "Enter Bet"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub
End Class