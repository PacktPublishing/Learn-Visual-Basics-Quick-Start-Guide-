<%
Dim fso, inputFile, studentGrades, line, fields, studentName, grade, grades, gradeList

Set fso = Server.CreateObject("Scripting.FileSystemObject")
Set inputFile = fso.OpenTextFile(Server.MapPath("students.csv"), 1, False)

Set studentGrades = Server.CreateObject("Scripting.Dictionary")

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
    Response.Write studentName & ": " & gradeList & "<br>"
Next
%>
