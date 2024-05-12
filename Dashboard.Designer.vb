<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        SidePanel = New Panel()
        LogoutPanel = New Panel()
        Button10 = New Button()
        LessonsPanel = New Panel()
        InstructorPanel = New Panel()
        CoursesPanel = New Panel()
        LearnersPanel = New Panel()
        DashboardPanel = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        MenuButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Close = New Button()
        Restore = New Button()
        Maximize = New Button()
        Minimize = New Button()
        Timer1 = New Timer(components)
        MainPanel = New Panel()
        Button9 = New Button()
        Button2 = New Button()
        SidePanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        SidePanel.Controls.Add(Button9)
        SidePanel.Controls.Add(LogoutPanel)
        SidePanel.Controls.Add(Button2)
        SidePanel.Controls.Add(Button10)
        SidePanel.Controls.Add(LessonsPanel)
        SidePanel.Controls.Add(InstructorPanel)
        SidePanel.Controls.Add(CoursesPanel)
        SidePanel.Controls.Add(LearnersPanel)
        SidePanel.Controls.Add(DashboardPanel)
        SidePanel.Controls.Add(Button8)
        SidePanel.Controls.Add(Button7)
        SidePanel.Controls.Add(Button6)
        SidePanel.Controls.Add(Button5)
        SidePanel.Controls.Add(Button4)
        SidePanel.Controls.Add(Button3)
        SidePanel.Controls.Add(PictureBox1)
        SidePanel.Controls.Add(Panel3)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 0)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(198, 814)
        SidePanel.TabIndex = 0
        ' 
        ' LogoutPanel
        ' 
        LogoutPanel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LogoutPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LogoutPanel.Location = New Point(0, 768)
        LogoutPanel.Name = "LogoutPanel"
        LogoutPanel.Size = New Size(10, 44)
        LogoutPanel.TabIndex = 16
        ' 
        ' Button10
        ' 
        Button10.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Georgia", 13.0F)
        Button10.ForeColor = Color.White
        Button10.Image = My.Resources.Resources.instagram
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(11, 559)
        Button10.Name = "Button10"
        Button10.Size = New Size(36, 44)
        Button10.TabIndex = 10
        Button10.UseVisualStyleBackColor = True
        ' 
        ' LessonsPanel
        ' 
        LessonsPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LessonsPanel.Location = New Point(0, 486)
        LessonsPanel.Name = "LessonsPanel"
        LessonsPanel.Size = New Size(10, 44)
        LessonsPanel.TabIndex = 15
        ' 
        ' InstructorPanel
        ' 
        InstructorPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        InstructorPanel.Location = New Point(0, 326)
        InstructorPanel.Name = "InstructorPanel"
        InstructorPanel.Size = New Size(10, 44)
        InstructorPanel.TabIndex = 14
        ' 
        ' CoursesPanel
        ' 
        CoursesPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        CoursesPanel.Location = New Point(0, 406)
        CoursesPanel.Name = "CoursesPanel"
        CoursesPanel.Size = New Size(10, 44)
        CoursesPanel.TabIndex = 13
        ' 
        ' LearnersPanel
        ' 
        LearnersPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        LearnersPanel.Location = New Point(0, 246)
        LearnersPanel.Name = "LearnersPanel"
        LearnersPanel.Size = New Size(10, 44)
        LearnersPanel.TabIndex = 12
        ' 
        ' DashboardPanel
        ' 
        DashboardPanel.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        DashboardPanel.Location = New Point(0, 166)
        DashboardPanel.Name = "DashboardPanel"
        DashboardPanel.Size = New Size(10, 44)
        DashboardPanel.TabIndex = 11
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Georgia", 13.0F)
        Button8.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button8.Image = My.Resources.Resources.logout
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(11, 768)
        Button8.Name = "Button8"
        Button8.Size = New Size(181, 44)
        Button8.TabIndex = 7
        Button8.Text = "Logout"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Georgia", 13.0F)
        Button7.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button7.Image = My.Resources.Resources.driving_license__1_
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(11, 486)
        Button7.Name = "Button7"
        Button7.Size = New Size(181, 44)
        Button7.TabIndex = 6
        Button7.Text = "Lessons"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Georgia", 13.0F)
        Button6.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button6.Image = My.Resources.Resources.test_drive__1_
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(11, 406)
        Button6.Name = "Button6"
        Button6.Size = New Size(181, 44)
        Button6.TabIndex = 5
        Button6.Text = "Courses"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Georgia", 13.0F)
        Button5.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button5.Image = My.Resources.Resources.driver__1_
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(12, 326)
        Button5.Name = "Button5"
        Button5.Size = New Size(181, 44)
        Button5.TabIndex = 4
        Button5.Text = "Instructors"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Georgia", 13.0F)
        Button4.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button4.Image = My.Resources.Resources.people__1_
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(11, 246)
        Button4.Name = "Button4"
        Button4.Size = New Size(181, 44)
        Button4.TabIndex = 3
        Button4.Text = "Learners"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Georgia", 13.0F)
        Button3.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Button3.Image = My.Resources.Resources.app__1_
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(11, 166)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 44)
        Button3.TabIndex = 2
        Button3.Text = "Dashboard"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account__3_
        PictureBox1.Location = New Point(9, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Panel3.Controls.Add(MenuButton)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(198, 50)
        Panel3.TabIndex = 0
        ' 
        ' MenuButton
        ' 
        MenuButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MenuButton.FlatAppearance.BorderSize = 0
        MenuButton.FlatStyle = FlatStyle.Flat
        MenuButton.Font = New Font("Georgia", 13.0F)
        MenuButton.Image = My.Resources.Resources.menus
        MenuButton.Location = New Point(150, 7)
        MenuButton.Name = "MenuButton"
        MenuButton.Size = New Size(42, 37)
        MenuButton.TabIndex = 2
        MenuButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 12.0F)
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Label1.Location = New Point(18, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 18)
        Label1.TabIndex = 11
        Label1.Text = "SARAN DRIVING SCHOOL"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(191), CByte(172), CByte(170))
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Close)
        Panel2.Controls.Add(Restore)
        Panel2.Controls.Add(Maximize)
        Panel2.Controls.Add(Minimize)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(198, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1228, 50)
        Panel2.TabIndex = 1
        ' 
        ' Close
        ' 
        Close.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Close.FlatAppearance.BorderSize = 0
        Close.FlatStyle = FlatStyle.Flat
        Close.Font = New Font("Georgia", 13.0F)
        Close.ForeColor = Color.White
        Close.Image = My.Resources.Resources.close__4_
        Close.ImageAlign = ContentAlignment.MiddleLeft
        Close.Location = New Point(1184, 12)
        Close.Name = "Close"
        Close.Size = New Size(27, 30)
        Close.TabIndex = 14
        Close.UseVisualStyleBackColor = True
        ' 
        ' Restore
        ' 
        Restore.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Restore.FlatAppearance.BorderSize = 0
        Restore.FlatStyle = FlatStyle.Flat
        Restore.Font = New Font("Georgia", 13.0F)
        Restore.ForeColor = Color.White
        Restore.Image = My.Resources.Resources.restore_down__1_
        Restore.ImageAlign = ContentAlignment.MiddleLeft
        Restore.Location = New Point(1152, 12)
        Restore.Name = "Restore"
        Restore.Size = New Size(27, 30)
        Restore.TabIndex = 13
        Restore.UseVisualStyleBackColor = True
        ' 
        ' Maximize
        ' 
        Maximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Maximize.FlatAppearance.BorderSize = 0
        Maximize.FlatStyle = FlatStyle.Flat
        Maximize.Font = New Font("Georgia", 13.0F)
        Maximize.ForeColor = Color.White
        Maximize.Image = My.Resources.Resources.open__1_
        Maximize.ImageAlign = ContentAlignment.MiddleLeft
        Maximize.Location = New Point(1120, 12)
        Maximize.Name = "Maximize"
        Maximize.Size = New Size(27, 30)
        Maximize.TabIndex = 12
        Maximize.UseVisualStyleBackColor = True
        ' 
        ' Minimize
        ' 
        Minimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Minimize.FlatAppearance.BorderSize = 0
        Minimize.FlatStyle = FlatStyle.Flat
        Minimize.Font = New Font("Georgia", 13.0F)
        Minimize.ForeColor = Color.White
        Minimize.Image = My.Resources.Resources.minus_sign__1_
        Minimize.ImageAlign = ContentAlignment.MiddleLeft
        Minimize.Location = New Point(1088, 12)
        Minimize.Name = "Minimize"
        Minimize.Size = New Size(27, 30)
        Minimize.TabIndex = 11
        Minimize.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' MainPanel
        ' 
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(198, 50)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1228, 764)
        MainPanel.TabIndex = 2
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Georgia", 13.0F)
        Button9.ForeColor = Color.White
        Button9.Image = My.Resources.Resources.linkedin
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(11, 660)
        Button9.Name = "Button9"
        Button9.Size = New Size(36, 44)
        Button9.TabIndex = 10
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Georgia", 13.0F)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.facebook
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(11, 610)
        Button2.Name = "Button2"
        Button2.Size = New Size(36, 44)
        Button2.TabIndex = 10
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        ClientSize = New Size(1426, 814)
        Controls.Add(MainPanel)
        Controls.Add(Panel2)
        Controls.Add(SidePanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        SidePanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Minimize As Button
    Friend WithEvents Restore As Button
    Friend WithEvents Maximize As Button
    Friend WithEvents Close As Button
    Friend WithEvents DashboardPanel As Panel
    Friend WithEvents LearnersPanel As Panel
    Friend WithEvents CoursesPanel As Panel
    Friend WithEvents LogoutPanel As Panel
    Friend WithEvents LessonsPanel As Panel
    Friend WithEvents InstructorPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDahboard As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
End Class
