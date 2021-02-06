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
                Dim dllBEZ As New BEZ.BEZkalkulatu(Me.cbBEZ.SelectedItem, prezioa)
                sinbez = dllBEZ.BEZa()
                beztotal = dllBEZ.TotalaBEZikGabe()
                'Dim bezmota As Double


                'MsgBox(Me.cbBEZ.SelectedIndex)

                'If (Me.cbBEZ.SelectedIndex = 0) Then
                '    'orokorra
                '    bezmota = 1.21
                'ElseIf (Me.cbBEZ.SelectedIndex = 1) Then
                '    'murriztua
                '    bezmota = 1.1
                'ElseIf (Me.cbBEZ.SelectedIndex = 2) Then
                '    'produktuarena
                '    bezmota = 1.04
                'Else
                '    bezmota = 1
                'End If

                'prezioa = Me.txtPrecioProd.Text
                'MsgBox(prezioa)

                'sinbez = prezioa / bezmota
                Me.txtSinBEZ.Text = Format(sinbez, ".##")
                'beztotal = prezioa - sinbez
                Me.txtConBEZ.Text = Format(beztotal, ".##")
                prezioa = Me.txtPrecioProd.Text
            Catch ex As Exception
                MsgBox("Eres tonto")
            End Try

        End If

    End Sub

End Class
