Imports System.Data.SqlClient

Public Class RPT_ITEMRATEWISESALES
    Inherits System.Windows.Forms.Form


    Public Myconn As New SqlConnection
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Dim gconnection As New GlobalClass

    Private Sub RPT_ITEMRATEWISESALES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       If e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If CmdClear.Enabled = True Then
                Call CmdClear_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            If cmdexit.Enabled = True Then
                Call cmdexit_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If cmdexit.Enabled = True Then
                Call CMD_EXPORT_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F1 Then
            Search_rpt = InputBox("ENTER TEXT", "SEARCH")
            '  ElseIf chklist_POSlocation.SelectedIndex = 0 Then
            Call Search_Item(chklist_POSlocation, Search_rpt)
        ElseIf e.KeyCode = Keys.F2 Then
            Search_rpt = InputBox("ENTER TEXT", "SEARCH")
            Call Search_Item(chklist_Type, Search_rpt)
        End If

    End Sub

    Private Sub RPT_ITEMRATEWISESALES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Resize_Form()

        mskFromDate.Value = Format(CDate(Now), "dd-MM-yyyy")
        mskToDate.Value = Format(CDate(Now), "dd-MM-yyyy")


        Call FillCATEGORY()
        Call FillPOSLocation()
        Call FILLTAXTYPE()

        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub FillPOSLocation()
        Dim sqlstring As String
        Dim i As Integer
        chklist_POSlocation.Items.Clear()
        sqlstring = "SELECT DISTINCT poscode,posdesc FROM posmaster WHERE ISNULL(Freeze,'')<>'Y' "
        gconnection.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    'chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
                    chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")) & Space(200) & "-->" & Trim(.Item("POSCode")))
                End With
            Next i
        End If

        If Mid(gCompName, 1, 5) = "MCEME" Or Mid(gCompName, 1, 4) = "ASCC" Then
            If gUserCategory <> "S" Then
                chklist_POSlocation.Items.Clear()
                sqlstring = "SELECT DISTINCT U.poscode,P.posdesc FROM POS_USERCONTROL U,posmaster P WHERE ISNULL(P.Freeze,'')<>'Y' AND P.POSCODE=U.POSCODE AND U.USERNAME='" & gUsername & "'"
                vconn.getDataSet(sqlstring, "POS")
                If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                        With gdataset.Tables("POS").Rows(i)
                            chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")) & Space(200) & "-->" & Trim(.Item("POSCode")))
                        End With
                    Next i
                End If
            End If
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
        '  Me.CMD.Enabled = False
        Me.CmdView.Enabled = False
        Me.CMD_EXPORT.Enabled = False
        'Me.AUTHORISE.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    'Me.CmdAdd.Enabled = True
                    '  Me.CmdPrint.Enabled = True
                    Me.CmdView.Enabled = True
                    Me.CMD_EXPORT.Enabled = True

                    Exit Sub
                End If

                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    Me.CMD_EXPORT.Enabled = True
                End If
                If Right(x) = "P" Then
                    ' Me.CmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub FillCATEGORY()   '''***************************** To fill Group details from GroupMaster  *****************'''
        Dim sqlstring As String
        Dim gconnection As String
        lstcategory.Items.Clear()
        Dim i As Integer
        sqlstring = "SELECT DISTINCT CATEGORY FROM ITEMMaster "
        vconn.getDataSet(sqlstring, "GroupMaster")
        If gdataset.Tables("GroupMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("GroupMaster").Rows.Count - 1
                With gdataset.Tables("GroupMaster").Rows(i)
                    lstcategory.Items.Add(Trim(.Item("CATEGORY")))
                    'chklist_Type.Items.Add(Trim(.Item("TaxDesc")) & Space(100) & "-->" & Trim(.Item("TaxCode")))
                End With
            Next
        End If
    End Sub


    Private Sub FILLTAXTYPE()
        Dim sqlstring As String
        chklist_Type.Items.Clear()
        Dim i As Integer
        sqlstring = "SELECT DISTINCT itemcode,itemNAME FROM bom_det where isnull(void,'')<>'Y' ORDER BY ITEMNAME "
        gconnection.getDataSet(sqlstring, "ITEMMaster")
        If gdataset.Tables("ITEMMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("ITEMMaster").Rows.Count - 1
                With gdataset.Tables("ITEMMaster").Rows(i)
                    ' chklist_Type.Items.Add(Trim(.Item("itemcode")))
                    chklist_Type.Items.Add(Trim(.Item("itemcode")) & "-->" & Trim(.Item("itemNAME")))
                End With
            Next
        End If
        chklist_Type.Sorted = True
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

                            L = L + 20
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

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        Dim SQL As String
        Dim SSQL, TYPE(), HNAME As String


        If ch_day.Checked = True Then

            SQL = "SELECT ORDERDATE,ITEMCODE,ITEMDESC , RATE, SUM(QTY) AS QTY FROM ITEMRATEWISESALES WHERE CAST(CONVERT(VARCHAR(11),ORDERDATE,106)AS DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "' "
            '  SQL = SQL & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "

            If chklist_Type.CheckedItems.Count <> 0 Then
                SQL = SQL & " and  itemcode IN("
                For i = 0 To chklist_Type.CheckedItems.Count - 1
                    Type = Split(chklist_Type.CheckedItems(i), "-->")
                    SQL = SQL & " '" & Type(0) & "', "
                    HNAME = HNAME & " " & Trim(Type(1))
                    'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"
            End If
            If lstcategory.CheckedItems.Count <> 0 Then
                SQL = SQL & " and CATEGORY in ("
                For i = 0 To lstcategory.CheckedItems.Count - 1
                    SQL = SQL & " '" & lstcategory.CheckedItems(i) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"
            End If
            If chklist_POSlocation.CheckedItems.Count <> 0 Then
                SQL = SQL & " AND POSCODE IN ("
                For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                    TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
                    SQL = SQL & " '" & TYPE(1) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"

            End If
            SQL = SQL & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "
            SQL = SQL & " ORDER BY ORDERDATE "


            Dim r1 As New ITEMRATEWISESALES
            Dim Viewer As New ReportViwer
            Dim TXTOBJ3 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ3 = r1.ReportDefinition.ReportObjects("Text13")
            TXTOBJ3.Text = "PERIOD FROM " & Format(mskFromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskToDate.Value, "dd/MM/yyyy") & ""


            'Dim TXTOBJ4 As CrystalDecisions.CrystalReports.Engine.TextObject
            'TXTOBJ4 = r1.ReportDefinition.ReportObjects("Text15")

            Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ5 = r1.ReportDefinition.ReportObjects("Text14")
            TXTOBJ5.Text = gCompanyname

            Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ1 = r1.ReportDefinition.ReportObjects("Text9")
            TXTOBJ1.Text = "UserName : " & UCase(gUsername)


            'Dim TXTOBJ9 As CrystalDecisions.CrystalReports.Engine.TextObject
            'TXTOBJ9 = r1.ReportDefinition.ReportObjects("Text16")
            'TXTOBJ9.Text = "Accounting Period : " & Format(strFinancialYearStart, "dd-MM-yyyy") & " - " & Format(strFinancialYearEnd, "dd-MM-yyyy")


            Viewer.ssql = SQL
            Viewer.Report = r1
            Viewer.TableName = "ITEMRATEWISESALES"
            Viewer.Show()
        ElseIf chk_item.Checked = True Then

            SQL = "SELECT ITEMCODE,ITEMDESC , RATE, SUM(QTY) AS QTY FROM ITEMRATEWISESALES WHERE CAST(CONVERT(VARCHAR(11),ORDERDATE,106)AS DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "' "
            '  SQL = SQL & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "

            If chklist_Type.CheckedItems.Count <> 0 Then
                SQL = SQL & " and  itemcode IN("
                For i = 0 To chklist_Type.CheckedItems.Count - 1
                    TYPE = Split(chklist_Type.CheckedItems(i), "-->")
                    SQL = SQL & " '" & TYPE(0) & "', "
                    HNAME = HNAME & " " & Trim(TYPE(1))
                    'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"
            End If
            If lstcategory.CheckedItems.Count <> 0 Then
                SQL = SQL & " and CATEGORY in ("
                For i = 0 To lstcategory.CheckedItems.Count - 1
                    SQL = SQL & " '" & lstcategory.CheckedItems(i) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"
            End If
            If chklist_POSlocation.CheckedItems.Count <> 0 Then
                SQL = SQL & " AND POSCODE IN ("
                For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                    TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
                    SQL = SQL & " '" & TYPE(1) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"


            End If
            SQL = SQL & "      GROUP BY ITEMCODE,ITEMDESC , RATE"
            SQL = SQL & " ORDER BY ITEMCODE "


            Dim r1 As New ITEMRATEWISESALES1
            Dim Viewer As New ReportViwer
            Dim TXTOBJ3 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ3 = r1.ReportDefinition.ReportObjects("Text13")
            TXTOBJ3.Text = "PERIOD FROM " & Format(mskFromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskToDate.Value, "dd/MM/yyyy") & ""


            'Dim TXTOBJ4 As CrystalDecisions.CrystalReports.Engine.TextObject
            'TXTOBJ4 = r1.ReportDefinition.ReportObjects("Text15")

            Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ5 = r1.ReportDefinition.ReportObjects("Text14")
            TXTOBJ5.Text = gCompanyname

            Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
            TXTOBJ1 = r1.ReportDefinition.ReportObjects("Text9")
            TXTOBJ1.Text = "UserName : " & UCase(gUsername)


            'Dim TXTOBJ9 As CrystalDecisions.CrystalReports.Engine.TextObject
            'TXTOBJ9 = r1.ReportDefinition.ReportObjects("Text16")
            'TXTOBJ9.Text = "Accounting Period : " & Format(strFinancialYearStart, "dd-MM-yyyy") & " - " & Format(strFinancialYearEnd, "dd-MM-yyyy")


            Viewer.ssql = SQL
            Viewer.Report = r1
            Viewer.TableName = "ITEMRATEWISESALES"
            Viewer.Show()



        Else
            MsgBox("PLEASE SELECT OPTIONS", MsgBoxStyle.Information)
            Exit Sub
        End If


    End Sub

    Private Sub CMD_EXPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_EXPORT.Click
        Dim SQL
        Dim exp As New exportexcel
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        Dim SSQL, TYPE(), HNAME As String


        If ch_day.Checked = True Then

            Sql = "SELECT ORDERDATE,ITEMCODE,ITEMDESC , RATE, SUM(QTY) AS QTY FROM ITEMRATEWISESALES WHERE CAST(CONVERT(VARCHAR(11),ORDERDATE,106)AS DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "' "
            '  SQL = SQL & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "

            If chklist_Type.CheckedItems.Count <> 0 Then
                Sql = Sql & " and  itemcode IN("
                For i = 0 To chklist_Type.CheckedItems.Count - 1
                    Type = Split(chklist_Type.CheckedItems(i), "-->")
                    Sql = Sql & " '" & Type(0) & "', "
                    HNAME = HNAME & " " & Trim(Type(1))
                    'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = Sql & ")"
            End If
            If lstcategory.CheckedItems.Count <> 0 Then
                Sql = Sql & " and CATEGORY in ("
                For i = 0 To lstcategory.CheckedItems.Count - 1
                    Sql = Sql & " '" & lstcategory.CheckedItems(i) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = SSQL & ")"
            End If
            If chklist_POSlocation.CheckedItems.Count <> 0 Then
                Sql = Sql & " AND POSCODE IN ("
                For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                    Type = Split(chklist_POSlocation.CheckedItems(i), "-->")
                    Sql = Sql & " '" & Type(1) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = Sql & ")"

            End If
            Sql = Sql & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "
            Sql = Sql & " ORDER BY ORDERDATE "


        ElseIf chk_item.Checked = True Then

            Sql = "SELECT ITEMCODE,ITEMDESC , RATE, SUM(QTY) AS QTY FROM ITEMRATEWISESALES WHERE CAST(CONVERT(VARCHAR(11),ORDERDATE,106)AS DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "' "
            '  SQL = SQL & " GROUP BY ORDERDATE,ITEMCODE,ITEMDESC,RATE "

            If chklist_Type.CheckedItems.Count <> 0 Then
                Sql = Sql & " and  itemcode IN("
                For i = 0 To chklist_Type.CheckedItems.Count - 1
                    Type = Split(chklist_Type.CheckedItems(i), "-->")
                    Sql = Sql & " '" & Type(0) & "', "
                    HNAME = HNAME & " " & Trim(Type(1))
                    'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = Sql & ")"
            End If
            If lstcategory.CheckedItems.Count <> 0 Then
                Sql = Sql & " and CATEGORY in ("
                For i = 0 To lstcategory.CheckedItems.Count - 1
                    Sql = Sql & " '" & lstcategory.CheckedItems(i) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = Sql & ")"
            End If
            If chklist_POSlocation.CheckedItems.Count <> 0 Then
                Sql = Sql & " AND POSCODE IN ("
                For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                    Type = Split(chklist_POSlocation.CheckedItems(i), "-->")
                    Sql = Sql & " '" & Type(1) & "', "
                Next
                Sql = Mid(Sql, 1, Len(Sql) - 2)
                Sql = Sql & ")"


            End If
            Sql = Sql & "      GROUP BY ITEMCODE,ITEMDESC , RATE"
            SQL = SQL & " ORDER BY ITEMCODE "
        Else
            MsgBox("PLEASE SELECT OPTIONS", MsgBoxStyle.Information)
            Exit Sub
        End If


        gconnection.getDataSet(SQL, "ITEMRATEWISESALES")
        If gdataset.Tables("ITEMRATEWISESALES").Rows.Count > 0 Then
            exp.Show()
            Call exp.export(SQL, "ITEM RATE WISE SALES  " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "   TO   " & Format(mskToDate.Value, "dd-MMM-yyyy"), "")
        Else
            MsgBox("NO SUCH RECORDS FOUND", MsgBoxStyle.Information)
            Exit Sub
        End If

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        mskFromDate.Value = Format(CDate(Now), "dd-MM-yyyy")
        mskToDate.Value = Format(CDate(Now), "dd-MM-yyyy")
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Dim I As Long
        For I = 0 To chklist_Type.Items.Count - 1
            chklist_Type.SetItemChecked(I, False)
        Next
        For I = 0 To chklist_POSlocation.Items.Count - 1
            chklist_POSlocation.SetItemChecked(I, False)
        Next
        For I = 0 To lstcategory.Items.Count - 1
            lstcategory.SetItemChecked(I, False)
        Next
        Chk_SelectAllCategory.Checked = False
        Chk_Taxtype.Checked = False
        Chk_POSlocation.Checked = False


    End Sub

    Private Sub Chk_SelectAllCategory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllCategory.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllCategory.Checked = True Then
            For i = 0 To lstcategory.Items.Count - 1
                lstcategory.SetItemChecked(i, True)
            Next i
        Else
            For i = 0 To lstcategory.Items.Count - 1
                lstcategory.SetItemChecked(i, False)
            Next i
        End If
    End Sub

    Private Sub Chk_POSlocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.CheckedChanged
        Dim i As Integer

        If Chk_POSlocation.Checked = True Then
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_Taxtype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Taxtype.CheckedChanged
        Dim i As Integer
        If Chk_Taxtype.Checked = True Then
            For i = 0 To chklist_Type.Items.Count - 1
                chklist_Type.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Type.Items.Count - 1
                chklist_Type.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_item.CheckedChanged
        If chk_item.Checked = True Then
            ch_day.Checked = False
        Else
            ch_day.Checked = True

        End If
    End Sub

    Private Sub ch_day_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_day.CheckedChanged
        If ch_day.Checked = True Then
            chk_item.Checked = False
        Else


        End If
    End Sub
End Class