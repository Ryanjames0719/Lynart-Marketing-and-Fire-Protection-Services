Public Class additemform
    Public Property ItemName As String
    Public Property ItemPrice As String
    Public Property ItemImage As Image
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub additemform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub browsebutton_Click(sender As Object, e As EventArgs) Handles browsebutton.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            picItem.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
         String.IsNullOrWhiteSpace(txtprice.Text) OrElse
         picItem.Image Is Nothing Then
            MessageBox.Show("Please fill in all fields and select an image.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim priceValue As Integer
        If Not Integer.TryParse(txtprice.Text, priceValue) Then
            MessageBox.Show("Price must contain numbers only.",
                            "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Save input values
        ItemName = txtname.Text.Trim()
        ItemPrice = priceValue.ToString()
        ItemImage = picItem.Image

        ' Close form and return OK result
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class