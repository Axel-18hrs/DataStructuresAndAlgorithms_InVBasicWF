Public Interface ImethodLists(Of T)
    Sub Add(data As T)
    Sub Delete(data As T)
    Sub Search(data As T)
    Function Exist(data As T) As Boolean
    Function Show() As IEnumerable(Of T)
    Function ShowRevers() As IEnumerable(Of T)
    Function IsEmpty() As Boolean
    Sub Clear()
End Interface
