Public Class Mergesort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0
    Private Shared recursions As Integer = 0
    Private Shared swaps As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        MergeSort(arr, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of recursions: {recursions}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Shared Sub MergeSort(ByVal arr() As Integer, ByVal listBX As ListBox)
        If arr.Length < 2 Then
            Return
        End If

        Dim mid As Integer = arr.Length \ 2
        Dim left(mid - 1) As Integer
        Dim right(arr.Length - mid - 1) As Integer

        Array.Copy(arr, 0, left, 0, mid)
        Array.Copy(arr, mid, right, 0, arr.Length - mid)

        MergeSort(left, listBX)
        MergeSort(right, listBX)
        Merge(arr, left, right, listBX)
    End Sub

    Public Shared Sub Merge(ByVal arr() As Integer, ByVal left() As Integer, ByVal right() As Integer, ByVal listBX As ListBox)
        Dim i As Integer = 0, j As Integer = 0, k As Integer = 0
        recursions += 1
        While i < left.Length AndAlso j < right.Length
            If left(i) <= right(j) Then
                arr(k) = left(i)
                i += 1
            Else
                arr(k) = right(j)
                j += 1
            End If
            k += 1

            ' Imprimir el arreglo completo en cada comparación
            listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            iterations += 1 ' Incrementa el número de iteraciones
        End While

        While i < left.Length
            arr(k) = left(i)
            i += 1
            k += 1

            ' Imprimir el arreglo completo en cada comparación
            listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            iterations += 1 ' Incrementa el número de iteraciones
        End While

        While j < right.Length
            arr(k) = right(j)
            j += 1
            k += 1

            ' Imprimir el arreglo completo en cada comparación
            listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            iterations += 1 ' Incrementa el número de iteraciones
        End While
    End Sub

    Public Sub Sort(ByVal arr() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
