Imports System.Data.SqlClient
Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmSeguridad
    Dim user As New Usuario()
    Private Sub paneMantenimiento_load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_dgUsuarios()
        load_dgRoles()
        load_dgPermisos()

        load_combobox_roles()

    End Sub

    Private Sub load_combobox_roles()

        cbRol.Items.Clear()

        Dim gestor As New GestorRol(user)
        Dim lst As New List(Of Rol)

        lst = gestor.RetrieveAll()

        For Each item In lst
            cbRol.Items.Add(item.Nombre)
        Next

    End Sub

    Private Sub load_dgPermisos()

        dgPermisos.Rows.Clear()

        Dim gestor As New GestorPermiso(user)
        Dim lst As New List(Of Permiso)

        Try
            lst = gestor.RetrieveAll()

            Dim data_table As String() = {"Nombre", "Descripcion"}

            buildTableData(dgPermisos, data_table)

            If lst IsNot Nothing Then
                For Each item In lst
                    dgPermisos.Rows.Add(item.Nombre, item.Descripcion)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub load_dgRoles()

        dgRoles.Rows.Clear()

        Dim gestor As New GestorRol(user)
        Dim lst As New List(Of Rol)

        Try
            lst = gestor.RetrieveAll()

            Dim data_table As String() = {"Nombre", "Descripcion"}

            buildTableData(dgRoles, data_table)

            If lst IsNot Nothing Then
                For Each item In lst
                    dgRoles.Rows.Add(item.Nombre, item.Descripcion)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub load_dgUsuarios()

        dgUsuarios.Rows.Clear()

        Dim gestor As New GestorUsuario(user)
        Dim lst As New List(Of Usuario)

        Try
            lst = gestor.RetrieveAll()

            Dim data_table As String() = {"Nombre", "Nick", "Clave", "Email", "Telefono", "Rol"}

            buildTableData(dgUsuarios, data_table)

            If lst IsNot Nothing Then
                For Each item In lst
                    dgUsuarios.Rows.Add(item.Nombre, item.Nick, item.Clave, item.Email, item.Telefono, item.Rol)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Function buildTableData(ByVal table As DataGridView, ByVal data_table As String())

        table.ColumnCount = data_table.Length

        For i As Integer = 0 To data_table.Length - 1
            table.Columns(i).Name = data_table(i)
        Next

        Return 0
    End Function
    Private Sub btnActualizarUsuarios_Click(sender As Object, e As EventArgs) Handles btnActualizarUsuarios.Click
        load_dgUsuarios()

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim gestorRol As New GestorRol(user)
        Dim gestor As New GestorUsuario(user)
        Dim usuario As New Usuario()

        Try
            usuario.Nombre = txtNombre.Text
            usuario.Nick = txtNick.Text
            usuario.Clave = txtClave.Text
            usuario.Email = txtEmail.Text
            usuario.Telefono = txtTelefono.Text
            usuario.Rol = gestorRol.RetrievePorNombre(cbRol.Text).Id

            gestor.Create(usuario)
            MsgBox("Se registro usuario exitosamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        load_dgUsuarios()

    End Sub

    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click

        Dim gestor As New GestorUsuario(user)
        Dim usuario As New Usuario

        Try
            usuario.Nick = txtNick.Text

            gestor.Delete(usuario)

            MsgBox("Se elimino usuario exitosamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        load_dgUsuarios()

    End Sub

    Private Sub dgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellClick

        Dim rowIndex As Integer = dgUsuarios.CurrentRow.Index

        Dim gestor As New GestorUsuario(user)
        Dim usuario As New Usuario

        Try
            usuario = gestor.RetrievePorId(dgUsuarios.Item(1, rowIndex).Value)

            txtNombre.Text = usuario.Nombre
            txtNick.Text = usuario.Nick
            txtClave.Text = usuario.Clave
            txtEmail.Text = usuario.Email
            txtTelefono.Text = usuario.Telefono
            cbRol.Text = usuario.Rol

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        limiarInputs()
    End Sub

    Private Sub limiarInputs()
        txtNombre.Text = ""
        txtNick.Text = ""
        txtClave.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        cbRol.Text = ""
    End Sub

    Private Sub dgRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRoles.CellClick

        dgAutorizacion.Rows.Clear()

        Dim rowIndex As Integer = dgRoles.CurrentRow.Index

        Dim gestor As New GestorPermiso(user)
        Dim lst As New List(Of Permiso)

        Dim gestorRol As New GestorRol(user)
        Dim rol As New Rol

        Try
            If dgRoles.Item(0, rowIndex).Value <> "" Then

                ' SEARCH PERMISOS BY ROL
                rol = gestorRol.RetrievePorNombre(dgRoles.Item(0, rowIndex).Value)
                lst = gestor.RetrieveAllPorRol(rol)

                Dim data_table As String() = {"Nombre"}

                buildTableData(dgAutorizacion, data_table)

                If lst IsNot Nothing Then
                    For Each item In lst
                        dgAutorizacion.Rows.Add(item.Nombre)
                    Next
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

End Class