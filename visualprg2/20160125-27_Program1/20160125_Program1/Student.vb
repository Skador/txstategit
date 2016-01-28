Public Class Student
    'Public allows for Variables to be accessable outside the class
    Private firstName As String
    Private lastName As String
    Private studId As Integer
    'Private restricts variables to only be accessable inside the class
    'Private SocialId As Integer

    'For security reasons, Public Properties or Constructors

    'Public Properties (Creates the Getters and Setters)
    Public Property StudentId() As Integer
        Get
            Return studId
        End Get
        Set(ByVal value As Integer)
            'To limit the user from accessing a value, place a restrictive statement
            If value <> 123 Then
                studId = value
            Else
                MsgBox("You are not allowed to register for this class")
            End If
        End Set
    End Property

    Public Property studentFirstName() As String
        Get
            Return firstName
        End Get
        Set(value As String)
            firstName = value
        End Set
    End Property

    Public Property studentLastName() As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property

    'Constructor for New. For Optional: Everything after the first OPTIONAL MUST BE OPTIONAL
    Public Sub New(ByVal pStudId As Integer, Optional ByVal pFirstName As String = "FN", Optional ByVal pLastName As String = "LN")
        studId = pStudId
        firstName = pFirstName
        lastName = pLastName
    End Sub

    'Constuctor for Clear. Clears everything! All the data is removed from the private attributes
    Public Sub Clear()
        studId = 0
        firstName = String.Empty
        lastName = String.Empty
    End Sub

    'Constructor for Talking(), Shows a behaviour consturctor
    Public Sub Talking()
        MsgBox("I don't like Advance VB")
    End Sub

End Class
