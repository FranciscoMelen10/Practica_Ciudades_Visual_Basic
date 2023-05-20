Imports System.Data.SqlClient
Imports System.Threading
'Francisco De Jesus Melendez Simplina'

Public Class Frm_Ciudades
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCiudades.Ciudades' Puede moverla o quitarla según sea necesario.
        Me.CiudadesTableAdapter.Fill(Me.DsCiudades.Ciudades)



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
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (DsCiudades.HasChanges()) Then
                    Me.CiudadesBindingSource.EndEdit()
                    Me.CiudadesTableAdapter.Update(Me.DsCiudades.Ciudades)
                    MessageBox.Show("Base de datos actualizada")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub bt_Agregar_Click(sender As Object, e As EventArgs) Handles bt_Agregar.Click
        Dim miTabla As DataTable = DsCiudades.Ciudades
        Dim i As Integer = DsCiudades.Ciudades.Count
        Dim cfila As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow

        Try
            nuevaFila = miTabla.NewRow()
            nuevaFila(1) = "Nombre " & i + 1
            nuevaFila(2) = True
            nuevaFila(3) = "Observaciones " & i + 1
            cfila.Add(nuevaFila)
            bt_Ultimo.PerformClick()
            MostrarPosicion()
            txt_nombre.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_Editar_Click(sender As Object, e As EventArgs) Handles bt_Editar.Click

    End Sub

    Private Sub bt_Eliminar_Click(sender As Object, e As EventArgs) Handles bt_Eliminar.Click
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("Desea borrar este registro?" & NL, "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = CiudadesBindingSource.Current
            vistaFilaActual.Row.Delete()
            bt_primero.PerformClick()
        End If
    End Sub

    Private Sub bt_Vaciar_Click(sender As Object, e As EventArgs) Handles bt_Vaciar.Click
        Me.txt_id.Clear()
        Me.txt_nombre.Clear()
        Me.txt_observaciones.Clear()
        Me.txt_estado.Clear()
        Me.txt_buscar.Clear()
    End Sub

    Private Sub bt_Buscar_Click(sender As Object, e As EventArgs) Handles bt_Buscar.Click
        Dim miTabla As DataTable = DsCiudades.Ciudades
        Dim cFilas As DataRowCollection = miTabla.Rows
        Dim filaBuscada() As DataRow
        Dim NL As String = Environment.NewLine
        Dim criterio As String = "Nombre Like '*" & txt_buscar.Text & "*'"

        filaBuscada = miTabla.Select(criterio)

        If (filaBuscada.GetUpperBound(0) < 0) Then
            MessageBox.Show("No se encontraron registros coincidentes", "Buscar")
            Exit Sub
        End If
        Dim i, j As Integer
        For i = 0 To filaBuscada.GetUpperBound(0)
            If (MessageBox.Show("Este es el nombre buscado?" & NL & filaBuscada(i)(1) & NL, "Buscar",
                MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                CiudadesBindingSource.Position = cFilas.IndexOf(filaBuscada(i))
                MostrarPosicion()
                Exit For
            End If
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_refrescar.Click
        Me.CiudadesTableAdapter.Fill(Me.DsCiudades.Ciudades)
    End Sub
End Class
