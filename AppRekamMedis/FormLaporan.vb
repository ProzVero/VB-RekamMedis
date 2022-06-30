Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Public Class FormLaporan
    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
    Dim db As New Database
    Dim kd1, kd2 As String
    Public tambah As Boolean = False
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.rekam' table. You can move, or remove it, as needed.
        'Me.RekamTableAdapter.Fill(Me.DbRekamMedisDataSet1.rekam)
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.Pasien' table. You can move, or remove it, as needed.
        'Me.PasienTableAdapter.Fill(Me.DbRekamMedisDataSet1.Pasien)

        DG1.DefaultCellStyle.ForeColor = Color.Black
        DG2.DefaultCellStyle.ForeColor = Color.Black
        db.koneksi()
        Call FormatGrid()
        Call TampilGrid1()
    End Sub

    Sub FormatGrid()
        Dim widthDG1 = DG1.Width
        Dim widthDG2 = DG2.Width

        Dim widthClm1 As Integer = Fix((widthDG1 - 50) / 20)
        Dim widthClm2 As Integer = Fix((widthDG2 - 50) / 25)

        DG1.Columns(0).Width = widthClm1 * 2
        DG1.Columns(1).Width = widthClm1 * 3
        DG1.Columns(2).Width = widthClm1 * 4
        DG1.Columns(3).Width = widthClm1 * 2
        DG1.Columns(4).Width = widthClm1
        DG1.Columns(5).Width = widthClm1
        DG1.Columns(6).Width = widthClm1 * 5
        DG1.Columns(7).Width = widthClm1 * 2
        'MsgBox("'" & widthDG & "'- '" & widthClm & "'")
        DG2.Columns(0).Width = widthClm2 * 3
        DG2.Columns(1).Width = widthClm2 * 3
        DG2.Columns(2).Width = widthClm2 * 3
        DG2.Columns(3).Width = widthClm2 * 3
        DG2.Columns(4).Width = widthClm2 * 3
        DG2.Columns(5).Width = widthClm2 * 7
        DG2.Columns(6).Width = widthClm2 * 3

        Panel3.Width = Me.Width - 20
        Panel3.Height = Me.Height - pnlTop.Height - 45
        DG1.Width = Me.Width - 40
        DG1.Height = (Panel3.Height - 40) * 0.7
        DG2.Width = Me.Width - 40
        DG2.Height = (Panel3.Height - 40) * 0.3
        DG2.Top = (Panel3.Height * 0.7) - 10
    End Sub

    Private Sub TampilGrid1()
        Try
            DG1.DataSource = Nothing
            DG1.Refresh()
            db.koneksi()
            Dim query = "select * from Pasien order by idPasien desc"
            Dim DA As New SqlDataAdapter(query, db.konek)
            Dim DS As New DataSet
            DA.Fill(DS)


            DG1.DataSource = DS.Tables(0)
            DG1.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TampilGrid2()
        Try
            If DG1.SelectedRows.Count > 0 Then
                kd1 = DG1.CurrentRow.Cells(0).Value
                DG2.DataSource = Nothing
                DG2.Refresh()
                db.koneksi()
                Dim query = "select * from Rekam where idPasien = '" & kd1 & "' order by idRekam desc"
                Dim DA As New SqlDataAdapter(query, db.konek)
                Dim DS As New DataSet
                DA.Fill(DS)


                DG2.DataSource = DS.Tables(0)
                DG2.Refresh()
            Else
                MessageBox.Show("Anda Belum Memilih Data Rekam", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        If DG2.SelectedRows.Count > 0 Then

            kd2 = DG2.CurrentRow.Cells(0).Value
            Call ExportPdf(kd2)
        Else
            MessageBox.Show("Anda Belum Memilih Data Rekam", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtCriPasien_TextChanged(sender As Object, e As EventArgs) 
        db.koneksi()
        Dim query = "select * from pasien where idPasien like '%" & txtCriPasien.Text & "%' or nama like '%" & txtCriPasien.Text & "%' or noKTP like '%" & txtCriPasien.Text & "%' order by idPasien desc"
        Dim DA As New SqlDataAdapter(query, db.konek)
        Dim DS As New DataSet
        DA.Fill(DS)

        DG1.DataSource = DS.Tables(0)
        DG1.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) 
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) 
        Me.WindowState = WindowState.Minimized
        picClose.Left = Me.Width - picClose.Width - 8
        picMax.Left = Me.Width - picMax.Width - 36
        picMin.Left = Me.Width - picMin.Width - 62
        lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) 
        If WindowState = WindowState.Normal Then
            WindowState = FormWindowState.Maximized
            picClose.Left = Me.Width - picClose.Width - 8
            picMax.Left = Me.Width - picMax.Width - 36
            picMin.Left = Me.Width - picMin.Width - 62
            lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
            Button1.Left = Me.Width - Button1.Width - 10

            Call FormatGrid()
        ElseIf WindowState = WindowState.Maximized Then
            WindowState = WindowState.Normal
            picClose.Left = Me.Width - picClose.Width - 8
            picMax.Left = Me.Width - picMax.Width - 36
            picMin.Left = Me.Width - picMin.Width - 62
            lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
            Button1.Left = Me.Width - Button1.Width - 10

            Call FormatGrid()
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) 
        picClose.Left = Me.Width - picClose.Width - 8
        picMax.Left = Me.Width - picMax.Width - 36
        picMin.Left = Me.Width - picMin.Width - 62
        lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
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

    Dim x, y, q, w, h As Double

    Public graph As XGraphics
    Public pdf As PdfDocument
    Public page As PdfPage

    Public Sub createPage()
        page = pdf.AddPage
        page.Size = PageSize.A4
        graph = XGraphics.FromPdfPage(page)
    End Sub

    Public Sub ExportPdf(id As String)


        pdf = New PdfDocument
        Call createPage()


        Call pdfHeader()
        Call pdfBody()
        Call pdfFooter()

        Try
            Dim pdfFilename As String = "DataLaporan-" & id & ".pdf"


            Dim filePath As String
            Dim dir = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "/AppRekamMedis"

            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            filePath = Path.Combine(dir, pdfFilename)

            pdf.Save(filePath)
            Process.Start(filePath)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub pdfHeader()
        Dim logoPath = db.appPath & "\logo.png"
        Dim image As XImage = XImage.FromFile(logoPath)
        q = XUnit.FromCentimeter(1)
        Dim font1 = New XFont("Times", 14)
        Dim fontH1 = New XFont("Times", 18, XFontStyle.Bold)
        Dim fontH2 = New XFont("Times", 9, XFontStyle.Bold)

        x = 0
        y = q
        Dim l1 As Double = font1.Height
        Dim lH1 As Double = fontH1.Height
        Dim format = New XStringFormat()


        w = page.Width
        Dim c = (q * 2)


        graph.DrawImage(image, c, q, q * 1.8, q * 2.16)

        format.Alignment = XStringAlignment.Center
        graph.DrawString("PEMERINTAH KOTA PALOPO",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("DINAS PERTANIAN PETERNAKAN DAN PERKEBUN
AN",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("PUSKESWAN PALOPO",
                         fontH1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += lH1
        graph.DrawString("Jln. Veteran No. 39 Telp / Fax (0471)21019 Palopo",
                         fontH2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += lH1
        Dim pen = New XPen(XColors.Black, 4)
        Dim ujng = w - (q * 2)
        graph.DrawLine(pen, q * 2, y, ujng, y)
        y += 12
    End Sub

    Sub pdfBody()
        Dim q = 28.3
        Dim fontTitle = New XFont("Times", 12, XFontStyle.Bold Or XFontStyle.Underline)
        Dim fontParagraph = New XFont("Times", 12)
        Dim fontMini = New XFont("Times", 10.5)
        Dim l1 As Double = fontTitle.Height
        Dim format = New XStringFormat




        w = page.Width
        h = page.Height

        format.Alignment = XStringAlignment.Center
        graph.DrawString("REKAM MEDIS KESEHATAN HEWAN",
                         fontTitle, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1 + 10

        Dim rect_style1 = New XSolidBrush(XColors.White)
        Dim rect_style2 = New XSolidBrush(XColors.DarkGreen)
        Dim rect_style3 = New XSolidBrush(XColors.Red)
        Dim d = 0
        Dim i = 1
        Dim n As Boolean = False

        db.koneksi()
        Dim query = "SELECT * FROM Pasien P JOIN Rekam R ON P.idPasien = R.idPasien WHERE P.idPasien = '" & kd1 & "' AND R.idRekam = '" & kd2 & "'"
        Dim CMD As New SqlCommand(query, db.konek)
        Dim DR As SqlDataReader = CMD.ExecuteReader()

        q = XUnit.FromCentimeter(1)
        Dim font2 = New XFont("Times", 12)
        Dim l2 As Double = font2.Height

        format.Alignment = XStringAlignment.Near
        x = q * 3
        Dim x2 = q * 7
        Dim x3 = x2 + 7
        Dim tWidth = q * 12
        l2 += 4

        While DR.Read()
            Dim pen2 = New XPen(XColors.Black, 1)
            Dim tf = New Layout.XTextFormatter(graph)

            Dim txt = DR("ket").ToString
            Dim tfHeight = MeasureHeight(graph, txt, font2, tWidth)
            graph.DrawString("No Pendaftaran",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("idPasien").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("No KTP",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("noKTP").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Nama Pemilik",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("nama").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Alamat",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("alamat").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("No Telepon",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("noTelepon").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2 + 10

            Dim y2 = y

            graph.DrawString("No Rekam Medis",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("idRekam").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Tanggal",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("tgl").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Nama Hewan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("namaHewan").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Jenis Hewan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("jenisHewan").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Jenis Kelamin Hewan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("jkHewan").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Anamnesa",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("anamnesa").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Gejala",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("gejala").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Diagnosa",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("diagnosa").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2
            graph.DrawString("Pengobatan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            graph.DrawString(DR("pengobatan").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, page.Width, page.Height), format)
            y += l2

            graph.DrawString("Keterangan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)
            Dim tdAli = New Layout.XParagraphAlignment
            tf.Alignment = tdAli.Justify

            tf.DrawString(DR("ket").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, tWidth, page.Height), XStringFormat.TopLeft)
            y += tfHeight

            Dim y3 = y
            graph.DrawRectangle(pen2, x - 4, y2 - 4, tWidth + (q * 4) + 20, y3 - y2 + 10)

        End While


    End Sub

    Sub pdfFooter()
        q = XUnit.FromCentimeter(1)
        Dim font1 = New XFont("Times", 14)
        Dim fontH1 = New XFont("Times", 18, XFontStyle.Bold)
        Dim fontH2 = New XFont("Times", 9, XFontStyle.Bold)

        x = 0
        y = y + (q * 1)
        Dim l1 As Double = font1.Height
        Dim lH1 As Double = fontH1.Height
        Dim format = New XStringFormat()

        w = page.Width
        format.Alignment = XStringAlignment.Center
        graph.DrawString("PUSAT KESEHATAN HEWAN (PUSKESWAN)",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("DINAS PERTANIAN PETERNAKAN DAN PERKEBUMAN",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("KOTA PALOPO",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)

    End Sub

    Private Function MeasureHeight(gfx As XGraphics, text As String, font As XFont, width As Integer) As Double
        Dim lines = text.Split(vbLf)
        Dim totalHeight As Double = 0
        Dim x = 0
        For Each line As String In lines
            Console.WriteLine(line)
            Dim size = gfx.MeasureString(line, font)
            Dim height As Double = size.Height + (size.Height * Math.Floor(size.Width / width))
            totalHeight += height

            Console.WriteLine(size.Height & "*" & size.Width & "/" & width & "=" & height & "-" & totalHeight)
        Next
        Return totalHeight
    End Function

    Private Sub DG1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellClick
        kd1 = DG1.CurrentRow.Cells(0).Value
        Call TampilGrid2()
    End Sub
End Class