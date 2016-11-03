<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteVentas
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New AForge.Controls.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgReporteDiario = New System.Windows.Forms.DataGridView()
        Me.Reportes = New System.Windows.Forms.Label()
        Me.calendarAntes = New System.Windows.Forms.MonthCalendar()
        Me.Resumen = New System.Windows.Forms.GroupBox()
        Me.lblHoraActual = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCantVentas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalDinero = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFechaDespues = New System.Windows.Forms.Label()
        Me.lblFechaAntes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgReporteSemanal = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New AForge.Controls.PictureBox()
        Me.dgReporteMensual = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New AForge.Controls.PictureBox()
        Me.calendarDespues = New System.Windows.Forms.MonthCalendar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReporteDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Resumen.SuspendLayout()
        CType(Me.dgReporteSemanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReporteMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(607, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 20)
        Me.TextBox2.TabIndex = 69
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.CQR.UI.LOCAL.My.Resources.Resources.magnifier
        Me.PictureBox3.Location = New System.Drawing.Point(763, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(460, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Diario"
        '
        'dgReporteDiario
        '
        Me.dgReporteDiario.AllowUserToOrderColumns = True
        Me.dgReporteDiario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReporteDiario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgReporteDiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgReporteDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReporteDiario.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgReporteDiario.GridColor = System.Drawing.Color.White
        Me.dgReporteDiario.Location = New System.Drawing.Point(464, 73)
        Me.dgReporteDiario.Name = "dgReporteDiario"
        Me.dgReporteDiario.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReporteDiario.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgReporteDiario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        Me.dgReporteDiario.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgReporteDiario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgReporteDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReporteDiario.Size = New System.Drawing.Size(326, 92)
        Me.dgReporteDiario.TabIndex = 75
        '
        'Reportes
        '
        Me.Reportes.AutoSize = True
        Me.Reportes.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reportes.ForeColor = System.Drawing.Color.Black
        Me.Reportes.Location = New System.Drawing.Point(335, 9)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(111, 27)
        Me.Reportes.TabIndex = 77
        Me.Reportes.Text = "Reportes"
        '
        'calendarAntes
        '
        Me.calendarAntes.Location = New System.Drawing.Point(12, 59)
        Me.calendarAntes.Name = "calendarAntes"
        Me.calendarAntes.TabIndex = 78
        '
        'Resumen
        '
        Me.Resumen.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Resumen.Controls.Add(Me.lblHoraActual)
        Me.Resumen.Controls.Add(Me.Label12)
        Me.Resumen.Controls.Add(Me.lblCantVentas)
        Me.Resumen.Controls.Add(Me.Label7)
        Me.Resumen.Controls.Add(Me.lblTotalDinero)
        Me.Resumen.Controls.Add(Me.Label9)
        Me.Resumen.Controls.Add(Me.lblFechaDespues)
        Me.Resumen.Controls.Add(Me.lblFechaAntes)
        Me.Resumen.Controls.Add(Me.Label5)
        Me.Resumen.Controls.Add(Me.Label4)
        Me.Resumen.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Resumen.Location = New System.Drawing.Point(12, 233)
        Me.Resumen.Name = "Resumen"
        Me.Resumen.Size = New System.Drawing.Size(402, 145)
        Me.Resumen.TabIndex = 79
        Me.Resumen.TabStop = False
        Me.Resumen.Text = "Resumen"
        '
        'lblHoraActual
        '
        Me.lblHoraActual.AutoSize = True
        Me.lblHoraActual.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblHoraActual.ForeColor = System.Drawing.Color.Black
        Me.lblHoraActual.Location = New System.Drawing.Point(96, 77)
        Me.lblHoraActual.Name = "lblHoraActual"
        Me.lblHoraActual.Size = New System.Drawing.Size(24, 17)
        Me.lblHoraActual.TabIndex = 9
        Me.lblHoraActual.Text = "--"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(43, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Hora"
        '
        'lblCantVentas
        '
        Me.lblCantVentas.AutoSize = True
        Me.lblCantVentas.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblCantVentas.ForeColor = System.Drawing.Color.Black
        Me.lblCantVentas.Location = New System.Drawing.Point(96, 100)
        Me.lblCantVentas.Name = "lblCantVentas"
        Me.lblCantVentas.Size = New System.Drawing.Size(24, 17)
        Me.lblCantVentas.TabIndex = 7
        Me.lblCantVentas.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ventas"
        '
        'lblTotalDinero
        '
        Me.lblTotalDinero.AutoSize = True
        Me.lblTotalDinero.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblTotalDinero.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTotalDinero.Location = New System.Drawing.Point(248, 106)
        Me.lblTotalDinero.Name = "lblTotalDinero"
        Me.lblTotalDinero.Size = New System.Drawing.Size(32, 17)
        Me.lblTotalDinero.TabIndex = 5
        Me.lblTotalDinero.Text = "---"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(262, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total"
        '
        'lblFechaDespues
        '
        Me.lblFechaDespues.AutoSize = True
        Me.lblFechaDespues.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblFechaDespues.ForeColor = System.Drawing.Color.Black
        Me.lblFechaDespues.Location = New System.Drawing.Point(96, 51)
        Me.lblFechaDespues.Name = "lblFechaDespues"
        Me.lblFechaDespues.Size = New System.Drawing.Size(88, 17)
        Me.lblFechaDespues.TabIndex = 3
        Me.lblFechaDespues.Text = "-- -- ----"
        '
        'lblFechaAntes
        '
        Me.lblFechaAntes.AutoSize = True
        Me.lblFechaAntes.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblFechaAntes.ForeColor = System.Drawing.Color.Black
        Me.lblFechaAntes.Location = New System.Drawing.Point(96, 23)
        Me.lblFechaAntes.Name = "lblFechaAntes"
        Me.lblFechaAntes.Size = New System.Drawing.Size(88, 17)
        Me.lblFechaAntes.TabIndex = 2
        Me.lblFechaAntes.Text = "-- -- ----"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hasta"
        '
        'dgReporteSemanal
        '
        Me.dgReporteSemanal.AllowUserToOrderColumns = True
        Me.dgReporteSemanal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReporteSemanal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgReporteSemanal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgReporteSemanal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReporteSemanal.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgReporteSemanal.GridColor = System.Drawing.Color.White
        Me.dgReporteSemanal.Location = New System.Drawing.Point(464, 218)
        Me.dgReporteSemanal.Name = "dgReporteSemanal"
        Me.dgReporteSemanal.ReadOnly = True
        Me.dgReporteSemanal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        Me.dgReporteSemanal.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgReporteSemanal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgReporteSemanal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReporteSemanal.Size = New System.Drawing.Size(326, 92)
        Me.dgReporteSemanal.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(460, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Semanal"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(654, 197)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 81
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CQR.UI.LOCAL.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(763, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'dgReporteMensual
        '
        Me.dgReporteMensual.AllowUserToOrderColumns = True
        Me.dgReporteMensual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReporteMensual.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgReporteMensual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReporteMensual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgReporteMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReporteMensual.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgReporteMensual.GridColor = System.Drawing.Color.White
        Me.dgReporteMensual.Location = New System.Drawing.Point(464, 344)
        Me.dgReporteMensual.Name = "dgReporteMensual"
        Me.dgReporteMensual.ReadOnly = True
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReporteMensual.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgReporteMensual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReporteMensual.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgReporteMensual.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgReporteMensual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReporteMensual.Size = New System.Drawing.Size(326, 91)
        Me.dgReporteMensual.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(460, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Mensual"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(654, 322)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 20)
        Me.TextBox3.TabIndex = 85
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.CQR.UI.LOCAL.My.Resources.Resources.magnifier
        Me.PictureBox4.Location = New System.Drawing.Point(763, 316)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 31)
        Me.PictureBox4.TabIndex = 86
        Me.PictureBox4.TabStop = False
        '
        'calendarDespues
        '
        Me.calendarDespues.Location = New System.Drawing.Point(222, 59)
        Me.calendarDespues.Name = "calendarDespues"
        Me.calendarDespues.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label10.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label10.Location = New System.Drawing.Point(81, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Desde"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.Label11.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label11.Location = New System.Drawing.Point(299, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Hasta"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.calendarDespues)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.calendarAntes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Resumen)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.GroupBox1.Location = New System.Drawing.Point(28, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 384)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte por rango de fechas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label6.Location = New System.Drawing.Point(539, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "(Ultimos 7 dias)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label8.Location = New System.Drawing.Point(539, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "(Mes y Año)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label13.Location = New System.Drawing.Point(515, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "(Hoy)"
        '
        'frmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 447)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgReporteMensual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.dgReporteSemanal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Reportes)
        Me.Controls.Add(Me.dgReporteDiario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReporteVentas"
        Me.Text = "s"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReporteDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Resumen.ResumeLayout(False)
        Me.Resumen.PerformLayout()
        CType(Me.dgReporteSemanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReporteMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox3 As AForge.Controls.PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgReporteDiario As DataGridView
    Friend WithEvents Reportes As Label
    Friend WithEvents calendarAntes As MonthCalendar
    Friend WithEvents Resumen As GroupBox
    Friend WithEvents dgReporteSemanal As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As AForge.Controls.PictureBox
    Friend WithEvents dgReporteMensual As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox4 As AForge.Controls.PictureBox
    Friend WithEvents lblTotalDinero As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFechaDespues As Label
    Friend WithEvents lblFechaAntes As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents calendarDespues As MonthCalendar
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblHoraActual As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCantVentas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
End Class
