Public Class Form3

    Dim table As DataTable
    Dim dipath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Private Sub LoadRows(ByVal dir As String)
        If IO.Directory.Exists(dir) Then
            Try
                For Each fn As String In IO.Directory.GetFiles(dir, "*.*")
                    table.Rows.Add(IO.Path.GetFileName(fn), fn)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GunaVScrollBar1.Focus()
        GunaVScrollBar1.Visible = True
        Dim fileExten As String
        Dim r As New Random
        Me.table = New DataTable


        If Form1.bookflag = "simeioseis" Then
            table.Clear()

            With table.Columns
                .Add("Name", GetType(String))
                .Add("FullPath", GetType(String))
            End With
            Me.LoadRows(dipath + Form1.mathima + "\diafaneies")

            For i As Integer = table.Rows.Count - 1 To 0 Step -1
                Dim c As UserControl2 = New UserControl2
                c.Dock = DockStyle.Top
                fileExten = table.Rows(i).Item(0).ToString
                c.lb_name.Text = table.Rows(i).Item(0).ToString
                c.lb_type.Text = fileExten.Substring(fileExten.LastIndexOf(".") + 1)
                c.GunaGradientButton1.Text = table.Rows(i).Item(0).ToString
                c.lb_company.Text = table.Rows(i).Item(1).ToString

                paneltest.Controls.Add(c)

            Next

        ElseIf Form1.bookflag = "askiseis" Then
            table.Clear()

            With table.Columns
                .Add("Name", GetType(String))
                .Add("FullPath", GetType(String))
            End With
            Me.LoadRows(dipath + Form1.mathima + "\askiseis")

            For i As Integer = table.Rows.Count - 1 To 0 Step -1
                Dim c As UserControl2 = New UserControl2
                c.Dock = DockStyle.Top
                fileExten = table.Rows(i).Item(0).ToString
                c.lb_name.Text = table.Rows(i).Item(0).ToString
                c.GunaGradientButton1.Text = table.Rows(i).Item(0).ToString
                c.lb_type.Text = fileExten.Substring(fileExten.LastIndexOf(".") + 1)

                c.lb_company.Text = table.Rows(i).Item(1).ToString

                paneltest.Controls.Add(c)

            Next

        Else
            table.Clear()

            With table.Columns
                .Add("Name", GetType(String))
                .Add("FullPath", GetType(String))
            End With
            Me.LoadRows(dipath + Form1.mathima + "\themata")

            For i As Integer = table.Rows.Count - 1 To 0 Step -1
                Dim c As UserControl2 = New UserControl2
                c.Dock = DockStyle.Top
                fileExten = table.Rows(i).Item(0).ToString
                c.lb_name.Text = table.Rows(i).Item(0).ToString
                c.GunaGradientButton1.Text = table.Rows(i).Item(0).ToString
                c.lb_type.Text = fileExten.Substring(fileExten.LastIndexOf(".") + 1)

                c.lb_company.Text = table.Rows(i).Item(1).ToString

                paneltest.Controls.Add(c)

            Next

        End If
        GunaVScrollBar1.Visible = True

        Dim max As Integer = paneltest.Height - Panel1.Height

        If max > 0 Then

            GunaVScrollBar1.Maximum = max + SystemInformation.VerticalScrollBarArrowHeight

        End If
        ''GunaLabel3.Text = max
        If max < 3 Then
            GunaVScrollBar1.Visible = False
            '' GunaVScrollBar1.Enabled = False

        End If


    End Sub
    Private Sub paneltest_Scroll(sender As Object, e As ScrollEventArgs) Handles paneltest.Scroll
        ''GunaVScrollBar1.Value = paneltest.VerticalScroll.Value
    End Sub

    Private Sub GunaVScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles GunaVScrollBar1.ValueChanged

        paneltest.Top = -GunaVScrollBar1.Value



    End Sub



    Private Sub paneltest_MouseWheel(sender As Object, e As MouseEventArgs) Handles paneltest.MouseWheel
        If GunaVScrollBar1.Visible = True Then
            If e.Delta <= 0 Then
                GunaVScrollBar1.Value += 10
            Else
                GunaVScrollBar1.Value -= 10
            End If

            GunaVScrollBar1.Select()
        End If
    End Sub
    Private Sub createData()
        Dim dir As New IO.DirectoryInfo(Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3) + "FULLDATA\" + "analisi")
        If dir.Exists Then

        Else
            Dim ask As MsgBoxResult = MsgBox("Θελετέ να κατεβασετε το πακετο για διακριτα?", MsgBoxStyle.YesNo)
            If ask = MsgBoxResult.Yes Then


            Else
                Me.Show()
            End If

        End If

        Me.table = New DataTable
        With table.Columns
            .Add("Name", GetType(String))
            .Add("FullPath", GetType(String))
        End With
        Me.table.Rows.Add("Διαφάνειες", "PDFS")



    End Sub
    Private Sub paneltest_Paint(sender As Object, e As PaintEventArgs) Handles paneltest.Paint

    End Sub

    Private Sub GunaLinePanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel2.Paint

    End Sub



    Private Sub paneltest_SizeChanged(sender As Object, e As EventArgs) Handles paneltest.SizeChanged
        Dim max As Integer = paneltest.Height - Panel1.ClientSize.Height

        If max > 0 Then

            GunaVScrollBar1.Maximum = max + SystemInformation.VerticalScrollBarArrowHeight

        End If

    End Sub
End Class