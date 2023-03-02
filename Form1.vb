Public Class Form1
    Private Sub btnroll_Click(sender As Object, e As EventArgs) Handles btnroll.Click
        dice1.roll()
        Dice2.roll()
        Tracker1.update(dice1.value)
        Tracker1.update(Dice2.value)
        Tracker1.update2(dice1.value + Dice2.value)
    End Sub
End Class
