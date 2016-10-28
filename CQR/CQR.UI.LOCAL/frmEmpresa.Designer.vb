<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRegistrarServicio = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoServicio = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.txtDescripcionServicio = New System.Windows.Forms.TextBox()
        Me.txtCostoServicio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoEmpresa = New System.Windows.Forms.Button()
        Me.btnRegistrarEmpresa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSitio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCedulaJuridica = New System.Windows.Forms.TextBox()
        Me.btnActualizarForm = New AForge.Controls.PictureBox()
        Me.btnEliminar = New AForge.Controls.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New AForge.Controls.PictureBox()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.Servicios = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrarServicio
        '
        Me.btnRegistrarServicio.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarServicio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarServicio.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRegistrarServicio.Location = New System.Drawing.Point(0, 135)
        Me.btnRegistrarServicio.Name = "btnRegistrarServicio"
        Me.btnRegistrarServicio.Size = New System.Drawing.Size(391, 36)
        Me.btnRegistrarServicio.TabIndex = 53
        Me.btnRegistrarServicio.Text = "Registrar Servicio"
        Me.btnRegistrarServicio.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnNuevoServicio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnRegistrarServicio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNombreServicio)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionServicio)
        Me.GroupBox2.Controls.Add(Me.txtCostoServicio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(397, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 171)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del servicio"
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoServicio.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoServicio.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevoServicio.Location = New System.Drawing.Point(347, 12)
        Me.btnNuevoServicio.Name = "btnNuevoServicio"
        Me.btnNuevoServicio.Size = New System.Drawing.Size(38, 36)
        Me.btnNuevoServicio.TabIndex = 47
        Me.btnNuevoServicio.Text = "+"
        Me.btnNuevoServicio.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.Location = New System.Drawing.Point(320, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 21)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(90, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Location = New System.Drawing.Point(65, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 19)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Descripcion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label11.Location = New System.Drawing.Point(106, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 19)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Costo"
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreServicio.Location = New System.Drawing.Point(164, 37)
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(154, 13)
        Me.txtNombreServicio.TabIndex = 30
        '
        'txtDescripcionServicio
        '
        Me.txtDescripcionServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionServicio.Location = New System.Drawing.Point(164, 67)
        Me.txtDescripcionServicio.Name = "txtDescripcionServicio"
        Me.txtDescripcionServicio.Size = New System.Drawing.Size(154, 13)
        Me.txtDescripcionServicio.TabIndex = 31
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoServicio.Location = New System.Drawing.Point(164, 97)
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(154, 13)
        Me.txtCostoServicio.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnNuevoEmpresa)
        Me.GroupBox1.Controls.Add(Me.btnRegistrarEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSitio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCedulaJuridica)
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 389)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de la Empresa"
        '
        'btnNuevoEmpresa
        '
        Me.btnNuevoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpresa.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpresa.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevoEmpresa.Location = New System.Drawing.Point(297, 19)
        Me.btnNuevoEmpresa.Name = "btnNuevoEmpresa"
        Me.btnNuevoEmpresa.Size = New System.Drawing.Size(38, 36)
        Me.btnNuevoEmpresa.TabIndex = 46
        Me.btnNuevoEmpresa.Text = "+"
        Me.btnNuevoEmpresa.UseVisualStyleBackColor = False
        '
        'btnRegistrarEmpresa
        '
        Me.btnRegistrarEmpresa.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegistrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarEmpresa.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEmpresa.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRegistrarEmpresa.Location = New System.Drawing.Point(0, 353)
        Me.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa"
        Me.btnRegistrarEmpresa.Size = New System.Drawing.Size(349, 36)
        Me.btnRegistrarEmpresa.TabIndex = 45
        Me.btnRegistrarEmpresa.Text = "Actualizar informacion"
        Me.btnRegistrarEmpresa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(103, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sitio"
        '
        'txtSitio
        '
        Me.txtSitio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSitio.Location = New System.Drawing.Point(145, 212)
        Me.txtSitio.Name = "txtSitio"
        Me.txtSitio.Size = New System.Drawing.Size(154, 13)
        Me.txtSitio.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(59, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ubicacion"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUbicacion.Location = New System.Drawing.Point(145, 175)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(154, 13)
        Me.txtUbicacion.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(73, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Location = New System.Drawing.Point(145, 139)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(154, 13)
        Me.txtTelefono.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(75, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Location = New System.Drawing.Point(145, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 13)
        Me.txtNombre.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(19, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Cedula Juridica"
        '
        'txtCedulaJuridica
        '
        Me.txtCedulaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaJuridica.Location = New System.Drawing.Point(145, 69)
        Me.txtCedulaJuridica.Name = "txtCedulaJuridica"
        Me.txtCedulaJuridica.Size = New System.Drawing.Size(154, 13)
        Me.txtCedulaJuridica.TabIndex = 36
        '
        'btnActualizarForm
        '
        Me.btnActualizarForm.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473957601_InterfaceExpendet_01
        Me.btnActualizarForm.Location = New System.Drawing.Point(527, 215)
        Me.btnActualizarForm.Name = "btnActualizarForm"
        Me.btnActualizarForm.Size = New System.Drawing.Size(31, 36)
        Me.btnActualizarForm.TabIndex = 59
        Me.btnActualizarForm.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473950306_edit_delete
        Me.btnEliminar.Location = New System.Drawing.Point(564, 215)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 36)
        Me.btnEliminar.TabIndex = 55
        Me.btnEliminar.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(605, 218)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(150, 20)
        Me.txtBuscar.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CQR.UI.LOCAL.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(761, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'dgServicios
        '
        Me.dgServicios.AllowUserToOrderColumns = True
        Me.dgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgServicios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgServicios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgServicios.GridColor = System.Drawing.Color.DarkBlue
        Me.dgServicios.Location = New System.Drawing.Point(397, 244)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.dgServicios.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgServicios.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServicios.Size = New System.Drawing.Size(394, 170)
        Me.dgServicios.TabIndex = 67
        '
        'Servicios
        '
        Me.Servicios.AutoSize = True
        Me.Servicios.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servicios.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Servicios.Location = New System.Drawing.Point(393, 220)
        Me.Servicios.Name = "Servicios"
        Me.Servicios.Size = New System.Drawing.Size(80, 21)
        Me.Servicios.TabIndex = 68
        Me.Servicios.Text = "Servicios"
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(814, 448)
        Me.Controls.Add(Me.Servicios)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnActualizarForm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpresa"
        Me.Text = "frmEmpresa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrarServicio As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNuevoServicio As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombreServicio As TextBox
    Friend WithEvents txtDescripcionServicio As TextBox
    Friend WithEvents txtCostoServicio As TextBox
    Friend WithEvents btnEliminar As AForge.Controls.PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevoEmpresa As Button
    Friend WithEvents btnRegistrarEmpresa As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSitio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCedulaJuridica As TextBox
    Friend WithEvents btnActualizarForm As AForge.Controls.PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As AForge.Controls.PictureBox
    Friend WithEvents dgServicios As DataGridView
    Friend WithEvents Servicios As Label
End Class
