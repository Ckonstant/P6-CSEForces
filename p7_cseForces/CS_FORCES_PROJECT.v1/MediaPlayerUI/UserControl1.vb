Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.ComponentModel
Public Class UserControl1
    Dim WithEvents wc As New WebClient
    Dim dpath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Dim lastUpdate As DateTime
    Dim lastBytes As Long = 0
    Dim iSecond As Double = 0
    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        GunaContextMenuStrip1.Show(MousePosition)
    End Sub

    Private Sub lb_name_Click(sender As Object, e As EventArgs)





    End Sub


    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then

            Try



                GunaProgressBar1.Visible = False
                GunaLabel1.Visible = False
                GunaLabel2.Visible = False
                GunaLabel3.Visible = False
                GunaLabel4.Visible = False
                GunaLabel5.Visible = False
                Dim zipPath As String = (dpath + GunaLabel7.Text + ".zip")
                Dim extractPath As String = dpath

                ''ZipFile.CreateFromDirectory(startPath, zipPath)

                ZipFile.ExtractToDirectory(zipPath, extractPath)
                lb_name.Image = My.Resources.icons8_checkmark_32
                GunaWinCircleProgressIndicator1.Visible = False
                lb_name.Visible = True
                GunaLabel8.Visible = False
                ''MsgBox("Επιτυχης εγκατασταση πακετου.")

                ''  Me.Close()
                ''  Form1.Show()
            Catch ex As Exception
                MsgBox("Σφάλμα κατά την εγκατάσταση του πακέτου.")
                Exit Sub
            End Try


        Else
            MessageBox.Show(e.Error.Message)
            Exit Sub
        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        '' MsgBox("Total size of :" + (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00") + "Found")
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        GunaLabel4.Text = String.Format("{0} MB / {1} MB", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        '' ActiveForm.Text = ("Ποσοστό Ολοκλήρωσης: ") + e.ProgressPercentage.ToString & ("%")
        GunaLabel5.Text = "(" & e.ProgressPercentage & "%)"
        If lastBytes = 0 Then
            lastUpdate = DateTime.Now
            lastBytes = e.BytesReceived
            Return
        End If

        Dim now = DateTime.Now
        Dim timeSpan = now - lastUpdate
        If Not timeSpan.Seconds = 0 Then
            Dim bytesChange = e.BytesReceived - lastBytes
            Dim bytesPerSecond = bytesChange / timeSpan.Seconds

            lastBytes = e.BytesReceived
            lastUpdate = now
            GunaLabel2.Text = String.Format("{0} MB/s", (bytesPerSecond / 1024D / 1024D).ToString("0.00"))
            '' left.Text = "Timeleft:" + Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond) + " s"
            '' left.Text = "Timeleft:" & Math.Round(((1 - Me.ProgressBar1.Value / 100) * Math.Round((e.TotalBytesToReceive / 1024), 2)) / bytesPerSecond / 1024D / 1024D) & " s"


            Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
            iSecond = Math.Round((e.TotalBytesToReceive - e.BytesReceived) / (bytesPerSecond))
            If iSecond < 60 Then
                GunaLabel3.Text = "Estimated:" & iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
            ElseIf iSecond < 3600 Then
                GunaLabel3.Text = "Estimated:" & iSpan.Minutes.ToString.PadLeft(1, "0"c) & " minutes " &
                                iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
            Else
                GunaLabel3.Text = "Estimated:" & iSpan.Hours.ToString.PadLeft(1, "0"c) & " hours " &
                        iSpan.Minutes.ToString.PadLeft(1, "0"c) & " minutes "
                ''&                         iSpan.Seconds.ToString.PadLeft(1, "0"c) & "s"
            End If
            ''left.Text = "Estimated:" & Math.Round((e.TotalBytesToReceive - e.BytesReceived) / (bytesPerSecond)) & "s"

        End If



        GunaProgressBar1.Value = e.ProgressPercentage

        If GunaProgressBar1.Value = 90 Then
            GunaLabel1.Text = "Αποσυμπίεση αρχειων..."
        End If
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)


        Try
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            If Not System.IO.Directory.Exists(dpath) Then
                System.IO.Directory.CreateDirectory(dpath)
            End If
            wc.DownloadFileAsync(New Uri(GunaLabel6.Text), dpath + GunaLabel7.Text + ".zip")

            GunaWinCircleProgressIndicator1.Visible = True
            GunaProgressBar1.Visible = True
            GunaLabel1.Visible = True
            GunaLabel2.Visible = True
            GunaLabel3.Visible = True
            GunaLabel4.Visible = True
            GunaLabel5.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub ΔιαγραφήΠακέτουToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΔιαγραφήΠακέτουToolStripMenuItem.Click
        Try
            Dim dirF As New System.IO.DirectoryInfo(dpath + GunaLabel7.Text)
            Dim dirZ As New System.IO.DirectoryInfo(dpath + GunaLabel7.Text)

            If dirF.Exists Then
                '' System.IO.Directory.Delete(dpath & GunaLabel7.Text & ".zip", True)
                System.IO.Directory.Delete(dpath & GunaLabel7.Text, True)
                File.Delete(dpath + GunaLabel7.Text + ".zip")
                lb_name.Image = My.Resources.icons8_download_32
            Else
                MsgBox("Δεν βρέθηκε πακέτο για διαγραφή.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ΚατέβασμαΠακέτουToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΚατέβασμαΠακέτουToolStripMenuItem.Click

        Try
            AddHandler wc.DownloadFileCompleted, AddressOf OnDownloadComplete
            AddHandler wc.DownloadProgressChanged, AddressOf client_ProgressChanged
            If Not System.IO.Directory.Exists(dpath) Then
                System.IO.Directory.CreateDirectory(dpath)
            End If
            wc.DownloadFileAsync(New Uri(GunaLabel6.Text), dpath + GunaLabel7.Text + ".zip")

            GunaWinCircleProgressIndicator1.Visible = True
            GunaProgressBar1.Visible = True
            GunaLabel1.Visible = True
            GunaLabel2.Visible = True
            GunaLabel3.Visible = True
            GunaLabel4.Visible = True
            GunaLabel5.Visible = True
            GunaLabel8.Visible = True
            lb_name.Visible = False
            GunaLabel8.Text = lb_name.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub



    Private Sub lb_name_Click_1(sender As Object, e As EventArgs) Handles lb_name.Click

        Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text) ''gunalabel7.text  = p.x = anaptiksi folder
        If dir.Exists Then
            Form1.mathima = GunaLabel7.Text
            My.Settings.chosenM = GunaLabel7.Text
            My.Settings.mathimaName = lb_name.Text
            My.Settings.Save()
            Form1.onomaMathimatos = lb_name.Text


            Form1.GunaLabel1.Text = lb_name.Text
            Form1.btnPlaylist.PerformClick()
            ''  Form1.openChildForm(New Form4())
            ''Me.ActiveMdiChild.Close()
            FindForm.Close()
        Else
            Dim result As DialogResult = MessageBox.Show("Κατεβάστε πρώτα το πακέτο πριν την επιλογή μαθήματος." & vbCrLf & "Θέλετε να γίνει λήψη τώρα?", "cs FORCES", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ΚατέβασμαΠακέτουToolStripMenuItem.PerformClick()

            Else
                Exit Sub
            End If

        End If
    End Sub
    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function
    Private Sub ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Click

        ''  Dim dir As New IO.DirectoryInfo(dpath + GunaLabel7.Text + ".zip")
        Try
            Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dpath + GunaLabel7.Text + ".zip")
            Dim newDsize As String = GetDownloadSize(GunaLabel6.Text)
            If infoReader.Exists Then
                If newDsize = infoReader.Length Then
                    MsgBox("Δεν υπάρχει νέο πακέτο.")
                    Exit Sub
                Else
                    Dim result As DialogResult = MessageBox.Show("Υπάρχει νέο πακέτο για λήψη!!" & vbNewLine & "Να γίνει λήψη τώρα?", "Cse Forces", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                    If result = vbYes Then
                        ΚατέβασμαΠακέτουToolStripMenuItem.PerformClick()
                    Else
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MyCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyCoursesToolStripMenuItem.Click
        MessageBox.Show("Under Construction...", "Cs Forces - WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub GunaContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles GunaContextMenuStrip1.Opening

    End Sub
End Class
