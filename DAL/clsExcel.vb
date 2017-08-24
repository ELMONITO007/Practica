Imports System.Data.OleDb
Public Class clsExcel
    Public Shared Function obtenerDatosDeExcel(cadena As String) As DataTable
        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim conn As OleDbConnection

        Dim xSheet As String = "Hoja1"
        conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & cadena & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

        Try
            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

            conn.Open()
            da.Fill(ds, "MyData")
            dt = ds.Tables("MyData")
            Return dt
        Catch ex As Exception
            MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Return Nothing
        Finally
            conn.Close()
        End Try

        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")



    End Function
End Class
