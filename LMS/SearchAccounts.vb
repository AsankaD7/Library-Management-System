Imports MySql.Data.MySqlClient
Public Class SearchAccounts
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Sub SearchAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub
    Private Sub load_table()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim SDA As New MySqlDataAdapter
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

    Private Sub Button_SignOut_Click(sender As Object, e As EventArgs) Handles Button_SignOut.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_RegNo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_RegNo.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("registration_number Like '%{0}%'", TextBox_RegNo.Text)
        DataGridView_Accounts.DataSource = DV
    End Sub

    Private Sub TextBox_Email_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Email.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("email Like '%{0}%'", TextBox_Email.Text)
        DataGridView_Accounts.DataSource = DV
    End Sub

    Private Sub TextBox_PhoneNo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_PhoneNo.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("phoneno Like '%{0}%'", TextBox_PhoneNo.Text)
        DataGridView_Accounts.DataSource = DV
    End Sub

    Private Sub TextBox_ClassRoleNo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ClassRoleNo.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("classroll_number Like '%{0}%'", TextBox_ClassRoleNo.Text)
        DataGridView_Accounts.DataSource = DV
    End Sub
End Class