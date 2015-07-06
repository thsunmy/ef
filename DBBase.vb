Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Web

Public Class DBBase
    Private _Database1Entity As New Database1Entities()


    Public ReadOnly Property Database1Entity() As Database1Entities
        Get
            Return _Database1Entity
        End Get
    End Property
End Class
