<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ListsToolStripMenuItem = New ToolStripMenuItem()
        SimpleListToolStripMenuItem = New ToolStripMenuItem()
        CircularListToolStripMenuItem = New ToolStripMenuItem()
        DoublyListToolStripMenuItem = New ToolStripMenuItem()
        CircularDoublyListToolStripMenuItem = New ToolStripMenuItem()
        _StacksToolStripMenuItem = New ToolStripMenuItem()
        StaticSToolStripMenuItem = New ToolStripMenuItem()
        DinamicStackToolStripMenuItem = New ToolStripMenuItem()
        QueuesToolStripMenuItem = New ToolStripMenuItem()
        RegularQueueToolStripMenuItem = New ToolStripMenuItem()
        DoubleQueueToolStripMenuItem = New ToolStripMenuItem()
        PriorityQueueToolStripMenuItem = New ToolStripMenuItem()
        CircularQueueToolStripMenuItem = New ToolStripMenuItem()
        TreeToolStripMenuItem = New ToolStripMenuItem()
        GraphsToolStripMenuItem = New ToolStripMenuItem()
        SortingAlgorithmsToolStripMenuItem = New ToolStripMenuItem()
        BinaryTreeSortToolStripMenuItem = New ToolStripMenuItem()
        BubbleSortToolStripMenuItem = New ToolStripMenuItem()
        BucketSortToolStripMenuItem = New ToolStripMenuItem()
        CombSortToolStripMenuItem = New ToolStripMenuItem()
        CountingSortToolStripMenuItem = New ToolStripMenuItem()
        GnomeSortToolStripMenuItem = New ToolStripMenuItem()
        HeapSortToolStripMenuItem = New ToolStripMenuItem()
        InsertionSortToolStripMenuItem = New ToolStripMenuItem()
        MergeSortToolStripMenuItem = New ToolStripMenuItem()
        PigeonholeToolStripMenuItem = New ToolStripMenuItem()
        QuickSortToolStripMenuItem = New ToolStripMenuItem()
        RadixSortToolStripMenuItem = New ToolStripMenuItem()
        ShellSortToolStripMenuItem = New ToolStripMenuItem()
        SmoothSortToolStripMenuItem = New ToolStripMenuItem()
        pnlLists = New Panel()
        btnClear = New Button()
        btnDelete = New Button()
        btnShowReverse = New Button()
        btnSearch = New Button()
        listLista = New ListBox()
        btnSend = New Button()
        lblNumbers = New Label()
        txtNumbers = New TextBox()
        lblBeggininMessage = New Label()
        pnlQueues = New Panel()
        lsbQueues = New ListBox()
        lblQueue = New Label()
        gbxQueueCircularM = New GroupBox()
        btnPeekQ = New Button()
        btnDequeue = New Button()
        btnEnqueue = New Button()
        gbxCircularQ = New GroupBox()
        btnPeekQRear = New Button()
        btnDequeueRear = New Button()
        btnEnqueueRear = New Button()
        label2 = New Label()
        txtNumbersQueue = New TextBox()
        gbxCircularQLenght = New GroupBox()
        btnStartQu = New Button()
        lblLenght = New Label()
        txtLenghtsQu = New TextBox()
        gbxPriorityQue = New GroupBox()
        label3 = New Label()
        txtPriorityQ = New TextBox()
        pnlStacks = New Panel()
        gbxMenuStackAll = New GroupBox()
        btnPeek = New Button()
        btnCount = New Button()
        btnPop = New Button()
        btnPush = New Button()
        label1 = New Label()
        txtNumberStack = New TextBox()
        gbxMenuStatickStack = New GroupBox()
        btnLengthStack = New Button()
        lblLenghtStack = New Label()
        txtLengthStacks = New TextBox()
        lsbStacks = New ListBox()
        pnlTree = New Panel()
        treeView = New TreeView()
        btnSearchTreeN = New Button()
        btnDeleteTreeN = New Button()
        label7 = New Label()
        lsbInOrder = New ListBox()
        label6 = New Label()
        lsbPostOrder = New ListBox()
        label5 = New Label()
        lsbPreorder = New ListBox()
        lblBinaryTree = New Label()
        btnAdd = New Button()
        label4 = New Label()
        txtNumberBinaryTree = New TextBox()
        pnlGraph = New Panel()
        btnFindAwayGraph = New Button()
        btnToursDFSGraph = New Button()
        btnAddEdgeGraph = New Button()
        btnDeleteGraph = New Button()
        label14 = New Label()
        label13 = New Label()
        label12 = New Label()
        txtOriginGraph = New TextBox()
        label11 = New Label()
        txtWeightGraph = New TextBox()
        label10 = New Label()
        txtDestinationGraph = New TextBox()
        lsbTourGraph = New ListBox()
        lsbAdyacencyMatrixGraph = New ListBox()
        btnAddVertGraph = New Button()
        label9 = New Label()
        txtNumberGraph = New TextBox()
        label8 = New Label()
        lsbGraph = New ListBox()
        pnlAlgorithmsOfSorting = New Panel()
        label18 = New Label()
        txtMaximumRangeAlgorithms = New TextBox()
        label17 = New Label()
        txtMinimumRangeAlgorithms = New TextBox()
        label16 = New Label()
        lsbAlgorithmSorting = New ListBox()
        btnCantOfItemsAlgorithms = New Button()
        label15 = New Label()
        txtNumbersOfItemstoOrder = New TextBox()
        MenuStrip1.SuspendLayout()
        pnlLists.SuspendLayout()
        pnlQueues.SuspendLayout()
        gbxQueueCircularM.SuspendLayout()
        gbxCircularQ.SuspendLayout()
        gbxCircularQLenght.SuspendLayout()
        gbxPriorityQue.SuspendLayout()
        pnlStacks.SuspendLayout()
        gbxMenuStackAll.SuspendLayout()
        gbxMenuStatickStack.SuspendLayout()
        pnlTree.SuspendLayout()
        pnlGraph.SuspendLayout()
        pnlAlgorithmsOfSorting.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListsToolStripMenuItem, _StacksToolStripMenuItem, QueuesToolStripMenuItem, TreeToolStripMenuItem, GraphsToolStripMenuItem, SortingAlgorithmsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1127, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ListsToolStripMenuItem
        ' 
        ListsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SimpleListToolStripMenuItem, CircularListToolStripMenuItem, DoublyListToolStripMenuItem, CircularDoublyListToolStripMenuItem})
        ListsToolStripMenuItem.Name = "ListsToolStripMenuItem"
        ListsToolStripMenuItem.Size = New Size(51, 24)
        ListsToolStripMenuItem.Text = "Lists"
        ' 
        ' SimpleListToolStripMenuItem
        ' 
        SimpleListToolStripMenuItem.Name = "SimpleListToolStripMenuItem"
        SimpleListToolStripMenuItem.Size = New Size(220, 26)
        SimpleListToolStripMenuItem.Text = "Simple List"
        ' 
        ' CircularListToolStripMenuItem
        ' 
        CircularListToolStripMenuItem.Name = "CircularListToolStripMenuItem"
        CircularListToolStripMenuItem.Size = New Size(220, 26)
        CircularListToolStripMenuItem.Text = "Circular List"
        ' 
        ' DoublyListToolStripMenuItem
        ' 
        DoublyListToolStripMenuItem.Name = "DoublyListToolStripMenuItem"
        DoublyListToolStripMenuItem.Size = New Size(220, 26)
        DoublyListToolStripMenuItem.Text = "Doubly List"
        ' 
        ' CircularDoublyListToolStripMenuItem
        ' 
        CircularDoublyListToolStripMenuItem.Name = "CircularDoublyListToolStripMenuItem"
        CircularDoublyListToolStripMenuItem.Size = New Size(220, 26)
        CircularDoublyListToolStripMenuItem.Text = "Circular Doubly List"
        ' 
        ' _StacksToolStripMenuItem
        ' 
        _StacksToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StaticSToolStripMenuItem, DinamicStackToolStripMenuItem})
        _StacksToolStripMenuItem.Name = "_StacksToolStripMenuItem"
        _StacksToolStripMenuItem.Size = New Size(64, 24)
        _StacksToolStripMenuItem.Text = "Stacks"
        ' 
        ' StaticSToolStripMenuItem
        ' 
        StaticSToolStripMenuItem.Name = "StaticSToolStripMenuItem"
        StaticSToolStripMenuItem.Size = New Size(186, 26)
        StaticSToolStripMenuItem.Text = "Static Stack"
        ' 
        ' DinamicStackToolStripMenuItem
        ' 
        DinamicStackToolStripMenuItem.Name = "DinamicStackToolStripMenuItem"
        DinamicStackToolStripMenuItem.Size = New Size(186, 26)
        DinamicStackToolStripMenuItem.Text = "Dinamic Stack"
        ' 
        ' QueuesToolStripMenuItem
        ' 
        QueuesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegularQueueToolStripMenuItem, DoubleQueueToolStripMenuItem, PriorityQueueToolStripMenuItem, CircularQueueToolStripMenuItem})
        QueuesToolStripMenuItem.Name = "QueuesToolStripMenuItem"
        QueuesToolStripMenuItem.Size = New Size(72, 24)
        QueuesToolStripMenuItem.Text = "Queues"
        ' 
        ' RegularQueueToolStripMenuItem
        ' 
        RegularQueueToolStripMenuItem.Name = "RegularQueueToolStripMenuItem"
        RegularQueueToolStripMenuItem.Size = New Size(190, 26)
        RegularQueueToolStripMenuItem.Text = "Regular Queue"
        ' 
        ' DoubleQueueToolStripMenuItem
        ' 
        DoubleQueueToolStripMenuItem.Name = "DoubleQueueToolStripMenuItem"
        DoubleQueueToolStripMenuItem.Size = New Size(190, 26)
        DoubleQueueToolStripMenuItem.Text = "Double Queue"
        ' 
        ' PriorityQueueToolStripMenuItem
        ' 
        PriorityQueueToolStripMenuItem.Name = "PriorityQueueToolStripMenuItem"
        PriorityQueueToolStripMenuItem.Size = New Size(190, 26)
        PriorityQueueToolStripMenuItem.Text = "Priority Queue"
        ' 
        ' CircularQueueToolStripMenuItem
        ' 
        CircularQueueToolStripMenuItem.Name = "CircularQueueToolStripMenuItem"
        CircularQueueToolStripMenuItem.Size = New Size(190, 26)
        CircularQueueToolStripMenuItem.Text = "Circular Queue"
        ' 
        ' TreeToolStripMenuItem
        ' 
        TreeToolStripMenuItem.Name = "TreeToolStripMenuItem"
        TreeToolStripMenuItem.Size = New Size(51, 24)
        TreeToolStripMenuItem.Text = "Tree"
        ' 
        ' GraphsToolStripMenuItem
        ' 
        GraphsToolStripMenuItem.Name = "GraphsToolStripMenuItem"
        GraphsToolStripMenuItem.Size = New Size(69, 24)
        GraphsToolStripMenuItem.Text = "Graphs"
        ' 
        ' SortingAlgorithmsToolStripMenuItem
        ' 
        SortingAlgorithmsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BinaryTreeSortToolStripMenuItem, BubbleSortToolStripMenuItem, BucketSortToolStripMenuItem, CombSortToolStripMenuItem, CountingSortToolStripMenuItem, GnomeSortToolStripMenuItem, HeapSortToolStripMenuItem, InsertionSortToolStripMenuItem, MergeSortToolStripMenuItem, PigeonholeToolStripMenuItem, QuickSortToolStripMenuItem, RadixSortToolStripMenuItem, ShellSortToolStripMenuItem, SmoothSortToolStripMenuItem})
        SortingAlgorithmsToolStripMenuItem.Name = "SortingAlgorithmsToolStripMenuItem"
        SortingAlgorithmsToolStripMenuItem.Size = New Size(148, 24)
        SortingAlgorithmsToolStripMenuItem.Text = "Sorting Algorithms"
        ' 
        ' BinaryTreeSortToolStripMenuItem
        ' 
        BinaryTreeSortToolStripMenuItem.Name = "BinaryTreeSortToolStripMenuItem"
        BinaryTreeSortToolStripMenuItem.Size = New Size(224, 26)
        BinaryTreeSortToolStripMenuItem.Text = "Binary Tree Sort"
        ' 
        ' BubbleSortToolStripMenuItem
        ' 
        BubbleSortToolStripMenuItem.Name = "BubbleSortToolStripMenuItem"
        BubbleSortToolStripMenuItem.Size = New Size(224, 26)
        BubbleSortToolStripMenuItem.Text = "Bubble Sort"
        ' 
        ' BucketSortToolStripMenuItem
        ' 
        BucketSortToolStripMenuItem.Name = "BucketSortToolStripMenuItem"
        BucketSortToolStripMenuItem.Size = New Size(224, 26)
        BucketSortToolStripMenuItem.Text = "Bucket Sort"
        ' 
        ' CombSortToolStripMenuItem
        ' 
        CombSortToolStripMenuItem.Name = "CombSortToolStripMenuItem"
        CombSortToolStripMenuItem.Size = New Size(224, 26)
        CombSortToolStripMenuItem.Text = "Comb Sort"
        ' 
        ' CountingSortToolStripMenuItem
        ' 
        CountingSortToolStripMenuItem.Name = "CountingSortToolStripMenuItem"
        CountingSortToolStripMenuItem.Size = New Size(224, 26)
        CountingSortToolStripMenuItem.Text = "Counting Sort"
        ' 
        ' GnomeSortToolStripMenuItem
        ' 
        GnomeSortToolStripMenuItem.Name = "GnomeSortToolStripMenuItem"
        GnomeSortToolStripMenuItem.Size = New Size(224, 26)
        GnomeSortToolStripMenuItem.Text = "Gnome Sort"
        ' 
        ' HeapSortToolStripMenuItem
        ' 
        HeapSortToolStripMenuItem.Name = "HeapSortToolStripMenuItem"
        HeapSortToolStripMenuItem.Size = New Size(224, 26)
        HeapSortToolStripMenuItem.Text = "Heap Sort"
        ' 
        ' InsertionSortToolStripMenuItem
        ' 
        InsertionSortToolStripMenuItem.Name = "InsertionSortToolStripMenuItem"
        InsertionSortToolStripMenuItem.Size = New Size(224, 26)
        InsertionSortToolStripMenuItem.Text = "Insertion Sort"
        ' 
        ' MergeSortToolStripMenuItem
        ' 
        MergeSortToolStripMenuItem.Name = "MergeSortToolStripMenuItem"
        MergeSortToolStripMenuItem.Size = New Size(224, 26)
        MergeSortToolStripMenuItem.Text = "Merge Sort"
        ' 
        ' PigeonholeToolStripMenuItem
        ' 
        PigeonholeToolStripMenuItem.Name = "PigeonholeToolStripMenuItem"
        PigeonholeToolStripMenuItem.Size = New Size(224, 26)
        PigeonholeToolStripMenuItem.Text = "Pigeonhole"
        ' 
        ' QuickSortToolStripMenuItem
        ' 
        QuickSortToolStripMenuItem.Name = "QuickSortToolStripMenuItem"
        QuickSortToolStripMenuItem.Size = New Size(224, 26)
        QuickSortToolStripMenuItem.Text = "Quick Sort"
        ' 
        ' RadixSortToolStripMenuItem
        ' 
        RadixSortToolStripMenuItem.Name = "RadixSortToolStripMenuItem"
        RadixSortToolStripMenuItem.Size = New Size(224, 26)
        RadixSortToolStripMenuItem.Text = "Radix Sort"
        ' 
        ' ShellSortToolStripMenuItem
        ' 
        ShellSortToolStripMenuItem.Name = "ShellSortToolStripMenuItem"
        ShellSortToolStripMenuItem.Size = New Size(224, 26)
        ShellSortToolStripMenuItem.Text = "Shell Sort"
        ' 
        ' SmoothSortToolStripMenuItem
        ' 
        SmoothSortToolStripMenuItem.Name = "SmoothSortToolStripMenuItem"
        SmoothSortToolStripMenuItem.Size = New Size(224, 26)
        SmoothSortToolStripMenuItem.Text = "Smooth Sort"
        ' 
        ' pnlLists
        ' 
        pnlLists.Controls.Add(btnClear)
        pnlLists.Controls.Add(btnDelete)
        pnlLists.Controls.Add(btnShowReverse)
        pnlLists.Controls.Add(btnSearch)
        pnlLists.Controls.Add(listLista)
        pnlLists.Controls.Add(btnSend)
        pnlLists.Controls.Add(lblNumbers)
        pnlLists.Controls.Add(txtNumbers)
        pnlLists.Location = New Point(0, 31)
        pnlLists.Name = "pnlLists"
        pnlLists.Size = New Size(1127, 499)
        pnlLists.TabIndex = 14
        pnlLists.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(808, 417)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(159, 40)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(93, 372)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(159, 40)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnShowReverse
        ' 
        btnShowReverse.Location = New Point(643, 417)
        btnShowReverse.Name = "btnShowReverse"
        btnShowReverse.Size = New Size(159, 40)
        btnShowReverse.TabIndex = 10
        btnShowReverse.Text = "Reverse"
        btnShowReverse.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(93, 326)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(159, 40)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' listLista
        ' 
        listLista.Font = New Font("Segoe UI", 12F)
        listLista.FormattingEnabled = True
        listLista.ItemHeight = 28
        listLista.Location = New Point(643, 70)
        listLista.Margin = New Padding(3, 4, 3, 4)
        listLista.Name = "listLista"
        listLista.Size = New Size(394, 340)
        listLista.TabIndex = 8
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(93, 280)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(159, 40)
        btnSend.TabIndex = 7
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' lblNumbers
        ' 
        lblNumbers.AutoSize = True
        lblNumbers.Location = New Point(93, 127)
        lblNumbers.Name = "lblNumbers"
        lblNumbers.Size = New Size(63, 20)
        lblNumbers.TabIndex = 5
        lblNumbers.Text = "Number"
        ' 
        ' txtNumbers
        ' 
        txtNumbers.ImeMode = ImeMode.NoControl
        txtNumbers.Location = New Point(93, 150)
        txtNumbers.Name = "txtNumbers"
        txtNumbers.Size = New Size(253, 27)
        txtNumbers.TabIndex = 2
        ' 
        ' lblBeggininMessage
        ' 
        lblBeggininMessage.AutoSize = True
        lblBeggininMessage.Font = New Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBeggininMessage.Location = New Point(238, 188)
        lblBeggininMessage.Name = "lblBeggininMessage"
        lblBeggininMessage.Size = New Size(652, 60)
        lblBeggininMessage.TabIndex = 15
        lblBeggininMessage.Text = "Data structures and Algorithms"
        ' 
        ' pnlQueues
        ' 
        pnlQueues.Controls.Add(lsbQueues)
        pnlQueues.Controls.Add(lblQueue)
        pnlQueues.Controls.Add(gbxQueueCircularM)
        pnlQueues.Controls.Add(gbxCircularQLenght)
        pnlQueues.Controls.Add(gbxPriorityQue)
        pnlQueues.Location = New Point(-5, 31)
        pnlQueues.Name = "pnlQueues"
        pnlQueues.Size = New Size(1135, 495)
        pnlQueues.TabIndex = 16
        ' 
        ' lsbQueues
        ' 
        lsbQueues.Font = New Font("Segoe UI", 12F)
        lsbQueues.FormattingEnabled = True
        lsbQueues.ItemHeight = 28
        lsbQueues.Location = New Point(592, 62)
        lsbQueues.Margin = New Padding(3, 4, 3, 4)
        lsbQueues.Name = "lsbQueues"
        lsbQueues.Size = New Size(394, 340)
        lsbQueues.TabIndex = 14
        ' 
        ' lblQueue
        ' 
        lblQueue.AutoSize = True
        lblQueue.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQueue.Location = New Point(594, 32)
        lblQueue.Name = "lblQueue"
        lblQueue.Size = New Size(84, 26)
        lblQueue.TabIndex = 63
        lblQueue.Text = "Queue"
        ' 
        ' gbxQueueCircularM
        ' 
        gbxQueueCircularM.Controls.Add(btnPeekQ)
        gbxQueueCircularM.Controls.Add(btnDequeue)
        gbxQueueCircularM.Controls.Add(btnEnqueue)
        gbxQueueCircularM.Controls.Add(gbxCircularQ)
        gbxQueueCircularM.Controls.Add(label2)
        gbxQueueCircularM.Controls.Add(txtNumbersQueue)
        gbxQueueCircularM.Location = New Point(99, 244)
        gbxQueueCircularM.Name = "gbxQueueCircularM"
        gbxQueueCircularM.Size = New Size(388, 248)
        gbxQueueCircularM.TabIndex = 37
        gbxQueueCircularM.TabStop = False
        ' 
        ' btnPeekQ
        ' 
        btnPeekQ.Location = New Point(32, 185)
        btnPeekQ.Name = "btnPeekQ"
        btnPeekQ.Size = New Size(159, 40)
        btnPeekQ.TabIndex = 28
        btnPeekQ.Text = "Peek"
        btnPeekQ.UseVisualStyleBackColor = True
        ' 
        ' btnDequeue
        ' 
        btnDequeue.Location = New Point(32, 133)
        btnDequeue.Name = "btnDequeue"
        btnDequeue.Size = New Size(159, 40)
        btnDequeue.TabIndex = 26
        btnDequeue.Text = "Dequeue"
        btnDequeue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueue
        ' 
        btnEnqueue.Location = New Point(32, 81)
        btnEnqueue.Name = "btnEnqueue"
        btnEnqueue.Size = New Size(159, 40)
        btnEnqueue.TabIndex = 24
        btnEnqueue.Text = "Enqueue"
        btnEnqueue.UseVisualStyleBackColor = True
        ' 
        ' gbxCircularQ
        ' 
        gbxCircularQ.Controls.Add(btnPeekQRear)
        gbxCircularQ.Controls.Add(btnDequeueRear)
        gbxCircularQ.Controls.Add(btnEnqueueRear)
        gbxCircularQ.Location = New Point(201, 74)
        gbxCircularQ.Name = "gbxCircularQ"
        gbxCircularQ.Size = New Size(187, 176)
        gbxCircularQ.TabIndex = 30
        gbxCircularQ.TabStop = False
        ' 
        ' btnPeekQRear
        ' 
        btnPeekQRear.Location = New Point(6, 110)
        btnPeekQRear.Name = "btnPeekQRear"
        btnPeekQRear.Size = New Size(159, 40)
        btnPeekQRear.TabIndex = 29
        btnPeekQRear.Text = "Peek rear"
        btnPeekQRear.UseCompatibleTextRendering = True
        btnPeekQRear.UseVisualStyleBackColor = True
        ' 
        ' btnDequeueRear
        ' 
        btnDequeueRear.Location = New Point(6, 58)
        btnDequeueRear.Name = "btnDequeueRear"
        btnDequeueRear.Size = New Size(159, 40)
        btnDequeueRear.TabIndex = 27
        btnDequeueRear.Text = "Dequeue rear"
        btnDequeueRear.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueRear
        ' 
        btnEnqueueRear.Location = New Point(6, 6)
        btnEnqueueRear.Name = "btnEnqueueRear"
        btnEnqueueRear.Size = New Size(159, 40)
        btnEnqueueRear.TabIndex = 25
        btnEnqueueRear.Text = "Enqueue rear"
        btnEnqueueRear.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(32, 13)
        label2.Name = "label2"
        label2.Size = New Size(63, 20)
        label2.TabIndex = 23
        label2.Text = "Number"
        ' 
        ' txtNumbersQueue
        ' 
        txtNumbersQueue.ImeMode = ImeMode.NoControl
        txtNumbersQueue.Location = New Point(32, 36)
        txtNumbersQueue.Name = "txtNumbersQueue"
        txtNumbersQueue.Size = New Size(253, 27)
        txtNumbersQueue.TabIndex = 22
        ' 
        ' gbxCircularQLenght
        ' 
        gbxCircularQLenght.Controls.Add(btnStartQu)
        gbxCircularQLenght.Controls.Add(lblLenght)
        gbxCircularQLenght.Controls.Add(txtLenghtsQu)
        gbxCircularQLenght.Location = New Point(102, 38)
        gbxCircularQLenght.Name = "gbxCircularQLenght"
        gbxCircularQLenght.Size = New Size(314, 128)
        gbxCircularQLenght.TabIndex = 36
        gbxCircularQLenght.TabStop = False
        ' 
        ' btnStartQu
        ' 
        btnStartQu.Location = New Point(29, 74)
        btnStartQu.Name = "btnStartQu"
        btnStartQu.Size = New Size(159, 40)
        btnStartQu.TabIndex = 37
        btnStartQu.Text = "Start"
        btnStartQu.UseVisualStyleBackColor = True
        ' 
        ' lblLenght
        ' 
        lblLenght.AutoSize = True
        lblLenght.Location = New Point(29, 18)
        lblLenght.Name = "lblLenght"
        lblLenght.Size = New Size(54, 20)
        lblLenght.TabIndex = 35
        lblLenght.Text = "Lenght"
        ' 
        ' txtLenghtsQu
        ' 
        txtLenghtsQu.ImeMode = ImeMode.NoControl
        txtLenghtsQu.Location = New Point(29, 41)
        txtLenghtsQu.Name = "txtLenghtsQu"
        txtLenghtsQu.Size = New Size(253, 27)
        txtLenghtsQu.TabIndex = 34
        ' 
        ' gbxPriorityQue
        ' 
        gbxPriorityQue.Controls.Add(label3)
        gbxPriorityQue.Controls.Add(txtPriorityQ)
        gbxPriorityQue.Location = New Point(99, 172)
        gbxPriorityQue.Name = "gbxPriorityQue"
        gbxPriorityQue.Size = New Size(324, 69)
        gbxPriorityQue.TabIndex = 33
        gbxPriorityQue.TabStop = False
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(32, 10)
        label3.Name = "label3"
        label3.Size = New Size(56, 20)
        label3.TabIndex = 32
        label3.Text = "Priority"
        ' 
        ' txtPriorityQ
        ' 
        txtPriorityQ.ImeMode = ImeMode.NoControl
        txtPriorityQ.Location = New Point(32, 33)
        txtPriorityQ.Name = "txtPriorityQ"
        txtPriorityQ.Size = New Size(253, 27)
        txtPriorityQ.TabIndex = 31
        ' 
        ' pnlStacks
        ' 
        pnlStacks.Controls.Add(gbxMenuStackAll)
        pnlStacks.Controls.Add(gbxMenuStatickStack)
        pnlStacks.Controls.Add(lsbStacks)
        pnlStacks.Location = New Point(-5, 31)
        pnlStacks.Name = "pnlStacks"
        pnlStacks.Size = New Size(1135, 501)
        pnlStacks.TabIndex = 17
        ' 
        ' gbxMenuStackAll
        ' 
        gbxMenuStackAll.Controls.Add(btnPeek)
        gbxMenuStackAll.Controls.Add(btnCount)
        gbxMenuStackAll.Controls.Add(btnPop)
        gbxMenuStackAll.Controls.Add(btnPush)
        gbxMenuStackAll.Controls.Add(label1)
        gbxMenuStackAll.Controls.Add(txtNumberStack)
        gbxMenuStackAll.Location = New Point(55, 168)
        gbxMenuStackAll.Name = "gbxMenuStackAll"
        gbxMenuStackAll.Size = New Size(381, 275)
        gbxMenuStackAll.TabIndex = 23
        gbxMenuStackAll.TabStop = False
        ' 
        ' btnPeek
        ' 
        btnPeek.Location = New Point(40, 170)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(159, 40)
        btnPeek.TabIndex = 19
        btnPeek.Text = "Peek"
        btnPeek.UseVisualStyleBackColor = True
        ' 
        ' btnCount
        ' 
        btnCount.Location = New Point(40, 216)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(159, 40)
        btnCount.TabIndex = 18
        btnCount.Text = "Count"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' btnPop
        ' 
        btnPop.Location = New Point(40, 124)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(159, 40)
        btnPop.TabIndex = 17
        btnPop.Text = "Pop"
        btnPop.UseVisualStyleBackColor = True
        ' 
        ' btnPush
        ' 
        btnPush.Location = New Point(40, 78)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(159, 40)
        btnPush.TabIndex = 16
        btnPush.Text = "Push"
        btnPush.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(40, 16)
        label1.Name = "label1"
        label1.Size = New Size(63, 20)
        label1.TabIndex = 15
        label1.Text = "Number"
        ' 
        ' txtNumberStack
        ' 
        txtNumberStack.ImeMode = ImeMode.NoControl
        txtNumberStack.Location = New Point(40, 39)
        txtNumberStack.Name = "txtNumberStack"
        txtNumberStack.Size = New Size(253, 27)
        txtNumberStack.TabIndex = 14
        ' 
        ' gbxMenuStatickStack
        ' 
        gbxMenuStatickStack.Controls.Add(btnLengthStack)
        gbxMenuStatickStack.Controls.Add(lblLenghtStack)
        gbxMenuStatickStack.Controls.Add(txtLengthStacks)
        gbxMenuStatickStack.Location = New Point(64, 40)
        gbxMenuStatickStack.Name = "gbxMenuStatickStack"
        gbxMenuStatickStack.Size = New Size(318, 131)
        gbxMenuStatickStack.TabIndex = 22
        gbxMenuStatickStack.TabStop = False
        ' 
        ' btnLengthStack
        ' 
        btnLengthStack.Location = New Point(31, 82)
        btnLengthStack.Name = "btnLengthStack"
        btnLengthStack.Size = New Size(159, 40)
        btnLengthStack.TabIndex = 21
        btnLengthStack.Text = "Start"
        btnLengthStack.UseVisualStyleBackColor = True
        ' 
        ' lblLenghtStack
        ' 
        lblLenghtStack.AutoSize = True
        lblLenghtStack.Location = New Point(31, 22)
        lblLenghtStack.Name = "lblLenghtStack"
        lblLenghtStack.Size = New Size(148, 20)
        lblLenghtStack.TabIndex = 20
        lblLenghtStack.Text = "Lenght of static stack"
        ' 
        ' txtLengthStacks
        ' 
        txtLengthStacks.ImeMode = ImeMode.NoControl
        txtLengthStacks.Location = New Point(31, 45)
        txtLengthStacks.Name = "txtLengthStacks"
        txtLengthStacks.Size = New Size(253, 27)
        txtLengthStacks.TabIndex = 19
        ' 
        ' lsbStacks
        ' 
        lsbStacks.Font = New Font("Segoe UI", 12F)
        lsbStacks.FormattingEnabled = True
        lsbStacks.ItemHeight = 28
        lsbStacks.Location = New Point(627, 85)
        lsbStacks.Margin = New Padding(3, 4, 3, 4)
        lsbStacks.Name = "lsbStacks"
        lsbStacks.Size = New Size(394, 340)
        lsbStacks.TabIndex = 13
        ' 
        ' pnlTree
        ' 
        pnlTree.Controls.Add(treeView)
        pnlTree.Controls.Add(btnSearchTreeN)
        pnlTree.Controls.Add(btnDeleteTreeN)
        pnlTree.Controls.Add(label7)
        pnlTree.Controls.Add(lsbInOrder)
        pnlTree.Controls.Add(label6)
        pnlTree.Controls.Add(lsbPostOrder)
        pnlTree.Controls.Add(label5)
        pnlTree.Controls.Add(lsbPreorder)
        pnlTree.Controls.Add(lblBinaryTree)
        pnlTree.Controls.Add(btnAdd)
        pnlTree.Controls.Add(label4)
        pnlTree.Controls.Add(txtNumberBinaryTree)
        pnlTree.Location = New Point(0, 31)
        pnlTree.Name = "pnlTree"
        pnlTree.Size = New Size(1134, 498)
        pnlTree.TabIndex = 18
        ' 
        ' treeView
        ' 
        treeView.AllowDrop = True
        treeView.Location = New Point(54, 68)
        treeView.Name = "treeView"
        treeView.Size = New Size(318, 409)
        treeView.TabIndex = 50
        ' 
        ' btnSearchTreeN
        ' 
        btnSearchTreeN.Location = New Point(743, 279)
        btnSearchTreeN.Name = "btnSearchTreeN"
        btnSearchTreeN.Size = New Size(159, 40)
        btnSearchTreeN.TabIndex = 49
        btnSearchTreeN.Text = "Search"
        btnSearchTreeN.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTreeN
        ' 
        btnDeleteTreeN.Location = New Point(743, 233)
        btnDeleteTreeN.Name = "btnDeleteTreeN"
        btnDeleteTreeN.Size = New Size(159, 40)
        btnDeleteTreeN.TabIndex = 48
        btnDeleteTreeN.Text = "Delete"
        btnDeleteTreeN.UseVisualStyleBackColor = True
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label7.Location = New Point(423, 337)
        label7.Name = "label7"
        label7.Size = New Size(101, 26)
        label7.TabIndex = 47
        label7.Text = "InOrder"
        ' 
        ' lsbInOrder
        ' 
        lsbInOrder.Font = New Font("Segoe UI", 12F)
        lsbInOrder.FormattingEnabled = True
        lsbInOrder.ItemHeight = 28
        lsbInOrder.Location = New Point(423, 367)
        lsbInOrder.Margin = New Padding(3, 4, 3, 4)
        lsbInOrder.Name = "lsbInOrder"
        lsbInOrder.Size = New Size(234, 116)
        lsbInOrder.TabIndex = 46
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label6.Location = New Point(423, 170)
        label6.Name = "label6"
        label6.Size = New Size(124, 26)
        label6.TabIndex = 45
        label6.Text = "PostOrder"
        ' 
        ' lsbPostOrder
        ' 
        lsbPostOrder.Font = New Font("Segoe UI", 12F)
        lsbPostOrder.FormattingEnabled = True
        lsbPostOrder.ItemHeight = 28
        lsbPostOrder.Location = New Point(423, 200)
        lsbPostOrder.Margin = New Padding(3, 4, 3, 4)
        lsbPostOrder.Name = "lsbPostOrder"
        lsbPostOrder.Size = New Size(234, 116)
        lsbPostOrder.TabIndex = 44
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label5.Location = New Point(423, 14)
        label5.Name = "label5"
        label5.Size = New Size(109, 26)
        label5.TabIndex = 43
        label5.Text = "Preorder"
        ' 
        ' lsbPreorder
        ' 
        lsbPreorder.Font = New Font("Segoe UI", 12F)
        lsbPreorder.FormattingEnabled = True
        lsbPreorder.ItemHeight = 28
        lsbPreorder.Location = New Point(423, 44)
        lsbPreorder.Margin = New Padding(3, 4, 3, 4)
        lsbPreorder.Name = "lsbPreorder"
        lsbPreorder.Size = New Size(234, 116)
        lsbPreorder.TabIndex = 42
        ' 
        ' lblBinaryTree
        ' 
        lblBinaryTree.AutoSize = True
        lblBinaryTree.Font = New Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBinaryTree.Location = New Point(54, 27)
        lblBinaryTree.Name = "lblBinaryTree"
        lblBinaryTree.Size = New Size(183, 34)
        lblBinaryTree.TabIndex = 41
        lblBinaryTree.Text = "Binary Tree"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(743, 187)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(159, 40)
        btnAdd.TabIndex = 40
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(743, 119)
        label4.Name = "label4"
        label4.Size = New Size(63, 20)
        label4.TabIndex = 39
        label4.Text = "Number"
        ' 
        ' txtNumberBinaryTree
        ' 
        txtNumberBinaryTree.ImeMode = ImeMode.NoControl
        txtNumberBinaryTree.Location = New Point(743, 142)
        txtNumberBinaryTree.Name = "txtNumberBinaryTree"
        txtNumberBinaryTree.Size = New Size(253, 27)
        txtNumberBinaryTree.TabIndex = 38
        ' 
        ' pnlGraph
        ' 
        pnlGraph.Controls.Add(btnFindAwayGraph)
        pnlGraph.Controls.Add(btnToursDFSGraph)
        pnlGraph.Controls.Add(btnAddEdgeGraph)
        pnlGraph.Controls.Add(btnDeleteGraph)
        pnlGraph.Controls.Add(label14)
        pnlGraph.Controls.Add(label13)
        pnlGraph.Controls.Add(label12)
        pnlGraph.Controls.Add(txtOriginGraph)
        pnlGraph.Controls.Add(label11)
        pnlGraph.Controls.Add(txtWeightGraph)
        pnlGraph.Controls.Add(label10)
        pnlGraph.Controls.Add(txtDestinationGraph)
        pnlGraph.Controls.Add(lsbTourGraph)
        pnlGraph.Controls.Add(lsbAdyacencyMatrixGraph)
        pnlGraph.Controls.Add(btnAddVertGraph)
        pnlGraph.Controls.Add(label9)
        pnlGraph.Controls.Add(txtNumberGraph)
        pnlGraph.Controls.Add(label8)
        pnlGraph.Controls.Add(lsbGraph)
        pnlGraph.Location = New Point(-2, 31)
        pnlGraph.Name = "pnlGraph"
        pnlGraph.Size = New Size(1133, 498)
        pnlGraph.TabIndex = 19
        ' 
        ' btnFindAwayGraph
        ' 
        btnFindAwayGraph.Location = New Point(565, 46)
        btnFindAwayGraph.Name = "btnFindAwayGraph"
        btnFindAwayGraph.Size = New Size(159, 40)
        btnFindAwayGraph.TabIndex = 62
        btnFindAwayGraph.Text = "Find way"
        btnFindAwayGraph.UseVisualStyleBackColor = True
        ' 
        ' btnToursDFSGraph
        ' 
        btnToursDFSGraph.Location = New Point(471, 101)
        btnToursDFSGraph.Name = "btnToursDFSGraph"
        btnToursDFSGraph.Size = New Size(159, 40)
        btnToursDFSGraph.TabIndex = 61
        btnToursDFSGraph.Text = "Tours DFS"
        btnToursDFSGraph.UseVisualStyleBackColor = True
        ' 
        ' btnAddEdgeGraph
        ' 
        btnAddEdgeGraph.Location = New Point(306, 101)
        btnAddEdgeGraph.Name = "btnAddEdgeGraph"
        btnAddEdgeGraph.Size = New Size(159, 40)
        btnAddEdgeGraph.TabIndex = 60
        btnAddEdgeGraph.Text = "Add edge"
        btnAddEdgeGraph.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteGraph
        ' 
        btnDeleteGraph.Location = New Point(935, 89)
        btnDeleteGraph.Name = "btnDeleteGraph"
        btnDeleteGraph.Size = New Size(159, 40)
        btnDeleteGraph.TabIndex = 59
        btnDeleteGraph.Text = "Delete"
        btnDeleteGraph.UseVisualStyleBackColor = True
        ' 
        ' label14
        ' 
        label14.AutoSize = True
        label14.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label14.Location = New Point(810, 175)
        label14.Name = "label14"
        label14.Size = New Size(108, 26)
        label14.TabIndex = 58
        label14.Text = "DFS tour"
        ' 
        ' label13
        ' 
        label13.AutoSize = True
        label13.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label13.Location = New Point(29, 175)
        label13.Name = "label13"
        label13.Size = New Size(83, 26)
        label13.TabIndex = 57
        label13.Text = "Graph"
        ' 
        ' label12
        ' 
        label12.AutoSize = True
        label12.Location = New Point(306, 33)
        label12.Name = "label12"
        label12.Size = New Size(50, 20)
        label12.TabIndex = 56
        label12.Text = "Origin"
        ' 
        ' txtOriginGraph
        ' 
        txtOriginGraph.ImeMode = ImeMode.NoControl
        txtOriginGraph.Location = New Point(306, 56)
        txtOriginGraph.Name = "txtOriginGraph"
        txtOriginGraph.Size = New Size(253, 27)
        txtOriginGraph.TabIndex = 55
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(29, 89)
        label11.Name = "label11"
        label11.Size = New Size(56, 20)
        label11.TabIndex = 54
        label11.Text = "Weight"
        ' 
        ' txtWeightGraph
        ' 
        txtWeightGraph.ImeMode = ImeMode.NoControl
        txtWeightGraph.Location = New Point(29, 112)
        txtWeightGraph.Name = "txtWeightGraph"
        txtWeightGraph.Size = New Size(253, 27)
        txtWeightGraph.TabIndex = 53
        ' 
        ' label10
        ' 
        label10.AutoSize = True
        label10.Location = New Point(29, 33)
        label10.Name = "label10"
        label10.Size = New Size(85, 20)
        label10.TabIndex = 52
        label10.Text = "Destination"
        ' 
        ' txtDestinationGraph
        ' 
        txtDestinationGraph.ImeMode = ImeMode.NoControl
        txtDestinationGraph.Location = New Point(29, 56)
        txtDestinationGraph.Name = "txtDestinationGraph"
        txtDestinationGraph.Size = New Size(253, 27)
        txtDestinationGraph.TabIndex = 51
        ' 
        ' lsbTourGraph
        ' 
        lsbTourGraph.Font = New Font("Segoe UI", 12F)
        lsbTourGraph.FormattingEnabled = True
        lsbTourGraph.ItemHeight = 28
        lsbTourGraph.Location = New Point(810, 203)
        lsbTourGraph.Margin = New Padding(3, 4, 3, 4)
        lsbTourGraph.Name = "lsbTourGraph"
        lsbTourGraph.Size = New Size(295, 284)
        lsbTourGraph.TabIndex = 50
        ' 
        ' lsbAdyacencyMatrixGraph
        ' 
        lsbAdyacencyMatrixGraph.Font = New Font("Segoe UI", 12F)
        lsbAdyacencyMatrixGraph.FormattingEnabled = True
        lsbAdyacencyMatrixGraph.ItemHeight = 28
        lsbAdyacencyMatrixGraph.Location = New Point(368, 203)
        lsbAdyacencyMatrixGraph.Margin = New Padding(3, 4, 3, 4)
        lsbAdyacencyMatrixGraph.Name = "lsbAdyacencyMatrixGraph"
        lsbAdyacencyMatrixGraph.Size = New Size(391, 284)
        lsbAdyacencyMatrixGraph.TabIndex = 49
        ' 
        ' btnAddVertGraph
        ' 
        btnAddVertGraph.Location = New Point(770, 89)
        btnAddVertGraph.Name = "btnAddVertGraph"
        btnAddVertGraph.Size = New Size(159, 40)
        btnAddVertGraph.TabIndex = 48
        btnAddVertGraph.Text = "Add"
        btnAddVertGraph.UseVisualStyleBackColor = True
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Location = New Point(770, 33)
        label9.Name = "label9"
        label9.Size = New Size(63, 20)
        label9.TabIndex = 47
        label9.Text = "Number"
        ' 
        ' txtNumberGraph
        ' 
        txtNumberGraph.ImeMode = ImeMode.NoControl
        txtNumberGraph.Location = New Point(770, 56)
        txtNumberGraph.Name = "txtNumberGraph"
        txtNumberGraph.Size = New Size(253, 27)
        txtNumberGraph.TabIndex = 46
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label8.Location = New Point(368, 175)
        label8.Name = "label8"
        label8.Size = New Size(207, 26)
        label8.TabIndex = 45
        label8.Text = "Adjacency matrix"
        ' 
        ' lsbGraph
        ' 
        lsbGraph.Font = New Font("Segoe UI", 12F)
        lsbGraph.FormattingEnabled = True
        lsbGraph.ItemHeight = 28
        lsbGraph.Location = New Point(29, 203)
        lsbGraph.Margin = New Padding(3, 4, 3, 4)
        lsbGraph.Name = "lsbGraph"
        lsbGraph.Size = New Size(295, 284)
        lsbGraph.TabIndex = 44
        ' 
        ' pnlAlgorithmsOfSorting
        ' 
        pnlAlgorithmsOfSorting.Controls.Add(label18)
        pnlAlgorithmsOfSorting.Controls.Add(txtMaximumRangeAlgorithms)
        pnlAlgorithmsOfSorting.Controls.Add(label17)
        pnlAlgorithmsOfSorting.Controls.Add(txtMinimumRangeAlgorithms)
        pnlAlgorithmsOfSorting.Controls.Add(label16)
        pnlAlgorithmsOfSorting.Controls.Add(lsbAlgorithmSorting)
        pnlAlgorithmsOfSorting.Controls.Add(btnCantOfItemsAlgorithms)
        pnlAlgorithmsOfSorting.Controls.Add(label15)
        pnlAlgorithmsOfSorting.Controls.Add(txtNumbersOfItemstoOrder)
        pnlAlgorithmsOfSorting.Location = New Point(-5, 31)
        pnlAlgorithmsOfSorting.Name = "pnlAlgorithmsOfSorting"
        pnlAlgorithmsOfSorting.Size = New Size(1135, 501)
        pnlAlgorithmsOfSorting.TabIndex = 20
        ' 
        ' label18
        ' 
        label18.AutoSize = True
        label18.Location = New Point(86, 213)
        label18.Name = "label18"
        label18.Size = New Size(117, 20)
        label18.TabIndex = 69
        label18.Text = "Maximum range"
        ' 
        ' txtMaximumRangeAlgorithms
        ' 
        txtMaximumRangeAlgorithms.ImeMode = ImeMode.NoControl
        txtMaximumRangeAlgorithms.Location = New Point(86, 236)
        txtMaximumRangeAlgorithms.Name = "txtMaximumRangeAlgorithms"
        txtMaximumRangeAlgorithms.Size = New Size(253, 27)
        txtMaximumRangeAlgorithms.TabIndex = 68
        ' 
        ' label17
        ' 
        label17.AutoSize = True
        label17.Location = New Point(86, 137)
        label17.Name = "label17"
        label17.Size = New Size(114, 20)
        label17.TabIndex = 67
        label17.Text = "Minimum range"
        ' 
        ' txtMinimumRangeAlgorithms
        ' 
        txtMinimumRangeAlgorithms.ImeMode = ImeMode.NoControl
        txtMinimumRangeAlgorithms.Location = New Point(86, 160)
        txtMinimumRangeAlgorithms.Name = "txtMinimumRangeAlgorithms"
        txtMinimumRangeAlgorithms.Size = New Size(253, 27)
        txtMinimumRangeAlgorithms.TabIndex = 66
        ' 
        ' label16
        ' 
        label16.AutoSize = True
        label16.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label16.Location = New Point(725, 37)
        label16.Name = "label16"
        label16.Size = New Size(127, 26)
        label16.TabIndex = 65
        label16.Text = "Algorithm"
        ' 
        ' lsbAlgorithmSorting
        ' 
        lsbAlgorithmSorting.Font = New Font("Segoe UI", 12F)
        lsbAlgorithmSorting.FormattingEnabled = True
        lsbAlgorithmSorting.ItemHeight = 28
        lsbAlgorithmSorting.Location = New Point(553, 72)
        lsbAlgorithmSorting.Margin = New Padding(3, 4, 3, 4)
        lsbAlgorithmSorting.Name = "lsbAlgorithmSorting"
        lsbAlgorithmSorting.Size = New Size(470, 368)
        lsbAlgorithmSorting.TabIndex = 64
        ' 
        ' btnCantOfItemsAlgorithms
        ' 
        btnCantOfItemsAlgorithms.Location = New Point(86, 295)
        btnCantOfItemsAlgorithms.Name = "btnCantOfItemsAlgorithms"
        btnCantOfItemsAlgorithms.Size = New Size(159, 40)
        btnCantOfItemsAlgorithms.TabIndex = 62
        btnCantOfItemsAlgorithms.Text = "Add"
        btnCantOfItemsAlgorithms.UseVisualStyleBackColor = True
        ' 
        ' label15
        ' 
        label15.AutoSize = True
        label15.Location = New Point(86, 65)
        label15.Name = "label15"
        label15.Size = New Size(179, 20)
        label15.TabIndex = 61
        label15.Text = "Number of items to order"
        ' 
        ' txtNumbersOfItemstoOrder
        ' 
        txtNumbersOfItemstoOrder.ImeMode = ImeMode.NoControl
        txtNumbersOfItemstoOrder.Location = New Point(86, 88)
        txtNumbersOfItemstoOrder.Name = "txtNumbersOfItemstoOrder"
        txtNumbersOfItemstoOrder.Size = New Size(253, 27)
        txtNumbersOfItemstoOrder.TabIndex = 60
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 527)
        Controls.Add(pnlAlgorithmsOfSorting)
        Controls.Add(pnlGraph)
        Controls.Add(pnlTree)
        Controls.Add(pnlQueues)
        Controls.Add(pnlStacks)
        Controls.Add(pnlLists)
        Controls.Add(MenuStrip1)
        Controls.Add(lblBeggininMessage)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlLists.ResumeLayout(False)
        pnlLists.PerformLayout()
        pnlQueues.ResumeLayout(False)
        pnlQueues.PerformLayout()
        gbxQueueCircularM.ResumeLayout(False)
        gbxQueueCircularM.PerformLayout()
        gbxCircularQ.ResumeLayout(False)
        gbxCircularQLenght.ResumeLayout(False)
        gbxCircularQLenght.PerformLayout()
        gbxPriorityQue.ResumeLayout(False)
        gbxPriorityQue.PerformLayout()
        pnlStacks.ResumeLayout(False)
        gbxMenuStackAll.ResumeLayout(False)
        gbxMenuStackAll.PerformLayout()
        gbxMenuStatickStack.ResumeLayout(False)
        gbxMenuStatickStack.PerformLayout()
        pnlTree.ResumeLayout(False)
        pnlTree.PerformLayout()
        pnlGraph.ResumeLayout(False)
        pnlGraph.PerformLayout()
        pnlAlgorithmsOfSorting.ResumeLayout(False)
        pnlAlgorithmsOfSorting.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircularListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoublyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircularDoublyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents _StacksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaticSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DinamicStackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegularQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoubleQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriorityQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircularQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortingAlgorithmsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pnlLists As Panel
    Private WithEvents btnClear As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnShowReverse As Button
    Private WithEvents btnSearch As Button
    Private WithEvents listLista As ListBox
    Private WithEvents btnSend As Button
    Private WithEvents lblNumbers As Label
    Private WithEvents txtNumbers As TextBox
    Private WithEvents lblBeggininMessage As Label
    Private WithEvents pnlQueues As Panel
    Private WithEvents lblQueue As Label
    Private WithEvents gbxQueueCircularM As GroupBox
    Private WithEvents btnPeekQ As Button
    Private WithEvents btnDequeue As Button
    Private WithEvents btnEnqueue As Button
    Private WithEvents gbxCircularQ As GroupBox
    Private WithEvents btnPeekQRear As Button
    Private WithEvents btnDequeueRear As Button
    Private WithEvents btnEnqueueRear As Button
    Private WithEvents label2 As Label
    Private WithEvents txtNumbersQueue As TextBox
    Private WithEvents gbxCircularQLenght As GroupBox
    Private WithEvents btnStartQu As Button
    Private WithEvents lblLenght As Label
    Private WithEvents txtLenghtsQu As TextBox
    Private WithEvents gbxPriorityQue As GroupBox
    Private WithEvents label3 As Label
    Private WithEvents txtPriorityQ As TextBox
    Private WithEvents lsbQueues As ListBox
    Private WithEvents pnlStacks As Panel
    Private WithEvents gbxMenuStackAll As GroupBox
    Private WithEvents btnPeek As Button
    Private WithEvents btnCount As Button
    Private WithEvents btnPop As Button
    Private WithEvents btnPush As Button
    Private WithEvents label1 As Label
    Private WithEvents txtNumberStack As TextBox
    Private WithEvents gbxMenuStatickStack As GroupBox
    Private WithEvents btnLengthStack As Button
    Private WithEvents lblLenghtStack As Label
    Private WithEvents txtLengthStacks As TextBox
    Private WithEvents lsbStacks As ListBox
    Private WithEvents pnlTree As Panel
    Private WithEvents treeView As TreeView
    Private WithEvents btnSearchTreeN As Button
    Private WithEvents btnDeleteTreeN As Button
    Private WithEvents label7 As Label
    Private WithEvents lsbInOrder As ListBox
    Private WithEvents label6 As Label
    Private WithEvents lsbPostOrder As ListBox
    Private WithEvents label5 As Label
    Private WithEvents lsbPreorder As ListBox
    Private WithEvents lblBinaryTree As Label
    Private WithEvents btnAdd As Button
    Private WithEvents label4 As Label
    Private WithEvents txtNumberBinaryTree As TextBox
    Private WithEvents pnlGraph As Panel
    Private WithEvents btnFindAwayGraph As Button
    Private WithEvents btnToursDFSGraph As Button
    Private WithEvents btnAddEdgeGraph As Button
    Private WithEvents btnDeleteGraph As Button
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents txtOriginGraph As TextBox
    Private WithEvents label11 As Label
    Private WithEvents txtWeightGraph As TextBox
    Private WithEvents label10 As Label
    Private WithEvents txtDestinationGraph As TextBox
    Private WithEvents lsbTourGraph As ListBox
    Private WithEvents lsbAdyacencyMatrixGraph As ListBox
    Private WithEvents btnAddVertGraph As Button
    Private WithEvents label9 As Label
    Private WithEvents txtNumberGraph As TextBox
    Private WithEvents label8 As Label
    Private WithEvents lsbGraph As ListBox
    Private WithEvents pnlAlgorithmsOfSorting As Panel
    Private WithEvents label18 As Label
    Private WithEvents txtMaximumRangeAlgorithms As TextBox
    Private WithEvents label17 As Label
    Private WithEvents txtMinimumRangeAlgorithms As TextBox
    Private WithEvents label16 As Label
    Private WithEvents lsbAlgorithmSorting As ListBox
    Private WithEvents btnCantOfItemsAlgorithms As Button
    Private WithEvents label15 As Label
    Private WithEvents txtNumbersOfItemstoOrder As TextBox
    Friend WithEvents BinaryTreeSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BubbleSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BucketSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CombSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountingSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GnomeSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeapSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertionSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MergeSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PigeonholeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadixSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShellSortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmoothSortToolStripMenuItem As ToolStripMenuItem

End Class
