Public Class Crucigrama
    Dim palabras() As String = {"empate", "empanada", "naranja", "heladera"}
    Dim palabraSeleccionada
    Dim checksCount As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox15.TextChanged, TextBox16.TextChanged, TextBox17.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox20.TextChanged, TextBox21.TextChanged, TextBox22.TextChanged, TextBox23.TextChanged, TextBox24.TextChanged, TextBox25.TextChanged, TextBox26.TextChanged
        Dim letra As String = sender.Text
        Dim tag As String = sender.Tag

        Console.WriteLine("letra: " + letra + " tag: " + tag)

    End Sub

    Private Sub CheckBoxPalabras_Check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxH1.CheckedChanged, CheckBoxH2.CheckedChanged, CheckBoxV1.CheckedChanged, CheckBoxV2.CheckedChanged
        If sender.checked Then
            checksCount += 1
        Else
            checksCount -= 1
        End If
    End Sub

    Private Sub ButtonValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonValidar.Click
        If checksCount <> 1 Then
            MsgBox("Debe haber solo una palabra marcada para validar")
            Return
        End If
        Dim tg As String
        If CheckBoxH1.Checked Then
            For i As Integer = 0 To Integer.Parse(CheckBoxH1.Tag)
                tg = "h" + i.ToString()
            Next
        ElseIf CheckBoxH2.Checked Then
            For i As Integer = 0 To Integer.Parse(CheckBoxH2.Tag)
                tg = "h" + i.ToString()
            Next
        ElseIf CheckBoxV1.Checked Then
            For i As Integer = 0 To Integer.Parse(CheckBoxV1.Tag)
                tg = "v" + i.ToString()
            Next
        ElseIf CheckBoxV2.Checked Then
            For i As Integer = 0 To Integer.Parse(CheckBoxH2.Tag)
                tg = "v" + i.ToString()
            Next
        End If
        'MsgBox("Validar palabra seleccionada (solo puede haber un checkbox marcado)")
        'MsgBox("hay " + checksCount.ToString() + " valores checkeados")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
