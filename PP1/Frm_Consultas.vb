Public Class Frm_Consultas
    Dim var_checkbox As Boolean = False
    Public consulta As String
    Public var_where As String
    Private query As String
    Private DT_query As New System.Data.DataTable

    Private Sub Frm_Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (Frm_Login.Height - Me.Height) / 2 ' añadido 5/5
        Me.Left = (Frm_Login.Width - Me.Width) / 2 ' añadido 5/5
        CargarQuery()
        CargarTreeView()
        txt_Buscar.Focus()
    End Sub

    Private Sub CargarQuery()
        Dim DT As New System.Data.DataTable
        DT = MySQL.Leer("SELECT str_sql FROM consultas WHERE transaccion='" & consulta & "'")
        If DT.Rows.Count > 0 Then
            query = DT.Rows(0)(0)
        End If
    End Sub
    Private Sub CargarTreeView()
        DT_query = MySQL.Leer(query)
        'TV_Consulta.Nodes.Add("ID")
        'TV_Consulta.Nodes(0).Nodes.Add("1")
        'TV_Consulta.Nodes(0).Nodes.Add("2")
        'TV_Consulta.Nodes(0).Nodes.Add("3")
        LV_Consulta.View = View.Details
        LV_Consulta.Columns.Add("PERFIL")
        LV_Consulta.Items.Add("asdasd")
        LV_Consulta.Items.Add("asdaSSsd")
        LV_Consulta.Items.Add("asdaDDsd")

    End Sub
End Class