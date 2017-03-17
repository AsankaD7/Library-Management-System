<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPannel
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
        Me.Button_ManageBooks = New System.Windows.Forms.Button()
        Me.Button_ManageAccounts = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_SearchAcc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_ManageBooks
        '
        Me.Button_ManageBooks.Location = New System.Drawing.Point(138, 141)
        Me.Button_ManageBooks.Name = "Button_ManageBooks"
        Me.Button_ManageBooks.Size = New System.Drawing.Size(138, 37)
        Me.Button_ManageBooks.TabIndex = 0
        Me.Button_ManageBooks.Text = "Manage Books"
        Me.Button_ManageBooks.UseVisualStyleBackColor = True
        '
        'Button_ManageAccounts
        '
        Me.Button_ManageAccounts.Location = New System.Drawing.Point(350, 141)
        Me.Button_ManageAccounts.Name = "Button_ManageAccounts"
        Me.Button_ManageAccounts.Size = New System.Drawing.Size(138, 37)
        Me.Button_ManageAccounts.TabIndex = 1
        Me.Button_ManageAccounts.Text = "Manage Accounts"
        Me.Button_ManageAccounts.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Manage Book Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_SearchAcc
        '
        Me.Button_SearchAcc.Location = New System.Drawing.Point(350, 200)
        Me.Button_SearchAcc.Name = "Button_SearchAcc"
        Me.Button_SearchAcc.Size = New System.Drawing.Size(138, 37)
        Me.Button_SearchAcc.TabIndex = 3
        Me.Button_SearchAcc.Text = "Search Accounts"
        Me.Button_SearchAcc.UseVisualStyleBackColor = True
        '
        'AdminPannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 337)
        Me.Controls.Add(Me.Button_SearchAcc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_ManageAccounts)
        Me.Controls.Add(Me.Button_ManageBooks)
        Me.Name = "AdminPannel"
        Me.Text = "AdminPannel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_ManageBooks As Button
    Friend WithEvents Button_ManageAccounts As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_SearchAcc As Button
End Class
