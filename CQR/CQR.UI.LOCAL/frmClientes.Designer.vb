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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
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
        Me.btnEliminar = New AForge.Controls.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.btnActualizarForm = New AForge.Controls.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
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
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(394, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 157)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Cliente"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnActualizar.Location = New System.Drawing.Point(1, 121)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(370, 36)
        Me.btnActualizar.TabIndex = 48
        Me.btnActualizar.Text = "Actualizar Informacion"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(17, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.Location = New System.Drawing.Point(275, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Premio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Location = New System.Drawing.Point(17, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label10.Location = New System.Drawing.Point(275, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 19)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Visitas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label11.Location = New System.Drawing.Point(17, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Correo"
        '
        'txtPremio
        '
        Me.txtPremio.Location = New System.Drawing.Point(279, 90)
        Me.txtPremio.Name = "txtPremio"
        Me.txtPremio.Size = New System.Drawing.Size(72, 20)
        Me.txtPremio.TabIndex = 34
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 30
        '
        'txtVisitas
        '
        Me.txtVisitas.Location = New System.Drawing.Point(279, 43)
        Me.txtVisitas.Name = "txtVisitas"
        Me.txtVisitas.Size = New System.Drawing.Size(72, 20)
        Me.txtVisitas.TabIndex = 33
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(101, 59)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(154, 20)
        Me.txtTelefono.TabIndex = 31
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(101, 89)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(154, 20)
        Me.txtCorreo.TabIndex = 32
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473950306_edit_delete
        Me.btnEliminar.Location = New System.Drawing.Point(750, 380)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(33, 36)
        Me.btnEliminar.TabIndex = 42
        Me.btnEliminar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(31, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Lista de Clientes"
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToOrderColumns = True
        Me.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClientes.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgClientes.GridColor = System.Drawing.Color.DarkBlue
        Me.dgClientes.Location = New System.Drawing.Point(35, 210)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.dgClientes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(748, 164)
        Me.dgClientes.TabIndex = 40
        '
        'btnActualizarForm
        '
        Me.btnActualizarForm.Image = Global.CQR.UI.LOCAL.My.Resources.Resources._1473957601_InterfaceExpendet_01
        Me.btnActualizarForm.Location = New System.Drawing.Point(713, 380)
        Me.btnActualizarForm.Name = "btnActualizarForm"
        Me.btnActualizarForm.Size = New System.Drawing.Size(31, 36)
        Me.btnActualizarForm.TabIndex = 60
        Me.btnActualizarForm.TabStop = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(814, 447)
        Me.Controls.Add(Me.btnActualizarForm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPremio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActualizarForm, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
