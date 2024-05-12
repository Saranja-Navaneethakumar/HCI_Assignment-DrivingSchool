<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructors
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
        InstructorSerachComboBox = New ComboBox()
        SearchRefresh = New Button()
        DOBalert = New Label()
        LessonTypealert = New Label()
        Genderalert = New Label()
        Contactalert = New Label()
        Emailalert = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        LastNameTextBox = New TextBox()
        InstructorLastName = New Label()
        EmailTextBox = New TextBox()
        Email = New Label()
        DeleteAll = New Button()
        Refresh = New Button()
        InstructorSearch = New Button()
        InstructorSearchBox = New TextBox()
        Delete = New Button()
        Update = New Button()
        Save = New Button()
        InstructorDataGridView = New DataGridView()
        TypeInstructor = New ComboBox()
        InstructorType = New Label()
        GenderLabel = New Label()
        DateTimePicker1 = New DateTimePicker()
        DOB = New Label()
        ContactTextBox = New TextBox()
        ContactNoLabel = New Label()
        AddressTextBox = New TextBox()
        AddressLabel = New Label()
        FirstNameTextBox = New TextBox()
        InstructorFirstName = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Gender = New ComboBox()
        CType(InstructorDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InstructorSerachComboBox
        ' 
        InstructorSerachComboBox.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        InstructorSerachComboBox.FlatStyle = FlatStyle.Flat
        InstructorSerachComboBox.Font = New Font("Georgia", 14F)
        InstructorSerachComboBox.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        InstructorSerachComboBox.FormattingEnabled = True
        InstructorSerachComboBox.Items.AddRange(New Object() {"First Name", "Last Name", "Address", "Email", "Instructor Type"})
        InstructorSerachComboBox.Location = New Point(589, 110)
        InstructorSerachComboBox.Name = "InstructorSerachComboBox"
        InstructorSerachComboBox.Size = New Size(228, 31)
        InstructorSerachComboBox.TabIndex = 83
        ' 
        ' SearchRefresh
        ' 
        SearchRefresh.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        SearchRefresh.FlatStyle = FlatStyle.Flat
        SearchRefresh.Font = New Font("Georgia", 14.25F)
        SearchRefresh.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        SearchRefresh.Image = My.Resources.Resources.reload
        SearchRefresh.ImageAlign = ContentAlignment.MiddleLeft
        SearchRefresh.Location = New Point(1249, 107)
        SearchRefresh.Name = "SearchRefresh"
        SearchRefresh.Size = New Size(34, 34)
        SearchRefresh.TabIndex = 82
        SearchRefresh.UseVisualStyleBackColor = False
        ' 
        ' DOBalert
        ' 
        DOBalert.AutoSize = True
        DOBalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        DOBalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DOBalert.ForeColor = Color.PaleVioletRed
        DOBalert.Location = New Point(188, 482)
        DOBalert.Name = "DOBalert"
        DOBalert.Size = New Size(0, 18)
        DOBalert.TabIndex = 81
        ' 
        ' LessonTypealert
        ' 
        LessonTypealert.AutoSize = True
        LessonTypealert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        LessonTypealert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LessonTypealert.ForeColor = Color.PaleVioletRed
        LessonTypealert.Location = New Point(188, 610)
        LessonTypealert.Name = "LessonTypealert"
        LessonTypealert.Size = New Size(0, 18)
        LessonTypealert.TabIndex = 80
        ' 
        ' Genderalert
        ' 
        Genderalert.AutoSize = True
        Genderalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Genderalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Genderalert.ForeColor = Color.PaleVioletRed
        Genderalert.Location = New Point(188, 544)
        Genderalert.Name = "Genderalert"
        Genderalert.Size = New Size(0, 18)
        Genderalert.TabIndex = 79
        ' 
        ' Contactalert
        ' 
        Contactalert.AutoSize = True
        Contactalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Contactalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Contactalert.ForeColor = Color.PaleVioletRed
        Contactalert.Location = New Point(191, 350)
        Contactalert.Name = "Contactalert"
        Contactalert.Size = New Size(0, 18)
        Contactalert.TabIndex = 78
        ' 
        ' Emailalert
        ' 
        Emailalert.AutoSize = True
        Emailalert.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Emailalert.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Emailalert.ForeColor = Color.PaleVioletRed
        Emailalert.Location = New Point(188, 415)
        Emailalert.Name = "Emailalert"
        Emailalert.Size = New Size(0, 18)
        Emailalert.TabIndex = 77
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label10.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.PaleVioletRed
        Label10.Location = New Point(72, 572)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 34)
        Label10.TabIndex = 76
        Label10.Text = "*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label9.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.PaleVioletRed
        Label9.Location = New Point(89, 505)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 34)
        Label9.TabIndex = 75
        Label9.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label8.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.PaleVioletRed
        Label8.Location = New Point(128, 441)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 34)
        Label8.TabIndex = 74
        Label8.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label7.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.PaleVioletRed
        Label7.Location = New Point(78, 375)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 34)
        Label7.TabIndex = 73
        Label7.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label6.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.PaleVioletRed
        Label6.Location = New Point(111, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 34)
        Label6.TabIndex = 72
        Label6.Text = "*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label5.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.PaleVioletRed
        Label5.Location = New Point(94, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 34)
        Label5.TabIndex = 71
        Label5.Text = "*"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label4.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.PaleVioletRed
        Label4.Location = New Point(109, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 34)
        Label4.TabIndex = 70
        Label4.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        Label3.Font = New Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.PaleVioletRed
        Label3.Location = New Point(115, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 34)
        Label3.TabIndex = 69
        Label3.Text = "*"
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        LastNameTextBox.BorderStyle = BorderStyle.None
        LastNameTextBox.Font = New Font("Georgia", 13F)
        LastNameTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LastNameTextBox.Location = New Point(188, 168)
        LastNameTextBox.Multiline = True
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(299, 25)
        LastNameTextBox.TabIndex = 68
        ' 
        ' InstructorLastName
        ' 
        InstructorLastName.AutoSize = True
        InstructorLastName.BackColor = Color.Transparent
        InstructorLastName.Font = New Font("Georgia", 12F)
        InstructorLastName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        InstructorLastName.ImageAlign = ContentAlignment.MiddleLeft
        InstructorLastName.Location = New Point(30, 171)
        InstructorLastName.Name = "InstructorLastName"
        InstructorLastName.RightToLeft = RightToLeft.No
        InstructorLastName.Size = New Size(85, 18)
        InstructorLastName.TabIndex = 67
        InstructorLastName.Text = "Last Name"
        InstructorLastName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        EmailTextBox.BorderStyle = BorderStyle.None
        EmailTextBox.Font = New Font("Georgia", 13F)
        EmailTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        EmailTextBox.Location = New Point(188, 387)
        EmailTextBox.Multiline = True
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(299, 25)
        EmailTextBox.TabIndex = 66
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.BackColor = Color.Transparent
        Email.Font = New Font("Georgia", 12F)
        Email.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Email.ImageAlign = ContentAlignment.MiddleLeft
        Email.Location = New Point(30, 387)
        Email.Name = "Email"
        Email.RightToLeft = RightToLeft.No
        Email.Size = New Size(48, 18)
        Email.TabIndex = 65
        Email.Text = "Email"
        Email.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DeleteAll
        ' 
        DeleteAll.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        DeleteAll.FlatStyle = FlatStyle.Flat
        DeleteAll.Font = New Font("Georgia", 14.25F)
        DeleteAll.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DeleteAll.Image = My.Resources.Resources.delete__1_
        DeleteAll.ImageAlign = ContentAlignment.MiddleLeft
        DeleteAll.Location = New Point(254, 710)
        DeleteAll.Name = "DeleteAll"
        DeleteAll.Size = New Size(148, 37)
        DeleteAll.TabIndex = 64
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
        Refresh.Location = New Point(109, 710)
        Refresh.Name = "Refresh"
        Refresh.Size = New Size(125, 37)
        Refresh.TabIndex = 63
        Refresh.Text = "Refresh"
        Refresh.UseVisualStyleBackColor = False
        ' 
        ' InstructorSearch
        ' 
        InstructorSearch.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        InstructorSearch.FlatStyle = FlatStyle.Flat
        InstructorSearch.Font = New Font("Georgia", 14.25F)
        InstructorSearch.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorSearch.Image = My.Resources.Resources.paper
        InstructorSearch.ImageAlign = ContentAlignment.MiddleLeft
        InstructorSearch.Location = New Point(1113, 108)
        InstructorSearch.Name = "InstructorSearch"
        InstructorSearch.Size = New Size(130, 34)
        InstructorSearch.TabIndex = 62
        InstructorSearch.Text = "Search"
        InstructorSearch.UseVisualStyleBackColor = False
        ' 
        ' InstructorSearchBox
        ' 
        InstructorSearchBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        InstructorSearchBox.BorderStyle = BorderStyle.None
        InstructorSearchBox.Font = New Font("Georgia", 13F)
        InstructorSearchBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorSearchBox.Location = New Point(835, 108)
        InstructorSearchBox.Multiline = True
        InstructorSearchBox.Name = "InstructorSearchBox"
        InstructorSearchBox.Size = New Size(259, 34)
        InstructorSearchBox.TabIndex = 61
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Delete.FlatStyle = FlatStyle.Flat
        Delete.Font = New Font("Georgia", 14.25F)
        Delete.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Delete.Image = My.Resources.Resources.delete
        Delete.ImageAlign = ContentAlignment.MiddleLeft
        Delete.Location = New Point(336, 653)
        Delete.Name = "Delete"
        Delete.Size = New Size(125, 37)
        Delete.TabIndex = 60
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
        Update.Location = New Point(191, 653)
        Update.Name = "Update"
        Update.Size = New Size(125, 37)
        Update.TabIndex = 59
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
        Save.Location = New Point(46, 653)
        Save.Name = "Save"
        Save.Size = New Size(125, 37)
        Save.TabIndex = 58
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = False
        ' 
        ' InstructorDataGridView
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        InstructorDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        InstructorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        InstructorDataGridView.BackgroundColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorDataGridView.BorderStyle = BorderStyle.None
        InstructorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InstructorDataGridView.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        InstructorDataGridView.Location = New Point(589, 182)
        InstructorDataGridView.Name = "InstructorDataGridView"
        InstructorDataGridView.Size = New Size(758, 631)
        InstructorDataGridView.TabIndex = 57
        ' 
        ' TypeInstructor
        ' 
        TypeInstructor.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        TypeInstructor.FlatStyle = FlatStyle.Flat
        TypeInstructor.Font = New Font("Georgia", 12F)
        TypeInstructor.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        TypeInstructor.FormattingEnabled = True
        TypeInstructor.Items.AddRange(New Object() {"Full Time", "Part Time"})
        TypeInstructor.Location = New Point(188, 581)
        TypeInstructor.Name = "TypeInstructor"
        TypeInstructor.Size = New Size(299, 26)
        TypeInstructor.TabIndex = 56
        ' 
        ' InstructorType
        ' 
        InstructorType.AutoSize = True
        InstructorType.BackColor = Color.Transparent
        InstructorType.Font = New Font("Georgia", 12F)
        InstructorType.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        InstructorType.ImageAlign = ContentAlignment.MiddleLeft
        InstructorType.Location = New Point(30, 581)
        InstructorType.Name = "InstructorType"
        InstructorType.RightToLeft = RightToLeft.No
        InstructorType.Size = New Size(45, 18)
        InstructorType.TabIndex = 55
        InstructorType.Text = "Type"
        InstructorType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GenderLabel
        ' 
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = Color.Transparent
        GenderLabel.Font = New Font("Georgia", 12F)
        GenderLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        GenderLabel.ImageAlign = ContentAlignment.MiddleLeft
        GenderLabel.Location = New Point(30, 515)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.RightToLeft = RightToLeft.No
        GenderLabel.Size = New Size(61, 18)
        GenderLabel.TabIndex = 53
        GenderLabel.Text = "Gender"
        GenderLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarMonthBackground = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTitleBackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTitleForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DateTimePicker1.Font = New Font("Georgia", 13F)
        DateTimePicker1.Location = New Point(188, 452)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(299, 27)
        DateTimePicker1.TabIndex = 52
        ' 
        ' DOB
        ' 
        DOB.AutoSize = True
        DOB.BackColor = Color.Transparent
        DOB.Font = New Font("Georgia", 12F)
        DOB.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        DOB.ImageAlign = ContentAlignment.MiddleLeft
        DOB.Location = New Point(30, 452)
        DOB.Name = "DOB"
        DOB.RightToLeft = RightToLeft.No
        DOB.Size = New Size(98, 18)
        DOB.TabIndex = 51
        DOB.Text = "Date of Birth"
        DOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContactTextBox
        ' 
        ContactTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        ContactTextBox.BorderStyle = BorderStyle.None
        ContactTextBox.Font = New Font("Georgia", 13F)
        ContactTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        ContactTextBox.Location = New Point(188, 322)
        ContactTextBox.Multiline = True
        ContactTextBox.Name = "ContactTextBox"
        ContactTextBox.Size = New Size(299, 25)
        ContactTextBox.TabIndex = 50
        ' 
        ' ContactNoLabel
        ' 
        ContactNoLabel.AutoSize = True
        ContactNoLabel.BackColor = Color.Transparent
        ContactNoLabel.Font = New Font("Georgia", 12F)
        ContactNoLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        ContactNoLabel.ImageAlign = ContentAlignment.MiddleLeft
        ContactNoLabel.Location = New Point(30, 322)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.RightToLeft = RightToLeft.No
        ContactNoLabel.Size = New Size(86, 18)
        ContactNoLabel.TabIndex = 49
        ContactNoLabel.Text = "Contact No"
        ContactNoLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        AddressTextBox.BorderStyle = BorderStyle.None
        AddressTextBox.Font = New Font("Georgia", 13F)
        AddressTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        AddressTextBox.Location = New Point(188, 228)
        AddressTextBox.Multiline = True
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(299, 54)
        AddressTextBox.TabIndex = 48
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = Color.Transparent
        AddressLabel.Font = New Font("Georgia", 12F)
        AddressLabel.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        AddressLabel.ImageAlign = ContentAlignment.MiddleLeft
        AddressLabel.Location = New Point(30, 228)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.RightToLeft = RightToLeft.No
        AddressLabel.Size = New Size(66, 18)
        AddressLabel.TabIndex = 47
        AddressLabel.Text = "Address"
        AddressLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        FirstNameTextBox.BorderStyle = BorderStyle.None
        FirstNameTextBox.Font = New Font("Georgia", 13F)
        FirstNameTextBox.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        FirstNameTextBox.Location = New Point(188, 107)
        FirstNameTextBox.Multiline = True
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(299, 25)
        FirstNameTextBox.TabIndex = 46
        ' 
        ' InstructorFirstName
        ' 
        InstructorFirstName.AutoSize = True
        InstructorFirstName.BackColor = Color.Transparent
        InstructorFirstName.Font = New Font("Georgia", 12F)
        InstructorFirstName.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        InstructorFirstName.ImageAlign = ContentAlignment.MiddleLeft
        InstructorFirstName.Location = New Point(30, 110)
        InstructorFirstName.Name = "InstructorFirstName"
        InstructorFirstName.RightToLeft = RightToLeft.No
        InstructorFirstName.Size = New Size(88, 18)
        InstructorFirstName.TabIndex = 45
        InstructorFirstName.Text = "First Name"
        InstructorFirstName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.driver__4_
        PictureBox1.Location = New Point(207, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 15F)
        Label1.ForeColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(20, 36)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(186, 24)
        Label1.TabIndex = 43
        Label1.Text = "Manage Instructors"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Gender
        ' 
        Gender.BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        Gender.FlatStyle = FlatStyle.Flat
        Gender.Font = New Font("Georgia", 12F)
        Gender.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Gender.FormattingEnabled = True
        Gender.Location = New Point(188, 515)
        Gender.Name = "Gender"
        Gender.Size = New Size(299, 26)
        Gender.TabIndex = 54
        ' 
        ' Instructors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        ClientSize = New Size(1426, 814)
        Controls.Add(InstructorSerachComboBox)
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
        Controls.Add(InstructorLastName)
        Controls.Add(EmailTextBox)
        Controls.Add(Email)
        Controls.Add(DeleteAll)
        Controls.Add(Refresh)
        Controls.Add(InstructorSearch)
        Controls.Add(InstructorSearchBox)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Save)
        Controls.Add(InstructorDataGridView)
        Controls.Add(TypeInstructor)
        Controls.Add(InstructorType)
        Controls.Add(Gender)
        Controls.Add(GenderLabel)
        Controls.Add(DateTimePicker1)
        Controls.Add(DOB)
        Controls.Add(ContactTextBox)
        Controls.Add(ContactNoLabel)
        Controls.Add(AddressTextBox)
        Controls.Add(AddressLabel)
        Controls.Add(FirstNameTextBox)
        Controls.Add(InstructorFirstName)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Instructors"
        Text = "Instructors"
        CType(InstructorDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InstructorSerachComboBox As ComboBox
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents InstructorLastName As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents DeleteAll As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents InstructorSearch As Button
    Friend WithEvents InstructorSearchBox As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents Update As Button
    Friend WithEvents Save As Button
    Friend WithEvents InstructorDataGridView As DataGridView
    Friend WithEvents TypeInstructor As ComboBox
    Friend WithEvents InstructorType As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DOB As Label
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents ContactNoLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents InstructorFirstName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Gender As ComboBox
End Class
