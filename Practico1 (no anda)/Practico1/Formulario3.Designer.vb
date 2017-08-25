<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario3))
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
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
        Me.CBTarjeta3 = New System.Windows.Forms.CheckBox()
        Me.CBTarjeta2 = New System.Windows.Forms.CheckBox()
        Me.CBTarjeta1 = New System.Windows.Forms.CheckBox()
        Me.LTarjetas = New System.Windows.Forms.Label()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TEliminar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.CBTarjeta3)
        Me.Panel1.Controls.Add(Me.CBTarjeta2)
        Me.Panel1.Controls.Add(Me.CBTarjeta1)
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
        Me.Panel1.Location = New System.Drawing.Point(29, 61)
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
        'CBTarjeta3
        '
        Me.CBTarjeta3.AutoSize = True
        Me.CBTarjeta3.Location = New System.Drawing.Point(185, 276)
        Me.CBTarjeta3.Name = "CBTarjeta3"
        Me.CBTarjeta3.Size = New System.Drawing.Size(103, 21)
        Me.CBTarjeta3.TabIndex = 19
        Me.CBTarjeta3.Text = "MasterCard"
        Me.CBTarjeta3.UseVisualStyleBackColor = True
        '
        'CBTarjeta2
        '
        Me.CBTarjeta2.AutoSize = True
        Me.CBTarjeta2.Location = New System.Drawing.Point(185, 249)
        Me.CBTarjeta2.Name = "CBTarjeta2"
        Me.CBTarjeta2.Size = New System.Drawing.Size(57, 21)
        Me.CBTarjeta2.TabIndex = 18
        Me.CBTarjeta2.Text = "Visa"
        Me.CBTarjeta2.UseVisualStyleBackColor = True
        '
        'CBTarjeta1
        '
        Me.CBTarjeta1.AutoSize = True
        Me.CBTarjeta1.Location = New System.Drawing.Point(185, 222)
        Me.CBTarjeta1.Name = "CBTarjeta1"
        Me.CBTarjeta1.Size = New System.Drawing.Size(80, 21)
        Me.CBTarjeta1.TabIndex = 17
        Me.CBTarjeta1.Text = "Naranja"
        Me.CBTarjeta1.UseVisualStyleBackColor = True
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
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Checked = True
        Me.RBVaron.Location = New System.Drawing.Point(447, 279)
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
        Me.RBMujer.Location = New System.Drawing.Point(584, 279)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(64, 21)
        Me.RBMujer.TabIndex = 22
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(300, 9)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(165, 29)
        Me.LTitulo.TabIndex = 25
        Me.LTitulo.Text = "Nuevo Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(447, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'BSalir
        '
        Me.BSalir.Image = Global.Practicos.My.Resources.Resources.salir_min
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(584, 400)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(131, 55)
        Me.BSalir.TabIndex = 19
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'TGuardar
        '
        Me.TGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TGuardar.Image = Global.Practicos.My.Resources.Resources.guardar_min
        Me.TGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.TGuardar.Location = New System.Drawing.Point(60, 405)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(131, 55)
        Me.TGuardar.TabIndex = 12
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TEliminar
        '
        Me.TEliminar.Image = Global.Practicos.My.Resources.Resources.eliminar_min
        Me.TEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TEliminar.Location = New System.Drawing.Point(214, 405)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(131, 55)
        Me.TEliminar.TabIndex = 11
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(739, 470)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.RBVaron)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.TGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TEliminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formulario3"
        Me.Text = "Formulario3"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CBTarjeta3 As CheckBox
    Friend WithEvents CBTarjeta2 As CheckBox
    Friend WithEvents CBTarjeta1 As CheckBox
    Friend WithEvents BSalir As Button
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LTitulo As Label
End Class
