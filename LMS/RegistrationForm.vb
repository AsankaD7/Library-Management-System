Imports MySql.Data.MySqlClient
Public Class RegistrationForm
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "insert into library.tbl_studentregistration (email,phoneno,classroll_number,password) values ('" & TextBox_Email.Text & "','" & TextBox_PhoneNo.Text & "','" & TextBoxClassRollNo.Text & "','" & TextBox_Password.Text & "')"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            MessageBox.Show("Data Saved")
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub Button_SignOut_Click(sender As Object, e As EventArgs) Handles Button_SignOut.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class