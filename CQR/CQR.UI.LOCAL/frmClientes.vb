Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmClientes

    Dim user = New Usuario()

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgClientes_load()

    End Sub

    Private Sub dgClientes_load()

        Dim gestor As New GestorCliente(user)
        Dim lst = New List(Of Cliente)

        lst = gestor.RetrieveAll()

        dgClientes.Rows.Clear()

        dgClientes.ColumnCount = 6

        dgClientes.Columns(0).Name = "Cedula"
        dgClientes.Columns(1).Name = "Nombre"
        dgClientes.Columns(2).Name = "Telefono"
        dgClientes.Columns(3).Name = "Correo"
        dgClientes.Columns(4).Name = "Visitas"
        dgClientes.Columns(5).Name = "Premio"
        'dgClientes.Columns(6).Name = "Habilitado"
        'dgClientes.Columns(7).Name = "CodigoQR"

        For Each item In lst
            dgClientes.Rows.Add(item.Cedula, item.Nombre, item.Telefono, item.Correo, item.Visitas, item.Premio)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        QrCodeImgControl1.Text = "Jose Alejandro Gomez Castro"
    End Sub

    Private Sub btnGuardarImagen_Click(sender As Object, e As EventArgs) Handles btnGuardarImagen.Click

        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)
        Dim sv As New SaveFileDialog

        sv.AddExtension = True
        sv.Filter = "Image JPG (*.jpg|.jpg"
        sv.ShowDialog()

        If Not String.IsNullOrEmpty(sv.FileName) Then
            img.Save(sv.FileName)
        End If

        img.Dispose()

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim gestor As New GestorCliente(user)
        Dim nuevoCliente As New Cliente

        nuevoCliente.Cedula = txtCedula.Text
        nuevoCliente.Nombre = txtNombre.Text
        nuevoCliente.Telefono = txtTelefono.Text
        nuevoCliente.Correo = txtCorreo.Text
        nuevoCliente.Visitas = numericVisitas.Value
        nuevoCliente.Premio = numericPremio.Value
        nuevoCliente.Habilitado = cbxHabilitado.Checked

        Try
            gestor.Create(nuevoCliente)

            MsgBox("Cliente registrado exitosamente", MsgBoxStyle.Information)

            dgClientes_load()

        Catch ex As System.Data.SqlClient.SqlException

            Select Case ex.Number

                Case 2627
                    MsgBox("La cedula ya ha sido registrada", MsgBoxStyle.Information)

                Case 201
                    'MsgBox("Falta un parametro que no puede ser nulo", MsgBoxStyle.Information)
                    MsgBox(ex.Message)

                Case 515
                    MsgBox("No se aceptan campos vacios", MsgBoxStyle.Information)

            End Select

        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        limpiarInputs()

    End Sub

    Private Sub limpiarInputs()

        txtCedula.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        numericVisitas.Value = 0
        numericPremio.Value = 0
        cbxHabilitado.Checked = True

    End Sub

    Private Sub dgClientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgClientes.CellMouseClick

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then

            txtCedula.Text = dgClientes.Rows(e.RowIndex).Cells(0).Value
            txtNombre.Text = dgClientes.Rows(e.RowIndex).Cells(1).Value
            txtTelefono.Text = dgClientes.Rows(e.RowIndex).Cells(2).Value
            txtCorreo.Text = dgClientes.Rows(e.RowIndex).Cells(3).Value
            numericVisitas.Value = dgClientes.Rows(e.RowIndex).Cells(4).Value
            numericPremio.Value = dgClientes.Rows(e.RowIndex).Cells(5).Value
            'If dgClientes.Rows(e.RowIndex).Cells(6).Value Then
            '   cbxHabilitado.Checked = True
            'Else
            '   cbxHabilitado.Checked = False
            'End If

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim gestor As New GestorCliente(user)
        Dim cliente As New Cliente

        Dim index = dgClientes.CurrentRow.Index
        cliente.Cedula = dgClientes.Rows(index).Cells(0).Value

        Try
            gestor.Delete(cliente)
            MsgBox("Cliente eliminado exitosamente!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

        dgClientes_load()

    End Sub
End Class