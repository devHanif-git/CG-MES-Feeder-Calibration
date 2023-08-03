<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnlRecoveryPassword = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtNewPassword2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPassword1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblVerRP = New System.Windows.Forms.Label()
        Me.btnRPConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRPCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlRecoveryCode = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblVerRC = New System.Windows.Forms.Label()
        Me.btnRCConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRCBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlRecovery = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCGID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblVerR = New System.Windows.Forms.Label()
        Me.btnRConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlLoading = New Guna.UI2.WinForms.Guna2Panel()
        Me.loadingGif = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRecover = New System.Windows.Forms.LinkLabel()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.picHero = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Transition = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlRecoveryPassword.SuspendLayout()
        Me.pnlRecoveryCode.SuspendLayout()
        Me.pnlRecovery.SuspendLayout()
        Me.pnlLoading.SuspendLayout()
        CType(Me.loadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.ctrlClose)
        Me.Guna2Panel1.Controls.Add(Me.ctrlMin)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Transition.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1164, 30)
        Me.Guna2Panel1.TabIndex = 5
        '
        'ctrlClose
        '
        Me.ctrlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlClose.Animated = True
        Me.Transition.SetDecoration(Me.ctrlClose, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Transition.SetDecoration(Me.ctrlMin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ctrlMin.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ctrlMin.IconColor = System.Drawing.Color.White
        Me.ctrlMin.Location = New System.Drawing.Point(1087, 0)
        Me.ctrlMin.Name = "ctrlMin"
        Me.ctrlMin.Size = New System.Drawing.Size(40, 29)
        Me.ctrlMin.TabIndex = 2
        '
        'pnlRecoveryPassword
        '
        Me.pnlRecoveryPassword.BackColor = System.Drawing.Color.White
        Me.pnlRecoveryPassword.Controls.Add(Me.txtNewPassword2)
        Me.pnlRecoveryPassword.Controls.Add(Me.Label2)
        Me.pnlRecoveryPassword.Controls.Add(Me.txtNewPassword1)
        Me.pnlRecoveryPassword.Controls.Add(Me.lblVerRP)
        Me.pnlRecoveryPassword.Controls.Add(Me.btnRPConfirm)
        Me.pnlRecoveryPassword.Controls.Add(Me.btnRPCancel)
        Me.pnlRecoveryPassword.Controls.Add(Me.Label9)
        Me.Transition.SetDecoration(Me.pnlRecoveryPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlRecoveryPassword.Location = New System.Drawing.Point(327, 83)
        Me.pnlRecoveryPassword.Name = "pnlRecoveryPassword"
        Me.pnlRecoveryPassword.Size = New System.Drawing.Size(52, 42)
        Me.pnlRecoveryPassword.TabIndex = 74
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Animated = True
        Me.txtNewPassword2.BackColor = System.Drawing.Color.Transparent
        Me.txtNewPassword2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtNewPassword2.BorderRadius = 8
        Me.txtNewPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtNewPassword2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtNewPassword2.DefaultText = ""
        Me.txtNewPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNewPassword2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewPassword2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtNewPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNewPassword2.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtNewPassword2.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtNewPassword2.Location = New System.Drawing.Point(57, 178)
        Me.txtNewPassword2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword2.PlaceholderText = "Re-enter New Password"
        Me.txtNewPassword2.SelectedText = ""
        Me.txtNewPassword2.Size = New System.Drawing.Size(288, 47)
        Me.txtNewPassword2.TabIndex = 13
        Me.txtNewPassword2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(111, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 15)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Please create a new password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.Animated = True
        Me.txtNewPassword1.BackColor = System.Drawing.Color.Transparent
        Me.txtNewPassword1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtNewPassword1.BorderRadius = 8
        Me.txtNewPassword1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtNewPassword1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtNewPassword1.DefaultText = ""
        Me.txtNewPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNewPassword1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewPassword1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtNewPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNewPassword1.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtNewPassword1.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtNewPassword1.Location = New System.Drawing.Point(57, 126)
        Me.txtNewPassword1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword1.PlaceholderText = "Enter New Password"
        Me.txtNewPassword1.SelectedText = ""
        Me.txtNewPassword1.Size = New System.Drawing.Size(288, 47)
        Me.txtNewPassword1.TabIndex = 12
        Me.txtNewPassword1.UseSystemPasswordChar = True
        '
        'lblVerRP
        '
        Me.lblVerRP.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.lblVerRP, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblVerRP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerRP.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVerRP.Location = New System.Drawing.Point(57, 438)
        Me.lblVerRP.Name = "lblVerRP"
        Me.lblVerRP.Size = New System.Drawing.Size(288, 15)
        Me.lblVerRP.TabIndex = 71
        Me.lblVerRP.Text = "Ver: {0.0.0.1}"
        Me.lblVerRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRPConfirm
        '
        Me.btnRPConfirm.Animated = True
        Me.btnRPConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnRPConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRPConfirm.BorderRadius = 8
        Me.btnRPConfirm.BorderThickness = 1
        Me.btnRPConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRPConfirm.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRPConfirm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRPConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRPConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRPConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRPConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRPConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRPConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRPConfirm.ForeColor = System.Drawing.Color.White
        Me.btnRPConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRPConfirm.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRPConfirm.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRPConfirm.Location = New System.Drawing.Point(57, 287)
        Me.btnRPConfirm.Name = "btnRPConfirm"
        Me.btnRPConfirm.Size = New System.Drawing.Size(288, 47)
        Me.btnRPConfirm.TabIndex = 12
        Me.btnRPConfirm.Text = "Confirm"
        '
        'btnRPCancel
        '
        Me.btnRPCancel.Animated = True
        Me.btnRPCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnRPCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRPCancel.BorderRadius = 8
        Me.btnRPCancel.BorderThickness = 1
        Me.btnRPCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRPCancel.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRPCancel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRPCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRPCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRPCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRPCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRPCancel.FillColor = System.Drawing.Color.White
        Me.btnRPCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRPCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRPCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRPCancel.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRPCancel.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRPCancel.Location = New System.Drawing.Point(57, 340)
        Me.btnRPCancel.Name = "btnRPCancel"
        Me.btnRPCancel.Size = New System.Drawing.Size(288, 47)
        Me.btnRPCancel.TabIndex = 13
        Me.btnRPCancel.Text = "Cancel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(115, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 46)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Recovery"
        '
        'pnlRecoveryCode
        '
        Me.pnlRecoveryCode.BackColor = System.Drawing.Color.White
        Me.pnlRecoveryCode.Controls.Add(Me.Label6)
        Me.pnlRecoveryCode.Controls.Add(Me.txtRCode)
        Me.pnlRecoveryCode.Controls.Add(Me.lblVerRC)
        Me.pnlRecoveryCode.Controls.Add(Me.btnRCConfirm)
        Me.pnlRecoveryCode.Controls.Add(Me.btnRCBack)
        Me.pnlRecoveryCode.Controls.Add(Me.Label8)
        Me.Transition.SetDecoration(Me.pnlRecoveryCode, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlRecoveryCode.Location = New System.Drawing.Point(270, 83)
        Me.pnlRecoveryCode.Name = "pnlRecoveryCode"
        Me.pnlRecoveryCode.Size = New System.Drawing.Size(39, 42)
        Me.pnlRecoveryCode.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(73, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 30)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Enter the recovery code from your email to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "proceed with the password reset."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRCode
        '
        Me.txtRCode.Animated = True
        Me.txtRCode.BackColor = System.Drawing.Color.Transparent
        Me.txtRCode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtRCode.BorderRadius = 8
        Me.txtRCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtRCode, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtRCode.DefaultText = ""
        Me.txtRCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtRCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtRCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtRCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtRCode.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtRCode.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtRCode.Location = New System.Drawing.Point(57, 158)
        Me.txtRCode.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtRCode.Name = "txtRCode"
        Me.txtRCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRCode.PlaceholderText = "Recovery Code"
        Me.txtRCode.SelectedText = ""
        Me.txtRCode.Size = New System.Drawing.Size(288, 47)
        Me.txtRCode.TabIndex = 9
        '
        'lblVerRC
        '
        Me.lblVerRC.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.lblVerRC, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblVerRC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerRC.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVerRC.Location = New System.Drawing.Point(57, 438)
        Me.lblVerRC.Name = "lblVerRC"
        Me.lblVerRC.Size = New System.Drawing.Size(288, 15)
        Me.lblVerRC.TabIndex = 67
        Me.lblVerRC.Text = "Ver: {0.0.0.1}"
        Me.lblVerRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRCConfirm
        '
        Me.btnRCConfirm.Animated = True
        Me.btnRCConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnRCConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRCConfirm.BorderRadius = 8
        Me.btnRCConfirm.BorderThickness = 1
        Me.btnRCConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRCConfirm.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRCConfirm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRCConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRCConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRCConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRCConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRCConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRCConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCConfirm.ForeColor = System.Drawing.Color.White
        Me.btnRCConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRCConfirm.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCConfirm.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRCConfirm.Location = New System.Drawing.Point(57, 254)
        Me.btnRCConfirm.Name = "btnRCConfirm"
        Me.btnRCConfirm.Size = New System.Drawing.Size(288, 47)
        Me.btnRCConfirm.TabIndex = 10
        Me.btnRCConfirm.Text = "Confirm"
        '
        'btnRCBack
        '
        Me.btnRCBack.Animated = True
        Me.btnRCBack.BackColor = System.Drawing.Color.Transparent
        Me.btnRCBack.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRCBack.BorderRadius = 8
        Me.btnRCBack.BorderThickness = 1
        Me.btnRCBack.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRCBack.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRCBack, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRCBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRCBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRCBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRCBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRCBack.FillColor = System.Drawing.Color.White
        Me.btnRCBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRCBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRCBack.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCBack.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRCBack.Location = New System.Drawing.Point(57, 307)
        Me.btnRCBack.Name = "btnRCBack"
        Me.btnRCBack.Size = New System.Drawing.Size(288, 47)
        Me.btnRCBack.TabIndex = 11
        Me.btnRCBack.Text = "Back"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(115, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 46)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Recovery"
        '
        'pnlRecovery
        '
        Me.pnlRecovery.BackColor = System.Drawing.Color.White
        Me.pnlRecovery.Controls.Add(Me.Label4)
        Me.pnlRecovery.Controls.Add(Me.txtCGID)
        Me.pnlRecovery.Controls.Add(Me.lblVerR)
        Me.pnlRecovery.Controls.Add(Me.btnRConfirm)
        Me.pnlRecovery.Controls.Add(Me.btnRCancel)
        Me.pnlRecovery.Controls.Add(Me.Label3)
        Me.Transition.SetDecoration(Me.pnlRecovery, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlRecovery.Location = New System.Drawing.Point(222, 82)
        Me.pnlRecovery.Name = "pnlRecovery"
        Me.pnlRecovery.Size = New System.Drawing.Size(42, 43)
        Me.pnlRecovery.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(358, 30)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Please provide your employee ID, and we'll send instructions on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "how to reset you" &
    "r password to your registered email address."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCGID
        '
        Me.txtCGID.Animated = True
        Me.txtCGID.BackColor = System.Drawing.Color.Transparent
        Me.txtCGID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtCGID.BorderRadius = 8
        Me.txtCGID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCGID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtCGID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtCGID.DefaultText = ""
        Me.txtCGID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCGID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCGID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCGID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCGID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtCGID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCGID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtCGID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtCGID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCGID.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtCGID.Location = New System.Drawing.Point(57, 158)
        Me.txtCGID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCGID.Name = "txtCGID"
        Me.txtCGID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCGID.PlaceholderText = "Employee ID"
        Me.txtCGID.SelectedText = ""
        Me.txtCGID.Size = New System.Drawing.Size(288, 47)
        Me.txtCGID.TabIndex = 6
        '
        'lblVerR
        '
        Me.lblVerR.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.lblVerR, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblVerR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerR.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVerR.Location = New System.Drawing.Point(57, 438)
        Me.lblVerR.Name = "lblVerR"
        Me.lblVerR.Size = New System.Drawing.Size(288, 15)
        Me.lblVerR.TabIndex = 72
        Me.lblVerR.Text = "Ver: {0.0.0.1}"
        Me.lblVerR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRConfirm
        '
        Me.btnRConfirm.Animated = True
        Me.btnRConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnRConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRConfirm.BorderRadius = 8
        Me.btnRConfirm.BorderThickness = 1
        Me.btnRConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRConfirm.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRConfirm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRConfirm.ForeColor = System.Drawing.Color.White
        Me.btnRConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRConfirm.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRConfirm.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRConfirm.Location = New System.Drawing.Point(57, 254)
        Me.btnRConfirm.Name = "btnRConfirm"
        Me.btnRConfirm.Size = New System.Drawing.Size(288, 47)
        Me.btnRConfirm.TabIndex = 7
        Me.btnRConfirm.Text = "Confirm"
        '
        'btnRCancel
        '
        Me.btnRCancel.Animated = True
        Me.btnRCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnRCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnRCancel.BorderRadius = 8
        Me.btnRCancel.BorderThickness = 1
        Me.btnRCancel.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRCancel.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnRCancel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRCancel.FillColor = System.Drawing.Color.White
        Me.btnRCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRCancel.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRCancel.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRCancel.Location = New System.Drawing.Point(57, 307)
        Me.btnRCancel.Name = "btnRCancel"
        Me.btnRCancel.Size = New System.Drawing.Size(288, 47)
        Me.btnRCancel.TabIndex = 8
        Me.btnRCancel.Text = "Cancel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(115, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 46)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Recovery"
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.White
        Me.pnlLoading.Controls.Add(Me.loadingGif)
        Me.Transition.SetDecoration(Me.pnlLoading, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlLoading.Location = New System.Drawing.Point(148, 82)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(46, 40)
        Me.pnlLoading.TabIndex = 71
        '
        'loadingGif
        '
        Me.loadingGif.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.loadingGif, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.loadingGif.FillColor = System.Drawing.Color.Transparent
        Me.loadingGif.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.Rolling
        Me.loadingGif.ImageRotate = 0!
        Me.loadingGif.Location = New System.Drawing.Point(15, 7)
        Me.loadingGif.Name = "loadingGif"
        Me.loadingGif.Size = New System.Drawing.Size(124, 124)
        Me.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.loadingGif.TabIndex = 0
        Me.loadingGif.TabStop = False
        Me.loadingGif.UseTransparentBackground = True
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.lblVer)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtID)
        Me.pnlLogin.Controls.Add(Me.btnExit)
        Me.pnlLogin.Controls.Add(Me.label1)
        Me.pnlLogin.Controls.Add(Me.txtPass)
        Me.pnlLogin.Controls.Add(Me.txtRecover)
        Me.Transition.SetDecoration(Me.pnlLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlLogin.Location = New System.Drawing.Point(88, 83)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(383, 434)
        Me.pnlLogin.TabIndex = 70
        Me.pnlLogin.Visible = False
        '
        'lblVer
        '
        Me.lblVer.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.lblVer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblVer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVer.Location = New System.Drawing.Point(57, 438)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(288, 15)
        Me.lblVer.TabIndex = 73
        Me.lblVer.Text = "Ver: {0.0.0.1}"
        Me.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLogin.BorderRadius = 8
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogin.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnLogin.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(57, 287)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(288, 47)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'txtID
        '
        Me.txtID.Animated = True
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtID.BorderRadius = 8
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtID.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtID.Location = New System.Drawing.Point(57, 120)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtID.MaxLength = 7
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = "Employee ID"
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(288, 47)
        Me.txtID.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Animated = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnExit.BorderRadius = 8
        Me.btnExit.BorderThickness = 1
        Me.btnExit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExit.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Transition.SetDecoration(Me.btnExit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnExit.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(57, 340)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(288, 47)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(141, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 46)
        Me.label1.TabIndex = 55
        Me.label1.Text = "Log In"
        '
        'txtPass
        '
        Me.txtPass.Animated = True
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtPass.BorderRadius = 8
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transition.SetDecoration(Me.txtPass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPass.IconLeftSize = New System.Drawing.Size(22, 22)
        Me.txtPass.Location = New System.Drawing.Point(57, 172)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.PlaceholderText = "Password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(288, 47)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtRecover
        '
        Me.txtRecover.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtRecover.AutoSize = True
        Me.txtRecover.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.txtRecover, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtRecover.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecover.LinkColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtRecover.Location = New System.Drawing.Point(237, 225)
        Me.txtRecover.Name = "txtRecover"
        Me.txtRecover.Size = New System.Drawing.Size(108, 15)
        Me.txtRecover.TabIndex = 4
        Me.txtRecover.TabStop = True
        Me.txtRecover.Text = "Recovery Password"
        Me.txtRecover.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(238, Byte), Integer))
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.Guna2Panel2)
        Me.Transition.SetDecoration(Me.pnlMain, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlMain.FillColor = System.Drawing.Color.White
        Me.pnlMain.Location = New System.Drawing.Point(37, 79)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(45, 46)
        Me.pnlMain.TabIndex = 69
        Me.pnlMain.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackgroundImage = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.layered_waves_haikei__2_
        Me.Guna2Panel2.Controls.Add(Me.picHero)
        Me.Transition.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(311, 46)
        Me.Guna2Panel2.TabIndex = 6
        '
        'picHero
        '
        Me.picHero.BackColor = System.Drawing.Color.Transparent
        Me.Transition.SetDecoration(Me.picHero, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.picHero.Image = Global.CG_MES___Feeder_Calibration.My.Resources.Resources.CG_GLOBAL_1wite
        Me.picHero.ImageRotate = 0!
        Me.picHero.Location = New System.Drawing.Point(51, 198)
        Me.picHero.Name = "picHero"
        Me.picHero.Size = New System.Drawing.Size(221, 97)
        Me.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHero.TabIndex = 1
        Me.picHero.TabStop = False
        '
        'Transition
        '
        Me.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Transition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Transition.DefaultAnimation = Animation1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 50
        Me.Guna2Elipse2.TargetControl = Me.pnlMain
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 893)
        Me.Controls.Add(Me.pnlRecoveryPassword)
        Me.Controls.Add(Me.pnlRecoveryCode)
        Me.Controls.Add(Me.pnlRecovery)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Transition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CG Global Profastex Manufacturing (MES) - Login"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pnlRecoveryPassword.ResumeLayout(False)
        Me.pnlRecoveryPassword.PerformLayout()
        Me.pnlRecoveryCode.ResumeLayout(False)
        Me.pnlRecoveryCode.PerformLayout()
        Me.pnlRecovery.ResumeLayout(False)
        Me.pnlRecovery.PerformLayout()
        Me.pnlLoading.ResumeLayout(False)
        Me.pnlLoading.PerformLayout()
        CType(Me.loadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlRecoveryPassword As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtNewPassword2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewPassword1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblVerRP As Label
    Friend WithEvents btnRPConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRPCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlRecoveryCode As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblVerRC As Label
    Friend WithEvents btnRCConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRCBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlRecovery As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCGID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblVerR As Label
    Friend WithEvents btnRConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlLoading As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loadingGif As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblVer As Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents label1 As Label
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRecover As LinkLabel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picHero As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Transition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
