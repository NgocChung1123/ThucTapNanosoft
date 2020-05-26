<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDMQuocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDMQuocGia))
        Me.pnContent = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grvQuocGia = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDQuocGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TenQuocGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MoTaQuocGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GhiChu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnLabel = New DevExpress.XtraEditors.PanelControl()
        Me.lbTitle = New DevExpress.XtraEditors.LabelControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXuatExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXemIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNhapMoi = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnContent.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grvQuocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLabel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnContent
        '
        Me.pnContent.Controls.Add(Me.PanelControl1)
        Me.pnContent.Controls.Add(Me.pnLabel)
        Me.pnContent.Location = New System.Drawing.Point(3, 12)
        Me.pnContent.Name = "pnContent"
        Me.pnContent.Size = New System.Drawing.Size(756, 400)
        Me.pnContent.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grvQuocGia)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 53)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(742, 342)
        Me.PanelControl1.TabIndex = 1
        '
        'grvQuocGia
        '
        Me.grvQuocGia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grvQuocGia.Location = New System.Drawing.Point(2, 2)
        Me.grvQuocGia.MainView = Me.GridView1
        Me.grvQuocGia.Name = "grvQuocGia"
        Me.grvQuocGia.ShowOnlyPredefinedDetails = True
        Me.grvQuocGia.Size = New System.Drawing.Size(738, 338)
        Me.grvQuocGia.TabIndex = 1
        Me.grvQuocGia.UseEmbeddedNavigator = True
        Me.grvQuocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDQuocGia, Me.TenQuocGia, Me.MoTaQuocGia, Me.GhiChu})
        Me.GridView1.GridControl = Me.grvQuocGia
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 5
        Me.GridView1.OptionsPrint.PrintDetails = True
        '
        'IDQuocGia
        '
        Me.IDQuocGia.Caption = "ID Quốc Gia"
        Me.IDQuocGia.FieldName = "IDQuocGia"
        Me.IDQuocGia.Name = "IDQuocGia"
        Me.IDQuocGia.Visible = True
        Me.IDQuocGia.VisibleIndex = 0
        '
        'TenQuocGia
        '
        Me.TenQuocGia.Caption = "Tên quốc gia"
        Me.TenQuocGia.FieldName = "TenQuocGia"
        Me.TenQuocGia.Name = "TenQuocGia"
        Me.TenQuocGia.Visible = True
        Me.TenQuocGia.VisibleIndex = 1
        '
        'MoTaQuocGia
        '
        Me.MoTaQuocGia.Caption = "Mô tả"
        Me.MoTaQuocGia.FieldName = "MoTaQuocGia"
        Me.MoTaQuocGia.Name = "MoTaQuocGia"
        Me.MoTaQuocGia.Visible = True
        Me.MoTaQuocGia.VisibleIndex = 3
        '
        'GhiChu
        '
        Me.GhiChu.Caption = "Ghi chú"
        Me.GhiChu.FieldName = "GhiChu"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.Visible = True
        Me.GhiChu.VisibleIndex = 2
        '
        'pnLabel
        '
        Me.pnLabel.Controls.Add(Me.lbTitle)
        Me.pnLabel.Location = New System.Drawing.Point(0, 5)
        Me.pnLabel.Name = "pnLabel"
        Me.pnLabel.Size = New System.Drawing.Size(751, 42)
        Me.pnLabel.TabIndex = 0
        '
        'lbTitle
        '
        Me.lbTitle.Appearance.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbTitle.Appearance.Options.UseFont = True
        Me.lbTitle.Appearance.Options.UseForeColor = True
        Me.lbTitle.Location = New System.Drawing.Point(5, 12)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(209, 22)
        Me.lbTitle.TabIndex = 103
        Me.lbTitle.Text = "DANH MỤC QUỐC GIA:"
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 464)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 2, 30, 0)
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(769, 40)
        Me.FlowLayoutPanel1.TabIndex = 97
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(638, 5)
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
        Me.btnXuatExcel.Location = New System.Drawing.Point(534, 5)
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
        Me.btnXemIn.Location = New System.Drawing.Point(430, 5)
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
        Me.btnXoa.Location = New System.Drawing.Point(326, 5)
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
        Me.btnSua.Location = New System.Drawing.Point(218, 5)
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
        Me.btnNhapMoi.Location = New System.Drawing.Point(110, 5)
        Me.btnNhapMoi.Name = "btnNhapMoi"
        Me.btnNhapMoi.Size = New System.Drawing.Size(102, 31)
        Me.btnNhapMoi.TabIndex = 1
        Me.btnNhapMoi.Text = "Thêm mới"
        '
        'frmDMQuocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 504)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pnContent)
        Me.Name = "frmDMQuocGia"
        Me.Text = "frmDMQuocGia"
        CType(Me.pnContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnContent.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grvQuocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLabel.ResumeLayout(False)
        Me.pnLabel.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnContent As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnLabel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grvQuocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDQuocGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TenQuocGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GhiChu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MoTaQuocGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXuatExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXemIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNhapMoi As DevExpress.XtraEditors.SimpleButton
End Class
