Public Class Example

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        Dim frm1 As New Form1()
        Dim frm2 As New Form2()

        Dim sTextBoxes As New Synchronizer(frm1.txtBox1, frm2.txtBox2)
        Dim sCheckBoxes As New Synchronizer(frm1.chkBox1, frm2.chkBox2)

        frm1.Show()
        frm2.Show()
    End Sub
End Class
