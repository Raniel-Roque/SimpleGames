Public Class LoadGame
    'Programmer: Raniel Christian Roque
    'BSIT - 2A
    'Date: October 22 2023
    Dim Choose_Game_Main As ChooseGame
    Private Sub Load_Tick(sender As Object, e As EventArgs) Handles Load.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 4
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            Button1.Visible = True
            ProgressBar1.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("This application includes content that is restricted to individuals who are at least 18 years old or the age of majority in their jurisdiction. This includes gambling-related content. By accessing this application, you affirm that you meet these age requirements and consent to engage in gambling activities. Please be aware that gambling can lead to addiction and financial loss. Always gamble responsibly.", "Are you 18+?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If Choose_Game_Main Is Nothing Then
                Choose_Game_Main = New ChooseGame
            End If
            Choose_Game_Main.Show()
            Me.Close()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub LoadGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Casino_Main, AudioPlayMode.BackgroundLoop)
    End Sub
End Class