Imports BLL
Imports EE
Imports ThoughtWorks.QRCode.Codec
Public Class frmScrap
    'Generar Enum
#Region "Enum"


    Enum TipoScrap
        AP
        Switch
        Servidor
        Router
        Transeiver
        Firewall
        UPS
        Monitores
        DockingStation
        Proyectores
        Polycom
        Tablet
        Ipad
        AIO
        PC
        Notebook
    End Enum
#End Region
    'Variabes de la tabla y la cadena del QR
    Dim cadena As String
    Dim DTexcel As New DataTable
    'completar los combobox con datos

    Private Sub Generar_Codigo_QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.Color.DarkBlue
        txtEstado.DataSource = clsListas.EstadoScrap
        txtTipo.DataSource = clsListas.tipoScrap
    End Sub

    'boton de generar codigo qr

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        CrearQR()

    End Sub
    'codigo que genera el codigo qr
    Public Sub CrearQR()
        Dim bmp As Bitmap
        Dim generarQR As New clsGenerarQR


        Dim acta As String = txtActa.Text
        Dim estado As String = txtEstado.Text
        Dim Etiqueta As String = txtEtiqueta.Text
        Dim Modelo As String = txtModelo.Text
        Dim posicion As String = txtPosicion.Text
        Dim serial As String = txtSerial.Text
        Dim tipo As String = txtTipo.Text
        Dim unScrap As New clsScrap(acta, estado, Etiqueta, Modelo, posicion, serial, tipo)
        txtEtiquetaImprimir.Text = txtEstado.Text

        ImagenQR.Image = generarQR.GenerarBmpQR(gbVistaFinalQR.Width, gbVistaFinalQR.Height, Integer.Parse(txtEscala.Text), unScrap)

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
            dgvArchivo.CurrentRow.Cells(7).Value = "SI"
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
        txtEstado.Text = dgvArchivo.CurrentRow.Cells(1).Value.ToString
        txtModelo.Text = dgvArchivo.CurrentRow.Cells(2).Value.ToString
        txtSerial.Text = dgvArchivo.CurrentRow.Cells(3).Value.ToString
        txtActa.Text = dgvArchivo.CurrentRow.Cells(4).Value.ToString
        txtPosicion.Text = dgvArchivo.CurrentRow.Cells(5).Value.ToString
        CrearQR()

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
        DTexcel = abrirExcel.generarExcel(cadenaPath)

        llenarGrilla()

    End Sub
    'llena la grilla
    Sub llenarGrilla()
        If dgvArchivo.Visible = True Then
            dgvArchivo.DataSource = ""
            dgvArchivo.DataSource = DTexcel
        End If
    End Sub
End Class