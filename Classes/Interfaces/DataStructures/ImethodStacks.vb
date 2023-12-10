Friend Interface ImethodStacks(Of T)
    Sub Push(element As T)
    Function Pop() As T
    Function Peek() As T
    Function Show() As IEnumerable(Of T)
    Function Count() As Integer
End Interface
