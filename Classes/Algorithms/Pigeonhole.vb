Public Class Pigeonhole
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        PigeonholeSort(arr, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub PigeonholeSort(ByVal arr() As Integer, ByVal listBX As ListBox)
        Dim min As Integer = arr(0)
        Dim max As Integer = arr(0)
        Dim range, i, j, index As Integer

        For a As Integer = 1 To arr.Length - 1
            If arr(a) > max Then
                max = arr(a)
            End If
            If arr(a) < min Then
                min = arr(a)
            End If
        Next

        range = max - min + 1
        Dim pigeonholes(range - 1) As Integer

        For i = 0 To arr.Length - 1
            pigeonholes(i) = 0
        Next

        For i = 0 To arr.Length - 1
            pigeonholes(arr(i) - min) += 1
        Next

        index = 0

        For j = 0 To range - 1
            While pigeonholes(j) > 0
                arr(index) = j + min
                index += 1

                ' Imprimir el arreglo completo en cada iteración
                listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
                iterations += 1 ' Incrementa el número de iteraciones
                pigeonholes(j) -= 1
            End While
        Next
    End Sub

    Public Sub Sort(ByVal arr() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
