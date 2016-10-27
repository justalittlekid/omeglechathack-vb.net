Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Based on https://github.com/indrajeetb 
        Dim chars2use As String = "abcdef"

        Dim sb As New StringBuilder()
        Dim rand1 As New Random()
        For i As Integer = 1 To 1
            Dim idx As Integer = rand1.Next(0, chars2use.Length)
            Dim randomChar As Char = chars2use(idx)
            sb.Append(randomChar)

            Dim rand As New Random()
            Dim number = rand.Next(1111, 99999) & randomChar & ".png"

            Process.Start("http://l.omegle.com/" & number)


        Next i


        Dim randomString = sb.ToString()
    End Sub

End Class
