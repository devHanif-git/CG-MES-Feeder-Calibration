<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoading))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.load = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please wait while fetching data..."
        '
        'load
        '
        Me.load.Image = CType(resources.GetObject("load.Image"), System.Drawing.Image)
        Me.load.Location = New System.Drawing.Point(27, 55)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(82, 76)
        Me.load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.load.TabIndex = 4
        Me.load.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(489, 30)
        Me.Guna2Panel1.TabIndex = 77
        '
        'FrmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 156)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.load)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        CType(Me.load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents load As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
