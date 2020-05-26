Public Class DMQuocGiaFacede
    Private IDMQuocGia As DataAccess.DMQuocGiaDA = New DataAccess.DMQuocGiaDA

    Public Function SelectAllDMQuocGia() As List(Of Common.DMQuocGiaEntity)
        Return IDMQuocGia.SelectAllDMQuocGia()
    End Function

    Public Function SelectDMQuocGiaByID(ByVal ID As String) As Common.DMQuocGiaEntity
        Return IDMQuocGia.SelectDMQuocGiaByPrimaryKey(ID)
    End Function

    Public Sub DeleteDMQuocGia(ByVal ID As String)
        IDMQuocGia.DeleteDMQuocGia(ID)
    End Sub

    Public Sub InsertDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity)
        IDMQuocGia.InsertDMQuocGia(DMQuocGia)
    End Sub

    Public Sub UpdateDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity)
        IDMQuocGia.UpdateDMQuocGia(DMQuocGia)
    End Sub

End Class
