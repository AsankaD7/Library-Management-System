<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_PhoneNo = New System.Windows.Forms.TextBox()
        Me.TextBoxClassRollNo = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_SignOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Registration Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class Roll No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(166, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Confirm Password"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(350, 131)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(266, 26)
        Me.TextBox_Email.TabIndex = 6
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(350, 162)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(266, 26)
        Me.TextBox_PhoneNo.TabIndex = 7
        '
        'TextBoxClassRollNo
        '
        Me.TextBoxClassRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClassRollNo.Location = New System.Drawing.Point(350, 194)
        Me.TextBoxClassRollNo.Name = "TextBoxClassRollNo"
        Me.TextBoxClassRollNo.Size = New System.Drawing.Size(266, 26)
        Me.TextBoxClassRollNo.TabIndex = 8
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(350, 226)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(266, 26)
        Me.TextBox_Password.TabIndex = 9
        '
        'TextBox_ConfirmPassword
        '
        Me.TextBox_ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ConfirmPassword.Location = New System.Drawing.Point(350, 258)
        Me.TextBox_ConfirmPassword.Name = "TextBox_ConfirmPassword"
        Me.TextBox_ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_ConfirmPassword.Size = New System.Drawing.Size(266, 26)
        Me.TextBox_ConfirmPassword.TabIndex = 10
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(404, 302)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(100, 25)
        Me.Button_Save.TabIndex = 11
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(516, 302)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 25)
        Me.Button_Cancel.TabIndex = 12
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_SignOut
        '
        Me.Button_SignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SignOut.Location = New System.Drawing.Point(543, 22)
        Me.Button_SignOut.Name = "Button_SignOut"
        Me.Button_SignOut.Size = New System.Drawing.Size(92, 26)
        Me.Button_SignOut.TabIndex = 13
        Me.Button_SignOut.Text = "SignOut"
        Me.Button_SignOut.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 421)
        Me.Controls.Add(Me.Button_SignOut)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.TextBox_ConfirmPassword)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBoxClassRollNo)
        Me.Controls.Add(Me.TextBox_PhoneNo)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents TextBoxClassRollNo As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents TextBox_ConfirmPassword As TextBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_SignOut As Button
End Class
