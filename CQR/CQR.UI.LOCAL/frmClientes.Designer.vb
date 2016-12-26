<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPremio = New System.Windows.Forms.NumericUpDown()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtVisitas = New System.Windows.Forms.NumericUpDown()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCambiarConfiabilidad = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New AForge.Controls.PictureBox()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.btnActualizarForm = New AForge.Controls.PictureBox()
        Me.btnEliminar = New AForge.Controls.PictureBox()
        Me.btnVisitaManual = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtProfesion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPremio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtVisitas)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(31, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 125)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(265, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Profesion"
        '
        'txtProfesion
        '
        Me.txtProfesion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProfesion.Location = New System.Drawing.Point(344, 62)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(154, 13)
        Me.txtProfesion.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(293, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Placa"
        '
        'txtPlaca
        '
        Me.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaca.Location = New System.Drawing.Point(344, 37)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(154, 13)
        Me.txtPlaca.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(43, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(404, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Premio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(29, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(282, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Visitas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(43, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Correo"
        '
        'txtPremio
        '
        Me.txtPremio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPremio.Location = New System.Drawing.Point(460, 86)
        Me.txtPremio.Name = "txtPremio"
        Me.txtPremio.Size = New System.Drawing.Size(48, 16)
        Me.txtPremio.TabIndex = 34
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombre.Location = New System.Drawing.Point(100, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 13)
        Me.txtNombre.TabIndex = 30
        '
        'txtVisitas
        '
        Me.txtVisitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVisitas.Location = New System.Drawing.Point(346, 86)
        Me.txtVisitas.Name = "txtVisitas"
        Me.txtVisitas.Size = New System.Drawing.Size(48, 16)
        Me.txtVisitas.TabIndex = 33
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Location = New System.Drawing.Point(100, 63)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(154, 13)
        Me.txtTelefono.TabIndex = 31
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Location = New System.Drawing.Point(101, 89)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(154, 13)
        Me.txtCorreo.TabIndex = 32
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnActualizar.Location = New System.Drawing.Point(407, 143)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(135, 30)
        Me.btnActualizar.TabIndex = 48
        Me.btnActualizar.Text = "Actualizar Informacion"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Lista de Clientes"
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToOrderColumns = True
        Me.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgClientes.GridColor = System.Drawing.Color.White
        Me.dgClientes.Location = New System.Drawing.Point(31, 222)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.dgClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(754, 190)
        Me.dgClientes.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(648, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Codigo QR"
        '
        'btnCambiarConfiabilidad
        '
        Me.btnCambiarConfiabilidad.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnCambiarConfiabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarConfiabilidad.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.btnCambiarConfiabilidad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCambiarConfiabilidad.Location = New System.Drawing.Point(599, 404)
        Me.btnCambiarConfiabilidad.Name = "btnCambiarConfiabilidad"
        Me.btnCambiarConfiabilidad.Size = New System.Drawing.Size(154, 33)
        Me.btnCambiarConfiabilidad.TabIndex = 49
        Me.btnCambiarConfiabilidad.Text = "Cambiar estado"
        Me.btnCambiarConfiabilidad.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(529, 201)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(223, 20)
        Me.txtBuscar.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CQR.UI.LOCAL.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(758, 198)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.BackColor = System.Drawing.SystemColors.Window
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.ErrorImage = Global.CQR.UI.LOCAL.My.Resources.Resources.Coyote_Car_Wash_final_RGB
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.InitialImage = Global.CQR.UI.LOCAL.My.Resources.Resources.Coyote_Car_Wash_final_RGB
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(617, 45)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(130, 122)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QrCodeImgControl1.TabIndex = 62
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'btnActualizarForm
        '
        Me.btnActualizarForm.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473957601_InterfaceExpendet_01
        Me.btnActualizarForm.Location = New System.Drawing.Point(453, 193)
        Me.btnActualizarForm.Name = "btnActualizarForm"
        Me.btnActualizarForm.Size = New System.Drawing.Size(31, 36)
        Me.btnActualizarForm.TabIndex = 60
        Me.btnActualizarForm.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473950306_edit_delete
        Me.btnEliminar.Location = New System.Drawing.Point(490, 193)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 36)
        Me.btnEliminar.TabIndex = 42
        Me.btnEliminar.TabStop = False
        '
        'btnVisitaManual
        '
        Me.btnVisitaManual.BackColor = System.Drawing.Color.Transparent
        Me.btnVisitaManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisitaManual.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.btnVisitaManual.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnVisitaManual.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473947706_6
        Me.btnVisitaManual.Location = New System.Drawing.Point(407, 193)
        Me.btnVisitaManual.Name = "btnVisitaManual"
        Me.btnVisitaManual.Size = New System.Drawing.Size(36, 33)
        Me.btnVisitaManual.TabIndex = 65
        Me.btnVisitaManual.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(814, 447)
        Me.Controls.Add(Me.btnCambiarConfiabilidad)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.QrCodeImgControl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnActualizarForm)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVisitaManual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPremio As NumericUpDown
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtVisitas As NumericUpDown
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnEliminar As AForge.Controls.PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents btnActualizarForm As AForge.Controls.PictureBox
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCambiarConfiabilidad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProfesion As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As AForge.Controls.PictureBox
    Friend WithEvents btnVisitaManual As Button
End Class
