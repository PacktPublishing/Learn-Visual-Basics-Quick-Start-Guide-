Public Class HWGrade
    Inherits Grade
    Private pdSubmitted As Date

    Public Sub New(piScore As Integer, pdSubmitted As Date)
        Me.Score = piScore
        Me.pdSubmitted = pdSubmitted
    End Sub

    Public Property Submitted As Date
        Get
            Return pdSubmitted
        End Get
        Set(value As Date)
            pdSubmitted = value
        End Set
    End Property
End Class
