Public Class Frm_vatlieudai
    Private Sub cbb_betong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_betong.SelectedIndexChanged
        Select Case cbb_betong.SelectedIndex
            Case 0
                txtRb.Text = 11500
                txtRbt.Text = 900
                txtEb.Text = 27000000
            Case 1
                txtRb.Text = 14500
                txtRbt.Text = 1050
                txtEb.Text = 30000000
            Case 2
                txtRb.Text = 17000
                txtRbt.Text = 1200
                txtEb.Text = 32500000
            Case 3
                txtRb.Text = 19500
                txtRbt.Text = 1300
                txtEb.Text = 34500000
            Case 4
                txtRb.Text = 22000
                txtRbt.Text = 1400
                txtEb.Text = 36000000
        End Select
    End Sub

    Private Sub cbb_thep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_thep.SelectedIndexChanged
        Select Case cbb_thep.SelectedIndex
            Case 0
                txtRs.Text = 210000
                txtRsc.Text = 210000
                txtEs.Text = 210000000
            Case 1
                txtRs.Text = 260000
                txtRsc.Text = 260000
                txtEs.Text = 210000000
            Case 2
                txtRs.Text = 350000
                txtRsc.Text = 350000
                txtEs.Text = 200000000
            Case 3
                txtRs.Text = 435000
                txtRsc.Text = 4355000
                txtEs.Text = 200000000
        End Select
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        DaiMong.Betong = cbb_betong.Text
        DaiMong.Rb = txtRb.Text
        DaiMong.Rbt = txtRbt.Text
        DaiMong.Eb = txtEb.Text
        DaiMong.Thep = cbb_thep.Text
        DaiMong.Rs = txtRs.Text
        DaiMong.Rsc = txtRsc.Text
        DaiMong.Es = txtEs.Text

        Me.Close()

    End Sub

    Private Sub Frm_vatlieudai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class