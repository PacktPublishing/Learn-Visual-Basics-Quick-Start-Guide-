Attribute VB_Name = "Module1"
Option Explicit

Sub ReadCSVFile()
    Dim fso As Object
    Dim inputFile As Object
    Dim studentGrades As Object
    Dim line As String
    Dim fields() As String
    Dim studentName As String
    Dim grade As String
    Dim grades() As String
    Dim gradeList As String
    
    Set fso = CreateObject("Scripting.FileSystemObject")
    Set inputFile = fso.OpenTextFile("students.csv", 1, False)
    Set studentGrades = CreateObject("Scripting.Dictionary")
    
    Do Until inputFile.AtEndOfStream
        line = inputFile.ReadLine
        fields = Split(line, ",")
        
        If UBound(fields) = 1 Then
            studentName = Trim(fields(0))
            grade = Trim(fields(1))
            
            If Not studentGrades.Exists(studentName) Then
                studentGrades.Add studentName, Array(grade)
            Else
                grades = studentGrades(studentName)
                ReDim Preserve grades(UBound(grades) + 1)
                grades(UBound(grades)) = grade
                studentGrades(studentName) = grades
            End If
        End If
    Loop
    
    inputFile.Close
    
    For Each studentName In studentGrades.Keys
        grades = studentGrades(studentName)
        gradeList = Join(grades, ", ")
        Debug.Print studentName & ": " & gradeList
    Next studentName
End Sub
