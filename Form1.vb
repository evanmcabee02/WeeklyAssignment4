Public Class frmairbnb
    Const cdecCostPerNight As Decimal = 79D
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        strEnterNumberOfNights = txtNights.Text
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        decTotalCostOfStay = intEnterNumberOfNights * cdecCostPerNight
        lblTotalCost.Text = decTotalCostOfStay.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub frmairbnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = "Only " & cdecCostPerNight.ToString("C") & " per night"
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub
End Class
