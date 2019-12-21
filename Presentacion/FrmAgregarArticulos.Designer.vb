<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.ckSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.partida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New Guna.UI.WinForms.GunaButton()
        Me.PanelBarraTitulo = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.BtnRestaurar = New Guna.UI.WinForms.GunaImageButton()
        Me.BtnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.LbLogin = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.BtnMaximizar = New Guna.UI.WinForms.GunaImageButton()
        Me.BtnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(7, 112)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1081, 10)
        Me.GunaSeparator1.TabIndex = 171
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(82, 93)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(213, 18)
        Me.Label26.TabIndex = 170
        Me.Label26.Text = "Exportar Cotizaciones 2019 a 2020"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.ForestGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(79, 61)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(282, 32)
        Me.GunaLabel2.TabIndex = 168
        Me.GunaLabel2.Text = "Cotización por Artículo"
        '
        'DGCotizaciones
        '
        Me.DGCotizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCotizaciones.BackgroundColor = System.Drawing.Color.White
        Me.DGCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ckSeleccionar, Me.partida, Me.codigoServicio, Me.cantidad, Me.equipoDescripcion, Me.marca, Me.modelo, Me.id, Me.intervalo, Me.precioUnitario, Me.precioTotal})
        Me.DGCotizaciones.EnableHeadersVisualStyles = False
        Me.DGCotizaciones.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGCotizaciones.Location = New System.Drawing.Point(7, 122)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGCotizaciones.RowHeadersVisible = False
        Me.DGCotizaciones.Size = New System.Drawing.Size(1081, 270)
        Me.DGCotizaciones.TabIndex = 306
        '
        'ckSeleccionar
        '
        Me.ckSeleccionar.HeaderText = "Seleccionar"
        Me.ckSeleccionar.Name = "ckSeleccionar"
        Me.ckSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ckSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'partida
        '
        Me.partida.HeaderText = "Partida"
        Me.partida.Name = "partida"
        Me.partida.Visible = False
        '
        'codigoServicio
        '
        Me.codigoServicio.HeaderText = "Código Servicio"
        Me.codigoServicio.Name = "codigoServicio"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Visible = False
        '
        'equipoDescripcion
        '
        Me.equipoDescripcion.HeaderText = "Equipo/Descripción"
        Me.equipoDescripcion.Name = "equipoDescripcion"
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'intervalo
        '
        Me.intervalo.HeaderText = "Intervalo"
        Me.intervalo.Name = "intervalo"
        '
        'precioUnitario
        '
        Me.precioUnitario.HeaderText = "Precio 2019"
        Me.precioUnitario.Name = "precioUnitario"
        '
        'precioTotal
        '
        Me.precioTotal.HeaderText = "Precio 2019"
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.AnimationHoverSpeed = 0.07!
        Me.btnAgregar.AnimationSpeed = 0.03!
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.BorderColor = System.Drawing.Color.Black
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_add_48
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(85, 398)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAgregar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAgregar.OnHoverImage = Nothing
        Me.btnAgregar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAgregar.Radius = 3
        Me.btnAgregar.Size = New System.Drawing.Size(162, 28)
        Me.btnAgregar.TabIndex = 307
        Me.btnAgregar.Text = "Agregar a Cotización"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.White
        Me.PanelBarraTitulo.Controls.Add(Me.GunaPictureBox2)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaVSeparator2)
        Me.PanelBarraTitulo.Controls.Add(Me.LbLogin)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaPictureBox1)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaVSeparator1)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaImageButton4)
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(7, 12)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1084, 50)
        Me.PanelBarraTitulo.TabIndex = 308
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Cotizador_Lite.My.Resources.Resources.papel
        Me.GunaPictureBox2.Location = New System.Drawing.Point(12, 8)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 9
        Me.GunaPictureBox2.TabStop = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnRestaurar.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_enlarge_48
        Me.BtnRestaurar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnRestaurar.Location = New System.Drawing.Point(1007, 8)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.OnHoverImage = Nothing
        Me.BtnRestaurar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnRestaurar.Size = New System.Drawing.Size(32, 32)
        Me.BtnRestaurar.TabIndex = 8
        Me.BtnRestaurar.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCerrar.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_multiply_48
        Me.BtnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnCerrar.Location = New System.Drawing.Point(1045, 8)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.OnHoverImage = Nothing
        Me.BtnCerrar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.BtnCerrar.TabIndex = 7
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator2.Location = New System.Drawing.Point(723, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'LbLogin
        '
        Me.LbLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLogin.AutoSize = True
        Me.LbLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLogin.Location = New System.Drawing.Point(796, 17)
        Me.LbLogin.Name = "LbLogin"
        Me.LbLogin.Size = New System.Drawing.Size(65, 20)
        Me.LbLogin.TabIndex = 5
        Me.LbLogin.Text = "Manuel"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_verified_account_28
        Me.GunaPictureBox1.Location = New System.Drawing.Point(749, 8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator1.Location = New System.Drawing.Point(959, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMaximizar.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_full_screen_32
        Me.BtnMaximizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnMaximizar.Location = New System.Drawing.Point(1007, 8)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.OnHoverImage = Nothing
        Me.BtnMaximizar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnMaximizar.Size = New System.Drawing.Size(32, 32)
        Me.BtnMaximizar.TabIndex = 2
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMinimizar.Image = Global.Cotizador_Lite.My.Resources.Resources.icons8_horizontal_line_48
        Me.BtnMinimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnMinimizar.Location = New System.Drawing.Point(969, 8)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.OnHoverImage = Nothing
        Me.BtnMinimizar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.BtnMinimizar.TabIndex = 1
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Image = Nothing
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton4.Location = New System.Drawing.Point(8, 8)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.GunaImageButton4.Size = New System.Drawing.Size(32, 32)
        Me.GunaImageButton4.TabIndex = 0
        '
        'FrmAgregarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1094, 441)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DGCotizaciones)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgregarArticulos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents btnAgregar As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelBarraTitulo As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BtnRestaurar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents BtnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents LbLogin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents BtnMaximizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents BtnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton4 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents ckSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents partida As DataGridViewTextBoxColumn
    Friend WithEvents codigoServicio As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents equipoDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents intervalo As DataGridViewTextBoxColumn
    Friend WithEvents precioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As DataGridViewTextBoxColumn
End Class
