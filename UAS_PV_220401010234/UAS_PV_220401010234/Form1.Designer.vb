<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TxtKode = New TextBox()
        TxtJumlah = New TextBox()
        TxtHarga = New TextBox()
        TxtTotal = New TextBox()
        TxtSatuan = New TextBox()
        TxtNama = New TextBox()
        BtnHitung = New Button()
        BtnClear = New Button()
        BtnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(361, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 0
        Label1.Text = "PENJUALAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 1
        Label2.Text = "Harga Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(173, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(173, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 20)
        Label5.TabIndex = 4
        Label5.Text = "Nama Barang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(173, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 5
        Label6.Text = "KodeBarang"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(492, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 20)
        Label7.TabIndex = 6
        Label7.Text = "Total"
        ' 
        ' TxtKode
        ' 
        TxtKode.Location = New Point(409, 70)
        TxtKode.Name = "TxtKode"
        TxtKode.Size = New Size(125, 27)
        TxtKode.TabIndex = 7
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(409, 208)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(125, 27)
        TxtJumlah.TabIndex = 8
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(409, 258)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(125, 27)
        TxtHarga.TabIndex = 9
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(572, 301)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(125, 27)
        TxtTotal.TabIndex = 10
        ' 
        ' TxtSatuan
        ' 
        TxtSatuan.Location = New Point(409, 159)
        TxtSatuan.Name = "TxtSatuan"
        TxtSatuan.Size = New Size(125, 27)
        TxtSatuan.TabIndex = 11
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(409, 115)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(125, 27)
        TxtNama.TabIndex = 12
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(605, 189)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(106, 96)
        BtnHitung.TabIndex = 13
        BtnHitung.Text = "HITUNG"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(245, 378)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(106, 31)
        BtnClear.TabIndex = 14
        BtnClear.Text = "CLEAR"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(466, 378)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(106, 31)
        BtnExit.TabIndex = 15
        BtnExit.Text = "EXIT"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnExit)
        Controls.Add(BtnClear)
        Controls.Add(BtnHitung)
        Controls.Add(TxtNama)
        Controls.Add(TxtSatuan)
        Controls.Add(TxtTotal)
        Controls.Add(TxtHarga)
        Controls.Add(TxtJumlah)
        Controls.Add(TxtKode)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtSatuan As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
End Class
