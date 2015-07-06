Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a As New CategoryDA()

        Response.Write(a.allCategories.ToArray()(0).Description)
        Response.Write("<br />")
        Response.Write(a.allCategories.ToArray()(1).Description)
        Response.Write("<br />")
        Response.Write(a.allCategories.ToArray()(2).Description)
    End Sub

End Class