Public Class TestGrade
    Inherits Grade
    Private piDuration As Integer

    Public Sub New(piScore As Integer, piDuration As Integer)
        Me.Score = piScore
        Me.piDuration = piDuration
    End Sub

    Public Property Duration As Integer
        Get
            Return piDuration
        End Get
        Set(value As Integer)
            piDuration = value
        End Set
    End Property
End Class
