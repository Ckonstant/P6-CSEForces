<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl2))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.lb_company = New Guna.UI.WinForms.GunaLabel()
        Me.lb_type = New Guna.UI.WinForms.GunaLabel()
        Me.lb_name = New Guna.UI.WinForms.GunaLabel()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.ΠροβολήToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΛήψηToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaCircleButton2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaLinePanel1.Controls.Add(Me.lb_company)
        Me.GunaLinePanel1.Controls.Add(Me.lb_type)
        Me.GunaLinePanel1.Controls.Add(Me.lb_name)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(520, 41)
        Me.GunaLinePanel1.TabIndex = 2
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.Silver
        Me.GunaGradientButton1.Image = CType(resources.GetObject("GunaGradientButton1.Image"), System.Drawing.Image)
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(17, 0)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.SystemColors.WindowFrame
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaGradientButton1.Size = New System.Drawing.Size(459, 41)
        Me.GunaGradientButton1.TabIndex = 7
        Me.GunaGradientButton1.Text = "GunaGradientButton1"
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
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaCircleButton2.Image = CType(resources.GetObject("GunaCircleButton2.Image"), System.Drawing.Image)
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(482, 5)
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
        'lb_company
        '
        Me.lb_company.AutoSize = True
        Me.lb_company.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_company.ForeColor = System.Drawing.Color.Silver
        Me.lb_company.Location = New System.Drawing.Point(435, 16)
        Me.lb_company.Name = "lb_company"
        Me.lb_company.Size = New System.Drawing.Size(41, 13)
        Me.lb_company.TabIndex = 3
        Me.lb_company.Text = "ΤΥΠΟΣ"
        Me.lb_company.Visible = False
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_type.ForeColor = System.Drawing.Color.Silver
        Me.lb_type.Location = New System.Drawing.Point(369, 16)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(60, 13)
        Me.lb_type.TabIndex = 1
        Me.lb_type.Text = "ΕΞΑΜΗΝΟ"
        Me.lb_type.Visible = False
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.ContextMenuStrip = Me.GunaContextMenuStrip1
        Me.lb_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_name.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lb_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lb_name.Location = New System.Drawing.Point(37, 14)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(74, 19)
        Me.lb_name.TabIndex = 0
        Me.lb_name.Text = "ΜΑΘΗΜΑ"
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΠροβολήToolStripMenuItem, Me.ΛήψηToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(144, 48)
        '
        'ΠροβολήToolStripMenuItem
        '
        Me.ΠροβολήToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ΠροβολήToolStripMenuItem.Image = CType(resources.GetObject("ΠροβολήToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ΠροβολήToolStripMenuItem.Name = "ΠροβολήToolStripMenuItem"
        Me.ΠροβολήToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ΠροβολήToolStripMenuItem.Text = "Προβολή"
        '
        'ΛήψηToolStripMenuItem
        '
        Me.ΛήψηToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ΛήψηToolStripMenuItem.Image = CType(resources.GetObject("ΛήψηToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ΛήψηToolStripMenuItem.Name = "ΛήψηToolStripMenuItem"
        Me.ΛήψηToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ΛήψηToolStripMenuItem.Text = "Αποθήκευση"
        '
        'UserControl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Name = "UserControl2"
        Me.Size = New System.Drawing.Size(520, 41)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lb_company As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_type As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents ΠροβολήToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ΛήψηToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
End Class
