<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox
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
        Me.picPicture = New DevExpress.XtraEditors.PictureEdit
        Me.btnButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.btnButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lblNoiDung = New DevExpress.XtraEditors.LabelControl
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPicture.Location = New System.Drawing.Point(1, 0)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(53, 44)
        Me.picPicture.TabIndex = 0
        '
        'btnButton3
        '
        Me.btnButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton3.Appearance.Options.UseFont = True
        Me.btnButton3.Location = New System.Drawing.Point(252, 42)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(80, 25)
        Me.btnButton3.TabIndex = 1
        Me.btnButton3.Text = "SimpleButton1"
        '
        'btnButton2
        '
        Me.btnButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton2.Appearance.Options.UseFont = True
        Me.btnButton2.Location = New System.Drawing.Point(165, 42)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(80, 25)
        Me.btnButton2.TabIndex = 2
        Me.btnButton2.Text = "SimpleButton2"
        '
        'btnButton1
        '
        Me.btnButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton1.Appearance.Options.UseFont = True
        Me.btnButton1.Location = New System.Drawing.Point(78, 42)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(80, 25)
        Me.btnButton1.TabIndex = 3
        Me.btnButton1.Text = "SimpleButton3"
        '
        'lblNoiDung
        '
        Me.lblNoiDung.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblNoiDung.Appearance.Options.UseFont = True
        Me.lblNoiDung.Location = New System.Drawing.Point(58, 14)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Size = New System.Drawing.Size(66, 13)
        Me.lblNoiDung.TabIndex = 4
        Me.lblNoiDung.Text = "LabelControl1"
        '
        'MessageBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(336, 69)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNoiDung)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.picPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MessageBox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nanosoft Message"
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNoiDung As DevExpress.XtraEditors.LabelControl
End Class
