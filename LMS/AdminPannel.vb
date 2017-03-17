Public Class AdminPannel
    Private Sub Button_ManageBooks_Click(sender As Object, e As EventArgs) Handles Button_ManageBooks.Click
        ManageBooks.Show()
        Me.Hide()
    End Sub

    Private Sub Button_ManageAccounts_Click(sender As Object, e As EventArgs) Handles Button_ManageAccounts.Click
        ManageAccounts.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManageBookDetails.Show()
        Me.Hide()
    End Sub

    Private Sub Button_SearchAcc_Click(sender As Object, e As EventArgs) Handles Button_SearchAcc.Click
        SearchAccounts.Show()
        Me.Hide()
    End Sub
End Class