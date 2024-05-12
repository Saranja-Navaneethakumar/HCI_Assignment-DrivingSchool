Public Class DashboardPanel
    Private Sub Instructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim learner_count = SaveDataInTextFile.GetRowCountIgnoringFirstLine(FilePaths.learnerFilePath)
        Dim instructor_count = SaveDataInTextFile.GetRowCountIgnoringFirstLine(FilePaths.instructorFilePath)
        Dim course_count = SaveDataInTextFile.GetRowCountIgnoringFirstLine(FilePaths.coursesFilePath)
        Dim lesson_count = SaveDataInTextFile.GetRowCountIgnoringFirstLine(FilePaths.lessonFilePath)

        Dim total_income As Double
        LearnerCount.Text = learner_count
        InstructorCount.Text = instructor_count
        CoursesCount.Text = course_count
        LessonCount.Text = lesson_count

        'Load lessons
        Dim dashboard_lesson As New DataTable("table")
        dashboard_lesson.Columns.Add("ID", Type.GetType("System.Int32"))
        dashboard_lesson.Columns.Add("Learner Name", Type.GetType("System.String"))
        dashboard_lesson.Columns.Add("Course Name", Type.GetType("System.String"))
        dashboard_lesson.Columns.Add("Instructor", Type.GetType("System.String"))
        dashboard_lesson.Columns.Add("Duration", Type.GetType("System.String"))
        dashboard_lesson.Columns.Add("Amount", Type.GetType("System.String"))
        dashboard_lesson.Columns.Add("Date", Type.GetType("System.DateTime"))

        Dim lesson_filepath As String = FilePaths.lessonFilePath
        SaveDataInTextFile.LoadDataTableFromTxt(lesson_filepath, dashboard_lesson)

        For Each row As DataRow In dashboard_lesson.Rows
            ' Add the first name from the "First Name" column to the ListBox
            total_income += row("Amount")
        Next
        TotalIncome.Text = total_income & " £"

    End Sub
End Class