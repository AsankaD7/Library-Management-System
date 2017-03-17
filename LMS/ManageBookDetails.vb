Imports MySql.Data.MySqlClient
Public Class ManageBookDetails
    Dim cn As New MySqlConnection
    Dim command As MySqlCommand
    Dim handOver As String
    Private Sub ManageBookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combo1()
        load_combo2()
        load_table()
    End Sub
    Private Sub load_combo1()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "select * from library.tbl_bookdetails"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            While Reader.Read
                Dim sISBN = Reader.GetString("ISBN")
                ComboBox_ISBM.Items.Add(sISBN)
            End While
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub load_combo2()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "select * from library.tbl_studentregistration"
            command = New MySqlCommand(Query, cn)
            Reader = command.ExecuteReader
            While Reader.Read
                Dim sReg = Reader.GetString("registration_number")
                ComboBox_RegNo.Items.Add(sReg)
            End While
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        handOver = "True"

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        handOver = "False"
    End Sub

    Private Sub ManageBookDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "insert into tbl_borrowbooksdetails (ISBN,borrowed_date,handover_date,registration_number,handover) values ('" & ComboBox_ISBM.Text & "','" & DateTimePicker_BD.Text & "','" & DateTimePicker_HD.Text & "','" & ComboBox_RegNo.Text & "','" & handOver & "')"
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
    Private Sub load_table()
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            cn.Open()
            Dim Query As String
            Query = "select id as ID,ISBN as ISBN,borrowed_date as BorrowedDate,handover_date as HandoverDate,registration_number as RegNo,handover as Handover from library.tbl_borrowbooksdetails"
            command = New MySqlCommand(Query, cn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Tbl_ManageBookDetails.DataSource = bSource
            SDA.Update(dbDataSet)
            cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            cn.Dispose()

        End Try
    End Sub

    Private Sub Tbl_ManageBookDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_ManageBookDetails.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.Tbl_ManageBookDetails.Rows(e.RowIndex)

            TextBox_ID.Text = row.Cells("ID").Value.ToString
            ComboBox_ISBM.Text = row.Cells("ISBN").Value.ToString
            DateTimePicker_BD.Text = row.Cells("BorrowedDate").Value.ToString
            DateTimePicker_HD.Text = row.Cells("HandoverDate").Value.ToString
            ComboBox_RegNo.Text = row.Cells("RegNo").Value.ToString
            'handOver = row.Cells("Handover").Value.ToString
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        cn.ConnectionString = "server=localhost;userid=root;password=;database=library"
        Dim Reader As MySqlDataReader

        Try
            cn.Open()
            Dim Query As String
            Query = "update library.tbl_borrowbooksdetails set ISBN='" & ComboBox_ISBM.Text & "',borrowed_date='" & DateTimePicker_BD.Text & "',handover_date='" & DateTimePicker_HD.Text & "',registration_number='" & ComboBox_RegNo.Text & "' where id='" & TextBox_ID.Text & "'"
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
            Query = "delete from library.tbl_borroWbooksdetails where id='" & TextBox_ID.Text & "'"
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
End Class