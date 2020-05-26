Public Class DMReportDiaChiFacedevb
    Private IDMReportDiaChi As DataAccess.DMReportDiaChiDA = New DataAccess.DMReportDiaChiDA

    Public Function SelectAllDiaChi() As DataTable
        Return IDMReportDiaChi.SelectAllDMQuocGia_TinhThanh_QuanHuyen()
    End Function
End Class
