<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Learners
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LearnerFirstName = New Label()
        FirstNameTextBox = New TextBox()
        AddressTextBox = New TextBox()
        AddressLabel = New Label()
        ContactTextBox = New TextBox()
        ContactNoLabel = New Label()
        DOB = New Label()
        DateTimePicker1 = New DateTimePicker()
        GenderLabel = New Label()
        BindingSource1 = New BindingSource(components)
        Gender = New ComboBox()
        LessonType = New ComboBox()
        LessonTypeLabel = New Label()
        LearnerDataGridView = New DataGridView()
        Save = New Button()
        Update = New Button()
        Delete = New Button()
        LearnerSearchBox = New TextBox()
        LearnerSearch = New Button()
        BindingSource2 = New BindingSource(components)
        Refresh = New Button()
        DeleteAll = New Button()
        EmailTextBox = New TextBox()
        Email = New Label()
        LastNameTextBox = New TextBox()
        LearnerLastName = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Emailalert = New Label()
        Contactalert = New Label()
        Genderalert = New Label()
        LessonTypealert = New Label()
        DOBalert = New Label()
        SearchRefresh = New Button()
        LearnerSerachComboBox = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(LearnerDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 15F)
        Label1.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(17, 20)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(165, 24)
        Label1.TabIndex = 0
        Label1.Text = "Manage Learners"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.people__4_
        PictureBox1.Location = New Point(187, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LearnerFirstName
        ' 
        LearnerFirstName.AutoSize = True
        LearnerFirstName.BackColor = Color.Transparent
        LearnerFirstName.Font = New Font("Georgia", 12F)
        LearnerFirstName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LearnerFirstName.ImageAlign = ContentAlignment.MiddleLeft
        LearnerFirstName.Location = New Point(27, 94)
        LearnerFirstName.Name = "LearnerFirstName"
        LearnerFirstName.RightToLeft = RightToLeft.No
        LearnerFirstName.Size = New Size(88, 18)
        LearnerFirstName.TabIndex = 2
        LearnerFirstName.Text = "First Name"
        LearnerFirstName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        FirstNameTextBox.BorderStyle = BorderStyle.None
        FirstNameTextBox.Font = New Font("Georgia", 13F)
        FirstNameTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        FirstNameTextBox.Location = New Point(185, 91)
        FirstNameTextBox.Multiline = True
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(299, 25)
        FirstNameTextBox.TabIndex = 3
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        AddressTextBox.BorderStyle = BorderStyle.None
        AddressTextBox.Font = New Font("Georgia", 13F)
        AddressTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        AddressTextBox.Location = New Point(185, 212)
        AddressTextBox.Multiline = True
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(299, 54)
        AddressTextBox.TabIndex = 5
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = Color.Transparent
        AddressLabel.Font = New Font("Georgia", 12F)
        AddressLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        AddressLabel.ImageAlign = ContentAlignment.MiddleLeft
        AddressLabel.Location = New Point(27, 212)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.RightToLeft = RightToLeft.No
        AddressLabel.Size = New Size(66, 18)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address"
        AddressLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        ContactTextBox.BorderStyle = BorderStyle.None
        ContactTextBox.Font = New Font("Georgia", 13F)
        ContactTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        ContactTextBox.Location = New Point(185, 306)
        ContactTextBox.Multiline = True
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(299, 25)
        ContactTextBox.TabIndex = 7
        ' 
        ' ContactNoLabel
        ' 
        ContactNoLabel.AutoSize = True
        ContactNoLabel.BackColor = Color.Transparent
        ContactNoLabel.Font = New Font("Georgia", 12F)
        ContactNoLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        ContactNoLabel.ImageAlign = ContentAlignment.MiddleLeft
        ContactNoLabel.Location = New Point(27, 306)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.RightToLeft = RightToLeft.No
        ContactNoLabel.Size = New Size(86, 18)
        ContactNoLabel.TabIndex = 6
        ContactNoLabel.Text = "Contact No"
        ContactNoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DOB
        ' 
        DOB.AutoSize = True
        DOB.BackColor = Color.Transparent
        DOB.Font = New Font("Georgia", 12F)
        DOB.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        DOB.ImageAlign = ContentAlignment.MiddleLeft
        DOB.Location = New Point(27, 436)
        DOB.Name = "DOB"
        DOB.RightToLeft = RightToLeft.No
        DOB.Size = New Size(98, 18)
        DOB.TabIndex = 8
        DOB.Text = "Date of Birth"
        DOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarMonthBackground = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTitleBackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTitleForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.Font = New Font("Georgia", 13F)
        DateTimePicker1.Location = New Point(185, 436)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(299, 27)
        DateTimePicker1.TabIndex = 10
        ' 
        ' GenderLabel
        ' 
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = Color.Transparent
        GenderLabel.Font = New Font("Georgia", 12F)
        GenderLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        GenderLabel.ImageAlign = ContentAlignment.MiddleLeft
        GenderLabel.Location = New Point(27, 499)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.RightToLeft = RightToLeft.No
        GenderLabel.Size = New Size(61, 18)
        GenderLabel.TabIndex = 11
        GenderLabel.Text = "Gender"
        GenderLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Gender
        ' 
        Gender.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        Gender.FlatStyle = FlatStyle.Flat
        Gender.Font = New Font("Georgia", 12F)
        Gender.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Gender.FormattingEnabled = True
        Gender.Location = New Point(185, 499)
        Gender.Name = "Gender"
        Gender.Size = New Size(299, 26)
        Gender.TabIndex = 12
        ' 
        ' LessonType
        ' 
        LessonType.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LessonType.FlatStyle = FlatStyle.Flat
        LessonType.Font = New Font("Georgia", 12F)
        LessonType.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LessonType.FormattingEnabled = True
        LessonType.Location = New Point(185, 565)
        LessonType.Name = "LessonType"
        LessonType.Size = New Size(299, 26)
        LessonType.TabIndex = 14
        ' 
        ' LessonTypeLabel
        ' 
        LessonTypeLabel.AutoSize = True
        LessonTypeLabel.BackColor = Color.Transparent
        LessonTypeLabel.Font = New Font("Georgia", 12F)
        LessonTypeLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LessonTypeLabel.ImageAlign = ContentAlignment.MiddleLeft
        LessonTypeLabel.Location = New Point(27, 565)
        LessonTypeLabel.Name = "LessonTypeLabel"
        LessonTypeLabel.RightToLeft = RightToLeft.No
        LessonTypeLabel.Size = New Size(98, 18)
        LessonTypeLabel.TabIndex = 13
        LessonTypeLabel.Text = "Lesson Type"
        LessonTypeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LearnerDataGridView
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LearnerDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        LearnerDataGridView.BackgroundColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LearnerDataGridView.BorderStyle = BorderStyle.None
        LearnerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LearnerDataGridView.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LearnerDataGridView.Location = New Point(586, 166)
        LearnerDataGridView.Name = "LearnerDataGridView"
        LearnerDataGridView.Size = New Size(738, 454)
        LearnerDataGridView.TabIndex = 15
        ' 
        ' Save
        ' 
        Save.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Save.FlatStyle = FlatStyle.Flat
        Save.Font = New Font("Georgia", 14.25F)
        Save.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Save.Image = My.Resources.Resources.download
        Save.ImageAlign = ContentAlignment.MiddleLeft
        Save.Location = New Point(43, 637)
        Save.Name = "Save"
        Save.Size = New Size(125, 37)
        Save.TabIndex = 16
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' Update
        ' 
        Update.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Update.FlatStyle = FlatStyle.Flat
        Update.Font = New Font("Georgia", 14.25F)
        Update.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Update.Image = My.Resources.Resources.changes
        Update.ImageAlign = ContentAlignment.MiddleLeft
        Update.Location = New Point(188, 637)
        Update.Name = "Update"
        Update.Size = New Size(125, 37)
        Update.TabIndex = 17
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Delete.FlatStyle = FlatStyle.Flat
        Delete.Font = New Font("Georgia", 14.25F)
        Delete.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Delete.Image = My.Resources.Resources.delete
        Delete.ImageAlign = ContentAlignment.MiddleLeft
        Delete.Location = New Point(333, 637)
        Delete.Name = "Delete"
        Delete.Size = New Size(125, 37)
        Delete.TabIndex = 18
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' LearnerSearchBox
        ' 
        LearnerSearchBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LearnerSearchBox.BorderStyle = BorderStyle.None
        LearnerSearchBox.Font = New Font("Georgia", 13F)
        LearnerSearchBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LearnerSearchBox.Location = New Point(832, 92)
        LearnerSearchBox.Multiline = True
        LearnerSearchBox.Name = "LearnerSearchBox"
        LearnerSearchBox.Size = New Size(259, 34)
        LearnerSearchBox.TabIndex = 19
        ' 
        ' LearnerSearch
        ' 
        LearnerSearch.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        LearnerSearch.FlatStyle = FlatStyle.Flat
        LearnerSearch.Font = New Font("Georgia", 14.25F)
        LearnerSearch.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LearnerSearch.Image = My.Resources.Resources.paper
        LearnerSearch.ImageAlign = ContentAlignment.MiddleLeft
        LearnerSearch.Location = New Point(1110, 92)
        LearnerSearch.Name = "LearnerSearch"
        LearnerSearch.Size = New Size(130, 34)
        LearnerSearch.TabIndex = 20
        LearnerSearch.Text = "Search"
        LearnerSearch.UseVisualStyleBackColor = False
        ' 
        ' Refresh
        ' 
        Refresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Refresh.FlatStyle = FlatStyle.Flat
        Refresh.Font = New Font("Georgia", 14.25F)
        Refresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Refresh.Image = My.Resources.Resources.reload
        Refresh.ImageAlign = ContentAlignment.MiddleLeft
        Refresh.Location = New Point(106, 694)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(125, 37)
        Refresh.TabIndex = 22
        Refresh.Text = "Refresh"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' DeleteAll
        ' 
        DeleteAll.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        DeleteAll.FlatStyle = FlatStyle.Flat
        DeleteAll.Font = New Font("Georgia", 14.25F)
        DeleteAll.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DeleteAll.Image = My.Resources.Resources.delete__1_
        DeleteAll.ImageAlign = ContentAlignment.MiddleLeft
        DeleteAll.Location = New Point(251, 694)
        DeleteAll.Name = "DeleteAll"
        DeleteAll.Size = New Size(148, 37)
        DeleteAll.TabIndex = 23
        DeleteAll.Text = "Delete All"
        DeleteAll.UseVisualStyleBackColor = False
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        EmailTextBox.BorderStyle = BorderStyle.None
        EmailTextBox.Font = New Font("Georgia", 13F)
        EmailTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        EmailTextBox.Location = New Point(185, 371)
        EmailTextBox.Multiline = True
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(299, 25)
        EmailTextBox.TabIndex = 25
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.BackColor = Color.Transparent
        Email.Font = New Font("Georgia", 12F)
        Email.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Email.ImageAlign = ContentAlignment.MiddleLeft
        Email.Location = New Point(27, 371)
        Email.Name = "Email"
        Email.RightToLeft = RightToLeft.No
        Email.Size = New Size(48, 18)
        Email.TabIndex = 24
        Email.Text = "Email"
        Email.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LastNameTextBox.BorderStyle = BorderStyle.None
        LastNameTextBox.Font = New Font("Georgia", 13F)
        LastNameTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LastNameTextBox.Location = New Point(185, 152)
        LastNameTextBox.Multiline = True
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(299, 25)
        LastNameTextBox.TabIndex = 27
        ' 
        ' LearnerLastName
        ' 
        LearnerLastName.AutoSize = True
        LearnerLastName.BackColor = Color.Transparent
        LearnerLastName.Font = New Font("Georgia", 12F)
        LearnerLastName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LearnerLastName.ImageAlign = ContentAlignment.MiddleLeft
        LearnerLastName.Location = New Point(27, 155)
        LearnerLastName.Name = "LearnerLastName"
        LearnerLastName.RightToLeft = RightToLeft.No
        LearnerLastName.Size = New Size(85, 18)
        LearnerLastName.TabIndex = 26
        LearnerLastName.Text = "Last Name"
        LearnerLastName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label3.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.PaleVioletRed
        Label3.Location = New Point(112, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 34)
        Label3.TabIndex = 28
        Label3.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label4.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.PaleVioletRed
        Label4.Location = New Point(106, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 34)
        Label4.TabIndex = 29
        Label4.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label5.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.PaleVioletRed
        Label5.Location = New Point(91, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 34)
        Label5.TabIndex = 30
        Label5.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label6.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.PaleVioletRed
        Label6.Location = New Point(108, 294)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 34)
        Label6.TabIndex = 31
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label7.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.PaleVioletRed
        Label7.Location = New Point(75, 359)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 34)
        Label7.TabIndex = 32
        Label7.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label8.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.PaleVioletRed
        Label8.Location = New Point(125, 425)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 34)
        Label8.TabIndex = 33
        Label8.Text = "*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label9.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.PaleVioletRed
        Label9.Location = New Point(86, 489)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 34)
        Label9.TabIndex = 34
        Label9.Text = "*"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label10.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.PaleVioletRed
        Label10.Location = New Point(123, 556)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 34)
        Label10.TabIndex = 35
        Label10.Text = "*"
        ' 
        ' Emailalert
        ' 
        Emailalert.AutoSize = True
        Emailalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Emailalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Emailalert.ForeColor = Color.PaleVioletRed
        Emailalert.Location = New Point(185, 399)
        Emailalert.Name = "Emailalert"
        Emailalert.Size = New Size(0, 18)
        Emailalert.TabIndex = 36
        ' 
        ' Contactalert
        ' 
        Contactalert.AutoSize = True
        Contactalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Contactalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Contactalert.ForeColor = Color.PaleVioletRed
        Contactalert.Location = New Point(188, 334)
        Contactalert.Name = "Contactalert"
        Contactalert.Size = New Size(0, 18)
        Contactalert.TabIndex = 37
        ' 
        ' Genderalert
        ' 
        Genderalert.AutoSize = True
        Genderalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Genderalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Genderalert.ForeColor = Color.PaleVioletRed
        Genderalert.Location = New Point(185, 528)
        Genderalert.Name = "Genderalert"
        Genderalert.Size = New Size(0, 18)
        Genderalert.TabIndex = 38
        ' 
        ' LessonTypealert
        ' 
        LessonTypealert.AutoSize = True
        LessonTypealert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        LessonTypealert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LessonTypealert.ForeColor = Color.PaleVioletRed
        LessonTypealert.Location = New Point(185, 594)
        LessonTypealert.Name = "LessonTypealert"
        LessonTypealert.Size = New Size(0, 18)
        LessonTypealert.TabIndex = 39
        ' 
        ' DOBalert
        ' 
        DOBalert.AutoSize = True
        DOBalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        DOBalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DOBalert.ForeColor = Color.PaleVioletRed
        DOBalert.Location = New Point(185, 466)
        DOBalert.Name = "DOBalert"
        DOBalert.Size = New Size(0, 18)
        DOBalert.TabIndex = 40
        ' 
        ' SearchRefresh
        ' 
        SearchRefresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        SearchRefresh.FlatStyle = FlatStyle.Flat
        SearchRefresh.Font = New Font("Georgia", 14.25F)
        SearchRefresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        SearchRefresh.Image = My.Resources.Resources.reload
        SearchRefresh.ImageAlign = ContentAlignment.MiddleLeft
        SearchRefresh.Location = New Point(1246, 91)
        SearchRefresh.Name = "SearchRefresh"
        SearchRefresh.Size = New Size(34, 34)
        SearchRefresh.TabIndex = 41
        SearchRefresh.UseVisualStyleBackColor = False
        ' 
        ' LearnerSerachComboBox
        ' 
        LearnerSerachComboBox.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        LearnerSerachComboBox.FlatStyle = FlatStyle.Flat
        LearnerSerachComboBox.Font = New Font("Georgia", 14F)
        LearnerSerachComboBox.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        LearnerSerachComboBox.FormattingEnabled = True
        LearnerSerachComboBox.Items.AddRange(New Object() {"First Name", "Last Name", "Address", "Email", "Lesson Type"})
        LearnerSerachComboBox.Location = New Point(586, 94)
        LearnerSerachComboBox.Name = "LearnerSerachComboBox"
        LearnerSerachComboBox.Size = New Size(228, 31)
        LearnerSerachComboBox.TabIndex = 42
        ' 
        ' Learners
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        ClientSize = New Size(1426, 814)
        Controls.Add(LearnerSerachComboBox)
        Controls.Add(SearchRefresh)
        Controls.Add(DOBalert)
        Controls.Add(LessonTypealert)
        Controls.Add(Genderalert)
        Controls.Add(Contactalert)
        Controls.Add(Emailalert)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LastNameTextBox)
        Controls.Add(LearnerLastName)
        Controls.Add(EmailTextBox)
        Controls.Add(Email)
        Controls.Add(DeleteAll)
        Controls.Add(Refresh)
        Controls.Add(LearnerSearch)
        Controls.Add(LearnerSearchBox)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Save)
        Controls.Add(LearnerDataGridView)
        Controls.Add(LessonType)
        Controls.Add(LessonTypeLabel)
        Controls.Add(Gender)
        Controls.Add(GenderLabel)
        Controls.Add(DateTimePicker1)
        Controls.Add(DOB)
        Controls.Add(ContactTextBox)
        Controls.Add(ContactNoLabel)
        Controls.Add(AddressTextBox)
        Controls.Add(AddressLabel)
        Controls.Add(FirstNameTextBox)
        Controls.Add(LearnerFirstName)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Learners"
        Text = "Learners"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(LearnerDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LearnerFirstName As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents ContactNoLabel As Label
    Friend WithEvents DOB As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GenderLabel As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Gender As ComboBox
    Friend WithEvents LessonType As ComboBox
    Friend WithEvents LessonTypeLabel As Label
    Friend WithEvents LearnerDataGridView As DataGridView
    Friend WithEvents Save As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents LearnerSearchBox As TextBox
    Friend WithEvents LearnerSearch As Button
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents Refresh As Button
    Friend WithEvents DeleteAll As Button
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LearnerLastName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Emailalert As Label
    Friend WithEvents Contactalert As Label
    Friend WithEvents Genderalert As Label
    Friend WithEvents LessonTypealert As Label
    Friend WithEvents DOBalert As Label
    Friend WithEvents SearchRefresh As Button
    Friend WithEvents LearnerSerachComboBox As ComboBox
End Class
