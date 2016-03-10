Public Class Hero
    Inherits Person

    Public Property Ability As String

    Sub New(ByVal pName As String, ByVal pAbility As String)
        MyBase.New(pName)
        Ability = pAbility
    End Sub


    Public Overrides Function ToString() As String
        Return "I'm " & Name & ", the " & Ability
    End Function

End Class
