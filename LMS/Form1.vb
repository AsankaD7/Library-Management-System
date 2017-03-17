Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand

    Private Sub Connection_Click(sender As Object, e As EventArgs) Handles Connection.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"

        Try
            cn.Open()
            MessageBox.Show("Connection sucessful")
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub Button_Registration_Click(sender As Object, e As EventArgs) Handles Button_Registration.Click
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_LogIn_Click(sender As Object, e As EventArgs) Handles Button_LogIn.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "select * from library.tbl_studentregistration where email='" & TextBox_UserName.Text & "' and password='" & TextBox_Password.Text & "'"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")
                SearchBooks.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are not correct")
            End If
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()



        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminPannel.Show()
        Me.Hide()

    End Sub
End Class
