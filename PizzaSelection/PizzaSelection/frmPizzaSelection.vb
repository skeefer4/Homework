Public Class frmPizzaSelection
    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        btnDeepDish.Enabled = False
        btnThinCrust.Enabled = False
        btnSelectPizza.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnSelectPizza.Enabled = True
    End Sub
End Class
