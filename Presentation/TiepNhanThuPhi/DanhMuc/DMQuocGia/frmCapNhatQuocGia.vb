Public Class frmCapNhatQuocGia
    Private objEnQuocGia As New Common.DMQuocGiaEntity
    Private objFCQuocGia As New Bussiness.DMQuocGiaFacede

    Private State As Byte

    Sub New(ByVal nState As Byte)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        State = nState
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal nState As Byte, obj As Common.DMQuocGiaEntity)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        State = nState
        objEnQuocGia = obj
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Event _Save()

    Private Sub ClearControl()
        txtID.Text = String.Empty
        txtTenQuocGia.Text = String.Empty
        txtMota.Text = String.Empty
        txtGhiChu.Text = String.Empty
        cboTrangThai.Items.Add("True")
        cboTrangThai.Items.Add("False")
    End Sub
    Private Sub frmCapNhatQuocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case State
            Case ADD_STATE
                ClearControl()
            Case UPDATE_STATE
                txtID.Text = objEnQuocGia.IDQuocGia
                txtTenQuocGia.Text = objEnQuocGia.TenQuocGia
                txtMota.Text = objEnQuocGia.MoTaQuocGia
                txtGhiChu.Text = objEnQuocGia.GhiChu
                If objEnQuocGia.TrangThaiSuDung = 0 Then
                    cboTrangThai.Text = "False"
                    cboTrangThai.Items.Add("True")
                    cboTrangThai.Items.Add("False")
                End If
                If objEnQuocGia.TrangThaiSuDung = 1 Then
                    cboTrangThai.Text = "True"
                    cboTrangThai.Items.Add("False")
                    cboTrangThai.Items.Add("True")
                End If

        End Select
        AddHandler Me.btnThoat.Click, AddressOf Me.Close
        Me.CancelButton = Me.btnThoat
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        objEnQuocGia.IDQuocGia = txtID.Text.Trim
        objEnQuocGia.TenQuocGia = txtTenQuocGia.Text.Trim
        objEnQuocGia.MoTaQuocGia = txtMota.Text.Trim
        objEnQuocGia.TrangThaiSuDung = cboTrangThai.Text.Trim
        objEnQuocGia.GhiChu = txtGhiChu.Text.Trim
        Select Case State
            Case ADD_STATE
                objFCQuocGia.InsertDMQuocGia(objEnQuocGia)
                ClearControl()
            Case UPDATE_STATE
                Console.WriteLine(cboTrangThai.Text.Trim)
                objFCQuocGia.UpdateDMQuocGia(objEnQuocGia)
                MessageBox.Show_CapNhatThanhCong()
        End Select
        RaiseEvent _Save()
        AddHandler Me.btnThoat.Click, AddressOf Me.Close
    End Sub
End Class