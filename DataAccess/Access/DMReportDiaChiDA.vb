Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMReportDiaChiDA
    Implements IDMReportDiaChiDA

    Public Function SelectAllDMQuocGia_TinhThanh_QuanHuyen() As DataTable Implements IDMReportDiaChiDA.SelectAllDMQuocGia_TinhThanh_QuanHuyen
        Dim db As Database
        Dim sp As String = "sp_ReportDiaChi"
        Dim objCmd As DbCommand
        Dim ds As DataSet
        'Dim dt As DataTable
        db = DatabaseFactory.CreateDatabase()
        objCmd = db.GetStoredProcCommand(sp)
        ds = db.ExecuteDataSet(objCmd)
        Return ds.Tables(0)
    End Function
End Class
