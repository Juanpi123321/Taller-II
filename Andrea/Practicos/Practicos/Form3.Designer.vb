<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LNya = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TEliminar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(40, 60)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(91, 13)
        Me.LNya.TabIndex = 0
        Me.LNya.Text = "Nombre y apellido"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(40, 104)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(23, 13)
        Me.LDni.TabIndex = 1
        Me.LDni.Text = "Dni"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(40, 136)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(40, 171)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.ForeColor = System.Drawing.Color.Red
        Me.LModificar.Location = New System.Drawing.Point(152, 60)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(50, 13)
        Me.LModificar.TabIndex = 4
        Me.LModificar.Text = "Modificar"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(102, 104)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 20)
        Me.TDni.TabIndex = 5
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(102, 136)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 6
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(102, 168)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 7
        '
        'TGuardar
        '
        Me.TGuardar.Location = New System.Drawing.Point(43, 211)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(75, 23)
        Me.TGuardar.TabIndex = 8
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TEliminar
        '
        Me.TEliminar.Location = New System.Drawing.Point(124, 211)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(75, 23)
        Me.TEliminar.TabIndex = 9
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 261)
        Me.Controls.Add(Me.TEliminar)
        Me.Controls.Add(Me.TGuardar)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LNya)
        Me.Name = "Form3"
        Me.Text = "Pequeño Formulario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNya As System.Windows.Forms.Label
    Friend WithEvents LDni As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TGuardar As System.Windows.Forms.Button
    Friend WithEvents TEliminar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
