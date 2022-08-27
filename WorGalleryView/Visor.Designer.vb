<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visor))
        Me.MenuPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerListaDeArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDeLaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoConsentradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarBarraDeHerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEnElEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarEazyCAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarLaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GalleryViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCarpetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LimpiarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.IniciarEazyCAMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivarModoConsentradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComenzarDiapositivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EazyCAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListaDeArchivosToolStripMenuItem, Me.LimpiarListaToolStripMenuItem1, Me.EliminarToolStripMenuItem, Me.EliminarDeLaListaToolStripMenuItem, Me.ModoConsentradoToolStripMenuItem, Me.OcultarBarraDeHerramientasToolStripMenuItem, Me.VerEnElEditorToolStripMenuItem, Me.IniciarEazyCAMToolStripMenuItem, Me.GuardarLaListaToolStripMenuItem, Me.ToolStripMenuItem3, Me.OpcionesToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(234, 252)
        Me.MenuPrincipal.Text = "Menu"
        '
        'VerListaDeArchivosToolStripMenuItem
        '
        Me.VerListaDeArchivosToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.images
        Me.VerListaDeArchivosToolStripMenuItem.Name = "VerListaDeArchivosToolStripMenuItem"
        Me.VerListaDeArchivosToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.VerListaDeArchivosToolStripMenuItem.Text = "Ver Lista de Archivos"
        '
        'LimpiarListaToolStripMenuItem1
        '
        Me.LimpiarListaToolStripMenuItem1.Image = Global.WorGalleryView.My.Resources.Resources.New_32
        Me.LimpiarListaToolStripMenuItem1.Name = "LimpiarListaToolStripMenuItem1"
        Me.LimpiarListaToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.LimpiarListaToolStripMenuItem1.Text = "Limpiar Lista"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.EliminarToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Button_Close_icon
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar Archivo"
        '
        'EliminarDeLaListaToolStripMenuItem
        '
        Me.EliminarDeLaListaToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Button_Close_icon
        Me.EliminarDeLaListaToolStripMenuItem.Name = "EliminarDeLaListaToolStripMenuItem"
        Me.EliminarDeLaListaToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.EliminarDeLaListaToolStripMenuItem.Text = "Eliminar de la Lista"
        '
        'ModoConsentradoToolStripMenuItem
        '
        Me.ModoConsentradoToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.images
        Me.ModoConsentradoToolStripMenuItem.Name = "ModoConsentradoToolStripMenuItem"
        Me.ModoConsentradoToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        '
        'OcultarBarraDeHerramientasToolStripMenuItem
        '
        Me.OcultarBarraDeHerramientasToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.images
        Me.OcultarBarraDeHerramientasToolStripMenuItem.Name = "OcultarBarraDeHerramientasToolStripMenuItem"
        Me.OcultarBarraDeHerramientasToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OcultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar Barra de Herramientas"
        '
        'VerEnElEditorToolStripMenuItem
        '
        Me.VerEnElEditorToolStripMenuItem.Name = "VerEnElEditorToolStripMenuItem"
        Me.VerEnElEditorToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.VerEnElEditorToolStripMenuItem.Text = "Ver en el Editor"
        '
        'IniciarEazyCAMToolStripMenuItem
        '
        Me.IniciarEazyCAMToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.IniciarEazyCAMToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.WebCam_Logo
        Me.IniciarEazyCAMToolStripMenuItem.Name = "IniciarEazyCAMToolStripMenuItem"
        Me.IniciarEazyCAMToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.IniciarEazyCAMToolStripMenuItem.Text = "Iniciar EazyCAM"
        Me.IniciarEazyCAMToolStripMenuItem.ToolTipText = "Esta Opcion sige en Desarrollo"
        '
        'GuardarLaListaToolStripMenuItem
        '
        Me.GuardarLaListaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.CargarToolStripMenuItem})
        Me.GuardarLaListaToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.New_32
        Me.GuardarLaListaToolStripMenuItem.Name = "GuardarLaListaToolStripMenuItem"
        Me.GuardarLaListaToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.GuardarLaListaToolStripMenuItem.Text = "Lista"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Save_32
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Folder_48
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(230, 6)
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Ajustes_Logo
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.WorGalleryView.My.Resources.Resources.Button_Close_icon
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "WorCODE"
        Me.SaveFileDialog1.Filter = "WorCode|*.WorCODE"
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        Me.SaveFileDialog1.Title = "Guardar Archivo..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "WorCODE"
        Me.OpenFileDialog1.Filter = "WorCode|*.WorCODE"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Abrir Archivo..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.BarraArriba
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.ContextMenuStrip = Me.MenuPrincipal
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 556)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 56)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(865, -1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Reset Zoom"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.LupaMENOS
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(901, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.LupaMAS
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(865, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.Adelante
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(468, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.Atras
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(417, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.BackgroundImage = Global.WorGalleryView.My.Resources.Resources.Barra
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GalleryViewToolStripMenuItem, Me.EazyCAMToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GalleryViewToolStripMenuItem
        '
        Me.GalleryViewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.GalleryViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GalleryViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirArchivoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ToolStripMenuItem5, Me.IniciarEazyCAMToolStripMenuItem1, Me.ActivarModoConsentradoToolStripMenuItem, Me.ComenzarDiapositivasToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.GalleryViewToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GalleryViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GalleryViewToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Diapositiva
        Me.GalleryViewToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GalleryViewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GalleryViewToolStripMenuItem.Name = "GalleryViewToolStripMenuItem"
        Me.GalleryViewToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.GalleryViewToolStripMenuItem.Text = "GalleryView"
        '
        'AbrirArchivoToolStripMenuItem
        '
        Me.AbrirArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCarpetaToolStripMenuItem, Me.SeleccionarArchivosToolStripMenuItem, Me.ToolStripMenuItem2, Me.LimpiarListaToolStripMenuItem, Me.VerListaToolStripMenuItem, Me.ToolStripMenuItem4, Me.PlaylistToolStripMenuItem})
        Me.AbrirArchivoToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.New_32
        Me.AbrirArchivoToolStripMenuItem.Name = "AbrirArchivoToolStripMenuItem"
        Me.AbrirArchivoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AbrirArchivoToolStripMenuItem.Text = "Lista"
        '
        'AgregarCarpetaToolStripMenuItem
        '
        Me.AgregarCarpetaToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Folder_48
        Me.AgregarCarpetaToolStripMenuItem.Name = "AgregarCarpetaToolStripMenuItem"
        Me.AgregarCarpetaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AgregarCarpetaToolStripMenuItem.Text = "Agregar Carpeta"
        '
        'SeleccionarArchivosToolStripMenuItem
        '
        Me.SeleccionarArchivosToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.New_32
        Me.SeleccionarArchivosToolStripMenuItem.Name = "SeleccionarArchivosToolStripMenuItem"
        Me.SeleccionarArchivosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SeleccionarArchivosToolStripMenuItem.Text = "Seleccionar Archivos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 6)
        '
        'LimpiarListaToolStripMenuItem
        '
        Me.LimpiarListaToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Button_Close_icon
        Me.LimpiarListaToolStripMenuItem.Name = "LimpiarListaToolStripMenuItem"
        Me.LimpiarListaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.LimpiarListaToolStripMenuItem.Text = "Limpiar Lista"
        '
        'VerListaToolStripMenuItem
        '
        Me.VerListaToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.images
        Me.VerListaToolStripMenuItem.Name = "VerListaToolStripMenuItem"
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VerListaToolStripMenuItem.Text = "Ver Lista"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 6)
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem1, Me.GuardarToolStripMenuItem1})
        Me.PlaylistToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.New_32
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'CargarToolStripMenuItem1
        '
        Me.CargarToolStripMenuItem1.Image = Global.WorGalleryView.My.Resources.Resources.Folder_48
        Me.CargarToolStripMenuItem1.Name = "CargarToolStripMenuItem1"
        Me.CargarToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.CargarToolStripMenuItem1.Text = "Cargar"
        '
        'GuardarToolStripMenuItem1
        '
        Me.GuardarToolStripMenuItem1.Image = Global.WorGalleryView.My.Resources.Resources.Save_32
        Me.GuardarToolStripMenuItem1.Name = "GuardarToolStripMenuItem1"
        Me.GuardarToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.GuardarToolStripMenuItem1.Text = "Guardar"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Folder_48
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(216, 6)
        '
        'IniciarEazyCAMToolStripMenuItem1
        '
        Me.IniciarEazyCAMToolStripMenuItem1.Image = Global.WorGalleryView.My.Resources.Resources.WebCam_Logo
        Me.IniciarEazyCAMToolStripMenuItem1.Name = "IniciarEazyCAMToolStripMenuItem1"
        Me.IniciarEazyCAMToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.IniciarEazyCAMToolStripMenuItem1.Text = "Iniciar EazyCAM"
        '
        'ActivarModoConsentradoToolStripMenuItem
        '
        Me.ActivarModoConsentradoToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.images
        Me.ActivarModoConsentradoToolStripMenuItem.Name = "ActivarModoConsentradoToolStripMenuItem"
        Me.ActivarModoConsentradoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        '
        'ComenzarDiapositivasToolStripMenuItem
        '
        Me.ComenzarDiapositivasToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Diapositiva
        Me.ComenzarDiapositivasToolStripMenuItem.Name = "ComenzarDiapositivasToolStripMenuItem"
        Me.ComenzarDiapositivasToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Ajustes_Logo
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Ball_info_32
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.Button_Close_icon
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EazyCAMToolStripMenuItem
        '
        Me.EazyCAMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturarToolStripMenuItem})
        Me.EazyCAMToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EazyCAMToolStripMenuItem.Name = "EazyCAMToolStripMenuItem"
        Me.EazyCAMToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.EazyCAMToolStripMenuItem.Text = "EazyCAM"
        Me.EazyCAMToolStripMenuItem.Visible = False
        '
        'CapturarToolStripMenuItem
        '
        Me.CapturarToolStripMenuItem.Image = Global.WorGalleryView.My.Resources.Resources.WebCam_Logo
        Me.CapturarToolStripMenuItem.Name = "CapturarToolStripMenuItem"
        Me.CapturarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CapturarToolStripMenuItem.Text = "Capturar"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Visualisador de Imagenes"
        Me.NotifyIcon1.BalloonTipTitle = "GalleryView"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Wor: GalleryView"
        Me.NotifyIcon1.Visible = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 526)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(931, 526)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(934, 612)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(135, 95)
        Me.Name = "Visor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wor: GalleryView"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GalleryViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarCarpetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LimpiarListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPrincipal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarDeLaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerListaDeArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarListaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerEnElEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GuardarLaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoConsentradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarEazyCAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EazyCAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IniciarEazyCAMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivarModoConsentradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComenzarDiapositivasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarBarraDeHerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
