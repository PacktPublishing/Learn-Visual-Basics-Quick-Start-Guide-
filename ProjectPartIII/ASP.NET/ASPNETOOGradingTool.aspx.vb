Imports System.IO

Public Class ASPNETOOGradingTool
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim filePath As String = "students.csv"
        Dim studentGrades As New Dictionary(Of String, List(Of clsGrade))()

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
                            studentGrades(studentName).Add(New clsTestGrade(score, fields(3).Trim()))
                        Case "Quiz"
                            studentGrades(studentName).Add(New clsQuizGrade(score, fields(3).Trim()))
                        Case "HW"
                            studentGrades(studentName).Add(New clsHWGrade(score, fields(3).Trim()))
                    End Select


                End If
            End While
        End Using

        For Each studentName As String In studentGrades.Keys
            Dim testtotal, testcnt, quiztotal, quizcnt, hwtotal, hwcnt As Integer
            Dim grades As List(Of clsGrade) = studentGrades(studentName)
            For Each eagrade As clsGrade In grades
                If TypeOf eagrade Is clsTestGrade Then
                    testtotal += eagrade.Score
                    testcnt += 1
                ElseIf TypeOf eagrade Is clsQuizGrade Then
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

            Response.Write(studentName & ": Test Avg:" & testavg.ToString("N1") &
                 " Quiz Avg:" & quizavg.ToString("N1") &
                 " HW Avg:" & hwavg.ToString("N1") & "</br>")

        Next

    End Sub

End Class