Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class FrmCotizacion2019
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
        Application.Exit()
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

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DgEmpresas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEmpresas.CellDoubleClick
        MetodoMetasInf2019() ''MetasINF-2019
        clave1 = DgEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
        If DgCotizaciones.Rows.Count < 2 Then
        Else
            DgCotizaciones.Rows.Clear()
        End If
        comando2019 = conexion2019.CreateCommand
        R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, 
                EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot
                inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot]
                where EntradaRegistroCot.CveEmpresa=" & clave1
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read()
            DgCotizaciones.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4))
        End While
        lector2019.Close()
        conexion2019.Close()
    End Sub

    Dim sw, sh As Integer

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreE.TextChanged
        ConsultarEmpresas()
    End Sub

    Private Sub RbCotizacion_CheckedChanged(sender As Object, e As EventArgs) Handles RbCotizacion.CheckedChanged
        If (RbCotizacion.Checked) Then
            DgCotizaciones.Visible = True
            TxtMarca.Visible = True
            TxtModelo.Visible = True
            LbMarca.Visible = True
            LbModelo.Visible = True
            lbCot.Visible = True
        End If
    End Sub

    Private Sub RbArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles RbArticulo.CheckedChanged
        If (RbArticulo.Checked) Then
            DgCotizaciones.Visible = False
            TxtMarca.Visible = False
            TxtModelo.Visible = False
            LbMarca.Visible = False
            LbModelo.Visible = False
            lbCot.Visible = False
        End If
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
        ConsultarEmpresas()
    End Sub

    Private Sub TxtMarca_TextChanged(sender As Object, e As EventArgs) Handles TxtMarca.TextChanged
        ConsultarCotizaciones()
    End Sub

    Private Sub TxtModelo_TextChanged(sender As Object, e As EventArgs) Handles TxtModelo.TextChanged
        ConsultarCotizaciones()
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        ConsultarCotizaciones()
    End Sub

    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DgCotizaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCotizaciones.CellDoubleClick
        Try
            NumCot = DgCotizaciones.Rows(e.RowIndex).Cells(0).Value.ToString
            FrmEdicionCot2019_2020.TxtCotizacion.Text = NumCot
            FrmEdicionCot2019_2020.Show()
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al cargar los clientes", Err.Number, cadena)
        End Try

    End Sub

    Private Sub RbFolio_CheckedChanged(sender As Object, e As EventArgs) Handles RbFolio.CheckedChanged
        If RbFolio.Checked = True Then
            respuestafolio = InputBox("Folio", "Ingrese la confirmación metrológica:")
            FrmEdicionCot2019_2020.LbNumCon.Visible = False
            FrmEdicionCot2019_2020.TxtNumCon.Visible = False
            FrmEdicionCot2019_2020.LbtxtNumCon.Visible = True
            FrmEdicionCot2019_2020.TxtNumCond.Visible = True
            FrmEdicionCot2019_2020.LbCotizo2019.Enabled = False
            FrmEdicionCot2019_2020.TxtCotizo.Enabled = False
            FrmEdicionCot2019_2020.TxtObservaciones.Text = "*La cotización fué realizada en base a la información recibida. Cualquier diferencia entre su solicitud y esta cotización contactar a Ventas*"
            FrmEdicionCot2019_2020.Show()
        End If

    End Sub

    Private Sub RbNumCot_CheckedChanged(sender As Object, e As EventArgs) Handles RbNumCot.CheckedChanged
        If RbNumCot.Checked = True Then
            NumCot = InputBox("Cotización", "Ingrese el Número de Cotización:")
            FrmEdicionCot2019_2020.TxtCotizacion.Text = NumCot
            FrmEdicionCot2019_2020.Show()
        End If
    End Sub

    Private Sub FrmHOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        '============================================ BOTON QUE LLENA EL DATAGRID DE LOS CLIENTES ==========================================================
        Try
            MetodoInformacionGeneral()
            comandogeneral = conexiongeneral.CreateCommand
            R = "select Clavempresa, Compania, RFC, DomicilioConsig, EdoConsig FROM MetAsInf"
            comandogeneral.CommandText = R
            lectorgeneral = comandogeneral.ExecuteReader
            While lectorgeneral.Read()
                DgEmpresas.Rows.Add(lectorgeneral(0), lectorgeneral(1), lectorgeneral(2), lectorgeneral(3), lectorgeneral(4))
            End While
            lectorgeneral.Close()
            conexiongeneral.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al cargar los clientes", Err.Number, cadena)
        End Try
    End Sub
#End Region
    Sub ConsultarEmpresas()
        Try
            MetodoInformacionGeneral()
            DgEmpresas.Rows.Clear()
            DgCotizaciones.Rows.Clear()
            comandogeneral = conexiongeneral.CreateCommand
            R = "select Clavempresa, Compania, RFC, DomicilioConsig, EdoConsig FROM MetAsInf where Clavempresa like '" & TxtClave.Text & "%' and Compania like'" & TxtNombreE.Text & "%'"
            comandogeneral.CommandText = R
            lectorgeneral = comandogeneral.ExecuteReader
            While lectorgeneral.Read()
                DgEmpresas.Rows.Add(lectorgeneral(0), lectorgeneral(1), lectorgeneral(2), lectorgeneral(3), lectorgeneral(4))
            End While
            lectorgeneral.Close()
            conexiongeneral.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizadorLIMS", "Error al consultar los articulos", Err.Number, cadena)
        End Try
    End Sub
    Sub ConsultarCotizaciones()
        Try
            MetodoMetasInf2019()
            DgCotizaciones.Rows.Clear()
            comando2019 = conexion2019.CreateCommand
            R = "select EntradaRegistroCot.Numcot, EntradaRegistroCot.Cliente, EntradaRegistroCot.Fecha, EntradaRegistroCot.Referencia, [Claves-Elaboro-Cot].Nombre as [Elaboró] from EntradaRegistroCot 
                 inner join [Claves-Elaboro-Cot] on [Claves-Elaboro-Cot].[Clave-elaboro-cot] = EntradaRegistroCot.[Elaboró Cot] inner join [1Cotizar] on EntradaRegistroCot.NumCot=[1Cotizar].NumCot where 
                 EntradaRegistroCot.CveEmpresa=" & clave1 & " and [1Cotizar].Marca like '" & TxtMarca.Text & "%' and [1Cotizar].Modelo like '" & TxtModelo.Text & "%' and [1Cotizar].ID like '" & TxtID.Text & "%'"
            'MsgBox(R)
            comando2019.CommandText = R
            lector2019 = comando2019.ExecuteReader
            While lector2019.Read()
                DgCotizaciones.Rows.Add(lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4))
            End While
            lector2019.Close()
            conexion2019.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizadorLIMS", "Error al consultar los articulos", Err.Number, cadena)
        End Try
    End Sub
End Class