<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPasien
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasien))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicMin = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlPasien = New System.Windows.Forms.Panel()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.IdPasienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoKTPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JkHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbRekamMedisDataSet1 = New AppRekamMedis.dbRekamMedisDataSet1()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCri = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PasienTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.PasienTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPasien.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(360, 155)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(179, 31)
        Me.Title.TabIndex = 30
        Me.Title.Text = "DATA PASIEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 31)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "KOTA PALOPO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 5)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "PUSAT KESEHATAN HEWAN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.pdhi
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(689, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PicMin
        '
        Me.PicMin.BackgroundImage = CType(resources.GetObject("PicMin.BackgroundImage"), System.Drawing.Image)
        Me.PicMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMin.InitialImage = Nothing
        Me.PicMin.Location = New System.Drawing.Point(844, 12)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(20, 20)
        Me.PicMin.TabIndex = 28
        Me.PicMin.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Location = New System.Drawing.Point(870, 12)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 27
        Me.picClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(100, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'pnlPasien
        '
        Me.pnlPasien.BackColor = System.Drawing.Color.DarkMagenta
        Me.pnlPasien.Controls.Add(Me.DG)
        Me.pnlPasien.Controls.Add(Me.btnHapus)
        Me.pnlPasien.Controls.Add(Me.btnEdit)
        Me.pnlPasien.Controls.Add(Me.btnPrint)
        Me.pnlPasien.Controls.Add(Me.btnRefresh)
        Me.pnlPasien.Controls.Add(Me.btnTambah)
        Me.pnlPasien.Controls.Add(Me.Panel8)
        Me.pnlPasien.Controls.Add(Me.btnBack)
        Me.pnlPasien.Location = New System.Drawing.Point(30, 190)
        Me.pnlPasien.Name = "pnlPasien"
        Me.pnlPasien.Size = New System.Drawing.Size(840, 480)
        Me.pnlPasien.TabIndex = 31
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.AutoGenerateColumns = False
        Me.DG.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPasienDataGridViewTextBoxColumn, Me.NoKTPDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.NamaHewanDataGridViewTextBoxColumn, Me.JenisHewanDataGridViewTextBoxColumn, Me.JkHewanDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoTeleponDataGridViewTextBoxColumn})
        Me.DG.DataSource = Me.PasienBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG.EnableHeadersVisualStyles = False
        Me.DG.Location = New System.Drawing.Point(30, 60)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DG.Size = New System.Drawing.Size(783, 360)
        Me.DG.TabIndex = 12
        '
        'IdPasienDataGridViewTextBoxColumn
        '
        Me.IdPasienDataGridViewTextBoxColumn.DataPropertyName = "IdPasien"
        Me.IdPasienDataGridViewTextBoxColumn.HeaderText = "No Pendaftaran"
        Me.IdPasienDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.IdPasienDataGridViewTextBoxColumn.Name = "IdPasienDataGridViewTextBoxColumn"
        Me.IdPasienDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoKTPDataGridViewTextBoxColumn
        '
        Me.NoKTPDataGridViewTextBoxColumn.DataPropertyName = "noKTP"
        Me.NoKTPDataGridViewTextBoxColumn.HeaderText = "noKTP"
        Me.NoKTPDataGridViewTextBoxColumn.Name = "NoKTPDataGridViewTextBoxColumn"
        Me.NoKTPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaHewanDataGridViewTextBoxColumn
        '
        Me.NamaHewanDataGridViewTextBoxColumn.DataPropertyName = "namaHewan"
        Me.NamaHewanDataGridViewTextBoxColumn.HeaderText = "namaHewan"
        Me.NamaHewanDataGridViewTextBoxColumn.Name = "NamaHewanDataGridViewTextBoxColumn"
        Me.NamaHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisHewanDataGridViewTextBoxColumn
        '
        Me.JenisHewanDataGridViewTextBoxColumn.DataPropertyName = "jenisHewan"
        Me.JenisHewanDataGridViewTextBoxColumn.HeaderText = "jenisHewan"
        Me.JenisHewanDataGridViewTextBoxColumn.Name = "JenisHewanDataGridViewTextBoxColumn"
        Me.JenisHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JkHewanDataGridViewTextBoxColumn
        '
        Me.JkHewanDataGridViewTextBoxColumn.DataPropertyName = "jkHewan"
        Me.JkHewanDataGridViewTextBoxColumn.HeaderText = "jkHewan"
        Me.JkHewanDataGridViewTextBoxColumn.Name = "JkHewanDataGridViewTextBoxColumn"
        Me.JkHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoTeleponDataGridViewTextBoxColumn
        '
        Me.NoTeleponDataGridViewTextBoxColumn.DataPropertyName = "noTelepon"
        Me.NoTeleponDataGridViewTextBoxColumn.HeaderText = "noTelepon"
        Me.NoTeleponDataGridViewTextBoxColumn.Name = "NoTeleponDataGridViewTextBoxColumn"
        Me.NoTeleponDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "Pasien"
        Me.PasienBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'DbRekamMedisDataSet1
        '
        Me.DbRekamMedisDataSet1.DataSetName = "dbRekamMedisDataSet1"
        Me.DbRekamMedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.FlatAppearance.BorderSize = 2
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.Black
        Me.btnHapus.Location = New System.Drawing.Point(454, 434)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(90, 35)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(280, 434)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 35)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnPrint.FlatAppearance.BorderSize = 2
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(714, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 35)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnRefresh.FlatAppearance.BorderSize = 2
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(484, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 35)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnTambah.FlatAppearance.BorderSize = 2
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(598, 11)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(90, 35)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCri)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Location = New System.Drawing.Point(86, 13)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(378, 30)
        Me.Panel8.TabIndex = 6
        '
        'txtCri
        '
        Me.txtCri.BackColor = System.Drawing.SystemColors.Control
        Me.txtCri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCri.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCri.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCri.ForeColor = System.Drawing.Color.Black
        Me.txtCri.Location = New System.Drawing.Point(76, 5)
        Me.txtCri.Name = "txtCri"
        Me.txtCri.Size = New System.Drawing.Size(287, 22)
        Me.txtCri.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(9, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cari"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.home
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(20, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 26)
        Me.btnBack.TabIndex = 1
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'FormPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.pnlPasien)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicMin)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPasien"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPasien.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicMin As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents pnlPasien As Panel
    Friend WithEvents DG As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCri As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents DbRekamMedisDataSet1 As dbRekamMedisDataSet1
    Friend WithEvents PasienBindingSource As BindingSource
    Friend WithEvents PasienTableAdapter As dbRekamMedisDataSet1TableAdapters.PasienTableAdapter
    Friend WithEvents NoTeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JkHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoKTPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPasienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
