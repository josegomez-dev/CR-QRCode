Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmMenuPrincipal
    Dim user As New Usuario()

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        showScreen(New frmClientes)
    End Sub

    Private Sub btnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        showScreen(New frmEmpresa)
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

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gestor As New GestorEmpresa(user)
        Dim empresa As New Empresa()

        Try
            empresa = gestor.RetrieveAll()(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub btnEscaner_Click(sender As Object, e As EventArgs)
        Dim form As New frmEscaner()
        form.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim form As New frmRegistrarCliente()
        form.Show()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Dim form As New frmEscaner()
        form.Show()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        showScreen(New frmReporteVentas)
    End Sub

    Private Sub btnSeguridad_Click(sender As Object, e As EventArgs) Handles btnSeguridad.Click
        showScreen(New frmSeguridad)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Select Case MsgBox("Desea cerrar la aplicacion?", MsgBoxStyle.YesNoCancel, "Confirmar accion")
            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.Cancel
                MessageBox.Show("Cancel action")
            Case MsgBoxResult.No
        End Select
    End Sub
End Class