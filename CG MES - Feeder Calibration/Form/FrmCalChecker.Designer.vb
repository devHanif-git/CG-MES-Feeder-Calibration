<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalChecker))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.LblVer = New System.Windows.Forms.Label()
        Me.btnCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckAll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.btnLastCal = New Guna.UI2.WinForms.Guna2Button()
        Me.ImgHero = New System.Windows.Forms.PictureBox()
        Me.txtFeederID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.ctrlClose)
        Me.Guna2Panel1.Controls.Add(Me.ctrlMin)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        resources.ApplyResources(Me.Guna2Panel1, "Guna2Panel1")
        Me.Guna2Panel1.Name = "Guna2Panel1"
        '
        'ctrlClose
        '
        resources.ApplyResources(Me.ctrlClose, "ctrlClose")
        Me.ctrlClose.Animated = True
        Me.ctrlClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ctrlClose.IconColor = System.Drawing.Color.White
        Me.ctrlClose.Name = "ctrlClose"
        '
        'ctrlMin
        '
        resources.ApplyResources(Me.ctrlMin, "ctrlMin")
        Me.ctrlMin.Animated = True
        Me.ctrlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlMin.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlMin.IconColor = System.Drawing.Color.White
        Me.ctrlMin.Name = "ctrlMin"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'LblVer
        '
        Me.LblVer.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.LblVer, "LblVer")
        Me.LblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblVer.Name = "LblVer"
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
        resources.ApplyResources(Me.btnCheck, "btnCheck")
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCheck.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.TextOffset = New System.Drawing.Point(0, 25)
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
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnBack.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnBack.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.TextOffset = New System.Drawing.Point(-80, 0)
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
        resources.ApplyResources(Me.btnCheckAll, "btnCheckAll")
        Me.btnCheckAll.ForeColor = System.Drawing.Color.White
        Me.btnCheckAll.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCheckAll.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCheckAll.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCheckAll.TextOffset = New System.Drawing.Point(55, 0)
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
        resources.ApplyResources(Me.btnLastCal, "btnLastCal")
        Me.btnLastCal.ForeColor = System.Drawing.Color.White
        Me.btnLastCal.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnLastCal.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnLastCal.Name = "btnLastCal"
        Me.btnLastCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLastCal.TextOffset = New System.Drawing.Point(55, 0)
        '
        'ImgHero
        '
        resources.ApplyResources(Me.ImgHero, "ImgHero")
        Me.ImgHero.Name = "ImgHero"
        Me.ImgHero.TabStop = False
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
        resources.ApplyResources(Me.txtFeederID, "txtFeederID")
        Me.txtFeederID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtFeederID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtFeederID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.barcode_scanner
        Me.txtFeederID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFeederID.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtFeederID.MaxLength = 7
        Me.txtFeederID.Name = "txtFeederID"
        Me.txtFeederID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFeederID.PlaceholderText = "Feeder ID"
        Me.txtFeederID.SelectedText = ""
        '
        'FrmCalChecker
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Controls.Add(Me.btnLastCal)
        Me.Controls.Add(Me.btnCheckAll)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtFeederID)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCalChecker"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents LblVer As Label
    Friend WithEvents txtFeederID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ImgHero As PictureBox
    Friend WithEvents btnCheckAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnLastCal As Guna.UI2.WinForms.Guna2Button
End Class
