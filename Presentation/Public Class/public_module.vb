Module public_module
    Public Const ADD_STATE As Byte = 1
    Public Const UPDATE_STATE As Byte = 2

    Public Sub XuatExcel(ByVal gvView As DevExpress.XtraGrid.Views.Grid.GridView)
        If gvView.RowCount <= 0 Then
            Exit Sub
        End If

        Dim fld As New SaveFileDialog()
        fld.Filter = "Excel file (*.xls;*.*)|*.xls;*.xlsx"
        fld.RestoreDirectory = True
        If fld.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        gvView.ExportToXls(fld.FileName)
        MessageBox.Show_Message("Xuất excel thành công!", Presentation.MessageBox.MessageBoxButton.OK, Presentation.MessageBox.MessageIcon.Information)
    End Sub
End Module
