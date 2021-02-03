Public Class DatuSortzailea
    Private Shared FakturenZenbatekoakEtaBEZMotak =
        New Double(,) {{2500, 10}, {3150.55, 21}, {25000, 10}, {315.35, 4}}
    Public Shared DatuSortzaileaInstance As DatuSortzailea
    'method for creating the instance of the class
    'return DatuSortzaileaInstance DatuSortzailea
    Public Shared Function getInstance() As DatuSortzailea
        If (DatuSortzaileaInstance Is Nothing) Then
            DatuSortzaileaInstance = New DatuSortzailea()
        End If
        Return DatuSortzaileaInstance
    End Function
    Private Sub New()

    End Sub
    'Method for getting the total payment for the selected bill
    'Param FakturarenKodea Integer
    'return FakturarenTotala Double
    Public Function FakturarenTotala(ByVal FakturarenKodea As Integer) As Double
        Try
            FakturarenTotala = FakturenZenbatekoakEtaBEZMotak(FakturarenKodea - 1, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Method for retrieving the VAT for the selected bill
    'Param FakturarenKodea Integer
    'return FakturarenBEZMota Integer
    Public Function FakturarenBEZMota(ByVal FakturarenKodea As Integer) As String
        If (FakturenZenbatekoakEtaBEZMotak(FakturarenKodea - 1, 1) = 21) Then
            FakturarenBEZMota = "orokorra"
        ElseIf (FakturenZenbatekoakEtaBEZMotak(FakturarenKodea - 1, 1) = 10) Then
            FakturarenBEZMota = "murriztua"
        Else
            FakturarenBEZMota = "oinarrizko produktua"
        End If
    End Function
End Class
