Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim user = New Usuario()
        Dim gestor As New GestorCliente(user)
        Dim lst = New List(Of Cliente)

        lst = gestor.RetrieveAll()

        dgClientes.ColumnCount = 8

        dgClientes.Columns(0).Name = "Cedula"
        dgClientes.Columns(1).Name = "Nombre"
        dgClientes.Columns(2).Name = "Telefono"
        dgClientes.Columns(3).Name = "Correo"
        dgClientes.Columns(4).Name = "Visitas"
        dgClientes.Columns(5).Name = "Premio"
        dgClientes.Columns(6).Name = "Habilitado"
        dgClientes.Columns(7).Name = "CodigoQR"



        For Each item In lst
            dgClientes.Rows.Add(item.Cedula, item.Nombre, item.Telefono, item.Correo, item.Visitas, item.Premio, item.Habilitado, item.CodigoQR)
        Next

    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

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
End Class