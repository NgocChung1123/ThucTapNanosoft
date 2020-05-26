Imports DevExpress.XtraEditors.Repository

Public Class frmDiaChi

    Private objTinhThanhList As List(Of Common.DMTinhThanhEntity) = Nothing
    Private objEnTinhThanh As Common.DMTinhThanhEntity = Nothing
    Private objFCTinhThanh As New Bussiness.DMTinhThanhFacade

    Private objQuocGiaList As List(Of Common.DMQuocGiaEntity) = Nothing
    Private objEnQuocGia As Common.DMQuocGiaEntity = Nothing
    Private objFCQuocGia As New Bussiness.DMQuocGiaFacede

    Private objQuanHuyenList As List(Of Common.DMQuanHuyenEntity) = Nothing
    Private objEnQuanHuyen As Common.DMQuanHuyenEntity = Nothing
    Private objFCQuanHuyen As New Bussiness.DMQuanHuyenFacede

    Private Sub LoadDataQuocGia()
        RepositoryItemLUEQuocGia.DataSource = objFCQuocGia.SelectAllDMQuocGia()
        RepositoryItemLUEQuocGia.DisplayMember = "TenQuocGia"
        RepositoryItemLUEQuocGia.ValueMember = "IDQuocGia"
    End Sub
    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub PanelControl2_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl2.Paint

    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmDiaChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataQuocGia()
        LookUpEdit1.Properties.DataSource = objFCQuocGia.SelectAllDMQuocGia()
        LookUpEdit1.Properties.DisplayMember = "TenQuocGia"
        LookUpEdit1.Properties.ValueMember = "IDQuocGia"
        LookUpEdit1.Properties.BestFit()
    End Sub
    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LookUpEdit1_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        Dim ID = LookUpEdit1.GetColumnValue("IDQuocGia").ToString()
        Console.WriteLine(ID)
        LookUpEdit2.Properties.DataSource = objFCTinhThanh.SelectAllDMTinhThanhByIDQuocGia(ID)
        LookUpEdit2.Properties.DisplayMember = "TenTinhThanh"
        LookUpEdit2.Properties.ValueMember = "IDTinhThanh"

    End Sub

    Private Sub LookUpEdit1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles LookUpEdit1.EditValueChanging

    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click, LabelControl3.Click, LabelControl2.Click

    End Sub

    Private Sub LookUpEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit3.EditValueChanged

    End Sub

    Private Sub LookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit2.EditValueChanged
        Dim ID = LookUpEdit2.GetColumnValue("IDTinhThanh").ToString()
        Console.WriteLine(ID)
        LookUpEdit3.Properties.DataSource = objFCQuanHuyen.SelectAllDMQuanHuyenByIDTinhThanh(ID)
        LookUpEdit3.Properties.DisplayMember = "TenQuanHuyen"
        LookUpEdit3.Properties.ValueMember = "IDQuanHuyen"
    End Sub

    Private Sub PanelControl3_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl3.Paint

    End Sub
End Class