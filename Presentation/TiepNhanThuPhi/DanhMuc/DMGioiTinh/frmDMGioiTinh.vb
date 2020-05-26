Public Class frmDMGioiTinh
    Private objEnQuocGiaList As List(Of Common.DMGioiTinhEntity) = Nothing
    Private objEnQuocGia As Common.DMGioiTinhEntity = Nothing
    Private objFCQuocGia As New Bussiness.DMGioiTinhFacade

    Private WithEvents _reset As frmCapNhatDMGioiTinh = Nothing
    Private objAddCheckBox As AddCheckboxInXtragrid = Nothing

    Private Sub LoadDataGrid() Handles _reset._Save
        objEnQuocGiaList = objFCQuocGia.SelectAllDMGioiTinh()
        grdQuocGia.DataSource = objEnQuocGiaList
        objAddCheckBox = New AddCheckboxInXtragrid(grdQuocGia, gvQuocGia)
        objAddCheckBox.AddCheckColumn_FieldName()
    End Sub

    Private Function GetData() As Common.DMGioiTinhEntity
        Dim _data As Common.DMGioiTinhEntity = Nothing
        Try
            If gvQuocGia.RowCount > 0 Then
                _data = gvQuocGia.GetFocusedRow()
            End If
            Return _data
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub frmDMQuocGia_Load() Handles MyBase.Load
        LoadDataGrid()
        AddHandler Me.btnThoat.Click, AddressOf Me.Close
    End Sub


    Private Sub btnNhapMoi_Click() Handles btnNhapMoi.Click
        _reset = New frmCapNhatDMGioiTinh(ADD_STATE)
        _reset.ShowDialog()
    End Sub

    Private Sub btnSua_Click() Handles btnSua.Click, grdQuocGia.DoubleClick
        If GetData() Is Nothing Then
            Exit Sub
        End If

        _reset = New frmCapNhatDMGioiTinh(UPDATE_STATE, GetData())
        _reset.ShowDialog()
    End Sub

    Private Sub gvQuocGia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If GetData() Is Nothing Then
            Exit Sub
        End If

        _reset = New frmCapNhatDMGioiTinh(UPDATE_STATE, GetData)
        _reset.ShowDialog()
    End Sub

    Private Sub btnXoa_Click() Handles btnXoa.Click
        If gvQuocGia.RowCount <= 0 Then
            Exit Sub
        End If

        Dim lst As New List(Of Object)
        lst = objAddCheckBox.objects

        If lst.Count <= 0 Then
            MessageBox.Show_ChuaChonBanGhiDeXoa()
            Exit Sub
        End If

        If MessageBox.Show_HoiTruocKhiXoa = DialogResult.No Then
            Exit Sub
        End If

        Try
            For Each r As Object In lst
                objEnQuocGia = CType(r, Common.DMGioiTinhEntity)
                objFCQuocGia.DeleteDMGioiTinh(objEnQuocGia.IDGioiTinh)
            Next
        Catch ex As Exception
            ' MessageBox.Show_DuLieuBiRangBuoc()
        End Try

        LoadDataGrid()
    End Sub

    Private Sub btnXuatExcel_Click() Handles btnXuatExcel.Click
        XuatExcel(gvQuocGia)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles grdQuocGia.DoubleClick, btnSua.Click

    End Sub

    Private Sub frmDMQuocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grdQuocGia_Click(sender As Object, e As EventArgs) Handles grdQuocGia.Click

    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub btnXemIn_Click(sender As Object, e As EventArgs) Handles btnXemIn.Click

    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click

    End Sub
End Class