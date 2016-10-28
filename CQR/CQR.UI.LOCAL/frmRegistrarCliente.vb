Imports System.IO
Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmRegistrarCliente
    Dim user As Usuario
    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        QrCodeImgControl1.Text = "-" + txtCedula.Text
        Try
            ' Convert the text to a Double and determine if it is a negative number.
            If Double.Parse(txtCedula.Text) < 0 Then
                ' If the number is negative, display it in Red.
                txtCedula.ForeColor = Color.Red
            Else
                ' If the number is not negative, display it in Black.
                txtCedula.ForeColor = Color.Black
            End If
        Catch
            ' If there is an error, display the text using the system colors.
            txtCedula.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim gestor As New GestorCliente(user)
        Dim cl As New Cliente

        cl.Cedula = txtCedula.Text
        cl.Nombre = txtNombre.Text
        cl.Telefono = txtTelefono.Text
        cl.Correo = txtCorreo.Text
        cl.PlacaActual = txtPlaca.Text
        cl.Profesion = txtProfesion.Text

        Try
            gestor.Create(cl)

            uploadImage(txtImagePath.Text, txtCedula.Text)

            MsgBox("Cliente registrado con exito", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

        Me.Close()
    End Sub

    Private Sub btnGuardarEnC_Click(sender As Object, e As EventArgs) Handles btnGuardarEnC.Click

        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)
        Dim sv As New SaveFileDialog
        sv.AddExtension = True
        sv.Filter = "Image JPG (*.jpg|.jpg"
        sv.ShowDialog()
        If Not String.IsNullOrEmpty(sv.FileName) Then
            img.Save(sv.FileName)
        End If
        img.Dispose()

        ' PUSH IMAGE PATH ON TXT
        ofdBrowse.ShowDialog()
        Try
            QrCodeImgControl1.Image = Image.FromFile(ofdBrowse.FileName)
            txtImagePath.Text = ofdBrowse.FileName
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        btnRegistrar.Enabled = True

    End Sub

    Private Sub uploadImage(Path As String, cedulaCliente As String)
        Dim gestor As New GestorCliente(user)

        ' EXIT IF IMAGE NOT SELECTED
        If String.IsNullOrEmpty(Path) Then Exit Sub

        ' GET IMAGE DATA VIA MEMORY STREAM
        Dim img As Image = Image.FromFile(Path)
        Dim ms As New MemoryStream
        img.Save(ms, img.RawFormat)
        Dim buffer As Byte() = ms.GetBuffer()


        ' QRCODE ENTITY
        Dim qr As New QrCode
        qr.Cliente = cedulaCliente
        qr.Qrcode = buffer

        Try
            gestor.CreateQrCode(qr)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub frmRegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ofdBrowse.InitialDirectory = Application.StartupPath
    End Sub

End Class