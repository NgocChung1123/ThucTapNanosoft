Public Class DMQuanHuyenEntity
    Implements IDMQuanHuyenEntity

    Public Const Column_IDQuanHuyen As String = "IDQuanHuyen"
    Public Const Column_TenQuanHuyen As String = "TenQuanHuyen"
    Public Const Column_MoTa As String = "MoTa"
    Public Const Column_TrangThaiSuDung As String = "TrangThaiSuDung"
    Public Const Column_IDTinhThanh As String = "IDTinhThanh"

    Private _IDQuanHuyen As String
    Private _TenQuanHuyen As String
    Private _MoTa As String
    Private _TrangThaiSuDung As String
    Private _IDTinhThanh As String

    Public Property IDQuanHuyen As String Implements IDMQuanHuyenEntity.IDQuanHuyen
        Get
            Return _IDQuanHuyen
        End Get
        Set(ByVal value As String)
            _IDQuanHuyen = value
        End Set
    End Property

    Public Property TenQuanHuyen As String Implements IDMQuanHuyenEntity.TenQuanHuyen
        Get
            Return _TenQuanHuyen
        End Get
        Set(ByVal value As String)
            _TenQuanHuyen = value
        End Set
    End Property

    Public Property MoTa As String Implements IDMQuanHuyenEntity.MoTa
        Get
            Return _MoTa
        End Get
        Set(ByVal value As String)
            _MoTa = value
        End Set
    End Property

    Public Property TrangThaiSuDung As String Implements IDMQuanHuyenEntity.TrangThaiSuDung
        Get
            Return _TrangThaiSuDung
        End Get
        Set(ByVal value As String)
            _TrangThaiSuDung = value
        End Set
    End Property

    Public Property IDTinhThanh As String Implements IDMQuanHuyenEntity.IDTinhThanh
        Get
            Return _IDTinhThanh
        End Get
        Set(ByVal value As String)
            _IDTinhThanh = value
        End Set
    End Property
End Class
