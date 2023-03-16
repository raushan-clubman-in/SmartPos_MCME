
Public Class ITEMTAGTABLE

    Dim Vconn As New GlobalClass

    Private Sub PosItemStoreTagging_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call Resize_Form()
        Call FILLDATA()

    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Public Sub FILLDATA()

        Dim i, j As Integer
        SQLSTRING = "SELECT ISNULL(ITEMCODE,'')AS ITEMCODE , ISNULL(TABLEMONEY,0)AS TABLEMONEY , ISNULL(ACCODE,'')AS ACCODE FROM ITEMTAGTABLE  ORDER BY  ITEMCODE"
        Vconn.getDataSet(SQLSTRING, "ITEMTAG")
        If gdataset.Tables("ITEMTAG").Rows.Count > 0 Then
            ssgrid1.MaxRows = gdataset.Tables("ITEMTAG").Rows.Count + 10
            j = 1
            For i = 0 To gdataset.Tables("ITEMTAG").Rows.Count - 1
                j = j + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("ITEMTAG").Rows(i).Item("ITEMCODE")
                    .Col = 2
                    .Text = gdataset.Tables("ITEMTAG").Rows(i).Item("TABLEMONEY")
                    .Col = 3
                    .Text = gdataset.Tables("ITEMTAG").Rows(i).Item("ACCODE")
                End With
                'ssgrid1.MaxRows = ssgrid1.MaxRows + 1

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

                            L = L + 5
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




    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        With ssgrid1
            If .ActiveCol = 1 Then
                .Row = .ActiveRow
                If .Text = "" And e.keyCode = 13 Then
                    Call FillITEM()
                End If
            ElseIf .ActiveCol = 2 Then
                .Row = .ActiveRow
                .Col = 2
                If Val(.Text) <> 0 And e.keyCode = 13 Then
                    .SetActiveCell(3, ssgrid1.ActiveRow)
                End If

            ElseIf .ActiveCol = 3 Then
                .Row = .ActiveRow
                .Col = 3

                If .Text = "" And e.keyCode = 13 Then
                    Call FillMenu()
                End If
            End If
        End With
    End Sub
    Private Sub FillMenu()
        Dim vform As New LIST_OPERATION1
        Dim ssql As String
        gSQLString = "SELECT accode ,acdesc  FROM accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE ISNULL(FREZEEFLAG,'') <> 'Y' --AND ISNULL(STORESTATUS,'') <> 'M'"
        Else
            M_WhereCondition = " WHERE ISNULL(FREZEEFLAG,'') <> 'Y' --AND ISNULL(STORESTATUS,'') <> 'M' "
        End If
        vform.Field = "ACCODE,ACDESC"
        'vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ACCOUNTS CODE HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield
                .SetActiveCell(1, ssgrid1.ActiveRow + 1)
            End With
        Else
            ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub
    Private Sub FillITEM()
        Dim vform As New LIST_OPERATION1
        Dim ssql As String
        gSQLString = "SELECT ITEMCODE ,ITEMDESC  FROM ITEMMASTER  "
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y' AND ISNULL(CATEGORY,'')=  'EXTRA MESSING'"
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y' AND ISNULL(CATEGORY,'') ='EXTRA MESSING' "
        End If
        vform.Field = "ITEMCODE,ITEMDESC"
        'vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ITEMMASTER CODE HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield
                .SetActiveCell(2, ssgrid1.ActiveRow)
            End With
        Else
            ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmd_Add.Click
        Dim i As Integer
        Dim itemcd, ACCODE, ssql As String
        Dim MONEY

        If ssgrid1.DataRowCnt <= 1 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        ssql = "Delete from ITEMTAGTABLE "
        Vconn.dataOperation(6, ssql, "DelItem")
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 2
                MONEY = Val(.Text)
                .Col = 3
                ACCODE = .Text
                If Trim(itemcd) <> "" Then
                    ssql = "INSERT INTO ITEMTAGTABLE (ITEMCODE,TABLEMONEY,ACCODE) VALUES ('" & itemcd & "'," & MONEY & ",'" & ACCODE & "')"
                    Vconn.dataOperation(6, ssql, "InsItem")
                End If
            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmd_Clear.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        'Call PosItemStoreTagging_Load(sender, e)
        Call FILLDATA()

    End Sub

    Private Sub LBL_POSWISE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_POSWISE.Click

    End Sub
End Class