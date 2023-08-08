Set fso = CreateObject("Scripting.FileSystemObject")
Set inputFile = fso.OpenTextFile("students.csv", 1, False)

Dim studentGrades
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

For Each studentName In studentGrades
    grades = studentGrades(studentName)
    gradeList = Join(grades, ", ")
    WScript.Echo studentName & ": " & gradeList
Next
