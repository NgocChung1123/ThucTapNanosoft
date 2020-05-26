Imports System.Data.Common
Imports Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMQuanHuyenDA
    Implements IDMQuanHuyenDA

    Public Function SelectAllDMQuanHuyen(ByVal IDQuocGia As String) As List(Of DMQuanHuyenEntity) Implements IDMQuanHuyenDA.SelectAllDMQuanHuyen
        Dim db As Database
        Dim sp As String = "spDMQuanHuyen_SelectAll"
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Dim lstDMQuanHuyen As List(Of Common.DMQuanHuyenEntity) = Nothing
        Dim i As Integer = 0
        ''1)------------------------------------------------------
        Try
            db = DatabaseFactory.CreateDatabase()
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@" & Common.DMQuanHuyenEntity.Column_IDTinhThanh, System.Data.DbType.String, IDQuocGia)
            objDs = db.ExecuteDataSet(objCmd)
            ''2)------------------------------------------------------
            If objDs.Tables.Count > 0 AndAlso objDs.Tables(0).Rows.Count > 0 Then
                lstDMQuanHuyen = New List(Of Common.DMQuanHuyenEntity)
                For Each r As DataRow In objDs.Tables(0).Rows
                    lstDMQuanHuyen.Add(New Common.DMQuanHuyenEntity)
                    With lstDMQuanHuyen(i)
                        .IDQuanHuyen = r.Item(Common.DMQuanHuyenEntity.Column_IDQuanHuyen)
                        .TenQuanHuyen = r.Item(Common.DMQuanHuyenEntity.Column_TenQuanHuyen)
                        '.MoTa = r.Item(Common.DMQuanHuyenEntity.Column_MoTa)
                    End With
                    i += 1
                Next
            End If
        Catch ex As Exception
            'objLog.WriteLog("spDMGioiTinh_SelectAll", ex.Message)
            MessageBox.Show(ex.Message)
        End Try

        ''3)------------------------------------------------------

        Return lstDMQuanHuyen
    End Function
End Class
