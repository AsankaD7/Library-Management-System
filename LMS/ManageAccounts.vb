Imports MySql.Data.MySqlClient
Public Class ManageAccounts
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "insert into tbl_studentregistration (email,phoneno,classroll_number,password) values ('" & TextBox_Email.Text & "','" & TextBox_PhoneNo.Text & "','" & TextBox_ClassrollNo.Text & "','" & TextBox_Password.Text & "')"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            MessageBox.Show("Data Saved")
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()
        End Try
        load_table()
    End Sub
    Private Sub load_table()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            cn.Open()
            Dim Query As String
            Query = "select registration_number as RegNo,email as Email,phoneno as PhoneNo,classroll_number as ClassRollNo,password as Password from library.tbl_studentregistration"
            command = New MySqlCommand(Query, cn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_Accounts.DataSource = bSource
            SDA.Update(dbDataSet)
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "update library.tbl_studentregistration set email='" & TextBox_Email.Text & "',phoneno='" & TextBox_PhoneNo.Text & "',classroll_number='" & TextBox_ClassrollNo.Text & "',password='" & TextBox_Password.Text & "' where registration_number='" & TextBox_RegNo.Text & "'"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            MessageBox.Show("Data Updated")
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

            load_table()

        End Try
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "delete from library.tbl_studentregistration where registration_number='" & TextBox_RegNo.Text & "'"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            MessageBox.Show("Data Deleted")
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
        load_table()
    End Sub

    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Private Sub DataGridView_Accounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Accounts.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView_Accounts.Rows(e.RowIndex)

            TextBox_RegNo.Text = row.Cells("RegNo").Value.ToString
            TextBox_Email.Text = row.Cells("Email").Value.ToString
            TextBox_PhoneNo.Text = row.Cells("PhoneNo").Value.ToString
            TextBox_ClassrollNo.Text = row.Cells("ClassRollNo").Value.ToString
            TextBox_Password.Text = row.Cells("Password").Value.ToString
        End If
    End Sub
End Class