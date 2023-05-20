<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ciudades
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
        Me.components = New System.ComponentModel.Container()
        Me.DsCiudades = New MonitoresUCA1.dsCiudades()
        Me.CiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesTableAdapter = New MonitoresUCA1.dsCiudadesTableAdapters.CiudadesTableAdapter()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.bt_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.bt_Vaciar = New System.Windows.Forms.Button()
        Me.bt_Eliminar = New System.Windows.Forms.Button()
        Me.bt_Editar = New System.Windows.Forms.Button()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orden_page = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.bt_Ultimo = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.bt_primero = New System.Windows.Forms.Button()
        Me.bt_refrescar = New System.Windows.Forms.Button()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCiudades
        '
        Me.DsCiudades.DataSetName = "dsCiudades"
        Me.DsCiudades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadesBindingSource
        '
        Me.CiudadesBindingSource.DataMember = "Ciudades"
        Me.CiudadesBindingSource.DataSource = Me.DsCiudades
        '
        'CiudadesTableAdapter
        '
        Me.CiudadesTableAdapter.ClearBeforeFill = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Location = New System.Drawing.Point(609, 72)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Agregar.TabIndex = 40
        Me.bt_Agregar.Text = "Añadir"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'bt_Buscar
        '
        Me.bt_Buscar.Location = New System.Drawing.Point(651, 338)
        Me.bt_Buscar.Name = "bt_Buscar"
        Me.bt_Buscar.Size = New System.Drawing.Size(67, 25)
        Me.bt_Buscar.TabIndex = 39
        Me.bt_Buscar.Text = "Buscar"
        Me.bt_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(631, 312)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(112, 20)
        Me.txt_buscar.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(557, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Buscar:"
        '
        'txt_id
        '
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "id", True))
        Me.txt_id.Location = New System.Drawing.Point(192, 124)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(324, 20)
        Me.txt_id.TabIndex = 36
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "nombre", True))
        Me.txt_nombre.Location = New System.Drawing.Point(192, 172)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(324, 20)
        Me.txt_nombre.TabIndex = 35
        '
        'txt_estado
        '
        Me.txt_estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "estado", True))
        Me.txt_estado.Location = New System.Drawing.Point(192, 226)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(324, 20)
        Me.txt_estado.TabIndex = 34
        '
        'txt_observaciones
        '
        Me.txt_observaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "observaciones", True))
        Me.txt_observaciones.Location = New System.Drawing.Point(192, 285)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(324, 73)
        Me.txt_observaciones.TabIndex = 33
        Me.txt_observaciones.Text = ""
        '
        'bt_Vaciar
        '
        Me.bt_Vaciar.Location = New System.Drawing.Point(609, 268)
        Me.bt_Vaciar.Name = "bt_Vaciar"
        Me.bt_Vaciar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Vaciar.TabIndex = 32
        Me.bt_Vaciar.Text = "Vaciar"
        Me.bt_Vaciar.UseVisualStyleBackColor = True
        '
        'bt_Eliminar
        '
        Me.bt_Eliminar.Location = New System.Drawing.Point(609, 218)
        Me.bt_Eliminar.Name = "bt_Eliminar"
        Me.bt_Eliminar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Eliminar.TabIndex = 31
        Me.bt_Eliminar.Text = "Eliminar"
        Me.bt_Eliminar.UseVisualStyleBackColor = True
        '
        'bt_Editar
        '
        Me.bt_Editar.Location = New System.Drawing.Point(609, 164)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Editar.TabIndex = 30
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseVisualStyleBackColor = True
        '
        'bt_Guardar
        '
        Me.bt_Guardar.Location = New System.Drawing.Point(609, 114)
        Me.bt_Guardar.Name = "bt_Guardar"
        Me.bt_Guardar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Guardar.TabIndex = 29
        Me.bt_Guardar.Text = "Guardar"
        Me.bt_Guardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label5.Location = New System.Drawing.Point(273, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 31)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Listado de ciudades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(60, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Observaciones:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(60, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(60, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(60, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID:"
        '
        'orden_page
        '
        Me.orden_page.AutoSize = True
        Me.orden_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.orden_page.Location = New System.Drawing.Point(415, 441)
        Me.orden_page.Name = "orden_page"
        Me.orden_page.Size = New System.Drawing.Size(16, 17)
        Me.orden_page.TabIndex = 46
        Me.orden_page.Text = "1"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.label7.Location = New System.Drawing.Point(353, 441)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(56, 17)
        Me.label7.TabIndex = 45
        Me.label7.Text = "Página:"
        '
        'bt_Ultimo
        '
        Me.bt_Ultimo.Location = New System.Drawing.Point(659, 435)
        Me.bt_Ultimo.Name = "bt_Ultimo"
        Me.bt_Ultimo.Size = New System.Drawing.Size(109, 23)
        Me.bt_Ultimo.TabIndex = 44
        Me.bt_Ultimo.Text = "Ultimo"
        Me.bt_Ultimo.UseVisualStyleBackColor = True
        '
        'bt_Siguiente
        '
        Me.bt_Siguiente.Location = New System.Drawing.Point(502, 435)
        Me.bt_Siguiente.Name = "bt_Siguiente"
        Me.bt_Siguiente.Size = New System.Drawing.Size(109, 23)
        Me.bt_Siguiente.TabIndex = 43
        Me.bt_Siguiente.Text = "Siguiente"
        Me.bt_Siguiente.UseVisualStyleBackColor = True
        '
        'bt_Anterior
        '
        Me.bt_Anterior.Location = New System.Drawing.Point(203, 435)
        Me.bt_Anterior.Name = "bt_Anterior"
        Me.bt_Anterior.Size = New System.Drawing.Size(109, 23)
        Me.bt_Anterior.TabIndex = 42
        Me.bt_Anterior.Text = "Anterior"
        Me.bt_Anterior.UseVisualStyleBackColor = True
        '
        'bt_primero
        '
        Me.bt_primero.Location = New System.Drawing.Point(41, 435)
        Me.bt_primero.Name = "bt_primero"
        Me.bt_primero.Size = New System.Drawing.Size(109, 23)
        Me.bt_primero.TabIndex = 41
        Me.bt_primero.Text = "Primero"
        Me.bt_primero.UseVisualStyleBackColor = True
        '
        'bt_refrescar
        '
        Me.bt_refrescar.Location = New System.Drawing.Point(641, 379)
        Me.bt_refrescar.Name = "bt_refrescar"
        Me.bt_refrescar.Size = New System.Drawing.Size(87, 23)
        Me.bt_refrescar.TabIndex = 47
        Me.bt_refrescar.Text = "Refrescar tabla"
        Me.bt_refrescar.UseVisualStyleBackColor = True
        '
        'Frm_Ciudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.bt_refrescar)
        Me.Controls.Add(Me.orden_page)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.bt_Ultimo)
        Me.Controls.Add(Me.bt_Siguiente)
        Me.Controls.Add(Me.bt_Anterior)
        Me.Controls.Add(Me.bt_primero)
        Me.Controls.Add(Me.bt_Agregar)
        Me.Controls.Add(Me.bt_Buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.bt_Vaciar)
        Me.Controls.Add(Me.bt_Eliminar)
        Me.Controls.Add(Me.bt_Editar)
        Me.Controls.Add(Me.bt_Guardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Ciudades"
        Me.Text = "Tabla de Ciudades de la Base de datos DBMonitoresUCA"
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCiudades As dsCiudades
    Friend WithEvents CiudadesBindingSource As BindingSource
    Friend WithEvents CiudadesTableAdapter As dsCiudadesTableAdapters.CiudadesTableAdapter
    Friend WithEvents bt_Agregar As Button
    Friend WithEvents bt_Buscar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents txt_observaciones As RichTextBox
    Friend WithEvents bt_Vaciar As Button
    Friend WithEvents bt_Eliminar As Button
    Friend WithEvents bt_Editar As Button
    Friend WithEvents bt_Guardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents orden_page As Label
    Friend WithEvents label7 As Label
    Friend WithEvents bt_Ultimo As Button
    Friend WithEvents bt_Siguiente As Button
    Friend WithEvents bt_Anterior As Button
    Friend WithEvents bt_primero As Button
    Friend WithEvents bt_refrescar As Button
End Class
