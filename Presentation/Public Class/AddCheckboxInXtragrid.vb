Public Class AddCheckboxInXtragrid
    Friend WithEvents _GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents _GridView As DevExpress.XtraGrid.Views.Grid.GridView

    Sub New(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
        _GridControl = gridControl
        _GridView = gridView
    End Sub

    Private booTest As Boolean = False

    Sub AddCheckColumn_FieldName()
        'add colum checkbox
        'author: Pham Phu Dang
        'Company: Nanosoft
        'Date:24/04/2010
        '--------------------------------------
        booTest = False
        For i As Int32 = 0 To _GridView.Columns.Count - 1
            If _GridView.Columns(i).Name.Trim.ToString = "ColCheckXoa" Then
                booTest = True
                Exit For
            End If
        Next
        If booTest = True Then
            _GridView.Columns.Remove(_GridView.Columns.Item("ColCheckXoa"))
        End If

        _GridControl.ForceInitialize()
        _GridView.BeginUpdate()
        Dim ColumnCheck As DevExpress.XtraGrid.Columns.GridColumn = _GridView.Columns.AddField("ColCheckXoa")
        Dim RepositoryCheck As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        ColumnCheck.ColumnEdit = RepositoryCheck
        ColumnCheck.Name = "ColCheckXoa"
        ColumnCheck.Caption = "Chọn"
        ColumnCheck.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColumnCheck.Width = 50
        ColumnCheck.OptionsColumn.AllowEdit = True
        ColumnCheck.OptionsColumn.AllowSize = False
        ColumnCheck.OptionsColumn.FixedWidth = True
        ColumnCheck.ToolTip = "Chọn"
        ColumnCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
        ColumnCheck.VisibleIndex = 0 'Integer.MaxValue
        objects.Clear()
        AddHandler _GridView.CustomUnboundColumnData, AddressOf _GridView_CustomUnboundColumnData
        _GridView.EndUpdate()
    End Sub

    Public objects As New List(Of Object)

    Public Sub CheckAllCheckBox()
        'Checked all checkbox
        'author: Pham Phu Dang
        'Company: Nanosoft
        'Date:24/04/2010
        '--------------------------------------
        objects.Clear()
        For i As Integer = 0 To _GridView.DataRowCount - 1
            objects.Add(_GridView.GetRow(i))
        Next
        _GridView.RefreshData()
    End Sub

    Public Sub ClearCheckBox()
        'ClearCheckbox
        'author: Pham Phu Dang
        'Company: Nanosoft
        'Date:24/04/2010
        '--------------------------------------
        objects.Clear()
        _GridView.RefreshData()
    End Sub

    Private Sub _GridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) ' Handles _GridView.CustomUnboundColumnData
        'set value checked
        'author: Pham Phu Dang
        'Company: Nanosoft
        'Date:24/04/2010
        '--------------------------------------
        If e.Column.FieldName <> "ColCheckXoa" Then Return
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.IsGetData Then
            e.Value = objects.Contains(_GridView.GetRow(e.ListSourceRowIndex))
        ElseIf e.IsSetData Then
            Dim c As Boolean = CType(e.Value, Boolean)
            If c Then
                objects.Add(_GridView.GetRow(e.ListSourceRowIndex))
            Else
                objects.Remove(_GridView.GetRow(e.ListSourceRowIndex))
            End If
        End If
    End Sub
End Class
