<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManagement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManagement))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.dgvFeeder = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.cbxStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxColor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxSize = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.cbxType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtEmployeeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFeederID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.LblVer = New System.Windows.Forms.Label()
        Me.ImgHero = New System.Windows.Forms.PictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvFeeder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
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
        'dgvFeeder
        '
        Me.dgvFeeder.AllowUserToAddRows = False
        Me.dgvFeeder.AllowUserToDeleteRows = False
        Me.dgvFeeder.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFeeder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFeeder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFeeder.ColumnHeadersHeight = 27
        Me.dgvFeeder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFeeder.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFeeder.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvFeeder.Location = New System.Drawing.Point(20, 16)
        Me.dgvFeeder.Name = "dgvFeeder"
        Me.dgvFeeder.ReadOnly = True
        Me.dgvFeeder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFeeder.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFeeder.RowHeadersVisible = False
        Me.dgvFeeder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFeeder.RowTemplate.Height = 20
        Me.dgvFeeder.Size = New System.Drawing.Size(616, 382)
        Me.dgvFeeder.TabIndex = 1
        Me.dgvFeeder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgvFeeder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvFeeder.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFeeder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvFeeder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvFeeder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFeeder.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvFeeder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvFeeder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvFeeder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFeeder.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFeeder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvFeeder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvFeeder.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvFeeder.ThemeStyle.ReadOnly = True
        Me.dgvFeeder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvFeeder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvFeeder.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFeeder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvFeeder.ThemeStyle.RowsStyle.Height = 20
        Me.dgvFeeder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvFeeder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnl1
        '
        Me.pnl1.BorderRadius = 15
        Me.pnl1.Controls.Add(Me.btnSearch)
        Me.pnl1.Controls.Add(Me.btnRefresh)
        Me.pnl1.Controls.Add(Me.dgvFeeder)
        Me.pnl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.pnl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnl1.Location = New System.Drawing.Point(46, 214)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(655, 446)
        Me.pnl1.TabIndex = 79
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
        Me.btnSearch.Location = New System.Drawing.Point(20, 404)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(303, 27)
        Me.btnSearch.TabIndex = 90
        Me.btnSearch.Text = "Search"
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
        Me.btnRefresh.Location = New System.Drawing.Point(333, 404)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(303, 27)
        Me.btnRefresh.TabIndex = 89
        Me.btnRefresh.Text = "Refresh"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.Controls.Add(Me.btnConfirm)
        Me.Guna2Panel3.Controls.Add(Me.btnCancel)
        Me.Guna2Panel3.Controls.Add(Me.btnDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel3.Controls.Add(Me.btnCreate)
        Me.Guna2Panel3.Controls.Add(Me.cbxStatus)
        Me.Guna2Panel3.Controls.Add(Me.cbxColor)
        Me.Guna2Panel3.Controls.Add(Me.cbxSize)
        Me.Guna2Panel3.Controls.Add(Me.lblDetails)
        Me.Guna2Panel3.Controls.Add(Me.cbxType)
        Me.Guna2Panel3.Controls.Add(Me.txtEmployeeID)
        Me.Guna2Panel3.Controls.Add(Me.txtFeederID)
        Me.Guna2Panel3.Controls.Add(Me.btnBack)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Guna2Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2Panel3.Location = New System.Drawing.Point(718, 214)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(393, 446)
        Me.Guna2Panel3.TabIndex = 80
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
        Me.btnConfirm.Location = New System.Drawing.Point(22, 290)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(350, 65)
        Me.btnConfirm.TabIndex = 104
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.TextOffset = New System.Drawing.Point(-65, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(199, 245)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(173, 39)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextOffset = New System.Drawing.Point(-19, 0)
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
        Me.btnDelete.Location = New System.Drawing.Point(22, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(173, 39)
        Me.btnDelete.TabIndex = 102
        Me.btnDelete.Text = "Delete Feeder"
        Me.btnDelete.TextOffset = New System.Drawing.Point(5, 0)
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
        Me.btnUpdate.Location = New System.Drawing.Point(199, 200)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(173, 39)
        Me.btnUpdate.TabIndex = 101
        Me.btnUpdate.Text = "Edit Feeder"
        Me.btnUpdate.TextOffset = New System.Drawing.Point(-2, 0)
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
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCreate.ImageOffset = New System.Drawing.Point(15, 0)
        Me.btnCreate.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnCreate.Location = New System.Drawing.Point(22, 200)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(173, 39)
        Me.btnCreate.TabIndex = 100
        Me.btnCreate.Text = "Add New Feeder"
        Me.btnCreate.TextOffset = New System.Drawing.Point(18, 0)
        '
        'cbxStatus
        '
        Me.cbxStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbxStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxStatus.BorderRadius = 8
        Me.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.Enabled = False
        Me.cbxStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxStatus.ItemHeight = 30
        Me.cbxStatus.Items.AddRange(New Object() {"GOOD", "NO GOOD"})
        Me.cbxStatus.Location = New System.Drawing.Point(22, 139)
        Me.cbxStatus.MaxDropDownItems = 14
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(173, 36)
        Me.cbxStatus.StartIndex = 0
        Me.cbxStatus.TabIndex = 6
        '
        'cbxColor
        '
        Me.cbxColor.BackColor = System.Drawing.Color.Transparent
        Me.cbxColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxColor.BorderRadius = 8
        Me.cbxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxColor.Enabled = False
        Me.cbxColor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxColor.ItemHeight = 30
        Me.cbxColor.Items.AddRange(New Object() {"Select Colour", "ORANGE", "BLUE", "GREEN"})
        Me.cbxColor.Location = New System.Drawing.Point(199, 94)
        Me.cbxColor.MaxDropDownItems = 14
        Me.cbxColor.Name = "cbxColor"
        Me.cbxColor.Size = New System.Drawing.Size(173, 36)
        Me.cbxColor.StartIndex = 0
        Me.cbxColor.TabIndex = 5
        '
        'cbxSize
        '
        Me.cbxSize.BackColor = System.Drawing.Color.Transparent
        Me.cbxSize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxSize.BorderRadius = 8
        Me.cbxSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSize.Enabled = False
        Me.cbxSize.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxSize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxSize.ItemHeight = 30
        Me.cbxSize.Items.AddRange(New Object() {"Select Size", "SMALL", "BIG"})
        Me.cbxSize.Location = New System.Drawing.Point(22, 94)
        Me.cbxSize.MaxDropDownItems = 14
        Me.cbxSize.Name = "cbxSize"
        Me.cbxSize.Size = New System.Drawing.Size(173, 36)
        Me.cbxSize.StartIndex = 0
        Me.cbxSize.TabIndex = 4
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetails.Location = New System.Drawing.Point(120, 13)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(152, 28)
        Me.lblDetails.TabIndex = 96
        Me.lblDetails.Text = "Feeder Details:"
        '
        'cbxType
        '
        Me.cbxType.BackColor = System.Drawing.Color.Transparent
        Me.cbxType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbxType.BorderRadius = 8
        Me.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.Enabled = False
        Me.cbxType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.cbxType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cbxType.ItemHeight = 30
        Me.cbxType.Items.AddRange(New Object() {"Select Type", "P8x2mm (CF)", "P8x2mm (NF)", "P8x2mm (FF)", "E8x2mm (CF)", "E8x2mm (NF)", "E8x2mm (FF)", "P8x4mm (CF)", "P8x4mm (NF)", "P8x4mm (FF)", "E8x4mm (CF)", "E8x4mm (NF)", "E8x4mm (FF)", "E12 (NF)", "E12 (FF)", "E16 (NF)", "E16 (FF)", "E24 (NF)", "E24 (FF)", "E32 (FF)"})
        Me.cbxType.Location = New System.Drawing.Point(199, 50)
        Me.cbxType.MaxDropDownItems = 14
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(173, 36)
        Me.cbxType.StartIndex = 0
        Me.cbxType.TabIndex = 3
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
        Me.txtEmployeeID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.user__4_
        Me.txtEmployeeID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmployeeID.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtEmployeeID.Location = New System.Drawing.Point(199, 139)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtEmployeeID.MaxLength = 7
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployeeID.PlaceholderText = "Employee ID"
        Me.txtEmployeeID.SelectedText = ""
        Me.txtEmployeeID.Size = New System.Drawing.Size(173, 35)
        Me.txtEmployeeID.TabIndex = 7
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
        Me.txtFeederID.Enabled = False
        Me.txtFeederID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtFeederID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFeederID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtFeederID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtFeederID.IconLeft = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.id__1_
        Me.txtFeederID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFeederID.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtFeederID.Location = New System.Drawing.Point(22, 50)
        Me.txtFeederID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFeederID.MaxLength = 7
        Me.txtFeederID.Name = "txtFeederID"
        Me.txtFeederID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFeederID.PlaceholderText = "Feeder ID"
        Me.txtFeederID.SelectedText = ""
        Me.txtFeederID.Size = New System.Drawing.Size(173, 35)
        Me.txtFeederID.TabIndex = 2
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
        Me.btnBack.Location = New System.Drawing.Point(22, 361)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(350, 65)
        Me.btnBack.TabIndex = 88
        Me.btnBack.Text = "Back"
        Me.btnBack.TextOffset = New System.Drawing.Point(-80, 0)
        '
        'LblVer
        '
        Me.LblVer.BackColor = System.Drawing.Color.Transparent
        Me.LblVer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblVer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVer.Location = New System.Drawing.Point(515, 816)
        Me.LblVer.Name = "LblVer"
        Me.LblVer.Size = New System.Drawing.Size(288, 15)
        Me.LblVer.TabIndex = 86
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
        Me.ImgHero.TabIndex = 85
        Me.ImgHero.TabStop = False
        '
        'FrmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.LblVer)
        Me.Controls.Add(Me.ImgHero)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feeder Management"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dgvFeeder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.ImgHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents dgvFeeder As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnl1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ImgHero As PictureBox
    Friend WithEvents LblVer As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmployeeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFeederID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents cbxSize As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxColor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
