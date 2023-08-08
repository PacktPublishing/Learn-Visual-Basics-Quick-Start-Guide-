Imports System.IO
Imports System.Collections.Generic

Module MainModule
    Sub Main()
        Dim filePath As String = "students.csv"
        Dim studentGrades As New Dictionary(Of String, List(Of String))()

        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(","c)

                If fields.Length = 2 Then
                    Dim studentName As String = fields(0).Trim()
                    Dim grade As String = fields(1).Trim()

                    If Not studentGrades.ContainsKey(studentName) Then
                        studentGrades.Add(studentName, New List(Of String)())
                    End If

                    studentGrades(studentName).Add(grade)
                End If
            End While
        End Using

        For Each studentName As String In studentGrades.Keys
            Dim grades As List(Of String) = studentGrades(studentName)
            Dim gradeList As String = String.Join(", ", grades)
            Console.WriteLine(studentName & ": " & gradeList)
        Next

        Console.ReadLine()
    End Sub
End Module
