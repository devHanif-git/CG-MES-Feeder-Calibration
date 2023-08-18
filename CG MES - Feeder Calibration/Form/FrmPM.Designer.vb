<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPM))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.LblVer = New System.Windows.Forms.Label()
        Me.ImgHero = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCalibrate = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnULog = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMLog = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnManage = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUserManage = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.TabIndex = 76
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
        'LblVer
        '
        Me.LblVer.BackColor = System.Drawing.Color.Transparent
        Me.LblVer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblVer.Location = New System.Drawing.Point(269, 683)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(288, 15)
        Me.LblVer.TabIndex = 78
        Me.LblVer.Text = "Ver: {0.0.0.1}"
        Me.LblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgHero
        '
        Me.ImgHero.Image = CType(resources.GetObject("ImgHero.Image"), System.Drawing.Image)
        Me.ImgHero.ImageRotate = 0!
        Me.ImgHero.Location = New System.Drawing.Point(243, 94)
        Me.ImgHero.Name = "ImgHero"
        Me.ImgHero.Size = New System.Drawing.Size(275, 84)
        Me.ImgHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHero.TabIndex = 77
        Me.ImgHero.TabStop = False
        '
        'BtnCheck
        '
        Me.BtnCheck.Animated = True
        Me.BtnCheck.BorderRadius = 10
        Me.BtnCheck.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.research__1_
        Me.BtnCheck.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCheck.CustomImages.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCheck.Enabled = False
        Me.BtnCheck.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnCheck.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCheck.ForeColor = System.Drawing.Color.White
        Me.BtnCheck.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCheck.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnCheck.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnCheck.Location = New System.Drawing.Point(252, 251)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(358, 65)
        Me.BtnCheck.TabIndex = 79
        Me.BtnCheck.Text = "Machine PM Checker"
        Me.BtnCheck.TextOffset = New System.Drawing.Point(-3, 0)
        '
        'BtnCalibrate
        '
        Me.BtnCalibrate.Animated = True
        Me.BtnCalibrate.BorderRadius = 10
        Me.BtnCalibrate.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.oscilloscope
        Me.BtnCalibrate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCalibrate.CustomImages.ImageOffset = New System.Drawing.Point(2, 0)
        Me.BtnCalibrate.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnCalibrate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCalibrate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCalibrate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCalibrate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCalibrate.Enabled = False
        Me.BtnCalibrate.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnCalibrate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCalibrate.ForeColor = System.Drawing.Color.White
        Me.BtnCalibrate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCalibrate.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnCalibrate.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnCalibrate.Location = New System.Drawing.Point(252, 322)
        Me.BtnCalibrate.Name = "BtnCalibrate"
        Me.BtnCalibrate.Size = New System.Drawing.Size(358, 65)
        Me.BtnCalibrate.TabIndex = 80
        Me.BtnCalibrate.Text = "Machine PM Calibration"
        Me.BtnCalibrate.TextOffset = New System.Drawing.Point(13, 0)
        '
        'BtnULog
        '
        Me.BtnULog.Animated = True
        Me.BtnULog.BorderRadius = 10
        Me.BtnULog.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.log
        Me.BtnULog.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnULog.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnULog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnULog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnULog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnULog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnULog.Enabled = False
        Me.BtnULog.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnULog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnULog.ForeColor = System.Drawing.Color.White
        Me.BtnULog.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnULog.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnULog.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnULog.Location = New System.Drawing.Point(432, 393)
        Me.BtnULog.Name = "BtnULog"
        Me.BtnULog.Size = New System.Drawing.Size(178, 65)
        Me.BtnULog.TabIndex = 82
        Me.BtnULog.Text = "User Log"
        Me.BtnULog.TextOffset = New System.Drawing.Point(12, 0)
        '
        'BtnMLog
        '
        Me.BtnMLog.Animated = True
        Me.BtnMLog.BorderRadius = 10
        Me.BtnMLog.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.log
        Me.BtnMLog.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnMLog.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnMLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMLog.Enabled = False
        Me.BtnMLog.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnMLog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMLog.ForeColor = System.Drawing.Color.White
        Me.BtnMLog.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnMLog.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnMLog.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnMLog.Location = New System.Drawing.Point(252, 393)
        Me.BtnMLog.Name = "BtnMLog"
        Me.BtnMLog.Size = New System.Drawing.Size(178, 65)
        Me.BtnMLog.TabIndex = 81
        Me.BtnMLog.Text = "Machine Log"
        Me.BtnMLog.TextOffset = New System.Drawing.Point(28, 0)
        '
        'BtnManage
        '
        Me.BtnManage.Animated = True
        Me.BtnManage.BorderRadius = 10
        Me.BtnManage.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.idea
        Me.BtnManage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnManage.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnManage.Enabled = False
        Me.BtnManage.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnManage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnManage.ForeColor = System.Drawing.Color.White
        Me.BtnManage.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnManage.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnManage.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnManage.Location = New System.Drawing.Point(252, 464)
        Me.BtnManage.Name = "BtnManage"
        Me.BtnManage.Size = New System.Drawing.Size(358, 65)
        Me.BtnManage.TabIndex = 83
        Me.BtnManage.Text = "Machine Management"
        Me.BtnManage.TextOffset = New System.Drawing.Point(3, 0)
        '
        'BtnUserManage
        '
        Me.BtnUserManage.Animated = True
        Me.BtnUserManage.BorderRadius = 10
        Me.BtnUserManage.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.team_management
        Me.BtnUserManage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnUserManage.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnUserManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUserManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUserManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUserManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUserManage.Enabled = False
        Me.BtnUserManage.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BtnUserManage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnUserManage.ForeColor = System.Drawing.Color.White
        Me.BtnUserManage.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnUserManage.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnUserManage.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnUserManage.Location = New System.Drawing.Point(252, 535)
        Me.BtnUserManage.Name = "BtnUserManage"
        Me.BtnUserManage.Size = New System.Drawing.Size(358, 65)
        Me.BtnUserManage.TabIndex = 85
        Me.BtnUserManage.Text = "User Management"
        Me.BtnUserManage.TextOffset = New System.Drawing.Point(-16, 0)
        '
        'BtnExit
        '
        Me.BtnExit.Animated = True
        Me.BtnExit.BorderRadius = 10
        Me.BtnExit.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.button
        Me.BtnExit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnExit.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.HoverState.FillColor = System.Drawing.Color.Red
        Me.BtnExit.ImageOffset = New System.Drawing.Point(15, 0)
        Me.BtnExit.ImageSize = New System.Drawing.Size(50, 50)
        Me.BtnExit.Location = New System.Drawing.Point(252, 606)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(358, 65)
        Me.BtnExit.TabIndex = 84
        Me.BtnExit.Text = "Log Out"
        Me.BtnExit.TextOffset = New System.Drawing.Point(-64, 0)
        '
        'FrmPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.BtnUserManage)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnManage)
        Me.Controls.Add(Me.BtnULog)
        Me.Controls.Add(Me.BtnMLog)
        Me.Controls.Add(Me.BtnCalibrate)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CG MES - Machine Preventive Maintenance"
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
    Friend WithEvents LblVer As Label
    Friend WithEvents ImgHero As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCalibrate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnULog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMLog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnManage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUserManage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2Button
End Class
