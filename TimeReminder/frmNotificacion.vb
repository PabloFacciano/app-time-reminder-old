Public Class frmNotificacion

    Public Enum Position As Byte
        None = 0
        Up = 1
        Down = 2
        Left = 4
        Right = 8
    End Enum
    Public Property NotifyPosition As Position = Position.Left
    Public Property NotifyMargin As Integer = 5

    Public Shadows Property InnerPadding As Padding
        Get
            Return Panel1.Padding
        End Get
        Set(value As Padding)
            Panel1.Padding = value
        End Set
    End Property


    Sub UpdateSize()
        Me.Size = New Size(
            Math.Max(title.Width, message.Width) + (InnerPadding.Left + InnerPadding.Right) + (Padding.Left + Padding.Right),
           (title.Height + message.Height) + (InnerPadding.Top + InnerPadding.Bottom)
        )
    End Sub
    Sub UpdateLocation()

        Dim C As Rectangle = New Rectangle(System.Windows.Forms.Cursor.Position, System.Windows.Forms.Cursor.Current.Size)

        Dim LocX As Integer = C.X
        Dim LocY As Integer = C.Y

        Select Case NotifyPosition
            Case Position.Up
                LocX -= (Me.Width / 2)
                LocY -= (NotifyMargin + Me.Height)
            Case Position.Down
                LocX -= (Me.Width / 2)
                LocY += C.Height + NotifyMargin
            Case Position.Left
                LocX -= (NotifyMargin + Me.Width)
                LocY -= (Me.Height / 2)
            Case Position.Right
                LocX += (C.Width + NotifyMargin)
                LocY -= (C.Height / 2)
        End Select

        Me.Location = New Point(LocX, LocY)

    End Sub






End Class