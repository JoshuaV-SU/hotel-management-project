<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationViewFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReservationView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.reserveNoTxt = New System.Windows.Forms.TextBox()
        Me.checkInTxt = New System.Windows.Forms.TextBox()
        Me.guestIdTxt = New System.Windows.Forms.TextBox()
        Me.guestNameTxt = New System.Windows.Forms.TextBox()
        Me.noGuestTxt = New System.Windows.Forms.TextBox()
        Me.checkOutTxt = New System.Windows.Forms.TextBox()
        Me.roomIdTxt = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.statusTxt = New System.Windows.Forms.ComboBox()
        CType(Me.ReservationView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(740, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservations"
        '
        'ReservationView
        '
        Me.ReservationView.AllowUserToAddRows = False
        Me.ReservationView.AllowUserToDeleteRows = False
        Me.ReservationView.AllowUserToResizeColumns = False
        Me.ReservationView.AllowUserToResizeRows = False
        Me.ReservationView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReservationView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReservationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationView.Location = New System.Drawing.Point(381, 101)
        Me.ReservationView.MultiSelect = False
        Me.ReservationView.Name = "ReservationView"
        Me.ReservationView.ReadOnly = True
        Me.ReservationView.RowHeadersVisible = False
        Me.ReservationView.RowHeadersWidth = 51
        Me.ReservationView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ReservationView.Size = New System.Drawing.Size(466, 315)
        Me.ReservationView.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(197, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Details"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(234, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Room ID:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(102, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Reservation No:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(102, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Check In:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(234, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Check Out:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(102, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(234, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Number of Guest:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(102, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Guest ID:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(234, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Guest Name:"
        '
        'reserveNoTxt
        '
        Me.reserveNoTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.reserveNoTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.reserveNoTxt.Enabled = False
        Me.reserveNoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.reserveNoTxt.Location = New System.Drawing.Point(106, 140)
        Me.reserveNoTxt.Name = "reserveNoTxt"
        Me.reserveNoTxt.Size = New System.Drawing.Size(100, 24)
        Me.reserveNoTxt.TabIndex = 12
        '
        'checkInTxt
        '
        Me.checkInTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkInTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.checkInTxt.Enabled = False
        Me.checkInTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkInTxt.Location = New System.Drawing.Point(106, 201)
        Me.checkInTxt.Name = "checkInTxt"
        Me.checkInTxt.Size = New System.Drawing.Size(100, 26)
        Me.checkInTxt.TabIndex = 13
        '
        'guestIdTxt
        '
        Me.guestIdTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.guestIdTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.guestIdTxt.Enabled = False
        Me.guestIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestIdTxt.Location = New System.Drawing.Point(106, 336)
        Me.guestIdTxt.Name = "guestIdTxt"
        Me.guestIdTxt.Size = New System.Drawing.Size(100, 26)
        Me.guestIdTxt.TabIndex = 15
        '
        'guestNameTxt
        '
        Me.guestNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.guestNameTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.guestNameTxt.Enabled = False
        Me.guestNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestNameTxt.Location = New System.Drawing.Point(238, 336)
        Me.guestNameTxt.Name = "guestNameTxt"
        Me.guestNameTxt.Size = New System.Drawing.Size(111, 29)
        Me.guestNameTxt.TabIndex = 19
        '
        'noGuestTxt
        '
        Me.noGuestTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.noGuestTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.noGuestTxt.Enabled = False
        Me.noGuestTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noGuestTxt.Location = New System.Drawing.Point(238, 271)
        Me.noGuestTxt.Name = "noGuestTxt"
        Me.noGuestTxt.Size = New System.Drawing.Size(111, 26)
        Me.noGuestTxt.TabIndex = 18
        '
        'checkOutTxt
        '
        Me.checkOutTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkOutTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.checkOutTxt.Enabled = False
        Me.checkOutTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkOutTxt.Location = New System.Drawing.Point(238, 201)
        Me.checkOutTxt.Name = "checkOutTxt"
        Me.checkOutTxt.Size = New System.Drawing.Size(111, 26)
        Me.checkOutTxt.TabIndex = 17
        '
        'roomIdTxt
        '
        Me.roomIdTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roomIdTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.roomIdTxt.Enabled = False
        Me.roomIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomIdTxt.Location = New System.Drawing.Point(238, 141)
        Me.roomIdTxt.Name = "roomIdTxt"
        Me.roomIdTxt.Size = New System.Drawing.Size(111, 26)
        Me.roomIdTxt.TabIndex = 16
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUpdate.BackColor = System.Drawing.Color.Black
        Me.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(167, 400)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(110, 35)
        Me.BtnUpdate.TabIndex = 20
        Me.BtnUpdate.Text = "Update Status"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'statusTxt
        '
        Me.statusTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.statusTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusTxt.FormattingEnabled = True
        Me.statusTxt.Items.AddRange(New Object() {"In Hotel", "Cancelled ", "Check Out"})
        Me.statusTxt.Location = New System.Drawing.Point(106, 271)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(100, 28)
        Me.statusTxt.TabIndex = 21
        '
        'ReservationViewFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 565)
        Me.Controls.Add(Me.statusTxt)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.guestNameTxt)
        Me.Controls.Add(Me.noGuestTxt)
        Me.Controls.Add(Me.checkOutTxt)
        Me.Controls.Add(Me.roomIdTxt)
        Me.Controls.Add(Me.guestIdTxt)
        Me.Controls.Add(Me.checkInTxt)
        Me.Controls.Add(Me.reserveNoTxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReservationView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReservationViewFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Status"
        CType(Me.ReservationView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReservationView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents reserveNoTxt As TextBox
    Friend WithEvents checkInTxt As TextBox
    Friend WithEvents guestIdTxt As TextBox
    Friend WithEvents guestNameTxt As TextBox
    Friend WithEvents noGuestTxt As TextBox
    Friend WithEvents checkOutTxt As TextBox
    Friend WithEvents roomIdTxt As TextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents statusTxt As ComboBox
End Class
