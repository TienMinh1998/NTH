Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports Microsoft.Office.Interop
Imports System.Linq
Imports System.Data.Linq
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Frm_NoiLuc
    Public _listT As New List(Of Double)
    Public _listMx As New List(Of Double)
    Public _listMy As New List(Of Double)
    Public _listQx As New List(Of Double)
    Public _listQy As New List(Of Double)
    Public _listNoiLuc As New List(Of NoiLuc)
    Public isActive As Boolean = False
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtN.Text = "" Or txtMx.Text = "" Or txtMy.Text = "" Or txtQx.Text = "" Or txtQy.Text = "" Or txtQy.Text = "" Or txtHSantoan.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ nội lực!")
        ElseIf IsNumeric(txtN.Text) And IsNumeric(txtMx.Text) And IsNumeric(txtMy.Text) And IsNumeric(txtQx.Text) And IsNumeric(txtQy.Text) And IsNumeric(txtHSantoan.Text) Then
            DATA.Ntt = txtN.Text
            DATA.Mxtt = txtMx.Text
            DATA.Mytt = txtMy.Text
            DATA.Qxtt = txtQx.Text
            DATA.Qytt = txtQy.Text
            DATA.HSantoan = txtHSantoan.Text

            Me.Close()
        Else
            MessageBox.Show("Giá trị bạn nhập không hợp lệ!")
        End If
    End Sub

    Private Sub Frm_NoiLuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_load_excel_Click(sender As Object, e As EventArgs) Handles btn_load_excel.Click
        isActive = True
        btn_luu.Enabled = isActive
        dgv_diachat.Rows.Clear()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            'Dem so hang
            Dim sh As Integer = 0
            For i As Integer = 5 To 1000
                If xlWorkSheet.Cells(i, 14).value <> Nothing Then
                    sh = sh + 1
                Else

                End If
            Next
            Me.dgv_diachat.Rows.Clear()
            For i As Integer = 6 To sh + 1
                dgv_diachat.Rows.Add(xlWorkSheet.Cells(i, 14).value,
                                     xlWorkSheet.Cells(i, 15).value,
                                     xlWorkSheet.Cells(i, 16).value,
                                     xlWorkSheet.Cells(i, 17).value,
                                     xlWorkSheet.Cells(i, 18).value)
            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If

        ' Đọc dữ liệu từ Excel
        For index = 0 To dgv_diachat.Rows.Count() - 1 Step 6
            _listT.Add(dgv_diachat.Rows(index).Cells(0).Value)
            _listMx.Add(dgv_diachat.Rows(index + 1).Cells(1).Value)
            _listMy.Add(dgv_diachat.Rows(index + 2).Cells(2).Value)
            _listQx.Add(dgv_diachat.Rows(index + 3).Cells(3).Value)
            _listQy.Add(dgv_diachat.Rows(index + 4).Cells(4).Value)
        Next

        ' Lấy giá trị từ DataGriview
        For index = 0 To _listT.Count() - 1
            Dim nl = New NoiLuc()
            nl.N = _listT(index)
            nl.Mx = _listMx(index)
            nl.My = _listMy(index)
            nl.Qx = _listQx(index)
            nl.Qy = _listQy(index)
            _listNoiLuc.Add(nl)
        Next

        ' Tìm max
        Dim maxValue = _listNoiLuc.Max(Function(x) x.N)
        Dim Item = _listNoiLuc.First(Function(x) x.N.Equals(maxValue))
        ' Gán giá trị cho biến
        txtN.Text = Item.N.ToString()
        txtMx.Text = Math.Abs(Item.Mx).ToString()
        txtMy.Text = Math.Abs(Item.My).ToString()
        txtQx.Text = Math.Abs(Item.Qx).ToString()
        txtQy.Text = Math.Abs(Item.Qy).ToString()

    End Sub
End Class