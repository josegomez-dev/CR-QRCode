Public Class frmMenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a As New frmClientes
        a.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Call New frmClientes() With {.MdiParent = Me}.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Me.SplitContainer1.Panel2.Controls.Clear()

        Dim formClientes As New frmClientes
        formClientes.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formClientes)
        formClientes.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SplitContainer1.Panel2.Controls.Clear()

        Dim formClientes As New Form1
        formClientes.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formClientes)
        formClientes.Show()
    End Sub

    Private Sub btnEscaner_Click(sender As Object, e As EventArgs) Handles btnEscaner.Click
        Me.SplitContainer1.Panel2.Controls.Clear()

        Dim formClientes As New frmEscaner
        formClientes.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formClientes)
        formClientes.Show()
    End Sub

    Private Sub btnEscaner_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles btnEscaner.MouseHover
        btnEscaner.BackColor = Color.LightCyan
    End Sub
    Private Sub btnEscaner_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnEscaner.MouseLeave
        btnEscaner.BackColor = Color.LightSeaGreen
    End Sub
End Class