Public Class clsPC
    Inherits clsEquipamiento



    Property idEquipo As String
    Property sector As String

    Sub New(_emplazamiento As String, _etiqueta As String, _idEquipo As String, _marca As String, _modelo As String, _sector As String, _serial As String)
        Emplazamiento = _emplazamiento
        Etiqueta = _etiqueta
        idEquipo = _idEquipo
        Marca = _marca
        Modelo = _modelo
        sector = _sector
        Serial = _serial
    End Sub
    Public Overrides Sub PasarAMayusculas()
        Emplazamiento = UCase(Emplazamiento)
        Etiqueta = UCase(Etiqueta)
        idEquipo = UCase(idEquipo)
        Marca = UCase(Marca)
        Modelo = UCase(Modelo)
        sector = UCase(sector)
        Serial = UCase(Serial)
        Serial = Right(Serial, 10)
    End Sub

    Public Overrides Function CrearCadena() As String
        PasarAMayusculas()
        Dim cadena As String
        cadena = Etiqueta + vbNewLine + idEquipo + vbNewLine + Marca + " " + Modelo + vbNewLine + Serial + vbNewLine + sector + " " + Emplazamiento
        Return cadena
    End Function
End Class
