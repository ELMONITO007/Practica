﻿Imports BLL
Imports EE
Imports ThoughtWorks.QRCode.Codec
Public Class frmTecnica
    Dim cadena As String
    Dim dtExcel As DataTable
    'Generar Enum

    Private Sub frmTecnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMarca.DataSource = clsListas.marcaPC
        txtTipo.DataSource = clsListas.tipoScrap
    End Sub
    'controlar el combo de la zona para determinar el sector
    Private Sub txtZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtZona.SelectedIndexChanged
        If txtZona.Text = "SEDE" Then
            txtSector.DataSource = clsListas.SectorSede
        ElseIf txtZona.Text = "OTROS" Then
            txtSector.DataSource = clsListas.SectorOtros
        End If
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
        Dim idEquipo As String = txtNombrePC.Text
        Dim modelo As String = txtModelo.Text
        Dim sector As String = txtSector.Text
        Dim marcaPC As String = txtMarca.Text
        Dim tipo As String = txtTipo.Text
        Dim serial As String = txtSerial.Text
        Dim tecnica As New clsTecnica(idEquipo, marcaPC, modelo, sector, serial, tipo, emplazamiento)
        txtEtiquetaImprimir.Text = txtEtiqueta.Text

        ImagenQR.Image = generarQR.GenerarBmpQR(gbVistaFinalQR.Width, gbVistaFinalQR.Height, Integer.Parse(txtEscala.Text), tecnica)

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
            dgvArchivo.CurrentRow.Cells(8).Value = "SI"
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

        txtNombrePC.Text = dgvArchivo.CurrentRow.Cells(0).Value.ToString
        txtEtiqueta.Text = dgvArchivo.CurrentRow.Cells(1).Value.ToString
        txtTipo.Text = dgvArchivo.CurrentRow.Cells(2).Value.ToString
        txtMarca.Text = dgvArchivo.CurrentRow.Cells(3).Value.ToString
        txtModelo.Text = dgvArchivo.CurrentRow.Cells(4).Value.ToString
        txtSerial.Text = dgvArchivo.CurrentRow.Cells(5).Value.ToString
        txtSector.Text = dgvArchivo.CurrentRow.Cells(6).Value.ToString
        txtEmplazamiento.Text = dgvArchivo.CurrentRow.Cells(7).Value.ToString
        txtZona.Text = dgvArchivo.CurrentRow.Cells(9).Value.ToString

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