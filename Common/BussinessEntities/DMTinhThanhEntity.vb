Public Class DMTinhThanhEntity
    Implements IDMTinhThanhEntity

    Public Const Column_IDTinhThanh As String = "IDTinhThanh"
    Public Const Column_TenTinhThanh As String = "TenTinhThanh"
    Public Const Column_MoTa As String = "MoTa"
    Public Const Column_TrangThaiSuDung As String = "TrangThaiSuDung"
    Public Const Column_IDQuocGia As String = "IDQuocGia"

    Private _IDTinhThanh As String
    Private _TenTinhThanh As String
    Private _MoTa As String
    Private _TrangThaiSuDung As String
    Private _IDQuocGia As String

    Public Property IDTinhThanh As String Implements IDMTinhThanhEntity.IDTinhThanh
        Get
            Return _IDTinhThanh
        End Get
        Set(ByVal value As String)
            _IDTinhThanh = value
        End Set
    End Property

    Public Property TenTinhThanh As String Implements IDMTinhThanhEntity.TenTinhThanh
        Get
            Return _TenTinhThanh
        End Get
        Set(ByVal value As String)
            _TenTinhThanh = value
        End Set
    End Property

    Public Property MoTa As String Implements IDMTinhThanhEntity.MoTa
        Get
            Return _MoTa
        End Get
        Set(ByVal value As String)
            _MoTa = value
        End Set
    End Property

    Public Property TrangThaiSuDung As String Implements IDMTinhThanhEntity.TrangThaiSuDung
        Get
            Return _TrangThaiSuDung
        End Get
        Set(ByVal value As String)
            _TrangThaiSuDung = value
        End Set
    End Property

    Public Property IDQuocGia As String Implements IDMTinhThanhEntity.IDQuocGia
        Get
            Return _IDQuocGia
        End Get
        Set(ByVal value As String)
            _IDQuocGia = value
        End Set
    End Property
End Class
