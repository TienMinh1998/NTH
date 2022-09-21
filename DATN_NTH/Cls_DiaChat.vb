Public Class Cls_DiaChat
    Private _Lop As Integer
    Private _LoaiDat As String
    Private _TrangThai As String
    Private _ChieuDay As Double
    Private _DungTrong As Double
    Private _MoDun As Double
    Private _GocMS As Double
    Private _DoRoi As Double
    Private _Qc As Double
    Private _N30 As Double
    Private _Hsk As Double
    Private _Hsa As Double

    Public Property Lop As Integer
        Get
            Return _Lop
        End Get
        Set(value As Integer)
            _Lop = value
        End Set
    End Property

    Public Property LoaiDat As String
        Get
            Return _LoaiDat
        End Get
        Set(value As String)
            _LoaiDat = value
        End Set
    End Property

    Public Property TrangThai As String
        Get
            Return _TrangThai
        End Get
        Set(value As String)
            _TrangThai = value
        End Set
    End Property

    Public Property ChieuDay As Double
        Get
            Return _ChieuDay
        End Get
        Set(value As Double)
            _ChieuDay = value
        End Set
    End Property

    Public Property DungTrong As Double
        Get
            Return _DungTrong
        End Get
        Set(value As Double)
            _DungTrong = value
        End Set
    End Property

    Public Property GocMS As Double
        Get
            Return _GocMS
        End Get
        Set(value As Double)
            _GocMS = value
        End Set
    End Property

    Public Property DoRoi As Double
        Get
            Return _DoRoi
        End Get
        Set(value As Double)
            _DoRoi = value
        End Set
    End Property

    Public Property Qc As Double
        Get
            Return _Qc
        End Get
        Set(value As Double)
            _Qc = value
        End Set
    End Property

    Public Property N30 As Double
        Get
            Return _N30
        End Get
        Set(value As Double)
            _N30 = value
        End Set
    End Property

    Public Property Hsk As Double
        Get
            Return _Hsk
        End Get
        Set(value As Double)
            _Hsk = value
        End Set
    End Property

    Public Property Hsa As Double
        Get
            Return _Hsa
        End Get
        Set(value As Double)
            _Hsa = value
        End Set
    End Property

    Public Property MoDun As Double
        Get
            Return _MoDun
        End Get
        Set(value As Double)
            _MoDun = value
        End Set
    End Property
End Class
