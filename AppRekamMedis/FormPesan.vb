Public Class FormPesan
    Private Sub FormPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPesan.Left = (Me.Width - lblPesan.Width) / 2
        lblpesan2.Left = (Me.Width - lblpesan2.Width) / 2
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FormPasien.Visible = True Then
            Call FormPasien.Pesan()
        ElseIf FormRekam.Visible = True Then

            Call FormRekam.Pesan()

        ElseIf FormPengaturan.Visible = True Then

            Call FormPengaturan.Pesan()
        End If
    End Sub
End Class