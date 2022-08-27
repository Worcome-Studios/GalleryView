Public Class Options

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Visor.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
            CheckBox1.CheckState = CheckState.Checked
        ElseIf Visor.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            CheckBox1.CheckState = CheckState.Unchecked
        End If
        If My.Settings.ActiveNotify = True Then
            Visor.NotifyIcon1.Visible = True
            CheckBox2.CheckState = CheckState.Checked
        ElseIf My.Settings.ActiveNotify = False Then
            Visor.NotifyIcon1.Visible = False
            CheckBox2.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If Button1.Text = "Comenzar Diapositivas" Then
                Dim TextBoxVirtual = InputBox("¿Cuantos segundos deben pasar para cambiar a la siguiente imagen?" & vbCrLf & "(Valor en Segundos)", "Worcome Security", My.Settings.DiapositivaTimer)
                If TextBoxVirtual = Nothing Then
                    On_Off_Diapositivas(My.Settings.DiapositivaTimer)
                Else
                    On_Off_Diapositivas(TextBoxVirtual)
                    My.Settings.DiapositivaTimer = TextBoxVirtual
                    My.Settings.Save()
                    My.Settings.Reload()
                End If
            Else
                Visor.Timer1.Enabled = False
                Button1.Text = "Comenzar Diapositivas"
                Visor.ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas"
            End If
        Catch ex As Exception
            Console.WriteLine("[Options@Button1_Click]Error: " & ex.Message)
        End Try
    End Sub

    Sub On_Off_Diapositivas(ByVal Segundos As String)
        Try
            If Button1.Text = "Comenzar Diapositivas" Then
                Visor.Timer1.Interval = Segundos & 0 & 0 & 0
                Visor.Timer1.Enabled = True
                Button1.Text = "Parar Diapositivas"
                Visor.ComenzarDiapositivasToolStripMenuItem.Text = "Parar Diapositivas"
            Else
                Visor.Timer1.Enabled = False
                Button1.Text = "Comenzar Diapositivas"
                Visor.ComenzarDiapositivasToolStripMenuItem.Text = "Comenzar Diapositivas"
            End If
        Catch ex As Exception
            Console.WriteLine("[Options@On_Off_Diapositivas]Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Visor.Opacity = 0.1 + Me.TrackBar1.Value / 100
        Label6.Text = TrackBar1.Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Visor.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            Visor.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            Visor.NotifyIcon1.Visible = True
            My.Settings.ActiveNotify = True
        ElseIf CheckBox2.CheckState = CheckState.Unchecked Then
            Visor.NotifyIcon1.Visible = False
            My.Settings.ActiveNotify = False
        End If
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class