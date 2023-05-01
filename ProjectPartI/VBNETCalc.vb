Imports System

Module Program
    Sub Main(args As String())
        Dim n1, n2, oper As String
        Dim res As String = ""
        Dim sentinel As String = False
        Do
            Console.WriteLine("Enter the first number or X to quit:")
            n1 = Console.ReadLine()
            If n1 = "X" Then
                sentinel = True
            Else
                Console.WriteLine("Enter the second number:")
                n2 = Console.ReadLine()
                Console.WriteLine("Enter the operator (+, -, *, /):")
                oper = Console.ReadLine()

                Select Case oper
                    Case "+"
                        res = CInt(n1) + CInt(n2)
                    Case "-"
                        res = n1 - n2
                    Case "*"
                        res = n1 * n2
                    Case "/"
                        If n2 = 0 Then
                            Console.WriteLine("Cannot divide by zero!")
                        Else
                            res = n1 / n2
                        End If
                    Case Else
                        Console.WriteLine("Invalid operator!")
                End Select
                Console.WriteLine("The result is: " & res)
            End If
        Loop While Not sentinel = True
    End Sub
End Module
