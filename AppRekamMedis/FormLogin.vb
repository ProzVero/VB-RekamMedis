Imports System.Data.SqlClient
Public Class FormLogin
    Dim db As New Database

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then txtuser.Focus()
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then btnlogin_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        txtuser.Text = ""
    End Sub

    Private Sub txtpass_Click(sender As Object, e As EventArgs) Handles txtpass.Click
        txtpass.UseSystemPasswordChar = True
        txtpass.Text = ""
    End Sub

    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Close()
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        Me.Label3.BackColor = Color.Red
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        db.koneksi()

        Dim query = "SELECT * FROM users WHERE username = '" & txtuser.Text & "' and pass = '" & txtpass.Text & "'"
        Dim cmd As New SqlCommand(query, db.konek)

        If txtuser.Text = "admin" And txtpass.Text = "admin123" Then
            Me.Visible = False

            'MsgBox("Nama user dan password cocok")

            FormMain.MaximumSize = Screen.FromRectangle(FormMain.Bounds).WorkingArea.Size
            FormMain.WindowState = FormWindowState.Maximized
            FormMain.Show()
        Else
            Dim DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                If txtpass.Text <> DR.Item("pass") And txtuser.Text <> DR.Item("username") Then
                    MsgBox("Login Gagal")
                    txtuser.Clear()
                    txtpass.Clear()
                    txtuser.Focus()
                    Exit Sub
                Else
                    Me.Visible = False

                    'MsgBox("Nama user dan password cocok")
                    FormMain.Show()
                End If
            Else
                MsgBox("Nama user dan password tidak cocok")
                txtuser.Clear()
                txtpass.Clear()
                txtuser.Focus()
            End If
            DR.Close()
            db.konek.Close()
        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label3.Left = Me.Width - Label3.Width - 10
        Panel1.Width = Me.Width
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        PictureBox2.Left = Me.Width - PictureBox2.Width - 80
        Panel4.Left = (Me.Width - Panel4.Width) / 2
        Panel4.Top = (Me.Height - Panel4.Height + 20) / 2
        PictureBox3.Left = Me.Width - PictureBox3.Width
        PictureBox3.Top = Me.Height - PictureBox3.Height

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
    End Sub
End Class
