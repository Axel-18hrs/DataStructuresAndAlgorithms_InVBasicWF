Friend Class CircularQueue(Of T)
    Implements ImethodQueues(Of T)

    Private myCircularQueue As T()
    Private front As Integer
    Private rear As Integer
    Private capacity As Integer

    Public Sub New(size As Integer)
        myCircularQueue = New T(size - 1) {}
        Me.capacity = size
        front = rear = -1
    End Sub

    Public Sub Enqueue(value As T) Implements ImethodQueues(Of T).Enqueue
        If IsEmpty() Then
            front = rear = 0
            myCircularQueue(rear) = value
            Console.WriteLine($"Enqueued: {value}")
            Return
        End If

        If (rear + 1) Mod capacity = front Then
            Console.WriteLine("Circular Queue is full. Unable to enqueue.")
            MessageBox.Show("Circular Queue is full. Unable to enqueue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        rear = (rear + 1) Mod capacity
        myCircularQueue(rear) = value
        Console.WriteLine($"Enqueued: {value}")
    End Sub

    Public Sub Enqueue(value As T, capacity As Integer) Implements ImethodQueues(Of T).Enqueue

    End Sub

    Public Sub EnqueueRear(value As T) Implements ImethodQueues(Of T).EnqueueRear

    End Sub

    Public Sub Dequeue() Implements ImethodQueues(Of T).Dequeue
        If IsEmpty() Then
            Console.WriteLine("Circular Queue is empty. Unable to dequeue.")
            MessageBox.Show("Circular Queue is full. Unable to enqueue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If front = rear Then
            Console.WriteLine($"Dequeued: {myCircularQueue(front)}")
            front = rear = -1
            Return
        End If

        Console.WriteLine($"Dequeued: {myCircularQueue(front)}")
        front = (front + 1) Mod capacity
    End Sub

    Public Sub DequeueRear() Implements ImethodQueues(Of T).DequeueRear

    End Sub

    Public Sub Peek() Implements ImethodQueues(Of T).Peek
        If IsEmpty() Then
            Console.WriteLine("Circular Queue is empty. No elements to peek.")
            MessageBox.Show("Circular Queue is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Console.WriteLine($"Front element: {myCircularQueue(front)}")
        MessageBox.Show($"Front element: {myCircularQueue(front)}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub PeekRear() Implements ImethodQueues(Of T).PeekRear

    End Sub

    Public Iterator Function Display() As IEnumerable(Of String) Implements ImethodQueues(Of T).Display
        If IsEmpty() Then
            Console.WriteLine("Circular Queue is empty.")
            MessageBox.Show("Circular Queue is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Console.Write("Circular Queue elements: ")
        Dim i As Integer = front
        Do
            Yield $"{myCircularQueue(i)} "
            Console.Write($"{myCircularQueue(i)} ")
            i = (i + 1) Mod capacity
        Loop While i <> (rear + 1) Mod capacity
        Console.WriteLine()
    End Function

    Public Function Count() As Integer Implements ImethodQueues(Of T).Count
        If IsEmpty() Then
            Return 0
        End If

        If front <= rear Then
            Return rear - front + 1
        End If

        Return capacity - front + rear + 1
    End Function

    Public Function IsEmpty() As Boolean
        Return front = -1 AndAlso rear = -1
    End Function
End Class