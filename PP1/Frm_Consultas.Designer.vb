<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Imprimir = New System.Windows.Forms.Button()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.cbo_Filtro = New System.Windows.Forms.ComboBox()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.TV_Consulta = New System.Windows.Forms.TreeView()
        Me.LV_Consulta = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(694, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Location = New System.Drawing.Point(12, 3)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(28, 19)
        Me.btn_Imprimir.TabIndex = 1
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(46, 6)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(32, 13)
        Me.lblFiltro.TabIndex = 2
        Me.lblFiltro.Text = "Filtro:"
        '
        'cbo_Filtro
        '
        Me.cbo_Filtro.FormattingEnabled = True
        Me.cbo_Filtro.Location = New System.Drawing.Point(84, 3)
        Me.cbo_Filtro.Name = "cbo_Filtro"
        Me.cbo_Filtro.Size = New System.Drawing.Size(134, 21)
        Me.cbo_Filtro.TabIndex = 3
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(242, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 4
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(291, 4)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(391, 20)
        Me.txt_Buscar.TabIndex = 5
        '
        'TV_Consulta
        '
        Me.TV_Consulta.Location = New System.Drawing.Point(12, 30)
        Me.TV_Consulta.Name = "TV_Consulta"
        Me.TV_Consulta.Size = New System.Drawing.Size(670, 322)
        Me.TV_Consulta.TabIndex = 6
        '
        'LV_Consulta
        '
        Me.LV_Consulta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LV_Consulta.GridLines = True
        Me.LV_Consulta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV_Consulta.Location = New System.Drawing.Point(12, 30)
        Me.LV_Consulta.Name = "LV_Consulta"
        Me.LV_Consulta.Size = New System.Drawing.Size(670, 322)
        Me.LV_Consulta.TabIndex = 7
        Me.LV_Consulta.UseCompatibleStateImageBehavior = False
        '
        'Frm_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 358)
        Me.Controls.Add(Me.LV_Consulta)
        Me.Controls.Add(Me.TV_Consulta)
        Me.Controls.Add(Me.txt_Buscar)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.cbo_Filtro)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.btn_Imprimir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_Consultas"
        Me.Text = "Frm_Consultas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents cbo_Filtro As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents TV_Consulta As System.Windows.Forms.TreeView
    Friend WithEvents LV_Consulta As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
