<!DOCTYPE html>
<html>
<body>
<form method="get">
Enter the first number: <input name="n1">
Enter the second number: <input name="n2">
Enter the operator: 
<select name="operator">
<option value="+">+</option>
<option value="-">-</option>
<option value="*">*</option>
<option value="/">/</option>
</select>
<input type="submit">
</form>
<%
Dim n1, n2, res, operator
n1 = Request.QueryString("n1")
n2 = Request.QueryString("n2")
operator = Request.QueryString("operator")
Select Case operator
  Case "+"
    res = CInt(n1) + CInt(n2)
  Case "-"
    res = n1 - n2
  Case "*"
    res = n1 * n2
  Case "/"
    If n2 = 0 Then
        Response.Write("Cannot divide by zero!")
    Else
        res = num1 / num2
    End If
End Select
If len(n1) > 0 then
  Response.Write("The result is: " & res)
End if  
%>
</body>
</html>