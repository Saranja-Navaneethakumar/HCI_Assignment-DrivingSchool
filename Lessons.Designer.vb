<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lessons
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
        DurationAlert = New Label()
        LessonSerachComboBox = New ComboBox()
        SearchRefresh = New Button()
        Contactalert = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Instructor = New Label()
        DeleteAll = New Button()
        Refresh = New Button()
        LessonSearch = New Button()
        LessonSearchBox = New TextBox()
        Delete = New Button()
        Update = New Button()
        Save = New Button()
        LessonDataGridView = New DataGridView()
        DatePicker = New DateTimePicker()
        LessonDate = New Label()
        AmountTextBox = New TextBox()
        Amount = New Label()
        DurationTextBox = New TextBox()
        Duration = New Label()
        CourseName = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        LearnerName = New Label()
        LearnerComboBox = New ComboBox()
        InstructorComboBox = New ComboBox()
        CourseComboBox = New ComboBox()
        CType(LessonDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DurationAlert
        ' 
        DurationAlert.AutoSize = True
        DurationAlert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        DurationAlert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DurationAlert.ForeColor = Color.PaleVioletRed
        DurationAlert.Location = New Point(213, 317)
        DurationAlert.Name = "DurationAlert"
        DurationAlert.Size = New Size(0, 18)
        DurationAlert.TabIndex = 155
        ' 
        ' LessonSerachComboBox
        ' 
        LessonSerachComboBox.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        LessonSerachComboBox.FlatStyle = FlatStyle.Flat
        LessonSerachComboBox.Font = New Font("Georgia", 14F)
        LessonSerachComboBox.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LessonSerachComboBox.FormattingEnabled = True
        LessonSerachComboBox.Items.AddRange(New Object() {"Learner Name", "Course Name", "Instructor", "Date"})
        LessonSerachComboBox.Location = New Point(601, 118)
        LessonSerachComboBox.Name = "LessonSerachComboBox"
        LessonSerachComboBox.Size = New Size(228, 31)
        LessonSerachComboBox.TabIndex = 153
        ' 
        ' SearchRefresh
        ' 
        SearchRefresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        SearchRefresh.FlatStyle = FlatStyle.Flat
        SearchRefresh.Font = New Font("Georgia", 14.25F)
        SearchRefresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        SearchRefresh.Image = My.Resources.Resources.reload
        SearchRefresh.ImageAlign = ContentAlignment.MiddleLeft
        SearchRefresh.Location = New Point(1261, 115)
        SearchRefresh.Name = "SearchRefresh"
        SearchRefresh.Size = New Size(34, 34)
        SearchRefresh.TabIndex = 152
        SearchRefresh.UseVisualStyleBackColor = False
        ' 
        ' Contactalert
        ' 
        Contactalert.AutoSize = True
        Contactalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Contactalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Contactalert.ForeColor = Color.PaleVioletRed
        Contactalert.Location = New Point(203, 377)
        Contactalert.Name = "Contactalert"
        Contactalert.Size = New Size(0, 18)
        Contactalert.TabIndex = 151
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label8.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.PaleVioletRed
        Label8.Location = New Point(82, 401)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 34)
        Label8.TabIndex = 150
        Label8.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label6.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.PaleVioletRed
        Label6.Location = New Point(106, 341)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 34)
        Label6.TabIndex = 149
        Label6.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label5.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.PaleVioletRed
        Label5.Location = New Point(178, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 34)
        Label5.TabIndex = 148
        Label5.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label4.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.PaleVioletRed
        Label4.Location = New Point(121, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 34)
        Label4.TabIndex = 147
        Label4.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label3.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.PaleVioletRed
        Label3.Location = New Point(140, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 34)
        Label3.TabIndex = 146
        Label3.Text = "*"
        ' 
        ' Instructor
        ' 
        Instructor.AutoSize = True
        Instructor.BackColor = Color.Transparent
        Instructor.Font = New Font("Georgia", 12F)
        Instructor.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Instructor.ImageAlign = ContentAlignment.MiddleLeft
        Instructor.Location = New Point(42, 232)
        Instructor.Name = "Instructor"
        Instructor.RightToLeft = RightToLeft.No
        Instructor.Size = New Size(81, 18)
        Instructor.TabIndex = 145
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
        DeleteAll.Location = New Point(266, 542)
        DeleteAll.Name = "DeleteAll"
        DeleteAll.Size = New Size(148, 37)
        DeleteAll.TabIndex = 144
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
        Refresh.Location = New Point(121, 542)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(125, 37)
        Refresh.TabIndex = 143
        Refresh.Text = "Refresh"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' LessonSearch
        ' 
        LessonSearch.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        LessonSearch.FlatStyle = FlatStyle.Flat
        LessonSearch.Font = New Font("Georgia", 14.25F)
        LessonSearch.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LessonSearch.Image = My.Resources.Resources.paper
        LessonSearch.ImageAlign = ContentAlignment.MiddleLeft
        LessonSearch.Location = New Point(1125, 116)
        LessonSearch.Name = "LessonSearch"
        LessonSearch.Size = New Size(130, 34)
        LessonSearch.TabIndex = 142
        LessonSearch.Text = "Search"
        LessonSearch.UseVisualStyleBackColor = False
        ' 
        ' LessonSearchBox
        ' 
        LessonSearchBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LessonSearchBox.BorderStyle = BorderStyle.None
        LessonSearchBox.Font = New Font("Georgia", 13F)
        LessonSearchBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LessonSearchBox.Location = New Point(847, 116)
        LessonSearchBox.Multiline = True
        LessonSearchBox.Name = "LessonSearchBox"
        LessonSearchBox.Size = New Size(259, 34)
        LessonSearchBox.TabIndex = 141
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Delete.FlatStyle = FlatStyle.Flat
        Delete.Font = New Font("Georgia", 14.25F)
        Delete.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Delete.Image = My.Resources.Resources.delete
        Delete.ImageAlign = ContentAlignment.MiddleLeft
        Delete.Location = New Point(348, 485)
        Delete.Name = "Delete"
        Delete.Size = New Size(125, 37)
        Delete.TabIndex = 140
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
        Update.Location = New Point(203, 485)
        Update.Name = "Update"
        Update.Size = New Size(125, 37)
        Update.TabIndex = 139
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
        Save.Location = New Point(58, 485)
        Save.Name = "Save"
        Save.Size = New Size(125, 37)
        Save.TabIndex = 138
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' LessonDataGridView
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LessonDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        LessonDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LessonDataGridView.BackgroundColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LessonDataGridView.BorderStyle = BorderStyle.None
        LessonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LessonDataGridView.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LessonDataGridView.Location = New Point(601, 190)
        LessonDataGridView.Name = "LessonDataGridView"
        LessonDataGridView.Size = New Size(738, 454)
        LessonDataGridView.TabIndex = 137
        ' 
        ' DatePicker
        ' 
        DatePicker.CalendarForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DatePicker.CalendarMonthBackground = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DatePicker.CalendarTitleBackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DatePicker.CalendarTitleForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DatePicker.CalendarTrailingForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DatePicker.Font = New Font("Georgia", 13F)
        DatePicker.Location = New Point(213, 414)
        DatePicker.Name = "DatePicker"
        DatePicker.Size = New Size(299, 27)
        DatePicker.TabIndex = 136
        ' 
        ' LessonDate
        ' 
        LessonDate.AutoSize = True
        LessonDate.BackColor = Color.Transparent
        LessonDate.Font = New Font("Georgia", 12F)
        LessonDate.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LessonDate.ImageAlign = ContentAlignment.MiddleLeft
        LessonDate.Location = New Point(42, 414)
        LessonDate.Name = "LessonDate"
        LessonDate.RightToLeft = RightToLeft.No
        LessonDate.Size = New Size(41, 18)
        LessonDate.TabIndex = 135
        LessonDate.Text = "Date"
        LessonDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AmountTextBox
        ' 
        AmountTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        AmountTextBox.BorderStyle = BorderStyle.None
        AmountTextBox.Font = New Font("Georgia", 13F)
        AmountTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        AmountTextBox.Location = New Point(213, 349)
        AmountTextBox.Multiline = True
        AmountTextBox.Name = "AmountTextBox"
        AmountTextBox.Size = New Size(299, 25)
        AmountTextBox.TabIndex = 134
        ' 
        ' Amount
        ' 
        Amount.AutoSize = True
        Amount.BackColor = Color.Transparent
        Amount.Font = New Font("Georgia", 12F)
        Amount.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Amount.ImageAlign = ContentAlignment.MiddleLeft
        Amount.Location = New Point(42, 349)
        Amount.Name = "Amount"
        Amount.RightToLeft = RightToLeft.No
        Amount.Size = New Size(65, 18)
        Amount.TabIndex = 133
        Amount.Text = "Amount"
        Amount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DurationTextBox
        ' 
        DurationTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        DurationTextBox.BorderStyle = BorderStyle.None
        DurationTextBox.Font = New Font("Georgia", 13F)
        DurationTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DurationTextBox.Location = New Point(213, 289)
        DurationTextBox.Multiline = True
        DurationTextBox.Name = "DurationTextBox"
        DurationTextBox.Size = New Size(299, 25)
        DurationTextBox.TabIndex = 132
        ' 
        ' Duration
        ' 
        Duration.AutoSize = True
        Duration.BackColor = Color.Transparent
        Duration.Font = New Font("Georgia", 12F)
        Duration.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Duration.ImageAlign = ContentAlignment.MiddleLeft
        Duration.Location = New Point(42, 289)
        Duration.Name = "Duration"
        Duration.RightToLeft = RightToLeft.No
        Duration.Size = New Size(129, 18)
        Duration.TabIndex = 131
        Duration.Text = "Duration (Hours)"
        Duration.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CourseName
        ' 
        CourseName.AutoSize = True
        CourseName.BackColor = Color.Transparent
        CourseName.Font = New Font("Georgia", 12F)
        CourseName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        CourseName.ImageAlign = ContentAlignment.MiddleLeft
        CourseName.Location = New Point(42, 171)
        CourseName.Name = "CourseName"
        CourseName.RightToLeft = RightToLeft.No
        CourseName.Size = New Size(103, 18)
        CourseName.TabIndex = 129
        CourseName.Text = "Course Name"
        CourseName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.driving_license__2_
        PictureBox1.Location = New Point(187, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 128
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 15F)
        Label1.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(32, 44)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(158, 24)
        Label1.TabIndex = 127
        Label1.Text = "Manage Lessons"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label2.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.PaleVioletRed
        Label2.Location = New Point(154, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 34)
        Label2.TabIndex = 158
        Label2.Text = "*"
        ' 
        ' LearnerName
        ' 
        LearnerName.AutoSize = True
        LearnerName.BackColor = Color.Transparent
        LearnerName.Font = New Font("Georgia", 12F)
        LearnerName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LearnerName.ImageAlign = ContentAlignment.MiddleLeft
        LearnerName.Location = New Point(42, 110)
        LearnerName.Name = "LearnerName"
        LearnerName.RightToLeft = RightToLeft.No
        LearnerName.Size = New Size(111, 18)
        LearnerName.TabIndex = 156
        LearnerName.Text = "Learner Name"
        LearnerName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LearnerComboBox
        ' 
        LearnerComboBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LearnerComboBox.FlatStyle = FlatStyle.Flat
        LearnerComboBox.Font = New Font("Georgia", 14F)
        LearnerComboBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LearnerComboBox.FormattingEnabled = True
        LearnerComboBox.Location = New Point(213, 107)
        LearnerComboBox.Name = "LearnerComboBox"
        LearnerComboBox.Size = New Size(299, 31)
        LearnerComboBox.TabIndex = 160
        ' 
        ' InstructorComboBox
        ' 
        InstructorComboBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        InstructorComboBox.FlatStyle = FlatStyle.Flat
        InstructorComboBox.Font = New Font("Georgia", 14F)
        InstructorComboBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorComboBox.FormattingEnabled = True
        InstructorComboBox.Location = New Point(213, 229)
        InstructorComboBox.Name = "InstructorComboBox"
        InstructorComboBox.Size = New Size(299, 31)
        InstructorComboBox.TabIndex = 159
        ' 
        ' CourseComboBox
        ' 
        CourseComboBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        CourseComboBox.FlatStyle = FlatStyle.Flat
        CourseComboBox.Font = New Font("Georgia", 14F)
        CourseComboBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CourseComboBox.FormattingEnabled = True
        CourseComboBox.Location = New Point(213, 168)
        CourseComboBox.Name = "CourseComboBox"
        CourseComboBox.Size = New Size(299, 31)
        CourseComboBox.TabIndex = 161
        ' 
        ' Lessons
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        ClientSize = New Size(1410, 775)
        Controls.Add(CourseComboBox)
        Controls.Add(LearnerComboBox)
        Controls.Add(InstructorComboBox)
        Controls.Add(Label2)
        Controls.Add(LearnerName)
        Controls.Add(DurationAlert)
        Controls.Add(LessonSerachComboBox)
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
        Controls.Add(LessonSearch)
        Controls.Add(LessonSearchBox)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Save)
        Controls.Add(LessonDataGridView)
        Controls.Add(DatePicker)
        Controls.Add(LessonDate)
        Controls.Add(AmountTextBox)
        Controls.Add(Amount)
        Controls.Add(DurationTextBox)
        Controls.Add(Duration)
        Controls.Add(CourseName)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Lessons"
        Text = "Lessons"
        CType(LessonDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DurationAlert As Label
    Friend WithEvents LessonSerachComboBox As ComboBox
    Friend WithEvents SearchRefresh As Button
    Friend WithEvents Contactalert As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Instructor As Label
    Friend WithEvents DeleteAll As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents LessonSearch As Button
    Friend WithEvents LessonSearchBox As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Save As Button
    Friend WithEvents LessonDataGridView As DataGridView
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents LessonDate As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Amount As Label
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents Duration As Label
    Friend WithEvents CourseName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LearnerName As Label
    Friend WithEvents LearnerComboBox As ComboBox
    Friend WithEvents InstructorComboBox As ComboBox
    Friend WithEvents CourseComboBox As ComboBox
End Class
