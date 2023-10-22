Imports System.Threading

Public Class CToss
    Dim Choose_Game_Main As ChooseGame
    Dim FinalFace As Integer
    Dim CoinSpinCount As Integer = 0
    Private Sub UpdateCashDisplay()
        If GlobalData.CashGlobal = 0 Then
            ToolStripMenuItem2.Text = "Cash: ₱0"
        Else
            ToolStripMenuItem2.Text = "Cash: " + Format(GlobalData.CashGlobal, "₱#,##")
        End If
    End Sub
    Private Sub CToss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
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

    Private Sub Toss_Click(sender As Object, e As EventArgs) Handles Toss.Click
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

        ComboBox1.Enabled = False
        SpinDaCoin.Enabled = True
        Toss.Enabled = False
        TextBox1.ReadOnly = True
        HomeToolStripMenuItem.Enabled = False
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.CoinStartFlip, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.CToss_Suspense, AudioPlayMode.Background)
        PictureBox1.Image = My.Resources.CoinFlip
    End Sub

    Private Sub SpinDaCoin_Tick(sender As Object, e As EventArgs) Handles SpinDaCoin.Tick
        Dim Rand As New Random()

        If CoinSpinCount <= 35 Then
            FinalFace = Rand.Next(0, 2)
        End If

        If CoinSpinCount = 35 Then
            If FinalFace = 0 Then
                PictureBox1.Image = My.Resources.Heads
            Else
                PictureBox1.Image = My.Resources.Tails
            End If
        End If

        If CoinSpinCount = 36 Then
            If (FinalFace = 0 AndAlso ComboBox1.SelectedIndex = 0) OrElse (FinalFace = 1 AndAlso ComboBox1.SelectedIndex = 1) Then
                GlobalData.CashGlobal += TextBox1.Text * 2
                My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.WaitToComplete)
            Else
                My.Computer.Audio.Play(My.Resources.Lose, AudioPlayMode.WaitToComplete)
            End If

            CoinSpinCount = 0
            ComboBox1.Enabled = True
            SpinDaCoin.Enabled = False
            Toss.Enabled = True
            TextBox1.ReadOnly = False
            HomeToolStripMenuItem.Enabled = True
            UpdateCashDisplay()
            My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
        End If

        CoinSpinCount += 1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources.Heads
        Else
            PictureBox1.Image = My.Resources.Tails
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
End Class