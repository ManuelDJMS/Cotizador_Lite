Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class FrmCotizacionPorArticulo
    Dim banm, banb As Boolean
    Dim bandera As Boolean
    Dim dt2 As New DataTable
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
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
        Me.PanelFormularios.Region = region
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


    Dim sw, sh As Integer
#End Region
    Private Sub FrmCotizacionPorArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasInf2019()
        ' Try
        comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select top 1 MetAsInf.Clavempresa, isnull(MetAsInf.Compania,'-'), isnull(MetAsInf.DomicilioConsig,'-'), isnull(MetAsInf.CiudadConsig,'-'), isnull(MetAsInf.EdoConsig,'-'),
            isnull([Contactos-Clientes-Usuarios].ClaveContacto,'-'), isnull([Contactos-Clientes-Usuarios].Nombre,'-'), isnull([Contactos-Clientes-Usuarios].Tel,'-'),
            isnull([Contactos-Clientes-Usuarios].Ext,'-'), isnull([Contactos-Clientes-Usuarios].Email,'-'),isnull(EntradaRegistroCot.Numcond,'1'),
            isnull(EntradaRegistroCot.Referencia,'-'), isnull(EntradaRegistroCot.ServicioEn,'-'), isnull([Claves-Elaboro-Cot].Nombre,'-'), isnull(EntradaRegistroCot.Observaciones,'-') 
            From [InformacionGeneral].[dbo].[MetAsInf] inner Join [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] On MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
            inner Join EntradaRegistroCot on [Contactos-Clientes-Usuarios].ClaveContacto = EntradaRegistroCot.ClaveContacto 
            inner join Condiciones_p_cotizar on EntradaRegistroCot.[Elaboró Cot] = Condiciones_p_cotizar.Numcond 
            inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot]= EntradaRegistroCot.[Elaboró Cot]
            where [InformacionGeneral].[dbo].[MetAsInf].Clavempresa = 424 order by EntradaRegistroCot.Numcot desc"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            lector2019.Read()
            txtClaveE.Text = lector2019(0)
            txtNombreEmpresa.Text = lector2019(1)
            lblDomicilio.Text = lector2019(1)
            lblCiudad.Text = lector2019(3)
            lblEstado.Text = lector2019(4)
            lblClave.Text = lector2019(5)
            lblContacto.Text = lector2019(6)
            lblTelefono.Text = lector2019(7)
            lblExt.Text = lector2019(8)
            lblCorreo.Text = lector2019(9)
            lblNumCond.Text = lector2019(10)
            txtReferencia.Text = lector2019(11)
            cboServicio.Text = lector2019(12)
            txtCotizo.Text = lector2019(13)
            txtObservaciones.Text = lector2019(14)
            lector2019.Close()
            ''------------------------------------
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                DGCotizaciones.Rows.Add(False, lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8))
            End While
            lector2019.Close()
            lbPartidas.Text = "Total de Partidas: " + Convert.ToString(DGCotizaciones.Rows.Count - 1)
        'clase.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
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

    Private Sub TxtModelo_TextChanged(sender As Object, e As EventArgs)
        Try
            DGCotizaciones.Rows.Clear()
            MetodoMetasInf2019()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa & "and Modelo like '" & TxtModelo.Text & "%'"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                DGCotizaciones.Rows.Add(False, lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8))
            End While
            lector2019.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")

        End Try
        da.Dispose()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCorreo.KeyDown
        'Try
        Select Case e.KeyData
                Case Keys.Enter
                    'Dim clase As New SqlConnection(conexionprueba)
                    'clase.Open()
                    MetodoMetasInf2019()
                    comando2019 = conexion2019.CreateCommand
                    Dim R As String
                    R = "select distinct MetAsInf.Clavempresa, MetAsInf.Compania, MetAsInf.DomicilioConsig, MetAsInf.CiudadConsig, MetAsInf.EdoConsig,
                     [Contactos-Clientes-Usuarios].ClaveContacto, [Contactos-Clientes-Usuarios].Nombre, [Contactos-Clientes-Usuarios].Tel,
                     [Contactos-Clientes-Usuarios].Ext, [Contactos-Clientes-Usuarios].Email
                     from [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] inner join [InformacionGeneral].[dbo].[MetAsInf] on MetAsInf.Clavempresa = [Contactos-Clientes-Usuarios].Clavempresa
                     where [Contactos-Clientes-Usuarios].Email ='" & txtCorreo.Text & "'"
                    comando2019.CommandText = R
                    lector2019 = comando2019.ExecuteReader
                    lector2019.Read()
                    txtClaveE.Text = lector2019(0)
                    txtNombreEmpresa.Text = lector2019(1)
                    lblDomicilio.Text = lector2019(2)
                    lblCiudad.Text = lector2019(3)
                    lblEstado.Text = lector2019(4)
                    lblClave.Text = lector2019(5)
                    lblContacto.Text = lector2019(6)
                    lblTelefono.Text = lector2019(7)
                    lblExt.Text = lector2019(8)
                    lblCorreo.Text = lector2019(9)
                    lector2019.Close()

            End Select
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
    End Sub

    Private Sub TxtMarca_TextChanged(sender As Object, e As EventArgs) Handles TxtMarca.TextChanged

        Try
            DGCotizaciones.Rows.Clear()
            MetodoMetasInf2019()
            If DGCotizaciones.Rows.Count < 2 Then
            Else
                DGCotizaciones.Rows.RemoveAt(DGCotizaciones.CurrentRow.Index)
            End If
            comando2019 = conexion2019.CreateCommand
            Dim R As String
            R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot where CveEmpresa =" & empresa & "and Marca like '" & TxtMarca.Text & "%'"
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                DGCotizaciones.Rows.Add(False, lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8))
            End While
            lector2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
        da.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim seleccionado As Boolean
            seleccionado = DGCotizaciones.Rows(i).Cells(0).Value
            If seleccionado = True Then
                DGCarrito.Rows.Add(DGCotizaciones.Rows(i).Cells(1).Value, DGCotizaciones.Rows(i).Cells(2).Value, DGCotizaciones.Rows(i).Cells(3).Value, DGCotizaciones.Rows(i).Cells(4).Value, DGCotizaciones.Rows(i).Cells(5).Value, DGCotizaciones.Rows(i).Cells(6).Value, DGCotizaciones.Rows(i).Cells(7).Value, DGCotizaciones.Rows(i).Cells(8).Value, DGCotizaciones.Rows(i).Cells(9).Value)
            End If
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        MetodoMetasInf2019()
        'fechaActual = DTPDesde.Value.Date.Year & "-" & DTPDesde.Value.Date.Day & "-" & DTPDesde.Value.Date.Month
        Dim maximo As Integer
        Dim R As String

        ''Aqui va el insert de entrada Registro cot
        If txtCotizacion19.Text.Trim.Equals("") Then
            ''Es nueva cotizacion hasta el ultimo registro (select(MAX))
            Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            maximo = lector(0)
            ' MsgBox("Ultimo registro: " & maximo + 1)
            lector.Close()
            R = "insert into EntradaRegistroCot (NumCot, Cliente, ClaveContacto, Fecha, Referencia, Numcond, Observaciones, ServicioEn, TipodeCliente, 
                CveEmpresa, [Elaboró Cot], ModoDeContabilizar) values (" & maximo + 1 & ",'" & txtNombreEmpresa.Text & "',
                " & Val(lblClave.Text) & ", (CONVERT(varchar(10), getdate(), 103)),'" & txtReferencia.Text & "'," & Val(lblNumCond.Text) & ",
                '" & txtObservaciones.Text & "','" & cboServicio.Text & "'," & Val(txtTipoCliente.Text) & "," & Val(txtClaveE.Text) & ",
                " & Val(txtCotizo2019.Text) & "," & txtConta.Text & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            'MsgBox("")
            ''Finalizo insert de EntradaRegistroCot

            'Codigo para guardar en 1Cotizar----------------------------------------------------
            For i = 0 To DGCarrito.Rows.Count - 2
                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & maximo + 1 & "," & Val(i + 1) & ",'" & DGCarrito.Item(1, i).Value & "',
                    '" & "-" & "'," & Val(DGCarrito.Item(2, i).Value) & ",'" & DGCarrito.Item(3, i).Value & "',
                    '" & DGCarrito.Item(4, i).Value & "','" & DGCarrito.Item(5, i).Value & "','" & DGCarrito.Item(7, i).Value & "',
                    '" & DGCarrito.Item(6, i).Value & "'," & Val(DGCarrito.Item(9, i).Value) & "," & "0" & ")"
                ''MsgBox(R)
                comando.CommandText = R
                comando.ExecuteNonQuery()
            Next i
            MsgBox("Guardado en 2019 correctamente.", MsgBoxStyle.Information)
            'lector2019.Close()
        Else
            Dim comando As New SqlCommand("select MAX(Numcot) from EntradaRegistroCot", conexion2019)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            lector.Close()

            ''Se hace update a una cot apartada, ya existente (UPDATE)
            R = "update EntradaRegistroCot set NumCot='" & Val(txtCotizacion19.Text) & "', Cliente = '" & txtNombreEmpresa.Text & "', 
                ClaveContacto='" & Val(lblClave.Text) & "', Fecha= (CONVERT(varchar(10), getdate(), 103)), Referencia='" & txtReferencia.Text & "', 
                Numcond='" & Val(lblNumCond.Text) & "', Observaciones='" & txtObservaciones.Text & "', ServicioEn='" & cboServicio.Text & "', 
                TipodeCliente='1', CveEmpresa='" & Val(txtClaveE.Text) & "', [Elaboró Cot]=" & Val(txtCotizo2019.Text) & ", 
                ModoDeContabilizar='" & Val(txtConta.Text) & "' WHERE NumCot='" & Val(txtCotizacion19.Text) & "'"
            comando.CommandText = R
            comando.ExecuteNonQuery()
            ' MsgBox("Cotizacion Actualizada")

            For i = 0 To DGCarrito.Rows.Count - 2
                R = "insert into [1Cotizar] (Numcot, PartidaNo, ServCatalogo, Especial, Cant, Tipo, Marca, Modelo, Alcance, 
                     ID, Punitariocot, Realizado) values (" & Val(txtCotizacion19.Text) & "," & Val(i + 1) & ",'" & DGCarrito.Item(1, i).Value & "',
                    '" & "-" & "'," & Val(DGCarrito.Item(2, i).Value) & ",'" & DGCarrito.Item(3, i).Value & "',
                    '" & DGCarrito.Item(4, i).Value & "','" & DGCarrito.Item(5, i).Value & "','" & DGCarrito.Item(7, i).Value & "','
                    " & DGCarrito.Item(6, i).Value & "'," & Val(DGCarrito.Item(9, i).Value) & "," & "0" & ")"
                comando.CommandText = R
                comando.ExecuteNonQuery()
                'MsgBox("Partida " & i + 1 & "insertada")
            Next i
            MsgBox("Cotización actualizada y nuevas partidas agregadas, verifica registros en ACCESS", MsgBoxStyle.Information)
            conexion2019.Close()
        End If
        FrmCotizacion2019.TxtClave.Text = ""
        FrmCotizacion2019.TxtNombreE.Text = ""
        FrmCotizacion2019.DgCotizaciones.DataSource = Nothing
        FrmCotizacion2019.DgEmpresas.DataSource = Nothing
        ' FrmCotizacion2019.DGCarrit.DataSource = Nothing
        Me.Dispose()
    End Sub
End Class