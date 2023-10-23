Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class JEP
    'Programmer: Raniel Christian Roque
    'BSIT - 2A
    'Date: October 23 2023
    Dim Rand As New Random()
    Dim ComRandCount As Integer = 0
    Dim Player1Chose, Player2Chose, ComChoose As Integer
    Dim Choose_Game_Main As ChooseGame
    'Game Resetter
    Private Sub ResetGame()
        ComboBox1.Enabled = True
        Play.Visible = True
        TextBox1.ReadOnly = False
        HomeToolStripMenuItem.Enabled = True
        ComChoose = Nothing
        ComRandCount = 0
        Player1Chose = Nothing
        Player2Chose = Nothing
    End Sub
    'For P1 Buttons; Rock: 0; Paper: 1; Scissors: 2
    Private Sub Player1(ButtHit As Integer)
        Player1Chose = ButtHit
        PlayerRock.Visible = False
        PlayerScissor.Visible = False
        PlayerPaper.Visible = False

        'If Player2 Is selected
        If ComboBox1.SelectedIndex = 1 Then
            PlayerPic.Image = My.Resources.QMark
            PlayerRock.Visible = False
            PlayerScissor.Visible = False
            PlayerPaper.Visible = False
            ComRock.Visible = True
            ComScissor.Visible = True
            ComPaper.Visible = True
            Return
        End If

        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.JEP_Voice, AudioPlayMode.Background)
        Select Case Player1Chose
            Case 0
                PlayerPic.Image = My.Resources.RockR
            Case 1
                PlayerPic.Image = My.Resources.PaperR
            Case 2
                PlayerPic.Image = My.Resources.ScissorR
        End Select
        ComRandomizer.Enabled = True
    End Sub
    'For P2 Buttons; Rock: 0; Paper: 1; Scissors: 2
    Private Sub Player2(ButtHit As Integer)
        Player2Chose = ButtHit
        ComRock.Visible = False
        ComScissor.Visible = False
        ComPaper.Visible = False
        ComPic.Image = My.Resources.QMark
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.JEP_Voice, AudioPlayMode.Background)
        PlayerRandomizer.Enabled = True
    End Sub
    Private Sub ChooseGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        TextBox1.Text = "Enter Bet"
        TextBox1.ForeColor = Color.Gray
        UpdateCashDisplay()
    End Sub
    Private Sub UpdateCashDisplay()
        If GlobalData.CashGlobal = 0 Then
            ToolStripMenuItem2.Text = "Cash: ₱0"
        Else
            ToolStripMenuItem2.Text = "Cash: " + Format(GlobalData.CashGlobal, "₱#,##")
        End If
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

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        'Resets Image and Result Text
        PlayerResultedLabel.Visible = False
        ComResultedLabel.Visible = False

        PlayerPic.Image = My.Resources.HandUpR
        ComPic.Image = My.Resources.HandUpL

        'If Vs Comp
        If ComboBox1.SelectedIndex = 0 Then
            Dim result As Integer
            If TextBox1.Text = Nothing OrElse TextBox1.Text = "Enter Bet" OrElse Not ULong.TryParse(TextBox1.Text, result) OrElse TextBox1.Text = 0 Then
                MessageBox.Show("Please Bet an Amount", "Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Text = "Enter Bet"
                TextBox1.ForeColor = Color.Gray
                Return
            ElseIf Not ULong.TryParse(TextBox1.Text, result) Then
                MessageBox.Show("Please Enter a Valid Amount", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            TextBox1.ReadOnly = True
        End If

        'If Vs Player2
        ComboBox1.Enabled = False
        Play.Visible = False
        HomeToolStripMenuItem.Enabled = False
        PlayerRock.Visible = True
        PlayerScissor.Visible = True
        PlayerPaper.Visible = True
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.ThinkingLucky9, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'UI Change for Comp or P2
        Select Case ComboBox1.SelectedIndex
            Case 0
                ComResultedLabel.Visible = False
                TextBox1.Text = "Enter Bet"
                TextBox1.ForeColor = Color.Gray
                Bet.Visible = True
                TextBox1.Visible = True
            Case 1

                If PlayerResultedLabel.Visible = True Then
                    ComResultedLabel.Visible = True
                End If
                Bet.Visible = False
                TextBox1.Visible = False
        End Select
    End Sub

    Private Sub PlayerRock_Click(sender As Object, e As EventArgs) Handles PlayerRock.Click
        Player1(0)
    End Sub
    Private Sub PlayerPaper_Click(sender As Object, e As EventArgs) Handles PlayerPaper.Click
        Player1(1)
    End Sub
    Private Sub PlayerScissor_Click(sender As Object, e As EventArgs) Handles PlayerScissor.Click
        Player1(2)
    End Sub
    Private Sub Player2Rock_Click(sender As Object, e As EventArgs) Handles ComRock.Click
        Player2(0)
    End Sub
    Private Sub Player2Paper_Click(sender As Object, e As EventArgs) Handles ComPaper.Click
        Player2(1)
    End Sub

    Private Sub Player2Scissor_Click(sender As Object, e As EventArgs) Handles ComScissor.Click
        Player2(2)
    End Sub
    'Uses for Randomize Animation + Audio Offset (Can be merged with ComRandomizer but might be confusing to code read
    Private Sub PlayerRandomizer_Tick(sender As Object, e As EventArgs) Handles PlayerRandomizer.Tick
        If ComRandCount < 60 Then
            ComChoose = Rand.Next(0, 3)
            Select Case ComChoose
                Case 0
                    PlayerPic.Image = My.Resources.RockR
                Case 1
                    PlayerPic.Image = My.Resources.PaperR
                Case 2
                    PlayerPic.Image = My.Resources.ScissorR
            End Select

            ComChoose = Rand.Next(0, 3)
            Select Case ComChoose
                Case 0
                    ComPic.Image = My.Resources.RockL
                Case 1
                    ComPic.Image = My.Resources.PaperL
                Case 2
                    ComPic.Image = My.Resources.ScissorL
            End Select
        End If

        If ComRandCount = 60 Then
            Select Case Player1Chose
                Case 0
                    PlayerPic.Image = My.Resources.RockR
                Case 1
                    PlayerPic.Image = My.Resources.PaperR
                Case 2
                    PlayerPic.Image = My.Resources.ScissorR
            End Select

            Select Case Player2Chose
                Case 0
                    ComPic.Image = My.Resources.RockL
                Case 1
                    ComPic.Image = My.Resources.PaperL
                Case 2
                    ComPic.Image = My.Resources.ScissorL
            End Select

            My.Computer.Audio.Stop()
            PlayerRandomizer.Enabled = False
            Result.Enabled = True
        End If

        ComRandCount += 1
    End Sub
    'Same Concept but for comp
    Private Sub ComRandomizer_Tick(sender As Object, e As EventArgs) Handles ComRandomizer.Tick
        If ComRandCount < 60 Then
            ComChoose = Rand.Next(0, 3)
            Select Case ComChoose
                Case 0
                    ComPic.Image = My.Resources.RockL
                Case 1
                    ComPic.Image = My.Resources.PaperL
                Case 2
                    ComPic.Image = My.Resources.ScissorL
            End Select
        End If

        If ComRandCount = 60 Then
            My.Computer.Audio.Stop()
            ComRandomizer.Enabled = False
            Result.Enabled = True
        End If

        ComRandCount += 1
    End Sub
    'Result offset for audio
    Private Sub Result_Tick(sender As Object, e As EventArgs) Handles Result.Tick
        PlayerResultedLabel.Visible = True

        'Rock = 0; Paper = 1; Scissor = 2
        If ComboBox1.SelectedIndex = 0 Then
            If Player1Chose = ComChoose Then
                PlayerResultedLabel.Text = "TIE"
                GlobalData.CashGlobal += TextBox1.Text
                My.Computer.Audio.Play(My.Resources.TiedGame, AudioPlayMode.WaitToComplete)
            ElseIf (Player1Chose = 0 AndAlso ComChoose = 1) OrElse (Player1Chose = 1 AndAlso ComChoose = 2) OrElse (Player1Chose = 2 AndAlso ComChoose = 0) Then
                PlayerResultedLabel.Text = "LOSE"
                My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.WaitToComplete)
            Else
                PlayerResultedLabel.Text = "WIN"
                GlobalData.CashGlobal += TextBox1.Text * 2
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            End If

            UpdateCashDisplay()
        Else
            ComResultedLabel.Visible = True
            If Player1Chose = Player2Chose Then
                PlayerResultedLabel.Text = "TIE"
                ComResultedLabel.Text = "TIE"
                My.Computer.Audio.Play(My.Resources.TiedGame, AudioPlayMode.WaitToComplete)
            ElseIf (Player1Chose = 0 AndAlso Player2Chose = 1) OrElse (Player1Chose = 1 AndAlso Player2Chose = 2) OrElse (Player1Chose = 2 AndAlso Player2Chose = 0) Then
                PlayerResultedLabel.Text = "LOSE"
                ComResultedLabel.Text = "WIN"
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            Else
                PlayerResultedLabel.Text = "WIN"
                ComResultedLabel.Text = "LOSE"
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            End If
        End If

        My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
        ResetGame()
        Result.Enabled = False
    End Sub

End Class