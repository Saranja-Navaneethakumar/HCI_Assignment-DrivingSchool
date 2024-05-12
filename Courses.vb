Imports System.Data.DataTable
Imports HCI___Driving_School.Validations
Imports SpeechLib

Public Class Courses
    Dim course_table As New DataTable("table")
    Dim synth As SpVoice
    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 151, 214)
    Dim alert_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 112, 147)
    Dim success_color As System.Drawing.Color = System.Drawing.Color.FromArgb(112, 219, 184)
    Dim warning_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 185, 112)
    Dim textbox_color As System.Drawing.Color = System.Drawing.Color.FromArgb(225, 226, 239)
    Dim index As Integer
    Dim filepath As String = FilePaths.coursesFilePath
    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        synth = New SpVoice

        course_table.Columns.Add("ID", Type.GetType("System.Int32"))
        course_table.Columns.Add("Course Name", Type.GetType("System.String"))
        course_table.Columns.Add("Instructor", Type.GetType("System.String"))
        course_table.Columns.Add("Duration", Type.GetType("System.String"))
        course_table.Columns.Add("Amount/Hour", Type.GetType("System.String"))
        course_table.Columns.Add("Start Date", Type.GetType("System.DateTime"))

        CourseDataGridView.DataSource = course_table


        If SaveDataInTextFile.FileHasDataIgnoreFirstLine(FilePaths.coursesFilePath) Then
            SaveDataInTextFile.LoadDataTableFromTxt(filepath, course_table)
        End If

        'Load instructors
        Dim course_instructor_table As New DataTable("table")
        course_instructor_table.Columns.Add("ID", Type.GetType("System.Int32"))
        course_instructor_table.Columns.Add("First Name", Type.GetType("System.String"))
        course_instructor_table.Columns.Add("Last Name", Type.GetType("System.String"))
        course_instructor_table.Columns.Add("Address", Type.GetType("System.String"))
        course_instructor_table.Columns.Add("ContactNo", Type.GetType("System.Int64"))
        course_instructor_table.Columns.Add("Email", Type.GetType("System.String"))
        course_instructor_table.Columns.Add("DOB", Type.GetType("System.DateTime"))
        course_instructor_table.Columns.Add("Gender", Type.GetType("System.String"))
        course_instructor_table.Columns.Add("Instructor Type", Type.GetType("System.String"))

        Dim instructor_filepath As String = FilePaths.instructorFilePath
        SaveDataInTextFile.LoadDataTableFromTxt(instructor_filepath, course_instructor_table)

        For Each row As DataRow In course_instructor_table.Rows
            ' Add the first name from the "First Name" column to the ListBox
            InstructorComboBox.Items.Add(row("First Name").ToString())
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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Save.MouseHover, Update.MouseHover, Delete.MouseHover, CourseSearch.MouseHover, DeleteAll.MouseHover, Refresh.MouseHover, SearchRefresh.MouseHover
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

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Save.MouseLeave, Update.MouseLeave, Delete.MouseLeave, CourseSearch.MouseLeave, DeleteAll.MouseLeave, Refresh.MouseLeave, SearchRefresh.MouseLeave
        Dim button = CType(sender, Button)
        button.BackColor = color
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        'Save Courses details
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "CourseSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "CourseSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim course_Id As Integer = Generate_ID()
                Dim start_date As Date = StartDatePicker.Value.Date
                If Double.Parse(DurationTextBox.Text) > 12 Then
                    MsgBox("Enter valid duration of months less than or equal to 12!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                Else
                    course_table.Rows.Add(course_Id, CourseNameTextBox.Text, InstructorComboBox.Text, DurationTextBox.Text, AmountTextBox.Text, start_date)
                    SaveDataInTextFile.SaveDataTableToTxt(filepath, course_table)
                    CourseNameTextBox.BackColor = textbox_color
                    AmountTextBox.BackColor = textbox_color
                    InstructorComboBox.BackColor = textbox_color
                    DurationTextBox.BackColor = textbox_color
                    MsgBox("Course details saved successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                End If
            Catch ex As Exception
                MsgBox("An error occurred while saving course details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If

    End Sub

    Private Sub CourseDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseDataGridView.CellClick
        'View Instructor details when clicking cell
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = CourseDataGridView.Rows(index)
        CourseNameTextBox.Text = selectedRow.Cells(1).Value.ToString
        InstructorComboBox.Text = selectedRow.Cells(2).Value.ToString
        DurationTextBox.Text = selectedRow.Cells(3).Value.ToString
        AmountTextBox.Text = selectedRow.Cells(4).Value.ToString
        StartDatePicker.Text = selectedRow.Cells(5).Value.ToString

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Update Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to update course details?", MsgBoxStyle.YesNo, "Confirmation")
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "CourseSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "CourseSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim start_date As Date = StartDatePicker.Value.Date
                If result = MsgBoxResult.Yes Then
                    Dim updateData As DataGridViewRow = CourseDataGridView.Rows(index)
                    If Double.Parse(DurationTextBox.Text) > 12 Then
                        MsgBox("Enter valid duration of months less than or equal to 12!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    Else
                        updateData.Cells(1).Value = CourseNameTextBox.Text
                        updateData.Cells(2).Value = InstructorComboBox.Text
                        updateData.Cells(3).Value = DurationTextBox.Text
                        updateData.Cells(4).Value = AmountTextBox.Text
                        updateData.Cells(5).Value = StartDatePicker.Value.Date
                        SaveDataInTextFile.SaveDataTableToTxt(filepath, course_table)
                        MsgBox("Course details updated successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                    End If

                End If
                CourseNameTextBox.BackColor = textbox_color
                InstructorComboBox.BackColor = textbox_color
                DurationTextBox.BackColor = textbox_color
                AmountTextBox.BackColor = textbox_color

            Catch ex As Exception
                MsgBox("An error occurred while saving course details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If


    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        'Refresh Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to refresh details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            CourseNameTextBox.Clear()
            InstructorComboBox.Text = ""
            DurationTextBox.Clear()
            AmountTextBox.Clear()
            StartDatePicker.Value = DateTime.Today.Date
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Delete selected course details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete selected course details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            CourseDataGridView.Rows.RemoveAt(index)
            SaveDataInTextFile.SaveDataTableToTxt(filepath, course_table)
        End If

    End Sub

    Private Sub DeleteAll_Click(sender As Object, e As EventArgs) Handles DeleteAll.Click
        'Delete all course details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete all course details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            course_table.Clear()
            SaveDataInTextFile.SaveDataTableToTxt(filepath, course_table)
        End If
    End Sub

    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged

    End Sub

    Private Sub CourseNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CourseNameTextBox.TextChanged
        If Not ValidateName(CourseNameTextBox.Text) Then
            MsgBox("Course Name must only contain letters and spaces!", MsgBoxStyle.Critical, "Saran Driving School - Error")
            CourseNameTextBox.BackColor = alert_color
        Else
            CourseNameTextBox.BackColor = textbox_color
        End If
    End Sub

    Private Sub TextBoxLetter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseNameTextBox.KeyPress
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

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles CourseNameTextBox.GotFocus, DurationTextBox.GotFocus, AmountTextBox.GotFocus, CourseSearchBox.GotFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = color
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles CourseNameTextBox.LostFocus, DurationTextBox.LostFocus, AmountTextBox.LostFocus, CourseSearchBox.LostFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = textbox_color
    End Sub

    Private Sub CourseSearch_Click(sender As Object, e As EventArgs) Handles CourseSearch.Click
        If Not CourseSerachComboBox.SelectedItem = "" Then
            If CourseSerachComboBox.SelectedItem = "Course Name" Then
                TryCast(course_table, DataTable).DefaultView.RowFilter =
                String.Format("[Course Name] like '%" & CourseSearchBox.Text & "%'")
            ElseIf CourseSerachComboBox.SelectedItem = "Instructor" Then
                TryCast(course_table, DataTable).DefaultView.RowFilter =
                String.Format("[Instructor] like '%" & CourseSearchBox.Text & "%'")
            ElseIf CourseSerachComboBox.SelectedItem = "Start Date" Then
                Dim searchText As String = CourseSearchBox.Text
                Dim searchDate As Date
                If Date.TryParse(searchText, searchDate) Then
                    Dim formattedDate As String = searchDate.ToString("yyyy-MM-dd")
                    TryCast(course_table, DataTable).DefaultView.RowFilter =
                        String.Format("[Start Date] = #{0}#", formattedDate)
                Else
                    MsgBox("Please enter date in correct fromat dd/mm//yyyy!", MsgBoxStyle.Information, "Saran Driving School")
                End If
            End If
        Else
            MsgBox("Please choose category to search!", MsgBoxStyle.Information, "Saran Driving School")
        End If

    End Sub

    Private Sub SearchRefresh_Click(sender As Object, e As EventArgs) Handles SearchRefresh.Click
        Dim dataTable As DataTable = TryCast(CourseDataGridView.DataSource, DataTable)

        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = ""
        End If
    End Sub
    Private Sub TextboxLabel_MouseHover(sender As Object, e As EventArgs) Handles CourseName.MouseHover, Instructor.MouseHover, Duration.MouseHover, Amount.MouseHover, StartDate.MouseHover
        Dim label = CType(sender, Label)
        Task.Run(Sub() SpeakText(label.Text))
    End Sub


    Private Sub DurationTextBox_TextChanged(sender As Object, e As EventArgs) Handles DurationTextBox.TextChanged
        If Not DurationTextBox.Text = "" Then
            If Double.Parse(DurationTextBox.Text) > 12 Then
                DurationAlert.Text = "Enter valid duration of months less than or equal to 12"
            Else
                DurationAlert.Text = ""
            End If
        End If
    End Sub
End Class