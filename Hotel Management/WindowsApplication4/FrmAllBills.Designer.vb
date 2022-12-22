<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllBills
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
        Me.DgvBills = New System.Windows.Forms.DataGridView()
        CType(Me.DgvBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBills
        '
        Me.DgvBills.AllowUserToAddRows = False
        Me.DgvBills.AllowUserToDeleteRows = False
        Me.DgvBills.AllowUserToResizeColumns = False
        Me.DgvBills.AllowUserToResizeRows = False
        Me.DgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBills.Location = New System.Drawing.Point(0, 0)
        Me.DgvBills.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvBills.Name = "DgvBills"
        Me.DgvBills.RowHeadersVisible = False
        Me.DgvBills.RowHeadersWidth = 51
        Me.DgvBills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBills.ShowCellErrors = False
        Me.DgvBills.ShowCellToolTips = False
        Me.DgvBills.ShowEditingIcon = False
        Me.DgvBills.ShowRowErrors = False
        Me.DgvBills.Size = New System.Drawing.Size(1022, 599)
        Me.DgvBills.TabIndex = 0
        '
        'FrmAllBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 599)
        Me.Controls.Add(Me.DgvBills)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmAllBills"
        Me.Text = "All Transactions"
        CType(Me.DgvBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvBills As System.Windows.Forms.DataGridView
End Class
