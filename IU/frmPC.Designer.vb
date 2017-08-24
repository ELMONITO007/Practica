<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPC
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSector = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtTamaño = New MetroFramework.Controls.MetroComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImportarExcel = New MetroFramework.Controls.MetroButton()
        Me.cbUsarExcel = New MetroFramework.Controls.MetroCheckBox()
        Me.dgvArchivo = New MetroFramework.Controls.MetroGrid()
        Me.txtMarca = New MetroFramework.Controls.MetroComboBox()
        Me.lblModelo = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtEtiquetaImprimir = New System.Windows.Forms.Label()
        Me.gbVistaFinalQR = New System.Windows.Forms.GroupBox()
        Me.ImagenQR = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtZona = New MetroFramework.Controls.MetroComboBox()
        Me.lblEmplazamiento = New MetroFramework.Controls.MetroLabel()
        Me.lblUsuario = New MetroFramework.Controls.MetroLabel()
        Me.lblMarca = New MetroFramework.Controls.MetroLabel()
        Me.lblEtiquta = New MetroFramework.Controls.MetroLabel()
        Me.lblNombre = New MetroFramework.Controls.MetroLabel()
        Me.txtEmplazamiento = New MetroFramework.Controls.MetroTextBox()
        Me.txtEtiqueta = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombrePC = New MetroFramework.Controls.MetroTextBox()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.txtEscala = New System.Windows.Forms.Label()
        Me.txtModelo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSerial = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVistaFinalQR.SuspendLayout()
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSector
        '
        Me.txtSector.FormattingEnabled = True
        Me.txtSector.ItemHeight = 23
        Me.txtSector.Items.AddRange(New Object() {"SEDE", "OTROS"})
        Me.txtSector.Location = New System.Drawing.Point(766, 315)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(310, 29)
        Me.txtSector.TabIndex = 29
        Me.txtSector.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(245, 129)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 84
        Me.MetroLabel3.Text = "Tamaño"
        '
        'txtTamaño
        '
        Me.txtTamaño.FormattingEnabled = True
        Me.txtTamaño.ItemHeight = 23
        Me.txtTamaño.Items.AddRange(New Object() {"23X23", "29X30"})
        Me.txtTamaño.Location = New System.Drawing.Point(323, 119)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(121, 29)
        Me.txtTamaño.TabIndex = 32
        Me.txtTamaño.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImportarExcel
        '
        Me.btnImportarExcel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnImportarExcel.Location = New System.Drawing.Point(255, 323)
        Me.btnImportarExcel.Name = "btnImportarExcel"
        Me.btnImportarExcel.Size = New System.Drawing.Size(109, 23)
        Me.btnImportarExcel.TabIndex = 35
        Me.btnImportarExcel.Text = "Importar excel"
        Me.btnImportarExcel.UseSelectable = True
        Me.btnImportarExcel.Visible = False
        '
        'cbUsarExcel
        '
        Me.cbUsarExcel.AutoSize = True
        Me.cbUsarExcel.Location = New System.Drawing.Point(114, 327)
        Me.cbUsarExcel.Name = "cbUsarExcel"
        Me.cbUsarExcel.Size = New System.Drawing.Size(75, 15)
        Me.cbUsarExcel.TabIndex = 34
        Me.cbUsarExcel.Text = "Usar Excel"
        Me.cbUsarExcel.UseSelectable = True
        '
        'dgvArchivo
        '
        Me.dgvArchivo.AllowUserToAddRows = False
        Me.dgvArchivo.AllowUserToDeleteRows = False
        Me.dgvArchivo.AllowUserToOrderColumns = True
        Me.dgvArchivo.AllowUserToResizeRows = False
        Me.dgvArchivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArchivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvArchivo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvArchivo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvArchivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArchivo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArchivo.EnableHeadersVisualStyles = False
        Me.dgvArchivo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvArchivo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivo.Location = New System.Drawing.Point(16, 422)
        Me.dgvArchivo.MultiSelect = False
        Me.dgvArchivo.Name = "dgvArchivo"
        Me.dgvArchivo.ReadOnly = True
        Me.dgvArchivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArchivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvArchivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArchivo.Size = New System.Drawing.Size(992, 283)
        Me.dgvArchivo.TabIndex = 80
        Me.dgvArchivo.Visible = False
        '
        'txtMarca
        '
        Me.txtMarca.FormattingEnabled = True
        Me.txtMarca.ItemHeight = 23
        Me.txtMarca.Location = New System.Drawing.Point(639, 199)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(121, 29)
        Me.txtMarca.TabIndex = 26
        Me.txtMarca.UseSelectable = True
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(514, 248)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(55, 19)
        Me.lblModelo.TabIndex = 79
        Me.lblModelo.Text = "Modelo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(887, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 125)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'txtEtiquetaImprimir
        '
        Me.txtEtiquetaImprimir.AutoSize = True
        Me.txtEtiquetaImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtiquetaImprimir.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEtiquetaImprimir.Location = New System.Drawing.Point(3, 104)
        Me.txtEtiquetaImprimir.Name = "txtEtiquetaImprimir"
        Me.txtEtiquetaImprimir.Size = New System.Drawing.Size(0, 15)
        Me.txtEtiquetaImprimir.TabIndex = 27
        '
        'gbVistaFinalQR
        '
        Me.gbVistaFinalQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbVistaFinalQR.Controls.Add(Me.txtEtiquetaImprimir)
        Me.gbVistaFinalQR.Controls.Add(Me.ImagenQR)
        Me.gbVistaFinalQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbVistaFinalQR.ForeColor = System.Drawing.SystemColors.Info
        Me.gbVistaFinalQR.Location = New System.Drawing.Point(134, 109)
        Me.gbVistaFinalQR.Name = "gbVistaFinalQR"
        Me.gbVistaFinalQR.Size = New System.Drawing.Size(93, 125)
        Me.gbVistaFinalQR.TabIndex = 77
        Me.gbVistaFinalQR.TabStop = False
        '
        'ImagenQR
        '
        Me.ImagenQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenQR.Location = New System.Drawing.Point(0, 9)
        Me.ImagenQR.Name = "ImagenQR"
        Me.ImagenQR.Size = New System.Drawing.Size(93, 92)
        Me.ImagenQR.TabIndex = 0
        Me.ImagenQR.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(245, 199)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 33
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.Visible = False
        '
        'PrintDocument1
        '
        '
        'txtZona
        '
        Me.txtZona.FormattingEnabled = True
        Me.txtZona.ItemHeight = 23
        Me.txtZona.Items.AddRange(New Object() {"SEDE", "OTROS"})
        Me.txtZona.Location = New System.Drawing.Point(639, 315)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(121, 29)
        Me.txtZona.TabIndex = 28
        Me.txtZona.UseSelectable = True
        '
        'lblEmplazamiento
        '
        Me.lblEmplazamiento.AutoSize = True
        Me.lblEmplazamiento.Location = New System.Drawing.Point(514, 364)
        Me.lblEmplazamiento.Name = "lblEmplazamiento"
        Me.lblEmplazamiento.Size = New System.Drawing.Size(100, 19)
        Me.lblEmplazamiento.TabIndex = 75
        Me.lblEmplazamiento.Text = "Emplazamiento"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(514, 325)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 19)
        Me.lblUsuario.TabIndex = 74
        Me.lblUsuario.Text = "Sector"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(514, 209)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(46, 19)
        Me.lblMarca.TabIndex = 73
        Me.lblMarca.Text = "Marca"
        '
        'lblEtiquta
        '
        Me.lblEtiquta.AutoSize = True
        Me.lblEtiquta.Location = New System.Drawing.Point(514, 158)
        Me.lblEtiquta.Name = "lblEtiquta"
        Me.lblEtiquta.Size = New System.Drawing.Size(56, 19)
        Me.lblEtiquta.TabIndex = 72
        Me.lblEtiquta.Text = "Etiqueta"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(514, 119)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 19)
        Me.lblNombre.TabIndex = 71
        Me.lblNombre.Text = "ID Equipo"
        '
        'txtEmplazamiento
        '
        '
        '
        '
        Me.txtEmplazamiento.CustomButton.Image = Nothing
        Me.txtEmplazamiento.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtEmplazamiento.CustomButton.Name = ""
        Me.txtEmplazamiento.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmplazamiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmplazamiento.CustomButton.TabIndex = 1
        Me.txtEmplazamiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmplazamiento.CustomButton.UseSelectable = True
        Me.txtEmplazamiento.CustomButton.Visible = False
        Me.txtEmplazamiento.Lines = New String() {"Codigo estacion"}
        Me.txtEmplazamiento.Location = New System.Drawing.Point(639, 360)
        Me.txtEmplazamiento.MaxLength = 32767
        Me.txtEmplazamiento.Name = "txtEmplazamiento"
        Me.txtEmplazamiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmplazamiento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmplazamiento.SelectedText = ""
        Me.txtEmplazamiento.SelectionLength = 0
        Me.txtEmplazamiento.SelectionStart = 0
        Me.txtEmplazamiento.ShortcutsEnabled = True
        Me.txtEmplazamiento.Size = New System.Drawing.Size(173, 23)
        Me.txtEmplazamiento.TabIndex = 30
        Me.txtEmplazamiento.Text = "Codigo estacion"
        Me.txtEmplazamiento.UseSelectable = True
        Me.txtEmplazamiento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmplazamiento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEtiqueta
        '
        '
        '
        '
        Me.txtEtiqueta.CustomButton.Image = Nothing
        Me.txtEtiqueta.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtEtiqueta.CustomButton.Name = ""
        Me.txtEtiqueta.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEtiqueta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEtiqueta.CustomButton.TabIndex = 1
        Me.txtEtiqueta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEtiqueta.CustomButton.UseSelectable = True
        Me.txtEtiqueta.CustomButton.Visible = False
        Me.txtEtiqueta.Lines = New String(-1) {}
        Me.txtEtiqueta.Location = New System.Drawing.Point(639, 158)
        Me.txtEtiqueta.MaxLength = 32767
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEtiqueta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEtiqueta.SelectedText = ""
        Me.txtEtiqueta.SelectionLength = 0
        Me.txtEtiqueta.SelectionStart = 0
        Me.txtEtiqueta.ShortcutsEnabled = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(173, 23)
        Me.txtEtiqueta.TabIndex = 25
        Me.txtEtiqueta.UseSelectable = True
        Me.txtEtiqueta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEtiqueta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombrePC
        '
        '
        '
        '
        Me.txtNombrePC.CustomButton.Image = Nothing
        Me.txtNombrePC.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtNombrePC.CustomButton.Name = ""
        Me.txtNombrePC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombrePC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombrePC.CustomButton.TabIndex = 1
        Me.txtNombrePC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombrePC.CustomButton.UseSelectable = True
        Me.txtNombrePC.CustomButton.Visible = False
        Me.txtNombrePC.Lines = New String(-1) {}
        Me.txtNombrePC.Location = New System.Drawing.Point(639, 119)
        Me.txtNombrePC.MaxLength = 32767
        Me.txtNombrePC.Name = "txtNombrePC"
        Me.txtNombrePC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombrePC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombrePC.SelectedText = ""
        Me.txtNombrePC.SelectionLength = 0
        Me.txtNombrePC.SelectionStart = 0
        Me.txtNombrePC.ShortcutsEnabled = True
        Me.txtNombrePC.Size = New System.Drawing.Size(173, 23)
        Me.txtNombrePC.TabIndex = 24
        Me.txtNombrePC.UseSelectable = True
        Me.txtNombrePC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombrePC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(399, 196)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 31
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseSelectable = True
        '
        'txtEscala
        '
        Me.txtEscala.AutoSize = True
        Me.txtEscala.Location = New System.Drawing.Point(784, 69)
        Me.txtEscala.Name = "txtEscala"
        Me.txtEscala.Size = New System.Drawing.Size(13, 13)
        Me.txtEscala.TabIndex = 67
        Me.txtEscala.Text = "2"
        Me.txtEscala.Visible = False
        '
        'txtModelo
        '
        Me.txtModelo.FormattingEnabled = True
        Me.txtModelo.ItemHeight = 23
        Me.txtModelo.Location = New System.Drawing.Point(639, 242)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 29)
        Me.txtModelo.TabIndex = 85
        Me.txtModelo.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(514, 286)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel1.TabIndex = 87
        Me.MetroLabel1.Text = "Serial"
        '
        'txtSerial
        '
        '
        '
        '
        Me.txtSerial.CustomButton.Image = Nothing
        Me.txtSerial.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtSerial.CustomButton.Name = ""
        Me.txtSerial.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSerial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSerial.CustomButton.TabIndex = 1
        Me.txtSerial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSerial.CustomButton.UseSelectable = True
        Me.txtSerial.CustomButton.Visible = False
        Me.txtSerial.Lines = New String() {"Ultimos 10 digítos"}
        Me.txtSerial.Location = New System.Drawing.Point(639, 286)
        Me.txtSerial.MaxLength = 32767
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSerial.SelectedText = ""
        Me.txtSerial.SelectionLength = 0
        Me.txtSerial.SelectionStart = 0
        Me.txtSerial.ShortcutsEnabled = True
        Me.txtSerial.Size = New System.Drawing.Size(173, 23)
        Me.txtSerial.TabIndex = 86
        Me.txtSerial.Text = "Ultimos 10 digítos"
        Me.txtSerial.UseSelectable = True
        Me.txtSerial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSerial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1093, 711)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtTamaño)
        Me.Controls.Add(Me.btnImportarExcel)
        Me.Controls.Add(Me.cbUsarExcel)
        Me.Controls.Add(Me.dgvArchivo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbVistaFinalQR)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.lblEmplazamiento)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblEtiquta)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtEmplazamiento)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.txtNombrePC)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtEscala)
        Me.Name = "frmPC"
        Me.Text = "Computadoras y Monitores"
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVistaFinalQR.ResumeLayout(False)
        Me.gbVistaFinalQR.PerformLayout()
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSector As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTamaño As MetroFramework.Controls.MetroComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnImportarExcel As MetroFramework.Controls.MetroButton
    Friend WithEvents cbUsarExcel As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents dgvArchivo As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtMarca As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblModelo As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEtiquetaImprimir As Label
    Friend WithEvents gbVistaFinalQR As GroupBox
    Friend WithEvents ImagenQR As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtZona As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblEmplazamiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsuario As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMarca As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEtiquta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmplazamiento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEtiqueta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombrePC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGenerar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEscala As Label
    Friend WithEvents txtModelo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSerial As MetroFramework.Controls.MetroTextBox
End Class
