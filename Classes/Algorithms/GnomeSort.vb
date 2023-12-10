Public Class Gnomesort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0
    Private Shared swaps As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Dim n As Integer = arr.Length
        Dim index As Integer = 0

        While index < n
            If index = 0 Then
                index += 1
            End If

            If arr(index) >= arr(index - 1) Then
                index += 1
            Else
                Swap(arr(index), arr(index - 1))
                index -= 1

                ' Imprimir el arreglo completo en cada intercambio
                listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
                iterations += 1 ' Incrementa el número de iteraciones
            End If
        End While
        listBX.Items.Add($"Number of iterations: {iterations}")
        listBX.Items.Add($"Number of swaps: {swaps}")
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(ByVal array() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
        swaps += 1
    End Sub

    Public Sub Sort(ByVal array() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
