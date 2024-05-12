<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CourseSerachComboBox = New ComboBox()
        SearchRefresh = New Button()
        Contactalert = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Instructor = New Label()
        DeleteAll = New Button()
        Refresh = New Button()
        CourseSearch = New Button()
        CourseSearchBox = New TextBox()
        Delete = New Button()
        Update = New Button()
        Save = New Button()
        CourseDataGridView = New DataGridView()
        StartDatePicker = New DateTimePicker()
        StartDate = New Label()
        AmountTextBox = New TextBox()
        Amount = New Label()
        CourseNameTextBox = New TextBox()
        CourseName = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Duration = New Label()
        DurationTextBox = New TextBox()
        Label5 = New Label()
        DurationAlert = New Label()
        InstructorComboBox = New ComboBox()
        CType(CourseDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CourseSerachComboBox
        ' 
        CourseSerachComboBox.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        CourseSerachComboBox.FlatStyle = FlatStyle.Flat
        CourseSerachComboBox.Font = New Font("Georgia", 14F)
        CourseSerachComboBox.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        CourseSerachComboBox.FormattingEnabled = True
        CourseSerachComboBox.Items.AddRange(New Object() {"Course Name", "Instructor", "Start Date"})
        CourseSerachComboBox.Location = New Point(606, 116)
        CourseSerachComboBox.Name = "CourseSerachComboBox"
        CourseSerachComboBox.Size = New Size(228, 31)
        CourseSerachComboBox.TabIndex = 124
        ' 
        ' SearchRefresh
        ' 
        SearchRefresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        SearchRefresh.FlatStyle = FlatStyle.Flat
        SearchRefresh.Font = New Font("Georgia", 14.25F)
        SearchRefresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        SearchRefresh.Image = My.Resources.Resources.reload
        SearchRefresh.ImageAlign = ContentAlignment.MiddleLeft
        SearchRefresh.Location = New Point(1266, 113)
        SearchRefresh.Name = "SearchRefresh"
        SearchRefresh.Size = New Size(34, 34)
        SearchRefresh.TabIndex = 123
        SearchRefresh.UseVisualStyleBackColor = False
        ' 
        ' Contactalert
        ' 
        Contactalert.AutoSize = True
        Contactalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Contactalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Contactalert.ForeColor = Color.PaleVioletRed
        Contactalert.Location = New Point(208, 322)
        Contactalert.Name = "Contactalert"
        Contactalert.Size = New Size(0, 18)
        Contactalert.TabIndex = 119
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label8.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.PaleVioletRed
        Label8.Location = New Point(127, 352)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 34)
        Label8.TabIndex = 115
        Label8.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label6.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.PaleVioletRed
        Label6.Location = New Point(163, 286)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 34)
        Label6.TabIndex = 113
        Label6.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label4.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.PaleVioletRed
        Label4.Location = New Point(126, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 34)
        Label4.TabIndex = 111
        Label4.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label3.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.PaleVioletRed
        Label3.Location = New Point(145, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 34)
        Label3.TabIndex = 110
        Label3.Text = "*"
        ' 
        ' Instructor
        ' 
        Instructor.AutoSize = True
        Instructor.BackColor = Color.Transparent
        Instructor.Font = New Font("Georgia", 12F)
        Instructor.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Instructor.ImageAlign = ContentAlignment.MiddleLeft
        Instructor.Location = New Point(47, 177)
        Instructor.Name = "Instructor"
        Instructor.RightToLeft = RightToLeft.No
        Instructor.Size = New Size(81, 18)
        Instructor.TabIndex = 108
        Instructor.Text = "Instructor"
        Instructor.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DeleteAll
        ' 
        DeleteAll.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        DeleteAll.FlatStyle = FlatStyle.Flat
        DeleteAll.Font = New Font("Georgia", 14.25F)
        DeleteAll.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DeleteAll.Image = My.Resources.Resources.delete__1_
        DeleteAll.ImageAlign = ContentAlignment.MiddleLeft
        DeleteAll.Location = New Point(271, 491)
        DeleteAll.Name = "DeleteAll"
        DeleteAll.Size = New Size(148, 37)
        DeleteAll.TabIndex = 105
        DeleteAll.Text = "Delete All"
        DeleteAll.UseVisualStyleBackColor = False
        ' 
        ' Refresh
        ' 
        Refresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Refresh.FlatStyle = FlatStyle.Flat
        Refresh.Font = New Font("Georgia", 14.25F)
        Refresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Refresh.Image = My.Resources.Resources.reload
        Refresh.ImageAlign = ContentAlignment.MiddleLeft
        Refresh.Location = New Point(126, 491)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(125, 37)
        Refresh.TabIndex = 104
        Refresh.Text = "Refresh"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' CourseSearch
        ' 
        CourseSearch.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        CourseSearch.FlatStyle = FlatStyle.Flat
        CourseSearch.Font = New Font("Georgia", 14.25F)
        CourseSearch.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CourseSearch.Image = My.Resources.Resources.paper
        CourseSearch.ImageAlign = ContentAlignment.MiddleLeft
        CourseSearch.Location = New Point(1130, 114)
        CourseSearch.Name = "CourseSearch"
        CourseSearch.Size = New Size(130, 34)
        CourseSearch.TabIndex = 103
        CourseSearch.Text = "Search"
        CourseSearch.UseVisualStyleBackColor = False
        ' 
        ' CourseSearchBox
        ' 
        CourseSearchBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        CourseSearchBox.BorderStyle = BorderStyle.None
        CourseSearchBox.Font = New Font("Georgia", 13F)
        CourseSearchBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CourseSearchBox.Location = New Point(852, 114)
        CourseSearchBox.Multiline = True
        CourseSearchBox.Name = "CourseSearchBox"
        CourseSearchBox.Size = New Size(259, 34)
        CourseSearchBox.TabIndex = 102
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Delete.FlatStyle = FlatStyle.Flat
        Delete.Font = New Font("Georgia", 14.25F)
        Delete.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Delete.Image = My.Resources.Resources.delete
        Delete.ImageAlign = ContentAlignment.MiddleLeft
        Delete.Location = New Point(353, 434)
        Delete.Name = "Delete"
        Delete.Size = New Size(125, 37)
        Delete.TabIndex = 101
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' Update
        ' 
        Update.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Update.FlatStyle = FlatStyle.Flat
        Update.Font = New Font("Georgia", 14.25F)
        Update.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Update.Image = My.Resources.Resources.changes
        Update.ImageAlign = ContentAlignment.MiddleLeft
        Update.Location = New Point(208, 434)
        Update.Name = "Update"
        Update.Size = New Size(125, 37)
        Update.TabIndex = 100
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Save
        ' 
        Save.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Save.FlatStyle = FlatStyle.Flat
        Save.Font = New Font("Georgia", 14.25F)
        Save.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Save.Image = My.Resources.Resources.download
        Save.ImageAlign = ContentAlignment.MiddleLeft
        Save.Location = New Point(63, 434)
        Save.Name = "Save"
        Save.Size = New Size(125, 37)
        Save.TabIndex = 99
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' CourseDataGridView
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        CourseDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        CourseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CourseDataGridView.BackgroundColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CourseDataGridView.BorderStyle = BorderStyle.None
        CourseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CourseDataGridView.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CourseDataGridView.Location = New Point(606, 188)
        CourseDataGridView.Name = "CourseDataGridView"
        CourseDataGridView.Size = New Size(738, 454)
        CourseDataGridView.TabIndex = 98
        ' 
        ' StartDatePicker
        ' 
        StartDatePicker.CalendarForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        StartDatePicker.CalendarMonthBackground = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        StartDatePicker.CalendarTitleBackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        StartDatePicker.CalendarTitleForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        StartDatePicker.CalendarTrailingForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        StartDatePicker.Font = New Font("Georgia", 13F)
        StartDatePicker.Location = New Point(218, 359)
        StartDatePicker.Name = "StartDatePicker"
        StartDatePicker.Size = New Size(299, 27)
        StartDatePicker.TabIndex = 93
        ' 
        ' StartDate
        ' 
        StartDate.AutoSize = True
        StartDate.BackColor = Color.Transparent
        StartDate.Font = New Font("Georgia", 12F)
        StartDate.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        StartDate.ImageAlign = ContentAlignment.MiddleLeft
        StartDate.Location = New Point(47, 359)
        StartDate.Name = "StartDate"
        StartDate.RightToLeft = RightToLeft.No
        StartDate.Size = New Size(81, 18)
        StartDate.TabIndex = 92
        StartDate.Text = "Strat Date"
        StartDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AmountTextBox
        ' 
        AmountTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        AmountTextBox.BorderStyle = BorderStyle.None
        AmountTextBox.Font = New Font("Georgia", 13F)
        AmountTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        AmountTextBox.Location = New Point(218, 294)
        AmountTextBox.Multiline = True
        AmountTextBox.Name = "AmountTextBox"
        AmountTextBox.Size = New Size(299, 25)
        AmountTextBox.TabIndex = 91
        ' 
        ' Amount
        ' 
        Amount.AutoSize = True
        Amount.BackColor = Color.Transparent
        Amount.Font = New Font("Georgia", 12F)
        Amount.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Amount.ImageAlign = ContentAlignment.MiddleLeft
        Amount.Location = New Point(47, 294)
        Amount.Name = "Amount"
        Amount.RightToLeft = RightToLeft.No
        Amount.Size = New Size(117, 18)
        Amount.TabIndex = 90
        Amount.Text = "Amount / Hour"
        Amount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CourseNameTextBox
        ' 
        CourseNameTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        CourseNameTextBox.BorderStyle = BorderStyle.None
        CourseNameTextBox.Font = New Font("Georgia", 13F)
        CourseNameTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CourseNameTextBox.Location = New Point(218, 113)
        CourseNameTextBox.Multiline = True
        CourseNameTextBox.Name = "CourseNameTextBox"
        CourseNameTextBox.Size = New Size(299, 25)
        CourseNameTextBox.TabIndex = 87
        ' 
        ' CourseName
        ' 
        CourseName.AutoSize = True
        CourseName.BackColor = Color.Transparent
        CourseName.Font = New Font("Georgia", 12F)
        CourseName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        CourseName.ImageAlign = ContentAlignment.MiddleLeft
        CourseName.Location = New Point(47, 116)
        CourseName.Name = "CourseName"
        CourseName.RightToLeft = RightToLeft.No
        CourseName.Size = New Size(103, 18)
        CourseName.TabIndex = 86
        CourseName.Text = "Course Name"
        CourseName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.test_drive__2_
        PictureBox1.Location = New Point(192, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 15F)
        Label1.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(37, 42)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(158, 24)
        Label1.TabIndex = 84
        Label1.Text = "Manage Courses"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Duration
        ' 
        Duration.AutoSize = True
        Duration.BackColor = Color.Transparent
        Duration.Font = New Font("Georgia", 12F)
        Duration.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Duration.ImageAlign = ContentAlignment.MiddleLeft
        Duration.Location = New Point(47, 234)
        Duration.Name = "Duration"
        Duration.RightToLeft = RightToLeft.No
        Duration.Size = New Size(140, 18)
        Duration.TabIndex = 88
        Duration.Text = "Duration (Months)"
        Duration.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DurationTextBox
        ' 
        DurationTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        DurationTextBox.BorderStyle = BorderStyle.None
        DurationTextBox.Font = New Font("Georgia", 13F)
        DurationTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DurationTextBox.Location = New Point(218, 234)
        DurationTextBox.Multiline = True
        DurationTextBox.Name = "DurationTextBox"
        DurationTextBox.Size = New Size(299, 25)
        DurationTextBox.TabIndex = 89
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label5.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.PaleVioletRed
        Label5.Location = New Point(183, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 34)
        Label5.TabIndex = 112
        Label5.Text = "*"
        ' 
        ' DurationAlert
        ' 
        DurationAlert.AutoSize = True
        DurationAlert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        DurationAlert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DurationAlert.ForeColor = Color.PaleVioletRed
        DurationAlert.Location = New Point(218, 262)
        DurationAlert.Name = "DurationAlert"
        DurationAlert.Size = New Size(0, 18)
        DurationAlert.TabIndex = 126
        ' 
        ' InstructorComboBox
        ' 
        InstructorComboBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        InstructorComboBox.FlatStyle = FlatStyle.Flat
        InstructorComboBox.Font = New Font("Georgia", 14F)
        InstructorComboBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorComboBox.FormattingEnabled = True
        InstructorComboBox.Location = New Point(218, 174)
        InstructorComboBox.Name = "InstructorComboBox"
        InstructorComboBox.Size = New Size(299, 31)
        InstructorComboBox.TabIndex = 127
        ' 
        ' Courses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        ClientSize = New Size(1426, 814)
        Controls.Add(InstructorComboBox)
        Controls.Add(DurationAlert)
        Controls.Add(CourseSerachComboBox)
        Controls.Add(SearchRefresh)
        Controls.Add(Contactalert)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Instructor)
        Controls.Add(DeleteAll)
        Controls.Add(Refresh)
        Controls.Add(CourseSearch)
        Controls.Add(CourseSearchBox)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Save)
        Controls.Add(CourseDataGridView)
        Controls.Add(StartDatePicker)
        Controls.Add(StartDate)
        Controls.Add(AmountTextBox)
        Controls.Add(Amount)
        Controls.Add(DurationTextBox)
        Controls.Add(Duration)
        Controls.Add(CourseNameTextBox)
        Controls.Add(CourseName)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Courses"
        Text = "Courses"
        CType(CourseDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CourseSerachComboBox As ComboBox
    Friend WithEvents SearchRefresh As Button
    Friend WithEvents DOBalert As Label
    Friend WithEvents LessonTypealert As Label
    Friend WithEvents Genderalert As Label
    Friend WithEvents Contactalert As Label
    Friend WithEvents Emailalert As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Instructor As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents DeleteAll As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents CourseSearch As Button
    Friend WithEvents CourseSearchBox As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Save As Button
    Friend WithEvents CourseDataGridView As DataGridView
    Friend WithEvents TypeInstructor As ComboBox
    Friend WithEvents InstructorType As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents GenderLabel As Label
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents StartDate As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Amount As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CourseNameTextBox As TextBox
    Friend WithEvents CourseName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Duration As Label
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DurationAlert As Label
    Friend WithEvents InstructorComboBox As ComboBox
End Class
