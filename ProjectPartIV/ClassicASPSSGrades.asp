<FORM>
<INPUT name="grade"/>
<INPUT type="submit" value="Add Grade"/>
</FORM>
<%
if Request("grade").Count > 0 Then
	Session("Total") = Session("Total") + CInt(Request("grade"))
	Session("Cnt") = Session("Cnt") + 1
	response.write("Grade Average: ")
	response.write(Session("Total") / Session("Cnt"))
End If
%>