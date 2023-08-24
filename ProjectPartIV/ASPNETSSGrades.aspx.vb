Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("Total") += CInt(tbGrade.Text)
        Session("Cnt") += 1
        lblAverage.Text = "Grade Average: " & Session("Total") / Session("Cnt")
    End Sub
End Class