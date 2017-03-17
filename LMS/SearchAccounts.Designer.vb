<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAccounts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_SignOut = New System.Windows.Forms.Button()
        Me.TextBox_ClassRoleNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_RegNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView_Accounts = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Accounts"
        '
        'Button_SignOut
        '
        Me.Button_SignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SignOut.Location = New System.Drawing.Point(587, 14)
        Me.Button_SignOut.Name = "Button_SignOut"
        Me.Button_SignOut.Size = New System.Drawing.Size(92, 26)
        Me.Button_SignOut.TabIndex = 15
        Me.Button_SignOut.Text = "SignOut"
        Me.Button_SignOut.UseVisualStyleBackColor = True
        '
        'TextBox_ClassRoleNo
        '
        Me.TextBox_ClassRoleNo.Location = New System.Drawing.Point(441, 110)
        Me.TextBox_ClassRoleNo.Name = "TextBox_ClassRoleNo"
        Me.TextBox_ClassRoleNo.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_ClassRoleNo.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "ClassRole No"
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(139, 108)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_PhoneNo.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Phone No"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Location = New System.Drawing.Point(441, 69)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_Email.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Email"
        '
        'TextBox_RegNo
        '
        Me.TextBox_RegNo.Location = New System.Drawing.Point(139, 69)
        Me.TextBox_RegNo.Name = "TextBox_RegNo"
        Me.TextBox_RegNo.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_RegNo.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "RegNo"
        '
        'DataGridView_Accounts
        '
        Me.DataGridView_Accounts.AllowUserToAddRows = False
        Me.DataGridView_Accounts.AllowUserToDeleteRows = False
        Me.DataGridView_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Accounts.Location = New System.Drawing.Point(12, 159)
        Me.DataGridView_Accounts.Name = "DataGridView_Accounts"
        Me.DataGridView_Accounts.ReadOnly = True
        Me.DataGridView_Accounts.Size = New System.Drawing.Size(667, 303)
        Me.DataGridView_Accounts.TabIndex = 34
        '
        'SearchAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 474)
        Me.Controls.Add(Me.DataGridView_Accounts)
        Me.Controls.Add(Me.TextBox_ClassRoleNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_PhoneNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_RegNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_SignOut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchAccounts"
        Me.Text = "SearchAccounts"
        CType(Me.DataGridView_Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_SignOut As Button
    Friend WithEvents TextBox_ClassRoleNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_RegNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView_Accounts As DataGridView
End Class
