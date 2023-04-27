Option Explicit

Dim n1, n2, res, operator,sentinel
sentinel = False
Do 
  n1 = InputBox("Enter the first number or X to quit:")
  If n1 = "X" Then
    sentinel = True
  Else
    n2 = InputBox("Enter the second number:")

    operator = InputBox("Enter the operator (+, -, *, /):")

    Select Case operator
      Case "+"
        res = CInt(n1) + CInt(n2)
      Case "-"
        res = n1 - n2
      Case "*"
        res = n1 * n2
      Case "/"
        If n2 = 0 Then
            MsgBox("Cannot divide by zero!")
        Else
            res = num1 / num2
        End If
      Case Else
        MsgBox("Invalid operator!")
    End Select
    MsgBox("The result is: " & res)
  End If
Loop While Not sentinel
