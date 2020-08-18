Public Class Form1
    Dim total1 As Single
    Dim total2 As Single

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text = txtDisplay.Text & btnZero.Text
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtDisplay.Text = txtDisplay.Text & btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtDisplay.Text = txtDisplay.Text & btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtDisplay.Text = txtDisplay.Text & btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtDisplay.Text = txtDisplay.Text & btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtDisplay.Text = txtDisplay.Text & btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtDisplay.Text = txtDisplay.Text & btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtDisplay.Text = txtDisplay.Text & btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtDisplay.Text = txtDisplay.Text & btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtDisplay.Text = txtDisplay.Text & btnNine.Text
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ' add value in textbox (converted to a number) to the 1st total variable
        total1 = total1 + Val(txtDisplay.Text)
        ' clear the textbox
        txtDisplay.Clear()

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        ' add 1st total variable to the converted textbox value & save in the 2nd total variable
        total2 = total1 + Val(txtDisplay.Text)
        ' display the result
        txtDisplay.Text = total2
        ' reset the 1st total variable to zero 
        total1 = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' set the 1st total variable to zero 
        total1 = 0
        ' clear the textbox
        txtDisplay.Clear()
    End Sub
End Class
