Imports FontAwesome.Sharp

Public Class MenuClerk
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentForm As Form
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 64)
        PanelMenu.Controls.Add(leftBorderBtn)


    End Sub

    Private Sub BtnActivate(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            BtnDisable()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(173, 151, 79)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = Color.FromArgb(234, 234, 234)
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            CFIcon.IconChar = currentBtn.IconChar
            Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


        End If
    End Sub

    Private Sub BtnDisable()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(35, 31, 32)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub Section_Click(sender As Object, e As EventArgs)
        BtnActivate(sender, Color.FromArgb(173, 151, 79))
        FormOpen(New FrmNewGuest)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        BtnActivate(sender, Color.FromArgb(173, 151, 79))
        FormOpen(New FrmNewReservation)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)
        BtnActivate(sender, Color.FromArgb(173, 151, 79))
        FormOpen(New ReservationViewFRM)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs)
        BtnActivate(sender, Color.FromArgb(173, 151, 79))
        FormOpen(New FrmRoomService)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)
        Dim logout As New FrmLogin
        logout.Show()
        Me.Close()
    End Sub

    Private Sub FormOpen(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        DashBoard.Controls.Add(childForm)
        DashBoard.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        CFLabel.Text = childForm.Text

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        Homepage()

    End Sub

    Private Sub Homepage()
        leftBorderBtn.Visible = IconChar.Home
        CFIcon.IconChar = IconChar.Home
        CFLabel.Text = "Home"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = Date.Now.ToString("MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs)
        BtnActivate(sender, Color.FromArgb(173, 151, 79))
        FormOpen(New FrmRating)
    End Sub
End Class
