Public Class FRM_MKGA_mem_limit_unblock
    Inherits System.Windows.Forms.Form
    Dim ssql As String
    Dim i As Integer
    Friend WithEvents CMD_AUTH As System.Windows.Forms.Button
    Friend WithEvents CMD_BRSE As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Dim gconnection As New GlobalClass
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
    Friend WithEvents cmd_add As System.Windows.Forms.Button
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MSKFROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents MSKTODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmd_exit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_mem_limit_unblock))
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.cmd_add = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MSKFROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.MSKTODATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_exit = New System.Windows.Forms.Button()
        Me.CMD_AUTH = New System.Windows.Forms.Button()
        Me.CMD_BRSE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(261, 204)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(444, 400)
        Me.ssgrid.TabIndex = 0
        '
        'cmd_add
        '
        Me.cmd_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_add.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_add.Image = Global.SmartPos.My.Resources.Resources.save
        Me.cmd_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_add.Location = New System.Drawing.Point(6, 24)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(144, 65)
        Me.cmd_add.TabIndex = 1
        Me.cmd_add.Text = "UPDATE [F7]"
        Me.cmd_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SmartPos.My.Resources.Resources.view
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 65)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "VIEW [F9]"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MSKFROMDATE
        '
        Me.MSKFROMDATE.CustomFormat = "dd-MMM-yyyy"
        Me.MSKFROMDATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSKFROMDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MSKFROMDATE.Location = New System.Drawing.Point(124, 24)
        Me.MSKFROMDATE.Name = "MSKFROMDATE"
        Me.MSKFROMDATE.Size = New System.Drawing.Size(120, 20)
        Me.MSKFROMDATE.TabIndex = 3
        '
        'MSKTODATE
        '
        Me.MSKTODATE.CustomFormat = "dd-MMM-yyyy"
        Me.MSKTODATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSKTODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MSKTODATE.Location = New System.Drawing.Point(360, 24)
        Me.MSKTODATE.Name = "MSKTODATE"
        Me.MSKTODATE.Size = New System.Drawing.Size(120, 20)
        Me.MSKTODATE.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FROM DATE"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TO DATE"
        '
        'Cmd_exit
        '
        Me.Cmd_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_exit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_exit.Image = Global.SmartPos.My.Resources.Resources._Exit
        Me.Cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_exit.Location = New System.Drawing.Point(7, 348)
        Me.Cmd_exit.Name = "Cmd_exit"
        Me.Cmd_exit.Size = New System.Drawing.Size(144, 65)
        Me.Cmd_exit.TabIndex = 7
        Me.Cmd_exit.Text = "EXIT [F11]"
        Me.Cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CMD_AUTH
        '
        Me.CMD_AUTH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMD_AUTH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_AUTH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_AUTH.Location = New System.Drawing.Point(6, 267)
        Me.CMD_AUTH.Name = "CMD_AUTH"
        Me.CMD_AUTH.Size = New System.Drawing.Size(144, 65)
        Me.CMD_AUTH.TabIndex = 8
        Me.CMD_AUTH.Text = "AUTHORIZE"
        '
        'CMD_BRSE
        '
        Me.CMD_BRSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMD_BRSE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_BRSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_BRSE.Location = New System.Drawing.Point(6, 186)
        Me.CMD_BRSE.Name = "CMD_BRSE"
        Me.CMD_BRSE.Size = New System.Drawing.Size(144, 65)
        Me.CMD_BRSE.TabIndex = 9
        Me.CMD_BRSE.Text = "BROWSE"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MEMBER CREDIT LIMIT UNBLOCKING"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MSKFROMDATE)
        Me.GroupBox1.Controls.Add(Me.MSKTODATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 501)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmd_add)
        Me.GroupBox2.Controls.Add(Me.CMD_BRSE)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CMD_AUTH)
        Me.GroupBox2.Controls.Add(Me.Cmd_exit)
        Me.GroupBox2.Location = New System.Drawing.Point(853, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 441)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'FRM_MKGA_mem_limit_unblock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackgroundImage = Global.SmartPos.My.Resources.Resources._111in1024res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 732)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 5)
        Me.Name = "FRM_MKGA_mem_limit_unblock"
        Me.Text = "mem_limit_unblock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add.Click
        Checkdaterangevalidate(MSKFROMDATE.Value, MSKTODATE.Value)
        If chkdatevalidate = False Then Exit Sub
        With ssgrid
            For i = 0 To ssgrid.DataRowCnt - 1
                .Col = 1
                .Row = i + 1
                If Trim(.Text) <> "" Then
                    SQLSTRING = "select mcode,CURENTSTATUS from membermaster where mcode='" & Trim(.Text) & "'"
                    gconnection.getDataSet(SQLSTRING, "curdet")
                    If gdataset.Tables("curdet").Rows.Count > 0 Then
                        SQLSTRING = "select mcode,CURENTSTATUS from membermaster where mcode='" & Trim(.Text) & "'and CURENTSTATUS IN ('LIVE','ACTIVE')"
                        gconnection.getDataSet(SQLSTRING, "curdet")
                        If gdataset.Tables("curdet").Rows.Count > 0 Then
                        Else
                            MsgBox("MEMBERSHIP NO " & Trim(.Text) & " IS NOT ACTIVE", MsgBoxStyle.Exclamation, gCompanyname)
                            Exit Sub
                        End If
                    Else
                        MsgBox("MEMBERSHIP NO " & Trim(.Text) & " DOES NOT EXISET", MsgBoxStyle.Exclamation, gCompanyname)
                        Exit Sub
                    End If
                End If
            Next
        End With
        ssql = "update memberblocking set valid='Y'"
        gconnection.ExcuteStoreProcedure(ssql)
        With ssgrid
            For i = 0 To ssgrid.DataRowCnt - 1
                .Col = 1
                .Row = i + 1
                ssql = "insert into memberblocking(mcode,adduser,adddatetime,valid)"
                ssql = ssql & " values('" & .Text & "','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy") & "','N')"
                gconnection.ExcuteStoreProcedure(ssql)
            Next

        End With
        MsgBox("Transaction Completed Successfuly")
    End Sub

    Private Sub FRM_MKGA_mem_limit_unblock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.F6 Then
        '    Call Cmd_Clear_Click(Cmd_Clear, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F8 Then
        '    If Cmd_Freeze.Enabled = True Then
        '        Call Cmd_Freeze_Click(Cmd_Freeze, e)
        '        Exit Sub
        '    End If
        'End If
        If e.KeyCode = Keys.F7 Then
            If cmd_add.Enabled = True Then
                Call cmd_add_Click(cmd_add, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If Button1.Enabled = True Then
                Call Button1_Click(Button1, e)
                Exit Sub
            End If
        End If

        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_exit_Click(Cmd_exit, e)
            Exit Sub
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
                        If Controls(i_i).Name = "GroupBox2" Then
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
    Private Sub mem_limit_unblock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Controls.Add(ssgrid)
        ssgrid.Location = New Point(25, 75)
        Call Resize_Form()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        ssql = "select mcode from memberblocking where isnull(valid,'')<>'Y'"
        gconnection.getDataSet(ssql, "blc")
        If gdataset.Tables("blc").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("blc").Rows.Count - 1
                ssgrid.Row = i + 1
                ssgrid.Col = 1
                ssgrid.Text = gdataset.Tables("blc").Rows(i).Item("mcode")
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
        Me.cmd_add.Enabled = False
        Me.Button1.Enabled = False
        Me.CMD_AUTH.Enabled = False
        
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_add.Enabled = True
                    
                    Me.CMD_AUTH.Enabled = True
                    Me.Button1.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Button1.Enabled = True
                    'Me.cmdreport.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.CMD_AUTH.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            i = ssgrid.ActiveRow
            Call load_mem()
        End If
        With ssgrid
            If e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, i)
                .Focus()
            End If
        End With
    End Sub
    Private Sub load_mem()
       
        Try
            Dim vform As New LIST_OPERATION1
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM Membermaster"
            M_WhereCondition = " WHERE CURENTSTATUS IN ('LIVE','ACTIVE') "
            vform.Field = "MNAME,MCODE"
            'vform.Frmcalled = "    MEMBER CODE      |  MEMBER NAME        |                                  "
            vform.vCaption = " Member Master Help"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            'vform.KeyPos2 = 2
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                ssgrid.Row = i
                ssgrid.Col = 1
                ssgrid.Text = Trim(vform.keyfield & "")
                'txtlocationcode_Validated(sender, e)
                'cmd_add.Text = "Update[F7]"
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim servercode() As String
        'Dim i As Integer

        'Dim sqlstring, SSQL As String
        'Dim Viewer As New ReportViwer
        ''Dim txtobj1 As TextObject


        'Dim r As New SMARTOVERIDE

        'sqlstring = "SELECT * FROM SMARTOVERIDE WHERE "
        'sqlstring = sqlstring & " CAST(CONVERT(VARCHAR,ADD_DATE,106)AS DATETIME) BETWEEN '"
        'sqlstring = sqlstring & Format(MSKFROMDATE.Value, "yyyy-MM-dd") & "' AND '" & Format(MSKTODATE.Value, "yyyy-MM-dd") & "'"
        'If Chklist_POSLocation.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " AND POSDESC IN ("
        '    For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
        '        sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        'If Chklist_Servercode.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " AND SERVERCODE IN ("
        '    For i = 0 To Chklist_Servercode.CheckedItems.Count - 1
        '        servercode = Split(Chklist_Servercode.CheckedItems(i), "==>")
        '        'sqlstring = sqlstring & servercode(0) & ", "
        '        sqlstring = sqlstring & " '" & servercode(0) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        'If lstcategory.CheckedItems.Count <> 0 Then
        '    sqlstring = sqlstring & " and CATEGORY in ("
        '    For i = 0 To lstcategory.CheckedItems.Count - 1
        '        sqlstring = sqlstring & " '" & lstcategory.CheckedItems(i) & "', "
        '    Next
        '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '    sqlstring = sqlstring & ")"
        'End If
        'sqlstring = sqlstring & "ORDER BY ADD_DATE,USERNAME"
        'Call Viewer.GetDetails(sqlstring, "SMARTOVERIDE", r)
        'Viewer.TableName = "SMARTOVERIDE"

        'Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ1 = r.ReportDefinition.ReportObjects("Text18")
        'TXTOBJ1.Text = gCompanyname

        'Dim TXTOBJ16 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ16 = r.ReportDefinition.ReportObjects("Text20")
        'TXTOBJ16.Text = "Period From  " & Format(mskFromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskToDate.Value, "dd/MM/yyyy") & ""

        'Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ5 = r.ReportDefinition.ReportObjects("Text10")
        'TXTOBJ5.Text = "UserName : " & gUsername

        'Dim TXTOBJ9 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ9 = r.ReportDefinition.ReportObjects("Text10")
        'TXTOBJ9.Text = "Accounting Period : " & Format(strFinancialYearStart, "dd-MM-yyyy") & " - " & Format(strFinancialYearEnd, "dd-MM-yyyy")

        ' Viewer.Show()
        Dim FRM As New ReportDesigner
        '  If txtlocationcode.Text.Length > 0 Then
        'tables = " FROM LOCATIONMASTER WHERE LOCATIONCODE = '" & Trim(txtlocationcode.Text) & "'"
        'Else
        tables = "FROM memberblocking "
        ' End If
        Gheader = "memberunblocking DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"MCODE", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"adduser", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"adddatetime", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"valid", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        Dim CHK As New DataGridViewCheckBoxColumn()
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
    End Sub

    Private Sub Cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub CMD_BRSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_BRSE.Click
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM memberblocking"
        gconnection.getDataSet(STRQUERY, "MENUMASTER")
        Call VIEW1.LOADGRID(gdataset.Tables("MENUMASTER"), False, "MENUMASTER", "SELECT * FROM memberblocking", "SERIALNO", 0)
    End Sub

    Private Sub CMD_AUTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_AUTH.Click
        Dim SSQLSTR, SSQLSTR2 As String
        SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER1,'')=''"
        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
            gconnection.getDataSet(gSQLString, "AUTHORIZE")
            If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                    SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER1,'')=''"
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                        Dim VIEW1 As New AUTHORISATION
                        VIEW1.Show()
                        VIEW1.DTAUTH.DataSource = Nothing
                        VIEW1.DTAUTH.Rows.Clear()
                        'Dim STRQUERY As String
                        'STRQUERY = "SELECT * FROM CORPORATEMASTER"
                        ''STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
                        'gconnection.getDataSet(STRQUERY, "authorize")

                        Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE memberblocking set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                    End If
                Else
                    MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                End If
            End If
        Else
            SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER2,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER2,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            'Dim STRQUERY As String
                            'STRQUERY = "SELECT * FROM CORPORATEMASTER"
                            ''STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
                            'gconnection.getDataSet(STRQUERY, "authorize")

                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE memberblocking set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            Else
                SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER3,'')=''"
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                    gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
                    gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                    If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                        SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "'"
                        gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                        If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                            SSQLSTR2 = " SELECT * FROM memberblocking WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHTHORISEUSER3,'')=''"
                            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                                Dim VIEW1 As New AUTHORISATION
                                VIEW1.Show()
                                VIEW1.DTAUTH.DataSource = Nothing
                                VIEW1.DTAUTH.Rows.Clear()

                                Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE memberblocking set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                            End If
                        End If
                    End If
                Else
                    MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub
End Class
