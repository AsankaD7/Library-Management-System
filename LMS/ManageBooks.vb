Imports MySql.Data.MySqlClient
Public Class ManageBooks
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "insert into tbl_bookdetails (ISBN,title,author,location) values ('" & TextBox_ISBN.Text & "','" & TextBox_Title.Text & "','" & TextBox_Author.Text & "','" & TextBox_Location.Text & "')"
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

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click

        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "update library.tbl_bookdetails set ISBN='" & TextBox_ISBN.Text & "',title='" & TextBox_Title.Text & "',author='" & TextBox_Author.Text & "',location='" & TextBox_Location.Text & "' where ISBN='" & TextBox_ISBN.Text & "'"
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
            Query = "delete from library.tbl_bookdetails where ISBN='" & TextBox_ISBN.Text & "'"
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

    Private Sub ManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Query = "select ISBN as ISBN,title as Title,author as Author,location as Location from library.tbl_bookdetails"
            command = New MySqlCommand(Query, cn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_Books.DataSource = bSource
            SDA.Update(dbDataSet)
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub DataGridView_Books_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Books.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView_Books.Rows(e.RowIndex)

            TextBox_ISBN.Text = row.Cells("ISBN").Value.ToString
            TextBox_Title.Text = row.Cells("title").Value.ToString
            TextBox_Author.Text = row.Cells("author").Value.ToString
            TextBox_Location.Text = row.Cells("location").Value.ToString
        End If
    End Sub
End Class