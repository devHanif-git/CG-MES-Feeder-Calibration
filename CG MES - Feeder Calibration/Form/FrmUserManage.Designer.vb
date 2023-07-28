<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserManage
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
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserManage))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LblVer = New System.Windows.Forms.Label()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvUser = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ImgHero = New System.Windows.Forms.PictureBox()
        Me.cbxGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnActive = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnSuspend = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.pnl1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LblVer.Location = New System.Drawing.Point(535, 776)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(288, 15)
        Me.LblVer.TabIndex = 87
        Me.LblVer.Text = "Ver: {0.0.0.1}"
        Me.LblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.Controls.Add(Me.btnSuspend)
        Me.Guna2Panel3.Controls.Add(Me.btnActive)
        Me.Guna2Panel3.Controls.Add(Me.lblStatus)
        Me.Guna2Panel3.Controls.Add(Me.cbxLevel)
        Me.Guna2Panel3.Controls.Add(Me.cbxGroup)
        Me.Guna2Panel3.Controls.Add(Me.txtEmail)
        Me.Guna2Panel3.Controls.Add(Me.txtPass2)
        Me.Guna2Panel3.Controls.Add(Me.txtPass1)
        Me.Guna2Panel3.Controls.Add(Me.txtName)
        Me.Guna2Panel3.Controls.Add(Me.btnConfirm)
        Me.Guna2Panel3.Controls.Add(Me.btnCancel)
        Me.Guna2Panel3.Controls.Add(Me.btnDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel3.Controls.Add(Me.btnCreate)
        Me.Guna2Panel3.Controls.Add(Me.lblDetails)
        Me.Guna2Panel3.Controls.Add(Me.txtEmployeeID)
        Me.Guna2Panel3.Controls.Add(Me.btnBack)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Panel3.Location = New System.Drawing.Point(647, 223)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(468, 446)
        Me.Guna2Panel3.TabIndex = 89
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnConfirm.BorderRadius = 10
        Me.btnConfirm.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.confirmation
        Me.btnConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.CustomImages.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnConfirm.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnConfirm.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnConfirm.Location = New System.Drawing.Point(15, 350)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(216, 81)
        Me.btnConfirm.TabIndex = 104
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.cancelled
        Me.btnCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.CustomImages.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnCancel.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
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
        Me.btnCancel.Location = New System.Drawing.Point(238, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(216, 39)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextOffset = New System.Drawing.Point(-40, 0)
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnDelete.BorderRadius = 10
        Me.btnDelete.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.cancel
        Me.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.CustomImages.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnDelete.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDelete.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnDelete.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnDelete.Location = New System.Drawing.Point(15, 305)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(216, 39)
        Me.btnDelete.TabIndex = 102
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.TextOffset = New System.Drawing.Point(-24, 0)
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnUpdate.BorderRadius = 10
        Me.btnUpdate.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.edit
        Me.btnUpdate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdate.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnUpdate.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnUpdate.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnUpdate.Location = New System.Drawing.Point(238, 260)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(216, 39)
        Me.btnUpdate.TabIndex = 101
        Me.btnUpdate.Text = "Edit User"
        Me.btnUpdate.TextOffset = New System.Drawing.Point(-31, 0)
        '
        'btnCreate
        '
        Me.btnCreate.Animated = True
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnCreate.BorderRadius = 10
        Me.btnCreate.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.add_file
        Me.btnCreate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreate.CustomImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCreate.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCreate.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCreate.Location = New System.Drawing.Point(15, 260)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(216, 39)
        Me.btnCreate.TabIndex = 100
        Me.btnCreate.Text = "Add New User"
        Me.btnCreate.TextOffset = New System.Drawing.Point(-12, 0)
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetails.Location = New System.Drawing.Point(163, 13)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(131, 28)
        Me.lblDetails.TabIndex = 96
        Me.lblDetails.Text = "User Details:"
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
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
        Me.btnBack.Location = New System.Drawing.Point(238, 350)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(216, 81)
        Me.btnBack.TabIndex = 88
        Me.btnBack.Text = "Back"
        Me.btnBack.TextOffset = New System.Drawing.Point(-17, 0)
        '
        'pnl1
        '
        Me.pnl1.BorderRadius = 15
        Me.pnl1.Controls.Add(Me.btnSearch)
        Me.pnl1.Controls.Add(Me.btnRefresh)
        Me.pnl1.Controls.Add(Me.dgvUser)
        Me.pnl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnl1.Location = New System.Drawing.Point(50, 223)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(591, 446)
        Me.pnl1.TabIndex = 88
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
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
        Me.btnSearch.Location = New System.Drawing.Point(7, 404)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(286, 27)
        Me.btnSearch.TabIndex = 90
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextOffset = New System.Drawing.Point(12, 0)
        '
        'btnRefresh
        '
        Me.btnRefresh.Animated = True
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRefresh.CustomImages.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.refresh__1_
        Me.btnRefresh.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRefresh.CustomImages.ImageOffset = New System.Drawing.Point(85, 0)
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnRefresh.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnRefresh.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnRefresh.Location = New System.Drawing.Point(298, 404)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(286, 27)
        Me.btnRefresh.TabIndex = 89
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextOffset = New System.Drawing.Point(12, 0)
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeRows = False
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.dgvUser.ColumnHeadersHeight = 27
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle35
        Me.dgvUser.Enabled = False
        Me.dgvUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvUser.Location = New System.Drawing.Point(7, 16)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUser.RowTemplate.Height = 20
        Me.dgvUser.Size = New System.Drawing.Size(577, 382)
        Me.dgvUser.TabIndex = 1
        Me.dgvUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUser.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUser.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUser.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvUser.ThemeStyle.ReadOnly = True
        Me.dgvUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUser.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvUser.ThemeStyle.RowsStyle.Height = 20
        Me.dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.Enabled = False
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmail.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.email
        Me.txtEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmail.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtEmail.Location = New System.Drawing.Point(176, 50)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtEmail.MaxLength = 500
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email Address"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(278, 35)
        Me.txtEmail.TabIndex = 3
        '
        'txtPass2
        '
        Me.txtPass2.Animated = True
        Me.txtPass2.BackColor = System.Drawing.Color.Transparent
        Me.txtPass2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtPass2.BorderRadius = 8
        Me.txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass2.DefaultText = ""
        Me.txtPass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass2.Enabled = False
        Me.txtPass2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPass2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtPass2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass2.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.padlock__1_
        Me.txtPass2.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPass2.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtPass2.Location = New System.Drawing.Point(238, 139)
        Me.txtPass2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPass2.MaxLength = 500
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass2.PlaceholderText = "Re-enter Password"
        Me.txtPass2.SelectedText = ""
        Me.txtPass2.Size = New System.Drawing.Size(216, 35)
        Me.txtPass2.TabIndex = 6
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'txtPass1
        '
        Me.txtPass1.Animated = True
        Me.txtPass1.BackColor = System.Drawing.Color.Transparent
        Me.txtPass1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtPass1.BorderRadius = 8
        Me.txtPass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass1.DefaultText = ""
        Me.txtPass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass1.Enabled = False
        Me.txtPass1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPass1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtPass1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass1.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.padlock__1_
        Me.txtPass1.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPass1.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtPass1.Location = New System.Drawing.Point(15, 139)
        Me.txtPass1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPass1.MaxLength = 500
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass1.PlaceholderText = "Password"
        Me.txtPass1.SelectedText = ""
        Me.txtPass1.Size = New System.Drawing.Size(216, 35)
        Me.txtPass1.TabIndex = 5
        Me.txtPass1.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtName.BorderRadius = 8
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.Enabled = False
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtName.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.id_card
        Me.txtName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtName.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtName.Location = New System.Drawing.Point(15, 94)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtName.MaxLength = 500
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = "Name"
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(439, 35)
        Me.txtName.TabIndex = 4
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
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmployeeID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmployeeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtEmployeeID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.id__1_
        Me.txtEmployeeID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmployeeID.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtEmployeeID.Location = New System.Drawing.Point(15, 50)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtEmployeeID.MaxLength = 7
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeID.PlaceholderText = "Employee ID"
        Me.txtEmployeeID.SelectedText = ""
        Me.txtEmployeeID.Size = New System.Drawing.Size(154, 35)
        Me.txtEmployeeID.TabIndex = 2
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
        'cbxGroup
        '
        Me.cbxGroup.BackColor = System.Drawing.Color.Transparent
        Me.cbxGroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxGroup.BorderRadius = 8
        Me.cbxGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGroup.Enabled = False
        Me.cbxGroup.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxGroup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxGroup.ItemHeight = 30
        Me.cbxGroup.Location = New System.Drawing.Point(15, 183)
        Me.cbxGroup.MaxDropDownItems = 14
        Me.cbxGroup.Name = "cbxGroup"
        Me.cbxGroup.Size = New System.Drawing.Size(216, 36)
        Me.cbxGroup.StartIndex = 0
        Me.cbxGroup.TabIndex = 7
        '
        'cbxLevel
        '
        Me.cbxLevel.BackColor = System.Drawing.Color.Transparent
        Me.cbxLevel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxLevel.BorderRadius = 8
        Me.cbxLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLevel.Enabled = False
        Me.cbxLevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxLevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxLevel.ItemHeight = 30
        Me.cbxLevel.Location = New System.Drawing.Point(238, 183)
        Me.cbxLevel.MaxDropDownItems = 14
        Me.cbxLevel.Name = "cbxLevel"
        Me.cbxLevel.Size = New System.Drawing.Size(216, 36)
        Me.cbxLevel.StartIndex = 0
        Me.cbxLevel.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Enabled = False
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStatus.Location = New System.Drawing.Point(20, 226)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(61, 21)
        Me.lblStatus.TabIndex = 111
        Me.lblStatus.Text = "Status:"
        '
        'btnActive
        '
        Me.btnActive.AutoSize = True
        Me.btnActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnActive.Checked = True
        Me.btnActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActive.CheckedState.BorderThickness = 0
        Me.btnActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActive.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnActive.CheckedState.InnerOffset = -4
        Me.btnActive.Enabled = False
        Me.btnActive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnActive.ForeColor = System.Drawing.Color.White
        Me.btnActive.Location = New System.Drawing.Point(87, 225)
        Me.btnActive.Name = "btnActive"
        Me.btnActive.Size = New System.Drawing.Size(76, 25)
        Me.btnActive.TabIndex = 112
        Me.btnActive.TabStop = True
        Me.btnActive.Text = "Active"
        Me.btnActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnActive.UncheckedState.BorderThickness = 2
        Me.btnActive.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnActive.UseVisualStyleBackColor = False
        '
        'btnSuspend
        '
        Me.btnSuspend.AutoSize = True
        Me.btnSuspend.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnSuspend.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSuspend.CheckedState.BorderThickness = 0
        Me.btnSuspend.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSuspend.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnSuspend.CheckedState.InnerOffset = -4
        Me.btnSuspend.Enabled = False
        Me.btnSuspend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSuspend.ForeColor = System.Drawing.Color.White
        Me.btnSuspend.Location = New System.Drawing.Point(176, 225)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.Size = New System.Drawing.Size(93, 25)
        Me.btnSuspend.TabIndex = 113
        Me.btnSuspend.Text = "Suspend"
        Me.btnSuspend.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuspend.UncheckedState.BorderThickness = 2
        Me.btnSuspend.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnSuspend.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnSuspend.UseVisualStyleBackColor = False
        '
        'FrmUserManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUserManage"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ImgHero As PictureBox
    Friend WithEvents LblVer As Label
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDetails As Label
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSuspend As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnActive As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbxLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxGroup As Guna.UI2.WinForms.Guna2ComboBox
End Class
