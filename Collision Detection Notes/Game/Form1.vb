Public Class Form1
    Dim frame As Bitmap
    Dim framePen, formPen As Graphics
    Dim up, down, left, right As Boolean
    Dim shipX, shipY As Integer
    Dim moonX, moonY As Integer

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        'DRAW STUFF HERE
        '---------------
        'Draw your background first!
        framePen.DrawImage(My.Resources.space_background, 0, 0)


        'Move Ship
        If up = True Then
            shipY = shipY - 5
        End If
        If down = True Then
            shipY = shipY + 5
        End If
        If left = True Then
            shipX = shipX - 5
        End If
        If right = True Then
            shipX = shipX + 5
        End If


        'Draw the ship
        framePen.DrawImage(My.Resources.ship, shipX, shipY)

        'Draw the moon
        moonX = getWidth() / 2 - My.Resources.moon.Width / 2
        moonY = getHeight() / 2 - My.Resources.moon.Height / 2
        framePen.DrawImage(My.Resources.moon, moonX, moonY)

        'Draw a wormhole
        framePen.DrawImage(My.Resources.wormhole, getWidth() - My.Resources.wormhole.Width, getHeight() - My.Resources.wormhole.Height)

        'COLLISIONS
        'Make hitboxes


        'Draw hitboxes (for testing, remove in the final game)


        'Render the frame on screen - do not alter
        formPen.DrawImage(frame, 0, 0)
        'Check hitboxes BELOW this line


        'Check hitboxes for collision



        'YOU TRY
        'Add collision code so that when the ship hits the wormhole it moves 
        'back to the left side of the screen and sets the y-location to a random number 
        'If you don't like the hitboxes, you can tweak them by +/- from their x, y, width, height


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not alter this code
        frame = New Bitmap(getWidth(), getHeight())
        formPen = Me.CreateGraphics
        framePen = Graphics.FromImage(frame)

        formPen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        formPen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        formPen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        formPen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        framePen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        framePen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        framePen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        framePen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        GameTimer.Start()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Up Then
            up = True
        End If
        If e.KeyValue = Keys.Down Then
            down = True
        End If
        If e.KeyValue = Keys.Left Then
            left = True
        End If
        If e.KeyValue = Keys.Right Then
            right = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.Up Then
            up = False
        End If
        If e.KeyValue = Keys.Down Then
            down = False
        End If
        If e.KeyValue = Keys.Left Then
            left = False
        End If
        If e.KeyValue = Keys.Right Then
            right = False
        End If
    End Sub

    Function getWidth() As Integer
        'Returns the usable width of the form
        Return Me.ClientSize.Width
    End Function
    Function getHeight() As Integer
        'Returns the usable height of the form
        Return Me.ClientSize.Height
    End Function
End Class
