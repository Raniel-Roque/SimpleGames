Public Class AddCash
    'Programmer: Raniel Christian Roque
    'BSIT - 2A
    'Date: October 22 2023
    Public Property Input As String

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If Not InputTextBox.Text = "Enter Amount" AndAlso ULong.TryParse(InputTextBox.Text, Nothing) Then
            Input = InputTextBox.Text
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Invalid input. Please enter a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            InputTextBox.Text = "Enter Amount"
            InputTextBox.ForeColor = Color.Gray
            OkButton.Focus()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim Answer As DialogResult = MessageBox.Show("Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If Answer = DialogResult.Yes Then
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub InputTextBox_GotFocus(sender As Object, e As EventArgs) Handles InputTextBox.GotFocus
        If InputTextBox.Text = "Enter Amount" Then
            InputTextBox.Text = ""
            InputTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub InputTextBox_LostFocus(sender As Object, e As EventArgs) Handles InputTextBox.LostFocus
        If InputTextBox.Text = "" Then
            InputTextBox.Text = "Enter Amount"
            InputTextBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub AddCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputTextBox.Text = "Enter Amount"
        InputTextBox.ForeColor = Color.Gray
    End Sub
End Class