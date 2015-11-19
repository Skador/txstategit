Public Class Form1

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuPackagesScuba_Click(sender As Object, e As EventArgs) Handles mnuPackagesScuba.Click
        ' Create an instance of the ScubaForm.
        Dim frmScuba As New ScubaForm

        ' Display the ScubaForm in modal style.
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuPackagesSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuPackagesSkyDiving.Click
        ' Create an instance of the SkyDiveForm.
        Dim frmSkyDive As New SkyDiveForm

        ' Display the SkyDiveForm in modal style.
        frmSkyDive.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display a simple About box.
        MessageBox.Show("High Adventure Travel Price Quote System Version 1.0")
    End Sub
End Class
