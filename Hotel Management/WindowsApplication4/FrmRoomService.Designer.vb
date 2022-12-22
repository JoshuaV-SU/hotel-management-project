<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoomService
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
        Me.DgvServices = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvInHotel = New System.Windows.Forms.DataGridView()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvServices
        '
        Me.DgvServices.AllowUserToAddRows = False
        Me.DgvServices.AllowUserToDeleteRows = False
        Me.DgvServices.AllowUserToResizeColumns = False
        Me.DgvServices.AllowUserToResizeRows = False
        Me.DgvServices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServices.Location = New System.Drawing.Point(39, 85)
        Me.DgvServices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvServices.MultiSelect = False
        Me.DgvServices.Name = "DgvServices"
        Me.DgvServices.ReadOnly = True
        Me.DgvServices.RowHeadersVisible = False
        Me.DgvServices.RowHeadersWidth = 51
        Me.DgvServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvServices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvServices.Size = New System.Drawing.Size(287, 362)
        Me.DgvServices.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Services"
        '
        'DgvInHotel
        '
        Me.DgvInHotel.AllowUserToAddRows = False
        Me.DgvInHotel.AllowUserToDeleteRows = False
        Me.DgvInHotel.AllowUserToResizeColumns = False
        Me.DgvInHotel.AllowUserToResizeRows = False
        Me.DgvInHotel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvInHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvInHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInHotel.Location = New System.Drawing.Point(580, 85)
        Me.DgvInHotel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvInHotel.MultiSelect = False
        Me.DgvInHotel.Name = "DgvInHotel"
        Me.DgvInHotel.ReadOnly = True
        Me.DgvInHotel.RowHeadersVisible = False
        Me.DgvInHotel.RowHeadersWidth = 51
        Me.DgvInHotel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvInHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvInHotel.Size = New System.Drawing.Size(323, 362)
        Me.DgvInHotel.TabIndex = 2
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnConfirm.BackColor = System.Drawing.Color.Black
        Me.BtnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(675, 469)
        Me.BtnConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(228, 57)
        Me.BtnConfirm.TabIndex = 4
        Me.BtnConfirm.Text = "CONFIRM"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(575, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room"
        '
        'FrmRoomService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(945, 552)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.DgvInHotel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvServices)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRoomService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Service"
        CType(Me.DgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInHotel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvServices As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvInHotel As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConfirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
End Class
