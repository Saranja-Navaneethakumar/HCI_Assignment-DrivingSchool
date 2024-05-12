Imports System.Data.DataTable
Imports HCI___Driving_School.Validations
Imports SpeechLib
Public Class Instructors

    Dim Public instructor_table As New DataTable("table")
    Dim synth As SpVoice
    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 151, 214)
    Dim alert_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 112, 147)
    Dim success_color As System.Drawing.Color = System.Drawing.Color.FromArgb(112, 219, 184)
    Dim warning_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 185, 112)
    Dim textbox_color As System.Drawing.Color = System.Drawing.Color.FromArgb(225, 226, 239)
    Dim index As Integer

    'Declare file path
    Dim filepath As String = FilePaths.instructorFilePath
    Private Sub Instructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        synth = New SpVoice

        'Create instructor table
        instructor_table.Columns.Add("ID", Type.GetType("System.Int32"))
        instructor_table.Columns.Add("First Name", Type.GetType("System.String"))
        instructor_table.Columns.Add("Last Name", Type.GetType("System.String"))
        instructor_table.Columns.Add("Address", Type.GetType("System.String"))
        instructor_table.Columns.Add("ContactNo", Type.GetType("System.Int64"))
        instructor_table.Columns.Add("Email", Type.GetType("System.String"))
        instructor_table.Columns.Add("DOB", Type.GetType("System.DateTime"))
        instructor_table.Columns.Add("Gender", Type.GetType("System.String"))
        instructor_table.Columns.Add("Instructor Type", Type.GetType("System.String"))

        InstructorDataGridView.DataSource = instructor_table

        Gender.Items.Add("Male")
        Gender.Items.Add("Female")

        'Load data from text file when load form
        If SaveDataInTextFile.FileHasDataIgnoreFirstLine(FilePaths.instructorFilePath) Then
            SaveDataInTextFile.LoadDataTableFromTxt(filepath, instructor_table)
        End If


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

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Save.MouseHover, Update.MouseHover, Delete.MouseHover, InstructorSearch.MouseHover, DeleteAll.MouseHover, Refresh.MouseHover, SearchRefresh.MouseHover
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

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Save.MouseLeave, Update.MouseLeave, Delete.MouseLeave, InstructorSearch.MouseLeave, DeleteAll.MouseLeave, Refresh.MouseLeave, SearchRefresh.MouseLeave
        Dim button = CType(sender, Button)
        button.BackColor = color
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        'Save Instructors details
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "InstructorSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "InstructorSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim instructor_Id As Integer = Generate_ID()
                Dim date_of_birth As Date = DateTimePicker1.Value.Date
                Dim instructor_gender As String = Gender.Text
                Dim instructor_type As String = TypeInstructor.Text
                If Not Validations.ValidateEmail(EmailTextBox.Text) Then
                    MsgBox("Email is not in format!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    EmailTextBox.BackColor = alert_color
                ElseIf Validations.ValidateMobile(ContactTextBox.Text.ToString()) Then
                    MsgBox("Contact number should have 10 digits!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    ContactTextBox.BackColor = alert_color
                ElseIf Gender.Text = "" OrElse Not Gender.Items.Contains(Gender.Text) Then
                    MsgBox("Please select gender!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    Gender.BackColor = alert_color
                ElseIf TypeInstructor.Text = "" OrElse Not TypeInstructor.Items.Contains(TypeInstructor.Text) Then
                    MsgBox("Please select Lesson type!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    TypeInstructor.BackColor = alert_color
                ElseIf date_of_birth = Today Then
                    MsgBox("Please select the date of birth!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                Else
                    'Save data in table and in text file
                    instructor_table.Rows.Add(instructor_Id, FirstNameTextBox.Text, LastNameTextBox.Text, AddressTextBox.Text, ContactTextBox.Text, EmailTextBox.Text, date_of_birth, instructor_gender, instructor_type)
                    SaveDataInTextFile.SaveDataTableToTxt(filepath, instructor_table)

                    EmailTextBox.BackColor = textbox_color
                    ContactTextBox.BackColor = textbox_color
                    Gender.BackColor = textbox_color
                    TypeInstructor.BackColor = textbox_color
                    MsgBox("Instructor details saved successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                End If
            Catch ex As Exception
                MsgBox("An error occurred while saving instructor details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If


    End Sub

    Private Sub InstructorDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InstructorDataGridView.CellClick
        'View Instructor details when clicking cell
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = InstructorDataGridView.Rows(index)
        FirstNameTextBox.Text = selectedRow.Cells(1).Value.ToString
        LastNameTextBox.Text = selectedRow.Cells(2).Value.ToString
        AddressTextBox.Text = selectedRow.Cells(3).Value.ToString
        ContactTextBox.Text = selectedRow.Cells(4).Value.ToString
        EmailTextBox.Text = selectedRow.Cells(5).Value.ToString
        DateTimePicker1.Text = selectedRow.Cells(6).Value.ToString
        Gender.Text = selectedRow.Cells(7).Value.ToString
        TypeInstructor.Text = selectedRow.Cells(8).Value.ToString

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Update Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to update instructor details?", MsgBoxStyle.YesNo, "Confirmation")
        Dim emptyFields As New List(Of String)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                If Validations.ValidateEmptyTextBox(textbox) AndAlso Not textbox.Name = "InstructorSearchBox" Then
                    emptyFields.Add(textbox.Name)
                    textbox.BackColor = alert_color
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim combobox As ComboBox = CType(ctrl, ComboBox)
                If Validations.ValidateEmptyComboBox(combobox) AndAlso Not combobox.Name = "InstructorSerachComboBox" Then
                    emptyFields.Add(combobox.Name)
                    combobox.BackColor = alert_color
                End If
            End If
        Next
        If Not emptyFields.Count = 0 Then
            MsgBox("Please fill the mandatory fields!", MsgBoxStyle.Critical, "Saran Driving School - Error")
        Else
            Try
                Dim date_of_birth As Date = DateTimePicker1.Value.Date
                If Not Validations.ValidateEmail(EmailTextBox.Text) Then
                    MsgBox("Email is not in format!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    EmailTextBox.BackColor = alert_color
                ElseIf Validations.ValidateMobile(ContactTextBox.Text.ToString()) Then
                    MsgBox("Contact number should have 10 digits!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    ContactTextBox.BackColor = alert_color
                ElseIf Gender.Text = "" OrElse Not Gender.Items.Contains(Gender.Text) Then
                    MsgBox("Please select gender!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    Gender.BackColor = alert_color
                ElseIf TypeInstructor.Text = "" OrElse Not TypeInstructor.Items.Contains(TypeInstructor.Text) Then
                    MsgBox("Please select Lesson type!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                    TypeInstructor.BackColor = alert_color
                ElseIf date_of_birth = Today Then
                    MsgBox("Please select the date of birth!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                Else
                    If result = MsgBoxResult.Yes Then
                        Dim updateData As DataGridViewRow = InstructorDataGridView.Rows(index)
                        Try
                            If Not Validations.ValidateEmail(EmailTextBox.Text) Then
                                MsgBox("Email is not in format!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                                EmailTextBox.BackColor = alert_color
                            Else
                                updateData.Cells(1).Value = FirstNameTextBox.Text
                                updateData.Cells(2).Value = LastNameTextBox.Text
                                updateData.Cells(3).Value = AddressTextBox.Text
                                updateData.Cells(4).Value = ContactTextBox.Text
                                updateData.Cells(5).Value = EmailTextBox.Text
                                updateData.Cells(6).Value = DateTimePicker1.Value.Date
                                updateData.Cells(7).Value = Gender.Text
                                updateData.Cells(8).Value = TypeInstructor.Text
                                SaveDataInTextFile.SaveDataTableToTxt(filepath, instructor_table)
                                MsgBox("Instructor details updated successfully!", MsgBoxStyle.Information, "Saran Driving School - Success")
                            End If
                        Catch ex As Exception
                            MsgBox("Error saving instructor details!", MsgBoxStyle.Critical, "Saran Driving School - Error")
                        End Try
                    End If
                    EmailTextBox.BackColor = textbox_color
                    ContactTextBox.BackColor = textbox_color
                    Gender.BackColor = textbox_color
                    TypeInstructor.BackColor = textbox_color
                End If
            Catch ex As Exception
                MsgBox("An error occurred while saving instructor details: " & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Saran Driving School - Error")
            End Try
        End If


    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        'Refresh Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to refresh details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            FirstNameTextBox.Clear()
            LastNameTextBox.Clear()
            AddressTextBox.Clear()
            ContactTextBox.Clear()
            EmailTextBox.Clear()
            DateTimePicker1.Value = DateTime.Today.Date
            Gender.Text = ""
            TypeInstructor.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Delete selected Instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete selected instructor's details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            InstructorDataGridView.Rows.RemoveAt(index)
            SaveDataInTextFile.SaveDataTableToTxt(filepath, instructor_table)
        End If

    End Sub

    Private Sub DeleteAll_Click(sender As Object, e As EventArgs) Handles DeleteAll.Click
        'Delete all instructors details
        Dim result As MsgBoxResult = MsgBox("Do you want to delete all instructors details?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            instructor_table.Clear()
            SaveDataInTextFile.SaveDataTableToTxt(filepath, instructor_table)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim enteredDate As Date = DateTimePicker1.Value.Date
        Dim today = DateTime.Today.Date
        If enteredDate = today Then
            DOBalert.Text = "! Select date of birth"
        Else
            DOBalert.Text = ""
        End If

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        If Not ValidateName(FirstNameTextBox.Text) Then
            MsgBox("First name must only contain letters and spaces!", MsgBoxStyle.Critical, "Saran Driving School - Error")
            FirstNameTextBox.BackColor = alert_color
        Else
            FirstNameTextBox.BackColor = textbox_color
        End If
    End Sub

    Private Sub ContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactTextBox.TextChanged
        If Not ContactTextBox.Text = "" Then
            If Validations.ValidateMobile(ContactTextBox.Text) Then
                Contactalert.Text = "! Contact Number should be 10 digits"
                ContactTextBox.BackColor = alert_color
            Else
                ContactTextBox.BackColor = textbox_color
                Contactalert.Text = ""
            End If
        Else
            Contactalert.Text = "! Enter Contact Number"
        End If
        Dim contactBox As TextBox = CType(sender, TextBox)
        For Each ch As Char In contactBox.Text
            If Not Char.IsDigit(ch) Then
                MsgBox("Please enter only digits for contact number!", MsgBoxStyle.Critical, "Saran Driving School - Error")
            End If
        Next
    End Sub

    Private Sub TextBoxLetter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTextBox.KeyPress, LastNameTextBox.KeyPress
        ' Allow only numeric input in FirstNameTextBox, LastNameTextBox
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxDigit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTextBox.KeyPress
        ' Allow only alphabetic input in ContactTextBox
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Gender_TextChanged(sender As Object, e As EventArgs) Handles Gender.TextChanged
        Dim enteredGender = Gender.Text
        If Gender.Items.Contains(enteredGender) Then
            Gender.BackColor = textbox_color
        Else
            Gender.BackColor = alert_color
        End If

        If Not Gender.Text = "" Then
            If Not Gender.Items.Contains(enteredGender) Then
                Genderalert.Text = "! Invalid gender"
            Else
                Genderalert.Text = ""
            End If
        Else
            Genderalert.Text = "! Select Gender"
        End If
    End Sub

    Private Sub TypeInstructor_TextChanged(sender As Object, e As EventArgs) Handles TypeInstructor.TextChanged
        Dim enterdLesson = TypeInstructor.Text
        If TypeInstructor.Items.Contains(enterdLesson) Then
            TypeInstructor.BackColor = textbox_color
        Else
            TypeInstructor.BackColor = alert_color
        End If

        If Not TypeInstructor.Text = "" Then
            If Not TypeInstructor.Items.Contains(enterdLesson) Then
                LessonTypealert.Text = "! Invalid instructor type"
            Else
                LessonTypealert.Text = ""
            End If
        Else
            LessonTypealert.Text = "! Select Lesson type"
        End If
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.GotFocus, LastNameTextBox.GotFocus, AddressTextBox.GotFocus, EmailTextBox.GotFocus, ContactTextBox.GotFocus, InstructorSearchBox.GotFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = color
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.LostFocus, LastNameTextBox.LostFocus, AddressTextBox.LostFocus, EmailTextBox.LostFocus, ContactTextBox.LostFocus, InstructorSearchBox.LostFocus
        Dim textbox = CType(sender, TextBox)
        textbox.BackColor = textbox_color
    End Sub

    Private Sub ComboBox_GotFocus(sender As Object, e As EventArgs) Handles Gender.GotFocus, TypeInstructor.GotFocus
        Dim combobox = CType(sender, ComboBox)
        combobox.BackColor = color
    End Sub

    Private Sub ComboBox_LostFocus(sender As Object, e As EventArgs) Handles Gender.LostFocus, TypeInstructor.LostFocus
        Dim combobox = CType(sender, ComboBox)
        combobox.BackColor = textbox_color
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        If Not EmailTextBox.Text = "" Then
            If Not Validations.ValidateEmail(EmailTextBox.Text) Then
                Emailalert.Text = "! Invalid Email"
                EmailTextBox.BackColor = alert_color
            Else
                EmailTextBox.BackColor = textbox_color
                Emailalert.Text = ""
            End If
        Else
            Emailalert.Text = "! Enter email address"
        End If

    End Sub

    Private Sub InstructorSearch_Click(sender As Object, e As EventArgs) Handles InstructorSearch.Click
        If Not InstructorSerachComboBox.SelectedItem = "" Then
            If InstructorSerachComboBox.SelectedItem = "First Name" Then
                TryCast(instructor_table, DataTable).DefaultView.RowFilter =
                String.Format("[First Name] like '%" & InstructorSearchBox.Text & "%'")
            ElseIf InstructorSerachComboBox.SelectedItem = "Last Name" Then
                TryCast(instructor_table, DataTable).DefaultView.RowFilter =
                String.Format("[Last Name] like '%" & InstructorSearchBox.Text & "%'")
            ElseIf InstructorSerachComboBox.SelectedItem = "Address" Then
                TryCast(instructor_table, DataTable).DefaultView.RowFilter =
                String.Format("[Address] like '%" & InstructorSearchBox.Text & "%'")
            ElseIf InstructorSerachComboBox.SelectedItem = "Email" Then
                TryCast(instructor_table, DataTable).DefaultView.RowFilter =
                String.Format("[Email] like '%" & InstructorSearchBox.Text & "%'")
            ElseIf InstructorSerachComboBox.SelectedItem = "Instructor Type" Then
                TryCast(instructor_table, DataTable).DefaultView.RowFilter =
                String.Format("[Instructor Type] like '%" & InstructorSearchBox.Text & "%'")
            End If
        Else
            MsgBox("Please choose category to search!", MsgBoxStyle.Information, "Saran Driving School")
        End If

    End Sub

    Private Sub SearchRefresh_Click(sender As Object, e As EventArgs) Handles SearchRefresh.Click
        Dim dataTable As DataTable = TryCast(InstructorDataGridView.DataSource, DataTable)

        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = ""
        End If
    End Sub
    Private Sub TextboxLabel_MouseHover(sender As Object, e As EventArgs) Handles InstructorFirstName.MouseHover, InstructorLastName.MouseHover, AddressLabel.MouseHover, ContactNoLabel.MouseHover, Email.MouseHover, DOB.MouseHover, GenderLabel.MouseHover, InstructorType.MouseHover
        Dim label = CType(sender, Label)
        Task.Run(Sub() SpeakText(label.Text))
    End Sub
End Class