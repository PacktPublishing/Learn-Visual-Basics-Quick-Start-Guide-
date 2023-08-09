Public Class QuizGrade
    Inherits Grade
    Private piAttempts As Integer

    Public Sub New(piScore As Integer, piAttempts As Integer)
        Me.Score = piScore
        Me.piAttempts = piAttempts
    End Sub

    Public Property Attempts As Integer
        Get
            Return piAttempts
        End Get
        Set(value As Integer)
            piAttempts = value
        End Set
    End Property
End Class
