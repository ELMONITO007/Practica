Public Class clsOtrosDispositivos
    Inherits clsEquipamiento

    Property tipo As String
    Property ubicacionFisica As String


    Sub New(_tipo As String, _ubicacion As String, _modelo As String, _etiqueta As String, _emplazamiento As String, _serial As String)
        tipo = _tipo
        ubicacionFisica = _ubicacion
        Modelo = _modelo
        Etiqueta = _etiqueta
        Emplazamiento = _emplazamiento
        serial = _serial
    End Sub
    Public Overrides Sub PasarAMayusculas()
        tipo = UCase(tipo)
        ubicacionFisica = UCase(ubicacionFisica)
        Modelo = UCase(Modelo)
        Etiqueta = UCase(Etiqueta)
        Emplazamiento = UCase(Emplazamiento)
        serial = UCase(serial)
    End Sub

    Public Overrides Function CrearCadena() As String
        PasarAMayusculas()

        Dim cadena As String
        cadena = Etiqueta + vbNewLine + tipo + " " + Modelo + vbNewLine + serial + vbNewLine + Emplazamiento + vbNewLine + ubicacionFisica
        Return cadena

    End Function
End Class
