Public Class AddMenuItem
    Dim objC As New StockItems
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmdItemUnit.SelectedIndex = 0
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub btnSaveItems_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveItems.Click
        objC.Item_Desc = txtItemDesc.Text
        objC.Item_Qty = CDec(txtItemQty.Text)

        If (cmdItemUnit.SelectedItem = "Litres") Then
            objC.Item_Unit = "L"
        ElseIf (cmdItemUnit.SelectedItem = "Loose") Then
            objC.Item_Unit = "Ls"
        ElseIf (cmdItemUnit.SelectedItem = "Milli-litre") Then
            objC.Item_Unit = "ml"
        End If
        'objC.Item_Unit = cmdItemUnit.SelectedItem.ToString()
        objC.Item_Price = CDec(txtItemCostPrice.Text)
        objC.Reorder_Threshold = 0
        objC.SaveReceivedStock()
        MessageBox.Show("Succesfully saved")
    End Sub
End Class