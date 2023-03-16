Imports System.Windows.Forms

Public Class MDIFORM
    Dim gconnection As New GlobalClass
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    'Private Sub ApplicationMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationMasterToolStripMenuItem.Click
    '    GmoduleName = "FRM_MKGA_APPLICATIONMASTER"
    '    Dim f As New FRM_MKGA_APPLICATIONMASTER
    '    'f.MdiParent = Me
    '    STATUS = False
    '    'f.ShowDialog()
    '    'aplmcode = ""
    '    'aplmname = ""
    '    ' MCODE = ""
    '    'MEMNAME = ""
    '    ' gCategory = ""
    '    f.Show()
    'End Sub

    'Private Sub EntranceFeeRecieptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntranceFeeRecieptToolStripMenuItem.Click
    '    GmoduleName = "FRM_TKGA_ENTREEFEERECEIPT"
    '    Dim a As New FRM_TKGA_ENTREEFEERECEIPT
    '    a.ShowDialog()
    'End Sub

    'Private Sub InterviewResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterviewResultToolStripMenuItem.Click
    '    Dim b As New FRM_TKGA_INTERVIEWRESULT
    '    b.ShowDialog()
    'End Sub

    'Private Sub ReasonMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReasonMasterToolStripMenuItem.Click
    '    Dim c As New FRM_MKGA_REASONMASTER
    '    c.ShowDialog()
    'End Sub

    'Private Sub EntranceFeeMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntranceFeeMasterToolStripMenuItem.Click
    '    GmoduleName = "FRM_MKGA_ENTREEFEEMASTER"
    '    Dim d As New FRM_MKGA_ENTREEFEEMASTER
    '    d.ShowDialog()
    'End Sub

    'Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
    '    Me.Close()
    'End Sub

    'Private Sub NOMINEEINCLUSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOMINEEINCLUSIONToolStripMenuItem.Click

    '    GmoduleName = "INCLUSION"
    '    Dim d As New INCLUSION
    '    d.ShowDialog()
    'End Sub

    'Private Sub EditMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click

    'End Sub

    'Private Sub MEMBERCONFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERCONFORMATIONToolStripMenuItem.Click
    '    GmoduleName = "FRM_TKGA_CONFORMATION "
    '    Dim d As New FRM_TKGA_CONFORMATION
    '    d.ShowDialog()
    'End Sub
    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()

    End Sub

    Private Sub ReasonMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EntranceFeeMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MDIFORM_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        MDIParentobj = Me
        CheckForIllegalCrossThreadCalls = False
        If gDatabase = "" Then
            Call GetServer()
        End If

        Call SYS_DATE_TIME()
        'Call GETSTATUS()
        Call FillCompanyinfo()
        Call GetAccountcode()

        Me.Text = "[ POS  ]  " & gCompanyname & Space(25) & "[" & gFinancalyearStart & "-" & gFinancialYearEnd & "]" & Space(20) & "UserName:" & gUsername & "              Data Base: " & gDatabase
        If Mid(gCompanyname, 1, 10) <> "THE BENGAL" Then
            MenuItem24.Visible = True
        Else
            ' MenuItem24.Visible = False
        End If
        If UCase(Mid(gCompanyname, 1, 8)) = "KARNATAK" Then
            MenuItem25.Visible = False
        Else
            MenuItem25.Visible = True
        End If

        If Mid(gCompName, 1, 5) = "MCEME" Or Mid(gCompName, 1, 4) = "ASCC" Then
            ' Me.BackgroundImage = Image.FromFile(AppPath & "\BACKIMAGE.jpg") 
            Me.BackgroundImage = Image.FromFile(AppPath & "\BACK.PNG")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            MenuItem21.Text = "ORDER TICKET"
            MenuItem25.Text = "ORDER TICKET BOOK ISSUE"
            MenuItem25.Visible = False
            MenuItem18.Visible = False
            MenuItem10.Visible = False
            MenuItem24.Visible = False
            MenuItem26.Visible = False
            MenuItem17.Visible = False
            MenuItem35.Visible = False
            gconnection.ExcuteStoreProcedure(" update kot_det set CATEGORY=a.category from ItemMaster a where a.itemcode=kot_det.ITEMCODE and isnull(kot_det.CATEGORY,'')='' ")
        End If

        If UCase(Mid(gCompName, 1, 8)) = "ASCC" Then
            MenuItem44.Visible = True
            MenuItem43.Visible = False
        Else
            MenuItem44.Visible = False
        End If
        If Mid(gCompName, 1, 5) = "COSMO" Then
            MenuItem19.Visible = True
        Else
            MenuItem19.Visible = False
        End If

        Call Activateuseradmin()

        SQLSTRING = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ITEMMASTER' AND  COLUMN_NAME = 'StkCtl') Begin ALTER TABLE ITEMMASTER ADD StkCtl VARCHAR(10) End"
        gconnection.dataOperation(6, SQLSTRING, "AddC")

    End Sub
    Private Sub GetAccountcode()
        Dim sqlstring As String
        sqlstring = "SELECT ISNULL(SDRSCODE,'') AS SDRSCODE,ISNULL(SCRSCODE,'') AS SCRSCODE FROM ACCOUNTSSETUP "
        gconnection.getDataSet(sqlstring, "ACCOUNTSSETUP")
        If gdataset.Tables("ACCOUNTSSETUP").Rows.Count > 0 Then
            gDebitors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SDRSCODE")))
            gCreditors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SCRSCODE")))
        Else
            gDebitors = ""
            gCreditors = ""
        End If
    End Sub
    Private Sub Activateuseradmin()
        Dim totmenu As Integer = 0
        Dim i, j, k, ckhmn, ckhmn1 As Integer
        Call menublock()
        For i = 0 To Menu.MenuItems.Count - 2
            ckhmn1 = Menu.MenuItems(i).MenuItems.Count()
            If ckhmn1 <> 0 Then
                For j = 0 To Menu.MenuItems(i).MenuItems.Count() - 1
                    ckhmn = Menu.MenuItems(i).MenuItems(j).MenuItems.Count()
                    If ckhmn <> 0 Then
                        For k = 0 To Menu.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                            totmenu = totmenu + 1
                        Next
                    Else
                        totmenu = totmenu + 1
                    End If
                Next
            Else
                totmenu = totmenu + 1
            End If
        Next
        gconnection.getDataSet("SELECT COUNT(*) FROM  modulemaster WHERE PackageName='POS'", "chk")
        If gdataset.Tables("chk").Rows.Count <> totmenu Then
            gconnection.ExcuteStoreProcedure("DELETE FROM modulemaster WHERE PackageName='POS'")
            Call checkmenulist()
        End If
        If gUserCategory = "S" Or gUserCategory = "A" Then
            Call menuclear()
        Else
            Call relemenu()
        End If
    End Sub
    Public Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = Me.Menu.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = Me.Menu.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                If Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Visible = True Then
                                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','POS')"
                                    ReDim Preserve vsql(vsql.Length)
                                End If
                            Next
                        Else
                            If Me.Menu.MenuItems(i).MenuItems(j).Visible = True Then
                                vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','POS')"
                                ReDim Preserve vsql(vsql.Length)
                            End If
                        End If
                    Next
                Else
                    If Me.Menu.MenuItems(i).Visible = True Then
                        vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','POS')"
                        ReDim Preserve vsql(vsql.Length)
                    End If
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans1(vsql)
        End If
    End Sub
    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = Menu.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = Menu.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        Menu.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                Menu.MenuItems(i).Enabled = True
            End If
        Next
    End Sub
    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long

        ''vmain= Mainmenu1.ContextMenuStrip.Select
        vmain = Menu.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = Menu.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        Menu.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                Menu.MenuItems(i).Enabled = False
            End If
        Next
    End Sub

    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        a = .Item("mainmoduleid")
                        b = Val(.Item("submoduleid"))
                        c = Val(.Item("ssubmoduleid"))
                        Menu.MenuItems(a).MenuItems(b).MenuItems(c).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        a = gdataset.Tables("user").Rows(i).Item("mainmoduleid")
                        b = Val(gdataset.Tables("user").Rows(i).Item("submoduleid"))
                        Menu.MenuItems(a).MenuItems(b).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        Menu.MenuItems((.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                serverdate = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd-MMM-yyyy")
                servertime = gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERTIME")
            End If
            sqlstring = "SELECT ISNULL(COMPNAME,'') AS COMPNAME FROM POSSETUP "
            gconnection.getDataSet(sqlstring, "CNAME")
            If gdataset.Tables("CNAME").Rows.Count > 0 Then
                gCompName = Trim(gdataset.Tables("CNAME").Rows(0).Item("COMPNAME"))
            End If

            sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode, ISNULL(roundoffyesno,'') AS BILLROUNDOFF,ISNULL(SETTLEMENT,'') AS SETTLEMENT FROM POSSETUP"
            gconnection.getDataSet(sqlstring, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                BILLROUNDYESNO = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BILLROUNDOFF"))
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        AppPath = Application.StartupPath
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER, UserName, Password, Company_ID,DATABASE FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
                strDataSqlUsr = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                strDataSqlPwd = Trim(getserver.Tables(0).Rows(0).Item(2) & "")
                strCompany_ID = Trim(getserver.Tables(0).Rows(0).Item(3) & "")
                gDatabase = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
            Else
                MessageBox.Show("Failed to connect to Data Source")
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Public Sub GETSTATUS()
        Dim SQL As String
        SQL = "UPDATE MEMBERMASTER SET CURENTSTATUS=NEWSTATUS,STATUSDATEFROM='',NEWSTATUS='' WHERE ISNULL(NEWSTATUS,'')<>'' AND STATUSDATEFROM<='" & Format(serverdate, "yyyy-MM-dd") & "'"
        gconnection.dataOperation(2, SQL, "member")

    End Sub
    Public Sub FillCompanyinfo()
        Dim sqlstring As String
        Try
            If Trim(gDatabase) <> "" Then
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster WHERE DATAFILE = '" & Trim(gDatabase) & "'"
            Else
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster "
            End If
            gconnection.getCompanyinfo(sqlstring, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                MyCompanyName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("CompanyName")))
                Address1 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add1")))
                Address2 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add2")))
                gCity = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("City")))
                gState = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("State")))
                gPincode = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Pincode")))
                gDatabase = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Datafile")))
                Me.Text = " [" & "POS FACILITY SYSTEM" & " ]" & MyCompanyName & "   " & gDatabase & "USER NAME :" & gUsername
                If Mid(MyCompanyName, 1, 3) = "HIN" Then
                    PrintTaxheading1 = "C.F"
                    PrintTaxheading2 = "CHARGES"
                Else
                    PrintTaxheading1 = "SALES"
                    PrintTaxheading2 = "TAX"
                End If
            Else
                MessageBox.Show("Plz. Contact to your Computer Administrator ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MenuItem2.Click
        GmoduleName = "POS MASTER"
        Try
            Dim SMPS As New FRM_MKGA_POSMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        GmoduleName = "POSSETUP"
        Try
            Dim SMPS As New FRM_MKGA_POSSETUP
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        GmoduleName = "ITEM MASTER"
        Try
            Dim SMPS As New FRM_MKGA_ItemMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem5_Click(sender As Object, e As EventArgs) Handles MenuItem5.Click
        GmoduleName = "CATEGORY MASTER"
        Try
            Dim SMPS As New FRM_MKGA_CategoryMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
        GmoduleName = "GROUP MASTER"
        Try
            Dim SMPS As New FRM_MKGA_GroupMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        GmoduleName = "SUBGROUP MASTER"
        Try
            Dim SMPS As New FRM_MKGA_Subgroupmaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles MenuItem8.Click
        GmoduleName = "LOCATION MASTER"
        Try
            Dim SMPS As New FRM_MKGA_Locationmaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles MenuItem9.Click
        GmoduleName = "SERVER MASTER"
        Try
            Dim SMPS As New FRM_MKGA_ServerMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem10_Click(sender As Object, e As EventArgs) Handles MenuItem10.Click
        GmoduleName = "TABLE MASTER"
        Try
            Dim SMPS As New FRM_MKGA_Tablemaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click
        GmoduleName = "TAX TYPE MASTER"
        Try
            Dim SMPS As New FRM_MKGA_ItemType
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click
        GmoduleName = "PAYMENTMODE MASTER"
        Try
            Dim SMPS As New FRM_MKGA_Paymentmodemaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        GmoduleName = "UOM MASTER"
        Try
            Dim SMPS As New FRM_MKGA_Uommaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        GmoduleName = "CREDITLIMIT UNBLOCK"
        Try
            Dim SMPS As New FRM_MKGA_mem_limit_unblock
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MenuItem15.Click
        GmoduleName = "POS GROUPING"
        Try
            Dim SMPS As New FRM_MKGA_POSGROUPMASTER
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MenuItem16.Click
        GmoduleName = "BOM"
        Try
            Dim SMPS As New FRM_MKGA_BOM
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MenuItem17.Click
        GmoduleName = "RATE MASTER"
        Try
            Dim SMPS As New FRM_MKGA_RateMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem18_Click(sender As Object, e As EventArgs) Handles MenuItem18.Click
        GmoduleName = "PROMOTIONAL MASTER"
        Try
            Dim SMPS As New FRM_MKGA_PromotionalMaster
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem19_Click(sender As Object, e As EventArgs) Handles MenuItem19.Click
        GmoduleName = "DISCOUNT PERCENTAGE MASTER"
        Try
            Dim SMPS As New frmHappy
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem21_Click(sender As Object, e As EventArgs) Handles MenuItem21.Click
        GmoduleName = "ORDER TICKET"
        Try
            SQLSTRING = "SELECT ISNULL(centralizedkot,'N') AS CENTRALIZEDKOT,ISNULL(KOTPREFIX,'') AS KOTPREFIX,ISNULL(KOTTYPE,'') AS KOTTYPE FROM POSSETUP"
            gconnection.getDataSet(SQLSTRING, "CEN_CHECK")
            If gdataset.Tables("CEN_CHECK").Rows.Count > 0 Then
                If Mid(gdataset.Tables("CEN_CHECK").Rows(0).Item(0), 1, 1) = "Y" Then
                    SQLSTRING = "SELECT ISNULL(PACKINGPERCENT,0) AS PACKPER,ISNULL(TIPS,0) AS TIPS_SER,ISNULL(ADCHARGE,0) AS ADCHARGE,ISNULL(PRCHARGE,0) AS PRCHARGE,ISNULL(GRCHARGE,0) AS GRCHARGE,ISNULL(KOTTYPE,'') AS KOTTYPE,ISNULL(PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(KOTPREFIX,'') AS KOTPREFIX,ISNULL(TABLEREQUIRED,'') AS TABLEREQ FROM POSSETUP"
                    gconnection.getDataSet(SQLSTRING, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        gPackPer = gdataset.Tables("POSSETUP").Rows(0).Item("PACKPER")
                        gTipsPer = gdataset.Tables("POSSETUP").Rows(0).Item("TIPS_SER")
                        gAdCgsPer = gdataset.Tables("POSSETUP").Rows(0).Item("ADCHARGE")
                        gPartyPer = gdataset.Tables("POSSETUP").Rows(0).Item("PRCHARGE")
                        gRoomPer = gdataset.Tables("POSSETUP").Rows(0).Item("GRCHARGE")
                        gTableReq = gdataset.Tables("POSSETUP").Rows(0).Item("TABLEREQ")
                        gKotType = gdataset.Tables("POSSETUP").Rows(0).Item("KOTTYPE")
                        gKotPrefix = gdataset.Tables("POSSETUP").Rows(0).Item("KOTPREFIX")
                        DefaultPayment = gdataset.Tables("POSSETUP").Rows(0).Item("PAYMENTMODE")
                    End If
                    If Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(2)) = "AUTO" Then
                        gKotType = "A"
                    Else
                        gKotType = "M"
                    End If
                    gCenterlized = "Y"
                    If Mid(gCompName, 1, 5) = "COSMO" Then
                        Dim SMPS As New FRM_TCOS_SmartKotEntry("", Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(1)))
                        SMPS.Show()
                        SMPS.MdiParent = Me
                    Else
                        Dim SMPS As New FRM_TKGA_SmartKotEntry("", Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(1)))
                        SMPS.Show()
                        SMPS.MdiParent = Me
                    End If
                ElseIf Mid(gdataset.Tables("CEN_CHECK").Rows(0).Item(0), 1, 1) = "N" Then
                    SQLSTRING = "SELECT ISNULL(PACKINGPERCENT,0) AS PACKPER,ISNULL(TIPS,0) AS TIPS_SER,ISNULL(ADCHARGE,0) AS ADCHARGE,ISNULL(PRCHARGE,0) AS PRCHARGE,ISNULL(GRCHARGE,0) AS GRCHARGE,ISNULL(KOTTYPE,'') AS KOTTYPE,ISNULL(PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(FINALPREFIX,'') AS FINALPREFIX,ISNULL(TABLEREQUIRED,'') AS TABLEREQ,ISNULL(WAITREQR,'') AS WAITREQR FROM POSSETUP"
                    gconnection.getDataSet(SQLSTRING, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        gWaiterReq = gdataset.Tables("POSSETUP").Rows(0).Item("WAITREQR")
                    End If
                    gCenterlized = "N"
                    GmoduleName = "ORDER TICKET"
                    Dim DOCSelection As New DOCSelection("ORDER TICKET")
                    DOCSelection.FormBorderStyle = FormBorderStyle.FixedDialog
                    DOCSelection.MdiParent = Me
                    DOCSelection.Show()
                End If
            Else
                MessageBox.Show("Pos Setup Not Done Pleaze Check")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem22_Click(sender As Object, e As EventArgs) Handles MenuItem22.Click
        GmoduleName = "Final Billing"
        Try
            SQLSTRING = "SELECT ISNULL(centralizedkot,'N') AS CENTRALIZEDKOT,ISNULL(FINALPREFIX,'') AS FINALPREFIX,ISNULL(KOTTYPE,'') AS KOTTYPE FROM POSSETUP"
            gconnection.getDataSet(SQLSTRING, "CEN_CHECK")
            If gdataset.Tables("CEN_CHECK").Rows.Count > 0 Then
                If Mid(gdataset.Tables("CEN_CHECK").Rows(0).Item(0), 1, 1) = "Y" Then
                    SQLSTRING = "SELECT ISNULL(PACKINGPERCENT,0) AS PACKPER,ISNULL(TIPS,0) AS TIPS_SER,ISNULL(ADCHARGE,0) AS ADCHARGE,ISNULL(PRCHARGE,0) AS PRCHARGE,ISNULL(GRCHARGE,0) AS GRCHARGE,ISNULL(KOTTYPE,'') AS KOTTYPE,ISNULL(PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(FINALPREFIX,'') AS FINALPREFIX,ISNULL(TABLEREQUIRED,'') AS TABLEREQ,ISNULL(WAITREQR,'') AS WAITREQR FROM POSSETUP"
                    gconnection.getDataSet(SQLSTRING, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        gTableReq = gdataset.Tables("POSSETUP").Rows(0).Item("TABLEREQ")
                        gWaiterReq = gdataset.Tables("POSSETUP").Rows(0).Item("WAITREQR")
                        gKotType = gdataset.Tables("POSSETUP").Rows(0).Item("KOTTYPE")
                        gKotPrefix = gdataset.Tables("POSSETUP").Rows(0).Item("FINALPREFIX")
                        DefaultPayment = gdataset.Tables("POSSETUP").Rows(0).Item("PAYMENTMODE")
                    End If
                    If Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(2)) = "AUTO" Then
                        gKotType = "A"
                    Else
                        gKotType = "M"
                    End If
                    gCenterlized = "Y"
                    If Mid(gCompName, 1, 5) = "COSMO" Then
                        Dim SMPS As New FRM_TCOS_FinalBilling("", Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(1)))
                        SMPS.Show()
                        SMPS.MdiParent = Me
                    Else
                        Dim SMPS As New FRM_TKGA_FinalBilling("", Trim(gdataset.Tables("CEN_CHECK").Rows(0).Item(1)))
                        SMPS.Show()
                        SMPS.MdiParent = Me
                    End If

                ElseIf Mid(gdataset.Tables("CEN_CHECK").Rows(0).Item(0), 1, 1) = "N" Then
                    SQLSTRING = "SELECT ISNULL(PACKINGPERCENT,0) AS PACKPER,ISNULL(TIPS,0) AS TIPS_SER,ISNULL(ADCHARGE,0) AS ADCHARGE,ISNULL(PRCHARGE,0) AS PRCHARGE,ISNULL(GRCHARGE,0) AS GRCHARGE,ISNULL(KOTTYPE,'') AS KOTTYPE,ISNULL(PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(FINALPREFIX,'') AS FINALPREFIX,ISNULL(TABLEREQUIRED,'') AS TABLEREQ,ISNULL(WAITREQR,'') AS WAITREQR FROM POSSETUP"
                    gconnection.getDataSet(SQLSTRING, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        gWaiterReq = gdataset.Tables("POSSETUP").Rows(0).Item("WAITREQR")
                    End If
                    gCenterlized = "N"
                    GmoduleName = "Final Billing"
                    Dim DOCSelection As New DOCSelection("FINAL BILLING")
                    DOCSelection.FormBorderStyle = FormBorderStyle.FixedDialog
                    DOCSelection.MdiParent = Me
                    DOCSelection.Show()
                    If UCase(Mid(gCompanyname, 1, 8)) = "KARNATAK" Then
                        Call DOCSelection.direct()
                    End If
                End If
            Else
                MessageBox.Show("Pos Setup Not Done Pleaze Check")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        GmoduleName = "DIRECT BILLING"
        Try
            gCenterlized = "N"
            GmoduleName = "DIRECT BILLING"
            Dim DOCSelection As New DOCSelection("DIRECT BILLING")
            DOCSelection.FormBorderStyle = FormBorderStyle.FixedDialog
            DOCSelection.MdiParent = Me
            DOCSelection.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem24_Click(sender As Object, e As EventArgs) Handles MenuItem24.Click
        GmoduleName = "Service Billing"
        Dim DOCSelection As New DOCSelection("DIRECTBILL")
        DOCSelection.MdiParent = Me
        DOCSelection.Show()
    End Sub

    Private Sub MenuItem25_Click(sender As Object, e As EventArgs) Handles MenuItem25.Click
        GmoduleName = "KOT BOOK"
        Try
            Dim SMPS As New FRM_TKGA_KOTBOOK
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem26_Click(sender As Object, e As EventArgs) Handles MenuItem26.Click
        GmoduleName = "BILL CLOSING"
        Try
            Dim SMPS As New FRM_TKGA_BILLCLOSE
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem28_Click(sender As Object, e As EventArgs) Handles MenuItem28.Click
        GmoduleName = "POS WISE SALES REPORT"
        Try
            Dim SMPS As New SalesBillChecklist1
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs) Handles MenuItem29.Click
        GmoduleName = "SETTLEMENT REPORT"
        Try
            Dim SMPS As New FRM_RKGA_Selectivedatewise
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem30_Click(sender As Object, e As EventArgs) Handles MenuItem30.Click
        GmoduleName = "POSWISE ITEMSALES"
        Try
            Dim SMPS As New DeptitemwiseSalesRegister
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem31_Click(sender As Object, e As EventArgs) Handles MenuItem31.Click
        GmoduleName = "MEMBERWISE SALES"
        Try
            Dim SMPS As New MEMBERSALESPOINTWISEREGISTER
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem32_Click(sender As Object, e As EventArgs) Handles MenuItem32.Click
        GmoduleName = "GROUPWISE SALES"
        Try
            Dim SMPS As New DeptitemwiseSalesRegister123
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem33_Click(sender As Object, e As EventArgs) Handles MenuItem33.Click
        GmoduleName = "ITEMWISE/BILLWISE SALES"
        Try
            Dim SMPS As New FRM_RKGA_VatServiceTaxreport
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem34_Click(sender As Object, e As EventArgs) Handles MenuItem34.Click
        GmoduleName = "CANCELED ITEM REGISTER"
        Try
            Dim SMPS As New FRM_RKGA_CancelItemRegister
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem35_Click(sender As Object, e As EventArgs) Handles MenuItem35.Click
        GmoduleName = "BEARERWISE PENDING"
        Try
            Dim SMPS As New FRM_RKGA_SERVERWISEPENDING
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs) Handles MenuItem36.Click
        GmoduleName = "USERWISE PENDING"
        Try
            Dim SMPS As New FRM_RKGA_ServerwisePendingKotRegister
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem37_Click(sender As Object, e As EventArgs) Handles MenuItem37.Click
        GmoduleName = "TAX REPORT"
        Try
            Dim SMPS As New TAXREPORT
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem39_Click(sender As Object, e As EventArgs) Handles MenuItem39.Click
        GmoduleName = "ACCOUNTS ITEM TAGGING"
        Try
            Dim SMPS As New AccountItemTagging
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem40_Click(sender As Object, e As EventArgs) Handles MenuItem40.Click
        GmoduleName = "ACCOUNTS POSTING"
        Try
            Dim SMPS As New JournalRegister
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem41_Click(sender As Object, e As EventArgs) Handles MenuItem41.Click
        Application.Exit()
    End Sub

    Private Sub MDIFORM_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub MDIFORM_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MDIFORM_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click

    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        GmoduleName = "POS ITEM LINK"
        Try
            Dim SMPS As New PosItemStoreTagging
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        GmoduleName = "ITEM RATE WISE SALE REPORT"
        Try
            Dim SMPS As New RPT_ITEMRATEWISESALES
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        GmoduleName = "ITEM WISE TABLE MONEY TAG"
        Try
            Dim SMPS As New ITEMTAGTABLE
            SMPS.Show()
            SMPS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
