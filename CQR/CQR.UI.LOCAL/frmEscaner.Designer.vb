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
        Me.lstboxCodigos = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.vspEscaner = New AForge.Controls.VideoSourcePlayer()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.cmbDispositivos = New System.Windows.Forms.ComboBox()
        Me.lblEscaner = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstboxCodigos
        '
        Me.lstboxCodigos.FormattingEnabled = True
        Me.lstboxCodigos.Location = New System.Drawing.Point(477, 55)
        Me.lstboxCodigos.Name = "lstboxCodigos"
        Me.lstboxCodigos.Size = New System.Drawing.Size(120, 316)
        Me.lstboxCodigos.TabIndex = 3
        '
        'Timer1
        '
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(387, 82)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 23)
        Me.btnDetener.TabIndex = 2
        Me.btnDetener.Text = "Detener"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'vspEscaner
        '
        Me.vspEscaner.BackColor = System.Drawing.SystemColors.ControlText
        Me.vspEscaner.Location = New System.Drawing.Point(32, 122)
        Me.vspEscaner.Name = "vspEscaner"
        Me.vspEscaner.Size = New System.Drawing.Size(430, 249)
        Me.vspEscaner.TabIndex = 4
        Me.vspEscaner.Text = "VideoSourcePlayer1"
        Me.vspEscaner.VideoSource = Nothing
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(306, 82)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'cmbDispositivos
        '
        Me.cmbDispositivos.FormattingEnabled = True
        Me.cmbDispositivos.Location = New System.Drawing.Point(32, 55)
        Me.cmbDispositivos.Name = "cmbDispositivos"
        Me.cmbDispositivos.Size = New System.Drawing.Size(430, 21)
        Me.cmbDispositivos.TabIndex = 0
        '
        'lblEscaner
        '
        Me.lblEscaner.AutoSize = True
        Me.lblEscaner.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscaner.Location = New System.Drawing.Point(28, 31)
        Me.lblEscaner.Name = "lblEscaner"
        Me.lblEscaner.Size = New System.Drawing.Size(310, 21)
        Me.lblEscaner.TabIndex = 5
        Me.lblEscaner.Text = "Selecciona un dispositivo de lectura"
        '
        'frmEscaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(623, 383)
        Me.Controls.Add(Me.cmbDispositivos)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblEscaner)
        Me.Controls.Add(Me.vspEscaner)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.lstboxCodigos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEscaner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEscaner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstboxCodigos As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnDetener As Button
    Friend WithEvents vspEscaner As AForge.Controls.VideoSourcePlayer
    Friend WithEvents btnIniciar As Button
    Friend WithEvents cmbDispositivos As ComboBox
    Friend WithEvents lblEscaner As Label
End Class
