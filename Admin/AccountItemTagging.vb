
Public Class AccountItemTagging
    Dim Vconn As New GlobalClass
    Dim gconnection As New GlobalClass
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
                        If Controls(i_i).Name = "GroupBox1" Then
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
    Private Sub AccountItemTagging_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call Resize_Form()


        Dim i, j As Integer
        SQLSTRING = "select a.itemcode,a.itemdesc ,isnull(a.salesacctin,'') as accode,isnull(b.acdesc,'') as acdesc, ISNULL(A.SLCODE,'') AS SLCODE, ISNULL(C.SLDESC,'') AS SLDESC   from itemmaster a left outer join accountsglaccountmaster b on a.salesacctin=b.accode left outer join  ACCOUNTSSUBLEDGERMASTER C ON A.SLCODE=C.SLCODE where isnull(a.freeze,'')<>'Y' and isnull(b.freezeflag,'')<>'Y' order by b.acdesc,a.itemcode "
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemcode")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemdesc")
                    .Col = 3
                    .Text = gdataset.Tables("acctag").Rows(i).Item("accode")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("acdesc")
                    .Col = 5
                    .Text = gdataset.Tables("acctag").Rows(i).Item("SLCODE")
                    .Col = 6
                    .Text = gdataset.Tables("acctag").Rows(i).Item("SLDESC")
                End With
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
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
        Me.Cmd_Add.Enabled = False
        'Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        'Me.cmdreport.Enabled = False
        'Me.AUTHORISE.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    'Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    'Me.cmdreport.Enabled = True
                    'Me.AUTHORISE.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                    'Me.cmdreport.Enabled = True
                End If
                If Right(x) = "U" Then
                    'Me.AUTHORISE.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click(sender As Object, e As EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub


    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        With ssgrid1
            If .ActiveCol = 3 Then
                .Row = .ActiveRow
                If .Text = "" And e.keyCode = 13 Then
                    Call FillMenu()
                ElseIf .Text <> "" And e.keyCode = 13 Then
                    Call FillMenu(.Text)
                End If
            End If
            .Col = 3
            .Row = .ActiveRow
            If (.Text) <> "" Then
                If .ActiveCol = 5 Then
                    .Col = 5
                    '.Row = .ActiveRow
                    If .Text = "" And e.keyCode = 13 Then
                        Call SUB_FillMenu()
                    ElseIf .Text <> "" And e.keyCode = 13 Then
                        Call SUB_FillMenu(.Text)
                    End If
                End If
            End If
            If .Col = 4 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
        End With
    End Sub
    Private Sub SUB_FillMenu()
        Dim ACCODE As String
        ACCODE = ""
        With ssgrid1
            .Row = .ActiveRow
            .Col = 3
            If (.Text) <> "" Then
                ACCODE = .Text
            Else
                MessageBox.Show("Account code can't be blank")
                Exit Sub
            End If
        End With
        Dim vform As New LIST_OPERATION1
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select SLCODE,SLDESC from ACCOUNTSSUBLEDGERMASTER "

        'gSQLString = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        'gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM VIEW_ITEMMASTER AS I INNER "
        'gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "

        If Trim(Search) = " " Then
            M_WhereCondition = "WHERE   ACCODE='" & ACCODE & "' and sltype<>'DEBTORS' AND ISNULL(FREEZEFLAG,'')<>'Y'"
        Else
            M_WhereCondition = "WHERE   ACCODE='" & ACCODE & "' and sltype<>'DEBTORS' AND ISNULL(FREEZEFLAG,'')<>'Y'"
            'M_WhereCondition = " WHERE (accode LIKE '%" & Search & "%' OR acdesc LIKE '%" & Search & "%') AND category in ('I') and  ISNULL(FREEZEFLAG,'') <>'Y' "
        End If
        vform.Field = "SLCODE,SLDESC"
        'vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ITEM CODE HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 5
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 6
                .Row = .ActiveRow
                .Text = vform.keyfield1
                ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End With
        Else
            ssgrid1.SetActiveCell(5, ssgrid1.ActiveRow)
            ssgrid1.Col = 5
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            ssgrid1.Col = 6
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            Exit Sub
        End If
    End Sub


    Private Sub SUB_FillMenu(ByVal ACC)
        'Dim vform As New LIST_OPERATION1
        'Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select accode,acdesc from accountsglaccountmaster WHERE accode LIKE '%" & ACC & "%'  and  ISNULL(FREEZEFLAG,'') <>'Y' "
        gconnection.getDataSet(gSQLString, "accode")

        Dim subacc

        If gdataset.Tables("accode").Rows.Count > 0 Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = gdataset.Tables("accode").Rows(0).Item("accode")
                subacc = .Text
                .Col = 4
                .Row = .ActiveRow
                .Text = gdataset.Tables("accode").Rows(0).Item("ACDESC")
                ' ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End With
            gSQLString = "select accode,acdesc from accountsglaccountmaster WHERE accode='" & subacc & "' and subledgerflag='Y'  and  ISNULL(FREEZEFLAG,'') <>'Y' "
            gconnection.getDataSet(gSQLString, "subaccode")
            If gdataset.Tables("subaccode").Rows.Count > 0 Then
                ssgrid1.SetActiveCell(5, ssgrid1.ActiveRow)
            Else
                With ssgrid1
                    .Col = 5
                    .Row = .ActiveRow
                    .Lock = True
                    .Col = 6
                    .Row = .ActiveRow
                    .Lock = True
                End With
                ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End If
        Else
            ssgrid1.SetActiveCell(5, ssgrid1.ActiveRow)
            ssgrid1.Col = 5
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            ssgrid1.Col = 6
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""

            Exit Sub
        End If
    End Sub
    Private Sub FillMenu(ByVal ACC)
        'Dim vform As New LIST_OPERATION1
        'Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select accode,acdesc from accountsglaccountmaster WHERE accode LIKE '%" & ACC & "%'  and  ISNULL(FREEZEFLAG,'') <>'Y' "
        gconnection.getDataSet(gSQLString, "accode")

        Dim subacc

        If gdataset.Tables("accode").Rows.Count > 0 Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = gdataset.Tables("accode").Rows(0).Item("accode")
                subacc = .Text
                .Col = 4
                .Row = .ActiveRow
                .Text = gdataset.Tables("accode").Rows(0).Item("ACDESC")
                ' ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End With
            gSQLString = "select accode,acdesc from accountsglaccountmaster WHERE accode='" & subacc & "' and subledgerflag='Y'  and  ISNULL(FREEZEFLAG,'') <>'Y' "
            gconnection.getDataSet(gSQLString, "subaccode")
            If gdataset.Tables("subaccode").Rows.Count > 0 Then
                ssgrid1.SetActiveCell(5, ssgrid1.ActiveRow)
            Else
                With ssgrid1
                    .Col = 5
                    .Row = .ActiveRow
                    .Lock = True
                    .Col = 6
                    .Row = .ActiveRow
                    .Lock = True
                End With
                ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End If
        Else
            ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow)
            ssgrid1.Col = 3
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            ssgrid1.Col = 4
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""

            Exit Sub
        End If
    End Sub


    Private Sub FillMenu()
        Dim vform As New LIST_OPERATION1
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select accode,acdesc from accountsglaccountmaster "

        'gSQLString = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        'gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM VIEW_ITEMMASTER AS I INNER "
        'gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
        If Trim(Search) = " " Then
            M_WhereCondition = "WHERE  ISNULL(FREEZEFLAG,'') <>'Y'"
        Else
            M_WhereCondition = " WHERE (accode LIKE '%" & Search & "%' OR acdesc LIKE '%" & Search & "%')  and  ISNULL(FREEZEFLAG,'') <>'Y' "
        End If
        vform.Field = "ACDESC,ACCODE"
        'vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ACCODE CODE HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        Dim subacc

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield
                subacc = .Text
                .Col = 4
                .Row = .ActiveRow
                .Text = vform.keyfield1
            End With
            gSQLString = "select accode,acdesc from accountsglaccountmaster WHERE accode='" & subacc & "' and subledgerflag='Y'  and  ISNULL(FREEZEFLAG,'') <>'Y' "
            gconnection.getDataSet(gSQLString, "subaccode")
            If gdataset.Tables("subaccode").Rows.Count > 0 Then
                ssgrid1.SetActiveCell(5, ssgrid1.ActiveRow)
            Else
                With ssgrid1
                    .Col = 5
                    .Row = .ActiveRow
                    .Lock = True
                    .Col = 6
                    .Row = .ActiveRow
                    .Lock = True
                End With
                ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow + 1)
            End If
        Else
            ssgrid1.SetActiveCell(3, ssgrid1.ActiveRow)
            ssgrid1.Col = 3
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            ssgrid1.Col = 4
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_Add_Click(sender As Object, e As EventArgs) Handles Cmd_Add.Click
        Dim i As Integer
        Dim itemcd, acccd, SUBACC, ssql As String
        If ssgrid1.DataRowCnt <= 1 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 3
                acccd = .Text
                .Col = 5
                SUBACC = .Text
                'If SUBACC = "" Then
                '    ssql = "update itemmaster set salesacctin='" & acccd & "' where itemcode='" & itemcd & "'"
                'Else
                ssql = "update itemmaster set salesacctin='" & acccd & "',SLCODE='" & SUBACC & "' where itemcode='" & itemcd & "'"
                ''End If

                Vconn.dataOperation(6, ssql, "item")

            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Cmd_Clear_Click(sender As Object, e As EventArgs) Handles Cmd_Clear.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call AccountItemTagging_Load(sender, e)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance

    End Sub
End Class