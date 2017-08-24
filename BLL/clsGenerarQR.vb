Imports System.Drawing
Imports ThoughtWorks.QRCode.Codec
Imports EE
Imports DAL
Public Class clsGenerarQR

    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unaPC As clsPC) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unaPC.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing
        End Try

    End Function

    Public Function generarExcel(cadena As String) As DataTable
        Dim DT As New DataTable
        DT = clsExcel.obtenerDatosDeExcel(cadena)
        Return DT

    End Function


    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unScrap As clsScrap) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unScrap.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing
        End Try

    End Function

    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unatablet As clsTablet) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unatablet.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing
        End Try

    End Function

    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unatablet As clsTecnica) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unatablet.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing
        End Try

    End Function
    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unatablet As clsOtrosDispositivos) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unatablet.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing

        End Try

    End Function
    Public Function GenerarBmpQR(width As Integer, height As Integer, escala As Int32, unatablet As clsInfra) As Bitmap
        Try
            Dim generador As New QRCodeEncoder
            Dim qrBMP As Bitmap
            Dim cadena As String = unatablet.CrearCadena()
            generador.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            generador.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            generador.QRCodeScale =
            generador.QRCodeVersion = 0
            generador.QRCodeScale = Integer.Parse(escala)
            qrBMP = generador.Encode(cadena, System.Text.Encoding.ASCII)

            Return qrBMP
        Catch ex As System.IndexOutOfRangeException
            MsgBox("Excedio el tamaño del Codigo QR", MsgBoxStyle.Exclamation, "ERROR")
            Return Nothing

        End Try

    End Function
End Class
