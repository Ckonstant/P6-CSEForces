Public Class PDFview
    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF1.Enter

    End Sub

    Private Sub PDFview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Form1.Label1.Text
    End Sub
End Class