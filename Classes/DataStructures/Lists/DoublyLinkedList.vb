Public Class DoublyListLinked(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As DoubleNode(Of T)
    Private Property LastNode As DoubleNode(Of T)

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        ' Case 0: Create a new node
        Dim NewNode As New DoubleNode(Of T)(data)

        ' Case 1: Insert at the beginning
        If IsEmpty() Then
            Head = NewNode
            LastNode = NewNode
            Return
        End If

        ' Case 2: Prevent duplicate data
        If Exist(NewNode.Data) Then
            Return
        End If

        ' Case 3: The new data is inserted at the beginning
        If NewNode.CompareTo(Head) <= 0 Then
            Head.Back = NewNode
            NewNode.NextNode = Head
            Head = NewNode
            Return
        End If

        ' Case 4: The new data is inserted at the end
        If NewNode.CompareTo(LastNode) >= 0 Then
            LastNode.NextNode = NewNode
            NewNode.Back = LastNode
            LastNode = NewNode
            Return
        End If

        ' Case 5: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.NextNode IsNot Nothing AndAlso CurrentNode.NextNode.CompareTo(NewNode) <= 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 6: Insert at X position
        NewNode.NextNode = CurrentNode.NextNode
        NewNode.Back = CurrentNode
        CurrentNode.NextNode.Back = NewNode
        CurrentNode.NextNode = NewNode
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        ' Case 2: The data to delete is at the beginning of the list
        If Head.CompareTo(data) = 0 Then
            Head = Head.NextNode
            Head.Back = Nothing
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 3: The data to delete is at the end of the list
        If LastNode.CompareTo(data) = 0 Then
            LastNode = LastNode.Back
            LastNode.NextNode = Nothing
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 4: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.NextNode IsNot Nothing AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 5: The data is at X position in the list
        If CurrentNode.CompareTo(data) = 0 Then
            CurrentNode.Back.NextNode = CurrentNode.NextNode
            CurrentNode.NextNode.Back = CurrentNode.Back
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 6: The data was not found
        Console.WriteLine($"- Data[{data}] does not exist/deleted from the list")
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            MessageBox.Show("The list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Case 2: If the data is at the beginning
        If Head.CompareTo(data) = 0 AndAlso Head.Equals(data) Then
            Console.WriteLine($"- Data[{data}] exists in the list")
            MessageBox.Show(Head.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 3: If the data is at the end
        If LastNode.CompareTo(data) = 0 AndAlso LastNode.Equals(data) Then
            Console.WriteLine($"- Data[{data}] exists in the list")
            MessageBox.Show(LastNode.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 4: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.NextNode IsNot Nothing AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 5: If the data exists at X position
        If CurrentNode.CompareTo(data) = 0 AndAlso CurrentNode.Equals(data) Then
            Console.WriteLine($"- Data[{data}] exists in the list")
            MessageBox.Show(CurrentNode.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 6: The data does not exist in the list
        Console.WriteLine($"- Data[{data}] Does not exist in the list ")
        MessageBox.Show("Does not exist in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Iterator Function Show() As IEnumerable(Of T) Implements ImethodLists(Of T).Show
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        ' Case 2: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = Head
        Dim i As Integer = 0
        Console.WriteLine("=== My Doubly Linked List ===")
        While CurrentNode IsNot Nothing
            Console.WriteLine($"- Node[{i}] and data: " & CurrentNode.Data.ToString())
            Yield CurrentNode.Data
            CurrentNode = CurrentNode.NextNode
            i += 1
        End While
    End Function

    Public Iterator Function ShowRevers() As IEnumerable(Of T) Implements ImethodLists(Of T).ShowRevers
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        ' Case 2: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = LastNode
        Dim i As Integer = 0
        Console.WriteLine("=== My Reversed Doubly Linked List ===")
        Do
            Console.WriteLine($"- Node[{i}] and data: " & CurrentNode.Data.ToString())
            Yield CurrentNode.Data
            CurrentNode = CurrentNode.Back
            i += 1
        Loop While CurrentNode IsNot Nothing
    End Function

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return False
        End If

        ' Case 2: If the first element already exists
        If Head.CompareTo(data) = 0 Then
            Return True
        End If

        ' Case 3: If the data is at the end
        If LastNode.CompareTo(data) = 0 Then
            Return True
        End If

        ' Case 4: Traverse the list
        Dim CurrentNode As DoubleNode(Of T) = Head
        While CurrentNode.NextNode IsNot Nothing AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 5: The entered data exists at X position
        If CurrentNode.CompareTo(data) = 0 Then
            Return True
        End If

        ' Case 6: The data does not exist in the list
        Return False
    End Function

    Public Function IsEmpty() As Boolean Implements ImethodLists(Of T).IsEmpty
        Return Head Is Nothing
    End Function

    Public Sub Clear() Implements ImethodLists(Of T).Clear
        Head = Nothing
        LastNode = Nothing
    End Sub
End Class
