<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.lb_name = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lb_type = New Guna.UI.WinForms.GunaLabel()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.ΚατέβασμαΠακέτουToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΔιαγραφήΠακέτουToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaLinePanel1.Controls.Add(Me.lb_name)
        Me.GunaLinePanel1.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaProgressBar1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaCircleButton2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaLinePanel1.Controls.Add(Me.lb_type)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Red
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(520, 40)
        Me.GunaLinePanel1.TabIndex = 1
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(16, 1)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(12, 15)
        Me.GunaLabel8.TabIndex = 19
        Me.GunaLabel8.Text = "-"
        Me.GunaLabel8.Visible = False
        '
        'lb_name
        '
        Me.lb_name.Animated = True
        Me.lb_name.AnimationHoverSpeed = 0.07!
        Me.lb_name.AnimationSpeed = 0.03!
        Me.lb_name.BackColor = System.Drawing.Color.Transparent
        Me.lb_name.BaseColor1 = System.Drawing.Color.Transparent
        Me.lb_name.BaseColor2 = System.Drawing.Color.Transparent
        Me.lb_name.BorderColor = System.Drawing.Color.Black
        Me.lb_name.CausesValidation = False
        Me.lb_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_name.DialogResult = System.Windows.Forms.DialogResult.None
        Me.lb_name.FocusedColor = System.Drawing.Color.Transparent
        Me.lb_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lb_name.ForeColor = System.Drawing.Color.Silver
        Me.lb_name.Image = Global.MediaPlayerUI.My.Resources.Resources.icons8_download_32
        Me.lb_name.ImageSize = New System.Drawing.Size(20, 20)
        Me.lb_name.Location = New System.Drawing.Point(3, 0)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.OnHoverBaseColor1 = System.Drawing.SystemColors.WindowFrame
        Me.lb_name.OnHoverBaseColor2 = System.Drawing.Color.Transparent
        Me.lb_name.OnHoverBorderColor = System.Drawing.Color.Black
        Me.lb_name.OnHoverForeColor = System.Drawing.Color.Silver
        Me.lb_name.OnHoverImage = Nothing
        Me.lb_name.OnPressedColor = System.Drawing.Color.Black
        Me.lb_name.Size = New System.Drawing.Size(427, 40)
        Me.lb_name.TabIndex = 18
        Me.lb_name.Text = "GunaGradientButton1"
        Me.lb_name.UseTransfarantBackground = True
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(339, 29)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(10, 10)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 17
        Me.GunaWinCircleProgressIndicator1.Visible = False
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(308, 5)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel7.TabIndex = 15
        Me.GunaLabel7.Text = "GunaLabel7"
        Me.GunaLabel7.Visible = False
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(284, 5)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 15)
        Me.GunaLabel6.TabIndex = 13
        Me.GunaLabel6.Text = "GunaLabel6"
        Me.GunaLabel6.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(308, 27)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(28, 13)
        Me.GunaLabel5.TabIndex = 12
        Me.GunaLabel5.Text = "(0%)"
        Me.GunaLabel5.Visible = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel4.Location = New System.Drawing.Point(101, 18)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(11, 13)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "-"
        Me.GunaLabel4.Visible = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel3.Location = New System.Drawing.Point(236, 18)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(11, 13)
        Me.GunaLabel3.TabIndex = 10
        Me.GunaLabel3.Text = "-"
        Me.GunaLabel3.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel2.Location = New System.Drawing.Point(184, 19)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(11, 13)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "-"
        Me.GunaLabel2.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(16, 16)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel1.TabIndex = 8
        Me.GunaLabel1.Text = "Γινετε λήψη..."
        Me.GunaLabel1.Visible = False
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(19, 32)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GunaProgressBar1.Size = New System.Drawing.Size(284, 5)
        Me.GunaProgressBar1.TabIndex = 7
        Me.GunaProgressBar1.Visible = False
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleButton2.Image = CType(resources.GetObject("GunaCircleButton2.Image"), System.Drawing.Image)
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(451, 5)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = CType(resources.GetObject("GunaCircleButton2.OnHoverImage"), System.Drawing.Image)
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton2.TabIndex = 6
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(623, 10)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton1.TabIndex = 5
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_type.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb_type.Location = New System.Drawing.Point(359, 17)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(60, 13)
        Me.lb_type.TabIndex = 1
        Me.lb_type.Text = "ΕΞΑΜΗΝΟ"
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΚατέβασμαΠακέτουToolStripMenuItem, Me.ΔιαγραφήΠακέτουToolStripMenuItem, Me.MyCoursesToolStripMenuItem, Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(200, 114)
        '
        'ΚατέβασμαΠακέτουToolStripMenuItem
        '
        Me.ΚατέβασμαΠακέτουToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ΚατέβασμαΠακέτουToolStripMenuItem.Image = CType(resources.GetObject("ΚατέβασμαΠακέτουToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ΚατέβασμαΠακέτουToolStripMenuItem.Name = "ΚατέβασμαΠακέτουToolStripMenuItem"
        Me.ΚατέβασμαΠακέτουToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ΚατέβασμαΠακέτουToolStripMenuItem.Text = "Κατέβασμα πακέτου"
        '
        'ΔιαγραφήΠακέτουToolStripMenuItem
        '
        Me.ΔιαγραφήΠακέτουToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ΔιαγραφήΠακέτουToolStripMenuItem.Image = CType(resources.GetObject("ΔιαγραφήΠακέτουToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ΔιαγραφήΠακέτουToolStripMenuItem.Name = "ΔιαγραφήΠακέτουToolStripMenuItem"
        Me.ΔιαγραφήΠακέτουToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ΔιαγραφήΠακέτουToolStripMenuItem.Text = "Διαγραφή πακέτου"
        '
        'MyCoursesToolStripMenuItem
        '
        Me.MyCoursesToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.MyCoursesToolStripMenuItem.Image = CType(resources.GetObject("MyCoursesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MyCoursesToolStripMenuItem.Name = "MyCoursesToolStripMenuItem"
        Me.MyCoursesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MyCoursesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.MyCoursesToolStripMenuItem.Text = "My Courses"
        '
        'ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem
        '
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Image = CType(resources.GetObject("ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Name = "ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem"
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem.Text = "Έλεγχος για νέο πακέτο"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(520, 40)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents lb_type As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents ΚατέβασμαΠακέτουToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΔιαγραφήΠακέτουToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΈλεγχοςΓιαΝέοΠακέτοToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb_name As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
End Class
