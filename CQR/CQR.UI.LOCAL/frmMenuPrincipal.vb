Public Class frmMenuPrincipal

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Call New frmClientes() With {.MdiParent = Me}.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        showScreen(New frmClientes)
    End Sub

    Private Sub btnEscaner_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles btnEscaner.MouseHover
        btnEscaner.BackColor = Color.LightCyan
    End Sub
    Private Sub btnEscaner_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnEscaner.MouseLeave
        btnEscaner.BackColor = Color.LightSeaGreen
    End Sub

    Function showScreen(ByVal Xform As Form)
        Me.SplitContainer1.Panel2.Controls.Clear()

        Dim formClientes = Xform
        formClientes.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formClientes)
        formClientes.Show()

        Return 0
    End Function

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Dim form As New frmRegistrarCliente()
        form.Show()
    End Sub

    Private Sub btnEscanerCodigo_Click(sender As Object, e As EventArgs) Handles btnEscanerCodigo.Click
        Dim form As New frmEscaner()
        form.Show()
    End Sub
End Class