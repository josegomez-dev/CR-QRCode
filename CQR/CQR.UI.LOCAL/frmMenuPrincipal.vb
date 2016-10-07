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

            lblNombreEmpresa.Text = empresa.Nombre
            lblTelefono.Text = empresa.Telefono
            lblUbicacion.Text = empresa.Ubicacion

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

End Class