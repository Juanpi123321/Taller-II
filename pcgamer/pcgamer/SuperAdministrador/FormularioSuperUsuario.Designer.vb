<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioSuperUsuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioSuperUsuario))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RRolSuper = New System.Windows.Forms.RadioButton()
        Me.RRolAdmin = New System.Windows.Forms.RadioButton()
        Me.RRolVendedor = New System.Windows.Forms.RadioButton()
        Me.LRol = New System.Windows.Forms.Label()
        Me.LFechaIng = New System.Windows.Forms.Label()
        Me.FechaReg = New System.Windows.Forms.DateTimePicker()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BImagen = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.BAlta = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.TDNI = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TDomicilio = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridUsuario = New System.Windows.Forms.DataGridView()
        Me.Id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(358, 14)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(314, 40)
        Me.LTitulo.TabIndex = 31
        Me.LTitulo.Text = "Gestionar Usuario"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(794, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 22
        Me.PBLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RRolSuper)
        Me.Panel1.Controls.Add(Me.RRolAdmin)
        Me.Panel1.Controls.Add(Me.RRolVendedor)
        Me.Panel1.Controls.Add(Me.LRol)
        Me.Panel1.Controls.Add(Me.LFechaIng)
        Me.Panel1.Controls.Add(Me.FechaReg)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Controls.Add(Me.PBImagen)
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BImagen)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.CBBuscar)
        Me.Panel1.Controls.Add(Me.BAlta)
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.LEmail)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LDNI)
        Me.Panel1.Controls.Add(Me.LDomicilio)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LBuscar)
        Me.Panel1.Controls.Add(Me.TEmail)
        Me.Panel1.Controls.Add(Me.TDNI)
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.TDomicilio)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.TBuscar)
        Me.Panel1.Controls.Add(Me.DataGridUsuario)
        Me.Panel1.Location = New System.Drawing.Point(113, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 541)
        Me.Panel1.TabIndex = 30
        '
        'RRolSuper
        '
        Me.RRolSuper.AutoSize = True
        Me.RRolSuper.BackColor = System.Drawing.Color.Transparent
        Me.RRolSuper.Enabled = False
        Me.RRolSuper.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRolSuper.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RRolSuper.Location = New System.Drawing.Point(568, 287)
        Me.RRolSuper.Name = "RRolSuper"
        Me.RRolSuper.Size = New System.Drawing.Size(175, 21)
        Me.RRolSuper.TabIndex = 21
        Me.RRolSuper.Text = "Super Administrador"
        Me.RRolSuper.UseVisualStyleBackColor = False
        '
        'RRolAdmin
        '
        Me.RRolAdmin.AutoSize = True
        Me.RRolAdmin.BackColor = System.Drawing.Color.Transparent
        Me.RRolAdmin.Enabled = False
        Me.RRolAdmin.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRolAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RRolAdmin.Location = New System.Drawing.Point(568, 260)
        Me.RRolAdmin.Name = "RRolAdmin"
        Me.RRolAdmin.Size = New System.Drawing.Size(128, 21)
        Me.RRolAdmin.TabIndex = 20
        Me.RRolAdmin.Text = "Administrador"
        Me.RRolAdmin.UseVisualStyleBackColor = False
        '
        'RRolVendedor
        '
        Me.RRolVendedor.AutoSize = True
        Me.RRolVendedor.BackColor = System.Drawing.Color.Transparent
        Me.RRolVendedor.Checked = True
        Me.RRolVendedor.Enabled = False
        Me.RRolVendedor.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRolVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RRolVendedor.Location = New System.Drawing.Point(568, 233)
        Me.RRolVendedor.Name = "RRolVendedor"
        Me.RRolVendedor.Size = New System.Drawing.Size(96, 21)
        Me.RRolVendedor.TabIndex = 19
        Me.RRolVendedor.TabStop = True
        Me.RRolVendedor.Text = "Vendedor"
        Me.RRolVendedor.UseVisualStyleBackColor = False
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.Color.White
        Me.LRol.Location = New System.Drawing.Point(498, 246)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(38, 18)
        Me.LRol.TabIndex = 18
        Me.LRol.Text = "Rol:"
        '
        'LFechaIng
        '
        Me.LFechaIng.AutoSize = True
        Me.LFechaIng.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaIng.ForeColor = System.Drawing.Color.White
        Me.LFechaIng.Location = New System.Drawing.Point(54, 284)
        Me.LFechaIng.Name = "LFechaIng"
        Me.LFechaIng.Size = New System.Drawing.Size(120, 18)
        Me.LFechaIng.TabIndex = 17
        Me.LFechaIng.Text = "Fecha Ingreso:"
        '
        'FechaReg
        '
        Me.FechaReg.Enabled = False
        Me.FechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaReg.Location = New System.Drawing.Point(182, 276)
        Me.FechaReg.Name = "FechaReg"
        Me.FechaReg.Size = New System.Drawing.Size(151, 28)
        Me.FechaReg.TabIndex = 9
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.DarkRed
        Me.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BNuevo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNuevo.ForeColor = System.Drawing.Color.White
        Me.BNuevo.Location = New System.Drawing.Point(643, 15)
        Me.BNuevo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(129, 32)
        Me.BNuevo.TabIndex = 2
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'PBImagen
        '
        Me.PBImagen.Image = Global.pcgamer.My.Resources.Resources.usuario
        Me.PBImagen.Location = New System.Drawing.Point(544, 60)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(172, 163)
        Me.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagen.TabIndex = 34
        Me.PBImagen.TabStop = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(170, 322)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(95, 31)
        Me.BCancelar.TabIndex = 25
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        Me.BCancelar.Visible = False
        '
        'BImagen
        '
        Me.BImagen.BackColor = System.Drawing.Color.DarkRed
        Me.BImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BImagen.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImagen.ForeColor = System.Drawing.Color.White
        Me.BImagen.Location = New System.Drawing.Point(467, 195)
        Me.BImagen.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BImagen.Name = "BImagen"
        Me.BImagen.Size = New System.Drawing.Size(72, 28)
        Me.BImagen.TabIndex = 31
        Me.BImagen.Text = "Imagen"
        Me.BImagen.UseVisualStyleBackColor = False
        Me.BImagen.Visible = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(287, 322)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(95, 31)
        Me.BAgregar.TabIndex = 27
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        Me.BAgregar.Visible = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.DarkRed
        Me.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(330, 322)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(95, 31)
        Me.BGuardar.TabIndex = 28
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        Me.BGuardar.Visible = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.DarkRed
        Me.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEditar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditar.ForeColor = System.Drawing.Color.White
        Me.BEditar.Location = New System.Drawing.Point(142, 322)
        Me.BEditar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(94, 31)
        Me.BEditar.TabIndex = 24
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"DNI", "Apellido y Nombre", "Id_usuario"})
        Me.CBBuscar.Location = New System.Drawing.Point(421, 18)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(181, 28)
        Me.CBBuscar.TabIndex = 1
        '
        'BAlta
        '
        Me.BAlta.BackColor = System.Drawing.Color.DarkRed
        Me.BAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAlta.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAlta.ForeColor = System.Drawing.Color.White
        Me.BAlta.Image = Global.pcgamer.My.Resources.Resources.ok_icono
        Me.BAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAlta.Location = New System.Drawing.Point(640, 316)
        Me.BAlta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(107, 42)
        Me.BAlta.TabIndex = 22
        Me.BAlta.Text = "Alta "
        Me.BAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAlta.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.DarkRed
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEliminar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.Color.White
        Me.BEliminar.Image = Global.pcgamer.My.Resources.Resources.cancelar_icono1
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(640, 316)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(132, 42)
        Me.BEliminar.TabIndex = 23
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail.ForeColor = System.Drawing.Color.White
        Me.LEmail.Location = New System.Drawing.Point(54, 241)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(54, 18)
        Me.LEmail.TabIndex = 16
        Me.LEmail.Text = "Email:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.White
        Me.LTelefono.Location = New System.Drawing.Point(52, 205)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 18)
        Me.LTelefono.TabIndex = 15
        Me.LTelefono.Text = "Telefono:"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.ForeColor = System.Drawing.Color.White
        Me.LDNI.Location = New System.Drawing.Point(52, 134)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(42, 18)
        Me.LDNI.TabIndex = 13
        Me.LDNI.Text = "DNI:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDomicilio.ForeColor = System.Drawing.Color.White
        Me.LDomicilio.Location = New System.Drawing.Point(52, 168)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(81, 18)
        Me.LDomicilio.TabIndex = 14
        Me.LDomicilio.Text = "Domicilio:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(50, 100)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(83, 18)
        Me.LNombre.TabIndex = 12
        Me.LNombre.Text = "Nombres:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(50, 65)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(79, 18)
        Me.LApellido.TabIndex = 11
        Me.LApellido.Text = "Apellidos:"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(35, 21)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 10
        Me.LBuscar.Text = "Buscar:"
        '
        'TEmail
        '
        Me.TEmail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEmail.Location = New System.Drawing.Point(142, 239)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.ReadOnly = True
        Me.TEmail.Size = New System.Drawing.Size(282, 23)
        Me.TEmail.TabIndex = 8
        '
        'TDNI
        '
        Me.TDNI.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDNI.Location = New System.Drawing.Point(142, 134)
        Me.TDNI.MaxLength = 8
        Me.TDNI.Name = "TDNI"
        Me.TDNI.ReadOnly = True
        Me.TDNI.Size = New System.Drawing.Size(282, 23)
        Me.TDNI.TabIndex = 5
        '
        'TTelefono
        '
        Me.TTelefono.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(142, 204)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.ReadOnly = True
        Me.TTelefono.Size = New System.Drawing.Size(282, 23)
        Me.TTelefono.TabIndex = 7
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(142, 100)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.ReadOnly = True
        Me.TNombre.Size = New System.Drawing.Size(282, 23)
        Me.TNombre.TabIndex = 4
        '
        'TDomicilio
        '
        Me.TDomicilio.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDomicilio.Location = New System.Drawing.Point(142, 169)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.ReadOnly = True
        Me.TDomicilio.Size = New System.Drawing.Size(282, 23)
        Me.TDomicilio.TabIndex = 6
        '
        'TApellido
        '
        Me.TApellido.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido.Location = New System.Drawing.Point(142, 65)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.ReadOnly = True
        Me.TApellido.Size = New System.Drawing.Size(282, 23)
        Me.TApellido.TabIndex = 3
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(116, 18)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(281, 28)
        Me.TBuscar.TabIndex = 0
        '
        'DataGridUsuario
        '
        Me.DataGridUsuario.AllowUserToDeleteRows = False
        Me.DataGridUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_usuario, Me.apellidos, Me.nombres, Me.dni, Me.Rol, Me.fecha_ingreso})
        Me.DataGridUsuario.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridUsuario.Location = New System.Drawing.Point(4, 372)
        Me.DataGridUsuario.Name = "DataGridUsuario"
        Me.DataGridUsuario.ReadOnly = True
        Me.DataGridUsuario.RowTemplate.Height = 24
        Me.DataGridUsuario.Size = New System.Drawing.Size(776, 166)
        Me.DataGridUsuario.TabIndex = 29
        '
        'Id_usuario
        '
        Me.Id_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Id_usuario.DefaultCellStyle = DataGridViewCellStyle1
        Me.Id_usuario.HeaderText = "Id_usuario"
        Me.Id_usuario.Name = "Id_usuario"
        Me.Id_usuario.ReadOnly = True
        Me.Id_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Id_usuario.Width = 131
        '
        'apellidos
        '
        Me.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.apellidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'nombres
        '
        Me.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.nombres.DefaultCellStyle = DataGridViewCellStyle3
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dni
        '
        Me.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dni.DefaultCellStyle = DataGridViewCellStyle4
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dni.Width = 72
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.fecha_ingreso.DefaultCellStyle = DataGridViewCellStyle5
        Me.fecha_ingreso.HeaderText = "Fecha Ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        Me.fecha_ingreso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormularioSuperUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.superadmin_background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(150, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioSuperUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Gestionar Usuario"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTitulo As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents BAlta As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LEmail As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LDomicilio As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LBuscar As Label
    Friend WithEvents TEmail As TextBox
    Friend WithEvents TDNI As TextBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TDomicilio As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents DataGridUsuario As DataGridView
    Friend WithEvents PBImagen As PictureBox
    Friend WithEvents BNuevo As Button
    Friend WithEvents RRolSuper As RadioButton
    Friend WithEvents RRolAdmin As RadioButton
    Friend WithEvents RRolVendedor As RadioButton
    Friend WithEvents LRol As Label
    Friend WithEvents LFechaIng As Label
    Friend WithEvents FechaReg As DateTimePicker
    Friend WithEvents BAgregar As Button
    Friend WithEvents Id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents BImagen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
