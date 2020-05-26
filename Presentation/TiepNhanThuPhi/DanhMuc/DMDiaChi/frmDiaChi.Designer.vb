<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiaChi
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.QuocGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TinhThanh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLUETinhThanh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.QuanHuyen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLUEQuanHuyen = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLUEQuocGia = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLUETinhThanh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLUEQuanHuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLUEQuocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(854, 373)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit3)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit2)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit1)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 169)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(844, 199)
        Me.PanelControl3.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(524, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Quận/Huyện:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(267, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tỉnh thành:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Quốc gia:"
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.Location = New System.Drawing.Point(596, 64)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDQuanHuyen", "Mã quận/huyện"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenQuanHuyen", "Tên quận/huyện")})
        Me.LookUpEdit3.Properties.NullText = "Chọn quận/huyện"
        Me.LookUpEdit3.Size = New System.Drawing.Size(100, 20)
        Me.LookUpEdit3.TabIndex = 0
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.Location = New System.Drawing.Point(328, 66)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDTinhThanh", "Mã tỉnh"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTinhThanh", "Tên tỉnh thành")})
        Me.LookUpEdit2.Properties.NullText = "Chọn tỉnh thành"
        Me.LookUpEdit2.Size = New System.Drawing.Size(100, 20)
        Me.LookUpEdit2.TabIndex = 0
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(105, 66)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDQuocGia", "Mã quốc gia", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenQuocGia", "Tên quốc gia")})
        Me.LookUpEdit1.Properties.NullText = "Chọn quốc gia"
        Me.LookUpEdit1.Size = New System.Drawing.Size(100, 20)
        Me.LookUpEdit1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(849, 115)
        Me.PanelControl2.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLUEQuocGia, Me.RepositoryItemLUETinhThanh, Me.RepositoryItemLUEQuanHuyen, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(845, 137)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.QuocGia, Me.TinhThanh, Me.QuanHuyen})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'QuocGia
        '
        Me.QuocGia.Caption = "Quốc Gia"
        Me.QuocGia.ColumnEdit = Me.RepositoryItemLUEQuocGia
        Me.QuocGia.FieldName = "QuocGia"
        Me.QuocGia.Name = "QuocGia"
        Me.QuocGia.Visible = True
        Me.QuocGia.VisibleIndex = 0
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'TinhThanh
        '
        Me.TinhThanh.Caption = "Tỉnh thành"
        Me.TinhThanh.ColumnEdit = Me.RepositoryItemLUETinhThanh
        Me.TinhThanh.FieldName = "TinhThanh"
        Me.TinhThanh.Name = "TinhThanh"
        Me.TinhThanh.Visible = True
        Me.TinhThanh.VisibleIndex = 1
        '
        'RepositoryItemLUETinhThanh
        '
        Me.RepositoryItemLUETinhThanh.AutoHeight = False
        Me.RepositoryItemLUETinhThanh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLUETinhThanh.Name = "RepositoryItemLUETinhThanh"
        Me.RepositoryItemLUETinhThanh.NullText = "Chọn tỉnh thành"
        '
        'QuanHuyen
        '
        Me.QuanHuyen.Caption = "Quận huyện"
        Me.QuanHuyen.ColumnEdit = Me.RepositoryItemLUEQuanHuyen
        Me.QuanHuyen.FieldName = "QuanHuyen"
        Me.QuanHuyen.Name = "QuanHuyen"
        Me.QuanHuyen.Visible = True
        Me.QuanHuyen.VisibleIndex = 2
        '
        'RepositoryItemLUEQuanHuyen
        '
        Me.RepositoryItemLUEQuanHuyen.AutoHeight = False
        Me.RepositoryItemLUEQuanHuyen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLUEQuanHuyen.Name = "RepositoryItemLUEQuanHuyen"
        Me.RepositoryItemLUEQuanHuyen.NullText = "Chọn quận huyện"
        '
        'RepositoryItemLUEQuocGia
        '
        Me.RepositoryItemLUEQuocGia.AutoHeight = False
        Me.RepositoryItemLUEQuocGia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLUEQuocGia.Name = "RepositoryItemLUEQuocGia"
        Me.RepositoryItemLUEQuocGia.NullText = "Chọn quốc gia"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'frmDiaChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 397)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmDiaChi"
        Me.Text = "frmDiaChi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLUETinhThanh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLUEQuanHuyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLUEQuocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents QuocGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLUEQuocGia As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TinhThanh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLUETinhThanh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents QuanHuyen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLUEQuanHuyen As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
