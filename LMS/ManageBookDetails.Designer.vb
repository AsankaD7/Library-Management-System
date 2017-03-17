<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBookDetails
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
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbl_ManageBookDetails = New System.Windows.Forms.DataGridView()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.ComboBox_ISBM = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_BD = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_HD = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_RegNo = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.Tbl_ManageBookDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Book Detail"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ID.Location = New System.Drawing.Point(142, 59)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(184, 26)
        Me.TextBox_ID.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ISBN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Borrow Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(332, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Handover Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Reg No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Handover"
        '
        'Tbl_ManageBookDetails
        '
        Me.Tbl_ManageBookDetails.AllowUserToAddRows = False
        Me.Tbl_ManageBookDetails.AllowUserToDeleteRows = False
        Me.Tbl_ManageBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_ManageBookDetails.Location = New System.Drawing.Point(14, 170)
        Me.Tbl_ManageBookDetails.Name = "Tbl_ManageBookDetails"
        Me.Tbl_ManageBookDetails.ReadOnly = True
        Me.Tbl_ManageBookDetails.Size = New System.Drawing.Size(639, 293)
        Me.Tbl_ManageBookDetails.TabIndex = 21
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(447, 473)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(100, 25)
        Me.Button_Delete.TabIndex = 25
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Edit.Location = New System.Drawing.Point(340, 473)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(100, 25)
        Me.Button_Edit.TabIndex = 24
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.Location = New System.Drawing.Point(554, 473)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 25)
        Me.Button_Cancel.TabIndex = 23
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Add.Location = New System.Drawing.Point(236, 473)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(100, 25)
        Me.Button_Add.TabIndex = 22
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'ComboBox_ISBM
        '
        Me.ComboBox_ISBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_ISBM.FormattingEnabled = True
        Me.ComboBox_ISBM.IntegralHeight = False
        Me.ComboBox_ISBM.Location = New System.Drawing.Point(466, 59)
        Me.ComboBox_ISBM.Name = "ComboBox_ISBM"
        Me.ComboBox_ISBM.Size = New System.Drawing.Size(182, 28)
        Me.ComboBox_ISBM.TabIndex = 26
        '
        'DateTimePicker_BD
        '
        Me.DateTimePicker_BD.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_BD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_BD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_BD.Location = New System.Drawing.Point(142, 96)
        Me.DateTimePicker_BD.Name = "DateTimePicker_BD"
        Me.DateTimePicker_BD.Size = New System.Drawing.Size(184, 26)
        Me.DateTimePicker_BD.TabIndex = 27
        '
        'DateTimePicker_HD
        '
        Me.DateTimePicker_HD.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_HD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_HD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_HD.Location = New System.Drawing.Point(464, 96)
        Me.DateTimePicker_HD.Name = "DateTimePicker_HD"
        Me.DateTimePicker_HD.Size = New System.Drawing.Size(184, 26)
        Me.DateTimePicker_HD.TabIndex = 28
        '
        'ComboBox_RegNo
        '
        Me.ComboBox_RegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_RegNo.FormattingEnabled = True
        Me.ComboBox_RegNo.IntegralHeight = False
        Me.ComboBox_RegNo.Location = New System.Drawing.Point(142, 131)
        Me.ComboBox_RegNo.Name = "ComboBox_RegNo"
        Me.ComboBox_RegNo.Size = New System.Drawing.Size(184, 28)
        Me.ComboBox_RegNo.TabIndex = 29
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(464, 137)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(50, 20)
        Me.RadioButton1.TabIndex = 30
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(529, 137)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(44, 20)
        Me.RadioButton2.TabIndex = 31
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ManageBookDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 509)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox_RegNo)
        Me.Controls.Add(Me.DateTimePicker_HD)
        Me.Controls.Add(Me.DateTimePicker_BD)
        Me.Controls.Add(Me.ComboBox_ISBM)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Tbl_ManageBookDetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "ManageBookDetails"
        Me.Text = "ManageBookDetails"
        CType(Me.Tbl_ManageBookDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tbl_ManageBookDetails As DataGridView
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents ComboBox_ISBM As ComboBox
    Friend WithEvents DateTimePicker_BD As DateTimePicker
    Friend WithEvents DateTimePicker_HD As DateTimePicker
    Friend WithEvents ComboBox_RegNo As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
