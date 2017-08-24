Public Class clsListas
    Public Shared Function tipoInfra() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("AP")
            .Add("Firewall")
            .Add("Router")
            .Add("Servidor")
            .Add("Switch")
            .Add("Transeiver")
            .Add("UPS")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function tipoOtros() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("Proyector")
            .Add("Polycom")
            .Add("Switch_HDMI")
            .Add("Televisor")
            .Add("SmartKapp")
            .Add("Kiosco")
            .Add("Docking Station")
            .Add("Disco Rigido")

            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function marcaTablet() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo

            .Add("Apple")
            .Add("BGH")

            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function marcaPC() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("HP")
            .Add("Lenovo")
            .Add("Sony")
            .Add("Bangho")
            .Add("Samsung")
            .Add("LG")
            .Add("Exo")
            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function SectorSede() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("ADM_Y_COMP")
            .Add("ASISTENCIA_AL_MANT")
            .Add("COMUNICACIONES")
            .Add("DESARROLLO_NEGOCIOS")
            .Add("DESARROLLO_RRHH")
            .Add("DIRECCION")
            .Add("DIRECCION_LEGALES")
            .Add("EETT")
            .Add("ESTUDIOS_REG")
            .Add("GCIA_ADMIN")
            .Add("GCIA_DE_OBRAS")
            .Add("GCIA_DE_SISTEMAS")
            .Add("GCIA_FINANZAS")
            .Add("GCIA_INGENIERIA")
            .Add("GCIA_PLANIFICACION")
            .Add("GCIA_COMPRAS")
            .Add("GESTION_CALIDAD")
            .Add("GESTIÓN_DE_RIESGOS")
            .Add("ING_OPERACIONES")
            .Add("INSP_FABRICA")
            .Add("JEFATURA_DE_ADMIN")
            .Add("JEF_CONTADURIA")
            .Add("JEF_IMPUESTOS")
            .Add("LÍNEAS")
            .Add("OBRAS_CIVILES")
            .Add("PLANEAMIENTO")
            .Add("PLANEAMIENTO_RED")
            .Add("PYC")
            .Add("RELACIONES_LABORALES")
            .Add("SEG_PATRIMONIAL")
            .Add("SEGURIDAD_PUBLICA")
            .Add("SERVICIOS_GENERALES")
            .Add("SHTyMA")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function SectorOtros() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("ADMINISTRACION")
            .Add("ALMACENES")
            .Add("C_T_c_T")
            .Add("COMUNICACIONES")
            .Add("COT_OPERACION")
            .Add("COT_POGRAMACION")
            .Add("STAFF")
            .Add("COT_CC")
            .Add("ESTACIONES")
            .Add("GCIA_DE_OBRAS")
            .Add("GCIA_REGIONAL")
            .Add("GESTION_DEL_MANT")
            .Add("LÍNEAS")
            .Add("MANT_COMPLEJO")
            .Add("MANTENIMIENTO_EETT")
            .Add("OPERACIONES")
            .Add("PROGRAMACION")
            .Add("PROT_CONTROL_Y_COM")
            .Add("RRHH")
            .Add("SHTyMA")
            .Add("SISTEMAS")
            .Add("SSTMA")
            .Add("SUPERVISOR_EETT")
            .Add("TCT")
            .Add("TECNICO_EETT")
            .Add("TIERRAS")
            .Add("PROTECCIONES")
            .Add("CONTROL")
            .Add("ARCHIVO TECNICO")
            .Add("ASISTENCIA_AL_MANT")
            .Add("GESTION_CALIDAD")
            .Add("MEDICIONES")
            .Add("TIERRAS")
            .Add("LAB_QUIMICO")
            .Add("COTDT")
            .Add("ARO")
            .Add("GESTION_MANT")
            .Add("MEDICIONES")
            .Add("GESTION_CALIDAD")
            .Add("ING_OPERACIONES")
            .Add("GCIA_INGENIERIA")


            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function EstadoScrap() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("DONACION")
            .Add("DESTRUCCION")

            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function tipoScrap() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("AP")
            .Add("Switch")
            .Add("Servidor")
            .Add("Transeiver")
            .Add("Firewall")
            .Add("UPS")
            .Add("Monitores")
            .Add("Docking")
            .Add("Proyectores")
            .Add("Polycom")
            .Add("Tablet")
            .Add("Ipad")
            .Add("AIO")
            .Add("PC")
            .Add("Notebook")

            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function HPmarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("MS219LA")
            .Add("100B")
            .Add("PROONE 600G1")
            .Add("PROONE 600G2")
            .Add("ELiteBook 840G1")
            .Add("EliteBook 840G3")
            .Add("EliteOne 800G2")
            .Add("PROBook 450G3")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function LenovoMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("E420")
            .Add("E430")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function SonyMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("VPCEB17FL")
            .Add("VPCEB13EL")
            .Sort()
        End With
        Return tipo
    End Function



    Public Shared Function BanghoMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("AIO")
            .Add("BES1525")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function AppleMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("IPAD 2")
            .Add("IPAD PRO")
            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function BGHmarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("Y1000")

            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function LGmarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("23MP55HQ")

            .Sort()
        End With
        Return tipo
    End Function
    Public Shared Function SansungMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("S20C300BL")
            .Add("S19B300")
            .Add("LS22D300FYCZB")
            .Sort()
        End With
        Return tipo
    End Function

    Public Shared Function ExoMarca() As List(Of String)
        Dim tipo As New List(Of String)
        With tipo
            .Add("Bitsy")
            .Add("Kiosco")
            .Sort()
        End With
        Return tipo
    End Function
End Class
