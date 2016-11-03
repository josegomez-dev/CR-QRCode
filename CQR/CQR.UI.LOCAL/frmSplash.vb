Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQr.Start()
    End Sub

    Private Sub TimerQr_Tick(sender As Object, e As EventArgs) Handles TimerQr.Tick
        ProgressBarQr.Increment(10)
    End Sub

End Class