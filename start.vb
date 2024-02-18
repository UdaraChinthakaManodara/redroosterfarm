Imports System.Windows.Forms

Public Class start
    Private WithEvents progressTimer As New Timer()
    Private progressValue As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the timer.
        progressTimer.Interval = 50  ' Adjust the interval as needed (milliseconds).
        progressTimer.Start()
    End Sub

    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        ' Update the progress bar.
        ProgressBar1.Value = progressValue

        ' Simulate the task completion when the progress reaches 100%.
        If progressValue = 100 Then
            progressTimer.Stop()
        Else
            ' Increment the progress value.
            progressValue += 1
        End If
    End Sub
End Class
