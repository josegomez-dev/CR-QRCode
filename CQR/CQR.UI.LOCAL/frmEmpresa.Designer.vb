﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.btnActualizarTabla = New AForge.Controls.PictureBox()
        Me.btnEliminar = New AForge.Controls.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnActualizarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(814, 445)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRegistrarServicio)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnActualizarTabla)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dgServicios)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(806, 419)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MI EMPRESA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRegistrarServicio
        '
        Me.btnRegistrarServicio.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarServicio.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarServicio.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarServicio.Location = New System.Drawing.Point(410, 138)
        Me.btnRegistrarServicio.Name = "btnRegistrarServicio"
        Me.btnRegistrarServicio.Size = New System.Drawing.Size(375, 36)
        Me.btnRegistrarServicio.TabIndex = 47
        Me.btnRegistrarServicio.Text = "Registrar Servicio"
        Me.btnRegistrarServicio.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevoServicio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNombreServicio)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionServicio)
        Me.GroupBox2.Controls.Add(Me.txtCostoServicio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Location = New System.Drawing.Point(410, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 157)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del servicio"
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoServicio.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoServicio.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevoServicio.Location = New System.Drawing.Point(322, 17)
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
        Me.Label8.Location = New System.Drawing.Point(294, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 21)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(46, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Location = New System.Drawing.Point(16, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Descripcion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label11.Location = New System.Drawing.Point(63, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Costo"
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Location = New System.Drawing.Point(138, 35)
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreServicio.TabIndex = 30
        '
        'txtDescripcionServicio
        '
        Me.txtDescripcionServicio.Location = New System.Drawing.Point(138, 65)
        Me.txtDescripcionServicio.Name = "txtDescripcionServicio"
        Me.txtDescripcionServicio.Size = New System.Drawing.Size(154, 20)
        Me.txtDescripcionServicio.TabIndex = 31
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.Location = New System.Drawing.Point(138, 95)
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(154, 20)
        Me.txtCostoServicio.TabIndex = 32
        '
        'btnActualizarTabla
        '
        Me.btnActualizarTabla.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473957601_InterfaceExpendet_01
        Me.btnActualizarTabla.Location = New System.Drawing.Point(713, 380)
        Me.btnActualizarTabla.Name = "btnActualizarTabla"
        Me.btnActualizarTabla.Size = New System.Drawing.Size(33, 32)
        Me.btnActualizarTabla.TabIndex = 49
        Me.btnActualizarTabla.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473950306_edit_delete
        Me.btnEliminar.Location = New System.Drawing.Point(752, 380)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 36)
        Me.btnEliminar.TabIndex = 48
        Me.btnEliminar.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(406, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Lista de Servicios"
        '
        'dgServicios
        '
        Me.dgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgServicios.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Location = New System.Drawing.Point(410, 212)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.Size = New System.Drawing.Size(375, 165)
        Me.dgServicios.TabIndex = 1
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 385)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de la Empresa"
        '
        'btnNuevoEmpresa
        '
        Me.btnNuevoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpresa.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpresa.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevoEmpresa.Location = New System.Drawing.Point(307, 19)
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
        Me.btnRegistrarEmpresa.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEmpresa.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarEmpresa.Location = New System.Drawing.Point(0, 349)
        Me.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa"
        Me.btnRegistrarEmpresa.Size = New System.Drawing.Size(361, 36)
        Me.btnRegistrarEmpresa.TabIndex = 45
        Me.btnRegistrarEmpresa.Text = "Actualizar informacion"
        Me.btnRegistrarEmpresa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(118, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sitio"
        '
        'txtSitio
        '
        Me.txtSitio.Location = New System.Drawing.Point(166, 235)
        Me.txtSitio.Name = "txtSitio"
        Me.txtSitio.Size = New System.Drawing.Size(154, 20)
        Me.txtSitio.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(65, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ubicacion"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(166, 198)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(154, 20)
        Me.txtUbicacion.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(80, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(166, 162)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(154, 20)
        Me.txtTelefono.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(83, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(166, 127)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(21, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 21)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Cedula Juridica"
        '
        'txtCedulaJuridica
        '
        Me.txtCedulaJuridica.Location = New System.Drawing.Point(166, 92)
        Me.txtCedulaJuridica.Name = "txtCedulaJuridica"
        Me.txtCedulaJuridica.Size = New System.Drawing.Size(154, 20)
        Me.txtCedulaJuridica.TabIndex = 36
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(806, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SERVICIOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(814, 448)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpresa"
        Me.Text = "frmEmpresa"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnActualizarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents btnRegistrarEmpresa As Button
    Friend WithEvents btnNuevoEmpresa As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgServicios As DataGridView
    Friend WithEvents btnActualizarTabla As AForge.Controls.PictureBox
    Friend WithEvents btnEliminar As AForge.Controls.PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombreServicio As TextBox
    Friend WithEvents txtDescripcionServicio As TextBox
    Friend WithEvents txtCostoServicio As TextBox
    Friend WithEvents btnRegistrarServicio As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNuevoServicio As Button
End Class
