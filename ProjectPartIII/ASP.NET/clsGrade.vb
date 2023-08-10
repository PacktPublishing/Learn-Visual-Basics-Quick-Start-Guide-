Public Class Grade
    Private piScore As Integer

    Public Property Score As Integer
        Get
            Return piScore
        End Get
        Set(value As Integer)
            piScore = value
        End Set
    End Property
End Class
