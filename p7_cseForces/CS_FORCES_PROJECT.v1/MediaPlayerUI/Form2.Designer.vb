<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.search = New System.Windows.Forms.TextBox()
        Me.paneltest = New System.Windows.Forms.Panel()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelFocus = New System.Windows.Forms.Panel()
        Me.GunaLinePanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLinePanel2.Controls.Add(Me.TextBox1)
        Me.GunaLinePanel2.Controls.Add(Me.PictureBox2)
        Me.GunaLinePanel2.Controls.Add(Me.GunaLabel6)
        Me.GunaLinePanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(700, 62)
        Me.GunaLinePanel2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(39, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(412, 32)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(338, 43)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(84, 20)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "ΕΞΑΜΗΝΟ"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel3.Location = New System.Drawing.Point(47, 42)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(81, 20)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "ΜΑΘΗΜΑ"
        '
        'search
        '
        Me.search.AcceptsTab = True
        Me.search.BackColor = System.Drawing.Color.White
        Me.search.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.search.Location = New System.Drawing.Point(538, 155)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(149, 27)
        Me.search.TabIndex = 4
        '
        'paneltest
        '
        Me.paneltest.AutoScroll = True
        Me.paneltest.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.paneltest.Location = New System.Drawing.Point(0, 61)
        Me.paneltest.Name = "paneltest"
        Me.paneltest.Size = New System.Drawing.Size(522, 347)
        Me.paneltest.TabIndex = 13
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaVScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaVScrollBar1.HighlightOnWheel = True
        Me.GunaVScrollBar1.LargeChange = 20
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(0, 0)
        Me.GunaVScrollBar1.Maximum = 55
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.Radius = 0
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Transparent
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(32, 348)
        Me.GunaVScrollBar1.TabIndex = 14
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray
        Me.GunaVScrollBar1.ThumbSize = 100
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GunaVScrollBar1)
        Me.Panel1.Location = New System.Drawing.Point(500, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 348)
        Me.Panel1.TabIndex = 15
        '
        'panelFocus
        '
        Me.panelFocus.BackColor = System.Drawing.Color.Transparent
        Me.panelFocus.Location = New System.Drawing.Point(-1, 63)
        Me.panelFocus.Name = "panelFocus"
        Me.panelFocus.Size = New System.Drawing.Size(522, 347)
        Me.panelFocus.TabIndex = 16
        Me.panelFocus.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 463)
        Me.Controls.Add(Me.panelFocus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.paneltest)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents paneltest As Panel
    Public WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelFocus As Panel
    Public WithEvents search As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
