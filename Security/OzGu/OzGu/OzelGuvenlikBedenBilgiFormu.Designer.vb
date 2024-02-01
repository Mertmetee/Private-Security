<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OzelGuvenlikBedenBilgiFormu
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
        Me.OzguVTDS = New System.Data.DataSet()
        Me.OzelGuvenlikDGV = New System.Windows.Forms.DataGridView()
        Me.TCKimlikNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoyadiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BabaAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CinsiyetiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogumYeriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogumTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SicilNumarasiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedenOlcuDGV = New System.Windows.Forms.DataGridView()
        Me.OlcuBirimNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OlcusuC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OlcuBirimTuruC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedenOlcusuKayitNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOSicilNumarasiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YazdirBtn = New System.Windows.Forms.Button()
        Me.OzelGuvenlikBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BedenOlcuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OlcuBirimTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OzguVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzelGuvenlikDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedenOlcuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedenOlcuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlcuBirimTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OzguVTDS
        '
        Me.OzguVTDS.DataSetName = "NewDataSet"
        '
        'OzelGuvenlikDGV
        '
        Me.OzelGuvenlikDGV.AllowUserToAddRows = False
        Me.OzelGuvenlikDGV.AllowUserToDeleteRows = False
        Me.OzelGuvenlikDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OzelGuvenlikDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCKimlikNoC, Me.AdiC, Me.SoyadiC, Me.BabaAdiC, Me.CinsiyetiC, Me.DogumYeriC, Me.DogumTarihiC, Me.AdresiC, Me.GuvenlikNoktasiAdiC, Me.SicilNumarasiC})
        Me.OzelGuvenlikDGV.Location = New System.Drawing.Point(43, 34)
        Me.OzelGuvenlikDGV.Name = "OzelGuvenlikDGV"
        Me.OzelGuvenlikDGV.ReadOnly = True
        Me.OzelGuvenlikDGV.Size = New System.Drawing.Size(968, 236)
        Me.OzelGuvenlikDGV.TabIndex = 0
        '
        'TCKimlikNoC
        '
        Me.TCKimlikNoC.DataPropertyName = "TCKimlikNo"
        Me.TCKimlikNoC.HeaderText = "TC Kimlik Numarası"
        Me.TCKimlikNoC.Name = "TCKimlikNoC"
        Me.TCKimlikNoC.ReadOnly = True
        '
        'AdiC
        '
        Me.AdiC.DataPropertyName = "Adi"
        Me.AdiC.HeaderText = "Adı"
        Me.AdiC.Name = "AdiC"
        Me.AdiC.ReadOnly = True
        '
        'SoyadiC
        '
        Me.SoyadiC.DataPropertyName = "Soyadi"
        Me.SoyadiC.HeaderText = "Soyadı"
        Me.SoyadiC.Name = "SoyadiC"
        Me.SoyadiC.ReadOnly = True
        '
        'BabaAdiC
        '
        Me.BabaAdiC.DataPropertyName = "BabaAdi"
        Me.BabaAdiC.HeaderText = "Baba Adı"
        Me.BabaAdiC.Name = "BabaAdiC"
        Me.BabaAdiC.ReadOnly = True
        '
        'CinsiyetiC
        '
        Me.CinsiyetiC.DataPropertyName = "Cinsiyeti"
        Me.CinsiyetiC.HeaderText = "Cinsiyet"
        Me.CinsiyetiC.Name = "CinsiyetiC"
        Me.CinsiyetiC.ReadOnly = True
        '
        'DogumYeriC
        '
        Me.DogumYeriC.DataPropertyName = "DogumYeri"
        Me.DogumYeriC.HeaderText = "Doğum Yeri"
        Me.DogumYeriC.Name = "DogumYeriC"
        Me.DogumYeriC.ReadOnly = True
        '
        'DogumTarihiC
        '
        Me.DogumTarihiC.DataPropertyName = "DogumTarihi"
        Me.DogumTarihiC.HeaderText = "Doğum Tarihi"
        Me.DogumTarihiC.Name = "DogumTarihiC"
        Me.DogumTarihiC.ReadOnly = True
        '
        'AdresiC
        '
        Me.AdresiC.DataPropertyName = "Adresi"
        Me.AdresiC.HeaderText = "Adresi"
        Me.AdresiC.Name = "AdresiC"
        Me.AdresiC.ReadOnly = True
        '
        'GuvenlikNoktasiAdiC
        '
        Me.GuvenlikNoktasiAdiC.DataPropertyName = "GuvenlikNoktasiAdi"
        Me.GuvenlikNoktasiAdiC.HeaderText = "Güvenlik Noktası"
        Me.GuvenlikNoktasiAdiC.Name = "GuvenlikNoktasiAdiC"
        Me.GuvenlikNoktasiAdiC.ReadOnly = True
        '
        'SicilNumarasiC
        '
        Me.SicilNumarasiC.DataPropertyName = "SicilNumarasi"
        Me.SicilNumarasiC.HeaderText = "Sicil Numarası"
        Me.SicilNumarasiC.Name = "SicilNumarasiC"
        Me.SicilNumarasiC.ReadOnly = True
        Me.SicilNumarasiC.Visible = False
        '
        'BedenOlcuDGV
        '
        Me.BedenOlcuDGV.AllowUserToAddRows = False
        Me.BedenOlcuDGV.AllowUserToDeleteRows = False
        Me.BedenOlcuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedenOlcuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OlcuBirimNoC, Me.OlcusuC, Me.OlcuBirimTuruC, Me.AciklamaC, Me.BedenOlcusuKayitNoC, Me.BOSicilNumarasiC})
        Me.BedenOlcuDGV.Location = New System.Drawing.Point(43, 276)
        Me.BedenOlcuDGV.Name = "BedenOlcuDGV"
        Me.BedenOlcuDGV.ReadOnly = True
        Me.BedenOlcuDGV.Size = New System.Drawing.Size(480, 318)
        Me.BedenOlcuDGV.TabIndex = 1
        '
        'OlcuBirimNoC
        '
        Me.OlcuBirimNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.OlcuBirimNoC.HeaderText = "Ölçü Birimi"
        Me.OlcuBirimNoC.Name = "OlcuBirimNoC"
        Me.OlcuBirimNoC.ReadOnly = True
        '
        'OlcusuC
        '
        Me.OlcusuC.DataPropertyName = "Olcusu"
        Me.OlcusuC.HeaderText = "Beden Ölçüsü"
        Me.OlcusuC.Name = "OlcusuC"
        Me.OlcusuC.ReadOnly = True
        '
        'OlcuBirimTuruC
        '
        Me.OlcuBirimTuruC.DataPropertyName = "OlcuBirimTuru"
        Me.OlcuBirimTuruC.HeaderText = "Birim Türü"
        Me.OlcuBirimTuruC.Name = "OlcuBirimTuruC"
        Me.OlcuBirimTuruC.ReadOnly = True
        '
        'AciklamaC
        '
        Me.AciklamaC.DataPropertyName = "Aciklama"
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.ReadOnly = True
        '
        'BedenOlcusuKayitNoC
        '
        Me.BedenOlcusuKayitNoC.DataPropertyName = "BedenOlcusuKayitNo"
        Me.BedenOlcusuKayitNoC.HeaderText = "Beden Ölçüsü Kayıt No"
        Me.BedenOlcusuKayitNoC.Name = "BedenOlcusuKayitNoC"
        Me.BedenOlcusuKayitNoC.ReadOnly = True
        Me.BedenOlcusuKayitNoC.Visible = False
        '
        'BOSicilNumarasiC
        '
        Me.BOSicilNumarasiC.DataPropertyName = "SicilNumarasi"
        Me.BOSicilNumarasiC.HeaderText = "Sicil Numarası"
        Me.BOSicilNumarasiC.Name = "BOSicilNumarasiC"
        Me.BOSicilNumarasiC.ReadOnly = True
        Me.BOSicilNumarasiC.Visible = False
        '
        'YazdirBtn
        '
        Me.YazdirBtn.Image = Global.OzGu.My.Resources.Resources.yazdir
        Me.YazdirBtn.Location = New System.Drawing.Point(529, 549)
        Me.YazdirBtn.Name = "YazdirBtn"
        Me.YazdirBtn.Size = New System.Drawing.Size(103, 45)
        Me.YazdirBtn.TabIndex = 2
        Me.YazdirBtn.Text = "Yazdır"
        Me.YazdirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.YazdirBtn.UseVisualStyleBackColor = True
        '
        'OzelGuvenlikBedenBilgiFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 672)
        Me.Controls.Add(Me.YazdirBtn)
        Me.Controls.Add(Me.BedenOlcuDGV)
        Me.Controls.Add(Me.OzelGuvenlikDGV)
        Me.Name = "OzelGuvenlikBedenBilgiFormu"
        Me.Text = "Özel Güvenlik Beden Ölçüsü Bilgileri"
        CType(Me.OzguVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzelGuvenlikDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedenOlcuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedenOlcuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlcuBirimTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OzguVTDS As DataSet
    Friend WithEvents OzelGuvenlikBilgileriTablosuBS As BindingSource
    Friend WithEvents BedenOlcuTablosuBS As BindingSource
    Friend WithEvents OlcuBirimTablosuBS As BindingSource
    Friend WithEvents OzelGuvenlikDGV As DataGridView
    Friend WithEvents BedenOlcuDGV As DataGridView
    Friend WithEvents OlcuBirimNoC As DataGridViewComboBoxColumn
    Friend WithEvents OlcusuC As DataGridViewTextBoxColumn
    Friend WithEvents OlcuBirimTuruC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
    Friend WithEvents BedenOlcusuKayitNoC As DataGridViewTextBoxColumn
    Friend WithEvents BOSicilNumarasiC As DataGridViewTextBoxColumn
    Friend WithEvents TCKimlikNoC As DataGridViewTextBoxColumn
    Friend WithEvents AdiC As DataGridViewTextBoxColumn
    Friend WithEvents SoyadiC As DataGridViewTextBoxColumn
    Friend WithEvents BabaAdiC As DataGridViewTextBoxColumn
    Friend WithEvents CinsiyetiC As DataGridViewTextBoxColumn
    Friend WithEvents DogumYeriC As DataGridViewTextBoxColumn
    Friend WithEvents DogumTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents AdresiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiAdiC As DataGridViewTextBoxColumn
    Friend WithEvents SicilNumarasiC As DataGridViewTextBoxColumn
    Friend WithEvents YazdirBtn As Button
End Class
