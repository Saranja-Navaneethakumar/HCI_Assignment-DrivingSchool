Imports System.Data.DataTable
Imports HCI___Driving_School.Validations
Imports SpeechLib

Public Class Lessons
    Dim lesson_table As New DataTable("table")
    Dim synth As SpVoice
    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 151, 214)
    Dim alert_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 112, 147)
    Dim success_color As System.Drawing.Color = System.Drawing.Color.FromArgb(112, 219, 184)
    Dim warning_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 185, 112)
    Dim textbox_color As System.Drawing.Color = System.Drawing.Color.FromArgb(225, 226, 239)
    Dim index As Integer
    Dim filepath As String = FilePaths.lessonFilePath
    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        synth = New SpVoice

        lesson_table.Columns.Add("ID", Type.GetType("System.Int32"))
        lesson_table.Columns.Add("Learner Name", Type.GetType("System.String"))
        lesson_table.Columns.Add("Course Name", Type.GetType("System.String"))
        lesson_table.Columns.Add("Instructor", Type.GetType("System.String"))
        lesson_table.Columns.Add("Duration", Type.GetType("System.String"))
        lesson_table.Columns.Add("Amount", Type.GetType("System.String"))
        lesson_table.Columns.Add("Date", Type.GetType("System.DateTime"))

        LessonDataGridView.DataSource = lesson_table
        If SaveDataInTextFile.FileHasDataIgnoreFirstLine(FilePaths.lessonFilePath) Then
            SaveDataInTextFile.LoadDataTableFromTxt(filepath, lesson_table)
        End If

        'Load instructors
        Dim lesson_instructor_table As New DataTable("table")
        lesson_instructor_table.Columns.Add("ID", Type.GetType("System.Int32"))
        lesson_instructor_table.Columns.Add("First Name", Type.GetType("System.String"))
        lesson_instructor_table.Columns.Add("Last Name", Type.GetType("System.String"))
        lesson_instructor_table.Columns.Add("Address", Type.GetType("System.String"))
        lesson_instructor_table.Columns.Add("ContactNo", Type.GetType("System.Int64"))
        lesson_instructor_table.Columns.Add("Email", Type.GetType("System.String"))
        lesson_instructor_table.Columns.Add("DOB", Type.GetType("System.DateTime"))
        lesson_instructor_table.Columns.Add("Gender", Type.GetType("System.String"))
        lesson_instructor_table.Columns.Add("Instructor Type", Type.GetType("System.String"))

        Dim instructor_filepath As String = FilePaths.instructorFilePath
        SaveDataInTextFile.LoadDataTableFromTxt(instructor_filepath, lesson_instructor_table)

        For Each row As DataRow In lesson_instructor_table.Rows
            ' Add the first name from the "First Name" column to the ListBox
            InstructorComboBox.Items.Add(row("First Name").ToString())
        Next

        'Load learners
        Dim lesson_learner_table As New DataTable("table")
        lesson_learner_table.Columns.Add("ID", Type.GetType("System.Int32"))
        lesson_learner_table.Columns.Add("First Name", Type.GetType("System.String"))
        lesson_learner_table.Columns.Add("Last Name", Type.GetType("System.String"))
        lesson_learner_table.Columns.Add("Address", Type.GetType("System.String"))
        lesson_learner_table.Columns.Add("ContactNo", Type.GetType("System.Int64"))
        lesson_learner_table.Columns.Add("Email", Type.GetType("System.String"))
        lesson_learner_table.Columns.Add("DOB", Type.GetType("System.DateTime"))
        lesson_learner_table.Columns.Add("Gender", Type.GetType("System.String"))
        lesson_learner_table.Columns.Add("Lesson Type", Type.GetType("System.String"))

        Dim learner_filepath As String = FilePaths.learnerFilePath
        SaveDataInTextFile.LoadDataTableFromTxt(learner_filepath, lesson_learner_table)

        For Each row As DataRow In lesson_learner_table.Rows
            ' Add the first name from the "First Name" column to the ListBox
            LearnerComboBox.Items.Add(row("First Name").ToString())
        Next

        'Load courses
        Dim lesson_course_table As New DataTable("table")
        lesson_course_table.Columns.Add("ID", Type.GetType("System.Int32"))
        lesson_course_table.Columns.Add("Course Name", Type.GetType("System.String"))
        lesson_course_table.Columns.Add("Instructor", Type.GetType("System.String"))
        lesson_course_table.Columns.Add("Duration", Type.GetType("System.String"))
        lesson_course_table.Columns.Add("Amount/Hour", Type.GetType("System.String"))
        lesson_course_table.Columns.Add("Start Date", Type.GetType("System.DateTime"))

        Dim course_filepath As String = FilePaths.coursesFilePath
        SaveDataInTextFile.LoadDataTableFromTxt(course_filepath, lesson_course_table)

        For Each row As DataRow In lesson_course_table.Rows
            ' Add the first name from the "First Name" column to the ListBox
            CourseComboBox.Items.Add(row("Course Name").ToString())
        Next


    End Sub

    Private Sub SpeakText(ByVal textToSpeak As String)
        If Not String.IsNullOrEmpty(textToSpeak) Then
            Dim streamNumber As UInteger
            synth.Speak(textToSpeak, 0, streamNumber)
        End If
    End Sub

    Dim id As Integer = 999
    Private Function Generate_ID()
        id += 1
        Return id
    End Function

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Save.MouseHover, Update.MouseHover, Delete.MouseHover, LessonSearch.MouseHover, DeleteAll.MouseHover, Refresh.MouseHover, SearchRefresh.MouseHover
        Dim button = CType(sender, Button)
        If button.Name = "SearchRefresh" Then
            Task.Run(Sub() SpeakText("Refresh Table"))
        Else
            Task.Run(Sub() SpeakText(button.Text))
        End If
        If button.Text = "Save" OrElse button.Text = "Search" OrElse button.Text = "Refresh" OrElse button.Name = "SearchRefresh" Then
            button.BackColor = success_color
        ElseIf button.Text = "Update" Then
            button.BackColor = warning_color
        ElseIf button.Text = "Delete" OrElse button.Text = "Delete All" Then
            button.BackColor = alert_color
        End If

    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Save.MouseLeave, Update.MouseLeave, Delete.MouseLeave, LessonSearch.MouseLeave, DeleteAll.MouseLeave, Refresh.MouseLeave, SearchRefresh.MouseLeave
        Dim button = CType(sender, Button)
        button.BackColor = color
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        'Save Courses details
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "LessonSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "LessonSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim lesson_Id As Integer = Generate_ID()
                Dim lesson_date As Date = DatePicker.Value.Date
                If Double.Parse(DurationTextBox.Text) > 8 Then
                    MsgBox("Enter valid duration less than or equal to 8!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                Else
                    lesson_table.Rows.Add(lesson_Id, LearnerComboBox.Text, CourseComboBox.Text, InstructorComboBox.Text, DurationTextBox.Text, AmountTextBox.Text, lesson_date)
                    SaveDataInTextFile.SaveDataTableToTxt(filepath, lesson_table)
                    LearnerComboBox.BackColor = textbox_color
                    CourseComboBox.BackColor = textbox_color
                    AmountTextBox.BackColor = textbox_color
                    InstructorComboBox.BackColor = textbox_color
                    DurationTextBox.BackColor = textbox_color
                    MsgBox("Lesson details saved successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                End If
            Catch ex As Exception
                MsgBox("An error occurred while saving lesson details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If

    End Sub

    Private Sub CourseDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LessonDataGridView.CellClick
        'View Instructor details when clicking cell
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = LessonDataGridView.Rows(index)
        LearnerComboBox.Text = selectedRow.Cells(1).Value.ToString
        CourseComboBox.Text = selectedRow.Cells(2).Value.ToString
        InstructorComboBox.Text = selectedRow.Cells(3).Value.ToString
        DurationTextBox.Text = selectedRow.Cells(4).Value.ToString
        AmountTextBox.Text = selectedRow.Cells(5).Value.ToString
        DatePicker.Text = selectedRow.Cells(6).Value.ToString

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Update Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to update course details?", MsgBoxStyle.YesNo, "Confirmation")
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "LessonSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "LessonSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim start_date As Date = DatePicker.Value.Date
                If result = MsgBoxResult.Yes Then
                    Dim updateData As DataGridViewRow = LessonDataGridView.Rows(index)
                    If Double.Parse(DurationTextBox.Text) > 8 Then
                        MsgBox("Enter valid duration less than or equal to 8!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    Else
                        updateData.Cells(1).Value = LearnerComboBox.Text
                        updateData.Cells(2).Value = CourseComboBox.Text
                        updateData.Cells(3).Value = InstructorComboBox.Text
                        updateData.Cells(4).Value = DurationTextBox.Text
                        updateData.Cells(5).Value = AmountTextBox.Text
                        updateData.Cells(6).Value = DatePicker.Value.Date
                        SaveDataInTextFile.SaveDataTableToTxt(filepath, lesson_table)
                        MsgBox("Lesson details updated successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                    End If

                End If
                LearnerComboBox.BackColor = textbox_color
                CourseComboBox.BackColor = textbox_color
                InstructorComboBox.BackColor = textbox_color
                DurationTextBox.BackColor = textbox_color
                AmountTextBox.BackColor = textbox_color

            Catch ex As Exception
                MsgBox("An error occurred while saving lesson details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If


    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        'Refresh Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to refresh details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            LearnerComboBox.Text = ""
            CourseComboBox.Text = ""
            InstructorComboBox.Text = ""
            DurationTextBox.Clear()
            AmountTextBox.Clear()
            DatePicker.Value = DateTime.Today.Date
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Delete selected course details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete selected lesson details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            LessonDataGridView.Rows.RemoveAt(index)
            SaveDataInTextFile.SaveDataTableToTxt(filepath, lesson_table)
        End If

    End Sub

    Private Sub DeleteAll_Click(sender As Object, e As EventArgs) Handles DeleteAll.Click
        'Delete all course details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete all lesson details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            lesson_table.Clear()
            SaveDataInTextFile.SaveDataTableToTxt(filepath, lesson_table)
        End If
    End Sub

    Private Sub CourseNameTextBox_TextChanged(sender As Object, e As EventArgs)
        If Not ValidateName(CourseComboBox.Text) Then
            MsgBox("Course Name must only contain letters and spaces!", MsgBoxStyle.Critical, "Saran Driving School - Error")
            CourseComboBox.BackColor = alert_color
        Else
            CourseComboBox.BackColor = textbox_color
        End If
    End Sub


    Private Sub TextBoxLetter_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow only alphabetic input in FirstNameTextBox, LastNameTextBox
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxDigit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountTextBox.KeyPress, DurationTextBox.KeyPress
        Dim textbox As TextBox = CType(sender, TextBox)
        ' Allow only numeric input in ContactTextBox
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles DurationTextBox.GotFocus, AmountTextBox.GotFocus, LessonSearchBox.GotFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = color
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles DurationTextBox.LostFocus, AmountTextBox.LostFocus, LessonSearchBox.LostFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = textbox_color
    End Sub


    Private Sub LessonSearch_Click(sender As Object, e As EventArgs) Handles LessonSearch.Click
        If Not LessonSerachComboBox.SelectedItem = "" Then
            If LessonSerachComboBox.SelectedItem = "Learner Name" Then
                TryCast(lesson_table, DataTable).DefaultView.RowFilter =
                String.Format("[Learner Name] like '%" & LessonSearchBox.Text & "%'")
            ElseIf LessonSerachComboBox.SelectedItem = "Course Name" Then
                TryCast(lesson_table, DataTable).DefaultView.RowFilter =
                String.Format("[Course Name] like '%" & LessonSearchBox.Text & "%'")
            ElseIf LessonSerachComboBox.SelectedItem = "Instructor" Then
                TryCast(lesson_table, DataTable).DefaultView.RowFilter =
                String.Format("[Instructor] like '%" & LessonSearchBox.Text & "%'")
            ElseIf LessonSerachComboBox.SelectedItem = "Date" Then
                Dim searchText As String = LessonSearchBox.Text
                Dim searchDate As Date
                If Date.TryParse(searchText, searchDate) Then
                    Dim formattedDate As String = searchDate.ToString("yyyy-MM-dd")
                    TryCast(lesson_table, DataTable).DefaultView.RowFilter =
                        String.Format("[Date] = #{0}#", formattedDate)
                Else
                    MsgBox("Please enter date in correct fromat dd/mm//yyyy!", MsgBoxStyle.Information, "Saran Driving School")
                End If
            End If
        Else
            MsgBox("Please choose category to search!", MsgBoxStyle.Information, "Saran Driving School")
        End If

    End Sub

    Private Sub SearchRefresh_Click(sender As Object, e As EventArgs) Handles SearchRefresh.Click
        Dim dataTable As DataTable = TryCast(LessonDataGridView.DataSource, DataTable)

        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = ""
        End If
    End Sub
    Private Sub TextboxLabel_MouseHover(sender As Object, e As EventArgs) Handles LearnerName.MouseHover, CourseName.MouseHover, Instructor.MouseHover, Duration.MouseHover, Amount.MouseHover, LessonDate.MouseHover
        Dim label = CType(sender, Label)
        Task.Run(Sub() SpeakText(label.Text))
    End Sub


    Private Sub DurationTextBox_TextChanged(sender As Object, e As EventArgs) Handles DurationTextBox.TextChanged
        If Not DurationTextBox.Text = "" Then
            If Double.Parse(DurationTextBox.Text) > 8 Then
                DurationAlert.Text = "Enter valid duration less than or equal to 8"
            Else
                DurationAlert.Text = ""
            End If
        End If

    End Sub
End Class