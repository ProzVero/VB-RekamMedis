<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DG2 = New System.Windows.Forms.DataGridView()
        Me.IdRekamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnamnesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GejalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengobatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbRekamMedisDataSet1 = New AppRekamMedis.dbRekamMedisDataSet1()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.IdPasienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoKTPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JkHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.PasienTableAdapter()
        Me.RekamTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.rekamTableAdapter()
        Me.Panel3.SuspendLayout()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RekamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DG2)
        Me.Panel3.Controls.Add(Me.DG1)
        Me.Panel3.Location = New System.Drawing.Point(10, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 500)
        Me.Panel3.TabIndex = 26
        '
        'DG2
        '
        Me.DG2.AllowUserToAddRows = False
        Me.DG2.AllowUserToDeleteRows = False
        Me.DG2.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRekamDataGridViewTextBoxColumn, Me.AnamnesaDataGridViewTextBoxColumn, Me.GejalaDataGridViewTextBoxColumn, Me.DiagnosaDataGridViewTextBoxColumn, Me.PengobatanDataGridViewTextBoxColumn, Me.KetDataGridViewTextBoxColumn, Me.TglDataGridViewTextBoxColumn})
        Me.DG2.DataSource = Me.RekamBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG2.EnableHeadersVisualStyles = False
        Me.DG2.Location = New System.Drawing.Point(10, 195)
        Me.DG2.Name = "DG2"
        Me.DG2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG2.Size = New System.Drawing.Size(840, 175)
        Me.DG2.TabIndex = 2
        '
        'IdRekamDataGridViewTextBoxColumn
        '
        Me.IdRekamDataGridViewTextBoxColumn.DataPropertyName = "IdRekam"
        Me.IdRekamDataGridViewTextBoxColumn.HeaderText = "No Rekam"
        Me.IdRekamDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.IdRekamDataGridViewTextBoxColumn.Name = "IdRekamDataGridViewTextBoxColumn"
        Me.IdRekamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnamnesaDataGridViewTextBoxColumn
        '
        Me.AnamnesaDataGridViewTextBoxColumn.DataPropertyName = "anamnesa"
        Me.AnamnesaDataGridViewTextBoxColumn.HeaderText = "Anamnesa"
        Me.AnamnesaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.AnamnesaDataGridViewTextBoxColumn.Name = "AnamnesaDataGridViewTextBoxColumn"
        Me.AnamnesaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GejalaDataGridViewTextBoxColumn
        '
        Me.GejalaDataGridViewTextBoxColumn.DataPropertyName = "gejala"
        Me.GejalaDataGridViewTextBoxColumn.HeaderText = "Gejala"
        Me.GejalaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.GejalaDataGridViewTextBoxColumn.Name = "GejalaDataGridViewTextBoxColumn"
        Me.GejalaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiagnosaDataGridViewTextBoxColumn
        '
        Me.DiagnosaDataGridViewTextBoxColumn.DataPropertyName = "diagnosa"
        Me.DiagnosaDataGridViewTextBoxColumn.HeaderText = "Diagnosa"
        Me.DiagnosaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.DiagnosaDataGridViewTextBoxColumn.Name = "DiagnosaDataGridViewTextBoxColumn"
        Me.DiagnosaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PengobatanDataGridViewTextBoxColumn
        '
        Me.PengobatanDataGridViewTextBoxColumn.DataPropertyName = "pengobatan"
        Me.PengobatanDataGridViewTextBoxColumn.HeaderText = "Pengobatan"
        Me.PengobatanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.PengobatanDataGridViewTextBoxColumn.Name = "PengobatanDataGridViewTextBoxColumn"
        Me.PengobatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KetDataGridViewTextBoxColumn
        '
        Me.KetDataGridViewTextBoxColumn.DataPropertyName = "ket"
        Me.KetDataGridViewTextBoxColumn.HeaderText = "Ket"
        Me.KetDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.KetDataGridViewTextBoxColumn.Name = "KetDataGridViewTextBoxColumn"
        Me.KetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglDataGridViewTextBoxColumn
        '
        Me.TglDataGridViewTextBoxColumn.DataPropertyName = "tgl"
        Me.TglDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TglDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.TglDataGridViewTextBoxColumn.Name = "TglDataGridViewTextBoxColumn"
        Me.TglDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RekamBindingSource
        '
        Me.RekamBindingSource.DataMember = "Rekam"
        Me.RekamBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'DbRekamMedisDataSet1
        '
        Me.DbRekamMedisDataSet1.DataSetName = "dbRekamMedisDataSet1"
        Me.DbRekamMedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.AllowUserToDeleteRows = False
        Me.DG1.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPasienDataGridViewTextBoxColumn, Me.NoKTPDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.NamaHewanDataGridViewTextBoxColumn, Me.JenisHewanDataGridViewTextBoxColumn, Me.JkHewanDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoTeleponDataGridViewTextBoxColumn})
        Me.DG1.DataSource = Me.PasienBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG1.EnableHeadersVisualStyles = False
        Me.DG1.Location = New System.Drawing.Point(10, 10)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DG1.Size = New System.Drawing.Size(840, 175)
        Me.DG1.TabIndex = 1
        '
        'IdPasienDataGridViewTextBoxColumn
        '
        Me.IdPasienDataGridViewTextBoxColumn.DataPropertyName = "IdPasien"
        Me.IdPasienDataGridViewTextBoxColumn.HeaderText = "No Pendaftaran"
        Me.IdPasienDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.IdPasienDataGridViewTextBoxColumn.Name = "IdPasienDataGridViewTextBoxColumn"
        Me.IdPasienDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoKTPDataGridViewTextBoxColumn
        '
        Me.NoKTPDataGridViewTextBoxColumn.DataPropertyName = "noKTP"
        Me.NoKTPDataGridViewTextBoxColumn.HeaderText = "No KTP"
        Me.NoKTPDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NoKTPDataGridViewTextBoxColumn.Name = "NoKTPDataGridViewTextBoxColumn"
        Me.NoKTPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaHewanDataGridViewTextBoxColumn
        '
        Me.NamaHewanDataGridViewTextBoxColumn.DataPropertyName = "namaHewan"
        Me.NamaHewanDataGridViewTextBoxColumn.HeaderText = "Nama Hewan"
        Me.NamaHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NamaHewanDataGridViewTextBoxColumn.Name = "NamaHewanDataGridViewTextBoxColumn"
        Me.NamaHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisHewanDataGridViewTextBoxColumn
        '
        Me.JenisHewanDataGridViewTextBoxColumn.DataPropertyName = "jenisHewan"
        Me.JenisHewanDataGridViewTextBoxColumn.HeaderText = "Jenis Hewan"
        Me.JenisHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.JenisHewanDataGridViewTextBoxColumn.Name = "JenisHewanDataGridViewTextBoxColumn"
        Me.JenisHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JkHewanDataGridViewTextBoxColumn
        '
        Me.JkHewanDataGridViewTextBoxColumn.DataPropertyName = "jkHewan"
        Me.JkHewanDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin Hewan"
        Me.JkHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.JkHewanDataGridViewTextBoxColumn.Name = "JkHewanDataGridViewTextBoxColumn"
        Me.JkHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoTeleponDataGridViewTextBoxColumn
        '
        Me.NoTeleponDataGridViewTextBoxColumn.DataPropertyName = "noTelepon"
        Me.NoTeleponDataGridViewTextBoxColumn.HeaderText = "No Telepon"
        Me.NoTeleponDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NoTeleponDataGridViewTextBoxColumn.Name = "NoTeleponDataGridViewTextBoxColumn"
        Me.NoTeleponDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "Pasien"
        Me.PasienBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'RekamTableAdapter
        '
        Me.RekamTableAdapter.ClearBeforeFill = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RekamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DG2 As DataGridView
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents DbRekamMedisDataSet1 As dbRekamMedisDataSet1
    Friend WithEvents PasienBindingSource As BindingSource
    Friend WithEvents PasienTableAdapter As dbRekamMedisDataSet1TableAdapters.PasienTableAdapter
    Friend WithEvents RekamBindingSource As BindingSource
    Friend WithEvents RekamTableAdapter As dbRekamMedisDataSet1TableAdapters.rekamTableAdapter
    Friend WithEvents NoTeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JkHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoKTPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPasienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengobatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GejalaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnamnesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRekamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
