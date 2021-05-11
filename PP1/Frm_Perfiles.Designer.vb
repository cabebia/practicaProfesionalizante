<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Perfiles
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
        Me.gb_frmAMB = New System.Windows.Forms.GroupBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnConsultar_frmAMB = New System.Windows.Forms.Button()
        Me.btnIgnorar_frmAMB = New System.Windows.Forms.Button()
        Me.btnEliminar_frmAMB = New System.Windows.Forms.Button()
        Me.btnModificar_frmAMB = New System.Windows.Forms.Button()
        Me.btnAgregar_frmAMB = New System.Windows.Forms.Button()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gb_frmAMB.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_frmAMB
        '
        Me.gb_frmAMB.Controls.Add(Me.lblInfo)
        Me.gb_frmAMB.Controls.Add(Me.btnConsultar_frmAMB)
        Me.gb_frmAMB.Controls.Add(Me.btnIgnorar_frmAMB)
        Me.gb_frmAMB.Controls.Add(Me.btnEliminar_frmAMB)
        Me.gb_frmAMB.Controls.Add(Me.btnModificar_frmAMB)
        Me.gb_frmAMB.Controls.Add(Me.btnAgregar_frmAMB)
        Me.gb_frmAMB.Controls.Add(Me.txtPerfil)
        Me.gb_frmAMB.Controls.Add(Me.txtID)
        Me.gb_frmAMB.Controls.Add(Me.lblPerfil)
        Me.gb_frmAMB.Controls.Add(Me.lblID)
        Me.gb_frmAMB.Location = New System.Drawing.Point(26, 12)
        Me.gb_frmAMB.Name = "gb_frmAMB"
        Me.gb_frmAMB.Size = New System.Drawing.Size(472, 167)
        Me.gb_frmAMB.TabIndex = 0
        Me.gb_frmAMB.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(177, 24)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 10
        '
        'btnConsultar_frmAMB
        '
        Me.btnConsultar_frmAMB.Location = New System.Drawing.Point(131, 13)
        Me.btnConsultar_frmAMB.Name = "btnConsultar_frmAMB"
        Me.btnConsultar_frmAMB.Size = New System.Drawing.Size(40, 35)
        Me.btnConsultar_frmAMB.TabIndex = 9
        Me.btnConsultar_frmAMB.Text = "..."
        Me.btnConsultar_frmAMB.UseVisualStyleBackColor = True
        '
        'btnIgnorar_frmAMB
        '
        Me.btnIgnorar_frmAMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnIgnorar_frmAMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIgnorar_frmAMB.Location = New System.Drawing.Point(347, 114)
        Me.btnIgnorar_frmAMB.Name = "btnIgnorar_frmAMB"
        Me.btnIgnorar_frmAMB.Size = New System.Drawing.Size(102, 35)
        Me.btnIgnorar_frmAMB.TabIndex = 8
        Me.btnIgnorar_frmAMB.Text = "IGNORAR"
        Me.btnIgnorar_frmAMB.UseVisualStyleBackColor = True
        '
        'btnEliminar_frmAMB
        '
        Me.btnEliminar_frmAMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar_frmAMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar_frmAMB.Location = New System.Drawing.Point(239, 114)
        Me.btnEliminar_frmAMB.Name = "btnEliminar_frmAMB"
        Me.btnEliminar_frmAMB.Size = New System.Drawing.Size(102, 35)
        Me.btnEliminar_frmAMB.TabIndex = 7
        Me.btnEliminar_frmAMB.Text = "ELIMINAR"
        Me.btnEliminar_frmAMB.UseVisualStyleBackColor = True
        '
        'btnModificar_frmAMB
        '
        Me.btnModificar_frmAMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificar_frmAMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_frmAMB.Location = New System.Drawing.Point(131, 114)
        Me.btnModificar_frmAMB.Name = "btnModificar_frmAMB"
        Me.btnModificar_frmAMB.Size = New System.Drawing.Size(102, 35)
        Me.btnModificar_frmAMB.TabIndex = 6
        Me.btnModificar_frmAMB.Text = "MODIFICAR"
        Me.btnModificar_frmAMB.UseVisualStyleBackColor = True
        '
        'btnAgregar_frmAMB
        '
        Me.btnAgregar_frmAMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar_frmAMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_frmAMB.Location = New System.Drawing.Point(23, 114)
        Me.btnAgregar_frmAMB.Name = "btnAgregar_frmAMB"
        Me.btnAgregar_frmAMB.Size = New System.Drawing.Size(102, 35)
        Me.btnAgregar_frmAMB.TabIndex = 5
        Me.btnAgregar_frmAMB.Text = "AGREGAR"
        Me.btnAgregar_frmAMB.UseVisualStyleBackColor = True
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(56, 79)
        Me.txtPerfil.MaxLength = 30
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(285, 20)
        Me.txtPerfil.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(56, 21)
        Me.txtID.MaxLength = 12
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(69, 20)
        Me.txtID.TabIndex = 2
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Location = New System.Drawing.Point(20, 82)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(30, 13)
        Me.lblPerfil.TabIndex = 1
        Me.lblPerfil.Text = "Perfil"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(29, 24)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        '
        'Frm_Perfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 195)
        Me.Controls.Add(Me.gb_frmAMB)
        Me.Name = "Frm_Perfiles"
        Me.Text = "Perfiles"
        Me.gb_frmAMB.ResumeLayout(False)
        Me.gb_frmAMB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_frmAMB As System.Windows.Forms.GroupBox
    Friend WithEvents txtPerfil As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnConsultar_frmAMB As System.Windows.Forms.Button
    Friend WithEvents btnIgnorar_frmAMB As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_frmAMB As System.Windows.Forms.Button
    Friend WithEvents btnModificar_frmAMB As System.Windows.Forms.Button
    Friend WithEvents btnAgregar_frmAMB As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
End Class
