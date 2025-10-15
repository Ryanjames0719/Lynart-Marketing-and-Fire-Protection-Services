Public Class Services
    Private isMenuOpen As Boolean = False
    Dim lbs As Integer
    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.Location = New Point(0, -1)
        btnMenu.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        pnlMenu.BringToFront()
        btnMenu.BringToFront()
        ToggleMenu(pnlMenu, 330, isMenuOpen)
    End Sub

    Private Sub Red5lbs_Click(sender As Object, e As EventArgs) Handles Red5lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 5
        ProductData.CurrentProductName = Red5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red5lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Red10lbs_Click(sender As Object, e As EventArgs) Handles Red10lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = Red10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red10lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Red20lbs_Click(sender As Object, e As EventArgs) Handles Red20lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 20
        ProductData.CurrentProductName = Red20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(Red20lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue5lbs_Click(sender As Object, e As EventArgs) Handles blue5lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 5
        ProductData.CurrentProductName = blue5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue5lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub
    Private Sub blue10lbs_Click(sender As Object, e As EventArgs) Handles blue10lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = blue10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue10lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub blue20lbs_Click(sender As Object, e As EventArgs) Handles blue20lbs.Click
        Dim servicefrm As New ServicesForm()
        lbs = 10
        ProductData.CurrentProductName = blue20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue20lbsprice.Text)
        ProductData.Currentpounds = lbs
        servicefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim frntpage As New Frontpage()
        frntpage.Show()
        Me.Hide()
    End Sub
End Class
