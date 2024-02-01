<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetinTBox = New System.Windows.Forms.TextBox()
        Me.HashCBox = New System.Windows.Forms.ComboBox()
        Me.HashKoduTBox = New System.Windows.Forms.TextBox()
        Me.UzunlukTBox = New System.Windows.Forms.TextBox()
        Me.KopyalaBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HASH Algoritması:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HASH Kodu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Uzunluk:"
        '
        'MetinTBox
        '
        Me.MetinTBox.Location = New System.Drawing.Point(117, 34)
        Me.MetinTBox.Name = "MetinTBox"
        Me.MetinTBox.Size = New System.Drawing.Size(400, 20)
        Me.MetinTBox.TabIndex = 4
        '
        'HashCBox
        '
        Me.HashCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HashCBox.FormattingEnabled = True
        Me.HashCBox.Items.AddRange(New Object() {"Bir Algoritma Seçiniz", "MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.HashCBox.Location = New System.Drawing.Point(117, 60)
        Me.HashCBox.Name = "HashCBox"
        Me.HashCBox.Size = New System.Drawing.Size(121, 21)
        Me.HashCBox.TabIndex = 5
        '
        'HashKoduTBox
        '
        Me.HashKoduTBox.Location = New System.Drawing.Point(117, 87)
        Me.HashKoduTBox.Multiline = True
        Me.HashKoduTBox.Name = "HashKoduTBox"
        Me.HashKoduTBox.ReadOnly = True
        Me.HashKoduTBox.Size = New System.Drawing.Size(400, 99)
        Me.HashKoduTBox.TabIndex = 6
        '
        'UzunlukTBox
        '
        Me.UzunlukTBox.Location = New System.Drawing.Point(117, 192)
        Me.UzunlukTBox.Name = "UzunlukTBox"
        Me.UzunlukTBox.ReadOnly = True
        Me.UzunlukTBox.Size = New System.Drawing.Size(100, 20)
        Me.UzunlukTBox.TabIndex = 7
        '
        'KopyalaBtn
        '
        Me.KopyalaBtn.FlatAppearance.BorderSize = 0
        Me.KopyalaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KopyalaBtn.Location = New System.Drawing.Point(418, 192)
        Me.KopyalaBtn.Name = "KopyalaBtn"
        Me.KopyalaBtn.Size = New System.Drawing.Size(99, 23)
        Me.KopyalaBtn.TabIndex = 8
        Me.KopyalaBtn.Text = "Hafızaya Kopyala"
        Me.KopyalaBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 267)
        Me.Controls.Add(Me.KopyalaBtn)
        Me.Controls.Add(Me.UzunlukTBox)
        Me.Controls.Add(Me.HashKoduTBox)
        Me.Controls.Add(Me.HashCBox)
        Me.Controls.Add(Me.MetinTBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hash Algoritmaları"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MetinTBox As TextBox
    Friend WithEvents HashCBox As ComboBox
    Friend WithEvents HashKoduTBox As TextBox
    Friend WithEvents UzunlukTBox As TextBox
    Friend WithEvents KopyalaBtn As Button
End Class
