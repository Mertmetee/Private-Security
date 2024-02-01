Imports System.Data.SqlClient
Public Class OzelGuvenlikBedenBilgiFormu
    Private Sub OzelGuvenlikBedenBilgiFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OzelGuvenlikBilgileriniGetir()
        BedenOlcuBilgileriniGetir()
        OlcuBirimBilgileriniGetir()
        AtaVeiliskiOlustur()
        NesneleriBagla()
    End Sub
    Private Sub OzelGuvenlikBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT OGBT.*,GNBT.GuvenlikNoktasiAdi,
CASE WHEN Cinsiyet=0 THEN 'Erkek' ELSE 'Kadın' END AS Cinsiyeti
        FROM OzelGuvenlikBilgileriTablosu OGBT
        INNER JOIN GuvenlikNoktasiBilgileriTablosu GNBT 
        ON OGBT.GuvenlikNoktasiKayitNo=GNBT.GuvenlikNoktasiKayitNo
        Order By Adi,Soyadi"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzguVTDS, "OzelGuvenlikBilgileriTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try

    End Sub
    Private Sub BedenOlcuBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM BedenOlcuTablosu"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzguVTDS, "BedenOlcuTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub OlcuBirimBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM OlcuBirimTablosu"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzguVTDS, "OlcuBirimTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub AtaVeiliskiOlustur()
        OzelGuvenlikBilgileriTablosuBS.DataSource = OzguVTDS.Tables("OzelGuvenlikBilgileriTablosu")
        '**************İlişki Oluştur*****************
        Dim OzelGuvenlikBedenOlcu As New DataRelation("OzelGuvenlikBedenOlcuRelation",
                OzguVTDS.Tables("OzelGuvenlikBilgileriTablosu").Columns("SicilNumarasi"),
                OzguVTDS.Tables("BedenOlcuTablosu").Columns("SicilNumarasi"))

        OzguVTDS.Relations.Add(OzelGuvenlikBedenOlcu)
        '*****************************************
        BedenOlcuTablosuBS.DataSource = OzelGuvenlikBilgileriTablosuBS
        BedenOlcuTablosuBS.DataMember = "OzelGuvenlikBedenOlcuRelation" 'İlişkinin Adı

        OlcuBirimTablosuBS.DataSource = OzguVTDS.Tables("OlcuBirimTablosu")
    End Sub
    Private Sub NesneleriBagla()
        OzelGuvenlikDGV.AutoGenerateColumns = False
        BedenOlcuDGV.AutoGenerateColumns = False

        OzelGuvenlikDGV.DataSource = OzelGuvenlikBilgileriTablosuBS
        BedenOlcuDGV.DataSource = BedenOlcuTablosuBS

        OlcuBirimNoC.DataPropertyName = "OlcuBirimNo"
        OlcuBirimNoC.DisplayMember = "OlcuBirimAdi"
        OlcuBirimNoC.ValueMember = "OlcuBirimNo"
        OlcuBirimNoC.DataSource = OlcuBirimTablosuBS

    End Sub

    Private Sub YazdirBtn_Click(sender As Object, e As EventArgs) Handles YazdirBtn.Click
        OzelGuvenlikBedenOlcuRaporFormu.ShowDialog(Me)
        OzelGuvenlikBedenOlcuRaporFormu.Dispose()
    End Sub
End Class