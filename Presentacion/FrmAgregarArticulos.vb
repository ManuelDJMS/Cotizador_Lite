Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FrmAgregarArticulos
    Private Sub FrmAgregarArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasInf2019()
        comando2019 = conexion2019.CreateCommand
        Dim R As String
        R = "select PartidaNo, ServCatalogo, Cant, Tipo, Marca, Modelo, ID, Alcance, Punitariocot from [1Cotizar] inner join EntradaRegistroCot on [1Cotizar].Numcot=EntradaRegistroCot.Numcot"
        comando2019.CommandText = R
        lector2019 = comando2019.ExecuteReader
        While lector2019.Read()
            DGCotizaciones.Rows.Add(False, lector2019(0), lector2019(1), lector2019(2), lector2019(3), lector2019(4), lector2019(5), lector2019(6), lector2019(7), lector2019(8))
        End While
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim seleccionado As Boolean
            seleccionado = DGCotizaciones.Rows(i).Cells(0).Value
            If seleccionado = True Then
                Form1.DGCotizaciones1.Rows.Add(DGCotizaciones.Rows(i).Cells(1).Value, DGCotizaciones.Rows(i).Cells(2).Value, DGCotizaciones.Rows(i).Cells(3).Value, DGCotizaciones.Rows(i).Cells(4).Value, DGCotizaciones.Rows(i).Cells(5).Value, DGCotizaciones.Rows(i).Cells(6).Value, DGCotizaciones.Rows(i).Cells(7).Value, DGCotizaciones.Rows(i).Cells(8).Value, DGCotizaciones.Rows(i).Cells(9).Value)
            End If
        Next
    End Sub
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
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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
End Class