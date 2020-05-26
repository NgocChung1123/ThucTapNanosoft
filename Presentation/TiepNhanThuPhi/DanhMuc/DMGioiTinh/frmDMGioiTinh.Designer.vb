<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDMGioiTinh
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDMGioiTinh))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXuatExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXemIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNhapMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.gvQuocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDGioiTinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenGioiTinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GhiChu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdQuocGia = New DevExpress.XtraGrid.GridControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.gvQuocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdQuocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(719, 34)
        Me.PanelControl1.TabIndex = 95
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(8, 6)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(197, 22)
        Me.LabelControl8.TabIndex = 102
        Me.LabelControl8.Text = "DANH MỤC GIỚI TÍNH"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnThoat)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnXuatExcel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnXemIn)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnXoa)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSua)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNhapMoi)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 388)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 2, 30, 0)
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(719, 40)
        Me.FlowLayoutPanel1.TabIndex = 96
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(588, 5)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(98, 31)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXuatExcel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXuatExcel.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnXuatExcel.Appearance.Options.UseFont = True
        Me.btnXuatExcel.Appearance.Options.UseForeColor = True
        Me.btnXuatExcel.ImageOptions.Image = CType(resources.GetObject("btnXuatExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXuatExcel.Location = New System.Drawing.Point(484, 5)
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Size = New System.Drawing.Size(98, 31)
        Me.btnXuatExcel.TabIndex = 4
        Me.btnXuatExcel.Text = "Xuất Excel"
        '
        'btnXemIn
        '
        Me.btnXemIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXemIn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXemIn.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnXemIn.Appearance.Options.UseFont = True
        Me.btnXemIn.Appearance.Options.UseForeColor = True
        Me.btnXemIn.ImageOptions.Image = CType(resources.GetObject("btnXemIn.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXemIn.Location = New System.Drawing.Point(380, 5)
        Me.btnXemIn.Name = "btnXemIn"
        Me.btnXemIn.Size = New System.Drawing.Size(98, 31)
        Me.btnXemIn.TabIndex = 3
        Me.btnXemIn.Text = "Xem in"
        Me.btnXemIn.Visible = False
        '
        'btnXoa
        '
        Me.btnXoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.ImageOptions.Image = CType(resources.GetObject("btnXoa.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(276, 5)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(98, 31)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa bỏ "
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Appearance.Options.UseForeColor = True
        Me.btnSua.ImageOptions.Image = CType(resources.GetObject("btnSua.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSua.Location = New System.Drawing.Point(168, 5)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(102, 31)
        Me.btnSua.TabIndex = 0
        Me.btnSua.Text = "Sửa chữa"
        '
        'btnNhapMoi
        '
        Me.btnNhapMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNhapMoi.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapMoi.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnNhapMoi.Appearance.Options.UseFont = True
        Me.btnNhapMoi.Appearance.Options.UseForeColor = True
        Me.btnNhapMoi.ImageOptions.Image = CType(resources.GetObject("btnNhapMoi.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNhapMoi.Location = New System.Drawing.Point(60, 5)
        Me.btnNhapMoi.Name = "btnNhapMoi"
        Me.btnNhapMoi.Size = New System.Drawing.Size(102, 31)
        Me.btnNhapMoi.TabIndex = 1
        Me.btnNhapMoi.Text = "Thêm mới"
        '
        'gvQuocGia
        '
        Me.gvQuocGia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDGioiTinh, Me.TenGioiTinh, Me.GhiChu})
        Me.gvQuocGia.GridControl = Me.grdQuocGia
        Me.gvQuocGia.Name = "gvQuocGia"
        Me.gvQuocGia.OptionsView.ColumnAutoWidth = False
        Me.gvQuocGia.OptionsView.ShowAutoFilterRow = True
        Me.gvQuocGia.OptionsView.ShowGroupPanel = False
        '
        'IDGioiTinh
        '
        Me.IDGioiTinh.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDGioiTinh.AppearanceCell.Options.UseFont = True
        Me.IDGioiTinh.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDGioiTinh.AppearanceHeader.Options.UseFont = True
        Me.IDGioiTinh.AppearanceHeader.Options.UseTextOptions = True
        Me.IDGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IDGioiTinh.Caption = "Mã giới tính"
        Me.IDGioiTinh.FieldName = "IDGioiTinh"
        Me.IDGioiTinh.Name = "IDGioiTinh"
        Me.IDGioiTinh.OptionsColumn.AllowEdit = False
        Me.IDGioiTinh.Visible = True
        Me.IDGioiTinh.VisibleIndex = 0
        Me.IDGioiTinh.Width = 90
        '
        'TenGioiTinh
        '
        Me.TenGioiTinh.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenGioiTinh.AppearanceCell.Options.UseFont = True
        Me.TenGioiTinh.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenGioiTinh.AppearanceHeader.Options.UseFont = True
        Me.TenGioiTinh.AppearanceHeader.Options.UseTextOptions = True
        Me.TenGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TenGioiTinh.Caption = "Tên giới tính"
        Me.TenGioiTinh.FieldName = "TenGioiTinh"
        Me.TenGioiTinh.Name = "TenGioiTinh"
        Me.TenGioiTinh.OptionsColumn.AllowEdit = False
        Me.TenGioiTinh.Visible = True
        Me.TenGioiTinh.VisibleIndex = 1
        Me.TenGioiTinh.Width = 254
        '
        'GhiChu
        '
        Me.GhiChu.AppearanceCell.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GhiChu.AppearanceCell.Options.UseFont = True
        Me.GhiChu.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GhiChu.AppearanceHeader.Options.UseFont = True
        Me.GhiChu.AppearanceHeader.Options.UseTextOptions = True
        Me.GhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GhiChu.Caption = "Ghi chú"
        Me.GhiChu.FieldName = "GhiChu"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.OptionsColumn.AllowEdit = False
        Me.GhiChu.Visible = True
        Me.GhiChu.VisibleIndex = 2
        Me.GhiChu.Width = 300
        '
        'grdQuocGia
        '
        Me.grdQuocGia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdQuocGia.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdQuocGia.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdQuocGia.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdQuocGia.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdQuocGia.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdQuocGia.Location = New System.Drawing.Point(0, 34)
        Me.grdQuocGia.MainView = Me.gvQuocGia
        Me.grdQuocGia.Name = "grdQuocGia"
        Me.grdQuocGia.Size = New System.Drawing.Size(719, 354)
        Me.grdQuocGia.TabIndex = 97
        Me.grdQuocGia.UseEmbeddedNavigator = True
        Me.grdQuocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQuocGia})
        '
        'frmDMGioiTinh
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(719, 428)
        Me.Controls.Add(Me.grdQuocGia)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Name = "frmDMGioiTinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH MỤC GIỚI TÍNH"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.gvQuocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdQuocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXuatExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXemIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNhapMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvQuocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDGioiTinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenGioiTinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GhiChu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdQuocGia As DevExpress.XtraGrid.GridControl
End Class
