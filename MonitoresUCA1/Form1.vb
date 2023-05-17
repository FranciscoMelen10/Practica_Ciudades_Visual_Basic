Imports System.Data.SqlClient

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



    Private Sub bt_Guardar_Click(sender As Object, e As EventArgs) Handles bt_Guardar.Click


    End Sub

    Private Sub bt_Agregar_Click(sender As Object, e As EventArgs) Handles bt_Agregar.Click
        Dim miTabla As DataTable = DataSetCiudades.Ciudades
        Dim i As Integer = DataSetCiudades.Ciudades.Count
        Dim cfila As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow
        i += 1

        Try
            nuevaFila = miTabla.NewRow()
            nuevaFila(0) = i
            nuevaFila(1) = "Nombre " & i
            nuevaFila(2) = True
            nuevaFila(3) = "Observaciones " & i
            cfila.Add(nuevaFila)
            bt_Ultimo.PerformClick()
            MostrarPosicion()
            txt_nombre.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
