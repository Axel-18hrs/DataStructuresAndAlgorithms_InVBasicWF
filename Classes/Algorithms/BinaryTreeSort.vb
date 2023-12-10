Friend Class BinaryTreeNode
    Public Value As Integer
    Public Left, Right As BinaryTreeNode

    Public Sub New(ByVal value As Integer)
        Me.Value = value
        Left = Nothing
        Right = Nothing
    End Sub
End Class

Public Class BinaryTreeSort
    Implements ImethodAlgorithms

    Private root As BinaryTreeNode
    Private swaps As Integer = 0
    Private recursions As Integer = 0
    Private index As Integer = 0

    Public Sub New()
    End Sub

    Public Sub Sort(ByVal arr() As Integer) Implements ImethodAlgorithms.Sort
        For Each value In arr
            root = Insert(root, value)
        Next
        InOrderTraversal(root, arr, index)
        Console.WriteLine($"Number of swaps: {swaps}")
        Console.WriteLine($"Number of recursions: {recursions}")
    End Sub

    Public Sub Sort(ByVal arr() As Integer, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        For Each value In arr
            root = Insert(root, value)
            PrintTree(listBX)
        Next
        InOrderTraversal(root, arr, index, listBX)

        listBX.Items.Add($"Number of swaps: {swaps}")
        listBX.Items.Add($"Number of recursions: {recursions}")
    End Sub

    Private Function Insert(ByVal node As BinaryTreeNode, ByVal value As Integer) As BinaryTreeNode
        If node Is Nothing Then
            Return New BinaryTreeNode(value)
        End If

        If value < node.Value Then
            swaps += 1 ' Incrementa el número de intercambios
            node.Left = Insert(node.Left, value)
        ElseIf value > node.Value Then
            swaps += 1 ' Incrementa el número de intercambios
            node.Right = Insert(node.Right, value)
        End If

        Return node
    End Function

    Private Sub InOrderTraversal(ByVal node As BinaryTreeNode, ByVal arr() As Integer, ByRef index As Integer)
        recursions += 1 ' Incrementa el número de recursiones
        If node IsNot Nothing Then
            InOrderTraversal(node.Left, arr, index)
            arr(index) = node.Value
            index += 1
            InOrderTraversal(node.Right, arr, index)
        End If
    End Sub

    Private Sub InOrderTraversal(ByVal node As BinaryTreeNode, ByVal arr() As Integer, ByRef index As Integer, ByVal listBX As ListBox)
        recursions += 1 ' Incrementa el número de recursiones
        If node IsNot Nothing Then
            InOrderTraversal(node.Left, arr, index, listBX)
            arr(index) = node.Value
            PrintTree(listBX)
            index += 1
            InOrderTraversal(node.Right, arr, index, listBX)
        End If
    End Sub

    Private Sub PrintTree(ByVal listBX As ListBox)
        listBX.Items.Clear()
        PrintTree(root, listBX)
    End Sub

    Private Sub PrintTree(ByVal node As BinaryTreeNode, ByVal listBX As ListBox, Optional ByVal indent As String = "", Optional ByVal last As Boolean = True)
        If node IsNot Nothing Then
            listBX.Items.Add($"{indent}|- {node.Value}")
            indent += If(last, "   ", "|  ")
            PrintTree(node.Left, listBX, indent, False)
            PrintTree(node.Right, listBX, indent, True)
        End If
    End Sub

    Public Sub Sort(ByVal arr() As Double) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles
    End Sub

    Public Sub Sort(ByVal arr() As Double, ByVal listBX As ListBox) Implements ImethodAlgorithms.Sort
        ' Implementación para ordenar un array de doubles y mostrar pasos
    End Sub
End Class

