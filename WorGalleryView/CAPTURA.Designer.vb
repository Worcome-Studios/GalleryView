<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAPTURA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAPTURA))
        Me.PCAPTURA = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuardarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarAEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarAORCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PCAPTURA
        '
        Me.PCAPTURA.BackColor = System.Drawing.Color.Black
        Me.PCAPTURA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PCAPTURA.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PCAPTURA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PCAPTURA.Location = New System.Drawing.Point(0, 0)
        Me.PCAPTURA.Name = "PCAPTURA"
        Me.PCAPTURA.Size = New System.Drawing.Size(784, 562)
        Me.PCAPTURA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCAPTURA.TabIndex = 0
        Me.PCAPTURA.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarImagenToolStripMenuItem, Me.BorrarImagenToolStripMenuItem, Me.EnviarAEditorToolStripMenuItem, Me.EnviarAORCToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 120)
        '
        'GuardarImagenToolStripMenuItem
        '
        Me.GuardarImagenToolStripMenuItem.Name = "GuardarImagenToolStripMenuItem"
        Me.GuardarImagenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GuardarImagenToolStripMenuItem.Text = "Guardar Imagen"
        '
        'BorrarImagenToolStripMenuItem
        '
        Me.BorrarImagenToolStripMenuItem.Name = "BorrarImagenToolStripMenuItem"
        Me.BorrarImagenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BorrarImagenToolStripMenuItem.Text = "Borrar Imagen"
        '
        'EnviarAEditorToolStripMenuItem
        '
        Me.EnviarAEditorToolStripMenuItem.Name = "EnviarAEditorToolStripMenuItem"
        Me.EnviarAEditorToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EnviarAEditorToolStripMenuItem.Text = "Enviar a Editor"
        '
        'EnviarAORCToolStripMenuItem
        '
        Me.EnviarAORCToolStripMenuItem.Enabled = False
        Me.EnviarAORCToolStripMenuItem.Name = "EnviarAORCToolStripMenuItem"
        Me.EnviarAORCToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EnviarAORCToolStripMenuItem.Text = "Enviar a ORC"
        Me.EnviarAORCToolStripMenuItem.ToolTipText = "Esta Opcion no se Encuentra Disponible"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'CAPTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.PCAPTURA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAPTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wor: GalleryView | Visor de Capturas"
        Me.TopMost = True
        CType(Me.PCAPTURA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCAPTURA As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GuardarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarAORCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarAEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
