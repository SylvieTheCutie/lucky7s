Public Class Tracker
    Private counts(6) As Integer
    Private wins As Integer = 0
    Private games As Integer = 0
    Private money As Integer = 20
    Public Sub update(num As Integer)
        If num < 0 OrElse num > 6 Then
            Return
        Else
            counts(num) += 1
            updateLabels()
        End If
    End Sub
    Public Sub update2(num As Integer)
        If num <> 7 Then
            Return
            games += 1
            money -= 1
        Else
            games += 1
            wins += 1
            money += 4
        End If
        updateLabels()

    End Sub
    Private Sub updateLabels()
        lbl1.Text = counts(1).ToString
        lbl2.Text = counts(2).ToString
        lbl3.Text = counts(3).ToString
        lbl4.Text = counts(4).ToString
        lbl5.Text = counts(5).ToString
        lbl6.Text = counts(6).ToString
        lblwin.Text = wins.ToString
        lblwin.Text = games.ToString
        lblmoney.Text = money.ToString("C2")
    End Sub

    Private Sub Tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateLabels()

    End Sub
End Class
