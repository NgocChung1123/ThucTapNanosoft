Public Class DMQuocGiaEntity
    Implements IDMQuocGiaEntity

    Public Const Column_IDQuocGia As String = "IDQuocGia"
    Public Const Column_TenQuocGia As String = "TenQuocGia"
    Public Const Column_MoTaQuocGia As String = "MoTaQuocGia"
    Public Const Column_MaQuocGia As String = "MaQuocGia"
    Public Const Column_GhiChu As String = "GhiChu"
    Public Const Column_TrangThaiSuDung As String = "TrangThaiSuDung"

    Private _IDQuocGia As String
    Private _TenQuocGia As String
    Private _MoTaQuocGia As String
    Private _TrangThaiSuDung As String
    Private _MaQuocGia As String
    Private _GhiChu As String

    Public Property IDQuocGia As String Implements IDMQuocGiaEntity.IDQuocGia
        Get
            Return _IDQuocGia
        End Get
        Set(ByVal value As String)
            _IDQuocGia = value
        End Set
    End Property

    Public Property TenQuocGia As String Implements IDMQuocGiaEntity.TenQuocGia
        Get
            Return _TenQuocGia
        End Get
        Set(ByVal value As String)
            _TenQuocGia = value
        End Set
    End Property

    Public Property MoTaQuocGia As String Implements IDMQuocGiaEntity.MoTaQuocGia
        Get
            Return _MoTaQuocGia
        End Get
        Set(ByVal value As String)
            _MoTaQuocGia = value
        End Set
    End Property

    Public Property MaQuocGia As String Implements IDMQuocGiaEntity.MaQuocGia
        Get
            Return _MaQuocGia
        End Get
        Set(ByVal value As String)
            _MaQuocGia = value
        End Set
    End Property

    Public Property TrangThaiSuDung As String Implements IDMQuocGiaEntity.TrangThaiSuDung
        Get
            Return _TrangThaiSuDung
        End Get
        Set(ByVal value As String)
            _TrangThaiSuDung = value
        End Set
    End Property

    Public Property GhiChu As String Implements IDMQuocGiaEntity.GhiChu
        Get
            Return _GhiChu
        End Get
        Set(ByVal value As String)
            _GhiChu = value
        End Set
    End Property

End Class
