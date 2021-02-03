Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BEZaKalkulatuButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BEZaKalkulatuButton.Click
        Dim k As New BEZaren_Kalkulua_DDL.BEZKalkulatu(lstBEZMota.SelectedValue, ordainduBeharrekoaInput.Text)
        ordainduBeharrekoaLabel2.Text = ordainduBeharrekoaInput.Text
        BEZaMota2.Text = lstBEZMota.SelectedValue
        totalaBEZaGabe.Text = k.TotalaBEZikGabe()
        BEZa.Text = k.BEZa()
    End Sub
End Class