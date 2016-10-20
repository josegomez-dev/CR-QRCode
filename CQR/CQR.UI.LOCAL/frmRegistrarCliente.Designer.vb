<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardarEnC = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cbxHabilitado = New System.Windows.Forms.CheckBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtPremio = New System.Windows.Forms.NumericUpDown()
        Me.txtVisitas = New System.Windows.Forms.NumericUpDown()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnGuardarEnC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnGuardarEnC)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.QrCodeImgControl1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.cbxHabilitado)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtPremio)
        Me.GroupBox1.Controls.Add(Me.txtVisitas)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 530)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario de Registro"
        '
        'btnGuardarEnC
        '
        Me.btnGuardarEnC.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473957825_icon_130_cloud_upload
        Me.btnGuardarEnC.Location = New System.Drawing.Point(330, 406)
        Me.btnGuardarEnC.Name = "btnGuardarEnC"
        Me.btnGuardarEnC.Size = New System.Drawing.Size(33, 30)
        Me.btnGuardarEnC.TabIndex = 32
        Me.btnGuardarEnC.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(51, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "(Visitas)"
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(233, 290)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(130, 122)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QrCodeImgControl1.TabIndex = 29
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(254, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Codigo QR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(44, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Premio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(50, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Visitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(56, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(46, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(49, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevo.Location = New System.Drawing.Point(354, 23)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(38, 36)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "+"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'cbxHabilitado
        '
        Me.cbxHabilitado.AutoSize = True
        Me.cbxHabilitado.Checked = True
        Me.cbxHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxHabilitado.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHabilitado.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cbxHabilitado.Location = New System.Drawing.Point(243, 217)
        Me.cbxHabilitado.Name = "cbxHabilitado"
        Me.cbxHabilitado.Size = New System.Drawing.Size(111, 24)
        Me.cbxHabilitado.TabIndex = 20
        Me.cbxHabilitado.Text = "Habilitado?"
        Me.cbxHabilitado.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegistrar.Location = New System.Drawing.Point(79, 477)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(265, 36)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registrar nuevo cliente"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(136, 71)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(187, 24)
        Me.txtCedula.TabIndex = 5
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Nombre.Location = New System.Drawing.Point(54, 73)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(63, 20)
        Me.Nombre.TabIndex = 6
        Me.Nombre.Text = "Cedula"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(136, 106)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 24)
        Me.txtNombre.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(136, 141)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(187, 24)
        Me.txtTelefono.TabIndex = 9
        '
        'txtPremio
        '
        Me.txtPremio.Location = New System.Drawing.Point(122, 341)
        Me.txtPremio.Name = "txtPremio"
        Me.txtPremio.Size = New System.Drawing.Size(77, 24)
        Me.txtPremio.TabIndex = 14
        '
        'txtVisitas
        '
        Me.txtVisitas.Location = New System.Drawing.Point(122, 306)
        Me.txtVisitas.Name = "txtVisitas"
        Me.txtVisitas.Size = New System.Drawing.Size(77, 24)
        Me.txtVisitas.TabIndex = 13
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(136, 178)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(187, 24)
        Me.txtCorreo.TabIndex = 11
        '
        'frmRegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(435, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegistrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistrarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnGuardarEnC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbxHabilitado As CheckBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtPremio As NumericUpDown
    Friend WithEvents txtVisitas As NumericUpDown
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardarEnC As PictureBox
End Class
