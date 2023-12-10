Imports System.Windows.Forms

Friend Class RegularQueue(Of T)
    Implements ImethodQueues(Of T)

    Private myQueue As New Queue(Of T)()

    Public Sub Enqueue(value As T) Implements ImethodQueues(Of T).Enqueue
        myQueue.Enqueue(value)
        Console.WriteLine($"Enqueued: {value}")
    End Sub

    Public Sub Enqueue(value As T, count As Integer) Implements ImethodQueues(Of T).Enqueue

    End Sub

    Public Sub EnqueueRear(value As T) Implements ImethodQueues(Of T).EnqueueRear

    End Sub

    Public Sub Dequeue() Implements ImethodQueues(Of T).Dequeue
        If myQueue.Count > 0 Then
            Dim value As T = myQueue.Dequeue()
            Console.WriteLine($"Dequeued: {value}")
            Return
        End If

        Console.WriteLine("Queue is empty. Unable to dequeue.")
        MessageBox.Show("Queue is empty. Unable to dequeue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub DequeueRear() Implements ImethodQueues(Of T).DequeueRear

    End Sub

    Public Sub Peek() Implements ImethodQueues(Of T).Peek
        If myQueue.Count > 0 Then
            Dim frontValue As T = myQueue.Peek()
            Console.WriteLine($"Front element: {frontValue}")
            MessageBox.Show($"Front element: {frontValue}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Console.WriteLine("Queue is empty. No elements to peek.")
        MessageBox.Show("Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub PeekRear() Implements ImethodQueues(Of T).PeekRear

    End Sub

    Public Iterator Function Display() As IEnumerable(Of String) Implements ImethodQueues(Of T).Display
        Console.Write("Queue elements: ")
        For Each item In myQueue
            Yield item.ToString()
            Console.Write($"{item} ")
        Next
        Console.WriteLine()
    End Function

    Public Function Count() As Integer Implements ImethodQueues(Of T).Count
        Return myQueue.Count
    End Function
End Class
