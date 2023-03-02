<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.paneltest = New System.Windows.Forms.Panel()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLinePanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(267, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(173, 25)
        Me.label1.TabIndex = 19
        Me.label1.Text = "FORMULARIO X2"
        '
        'paneltest
        '
        Me.paneltest.AutoSize = True
        Me.paneltest.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.paneltest.Location = New System.Drawing.Point(31, 3)
        Me.paneltest.Name = "paneltest"
        Me.paneltest.Size = New System.Drawing.Size(516, 356)
        Me.paneltest.TabIndex = 21
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLinePanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaLinePanel2.Controls.Add(Me.GunaLabel4)
        Me.GunaLinePanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(700, 62)
        Me.GunaLinePanel2.TabIndex = 20
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel5.Location = New System.Drawing.Point(446, 18)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(76, 13)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "ΕΠΕΞΕΡΓΑΣΙΑ"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel4.Location = New System.Drawing.Point(323, 18)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(91, 13)
        Me.GunaLabel4.TabIndex = 1
        Me.GunaLabel4.Text = "ΤΥΠΟΣ ΑΡΧΕΙΟΥ"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 18)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(100, 13)
        Me.GunaLabel3.TabIndex = 0
        Me.GunaLabel3.Text = "ΟΝΟΜΑ ΑΡΧΕΙΟΥ"
        '
        'GunaVScrollBar1
        '
        Me.GunaVScrollBar1.LargeChange = 10
        Me.GunaVScrollBar1.Location = New System.Drawing.Point(507, 49)
        Me.GunaVScrollBar1.Maximum = 100
        Me.GunaVScrollBar1.MouseWheelBarPartitions = 20
        Me.GunaVScrollBar1.Name = "GunaVScrollBar1"
        Me.GunaVScrollBar1.Radius = 0
        Me.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Transparent
        Me.GunaVScrollBar1.Size = New System.Drawing.Size(22, 371)
        Me.GunaVScrollBar1.TabIndex = 22
        Me.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray
        Me.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray
        Me.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray
        Me.GunaVScrollBar1.ThumbSize = 50
        Me.GunaVScrollBar1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.paneltest)
        Me.Panel1.Location = New System.Drawing.Point(-45, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 362)
        Me.Panel1.TabIndex = 23
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 442)
        Me.Controls.Add(Me.GunaVScrollBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As Label
    Friend WithEvents paneltest As Panel
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Panel1 As Panel
End Class
