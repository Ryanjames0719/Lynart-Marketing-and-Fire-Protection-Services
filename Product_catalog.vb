Imports System.Runtime.Remoting.Messaging

Public Class Product_catalog
    Private selectedPanel As Panel = Nothing

    Private Sub Product_catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Userlabel.Text = SessionData.CurrentUsername
        Dim UserID As Integer = SessionData.CurrentUserID
        MainPanel.Anchor = AnchorStyles.None
        MainPanel.Dock = DockStyle.Fill
        HeaderPanel.Anchor = AnchorStyles.None
        HeaderPanel.Dock = DockStyle.Top
        MakePanelSelectable(Panel10)
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

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
    'etong additem panel is for adding items nga recommend ko is itake nio size nung panel ng item and also locations ng controls
    'like label image or ung another panel tapos dun nio sia ipaprompt kay gpt
    Private Sub AddItemToPanel(itemName As String, price As String, itemImage As Image)
        ' === Container panel for the entire item ===
        Dim itemPanel As New Panel()
        itemPanel.Size = New Size(227, 253)
        itemPanel.BorderStyle = BorderStyle.FixedSingle
        itemPanel.BackColor = Color.Firebrick

        'eto ung para sa delete handler'
        AddHandler itemPanel.Click, Sub()
                                        ' Deselect previous
                                        If selectedPanel IsNot Nothing Then
                                            selectedPanel.BackColor = Color.Firebrick
                                        End If
                                        ' Select new one
                                        selectedPanel = itemPanel
                                        selectedPanel.BackColor = Color.DarkRed ' highlight
                                    End Sub
        ' === PictureBox ===
        Dim pb As New PictureBox()
        pb.Size = New Size(191, 141)
        pb.Location = New Point(16, 11)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = itemImage
        itemPanel.Controls.Add(pb)

        ' === Description panel ===
        Dim descPanel As New Panel()
        descPanel.Size = New Size(191, 74)
        descPanel.Location = New Point(16, 163)
        descPanel.BackColor = Color.White
        descPanel.ForeColor = Color.Black

        Dim lblName As New Label() With {.Text = itemName, .Location = New Point(8, 9), .Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold Or FontStyle.Underline), .ForeColor = Color.Black, .AutoSize = False,
    .Size = New Size(175, 30), ' width of descPanel minus padding
    .TextAlign = ContentAlignment.TopLeft}
        Dim lblPeso As New Label() With {.Text = "Php", .Location = New Point(8, 37), .Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold), .ForeColor = Color.Black, .AutoSize = True}
        Dim lblPrice As New Label() With {.Text = price, .Location = New Point(52, 37), .Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold), .ForeColor = Color.Black}
        AddHandler lblName.Click, Sub(sender As Object, e As EventArgs)
                                      ' eto ung pagpasa sa orderform
                                      ProductData.CurrentProductName = itemName
                                      ProductData.CurrentProductPrice = Decimal.Parse(price)
                                      ProductData.CurrentProductImage = itemImage

                                      ' Show OrderForm
                                      Dim mainForm = Application.OpenForms("Frontpage")
                                      If mainForm IsNot Nothing Then
                                          mainForm.Hide()
                                          Dim orderForm As New OrderForm()
                                          AddHandler orderForm.FormClosed, Sub()
                                                                               mainForm.Show()
                                                                           End Sub
                                          orderForm.Show()
                                      End If
                                  End Sub
        descPanel.Controls.Add(lblName)
        descPanel.Controls.Add(lblPeso)
        descPanel.Controls.Add(lblPrice)
        itemPanel.Controls.Add(descPanel)

        ' === Add the item panel to the FlowLayoutPanel ===
        flowitems.Controls.Add(itemPanel)
    End Sub

    Private Sub additembtn_Click(sender As Object, e As EventArgs) Handles additembtn.Click
        'Dim addForm As New additemform()

        'If addForm.ShowDialog() = DialogResult.OK Then
        '    AddItemToPanel(addForm.ItemName, addForm.ItemPrice, addForm.ItemImage)
        'End If
        'Dim bmp As New Bitmap(100, 100)
        'Using g As Graphics = Graphics.FromImage(bmp)
        '    g.Clear(Color.Blue)
        'End Using

        'AddItemToPanel("Test Item", "123", bmp)

        'eto mismo ung nsa add button kumbaga '
        Dim addForm As New additemform()

        If addForm.ShowDialog() = DialogResult.OK Then
            AddItemToPanel(addForm.ItemName, addForm.ItemPrice, addForm.ItemImage)
        End If
    End Sub

    Private Sub flowitems_Paint(sender As Object, e As PaintEventArgs) Handles flowitems.Paint

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If selectedPanel IsNot Nothing Then
            selectedPanel.Parent.Controls.Remove(selectedPanel)
            selectedPanel.Dispose()
            MessageBox.Show("Selected item deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selectedPanel = Nothing
        Else
            MessageBox.Show("Please select an item to delete first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub SelectPanel(p As Panel)
        ' unselect previous
        If selectedPanel IsNot Nothing AndAlso selectedPanel IsNot p Then
            selectedPanel.BackColor = Color.Firebrick
        End If

        ' toggle selection: click same panel again will deselect
        If selectedPanel Is p Then
            selectedPanel.BackColor = Color.Firebrick
            selectedPanel = Nothing
            Return
        End If

        ' select new panel
        selectedPanel = p
        selectedPanel.BackColor = Color.DarkRed
    End Sub
    Private Sub MakePanelSelectable(p As Panel)
        ' click on the panel itself
        AddHandler p.Click, Sub(sender As Object, e As EventArgs)
                                SelectPanel(p)
                            End Sub

        ' make inner controls select the parent panel when clicked
        For Each ctrl As Control In p.Controls
            AddHandler ctrl.Click, Sub(sender As Object, e As EventArgs)
                                       SelectPanel(p)
                                   End Sub
        Next
    End Sub

    Private Sub Panel10_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub
End Class