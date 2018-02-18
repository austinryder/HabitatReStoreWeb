Public Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub imgbLogo_Click(sender As Object, e As ImageClickEventArgs) Handles imgbLogo.Click
        Server.Transfer("Home.aspx", True)
    End Sub
End Class