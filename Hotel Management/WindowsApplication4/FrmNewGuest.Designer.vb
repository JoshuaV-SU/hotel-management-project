<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewGuest
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
        Me.TxtGuestName = New System.Windows.Forms.TextBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGuestAdd = New System.Windows.Forms.TextBox()
        Me.TxtGuestPhoneNo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(116, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Name:"
        '
        'TxtGuestName
        '
        Me.TxtGuestName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtGuestName.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TxtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGuestName.Location = New System.Drawing.Point(121, 172)
        Me.TxtGuestName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGuestName.Name = "TxtGuestName"
        Me.TxtGuestName.Size = New System.Drawing.Size(265, 27)
        Me.TxtGuestName.TabIndex = 1
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnConfirm.BackColor = System.Drawing.SystemColors.InfoText
        Me.BtnConfirm.Enabled = False
        Me.BtnConfirm.FlatAppearance.BorderSize = 2
        Me.BtnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(349, 412)
        Me.BtnConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(234, 62)
        Me.BtnConfirm.TabIndex = 2
        Me.BtnConfirm.Text = "CONFIRM"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(529, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Guest Address:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(116, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Guest Phone No:"
        '
        'TxtGuestAdd
        '
        Me.TxtGuestAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtGuestAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TxtGuestAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGuestAdd.Location = New System.Drawing.Point(534, 172)
        Me.TxtGuestAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGuestAdd.Name = "TxtGuestAdd"
        Me.TxtGuestAdd.Size = New System.Drawing.Size(265, 27)
        Me.TxtGuestAdd.TabIndex = 5
        '
        'TxtGuestPhoneNo
        '
        Me.TxtGuestPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtGuestPhoneNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TxtGuestPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGuestPhoneNo.Location = New System.Drawing.Point(121, 278)
        Me.TxtGuestPhoneNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGuestPhoneNo.Name = "TxtGuestPhoneNo"
        Me.TxtGuestPhoneNo.Size = New System.Drawing.Size(263, 27)
        Me.TxtGuestPhoneNo.TabIndex = 6
        '
        'FrmNewGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 599)
        Me.Controls.Add(Me.TxtGuestPhoneNo)
        Me.Controls.Add(Me.TxtGuestAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.TxtGuestName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Guest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents BtnConfirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGuestAdd As System.Windows.Forms.TextBox
    Friend WithEvents TxtGuestPhoneNo As System.Windows.Forms.TextBox
End Class
