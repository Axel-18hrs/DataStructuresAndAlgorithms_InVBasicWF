Public Class Heapsort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0
    Private Shared swaps As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Dim n As Integer = arr.Length

        ' Construir un heap (montículo) máximo
        For i As Integer = n \ 2 - 1 To 0 Step -1
            Heapify(arr, n, i, listBX)
        Next

        ' Extraer elementos uno por uno del heap
        For i As Integer = n - 1 To 1 Step -1
            ' Mover la raíz actual al final
            Swap(arr(0), arr(i))

            ' Llamar a heapify en el subárbol reducido
            Heapify(arr, i, 0, listBX)

            ' Imprimir el arreglo completo en cada intercambio
            listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            iterations += 1 ' Incrementa el número de iteraciones
        Next
        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Private Sub Heapify(ByVal arr() As Integer, ByVal n As Integer, ByVal i As Integer, ByVal listBX As ListBox)
        Dim largest As Integer = i
        Dim left As Integer = 2 * i + 1
        Dim right As Integer = 2 * i + 2

        ' Comparar con el hijo izquierdo
        If left < n AndAlso arr(left) > arr(largest) Then
            largest = left
        End If

        ' Comparar con el hijo derecho
        If right < n AndAlso arr(right) > arr(largest) Then
            largest = right
        End If

        ' Si el mayor no es la raíz
        If largest <> i Then
            Swap(arr(i), arr(largest))

            ' Recursivamente heapify el subárbol afectado
            Heapify(arr, n, largest, listBX)

            ' Imprimir el arreglo completo en cada intercambio
            listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            iterations += 1 ' Incrementa el número de iteraciones
        End If
    End Sub

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
        swaps += 1
    End Sub

    Public Sub Sort(ByVal arr() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
