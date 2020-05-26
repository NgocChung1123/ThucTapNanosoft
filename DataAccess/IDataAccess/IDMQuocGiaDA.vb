Public Interface IDMQuocGiaDA
    Function SelectAllDMQuocGia() As List(Of Common.DMQuocGiaEntity) '/* Select all */
    Function SelectDMQuocGiaByPrimaryKey(ByVal ID As String) As Common.DMQuocGiaEntity '/* Select by primarykey */
    Sub InsertDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity) '/* Insert into table */
    Sub DeleteDMQuocGia(ByVal ID As String) '/* Delete from table */
    Sub UpdateDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity) '/* Update table */
End Interface
