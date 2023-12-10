Imports System.Windows.Forms

Public Class SmoothSort
    Implements ImethodAlgorithms

    Private heap As Integer()
    Private iterations As Integer
    Private swaps As Integer

    Public Sub New()
    End Sub

    Public Sub Sort(array() As Integer, listBX As ListBox) Implements ImethodAlgorithms.Sort
        heap = array
        Dim n As Integer = array.Length

        For i As Integer = (n - 1) \ 2 To 0 Step -1
            SiftDown(i, n - 1, listBX)
        Next

        For i As Integer = n - 1 To 1 Step -1
            Swap(0, i)
            listBX.Items.Add("[ " & String.Join(", ", array) & " ]")
            SiftDown(0, i - 1, listBX)
        Next

        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(arr() As Double, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Private Sub SiftDown(root As Integer, [end] As Integer, listBX As ListBox)
        iterations += 1
        Dim leftChild As Integer = 2 * root + 1

        While leftChild <= [end]
            Dim rightChild As Integer = leftChild + 1
            Dim swapIndex As Integer = root

            If heap(swapIndex) < heap(leftChild) Then
                swapIndex = leftChild
            End If

            If rightChild <= [end] AndAlso heap(swapIndex) < heap(rightChild) Then
                swapIndex = rightChild
            End If

            If swapIndex = root Then
                Return
            Else
                Swap(root, swapIndex)
                root = swapIndex
                leftChild = 2 * root + 1
            End If
        End While
    End Sub

    Private Sub Swap(i As Integer, j As Integer)
        Dim temp As Integer = heap(i)
        heap(i) = heap(j)
        heap(j) = temp
        swaps += 1
    End Sub

    Public Sub Sort(arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
