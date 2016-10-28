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

        Dim data_table As String() = {"Fecha", "Monto", "Cliente", "Servicio"}

            buildTableData(dgReporteSemanal, data_table)

            If lstDiaria IsNot Nothing Then

                For Each item In lstDiaria
                    dgReporteSemanal.Rows.Add(item.Fecha, item.Monto, item.Cliente, item.Servicio)
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

        Dim data_table As String() = {"Fecha", "Monto", "Cliente", "Servicio"}

            buildTableData(dgReporteMensual, data_table)

            If lstDiaria IsNot Nothing Then

                For Each item In lstDiaria
                    dgReporteMensual.Rows.Add(item.Fecha, item.Monto, item.Cliente, item.Servicio)
                Next

            End If

    End Sub

    Private Sub listarReportesVentasDiarias()

        Dim lst As New List(Of ReporteVentas)
        Dim lstDiaria As New List(Of ReporteVentas)

        For Each item In lst

                If item.Fecha.Day.Equals(Date.Now.Day) And item.Fecha.Month.Equals(Date.Now.Month) And item.Fecha.Year.Equals(Date.Now.Year) Then
                    lstDiaria.Add(item)
                End If

            Next

            Dim data_table As String() = {"Fecha", "Monto", "Cliente", "Servicio"}

            buildTableData(dgReporteDiario, data_table)

            If lstDiaria IsNot Nothing Then

                For Each item In lstDiaria
                    dgReporteDiario.Rows.Add(item.Fecha, item.Monto, item.Cliente, item.Servicio)
                Next

            End If

            listarReportesVentasSemanal()

    End Sub

    Private Sub listarReportesVentas()

        Dim gestor As New GestorReporteVentas(user)

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

End Class