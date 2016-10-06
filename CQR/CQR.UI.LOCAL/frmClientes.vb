Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmClientes
    Dim user = New Usuario()
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_tablaClientes()
    End Sub

    Function cargar_tablaClientes()

        dgClientes.Rows.Clear()

        Dim gestor As New GestorCliente(user)
        Dim lst As List(Of Cliente) = gestor.RetrieveAll()

        Dim data_table As String() = {"Cedula", "Nombre", "Telefono", "Correo", "Visitas", "Premio"}
        buildTableData(dgClientes, data_table)

        For Each item In lst
            dgClientes.Rows.Add(item.Cedula, item.Nombre, item.Telefono, item.Correo, item.Visitas, item.Premio)
        Next

        Return 0
    End Function

    Function buildTableData(ByVal table As DataGridView, ByVal data_table As String())

        table.ColumnCount = data_table.Length

        For i As Integer = 0 To data_table.Length - 1
            table.Columns(i).Name = data_table(i)
        Next

        Return 0
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim gestor As New GestorCliente(user)

        Dim rowIndex As Integer = dgClientes.CurrentRow.Index
        Dim idCliente As String = dgClientes.Item(0, rowIndex).Value

        Try
            Dim cl = New Cliente()
            cl.Cedula = idCliente

            gestor.Delete(cl)

            limpiarFormulario()
            MsgBox("Cliente eliminado con exito", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cargar_tablaClientes()
    End Sub

    Private Sub limpiarFormulario()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtVisitas.ResetText()
        txtPremio.ResetText()
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgClientes.CellClick

        Dim rowIndex As Integer = dgClientes.CurrentRow.Index

        txtNombre.Text = dgClientes.Item(1, rowIndex).Value
        txtTelefono.Text = dgClientes.Item(2, rowIndex).Value
        txtCorreo.Text = dgClientes.Item(3, rowIndex).Value
        txtVisitas.Value = dgClientes.Item(4, rowIndex).Value
        txtPremio.Value = dgClientes.Item(5, rowIndex).Value

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargar_tablaClientes()
    End Sub
End Class