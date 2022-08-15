Imports System
Imports System.Diagnostics

Public Class FormMain
    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Dim result As DialogResult = MessageBox.Show("Tutup Aplikasi?", "AppRekamMedis", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub PicMin_Click(sender As Object, e As EventArgs) Handles PicMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If
    End Sub

    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs)
        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FormPasien.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FormRekam.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        FormLaporan.Show()
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FormPengaturan.Show()
        'Me.Visible = False
    End Sub

    Public Sub setLocation()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        PictureBox2.Left = Me.Width - PictureBox2.Width - 80
        picClose.Left = Me.Width - 30
        PicMin.Left = Me.Width - 60
        PictureBox3.Left = Me.Width - 90
        Panel1.Width = Me.Width
        pnlLogin.Left = (Me.Width - pnlLogin.Width) / 2
        pnlLogin.Top = ((Me.Height - pnlLogin.Height + 150) / 2)
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call setLocation()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim result As DialogResult = MessageBox.Show("Logout?", "AppRekamMedis", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            FormLogin.Show()
            Close()
        End If
    End Sub
End Class