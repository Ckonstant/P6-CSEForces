Public Class Form2

    Dim dirPath As String = My.Application.Info.DirectoryPath + "\FULLDATA\"
    Dim names As String()
    Dim types As String()
    Dim dLink As String()
    Dim eksamino As String()
    Dim c As New UserControl1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        names = {"Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική",
                                 "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού",
                                 "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι",
                                 "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ",
                                 "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών",
                                 "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα",
                                 "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι",
                                 "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού"}



        types = {"Apeiro", "Agglika", "Geniki", "gramiki", "python", "unix",
                                 "apeiro2", "bak", "diak1", "java",
                                 "anaptiksi", "diak2", "domes", "pithanot", "psifiaki",
                                 "arxes", "arithmitiki", "ilektroniki", "analisi", "psifiaki2",
                                 "theoria", "c", "simata", "upologistika", "arhitek",
                                 "leitourgika", "tehniti", "tilep",
                                 "vaseis", "grafika", "diktia1",
                                 "diktia2", "metafrastes", "texnologia"}




        dLink = {"https://www.dropbox.com/s/oq1vsxdpxzl53x9/Apeiro.zip?dl=1", "https://www.dropbox.com/s/6pvdy0qv0dwx2y9/Agglika.zip?dl=1", "https://www.dropbox.com/s/lvbtasfjwlts9wu/arithmitiki.zip?dl=1", "https://www.dropbox.com/s/i5eafctwfezvi0i/gramiki.zip?dl=1", "https://www.dropbox.com/s/id3g7c8acgfawrn/python.zip?dl=1", "https://www.dropbox.com/s/smuvxl6aqvdx6wy/unix.zip?dl=1",
                                 "https://www.dropbox.com/s/q6axmat9dryo0nj/apeiro2.zip?dl=1", "https://www.dropbox.com/s/x8204ube7u8m8kh/bak.zip?dl=1", "https://www.dropbox.com/s/cyiyykv6lu0are5/diak1.zip?dl=1", "https://www.dropbox.com/s/e3zcok6n4097982/java.zip?dl=1",
                                 "https://www.dropbox.com/s/gq24hol4nzoocsj/anaptiksi.zip?dl=1", "https://www.dropbox.com/s/q7zbo0ocgufnsvr/diak2.zip?dl=1", "https://www.dropbox.com/s/2pos682ksqfacsy/domes.zip?dl=1", "https://www.dropbox.com/s/c6c522nc2qgow25/pithanot.zip?dl=1", "https://www.dropbox.com/s/hjz4m7rowzi3y62/psifiaki.zip?dl=1",
                                 "https://www.dropbox.com/s/ks6nrffj0lhwlxf/arxes.zip?dl=1", "https://www.dropbox.com/s/lvbtasfjwlts9wu/arithmitiki.zip?dl=1", "https://www.dropbox.com/s/4z8p0esvnincji3/ilektroniki.zip?dl=1", "https://www.dropbox.com/s/pclh0svsira31i7/analisi.zip?dl=1", "https://www.dropbox.com/s/iclyfxsr9dbluez/psifiaki2.zip?dl=1",
                                 "https://www.dropbox.com/s/7pj509vgg237v5f/theoria.zip?dl=1", "https://www.dropbox.com/s/kvmbfcss8qximpt/c.zip?dl=1", "https://www.dropbox.com/s/3a6ba49undtzp6z/simata.zip?dl=1", "https://www.dropbox.com/s/vciuz49ame63g9o/upologistika.zip?dl=1", "https://www.dropbox.com/s/z2h9w5wal6qzzq6/arhitek.zip?dl=1",
                                "https://www.dropbox.com/s/flepf4j1d7mkp3r/leitourgika.zip?dl=1", "https://www.dropbox.com/s/kw2te2ls27s7dqa/tehniti.zip?dl=1", "https://www.dropbox.com/s/fei607bi5m5h4we/tilep.zip?dl=1",
                                "https://www.dropbox.com/s/z0i9rv5575bvij6/vaseis.zip?dl=1", "https://www.dropbox.com/s/fffy2fzqcjaokro/grafika.zip?dl=1", "https://www.dropbox.com/s/htx0b52e0ukz8ey/diktia1.zip?dl=1",
                                "https://www.dropbox.com/s/vq4bdwbkvvpt291/diktia2.zip?dl=1", "https://www.dropbox.com/s/k5r0w4zu2k07p7u/metafrastes.zip?dl=1", "https://www.dropbox.com/s/hpf48n6r9joljuu/texnologia.zip?dl=1"}



        eksamino = {"1", "1", "1", "1", "1", "1",
                                    "2", "2", "2", "2",
                                    "3", "3", "3", "3", "3",
                                    "4", "4", "4", "4", "4",
                                    "5", "5", "5", "5", "5",
                                    "6", "6", "6",
                                    "7", "7", "7",
                                    "8", "8", "8"}
        Me.Visible = False
        Try
            For i As Integer = names.Length - 1 To 0 Step -1
                Dim c As UserControl1 = New UserControl1
                c.Dock = DockStyle.Top
                c.lb_name.Text = names(i)
                c.lb_type.Text = eksamino(i)
                c.GunaLabel6.Text = dLink(i)
                c.GunaLabel7.Text = types(i)


                Dim dir As New IO.DirectoryInfo(dirPath + types(i))
                If dir.Exists Then

                    c.lb_name.Image = My.Resources.icons8_checkmark_32

                Else

                    '' c.GunaPictureBox2.Visible = True
                    c.lb_name.Image = My.Resources.icons8_download_32

                End If
                paneltest.Controls.Add(c)
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Visible = True
        paneltest.VerticalScroll.Visible = False
        Panel1.BringToFront()
        paneltest.SendToBack()
        GunaVScrollBar1.Maximum = paneltest.VerticalScroll.Maximum
        GunaVScrollBar1.Height = paneltest.VerticalScroll.Maximum
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        addItems(DataCollection)
        TextBox1.AutoCompleteCustomSource = DataCollection

        ''Form1.TextBox1.Visible = True
        ''Form1.PictureBox2.Visible = True
        TextBox1.Visible = True
        PictureBox2.Visible = True
    End Sub
    Public Sub addItems(ByVal col As AutoCompleteStringCollection)
        col.AddRange(names)
    End Sub
    Private Sub GunaLinePanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel2.Paint

    End Sub

    Private Sub GunaVScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles GunaVScrollBar1.Scroll

    End Sub

    Private Sub paneltest_Paint(sender As Object, e As PaintEventArgs) Handles paneltest.Paint

    End Sub

    Private Sub paneltest_AutoSizeChanged(sender As Object, e As EventArgs) Handles paneltest.AutoSizeChanged
        GunaVScrollBar1.Height = 10
    End Sub

    Private Sub paneltest_Scroll(sender As Object, e As ScrollEventArgs) Handles paneltest.Scroll
        GunaVScrollBar1.Value = paneltest.VerticalScroll.Value
    End Sub

    Private Sub GunaVScrollBar1_ValueChanged(sender As Object, e As EventArgs) Handles GunaVScrollBar1.ValueChanged
        paneltest.VerticalScroll.Value = GunaVScrollBar1.Value
    End Sub



    Private Sub paneltest_MouseWheel(sender As Object, e As MouseEventArgs) Handles paneltest.MouseWheel
        GunaVScrollBar1.Value = paneltest.VerticalScroll.Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged





    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles search.Enter

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles search.MouseLeave

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub panelFocus_Paint(sender As Object, e As PaintEventArgs) Handles panelFocus.Paint

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            paneltest.Visible = True
            panelFocus.Visible = False
        Else

            For i As Integer = Form1.namesA.Length - 1 To 0 Step -1
                If (Form1.namesA(i)).Contains(TextBox1.Text) Then
                    panelFocus.Controls.Clear()
                    Dim c As UserControl1 = New UserControl1
                    c.Dock = DockStyle.Top
                    c.lb_name.Text = names(i)
                    c.lb_type.Text = eksamino(i)
                    c.GunaLabel6.Text = dLink(i)
                    c.GunaLabel7.Text = types(i)
                    Dim dir As New IO.DirectoryInfo(dirPath + types(i))
                    If dir.Exists Then

                        c.lb_name.Image = My.Resources.icons8_checkmark_32

                    Else

                        '' c.GunaPictureBox2.Visible = True
                        c.lb_name.Image = My.Resources.icons8_download_32

                    End If


                    panelFocus.Controls.Add(c)
                    paneltest.Visible = False
                    panelFocus.Visible = True

                End If
            Next

        End If
    End Sub
End Class