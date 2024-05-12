<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPanel
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
        Panel1 = New Panel()
        LearnerCount = New Label()
        PictureBox1 = New PictureBox()
        Learners = New Label()
        Panel2 = New Panel()
        InstructorCount = New Label()
        PictureBox2 = New PictureBox()
        Instructors = New Label()
        Panel3 = New Panel()
        CoursesCount = New Label()
        PictureBox3 = New PictureBox()
        Courses = New Label()
        Panel4 = New Panel()
        LessonCount = New Label()
        PictureBox4 = New PictureBox()
        Lessons = New Label()
        Panel5 = New Panel()
        TotalIncome = New Label()
        PictureBox5 = New PictureBox()
        Income = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Panel1.Controls.Add(LearnerCount)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Learners)
        Panel1.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Panel1.Location = New Point(78, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(268, 135)
        Panel1.TabIndex = 0
        ' 
        ' LearnerCount
        ' 
        LearnerCount.AutoSize = True
        LearnerCount.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LearnerCount.Location = New Point(98, 55)
        LearnerCount.Name = "LearnerCount"
        LearnerCount.Size = New Size(0, 25)
        LearnerCount.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.people__5_
        PictureBox1.Location = New Point(17, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 65)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Learners
        ' 
        Learners.AutoSize = True
        Learners.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Learners.Location = New Point(17, 10)
        Learners.Name = "Learners"
        Learners.Size = New Size(95, 25)
        Learners.TabIndex = 0
        Learners.Text = "Learners"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(InstructorCount)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Instructors)
        Panel2.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Panel2.Location = New Point(390, 86)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(268, 135)
        Panel2.TabIndex = 1
        ' 
        ' InstructorCount
        ' 
        InstructorCount.AutoSize = True
        InstructorCount.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorCount.Location = New Point(98, 55)
        InstructorCount.Name = "InstructorCount"
        InstructorCount.Size = New Size(0, 25)
        InstructorCount.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.driver__5_
        PictureBox2.Location = New Point(17, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 65)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Instructors
        ' 
        Instructors.AutoSize = True
        Instructors.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Instructors.Location = New Point(17, 10)
        Instructors.Name = "Instructors"
        Instructors.Size = New Size(115, 25)
        Instructors.TabIndex = 1
        Instructors.Text = "Instructors"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Panel3.Controls.Add(CoursesCount)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Courses)
        Panel3.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Panel3.Location = New Point(702, 86)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(268, 135)
        Panel3.TabIndex = 1
        ' 
        ' CoursesCount
        ' 
        CoursesCount.AutoSize = True
        CoursesCount.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CoursesCount.Location = New Point(98, 55)
        CoursesCount.Name = "CoursesCount"
        CoursesCount.Size = New Size(0, 25)
        CoursesCount.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.test_drive__3_
        PictureBox3.Location = New Point(19, 47)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(70, 65)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Courses
        ' 
        Courses.AutoSize = True
        Courses.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Courses.Location = New Point(19, 10)
        Courses.Name = "Courses"
        Courses.Size = New Size(85, 25)
        Courses.TabIndex = 2
        Courses.Text = "Courses"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Panel4.Controls.Add(LessonCount)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(Lessons)
        Panel4.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Panel4.Location = New Point(1011, 86)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(268, 135)
        Panel4.TabIndex = 2
        ' 
        ' LessonCount
        ' 
        LessonCount.AutoSize = True
        LessonCount.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LessonCount.Location = New Point(98, 55)
        LessonCount.Name = "LessonCount"
        LessonCount.Size = New Size(0, 25)
        LessonCount.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.driving_license__3_
        PictureBox4.Location = New Point(15, 47)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(70, 65)
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Lessons
        ' 
        Lessons.AutoSize = True
        Lessons.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lessons.Location = New Point(15, 10)
        Lessons.Name = "Lessons"
        Lessons.Size = New Size(85, 25)
        Lessons.TabIndex = 3
        Lessons.Text = "Lessons"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Panel5.Controls.Add(TotalIncome)
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(Income)
        Panel5.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Panel5.Location = New Point(78, 264)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(268, 135)
        Panel5.TabIndex = 4
        ' 
        ' TotalIncome
        ' 
        TotalIncome.AutoSize = True
        TotalIncome.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalIncome.Location = New Point(98, 55)
        TotalIncome.Name = "TotalIncome"
        TotalIncome.Size = New Size(0, 25)
        TotalIncome.TabIndex = 6
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.money
        PictureBox5.Location = New Point(17, 48)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(70, 65)
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' Income
        ' 
        Income.AutoSize = True
        Income.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Income.Location = New Point(15, 10)
        Income.Name = "Income"
        Income.Size = New Size(82, 25)
        Income.TabIndex = 3
        Income.Text = "Income"
        ' 
        ' DashboardPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(7), CByte(42), CByte(98))
        ClientSize = New Size(1426, 814)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardPanel"
        Text = "DashboardPanel"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Learners As Label
    Friend WithEvents Instructors As Label
    Friend WithEvents Courses As Label
    Friend WithEvents Lessons As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Income As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LearnerCount As Label
    Friend WithEvents InstructorCount As Label
    Friend WithEvents CoursesCount As Label
    Friend WithEvents LessonCount As Label
    Friend WithEvents TotalIncome As Label
End Class
