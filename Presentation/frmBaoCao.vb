Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.Import.Interop.Access
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.XtraReport
Public Class frmBaoCao

    Private objFCReport As New Bussiness.DMReportDiaChiFacedevb
    Dim dt As DataTable = objFCReport.SelectAllDiaChi()

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim report As New XtraReportDiaChi
        report.DataSource = dt
        'Dim printTool As New ReportPrintTool(New XtraReportDiaChi())
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreviewDialog()
        Console.WriteLine("aaaaaaaaaaaaaaaa")
    End Sub

    Private Sub frmBaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class