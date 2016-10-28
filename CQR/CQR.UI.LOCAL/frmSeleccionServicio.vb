Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmSeleccionServicio
    Dim user As New Usuario

    Private Sub frmSeleccionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgServicios_load()

    End Sub

    Function buildTableData(ByVal table As DataGridView, ByVal data_table As String())

        table.ColumnCount = data_table.Length

        For i As Integer = 0 To data_table.Length - 1
            table.Columns(i).Name = data_table(i)
        Next

        Return 0
    End Function

    Private Sub dgServicios_load()
        dgServicios.Rows.Clear()

        Dim gestor As New GestorServicio(user)
        Dim lst As New List(Of Servicio)

        Try
            lst = gestor.RetrieveAll()

            Dim data_table As String() = {"Nombre", "Descripcion", "Costo"}

            buildTableData(dgServicios, data_table)

            If lst IsNot Nothing Then

                For Each item In lst
                    dgServicios.Rows.Add(item.Nombre, item.Descripcion, item.Costo)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub dgServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicios.CellClick


        Dim rowIndex As Integer = dgServicios.CurrentRow.Index

        lblServicioSeleccionad.Text = dgServicios.Item(0, rowIndex).Value

        btnEnviar.Enabled = True

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim gestor As New GestorReporteVentas(user)
        Dim reporte As New ReporteVentas

        Dim rowIndex As Integer = dgServicios.CurrentRow.Index


        Try
            reporte.Fecha = Date.Now
            reporte.Monto = dgServicios.Item(2, rowIndex).Value
            reporte.Cliente = lblCliente.Text
            reporte.Servicio = lblServicioSeleccionad.Text

            gestor.Create(reporte)

            MsgBox("Reporte registrado exitosamente!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Me.Close()

    End Sub
End Class