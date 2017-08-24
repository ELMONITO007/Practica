<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrap
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbUsarExcel = New MetroFramework.Controls.MetroCheckBox()
        Me.dgvArchivo = New MetroFramework.Controls.MetroGrid()
        Me.txtEstado = New MetroFramework.Controls.MetroComboBox()
        Me.lblModelo = New MetroFramework.Controls.MetroLabel()
        Me.txtModelo = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnImportarExcel = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblEmplazamiento = New MetroFramework.Controls.MetroLabel()
        Me.lblUsuario = New MetroFramework.Controls.MetroLabel()
        Me.lblMarca = New MetroFramework.Controls.MetroLabel()
        Me.lblEtiquta = New MetroFramework.Controls.MetroLabel()
        Me.txtActa = New MetroFramework.Controls.MetroTextBox()
        Me.txtSerial = New MetroFramework.Controls.MetroTextBox()
        Me.txtEtiqueta = New MetroFramework.Controls.MetroTextBox()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.txtEscala = New System.Windows.Forms.Label()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtPosicion = New MetroFramework.Controls.MetroTextBox()
        Me.gbVistaFinalQR = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEtiquetaImprimir = New System.Windows.Forms.Label()
        Me.ImagenQR = New System.Windows.Forms.PictureBox()
        Me.txtTipo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtTamaño = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVistaFinalQR.SuspendLayout()
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cbUsarExcel
        '
        Me.cbUsarExcel.AutoSize = True
        Me.cbUsarExcel.Location = New System.Drawing.Point(108, 523)
        Me.cbUsarExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbUsarExcel.Name = "cbUsarExcel"
        Me.cbUsarExcel.Size = New System.Drawing.Size(75, 15)
        Me.cbUsarExcel.TabIndex = 50
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
        Me.dgvArchivo.Location = New System.Drawing.Point(27, 651)
        Me.dgvArchivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.dgvArchivo.Size = New System.Drawing.Size(1488, 435)
        Me.dgvArchivo.TabIndex = 49
        Me.dgvArchivo.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.FormattingEnabled = True
        Me.txtEstado.ItemHeight = 23
        Me.txtEstado.Location = New System.Drawing.Point(914, 200)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(180, 29)
        Me.txtEstado.TabIndex = 3
        Me.txtEstado.UseSelectable = True
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(726, 275)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(55, 19)
        Me.lblModelo.TabIndex = 48
        Me.lblModelo.Text = "Modelo"
        '
        'txtModelo
        '
        '
        '
        '
        Me.txtModelo.CustomButton.Image = Nothing
        Me.txtModelo.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtModelo.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtModelo.CustomButton.Name = ""
        Me.txtModelo.CustomButton.Size = New System.Drawing.Size(50, 51)
        Me.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtModelo.CustomButton.TabIndex = 1
        Me.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtModelo.CustomButton.UseSelectable = True
        Me.txtModelo.CustomButton.Visible = False
        Me.txtModelo.Lines = New String(-1) {}
        Me.txtModelo.Location = New System.Drawing.Point(914, 269)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtModelo.MaxLength = 32767
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModelo.SelectedText = ""
        Me.txtModelo.SelectionLength = 0
        Me.txtModelo.SelectionStart = 0
        Me.txtModelo.ShortcutsEnabled = True
        Me.txtModelo.Size = New System.Drawing.Size(260, 35)
        Me.txtModelo.TabIndex = 4
        Me.txtModelo.UseSelectable = True
        Me.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModelo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1302, 143)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 192)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnImportarExcel
        '
        Me.btnImportarExcel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnImportarExcel.Location = New System.Drawing.Point(320, 517)
        Me.btnImportarExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImportarExcel.Name = "btnImportarExcel"
        Me.btnImportarExcel.Size = New System.Drawing.Size(164, 35)
        Me.btnImportarExcel.TabIndex = 51
        Me.btnImportarExcel.Text = "Importar excel"
        Me.btnImportarExcel.UseSelectable = True
        Me.btnImportarExcel.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(268, 263)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 35)
        Me.btnImprimir.TabIndex = 45
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.Visible = False
        '
        'PrintDocument1
        '
        '
        'lblEmplazamiento
        '
        Me.lblEmplazamiento.AutoSize = True
        Me.lblEmplazamiento.Location = New System.Drawing.Point(726, 391)
        Me.lblEmplazamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmplazamiento.Name = "lblEmplazamiento"
        Me.lblEmplazamiento.Size = New System.Drawing.Size(35, 19)
        Me.lblEmplazamiento.TabIndex = 44
        Me.lblEmplazamiento.Text = "Acta"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(726, 337)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(41, 19)
        Me.lblUsuario.TabIndex = 43
        Me.lblUsuario.Text = "Serial"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(726, 215)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(48, 19)
        Me.lblMarca.TabIndex = 42
        Me.lblMarca.Text = "Estado"
        '
        'lblEtiquta
        '
        Me.lblEtiquta.AutoSize = True
        Me.lblEtiquta.Location = New System.Drawing.Point(726, 137)
        Me.lblEtiquta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtiquta.Name = "lblEtiquta"
        Me.lblEtiquta.Size = New System.Drawing.Size(56, 19)
        Me.lblEtiquta.TabIndex = 41
        Me.lblEtiquta.Text = "Etiqueta"
        '
        'txtActa
        '
        '
        '
        '
        Me.txtActa.CustomButton.Image = Nothing
        Me.txtActa.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtActa.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtActa.CustomButton.Name = ""
        Me.txtActa.CustomButton.Size = New System.Drawing.Size(50, 51)
        Me.txtActa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtActa.CustomButton.TabIndex = 1
        Me.txtActa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtActa.CustomButton.UseSelectable = True
        Me.txtActa.CustomButton.Visible = False
        Me.txtActa.Lines = New String(-1) {}
        Me.txtActa.Location = New System.Drawing.Point(914, 391)
        Me.txtActa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtActa.MaxLength = 32767
        Me.txtActa.Name = "txtActa"
        Me.txtActa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActa.SelectedText = ""
        Me.txtActa.SelectionLength = 0
        Me.txtActa.SelectionStart = 0
        Me.txtActa.ShortcutsEnabled = True
        Me.txtActa.Size = New System.Drawing.Size(260, 35)
        Me.txtActa.TabIndex = 6
        Me.txtActa.UseSelectable = True
        Me.txtActa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtActa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSerial
        '
        '
        '
        '
        Me.txtSerial.CustomButton.Image = Nothing
        Me.txtSerial.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtSerial.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSerial.CustomButton.Name = ""
        Me.txtSerial.CustomButton.Size = New System.Drawing.Size(50, 51)
        Me.txtSerial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSerial.CustomButton.TabIndex = 1
        Me.txtSerial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSerial.CustomButton.UseSelectable = True
        Me.txtSerial.CustomButton.Visible = False
        Me.txtSerial.Lines = New String(-1) {}
        Me.txtSerial.Location = New System.Drawing.Point(914, 331)
        Me.txtSerial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSerial.MaxLength = 32767
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSerial.SelectedText = ""
        Me.txtSerial.SelectionLength = 0
        Me.txtSerial.SelectionStart = 0
        Me.txtSerial.ShortcutsEnabled = True
        Me.txtSerial.Size = New System.Drawing.Size(260, 35)
        Me.txtSerial.TabIndex = 5
        Me.txtSerial.UseSelectable = True
        Me.txtSerial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSerial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEtiqueta
        '
        '
        '
        '
        Me.txtEtiqueta.CustomButton.Image = Nothing
        Me.txtEtiqueta.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtEtiqueta.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEtiqueta.CustomButton.Name = ""
        Me.txtEtiqueta.CustomButton.Size = New System.Drawing.Size(50, 51)
        Me.txtEtiqueta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEtiqueta.CustomButton.TabIndex = 1
        Me.txtEtiqueta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEtiqueta.CustomButton.UseSelectable = True
        Me.txtEtiqueta.CustomButton.Visible = False
        Me.txtEtiqueta.Lines = New String(-1) {}
        Me.txtEtiqueta.Location = New System.Drawing.Point(914, 138)
        Me.txtEtiqueta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEtiqueta.MaxLength = 32767
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEtiqueta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEtiqueta.SelectedText = ""
        Me.txtEtiqueta.SelectionLength = 0
        Me.txtEtiqueta.SelectionStart = 0
        Me.txtEtiqueta.ShortcutsEnabled = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(260, 35)
        Me.txtEtiqueta.TabIndex = 2
        Me.txtEtiqueta.UseSelectable = True
        Me.txtEtiqueta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEtiqueta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(554, 263)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(112, 35)
        Me.btnGenerar.TabIndex = 39
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseSelectable = True
        '
        'txtEscala
        '
        Me.txtEscala.AutoSize = True
        Me.txtEscala.Location = New System.Drawing.Point(1131, 68)
        Me.txtEscala.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEscala.Name = "txtEscala"
        Me.txtEscala.Size = New System.Drawing.Size(18, 20)
        Me.txtEscala.TabIndex = 34
        Me.txtEscala.Text = "2"
        Me.txtEscala.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(726, 449)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 53
        Me.MetroLabel1.Text = "Posicion"
        '
        'txtPosicion
        '
        '
        '
        '
        Me.txtPosicion.CustomButton.Image = Nothing
        Me.txtPosicion.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtPosicion.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPosicion.CustomButton.Name = ""
        Me.txtPosicion.CustomButton.Size = New System.Drawing.Size(50, 51)
        Me.txtPosicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPosicion.CustomButton.TabIndex = 1
        Me.txtPosicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPosicion.CustomButton.UseSelectable = True
        Me.txtPosicion.CustomButton.Visible = False
        Me.txtPosicion.Lines = New String(-1) {}
        Me.txtPosicion.Location = New System.Drawing.Point(914, 449)
        Me.txtPosicion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPosicion.MaxLength = 32767
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosicion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosicion.SelectedText = ""
        Me.txtPosicion.SelectionLength = 0
        Me.txtPosicion.SelectionStart = 0
        Me.txtPosicion.ShortcutsEnabled = True
        Me.txtPosicion.Size = New System.Drawing.Size(260, 35)
        Me.txtPosicion.TabIndex = 7
        Me.txtPosicion.UseSelectable = True
        Me.txtPosicion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPosicion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'gbVistaFinalQR
        '
        Me.gbVistaFinalQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbVistaFinalQR.Controls.Add(Me.Label1)
        Me.gbVistaFinalQR.Controls.Add(Me.txtEtiquetaImprimir)
        Me.gbVistaFinalQR.Controls.Add(Me.ImagenQR)
        Me.gbVistaFinalQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbVistaFinalQR.ForeColor = System.Drawing.SystemColors.Info
        Me.gbVistaFinalQR.Location = New System.Drawing.Point(99, 129)
        Me.gbVistaFinalQR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbVistaFinalQR.Name = "gbVistaFinalQR"
        Me.gbVistaFinalQR.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbVistaFinalQR.Size = New System.Drawing.Size(140, 192)
        Me.gbVistaFinalQR.TabIndex = 54
        Me.gbVistaFinalQR.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(4, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 28
        '
        'txtEtiquetaImprimir
        '
        Me.txtEtiquetaImprimir.AutoSize = True
        Me.txtEtiquetaImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtiquetaImprimir.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEtiquetaImprimir.Location = New System.Drawing.Point(4, 160)
        Me.txtEtiquetaImprimir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEtiquetaImprimir.Name = "txtEtiquetaImprimir"
        Me.txtEtiquetaImprimir.Size = New System.Drawing.Size(0, 22)
        Me.txtEtiquetaImprimir.TabIndex = 27
        '
        'ImagenQR
        '
        Me.ImagenQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenQR.Location = New System.Drawing.Point(0, 14)
        Me.ImagenQR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagenQR.Name = "ImagenQR"
        Me.ImagenQR.Size = New System.Drawing.Size(138, 140)
        Me.ImagenQR.TabIndex = 0
        Me.ImagenQR.TabStop = False
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.ItemHeight = 23
        Me.txtTipo.Location = New System.Drawing.Point(914, 494)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(180, 29)
        Me.txtTipo.TabIndex = 55
        Me.txtTipo.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(726, 509)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel2.TabIndex = 56
        Me.MetroLabel2.Text = "Tipo"
        '
        'txtTamaño
        '
        Me.txtTamaño.FormattingEnabled = True
        Me.txtTamaño.ItemHeight = 23
        Me.txtTamaño.Items.AddRange(New Object() {"23X23", "29X30"})
        Me.txtTamaño.Location = New System.Drawing.Point(386, 143)
        Me.txtTamaño.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(180, 29)
        Me.txtTamaño.TabIndex = 57
        Me.txtTamaño.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(268, 158)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel3.TabIndex = 58
        Me.MetroLabel3.Text = "Tamaño"
        '
        'frmScrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1642, 1094)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtTamaño)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.gbVistaFinalQR)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.cbUsarExcel)
        Me.Controls.Add(Me.dgvArchivo)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImportarExcel)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblEmplazamiento)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblEtiquta)
        Me.Controls.Add(Me.txtActa)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtEscala)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmScrap"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        Me.Text = "Scrap"
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVistaFinalQR.ResumeLayout(False)
        Me.gbVistaFinalQR.PerformLayout()
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbUsarExcel As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents dgvArchivo As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtEstado As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblModelo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtModelo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnImportarExcel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lblEmplazamiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsuario As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMarca As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEtiquta As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtActa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSerial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEtiqueta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGenerar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEscala As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPosicion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gbVistaFinalQR As GroupBox
    Friend WithEvents txtEtiquetaImprimir As Label
    Friend WithEvents ImagenQR As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTamaño As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
