Public Class Form1
    Dim nilai1, nilai2, hasil As Double
    Dim a As String

    Private Sub btnon_Click(sender As System.Object, e As System.EventArgs) Handles btnon.Click
        Btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnoff.Enabled = True
        btnon.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub btnoff_Click(sender As System.Object, e As System.EventArgs) Handles btnoff.Click
        Btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnoff.Enabled = False
        btnon.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub Btn0_Click(sender As System.Object, e As System.EventArgs) Handles Btn0.Click
        Textlayar.Text = Textlayar.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        Textlayar.Text = Textlayar.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        Textlayar.Text = Textlayar.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        Textlayar.Text = Textlayar.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        Textlayar.Text = Textlayar.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        Textlayar.Text = Textlayar.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        Textlayar.Text = Textlayar.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        Textlayar.Text = Textlayar.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        Textlayar.Text = Textlayar.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        Textlayar.Text = Textlayar.Text & "9"
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Textlayar.Clear()
    End Sub

    Private Sub btntotal_Click(sender As System.Object, e As System.EventArgs) Handles btntotal.Click
        If a = "+" Then
            hasil = nilai1 + Val(Textlayar.Text)
            Textlayar.Text = hasil
        ElseIf a = "-" Then
            hasil = nilai1 - Val(Textlayar.Text)
            Textlayar.Text = hasil
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MsgBox("apa anda serius ingin keluar " + Textlayar.Text + "?", vbYesNo + vbQuestion, "ajik suryo widodo") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnjumlah_Click(sender As System.Object, e As System.EventArgs) Handles btnjumlah.Click
        nilai1 = Val(Textlayar.Text)
        a = "+"
        Textlayar.Text = ""
    End Sub

    Private Sub btnkurang_Click(sender As System.Object, e As System.EventArgs) Handles btnkurang.Click
        nilai1 = Val(Textlayar.Text)
        a = "-"
        Textlayar.Text = ""
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnoff.Enabled = False
        btnon.Enabled = True
    End Sub
End Class
