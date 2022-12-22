<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewReservation
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvRoomView = New System.Windows.Forms.DataGridView()
        Me.guestIdTxt = New System.Windows.Forms.TextBox()
        Me.checkInTxt = New System.Windows.Forms.TextBox()
        Me.checkOutTxt = New System.Windows.Forms.TextBox()
        Me.noGuestTxt = New System.Windows.Forms.TextBox()
        Me.roomIdTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnReserve = New System.Windows.Forms.Button()
        Me.statusTxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomIdText = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DgvGuest = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvRoomView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(372, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Guest ID:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(371, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Check In Date:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(371, 264)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Check Out Date:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(371, 333)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Number of Guests:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label7.Location = New System.Drawing.Point(375, 410)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(620, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Search Room Name:"
        '
        'DgvRoomView
        '
        Me.DgvRoomView.AllowUserToAddRows = False
        Me.DgvRoomView.AllowUserToDeleteRows = False
        Me.DgvRoomView.AllowUserToResizeColumns = False
        Me.DgvRoomView.AllowUserToResizeRows = False
        Me.DgvRoomView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvRoomView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRoomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoomView.Location = New System.Drawing.Point(623, 126)
        Me.DgvRoomView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvRoomView.MultiSelect = False
        Me.DgvRoomView.Name = "DgvRoomView"
        Me.DgvRoomView.ReadOnly = True
        Me.DgvRoomView.RowHeadersVisible = False
        Me.DgvRoomView.RowHeadersWidth = 51
        Me.DgvRoomView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvRoomView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRoomView.Size = New System.Drawing.Size(299, 162)
        Me.DgvRoomView.TabIndex = 8
        '
        'guestIdTxt
        '
        Me.guestIdTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.guestIdTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.guestIdTxt.Enabled = False
        Me.guestIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestIdTxt.Location = New System.Drawing.Point(377, 160)
        Me.guestIdTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.guestIdTxt.Name = "guestIdTxt"
        Me.guestIdTxt.Size = New System.Drawing.Size(202, 24)
        Me.guestIdTxt.TabIndex = 11
        '
        'checkInTxt
        '
        Me.checkInTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkInTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.checkInTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkInTxt.Location = New System.Drawing.Point(376, 229)
        Me.checkInTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkInTxt.Name = "checkInTxt"
        Me.checkInTxt.Size = New System.Drawing.Size(202, 24)
        Me.checkInTxt.TabIndex = 12
        '
        'checkOutTxt
        '
        Me.checkOutTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkOutTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.checkOutTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkOutTxt.Location = New System.Drawing.Point(377, 298)
        Me.checkOutTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkOutTxt.Name = "checkOutTxt"
        Me.checkOutTxt.Size = New System.Drawing.Size(202, 24)
        Me.checkOutTxt.TabIndex = 13
        '
        'noGuestTxt
        '
        Me.noGuestTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.noGuestTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.noGuestTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noGuestTxt.Location = New System.Drawing.Point(377, 367)
        Me.noGuestTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.noGuestTxt.Name = "noGuestTxt"
        Me.noGuestTxt.Size = New System.Drawing.Size(148, 24)
        Me.noGuestTxt.TabIndex = 14
        '
        'roomIdTxt
        '
        Me.roomIdTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roomIdTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.roomIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomIdTxt.Location = New System.Drawing.Point(623, 90)
        Me.roomIdTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.roomIdTxt.Name = "roomIdTxt"
        Me.roomIdTxt.Size = New System.Drawing.Size(202, 24)
        Me.roomIdTxt.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(620, 23)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Available Rooms"
        '
        'BtnReserve
        '
        Me.BtnReserve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReserve.BackColor = System.Drawing.Color.Black
        Me.BtnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.BtnReserve.ForeColor = System.Drawing.Color.White
        Me.BtnReserve.Location = New System.Drawing.Point(404, 489)
        Me.BtnReserve.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReserve.Name = "BtnReserve"
        Me.BtnReserve.Size = New System.Drawing.Size(146, 48)
        Me.BtnReserve.TabIndex = 17
        Me.BtnReserve.Text = "Reserve"
        Me.BtnReserve.UseVisualStyleBackColor = False
        '
        'statusTxt
        '
        Me.statusTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusTxt.FormattingEnabled = True
        Me.statusTxt.Items.AddRange(New Object() {"Waiting", "In Hotel"})
        Me.statusTxt.Location = New System.Drawing.Point(469, 414)
        Me.statusTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(110, 28)
        Me.statusTxt.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(371, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Room ID:"
        '
        'roomIdText
        '
        Me.roomIdText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roomIdText.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.roomIdText.Enabled = False
        Me.roomIdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomIdText.Location = New System.Drawing.Point(377, 91)
        Me.roomIdText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.roomIdText.Name = "roomIdText"
        Me.roomIdText.Size = New System.Drawing.Size(202, 24)
        Me.roomIdText.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(813, 298)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 41)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DgvGuest
        '
        Me.DgvGuest.AllowUserToAddRows = False
        Me.DgvGuest.AllowUserToDeleteRows = False
        Me.DgvGuest.AllowUserToResizeColumns = False
        Me.DgvGuest.AllowUserToResizeRows = False
        Me.DgvGuest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGuest.Location = New System.Drawing.Point(39, 56)
        Me.DgvGuest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvGuest.MultiSelect = False
        Me.DgvGuest.Name = "DgvGuest"
        Me.DgvGuest.ReadOnly = True
        Me.DgvGuest.RowHeadersVisible = False
        Me.DgvGuest.RowHeadersWidth = 51
        Me.DgvGuest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvGuest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvGuest.Size = New System.Drawing.Size(287, 432)
        Me.DgvGuest.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Guests"
        '
        'FrmNewReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 599)
        Me.Controls.Add(Me.DgvGuest)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.roomIdText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusTxt)
        Me.Controls.Add(Me.BtnReserve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.roomIdTxt)
        Me.Controls.Add(Me.noGuestTxt)
        Me.Controls.Add(Me.checkOutTxt)
        Me.Controls.Add(Me.checkInTxt)
        Me.Controls.Add(Me.guestIdTxt)
        Me.Controls.Add(Me.DgvRoomView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Reservation"
        CType(Me.DgvRoomView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvRoomView As DataGridView
    Friend WithEvents guestIdTxt As TextBox
    Friend WithEvents checkInTxt As TextBox
    Friend WithEvents checkOutTxt As TextBox
    Friend WithEvents noGuestTxt As TextBox
    Friend WithEvents roomIdTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnReserve As Button
    Friend WithEvents statusTxt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents roomIdText As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DgvGuest As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As Label
End Class
