Friend Interface ImethodQueues(Of T)
    Sub Enqueue(value As T)
    Sub Enqueue(value As T, val As Integer)
    Sub EnqueueRear(value As T)
    Sub Dequeue()
    Sub DequeueRear()
    Sub Peek()
    Sub PeekRear()
    Function Display() As IEnumerable(Of String)
    Function Count() As Integer
End Interface
