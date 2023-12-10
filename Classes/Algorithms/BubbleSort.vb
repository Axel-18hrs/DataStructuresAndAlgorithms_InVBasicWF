Public Class BubbleSort
    Implements ImethodAlgorithms

    Private swaps As Integer = 0
    Private iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort

    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(ByVal array() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        BubbleSort(array, listBX)
        listBX.Items.Add($"Number of swaps: {swaps}")
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Public Sub Sort(ByVal array() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles y mostrar pasos
    End Sub

    Private Sub BubbleSort(ByVal array() As Integer, ByVal listBX As ListBox)
        For i As Integer = 0 To array.Length - 1
            For j As Integer = 0 To array.Length - i - 1
                iterations += 1 ' Incrementa el número de iteraciones
                If array(j) > array(j + 1) Then
                    swaps += 1 ' Incrementa el número de intercambios
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp

                    listBX.Items.Add("[ " & String.Join(", ", array) & " ]")
                End If
            Next
        Next
    End Sub
End Class

