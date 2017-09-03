<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioCliente))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LObligatorio = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDomicilio = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(630, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 1
        Me.PBLogo.TabStop = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(22, 23)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(96, 20)
        Me.LNombre.TabIndex = 7
        Me.LNombre.Text = "*Nombre:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(23, 91)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(62, 20)
        Me.LDni.TabIndex = 9
        Me.LDni.Text = "*DNI:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(22, 57)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(97, 20)
        Me.LApellido.TabIndex = 8
        Me.LApellido.Text = "*Apellido:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(23, 159)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(87, 20)
        Me.LTelefono.TabIndex = 11
        Me.LTelefono.Text = "Telefono:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Location = New System.Drawing.Point(23, 125)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(107, 20)
        Me.LDomicilio.TabIndex = 10
        Me.LDomicilio.Text = "*Domicilio:"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(287, 53)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(293, 40)
        Me.LTitulo.TabIndex = 12
        Me.LTitulo.Text = "Registrar Cliente"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(139, 20)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(193, 28)
        Me.TNombre.TabIndex = 0
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(139, 54)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(193, 28)
        Me.TApellido.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LObligatorio)
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.TDomicilio)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LDomicilio)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(249, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 220)
        Me.Panel1.TabIndex = 8
        '
        'LObligatorio
        '
        Me.LObligatorio.AutoSize = True
        Me.LObligatorio.Font = New System.Drawing.Font("Verdana", 4.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LObligatorio.Location = New System.Drawing.Point(302, 201)
        Me.LObligatorio.Name = "LObligatorio"
        Me.LObligatorio.Size = New System.Drawing.Size(47, 8)
        Me.LObligatorio.TabIndex = 12
        Me.LObligatorio.Text = "*Obligatorio"
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(138, 156)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(193, 28)
        Me.TTelefono.TabIndex = 4
        '
        'TDomicilio
        '
        Me.TDomicilio.Location = New System.Drawing.Point(138, 122)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.Size = New System.Drawing.Size(193, 28)
        Me.TDomicilio.TabIndex = 3
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(139, 88)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(193, 28)
        Me.TDni.TabIndex = 2
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.BLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLimpiar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiar.ForeColor = System.Drawing.Color.White
        Me.BLimpiar.Location = New System.Drawing.Point(249, 371)
        Me.BLimpiar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(166, 32)
        Me.BLimpiar.TabIndex = 5
        Me.BLimpiar.Text = "Limpiar Registro"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(448, 371)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(166, 32)
        Me.BAgregar.TabIndex = 13
        Me.BAgregar.Text = "Agregar Cliente"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormularioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 442)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioCliente"
        Me.Text = "Formulario Cliente"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDomicilio As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDomicilio As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents BLimpiar As Button
    Friend WithEvents LObligatorio As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
