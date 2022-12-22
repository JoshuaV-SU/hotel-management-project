<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPayment
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
        Me.DgvBills = New System.Windows.Forms.DataGridView()
        Me.TxtGuestID = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPay = New System.Windows.Forms.Button()
        CType(Me.DgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBills
        '
        Me.DgvBills.AllowUserToAddRows = False
        Me.DgvBills.AllowUserToDeleteRows = False
        Me.DgvBills.AllowUserToResizeColumns = False
        Me.DgvBills.AllowUserToResizeRows = False
        Me.DgvBills.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBills.Location = New System.Drawing.Point(473, 34)
        Me.DgvBills.MultiSelect = False
        Me.DgvBills.Name = "DgvBills"
        Me.DgvBills.ReadOnly = True
        Me.DgvBills.RowHeadersVisible = False
        Me.DgvBills.RowHeadersWidth = 51
        Me.DgvBills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBills.Size = New System.Drawing.Size(455, 513)
        Me.DgvBills.TabIndex = 0
        '
        'TxtGuestID
        '
        Me.TxtGuestID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtGuestID.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TxtGuestID.Enabled = False
        Me.TxtGuestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.TxtGuestID.Location = New System.Drawing.Point(215, 148)
        Me.TxtGuestID.Name = "TxtGuestID"
        Me.TxtGuestID.Size = New System.Drawing.Size(171, 39)
        Me.TxtGuestID.TabIndex = 1
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtTotal.Location = New System.Drawing.Point(215, 264)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(171, 25)
        Me.TxtTotal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Guest ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total:"
        '
        'BtnPay
        '
        Me.BtnPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPay.BackColor = System.Drawing.Color.Black
        Me.BtnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.BtnPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnPay.Location = New System.Drawing.Point(215, 355)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(171, 57)
        Me.BtnPay.TabIndex = 5
        Me.BtnPay.Text = "PAY"
        Me.BtnPay.UseVisualStyleBackColor = False
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 599)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtGuestID)
        Me.Controls.Add(Me.DgvBills)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPayment"
        Me.Text = "Payment"
        CType(Me.DgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvBills As System.Windows.Forms.DataGridView
    Friend WithEvents TxtGuestID As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnPay As System.Windows.Forms.Button
End Class
