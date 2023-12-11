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
        SortingAlgorithmsToolStripMenuItem.Name = "SortingAlgorithmsToolStripMenuItem"
        SortingAlgorithmsToolStripMenuItem.Size = New Size(148, 24)
        SortingAlgorithmsToolStripMenuItem.Text = "Sorting Algorithms"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 527)
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

End Class
