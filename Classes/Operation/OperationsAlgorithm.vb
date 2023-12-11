Friend Class OperationsAlgorithm
    Private Shared _rand As New Random()

    Public Shared Function GenerarVectorDouble(Optional ByVal Minon As Integer = 0, Optional ByVal Lenght As Integer = 10, Optional ByVal values As Integer = 5) As Double()
        Dim _List As New List(Of Double)()

        For i As Integer = Minon To Lenght - 1
            If i < values Then
                Dim NewValor As Double = _rand.NextDouble()
                _List.Add(NewValor)
            Else
                Exit For
            End If
        Next
        Return _List.ToArray()
    End Function

    Public Shared Function GenerarVector(Optional ByVal Minon As Integer = 0, Optional ByVal Lenght As Integer = 10, Optional ByVal values As Integer = 5) As Integer()
        Dim _List As New List(Of Integer)()

        For i As Integer = Minon To Lenght - 1
            If i < values Then
                Dim NewValor As Integer = _rand.Next(Minon, Lenght + 1)
                If _List.Contains(NewValor) Then
                    i -= 1
                    Continue For
                End If
                _List.Add(NewValor)
            Else
                Exit For
            End If
        Next
        Return _List.ToArray()
    End Function
End Class
