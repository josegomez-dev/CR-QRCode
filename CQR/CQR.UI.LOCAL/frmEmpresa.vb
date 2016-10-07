Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmEmpresa

    Dim user As New Usuario()
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrarEmpresa.Click

        Dim gestor As New GestorEmpresa(user)
        Dim empresa As New Empresa

        Try
            empresa = gestor.RetrieveAll()(0)

            empresa.CedulaJuridica = txtCedulaJuridica.Text
            empresa.Nombre = txtNombre.Text
            empresa.Telefono = txtTelefono.Text
            empresa.Ubicacion = txtUbicacion.Text
            empresa.Sitio = txtSitio.Text

            gestor.Update(empresa)
            MsgBox("Informacion registrada exitosamente!", MsgBoxStyle.Information)

            actualizar_informacion_empresa()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        limpiarInputsEmpresa()

    End Sub

    Private Sub actualizar_informacion_empresa()

        MsgBox("Actualizar informacion del padre")

    End Sub

    Private Sub limpiarInputsEmpresa()

        txtCedulaJuridica.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtUbicacion.Clear()
        txtSitio.Clear()

    End Sub

    Function buildTableData(ByVal table As DataGridView, ByVal data_table As String())

        table.ColumnCount = data_table.Length

        For i As Integer = 0 To data_table.Length - 1
            table.Columns(i).Name = data_table(i)
        Next

        Return 0
    End Function

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inputs_load()
        dgServicios_load()

    End Sub

    Private Sub inputs_load()

        Dim gestor As New GestorEmpresa(user)
        Dim empresa As New Empresa

        Try
            empresa = gestor.RetrieveAll(0)

            txtCedulaJuridica.Text = empresa.CedulaJuridica
            txtNombre.Text = empresa.Nombre
            txtTelefono.Text = empresa.Telefono
            txtUbicacion.Text = empresa.Ubicacion
            txtSitio.Text = empresa.Sitio

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub dgServicios_load()
        dgServicios.Rows.Clear()

        Dim gestor As New GestorServicio(user)
        Dim lst As New List(Of Servicio)

        lst = gestor.RetrieveAll()

        Dim data_table As String() = {"Nombre", "Descripcion", "Costo"}
        buildTableData(dgServicios, data_table)

        If lst IsNot Nothing Then

            For Each item In lst
                dgServicios.Rows.Add(item.Nombre, item.Descripcion, item.Costo)
            Next

        End If

    End Sub
    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgServicios.CellClick

        Dim rowIndex As Integer = dgServicios.CurrentRow.Index

        txtNombreServicio.Text = dgServicios.Item(0, rowIndex).Value
        txtDescripcionServicio.Text = dgServicios.Item(1, rowIndex).Value
        txtCostoServicio.Text = dgServicios.Item(2, rowIndex).Value

    End Sub

    Private Sub btnNuevoEmpresa_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpresa.Click
        limpiarInputsEmpresa()
    End Sub

    Private Sub btnNuevoServicio_Click(sender As Object, e As EventArgs) Handles btnNuevoServicio.Click
        limpiarInputsServicio()
    End Sub

    Private Sub limpiarInputsServicio()

        txtNombreServicio.Clear()
        txtDescripcionServicio.Clear()
        txtCostoServicio.Clear()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim gestor As New GestorServicio(user)

        Dim rowIndex As Integer = dgServicios.CurrentRow.Index
        Dim nombreServicio As String = dgServicios.Item(0, rowIndex).Value

        Try
            Dim s = New Servicio()
            s.Nombre = nombreServicio

            gestor.DeleteByNombre(s)

            limpiarInputsServicio()
            MsgBox("Cliente eliminado con exito", MsgBoxStyle.Exclamation)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dgServicios_load()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnActualizarTabla.Click
        dgServicios_load()
    End Sub
End Class