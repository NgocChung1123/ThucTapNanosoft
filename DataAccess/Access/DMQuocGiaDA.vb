Imports Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Public Class DMQuocGiaDA
    Implements IDMQuocGiaDA

    Public Sub InsertDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity) Implements IDMQuocGiaDA.InsertDMQuocGia
        Try
            Dim db As Database
            Dim sp As String = "spDMQuocGia_Insert"
            Dim objCmd As DbCommand
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_IDQuocGia, System.Data.DbType.String, DMQuocGia.IDQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_TenQuocGia, System.Data.DbType.String, DMQuocGia.TenQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_MoTaQuocGia, System.Data.DbType.String, DMQuocGia.MoTaQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_TrangThaiSuDung, System.Data.DbType.String, DMQuocGia.TrangThaiSuDung)
            db.ExecuteNonQuery(objCmd)
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_Insert", ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub UpdateDMQuocGia(ByVal DMQuocGia As Common.DMQuocGiaEntity) Implements IDMQuocGiaDA.UpdateDMQuocGia
        Try
            Dim db As Database
            Dim sp As String = "spDMQuocGia_Update"
            Dim objCmd As DbCommand

            ''------------------------------------------------------
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_IDQuocGia, System.Data.DbType.String, DMQuocGia.IDQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_TenQuocGia, System.Data.DbType.String, DMQuocGia.TenQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_MoTaQuocGia, System.Data.DbType.String, DMQuocGia.MoTaQuocGia)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_TrangThaiSuDung, System.Data.DbType.String, DMQuocGia.TrangThaiSuDung)
            db.ExecuteNonQuery(objCmd)
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_Update", ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeleteDMQuocGia(ByVal ID As String) Implements IDMQuocGiaDA.DeleteDMQuocGia
        Try
            Dim db As Database
            Dim sp As String = "spDMQuocGia_DeleteByPrimaryKey"
            Dim objCmd As DbCommand

            ''------------------------------------------------------
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_IDQuocGia, System.Data.DbType.String, ID)
            db.ExecuteNonQuery(objCmd)
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_DeleteByPrimaryKey", ex.Message)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function SelectAllDMQuocGia() As System.Collections.Generic.List(Of Common.DMQuocGiaEntity) Implements IDMQuocGiaDA.SelectAllDMQuocGia
        Dim db As Database
        Dim sp As String = "spDMQuocGia_SelectAll"
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Dim lstDMQuocGia As List(Of Common.DMQuocGiaEntity) = Nothing
        Dim i As Integer = 0
        ''1)------------------------------------------------------
        Try
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            objDs = db.ExecuteDataSet(objCmd)
            ''2)------------------------------------------------------
            If objDs.Tables.Count > 0 AndAlso objDs.Tables(0).Rows.Count > 0 Then
                lstDMQuocGia = New List(Of Common.DMQuocGiaEntity)
                For Each r As DataRow In objDs.Tables(0).Rows
                    lstDMQuocGia.Add(New Common.DMQuocGiaEntity)
                    With lstDMQuocGia(i)
                        .IDQuocGia = r.Item(Common.DMQuocGiaEntity.Column_IDQuocGia)
                        .TenQuocGia = r.Item(Common.DMQuocGiaEntity.Column_TenQuocGia)
                        .MoTaQuocGia = r.Item(Common.DMQuocGiaEntity.Column_MoTaQuocGia)
                        .GhiChu = r.Item(Common.DMQuocGiaEntity.Column_GhiChu)
                    End With
                    i += 1
                Next
            End If
        Catch ex As Exception
            'objLog.WriteLog("spDMQuocGia_SelectAll", ex.Message)
            MessageBox.Show(ex.Message)
        End Try

        ''3)------------------------------------------------------

        Return lstDMQuocGia
    End Function

    Public Function SelectDMQuocGiaByPrimaryKey(ByVal ID As String) As DMQuocGiaEntity Implements IDMQuocGiaDA.SelectDMQuocGiaByPrimaryKey
        Dim db As Database
        Dim sp As String = "spDMQuocGia_SelectByPrimaryKey"
        Dim objCmd As DbCommand
        Dim r As IDataReader
        Dim objDMQuocGia As Common.DMQuocGiaEntity = Nothing
        ''1)------------------------------------------------------
        Try
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@" & Common.DMQuocGiaEntity.Column_IDQuocGia, System.Data.DbType.String, ID)
            r = db.ExecuteReader(objCmd)
            ''2)------------------------------------------------------

            If r.Read Then
                objDMQuocGia = New Common.DMQuocGiaEntity
                With objDMQuocGia
                    .IDQuocGia = r.Item(Common.DMQuocGiaEntity.Column_IDQuocGia)
                    .TenQuocGia = r.Item(Common.DMQuocGiaEntity.Column_TenQuocGia)
                    .MaQuocGia = r.Item(Common.DMQuocGiaEntity.Column_MaQuocGia)
                    .MoTaQuocGia = r.Item(Common.DMQuocGiaEntity.Column_MoTaQuocGia)
                End With
            End If
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_SelectByPrimaryKey", ex.Message)
            MessageBox.Show(ex.Message)
        End Try
        ''3)------------------------------------------------------
        Return objDMQuocGia
    End Function
End Class
