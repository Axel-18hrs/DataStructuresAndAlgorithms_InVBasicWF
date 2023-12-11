Public Class CircularList(Of T)
    Implements ImethodLists(Of T)

    Private Property Head As Node(Of T)
    Private Property LastNode As Node(Of T)

    Public Sub New()
        Clear()
    End Sub

    Public Sub Add(data As T) Implements ImethodLists(Of T).Add
        ' Case 0: Create a new node
        Dim NewNode As New Node(Of T)(data)

        ' Case 1: Insert at the beginning
        If IsEmpty() Then
            Head = NewNode
            Head.NextNode = Head
            LastNode = NewNode
            Return
        End If

        ' Case 2: Prevent duplicate data
        If Exist(NewNode.Data) Then
            MessageBox.Show($"{NewNode.Data} exists in the list", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 3: Place the data after the first node
        If NewNode.CompareTo(Head) <= 0 Then
            NewNode.NextNode = Head
            Head = NewNode
            LastNode.NextNode = Head
            Return
        End If

        ' Case 4: Insert at the end if the data is greater
        If NewNode.CompareTo(LastNode) >= 0 Then
            LastNode.NextNode = NewNode
            NewNode.NextNode = Head
            LastNode = NewNode
            Return
        End If

        ' Case 5: Traverse the list
        Dim CurrentNode As Node(Of T) = Head
        While CurrentNode.NextNode IsNot Head AndAlso CurrentNode.NextNode.CompareTo(NewNode) <= 0
            CurrentNode = CurrentNode.NextNode
        End While

        NewNode.NextNode = CurrentNode.NextNode
        CurrentNode.NextNode = NewNode
    End Sub

    Public Sub Delete(data As T) Implements ImethodLists(Of T).Delete
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        ' Case 2: The data is at the beginning of the list
        If Head.CompareTo(data) = 0 Then
            Head = Head.NextNode
            LastNode.NextNode = Head
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 3: Traverse the list
        Dim CurrentNode As Node(Of T) = Head
        While CurrentNode.NextNode IsNot Head AndAlso CurrentNode.NextNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 4: The data is at the end of the list
        If CurrentNode.NextNode Is LastNode AndAlso LastNode.CompareTo(data) = 0 Then
            CurrentNode.NextNode = CurrentNode.NextNode.NextNode
            LastNode = CurrentNode
            LastNode.NextNode = Head
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 5: The data is at X position in the list
        If CurrentNode.NextNode.CompareTo(data) = 0 Then
            CurrentNode.NextNode = CurrentNode.NextNode.NextNode
            Console.WriteLine($"- Data[{data}] deleted from the list")
            Return
        End If

        ' Case 6: The data was not found
        Console.WriteLine($"- Data[{data}] not found/deleted from the list")
    End Sub

    Public Sub Search(data As T) Implements ImethodLists(Of T).Search
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            MessageBox.Show("The list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Case 2: If the data is at the beginning of the list
        If Head.CompareTo(data) = 0 AndAlso Head.Equals(data) Then
            Console.WriteLine($"- Data[{data}] exists in the list")
            MessageBox.Show(Head.Data.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 3: Traverse the list
        Dim CurrentNode As Node(Of T) = Head
        While CurrentNode.NextNode IsNot Head AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 4: The entered data exists at X position
        If CurrentNode.CompareTo(data) = 0 Then
            Console.WriteLine($"- Data[{data}] exists in the list")
            MessageBox.Show(CurrentNode.Data.ToString(), "Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Case 5: The data does not exist
        Console.WriteLine($"- Data[{data}] does not exist in the list ")
        MessageBox.Show("Does not exist in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Iterator Function Show() As IEnumerable(Of T) Implements ImethodLists(Of T).Show
        ' Case 1: Check if the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        ' Case 2: Traverse the list
        Dim CurrentNode As Node(Of T) = Head
        Dim i As Integer = 0
        Console.WriteLine("=== My Circular List ===")
        Do
            Console.WriteLine($"- Node[{i}] and data: " & CurrentNode.Data.ToString())
            Yield CurrentNode.Data
            CurrentNode = CurrentNode.NextNode
            i += 1
        Loop While CurrentNode IsNot Head
    End Function

    Public Iterator Function ShowRevers() As IEnumerable(Of T) Implements ImethodLists(Of T).ShowRevers
        ' Case 1: Check if the list is empty
        If IsEmpty() Then
            Console.WriteLine("Empty list")
            Return
        End If

        Dim stack As New Stack(Of T)()
        Dim CurrentNode As Node(Of T) = Head
        Dim i As Integer = 0
        Do
            i += 1
            stack.Push(CurrentNode.Data)
            CurrentNode = CurrentNode.NextNode
        Loop While CurrentNode IsNot Head

        ' Create a copy of the stack before iterating
        Dim stackArray As T() = stack.ToArray()

        For Each node As T In stackArray
            Yield node
            Console.WriteLine($"- Node[{--i}] and data: " & node.ToString())
        Next
    End Function

    Public Function Exist(data As T) As Boolean Implements ImethodLists(Of T).Exist
        ' Case 1: If the list is empty
        If IsEmpty() Then
            Return False
        End If

        ' Case 2: If the data already exists at the beginning
        If Head.CompareTo(data) = 0 AndAlso Object.Equals(Head.Data, data) Then
            Return True
        End If

        ' Case 3: Traverse the list
        Dim CurrentNode As Node(Of T) = Head
        While CurrentNode.NextNode IsNot Head AndAlso CurrentNode.CompareTo(data) < 0
            CurrentNode = CurrentNode.NextNode
        End While

        ' Case 4: If the data already exists at X position / or at the end
        If CurrentNode.CompareTo(data) = 0 AndAlso Object.Equals(CurrentNode.Data, data) Then
            Return True
        End If
        ' Case 5: The data does not exist in the list
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

