<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.startbtn = New System.Windows.Forms.Button
        Me.stopbtn = New System.Windows.Forms.Button
        Me.exitbtn = New System.Windows.Forms.Button
        Me.usernamebox = New System.Windows.Forms.TextBox
        Me.passwordbox = New System.Windows.Forms.TextBox
        Me.tobox = New System.Windows.Forms.TextBox
        Me.subjectbox = New System.Windows.Forms.TextBox
        Me.messagebox = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sent = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'startbtn
        '
        Me.startbtn.Location = New System.Drawing.Point(13, 341)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(75, 23)
        Me.startbtn.TabIndex = 0
        Me.startbtn.Text = "Start"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'stopbtn
        '
        Me.stopbtn.Location = New System.Drawing.Point(94, 341)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(75, 23)
        Me.stopbtn.TabIndex = 1
        Me.stopbtn.Text = "Stop"
        Me.stopbtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(175, 341)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.exitbtn.TabIndex = 2
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'usernamebox
        '
        Me.usernamebox.Location = New System.Drawing.Point(13, 13)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(240, 20)
        Me.usernamebox.TabIndex = 3
        Me.usernamebox.Text = "A Gmail Account Username"
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(13, 40)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(240, 20)
        Me.passwordbox.TabIndex = 4
        Me.passwordbox.Text = "A Gmail Account Password"
        '
        'tobox
        '
        Me.tobox.Location = New System.Drawing.Point(13, 67)
        Me.tobox.Name = "tobox"
        Me.tobox.Size = New System.Drawing.Size(240, 20)
        Me.tobox.TabIndex = 5
        Me.tobox.Text = "Victim adress"
        '
        'subjectbox
        '
        Me.subjectbox.Location = New System.Drawing.Point(13, 94)
        Me.subjectbox.Name = "subjectbox"
        Me.subjectbox.Size = New System.Drawing.Size(240, 20)
        Me.subjectbox.TabIndex = 6
        Me.subjectbox.Text = "Subject"
        '
        'messagebox
        '
        Me.messagebox.Location = New System.Drawing.Point(13, 130)
        Me.messagebox.Multiline = True
        Me.messagebox.Name = "messagebox"
        Me.messagebox.Size = New System.Drawing.Size(240, 189)
        Me.messagebox.TabIndex = 7
        Me.messagebox.Text = "Message"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'sent
        '
        Me.sent.AutoSize = True
        Me.sent.Location = New System.Drawing.Point(13, 322)
        Me.sent.Name = "sent"
        Me.sent.Size = New System.Drawing.Size(32, 13)
        Me.sent.TabIndex = 8
        Me.sent.Text = "Sent:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 376)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sent)
        Me.Controls.Add(Me.messagebox)
        Me.Controls.Add(Me.subjectbox)
        Me.Controls.Add(Me.tobox)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.usernamebox)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.stopbtn)
        Me.Controls.Add(Me.startbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Mega Email Bomber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startbtn As System.Windows.Forms.Button
    Friend WithEvents stopbtn As System.Windows.Forms.Button
    Friend WithEvents exitbtn As System.Windows.Forms.Button
    Friend WithEvents usernamebox As System.Windows.Forms.TextBox
    Friend WithEvents passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents tobox As System.Windows.Forms.TextBox
    Friend WithEvents subjectbox As System.Windows.Forms.TextBox
    Friend WithEvents messagebox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sent As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
