Public Class Crucigrama
    Dim TextBoxArray(10, 10) As TextBox
    Const TxtBoxSize As Integer = 25
    Dim crucigrama(,) As String = {
        {"-", "-", "-", "-", "J", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "A", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "V", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "A", "-", "-", "-", "-", "-"},
        {"T", "Y", "P", "E", "S", "C", "R", "I", "P", "T"},
        {"-", "-", "-", "-", "C", "-", "-", "-", "Y", "-"},
        {"-", "-", "-", "-", "R", "E", "A", "C", "T", "-"},
        {"-", "-", "-", "-", "I", "-", "-", "-", "H", "-"},
        {"-", "-", "-", "-", "P", "-", "-", "-", "O", "-"},
        {"-", "N", "E", "X", "T", "-", "-", "-", "N", "-"}
    }
    Dim respuestas(,) As String


    Private Sub LeerRespuestas()
        Dim i, j
        For i = 0 To 9
            For j = 0 To 9
                'Console.WriteLine("a")
                respuestas(i, j) = TextBoxArray(i, j).Text
            Next
        Next
    End Sub

    Private Sub EvaluarRespuestas()
        Dim i, j
        Dim distinto As Boolean
        For i = 0 To 9
            For j = 0 To 9
                If respuestas(i, j) <> crucigrama(i, j) Then
                    distinto = True
                End If
            Next
        Next
        If distinto Then
            MsgBox("Respuesta incorrecta")
        Else
            MsgBox("Respuesta correcta")
        End If
    End Sub

    Private Sub Crucigrama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        For i = 0 To 9
            For j = 0 To 9
                TextBoxArray(i, j) = New TextBox
                TextBoxArray(i, j).Width = TxtBoxSize
                TextBoxArray(i, j).Height = TxtBoxSize
                TextBoxArray(i, j).AutoSize = False
                TextBoxArray(i, j).MaxLength = 1
                Console.WriteLine(crucigrama(i, j))
                If crucigrama(i, j) <> "-" Then
                    Console.WriteLine("se crea una caja")
                    TextBoxArray(i, j).Location = New Point(TxtBoxSize + j * TxtBoxSize, TxtBoxSize + i * TxtBoxSize)
                    Me.Controls.Add(TextBoxArray(i, j))
                End If
            Next
        Next
    End Sub

    Private Sub ButtonValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonValidar.Click
        LeerRespuestas()
        EvaluarRespuestas()
    End Sub
End Class
