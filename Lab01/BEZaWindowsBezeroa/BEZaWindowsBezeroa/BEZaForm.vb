Imports BEZ
Public Class BEZaForm


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbBEZ.SelectionChangeCommitted
        Dim prezioa As Double
        Dim beztotal As Double
        Dim sinbez As Double
        If (Me.txtPrecioProd.Text.Equals("")) Then
            MsgBox("Eres tonto")
        Else
            Try
                prezioa = Me.txtPrecioProd.Text()
                Dim dllBEZ As New BEZaren_Kalkulua_DDL.BEZKalkulatu(Me.cbBEZ.SelectedItem, prezioa)
                sinbez = dllBEZ.BEZa()
                beztotal = dllBEZ.TotalaBEZikGabe()
                Me.txtSinBEZ.Text = Format(sinbez, ".##")
                Me.txtConBEZ.Text = Format(beztotal, ".##")
                prezioa = Me.txtPrecioProd.Text
            Catch ex As Exception
                MsgBox("Eres tonto" + ex.Message)
            End Try

        End If

    End Sub
End Class
