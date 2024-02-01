Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class OzelGuvenlikBedenOlcuRaporFormu
    Private Sub OzelGuvenlikBedenOlcuRaporFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Baglanti As IConnectionInfo
        Dim CumleOlusturucu As New SqlConnectionStringBuilder(SqlBaglantiCumlesi)
        Dim Sunucu As String = CumleOlusturucu.DataSource
        Dim KullaniciAdi As String = CumleOlusturucu.UserID
        Dim Sifre As String = CumleOlusturucu.Password
        Dim VT As String = CumleOlusturucu.InitialCatalog

        For Each Baglanti In OGBORaporu.DataSourceConnections
            Baglanti.SetConnection(Sunucu, VT, KullaniciAdi, Sifre)
        Next

        For Each AltRapor As ReportDocument In OGBORaporu.Subreports
            For Each Baglanti In AltRapor.DataSourceConnections
                Baglanti.SetConnection(Sunucu, VT, KullaniciAdi, Sifre)
            Next
        Next
        OGBORaporu.Refresh()
    End Sub
End Class