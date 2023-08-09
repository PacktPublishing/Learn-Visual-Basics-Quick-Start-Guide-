Imports System.IO

Module Module1

    Sub Main()

        Dim filePath As String = "..\..\students.csv"
        Dim studentGrades As New Dictionary(Of String, List(Of Grade))()

        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(",")

                If fields.Length = 4 Then
                    Dim studentName As String = fields(0).Trim()
                    If Not studentGrades.ContainsKey(studentName) Then
                        studentGrades.Add(studentName, New List(Of Grade)())
                    End If
                    Dim score As String = fields(1).Trim()
                    Dim category As String = fields(2).Trim()
                    Select Case category
                        Case "Test"
                            studentGrades(studentName).Add(New TestGrade(score, fields(3).Trim()))
                        Case "Quiz"
                            studentGrades(studentName).Add(New QuizGrade(score, fields(3).Trim()))
                        Case "HW"
                            studentGrades(studentName).Add(New HWGrade(score, fields(3).Trim()))
                    End Select


                End If
            End While
        End Using

        For Each studentName As String In studentGrades.Keys
            Dim testtotal, testcnt, quiztotal, quizcnt, hwtotal, hwcnt As Integer
            Dim grades As List(Of Grade) = studentGrades(studentName)
            For Each eagrade As Grade In grades
                If TypeOf eagrade Is TestGrade Then
                    testtotal += eagrade.Score
                    testcnt += 1
                ElseIf TypeOf eagrade Is QuizGrade Then
                    quiztotal += eagrade.Score
                    quizcnt += 1
                Else
                    hwtotal += eagrade.Score
                    hwcnt += 1
                End If
            Next
            Dim testavg, quizavg, hwavg As Double
            If testcnt > 0 Then
                testavg = testtotal / testcnt
            End If
            If quizcnt > 0 Then
                quizavg = quiztotal / quizcnt
            End If
            If hwcnt > 0 Then
                hwavg = hwtotal / hwcnt
            End If

            Console.WriteLine(studentName & ": Test Avg:" & testavg.ToString("N1") &
                 " Quiz Avg:" & quizavg.ToString("N1") &
                 " HW Avg:" & hwavg.ToString("N1"))

        Next

        Console.ReadLine()
    End Sub

End Module
