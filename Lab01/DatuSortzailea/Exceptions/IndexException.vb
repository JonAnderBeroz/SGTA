Public Class IndexException
    Inherits ApplicationException

    Public Sub New(Optional ByVal Mezua As String = "Faktura zenbakia ez da existitzen")
        MyBase.New(Mezua)
    End Sub

End Class
