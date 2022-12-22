<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Section As FontAwesome.Sharp.IconButton
        Dim IconButton1 As FontAwesome.Sharp.IconButton
        Dim IconButton4 As FontAwesome.Sharp.IconButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCashier))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.CFLabel = New System.Windows.Forms.Label()
        Me.CFIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.DashBoard = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Section = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.CFIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DashBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'Section
        '
        Section.Dock = System.Windows.Forms.DockStyle.Top
        Section.FlatAppearance.BorderSize = 0
        Section.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Section.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Section.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Section.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt
        Section.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Section.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Section.IconSize = 33
        Section.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Section.Location = New System.Drawing.Point(0, 110)
        Section.Margin = New System.Windows.Forms.Padding(2)
        Section.Name = "Section"
        Section.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        Section.Size = New System.Drawing.Size(152, 52)
        Section.TabIndex = 1
        Section.Text = "Payment"
        Section.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Section.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Section.UseVisualStyleBackColor = True
        AddHandler Section.Click, AddressOf Me.Section_Click
        '
        'IconButton1
        '
        IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Table
        IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        IconButton1.IconSize = 33
        IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        IconButton1.Location = New System.Drawing.Point(0, 162)
        IconButton1.Margin = New System.Windows.Forms.Padding(2)
        IconButton1.Name = "IconButton1"
        IconButton1.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        IconButton1.Size = New System.Drawing.Size(152, 52)
        IconButton1.TabIndex = 2
        IconButton1.Text = "Transactions"
        IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = True
        AddHandler IconButton1.Click, AddressOf Me.IconButton1_Click
        '
        'IconButton4
        '
        IconButton4.Dock = System.Windows.Forms.DockStyle.Bottom
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        IconButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        IconButton4.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        IconButton4.IconSize = 33
        IconButton4.Location = New System.Drawing.Point(0, 605)
        IconButton4.Margin = New System.Windows.Forms.Padding(2)
        IconButton4.Name = "IconButton4"
        IconButton4.Padding = New System.Windows.Forms.Padding(8, 0, 15, 0)
        IconButton4.Size = New System.Drawing.Size(152, 41)
        IconButton4.TabIndex = 5
        IconButton4.Text = "Logout"
        IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = True
        AddHandler IconButton4.Click, AddressOf Me.IconButton4_Click
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelMenu.Controls.Add(IconButton4)
        Me.PanelMenu.Controls.Add(IconButton1)
        Me.PanelMenu.Controls.Add(Section)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(152, 646)
        Me.PanelMenu.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 110)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 110)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Time)
        Me.Panel3.Controls.Add(Me.CFLabel)
        Me.Panel3.Controls.Add(Me.CFIcon)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Location = New System.Drawing.Point(152, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 40)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(418, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cashier Menu"
        '
        'Time
        '
        Me.Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Time.Location = New System.Drawing.Point(771, 7)
        Me.Time.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(44, 20)
        Me.Time.TabIndex = 2
        Me.Time.Text = "Date"
        '
        'CFLabel
        '
        Me.CFLabel.AutoSize = True
        Me.CFLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.CFLabel.Location = New System.Drawing.Point(46, 7)
        Me.CFLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CFLabel.Name = "CFLabel"
        Me.CFLabel.Size = New System.Drawing.Size(52, 20)
        Me.CFLabel.TabIndex = 1
        Me.CFLabel.Text = "Home"
        '
        'CFIcon
        '
        Me.CFIcon.BackColor = System.Drawing.Color.Transparent
        Me.CFIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.CFIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.CFIcon.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.CFIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CFIcon.Location = New System.Drawing.Point(10, 7)
        Me.CFIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.CFIcon.Name = "CFIcon"
        Me.CFIcon.Size = New System.Drawing.Size(32, 32)
        Me.CFIcon.TabIndex = 0
        Me.CFIcon.TabStop = False
        '
        'DashBoard
        '
        Me.DashBoard.BackColor = System.Drawing.Color.White
        Me.DashBoard.Controls.Add(Me.Label3)
        Me.DashBoard.Controls.Add(Me.Label2)
        Me.DashBoard.Controls.Add(Me.Label4)
        Me.DashBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashBoard.Location = New System.Drawing.Point(152, 40)
        Me.DashBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.DashBoard.Name = "DashBoard"
        Me.DashBoard.Size = New System.Drawing.Size(969, 606)
        Me.DashBoard.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.Label3.Location = New System.Drawing.Point(251, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 55)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Welcome,"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(324, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 63)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edrian's Louvre"
        '
        'Timer1
        '
        '
        'MenuCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 646)
        Me.ControlBox = False
        Me.Controls.Add(Me.DashBoard)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(830, 529)
        Me.Name = "MenuCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Management System"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CFIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DashBoard.ResumeLayout(False)
        Me.DashBoard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CFLabel As Label
    Friend WithEvents CFIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents DashBoard As Panel
    Friend WithEvents Time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
