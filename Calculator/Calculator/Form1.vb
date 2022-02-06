Public Class frmCalculator
    Dim firstNum As Decimal
    Dim secondNum As Decimal
    Dim operation As Integer
    Dim opSelector As Boolean = False

    Public Sub msg_Box()
        MsgBox("Please input upto 16 numbers", MsgBoxStyle.Information, "Input")
    End Sub
    Public Sub msg_Operation()
        MsgBox("Only one operation possible at a time", MsgBoxStyle.Information, "Message")
    End Sub
    Public Sub msg_Clear()
        MsgBox("Clear the Output first", MsgBoxStyle.Information, "Message")
    End Sub

    Public Sub btn_common_func()
        firstNum = txtDisplay.Text
        txtOutput.Text = txtDisplay.Text
        txtDisplay.Text = "0"
        opSelector = True
    End Sub
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click

        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else

            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "1"
            Else
                txtDisplay.Text = "1"
            End If
        End If

    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click

        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "2"
            Else
                txtDisplay.Text = "2"
            End If
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "3"
            Else
                txtDisplay.Text = "3"
            End If
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "4"
            Else
                txtDisplay.Text = "4"
            End If
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "5"
            Else
                txtDisplay.Text = "5"
            End If
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "6"
            Else
                txtDisplay.Text = "6"
            End If
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "7"
            Else
                txtDisplay.Text = "7"
            End If
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "8"
            Else
                txtDisplay.Text = "8"
            End If
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "9"
            Else
                txtDisplay.Text = "9"
            End If
        End If
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If txtDisplay.Text.Length >= 16 Then

            msg_Box()
        Else
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text = txtDisplay.Text + "0"

            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        txtOutput.Text = ""
        txtSign.Text = ""
    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.MaxLength = 0
    End Sub


    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (txtSign.Text.Contains("=")) Then
            If Not (txtSign.Text.Contains("+") Or txtSign.Text.Contains("-") Or txtSign.Text.Contains("*") Or txtSign.Text.Contains("/") Or txtSign.Text.Contains("%")) Then
                btn_common_func()
                operation = 1
                txtSign.Text = "+"
            Else
                msg_Operation()
            End If
        Else
            msg_Clear()
        End If

       


    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        If Not (txtSign.Text.Contains("=")) Then
            If Not (txtSign.Text.Contains("-") Or txtSign.Text.Contains("+") Or txtSign.Text.Contains("*") Or txtSign.Text.Contains("/") Or txtSign.Text.Contains("%")) Then
                btn_common_func()
                operation = 2
                txtSign.Text = "-"

            Else
                msg_Operation()
            End If
        Else
            msg_Clear()
        End If
      

    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        If Not (txtSign.Text.Contains("=")) Then
            If Not (txtSign.Text.Contains("*") Or txtSign.Text.Contains("-") Or txtSign.Text.Contains("+") Or txtSign.Text.Contains("/") Or txtSign.Text.Contains("%")) Then
                btn_common_func()
                operation = 3
                txtSign.Text = "*"
            Else
                msg_Operation()
            End If
        Else
            msg_Clear()
        End If

        


    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        If Not (txtSign.Text.Contains("=")) Then
            If Not (txtSign.Text.Contains("/") Or txtSign.Text.Contains("-") Or txtSign.Text.Contains("+") Or txtSign.Text.Contains("*") Or txtSign.Text.Contains("%")) Then
                btn_common_func()
                operation = 4
                txtSign.Text = "/"
            Else
                msg_Operation()
            End If
        Else
            msg_Clear()
        End If
       


    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If Not (txtSign.Text.Contains("=")) Then
            If Not (txtSign.Text.Contains("%") Or txtSign.Text.Contains("-") Or txtSign.Text.Contains("+") Or txtSign.Text.Contains("*") Or txtSign.Text.Contains("/")) Then
                btn_common_func()
                operation = 5
                txtSign.Text = "%"
            Else
                msg_Operation()
            End If
        Else
            msg_Clear()
        End If
      


    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If opSelector = True Then
            secondNum = txtDisplay.Text
            txtSign.Text = "="
            If operation = 1 Then
                txtOutput.Text = firstNum + secondNum
            ElseIf operation = 2 Then
                txtOutput.Text = firstNum - secondNum
            ElseIf operation = 3 Then
                txtOutput.Text = firstNum * secondNum
            ElseIf operation = 4 Then
                If secondNum = 0 Then
                    txtOutput.Text = "Error!"
                Else
                    txtOutput.Text = firstNum / secondNum
                End If

            ElseIf operation = 5 Then
                If secondNum = 0 Then
                    txtOutput.Text = "Error!"
                Else
                    txtOutput.Text = firstNum Mod secondNum
                End If

            End If
            opSelector = False
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      

            If txtDisplay.Text > "0" Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
            If txtDisplay.Text = "" Then
                txtDisplay.Text = "0"
            End If
        Else
            txtDisplay.Text = "0"
        End If


    End Sub
End Class
