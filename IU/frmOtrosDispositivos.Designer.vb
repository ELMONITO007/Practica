﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtrosDispositivos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEmplazamiento = New MetroFramework.Controls.MetroLabel()
        Me.lblEtiquta = New MetroFramework.Controls.MetroLabel()
        Me.txtEmplazamiento = New MetroFramework.Controls.MetroTextBox()
        Me.txtEtiqueta = New MetroFramework.Controls.MetroTextBox()
        Me.txtEscala = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtEtiquetaImprimir = New System.Windows.Forms.Label()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ImagenQR = New System.Windows.Forms.PictureBox()
        Me.btnImportarExcel = New MetroFramework.Controls.MetroButton()
        Me.cbUsarExcel = New MetroFramework.Controls.MetroCheckBox()
        Me.dgvArchivo = New MetroFramework.Controls.MetroGrid()
        Me.lblModelo = New MetroFramework.Controls.MetroLabel()
        Me.txtModelo = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbVistaFinalQR = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtTamaño = New MetroFramework.Controls.MetroComboBox()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.txtSerial = New MetroFramework.Controls.MetroTextBox()
        Me.txtTipo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtUbicacion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVistaFinalQR.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmplazamiento
        '
        Me.lblEmplazamiento.AutoSize = True
        Me.lblEmplazamiento.Location = New System.Drawing.Point(503, 255)
        Me.lblEmplazamiento.Name = "lblEmplazamiento"
        Me.lblEmplazamiento.Size = New System.Drawing.Size(100, 19)
        Me.lblEmplazamiento.TabIndex = 98
        Me.lblEmplazamiento.Text = "Emplazamiento"
        '
        'lblEtiquta
        '
        Me.lblEtiquta.AutoSize = True
        Me.lblEtiquta.Location = New System.Drawing.Point(503, 88)
        Me.lblEtiquta.Name = "lblEtiquta"
        Me.lblEtiquta.Size = New System.Drawing.Size(56, 19)
        Me.lblEtiquta.TabIndex = 95
        Me.lblEtiquta.Text = "Etiqueta"
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
        Me.txtEmplazamiento.Lines = New String(-1) {}
        Me.txtEmplazamiento.Location = New System.Drawing.Point(628, 251)
        Me.txtEmplazamiento.MaxLength = 32767
        Me.txtEmplazamiento.Name = "txtEmplazamiento"
        Me.txtEmplazamiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmplazamiento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmplazamiento.SelectedText = ""
        Me.txtEmplazamiento.SelectionLength = 0
        Me.txtEmplazamiento.SelectionStart = 0
        Me.txtEmplazamiento.ShortcutsEnabled = True
        Me.txtEmplazamiento.Size = New System.Drawing.Size(173, 23)
        Me.txtEmplazamiento.TabIndex = 17
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
        Me.txtEtiqueta.Location = New System.Drawing.Point(628, 88)
        Me.txtEtiqueta.MaxLength = 32767
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEtiqueta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEtiqueta.SelectedText = ""
        Me.txtEtiqueta.SelectionLength = 0
        Me.txtEtiqueta.SelectionStart = 0
        Me.txtEtiqueta.ShortcutsEnabled = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(173, 23)
        Me.txtEtiqueta.TabIndex = 12
        Me.txtEtiqueta.UseSelectable = True
        Me.txtEtiqueta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEtiqueta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEscala
        '
        Me.txtEscala.AutoSize = True
        Me.txtEscala.Location = New System.Drawing.Point(773, 36)
        Me.txtEscala.Name = "txtEscala"
        Me.txtEscala.Size = New System.Drawing.Size(13, 13)
        Me.txtEscala.TabIndex = 90
        Me.txtEscala.Text = "2"
        Me.txtEscala.Visible = False
        '
        'PrintDocument1
        '
        '
        'txtEtiquetaImprimir
        '
        Me.txtEtiquetaImprimir.AutoSize = True
        Me.txtEtiquetaImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
        Me.txtEtiquetaImprimir.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtEtiquetaImprimir.Location = New System.Drawing.Point(3, 104)
        Me.txtEtiquetaImprimir.Name = "txtEtiquetaImprimir"
        Me.txtEtiquetaImprimir.Size = New System.Drawing.Size(0, 13)
        Me.txtEtiquetaImprimir.TabIndex = 27
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(234, 166)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 20
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'btnImportarExcel
        '
        Me.btnImportarExcel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnImportarExcel.Location = New System.Drawing.Point(244, 290)
        Me.btnImportarExcel.Name = "btnImportarExcel"
        Me.btnImportarExcel.Size = New System.Drawing.Size(109, 23)
        Me.btnImportarExcel.TabIndex = 105
        Me.btnImportarExcel.Text = "Importar excel"
        Me.btnImportarExcel.UseSelectable = True
        Me.btnImportarExcel.Visible = False
        '
        'cbUsarExcel
        '
        Me.cbUsarExcel.AutoSize = True
        Me.cbUsarExcel.Location = New System.Drawing.Point(103, 294)
        Me.cbUsarExcel.Name = "cbUsarExcel"
        Me.cbUsarExcel.Size = New System.Drawing.Size(75, 15)
        Me.cbUsarExcel.TabIndex = 104
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArchivo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvArchivo.EnableHeadersVisualStyles = False
        Me.dgvArchivo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvArchivo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivo.Location = New System.Drawing.Point(5, 398)
        Me.dgvArchivo.MultiSelect = False
        Me.dgvArchivo.Name = "dgvArchivo"
        Me.dgvArchivo.ReadOnly = True
        Me.dgvArchivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvArchivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvArchivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArchivo.Size = New System.Drawing.Size(992, 283)
        Me.dgvArchivo.TabIndex = 103
        Me.dgvArchivo.Visible = False
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(503, 158)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(55, 19)
        Me.lblModelo.TabIndex = 102
        Me.lblModelo.Text = "Modelo"
        '
        'txtModelo
        '
        '
        '
        '
        Me.txtModelo.CustomButton.Image = Nothing
        Me.txtModelo.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtModelo.CustomButton.Name = ""
        Me.txtModelo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtModelo.CustomButton.TabIndex = 1
        Me.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtModelo.CustomButton.UseSelectable = True
        Me.txtModelo.CustomButton.Visible = False
        Me.txtModelo.Lines = New String(-1) {}
        Me.txtModelo.Location = New System.Drawing.Point(628, 154)
        Me.txtModelo.MaxLength = 32767
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtModelo.SelectedText = ""
        Me.txtModelo.SelectionLength = 0
        Me.txtModelo.SelectionStart = 0
        Me.txtModelo.ShortcutsEnabled = True
        Me.txtModelo.Size = New System.Drawing.Size(173, 23)
        Me.txtModelo.TabIndex = 14
        Me.txtModelo.UseSelectable = True
        Me.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtModelo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(876, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 125)
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'gbVistaFinalQR
        '
        Me.gbVistaFinalQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbVistaFinalQR.Controls.Add(Me.txtEtiquetaImprimir)
        Me.gbVistaFinalQR.Controls.Add(Me.ImagenQR)
        Me.gbVistaFinalQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbVistaFinalQR.ForeColor = System.Drawing.SystemColors.Info
        Me.gbVistaFinalQR.Location = New System.Drawing.Point(123, 76)
        Me.gbVistaFinalQR.Name = "gbVistaFinalQR"
        Me.gbVistaFinalQR.Size = New System.Drawing.Size(93, 125)
        Me.gbVistaFinalQR.TabIndex = 100
        Me.gbVistaFinalQR.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(234, 96)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel3.TabIndex = 107
        Me.MetroLabel3.Text = "Tamaño"
        '
        'txtTamaño
        '
        Me.txtTamaño.FormattingEnabled = True
        Me.txtTamaño.ItemHeight = 23
        Me.txtTamaño.Items.AddRange(New Object() {"23X23", "29X30"})
        Me.txtTamaño.Location = New System.Drawing.Point(312, 86)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(121, 29)
        Me.txtTamaño.TabIndex = 106
        Me.txtTamaño.UseSelectable = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(388, 163)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 18
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseSelectable = True
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
        Me.txtSerial.Lines = New String(-1) {}
        Me.txtSerial.Location = New System.Drawing.Point(628, 190)
        Me.txtSerial.MaxLength = 32767
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSerial.SelectedText = ""
        Me.txtSerial.SelectionLength = 0
        Me.txtSerial.SelectionStart = 0
        Me.txtSerial.ShortcutsEnabled = True
        Me.txtSerial.Size = New System.Drawing.Size(173, 23)
        Me.txtSerial.TabIndex = 15
        Me.txtSerial.UseSelectable = True
        Me.txtSerial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSerial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.ItemHeight = 23
        Me.txtTipo.Location = New System.Drawing.Point(628, 114)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(121, 29)
        Me.txtTipo.TabIndex = 13
        Me.txtTipo.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(503, 226)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel1.TabIndex = 115
        Me.MetroLabel1.Text = "Ubicacion"
        '
        'txtUbicacion
        '
        '
        '
        '
        Me.txtUbicacion.CustomButton.Image = Nothing
        Me.txtUbicacion.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtUbicacion.CustomButton.Name = ""
        Me.txtUbicacion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUbicacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUbicacion.CustomButton.TabIndex = 1
        Me.txtUbicacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUbicacion.CustomButton.UseSelectable = True
        Me.txtUbicacion.CustomButton.Visible = False
        Me.txtUbicacion.Lines = New String(-1) {}
        Me.txtUbicacion.Location = New System.Drawing.Point(628, 222)
        Me.txtUbicacion.MaxLength = 32767
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUbicacion.SelectedText = ""
        Me.txtUbicacion.SelectionLength = 0
        Me.txtUbicacion.SelectionStart = 0
        Me.txtUbicacion.ShortcutsEnabled = True
        Me.txtUbicacion.Size = New System.Drawing.Size(173, 23)
        Me.txtUbicacion.TabIndex = 16
        Me.txtUbicacion.UseSelectable = True
        Me.txtUbicacion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUbicacion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(503, 124)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel2.TabIndex = 116
        Me.MetroLabel2.Text = "Tipo"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(503, 194)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 117
        Me.MetroLabel4.Text = "Serial"
        '
        'frmOtrosDispositivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 697)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.lblEmplazamiento)
        Me.Controls.Add(Me.lblEtiquta)
        Me.Controls.Add(Me.txtEmplazamiento)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.txtEscala)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnImportarExcel)
        Me.Controls.Add(Me.cbUsarExcel)
        Me.Controls.Add(Me.dgvArchivo)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbVistaFinalQR)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtTamaño)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "frmOtrosDispositivos"
        Me.Text = "Otros Dispositivos"
        CType(Me.ImagenQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVistaFinalQR.ResumeLayout(False)
        Me.gbVistaFinalQR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmplazamiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEtiquta As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmplazamiento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEtiqueta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEscala As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtEtiquetaImprimir As Label
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ImagenQR As PictureBox
    Friend WithEvents btnImportarExcel As MetroFramework.Controls.MetroButton
    Friend WithEvents cbUsarExcel As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents dgvArchivo As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblModelo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtModelo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbVistaFinalQR As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTamaño As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnGenerar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSerial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUbicacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
End Class
