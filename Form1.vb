Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private lists As ImethodLists(Of Object)
    Private stacks As ImethodStacks(Of Object)
    Private queues As ImethodQueues(Of Object)
    Private algorithms As ImethodAlgorithms()
    Private tree As BinaryTree
    Private graph As Graph(Of Object)
    Private algorithm As ImethodAlgorithms
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLists.Visible = False
        pnlStacks.Visible = False
        pnlQueues.Visible = False
        pnlTree.Visible = False
        pnlGraph.Visible = False
    End Sub
    Public Sub ShowLists()
        listLista.Items.Clear()
        For Each n In lists.Show()
            listLista.Items.Add(n)
        Next
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim age As Integer

        If Not Integer.TryParse(txtNumbers.Text, age) Then
            MessageBox.Show("Only numbers in the Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lists.Add(Integer.Parse(txtNumbers.Text))
        ShowLists()
        txtNumbers.ResetText()
    End Sub

    Private Sub btnShowReverse_Click(sender As Object, e As EventArgs) Handles btnShowReverse.Click
        If lists.IsEmpty() Then
            MessageBox.Show("The list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listLista.Items.Clear()
        For Each n In lists.ShowRevers()
            listLista.Items.Add(n)
        Next

    End Sub

    Private Sub ListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListsToolStripMenuItem.Click

    End Sub

    Private Sub SimpleListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleListToolStripMenuItem.Click
        lists = New SimpleList(Of Object)()
        pnlLists.Visible = True
    End Sub

    Private Sub CircularListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircularListToolStripMenuItem.Click
        lists = New CircularList(Of Object)()
        pnlLists.Visible = True
    End Sub

    Private Sub DoublyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoublyListToolStripMenuItem.Click
        lists = New DoublyListLinked(Of Object)()
        pnlLists.Visible = True
    End Sub

    Private Sub CircularDoublyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircularDoublyListToolStripMenuItem.Click
        lists = New CircularDoublyLinkedList(Of Object)()
        pnlLists.Visible = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim number As Integer
        If Not Integer.TryParse(txtNumbers.Text, number) Then
            MessageBox.Show("Only numbers in the box!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lists.Search(number)
        txtNumbers.ResetText()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listLista.Items.Clear()
        lists.Clear()
        ShowLists()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim number As Integer
        If Not Integer.TryParse(txtNumbers.Text, number) Then
            MessageBox.Show("Only numbers in the box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lists.Delete(Integer.Parse(txtNumbers.Text))
        listLista.Items.Clear()
        ShowLists()
    End Sub

    Private Sub _StacksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticSToolStripMenuItem.Click, _StacksToolStripMenuItem.Click
        pnlLists.Visible = False
        pnlStacks.Visible = True
        pnlQueues.Visible = False
        pnlTree.Visible = False
        pnlGraph.Visible = False
        gbxMenuStackAll.Visible = False
        gbxMenuStatickStack.Visible = False
    End Sub

    Private Sub StacksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        gbxMenuStackAll.Visible = False
        gbxMenuStatickStack.Visible = True
    End Sub

    Private Sub DinamicStackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DinamicStackToolStripMenuItem.Click
        gbxMenuStackAll.Visible = True
        gbxMenuStatickStack.Visible = False
    End Sub

    Private Sub btnLengthStack_Click(sender As Object, e As EventArgs)
        Dim number As Integer
        If Not Integer.TryParse(txtLengthStacks.Text, number) Then
            MessageBox.Show("Only numbers in the 'Length of static stack' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        stacks = New StaticStack(Of Object)(number)
        gbxMenuStatickStack.Visible = False
        gbxMenuStackAll.Visible = True
    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs)
        Dim number As Integer
        If Not Integer.TryParse(txtNumberStack.Text, number) Then
            MessageBox.Show("Only numbers in the 'Number' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        stacks.Push(number)
        lsbStacks.Items.Clear()

        For Each stack In stacks.Show
            lsbStacks.Items.Add(stack)
        Next
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs)
        stacks.Pop()
        lsbStacks.Items.Clear()

        For Each stack In stacks.Show
            lsbStacks.Items.Add(stack)
        Next
    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs)
        MessageBox.Show($"Element '{stacks.Peek}' is at the top of the stack.", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs)
        MessageBox.Show($"Number of elements in the stack: {stacks.Count}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub QueuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueuesToolStripMenuItem.Click
        pnlLists.Visible = False
        pnlStacks.Visible = False
        pnlQueues.Visible = True
        pnlGraph.Visible = False
        pnlTree.Visible = False
        gbxPriorityQue.Visible = False
        gbxCircularQ.Visible = False
        gbxCircularQLenght.Visible = False
        gbxQueueCircularM.Visible = False
    End Sub

    Private Sub RegularQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularQueueToolStripMenuItem.Click
        gbxPriorityQue.Visible = False
        gbxCircularQ.Visible = False
        gbxCircularQLenght.Visible = False
        gbxQueueCircularM.Visible = True
        lsbQueues.Items.Clear()
        queues = New RegularQueue(Of Object)
    End Sub

    Private Sub DoubleQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubleQueueToolStripMenuItem.Click
        gbxPriorityQue.Visible = False
        gbxCircularQ.Visible = False
        gbxPriorityQue.Visible = False
        gbxCircularQ.Visible = False
        gbxCircularQLenght.Visible = False
        gbxQueueCircularM.Visible = True
        lsbQueues.Items.Clear()
        queues = New DoubleQueue(Of Object)
    End Sub

    Private Sub PriorityQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriorityQueueToolStripMenuItem.Click
        gbxPriorityQue.Visible = True
        gbxCircularQ.Visible = False
        gbxCircularQLenght.Visible = False
        gbxQueueCircularM.Visible = True
        lsbQueues.Items.Clear()
        queues = New PriorityQueue(Of Object)
    End Sub

    Private Sub CircularQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircularQueueToolStripMenuItem.Click
        gbxPriorityQue.Visible = False
        gbxCircularQ.Visible = True
        gbxCircularQLenght.Visible = True
        gbxQueueCircularM.Visible = False
    End Sub

    Public Sub PrintQueues()
        lsbQueues.Items.Clear()
        For Each n As Object In queues.Display()
            lsbQueues.Items.Add(n)
        Next
    End Sub

    Private Sub btnStartQueue_Click(sender As Object, e As EventArgs) Handles btnStartQu.Click
        Dim num As Integer

        If Not Integer.TryParse(txtLenghtsQu.Text, num) Then
            MessageBox.Show("Only numbers in the box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        gbxCircularQ.Visible = False
        gbxQueueCircularM.Visible = True
        gbxCircularQLenght.Visible = False
        queues = New CircularQueue(Of Object)(num)
    End Sub

    Private Sub btnDequeue_Click(sender As Object, e As EventArgs) Handles btnDequeue.Click
        queues.Dequeue()
        PrintQueues()
    End Sub

    Private Sub btnEnqueue_Click(sender As Object, e As EventArgs) Handles btnEnqueue.Click
        Dim priority As Integer = 0

        ' Check if the priority input is visible and if parsing to an integer fails
        If gbxPriorityQue.Visible = True AndAlso Not Integer.TryParse(txtPriorityQ.Text, priority) Then
            MessageBox.Show($"Need a level of priority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' If priority input is visible, enqueue with priority, and print queues
        If gbxPriorityQue.Visible = True Then
            queues.Enqueue(txtNumbersQueue.Text, priority)
            PrintQueues()
            Return
        End If

        ' Enqueue without priority (if applicable) and print queues
        queues.Enqueue(txtNumbersQueue.Text)
        PrintQueues()
    End Sub

    Private Sub btnEnqueueRear_Click(sender As Object, e As EventArgs) Handles btnEnqueueRear.Click
        Dim number As Integer

        ' Check if parsing txtNumbersQueue.Text to an integer fails
        If Not Integer.TryParse(txtNumbersQueue.Text, number) Then
            MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Enqueue the number at the rear of the queues and print them
        queues.EnqueueRear(number)
        PrintQueues()
    End Sub

    Private Sub btnLengthStack_Click_1(sender As Object, e As EventArgs) Handles btnLengthStack.Click
        Dim number As Integer

        ' Check if parsing txtLengthStacks.Text to an integer fails
        If Not Integer.TryParse(txtLengthStacks.Text, number) Then
            MessageBox.Show("Only numbers in the 'Length of static stack' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create a new StaticStack(Of Object) with the parsed number
        stacks = New StaticStack(Of Object)(number)

        ' Update the visibility of the stack group boxes
        gbxMenuStatickStack.Visible = False
        gbxMenuStackAll.Visible = True

    End Sub

    Private Sub btnPush_Click_1(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim number As Integer

        ' Check if parsing txtNumberStack.Text to an integer fails
        If Not Integer.TryParse(txtNumberStack.Text, number) Then
            MessageBox.Show("Only numbers in the 'Number' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Push the parsed number onto the stack
        stacks.Push(number)

        ' Clear the items in lsbStacks
        lsbStacks.Items.Clear()

        ' Iterate through each item in the stack and add it to lsbStacks
        For Each stackItem In stacks.Show()
            lsbStacks.Items.Add(stackItem)
        Next
    End Sub

    Private Sub btnPop_Click_1(sender As Object, e As EventArgs) Handles btnPop.Click
        ' Pop an item from the stack
        stacks.Pop()

        ' Clear the items in lsbStacks
        lsbStacks.Items.Clear()

        ' Iterate through each item in the stack and add it to lsbStacks
        For Each stackItem In stacks.Show()
            lsbStacks.Items.Add(stackItem)
        Next
    End Sub

    Private Sub btnPeek_Click_1(sender As Object, e As EventArgs) Handles btnPeek.Click
        MessageBox.Show($"Element '{stacks.Peek()}' is at the top of the stack.", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCount_Click_1(sender As Object, e As EventArgs) Handles btnCount.Click
        MessageBox.Show($"Number of elements in the stack: {stacks.Count()}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDequeueRear_Click(sender As Object, e As EventArgs) Handles btnDequeueRear.Click
        queues.DequeueRear()
        PrintQueues()
    End Sub

    Private Sub btnPeekQ_Click(sender As Object, e As EventArgs) Handles btnPeekQ.Click
        queues.Peek()
    End Sub

    Private Sub btnPeekQRear_Click(sender As Object, e As EventArgs) Handles btnPeekQRear.Click
        queues.PeekRear()
    End Sub

    Private Sub TreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreeToolStripMenuItem.Click
        pnlLists.Visible = False
        pnlQueues.Visible = False
        pnlStacks.Visible = False
        pnlTree.Visible = True
        tree = New BinaryTree
    End Sub
    Public Sub ToursOfTree()
        lsbPreorder.Items.Clear()
        For Each val As Integer In tree.GetPreOrden
            lsbPreorder.Items.Add(val)
        Next

        lsbPostOrder.Items.Clear()
        For Each val As Integer In tree.GetPostOrden()
            lsbPostOrder.Items.Add(val)
        Next

        lsbInOrder.Items.Clear()
        For Each val As Integer In tree.GetInOrden()
            lsbInOrder.Items.Add(val)
        Next
    End Sub

    Private Sub VisualizarArbol(Tree As BinaryNode, parentNode As TreeNode, nodes As TreeNodeCollection)
        If Tree IsNot Nothing Then
            Dim NewNode As New TreeNode(Tree.Data.ToString())
            If parentNode IsNot Nothing Then
                parentNode.Nodes.Add(NewNode)
            Else
                nodes.Add(NewNode)
            End If
            VisualizarArbol(Tree.Left, NewNode, NewNode.Nodes)
            VisualizarArbol(Tree.Right, NewNode, NewNode.Nodes)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim number As Integer
        If Not Integer.TryParse(txtNumberBinaryTree.Text, number) Then
            MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        tree.Add(number)
        ToursOfTree()

        Dim data As Integer = 0
        Try
            data = Integer.Parse(txtNumberBinaryTree.Text)
        Catch
        End Try

        tree.Add(data)

        VisualizarArbol(tree.Root, Nothing, treeView.Nodes)

        txtNumberBinaryTree.Clear()
        txtNumberBinaryTree.Focus()

    End Sub

    Private Sub btnDeleteTreeN_Click(sender As Object, e As EventArgs) Handles btnDeleteTreeN.Click
        Dim number As Integer
        If Not Integer.TryParse(txtNumberBinaryTree.Text, number) Then
            MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        tree.Delete(number)
        ToursOfTree()
    End Sub

    Private Sub btnSearchTreeN_Click(sender As Object, e As EventArgs) Handles btnSearchTreeN.Click
        Dim number As Integer
        If Not Integer.TryParse(txtNumberBinaryTree.Text, number) Then
            MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        tree.Search(number)
    End Sub

    Private Sub GraphsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphsToolStripMenuItem.Click
        pnlLists.Visible = False
        pnlQueues.Visible = False
        pnlStacks.Visible = False
        pnlTree.Visible = False
        pnlGraph.Visible = True
        graph = New Graph(Of Object)
    End Sub

    Private Function CalculateTotalWeight(path As List(Of Object)) As Integer
        Dim totalWeight As Integer = 0

        For i As Integer = 0 To path.Count - 2
            Dim source = path(i)
            Dim destination = path(i + 1)

            For Each neighborWeightTuple In graph.GetNeighbors(source)
                Dim neighbor As Object = neighborWeightTuple.Item1
                Dim weight As Integer = neighborWeightTuple.Item2

                If Object.Equals(neighbor, destination) Then
                    totalWeight += weight
                    Exit For
                End If
            Next
        Next

        Return totalWeight
    End Function

    Private Sub MostrarMatrizAdyacencia()
        Dim matrizStrings As List(Of String) = graph.GetAdjacencyMatrix()

        lsbAdyacencyMatrixGraph.Items.Clear()

        For Each row As String In matrizStrings
            lsbAdyacencyMatrixGraph.Items.Add(row)
        Next
    End Sub

    Private Sub ActualizarListBox()
        lsbGraph.Items.Clear()

        For Each vertex In graph.GetVertices()
            lsbGraph.Items.Add($"Vertex: {vertex}")

            ' Utiliza GetNeighbors para recuperar los vecinos del vértice actual
            For Each neighbor In graph.GetNeighbors(vertex)
                lsbGraph.Items.Add($"  -> Neighbor: {neighbor.Item1}, Weight: {neighbor.Item2}")
            Next
        Next
    End Sub

    Private Sub btnAddVertGraph_Click(sender As Object, e As EventArgs) Handles btnAddVertGraph.Click
        Dim vertice As Integer

        If Not Integer.TryParse(txtNumberGraph.Text, vertice) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        graph.AddVertex(vertice)
        ActualizarListBox()
        MostrarMatrizAdyacencia()

        txtNumberGraph.Clear()

    End Sub

    Private Sub btnAddEdgeGraph_Click(sender As Object, e As EventArgs) Handles btnAddEdgeGraph.Click
        Dim origin, destination, weight As Integer

        If Not Integer.TryParse(txtOriginGraph.Text, origin) OrElse
            Not Integer.TryParse(txtDestinationGraph.Text, destination) OrElse
            Not Integer.TryParse(txtWeightGraph.Text, weight) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        graph.AddEdge(origin, destination, weight)

        ActualizarListBox()
        MostrarMatrizAdyacencia()
        MostrarMatrizAdyacencia()

        txtOriginGraph.Clear()
        txtDestinationGraph.Clear()
        txtWeightGraph.Clear()

    End Sub

    Private Sub btnToursDFSGraph_Click(sender As Object, e As EventArgs) Handles btnToursDFSGraph.Click
        Dim origen As Integer

        If Not Integer.TryParse(txtOriginGraph.Text, origen) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resultadoDFS = graph.DFS(origen, -1)

        If resultadoDFS.steps.Count <= 0 Then
            lsbTourGraph.Items.Clear()
            MessageBox.Show($"No DFS traversal found from vertex {origen}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lsbTourGraph.Items.Clear()
        For i As Integer = 0 To resultadoDFS.steps.Count - 1
            Dim paso As List(Of Object) = resultadoDFS.steps(i)
            Dim pasoStr As String = String.Join(" -> ", paso)
            lsbTourGraph.Items.Add($"Step {i + 1}: {pasoStr}")
        Next

        txtOriginGraph.Clear()

    End Sub

    Private Sub btnFindAwayGraph_Click(sender As Object, e As EventArgs) Handles btnFindAwayGraph.Click
        Dim origen, destino As Integer

        If Not Integer.TryParse(txtOriginGraph.Text, origen) OrElse Not Integer.TryParse(txtDestinationGraph.Text, destino) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim resultadoDFS = graph.DFS(origen, destino)

        ' Obtener el mejor camino desde la tupla
        Dim mejorCamino As List(Of Object) = resultadoDFS.bestPath

        If mejorCamino.Count <= 0 Then
            MessageBox.Show($"A path was not found from vertex {origen} to vertex {destino}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim caminoStr As String = String.Join(" -> ", mejorCamino)

        Dim pesoTotal As Integer = CalculateTotalWeight(mejorCamino)
        MessageBox.Show($"Best path found from vertex {origen} to vertex {destino}: {caminoStr}" & vbCrLf &
                 $"Total weight of the path: {pesoTotal}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtOriginGraph.Clear()
        txtDestinationGraph.Clear()
    End Sub

    Private Sub btnDeleteGraph_Click(sender As Object, e As EventArgs) Handles btnDeleteGraph.Click
        If lsbGraph.SelectedItem Is Nothing Then
            MessageBox.Show("Select a vertex to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim partes As String() = lsbGraph.SelectedItem.ToString().Split(":"c)

        Dim vertice As Integer = 0
        If Not (partes.Length >= 2 AndAlso Integer.TryParse(partes(1).Trim(), vertice)) Then
            MessageBox.Show("Error extracting selected vertex.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        graph.RemoveVertex(vertice)
        ActualizarListBox()

    End Sub

    Private Sub btnCantOfItemsAlgorithms_Click(sender As Object, e As EventArgs) Handles btnCantOfItemsAlgorithms.Click
        lsbAlgorithmSorting.Items.Clear()
        If algorithm Is Nothing Then
            MessageBox.Show("Select an algorithm to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim minon As Integer
        Console.WriteLine("Enter the minimum range from which you want to generate your unordered array:")
        If Not Integer.TryParse(txtMinimumRangeAlgorithms.Text, minon) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim length As Integer
        Console.WriteLine(Environment.NewLine & "Enter the maximum range or limit where you want to generate your unordered array:")
        If Not Integer.TryParse(txtMaximumRangeAlgorithms.Text, length) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim values As Integer
        Console.WriteLine(Environment.NewLine & "Enter the number of values you want in your array:")
        If Not Integer.TryParse(txtNumbersOfItemstoOrder.Text, values) Then
            MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (TypeOf algorithm Is Countingsort OrElse TypeOf algorithm Is Radixsort) AndAlso minon < 0 Then
            MessageBox.Show("Only positive numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If TypeOf algorithm Is BucketSort Then
            Dim arr As Double() = OperationsAlgorithm.GenerarVectorDouble(minon, length, values)

            lsbAlgorithmSorting.Items.Add("Unordered array: " & "[ " & String.Join(", ", arr) & " ]")
            Dim startTime As DateTime = DateTime.Now
            algorithm.Sort(arr, lsbAlgorithmSorting)
            lsbAlgorithmSorting.Items.Add("Sorted array: " & "[ " & String.Join(", ", arr) & " ]")
            lsbAlgorithmSorting.Items.Add("Time: " & (DateTime.Now - startTime).ToString)
            Return
        Else
            Dim arr As Integer() = OperationsAlgorithm.GenerarVector(minon, length, values)

            lsbAlgorithmSorting.Items.Add("Unordered array: " & "[ " & String.Join(", ", arr) & " ]")
            Dim startTime As DateTime = DateTime.Now
            algorithm.Sort(arr, lsbAlgorithmSorting)
            lsbAlgorithmSorting.Items.Add("Sorted array: " & "[ " & String.Join(", ", arr) & " ]")
            lsbAlgorithmSorting.Items.Add("Time: " & (DateTime.Now - startTime).ToString)
        End If

    End Sub

    Private Sub SortingAlgorithmsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortingAlgorithmsToolStripMenuItem.Click
        pnlGraph.Visible = False
        pnlLists.Visible = False
        pnlQueues.Visible = False
        pnlStacks.Visible = False
        pnlTree.Visible = False
        pnlAlgorithmsOfSorting.Visible = True
    End Sub

    Private Sub BinaryTreeSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryTreeSortToolStripMenuItem.Click
        algorithm = New BinaryTreeSort
    End Sub

    Private Sub BubbleSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BubbleSortToolStripMenuItem.Click
        algorithm = New BubbleSort
    End Sub

    Private Sub BucketSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BucketSortToolStripMenuItem.Click
        algorithm = New BucketSort
    End Sub

    Private Sub CombSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombSortToolStripMenuItem.Click
        algorithm = New Combsort
    End Sub

    Private Sub CountingSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountingSortToolStripMenuItem.Click
        algorithm = New Countingsort
    End Sub

    Private Sub GnomeSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GnomeSortToolStripMenuItem.Click
        algorithm = New Gnomesort
    End Sub

    Private Sub HeapSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeapSortToolStripMenuItem.Click
        algorithm = New Heapsort
    End Sub

    Private Sub InsertionSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertionSortToolStripMenuItem.Click
        algorithm = New Insertionsort
    End Sub

    Private Sub MergeSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MergeSortToolStripMenuItem.Click
        algorithm = New Mergesort
    End Sub

    Private Sub PigeonholeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PigeonholeToolStripMenuItem.Click
        algorithm = New Pigeonhole
    End Sub

    Private Sub QuickSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickSortToolStripMenuItem.Click
        algorithm = New QuickSort
    End Sub

    Private Sub RadixSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadixSortToolStripMenuItem.Click
        algorithm = New Radixsort
    End Sub

    Private Sub ShellSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShellSortToolStripMenuItem.Click
        algorithm = New ShellSort
    End Sub
    Private Sub SmoothSortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmoothSortToolStripMenuItem.Click
        algorithm = New SmoothSort
    End Sub
End Class
