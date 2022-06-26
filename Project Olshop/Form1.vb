Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TBUser.Text = "intan" Or TBPass.Text = "intan" Then
            Me.Close()
        End If

        FormHu.ShowDialog()
    End Sub
End Class