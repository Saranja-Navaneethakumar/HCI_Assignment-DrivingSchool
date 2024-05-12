Imports SpeechLib
'Imports System.ComponentModel
'Imports System.Globalization
'Imports System.Threading
Public Class Login
    Dim synth As SpVoice
    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 151, 214)
    Dim alert_color As System.Drawing.Color = System.Drawing.Color.FromArgb(219, 112, 147)
    Dim success_color As System.Drawing.Color = System.Drawing.Color.FromArgb(112, 219, 184)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create voice speech
        synth = New SpVoice
    End Sub

    'Create Tooltip
    Private toolTip As New ToolTip()

    'Text to speech
    Private Sub SpeakText(ByVal textToSpeak As String)
        If Not String.IsNullOrEmpty(textToSpeak) Then
            Dim streamNumber As UInteger
            synth.Speak(textToSpeak, 0, streamNumber)
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Username.PlaceholderText = "Username"
        Password.PlaceholderText = "Password"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SpeakText(Button1.Text)
        If Username.Text = "" And Password.Text = "" Then
            MsgBox("Please Enter Username and Password", MsgBoxStyle.Exclamation, "Saran Driving School")
            Panel2.BackColor = alert_color
            Panel3.BackColor = alert_color
        ElseIf Username.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.Exclamation, "Saran Driving School")
            Panel2.BackColor = alert_color
            If Not Password.Text = "" Then
                Panel3.BackColor = color
            End If
        ElseIf Password.Text = "" Then
            MsgBox("Please Enter Password", MsgBoxStyle.Exclamation, "Saran Driving School")
            Panel3.BackColor = alert_color
            If Not Username.Text = "" Then
                Panel2.BackColor = color
            End If
        ElseIf Not Username.Text = "Admin" And Password.Text = "12345" Then
            MsgBox("Incorrect Username", MsgBoxStyle.Critical, "Saran Driving School")
            Panel2.BackColor = alert_color
            Panel3.BackColor = success_color
        ElseIf Username.Text = "Admin" And Not Password.Text = "12345" Then
            MsgBox("Incorrect Password", MsgBoxStyle.Critical, "Saran Driving School")
            Panel2.BackColor = success_color
            Panel3.BackColor = alert_color
        ElseIf Username.Text = "Admin" And Password.Text = "12345" Then
            Dim dashboard = New Dashboard
            dashboard.Show()
            Me.Hide()
            Panel2.BackColor = color
            Panel3.BackColor = color
            Username.Text = ""
            Password.Text = ""
        Else
            MsgBox("Incorrect Username and Password", MsgBoxStyle.Critical, "Saran Driving School")
            Panel2.BackColor = alert_color
            Panel3.BackColor = alert_color
        End If
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(225, 226, 239)
        Button1.BackColor = success_color
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = color
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Task.Run(Sub() SpeakText("Close"))
        toolTip.SetToolTip(Button2, "close")
        toolTip.BackColor = alert_color
    End Sub

    Private Sub Username_MouseHover(sender As Object, e As EventArgs) Handles Username.MouseHover
        toolTip.SetToolTip(Username, "Username")
    End Sub

    Private Sub Password_MouseHover(sender As Object, e As EventArgs) Handles Password.MouseHover
        toolTip.SetToolTip(Password, "Password")
    End Sub

    Private Sub Username_MouseClick(sender As Object, e As MouseEventArgs) Handles Username.MouseClick
        SpeakText("Username")
    End Sub

    Private Sub Password_MouseClick(sender As Object, e As MouseEventArgs) Handles Password.MouseClick
        SpeakText("Password")
    End Sub

    Private Sub PasswordView_Click(sender As Object, e As EventArgs) Handles PasswordView.Click
        If Password.PasswordChar = Nothing Then
            Password.PasswordChar = "*"
        Else
            Password.PasswordChar = Nothing
        End If
    End Sub

    Private Sub PasswordView_MouseHover(sender As Object, e As EventArgs) Handles PasswordView.MouseHover
        Task.Run(Sub() SpeakText("View Password"))
        toolTip.SetToolTip(PasswordView, "View Password")
    End Sub


End Class
