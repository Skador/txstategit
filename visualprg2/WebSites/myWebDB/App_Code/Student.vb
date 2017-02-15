Imports Microsoft.VisualBasic

Public Class Student

    Dim studID As Integer
    Dim firstName As String
    Dim lastName As String

    Public Property ID As Integer
        Get
            Return studID
        End Get
        Set(ByVal value As Integer)
            studID = value
        End Set
    End Property

    Public Property First As Integer
        Get
            Return firstName
        End Get
        Set(ByVal value As Integer)
            firstName = value
        End Set
    End Property

    Public Property Last As Integer
        Get
            Return lastName
        End Get
        Set(ByVal value As Integer)
            lastName = value
        End Set
    End Property
End Class
