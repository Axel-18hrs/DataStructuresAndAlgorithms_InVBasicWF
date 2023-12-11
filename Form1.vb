Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private lists As ImethodLists(Of Object)
    Private stacks As ImethodStacks(Of Object)
    Private queues As ImethodQueues(Of Object)
    Private algorithms As ImethodAlgorithms()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLists.Visible = False
        pnlStacks.Visible = False
        pnlQueues.Visible = False
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
End Class
