Public Class clsScrap
    Inherits clsEquipamiento

    Property estado As String

    Property acta As String
    Property posicion As String
    Property tipo As String

    Sub New(_acta As String, _estado As String, _etiqueta As String, _modelo As String, _posicion As String, _serial As String, _tipo As String)
        acta = _acta
        estado = _estado
        Etiqueta = _etiqueta
        Modelo = _modelo
        posicion = _posicion
        serial = _serial
        tipo = _tipo

    End Sub

    Public Overrides Function CrearCadena() As String
        PasarAMayusculas()

        Dim cadena As String
        cadena = Etiqueta & vbNewLine & estado & vbNewLine & Modelo & vbNewLine & serial & vbNewLine & acta & vbNewLine & posicion & vbNewLine & tipo

        Return cadena
    End Function

    Public Overrides Sub PasarAMayusculas()
        acta = UCase(acta)
        estado = UCase(estado)
        Etiqueta = UCase(Etiqueta)
        Modelo = UCase(Modelo)
        posicion = UCase(posicion)
        serial = UCase(serial)
        tipo = UCase(tipo)
    End Sub
End Class
