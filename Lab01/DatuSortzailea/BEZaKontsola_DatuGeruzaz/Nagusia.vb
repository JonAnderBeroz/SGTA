Module Nagusia

    Sub Main()
        While True
            Try
                Console.WriteLine("Sartu fakturaren zenbakia")
                Dim fakturaZenbakia As Integer = Console.ReadLine()
                Dim BEZKDG_DLL As New BEZaren_Kalkulua_DatuGeruzaz_DLL.BEZKalkulu_DatuSortzaileaz(fakturaZenbakia)
                Console.WriteLine("Totala: " & BEZKDG_DLL.OrdainduBeharrekoa(fakturaZenbakia))
                Console.WriteLine("BEZa mota: " + BEZKDG_DLL.BEZaMota(fakturaZenbakia))
                Console.WriteLine("Totala BEZa gabe:" & BEZKDG_DLL.TotalaBEZikGabe())
                Console.WriteLine("BEZa-ren kopurua: " & BEZKDG_DLL.BEZa())
                Console.WriteLine("Fakturak ikusten jarraitu nahi duzu?(y/n)")
                Dim continueLooking As String = Console.ReadLine()
                If (Not continueLooking.Equals("y")) Then
                    Exit While
                End If
            Catch e As Exception
                Console.WriteLine("Faktura zenbakia okerra da")
            End Try
        End While
    End Sub

End Module
