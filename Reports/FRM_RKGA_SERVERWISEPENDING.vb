Imports System.Data.SqlClient
Public Class FRM_RKGA_SERVERWISEPENDING
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_Servercode As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_ServerCode As System.Windows.Forms.CheckedListBox
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexport As System.Windows.Forms.Button
    Friend WithEvents cmdreport As System.Windows.Forms.Button
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pending As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_miss As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RKGA_SERVERWISEPENDING))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chk_Servercode = New System.Windows.Forms.CheckBox()
        Me.Chklist_ServerCode = New System.Windows.Forms.CheckedListBox()
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox()
        Me.lbl_Wait = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdreport = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.cmdexport = New System.Windows.Forms.Button()
        Me.CmdPrint = New System.Windows.Forms.Button()
        Me.CmdView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox()
        Me.chk_pending = New System.Windows.Forms.CheckBox()
        Me.chk_miss = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(305, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 24)
        Me.Label7.TabIndex = 423
        Me.Label7.Text = "SERVER NAME :"
        '
        'Chk_Servercode
        '
        Me.Chk_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Servercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Servercode.Location = New System.Drawing.Point(305, 10)
        Me.Chk_Servercode.Name = "Chk_Servercode"
        Me.Chk_Servercode.Size = New System.Drawing.Size(174, 24)
        Me.Chk_Servercode.TabIndex = 422
        Me.Chk_Servercode.Text = "SELECT ALL"
        Me.Chk_Servercode.UseVisualStyleBackColor = False
        '
        'Chklist_ServerCode
        '
        Me.Chklist_ServerCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_ServerCode.Location = New System.Drawing.Point(305, 58)
        Me.Chklist_ServerCode.Name = "Chklist_ServerCode"
        Me.Chklist_ServerCode.Size = New System.Drawing.Size(264, 372)
        Me.Chklist_ServerCode.TabIndex = 421
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(186, 551)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(16, 64)
        Me.grp_SalebillChecklist.TabIndex = 427
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 18)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(214, 575)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 64)
        Me.GroupBox3.TabIndex = 424
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd/MM/yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(137, 24)
        Me.mskFromDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 21)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TO DATE :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd/MM/yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(368, 24)
        Me.mskToDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 21)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FROM DATE :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmdreport)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.cmdexport)
        Me.GroupBox4.Location = New System.Drawing.Point(854, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(140, 356)
        Me.GroupBox4.TabIndex = 430
        Me.GroupBox4.TabStop = False
        '
        'cmdreport
        '
        Me.cmdreport.BackColor = System.Drawing.Color.Transparent
        Me.cmdreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdreport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreport.ForeColor = System.Drawing.Color.Black
        Me.cmdreport.Image = Global.SmartPos.My.Resources.Resources.view
        Me.cmdreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdreport.Location = New System.Drawing.Point(4, 115)
        Me.cmdreport.Name = "cmdreport"
        Me.cmdreport.Size = New System.Drawing.Size(131, 68)
        Me.cmdreport.TabIndex = 435
        Me.cmdreport.Text = "Report  [F9]"
        Me.cmdreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdreport.UseVisualStyleBackColor = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.Black
        Me.CmdClear.Image = Global.SmartPos.My.Resources.Resources.Clear
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(4, 37)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(131, 68)
        Me.CmdClear.TabIndex = 433
        Me.CmdClear.Text = "Clear [F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Image = Global.SmartPos.My.Resources.Resources._Exit
        Me.cmdexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexit.Location = New System.Drawing.Point(4, 271)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(131, 68)
        Me.cmdexit.TabIndex = 432
        Me.cmdexit.Text = "Exit[F11]"
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdexport
        '
        Me.cmdexport.BackColor = System.Drawing.Color.Transparent
        Me.cmdexport.BackgroundImage = Global.SmartPos.My.Resources.Resources.excel
        Me.cmdexport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdexport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.ForeColor = System.Drawing.Color.Black
        Me.cmdexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexport.Location = New System.Drawing.Point(4, 193)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.Size = New System.Drawing.Size(131, 68)
        Me.cmdexport.TabIndex = 434
        Me.cmdexport.Text = " Export [F12]"
        Me.cmdexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdexport.UseVisualStyleBackColor = False
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(80, 312)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 431
        Me.CmdPrint.Text = " Print [F8]"
        Me.CmdPrint.UseVisualStyleBackColor = False
        Me.CmdPrint.Visible = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(8, 464)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(32, 32)
        Me.CmdView.TabIndex = 430
        Me.CmdView.Text = "View [F9]"
        Me.CmdView.UseVisualStyleBackColor = False
        Me.CmdView.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 15)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "BEARER WISE  PENDING ORDERS"
        '
        'Timer1
        '
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(68, 58)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(228, 372)
        Me.Chklist_POSLocation.TabIndex = 435
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(68, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 24)
        Me.Label6.TabIndex = 436
        Me.Label6.Text = "POS LOCATION :"
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(68, 10)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(104, 24)
        Me.Chk_SelectAllPos.TabIndex = 437
        Me.Chk_SelectAllPos.Text = "SELECT ALL "
        Me.Chk_SelectAllPos.UseVisualStyleBackColor = False
        '
        'chk_pending
        '
        Me.chk_pending.BackColor = System.Drawing.Color.Transparent
        Me.chk_pending.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pending.Location = New System.Drawing.Point(229, 436)
        Me.chk_pending.Name = "chk_pending"
        Me.chk_pending.Size = New System.Drawing.Size(122, 24)
        Me.chk_pending.TabIndex = 438
        Me.chk_pending.Text = "PENDING KOT"
        Me.chk_pending.UseVisualStyleBackColor = False
        '
        'chk_miss
        '
        Me.chk_miss.BackColor = System.Drawing.Color.Transparent
        Me.chk_miss.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_miss.Location = New System.Drawing.Point(421, 439)
        Me.chk_miss.Name = "chk_miss"
        Me.chk_miss.Size = New System.Drawing.Size(132, 24)
        Me.chk_miss.TabIndex = 439
        Me.chk_miss.Text = "MISSING KOT"
        Me.chk_miss.UseVisualStyleBackColor = False
        Me.chk_miss.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 689)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(424, 16)
        Me.Label5.TabIndex = 431
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_miss)
        Me.GroupBox1.Controls.Add(Me.chk_pending)
        Me.GroupBox1.Controls.Add(Me.Chklist_ServerCode)
        Me.GroupBox1.Controls.Add(Me.Chk_Servercode)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllPos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Chklist_POSLocation)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 466)
        Me.GroupBox1.TabIndex = 440
        Me.GroupBox1.TabStop = False
        '
        'FRM_RKGA_SERVERWISEPENDING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.SmartPos.My.Resources.Resources._111in1024res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 732)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FRM_RKGA_SERVERWISEPENDING"
        Me.Text = "PENDING BILL REGISTER"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.grp_SalebillChecklist.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim ssql As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Dim gconnection As New GlobalClass
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillServerCode()
        Dim i As Integer
        Chklist_ServerCode.Items.Clear()
        ssql = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME FROM SERVERMASTER ORDER BY SERVERCODE"
        vconn.getDataSet(ssql, "servermaster")
        If gdataset.Tables("servermaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("servermaster").Rows.Count - 1
                With gdataset.Tables("servermaster").Rows(i)
                    Chklist_ServerCode.Items.Add(Trim(.Item("SERVERNAME") & "==>" & .Item("SERVERCODE")))
                End With
            Next
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        'Me.CmdAdd.Enabled = False
        Me.CmdPrint.Enabled = False
        Me.CMDVIEW.Enabled = False
        Me.cmdexport.Enabled = False
        'Me.AUTHORISE.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    'Me.CmdAdd.Enabled = True
                    Me.CmdPrint.Enabled = True
                    Me.CMDVIEW.Enabled = True
                    Me.cmdexport.Enabled = True

                    Exit Sub
                End If

                If Right(x) = "V" Then
                    Me.CMDVIEW.Enabled = True
                    Me.cmdexport.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.CmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 732
        K = 1016
        Me.ResizeRedraw = True

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Width = U
        Me.Height = T


        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox4" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            L = L + 25
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub
    Private Sub rptPendingbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Resize_Form()

        If UCase(Mid(gCompanyname, 1, 4)) = "CATH" Then
            chk_miss.Visible = False
        End If
        If Mid(gCompName, 1, 5) = "MCEME" Or Mid(gCompName, 1, 4) = "ASCC" Then
            Label1.Text = "BEARER WISE ORDER TICKET PENDING"
            chk_pending.Text = "PENDING ORDER TICKET"
            chk_miss.Text = "MISSING ORDER TICKET"
        End If
        Call FillServerCode()
        Call FillPOSLocation()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        'opt_Details.Checked = True
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If

    End Sub
    Private Sub FillPOSLocation()
        Dim i As Integer
        chklist_POSlocation.Items.Clear()
        sqlstring = "SELECT DISTINCT poscode,posdesc FROM posmaster WHERE ISNULL(Freeze,'')<>'Y' "
        vconn.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
                End With
            Next i
        End If


        If Mid(gCompName, 1, 5) = "MCEME" Or Mid(gCompName, 1, 4) = "ASCC" Then
            If gUserCategory <> "S" Then
                Chklist_POSLocation.Items.Clear()
                SQLSTRING = "SELECT DISTINCT U.poscode,P.posdesc FROM POS_USERCONTROL U,posmaster P WHERE ISNULL(P.Freeze,'')<>'Y' AND P.POSCODE=U.POSCODE AND U.USERNAME='" & gUsername & "'"
                vconn.getDataSet(SQLSTRING, "POS")
                If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                        With gdataset.Tables("POS").Rows(i)
                            Chklist_POSLocation.Items.Add(Trim(.Item("POSdesc")))
                        End With
                    Next i
                End If
            End If
        End If


        Chklist_POSLocation.Sorted = True
    End Sub



    Private Sub mskFromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub

    '''Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '''    Chklist_ServerCode.Items.Clear()
    '''    grp_SalebillChecklist.Top = 1000
    '''    Chk_Servercode.Checked = False
    '''    ''opt_Details.Checked = True
    '''    Call FillServerCode()
    '''End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call ViewPendingBillRegister()
        End If
    End Sub

    Private Sub Chklist_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_ServerCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskFromDate.Focus()
        End If
    End Sub
    Private Sub ViewPendingBillRegister()
        Dim i As Integer
        Dim sqlstring As String
        Dim ServerCode() As String
        Dim strServer As String

        ' If Val(Chklist_ServerCode.CheckedItems.Count) = 1 Then
        'strServer = Chklist_ServerCode.CheckedItems(0)
        'Else
        For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
            ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
            strServer = strServer & " '" & ServerCode(0) & "', "
        Next
        'End If
        strServer = Mid(strServer, 1, Len(strServer) - 2)

        'If opt_Details.Checked = True Then
        '''****************************************************** PENDING BILL [DETAILS] *******************************************'''

        sqlstring = " SELECT * FROM PENDINGKOTREGISTER"
        sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " and  SERVERNAME IN (" & strServer & ")"
        sqlstring = sqlstring & " ORDER BY SERVERNAME,KOTDETAILS "

        Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        Dim ObjPendingKOTRegisterReport As New PendingKOTRegisterReport
        ObjPendingKOTRegisterReport.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
        '''''ElseIf opt_summary.Checked = True Then
        '''''    '''****************************************************** PENDING BILL [SUMMARY] *******************************************'''
        '''''    sqlstring = " SELECT * FROM PENDINGKOTREGISTER"
        '''''    sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        '''''    sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        '''''    sqlstring = sqlstring & " ORDER BY KOTDETAILS,KOTDATE "
        '''''    Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        '''''    Dim ObjPendingbillsummary As New rptPendingbillsummary
        '''''    ObjPendingbillsummary.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
        '''''End If

    End Sub

    ''Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    ''''If Chklist_ServerCode.CheckedItems.Count = 0 Then
    ''    ''''    MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''    ''''    Exit Sub
    ''    ''''End If
    ''    ''''Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
    ''    ''''If chkdatevalidate = False Then Exit Sub
    ''    ''''gPrint = False
    ''    ''''grp_SalebillChecklist.Top = 528
    ''    ''''grp_SalebillChecklist.Left = 168
    ''    ''''Me.ProgressBar1.Value = 2
    ''    ''''Me.Timer1.Interval = 100
    ''    ''''Me.Timer1.Enabled = True
    ''End Sub

    Private Sub Chk_Servercode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Servercode.CheckedChanged
        Dim i As Integer
        If Chk_Servercode.Checked = True Then
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub rptPendingbill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, True)
            Next i
            Chk_Servercode.Checked = True
            Me.mskFromDate.Focus()
            Exit Sub
            'ElseIf e.KeyCode = Keys.F8 Then
            '    Call CmdPrint_Click(sender, e)
            '    Exit Sub
            'ElseIf e.KeyCode = Keys.F9 Then
            '    Call CmdView_Click(sender, e)
            '    Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            If CmdPrint.Enabled = True Then
                Call CmdPrint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call cmdreport_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If CmdView.Enabled = True Then
                Call cmdexport_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.F Then
            Me.mskFromDate.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            Me.mskToDate.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Search_rpt = InputBox("ENTER TEXT", "SEARCH")
            Call Search_Item(Chklist_ServerCode, Search_rpt)
        End If
    End Sub

    '''''Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '''''    If Chklist_ServerCode.CheckedItems.Count = 0 Then
    '''''        MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '''''        Exit Sub
    '''''    End If
    '''''    Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
    '''''    If chkdatevalidate = False Then Exit Sub
    '''''    gPrint = True
    '''''    grp_SalebillChecklist.Top = 528
    '''''    grp_SalebillChecklist.Left = 168
    '''''    Me.ProgressBar1.Value = 2
    '''''    Me.Timer1.Interval = 100
    '''''    Me.Timer1.Enabled = True
    '''''End Sub



    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If Chklist_ServerCode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 528
        grp_SalebillChecklist.Left = 168
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        Dim i As Integer
        Dim sqlstring, SSQL As String
        Dim Viewer As New ReportViwer
        Dim ServerCode() As String
        Dim strServer As String
        Dim r As New CrptPendingKOTRegister
        Dim POSdesc(), MemberCode() As String
        Dim SQLSTRING2 As String
        sqlstring = " SELECT * FROM PENDINGKOTREGISTER WHERE"
        sqlstring = sqlstring & " CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        If Chklist_ServerCode.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND SERVERNAME IN ("
            For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                'sqlstring = sqlstring & servercode(0) & ", "
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        sqlstring = sqlstring & "ORDER BY SERVERCODE,KOTDATE"

        'End If
        'strServer = Mid(strServer, 1, Len(strServer) - 2)
        ''//
        'sqlstring = " SELECT * FROM PendingKOTRegister WHERE"
        'sqlstring = sqlstring & " BILLDATE BETWEEN '"
        'sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND '" & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        'If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " WHERE POSDESC IN ("
        '    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '        sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(i) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        'If chklist_Membername.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " AND SCODE IN ("
        '    For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '        MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
        '        sqlstring = sqlstring & "'" & MemberCode(0) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        Call Viewer.GetDetails(sqlstring, "PendingKOTRegister", r)
        Viewer.TableName = "PendingKOTRegister"


        Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ1 = r.ReportDefinition.ReportObjects("Text15")
        TXTOBJ1.Text = gCompanyname

        Dim TXTOBJ16 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ16 = r.ReportDefinition.ReportObjects("Text16")
        TXTOBJ16.Text = "Period From  " & Format(mskFromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskToDate.Value, "dd/MM/yyyy") & ""

        Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ5 = r.ReportDefinition.ReportObjects("Text1")
        TXTOBJ5.Text = "UserName : " & gUsername

        'Dim TXTOBJ9 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ9 = r.ReportDefinition.ReportObjects("Text3")
        'TXTOBJ9.Text = "Accounting Period : " & Format(strFinancialYearStart, "dd-MM-yyyy") & " - " & Format(strFinancialYearEnd, "dd-MM-yyyy")


        Viewer.Show()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Chklist_ServerCode.Items.Clear()
        Chklist_POSLocation.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_Servercode.Checked = False
        Chk_SelectAllPos.Checked = False

        ''opt_Details.Checked = True
        Call FillServerCode()
        Call FillPOSLocation()

    End Sub

    Private Sub cmdexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexport.Click
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Chklist_ServerCode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        If Me.chk_pending.Checked = True Then
            Call pendingkotEXCEL()
        ElseIf chk_miss.Checked = True Then
            Call missing_kotEXCEL()
        Else
            MessageBox.Show("NO RECORDS TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub pendingkotEXCEL()
        Dim i As Integer
        Dim exp As New exportexcel
        Dim sqlstring, SSQL As String
        Dim ServerCode() As String
        Dim strServer As String
        Dim POSdesc(), MemberCode() As String
        Dim SQLSTRING2 As String
        sqlstring = " SELECT * FROM PENDINGKOTREGISTER WHERE"
        sqlstring = sqlstring & " CAST(CONVERT(varchar(11),ORDERDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        If Chklist_ServerCode.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND SERVERNAME IN ("
            For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                'sqlstring = sqlstring & servercode(0) & ", "
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        sqlstring = sqlstring & "ORDER BY SERVERCODE,ORDERDATE"
        gconnection.getDataSet(sqlstring, "CANCEL")
        If gdataset.Tables("CANCEL").Rows.Count > 0 Then
            exp.Show()
            Call exp.export(sqlstring, "PENDING ORDER " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "   TO   " & Format(mskToDate.Value, "dd-MMM-yyyy"), "")

        Else
            MessageBox.Show("NO RECORDS FOUND", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub missing_kotEXCEL()
        Dim i As Integer
        Dim exp As New exportexcel
        Dim ServerCode() As String
        Dim strServer As String
        Dim POSdesc(), MemberCode() As String
        Dim SQLSTRING2 As String
        Dim sqlstring, SSQL As String
        sqlstring = "exec missing_kot '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "',' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        vconn.ExcuteStoreProcedure(sqlstring)
        sqlstring = "SELECT * FROM VIEW_MISSKOT order by ORDERNO"
        gconnection.getDataSet(sqlstring, "MISSING")
        If gdataset.Tables("MISSING").Rows.Count > 0 Then
            exp.Show()
            Call exp.export(sqlstring, "MISSING - ORDERS " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "   TO   " & Format(mskToDate.Value, "dd-MMM-yyyy"), "")

        Else
            MessageBox.Show("NO RECORDS FOUND", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub cmdreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreport.Click

        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Chklist_ServerCode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        chk_pending.Checked = True

        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub

        If Me.chk_pending.Checked = True Then
            Call pendingkot()
        Else
            Dim i As Integer
            Dim Viewer As New ReportViwer
            Dim ServerCode() As String
            Dim strServer As String
            'Dim r As New CrptPendingKOTRegister
            Dim R1 As New MSKTT
            Dim POSdesc(), MemberCode() As String
            Dim SQLSTRING2 As String
            Dim sqlstring, SSQL As String
            ' If Me.CheckBox1.Checked = True Then
            sqlstring = "exec missing_kot '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "',' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
            vconn.ExcuteStoreProcedure(sqlstring)
            sqlstring = "SELECT * FROM VIEW_MISSKOT order by ORDERNO"
            Call Viewer.GetDetails(sqlstring, "VIEW_MISSKOT", R1)
            Viewer.Show()
            ' Exit Sub
            'End If
        End If
    End Sub
    Private Sub pendingkot()
        Dim i As Integer

        Dim sqlstring, SSQL As String
        Dim Viewer As New ReportViwer
        Dim ServerCode() As String
        Dim strServer As String
        Dim r As New CrptWaiterwisePending
        Dim POSdesc(), MemberCode() As String
        Dim SQLSTRING2 As String
        sqlstring = " SELECT * FROM PENDINGKOTREGISTER WHERE"
        sqlstring = sqlstring & " CAST(CONVERT(varchar(11),ORDERDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        If Chklist_ServerCode.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND SERVERNAME IN ("
            For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                'sqlstring = sqlstring & servercode(0) & ", "
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        End If
        sqlstring = sqlstring & "ORDER BY SERVERCODE,ORDERDATE"

        'End If
        'strServer = Mid(strServer, 1, Len(strServer) - 2)
        ''//
        'sqlstring = " SELECT * FROM PendingKOTRegister WHERE"
        'sqlstring = sqlstring & " BILLDATE BETWEEN '"
        'sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND '" & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        'If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " WHERE POSDESC IN ("
        '    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '        sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(i) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        'If chklist_Membername.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " AND SCODE IN ("
        '    For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '        MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
        '        sqlstring = sqlstring & "'" & MemberCode(0) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        Call Viewer.GetDetails(sqlstring, "PendingKOTRegister", r)
        Viewer.TableName = "PendingKOTRegister"


        Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ1 = r.ReportDefinition.ReportObjects("Text15")
        TXTOBJ1.Text = gCompanyname

        Dim TXTOBJ16 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ16 = r.ReportDefinition.ReportObjects("Text16")
        TXTOBJ16.Text = "PERIOD FROM " & Format(mskFromDate.Value, "dd/MM/yyyy") & "  TO " & " " & Format(mskToDate.Value, "dd/MM/yyyy") & ""

        Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
        TXTOBJ5 = r.ReportDefinition.ReportObjects("Text1")
        TXTOBJ5.Text = "UserName : " & gUsername

        'Dim TXTOBJ9 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ9 = r.ReportDefinition.ReportObjects("Text3")
        'TXTOBJ9.Text = "Accounting Period : " & Format(strFinancialYearStart, "dd-MM-yyyy") & " - " & Format(strFinancialYearEnd, "dd-MM-yyyy")


        Viewer.Show()
    End Sub

    Private Sub Timer1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Disposed

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllPos.Checked = True Then
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub chk_pending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pending.CheckedChanged
        If chk_pending.Checked = True Then
            chk_miss.Checked = False
        Else
            chk_miss.Checked = True
        End If
    End Sub

    Private Sub chk_miss_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_miss.CheckedChanged
        If chk_miss.Checked = True Then
            'chk_miss.Checked = False
            chk_pending.Checked = False
        Else
            chk_pending.Checked = True
        End If
    End Sub
End Class
