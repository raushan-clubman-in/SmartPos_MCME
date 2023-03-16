<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TKGA_BILLCLOSE
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtptodate = New System.Windows.Forms.DateTimePicker()
        Me.dtpfromdate = New System.Windows.Forms.DateTimePicker()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.CMD_UNLOCK = New System.Windows.Forms.Button()
        Me.CMD_LOCK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(189, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 15)
        Me.Label16.TabIndex = 437
        Me.Label16.Text = "BILL  CLOSING"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtptodate)
        Me.GroupBox1.Controls.Add(Me.dtpfromdate)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 89)
        Me.GroupBox1.TabIndex = 438
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(298, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 439
        Me.Label2.Text = "TO DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 438
        Me.Label1.Text = "FROM DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtptodate
        '
        Me.dtptodate.Location = New System.Drawing.Point(369, 38)
        Me.dtptodate.Name = "dtptodate"
        Me.dtptodate.Size = New System.Drawing.Size(120, 20)
        Me.dtptodate.TabIndex = 1
        '
        'dtpfromdate
        '
        Me.dtpfromdate.Location = New System.Drawing.Point(104, 38)
        Me.dtpfromdate.Name = "dtpfromdate"
        Me.dtpfromdate.Size = New System.Drawing.Size(129, 20)
        Me.dtpfromdate.TabIndex = 0
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.White
        Me.Cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartPos.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(9, 143)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(131, 56)
        Me.Cmd_Exit.TabIndex = 439
        Me.Cmd_Exit.Text = "Exit "
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'CMD_UNLOCK
        '
        Me.CMD_UNLOCK.BackColor = System.Drawing.Color.White
        Me.CMD_UNLOCK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMD_UNLOCK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_UNLOCK.ForeColor = System.Drawing.Color.Black
        Me.CMD_UNLOCK.Image = Global.SmartPos.My.Resources.Resources.save
        Me.CMD_UNLOCK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_UNLOCK.Location = New System.Drawing.Point(9, 81)
        Me.CMD_UNLOCK.Name = "CMD_UNLOCK"
        Me.CMD_UNLOCK.Size = New System.Drawing.Size(131, 56)
        Me.CMD_UNLOCK.TabIndex = 440
        Me.CMD_UNLOCK.Text = "UnLock"
        Me.CMD_UNLOCK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_UNLOCK.UseVisualStyleBackColor = False
        '
        'CMD_LOCK
        '
        Me.CMD_LOCK.BackColor = System.Drawing.Color.White
        Me.CMD_LOCK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMD_LOCK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_LOCK.ForeColor = System.Drawing.Color.Black
        Me.CMD_LOCK.Image = Global.SmartPos.My.Resources.Resources.save
        Me.CMD_LOCK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_LOCK.Location = New System.Drawing.Point(9, 19)
        Me.CMD_LOCK.Name = "CMD_LOCK"
        Me.CMD_LOCK.Size = New System.Drawing.Size(131, 56)
        Me.CMD_LOCK.TabIndex = 441
        Me.CMD_LOCK.Text = "Lock"
        Me.CMD_LOCK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_LOCK.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CMD_LOCK)
        Me.GroupBox2.Controls.Add(Me.CMD_UNLOCK)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(851, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 210)
        Me.GroupBox2.TabIndex = 442
        Me.GroupBox2.TabStop = False
        '
        'FRM_TKGA_BILLCLOSE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SmartPos.My.Resources.Resources._111in1024res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 732)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 2)
        Me.Name = "FRM_TKGA_BILLCLOSE"
        Me.Text = "FRM_TKGA_BILLCLOSE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtptodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents CMD_UNLOCK As System.Windows.Forms.Button
    Friend WithEvents CMD_LOCK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
