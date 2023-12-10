Public Class SelectionSort
    Implements ImethodAlgorithms

    Private iterations As Integer = 0
    Private swaps As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(arr() As Integer, listBX As ListBox) Implements ImethodAlgorithms.Sort
        SelectionSortAlgorithm(arr, listBX)
        ShowIterations(listBX)
    End Sub

    Public Sub Sort(arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Private Sub SelectionSortAlgorithm(arr() As Integer, listBX As ListBox)
        Dim n As Integer = arr.Length

        For i As Integer = 0 To n - 2
            ' Encontrar el índice del mínimo elemento en el subarreglo no ordenado
            Dim minIndex As Integer = i
            For j As Integer = i + 1 To n - 1
                If arr(j) < arr(minIndex) Then
                    minIndex = j
                End If
                iterations += 1 ' Incrementar el número de iteraciones
                PrintArray(arr, listBX)
            Next

            ' Intercambiar el mínimo encontrado con el primer elemento del subarreglo no ordenado
            Swap(arr, i, minIndex)
            PrintArray(arr, listBX)
        Next
    End Sub

    Private Sub Swap(ByRef array() As Integer, a As Integer, b As Integer)
        Dim temp As Integer = array(a)
        array(a) = array(b)
        array(b) = temp
        swaps += 1
    End Sub

    Private Sub PrintArray(array() As Integer, listBX As ListBox)
        listBX.Items.Add("[ " & String.Join(", ", array) & " ]")
    End Sub

    Private Sub ShowIterations(listBX As ListBox)
        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(array() As Double, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(array() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
