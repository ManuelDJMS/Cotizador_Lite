<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdicionCot2019_2020
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEdicionCot2019_2020))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.TxtModelo = New Guna.UI.WinForms.GunaTextBox()
        Me.LbId = New Guna.UI.WinForms.GunaLabel()
        Me.LbModelo = New Guna.UI.WinForms.GunaLabel()
        Me.LbMarca = New Guna.UI.WinForms.GunaLabel()
        Me.TxtCliente = New Guna.UI.WinForms.GunaTextBox()
        Me.TxtID = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
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
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1160, 675)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Controls.Add(Me.GunaElipsePanel2)
        Me.PanelFormularios.Controls.Add(Me.GunaSeparator1)
        Me.PanelFormularios.Controls.Add(Me.Label26)
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Controls.Add(Me.GunaLabel2)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(0, 50)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1160, 625)
        Me.PanelFormularios.TabIndex = 6
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.GunaTextBox2)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaTextBox1)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel2.Controls.Add(Me.TxtModelo)
        Me.GunaElipsePanel2.Controls.Add(Me.LbId)
        Me.GunaElipsePanel2.Controls.Add(Me.LbModelo)
        Me.GunaElipsePanel2.Controls.Add(Me.LbMarca)
        Me.GunaElipsePanel2.Controls.Add(Me.TxtCliente)
        Me.GunaElipsePanel2.Controls.Add(Me.TxtID)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(12, 70)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(1141, 82)
        Me.GunaElipsePanel2.TabIndex = 287
        '
        'TxtModelo
        '
        Me.TxtModelo.BaseColor = System.Drawing.Color.White
        Me.TxtModelo.BorderColor = System.Drawing.Color.Silver
        Me.TxtModelo.BorderSize = 1
        Me.TxtModelo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtModelo.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtModelo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TxtModelo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtModelo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtModelo.Location = New System.Drawing.Point(320, 11)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtModelo.Size = New System.Drawing.Size(155, 26)
        Me.TxtModelo.TabIndex = 179
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbId.Location = New System.Drawing.Point(6, 49)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(75, 20)
        Me.LbId.TabIndex = 170
        Me.LbId.Text = "Empresa:"
        '
        'LbModelo
        '
        Me.LbModelo.AutoSize = True
        Me.LbModelo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbModelo.Location = New System.Drawing.Point(147, 11)
        Me.LbModelo.Name = "LbModelo"
        Me.LbModelo.Size = New System.Drawing.Size(167, 20)
        Me.LbModelo.TabIndex = 171
        Me.LbModelo.Text = "Correo del Contacto:"
        '
        'LbMarca
        '
        Me.LbMarca.AutoSize = True
        Me.LbMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarca.Location = New System.Drawing.Point(6, 11)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.Size = New System.Drawing.Size(65, 20)
        Me.LbMarca.TabIndex = 172
        Me.LbMarca.Text = "Cliente:"
        '
        'TxtCliente
        '
        Me.TxtCliente.BaseColor = System.Drawing.Color.White
        Me.TxtCliente.BorderColor = System.Drawing.Color.Silver
        Me.TxtCliente.BorderSize = 1
        Me.TxtCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCliente.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TxtCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCliente.Location = New System.Drawing.Point(77, 11)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCliente.Size = New System.Drawing.Size(64, 26)
        Me.TxtCliente.TabIndex = 178
        '
        'TxtID
        '
        Me.TxtID.BaseColor = System.Drawing.Color.White
        Me.TxtID.BorderColor = System.Drawing.Color.Silver
        Me.TxtID.BorderSize = 1
        Me.TxtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtID.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TxtID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtID.Location = New System.Drawing.Point(87, 49)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtID.Size = New System.Drawing.Size(388, 26)
        Me.TxtID.TabIndex = 180
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(7, 54)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(1140, 10)
        Me.GunaSeparator1.TabIndex = 171
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(86, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(213, 18)
        Me.Label26.TabIndex = 170
        Me.Label26.Text = "Exportar Cotizaciones 2019 a 2020"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 3)
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
        Me.GunaLabel2.Location = New System.Drawing.Point(83, 3)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(404, 32)
        Me.GunaLabel2.TabIndex = 168
        Me.GunaLabel2.Text = "Edición de Cotización MetAs 2019"
        '
        'PanelBarraTitulo
        '
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
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1160, 50)
        Me.PanelBarraTitulo.TabIndex = 5
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
        Me.BtnRestaurar.Location = New System.Drawing.Point(1083, 8)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(1121, 8)
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
        Me.GunaVSeparator2.Location = New System.Drawing.Point(799, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'LbLogin
        '
        Me.LbLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbLogin.AutoSize = True
        Me.LbLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLogin.Location = New System.Drawing.Point(872, 17)
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
        Me.GunaPictureBox1.Location = New System.Drawing.Point(825, 8)
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
        Me.GunaVSeparator1.Location = New System.Drawing.Point(1035, 12)
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
        Me.BtnMaximizar.Location = New System.Drawing.Point(1083, 8)
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
        Me.BtnMinimizar.Location = New System.Drawing.Point(1045, 8)
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
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(588, 34)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(123, 26)
        Me.GunaTextBox1.TabIndex = 182
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(584, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(127, 20)
        Me.GunaLabel1.TabIndex = 181
        Me.GunaLabel1.Text = "Cotización 2019:"
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.Location = New System.Drawing.Point(787, 34)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Size = New System.Drawing.Size(123, 26)
        Me.GunaTextBox2.TabIndex = 184
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(783, 11)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(127, 20)
        Me.GunaLabel3.TabIndex = 183
        Me.GunaLabel3.Text = "Cotización 2020:"
        '
        'FrmEdicionCot2019_2020
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1160, 675)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1160, 675)
        Me.Name = "FrmEdicionCot2019_2020"
        Me.Text = "FrmEdicionCot2019_2020"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
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
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents TxtModelo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LbId As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LbModelo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LbMarca As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtCliente As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TxtID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
