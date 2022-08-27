Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class Visor
    Public BM1 As Bitmap 'GUARDA LA IMAGEN INICIAL
    Dim MIX As Integer 'GUARDA LA POSICION INICIAL EN X DEL MOUSE
    Dim MIY As Integer 'GUARDA LA POSICION INICIAL EN Y DEL MOUSE
    Dim MUEVE As Boolean 'CONTROLA EL MOVIMIENTO DEL MOUSE
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Visor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        'Panel1.AutoScroll = True
        Try
            If My.Settings.OfflineMode = False Then
                AppService.StartAppService(False, False, True, False, True)
                Threading.Thread.Sleep(150)
            End If
        Catch ex As Exception
            MsgBox("ERROR CRITICO CON 'AppService'", MsgBoxStyle.Critical, "Worcome Security")
        End Try
        Try
            If Len(Command$) Then
                Dim PATH As String = Command$()
                PATH = PATH.Replace("""", "")
                If PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "png" Or PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "jpg" Or PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "gif" Or PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "bmp" Then
                    'BM1 = Bitmap.FromFile(PATH)
                    'PictureBox1.Image = BM1
                    ListadeArchivos.MemoryList.Add(PATH)
                    PATH = PATH.Remove(0, PATH.LastIndexOf("\") + 1)
                    ListadeArchivos.ListBox1.Items.Add(PATH)
                    PictureBox1.ImageLocation = PATH
                Else
                    'BM1 = Bitmap.FromFile(PATH)
                    'PictureBox1.Image = BM1
                    ListadeArchivos.MemoryList.Add(PATH)
                    PictureBox1.ImageLocation = PATH
                    PATH = PATH.Remove(0, PATH.LastIndexOf("\") + 1)
                    ListadeArchivos.ListBox1.Items.Add(PATH)
                End If
            End If
            ListadeArchivos.LoadImages(My.Settings.ImageDir)
            If My.Settings.ActiveNotify = True Then
                NotifyIcon1.Visible = True
                Options.CheckBox2.CheckState = CheckState.Checked
            ElseIf My.Settings.ActiveNotify = False Then
                NotifyIcon1.Visible = False
                Options.CheckBox2.CheckState = CheckState.Unchecked
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Worcome Security")
        End Try
    End Sub

    Private Sub AgregarCarpetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCarpetaToolStripMenuItem.Click
        ListadeArchivos.FolderSelecctor()
    End Sub

    Private Sub SeleccionarArchivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarArchivosToolStripMenuItem.Click
        ListadeArchivos.OpenFileDialog1.Multiselect = True
        ListadeArchivos.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub LimpiarListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarListaToolStripMenuItem.Click
        ListadeArchivos.MemoryList.Clear()
        ListadeArchivos.ListBox1.Items.Clear()
        PictureBox1.Image = My.Resources.Diapositiva
        'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
        'PictureBox1.Image = BM1
    End Sub

    Private Sub VerListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListaToolStripMenuItem.Click
        ListadeArchivos.Show()
        ListadeArchivos.Focus()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        ListadeArchivos.OpenFileDialog1.Multiselect = False
        ListadeArchivos.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ListadeArchivos.ListBox1.SelectedIndex > 0 Then
                ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex - 1
                Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
                ListadeArchivos.ListBox1.SelectedIndex = a
                ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
                PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
                'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
                'PictureBox1.Image = BM1
                Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
            End If
        Catch ex As Exception
            Console.WriteLine("[Visor@Atras_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Adelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex + 1
            Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
            ListadeArchivos.ListBox1.SelectedIndex = a
            ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
            'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
            'PictureBox1.Image = BM1
            PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
            Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
        Catch ex As Exception
            Console.WriteLine("[Visor@Adelante_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AbrirArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirArchivoToolStripMenuItem.Click
        ListadeArchivos.Show()
        ListadeArchivos.Focus()
    End Sub

    Private Sub VerListaDeArchivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListaDeArchivosToolStripMenuItem.Click
        ListadeArchivos.Show()
        ListadeArchivos.Focus()
    End Sub

    Private Sub LimpiarListaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarListaToolStripMenuItem1.Click
        ListadeArchivos.MemoryList.Clear()
        ListadeArchivos.ListBox1.Items.Clear()
        PictureBox1.Image = My.Resources.Diapositiva
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If MessageBox.Show("¿Realmente quieres eliminar este Archivo de tu Computadora?", "Worcome Security", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                ListadeArchivos.MemoryList.RemoveAt(ListadeArchivos.Contador)
                ListadeArchivos.ListBox1.Items.Remove(ListadeArchivos.ListBox1.SelectedItem)
                PictureBox1.Image = My.Resources.Diapositiva
                NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Archivo eliminado", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            Console.WriteLine("[Visor@EliminarToolStripMenuItem_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub EliminarDeLaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDeLaListaToolStripMenuItem.Click
        Try
            ListadeArchivos.MemoryList.RemoveAt(ListadeArchivos.Contador)
            ListadeArchivos.ListBox1.Items.RemoveAt(ListadeArchivos.ListBox1.SelectedIndex)
            NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Archivo quitado de la lista", ToolTipIcon.Info)
        Catch ex As Exception
            Console.WriteLine("[Visor@EliminarDeLaListaToolStripMenuItem_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub VerEnElEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerEnElEditorToolStripMenuItem.Click
        Editor.PictureBoxFOTO.Image = PictureBox1.Image
        Editor.Show()
        Editor.Focus()
    End Sub

#Region "PictureBox"

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        'If e.Delta <> 0 Then
        '    If e.Delta <= 0 Then
        '        If PictureBox1.Width < 500 Then Exit Sub 'minimum 500?
        '    Else
        '        If PictureBox1.Width > 2000 Then Exit Sub 'maximum 2000?
        '    End If

        '    PictureBox1.Width += CInt(PictureBox1.Width * e.Delta / 1000)
        '    PictureBox1.Height += CInt(PictureBox1.Height * e.Delta / 1000)
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'CADA VEZ QUE SE CLICA EL BOTON SE AUMENTA EL TAMAÑO DE LA IMAGEN UN 10%
            Dim BM2 As New Bitmap(BM1, PictureBox1.Image.Width * 1.1, PictureBox1.Image.Height * 1.1)
            PictureBox1.Image = BM2
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'CADA VEZ QUE SE CLICA EL BOTON SE DISMINUYE EL TAMAÑO DE LA IMAGEN UN 10%
            Dim BM2 As New Bitmap(BM1, PictureBox1.Image.Width * 0.9, PictureBox1.Image.Height * 0.9)
            PictureBox1.Image = BM2
        Catch ex As Exception
        End Try
    End Sub

    'Private Arrastrar As Boolean = False
    'Private MouseDownX As Integer
    'Private MouseDownY As Integer
    'Public MovementActive As Boolean = False

#Region "PictureMovementCode"
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            'DETERMINA LA POSICION EN LA QUE SE HA PRESIONADO EL MOUSE
            MIX = e.Location.X
            MIY = e.Location.Y
            MUEVE = True 'SE HA INICIADO EL DESPLAZAMIENTO
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Try
            If MUEVE Then
                'DETERMINA LA DIFERENCIA DE POSICION DEL MOUSE
                Dim DIFX As Integer = (MIX - e.X)
                Dim DIFY As Integer = (MIY - e.Y)
                'NUEVA POSICION DE LAS BARRAS DE SCROLL DEL PANEL
                Panel1.AutoScrollPosition = New Point((DIFX - Panel1.AutoScrollPosition.X), (DIFY - Panel1.AutoScrollPosition.Y))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            MUEVE = False 'SE HA TERMINADO EL DESPLAZAMIENTO
        Catch ex As Exception
        End Try
    End Sub
#End Region
#End Region

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            'IMAGEN Y PICTUREBOX VUELVEN A LOS VALORES INICIALES
            PictureBox1.Image = BM1
            Panel1.AutoScrollPosition = New Point(0, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim rutaFichero As String
        Dim i As Integer
        Try
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                'ListadeArchivos.ListBox1.Items.Add("[TAG]GALLERY_VIEW")
                rutaFichero = Path.Combine(Application.StartupPath, SaveFileDialog1.FileName)
                Dim fichero As New IO.StreamWriter(rutaFichero)
                For i = 0 To ListadeArchivos.ListBox1.Items.Count - 1
                    fichero.WriteLine(ListadeArchivos.MemoryList.Item(i))
                Next
                fichero.Close()
                NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Lista guardada", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            Console.WriteLine("[Visor@GuardarToolStripMenuItem_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim SEGUNDOS As Integer

#Region "EazyCAM"
    Dim CAMERA As Boolean
    Sub EazyCAM(ByVal DATA As Boolean)
        Try
            If DATA = True Then
                Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
                If CAMARAS.ShowDialog() = DialogResult.OK Then
                    CAMARA = CAMARAS.VideoDevice
                    AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
                    CAMARA.Start()
                    IniciarEazyCAMToolStripMenuItem.Text = "Detener EazyCAM"
                    IniciarEazyCAMToolStripMenuItem1.Text = "Detener EazyCAM"
                    EazyCAMToolStripMenuItem.Visible = True
                    Me.Text = "Wor: GalleryView | EazyCAM Streaming"
                    CAMERA = True
                End If
            ElseIf DATA = False Then
                Me.Text = "Wor: GalleryView"
                EazyCAMToolStripMenuItem.Visible = False
                IniciarEazyCAMToolStripMenuItem.Text = "Iniciar EazyCAM"
                IniciarEazyCAMToolStripMenuItem1.Text = "Iniciar EazyCAM"
                Try
                    CAMARA.Stop()
                    CAMARA.SignalToStop()
                Catch ex As Exception
                End Try
                PictureBox1.Image = Nothing
                PictureBox1.Image = My.Resources.Diapositiva
                DATA = False
                CAMERA = False
            End If
        Catch ex As Exception
            Console.WriteLine("[Visor@EazyCAM]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub IniciarEazyCAMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarEazyCAMToolStripMenuItem.Click
        If CAMERA = False Then
            CAMERA = True
            EazyCAM(True)
        Else
            CAMERA = False
            EazyCAM(False)
        End If
    End Sub

    Private Sub IniciarEazyCAMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarEazyCAMToolStripMenuItem1.Click
        If CAMERA = False Then
            CAMERA = True
            EazyCAM(True)
        Else
            CAMERA = False
            EazyCAM(False)
        End If
    End Sub

    Private Sub CAPTURAR(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
#End Region

    Private Sub ModoConsentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoConsentradoToolStripMenuItem.Click
        If ModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado" Then
            Me.TopMost = True
            ModoConsentradoToolStripMenuItem.Text = "Desactivar Modo Concentrado"
        Else
            Me.TopMost = False
            ModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            Dim rutaFichero As String = IO.Path.Combine(Application.StartupPath, OpenFileDialog1.FileName)
            If IO.File.Exists(rutaFichero) = True Then
                Dim fichero As New IO.StreamReader(rutaFichero)
                Dim StringPassed As String
                While (fichero.Peek() > -1)
                    StringPassed = fichero.ReadLine
                    ListadeArchivos.MemoryList.Add(StringPassed)
                    StringPassed = StringPassed.Remove(0, StringPassed.LastIndexOf("\") + 1)
                    ListadeArchivos.ListBox1.Items.Add(StringPassed)
                    'ListadeArchivos.ListBox1.Items.Add("[TAG]GALLERY_VIEW")
                End While
                fichero.Close()
                NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Hay " & ListadeArchivos.ListBox1.Items.Count & " Archivos", ToolTipIcon.Info)
            End If
            MsgBox("Items Agregados Correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            Console.WriteLine("[Visor@OpenFileDialog1_FileOk]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        CAPTURA.PCAPTURA.Image = PictureBox1.Image
        CAPTURA.Show()
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Left Then
            Try
                If ListadeArchivos.ListBox1.SelectedIndex > 0 Then
                    ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex - 1
                    Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
                    ListadeArchivos.ListBox1.SelectedIndex = a
                    'BM1 = Bitmap.FromFile(ListadeArchivos.ListBox1.SelectedItem)
                    'PictureBox1.Image = BM1
                    PictureBox1.ImageLocation = ListadeArchivos.ListBox1.SelectedItem
                    Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
                End If
            Catch ex As Exception
            End Try
        ElseIf e.KeyCode = Keys.Right Then
            Try
                ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex + 1
                Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
                ListadeArchivos.ListBox1.SelectedIndex = a
                'BM1 = Bitmap.FromFile(ListadeArchivos.ListBox1.SelectedItem)
                'PictureBox1.Image = BM1
                PictureBox1.ImageLocation = ListadeArchivos.ListBox1.SelectedItem
                Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Right Then
            Try
                ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex + 1
                Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
                ListadeArchivos.ListBox1.SelectedIndex = a
                ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
                PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
                'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
                'PictureBox1.Image = BM1
                Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
            Catch ex As Exception
            End Try
        ElseIf e.KeyCode = Keys.Left Then
            Try
                If ListadeArchivos.ListBox1.SelectedIndex > 0 Then
                    ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex - 1
                    Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
                    ListadeArchivos.ListBox1.SelectedIndex = a
                    ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
                    PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
                    'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
                    'PictureBox1.Image = BM1
                    Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            ListadeArchivos.ListBox1.SelectedIndex = ListadeArchivos.ListBox1.SelectedIndex + 1
            Dim a As Integer = ListadeArchivos.ListBox1.SelectedIndex
            ListadeArchivos.ListBox1.SelectedIndex = a
            ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
            PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
            'BM1 = Bitmap.FromFile(ListadeArchivos.MemoryList(ListadeArchivos.Contador))
            'PictureBox1.Image = BM1
            Me.Text = ListadeArchivos.ListBox1.SelectedItem & " | Wor: GalleryView"
        Catch ex As Exception
            Timer1.Enabled = False
            ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas"
            Options.Button1.Text = "Comenzar Presentacion de Diapositivas"
            MsgBox("Finalizo la Presentacion de Diapositivas", MsgBoxStyle.Information, "Worcome Security")
        End Try
    End Sub

    Private Sub ComenzarDiapositivasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComenzarDiapositivasToolStripMenuItem.Click
        If ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas" Then
            Timer1.Enabled = True
            Options.Button1.Text = "Parar Diapositivas"
            ComenzarDiapositivasToolStripMenuItem.Text = "Parar Diapositivas"
        Else
            Timer1.Enabled = False
            Options.Button1.Text = "Comenzar Diapositivas"
            ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas"
        End If
    End Sub

    Private Sub ActivarModoConsentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarModoConsentradoToolStripMenuItem.Click
        If ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado" Then
            Me.TopMost = True
            ActivarModoConsentradoToolStripMenuItem.Text = "Desactivar Modo Concentrado"
        Else
            Me.TopMost = False
            ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Concentrado"
        End If
    End Sub

    Private Sub OcultarBarraDeHerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultarBarraDeHerramientasToolStripMenuItem.Click
        If OcultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar Barra de Herramientas" Then
            MenuStrip1.Visible = False
            Panel1.Visible = False
            PictureBox1.Dock = DockStyle.Fill
            OcultarBarraDeHerramientasToolStripMenuItem.Text = "Mostrar Barra de Herramientas"
        ElseIf OcultarBarraDeHerramientasToolStripMenuItem.Text = "Mostrar Barra de Herramientas" Then
            MenuStrip1.Visible = True
            Panel1.Visible = True
            PictureBox1.Dock = DockStyle.Fill
            OcultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar Barra de Herramientas"
        End If
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Options.Show()
        Options.Focus()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        If OcultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar Barra de Herramientas" Then
            MenuStrip1.Visible = False
            Panel1.Visible = False
            PictureBox1.Dock = DockStyle.Fill
            OcultarBarraDeHerramientasToolStripMenuItem.Text = "Mostrar Barra de Herramientas"
        ElseIf OcultarBarraDeHerramientasToolStripMenuItem.Text = "Mostrar Barra de Herramientas" Then
            MenuStrip1.Visible = True
            Panel1.Visible = True
            PictureBox1.Dock = DockStyle.Fill
            OcultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar Barra de Herramientas"
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim strRutaArchivos() As String
                Dim i As Integer
                strRutaArchivos = e.Data.GetData(DataFormats.FileDrop)
                Dim StringPassed As String
                For i = 0 To strRutaArchivos.Length - 1
                    StringPassed = strRutaArchivos(i).ToString
                    ListadeArchivos.MemoryList.Add(StringPassed)
                    StringPassed = StringPassed.Remove(0, StringPassed.LastIndexOf("\") + 1)
                    ListadeArchivos.ListBox1.Items.Add(StringPassed)
                Next
                NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Se agregaron nuevos archivos", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            Console.WriteLine("[Visor@PictureBox1_DragDrop]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.Focus()
    End Sub

    Private Sub Panel1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDoubleClick
        ListadeArchivos.Show()
        ListadeArchivos.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class