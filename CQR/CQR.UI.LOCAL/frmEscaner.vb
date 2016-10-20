Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Imports CQR.API.CORE.Gestores
Imports CQR.Entidades

Public Class frmEscaner
    Dim user As Usuario
    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice

    Private Sub frmEscaner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each item In dispositivos
            cmbDispositivos.Items.Add(item.Name)
        Next
        cmbDispositivos.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim clienteidx As String
        Dim gestor As New GestorCliente(user)
        Dim cliente As New Cliente

        If vspEscaner.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(vspEscaner.GetCurrentVideoFrame())
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then

                stop_scanner()
                Me.Close()

                Try

                    'lstboxCodigos.Items.Add(clienteidx)
                    clienteidx = resultados(0).Remove(0, 1)
                    cliente = gestor.RetrievePorId(clienteidx)
                    cliente.Visitas = cliente.Visitas + 1

                    MsgBox(cliente.Nombre & " ha visitado una vez mas tu negocio! : " & cliente.Visitas, MsgBoxStyle.Information)

                    Dim resul = InputBox("La informacion anterior es correcta?", "Confirmacion de Visita", "Ingrese un comentario (Opcional)")

                    If resul <> "" Then
                        gestor.Update(cliente)
                        MsgBox(cliente.Nombre & " tiene " & cliente.Visitas & "visitas", MsgBoxStyle.Information)
                    Else
                        MsgBox("ERROR!, La informacion es incorrecta", MsgBoxStyle.Exclamation)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try


                Return
                End If
            End If
    End Sub

    Private Sub Form_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        stop_scanner()
    End Sub

    Private Sub stop_scanner()
        Timer1.Enabled = False
        vspEscaner.Stop()
    End Sub

    Private Sub btnIniciar_Click_1(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(cmbDispositivos.SelectedIndex).MonikerString) '' Read  video
        vspEscaner.VideoSource = fuenteVideo
        vspEscaner.Start()
    End Sub

    Private Sub btnDetener_Click_1(sender As Object, e As EventArgs) Handles btnDetener.Click
        Timer1.Enabled = False
        vspEscaner.Stop()
    End Sub
End Class