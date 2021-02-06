Imports BEZ
Public Class BEZWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Solbutton_Click(sender As Object, e As EventArgs) Handles Solbutton.Click
        Dim dirua As Double
        Dim BEZmota As String
        Dim sinbez As Double
        Dim beztotal As Double
        BEZmota = Me.DropDownBEZmota.SelectedItem.Text
        dirua = Me.txtDirua.Text
        Dim ddlBEZ As New BEZaren_Kalkulua_DDL.BEZKalkulatu(BEZmota, dirua)
        sinbez = Format(ddlBEZ.BEZa(), ".##")
        beztotal = Format(ddlBEZ.TotalaBEZikGabe(), ".##")

        Me.txtBEZgabe.Text = sinbez
        Me.txtBEZa.Text = beztotal
    End Sub
End Class