Public Class Node(Of T)
    Implements IComparable(Of Node(Of T))

    Public Property NextNode As Node(Of T)
    Public Property Data As T

    Public Sub New(d As T)
        Data = d
        NextNode = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return $"Data: {Data}"
    End Function

    Public Function CompareTo(otroNodo As Node(Of T)) As Integer Implements IComparable(Of Node(Of T)).CompareTo
        ' Case 1: Both types are numeric
        If EsNumero(Data) AndAlso EsNumero(otroNodo.Data) Then
            Dim valor1 As Long = Convert.ToInt64(Data)
            Dim valor2 As Long = Convert.ToInt64(otroNodo.Data)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 2: Only the data of the comparing node is numeric
        If EsNumero(Data) AndAlso (TypeOf otroNodo.Data Is String OrElse TypeOf otroNodo.Data Is Char) Then
            Dim valor1 As Long = Convert.ToInt64(Data)
            Dim valor2 As Long = Convert.ToInt64(otroNodo.Data.ToString().Length)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 3: Only the data of the node to compare is numeric
        If EsNumero(otroNodo.Data) AndAlso (TypeOf Data Is String OrElse TypeOf Data Is Char) Then
            Dim valor1 As Long = Convert.ToInt64(Data.ToString().Length)
            Dim valor2 As Long = Convert.ToInt64(otroNodo.Data)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 4: They are different types that can be compared
        If TypeOf Data Is IComparable AndAlso TypeOf otroNodo.Data Is IComparable Then
            Dim comparableData As IComparable = DirectCast(Data, IComparable)
            Dim comparableOtherData As IComparable = DirectCast(otroNodo.Data, IComparable)
            Return comparableData.ToString().Length.CompareTo(comparableOtherData.ToString().Length)
        End If

        Return 0
    End Function

    Public Function CompareTo(otroData As T) As Integer
        ' Case 1: Both types are numeric
        If EsNumero(Data) AndAlso EsNumero(otroData) Then
            Dim valor1 As Long = Convert.ToInt64(Data)
            Dim valor2 As Long = Convert.ToInt64(otroData)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 2: Only the data of the comparing node is numeric
        If EsNumero(Data) AndAlso (TypeOf otroData Is String OrElse TypeOf otroData Is Char) Then
            Dim valor1 As Long = Convert.ToInt64(Data)
            Dim valor2 As Long = Convert.ToInt64(otroData.ToString().Length)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 3: Only the data of the node to compare is numeric
        If EsNumero(otroData) AndAlso (TypeOf Data Is String OrElse TypeOf Data Is Char) Then
            Dim valor1 As Long = Convert.ToInt64(Data.ToString().Length)
            Dim valor2 As Long = Convert.ToInt64(otroData)
            Return valor1.CompareTo(valor2)
        End If

        ' Case 4: They are different types that can be compared
        If TypeOf Data Is IComparable AndAlso TypeOf otroData Is IComparable Then
            Dim comparableData As IComparable = DirectCast(Data, IComparable)
            Dim comparableOtherData As IComparable = DirectCast(otroData, IComparable)
            Return comparableData.ToString().Length.CompareTo(comparableOtherData.ToString().Length)
        End If

        Return 0
    End Function

    Private Function EsNumero(value As Object) As Boolean
        Return TypeOf value Is SByte OrElse TypeOf value Is Byte OrElse
               TypeOf value Is Short OrElse TypeOf value Is UShort OrElse
               TypeOf value Is Integer OrElse TypeOf value Is UInteger OrElse
               TypeOf value Is Long OrElse TypeOf value Is ULong OrElse
               TypeOf value Is Single OrElse TypeOf value Is Double OrElse
               TypeOf value Is Decimal
    End Function
End Class

