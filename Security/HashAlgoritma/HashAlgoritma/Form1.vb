Imports System.Security.Cryptography
Public Class Form1
    Private Sub HashCBox_DropDownClosed(sender As Object, e As EventArgs) Handles HashCBox.DropDownClosed
        Dim Metin As String = MetinTBox.Text
        Dim Sonuc As String = Nothing
        Dim Uzunluk As Integer
        Select Case HashCBox.SelectedItem.ToString().Trim
            Case "MD5"
                Sonuc = HashAlgoritma(Metin, MD5.Create)
            Case "SHA1"
                Sonuc = HashAlgoritma(Metin, SHA1.Create)
            Case "SHA256"
                Sonuc = HashAlgoritma(Metin, SHA256.Create)
            Case "SHA384"
                Sonuc = HashAlgoritma(Metin, SHA384.Create)
            Case "SHA512"
                Sonuc = HashAlgoritma(Metin, SHA512.Create)
            Case Else
                MessageBox.Show("Lütfen bir algoritma seçiniz.", "Uyarı")
                Uzunluk = 0
                Sonuc = Nothing
        End Select
        Uzunluk = Sonuc.Length
        HashKoduTBox.Text = Sonuc
        UzunlukTBox.Text = Uzunluk
        HashCBox.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HashCBox.SelectedIndex = 0
    End Sub

    Private Sub KopyalaBtn_Click(sender As Object, e As EventArgs) Handles KopyalaBtn.Click
        Clipboard.SetText(HashKoduTBox.Text)
    End Sub
End Class
