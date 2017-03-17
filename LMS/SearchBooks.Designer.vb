<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBooks
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Author = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Location = New System.Windows.Forms.TextBox()
        Me.DataGridView_Books = New System.Windows.Forms.DataGridView()
        Me.Button_Load = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Books, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Books"
        '
        'Button_SignOut
        '
        Me.Button_SignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SignOut.Location = New System.Drawing.Point(539, 19)
        Me.Button_SignOut.Name = "Button_SignOut"
        Me.Button_SignOut.Size = New System.Drawing.Size(92, 26)
        Me.Button_SignOut.TabIndex = 14
        Me.Button_SignOut.Text = "SignOut"
        Me.Button_SignOut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ISBN"
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.Location = New System.Drawing.Point(81, 80)
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_ISBN.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Title"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Location = New System.Drawing.Point(368, 80)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_Title.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Author"
        '
        'TextBox_Author
        '
        Me.TextBox_Author.Location = New System.Drawing.Point(81, 119)
        Me.TextBox_Author.Name = "TextBox_Author"
        Me.TextBox_Author.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_Author.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Location"
        '
        'TextBox_Location
        '
        Me.TextBox_Location.Location = New System.Drawing.Point(368, 119)
        Me.TextBox_Location.Name = "TextBox_Location"
        Me.TextBox_Location.Size = New System.Drawing.Size(158, 20)
        Me.TextBox_Location.TabIndex = 22
        '
        'DataGridView_Books
        '
        Me.DataGridView_Books.AllowUserToAddRows = False
        Me.DataGridView_Books.AllowUserToDeleteRows = False
        Me.DataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Books.Location = New System.Drawing.Point(17, 165)
        Me.DataGridView_Books.Name = "DataGridView_Books"
        Me.DataGridView_Books.ReadOnly = True
        Me.DataGridView_Books.Size = New System.Drawing.Size(614, 308)
        Me.DataGridView_Books.TabIndex = 23
        '
        'Button_Load
        '
        Me.Button_Load.Location = New System.Drawing.Point(548, 107)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(83, 32)
        Me.Button_Load.TabIndex = 24
        Me.Button_Load.Text = "Load"
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'SearchBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 485)
        Me.Controls.Add(Me.Button_Load)
        Me.Controls.Add(Me.DataGridView_Books)
        Me.Controls.Add(Me.TextBox_Location)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_Author)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_ISBN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_SignOut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchBooks"
        Me.Text = "SearchBooks"
        CType(Me.DataGridView_Books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_SignOut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Location As TextBox
    Friend WithEvents DataGridView_Books As DataGridView
    Friend WithEvents Button_Load As Button
End Class
