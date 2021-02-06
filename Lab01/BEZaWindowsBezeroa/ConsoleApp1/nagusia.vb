Module nagusia

    Sub Main()
        While True
            Try
                'Console.Clear()
                Dim ordainduBeharrekoa As Double
                Dim BEZaMota As String
                Console.WriteLine("Sartu ordaindu beharrekoa")
                ordainduBeharrekoa = Console.ReadLine()
                Console.WriteLine("Sartu BEZa mota:(orokorra, murriztua,oinarrizko produktua)")
                BEZaMota = Console.ReadLine()
                Console.WriteLine(ordainduBeharrekoa)
                Dim K As New BEZaren_Kalkulua_DDL.BEZKalkulatu(BEZaMota, ordainduBeharrekoa)
                Console.WriteLine("Ordaindu Beharrekoa: " & Format(ordainduBeharrekoa, ".##"))
                Console.WriteLine("BEZa mota: " + BEZaMota)
                Console.WriteLine("Totala BEZa gabe: " & Format(K.TotalaBEZikGabe(), ".##"))
                Console.WriteLine("BEZa: " & Format(K.BEZa(), ".##"))
                Console.WriteLine("Berriro kalkulatu nahi duzu?(y/n)")
                Dim continueCalculating As String = Console.ReadLine()
                If continueCalculating.Equals("n") Then
                    Exit While
                End If
            Catch ex As Exception
                Console.WriteLine("Kopuru desegokia")
            End Try
        End While
    End Sub

End Module
