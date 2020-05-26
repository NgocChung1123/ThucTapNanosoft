Public Class DMQuanHuyenFacede
    Private IDMQuanHuyen As DataAccess.DMQuanHuyenDA = New DataAccess.DMQuanHuyenDA
    Public Function SelectAllDMQuanHuyenByIDTinhThanh(ByVal IDTinhThanh As String) As List(Of Common.DMQuanHuyenEntity)
        Return IDMQuanHuyen.SelectAllDMQuanHuyen(IDTinhThanh)
    End Function
End Class
