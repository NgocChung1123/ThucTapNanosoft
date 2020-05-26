Public Class frmDMQuocGia
    Private objEnQuocGiaList As List(Of Common.DMQuocGiaEntity) = Nothing
    Private objEnQuocGia As Common.DMQuocGiaEntity = Nothing
    Private objFCQuocGia As New Bussiness.DMQuocGiaFacede

    Private WithEvents _reset As frmCapNhatQuocGia = Nothing
    Private objAddCheckBox As AddCheckboxInXtragrid = Nothing
    Private Sub LoadDataGrid() Handles _reset._Save
        objEnQuocGiaList = objFCQuocGia.SelectAllDMQuocGia()
        grvQuocGia.DataSource = objEnQuocGiaList
        objAddCheckBox = New AddCheckboxInXtragrid(grvQuocGia, GridView1)
        objAddCheckBox.AddCheckColumn_FieldName()
    End Sub

    Private Function GetData() As Common.DMQuocGiaEntity
        Dim _data As Common.DMQuocGiaEntity = Nothing
        Try
            If GridView1.RowCount > 0 Then
                _data = GridView1.GetFocusedRow()
            End If
            Return _data
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Sub frmDMQuocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
        'AddHandler Me.btnThoat.Click, AddressOf Me.Close
    End Sub

    Private Sub grvQuocGia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grvQuocGia_Click_1(sender As Object, e As EventArgs) Handles grvQuocGia.Click

    End Sub

    Private Sub btnNhapMoi_Click(sender As Object, e As EventArgs) Handles btnNhapMoi.Click
        _reset = New frmCapNhatQuocGia(ADD_STATE)
        _reset.ShowDialog()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If GridView1.RowCount <= 0 Then
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
                objEnQuocGia = CType(r, Common.DMQuocGiaEntity)
                objFCQuocGia.DeleteDMQuocGia(objEnQuocGia.IDQuocGia)
            Next
        Catch ex As Exception
            ' MessageBox.Show_DuLieuBiRangBuoc()
        End Try

        LoadDataGrid()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click, grvQuocGia.DoubleClick
        If GetData() Is Nothing Then
            Exit Sub
        End If

        _reset = New frmCapNhatQuocGia(UPDATE_STATE, GetData())
        _reset.ShowDialog()
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        XuatExcel(GridView1)
    End Sub

    Private Sub btnXemIn_Click(sender As Object, e As EventArgs) Handles btnXemIn.Click

    End Sub

    Private Sub pnLabel_Paint(sender As Object, e As PaintEventArgs) Handles pnLabel.Paint

    End Sub
End Class