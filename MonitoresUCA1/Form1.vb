Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCiudades.Ciudades' table. You can move, or remove it, as needed.
        Me.CiudadesTableAdapter.Fill(Me.DataSetCiudades.Ciudades)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub orden_page_Click(sender As Object, e As EventArgs) Handles orden_page.Click


    End Sub

    Public Sub MostrarPosicion()
        Dim total As Integer = CiudadesBindingSource.Count
        Dim iPos As Integer

        If total = 0 Then
            orden_page.Text = "0"
        End If
        iPos = CiudadesBindingSource.Position + 1
        orden_page.Text = iPos


    End Sub

    Private Sub bt_Siguiente_Click(sender As Object, e As EventArgs) Handles bt_Siguiente.Click
        CiudadesBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub bt_Anterior_Click(sender As Object, e As EventArgs) Handles bt_Anterior.Click
        CiudadesBindingSource.Position -= 1
        MostrarPosicion()
    End Sub

    Private Sub bt_primero_Click(sender As Object, e As EventArgs) Handles bt_primero.Click
        CiudadesBindingSource.Position = 0
        MostrarPosicion()
    End Sub

    Private Sub bt_Ultimo_Click(sender As Object, e As EventArgs) Handles bt_Ultimo.Click
        CiudadesBindingSource.Position = CiudadesBindingSource.Count
        MostrarPosicion()
    End Sub
End Class
