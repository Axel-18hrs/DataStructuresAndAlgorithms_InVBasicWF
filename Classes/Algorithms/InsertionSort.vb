Public Class Insertionsort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0
    Private Shared swaps As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        InsertionSortAlgorithm(arr, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub InsertionSortAlgorithm(ByVal arr() As Integer, ByVal listBX As ListBox)
        Dim n As Integer = arr.Length
        For i As Integer = 1 To n - 1
            Dim key As Integer = arr(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del subarreglo arr[0..i-1] que son mayores que key
            ' a una posición adelante de su posición actual
            While j >= 0 AndAlso arr(j) > key
                arr(j + 1) = arr(j)
                j = j - 1

                swaps += 1
                ' Imprimir el arreglo completo en cada iteración
                listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
                iterations += 1 ' Incrementa el número de iteraciones
            End While
            arr(j + 1) = key
        Next
    End Sub

    Public Sub Sort(ByVal arr() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
