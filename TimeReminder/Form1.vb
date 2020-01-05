Public Class frmMain

    Sub SaveConfig()
        T.Interval = Int(timeInterval.Value.TimeOfDay.TotalMilliseconds)
        My.Settings.Save()
    End Sub

    Sub NotificacionDeTiempo()
        Select Case action.SelectedIndex

            Case 0
                ' Beep
                Console.Beep()

            Case 1
                ' Notificación
                Dim mask As String = TextMask.Text
                Dim tiempo As String = Now.ToString(TimeFormat.Text)
                Dim finalText As String = String.Format(mask, tiempo)

                BarIcon.BalloonTipTitle = Title.Text
                BarIcon.BalloonTipText = finalText
                BarIcon.ShowBalloonTip(Int(TimeOut.Value.TimeOfDay.TotalMilliseconds))

            Case 2
                ' Notificacion Personalizada
                Dim mask As String = TextMask.Text
                Dim tiempo As String = Now.ToString(TimeFormat.Text)
                Dim finalText As String = String.Format(mask, tiempo)

                frmNotificacion.title.Text = Title.Text
                frmNotificacion.message.Text = finalText
                frmNotificacion.Show()
                Dim start As Date = Now
                Do Until (Now - start).TotalMilliseconds >= Int(TimeOut.Value.TimeOfDay.TotalMilliseconds)
                    frmNotificacion.UpdateSize()
                    frmNotificacion.UpdateLocation()
                    Threading.Thread.Sleep(1)
                    Application.DoEvents()
                Loop
                frmNotificacion.Hide()
                Application.DoEvents()

        End Select

    End Sub



    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        SaveConfig()
        NotificacionDeTiempo()
        T.Start()
    End Sub



    Private Sub AbrirPanelDeControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPanelDeControlToolStripMenuItem.Click
        Me.Show()
    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        T.Stop()
        Application.Exit()
    End Sub

    Private Sub T_Tick(sender As Object, e As EventArgs) Handles T.Tick

        If timeStart.Checked And Not (Now.TimeOfDay > timeStart.Value.TimeOfDay) Then Exit Sub
        If timeEnd.Checked And Not (Now.TimeOfDay < timeEnd.Value.TimeOfDay) Then Exit Sub

        NotificacionDeTiempo()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' action.SelectedIndex = 1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        T.Stop()
        Application.Exit()
    End Sub

    Private Sub BarIcon_DoubleClick(sender As Object, e As EventArgs) Handles BarIcon.BalloonTipClicked, BarIcon.DoubleClick
        T.Stop()
        Me.Show()
    End Sub



End Class
