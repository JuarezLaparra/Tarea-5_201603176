Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Desea salir de la aplicación", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fac As Long = 1
        Dim i As Long
        Dim a As Integer = Int32.Parse(TextBox1.Text)
        Dim resul As String = ""
        Dim res As Integer = 0

        While (a >= 0)
            If (a Mod 4 = 0) Then

                If IsNumeric(TextBox1.Text) Then
                    For i = CDbl(TextBox1.Text) To 1 Step -1
                        fac *= i
                    Next i
                    TextBox2.Text = fac.ToString
                End If
                TextBox3.Text = TextBox3.Text + a.ToString + ","
                TextBox3.Text = TextBox3.Text + 1

            End If
        End While



    End Sub
End Class
