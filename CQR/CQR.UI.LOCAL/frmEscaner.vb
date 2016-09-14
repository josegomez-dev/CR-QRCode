Imports Aforge.video.DirectShow
Imports BarcodeLib.BarcodeReader

Public Class frmEscaner
    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice

    Private Sub frmEscaner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each item In dispositivos
            cmbDispositivos.Items.Add(item.Name)
        Next
        cmbDispositivos.SelectedIndex = 0
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(cmbDispositivos.SelectedIndex).MonikerString) '' Read  video
        vspEscaner.VideoSource = fuenteVideo
        vspEscaner.Start()
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        Timer1.Enabled = False
        vspEscaner.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If vspEscaner.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(vspEscaner.GetCurrentVideoFrame)
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
                ListBox1.Items.Add(resultados(0))
            End If
        End If
    End Sub
End Class