Imports MySql.Data.MySqlClient
Public Class SearchBooks
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Sub Button_SignOut_Click(sender As Object, e As EventArgs) Handles Button_SignOut.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
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

    Private Sub load_table()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim SDA As New MySqlDataAdapter
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

    Private Sub SearchBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

    End Sub

    Private Sub TextBox_ISBN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ISBN.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("ISBN Like '%{0}%'", TextBox_ISBN.Text)
        DataGridView_Books.DataSource = DV
    End Sub

    Private Sub TextBox_Title_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Title.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("title Like '%{0}%'", TextBox_Title.Text)
        DataGridView_Books.DataSource = DV
    End Sub

    Private Sub TextBox_Author_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Author.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("author Like '%{0}%'", TextBox_Author.Text)
        DataGridView_Books.DataSource = DV
    End Sub

    Private Sub TextBox_Location_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Location.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("location Like '%{0}%'", TextBox_Location.Text)
        DataGridView_Books.DataSource = DV
    End Sub
End Class