Public Class NoiLuc
    Private _N As Double
    Private _Mx As Double
    Private _My As Double
    Private _Qx As Double
    Private _Qy As Double
    Public Property Qy() As Double
        Get
            Return _Qy
        End Get
        Set(ByVal value As Double)
            _Qy = value
        End Set
    End Property
    Public Property Qx() As Double
        Get
            Return _Qx
        End Get
        Set(ByVal value As Double)
            _Qx = value
        End Set
    End Property
    Public Property My() As Double
        Get
            Return _My
        End Get
        Set(ByVal value As Double)
            _My = value
        End Set
    End Property
    Public Property Mx() As Double
        Get
            Return _Mx
        End Get
        Set(ByVal value As Double)
            _Mx = value
        End Set
    End Property
    Public Property N() As Double
        Get
            Return _N
        End Get
        Set(ByVal value As Double)
            _N = value
        End Set
    End Property
End Class
