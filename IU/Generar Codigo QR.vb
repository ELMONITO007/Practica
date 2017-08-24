
'Imports BLL
'Imports EE
'Imports ThoughtWorks.QRCode.Codec
'Public Class Generar_Codigo_QR

'    Dim cadena As String
'    Dim DTexcel As New DataTable
'#Region "Enumerador"

'    Enum SECTOR_SEDE
'        ADMINISTRACIÓN_Y_COMPENSACIONES
'        ASISTENCIA_AL_MANTENIMIENTO
'        COMUNICACIONES
'        DESARROLLO_NEGOCIOS
'        DESARROLLO_RRHH
'        DIRECCION
'        DIRECCION_DE_ASUNTOS_LEGALES
'        ESTACIONES_TRANSFORMADORAS
'        ESTUDIOS_Y_ANALISIS_REGULATORIOS
'        GERENCIA_ADMINISTRACION
'        GERENCIA_DE_OBRAS
'        GERENCIA_DE_SISTEMAS
'        GERENCIA_FINANZAS
'        GERENCIA_INGENIERIA
'        GERENCIA_PLANIFICACION
'        GERENCIA_SUMINISTROS_Y_ABASTECIMIENTO
'        GESTION_DE_LA_CALIDAD
'        GESTIÓN_DE_RIESGOS_Y_AUDITORIAS
'        INGENIERIA_DE_OPERACIONES
'        INSPECCION_EN_FABRICA
'        JEFATURA_DE_ADMINISTRACION_REGIONAL
'        JEFATURA_DE_CONTADURIA
'        JEFATURA_DE_IMPUESTOS
'        LÍNEAS
'        OBRAS_CIVILES
'        PLANEAMIENTO
'        PLANEAMIENTO_DE_LA_RED
'        PROTECCIONES_Y_CONTROL
'        RELACIONES_LABORALES
'        SEGURIDAD_PATRIMONIAL
'        SEGURIDAD_PUBLICA
'        SERVICIOS_GENERALES
'        SHTyMA



'    End Enum
'    Enum SECTOR_OTROS
'        ADMINISTRACION
'        ALMACENES
'        C_T_c_T
'        COMUNICACIONES
'        COT
'        ESTACIONES
'        GERENCIA_DE_OBRAS
'        GERENCIA_REGIONAL
'        GESTION_DEL_MANTENIMIENTO
'        LÍNEAS
'        MANTENIMIENTO_COMPLEJO
'        MANTENIMIENTO_DE_ESTACIONES
'        OPERACIONES
'        PROGRAMACION
'        PROTECCIONES_CONTROL_Y_COM
'        RRHH
'        SHTyMA
'        SISTEMAS
'        SSTMA
'        SUPERVISOR_EETT
'        TCT
'        TECNICO_DE_ESTACIONES
'        TIERRAS

'    End Enum


'#End Region

'    Private Sub Generar_Codigo_QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Me.BackColor = System.Drawing.Color.DarkBlue

'    End Sub

'    Private Sub btnGenerar_Click(sender As Object, e As EventArgs)



'    End Sub

'    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

'        crearQR()

'    End Sub

'    Public Sub crearQR()
'        Dim bmp As Bitmap
'        Dim generarQR As New clsGenerarQR
'        Dim unaPC As New clsPC

'        unaPC.Emplazamiento = txtEmplazamiento.Text
'        unaPC.Etiqueta = txtEtiqueta.Text
'        unaPC.Marca = txtMarca.Text
'        unaPC.Modelo = txtModelo.Text
'        unaPC.idEquipo = txtNombrePC.Text
'        unaPC.sector = txtSector.Text
'        ImagenQR.Image = generarQR.GenerarBmpQR(gbVistaFinalQR.Width, gbVistaFinalQR.Height, Integer.Parse(txtEscala.Text), unaPC)



'        txtEtiquetaImprimir.Text = txtEtiqueta.Text




'        bmp = New Bitmap(gbVistaFinalQR.Width, gbVistaFinalQR.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
'        gbVistaFinalQR.DrawToBitmap(bmp, New Rectangle(0, 0, gbVistaFinalQR.Width, gbVistaFinalQR.Height))
'        PictureBox1.Image = bmp

'    End Sub



'    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
'        '93 97 (29x30) 70 87(23x23)
'        If txtTamaño.Text = "29X30" Then
'            e.Graphics.DrawImage(PictureBox1.Image, 0, 0, 93, 97)
'        ElseIf txtTamaño.Text = "23X23" Then
'            e.Graphics.DrawImage(PictureBox1.Image, 0, 0, 70, 87)
'        ElseIf txtTamaño.Text = "" Then
'            MsgBox("Ingrese un tamaño")
'        End If

'    End Sub

'    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
'        If dgvArchivo.Visible = True Then
'            dgvArchivo.CurrentRow.Cells(6).Value = "SI"
'        End If


'        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
'        PrintDocument1.Print()


'    End Sub

'    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbUsarExcel.CheckedChanged
'        If cbUsarExcel.Checked = True Then
'            btnImportarExcel.Visible = True
'            dgvArchivo.Visible = True

'        Else
'            dgvArchivo.Visible = False
'            btnImportarExcel.Visible = False

'        End If
'    End Sub

'    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs) Handles btnImportarExcel.Click
'        Dim cadenaPath As String
'        Dim abrirExcel As New clsGenerarQR
'        Dim myFileDialog As New OpenFileDialog()

'        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
'        With myFileDialog
'            .Filter = "Excel Files |*.xlsx"
'            .Title = "Open File"
'            .ShowDialog()
'        End With
'        cadenaPath = myFileDialog.FileName.ToString
'        DTexcel = abrirExcel.generarExcel(cadenaPath)
'        'End If
'        llenarGrilla()

'    End Sub

'    Sub llenarGrilla()
'        If dgvArchivo.Visible = True Then
'            dgvArchivo.DataSource = ""
'            dgvArchivo.DataSource = DTexcel
'        End If
'    End Sub

'    Private Sub dgvArchivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivo.CellContentClick

'    End Sub

'    Private Sub txtTamaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTamaño.SelectedIndexChanged
'        btnImprimir.Visible = True
'    End Sub

'    Private Sub dgvArchivo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivo.CellClick


'        txtNombrePC.Text = dgvArchivo.CurrentRow.Cells(1).Value.ToString
'        txtEtiqueta.Text = dgvArchivo.CurrentRow.Cells(0).Value.ToString
'        txtMarca.Text = dgvArchivo.CurrentRow.Cells(2).Value.ToString
'        txtModelo.Text = dgvArchivo.CurrentRow.Cells(3).Value.ToString
'        txtSector.Text = dgvArchivo.Curre||ntRow.Cells(4).Value.ToString
'        txtEmplazamiento.Text = dgvArchivo.CurrentRow.Cells(5).Value.ToString
'        crearQR()
'    End Sub

'    Private Sub txtZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtZona.SelectedIndexChanged

'    End Sub

'    Private Sub txtSector_Click(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub txtSector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSector.SelectedIndexChanged

'    End Sub
'End Class