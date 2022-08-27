Public Class CAPTURA

    Private Sub CAPTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Para Guardar la Imagen 'Click Derecho>Guardar Imagen'", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub GuardarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarImagenToolStripMenuItem.Click
        Dim SavePic As New SaveFileDialog
        SavePic.Title = "Guardar Captura..."
        SavePic.FileName = Nothing
        SavePic.Filter = "Todos los Archivos|*.*|Imagen JPG|*.jpg"
        SavePic.InitialDirectory = DesktopLocation.ToString
        If SavePic.ShowDialog = Windows.Forms.DialogResult.OK Then
            PCAPTURA.Image.Save(SavePic.FileName & ".jpeg", Imaging.ImageFormat.Jpeg)
            ListadeArchivos.MemoryList.Add(SavePic.FileName & ".jpeg")
            SavePic.FileName = SavePic.FileName.Remove(0, SavePic.FileName.LastIndexOf("\") + 1)
            ListadeArchivos.ListBox1.Items.Add(SavePic.FileName & ".jpeg")
            ListadeArchivos.ListBox1.SelectedItem = SavePic.FileName & ".jpeg"
            ListadeArchivos.Contador = ListadeArchivos.ListBox1.SelectedIndex
            Visor.PictureBox1.ImageLocation = ListadeArchivos.MemoryList(ListadeArchivos.Contador)
        End If
    End Sub

    Private Sub BorrarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarImagenToolStripMenuItem.Click
        PCAPTURA.Image = Nothing
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnviarAEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarAEditorToolStripMenuItem.Click
        Editor.PictureBoxFOTO.Image = PCAPTURA.Image
        Editor.Show()
    End Sub
End Class