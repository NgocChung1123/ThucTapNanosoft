Imports System.Data.Common
Imports Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMTinhThanhDA
    Implements IDMTinhThanhDA

    Public Function SelectAllDMTinhThanh(ByVal IDQuocGia As String) As List(Of Common.DMTinhThanhEntity) Implements IDMTinhThanhDA.SelectAllDMTinhThanh
        Dim db As Database
        Dim sp As String = "spDMTinhThanh_SelectAll"
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Dim lstDMTinhThanh As List(Of Common.DMTinhThanhEntity) = Nothing
        Dim i As Integer = 0
        ''1)------------------------------------------------------
        Try
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@" & Common.DMTinhThanhEntity.Column_IDQuocGia, System.Data.DbType.String, IDQuocGia)
            objDs = db.ExecuteDataSet(objCmd)
            ''2)------------------------------------------------------
            If objDs.Tables.Count > 0 AndAlso objDs.Tables(0).Rows.Count > 0 Then
                lstDMTinhThanh = New List(Of Common.DMTinhThanhEntity)
                For Each r As DataRow In objDs.Tables(0).Rows
                    lstDMTinhThanh.Add(New Common.DMTinhThanhEntity)
                    With lstDMTinhThanh(i)
                        .IDTinhThanh = r.Item(Common.DMTinhThanhEntity.Column_IDTinhThanh)
                        .TenTinhThanh = r.Item(Common.DMTinhThanhEntity.Column_TenTinhThanh)
                        '.MoTa = r.Item(Common.DMTinhThanhEntity.Column_MoTa)
                    End With
                    i += 1
                Next
            End If
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_SelectAll", ex.Message)
            MessageBox.Show(ex.Message)
        End Try

        ''3)------------------------------------------------------

        Return lstDMTinhThanh
    End Function
End Class
