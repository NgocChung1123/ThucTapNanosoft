Public Class DMXaPhuongEntity
    Implements IDMXaPhuongEntity

    Public Const Column_MaXa As String = "MaXa"
    Public Const Column_TTenXa As String = "TenXa"
    Public Const Column_MoTa As String = "MoTa"
    Public Const Column_VietTat As String = "VietTat"

    Private _MaXa As String
    Private _TenXa As String
    Private _MoTa As String
    Private _MaQuanHuyen As String
    Private _MaTinhThanh As String
    Private _VietTat As String

    Public Property MaXa As String Implements IDMXaPhuongEntity.MaXa
        Get
            Return _MaXa
        End Get
        Set(ByVal value As String)
            _MaXa = value
        End Set
    End Property

    Public Property TenXa As String Implements IDMXaPhuongEntity.TenXa
        Get
            Return _TenXa
        End Get
        Set(ByVal value As String)
            _TenXa=value
        End Set
    End Property

    Public Property MoTa As String Implements IDMXaPhuongEntity.MoTa
        Get
            Return _MoTa
        End Get
        Set(ByVal value As String)
            _MoTa = value
        End Set

    End Property

    Public Property MaQuanHuyen As String Implements IDMXaPhuongEntity.MaQuanHuyen
        Get
            Return _MaQuanHuyen
        End Get
        Set(ByVal value As String)
            _MaQuanHuyen = value
        End Set
    End Property

    Public Property MaTinhThanh As String Implements IDMXaPhuongEntity.MaTinhThanh
        Get
            Return _MaTinhThanh
        End Get
        Set(ByVal value As String)
            _MaTinhThanh = value
        End Set
    End Property

    Public Property VietTat As String Implements IDMXaPhuongEntity.VietTat
        Get
            Return _VietTat
        End Get
        Set(ByVal value As String)
            _VietTat = value
        End Set
    End Property
End Class
