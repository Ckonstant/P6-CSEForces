Imports System.IO

Public Class UserControl2


    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click

        GunaContextMenuStrip1.Show(MousePosition)

    End Sub

    Private Sub lb_name_Click(sender As Object, e As EventArgs) Handles lb_name.Click
        ''GunaContextMenuStrip1.Show(MousePosition)

        Dim test As String = lb_company.Text
        test = Microsoft.VisualBasic.Right(test, 4)


        If (test <> ".pdf") Then
            MsgBox("Παρακαλώ επιλέξτε αρχείο μορφής .pdf")
            ''lb_company.SaveAs(strNewFileName, 32)
            Exit Sub
        End If
        '' If UbuntuCheckBox1.Checked = False Then
        ''Me.Hide()

        '' End If
        Try
            Dim fn = New PDFview
            fn.Show()



            fn.AxAcroPDF1.src = lb_company.Text

        Catch ex As Exception
            MsgBox("Το αρχείο είτε δεν υπάρχει είτε δεν υπάρχει εγκατεστημένο το Adobe Reader.")
        End Try

    End Sub

    Private Sub ΠροβολήToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΠροβολήToolStripMenuItem.Click
        Dim test As String = lb_company.Text
        test = Microsoft.VisualBasic.Right(test, 4)


        If (test <> ".pdf") Then
            MsgBox("Παρακαλώ επιλέξτε αρχείο μορφής .pdf")
            ''lb_company.SaveAs(strNewFileName, 32)
            Exit Sub
        End If
        '' If UbuntuCheckBox1.Checked = False Then
        ''Me.Hide()

        '' End If
        Try
            Dim fn = New PDFview
            Form1.Label1.Text = lb_name.Text
            fn.Show()



            fn.AxAcroPDF1.src = lb_company.Text

        Catch ex As Exception
            MsgBox("Το αρχείο είτε δεν υπάρχει είτε δεν υπάρχει εγκατεστημένο το Adobe Reader.")
        End Try
    End Sub

    Private Sub ΛήψηToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΛήψηToolStripMenuItem.Click
        FilePath()
    End Sub


    Private Sub BackUpDataBase(ByVal filePath As String)

        If File.Exists(lb_company.Text) Then
            File.Copy(lb_company.Text, filePath)
            MessageBox.Show("Επιτυχής αποθήκευση Αρχείου!!!")
        End If
    End Sub

    Private Sub FilePath()
        Using sfdSaveFileDialog As New SaveFileDialog With {.DefaultExt = "pdf", .Title = "Save file as",
                                                            .FileName = String.Format(lb_name.Text),
                                                            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                                            .Filter = "All files (*.*)|*.*"}


            Dim result As DialogResult = sfdSaveFileDialog.ShowDialog

            If result = DialogResult.OK Then
                BackUpDataBase(sfdSaveFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        ΠροβολήToolStripMenuItem.PerformClick()
    End Sub
End Class
