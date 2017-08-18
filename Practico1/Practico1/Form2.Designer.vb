<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TEliminar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(66, 52)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(127, 17)
        Me.LNya.TabIndex = 0
        Me.LNya.Text = "Nombre y Apellido:"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.ForeColor = System.Drawing.Color.Red
        Me.LModificar.Location = New System.Drawing.Point(248, 52)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(65, 17)
        Me.LModificar.TabIndex = 0
        Me.LModificar.Text = "modificar"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(66, 110)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(31, 17)
        Me.LDni.TabIndex = 0
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(66, 194)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(58, 17)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(66, 151)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(58, 17)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(203, 107)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 22)
        Me.TDni.TabIndex = 1
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(203, 189)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 22)
        Me.TNombre.TabIndex = 1
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(203, 148)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 22)
        Me.TApellido.TabIndex = 1
        '
        'TGuardar
        '
        Me.TGuardar.Location = New System.Drawing.Point(69, 260)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(75, 23)
        Me.TGuardar.TabIndex = 2
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TEliminar
        '
        Me.TEliminar.Location = New System.Drawing.Point(203, 260)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(75, 23)
        Me.TEliminar.TabIndex = 2
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 336)
        Me.Controls.Add(Me.TEliminar)
        Me.Controls.Add(Me.TGuardar)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.LNya)
        Me.Name = "Form2"
        Me.Text = "Pequeño Formulario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
