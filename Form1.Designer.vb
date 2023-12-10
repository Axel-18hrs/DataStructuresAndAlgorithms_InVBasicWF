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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListsToolStripMenuItem})
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

End Class
