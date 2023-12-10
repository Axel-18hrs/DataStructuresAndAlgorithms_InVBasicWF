Friend Class PriorityQueue(Of T)
    Implements ImethodQueues(Of T)

    Private myPriorityQueue As New SortedDictionary(Of Integer, Queue(Of T))()

    Public Sub Enqueue(value As T, priority As Integer) Implements ImethodQueues(Of T).Enqueue
        If Not myPriorityQueue.ContainsKey(priority) Then
            myPriorityQueue(priority) = New Queue(Of T)()
        End If

        myPriorityQueue(priority).Enqueue(value)

        Console.WriteLine($"Enqueued with priority {priority}: {value}")
    End Sub

    Public Sub Enqueue(value As T) Implements ImethodQueues(Of T).Enqueue

    End Sub

    Public Sub EnqueueRear(priority As T) Implements ImethodQueues(Of T).EnqueueRear

    End Sub

    Public Sub Dequeue() Implements ImethodQueues(Of T).Dequeue
        If myPriorityQueue.Count > 0 Then
            Dim highestPriority = myPriorityQueue.First()
            Dim value = highestPriority.Value.Dequeue()

            If highestPriority.Value.Count = 0 Then
                myPriorityQueue.Remove(highestPriority.Key)
            End If

            Console.WriteLine($"Dequeued with priority {highestPriority.Key}: {value}")
            Return
        End If

        Console.WriteLine("Priority Queue is empty. Unable to dequeue.")
        MessageBox.Show("Priority Queue is empty. Unable to dequeue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub DequeueRear() Implements ImethodQueues(Of T).DequeueRear

    End Sub

    Public Sub Peek() Implements ImethodQueues(Of T).Peek
        If myPriorityQueue.Count > 0 Then
            Dim highestPriority = myPriorityQueue.First()
            Dim value = highestPriority.Value.Peek()

            Console.WriteLine($"Front element with priority {highestPriority.Key}: {value}")
            MessageBox.Show($"Front element with priority {highestPriority.Key}: {value}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Console.WriteLine("Priority Queue is empty. No elements to peek.")
        MessageBox.Show("Priority Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub PeekRear() Implements ImethodQueues(Of T).PeekRear

    End Sub

    Public Iterator Function Display() As IEnumerable(Of String) Implements ImethodQueues(Of T).Display
        Console.Write("Priority Queue elements: ")
        For Each priorityGroup In myPriorityQueue
            For Each item In priorityGroup.Value
                Yield $"{item} (Priority {priorityGroup.Key}) "
                Console.Write($"{item} (Priority {priorityGroup.Key}) ")
            Next
        Next
        Console.WriteLine()
    End Function

    Public Function Count() As Integer Implements ImethodQueues(Of T).Count
        Return myPriorityQueue.Sum(Function(priorityGroup) priorityGroup.Value.Count)
    End Function
End Class