Imports SpeechLib
Public Class Dashboard

    Dim synth As SpVoice
    Dim slidingMenu As Boolean = False
    Dim imageMove As Boolean = False
    Dim currentChildForm As Form
    Private toolTip As New ToolTip()
    Dim panel_hover_color As System.Drawing.Color = System.Drawing.Color.FromArgb(191, 172, 170)
    Dim panel_leave_color As System.Drawing.Color = System.Drawing.Color.FromArgb(5, 32, 74)
    Dim alert_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 112, 147)
    Dim success_color As System.Drawing.Color = System.Drawing.Color.FromArgb(112, 219, 184)
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        synth = New SpVoice
        'Me.TopMost = True
        SidePanel.Width = 198
        MenuButton.Location = New Point(SidePanel.Width - MenuButton.Width, 10)
        'Tags for each button highlight panel when hover, leave, clicked buttons
        Button3.Tag = DashboardPanel
        Button4.Tag = LearnersPanel
        Button5.Tag = InstructorPanel
        Button6.Tag = CoursesPanel
        Button7.Tag = LessonsPanel
        Button8.Tag = LogoutPanel

        'Tags for each button to control window state
        Minimize.Tag = FormWindowState.Minimized
        Maximize.Tag = FormWindowState.Maximized
        Restore.Tag = FormWindowState.Normal

        toolTip.ReshowDelay = 500
        OpenChildForm(New DashboardPanel)
    End Sub

    Private Sub SpeakText(ByVal textToSpeak As String)
        If Not String.IsNullOrEmpty(textToSpeak) Then
            Dim streamNumber As UInteger
            synth.Speak(textToSpeak, 0, streamNumber)
        End If
    End Sub
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If slidingMenu Then 'Expand Side Panel
            SidePanel.Width += 5
            MenuButton.Left = SidePanel.Width - MenuButton.Width 'Move menu button while slide
            If SidePanel.Width >= 198 Then
                'Stop timer while sidepanel fully expanded
                Timer1.Stop()
                slidingMenu = False
            End If
        Else
            SidePanel.Width -= 5
            MenuButton.Left = SidePanel.Width - MenuButton.Width 'Move menu button while slide
            If SidePanel.Width <= 55 Then
                'Stop timer while sidepanel fully expanded
                Timer1.Stop()
                slidingMenu = True
            End If
        End If
    End Sub

    'Minmize, Maximize, Restore Window size
    Private Sub Change_WindowState(sender As Object, e As EventArgs) Handles Minimize.Click, Maximize.Click, Restore.Click
        Dim button As Button = CType(sender, Button)
        Dim window_state As FormWindowState = CType(button.Tag, FormWindowState)
        Me.WindowState = window_state
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click, Button8.Click
        Dim result As MsgBoxResult = MsgBox("Do you want to close application?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Minimize_MouseHover(sender As Object, e As EventArgs) Handles Minimize.MouseHover
        Task.Run(Sub() SpeakText("Minimize Tab"))
        toolTip.SetToolTip(Minimize, "Minimize Tab")
    End Sub

    Private Sub Maximize_MouseHover(sender As Object, e As EventArgs) Handles Maximize.MouseHover
        Task.Run(Sub() SpeakText("Maximize Tab"))
        toolTip.SetToolTip(Maximize, "Maximize Tab")
    End Sub

    Private Sub Restore_MouseHover(sender As Object, e As EventArgs) Handles Restore.MouseHover
        Task.Run(Sub() SpeakText("Restore Tab"))
        toolTip.SetToolTip(Restore, "Restore Tab")
    End Sub

    Private Sub Close_MouseHover(sender As Object, e As EventArgs) Handles Close.MouseHover
        Task.Run(Sub() SpeakText("Close"))
        toolTip.SetToolTip(Close, "close")
    End Sub

    'Function for changing button highlight colour when mouse click
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click
        Dim button As Button = CType(sender, Button)
        Dim panel As Panel = CType(button.Tag, Panel)
        panel.BackColor = success_color
    End Sub

    'Function for changing button highlight colour when mouse hover
    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover, Button4.MouseHover, Button5.MouseHover, Button6.MouseHover, Button7.MouseHover, Button8.MouseHover
        Dim button = CType(sender, Button)
        Dim panel = CType(button.Tag, Panel)
        panel.BackColor = panel_hover_color
        Task.Run(Sub() SpeakText(button.Text))
        If slidingMenu Then
            Debug.WriteLine($"slidingMenu: {slidingMenu}")
            toolTip.SetToolTip(button, button.Text)
        Else
            toolTip.SetToolTip(button, "")
        End If
    End Sub

    'Function for changing button highlight colour when mouse leave
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave, Button7.MouseLeave, Button8.MouseLeave
        Dim button = CType(sender, Button)
        Dim panel = CType(button.Tag, Panel)
        panel.BackColor = panel_leave_color
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        MainPanel.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New DashboardPanel)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenChildForm(New Learners)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenChildForm(New Instructors)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenChildForm(New Courses)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OpenChildForm(New Lessons)
    End Sub


    Private Sub MenuButton_MouseHover(sender As Object, e As EventArgs) Handles MenuButton.MouseHover
        Task.Run(Sub() SpeakText("Menu"))
        toolTip.SetToolTip(MenuButton, "Menu")
    End Sub

End Class