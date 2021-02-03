Module nagusia

    Sub Main()
        While True
            'Console.Clear()
            Dim ordainduBeharrekoa As Double
            Dim BEZaMota As String
            Console.WriteLine("Sartu ordaindu beharrekoa")
            ordainduBeharrekoa = Console.ReadLine()
            Console.WriteLine("Sartu BEZa mota:(orokorra, murriztua,oinarrizko produktuena)")
            BEZaMota = Console.ReadLine()
            Dim K As New BEZaren_Kalkulua_DDL.BEZKalkulatu(BEZaMota, ordainduBeharrekoa)
            Console.WriteLine("Ordaindu Beharrekoa: " & ordainduBeharrekoa)
            Console.WriteLine("BEZa mota: " + BEZaMota)
            Console.WriteLine("Totala BEZa gabe: " & K.TotalaBEZikGabe())
            Console.WriteLine("BEZa: " & K.BEZa())
            Console.WriteLine("Berriro kalkulatu nahi duzu?(y/n)")
            Dim continueCalculating As String = Console.ReadLine()
            If continueCalculating.Equals("n") Then
                Exit While
            End If
        End While
    End Sub

End Module
