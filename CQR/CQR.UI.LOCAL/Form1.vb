Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmClientes()
        form.Show()
        Me.Hide()
    End Sub
End Class
