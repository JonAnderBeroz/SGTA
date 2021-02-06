Public Class kopuruDesegokiaException
    Inherits ApplicationException

    Public Sub New(Optional ByVal mezua As String = "Sartutako kopurua okerra da")
        MyBase.New(mezua)
    End Sub
End Class
