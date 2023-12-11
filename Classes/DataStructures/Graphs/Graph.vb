Imports System.Text
Friend Class Graph(Of T)
    Private graph As New Dictionary(Of T, List(Of (T, Integer)))()
    Private weights As New Dictionary(Of T, Integer)()

    Public Sub AddVertex(vertex As T)
        If Not graph.ContainsKey(vertex) Then
            graph(vertex) = New List(Of (T, Integer))()
        End If
    End Sub

    Public Sub AddEdge(source As T, destination As T, weight As Integer)
        If graph.ContainsKey(source) AndAlso graph.ContainsKey(destination) Then
            graph(source).Add((destination, weight))
        End If
    End Sub

    Public Sub RemoveEdge(source As T, destination As T)
        If graph.ContainsKey(source) Then
            graph(source).RemoveAll(Function(edge) edge.Item1.Equals(destination))
        End If
    End Sub

    Public Function GetNeighbors(vertex As T) As IEnumerable(Of (T, Integer))
        If graph.ContainsKey(vertex) Then
            Return graph(vertex)
        Else
            Return Enumerable.Empty(Of (T, Integer))()
        End If
    End Function

    Public Function GetVertices() As IEnumerable(Of T)
        Return graph.Keys
    End Function

    Public Sub RemoveVertex(vertex As T)
        If graph.ContainsKey(vertex) Then
            graph.Remove(vertex)

            For Each key In graph.Keys
                graph(key).RemoveAll(Function(tuple) tuple.Item1.Equals(vertex))
            Next
        End If
    End Sub

    Public Function DFS(start As T, goal As T) As (bestPath As List(Of T), steps As List(Of List(Of T)))
        If Not graph.ContainsKey(start) Then
            Console.WriteLine($"The starting vertex {start} is not present in the graph.")
            Return (New List(Of T)(), New List(Of List(Of T))())
        End If

        Dim stack As New Stack(Of T)()
        Dim parents As New Dictionary(Of T, T)()
        weights.Clear()

        stack.Push(start)
        parents(start) = Nothing
        weights(start) = 0 ' Initialize the weight for the starting vertex

        Dim steps As New List(Of List(Of T))()

        While stack.Count > 0
            Dim currentVertex As T = stack.Pop()
            Dim currentStep As New List(Of T) From {currentVertex}

            For Each edge In graph(currentVertex)
                Dim neighbor As T = edge.Item1
                Dim weight As Integer = edge.Item2

                Dim totalWeight As Integer = weights(currentVertex) + weight

                If Not parents.ContainsKey(neighbor) OrElse totalWeight < weights(neighbor) Then
                    stack.Push(neighbor)
                    parents(neighbor) = currentVertex
                    weights(neighbor) = totalWeight

                    ' Add the vertex to the current step
                    currentStep.Add(neighbor)
                End If
            Next

            ' Add the current step to the list of steps
            steps.Add(New List(Of T)(currentStep))
        End While

        Dim bestPath As List(Of T) = BuildPath(parents, goal)
        Return (bestPath, steps)
    End Function

    Private Sub PrintDFSSteps(steps As List(Of List(Of T)))
        Console.WriteLine("Depth-First Search (DFS) Steps:")
        For i As Integer = 0 To steps.Count - 1
            Console.WriteLine($"Step {i + 1}: {String.Join(" -> ", steps(i))}")
        Next
    End Sub

    Private Function BuildPath(parents As Dictionary(Of T, T), goal As T) As List(Of T)
        Dim path As New List(Of T)()

        Dim current As T = goal
        While Not EqualityComparer(Of T).Default.Equals(current, Nothing)
            path.Insert(0, current)

            ' Check if the key is present in the dictionary
            If parents.ContainsKey(current) Then
                current = parents(current)
            Else
                ' Handle the case where the key is not present
                Exit While
            End If
        End While

        Return path
    End Function

    Public Function GetAdjacencyMatrix() As List(Of String)
        Dim matrixStrings As New List(Of String)()
        Dim numVertices As Integer = graph.Count

        Dim header As New StringBuilder("   ")
        For Each vertex In graph.Keys
            header.Append($"{vertex} ")
        Next
        matrixStrings.Add(header.ToString())

        For Each vertex In graph.Keys
            Dim row As New StringBuilder($"{vertex} ")
            For Each otherVertex In graph.Keys
                Dim hasEdge As Boolean = graph(vertex).Any(Function(edge) edge.Item1.Equals(otherVertex))
                row.Append(If(hasEdge, "1 ", "0 "))
            Next
            matrixStrings.Add(row.ToString().Trim())
        Next

        Return matrixStrings
    End Function
End Class