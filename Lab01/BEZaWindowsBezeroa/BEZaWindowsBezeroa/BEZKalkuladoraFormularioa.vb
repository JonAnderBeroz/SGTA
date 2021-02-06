Public Class Form1
    Private Sub kalkulatuBEZa_Click(sender As Object, e As EventArgs) Handles kalkulatuBEZa.Click
        Try
            If TextBox1.Text() < 0 Then
                MsgBox("Ordaindu beharreko balioa ez da zuzena")
            Else
                Dim K As New BEZaren_Kalkulua_DDL.BEZKalkulatu(ComboBox1.SelectedItem.ToString(), TextBox1.Text())
                ordainduBeharrekoa.Text = "Ordaindu beharrekoa: " + TextBox1.Text()
                BEZaMota.Text = "BEZ mota: " + ComboBox1.SelectedItem.ToString()
                totalaBEZaGabe.Text = "Totala BEZa gabe: " + Format(K.TotalaBEZikGabe(), ".##")
                BEZa.Text = "BEZa: " + Format(K.BEZa(), ".##")
            End If
        Catch ex As Exception
            MsgBox("Ordaindu beharreko balioa ez da zuzena")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("orokorra")
        ComboBox1.Items.Add("murriztua")
        ComboBox1.Items.Add("oinarrizko produktua")
        ComboBox1.SelectedIndex = 0
    End Sub
End Class
