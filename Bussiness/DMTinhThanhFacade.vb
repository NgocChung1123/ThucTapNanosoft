Public Class DMTinhThanhFacade
    Private IDMTinhThanh As DataAccess.DMTinhThanhDA = New DataAccess.DMTinhThanhDA

    Public Function SelectAllDMTinhThanhByIDQuocGia(ByVal IDQuocGia As String) As List(Of Common.DMTinhThanhEntity)
        Return IDMTinhThanh.SelectAllDMTinhThanh(IDQuocGia)
    End Function
End Class
