Public Class KilometerConverter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' End the application.
        Me.Close()
    End Sub

    Private Sub btnInches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        ' Display the conversion to inches.
        lblMessage.Text = "1 Kilometer = 39,370 inches"
    End Sub

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        ' Display the conversion to feet.
        lblMessage.Text = "1 Kilometer = 3,281 feet"
    End Sub

    Private Sub btnYards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        ' Display the conversion to yards.
        lblMessage.Text = "1 Kilometer = 1,093.6 yards"
    End Sub

    Private Sub btnMiles_Click(sender As Object, e As EventArgs) Handles btnMiles.Click
        ' Display the conversion to miles.
        lblMessage.Text = "1 Kilometer = 0.6214 miles"
    End Sub
End Class
