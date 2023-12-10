Public Class BucketSort
    Implements ImethodAlgorithms

    Private Shared iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de enteros
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort

    End Sub

    Public Sub Sort(ByVal array() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de enteros y mostrar pasos
    End Sub

    Public Sub Sort(ByVal array() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        BucketSort_Double(array, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Private Shared Sub PrintBucketState(ByVal buckets() As List(Of Double), ByVal listBX As ListBox)
        listBX.Items.Clear()
        For i As Integer = 0 To buckets.Length - 1
            Dim bucketContent As New List(Of String)()

            For Each item In buckets(i)
                bucketContent.Add(item.ToString())
            Next

            listBX.Items.Add($"Bucket {i}: {String.Join(", ", bucketContent)}")
        Next
    End Sub

    Private Shared Function BucketSort_Double(ByVal array() As Double, ByVal listBX As ListBox) As Double()
        ' Crear buckets vacíos
        Dim buckets(array.Length - 1) As List(Of Double)
        For i As Integer = 0 To buckets.Length - 1
            buckets(i) = New List(Of Double)()
        Next

        ' Insertar elementos en sus respectivos buckets
        For Each element In array
            iterations += 1 ' Incrementa el número de iteraciones
            buckets(CInt(element * array.Length)).Add(element)

            PrintBucketState(buckets, listBX)
            PrintArray(array, listBX)
        Next

        ' Imprimir el estado de los buckets después de la inserción
        PrintBucketState(buckets, listBX)

        ' Ordenar los elementos de cada cubo
        For i As Integer = 0 To array.Length - 1
            buckets(i).Sort()
        Next

        ' Imprimir el estado de los buckets después de la ordenación
        PrintBucketState(buckets, listBX)

        ' Obtener los elementos ordenados
        Dim k As Integer = 0
        For i As Integer = 0 To array.Length - 1
            For Each item In buckets(i)
                array(k) = item
                k += 1
            Next
        Next

        Return array
    End Function

    Private Shared Sub PrintArray(ByVal array() As Double, ByVal listBX As ListBox)
        listBX.Items.Clear()
        For Each value In array
            listBX.Items.Add(value)
        Next
    End Sub
End Class
