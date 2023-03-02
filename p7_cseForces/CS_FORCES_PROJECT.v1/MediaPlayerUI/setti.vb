Public Class setti
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Try
            If GunaWinSwitch1.Checked = False Then
                Form1.FormBorderStyle = FormBorderStyle.None
                Form1.MaximizeBox = False
                My.Settings.windowSett = False
                My.Settings.Save()
            Else
                My.Settings.windowSett = True
                My.Settings.Save()
                Form1.FormBorderStyle = FormBorderStyle.FixedSingle
                Form1.MaximizeBox = False
            End If

            If GunaWinSwitch2.Checked = False Then
                '' Form1.FormBorderStyle = FormBorderStyle.None
                My.Settings.maxSett = False
                My.Settings.Save()
                Form1.MaximizeBox = False
            Else
                My.Settings.maxSett = True
                My.Settings.Save()
                Form1.FormBorderStyle = FormBorderStyle.FixedSingle
                Form1.MaximizeBox = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Handler(cse forces)", MessageBoxButtons.OK)
        End Try





    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaWinSwitch2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs) Handles GunaSeparator1.Click

    End Sub

    Private Sub setti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Settings.windowSett = False Then
                GunaWinSwitch1.Checked = False
            Else
                GunaWinSwitch1.Checked = True
            End If
            If My.Settings.maxSett = False Then
                GunaWinSwitch2.Checked = False
            Else
                GunaWinSwitch2.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Handler(cse forces)", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged_1(sender As Object, e As EventArgs) Handles GunaWinSwitch1.CheckedChanged

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click

        Dim result As DialogResult = MessageBox.Show("Να γίνει διαγραφή πακέτων ?", "ΔΙΑΓΡΑΦΗ ΠΑΚΕΤΩΝ -ΣΗΜΑΝΤΙΚΟ", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim packagePath As String = My.Application.Info.DirectoryPath + "\FULLDATA"
                Dim existPath As New IO.DirectoryInfo(packagePath) ''gunalabel7.text  = p.x = anaptiksi folder
                If existPath.Exists Then
                    System.IO.Directory.Delete(packagePath, True)

                Else
                    MsgBox("Δεν υπάρχουν πακέτα για διαγραφή")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Handler(cse forces)", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        MsgBox("Δεν υπάρχει διαθέσιμη ενημέρωση.")
    End Sub


End Class