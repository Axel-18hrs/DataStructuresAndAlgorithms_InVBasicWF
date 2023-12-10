Public Class StaticStack(Of T)
    Implements ImethodStacks(Of T)

    Private elements() As T
    Private capacity As Integer
    Private count_ As Integer

    Public Sub New(capacity As Integer)
        Me.capacity = capacity
        ReDim elements(capacity - 1)
        count_ = 0
    End Sub

    Public Sub Push(element As T) Implements ImethodStacks(Of T).Push
        If count_ < capacity Then
            elements(count_) = element
            count_ += 1
            Return
        End If

        Console.WriteLine("The stack is full. Cannot add more elements.")
        MessageBox.Show("The stack is full. Cannot add more elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function Pop() As T Implements ImethodStacks(Of T).Pop
        If count_ > 0 Then
            count_ -= 1
            Dim element As T = elements(count_)
            elements(count_) = Nothing ' Set to default value
            Return element
        End If

        Console.WriteLine("The stack is empty. Cannot pop more elements.")
        MessageBox.Show("The stack is empty. Cannot pop more elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Public Function Peek() As T Implements ImethodStacks(Of T).Peek
        If count > 0 Then
            Return elements(count_ - 1)
        End If

        Console.WriteLine("The stack is empty. No elements to peek.")
        MessageBox.Show("The stack is empty. No elements to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Public Function Count() As Integer Implements ImethodStacks(Of T).Count
        Return count_
    End Function

    Public Iterator Function Show() As IEnumerable(Of T) Implements ImethodStacks(Of T).Show
        Console.WriteLine(vbLf & "Elements in the stack:")
        For i As Integer = count - 1 To 0 Step -1
            Yield elements(i)
            Console.WriteLine(elements(i))
        Next
    End Function
End Class
