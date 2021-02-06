Public Class BEZKalkulu_DatuSortzaileaz
    Private BK As BEZaren_Kalkulua_DDL.BEZKalkulatu
    Private DG As DatuGeruza.DatuSortzailea
    Public Sub New(ByVal FakturaKodea As Integer)
        Try
            DG = DatuGeruza.DatuSortzailea.getInstance()
            Dim FakturarenTotala As Double = DG.FakturarenTotala(FakturaKodea)
            Dim FakturarenBEZMota As String = DG.FakturarenBEZMota(FakturaKodea)
            BK = New BEZaren_Kalkulua_DDL.BEZKalkulatu(FakturarenBEZMota, FakturarenTotala)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'get the total after the VAT has been retrieved
    'return TotalaBEZikGabe Double
    Public Function TotalaBEZikGabe() As Double
        TotalaBEZikGabe = BK.TotalaBEZikGabe()
    End Function
    ' gets the VAT quantity for the total of the bill
    ' return BEZa Double
    Public Function BEZa() As Double
        BEZa = BK.BEZa()
    End Function

    Public Function OrdainduBeharrekoa(ByVal FakturaKodea As Integer) As Double
        OrdainduBeharrekoa = DG.FakturarenTotala(FakturaKodea)
    End Function

    Public Function BEZaMota(ByVal FakturaKodea As Integer) As String
        BEZaMota = DG.FakturarenBEZMota(FakturaKodea)
    End Function
End Class
