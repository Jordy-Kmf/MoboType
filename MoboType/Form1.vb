'MoboType v1.0
'
'
Public Class Form1
    Dim inp As String
    Dim inpLen As Integer
    Dim y As Integer = 1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        bxNum.Clear()
        inp = bxAlpha.Text.ToLower
        inpLen = inp.Length

        For x = 0 To inpLen - 1
            'Send to main func
            catchInp(inp.Substring(x, y))
            bxNum.AppendText(".")
        Next
        bxNum.Text.Remove(bxNum.TextLength - 2, 1)
    End Sub

    Public Function catchInp(w As String)
        Dim two() = {"a", "b", "c"}
        Dim three() = {"d", "e", "f"}
        Dim four() = {"g", "h", "i"}
        Dim five() = {"j", "k", "l"}
        Dim six() = {"m", "n", "o"}
        Dim seven() = {"p", "q", "r", "s"}
        Dim eight() = {"t", "u", "v"}
        Dim nine() = {"w", "x", "y", "z"}

        '3 elements
        If two.Contains(w) Or three.Contains(w) Or four.Contains(w) Or five.Contains(w) Or six.Contains(w) Or eight.Contains(w) Then
            For i = 0 To 2
                If w = two(i) Then
                    Dim index As Int32 = Array.IndexOf(two, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("2")
                    Next

                ElseIf w = three(i) Then
                    Dim index As Int32 = Array.IndexOf(three, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("3")
                    Next

                ElseIf w = four(i) Then
                    Dim index As Int32 = Array.IndexOf(four, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("4")
                    Next

                ElseIf w = five(i) Then
                    Dim index As Int32 = Array.IndexOf(five, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("5")
                    Next

                ElseIf w = six(i) Then
                    Dim index As Int32 = Array.IndexOf(six, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("6")
                    Next

                ElseIf w = eight(i) Then
                    Dim index As Int32 = Array.IndexOf(eight, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("8")
                    Next
                End If
            Next

        ElseIf seven.Contains(w) Or nine.Contains(w) Then
            '4 elements
            For i = 0 To 3
                If w = seven(i) Then
                    Dim index As Int32 = Array.IndexOf(seven, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("7")
                    Next

                ElseIf w = nine(i) Then
                    Dim index As Int32 = Array.IndexOf(nine, w)
                    For j = 1 To index + 1
                        bxNum.AppendText("9")
                    Next
                End If
            Next

        ElseIf w = " " Then
            bxNum.AppendText("0")
        End If

        Return 0
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "Clear Num" Then
            bxNum.Clear()
        Else bxAlpha.Clear()
        End If
    End Sub

    Private Sub bxNum_Click(sender As Object, e As EventArgs) Handles bxNum.Click
        btnClear.Text = "Clear Num"
    End Sub

    Private Sub bxAlpha_Click(sender As Object, e As EventArgs) Handles bxAlpha.Click
        btnClear.Text = "Clear Alpha"
    End Sub

    Private Sub bxNum_TextChanged(sender As Object, e As EventArgs) Handles bxNum.TextChanged
        lblNC.Text = bxNum.TextLength - bxAlpha.TextLength
    End Sub

    Private Sub bxAlpha_TextChanged(sender As Object, e As EventArgs) Handles bxAlpha.TextChanged
        lblAR.Text = 1000 - bxAlpha.TextLength
        lblAL.Text = bxAlpha.TextLength
    End Sub

    Private Sub lblAR_Click(sender As Object, e As EventArgs) Handles lblAR.Click
        lblAR.Hide()
        lblAL.Show()
    End Sub

    Private Sub lblAL_Click(sender As Object, e As EventArgs) Handles lblAL.Click
        lblAL.Hide()
        lblAR.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
