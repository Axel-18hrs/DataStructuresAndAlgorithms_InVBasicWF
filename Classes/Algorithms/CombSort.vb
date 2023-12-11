Public Class Combsort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        Dim n As Integer = arr.Length

        ' Inicializar el tamaño del salto
        Dim gap As Integer = n

        ' Factor de reducción
        Dim shrink As Double = 1.3

        Dim swapped As Boolean

        Dim printInterval As Integer = Math.Max(1, n \ 10) ' Imprimir cada 10% del arreglo

        Do
            ' Aplicar un salto mínimo de 1
            If gap > 1 Then
                gap = CInt(gap / shrink)
            End If

            swapped = False

            ' Realizar comparaciones y swaps
            For i As Integer = 0 To n - gap - 1
                If arr(i) > arr(i + gap) Then
                    Swap(arr(i), arr(i + gap))
                    swapped = True
                End If
            Next

            ' Imprimir el arreglo en intervalos específicos
            If iterations Mod printInterval = 0 Then
                listBX.Items.Add("[ " & String.Join(", ", arr) & " ]")
            End If

            iterations += 1 ' Incrementa el número de iteraciones
        Loop While gap > 1 AndAlso swapped

        listBX.Items.Add($"Number of iterations: {iterations}")
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
    End Sub

    Public Sub Sort(ByVal array() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
