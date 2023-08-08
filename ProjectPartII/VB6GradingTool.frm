Option Explicit
Dim studentGrades As Object
Sub ReadCSVFile()
    Dim filePath As String
    Dim fileNum As Integer
    Dim line As String
    Dim fields() As String
    Dim studentName As String
    Dim grade As String
    
    filePath = "students.csv"
    Set studentGrades = CreateObject("Scripting.Dictionary")
    
    fileNum = FreeFile
    Open filePath For Input As fileNum
    
    Do Until EOF(fileNum)
        Line Input #fileNum, line
        fields = Split(line, ",")
        
        If UBound(fields) = 1 Then
            studentName = Trim(fields(0))
            grade = Trim(fields(1))
            
            If Not studentGrades.Exists(studentName) Then
                studentGrades.Add studentName, New Collection
            End If
            
            studentGrades(studentName).Add grade
        End If
    Loop
    
    Close fileNum
    
    Dim student As Variant
    For Each student In studentGrades.Keys
        studentName = student
        gradeList = GetGradeList(studentName)
        Debug.Print studentName & ": " & gradeList
    Next student
End Sub

Function GetGradeList(ByVal studentName As String) As String
    Dim gradeList As String
    Dim grades As Collection
    Set grades = studentGrades.Item(studentName)
    
    Dim grade As Variant
    For Each grade In grades
        gradeList = gradeList & grade & ", "
    Next grade
    
    If Len(gradeList) > 0 Then
        gradeList = Left(gradeList, Len(gradeList) - 2) 
    End If
    
    GetGradeList = gradeList
End Function
Private Sub Form_Load()
  ReadCSVFile
End Sub