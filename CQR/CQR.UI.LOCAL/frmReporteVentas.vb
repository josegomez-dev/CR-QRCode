Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmReporteVentas
    Dim user As Usuario
    Dim lst As New List(Of ReporteVentas)

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gestor As New GestorReporteVentas(user)
        lst = gestor.RetrieveAll()

        listarReportesVentasDiarias()

    End Sub

    Private Sub listarReportesVentasSemanal()

        Dim lstDiaria As New List(Of ReporteVentas)

        For Each item In lst

            If Not (DateTime.Now.DayOfYear - 7) <= 0 Then
                If item.Fecha.DayOfYear > DateTime.Now.DayOfYear - 7 And item.Fecha.DayOfYear < DateTime.Now.DayOfYear Then
                    lstDiaria.Add(item)
                End If
            End If

        Next

        Dim data_table As String() = {"Codigo", "Fecha", "Monto", "Cliente", "Servicio"}

        buildTableData(dgReporteSemanal, data_table)

        If lstDiaria IsNot Nothing Then

            For Each item In lstDiaria
                dgReporteSemanal.Rows.Add(item.Id, item.Fecha, item.Monto, item.Cliente, item.Servicio)
            Next

        End If

        listarReportesVentasMensuales()

    End Sub

    Private Sub listarReportesVentasMensuales()

        Dim lstDiaria As New List(Of ReporteVentas)

        For Each item In lst

            If item.Fecha.Month.Equals(Date.Now.Month) And item.Fecha.Year.Equals(Date.Now.Year) Then
                lstDiaria.Add(item)
            End If

        Next

        Dim data_table As String() = {"Codigo", "Fecha", "Monto", "Cliente", "Servicio"}

        buildTableData(dgReporteMensual, data_table)

        If lstDiaria IsNot Nothing Then

            For Each item In lstDiaria
                dgReporteMensual.Rows.Add(item.Id, item.Fecha, item.Monto, item.Cliente, item.Servicio)
            Next

        End If

    End Sub

    Private Sub listarReportesVentasDiarias()

        Dim lstDiaria As New List(Of ReporteVentas)

        For Each item In lst

            If Not item.Fecha.DayOfYear <> DateTime.Now.DayOfYear Then
                lstDiaria.Add(item)
            End If

        Next

        Dim data_table As String() = {"Codigo", "Fecha", "Monto", "Cliente", "Servicio"}

        buildTableData(dgReporteDiario, data_table)

        If lstDiaria IsNot Nothing Then

            For Each item In lstDiaria
                dgReporteDiario.Rows.Add(item.Id, item.Fecha, item.Monto, item.Cliente, item.Servicio)
            Next

        End If

        listarReportesVentasSemanal()

    End Sub

    Private Sub listarReportesVentas()

        Dim data_table As String() = {"Fecha", "Monto", "Cliente", "Servicio"}

        buildTableData(dgReporteDiario, data_table)

        If lst IsNot Nothing Then

            For Each item In lst
                dgReporteDiario.Rows.Add(item.Fecha, item.Monto, item.Cliente, item.Servicio)
            Next

        End If

    End Sub

    Function buildTableData(ByVal table As DataGridView, ByVal data_table As String())

        table.ColumnCount = data_table.Length

        For i As Integer = 0 To data_table.Length - 1
            table.Columns(i).Name = data_table(i)
        Next

        Return 0
    End Function

    Private Sub calendarAntes_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarAntes.DateChanged

        Dim lstRango As New List(Of ReporteVentas)

        Dim fechaSelect As DateTime = calendarAntes.SelectionStart.ToShortDateString
        Dim fechaSelectDespues As DateTime = calendarDespues.SelectionStart.ToShortDateString

        If verificarRangoValidoFecha(fechaSelect, fechaSelectDespues) Then

            lblFechaAntes.Text = fechaSelect
            lblFechaDespues.Text = fechaSelectDespues

            Dim total As Decimal = 0.00

            For Each item In lst
                If item.Fecha.DayOfYear >= fechaSelect.DayOfYear And item.Fecha.DayOfYear <= fechaSelectDespues.DayOfYear Then
                    lstRango.Add(item)
                    total = total + item.Monto
                End If
            Next

            cargarResumen(TimeOfDay, lstRango.Count, total)

        Else
            limpiarResumen()
            MsgBox("Fecha invalida", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub calendarDespues_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarDespues.DateChanged

        Dim lstRango As New List(Of ReporteVentas)

        Dim fechaSelect As DateTime = calendarDespues.SelectionStart.ToShortDateString
        Dim fechaSelectAntes As DateTime = calendarAntes.SelectionStart.ToShortDateString

        If verificarRangoValidoFecha(fechaSelectAntes, fechaSelect) Then

            lblFechaDespues.Text = fechaSelect
            lblFechaAntes.Text = fechaSelectAntes

            Dim total As Decimal = 0.00

            For Each item In lst
                If item.Fecha.DayOfYear <= fechaSelect.DayOfYear And item.Fecha.DayOfYear >= fechaSelectAntes.DayOfYear Then
                    lstRango.Add(item)
                    total = total + item.Monto
                End If
            Next

            cargarResumen(TimeOfDay, lstRango.Count, total)

        Else
            limpiarResumen()
            MsgBox("Fecha invalida", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Public Sub cargarResumen(time As String, ventas As String, total As String)
        lblHoraActual.Text = time
        lblCantVentas.Text = ventas
        lblTotalDinero.Text = total & " $"
    End Sub
    Public Sub limpiarResumen()
        lblFechaAntes.Text = "N/A"
        lblFechaDespues.Text = "N/A"
        lblHoraActual.Text = "N/A"
        lblCantVentas.Text = "0"
        lblTotalDinero.Text = "0.00"
    End Sub

    Public Function verificarRangoValidoFecha(antes As DateTime, despues As DateTime) As Boolean
        If antes.DayOfYear > despues.DayOfYear Or despues.DayOfYear < antes.DayOfYear Then
            verificarRangoValidoFecha = False
        Else
            verificarRangoValidoFecha = True
        End If
    End Function

End Class