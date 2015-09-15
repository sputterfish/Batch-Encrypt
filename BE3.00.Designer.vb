<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtEncrypted As System.Windows.Forms.TextBox
	Public WithEvents txtBatch As System.Windows.Forms.TextBox
	Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdHelp As System.Windows.Forms.Button
	Public WithEvents cmdCopy As System.Windows.Forms.Button
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents cmdEncrypt As System.Windows.Forms.Button
	Public WithEvents txtDefs As System.Windows.Forms.TextBox
	Public WithEvents cmdgenkey As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEncrypted = New System.Windows.Forms.TextBox()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdEncrypt = New System.Windows.Forms.Button()
        Me.txtDefs = New System.Windows.Forms.TextBox()
        Me.cmdgenkey = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEncrypted
        '
        Me.txtEncrypted.AcceptsReturn = True
        Me.txtEncrypted.BackColor = System.Drawing.SystemColors.Window
        Me.txtEncrypted.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEncrypted.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncrypted.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEncrypted.Location = New System.Drawing.Point(0, 168)
        Me.txtEncrypted.MaxLength = 0
        Me.txtEncrypted.Multiline = True
        Me.txtEncrypted.Name = "txtEncrypted"
        Me.txtEncrypted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEncrypted.Size = New System.Drawing.Size(353, 91)
        Me.txtEncrypted.TabIndex = 9
        Me.txtEncrypted.Text = "[Encrypted Code]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBatch
        '
        Me.txtBatch.AcceptsReturn = True
        Me.txtBatch.BackColor = System.Drawing.SystemColors.Window
        Me.txtBatch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBatch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBatch.Location = New System.Drawing.Point(0, 88)
        Me.txtBatch.MaxLength = 0
        Me.txtBatch.Multiline = True
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBatch.Size = New System.Drawing.Size(257, 73)
        Me.txtBatch.TabIndex = 8
        Me.txtBatch.Text = "[Paste Code Here]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(262, 132)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(89, 17)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHelp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHelp.Location = New System.Drawing.Point(262, 108)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdHelp.Size = New System.Drawing.Size(89, 17)
        Me.cmdHelp.TabIndex = 5
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdCopy
        '
        Me.cmdCopy.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCopy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCopy.Location = New System.Drawing.Point(262, 84)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCopy.Size = New System.Drawing.Size(89, 17)
        Me.cmdCopy.TabIndex = 4
        Me.cmdCopy.Text = "Copy Code"
        Me.cmdCopy.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(262, 60)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(89, 17)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear Code"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEncrypt.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEncrypt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEncrypt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEncrypt.Location = New System.Drawing.Point(262, 36)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEncrypt.Size = New System.Drawing.Size(89, 17)
        Me.cmdEncrypt.TabIndex = 2
        Me.cmdEncrypt.Text = "Encrypt .bat"
        Me.cmdEncrypt.UseVisualStyleBackColor = False
        '
        'txtDefs
        '
        Me.txtDefs.AcceptsReturn = True
        Me.txtDefs.BackColor = System.Drawing.SystemColors.Window
        Me.txtDefs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDefs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDefs.Location = New System.Drawing.Point(0, 0)
        Me.txtDefs.MaxLength = 0
        Me.txtDefs.Multiline = True
        Me.txtDefs.Name = "txtDefs"
        Me.txtDefs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDefs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDefs.Size = New System.Drawing.Size(257, 81)
        Me.txtDefs.TabIndex = 1
        Me.txtDefs.Text = "[Definitions]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdgenkey
        '
        Me.cmdgenkey.BackColor = System.Drawing.SystemColors.Control
        Me.cmdgenkey.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdgenkey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgenkey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdgenkey.Location = New System.Drawing.Point(262, 12)
        Me.cmdgenkey.Name = "cmdgenkey"
        Me.cmdgenkey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdgenkey.Size = New System.Drawing.Size(89, 17)
        Me.cmdgenkey.TabIndex = 0
        Me.cmdgenkey.Text = "Generate Defs."
        Me.cmdgenkey.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(353, 259)
        Me.Controls.Add(Me.txtEncrypted)
        Me.Controls.Add(Me.txtBatch)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdEncrypt)
        Me.Controls.Add(Me.txtDefs)
        Me.Controls.Add(Me.cmdgenkey)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(365, 322)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Batch Encrypt - Version 3.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class