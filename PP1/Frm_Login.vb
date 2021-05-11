Imports System.Deployment.Application
Public Class Frm_Login
    Dim loginActivate = False ' cambiar a true y quitar LoginRapido() una vez realizado el cambio interno
    Dim intentosLogin As Integer = 0

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'txtUser.Focus()
        LoginRapido("administrador") ' proporciona un acceso rapido al sistema como administrador

        If loginActivate = True Then

            grb_login.Top = (Me.Height - grb_login.Height) / 2
            grb_login.Left = (Me.Width - grb_login.Width) / 2
            grb_login.Visible = True
            loginActivate = False

        End If

    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Autenticacion()
        End If
    End Sub

    Private Sub btnAcceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceso.Click
        Autenticacion()
    End Sub

    Private Sub Menus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menus.Click
        Try

            If sender.Tag <> "" Then ' Solo los menus de lvl 0 darán False

                Dim vector_param() As String = Split(sender.Tag, ";") ' Variable para obtener parámetro de un menu
                Dim strFormName As String = vector_param(0)

                If strFormName = "" Then ' Solo los menus de logout o salida dan verdadero

                    Select Case vector_param(1)

                        Case "logout"

                            StatusStrip1.Visible = False
                            Menus.Items.Clear()
                            Menus.Visible = False
                            grb_login.Visible = True
                            intentosLogin = 0
                            txtUser.Text = ""
                            txtPassword.Text = ""
                            txtUser.Focus()
                            Exit Sub

                        Case "exit"

                            Me.Close()
                            Exit Sub

                    End Select

                End If

                Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

                'recibo nombre del form y genero instancia
                strFormName = "PP1." & strFormName

                Dim frm As Form = CType(asm.CreateInstance(strFormName), Form)
                frm.Tag = sender.Tag
                frm.ShowDialog()
                Exit Sub

            End If

        Catch err As System.NullReferenceException 'ArgumentNullException

            Dim vector_param() As String = Split(sender.Tag, ";") ' añadido 5/5
            Dim nombreForm As String = vector_param(0) ' añadido 5/5

            If nombreForm <> "" Then ' Los menus de nivel 1 no tienen asociado un formulario

                MsgBox("No Existe el Formulario del Sistema " & nombreForm, MsgBoxStyle.Critical, "Error de Sistema")
                Exit Sub

            End If

        End Try

    End Sub

    Private Sub Autenticacion()

        If txtUser.Text <> "" And txtPassword.Text <> "" Then

            intentosLogin += 1
            Dim DT As New System.Data.DataTable

            DT = MySQL.Leer("SELECT usuarios.apellido, usuarios.nombres, perfiles.perfil, usuarios.id_perfil FROM usuarios, perfiles WHERE usuarios.id_perfil = perfiles.id_perfil AND usuario = '" & txtUser.Text & "' AND clave = '" & txtPassword.Text & "'")

            If DT.Rows.Count > 0 Then

                Try

                    Ts_lbl.Text = "Usuario: " & DT.Rows(0)("apellido") & ", " & DT.Rows(0)("nombres") & " - Perfil: " & DT.Rows(0)("perfil") & " - Version : " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString

                Catch ex As Exception

                    Ts_lbl.Text = "Usuario: " & DT.Rows(0)("apellido") & ", " & DT.Rows(0)("nombres") & " - Perfil: " & DT.Rows(0)("perfil") & " - Version : Debug 1.0.0.0"

                End Try

                MsgBox("Inicio de sesión exitoso. Ingresando al sistema", MsgBoxStyle.OkOnly, "Correcto")
                grb_login.Visible = False
                StatusStrip1.Visible = True
                Cargar_menues(DT.Rows(0)("id_perfil"))

            Else

                If intentosLogin >= 3 Then

                    MsgBox("Alcanzaste los intentos máximos permitidos. Cerrando sesión", MsgBoxStyle.Critical, "Error de inicio de sesion")
                    Me.Close()
                    Exit Sub

                Else

                    MsgBox("Usuario y/o contraseña erróneos. Te quedan " & 3 - intentosLogin & " intentos.", MsgBoxStyle.Information, "Advertencia")

                End If

                txtUser.Text = ""
                txtPassword.Text = ""
                txtUser.Focus()

            End If

        Else

            MsgBox("Los campos no deben estar vacios", MsgBoxStyle.Information)

            If txtUser.Text = "" Then

                txtUser.Focus()

            Else

                txtPassword.Focus()

            End If

        End If

    End Sub

    Private Sub Cargar_menues(ByVal id_perfil As Integer)
        Dim DT As New System.Data.DataTable
        DT = MySQL.Leer("SELECT * from menus WHERE id_perfil >= '" & id_perfil & "' AND menu_activo = 'S' ORDER BY nivel, texto_menu")

        If DT.Rows.Count > 0 Then

            For i As Integer = 0 To DT.Rows.Count - 1

                Select Case DT.Rows(i)("nivel")

                    Case 0

                        Dim item As New ToolStripMenuItem(DT.Rows(i)("texto_menu").ToString)

                        item.Name = DT.Rows(i).Item("nombre_menu") ' nombre lógico
                        item.Text = DT.Rows(i)("texto_menu").ToString ' texto del menu que aparece en pantalla
                        item.Tag = DT.Rows(i).Item("formulario") & ";" & DT.Rows(i).Item("parametro") ' tag lógico
                        Menus.Items.Add(item)

                    Case 1

                        Dim level_sup As String
                        Dim levelupmenuitem As ToolStripMenuItem
                        Dim item As New ToolStripMenuItem

                        'Creamos los datos propios del sub menu
                        item.Name = DT.Rows(i).Item("nombre_menu")
                        item.Tag = DT.Rows(i).Item("formulario") & ";" & DT.Rows(i).Item("parametro")
                        item.Text = DT.Rows(i)("texto_menu").ToString

                        'Buscamos su padre y lo añadimos
                        level_sup = DT.Rows(i).Item("pertenece_menu")
                        levelupmenuitem = Menus.Items.Find(level_sup, False)(0)
                        levelupmenuitem.DropDown.Items.Add(item)

                        AddHandler item.Click, AddressOf Menus_Click

                    Case 2, 3

                        Dim level_sup As String
                        Dim levelupmenuitem As ToolStripMenuItem
                        Dim item As New ToolStripMenuItem

                        'Creamos los datos propios del sub menu
                        item.Name = DT.Rows(i).Item("nombre_menu")
                        item.Tag = DT.Rows(i).Item("formulario") & ";" & DT.Rows(i).Item("parametro")
                        item.Text = DT.Rows(i)("texto_menu").ToString

                        'Buscamos su padre y lo añadimos
                        level_sup = DT.Rows(i).Item("pertenece_menu")
                        levelupmenuitem = Menus.Items.Find(level_sup, True)(0)
                        levelupmenuitem.DropDown.Items.Add(item)

                        AddHandler item.Click, AddressOf Menus_Click

                End Select

            Next i

        End If

        Menus.Visible = True

    End Sub

    Private Sub LoginRapido(ByVal perfil As String)

        Dim DT As New System.Data.DataTable
        Dim usr As String = ""

        If perfil = "administrador" Then

            usr = "adm"

        ElseIf perfil = "gerente" Then

            usr = "grnt"

        ElseIf perfil = "usuario" Then

            usr = "user"

        End If

        DT = MySQL.Leer("SELECT usuarios.apellido, usuarios.nombres, perfiles.perfil, usuarios.id_perfil FROM usuarios, perfiles WHERE usuarios.id_perfil = perfiles.id_perfil AND usuario = '" & usr & "' AND clave = 'test'")

        Try

            Ts_lbl.Text = "Usuario: " & DT.Rows(0)("apellido") & ", " & DT.Rows(0)("nombres") & " - Perfil: " & DT.Rows(0)("perfil") & " - Version : " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString

        Catch ex As Exception

            Ts_lbl.Text = "Usuario: " & DT.Rows(0)("apellido") & ", " & DT.Rows(0)("nombres") & " - Perfil: " & DT.Rows(0)("perfil") & " - Version : Debug 1.0.0.0"

        End Try

        StatusStrip1.Visible = True
        Cargar_menues(DT.Rows(0)("id_perfil"))

    End Sub

End Class

