Imports System.Runtime.Remoting.Messaging

Public Class Product_catalog
    Private Sub Product_catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        MainPanel.Anchor = AnchorStyles.None
        MainPanel.Dock = DockStyle.Fill
        HeaderPanel.Anchor = AnchorStyles.None
        HeaderPanel.Dock = DockStyle.Top

    End Sub

    Private Sub blue1name_Click_1(sender As Object, e As EventArgs)
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue5lbsprice.Text)
        ProductData.CurrentProductImage = blue5lbspic.Image
        orderfrm.Show()
        Frontpage.Hide()

    End Sub

    Private Sub blue2name_Click_1(sender As Object, e As EventArgs)
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue10lbsprice.Text)
        ProductData.CurrentProductImage = blue5lbspic.Image
        orderfrm.Show()

    End Sub

    Private Sub blue3name_Click_1(sender As Object, e As EventArgs)
        Dim orderfrm As New OrderForm()
        ProductData.CurrentProductName = blue20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue20lbsprice.Text)
        ProductData.CurrentProductImage = blue5lbspic.Image
        orderfrm.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Dim ftnpage As New Frontpage()
        ftnpage.Show()
        Me.Hide()
    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics = e.Graphics
        Dim tabRect As Rectangle = TabControl1.GetTabRect(e.Index)
        Dim tabText As String = TabControl1.TabPages(e.Index).Text

        ' 🎨 Choose colors
        Dim backColor As Color
        Dim textColor As Color = Color.White

        ' Highlight selected tab
        If e.Index = TabControl1.SelectedIndex Then
            backColor = Color.Firebrick   ' Active tab color
        Else
            backColor = Color.DarkGray    ' Inactive tab color
        End If

        ' Fill background
        g.FillRectangle(New SolidBrush(backColor), tabRect)

        ' Draw text centered
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        g.DrawString(tabText, TabControl1.Font, New SolidBrush(textColor), tabRect, sf)
    End Sub
    Private Sub red5lbs_Click(sender As Object, e As EventArgs) Handles red5lbs.Click
        ProductData.CurrentProductName = red5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red1price.Text)
        ProductData.CurrentProductImage = red5lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")
        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If
    End Sub

    Private Sub red10lbs_Click(sender As Object, e As EventArgs) Handles red10lbs.Click
        ProductData.CurrentProductName = red10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red2price.Text)
        ProductData.CurrentProductImage = red5lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")

        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If
    End Sub

    Private Sub red20lbs_Click(sender As Object, e As EventArgs) Handles red20lbs.Click

        ProductData.CurrentProductName = red20lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(red3price.Text)
        ProductData.CurrentProductImage = red5lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")

        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If

    End Sub
    Private Sub blue5lbs_Click(sender As Object, e As EventArgs) Handles blue5lbs.Click
        ProductData.CurrentProductName = blue5lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue5lbsprice.Text)
        ProductData.CurrentProductImage = blue5lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")

        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If
    End Sub

    Private Sub blue10lbs_Click(sender As Object, e As EventArgs) Handles blue10lbs.Click
        ProductData.CurrentProductName = blue10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue10lbsprice.Text)
        ProductData.CurrentProductImage = blue10lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")

        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If
    End Sub

    Private Sub blue20lbs_Click(sender As Object, e As EventArgs) Handles blue20lbs.Click
        ProductData.CurrentProductName = blue10lbs.Text
        ProductData.CurrentProductPrice = Decimal.Parse(blue10lbsprice.Text)
        ProductData.CurrentProductImage = blue20lbspic.Image
        Dim mainForm = Application.OpenForms("Frontpage")

        ' Make sure it's found
        If mainForm IsNot Nothing Then
            ' Hide the main form instead of closing it
            mainForm.Hide()
            ' Create and show the OrderForm as a dialog (so it blocks other actions)
            Dim orderForm As New OrderForm()
            AddHandler orderForm.FormClosed, Sub()
                                                 mainForm.Show() ' When OrderForm closes, show MainForm again
                                             End Sub
            orderForm.Show()
        End If
    End Sub
End Class