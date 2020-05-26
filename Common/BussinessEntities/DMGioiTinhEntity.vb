Public Class DMGioiTinhEntity
    Implements IDMGioiTinhEntity

    Public Const Column_MaGioiTinh As String = "IDGioiTinh"
    Public Const Column_TenGioiTinh As String = "TenGioiTinh"
    Public Const Column_GhiChu As String = "ghiChu"

    Private _IDGioiTinh As String
    Private _TenGioiTinh As String
    Private _GhiChu As String
    Private _MaGioiTinh As String

    Public Property IDGioiTinh() As String Implements IDMGioiTinhEntity.IDGioiTinh
        Get
            Return _IDGioiTinh
        End Get
        Set(ByVal value As String)
            _IDGioiTinh = value
        End Set
    End Property

    Public Property TenGioiTinh() As String Implements IDMGioiTinhEntity.TenGioiTinh
        Get
            Return _TenGioiTinh
        End Get
        Set(ByVal value As String)
            _TenGioiTinh = value
        End Set
    End Property

    Public Property GhiChu() As String Implements IDMGioiTinhEntity.GhiChu
        Get
            Return _GhiChu
        End Get
        Set(ByVal value As String)
            _GhiChu = value
        End Set
    End Property

    Public Property MaGioiTinh() As String
        Get
            Return _IDGioiTinh
        End Get
        Set(ByVal value As String)
            _IDGioiTinh = value
        End Set
    End Property
End Class
