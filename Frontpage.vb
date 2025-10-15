Public Class Frontpage
    Private isMenuOpen As Boolean = False
    ' Constructor accepts username
    Private Sub Frontpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        dashboardname.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        MainPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim service As New Services()
        service.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim mainfrm As New Maintenance()
        mainfrm.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub prodbtn_Click(sender As Object, e As EventArgs) Handles prodbtn.Click
        Dim prod_catalog As New Product_catalog()
        prod_catalog.Show()
        Me.Hide()
    End Sub

    Private Sub mainbtn_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Dim mainfrm As New Maintenance()
        mainfrm.Show()
        Me.Hide()
    End Sub

    Private Sub servicebtn_Click(sender As Object, e As EventArgs) Handles servicebtn.Click
        Dim service As New Services()
        service.Show()
        Me.Hide()
    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class