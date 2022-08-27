Public Class ListadeArchivos
    Public MemoryList As New ArrayList
    Public Contador As Integer = -1

    Private Sub ListadeArchivos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub ListadeArchivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.InitialDirectory = My.Settings.ImageDir
        OpenFileDialog1.Filter = "Todos los Archivos|*.*|Imagen PNG|*.png|Imagen JPG|*.jpg|Imagen GIF|*.gif|Imagen BMP|*.bmp|Imagen TIFF|*.tiff|Imagen ICON|*.ico"
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "Abrir Archivos..."
        Me.ContextMenuStrip = Visor.MenuPrincipal
    End Sub

    Sub LoadImages(ByVal Directory As String)
        For Each Archivo As String In My.Computer.FileSystem.GetFiles(
                        Directory,
                         FileIO.SearchOption.SearchAllSubDirectories,
                        "*.png*", "*.jpg*", "*.gif", "*.bmp", "*.tiff", "*.ico")
            MemoryList.Add(Archivo)
            Archivo = Archivo.Remove(0, Archivo.LastIndexOf("\") + 1)
            ListBox1.Items.Add(Archivo.ToString)
        Next
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        Try
            If e.KeyCode = Keys.Delete And ListBox1.Items.Count > 0 And ListBox1.SelectedIndex > -1 Then
                MemoryList.RemoveAt(Contador)
                Visor.NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Archivo quitado de la lista" & vbCrLf & "(" & ListBox1.SelectedItem & ")", ToolTipIcon.Info)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            End If
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@ListBox1_KeyDown]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.InitialDirectory = My.Settings.ImageDir
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            For Each Imagenes As String In OpenFileDialog1.FileNames
                MemoryList.Add(Imagenes)
                Imagenes = Imagenes.Remove(0, Imagenes.LastIndexOf("\") + 1)
                ListBox1.Items.Add(Imagenes.ToString)
            Next
            Visor.NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Se agregaron nuevos archivos", ToolTipIcon.Info)
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@OpenFileDialog1_FileOk]Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderSelecctor()
    End Sub

    Public Sub FolderSelecctor()
        Try
            Dim Folder As New FolderBrowserDialog
            Folder.Description = "Seleccione la Capeta donde se Encuentran las Imagenes que desea Ver" & vbCrLf & "Formatos Compatibles: .PNG, .JPG, .GIF, .BMP, .TIFF, .ICO"
            Folder.ShowNewFolderButton = False
            Folder.SelectedPath = My.Settings.ImageDir
            If Folder.ShowDialog() = DialogResult.OK Then
                My.Settings.ImageDir = Folder.SelectedPath
                My.Settings.Save()
                My.Settings.Reload()
            End If

            For Each Archivo As String In My.Computer.FileSystem.GetFiles(
                                    My.Settings.ImageDir,
                                     FileIO.SearchOption.SearchAllSubDirectories,
                                    "*.png*", "*.jpg*", "*.gif", "*.bmp", "*.tiff", "*.ico")
                MemoryList.Add(Archivo)
                Archivo = Archivo.Remove(0, Archivo.LastIndexOf("\") + 1)
                ListBox1.Items.Add(Archivo.ToString)
            Next
            Visor.NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Se agregaron nuevos archivos", ToolTipIcon.Info)
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@ListBox1_SelectedIndexChanged]Error: " & ex.Message)
        End Try
        Me.Focus()
    End Sub

    Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim strRutaArchivos() As String
                Dim i As Integer
                strRutaArchivos = e.Data.GetData(DataFormats.FileDrop)
                Dim StringPassed As String
                For i = 0 To strRutaArchivos.Length - 1
                    StringPassed = strRutaArchivos(i).ToString
                    MemoryList.Add(StringPassed)
                    StringPassed = StringPassed.Remove(0, StringPassed.LastIndexOf("\") + 1)
                    ListBox1.Items.Add(StringPassed)
                Next
                Visor.NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Se agregaron nuevos archivos", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@ListBox1_DragDrop]Error: " & ex.Message)
        End Try
    End Sub

    Dim PATH As String
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Contador = ListBox1.SelectedIndex
            PATH = MemoryList(Contador)
            'Visor.BM1 = Bitmap.FromFile(PATH)
            'Visor.PictureBox1.Image = Visor.BM1
            Visor.PictureBox1.ImageLocation = PATH
            Visor.Text = ListBox1.SelectedItem & " | Wor: GalleryView"
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@ListBox1_SelectedIndexChanged]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListaToolStripMenuItem.Click
        MemoryList.Clear()
        ListBox1.Items.Clear()
        Visor.PictureBox1.Image = My.Resources.Diapositiva
    End Sub

    Private Sub EliminarDeLaListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDeLaListaToolStripMenuItem.Click
        Try
            MemoryList.RemoveAt(Contador)
            Visor.NotifyIcon1.ShowBalloonTip(1, "Lista de Archivos", "Archivo quitado de la lista" & vbCrLf & "(" & ListBox1.SelectedItem & ")", ToolTipIcon.Info)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Catch ex As Exception
            Console.WriteLine("[ListaDeArchivos@EliminarDeLaListaToolStripMenuItem_Click]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AbrirUbicacionDelArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirUbicacionDelArchivoToolStripMenuItem.Click
        Dim path As String = MemoryList(Contador)
        Process.Start("explorer.exe", "/select, " & path)
    End Sub
End Class