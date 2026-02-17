Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password=''; database=animales")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


    Private Sub MostrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarDatos.Click
        Call mostrarlosdatos()
    End Sub

    Private Sub mostrarlosdatos()
        Try
            sql = "select * from datos"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            Datos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Datos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datos.RowEnter
        Dim cellVal = Datos.Rows(e.RowIndex).Cells(0).Value
        If Datos.Rows(e.RowIndex).IsNewRow Then
            sql = String.Empty
            Return
        End If
        If cellVal Is Nothing OrElse Convert.IsDBNull(cellVal) Then
            sql = String.Empty ' o manejar según tu lógica
        Else
            sql = cellVal.ToString()
        End If
    End Sub
End Class
