Public Class clsTecnica
    Inherits clsEquipamiento


    Property idEquipo As String
    Property sector As String
    Property tipo As String
    Sub New(_IdEquipo As String, _marca As String, _modelo As String, _sector As String, _serial As String, _tipo As String, _UbicacionFisica As String)
        idEquipo = _IdEquipo
        Marca = _marca
        Modelo = _modelo
        sector = _sector
        serial = _serial
        tipo = _tipo
        Emplazamiento = _UbicacionFisica

    End Sub
    Public Overrides Sub PasarAMayusculas()
        idEquipo = UCase(idEquipo)
        Marca = UCase(Marca)
        Modelo = UCase(Modelo)
        sector = UCase(sector)
        serial = UCase(serial)
        tipo = UCase(tipo)
        Emplazamiento = UCase(Emplazamiento)
    End Sub

    Public Overrides Function CrearCadena() As String
        Dim cadena As String
        cadena = Etiqueta & vbNewLine & idEquipo & vbNewLine & tipo & " " & Marca & " " & Modelo & vbNewLine & serial & vbNewLine & sector & vbNewLine & Emplazamiento

        Return cadena
    End Function
End Class
