Imports System.Net

Public Class Form1
    Public Shared namesA As String()
    Public onomaMathimatos As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        hideSubmenu()
        ''Me.TransparencyKey = BackColor
        namesA = {"Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική",
                                 "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού",
                                 "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι",
                                 "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ",
                                 "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών",
                                 "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα",
                                 "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι",
                                 "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού"}
        mathima = My.Settings.chosenM
        GunaLabel1.Text = My.Settings.mathimaName
        If Not My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            MsgBox("Χρειάζεται δικαιώματα διαχειριστή για την ομαλή λειτουργία.")
        End If

        Try
            If My.Settings.windowSett = False Then
                Me.FormBorderStyle = FormBorderStyle.None
                Me.MaximizeBox = False

            Else
                Me.FormBorderStyle = FormBorderStyle.FixedSingle
                Me.MaximizeBox = False
            End If
            If My.Settings.maxSett = False Then
                '' Form1.FormBorderStyle = FormBorderStyle.None
                Me.MaximizeBox = False
            Else
                Me.FormBorderStyle = FormBorderStyle.FixedSingle
                Me.MaximizeBox = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Handler(cse forces)", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        ''PanelToolsSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Public Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        showSubmenu(PanelPlaylistSubmenu)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        openChildForm(New setti())
        ''showSubmenu(PanelToolsSubmenu)
    End Sub

#Region "Buttons Submenu"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        '' GunaLabel1.Text = "Γινεται φορτωση των διαθεσιμων πακετων.."
        openChildForm(New Form2())

        '...
        'your codes
        '...

        hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ''openChildForm(New Form3())
        '...
        'your codes
        '...
        MessageBox.Show("Under Construction...", "Cs Forces - WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        hideSubmenu()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        MessageBox.Show("Under Construction...", "Cs Forces - WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs)
        '' MessageBox.Show("Under Construction", "Cse Forces", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
    Public Shared bookflag As String
    Public Shared mathima As String
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        '' mathima = "analisi"
        bookflag = "simeioseis"
        openChildForm(New Form3())
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        bookflag = "askiseis"
        '' mathima = "analisi"
        openChildForm(New Form3())
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
#End Region

    Private Sub btnEqualizer_Click(sender As Object, e As EventArgs)
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

        MessageBox.Show("Credits go to Xristos Kon" & vbNewLine & "https://icons8.com/ , for icons." & vbNewLine & "Vutai for Scheme Design.",
                        "CS Forces.",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button2)

        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ''openChildForm(New Form2())
        MessageBox.Show("Under Construction...", "Cs Forces - WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        hideSubmenu()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        bookflag = "themata"
        '' mathima = "analisi"
        openChildForm(New Form3())

        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)
        ''Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        '' Dim appPath As String = Application.StartupPath()
        '' Dim dpath As String = My.Application.Info.DirectoryPath
        '' MsgBox(dpath)
    End Sub

    Private Sub panelLogo_Paint(sender As Object, e As PaintEventArgs) Handles panelLogo.Paint

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Form2.search.Text = "elas"
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click


    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        GunaContextMenuStrip1.Show(MousePosition)
    End Sub

    Private Sub ΕξοδοςToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ΕξοδοςToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ΑποσύνδεσηToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΑποσύνδεσηToolStripMenuItem.Click
        MessageBox.Show("Θέλετε να γίνει αποσύνδεση χρήστη?", "Cs Forces - WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
    End Sub
End Class
