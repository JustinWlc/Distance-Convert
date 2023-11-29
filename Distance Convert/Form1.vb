Public Class Form1
    Private Sub btnConcerttoKM_Click(sender As Object, e As EventArgs) Handles btnConcerttoKM.Click
        Dim Miles As Decimal
        Dim KM As Decimal

        Miles = txtMiles.Text

        KM = Miles * 1.609

        txtKM.Text = KM


    End Sub

    Private Sub btnConcerttoMiles_Click(sender As Object, e As EventArgs) Handles btnConcerttoMiles.Click
        Dim Miles As Decimal
        Dim KM As Decimal

        KM = txtKM.Text

        Miles = KM / 1.609

        txtMiles.Text = Miles
    End Sub

    Private Sub bntReset_Click(sender As Object, e As EventArgs) Handles bntReset.Click
        ResetText()
        txtMiles.ResetText()
        txtKM.ResetText()
    End Sub


End Class