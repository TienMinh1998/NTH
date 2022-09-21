Public Class cls_LstCoc
    Private _STT As Double
    Private _X As Double
    Private _Y As Double
    Private _Pi As Double
    Private _Poi As Double

    Public Property STT As Double
        Get
            Return _STT
        End Get
        Set(value As Double)
            _STT = value
        End Set
    End Property

    Public Property X As Double
        Get
            Return _X
        End Get
        Set(value As Double)
            _X = value
        End Set
    End Property

    Public Property Y As Double
        Get
            Return _Y
        End Get
        Set(value As Double)
            _Y = value
        End Set
    End Property

    Public Property Pi As Double
        Get
            Return _Pi
        End Get
        Set(value As Double)
            _Pi = value
        End Set
    End Property

    Public Property Poi As Double
        Get
            Return _Poi
        End Get
        Set(value As Double)
            _Poi = value
        End Set
    End Property
End Class
