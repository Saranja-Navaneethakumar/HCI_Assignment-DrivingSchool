<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Username = New TextBox()
        Panel2 = New Panel()
        Password = New TextBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        PasswordView = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._2
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Username
        ' 
        Username.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Username.BorderStyle = BorderStyle.None
        resources.ApplyResources(Username, "Username")
        Username.ForeColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        Username.Name = "Username"
        Username.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' Password
        ' 
        Password.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Password.BorderStyle = BorderStyle.None
        resources.ApplyResources(Password, "Password")
        Password.ForeColor = Color.FromArgb(CByte(225), CByte(226), CByte(239))
        Password.Name = "Password"
        Password.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.user__4_
        resources.ApplyResources(PictureBox2, "PictureBox2")
        PictureBox2.Name = "PictureBox2"
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.key
        resources.ApplyResources(PictureBox3, "PictureBox3")
        PictureBox3.Name = "PictureBox3"
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        resources.ApplyResources(Button1, "Button1")
        Button1.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Button1.Image = My.Resources.Resources.enter
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        resources.ApplyResources(Button2, "Button2")
        Button2.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Button2.Image = My.Resources.Resources.close__1_
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.FromArgb(CByte(180), CByte(151), CByte(214))
        Label1.Name = "Label1"
        ' 
        ' PasswordView
        ' 
        PasswordView.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        resources.ApplyResources(PasswordView, "PasswordView")
        PasswordView.ForeColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        PasswordView.Image = My.Resources.Resources.view
        PasswordView.Name = "PasswordView"
        PasswordView.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(74))
        Controls.Add(PasswordView)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel3)
        Controls.Add(Password)
        Controls.Add(Panel2)
        Controls.Add(Username)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Password As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordView As Button

End Class
