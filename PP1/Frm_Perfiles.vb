Public Class Frm_Perfiles
    ' Testeo para git
    Private Sub Frm_Perfiles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Top = (Frm_Login.Height - Me.Height) / 2 ' añadido 5/5
        Me.Left = (Frm_Login.Width - Me.Width) / 2 ' añadido 5/5
        txtID.Focus()

    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress '  añadido 6/5

        If e.KeyChar = Chr(13) Then

            Buscar("perfil")

            txtPerfil.Focus()

        End If

    End Sub

    Private Sub txtPerfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPerfil.KeyPress 'añadido 6/5

        e.KeyChar = UCase(e.KeyChar)

        If e.KeyChar = Chr(13) Then

            Buscar("id")

            txtID.Focus()

        End If

    End Sub

    Private Sub Buscar(ByVal param As String) 'añadido 5/5 - modificado 6/5

        Dim DT As New System.Data.DataTable

        If param = "perfil" Then

            DT = MySQL.Leer("SELECT perfil FROM perfiles WHERE perfiles.id_perfil = '" & txtID.Text & "'")

            If DT.Rows.Count > 0 Then

                txtPerfil.Text = DT.Rows(0)("perfil")

            Else

                txtPerfil.Text = "INEXISTENTE"

            End If

        Else

            If param = "id" Then

                DT = MySQL.Leer("SELECT id_perfil FROM perfiles WHERE perfiles.perfil = '" & txtPerfil.Text & "'")

                If DT.Rows.Count > 0 Then

                    txtID.Text = DT.Rows(0)("id_perfil")

                Else

                    txtID.Text = "INEXISTENTE"

                End If

            End If

        End If

    End Sub

    Private Sub btnAgregar_frmAMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_frmAMB.Click ' añadido 6/5
        If txtID.Text = "" And txtPerfil.Text <> "" Then

            If MySQL.Query("INSERT INTO perfiles (pearfil) VALUES ('" & txtPerfil.Text & "')") <> "0" Then
                MsgBox("Perfil añadido correctamente") 'añadido 6/5
            Else
                MsgBox("Error en la carga", MsgBoxStyle.Critical)
            End If
        Else

            If txtID.Text <> "" Then

                lblInfo.Text = "<Error. El campo ID debe estar vacio (clave autonumerica)>"
                lblInfo.Focus()

            ElseIf txtPerfil.Text = "" Then

                lblInfo.Text = "<Error. El campo PERFIL no debe estar vacio>"
                lblInfo.Focus()

            End If

        End If

    End Sub

    Private Sub btnModificar_frmAMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_frmAMB.Click 'añadido 6/5

        If txtID.Text <> "" And txtPerfil.Text <> "" Then

            If MySQL.Query("UPDATE perfiles set perfil='" & txtPerfil.Text & "' where id_perfil=" & txtID.Text & "") <> "0" Then

                MsgBox("Perfil modificado correctamente") 'añadido 10/5

            Else

                MsgBox("Error en la sobreescritura", MsgBoxStyle.Critical)

            End If

        Else

            lblInfo.Text = "<Error. Ningun campo puede estar vacío>"
            lblInfo.Focus()

        End If

    End Sub

    Private Sub btnEliminar_frmAMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_frmAMB.Click

        If txtID.Text <> "" And txtPerfil.Text <> "" Then

            If MySQL.Query("DELETE from perfiles where id_perfil=" & txtID.Text & "") <> "0" Then

                MsgBox("Perfil eliminado correctamente") 'añadido 6/5

            Else

                MsgBox("Error. No se ha podido eliminar el perfil", MsgBoxStyle.Critical)

            End If

        Else

            lblInfo.Text = "<Error. Ningun campo puede estar vacío>"
            lblInfo.Focus()

        End If

    End Sub

    Private Sub btnIgnorar_frmAMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnorar_frmAMB.Click
        txtID.Text = ""
        txtPerfil.Text = ""
    End Sub

    Private Sub lblInfo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInfo.LostFocus
        lblInfo.Text = ""
    End Sub

    Private Sub btnConsultar_frmAMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar_frmAMB.Click
        Frm_Consultas.consulta = "CONSULTA_PERFILES"
        Frm_Consultas.Show()
    End Sub

End Class