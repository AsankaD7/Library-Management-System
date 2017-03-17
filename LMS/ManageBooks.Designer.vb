<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBooks
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
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Author = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Location = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.DataGridView_Books = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_Books, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Books"
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ISBN.Location = New System.Drawing.Point(95, 59)
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_ISBN.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ISBN"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Title.Location = New System.Drawing.Point(406, 59)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(202, 26)
        Me.TextBox_Title.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Title"
        '
        'TextBox_Author
        '
        Me.TextBox_Author.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Author.Location = New System.Drawing.Point(95, 96)
        Me.TextBox_Author.Name = "TextBox_Author"
        Me.TextBox_Author.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_Author.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Author"
        '
        'TextBox_Location
        '
        Me.TextBox_Location.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Location.Location = New System.Drawing.Point(406, 96)
        Me.TextBox_Location.Name = "TextBox_Location"
        Me.TextBox_Location.Size = New System.Drawing.Size(202, 26)
        Me.TextBox_Location.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Location"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(527, 401)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 25)
        Me.Button_Cancel.TabIndex = 16
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Add.Location = New System.Drawing.Point(209, 401)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(100, 25)
        Me.Button_Add.TabIndex = 15
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Edit.Location = New System.Drawing.Point(315, 401)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(100, 25)
        Me.Button_Edit.TabIndex = 17
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(421, 401)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(100, 25)
        Me.Button_Delete.TabIndex = 18
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'DataGridView_Books
        '
        Me.DataGridView_Books.AllowUserToAddRows = False
        Me.DataGridView_Books.AllowUserToDeleteRows = False
        Me.DataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Books.Location = New System.Drawing.Point(16, 137)
        Me.DataGridView_Books.Name = "DataGridView_Books"
        Me.DataGridView_Books.ReadOnly = True
        Me.DataGridView_Books.Size = New System.Drawing.Size(605, 249)
        Me.DataGridView_Books.TabIndex = 19
        '
        'ManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 438)
        Me.Controls.Add(Me.DataGridView_Books)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_Location)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_Author)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_ISBN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "ManageBooks"
        Me.Text = "ManageBooks"
        CType(Me.DataGridView_Books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Location As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents DataGridView_Books As DataGridView
End Class
