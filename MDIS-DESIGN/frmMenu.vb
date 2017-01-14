Public Class frmMenu
    Private Sub mniLogin_Click(sender As Object, e As EventArgs) Handles mniLogin.Click
        Dim Login As frmLogin
        Login = New frmLogin
        Login.MdiParent = Me
        Login.Show()

    End Sub
End Class