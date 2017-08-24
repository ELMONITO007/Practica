Public Class clsInfra
    Inherits clsEquipamiento


    Property ubicacion As String
    Property tipo As String


    Sub New(_serial As String, _ubicacion As String, _tipo As String, _etiqueta As String, _emplazamiento As String, _modelo As String)
        serial = _serial
        ubicacion = _ubicacion
        tipo = _tipo
        Etiqueta = _etiqueta
        Emplazamiento = _emplazamiento
        Modelo = _modelo
    End Sub
    Public Overrides Function CrearCadena() As String
        PasarAMayusculas()

        Dim cadena As String
        cadena = Etiqueta + vbNewLine + tipo + vbNewLine + Modelo + vbNewLine + serial + vbNewLine + Emplazamiento + vbNewLine + ubicacion

        Return cadena
    End Function

    Public Overrides Sub PasarAMayusculas()
        serial = UCase(serial)
        ubicacion = UCase(ubicacion)
        tipo = UCase(tipo)
        Emplazamiento = UCase(Emplazamiento)
        Etiqueta = UCase(Etiqueta)
        Modelo = UCase(Modelo)
    End Sub
End Class
