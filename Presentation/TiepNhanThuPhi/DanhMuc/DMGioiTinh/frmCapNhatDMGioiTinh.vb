Public Class frmCapNhatDMGioiTinh
    Private objEnQuocGia As New Common.DMGioiTinhEntity
    Private objFCQuocGia As New Bussiness.DMGioiTinhFacade

    Public Event _Save()
    Private State As Byte

    Sub New(ByVal nState As Byte)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        State = nState
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal nState As Byte, ByVal obj As Common.DMGioiTinhEntity)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        State = nState
        objEnQuocGia = obj
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ClearControl()
        txtIDGioiTinh.Text = String.Empty
        txtTenGioiTinh.Text = String.Empty
        txtGhiChu.Text = String.Empty
        txtIDGioiTinh.Focus()
    End Sub

    Private Sub frmCapNhatDMQuocGia_Load() Handles MyBase.Load
        Select Case State
            Case ADD_STATE
                ClearControl()
            Case UPDATE_STATE
                Me.txtIDGioiTinh.Text = objEnQuocGia.IDGioiTinh
                Me.txtTenGioiTinh.Text = objEnQuocGia.TenGioiTinh
                txtGhichu.Text = objEnQuocGia.GhiChu
                txtIDGioiTinh.Enabled = False
        End Select
        AddHandler Me.btnThoat.Click, AddressOf Me.Close
        Me.CancelButton = Me.btnThoat
    End Sub

    Private Sub btnLuu_Click() Handles btnLuu.Click
        objEnQuocGia.IDGioiTinh = txtIDGioiTinh.Text.Trim
        objEnQuocGia.TenGioiTinh = txtTenGioiTinh.Text
        objEnQuocGia.GhiChu = txtGhichu.Text
        Select Case State
            Case ADD_STATE
                objFCQuocGia.InsertDMGioiTinh(objEnQuocGia)
                ClearControl()
            Case UPDATE_STATE
                objFCQuocGia.UpdateDMGioiTinh(objEnQuocGia)
                MessageBox.Show_CapNhatThanhCong()
        End Select
        RaiseEvent _Save()
    End Sub

    Private Sub KeyDownEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

End Class