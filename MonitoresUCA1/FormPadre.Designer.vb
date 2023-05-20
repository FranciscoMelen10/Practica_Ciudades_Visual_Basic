<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPadre
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.archivo_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.archivo_Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Formulario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Formulario_Crud = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_FormularioA = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_FormularioB = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_FormularioC = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Reportes1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Reportes2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Reportes3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivo_Menu, Me.menu_Formulario, Me.menu_Reportes})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(632, 24)
        Me.menu.TabIndex = 7
        Me.menu.Text = "MenuStrip1"
        '
        'archivo_Menu
        '
        Me.archivo_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivo_Cerrar})
        Me.archivo_Menu.Name = "archivo_Menu"
        Me.archivo_Menu.Size = New System.Drawing.Size(60, 20)
        Me.archivo_Menu.Text = "Archivo"
        '
        'archivo_Cerrar
        '
        Me.archivo_Cerrar.Name = "archivo_Cerrar"
        Me.archivo_Cerrar.Size = New System.Drawing.Size(106, 22)
        Me.archivo_Cerrar.Text = "Cerrar"
        '
        'menu_Formulario
        '
        Me.menu_Formulario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Formulario_Crud, Me.menu_FormularioA, Me.menu_FormularioB, Me.menu_FormularioC})
        Me.menu_Formulario.Name = "menu_Formulario"
        Me.menu_Formulario.Size = New System.Drawing.Size(81, 20)
        Me.menu_Formulario.Text = "Fomularios "
        '
        'menu_Formulario_Crud
        '
        Me.menu_Formulario_Crud.Name = "menu_Formulario_Crud"
        Me.menu_Formulario_Crud.Size = New System.Drawing.Size(167, 22)
        Me.menu_Formulario_Crud.Text = "Fomularios CRUD"
        '
        'menu_FormularioA
        '
        Me.menu_FormularioA.Name = "menu_FormularioA"
        Me.menu_FormularioA.Size = New System.Drawing.Size(167, 22)
        Me.menu_FormularioA.Text = "Fomulario A"
        '
        'menu_FormularioB
        '
        Me.menu_FormularioB.Name = "menu_FormularioB"
        Me.menu_FormularioB.Size = New System.Drawing.Size(167, 22)
        Me.menu_FormularioB.Text = "Fomulario B"
        '
        'menu_FormularioC
        '
        Me.menu_FormularioC.Name = "menu_FormularioC"
        Me.menu_FormularioC.Size = New System.Drawing.Size(167, 22)
        Me.menu_FormularioC.Text = "Fomulario C"
        '
        'menu_Reportes
        '
        Me.menu_Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Reportes1, Me.menu_Reportes2, Me.menu_Reportes3})
        Me.menu_Reportes.Name = "menu_Reportes"
        Me.menu_Reportes.Size = New System.Drawing.Size(65, 20)
        Me.menu_Reportes.Text = "Reportes"
        '
        'menu_Reportes1
        '
        Me.menu_Reportes1.Name = "menu_Reportes1"
        Me.menu_Reportes1.Size = New System.Drawing.Size(124, 22)
        Me.menu_Reportes1.Text = "Reporte 1"
        '
        'menu_Reportes2
        '
        Me.menu_Reportes2.Name = "menu_Reportes2"
        Me.menu_Reportes2.Size = New System.Drawing.Size(124, 22)
        Me.menu_Reportes2.Text = "Reporte 2"
        '
        'menu_Reportes3
        '
        Me.menu_Reportes3.Name = "menu_Reportes3"
        Me.menu_Reportes3.Size = New System.Drawing.Size(124, 22)
        Me.menu_Reportes3.Text = "Reporte 3"
        '
        'FormPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.menu)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPadre"
        Me.Text = "FormPadre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents menu As MenuStrip
    Friend WithEvents archivo_Menu As ToolStripMenuItem
    Friend WithEvents archivo_Cerrar As ToolStripMenuItem
    Friend WithEvents menu_Formulario As ToolStripMenuItem
    Friend WithEvents menu_Formulario_Crud As ToolStripMenuItem
    Friend WithEvents menu_FormularioA As ToolStripMenuItem
    Friend WithEvents menu_FormularioB As ToolStripMenuItem
    Friend WithEvents menu_FormularioC As ToolStripMenuItem
    Friend WithEvents menu_Reportes As ToolStripMenuItem
    Friend WithEvents menu_Reportes1 As ToolStripMenuItem
    Friend WithEvents menu_Reportes2 As ToolStripMenuItem
    Friend WithEvents menu_Reportes3 As ToolStripMenuItem
End Class
