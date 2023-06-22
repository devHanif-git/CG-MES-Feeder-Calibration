<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtFeederID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxSize = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxColor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2Panel1.Controls.Add(Me.ctrlMin)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(518, 30)
        Me.Guna2Panel1.TabIndex = 78
        '
        'ctrlClose
        '
        Me.ctrlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlClose.Animated = True
        Me.ctrlClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ctrlClose.IconColor = System.Drawing.Color.White
        Me.ctrlClose.Location = New System.Drawing.Point(478, 0)
        Me.ctrlClose.Name = "ctrlClose"
        Me.ctrlClose.Size = New System.Drawing.Size(40, 29)
        Me.ctrlClose.TabIndex = 0
        '
        'ctrlMin
        '
        Me.ctrlMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlMin.Animated = True
        Me.ctrlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlMin.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlMin.IconColor = System.Drawing.Color.White
        Me.ctrlMin.Location = New System.Drawing.Point(441, 0)
        Me.ctrlMin.Name = "ctrlMin"
        Me.ctrlMin.Size = New System.Drawing.Size(40, 29)
        Me.ctrlMin.TabIndex = 2
        '
        'txtFeederID
        '
        Me.txtFeederID.Animated = True
        Me.txtFeederID.BackColor = System.Drawing.Color.Transparent
        Me.txtFeederID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtFeederID.BorderRadius = 8
        Me.txtFeederID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFeederID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFeederID.DefaultText = ""
        Me.txtFeederID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFeederID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFeederID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeederID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeederID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtFeederID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFeederID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtFeederID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtFeederID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.id__1_
        Me.txtFeederID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFeederID.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtFeederID.Location = New System.Drawing.Point(3, 3)
        Me.txtFeederID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFeederID.MaxLength = 7
        Me.txtFeederID.Name = "txtFeederID"
        Me.txtFeederID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFeederID.PlaceholderText = "Feeder ID"
        Me.txtFeederID.SelectedText = ""
        Me.txtFeederID.Size = New System.Drawing.Size(173, 35)
        Me.txtFeederID.TabIndex = 79
        '
        'cbxType
        '
        Me.cbxType.BackColor = System.Drawing.Color.Transparent
        Me.cbxType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxType.BorderRadius = 8
        Me.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxType.ItemHeight = 30
        Me.cbxType.Items.AddRange(New Object() {"Select Type", "P8x2mm (CF)", "P8x2mm (NF)", "P8x2mm (FF)", "E8x2mm (CF)", "E8x2mm (NF)", "E8x2mm (FF)", "P8x4mm (CF)", "P8x4mm (NF)", "P8x4mm (FF)", "E8x4mm (CF)", "E8x4mm (NF)", "E8x4mm (FF)", "E12 (NF)", "E12 (FF)", "E16 (NF)", "E16 (FF)", "E24 (NF)", "E24 (FF)", "E32 (FF)"})
        Me.cbxType.Location = New System.Drawing.Point(184, 3)
        Me.cbxType.MaxDropDownItems = 14
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(173, 36)
        Me.cbxType.StartIndex = 0
        Me.cbxType.TabIndex = 80
        '
        'cbxSize
        '
        Me.cbxSize.BackColor = System.Drawing.Color.Transparent
        Me.cbxSize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxSize.BorderRadius = 8
        Me.cbxSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSize.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxSize.ItemHeight = 30
        Me.cbxSize.Items.AddRange(New Object() {"Select Size", "SMALL", "BIG"})
        Me.cbxSize.Location = New System.Drawing.Point(3, 45)
        Me.cbxSize.MaxDropDownItems = 14
        Me.cbxSize.Name = "cbxSize"
        Me.cbxSize.Size = New System.Drawing.Size(173, 36)
        Me.cbxSize.StartIndex = 0
        Me.cbxSize.TabIndex = 81
        '
        'cbxColor
        '
        Me.cbxColor.BackColor = System.Drawing.Color.Transparent
        Me.cbxColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxColor.BorderRadius = 8
        Me.cbxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxColor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxColor.ItemHeight = 30
        Me.cbxColor.Items.AddRange(New Object() {"Select Colour", "ORANGE", "BLUE", "GREEN"})
        Me.cbxColor.Location = New System.Drawing.Point(184, 45)
        Me.cbxColor.MaxDropDownItems = 14
        Me.cbxColor.Name = "cbxColor"
        Me.cbxColor.Size = New System.Drawing.Size(173, 36)
        Me.cbxColor.StartIndex = 0
        Me.cbxColor.TabIndex = 82
        '
        'cbxStatus
        '
        Me.cbxStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbxStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxStatus.BorderRadius = 8
        Me.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxStatus.ItemHeight = 30
        Me.cbxStatus.Items.AddRange(New Object() {"Select Status", "GOOD", "NO GOOD"})
        Me.cbxStatus.Location = New System.Drawing.Point(3, 87)
        Me.cbxStatus.MaxDropDownItems = 14
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(173, 36)
        Me.cbxStatus.StartIndex = 0
        Me.cbxStatus.TabIndex = 83
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.btnClose)
        Me.pnlMain.Controls.Add(Me.cbxStatus)
        Me.pnlMain.Controls.Add(Me.txtFeederID)
        Me.pnlMain.Controls.Add(Me.cbxColor)
        Me.pnlMain.Controls.Add(Me.cbxType)
        Me.pnlMain.Controls.Add(Me.cbxSize)
        Me.pnlMain.Location = New System.Drawing.Point(70, 50)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(360, 128)
        Me.pnlMain.TabIndex = 84
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
        Me.btnClose.Location = New System.Drawing.Point(184, 87)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(173, 36)
        Me.btnClose.TabIndex = 89
        Me.btnClose.Text = "Close"
        Me.btnClose.TextOffset = New System.Drawing.Point(-19, -1)
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSearch.BorderRadius = 8
        Me.btnSearch.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.magnifying_glass
        Me.btnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSearch.CustomImages.ImageOffset = New System.Drawing.Point(88, 0)
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnSearch.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnSearch.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSearch.Location = New System.Drawing.Point(73, 179)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(354, 36)
        Me.btnSearch.TabIndex = 91
        Me.btnSearch.Text = "Search"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 247)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtFeederID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxSize As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxColor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
End Class
