Public MustInherit Class clsEquipamiento
    Public Property Etiqueta As String
    Public Property Emplazamiento As String
    Public Property Marca As String
    Public Property Modelo As String
    Public Property Serial As String
    Public MustOverride Function CrearCadena() As String
    Public MustOverride Sub PasarAMayusculas()


End Class
