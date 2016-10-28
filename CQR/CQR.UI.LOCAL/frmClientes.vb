Imports System.IO
Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmClientes
    Dim user = New Usuario()
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_tablaClientes()
    End Sub

    Function cargar_tablaClientes()

        Dim gestor As New GestorCliente(user)
        Dim lst As List(Of Cliente)

        lst = gestor.RetrieveAll()


        dgClientes.DataSource = lst

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

            Dim qr As QrCode = gestor.RetrieveQRCodePorId(cl.Cedula)

            If qr IsNot Nothing Then
                gestor.Delete(cl, qr)
            Else
                gestor.Delete(cl)
            End If

            limpiarFormulario()
            MsgBox("Cliente eliminado con exito", MsgBoxStyle.Information)
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

        Dim gestor As New GestorCliente(user)
        Dim cliente As New Cliente

        Try

            If dgClientes.Item(0, rowIndex).Value IsNot Nothing Then

                cliente = gestor.RetrievePorId(dgClientes.Item(0, rowIndex).Value)

                txtNombre.Text = cliente.Nombre
                txtTelefono.Text = cliente.Telefono
                txtCorreo.Text = cliente.Correo
                txtPlaca.Text = cliente.PlacaActual
                txtProfesion.Text = cliente.Profesion
                txtVisitas.Value = cliente.Visitas
                txtPremio.Value = cliente.Premio

                ' DRAW CLIENT QRCODE
                drawAvatar(QrCodeImgControl1)

                checkedColor(cliente.Vetado)

            End If

        Catch ex As Exception
            If String.IsNullOrEmpty(ex.Message) Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Else
                MsgBox("Este cliente no tiene un Codigo Asignado", MsgBoxStyle.Exclamation)
            End If
        End Try

    End Sub

    Private Sub checkedColor(vetado As Boolean)

        If Not vetado Then
            btnCambiarConfiabilidad.BackColor = Color.Blue
            dgClientes.RowsDefaultCellStyle.SelectionBackColor = Color.Blue
        Else
            btnCambiarConfiabilidad.BackColor = Color.Firebrick
            dgClientes.RowsDefaultCellStyle.SelectionBackColor = Color.Firebrick
        End If

    End Sub

    Private Function fetchAvatar(cliente As String) As Byte()

        Dim gestor As New GestorCliente(user)
        Dim qr As QrCode = gestor.RetrieveQRCodePorId(cliente)

        Dim buffer As Byte() = qr.Qrcode

        Return buffer
    End Function
    Private Sub drawAvatar(PB As PictureBox)

        Dim rowIndex As Integer = dgClientes.CurrentRow.Index

        Dim buffer As Byte() = fetchAvatar(dgClientes.Item(0, rowIndex).Value)

        ' STREAM IMAGE DATA TO PICTUREBOX
        If buffer IsNot Nothing Then
            Using ms As New MemoryStream(buffer, 0, buffer.Length)
                ms.Write(buffer, 0, buffer.Length)
                PB.Image = Image.FromStream(ms, True)
            End Using
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim gestor As New GestorCliente(user)
        Dim cliente As New Cliente

        Dim rowIndex As Integer = dgClientes.CurrentRow.Index
        Dim primaryKey As String = dgClientes.Item(0, rowIndex).Value

        If Not (txtNombre.Text.Equals("") Or txtTelefono.Text.Equals("") Or txtCorreo.Text.Equals("") Or txtPlaca.Text.Equals("") Or txtProfesion.Text.Equals("")) Then

            Try

                cliente = gestor.RetrievePorId(primaryKey)

                cliente.Nombre = txtNombre.Text
                cliente.Telefono = txtTelefono.Text
                cliente.Correo = txtCorreo.Text
                cliente.PlacaActual = txtPlaca.Text
                cliente.Profesion = txtProfesion.Text
                cliente.Visitas = txtVisitas.Value
                cliente.Premio = txtPremio.Value

                gestor.Update(cliente)

                MsgBox("Cliente actualizado con exito", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

        Else
            MsgBox("Rellene los campos vacios", MsgBoxStyle.Exclamation)
        End If

        cargar_tablaClientes()

    End Sub

    Private Sub btnActualizarForm_Click(sender As Object, e As EventArgs) Handles btnActualizarForm.Click
        cargar_tablaClientes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCambiarConfiabilidad.Click

        Select Case MsgBox("Desea cambiar el estado del cliente?", MsgBoxStyle.YesNoCancel, "Confirmar accion")
            Case MsgBoxResult.Yes

                Dim rowIndex As Integer = dgClientes.CurrentRow.Index

                Dim gestor As New GestorCliente(user)
                Dim cliente As New Cliente

                Try

                    If dgClientes.Item(0, rowIndex).Value IsNot Nothing Then

                        cliente = gestor.RetrievePorId(dgClientes.Item(0, rowIndex).Value)

                        If cliente.Vetado Then
                            cliente.Vetado = False
                        Else
                            cliente.Vetado = True
                        End If

                        gestor.Update(cliente)

                        cargar_tablaClientes()

                    End If

                    checkedColor(cliente.Vetado)

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

            Case MsgBoxResult.Cancel

            Case MsgBoxResult.No

        End Select


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim gestor As New GestorCliente(user)
        Dim lst As New List(Of Cliente)

        lst = gestor.searchLike(txtBuscar.Text)

        dgClientes.DataSource = lst

    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellContentClick

    End Sub
End Class