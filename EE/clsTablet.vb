Public Class clsTablet
    Inherits clsEquipamiento

    Property sector As String

    Sub New(_emplazamiento As String, _etiqueta As String, _marca As String, _modelo As String, _sector As String, _serial As String)
        Emplazamiento = _emplazamiento
        Etiqueta = _etiqueta
        Marca = _marca
        Modelo = _modelo
        sector = _sector
        Serial = _serial
    End Sub
    Public Overrides Sub PasarAMayusculas()
        Emplazamiento = UCase(Emplazamiento)
        Etiqueta = UCase(Etiqueta)
        Marca = UCase(Marca)
        Modelo = UCase(Modelo)
        sector = UCase(sector)
        Serial = UCase(Serial)
        Serial = Right(Serial, 10)
    End Sub

    Public Overrides Function CrearCadena() As String
        PasarAMayusculas()
        Dim cadena As String
        cadena = Etiqueta & vbNewLine & Emplazamiento & vbNewLine & Marca & " " & Modelo & vbNewLine & Serial & vbNewLine & sector & vbNewLine & Emplazamiento
        Return cadena
    End Function
End Class
