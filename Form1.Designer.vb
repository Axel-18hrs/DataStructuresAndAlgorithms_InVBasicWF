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
        StacksToolStripMenuItem = New ToolStripMenuItem()
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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListsToolStripMenuItem, StacksToolStripMenuItem, QueuesToolStripMenuItem, TreeToolStripMenuItem, GraphsToolStripMenuItem, SortingAlgorithmsToolStripMenuItem})
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
        SimpleListToolStripMenuItem.Size = New Size(224, 26)
        SimpleListToolStripMenuItem.Text = "Simple List"
        ' 
        ' CircularListToolStripMenuItem
        ' 
        CircularListToolStripMenuItem.Name = "CircularListToolStripMenuItem"
        CircularListToolStripMenuItem.Size = New Size(224, 26)
        CircularListToolStripMenuItem.Text = "Circular List"
        ' 
        ' DoublyListToolStripMenuItem
        ' 
        DoublyListToolStripMenuItem.Name = "DoublyListToolStripMenuItem"
        DoublyListToolStripMenuItem.Size = New Size(224, 26)
        DoublyListToolStripMenuItem.Text = "Doubly List"
        ' 
        ' CircularDoublyListToolStripMenuItem
        ' 
        CircularDoublyListToolStripMenuItem.Name = "CircularDoublyListToolStripMenuItem"
        CircularDoublyListToolStripMenuItem.Size = New Size(224, 26)
        CircularDoublyListToolStripMenuItem.Text = "Circular Doubly List"
        ' 
        ' StacksToolStripMenuItem
        ' 
        StacksToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StaticSToolStripMenuItem, DinamicStackToolStripMenuItem})
        StacksToolStripMenuItem.Name = "StacksToolStripMenuItem"
        StacksToolStripMenuItem.Size = New Size(64, 24)
        StacksToolStripMenuItem.Text = "Stacks"
        ' 
        ' StaticSToolStripMenuItem
        ' 
        StaticSToolStripMenuItem.Name = "StaticSToolStripMenuItem"
        StaticSToolStripMenuItem.Size = New Size(224, 26)
        StaticSToolStripMenuItem.Text = "Static Stack"
        ' 
        ' DinamicStackToolStripMenuItem
        ' 
        DinamicStackToolStripMenuItem.Name = "DinamicStackToolStripMenuItem"
        DinamicStackToolStripMenuItem.Size = New Size(224, 26)
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
        RegularQueueToolStripMenuItem.Size = New Size(224, 26)
        RegularQueueToolStripMenuItem.Text = "Regular Queue"
        ' 
        ' DoubleQueueToolStripMenuItem
        ' 
        DoubleQueueToolStripMenuItem.Name = "DoubleQueueToolStripMenuItem"
        DoubleQueueToolStripMenuItem.Size = New Size(224, 26)
        DoubleQueueToolStripMenuItem.Text = "Double Queue"
        ' 
        ' PriorityQueueToolStripMenuItem
        ' 
        PriorityQueueToolStripMenuItem.Name = "PriorityQueueToolStripMenuItem"
        PriorityQueueToolStripMenuItem.Size = New Size(224, 26)
        PriorityQueueToolStripMenuItem.Text = "Priority Queue"
        ' 
        ' CircularQueueToolStripMenuItem
        ' 
        CircularQueueToolStripMenuItem.Name = "CircularQueueToolStripMenuItem"
        CircularQueueToolStripMenuItem.Size = New Size(224, 26)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 527)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircularListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoublyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircularDoublyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StacksToolStripMenuItem As ToolStripMenuItem
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

End Class
