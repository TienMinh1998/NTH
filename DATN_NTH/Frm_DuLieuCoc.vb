Public Class Frm_DuLieuCoc
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtDc.Text = "" Or txtLc.Text = "" Or txtLngam.Text = "" Or txtSothanhthep.Text = "" Or cbbDKthep.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin của Cọc!", "Thông báo !")
        ElseIf IsNumeric(txtDc.Text) And IsNumeric(txtLc.Text) And IsNumeric(txtLngam.Text) And IsNumeric(txtSothanhthep.Text) And IsNumeric(cbbDKthep.Text) Then
            Coc.Dc = txtDc.Text
            Coc.Lc = txtLc.Text
            Coc.Lngam = txtLngam.Text
            Coc.Sothanhthep = txtSothanhthep.Text
            Coc.DKthep = cbbDKthep.Text

            Me.Close()
        Else
            MessageBox.Show("Giá trị vừa nhập không hợp lệ!")
        End If
    End Sub

    Private Sub Frm_DuLieuCoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class