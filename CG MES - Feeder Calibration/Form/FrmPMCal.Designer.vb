<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPMCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPMCal))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.LblVer = New System.Windows.Forms.Label()
        Me.ImgHero = New System.Windows.Forms.PictureBox()
        Me.pnlAtas = New System.Windows.Forms.Panel()
        Me.txtMachineID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlSection = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlCal = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlAll = New System.Windows.Forms.Panel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDate1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblCal = New System.Windows.Forms.Label()
        Me.pnlDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLCalDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtas.SuspendLayout()
        Me.pnlSection.SuspendLayout()
        Me.pnlCal.SuspendLayout()
        Me.pnlAll.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
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
        Me.Guna2Panel1.TabIndex = 78
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
        Me.LblVer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblVer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVer.Location = New System.Drawing.Point(374, 834)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(288, 15)
        Me.LblVer.TabIndex = 87
        Me.LblVer.Text = "Ver: {0.0.0.1}"
        Me.LblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgHero
        '
        Me.ImgHero.Image = CType(resources.GetObject("ImgHero.Image"), System.Drawing.Image)
        Me.ImgHero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ImgHero.Location = New System.Drawing.Point(446, 95)
        Me.ImgHero.Name = "ImgHero"
        Me.ImgHero.Size = New System.Drawing.Size(275, 84)
        Me.ImgHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHero.TabIndex = 86
        Me.ImgHero.TabStop = False
        '
        'pnlAtas
        '
        Me.pnlAtas.Controls.Add(Me.txtMachineID)
        Me.pnlAtas.Controls.Add(Me.btnCancel)
        Me.pnlAtas.Location = New System.Drawing.Point(308, 214)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(482, 47)
        Me.pnlAtas.TabIndex = 91
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
        Me.txtMachineID.Location = New System.Drawing.Point(3, 0)
        Me.txtMachineID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtMachineID.MaxLength = 6
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMachineID.PlaceholderText = "Machine ID"
        Me.txtMachineID.SelectedText = ""
        Me.txtMachineID.Size = New System.Drawing.Size(350, 47)
        Me.txtMachineID.TabIndex = 83
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.button
        Me.btnCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Enabled = False
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnCancel.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCancel.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCancel.Location = New System.Drawing.Point(361, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 47)
        Me.btnCancel.TabIndex = 89
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextOffset = New System.Drawing.Point(15, 0)
        '
        'pnlSection
        '
        Me.pnlSection.BorderRadius = 15
        Me.pnlSection.Controls.Add(Me.pnlCal)
        Me.pnlSection.Controls.Add(Me.lblCal)
        Me.pnlSection.Controls.Add(Me.pnlDetails)
        Me.pnlSection.Controls.Add(Me.lblDetails)
        Me.pnlSection.Enabled = False
        Me.pnlSection.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnlSection.Location = New System.Drawing.Point(173, 297)
        Me.pnlSection.Name = "pnlSection"
        Me.pnlSection.Size = New System.Drawing.Size(656, 346)
        Me.pnlSection.TabIndex = 92
        '
        'pnlCal
        '
        Me.pnlCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnlCal.BorderRadius = 15
        Me.pnlCal.Controls.Add(Me.pnlAll)
        Me.pnlCal.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlCal.Location = New System.Drawing.Point(14, 203)
        Me.pnlCal.Name = "pnlCal"
        Me.pnlCal.Size = New System.Drawing.Size(629, 130)
        Me.pnlCal.TabIndex = 88
        '
        'pnlAll
        '
        Me.pnlAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlAll.Controls.Add(Me.btnConfirm)
        Me.pnlAll.Controls.Add(Me.Label5)
        Me.pnlAll.Controls.Add(Me.txtEmployeeID)
        Me.pnlAll.Controls.Add(Me.btnDate1)
        Me.pnlAll.Location = New System.Drawing.Point(96, 17)
        Me.pnlAll.Name = "pnlAll"
        Me.pnlAll.Size = New System.Drawing.Size(417, 97)
        Me.pnlAll.TabIndex = 88
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnConfirm.BorderRadius = 10
        Me.btnConfirm.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.checked
        Me.btnConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
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
        Me.btnConfirm.Location = New System.Drawing.Point(213, 45)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(197, 47)
        Me.btnConfirm.TabIndex = 85
        Me.btnConfirm.Text = "Confirm Calibrate"
        Me.btnConfirm.TextOffset = New System.Drawing.Point(15, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "New PM Calibration Date: "
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Animated = True
        Me.txtEmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.txtEmployeeID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtEmployeeID.BorderRadius = 8
        Me.txtEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployeeID.DefaultText = ""
        Me.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmployeeID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmployeeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmployeeID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.user__4_
        Me.txtEmployeeID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmployeeID.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtEmployeeID.Location = New System.Drawing.Point(8, 45)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtEmployeeID.MaxLength = 7
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeID.PlaceholderText = "Employee ID"
        Me.txtEmployeeID.SelectedText = ""
        Me.txtEmployeeID.Size = New System.Drawing.Size(197, 47)
        Me.txtEmployeeID.TabIndex = 84
        '
        'btnDate1
        '
        Me.btnDate1.Animated = True
        Me.btnDate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnDate1.BorderRadius = 15
        Me.btnDate1.Checked = True
        Me.btnDate1.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnDate1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDate1.ForeColor = System.Drawing.Color.White
        Me.btnDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.btnDate1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnDate1.Location = New System.Drawing.Point(266, 4)
        Me.btnDate1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.btnDate1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.btnDate1.Name = "btnDate1"
        Me.btnDate1.Size = New System.Drawing.Size(144, 29)
        Me.btnDate1.TabIndex = 0
        Me.btnDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnDate1.Value = New Date(2023, 6, 20, 9, 33, 24, 843)
        '
        'lblCal
        '
        Me.lblCal.AutoSize = True
        Me.lblCal.BackColor = System.Drawing.Color.Transparent
        Me.lblCal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCal.Location = New System.Drawing.Point(130, 173)
        Me.lblCal.Name = "lblCal"
        Me.lblCal.Size = New System.Drawing.Size(245, 28)
        Me.lblCal.TabIndex = 88
        Me.lblCal.Text = "Machine PM Calibration:"
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnlDetails.BorderRadius = 15
        Me.pnlDetails.Controls.Add(Me.lblLCalDate)
        Me.pnlDetails.Controls.Add(Me.lblLocation)
        Me.pnlDetails.Controls.Add(Me.lblMName)
        Me.pnlDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlDetails.Location = New System.Drawing.Point(14, 41)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(629, 122)
        Me.pnlDetails.TabIndex = 87
        '
        'lblLCalDate
        '
        Me.lblLCalDate.AutoSize = True
        Me.lblLCalDate.BackColor = System.Drawing.Color.Transparent
        Me.lblLCalDate.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLCalDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLCalDate.Location = New System.Drawing.Point(18, 69)
        Me.lblLCalDate.Name = "lblLCalDate"
        Me.lblLCalDate.Size = New System.Drawing.Size(253, 28)
        Me.lblLCalDate.TabIndex = 10
        Me.lblLCalDate.Text = "Last PM Calibration Date:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLocation.Location = New System.Drawing.Point(381, 69)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(98, 28)
        Me.lblLocation.TabIndex = 9
        Me.lblLocation.Text = "Location:"
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.BackColor = System.Drawing.Color.Transparent
        Me.lblMName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMName.Location = New System.Drawing.Point(159, 20)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(160, 28)
        Me.lblMName.TabIndex = 7
        Me.lblMName.Text = "Machine Name:"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetails.Location = New System.Drawing.Point(240, 10)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(170, 28)
        Me.lblDetails.TabIndex = 6
        Me.lblDetails.Text = "Machine Details:"
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
        Me.btnBack.Location = New System.Drawing.Point(377, 649)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(350, 65)
        Me.btnBack.TabIndex = 93
        Me.btnBack.Text = "Back"
        Me.btnBack.TextOffset = New System.Drawing.Point(-80, 0)
        '
        'FrmPMCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlSection)
        Me.Controls.Add(Me.pnlAtas)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPMCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine PM Calibration"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtas.ResumeLayout(False)
        Me.pnlSection.ResumeLayout(False)
        Me.pnlSection.PerformLayout()
        Me.pnlCal.ResumeLayout(False)
        Me.pnlAll.ResumeLayout(False)
        Me.pnlAll.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LblVer As Label
    Friend WithEvents ImgHero As PictureBox
    Friend WithEvents pnlAtas As Panel
    Friend WithEvents txtMachineID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSection As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlCal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlAll As Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDate1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblCal As Label
    Friend WithEvents pnlDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLCalDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblMName As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
