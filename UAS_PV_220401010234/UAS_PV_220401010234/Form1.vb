
Public Class Form1

    Sub BERSIH()
        TxtKode.Clear()
        TxtNama.Clear()
        TxtSatuan.Clear()
        TxtHarga.Clear()
        TxtJumlah.Clear()
        TxtTotal.Clear()
        TxtKode.Focus()
        TxtTotal.Enabled = False
    End Sub

    Sub Datakosong()
        If TxtKode.Text = "" Then
            MessageBox.Show("kode barang harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtKode.Focus()
        ElseIf TxtNama.Text = "" Then
            MessageBox.Show("Nama barang harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNama.Focus()
        ElseIf TxtSatuan.Text = "" Then
            MessageBox.Show("Satuan barang harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSatuan.Focus()
        ElseIf TxtHarga.Text = "" Then
            MessageBox.Show("Harga barang harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHarga.Focus()
        ElseIf TxtJumlah.Text = "" Then
            MessageBox.Show("Jumlah barang yang dibeli harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtJumlah.Focus()
        Else
            Call Hitung()
        End If

    End Sub
    Function Hitung()
        Dim harga, jumlah, total As Integer
        harga = TxtHarga.Text
        jumlah = TxtJumlah.Text
        total = harga * jumlah
        TxtTotal.Text = total
        Return total

    End Function

    Private Sub BtnHitung_Click_1(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Call Datakosong()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call BERSIH()
    End Sub

    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim keluar As String
        keluar = MessageBox.Show("Yakin Anda Ingin Keluar ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = MsgBoxResult.Yes Then
            Close()
        Else
            Exit Sub
            Call BERSIH()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
