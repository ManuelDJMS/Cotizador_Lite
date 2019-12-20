Imports System.Data.SqlClient
Module Conexiones
    '======================= METASINF-2019 ============================
    Public conexion2019 As SqlConnection
    Public comando2019 As SqlCommand
    Public lector2019 As SqlDataReader
    '======================= METASINF-2020 ============================
    Public conexion2020 As SqlConnection
    Public comando2020 As SqlCommand
    Public lector2020 As SqlDataReader
    '======================= METASINF-2020 ============================
    Public conexiongeneral As SqlConnection
    Public comandogeneral As SqlCommand
    Public lectorgeneral As SqlDataReader
    '================================================VARIABLE PARA UTILIZAR LA TRANSACCION DEL LIMS=========================================================================
    Public conexion2020transac As String = ("Data Source=IRONMAN;Initial Catalog=METASINF-2020; User Id=sa; Password=Met99011578a;Integrated Security=False")
    '=======================================================================================================================================================================
    Sub MetodoMetasInf2019()
        Try
            conexion2019 = New SqlConnection("Data Source=IRONMAN;Initial Catalog=MetasInf-2019; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2019.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
    Sub MetodoCotizador2020()
        Try
            conexion2020 = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=MetasCotizador-3; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexion2020.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
    Sub MetodoInformacionGeneral()
        Try
            conexiongeneral = New SqlConnection("Data Source=IRONMAN;Initial Catalog=InformacionGeneral; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexiongeneral.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
