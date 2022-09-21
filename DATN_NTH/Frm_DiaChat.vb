Imports excel = Microsoft.Office.Interop.Excel

Public Class Frm_DiaChat
    Dim k As Boolean

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Nhão" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 30
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Dẻo" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 30
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Dẻo mềm" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Nửa cứng" Then
            txtHsk.Text = 0.45
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Cứng" Then
            txtHsk.Text = 0.55
            txtHsa.Text = 40
        End If
        ' SÉT PHA
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Nhão" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Dẻo" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Dẻo mềm" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 50
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Nửa cứng" Then
            txtHsk.Text = 0.45
            txtHsa.Text = 50
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Cứng" Then
            txtHsk.Text = 0.55
            txtHsa.Text = 50
        End If
        'CÁT PHA 

        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 80
        End If
        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 70
        End If
        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Xốp" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 60
        End If
        ' CÁT
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.4
            txtHsa.Text = 150
        End If
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 100
        End If
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Xốp" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 60
        End If
        'CUỘI SỎI 
        If cbbLoaiDat.Text = "Cuội sỏi" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 150
        End If
        If cbbLoaiDat.Text = "Cuội sỏi" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 120
        End If

        '----- Them du lieu vao bang Datagridview -------
        If cbbLoaiDat.Text = "" Or cbbTrangThai.Text = "" Or txtChieuDay.Text = "" Or txtDungTrong.Text = "" Or txtmodun.Text = "" Or txtGocMS.Text = "" Or txtDoRoi.Text = "" Or txtQc.Text = "" Or txtN30.Text = "" Then
            MessageBox.Show("Vui lòng nhập đủ thông tin !")
        ElseIf IsNumeric(txtChieuDay.Text) = False Or IsNumeric(txtDungTrong.Text) = False Or IsNumeric(txtmodun.Text) = False Or IsNumeric(txtGocMS.Text) = False Or IsNumeric(txtDoRoi.Text) = False Or IsNumeric(txtQc.Text) = False Or IsNumeric(txtN30.Text) = False Then
            MessageBox.Show("Giá trị vừa nhập không hợp lệ !")
        Else
            If k = True Then
                dgv_diachat.Rows.Add(dgv_diachat.RowCount, cbbLoaiDat.Text, cbbTrangThai.Text, txtChieuDay.Text, txtDungTrong.Text, txtmodun.Text, txtGocMS.Text, txtDoRoi.Text, txtQc.Text, txtN30.Text, txtHsk.Text, txtHsa.Text)
            ElseIf k = False Then
                dgv_diachat.CurrentRow.Cells(0).Value = txtLopDat.Text
                dgv_diachat.CurrentRow.Cells(1).Value = cbbLoaiDat.Text
                dgv_diachat.CurrentRow.Cells(2).Value = cbbTrangThai.Text
                dgv_diachat.CurrentRow.Cells(3).Value = txtChieuDay.Text
                dgv_diachat.CurrentRow.Cells(4).Value = txtDungTrong.Text
                dgv_diachat.CurrentRow.Cells(5).Value = txtmodun.Text
                dgv_diachat.CurrentRow.Cells(6).Value = txtGocMS.Text
                dgv_diachat.CurrentRow.Cells(7).Value = txtDoRoi.Text
                dgv_diachat.CurrentRow.Cells(8).Value = txtQc.Text
                dgv_diachat.CurrentRow.Cells(9).Value = txtN30.Text
                dgv_diachat.CurrentRow.Cells(10).Value = txtHsk.Text
                dgv_diachat.CurrentRow.Cells(11).Value = txtHsa.Text
            End If
        End If

    End Sub

    Private Sub cbbLoaiDat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiDat.SelectedIndexChanged
        Select Case cbbLoaiDat.SelectedIndex
            Case 0
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Nhão")
                cbbTrangThai.Items.Add("Dẻo")
                cbbTrangThai.Items.Add("Dẻo mềm")
                cbbTrangThai.Items.Add("Nửa cứng")
                cbbTrangThai.Items.Add("Cứng")
            Case 1
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Nhão")
                cbbTrangThai.Items.Add("Dẻo")
                cbbTrangThai.Items.Add("Dẻo mềm")
                cbbTrangThai.Items.Add("Nửa cứng")
                cbbTrangThai.Items.Add("Cứng")
            Case 2
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
                cbbTrangThai.Items.Add("Xốp")

            Case 3
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
                cbbTrangThai.Items.Add("Xốp")
            Case 4
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
        End Select
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        k = True
        txtLopDat.Text = ""
        cbbLoaiDat.Text = ""
        cbbTrangThai.Text = ""
        txtChieuDay.Text = ""
        txtDungTrong.Text = ""
        txtmodun.Text = ""
        txtGocMS.Text = ""
        txtDoRoi.Text = ""
        txtQc.Text = ""
        txtN30.Text = ""
        txtHsk.Text = ""
        txtHsa.Text = ""
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        k = False
        If dgv_diachat.RowCount <> 0 Then
            txtLopDat.Text = dgv_diachat.CurrentRow.Cells(0).Value
            cbbLoaiDat.Text = dgv_diachat.CurrentRow.Cells(1).Value
            cbbTrangThai.Text = dgv_diachat.CurrentRow.Cells(2).Value
            txtChieuDay.Text = dgv_diachat.CurrentRow.Cells(3).Value
            txtDungTrong.Text = dgv_diachat.CurrentRow.Cells(4).Value
            txtmodun.Text = dgv_diachat.CurrentRow.Cells(5).Value
            txtGocMS.Text = dgv_diachat.CurrentRow.Cells(6).Value
            txtDoRoi.Text = dgv_diachat.CurrentRow.Cells(7).Value
            txtQc.Text = dgv_diachat.CurrentRow.Cells(8).Value
            txtN30.Text = dgv_diachat.CurrentRow.Cells(9).Value
        Else
            MessageBox.Show("Chưa chọn hàng để sửa!", "Thông báo!")
        End If
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim j = dgv_diachat.RowCount
        Dim index = dgv_diachat.CurrentRow.Index

        '----Xoa du lieu tu bang datagridview--------
        If index < 0 Then
            MessageBox.Show("Chưa chọn hàng cần xóa!", "Thông báo!")
        Else
            dgv_diachat.Rows.RemoveAt(index)
        End If

        '----Danh lai so thu tu lop dat sau khi xoa -----
        For i = 0 To dgv_diachat.RowCount - 2
            dgv_diachat.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub Frm_DiaChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        k = True
    End Sub

    Private Sub btn_hoanthanh_Click(sender As Object, e As EventArgs) Handles btn_hoanthanh.Click
        LST_DiaChat.Clear()
        '------ Them vao list dia chat------
        For i = 0 To dgv_diachat.RowCount - 1
            Dim DiaChat As New Cls_DiaChat

            DiaChat.Lop = Convert.ToInt16(dgv_diachat.Rows(i).Cells(0).Value)
            DiaChat.LoaiDat = Convert.ToString(dgv_diachat.Rows(i).Cells(1).Value)
            DiaChat.TrangThai = Convert.ToString(dgv_diachat.Rows(i).Cells(2).Value)
            DiaChat.ChieuDay = Convert.ToDouble(dgv_diachat.Rows(i).Cells(3).Value)
            DiaChat.DungTrong = Convert.ToDouble(dgv_diachat.Rows(i).Cells(4).Value)
            DiaChat.MoDun = Convert.ToDouble(dgv_diachat.Rows(i).Cells(5).Value)
            DiaChat.GocMS = Convert.ToDouble(dgv_diachat.Rows(i).Cells(6).Value)
            DiaChat.DoRoi = Convert.ToDouble(dgv_diachat.Rows(i).Cells(7).Value)
            DiaChat.Qc = Convert.ToDouble(dgv_diachat.Rows(i).Cells(8).Value)
            DiaChat.N30 = Convert.ToDouble(dgv_diachat.Rows(i).Cells(9).Value)
            DiaChat.Hsk = Convert.ToDouble(dgv_diachat.Rows(i).Cells(10).Value)
            DiaChat.Hsa = Convert.ToDouble(dgv_diachat.Rows(i).Cells(11).Value)

            LST_DiaChat.Add(DiaChat)
        Next
        Me.Close()
    End Sub


    Private Sub btn_nhapexcel_Click(sender As Object, e As EventArgs) Handles btn_nhapexcel.Click
        dgv_diachat.Rows.Clear()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            'Dem so hang
            Dim sh As Integer
            For i As Integer = 2 To 300
                If xlWorkSheet.Cells(i, 1).value <> Nothing Then
                    sh = i - 1
                Else
                    Exit For
                End If
            Next
            Me.dgv_diachat.Rows.Clear()
            For i As Integer = 2 To sh + 1
                dgv_diachat.Rows.Add(xlWorkSheet.Cells(i, 1).value, xlWorkSheet.Cells(i, 2).value, xlWorkSheet.Cells(i, 3).value, xlWorkSheet.Cells(i, 4).value, xlWorkSheet.Cells(i, 5).value, xlWorkSheet.Cells(i, 6).value, xlWorkSheet.Cells(i, 7).value, xlWorkSheet.Cells(i, 8).value, xlWorkSheet.Cells(i, 9).value, xlWorkSheet.Cells(i, 10).value, xlWorkSheet.Cells(i, 11).value, xlWorkSheet.Cells(i, 12).value)
            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If
    End Sub

    Private Sub btn_xuatexcel_Click(sender As Object, e As EventArgs) Handles btn_xuatexcel.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")
            For i = 0 To dgv_diachat.ColumnCount - 1
                xlWorkSheet.Cells(1, i + 1).value = dgv_diachat.Columns(i).HeaderText
            Next
            For i = 0 To dgv_diachat.RowCount - 1
                For j = 0 To dgv_diachat.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1).value = dgv_diachat.Rows(i).Cells(j).Value
                Next
            Next
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
        End If
    End Sub
End Class