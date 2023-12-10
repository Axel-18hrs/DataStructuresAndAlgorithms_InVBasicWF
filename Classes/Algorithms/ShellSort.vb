Imports System.Windows.Forms

Public Class ShellSort
    Implements ImethodAlgorithms

    Private iterations As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(arr() As Integer, listBX As ListBox) Implements ImethodAlgorithms.Sort
        ShellSort(arr, listBX)
        listBX.Items.Add($"Number of iterations: {iterations}")
    End Sub

    Public Sub Sort(arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub ShellSort(array() As Integer, Optional listBX As ListBox = Nothing)
        ' Obtener la longitud del array
        Dim n As Integer = array.Length
        ' Obtener el tamaño del espacio entre elementos
        Dim gap As Integer = n \ 2

        Console.WriteLine(vbLf & "Inicio del algoritmo de Shell Sort:")

        ' Mientras el espacio entre elementos sea mayor que 0
        While gap > 0
            Console.WriteLine($"{vbLf}Tamaño actual del espacio: {gap}")

            ' Aplicar el algoritmo de inserción para cada "subarray" con el tamaño del espacio
            For i As Integer = gap To n - 1
                ' Guardar el valor actual del elemento en una variable temporal
                Dim temp As Integer = array(i)
                Dim j As Integer = i

                Console.WriteLine($"{vbLf}Comparando {temp} con los elementos en su subarray:")

                ' Realizar la inserción
                While j >= gap AndAlso array(j - gap) > temp
                    ' Desplazar los elementos a la derecha hasta encontrar la posición correcta
                    array(j) = array(j - gap)
                    j -= gap
                    If listBX IsNot Nothing Then
                        listBX.Items.Add("[ " & String.Join(", ", array) & " ]")
                    End If
                    iterations += 1 ' Incrementar el número de iteraciones
                End While

                ' Colocar el valor temporal en la posición correcta en el subarray
                array(j) = temp
                Console.WriteLine($"Insertar {temp} en la posición {j} en el subarray:")

                If listBX IsNot Nothing Then
                    listBX.Items.Add("[ " & String.Join(", ", array) & " ]")
                End If

                iterations += 1 ' Incrementar el número de iteraciones
            Next

            ' Reducir el espacio entre elementos a la mitad en cada iteración
            gap \= 2
        End While

        Console.WriteLine($"{vbLf}Fin del algoritmo de Shell Sort:")
    End Sub

    Public Sub Sort(arr() As Double, listBX As ListBox) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub

    Public Sub Sort(arr() As Integer) Implements ImethodAlgorithms.Sort
        Throw New NotImplementedException()
    End Sub
End Class
