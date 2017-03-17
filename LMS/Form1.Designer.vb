<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox_UserName = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Button_Registration = New System.Windows.Forms.Button()
        Me.Button_LogIn = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Connection = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'TextBox_UserName
        '
        Me.TextBox_UserName.Location = New System.Drawing.Point(369, 139)
        Me.TextBox_UserName.Name = "TextBox_UserName"
        Me.TextBox_UserName.Size = New System.Drawing.Size(255, 20)
        Me.TextBox_UserName.TabIndex = 3
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(369, 178)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(255, 20)
        Me.TextBox_Password.TabIndex = 4
        '
        'Button_Registration
        '
        Me.Button_Registration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Registration.Location = New System.Drawing.Point(369, 219)
        Me.Button_Registration.Name = "Button_Registration"
        Me.Button_Registration.Size = New System.Drawing.Size(72, 27)
        Me.Button_Registration.TabIndex = 5
        Me.Button_Registration.Text = "Register"
        Me.Button_Registration.UseVisualStyleBackColor = True
        '
        'Button_LogIn
        '
        Me.Button_LogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_LogIn.Location = New System.Drawing.Point(460, 219)
        Me.Button_LogIn.Name = "Button_LogIn"
        Me.Button_LogIn.Size = New System.Drawing.Size(72, 27)
        Me.Button_LogIn.TabIndex = 6
        Me.Button_LogIn.Text = "LogIn"
        Me.Button_LogIn.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(552, 219)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(72, 27)
        Me.Button_Cancel.TabIndex = 7
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Connection
        '
        Me.Connection.Location = New System.Drawing.Point(565, 318)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(77, 21)
        Me.Connection.TabIndex = 8
        Me.Connection.Text = "Connection"
        Me.Connection.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Admin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 342)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Connection)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_LogIn)
        Me.Controls.Add(Me.Button_Registration)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_UserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "LogIn Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_UserName As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button_Registration As Button
    Friend WithEvents Button_LogIn As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Connection As Button
    Friend WithEvents Button1 As Button
End Class
