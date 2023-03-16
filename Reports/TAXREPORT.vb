Public Class TAXREPORT
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMD_EXPORT As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents SSGRID As AxFPSpreadADO.AxfpSpread
    Friend WithEvents chk_vat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_stax As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TAXREPORT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SSGRID = New AxFPSpreadADO.AxfpSpread()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMD_EXPORT = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.chk_vat = New System.Windows.Forms.CheckBox()
        Me.chk_stax = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vat And Service Tax Combined Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SSGRID)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 352)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'SSGRID
        '
        Me.SSGRID.DataSource = Nothing
        Me.SSGRID.Location = New System.Drawing.Point(8, 10)
        Me.SSGRID.Name = "SSGRID"
        Me.SSGRID.OcxState = CType(resources.GetObject("SSGRID.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID.Size = New System.Drawing.Size(631, 336)
        Me.SSGRID.TabIndex = 442
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(221, 534)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(563, 56)
        Me.GroupBox3.TabIndex = 397
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(155, 23)
        Me.mskFromDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(310, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "To Date :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(392, 22)
        Me.mskToDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "From Date :"
        '
        'CMD_EXPORT
        '
        Me.CMD_EXPORT.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_EXPORT.BackgroundImage = Global.SmartPos.My.Resources.Resources.excel
        Me.CMD_EXPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMD_EXPORT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CMD_EXPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_EXPORT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_EXPORT.ForeColor = System.Drawing.Color.Black
        Me.CMD_EXPORT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_EXPORT.Location = New System.Drawing.Point(6, 91)
        Me.CMD_EXPORT.Name = "CMD_EXPORT"
        Me.CMD_EXPORT.Size = New System.Drawing.Size(130, 50)
        Me.CMD_EXPORT.TabIndex = 438
        Me.CMD_EXPORT.Text = "GETDETAILS"
        Me.CMD_EXPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_EXPORT.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdexit.BackgroundImage = Global.SmartPos.My.Resources.Resources._Exit
        Me.cmdexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexit.Location = New System.Drawing.Point(6, 155)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(130, 50)
        Me.cmdexit.TabIndex = 437
        Me.cmdexit.Text = "Exit[F11]"
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.CmdClear.BackgroundImage = Global.SmartPos.My.Resources.Resources.Clear
        Me.CmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.Black
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.Location = New System.Drawing.Point(6, 30)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(130, 50)
        Me.CmdClear.TabIndex = 396
        Me.CmdClear.Text = "Clear[F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = False
        '
        'chk_vat
        '
        Me.chk_vat.BackColor = System.Drawing.Color.Transparent
        Me.chk_vat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_vat.ForeColor = System.Drawing.Color.Black
        Me.chk_vat.Location = New System.Drawing.Point(16, 8)
        Me.chk_vat.Name = "chk_vat"
        Me.chk_vat.Size = New System.Drawing.Size(104, 24)
        Me.chk_vat.TabIndex = 399
        Me.chk_vat.Text = "VAT"
        Me.chk_vat.UseVisualStyleBackColor = False
        '
        'chk_stax
        '
        Me.chk_stax.BackColor = System.Drawing.Color.Transparent
        Me.chk_stax.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_stax.ForeColor = System.Drawing.Color.Black
        Me.chk_stax.Location = New System.Drawing.Point(125, 12)
        Me.chk_stax.Name = "chk_stax"
        Me.chk_stax.Size = New System.Drawing.Size(141, 24)
        Me.chk_stax.TabIndex = 400
        Me.chk_stax.Text = "SERVICE TAX"
        Me.chk_stax.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chk_vat)
        Me.GroupBox2.Controls.Add(Me.chk_stax)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 490)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 40)
        Me.GroupBox2.TabIndex = 401
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CMD_EXPORT)
        Me.GroupBox4.Location = New System.Drawing.Point(856, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 236)
        Me.GroupBox4.TabIndex = 439
        Me.GroupBox4.TabStop = False
        '
        'TAXREPORT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SmartPos.My.Resources.Resources._111in1024res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1016, 732)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TAXREPORT"
        Me.Text = "TAXREPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim VCONN As New GlobalClass
    Dim gconnection As New GlobalClass
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        SSGRID.ClearRange(1, 1, -1, -1, False)
    End Sub

    Private Sub CMD_EXPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_EXPORT.Click
        Dim I, J, K As Integer
        Dim TaxPerc, TaxCF, TaxAmt, TotalAmt As Double
        'ISNULL(SUM(TAXAMOUNT),0)AS VAT,ISNULL(SUM(PACKAMOUNT),0)AS STAX FROM gpcROOMSUBS WHERE BILLDATE BETWEEN '" & Format(CDate(Me.mskFromDate.Value), "dd-MMM-yyyy") & "' AND '" & Format(CDate(Me.mskToDate.Value), "dd-MMM-yyyy") & "'"
        'SQLSTRING = "EXEC GRPSUM '" & Format(CDate(Me.mskFromDate.Value), "dd-MMM-yyyy") & "','" & Format(CDate(Me.mskToDate.Value), "dd-MMM-yyyy") & "'"
        'vconn.ExcuteStoreProcedure(SQLSTRING)
        'SQLSTRING = "SELECT GROUPCODE,GROUPDESC,ISNULL(TAXPERC,0)AS TAXPERC,ISNULL(PACKPERCENT,0) AS STAXPERC ,ISNULL(SUM(AMOUNT),0)AS AMOUNT,ISNULL(SUM(TAXAMOUNT),0)AS VAT,ISNULL(SUM(PACKAMOUNT),0)AS STAX FROM gpcROOMSUBS WHERE BILLDATE BETWEEN '" & Format(CDate(Me.mskFromDate.Value), "dd-MMM-yyyy") & "' AND '" & Format(CDate(Me.mskToDate.Value), "dd-MMM-yyyy") & "'"
        SQLSTRING = "SELECT GROUPCODE,GROUPDESC,ISNULL(TAXPERC,0)AS TAXPERC,ISNULL(SUM(AMOUNT),0)AS AMOUNT, "
        If Me.chk_stax.Checked = True Then
            SQLSTRING = SQLSTRING & " ISNULL(SUM(TAXAMOUNT),0)AS STAX FROM GroupWise_Tax WHERE BILLDATE BETWEEN '" & Format(CDate(Me.mskFromDate.Value), "dd-MMM-yyyy") & "' AND '" & Format(CDate(Me.mskToDate.Value), "dd-MMM-yyyy") & "' "
        Else
            SQLSTRING = SQLSTRING & " ISNULL(SUM(TAXAMOUNT),0)AS VAT FROM GroupWise_Tax WHERE BILLDATE BETWEEN '" & Format(CDate(Me.mskFromDate.Value), "dd-MMM-yyyy") & "' AND '" & Format(CDate(Me.mskToDate.Value), "dd-MMM-yyyy") & "' "
        End If

        If Me.chk_stax.Checked = True Then
            SQLSTRING = SQLSTRING & " and type='SERVICE TAX'"
        Else
            SQLSTRING = SQLSTRING & " and type='VAT'"
        End If
        SQLSTRING = SQLSTRING & " GROUP BY GROUPCODE,GROUPDESC,TAXPERC ORDER BY TAXPERC,GROUPDESC "
        VCONN.getDataSet(SQLSTRING, "GROUP")
        SSGRID.ClearRange(1, 1, -1, -1, False)
        If gdataset.Tables("GROUP").Rows.Count > 0 Then
            With SSGRID
                .Row = 1
                .Col = 1
                .Text = "TAX SUMMARY FOR " & Format(mskFromDate.Value, "dd-MM-yyyy") & " AND " & Format(mskToDate.Value, "dd-MM-yyyy") & ""
                For K = 0 To gdataset.Tables("GROUP").Columns.Count - 1
                    .Row = 2
                    .Col = K + 1
                    .Text = gdataset.Tables("GROUP").Columns(K).ColumnName
                Next
                '.Row = 1
                '.Col = 1
                '.Text = "ITEMCODE"
                '.Col = 2
                '.Text = "ITEMDESC"
                '.Col = 3
                '.Text = "ITEMTYPE"
                '.Col = 4
                '.Text = "GROUPCODE"
                '.Col = 5
                '.Text = "GROUPDESC"
                '.Col = 6
                '.Text = "QTY"
                '.Col = 7
                '.Text = "RATE"
                '.Col = 8
                '.Text = "UOM"
                '.Col = 9
                '.Text = "TAXAMOUNT"
                '.Col = 10
                '.Text = "SCHARGE"
                '.Col = 11
                '.Text = "PACKAMOUNT"
                '.Col = 12
                '.Text = "AMOUNT"
                '.Col = 13
                '.Text = "AMT"
                TaxPerc = gdataset.Tables("GROUP").Rows(0).Item(2)
                For I = 0 To gdataset.Tables("GROUP").Rows.Count - 1
                    'If I <> 0 Then
                    '    If gdataset.Tables("GROUP").Rows(I - 1).Item(2) <> TaxPerc Then
                    '        .Row = I + 4
                    '    Else
                    '        .Row = I + 3
                    '    End If
                    'Else
                    '    .Row = I + 3
                    'End If
                    .Row = I + 3
                    'If gdataset.Tables("GROUP").Rows(I).Item(2) <> TaxPerc Then
                    '    '.Row = I + 3
                    '    .Col = 5
                    '    .Text = TotalAmt
                    '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    '    .Col = 6
                    '    .Text = TaxAmt
                    '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    '    .Col = 7
                    '    .Text = TaxCF
                    '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    '    TotalAmt = 0
                    '    TaxAmt = 0
                    '    TaxCF = 0
                    '    TaxPerc = gdataset.Tables("GROUP").Rows(I).Item(2)
                    '    .Row = I + 4
                    'End If

                    For J = 0 To gdataset.Tables("GROUP").Columns.Count - 1
                        .Col = J + 1
                        If J < 2 Then
                            .Text = gdataset.Tables("GROUP").Rows(I).Item(J)
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                        Else
                            .Text = gdataset.Tables("GROUP").Rows(I).Item(J)
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                        End If

                        'If J <= 9 Then
                        '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                        'Else
                        '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                        'End If
                    Next
                    'TotalAmt = TotalAmt + gdataset.Tables("GROUP").Rows(I).Item(4)
                    'TaxAmt = TaxAmt + gdataset.Tables("GROUP").Rows(I).Item(5)
                    'TaxCF = TaxCF + gdataset.Tables("GROUP").Rows(I).Item(6)
                Next
                '.Row = I + 3
                '.Col = 5
                '.Text = TotalAmt
                '.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                '.Col = 6
                '.Text = TaxAmt
                '.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                '.Col = 7
                '.Text = TaxCF
                '.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                'TotalAmt = 0
                'TaxAmt = 0
                'TaxCF = 0
            End With
            Me.SSGRID.Visible = True
        End If
        Call ExportTo(SSGRID)
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

                            ' L = L - 5
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
    Private Sub TAXREPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Call Resize_Form()


        Me.mskFromDate.Value = DateTime.Now()
        Me.mskToDate.Value = DateTime.Now()
        Me.chk_vat.Checked = True
        If gUserCategory <> "S" Then
            Call GetRights()
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
        'Me.CmdPrint.Enabled = False
        'Me.CMDVIEW.Enabled = False
        Me.CMD_EXPORT.Enabled = False
        'Me.AUTHORISE.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    'Me.CmdAdd.Enabled = True
                    'Me.CmdPrint.Enabled = True
                    'Me.CMDVIEW.Enabled = True
                    Me.CMD_EXPORT.Enabled = True

                    Exit Sub
                End If

                If Right(x) = "V" Then
                    'Me.CMDVIEW.Enabled = True
                    Me.CMD_EXPORT.Enabled = True
                End If
                If Right(x) = "P" Then
                    'Me.CmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub chk_vat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_vat.CheckedChanged
        If Me.chk_vat.Checked = True Then
            Me.chk_stax.Checked = False
        End If
    End Sub

    Private Sub chk_stax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_stax.CheckedChanged
        If Me.chk_stax.Checked = True Then
            Me.chk_vat.Checked = False
        End If
    End Sub
End Class
