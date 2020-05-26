Public Class DMGioiTinhFacade

    Private IDMGioiTinh As DataAccess.IDMGioiTinhDA = New DataAccess.DMGioiTinhDA

    Public Function SelectDMGioiTinhByPrimaykey(ByVal MaGioiTinh As String) As Common.DMGioiTinhEntity
        Return IDMGioiTinh.SelectDMGioiTinhByPrimaryKey(MaGioiTinh)
    End Function

    Public Sub DeleteDMGioiTinh(ByVal MaGioiTinh As String)
        IDMGioiTinh.DeleteDMGioiTinh(MaGioiTinh)
    End Sub


    Public Function SelectAllDMGioiTinh() As List(Of Common.DMGioiTinhEntity)
        Return IDMGioiTinh.SelectAllDMGioiTinh()
    End Function


    Public Sub InsertDMGioiTinh(ByVal DMGioiTinh As Common.DMGioiTinhEntity)
        IDMGioiTinh.InsertDMGioiTinh(DMGioiTinh)
    End Sub

    Public Sub UpdateDMGioiTinh(ByVal DMGioiTinh As Common.DMGioiTinhEntity)
        IDMGioiTinh.UpdateDMGioiTinh(DMGioiTinh)
    End Sub

End Class
''======================================================