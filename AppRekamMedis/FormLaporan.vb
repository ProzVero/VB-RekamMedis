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

    Private Sub setLocation()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        PictureBox2.Left = Me.Width - PictureBox2.Width - 80
        picClose.Left = Me.Width - 30
        PicMin.Left = Me.Width - 60
        Panel1.Width = Me.Width
        Title.Left = (Me.Width - Title.Width) / 2

        'pnlLaporan
        pnlLaporan.Width = Me.Width - 60
        pnlLaporan.Height = Me.Height - 220

        'btn Atas
        btnPrint.Left = pnlLaporan.Width - 120

        'Data Grid
        DG1.Width = pnlLaporan.Width - 60
        DG2.Width = pnlLaporan.Width - 60

        DG1.Height = (pnlLaporan.Height - 90) * 0.7
        DG2.Height = (pnlLaporan.Height - 90) * 0.3
        DG2.Top = (pnlLaporan.Height * 0.7)

    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.rekam' table. You can move, or remove it, as needed.
        'Me.RekamTableAdapter.Fill(Me.DbRekamMedisDataSet1.rekam)
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.Pasien' table. You can move, or remove it, as needed.
        'Me.PasienTableAdapter.Fill(Me.DbRekamMedisDataSet1.Pasien)
        Call setLocation()

        DG1.DefaultCellStyle.ForeColor = Color.Black
        DG2.DefaultCellStyle.ForeColor = Color.Black
        db.koneksi()
        Call FormatGrid()
        Call TampilGrid1()
    End Sub

    Sub FormatGrid()
        Dim widthDG1 = DG1.Width
        Dim widthDG2 = DG2.Width

        Dim widthClm1 As Integer = Fix((widthDG1 - 50) / 25)
        Dim widthClm2 As Integer = Fix((widthDG2 - 50) / 25)

        DG1.Columns(0).Width = widthClm1 * 2
        DG1.Columns(1).Width = widthClm1 * 3
        DG1.Columns(2).Width = widthClm1 * 4
        DG1.Columns(3).Width = widthClm1 * 3
        DG1.Columns(4).Width = widthClm1 * 4
        DG1.Columns(5).Width = widthClm1 * 2
        DG1.Columns(6).Width = widthClm1 * 5
        DG1.Columns(7).Width = widthClm1 * 2
        'MsgBox("'" & widthDG & "'- '" & widthClm & "'")
        DG2.Columns(0).Width = widthClm2 * 3
        DG2.Columns(1).Width = widthClm2 * 4
        DG2.Columns(2).Width = widthClm2 * 4
        DG2.Columns(3).Width = widthClm2 * 4
        DG2.Columns(4).Width = widthClm2 * 4
        DG2.Columns(5).Width = widthClm2 * 4
        DG2.Columns(6).Width = widthClm2 * 3


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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DG2.SelectedRows.Count > 0 Then

            kd2 = DG2.CurrentRow.Cells(0).Value
            Call ExportPdf(kd2)
        Else
            MessageBox.Show("Anda Belum Memilih Data Rekam", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtCri_TextChanged(sender As Object, e As EventArgs) Handles txtCri.TextChanged
        db.koneksi()
        Dim query = "select * from pasien where idPasien like '%" & txtCri.Text & "%' or nama like '%" & txtCri.Text & "%' or noKTP like '%" & txtCri.Text & "%' order by idPasien desc"
        Dim DA As New SqlDataAdapter(query, db.konek)
        Dim DS As New DataSet
        DA.Fill(DS)

        DG1.DataSource = DS.Tables(0)
        DG1.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles PicMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Dim result As DialogResult = MessageBox.Show("Tutup Aplikasi?", "AppRekamMedis", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
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
        graph.DrawString("DINAS PERTANIAN PETERNAKAN DAN PERKEBUNAN",
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

            Dim txtAnamnesa = DR("anamnesa").ToString
            Dim txtGejala = DR("gejala").ToString
            Dim txtDiagnosa = DR("diagnosa").ToString
            Dim txtPengobatan = DR("pengobatan").ToString

            Dim htAnamnesa = MeasureHeight(graph, txtAnamnesa, font2, tWidth)
            Dim htGejala = MeasureHeight(graph, txtGejala, font2, tWidth)
            Dim htDiagnosa = MeasureHeight(graph, txtDiagnosa, font2, tWidth)
            Dim htPengobatan = MeasureHeight(graph, txtPengobatan, font2, tWidth)


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
            Dim tdAli = New Layout.XParagraphAlignment
            tf.Alignment = tdAli.Justify

            tf.DrawString(DR("anamnesa").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, tWidth, page.Height), XStringFormat.TopLeft)
            y += htAnamnesa
            graph.DrawString("Gejala",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)

            tf.DrawString(DR("gejala").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, tWidth, page.Height), XStringFormat.TopLeft)
            y += htGejala
            graph.DrawString("Diagnosa",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)

            tf.DrawString(DR("diagnosa").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, tWidth, page.Height), XStringFormat.TopLeft)
            y += htDiagnosa
            graph.DrawString("Pengobatan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)

            tf.DrawString(DR("pengobatan").ToString,
                         font2, XBrushes.Black, New XRect(x3, y, tWidth, page.Height), XStringFormat.TopLeft)
            y += htPengobatan
            graph.DrawString("Keterangan",
                         font2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
            graph.DrawString(":",
                         font2, XBrushes.Black, New XRect(x2, y, page.Width, page.Height), format)


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

        Dim f1 = New XFont("Times", 12)
        Dim f2 = New XFont("Times", 12, XFontStyle.Bold Or XFontStyle.Underline)

        x = 0
        'y = y + (q * 1)
        Dim l1 As Double = font1.Height
        Dim lH1 As Double = fontH1.Height
        Dim lf1 As Double = f1.Height
        Dim lf2 As Double = f2.Height
        Dim format = New XStringFormat()

        w = page.Width
        h = page.Height
        Dim width = w / 3


        Dim tf = New Layout.XTextFormatter(graph)
        Dim tdAli = New Layout.XParagraphAlignment
        tf.Alignment = tdAli.Justify

        Dim txtTTD = "Kepala Bidang Kesehatan Hewan dan Kesehatan Masyarakat Veteriner,"
        Dim txtNama = "Drh. BURHANUDDIN HARAHAP"
        Dim txtNIP = "NIP. 19780405 200902 1 005"

        Dim htTTD = MeasureHeight(graph, txtTTD, f1, width)

        w = page.Width
        format.Alignment = XStringAlignment.Center
        'graph.DrawString("PUSAT KESEHATAN HEWAN (PUSKESWAN)",font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        'y += l1
        'graph.DrawString("DINAS PERTANIAN PETERNAKAN DAN PERKEBUNAN", font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        'y += l1
        'graph.DrawString("KOTA PALOPO", font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += (q * 2)


        tf.DrawString(txtTTD, f1, XBrushes.Black, New XRect(w - width - (q * 1), y, width, htTTD + 5), XStringFormat.TopLeft)
        y += htTTD * 3
        format.Alignment = XStringAlignment.Near
        graph.DrawString(txtNama,
                         f2, XBrushes.Black, New XRect(w - width - (q * 1), y, width, lf2 + 5), format)
        y += lf2
        graph.DrawString(txtNIP,
                         f1, XBrushes.Black, New XRect(w - width - (q * 1), y, width, lf1 + 5), format)

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