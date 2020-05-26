Public Interface IDMGioiTinhDA
    Function SelectAllDMGioiTinh() As List(Of Common.DMGioiTinhEntity) '/* Select all */
    Function SelectDMGioiTinhByPrimaryKey(ByVal MaGioiTinh As String) As Common.DMGioiTinhEntity '/* Select by primarykey */
    Sub InsertDMGioiTinh(ByVal DMGioiTinh As Common.DMGioiTinhEntity) '/* Insert into table */
    Sub DeleteDMGioiTinh(ByVal MaGioiTinh As String) '/* Delete from table */
    Sub UpdateDMGioiTinh(ByVal DMGioiTinh As Common.DMGioiTinhEntity) '/* Update table */

End Interface