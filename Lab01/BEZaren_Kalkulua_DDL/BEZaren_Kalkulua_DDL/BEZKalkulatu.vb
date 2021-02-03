Public Class BEZKalkulatu
    Private BEZMota As String
    Private OrdainduBeharrekoa
    Public Sub New(ByVal bezMota As String, ByVal ordainduBeharrekoa As Double)
        Me.BEZMota = bezMota
        Me.OrdainduBeharrekoa = ordainduBeharrekoa
    End Sub

    Public Function BEZa() As Double
        If Me.BEZMota.Equals("orokorra") Then
            BEZa = Me.OrdainduBeharrekoa * 0.21
        ElseIf Me.BEZMota.Equals("murriztua") Then
            BEZa = Me.OrdainduBeharrekoa * 0.1
        ElseIf Me.BEZMota.Equals("oinarrizko produktua") Then
            BEZa = Me.OrdainduBeharrekoa * 0.04
        Else
            BEZa = 0
        End If
    End Function

    Public Function TotalaBEZikGabe() As Double
        TotalaBEZikGabe = OrdainduBeharrekoa - Me.BEZa
    End Function
End Class
