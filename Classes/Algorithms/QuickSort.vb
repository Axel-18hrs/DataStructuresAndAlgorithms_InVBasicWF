Public Class QuickSort
    Implements ImethodAlgorithms

    Private Shared _Random As New Random()
    Private Shared _Option, _ContainExchange, _ContainPartition, _ContainRecursive As Integer

    Public Sub New()
    End Sub

    Private Shared Sub Swap(ByRef IndexOne As Integer, ByRef IndexTwo As Integer)
        Dim Temporary As Integer = IndexOne
        IndexOne = IndexTwo
        IndexTwo = Temporary
    End Sub

    Public Sub Sort(arr() As Integer, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Quicksort(arr, 0, arr.Length - 1, listBX)
    End Sub

    Public Sub Sort(arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Private Function Partition(ByRef Array() As Integer, FirstIndex As Integer, LastIndex As Integer, listBX As ListBox) As Integer
        _ContainPartition += 1
        Dim IndexPivot As Integer
        Select Case _Option
            Case 1
                IndexPivot = FirstIndex
            Case 2
                IndexPivot = CInt(Math.Floor((LastIndex + FirstIndex) / 2))
            Case 3
                IndexPivot = LastIndex
            Case Else
                IndexPivot = _Random.Next(FirstIndex, LastIndex)
        End Select
        Swap(Array(FirstIndex), Array(IndexPivot))

        PrintSwap(Array, FirstIndex, IndexPivot, listBX)
        _ContainExchange += 1
        Dim Pivot As Integer = Array(FirstIndex)
        Dim Left As Integer = FirstIndex + 1
        Dim Right As Integer = LastIndex

        While True
            While Left <= Right AndAlso Array(Left) <= Pivot
                Left += 1
            End While
            While Left <= Right AndAlso Array(Right) >= Pivot
                Right -= 1
            End While
            If Right < Left Then
                Exit While
            End If
            Swap(Array(Left), Array(Right))
            PrintSwap(Array, Left, Right, listBX)
            _ContainExchange += 1
            Left += 1
            Right -= 1
        End While
        Swap(Array(FirstIndex), Array(Right))
        PrintSwap(Array, FirstIndex, Right)
        _ContainExchange += 1
        Return Right
    End Function

    Public Sub Quicksort(ByRef Array() As Integer, FirstIndex As Integer, LastIndex As Integer, listBX As ListBox)
        If FirstIndex < LastIndex Then
            _ContainRecursive += 1
            Dim IndexPivot As Integer = Partition(Array, FirstIndex, LastIndex, listBX)
            Quicksort(Array, FirstIndex, IndexPivot - 1, listBX)
            Quicksort(Array, IndexPivot + 1, LastIndex, listBX)
        End If
    End Sub

    Public Function Print(Array() As Integer) As String
        Return $"\nResult: [ {String.Join(", ", Array)} ]\nSwaps: {_ContainExchange}\nPartitions: {_ContainPartition}\nRecursion: {_ContainRecursive}"
    End Function

    Private Shared Sub PrintSwap(ByRef array() As Integer, Left As Integer, Right As Integer, listBX As ListBox)
        ' Crear una cadena que represente todo el array
        Dim arrayString As String = "[ "

        For i As Integer = 0 To array.Length - 1
            If Right = i AndAlso Left = i Then
                arrayString &= array(i)
            ElseIf i = Left OrElse i = Right Then
                arrayString &= array(i)
            Else
                arrayString &= array(i)
            End If

            If i < array.Length - 1 Then
                arrayString &= ", "
            End If
        Next

        arrayString &= " ]"

        ' Agregar la cadena al ListBox
        listBX.Items.Add(arrayString)
    End Sub

    Private Sub PrintSwap(ByRef array() As Integer, Left As Integer, Right As Integer)
        Console.Write("[ ")
        For i As Integer = 0 To array.Length - 1
            If Right = i AndAlso Left = i Then
                Console.ForegroundColor = ConsoleColor.DarkYellow
                Console.Write(array(i))
                Console.ResetColor()
            ElseIf i = Left OrElse i = Right Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(array(i))
                Console.ResetColor()
            Else
                Console.Write(array(i))
            End If
            If i < array.Length - 1 Then
                Console.Write(", ")
            End If
        Next
        Console.Write(" ]\n")
    End Sub

    Public Sub Sort(array() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(array() As Double, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class