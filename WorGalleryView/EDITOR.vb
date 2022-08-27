Public Class Editor

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ TAMAÑO DE LA FOTO
    Private Sub ButtonMAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMAS.Click
        PictureBoxFOTO.Width = PictureBoxFOTO.Width * 1.1 '+ 10%
        PictureBoxFOTO.Height = PictureBoxFOTO.Height * 1.1 '+ 10%
    End Sub

    Private Sub ButtonMENOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMENOS.Click
        PictureBoxFOTO.Width = PictureBoxFOTO.Width * 0.9 '- 10%
        PictureBoxFOTO.Height = PictureBoxFOTO.Height * 0.9 '- 10%
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ FONDOS
    Private Sub ButtonFONDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFONDO.Click
        If ColorDialog1.ShowDialog Then
            PictureBoxFONDO.BackColor = ColorDialog1.Color 'PARA ELEGIR COLOR DEL FONDO
        End If
    End Sub

    Dim AJUSTADA As Bitmap 'PARA ADAPTAR LA IMAGEN ELEGIDA AL TAMAÑO DEL FONDO

    Private Sub ButtonIMAGEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIMAGEN.Click
        If OpenFileDialog1.ShowDialog Then 'ADAPTA LA IMAGEN ELEGIDA AL TAMAÑO DEL FONDO
            Dim ORIGINAL As Bitmap = Bitmap.FromFile(OpenFileDialog1.FileName)
            AJUSTADA = New Bitmap(PictureBoxFONDO.Width, PictureBoxFONDO.Height) 'LA NUEVA IMAGEN TENDRA LAS DIMENSIONES DEL FONDO
            Dim DIBUJO As Graphics = Graphics.FromImage(AJUSTADA)
            DIBUJO.DrawImage(ORIGINAL, 0, 0, AJUSTADA.Width, AJUSTADA.Height)
            PictureBoxFONDO.Image = AJUSTADA
            ButtonFONDO.Visible = False 'SI HAY IMAGEN NO NECESITA COLOR DE FONDO
            ButtonBORRAR.Visible = False 'SI HAY IMAGEN NO SE PUEDE BORRAR PARCIALMENTE
        End If
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ INICIALIZACION Y DIBUJO SOBRE EL FONDO
    Dim MICOLOR As Color = Color.Blue 'COLOR DE INICIO PARA EL TRAZO MANUAL
    Dim TRAZO As SolidBrush 'BRUSH PARA EL DIBUJO MANUAL
    Dim DIBUJANDO As Boolean 'PARA SABER SI ESTA DIBUJANDO

    Private Sub CAPTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TRAZO = New SolidBrush(MICOLOR) 'INICIALIZA EL TRAZO CON EL COLOR INICIAL
        LabelCOLOR.BackColor = MICOLOR 'MUESTRA EN COLOR ELEGIDO EN LABELCOLOR
        LabelTEXTO.Visible = False 'PARA QUE NO SE VEA
        LabelTEXTO.Parent = PictureBoxFONDO 'FONDO TRANSPARENTE ASOCIADO AL PICTUREBOX FONDO NO AL FORM
    End Sub

    Private Sub ButtonDIBUJO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDIBUJO.Click
        If ColorDialog1.ShowDialog Then
            MICOLOR = ColorDialog1.Color 'ELIGE EL COLOR DEL TRAZO MANUAL
            TRAZO = New SolidBrush(MICOLOR)
            LabelCOLOR.BackColor = MICOLOR 'MUESTRA EL COLOR ELEGIDO EN EL LABELCOLOR
            ButtonBORRAR.BackColor = Color.Black 'POR SI ESTABA EN ROJO
        End If
    End Sub

    Private Sub PICTUREBOXFONDO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFONDO.MouseDown
        DIBUJANDO = True ' SE HA INICIADO EL DIBUJO MANUAL
    End Sub

    Private Sub PICTUREBOXFONDO_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFONDO.MouseMove
        If DIBUJANDO = True Then 'DIBUJA
            Dim DIBUJO As Graphics = PictureBoxFONDO.CreateGraphics
            DIBUJO.FillEllipse(TRAZO, e.X, e.Y, NumericUpDown1.Value, NumericUpDown1.Value)
        End If
    End Sub

    Private Sub PICTUREBOXFONDO_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFONDO.MouseUp
        DIBUJANDO = False 'HA DEJADO DE DIBUJAR
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BORRADO
    Private Sub ButtonBORRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBORRAR.Click
        If ButtonBORRAR.BackColor = Color.Black Then 'INICIO DE BORRADO
            TRAZO = New SolidBrush(PictureBoxFONDO.BackColor) 'DIBUJA CON EL COLOR DEL FONDO
            LabelCOLOR.BackColor = PictureBoxFONDO.BackColor 'MUESTRA EL COLOR DEL FONDO EN EL LABELCOLOR
            ButtonBORRAR.BackColor = Color.Red 'PARA QUE SE SEPA QUE ESTA EN ESTADO DE BORRAR
        Else
            ButtonBORRAR.BackColor = Color.Black 'HA DEJADO DE BORRAR
        End If
    End Sub

    Private Sub ButtonTODO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTODO.Click
        If PictureBoxFONDO.Image IsNot Nothing Then 'SI EL FONDO ES UNA IMAGEN.......
            PictureBoxFONDO.Image = AJUSTADA 'VUELVE A PRESENTARLA
            ButtonBORRAR.BackColor = Color.Black 'POR SI ESTABA EN ROJO
        Else
            PictureBoxFONDO.Refresh() 'SI EL FONDO NO ES UNA IMAGEN ELIMINA LO QUE SE HAYA DIBUJADO
            ButtonBORRAR.BackColor = Color.Black 'POR SI ESTABA EN ROJO
        End If
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ MOVIMIENTO DE LA FOTO
    Dim MUEVE As Boolean 'PARA SABER QUE SE ESTA MOVIENDO
    Dim MIX As Integer 'COORDENADAS PARA SABER ADONDE SE DESPLAZA
    Dim MIY As Integer 'COORDENADAS PARA SABER ADONDE SE DESPLAZA

    Private Sub PICTUREBOXFOTO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFOTO.MouseDown
        MUEVE = True 'SE INICIA EL MOVIMIENTO
        MIX = MousePosition.X - PictureBoxFOTO.Location.X 'DIFERENCIA DE COORDENADAS ENTRE EL MOUSE Y LA POSICION DEL PICTUREBOX
        MIY = MousePosition.Y - PictureBoxFOTO.Location.Y 'DIFERENCIA DE COORDENADAS ENTRE EL MOUSE Y LA POSICION DEL PICTUREBOX
    End Sub

    Private Sub PICTUREBOXFOTO_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFOTO.MouseMove
        'DESPLAZA EL PICTUREBOX 
        If MUEVE = True Then
            PictureBoxFOTO.Location = New Point(MousePosition.X - MIX, MousePosition.Y - MIY)
        End If
    End Sub

    Private Sub PICTUREBOXFOTO_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxFOTO.MouseUp
        MUEVE = False 'FINALIZA EL MOVIMIENTO
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ INTRODUCCION DE TEXTO  
    Private Sub ButtonINTRODUCIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonINTRODUCIR.Click
        LabelTEXTO.Visible = True
        LabelTEXTO.Text = InputBox("Escribe el Texto que sera Agregado") 'ENTRADA DEL TEXTO
    End Sub

    Private Sub ButtonLETRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLETRA.Click
        If FontDialog1.ShowDialog Then
            Try
                LabelTEXTO.Font = New Font(FontDialog1.Font, FontStyle.Bold) 'ELECCION TIPO DE LETRA
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonFOREC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFOREC.Click
        If ColorDialog1.ShowDialog Then
            LabelTEXTO.ForeColor = ColorDialog1.Color 'ELECCION COLOR DE LETRA(FORECOLOR)
        End If
    End Sub

    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ MOVIMIENTO DEL TEXTO
    Dim MUEVE_ETIQUETA As Boolean 'PARA SABER QUE SE ESTA MOVIENDO
    Dim TEXTOX As Integer 'COORDENADAS PARA SABER ADONDE SE DESPLAZA
    Dim TEXTOY As Integer 'COORDENADAS PARA SABER ADONDE SE DESPLAZA

    Private Sub LabelTEXTO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTEXTO.MouseDown
        MUEVE_ETIQUETA = True 'SE INICIA EL MOVIMIENTO
        TEXTOX = MousePosition.X - LabelTEXTO.Location.X 'DIFERENCIA DE COORDENADAS ENTRE EL MOUSE Y LA POSICION DE LA LABEL
        TEXTOY = MousePosition.Y - LabelTEXTO.Location.Y 'DIFERENCIA DE COORDENADAS ENTRE EL MOUSE Y LA POSICION DE LA LABEL
    End Sub

    Private Sub LabelTEXTO_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTEXTO.MouseMove
        If MUEVE_ETIQUETA = True Then 'DESPLAZA LA LABEL
            LabelTEXTO.Location = New Point(MousePosition.X - TEXTOX, MousePosition.Y - TEXTOY)
        End If
    End Sub

    Private Sub LabelTEXTO_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTEXTO.MouseUp
        MUEVE_ETIQUETA = False 'FINALIZA EL MOVIMIENTO
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ GUARDAR LA IMAGEN CREADA
    Private Sub ButtonGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGUARDAR.Click

        If SaveFileDialog1.ShowDialog Then
            Threading.Thread.Sleep(3000) 'PARA DAR TIEMPO A QUE DESAPAREZCA EL DIALOGO
            Dim BM As Bitmap = New Bitmap(PictureBoxFONDO.Width, PictureBoxFONDO.Height) 'TOMARA TODO EL CONTENIDO DEL FONDO
            Dim DIBUJO As Graphics = Graphics.FromImage(BM) 'PONDRA EL CONTENIDO DEL FONDO EN EL BITMAP
            DIBUJO.CopyFromScreen(Me.Location.X + PictureBoxFONDO.Location.X + 8, Me.Location.Y + PictureBoxFONDO.Location.Y + 50, 0, 0, PictureBoxFONDO.Size)
            BM.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg) 'GUARDA LA IMAGEN CON FORMATO JPG
            MsgBox("Imagen Guardada Correctamente", MsgBoxStyle.Exclamation, "Worcome Security")
        End If

    End Sub
End Class