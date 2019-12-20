Imports System.Data.SqlClient
Module Funciones
    Public cadena As String 'VARIABLE PARA LA BITACORA
    Public R As String 'VARIABLE QUE ALMACENA TODOS LOS QUERYS
    '-------------------------CODIGO PARA LAS ALERTAS ---------------------------
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
    End Sub
    '-------------------------CODIGO PARA LA BITACORA DE ERRORRES DEL SISTEMA ---------------------------
    Public Sub Bitacora(Formulario As String, Evento As String, error1 As String, Descripcion As String)
        Try
            Dim conexionbit As New SqlConnection("Data Source=IRONMAN;Initial Catalog=Bitacora; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionbit.Open()
            Dim comando As SqlCommand = conexionbit.CreateCommand()
            Dim r As String
            Dim I As Integer
            Dim x As String
            x = "'"
            For I = 1 To Len(error1)
                If Mid(error1, I, 1) = Chr(39) Then
                    x = x & "'"
                Else
                    x = x & Mid(error1, I, 1)
                End If
            Next
            error1 = x
            r = "insert into Resultados(Sistema,Formulario, Evento, Error, Descripcion, Fecha) values ('Cotizador Lite','" & Formulario & "','" & Evento & "'," & error1 & "','" & Descripcion & "', getdate())"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            conexionbit.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
End Module
