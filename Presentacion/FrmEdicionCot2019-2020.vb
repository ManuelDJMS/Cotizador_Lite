Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class FrmEdicionCot2019_2020
    Dim banm, banb As Boolean
    Dim clave1 As String
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(255, 255, 255))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim lx, ly As Integer

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FrmCotizacion2019.RbCotizacion.Checked = True
        Me.Close()
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Me.WindowState = FormWindowState.Normal
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        BtnMaximizar.Visible = True
        BtnRestaurar.Visible = False
    End Sub

    Private Sub FrmEdicionCot2019_2020_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        If respuestafolio = 0 Then
            R = "select isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
         isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
         isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'), isnull(EntradaRegistroCot.Numcot,'-'), EntradaRegistroCot.Fecha,
         isnull(EntradaRegistroCot.Referencia,'-'), isnull(EntradaRegistroCot.Observaciones,'-'), isnull(EntradaRegistroCot.Numcond,'-'), isnull(Condiciones_p_cotizar.donde,'-'),
         isnull(Condiciones_p_cotizar.Precios,'-'), isnull(Condiciones_p_cotizar.tentrega,'-'), isnull(Condiciones_p_cotizar.modalidad,'-'), isnull([Claves-Elaboro-Cot].Nombre,'-'), 
         isnull(EntradaRegistroCot.ServicioEn,'-'), isnull(MetAsInf.RFC,'-') 
         from [InformacionGeneral].[dbo].MetAsInf inner join [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
         inner join EntradaRegistroCot on [Contactos-Clientes-Usuarios].ClaveContacto = EntradaRegistroCot.ClaveContacto
         inner join Condiciones_p_cotizar on EntradaRegistroCot.[Elaboró Cot] = Condiciones_p_cotizar.Numcond 
         inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot]= EntradaRegistroCot.[Elaboró Cot] where EntradaRegistroCot.Numcot =" & NumCot
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            TxtClaveE.Text = lector2019(0)
            TxtNombreEmpresa.Text = lector2019(1)
            TxtDomicilio.Text = lector2019(1)
            TxtCiudad.Text = lector2019(3)
            TxtEstado.Text = lector2019(4)
            TxtCveContacto.Text = lector2019(5)
            TxtNombreC.Text = lector2019(6)
            TxtTelefono.Text = lector2019(7)
            TxtExt.Text = lector2019(8)
            TxtCorreo.Text = lector2019(9)
            TxtReferencia.Text = lector2019(12)
            TxtObservaciones.Text = lector2019(13)
            TxtNumCon.Text = lector2019(14)
            TxtCotizo.Text = lector2019(19)
            CboServicio.Text = lector2019(20)
            TxtRFC.Text = lector2019(21)
            lector2019.Close()
            R = "select *from [1Cotizar] where Numcot =" & NumCot
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                DgCotizaciones.Rows.Add(False, lector2019(2), lector2019(3), lector2019(5), lector2019(6), lector2019(7), lector2019(8), lector2019(10), lector2019(9), lector2019(11))
                partida1 = lector2019(2).ToString
            End While
            lector2019.Close()

        Else
            R = "select top 1 isnull(Folio,'-'),isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), 
		         isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), 
		         isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                 isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'),
                 isnull(RFC,'-')
		         from [INFORMES-SERVICIOS] INNER JOIN [InformacionGeneral].[dbo].MetAsInf on [INFORMES-SERVICIOS].ClaveContactoConsign=MetAsInf.Clavempresa
		         inner join [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] on [INFORMES-SERVICIOS].Clavecontacto = [Contactos-Clientes-Usuarios].Clavecontacto
		         where Folio=" & respuestafolio

            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            LbCot_Folio.Text = "Folio"
            TxtCotizacion.Text = lector2019(0)
            TxtClaveE.Text = lector2019(1)
            TxtNombreEmpresa.Text = lector2019(2)
            TxtDomicilio.Text = lector2019(3)
            TxtCiudad.Text = lector2019(4)
            TxtEstado.Text = lector2019(5)
            TxtCveContacto.Text = lector2019(6)
            TxtNombreC.Text = lector2019(7)
            TxtTelefono.Text = lector2019(8)
            TxtExt.Text = lector2019(9)
            TxtCorreo.Text = lector2019(10)
            TxtRFC.Text = lector2019(11)
            TxtReferencia.Text = "Confirmación Metrológica No." + Convert.ToString(respuestafolio)
            lector2019.Close()
            '----------------------------Llenar el grid por folio---------------------------------------------
            R = "select isnull(ServCatalogo1,'-'),isnull(Tipo,'-'), isnull(Marca,'-'), isnull(Modelo,'-'), 
                 isnull(ID,'-'), isnull(Puntos,'-'),isnull(PUCalib,'-'),isnull(Alcance,'-'),isnull(Serie,'-'), 
                 isnull(Informe,'-'), FECHACALIB, MAGNITUD, INFORME from [INFORMES-SERVICIOS] where Folio=" & respuestafolio
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            Dim partida As Integer = 1
            While lector2019.Read()
                DgCotizaciones.Rows.Add(False, partida, lector2019(0), 1, lector2019(1), lector2019(2), lector2019(3),
                 lector2019(4), (lector2019(5) + " Referencia Certificado " + lector2019(11) + lector2019(12)), lector2019(6), "-", lector2019(7), lector2019(8), lector2019(9), lector2019(10))
                partida = partida + 1
            End While
            lector2019.Close()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fechaActual As DateTime
        Dim maximo As Integer
        If DgCotizaciones.Rows.Count = 0 Then
            MsgBox("No hay artículos por cotizar¡", MsgBoxStyle.Critical)
        Else
            If TxtCotizo2020.Text = "" Then
                MsgBox("¿Quien Realiza esta Cotización?", MsgBoxStyle.Critical)
            Else
                Try
                    fechaActual = Convert.ToDateTime(DtpDesde.Text).ToShortDateString
                    Using conexion As New SqlConnection(conexion2020transac)
                    conexion.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion
                    comando.Transaction = transaction
                        If TxtCotizacion20.Text.Trim.Equals("") Then
                            '========================================================== SACAR EL ULTIMO REGISTRO DE COTIZACIONES PARA EL DETALLE DE COTIZACION =============================================================
                            R = "select MAX(Numcot) from [EntradaRegistroCot]"
                            comando.CommandText = R
                            lector = comando.ExecuteReader
                            lector.Read()
                            If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
                                maximo = 1
                            Else
                                maximo = lector(0)
                            End If
                            lector.Close()
                            '========================================================= DECISION SI SE GUARDA POR FOLIO O POR COT ===================================================================
                            If respuestafolio = 0 Then
                                '**************************************************** INSERTA EN ENTRADAREGISTROCOT CON COTIZACION *************************************************************************************
                                R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
                                     CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & TxtNombreEmpresa.Text & "',
                                     " & Val(TxtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & TxtReferencia.Text & "'," & Val(TxtNumCon.Text) & ",
                                     '" & TxtObservaciones.Text & "','" & CboServicio.Text & "'," & Val(TxtTipoCliente.Text) & "," & Val(TxtClaveE.Text) & "," & Val(TxtCotizo2020.Text) & "," & TxtConta.Text & ")"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            Else

                                '**************************************************** INSERTA EN ENTRADAREGISTROCOT CON COTIZACION *************************************************************************************
                                R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
                            CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & TxtNombreEmpresa.Text & "',
                            " & Val(TxtCveContacto.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & TxtReferencia.Text & "'," & Val(TxtNumCond.Text) & ",
                            '" & TxtObservaciones.Text & "','" & CboServicio.Text & "'," & Val(TxtTipoCliente.Text) & "," & Val(TxtClaveE.Text) & "," & Val(TxtCotizo2020.Text) & "," & TxtConta.Text & ")"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            End If
                            '=============================================== CODIGO PARA GUARDAR EN 1COTIZAR =========================================================================================
                            For i = 0 To DgCotizaciones.Rows.Count - 2
                                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                                ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DgCotizaciones.Item(2, i).Value & "',
                                '" & "-" & "'," & Val(DgCotizaciones.Item(3, i).Value) & ",'" & DgCotizaciones.Item(4, i).Value & "',
                                '" & DgCotizaciones.Item(5, i).Value & "','" & DgCotizaciones.Item(6, i).Value & "','" & DgCotizaciones.Item(8, i).Value & "','
                                " & DgCotizaciones.Item(7, i).Value & "'," & Val(DgCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            Next i
                        Else '============================ELSE DE DECISION SI ES NUEVA COT O NO ================================================
                            If respuestafolio = 0 Then
                                ''===================================== Se hace update a una cot apartada, ya existente (UPDATE) ==============================================================
                                R = "update EntradaRegistroCot set NumCot='" & Val(TxtCotizacion20.Text) & "', Cliente = '" & TxtNombreEmpresa.Text & "', 
                             ClaveContacto='" & Val(TxtCveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & TxtReferencia.Text & "', 
                             Numcond='" & Val(TxtNumCond.Text) & "', Observaciones='" & TxtObservaciones.Text & "', ServicioEn='" & CboServicio.Text & "', 
                             TipodeCliente='1', CveEmpresa='" & Val(TxtClaveE.Text) & "', [Elaboró Cot]=" & Val(TxtCotizo2020.Text) & ", 
                             ModoDeContabilizar='" & Val(TxtConta.Text) & "' WHERE NumCot='" & Val(TxtCotizacion20.Text) & "'"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            Else
                                ''===================================== Se hace update a una cot apartada, ya existente (UPDATE) ==============================================================
                                R = "update EntradaRegistroCot set NumCot='" & Val(TxtCotizacion20.Text) & "', Cliente = '" & TxtNombreEmpresa.Text & "', 
                             ClaveContacto='" & Val(TxtCveContacto.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & TxtReferencia.Text & "', 
                             Numcond='" & Val(TxtNumCond.Text) & "', Observaciones='" & TxtObservaciones.Text & "', ServicioEn='" & CboServicio.Text & "', 
                             TipodeCliente='1', CveEmpresa='" & Val(TxtClaveE.Text) & "', [Elaboró Cot]=" & Val(TxtCotizo2020.Text) & ", 
                             ModoDeContabilizar='" & Val(TxtConta.Text) & "' WHERE NumCot='" & Val(TxtCotizacion20.Text) & "'"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            End If

                            For i = 0 To DgCotizaciones.Rows.Count - 2
                                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                                 ID, Punitariocot, Realizado) values (" & Val(TxtCotizacion20.Text) & "," & Val(i + 1) & ",'" & DgCotizaciones.Item(2, i).Value & "',
                                '" & "-" & "'," & Val(DgCotizaciones.Item(3, i).Value) & ",'" & DgCotizaciones.Item(4, i).Value & "',
                                '" & DgCotizaciones.Item(5, i).Value & "','" & DgCotizaciones.Item(6, i).Value & "','" & DgCotizaciones.Item(8, i).Value & "',
                                '" & DgCotizaciones.Item(7, i).Value & "'," & Val(DgCotizaciones.Item(10, i).Value) & "," & "0" & ")"
                                comando.CommandText = R
                                comando.ExecuteNonQuery()
                            Next i
                        End If '****************************DECISION ACERCA DE COT EDITAR O NUEVA

                        '============================================================================================================================================================================================
                        Try
                        If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            transaction.Commit()
                            MsgBox("La Cotización se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                'FrmCotizacion.DgAgregar.Rows.Clear()
                                respuestafolio = 0
                                NumCot = 0
                                FrmCotizacion2019.RbCotizacion.Checked = True
                                Me.Close()

                            Else
                                transaction.Rollback()
                                respuestafolio = 0
                                NumCot = 0
                                FrmCotizacion2019.RbCotizacion.Checked = True
                                Me.Close()
                            End If
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                        Try
                            transaction.Rollback()
                        Catch ex1 As Exception
                            MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                        End Try
                    End Try
                    conexion.Close()
                End Using
                Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
                End Try
            End If
        End If
    End Sub

    Private Sub TxtCorreoBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCorreoBuscar.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    MetodoInformacionGeneral()
                    comandogeneral = conexiongeneral.CreateCommand
                    R = "select distinct isnull(MetAsInf.Clavempresa,'-'), isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
                         isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
                         isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-')
                         from [Contactos-Clientes-Usuarios] inner join MetAsInf on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
                         where [Contactos-Clientes-Usuarios].Email ='" & TxtCorreoBuscar.Text & "'"
                    comandogeneral.CommandText = R
                    lectorgeneral = comandogeneral.ExecuteReader
                    lectorgeneral.Read()
                    TxtClaveE.Text = lectorgeneral(0)
                    TxtNombreEmpresa.Text = lectorgeneral(1)
                    TxtDomicilio.Text = lectorgeneral(2)
                    TxtCiudad.Text = lectorgeneral(3)
                    TxtEstado.Text = lectorgeneral(4)
                    TxtCveContacto.Text = lectorgeneral(5)
                    TxtNombreC.Text = lectorgeneral(6)
                    TxtTelefono.Text = lectorgeneral(7)
                    TxtExt.Text = lectorgeneral(8)
                    TxtCorreo.Text = lectorgeneral(9)
                    lectorgeneral.Close()
                    conexiongeneral.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "El correo que ingreso no existe")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al presionar enter y buscar el correo", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        For i As Integer = DgCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = DgCotizaciones.Rows(i).Cells(0).Value
            If delete = True Then
                Dim row As DataGridViewRow
                row = DgCotizaciones.Rows(i)
                DgCotizaciones.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmAgregarArticulos.ShowDialog()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim sw, sh As Integer
#End Region
End Class