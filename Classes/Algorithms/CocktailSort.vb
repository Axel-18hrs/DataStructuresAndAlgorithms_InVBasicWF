Public Class CocktailSort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort

    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(ByVal array() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        CocktailSort_Int(array, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Public Sub Sort(ByVal array() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles y mostrar pasos
    End Sub

    Private Sub CocktailSort_Int(ByVal arr() As Integer, ByVal listBX As ListBox)
        Dim n As Integer = arr.Length
        Dim swapped As Boolean = True
        Dim start As Integer = 0
        Dim [end] As Integer = n - 1

        While swapped
            ' Mover de izquierda a derecha
            swapped = False
            For i As Integer = start To [end] - 1
                iterations += 1 ' Incrementa el número de iteraciones
                If arr(i) > arr(i + 1) Then
                    Swap(arr, i, i + 1)
                    swapped = True
                    listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
                End If
            Next

            If Not swapped Then
                Exit While
            End If

            [end] -= 1

            ' Mover de derecha a izquierda
            swapped = False
            For i As Integer = [end] - 1 To start Step -1
                iterations += 1 ' Incrementa el número de iteraciones
                If arr(i) > arr(i + 1) Then
                    Swap(arr, i, i + 1)
                    swapped = True
                    listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
                End If
            Next

            start += 1
        End While
    End Sub

    Private Sub Swap(ByVal arr() As Integer, ByVal i As Integer, ByVal j As Integer)
        Dim temp As Integer = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub
End Class
