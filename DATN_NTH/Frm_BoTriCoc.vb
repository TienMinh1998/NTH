Public Class Frm_BoTriCoc
    Private Sub btn_sct_Click(sender As Object, e As EventArgs) Handles btn_sct.Click
        Try
            txtPvl.Text = Tinh.Pvl()
            txtPcpt.Text = Tinh.Pcpt()
            txtPspt.Text = Tinh.Pspt()
        Catch

        End Try
    End Sub

    Private Sub btn_Botricoc_Click(sender As Object, e As EventArgs) Handles btn_Botricoc.Click
        Try
            Dim sococ As Double
            Dim Dc As Double
            Dim z As Double     'khoang cach giua cac truc coc
            Dim Bd As Double
            Dim Ld As Double

            sococ = cbbSococ.Text
            Dc = Coc.Dc
            z = Val(txtKC.Text) * Dc

            dgv_botricoc.RowCount = sococ       'so dong bang so coc (moi coc mot dong)
            Select Case cbbSococ.SelectedIndex
                Case 0      'bo tri 2 coc
                    'Bd = Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = z + Dc + 2 * DaiMong.KcCocdenDai

                    'coc 1
                    dgv_botricoc.Rows(0).Cells(0).Value = 1
                    dgv_botricoc.Rows(0).Cells(1).Value = -(z / 2)
                    dgv_botricoc.Rows(0).Cells(2).Value = 0
                    'coc 2
                    dgv_botricoc.Rows(1).Cells(0).Value = 2
                    dgv_botricoc.Rows(1).Cells(1).Value = (z / 2)
                    dgv_botricoc.Rows(1).Cells(2).Value = 0

                Case 1      'bo tri 3 coc
                    'Bd = Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = z + Dc + 2 * DaiMong.KcCocdenDai

                    'coc 1
                    dgv_botricoc.Rows(0).Cells(0).Value = 1
                    dgv_botricoc.Rows(0).Cells(1).Value = -z
                    dgv_botricoc.Rows(0).Cells(2).Value = 0
                    'coc 2
                    dgv_botricoc.Rows(1).Cells(0).Value = 2
                    dgv_botricoc.Rows(1).Cells(1).Value = 0
                    dgv_botricoc.Rows(1).Cells(2).Value = 0
                    'coc 3
                    dgv_botricoc.Rows(2).Cells(0).Value = 3
                    dgv_botricoc.Rows(2).Cells(1).Value = z
                    dgv_botricoc.Rows(2).Cells(2).Value = 0

                Case 2      'bo tri 4 coc
                    'Bd = z + Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = z + Dc + 2 * DaiMong.KcCocdenDai

                    For i = 0 To 1
                        'hang 1
                        dgv_botricoc.Rows(i).Cells(0).Value = i + 1
                        dgv_botricoc.Rows(i).Cells(1).Value = -(z / 2) + i * z
                        dgv_botricoc.Rows(i).Cells(2).Value = z / 2
                        'hang 2
                        dgv_botricoc.Rows(i + 2).Cells(0).Value = i + 3
                        dgv_botricoc.Rows(i + 2).Cells(1).Value = -(z / 2) + i * z
                        dgv_botricoc.Rows(i + 2).Cells(2).Value = -z / 2
                    Next

                Case 3      'bo tri 5 coc
                    'Bd = z + Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = z + Dc + 2 * DaiMong.KcCocdenDai

                    For i = 0 To 1
                        'hang 1
                        dgv_botricoc.Rows(i).Cells(0).Value = i + 1
                        dgv_botricoc.Rows(i).Cells(1).Value = -(z / 2) + i * z
                        dgv_botricoc.Rows(i).Cells(2).Value = z / 2
                        'hang 2
                        dgv_botricoc.Rows(i + 3).Cells(0).Value = i + 4
                        dgv_botricoc.Rows(i + 3).Cells(1).Value = -(z / 2) + i * z
                        dgv_botricoc.Rows(i + 3).Cells(2).Value = -z / 2
                    Next
                    'coc giua dai
                    dgv_botricoc.Rows(2).Cells(0).Value = 3
                    dgv_botricoc.Rows(2).Cells(1).Value = 0
                    dgv_botricoc.Rows(2).Cells(2).Value = 0

                Case 4      'bo tri 6 coc
                    'Bd = 2 * z + Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = 2 * z + Dc + 2 * DaiMong.KcCocdenDai
                    For i = 0 To 2
                        'hang 1
                        dgv_botricoc.Rows(i).Cells(0).Value = i + 1
                        dgv_botricoc.Rows(i).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i).Cells(2).Value = z / 2
                        'hang 2
                        dgv_botricoc.Rows(i + 3).Cells(0).Value = i + 4
                        dgv_botricoc.Rows(i + 3).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i + 3).Cells(2).Value = -z / 2
                    Next

                Case 5      'bo tri 7 coc
                    'Bd = 2 * z + Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = 2 * z + Dc + 2 * DaiMong.KcCocdenDai
                    For i = 0 To 2
                        'hang 1
                        dgv_botricoc.Rows(i).Cells(0).Value = i + 1
                        dgv_botricoc.Rows(i).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i).Cells(2).Value = z
                        'hang 2
                        dgv_botricoc.Rows(i + 4).Cells(0).Value = i + 5
                        dgv_botricoc.Rows(i + 4).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i + 4).Cells(2).Value = -z
                    Next
                    'coc giua dai
                    dgv_botricoc.Rows(3).Cells(0).Value = 4
                    dgv_botricoc.Rows(3).Cells(1).Value = 0
                    dgv_botricoc.Rows(3).Cells(2).Value = 0

                Case 6      'bo tri 8 coc
                    'Bd = 3 * z + Dc + 2 * DaiMong.KcCocdenDai
                    'Ld = 3 * z + Dc + 2 * DaiMong.KcCocdenDai

                    For i = 0 To 2
                        'hang 1
                        dgv_botricoc.Rows(i).Cells(0).Value = i + 1
                        dgv_botricoc.Rows(i).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i).Cells(2).Value = z
                        'hang 2
                        dgv_botricoc.Rows(i + 3).Cells(0).Value = i + 4
                        dgv_botricoc.Rows(i + 3).Cells(1).Value = -z + i * z
                        dgv_botricoc.Rows(i + 3).Cells(2).Value = -z
                    Next

                    ''coc 1
                    'dgv_botricoc.Rows(0).Cells(0).Value = 1
                    'dgv_botricoc.Rows(0).Cells(1).Value = -z - z / 2
                    'dgv_botricoc.Rows(0).Cells(2).Value = z / 2

                    ''coc 2
                    'dgv_botricoc.Rows(1).Cells(0).Value = 2
                    'dgv_botricoc.Rows(1).Cells(1).Value = -z / 2
                    'dgv_botricoc.Rows(1).Cells(2).Value = z / 2

                    ''coc 3
                    'dgv_botricoc.Rows(2).Cells(0).Value = 3
                    'dgv_botricoc.Rows(2).Cells(1).Value = z / 2
                    'dgv_botricoc.Rows(2).Cells(2).Value = z / 2

                    ''coc 4
                    'dgv_botricoc.Rows(3).Cells(0).Value = 4
                    'dgv_botricoc.Rows(3).Cells(1).Value = z + z / 2
                    'dgv_botricoc.Rows(3).Cells(2).Value = z / 2

                    ''coc 5
                    'dgv_botricoc.Rows(4).Cells(0).Value = 5
                    'dgv_botricoc.Rows(4).Cells(1).Value = -z - z / 2
                    'dgv_botricoc.Rows(4).Cells(2).Value = -z / 2

                    ''coc 6
                    'dgv_botricoc.Rows(5).Cells(0).Value = 6
                    'dgv_botricoc.Rows(5).Cells(1).Value = -z / 2
                    'dgv_botricoc.Rows(5).Cells(2).Value = -z / 2

                    'coc 7
                    dgv_botricoc.Rows(6).Cells(0).Value = 7
                    dgv_botricoc.Rows(6).Cells(1).Value = -z
                    dgv_botricoc.Rows(6).Cells(2).Value = 0

                    'coc 8
                    dgv_botricoc.Rows(7).Cells(0).Value = 8
                    dgv_botricoc.Rows(7).Cells(1).Value = z
                    dgv_botricoc.Rows(7).Cells(2).Value = 0

            End Select
        Catch

        End Try

    End Sub

    Private Sub btn_kiemtra_Click(sender As Object, e As EventArgs) Handles btn_kiemtra.Click
        Try
            If dgv_botricoc.RowCount = 0 Then
                MessageBox.Show("Bạn chưa bố trí cọc!", "Thông báo !")
            Else
                '----kich thuoc dai------
                Dim maxX As Double
                Dim maxY As Double
                maxX = (dgv_botricoc.Rows(0).Cells(1).Value)
                maxY = (dgv_botricoc.Rows(0).Cells(2).Value)
                For i = 0 To dgv_botricoc.RowCount - 1
                    If maxX <= Math.Abs(Convert.ToDouble(dgv_botricoc.Rows(i).Cells(1).Value)) Then
                        maxX = Math.Abs(Convert.ToDouble(dgv_botricoc.Rows(i).Cells(1).Value))
                    End If
                Next
                For i = 0 To dgv_botricoc.RowCount - 1
                    If maxY <= Math.Abs(Convert.ToDouble(dgv_botricoc.Rows(i).Cells(2).Value)) Then
                        maxY = Math.Abs(Convert.ToDouble(dgv_botricoc.Rows(i).Cells(2).Value))
                    End If
                Next

                txtLd.Text = 2 * maxX + Coc.Dc + 2 * DaiMong.KcCocdenDai
                txtBd.Text = 2 * maxY + Coc.Dc + 2 * DaiMong.KcCocdenDai

                '-----tinh tai trong tac dung len coc-----
                Dim Sx As Double
                Dim Sy As Double
                Sx = 0
                Sy = 0
                For i = 0 To dgv_botricoc.RowCount - 1
                    Sx = Sx + Convert.ToDouble(dgv_botricoc.Rows(i).Cells(1).Value) * Convert.ToDouble(dgv_botricoc.Rows(i).Cells(1).Value)
                    Sy = Sy + Convert.ToDouble(dgv_botricoc.Rows(i).Cells(2).Value) * Convert.ToDouble(dgv_botricoc.Rows(i).Cells(2).Value)
                Next

                Dim Ntc As Double = (Ntt / HSantoan) + Convert.ToDouble(txtBd.Text) * Convert.ToDouble(txtLd.Text) * DaiMong.Hm * 20
                Dim Mxtc As Double = Mxtt / HSantoan
                Dim Mytc As Double = Mytt / HSantoan
                Dim sococ As Double
                sococ = dgv_botricoc.RowCount

                If sococ = 2 Or sococ = 3 Then
                    For i = 0 To dgv_botricoc.RowCount - 1
                        dgv_botricoc.Rows(i).Cells(3).Value = Math.Round((Ntc / sococ) + (Mytc * Val(dgv_botricoc.Rows(i).Cells(1).Value) / Sx), 2)
                        dgv_botricoc.Rows(i).Cells(4).Value = Math.Round((Ntt / sococ) + (Mytt * Val(dgv_botricoc.Rows(i).Cells(1).Value) / Sx), 2)
                    Next
                Else
                    For i = 0 To dgv_botricoc.RowCount - 1
                        dgv_botricoc.Rows(i).Cells(3).Value = Math.Round((Ntc / sococ) + (Mytc * Val(dgv_botricoc.Rows(i).Cells(1).Value) / Sx) + (Mxtc * Val(dgv_botricoc.Rows(i).Cells(2).Value) / Sy), 2)
                        dgv_botricoc.Rows(i).Cells(4).Value = Math.Round((Ntt / sococ) + (Mytt * Val(dgv_botricoc.Rows(i).Cells(1).Value) / Sx) + (Mxtt * Val(dgv_botricoc.Rows(i).Cells(2).Value) / Sy), 2)
                    Next
                End If

                '-----Kiem tra coc trong giai doan su dung------

                Dim SCT As Double
                If cbbSCT.Text = "" Then
                    MessageBox.Show("Vui lòng chọn sức chịu tải cho phép của cọc!", "Thông báo !")
                ElseIf cbbSCT.Text = "Pvl" Then
                    SCT = Tinh.Pvl()
                ElseIf cbbSCT.Text = "Pcpt" Then
                    SCT = Tinh.Pcpt()
                ElseIf cbbSCT.Text = "Pspt" Then
                    SCT = Tinh.Pspt()
                End If

                Dim Pimax As Double
                Pimax = dgv_botricoc.Rows(0).Cells(3).Value
                For i = 0 To dgv_botricoc.RowCount - 1
                    If Pimax <= dgv_botricoc.Rows(i).Cells(3).Value Then
                        Pimax = dgv_botricoc.Rows(i).Cells(3).Value
                    End If

                    If Pimax + 25 * Coc.Lc * Coc.Dc * Coc.Dc <= SCT Then
                        lbKiemtra.ForeColor = Color.Blue
                        lbKiemtra.Text = "Pimax = " & Pimax + 25 * Coc.Lc * Coc.Dc * Coc.Dc & " kN < " & "[P] = " & Math.Round(SCT) & " kN" & vbCrLf & "Cọc đủ khả năng chịu lực!"
                    Else
                        lbKiemtra.ForeColor = Color.Red
                        lbKiemtra.Text = "Pimax = " & Pimax + 25 * Coc.Lc * Coc.Dc * Coc.Dc & " kN > " & "[P] = " & Math.Round(SCT) & " kN" & vbCrLf & "Cọc không đủ khả năng chịu lực!"
                    End If
                Next
            End If
        Catch

        End Try
    End Sub

    Private Sub cbbSCT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSCT.SelectedIndexChanged
        Try
            Select Case cbbSCT.SelectedIndex
                Case 0
                    txtsococsobo.Text = Math.Round(Ntt * 1.2 / Tinh.Pcpt(), 2).ToString
                Case 1
                    txtsococsobo.Text = Math.Round(Ntt * 1.2 / Tinh.Pspt(), 2).ToString
                Case 2
                    txtsococsobo.Text = Math.Round(Ntt * 1.2 / Tinh.Pvl(), 2).ToString
            End Select
        Catch
        End Try
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Try
            If dgv_botricoc.RowCount = 0 Then
                MessageBox.Show("Bạn chưa bố trí cọc!", "Thông báo !")
            Else
                DaiMong.Bd = txtBd.Text
                DaiMong.Ld = txtLd.Text

                LST_Coc.Clear()

                For i = 0 To dgv_botricoc.RowCount - 1
                    Dim DSCoc As New cls_LstCoc
                    DSCoc.STT = dgv_botricoc.Rows(i).Cells(0).Value
                    DSCoc.X = dgv_botricoc.Rows(i).Cells(1).Value
                    DSCoc.Y = dgv_botricoc.Rows(i).Cells(2).Value
                    DSCoc.Pi = dgv_botricoc.Rows(i).Cells(3).Value
                    DSCoc.Poi = dgv_botricoc.Rows(i).Cells(4).Value

                    LST_Coc.Add(DSCoc)      'them thong tin vao list
                Next
                'MessageBox.Show(LST_Coc(0).Poi & "-" & LST_Coc(1).Poi)
                Me.Close()
            End If
        Catch
        End Try
    End Sub

    Private Sub cbbSococ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSococ.SelectedIndexChanged

    End Sub

    Private Sub Frm_BoTriCoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class