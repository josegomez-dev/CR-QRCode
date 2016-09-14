<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEscaner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbDispositivos = New System.Windows.Forms.ComboBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.vspEscaner = New AForge.Controls.VideoSourcePlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbDispositivos
        '
        Me.cmbDispositivos.FormattingEnabled = True
        Me.cmbDispositivos.Location = New System.Drawing.Point(316, 65)
        Me.cmbDispositivos.Name = "cmbDispositivos"
        Me.cmbDispositivos.Size = New System.Drawing.Size(291, 21)
        Me.cmbDispositivos.TabIndex = 0
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(423, 92)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(654, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 316)
        Me.ListBox1.TabIndex = 3
        '
        'Timer1
        '
        '
        'vspEscaner
        '
        Me.vspEscaner.Location = New System.Drawing.Point(177, 133)
        Me.vspEscaner.Name = "vspEscaner"
        Me.vspEscaner.Size = New System.Drawing.Size(430, 249)
        Me.vspEscaner.TabIndex = 4
        Me.vspEscaner.Text = "VideoSourcePlayer1"
        Me.vspEscaner.VideoSource = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Escaner QR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-15, -15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(514, 92)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 2
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'frmEscaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 447)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vspEscaner)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.cmbDispositivos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEscaner"
        Me.Text = "frmEscaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbDispositivos As ComboBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents vspEscaner As AForge.Controls.VideoSourcePlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDetener As Button
End Class
