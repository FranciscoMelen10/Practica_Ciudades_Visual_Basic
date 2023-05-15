<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.bt_Editar = New System.Windows.Forms.Button()
        Me.bt_Eliminar = New System.Windows.Forms.Button()
        Me.bt_Vaciar = New System.Windows.Forms.Button()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.bt_primero = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Ultimo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.bt_Buscar = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.orden_page = New System.Windows.Forms.Label()
        Me.DataSetCiudades = New MonitoresUCA1.DataSetCiudades()
        Me.CiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesTableAdapter = New MonitoresUCA1.DataSetCiudadesTableAdapters.CiudadesTableAdapter()
        Me.CiudadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSetCiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSetCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(84, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(84, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(84, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Observaciones:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(84, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label5.Location = New System.Drawing.Point(302, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Listado de ciudades"
        '
        'bt_Guardar
        '
        Me.bt_Guardar.Location = New System.Drawing.Point(614, 81)
        Me.bt_Guardar.Name = "bt_Guardar"
        Me.bt_Guardar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Guardar.TabIndex = 5
        Me.bt_Guardar.Text = "Guardar"
        Me.bt_Guardar.UseVisualStyleBackColor = True
        '
        'bt_Editar
        '
        Me.bt_Editar.Location = New System.Drawing.Point(614, 131)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Editar.TabIndex = 6
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseVisualStyleBackColor = True
        '
        'bt_Eliminar
        '
        Me.bt_Eliminar.Location = New System.Drawing.Point(614, 185)
        Me.bt_Eliminar.Name = "bt_Eliminar"
        Me.bt_Eliminar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Eliminar.TabIndex = 7
        Me.bt_Eliminar.Text = "Eliminar"
        Me.bt_Eliminar.UseVisualStyleBackColor = True
        '
        'bt_Vaciar
        '
        Me.bt_Vaciar.Location = New System.Drawing.Point(614, 235)
        Me.bt_Vaciar.Name = "bt_Vaciar"
        Me.bt_Vaciar.Size = New System.Drawing.Size(150, 25)
        Me.bt_Vaciar.TabIndex = 8
        Me.bt_Vaciar.Text = "Vaciar"
        Me.bt_Vaciar.UseVisualStyleBackColor = True
        '
        'txt_observaciones
        '
        Me.txt_observaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "observaciones", True))
        Me.txt_observaciones.Location = New System.Drawing.Point(216, 242)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(324, 73)
        Me.txt_observaciones.TabIndex = 9
        Me.txt_observaciones.Text = ""
        '
        'txt_estado
        '
        Me.txt_estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "estado", True))
        Me.txt_estado.Location = New System.Drawing.Point(216, 183)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(324, 20)
        Me.txt_estado.TabIndex = 10
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "nombre", True))
        Me.txt_nombre.Location = New System.Drawing.Point(216, 129)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(324, 20)
        Me.txt_nombre.TabIndex = 11
        '
        'txt_id
        '
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadesBindingSource, "id", True))
        Me.txt_id.Location = New System.Drawing.Point(216, 81)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(324, 20)
        Me.txt_id.TabIndex = 12
        '
        'bt_primero
        '
        Me.bt_primero.Location = New System.Drawing.Point(29, 388)
        Me.bt_primero.Name = "bt_primero"
        Me.bt_primero.Size = New System.Drawing.Size(117, 33)
        Me.bt_primero.TabIndex = 13
        Me.bt_primero.Text = "Primero"
        Me.bt_primero.UseVisualStyleBackColor = True
        '
        'bt_Anterior
        '
        Me.bt_Anterior.Location = New System.Drawing.Point(191, 388)
        Me.bt_Anterior.Name = "bt_Anterior"
        Me.bt_Anterior.Size = New System.Drawing.Size(117, 33)
        Me.bt_Anterior.TabIndex = 14
        Me.bt_Anterior.Text = "Anterior"
        Me.bt_Anterior.UseVisualStyleBackColor = True
        '
        'bt_Siguiente
        '
        Me.bt_Siguiente.Location = New System.Drawing.Point(490, 388)
        Me.bt_Siguiente.Name = "bt_Siguiente"
        Me.bt_Siguiente.Size = New System.Drawing.Size(117, 33)
        Me.bt_Siguiente.TabIndex = 15
        Me.bt_Siguiente.Text = "Siguiente"
        Me.bt_Siguiente.UseVisualStyleBackColor = True
        '
        'bt_Ultimo
        '
        Me.bt_Ultimo.Location = New System.Drawing.Point(647, 388)
        Me.bt_Ultimo.Name = "bt_Ultimo"
        Me.bt_Ultimo.Size = New System.Drawing.Size(117, 33)
        Me.bt_Ultimo.TabIndex = 16
        Me.bt_Ultimo.Text = "Ultimo"
        Me.bt_Ultimo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(567, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(641, 295)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(112, 20)
        Me.txt_buscar.TabIndex = 18
        '
        'bt_Buscar
        '
        Me.bt_Buscar.Location = New System.Drawing.Point(666, 321)
        Me.bt_Buscar.Name = "bt_Buscar"
        Me.bt_Buscar.Size = New System.Drawing.Size(67, 25)
        Me.bt_Buscar.TabIndex = 19
        Me.bt_Buscar.Text = "Buscar"
        Me.bt_Buscar.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.label7.Location = New System.Drawing.Point(347, 393)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(56, 17)
        Me.label7.TabIndex = 20
        Me.label7.Text = "Página:"
        '
        'orden_page
        '
        Me.orden_page.AutoSize = True
        Me.orden_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.orden_page.Location = New System.Drawing.Point(409, 393)
        Me.orden_page.Name = "orden_page"
        Me.orden_page.Size = New System.Drawing.Size(16, 17)
        Me.orden_page.TabIndex = 21
        Me.orden_page.Text = "0"
        '
        'DataSetCiudades
        '
        Me.DataSetCiudades.DataSetName = "DataSetCiudades"
        Me.DataSetCiudades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadesBindingSource
        '
        Me.CiudadesBindingSource.DataMember = "Ciudades"
        Me.CiudadesBindingSource.DataSource = Me.DataSetCiudades
        '
        'CiudadesTableAdapter
        '
        Me.CiudadesTableAdapter.ClearBeforeFill = True
        '
        'CiudadesBindingSource1
        '
        Me.CiudadesBindingSource1.DataMember = "Ciudades"
        Me.CiudadesBindingSource1.DataSource = Me.DataSetCiudades
        '
        'CiudadesBindingSource2
        '
        Me.CiudadesBindingSource2.DataMember = "Ciudades"
        Me.CiudadesBindingSource2.DataSource = Me.DataSetCiudades
        '
        'CiudadesBindingSource3
        '
        Me.CiudadesBindingSource3.DataMember = "Ciudades"
        Me.CiudadesBindingSource3.DataSource = Me.DataSetCiudades
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CiudadesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(167, 478)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'DataSetCiudadesBindingSource
        '
        Me.DataSetCiudadesBindingSource.DataSource = Me.DataSetCiudades
        Me.DataSetCiudadesBindingSource.Position = 0
        '
        'CiudadesBindingSource4
        '
        Me.CiudadesBindingSource4.DataMember = "Ciudades"
        Me.CiudadesBindingSource4.DataSource = Me.DataSetCiudades
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.orden_page)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.bt_Buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_Ultimo)
        Me.Controls.Add(Me.bt_Siguiente)
        Me.Controls.Add(Me.bt_Anterior)
        Me.Controls.Add(Me.bt_primero)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSetCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_Guardar As Button
    Friend WithEvents bt_Editar As Button
    Friend WithEvents bt_Eliminar As Button
    Friend WithEvents bt_Vaciar As Button
    Friend WithEvents txt_observaciones As RichTextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents bt_primero As Button
    Friend WithEvents bt_Anterior As Button
    Friend WithEvents bt_Siguiente As Button
    Friend WithEvents bt_Ultimo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents bt_Buscar As Button
    Friend WithEvents label7 As Label
    Friend WithEvents orden_page As Label
    Friend WithEvents DataSetCiudades As DataSetCiudades
    Friend WithEvents CiudadesBindingSource As BindingSource
    Friend WithEvents CiudadesTableAdapter As DataSetCiudadesTableAdapters.CiudadesTableAdapter
    Friend WithEvents CiudadesBindingSource3 As BindingSource
    Friend WithEvents CiudadesBindingSource2 As BindingSource
    Friend WithEvents CiudadesBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadesBindingSource4 As BindingSource
    Friend WithEvents DataSetCiudadesBindingSource As BindingSource
End Class
