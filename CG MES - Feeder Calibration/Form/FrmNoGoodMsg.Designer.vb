<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoGoodMsg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNoGoodMsg))
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtMsg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.ctrlClose)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(468, 30)
        Me.Guna2Panel1.TabIndex = 80
        '
        'ctrlClose
        '
        Me.ctrlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlClose.Animated = True
        Me.ctrlClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ctrlClose.IconColor = System.Drawing.Color.White
        Me.ctrlClose.Location = New System.Drawing.Point(428, 0)
        Me.ctrlClose.Name = "ctrlClose"
        Me.ctrlClose.Size = New System.Drawing.Size(40, 29)
        Me.ctrlClose.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnConfirm.BorderRadius = 8
        Me.btnConfirm.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.checked
        Me.btnConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.CustomImages.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnConfirm.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnConfirm.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnConfirm.Location = New System.Drawing.Point(237, 92)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(217, 36)
        Me.btnConfirm.TabIndex = 95
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextOffset = New System.Drawing.Point(-6, 0)
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnClose.BorderRadius = 10
        Me.btnClose.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.button
        Me.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClose.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnClose.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnClose.Location = New System.Drawing.Point(14, 92)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(217, 36)
        Me.btnClose.TabIndex = 94
        Me.btnClose.Text = "Close"
        Me.btnClose.TextOffset = New System.Drawing.Point(-10, -1)
        '
        'txtMsg
        '
        Me.txtMsg.Animated = True
        Me.txtMsg.BackColor = System.Drawing.Color.Transparent
        Me.txtMsg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtMsg.BorderRadius = 8
        Me.txtMsg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMsg.DefaultText = ""
        Me.txtMsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtMsg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtMsg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtMsg.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.comments
        Me.txtMsg.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtMsg.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtMsg.Location = New System.Drawing.Point(14, 39)
        Me.txtMsg.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMsg.MaxLength = 255
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMsg.PlaceholderText = "No Good Message"
        Me.txtMsg.SelectedText = ""
        Me.txtMsg.Size = New System.Drawing.Size(440, 44)
        Me.txtMsg.TabIndex = 93
        '
        'FrmNoGoodMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 143)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNoGoodMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No Good Message"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtMsg As Guna.UI2.WinForms.Guna2TextBox
End Class
