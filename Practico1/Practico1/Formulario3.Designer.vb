<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario3
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
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TEliminar = New System.Windows.Forms.Button()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LNya = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LTarjetas = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(165, 134)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 22)
        Me.TNombre.TabIndex = 14
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(165, 91)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 22)
        Me.TApellido.TabIndex = 13
        '
        'TEliminar
        '
        Me.TEliminar.Location = New System.Drawing.Point(219, 368)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(75, 23)
        Me.TEliminar.TabIndex = 11
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'TGuardar
        '
        Me.TGuardar.Location = New System.Drawing.Point(85, 368)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(75, 23)
        Me.TGuardar.TabIndex = 12
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(165, 52)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 22)
        Me.TDni.TabIndex = 10
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(28, 96)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(67, 17)
        Me.LApellido.TabIndex = 5
        Me.LApellido.Text = "* Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(28, 139)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(67, 17)
        Me.LNombre.TabIndex = 6
        Me.LNombre.Text = "* Nombre"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(28, 55)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 17)
        Me.LDni.TabIndex = 7
        Me.LDni.Text = "* DNI"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.ForeColor = System.Drawing.Color.Red
        Me.LModificar.Location = New System.Drawing.Point(210, 16)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(65, 17)
        Me.LModificar.TabIndex = 8
        Me.LModificar.Text = "modificar"
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(28, 16)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(127, 17)
        Me.LNya.TabIndex = 9
        Me.LNya.Text = "Nombre y Apellido:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(28, 179)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LTelefono.TabIndex = 15
        Me.LTelefono.Text = "Telefono"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LNya)
        Me.Panel1.Controls.Add(Me.LTarjetas)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LModificar)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Location = New System.Drawing.Point(29, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 325)
        Me.Panel1.TabIndex = 17
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(165, 179)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(100, 22)
        Me.TTelefono.TabIndex = 20
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(185, 276)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(103, 21)
        Me.CheckBox3.TabIndex = 19
        Me.CheckBox3.Text = "MasterCard"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(185, 249)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 21)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "Visa"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(185, 222)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 21)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Naranja"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LTarjetas
        '
        Me.LTarjetas.AutoSize = True
        Me.LTarjetas.Location = New System.Drawing.Point(28, 222)
        Me.LTarjetas.Name = "LTarjetas"
        Me.LTarjetas.Size = New System.Drawing.Size(134, 17)
        Me.LTarjetas.TabIndex = 15
        Me.LTarjetas.Text = "Tarjetas de creditos"
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(635, 373)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 19
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Location = New System.Drawing.Point(447, 187)
        Me.RBVaron.Name = "RBVaron"
        Me.RBVaron.Size = New System.Drawing.Size(67, 21)
        Me.RBVaron.TabIndex = 21
        Me.RBVaron.TabStop = True
        Me.RBVaron.Text = "Varon"
        Me.RBVaron.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Location = New System.Drawing.Point(584, 187)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(64, 21)
        Me.RBMujer.TabIndex = 22
        Me.RBMujer.TabStop = True
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(727, 419)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.RBVaron)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.TGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TEliminar)
        Me.IsMdiContainer = True
        Me.Name = "Formulario3"
        Me.Text = "Formulario3"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TEliminar As Button
    Friend WithEvents TGuardar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LNya As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents LTelefono As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTarjetas As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BSalir As Button
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBVaron As RadioButton
End Class
