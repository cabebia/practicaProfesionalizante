<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grb_login = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Ts_lbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Menus = New System.Windows.Forms.MenuStrip()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAcceso = New System.Windows.Forms.Button()
        Me.grb_login.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grb_login
        '
        Me.grb_login.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grb_login.Controls.Add(Me.PictureBox2)
        Me.grb_login.Controls.Add(Me.PictureBox1)
        Me.grb_login.Controls.Add(Me.btnAcceso)
        Me.grb_login.Controls.Add(Me.txtPassword)
        Me.grb_login.Controls.Add(Me.txtUser)
        Me.grb_login.Controls.Add(Me.Label2)
        Me.grb_login.Controls.Add(Me.Label1)
        Me.grb_login.Location = New System.Drawing.Point(93, 24)
        Me.grb_login.Name = "grb_login"
        Me.grb_login.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grb_login.Size = New System.Drawing.Size(306, 172)
        Me.grb_login.TabIndex = 0
        Me.grb_login.TabStop = False
        Me.grb_login.Text = "Iniciar sesion"
        Me.grb_login.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(123, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(123, 45)
        Me.txtUser.MaxLength = 25
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtUser.Size = New System.Drawing.Size(158, 20)
        Me.txtUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ts_lbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 302)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(489, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'Ts_lbl
        '
        Me.Ts_lbl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ts_lbl.Name = "Ts_lbl"
        Me.Ts_lbl.Size = New System.Drawing.Size(0, 17)
        '
        'Menus
        '
        Me.Menus.Location = New System.Drawing.Point(0, 0)
        Me.Menus.Name = "Menus"
        Me.Menus.Size = New System.Drawing.Size(489, 24)
        Me.Menus.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PP1.My.Resources.Resources.password
        Me.PictureBox2.Location = New System.Drawing.Point(25, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 20)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PP1.My.Resources.Resources.usuario_hombre
        Me.PictureBox1.Location = New System.Drawing.Point(25, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 25)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnAcceso
        '
        Me.btnAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAcceso.Image = Global.PP1.My.Resources.Resources.entrar
        Me.btnAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcceso.Location = New System.Drawing.Point(179, 121)
        Me.btnAcceso.Name = "btnAcceso"
        Me.btnAcceso.Size = New System.Drawing.Size(102, 35)
        Me.btnAcceso.TabIndex = 4
        Me.btnAcceso.Text = "ACCEDER"
        Me.btnAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceso.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(489, 324)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Menus)
        Me.Controls.Add(Me.grb_login)
        Me.Name = "frmLogin"
        Me.Text = "Sistema alumnado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grb_login.ResumeLayout(False)
        Me.grb_login.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_login As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAcceso As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Ts_lbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Menus As System.Windows.Forms.MenuStrip

End Class
