Public Class ASPENTCalc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim n1, n2, oper As String
        Dim res As String = ""
        n1 = Request.Form("n1")
        n2 = Request.Form("n2")
        oper = Request.Form("oper")
        If Not n1 Is Nothing Then
            Select Case oper
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
                        res = n1 / n2
                    End If
            End Select
            If Len(n1) > 0 Then
                Response.Write("The result is: " & res)
            End If
        End If
    End Sub

End Class