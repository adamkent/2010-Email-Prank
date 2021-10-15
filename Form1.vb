Imports System.Net.Mail
Public Class Form1

    Private Sub usernamebox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usernamebox.TextChanged

    End Sub

    Private Sub startbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbtn.Click
        Timer1.Start()
    End Sub

    Private Sub stopbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopbtn.Click
        Timer1.Stop()
    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress(usernamebox.Text)
        MyMailMessage.To.Add(tobox.Text)
        MyMailMessage.Subject = (subjectbox.Text)
        MyMailMessage.Body = messagebox.Text
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        SMTPServer.Port = 587
        SMTPServer.Credentials = New System.Net.NetworkCredential(usernamebox.Text, passwordbox.Text)
        SMTPServer.EnableSsl = True
        Label1.Text = Val(Label1.Text + 1)
        SMTPServer.Send(MyMailMessage)
    End Sub
End Class
