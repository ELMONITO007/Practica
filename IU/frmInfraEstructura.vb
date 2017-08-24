Imports BLL
Imports EE
Imports ThoughtWorks.QRCode.Codec
Public Class frmInfraEstructura
    'Generar Enum
#Region "enumerador"
    Enum Tipo
        AP
        Firewall
        Router
        Servidor
        Switch
        Transeiver
        UPS

    End Enum
#End Region
    'Variabes de la tabla y la cadena del QR
    Dim cadena As String
    Dim dtExcel As DataTable
    'completar los combobox con datos
    Private Sub frmOtrosDispositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtTipo.DataSource = clsListas.tipoInfra
    End Sub

    'boton de generar codigo qr
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        CrearQr()
    End Sub


    'codigo que genera el codigo qr
    Sub CrearQr()
        Dim bmp As Bitmap
        Dim generarQR As New clsGenerarQR
        Dim emplazamiento As String = txtEmplazamiento.Text
        Dim etiqueta As String = txtEtiqueta.Text
        Dim modelo As String = txtModelo.Text
        Dim serial As String = txtSerial.Text
        Dim tipoDispositivo As String = txtTipo.Text
        Dim ubicacion As String = txtUbicacion.Text

        Dim unInfra As New clsInfra(serial, ubicacion, tipoDispositivo, etiqueta, emplazamiento, modelo)

        txtEtiquetaImprimir.Text = txtEtiqueta.Text

        ImagenQR.Image = generarQR.GenerarBmpQR(gbVistaFinalQR.Width, gbVistaFinalQR.Height, Integer.Parse(txtEscala.Text), unInfra)

        bmp = New Bitmap(gbVistaFinalQR.Width, gbVistaFinalQR.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        gbVistaFinalQR.DrawToBitmap(bmp, New Rectangle(0, 0, gbVistaFinalQR.Width, gbVistaFinalQR.Height))
        PictureBox1.Image = bmp
    End Sub


    'Codigo para imprimir
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '93 97 (29x30) 70 87(23x23)
        If txtTamaño.Text = "29X30" Then
            e.Graphics.DrawImage(PictureBox1.Image, 0, 0, 93, 97)
        ElseIf txtTamaño.Text = "23X23" Then
            e.Graphics.DrawImage(PictureBox1.Image, 0, 0, 70, 87)
        ElseIf txtTamaño.Text = "" Then
            MsgBox("Ingrese un tamaño")
        End If


    End Sub

    'Cambia el valor de la ultima columna a si cuando se envia a imprimir
    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvArchivo.Visible = True Then
            dgvArchivo.CurrentRow.Cells(6).Value = "SI"
        End If

        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        PrintDocument1.Print()


    End Sub
    'Habilita la opcion de imprimir cuando se elige el tamaño de la etiqueta
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTamaño.SelectedIndexChanged
        btnImprimir.Visible = True
    End Sub

    'Al presionar en la grilla completa automaticamente los texbox correspondientes
    Private Sub dgvArchivo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivo.CellClick


        txtEtiqueta.Text = dgvArchivo.CurrentRow.Cells(0).Value.ToString
        txtTipo.Text = dgvArchivo.CurrentRow.Cells(1).Value.ToString
        txtModelo.Text = dgvArchivo.CurrentRow.Cells(2).Value.ToString
        txtSerial.Text = dgvArchivo.CurrentRow.Cells(3).Value.ToString
        txtUbicacion.Text = dgvArchivo.CurrentRow.Cells(4).Value.ToString
        txtEmplazamiento.Text = dgvArchivo.CurrentRow.Cells(5).Value.ToString


        CrearQr()

    End Sub

    'Activa el boton de improtar excel cuando esta seleccionado el check
    Private Sub cbUsarExcel_CheckedChanged(sender As Object, e As EventArgs) Handles cbUsarExcel.CheckedChanged
        If cbUsarExcel.Checked = True Then
            btnImportarExcel.Visible = True
            dgvArchivo.Visible = True

        Else
            dgvArchivo.Visible = False
            btnImportarExcel.Visible = False

        End If
    End Sub

    'Abre el excel
    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs) Handles btnImportarExcel.Click
        Dim cadenaPath As String
        Dim abrirExcel As New clsGenerarQR
        Dim myFileDialog As New OpenFileDialog()


        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        cadenaPath = myFileDialog.FileName.ToString
        dtExcel = abrirExcel.generarExcel(cadenaPath)

        llenarGrilla()

    End Sub


    'llena la grilla
    Sub llenarGrilla()
        If dgvArchivo.Visible = True Then
            dgvArchivo.DataSource = ""
            dgvArchivo.DataSource = dtExcel
        End If
    End Sub

End Class