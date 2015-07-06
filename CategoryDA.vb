Imports System.Data.Entity.Infrastructure

Public Class CategoryDA
    Inherits DBBase

    Public allCategories As DbQuery(Of Category) = From C In Database1Entity.Categories Select C

End Class
