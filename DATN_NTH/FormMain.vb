Public Class Main
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttNhapDS.Click
        vl.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub btn_nhapdiachat_Click(sender As Object, e As EventArgs) Handles btn_nhapdiachat.Click
        Frm_DiaChat.ShowDialog()
    End Sub

    Private Sub btn_khaibaovatlieucoc_Click(sender As Object, e As EventArgs) Handles btn_khaibaovatlieucoc.Click
        Frm_vatlieucoc.ShowDialog()
    End Sub

    Private Sub btn_khaibaovatlieudai_Click(sender As Object, e As EventArgs) Handles btn_khaibaovatlieudai.Click
        Frm_vatlieudai.ShowDialog()
    End Sub

    Private Sub KhaiBáoNộiLựcTínhToánToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhaiBáoNộiLựcTínhToánToolStripMenuItem.Click
        Frm_NoiLuc.ShowDialog()
    End Sub

    Private Sub btn_botricoc_Click(sender As Object, e As EventArgs) Handles btn_botricoc.Click
        Frm_BoTriCoc.ShowDialog()
    End Sub

    Private Sub btn_chon_kichthuoccoc_Click(sender As Object, e As EventArgs) Handles btn_chon_kichthuoccoc.Click
        Frm_DuLieuCoc.ShowDialog()
    End Sub
End Class