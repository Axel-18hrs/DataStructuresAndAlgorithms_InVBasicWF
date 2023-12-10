Public Class Radixsort
    Implements ImethodAlgorithms

    Private iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(arr() As Integer, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Dim max As Integer = FindMax(arr)

        ' Aplicar Radix Sort para cada posición del dígito
        For exp As Integer = 1 To max \ 10
            CountingSort(arr, exp, listBX)
        Next

        ' Mostrar el número total de iteraciones al finalizar
        ShowIterations(listBX)
    End Sub

    Public Sub Sort(arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(arr() As Double, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Private Sub CountingSort(arr() As Integer, exp As Integer, listBX As ListBox)
        Dim n As Integer = arr.Length
        Dim output(n - 1) As Integer
        Dim count(9) As Integer

        ' Inicializar el arreglo de conteo
        For i As Integer = 0 To 9
            count(i) = 0
        Next

        ' Contar la frecuencia de cada elemento en la posición actual del dígito
        For i As Integer = 0 To n - 1
            count((arr(i) \ exp) Mod 10) += 1
        Next

        ' Actualizar el arreglo de conteo para contener las posiciones reales
        For i As Integer = 1 To 9
            count(i) += count(i - 1)
        Next

        ' Construir el arreglo de salida
        For i As Integer = n - 1 To 0 Step -1
            output(count((arr(i) \ exp) Mod 10) - 1) = arr(i)
            count((arr(i) \ exp) Mod 10) -= 1
        Next

        ' Copiar el arreglo de salida de vuelta al arreglo original
        For i As Integer = 0 To n - 1
            arr(i) = output(i)
        Next

        ' Mostrar el estado actual del arreglo en el ListBox
        PrintArray(arr, listBX)
        ' Incrementar el contador de iteraciones
        iterations += 1
    End Sub

    Private Sub PrintArray(arr() As Integer, listBX As ListBox)
        listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
    End Sub

    Private Sub ShowIterations(listBX As ListBox)
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Private Function FindMax(arr() As Integer) As Integer
        Dim max As Integer = arr(0)
        For i As Integer = 1 To arr.Length - 1
            If arr(i) > max Then
                max = arr(i)
            End If
        Next
        Return max
    End Function

    Public Sub Sort(arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class