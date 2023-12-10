Friend Class DinamicStack(Of T)
    Implements ImethodStacks(Of T)

    Private stackList As New List(Of T)()

    Public Sub New()
    End Sub

    Public Sub Push(item As T) Implements ImethodStacks(Of T).Push
        stackList.Add(item)
    End Sub

    Public Function Pop() As T Implements ImethodStacks(Of T).Pop
        If stackList.Count = 0 Then
            MessageBox.Show("The stack is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        Dim lastIndex As Integer = stackList.Count - 1
        Dim poppedItem As T = stackList(lastIndex)
        stackList.RemoveAt(lastIndex)

        Return poppedItem
    End Function

    Public Function Peek() As T Implements ImethodStacks(Of T).Peek
        If stackList.Count = 0 Then
            MessageBox.Show("The stack is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        Return stackList(stackList.Count - 1)
    End Function

    Public Function Count() As Integer Implements ImethodStacks(Of T).Count
        Return Convert.ToInt32(stackList.ToArray().Length)
    End Function

    Public Iterator Function Show() As IEnumerable(Of T) Implements ImethodStacks(Of T).Show
        Console.WriteLine(vbLf & "Elements in the stack:")
        For i As Integer = stackList.Count - 1 To 0 Step -1
            Yield stackList(i)
            Console.WriteLine(stackList(i))
        Next
    End Function
End Class