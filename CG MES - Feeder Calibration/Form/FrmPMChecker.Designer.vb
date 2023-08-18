<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPMChecker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPMChecker))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.ImgHero = New System.Windows.Forms.PictureBox()
        Me.LblVer = New System.Windows.Forms.Label()
        Me.txtMachineID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLastCal = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(1164, 30)
        Me.Guna2Panel1.TabIndex = 77
        '
        'ctrlClose
        '
        Me.ctrlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlClose.Animated = True
        Me.ctrlClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ctrlClose.IconColor = System.Drawing.Color.White
        Me.ctrlClose.Location = New System.Drawing.Point(1124, 0)
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
        Me.ctrlMin.Location = New System.Drawing.Point(1087, 0)
        Me.ctrlMin.Name = "ctrlMin"
        Me.ctrlMin.Size = New System.Drawing.Size(40, 29)
        Me.ctrlMin.TabIndex = 2
        '
        'ImgHero
        '
        Me.ImgHero.Image = CType(resources.GetObject("ImgHero.Image"), System.Drawing.Image)
        Me.ImgHero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ImgHero.Location = New System.Drawing.Point(266, 95)
        Me.ImgHero.Name = "ImgHero"
        Me.ImgHero.Size = New System.Drawing.Size(275, 84)
        Me.ImgHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHero.TabIndex = 84
        Me.ImgHero.TabStop = False
        '
        'LblVer
        '
        Me.LblVer.BackColor = System.Drawing.Color.Transparent
        Me.LblVer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblVer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVer.Location = New System.Drawing.Point(288, 774)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(288, 15)
        Me.LblVer.TabIndex = 83
        Me.LblVer.Text = "Ver: {0.0.0.1}"
        Me.LblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMachineID
        '
        Me.txtMachineID.Animated = True
        Me.txtMachineID.BackColor = System.Drawing.Color.Transparent
        Me.txtMachineID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtMachineID.BorderRadius = 8
        Me.txtMachineID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMachineID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMachineID.DefaultText = ""
        Me.txtMachineID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMachineID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMachineID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMachineID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMachineID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtMachineID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtMachineID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtMachineID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtMachineID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.barcode_scanner
        Me.txtMachineID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtMachineID.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtMachineID.Location = New System.Drawing.Point(222, 221)
        Me.txtMachineID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMachineID.MaxLength = 6
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMachineID.PlaceholderText = "Machine ID"
        Me.txtMachineID.SelectedText = ""
        Me.txtMachineID.Size = New System.Drawing.Size(350, 47)
        Me.txtMachineID.TabIndex = 85
        '
        'btnCheck
        '
        Me.btnCheck.Animated = True
        Me.btnCheck.BorderRadius = 10
        Me.btnCheck.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.standby__1_
        Me.btnCheck.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCheck.CustomImages.ImageOffset = New System.Drawing.Point(0, -35)
        Me.btnCheck.CustomImages.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheck.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCheck.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCheck.Location = New System.Drawing.Point(222, 294)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(350, 205)
        Me.btnCheck.TabIndex = 86
        Me.btnCheck.Text = "Waiting for input"
        Me.btnCheck.TextOffset = New System.Drawing.Point(0, 25)
        '
        'btnLastCal
        '
        Me.btnLastCal.Animated = True
        Me.btnLastCal.BorderRadius = 10
        Me.btnLastCal.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.clockye
        Me.btnLastCal.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLastCal.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnLastCal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLastCal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLastCal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLastCal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLastCal.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLastCal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLastCal.ForeColor = System.Drawing.Color.White
        Me.btnLastCal.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnLastCal.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnLastCal.Location = New System.Drawing.Point(222, 505)
        Me.btnLastCal.Name = "btnLastCal"
        Me.btnLastCal.Size = New System.Drawing.Size(350, 65)
        Me.btnLastCal.TabIndex = 87
        Me.btnLastCal.Text = "Next Calibration Date: N/A"
        Me.btnLastCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLastCal.TextOffset = New System.Drawing.Point(55, 0)
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Animated = True
        Me.btnCheckAll.BorderRadius = 10
        Me.btnCheckAll.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.checklist
        Me.btnCheckAll.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCheckAll.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnCheckAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheckAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheckAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnCheckAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckAll.ForeColor = System.Drawing.Color.White
        Me.btnCheckAll.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCheckAll.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCheckAll.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCheckAll.Location = New System.Drawing.Point(222, 576)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(350, 65)
        Me.btnCheckAll.TabIndex = 89
        Me.btnCheckAll.Text = "List All The Machines"
        Me.btnCheckAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCheckAll.TextOffset = New System.Drawing.Point(55, 0)
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BorderRadius = 10
        Me.btnBack.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.left_arrow1
        Me.btnBack.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBack.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnBack.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnBack.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnBack.Location = New System.Drawing.Point(222, 647)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(350, 65)
        Me.btnBack.TabIndex = 88
        Me.btnBack.Text = "Back"
        Me.btnBack.TextOffset = New System.Drawing.Point(-80, 0)
        '
        'FrmPMChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.btnCheckAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLastCal)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtMachineID)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPMChecker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPMChecker"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ImgHero As PictureBox
    Friend WithEvents LblVer As Label
    Friend WithEvents txtMachineID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLastCal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
