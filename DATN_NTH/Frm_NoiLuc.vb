Public Class Frm_NoiLuc
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
End Class