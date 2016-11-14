Public Class Form9

    
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim inches, miter As Single

        inches = 63360 * Val(txtMilies.Text) + 36 * Val(txtYard.Text) + 12 * Val(txtFeets.Text) + Val(txtInches.Text)

        miter = inches / 39.37

        Dim cms, kms As Single

        cms = miter * 100
        kms = Math.Floor(cms / 100000)
        cms = cms - (kms * 100000)
        miter = Math.Floor(cms / 100)
        cms = cms - (miter * 100)

        txtKms.Text = kms
        txtMiter.Text = miter
        txtCentimiter.Text = cms
    End Sub
End Class