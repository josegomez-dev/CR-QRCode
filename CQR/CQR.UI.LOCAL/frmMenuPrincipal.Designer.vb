<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEscaner = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnEscanerCodigo = New System.Windows.Forms.ToolStripButton()
        Me.btnRegistrarCliente = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEscaner)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClientes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Size = New System.Drawing.Size(1039, 447)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEscanerCodigo, Me.btnRegistrarCliente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(221, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEscaner
        '
        Me.btnEscaner.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEscaner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEscaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscaner.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscaner.ForeColor = System.Drawing.Color.White
        Me.btnEscaner.Location = New System.Drawing.Point(12, 403)
        Me.btnEscaner.Name = "btnEscaner"
        Me.btnEscaner.Size = New System.Drawing.Size(195, 35)
        Me.btnEscaner.TabIndex = 6
        Me.btnEscaner.Text = "Acerca de "
        Me.btnEscaner.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mi Empresa"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(12, 321)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(195, 35)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnEscanerCodigo
        '
        Me.btnEscanerCodigo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEscanerCodigo.Image = CType(resources.GetObject("btnEscanerCodigo.Image"), System.Drawing.Image)
        Me.btnEscanerCodigo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEscanerCodigo.Name = "btnEscanerCodigo"
        Me.btnEscanerCodigo.Size = New System.Drawing.Size(23, 22)
        Me.btnEscanerCodigo.Text = "Escanear codigo QR"
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRegistrarCliente.Image = CType(resources.GetObject("btnRegistrarCliente.Image"), System.Drawing.Image)
        Me.btnRegistrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(23, 22)
        Me.btnRegistrarCliente.Text = "Registrar nuevo Cliente"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 447)
        Me.Controls.Add(Me.SplitContainer1)
        Me.IsMdiContainer = True
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuPrincipal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnClientes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEscaner As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnEscanerCodigo As ToolStripButton
    Friend WithEvents btnRegistrarCliente As ToolStripButton
End Class
