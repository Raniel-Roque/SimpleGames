Imports System.IO.Pipes
Public Class Lottery
    Dim SpinCount As Integer
    Dim Slot1Final, Slot2Final, Slot3Final As Integer
    Dim Choose_Game_Main As ChooseGame
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

    Private Sub Spin_Click(sender As Object, e As EventArgs) Handles Spin.Click
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

        Me.Cursor = Cursors.WaitCursor
        Spinning.Enabled = True
        Spin.Enabled = False
        TextBox1.ReadOnly = True
        HomeToolStripMenuItem.Enabled = False
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Spin, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Spinning_Tick(sender As Object, e As EventArgs) Handles Spinning.Tick
        Dim Rand As New Random()
        If SpinCount = 8 Or SpinCount = 16 Or SpinCount = 24 Then
            My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
        End If

        If SpinCount <= 8 Then
            Slot1Final = Rand.Next(0, 7)
            Dim SlotImage1 As String = "Lottery_" & Slot1Final
            Slot1.Image = My.Resources.ResourceManager.GetObject(SlotImage1)
        End If

        If SpinCount <= 16 Then
            Slot2Final = Rand.Next(0, 7)
            Dim SlotImage2 As String = "Lottery_" & Slot2Final
            Slot2.Image = My.Resources.ResourceManager.GetObject(SlotImage2)
        End If

        If SpinCount <= 24 Then
            Slot3Final = Rand.Next(0, 7)
            Dim SlotImage3 As String = "Lottery_" & Slot3Final
            Slot3.Image = My.Resources.ResourceManager.GetObject(SlotImage3)
        End If

        If SpinCount = 25 Then
            If Slot1Final = Slot2Final AndAlso Slot2Final = Slot3Final AndAlso Slot1Final = Slot3Final Then
                GlobalData.CashGlobal += TextBox1.Text * 3
                My.Computer.Audio.Play(My.Resources.Jackpot, AudioPlayMode.WaitToComplete)
            ElseIf Slot1Final = Slot2Final Or Slot1Final = Slot3Final Or Slot2Final = Slot3Final Then
                GlobalData.CashGlobal += TextBox1.Text * 2
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            Else
                My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.WaitToComplete)
            End If

            Me.Cursor = Cursors.Default
            SpinCount = 0
            Spinning.Enabled = False
            Spin.Enabled = True
            TextBox1.ReadOnly = False
            HomeToolStripMenuItem.Enabled = True
            UpdateCashDisplay()
            My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
        End If
        SpinCount += 1
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