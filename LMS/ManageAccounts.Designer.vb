<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ClassrollNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_RegNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView_Accounts = New System.Windows.Forms.DataGridView()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(452, 131)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(202, 26)
        Me.TextBox_Password.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(359, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Password"
        '
        'TextBox_ClassrollNo
        '
        Me.TextBox_ClassrollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ClassrollNo.Location = New System.Drawing.Point(159, 131)
        Me.TextBox_ClassrollNo.Name = "TextBox_ClassrollNo"
        Me.TextBox_ClassrollNo.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_ClassrollNo.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Classroll No"
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(452, 94)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(202, 26)
        Me.TextBox_PhoneNo.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Phone No"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(159, 97)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_Email.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Email"
        '
        'TextBox_RegNo
        '
        Me.TextBox_RegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_RegNo.Location = New System.Drawing.Point(159, 65)
        Me.TextBox_RegNo.Name = "TextBox_RegNo"
        Me.TextBox_RegNo.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_RegNo.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Reg No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 29)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Manage Accounts"
        '
        'DataGridView_Accounts
        '
        Me.DataGridView_Accounts.AllowUserToAddRows = False
        Me.DataGridView_Accounts.AllowUserToDeleteRows = False
        Me.DataGridView_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Accounts.Location = New System.Drawing.Point(8, 178)
        Me.DataGridView_Accounts.Name = "DataGridView_Accounts"
        Me.DataGridView_Accounts.ReadOnly = True
        Me.DataGridView_Accounts.Size = New System.Drawing.Size(667, 283)
        Me.DataGridView_Accounts.TabIndex = 39
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(469, 467)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(100, 25)
        Me.Button_Delete.TabIndex = 43
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Edit.Location = New System.Drawing.Point(363, 467)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(100, 25)
        Me.Button_Edit.TabIndex = 42
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(575, 467)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 25)
        Me.Button_Cancel.TabIndex = 41
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Add.Location = New System.Drawing.Point(257, 467)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(100, 25)
        Me.Button_Add.TabIndex = 40
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'ManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 504)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DataGridView_Accounts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_RegNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ClassrollNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_PhoneNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ManageAccounts"
        Me.Text = "ManageAccounts"
        CType(Me.DataGridView_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ClassrollNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_RegNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView_Accounts As DataGridView
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Add As Button
End Class
