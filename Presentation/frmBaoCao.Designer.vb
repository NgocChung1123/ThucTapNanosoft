<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCao
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
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Cornsilk
        Me.btnReport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Red
        Me.btnReport.Location = New System.Drawing.Point(193, 58)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(124, 55)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "Báo cáo"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'frmBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 235)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "frmBaoCao"
        Me.Text = "frmBaoCao"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReport As Button
End Class
