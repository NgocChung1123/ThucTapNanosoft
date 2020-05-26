<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhatQuocGia
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
        Me.txtMota = New DevExpress.XtraEditors.MemoEdit()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTenQuocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTrangThai = New System.Windows.Forms.ComboBox()
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenQuocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMota
        '
        Me.txtMota.Location = New System.Drawing.Point(10, 94)
        Me.txtMota.Name = "txtMota"
        Me.txtMota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtMota.Properties.Appearance.Options.UseFont = True
        Me.txtMota.Size = New System.Drawing.Size(283, 79)
        Me.txtMota.TabIndex = 8
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Appearance.Options.UseForeColor = True
        Me.btnThoat.ImageOptions.Image = Global.Presentation.My.Resources.Resources.thoat
        Me.btnThoat.Location = New System.Drawing.Point(504, 260)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 28)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Appearance.Options.UseForeColor = True
        Me.btnLuu.ImageOptions.Image = Global.Presentation.My.Resources.Resources.save
        Me.btnLuu.Location = New System.Drawing.Point(412, 260)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(87, 28)
        Me.btnLuu.TabIndex = 10
        Me.btnLuu.Text = "Lưu"
        '
        'txtTenQuocGia
        '
        Me.txtTenQuocGia.Location = New System.Drawing.Point(102, 41)
        Me.txtTenQuocGia.Name = "txtTenQuocGia"
        Me.txtTenQuocGia.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenQuocGia.Properties.Appearance.Options.UseFont = True
        Me.txtTenQuocGia.Size = New System.Drawing.Size(165, 22)
        Me.txtTenQuocGia.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(102, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Size = New System.Drawing.Size(165, 22)
        Me.txtID.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(361, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Ghi chú"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(17, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Tên quôc gia"
        '
        'lbID
        '
        Me.lbID.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Appearance.Options.UseFont = True
        Me.lbID.Location = New System.Drawing.Point(17, 13)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(71, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "ID Quốc Gia"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Mô tả quốc gia"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(361, 94)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtGhiChu.Properties.Appearance.Options.UseFont = True
        Me.txtGhiChu.Size = New System.Drawing.Size(283, 79)
        Me.txtGhiChu.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(361, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(109, 16)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Trạng thái sử dụng"
        '
        'cboTrangThai
        '
        Me.cboTrangThai.FormattingEnabled = True
        Me.cboTrangThai.Location = New System.Drawing.Point(523, 15)
        Me.cboTrangThai.Name = "cboTrangThai"
        Me.cboTrangThai.Size = New System.Drawing.Size(121, 21)
        Me.cboTrangThai.TabIndex = 14
        '
        'frmCapNhatQuocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 301)
        Me.Controls.Add(Me.cboTrangThai)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtMota)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.txtTenQuocGia)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lbID)
        Me.Name = "frmCapNhatQuocGia"
        Me.Text = "frmCapNhatQuocGia"
        CType(Me.txtMota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenQuocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTenQuocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTrangThai As ComboBox
End Class
