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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioSuperUsuario))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBOk = New System.Windows.Forms.PictureBox()
        Me.BGenerarUsuario = New System.Windows.Forms.Button()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TContrasena = New System.Windows.Forms.TextBox()
        Me.LContrasena = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.BCambiarImagen = New System.Windows.Forms.Button()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.RRolSuper = New System.Windows.Forms.RadioButton()
        Me.RRolAdmin = New System.Windows.Forms.RadioButton()
        Me.RRolVendedor = New System.Windows.Forms.RadioButton()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LRolRB = New System.Windows.Forms.Label()
        Me.LFechaIng = New System.Windows.Forms.Label()
        Me.FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.BCancelar = New System.Windows.Forms.Button()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBOk, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LTitulo.Location = New System.Drawing.Point(435, 42)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(314, 40)
        Me.LTitulo.TabIndex = 33
        Me.LTitulo.Text = "Gestionar Usuario"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
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
        Me.Panel1.Controls.Add(Me.PBOk)
        Me.Panel1.Controls.Add(Me.BGenerarUsuario)
        Me.Panel1.Controls.Add(Me.TUsuario)
        Me.Panel1.Controls.Add(Me.TContrasena)
        Me.Panel1.Controls.Add(Me.LContrasena)
        Me.Panel1.Controls.Add(Me.LUsuario)
        Me.Panel1.Controls.Add(Me.BCambiarImagen)
        Me.Panel1.Controls.Add(Me.CBSexo)
        Me.Panel1.Controls.Add(Me.RRolSuper)
        Me.Panel1.Controls.Add(Me.RRolAdmin)
        Me.Panel1.Controls.Add(Me.RRolVendedor)
        Me.Panel1.Controls.Add(Me.LSexo)
        Me.Panel1.Controls.Add(Me.LRolRB)
        Me.Panel1.Controls.Add(Me.LFechaIng)
        Me.Panel1.Controls.Add(Me.FechaIngreso)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Controls.Add(Me.PBImagen)
        Me.Panel1.Controls.Add(Me.BCancelar)
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
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(17, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 524)
        Me.Panel1.TabIndex = 34
        '
        'PBOk
        '
        Me.PBOk.Image = Global.pcgamer.My.Resources.Resources.okk
        Me.PBOk.Location = New System.Drawing.Point(706, 170)
        Me.PBOk.Name = "PBOk"
        Me.PBOk.Size = New System.Drawing.Size(71, 57)
        Me.PBOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBOk.TabIndex = 37
        Me.PBOk.TabStop = False
        Me.PBOk.Visible = False
        '
        'BGenerarUsuario
        '
        Me.BGenerarUsuario.BackColor = System.Drawing.Color.DarkRed
        Me.BGenerarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BGenerarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGenerarUsuario.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGenerarUsuario.ForeColor = System.Drawing.Color.White
        Me.BGenerarUsuario.Location = New System.Drawing.Point(646, 177)
        Me.BGenerarUsuario.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGenerarUsuario.Name = "BGenerarUsuario"
        Me.BGenerarUsuario.Size = New System.Drawing.Size(185, 47)
        Me.BGenerarUsuario.TabIndex = 36
        Me.BGenerarUsuario.Text = "Generar Usuario"
        Me.BGenerarUsuario.UseVisualStyleBackColor = False
        Me.BGenerarUsuario.Visible = False
        '
        'TUsuario
        '
        Me.TUsuario.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUsuario.Location = New System.Drawing.Point(615, 176)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.ReadOnly = True
        Me.TUsuario.Size = New System.Drawing.Size(169, 23)
        Me.TUsuario.TabIndex = 41
        '
        'TContrasena
        '
        Me.TContrasena.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TContrasena.Location = New System.Drawing.Point(615, 205)
        Me.TContrasena.Name = "TContrasena"
        Me.TContrasena.ReadOnly = True
        Me.TContrasena.Size = New System.Drawing.Size(169, 23)
        Me.TContrasena.TabIndex = 40
        Me.TContrasena.UseSystemPasswordChar = True
        '
        'LContrasena
        '
        Me.LContrasena.AutoSize = True
        Me.LContrasena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContrasena.ForeColor = System.Drawing.Color.White
        Me.LContrasena.Location = New System.Drawing.Point(487, 210)
        Me.LContrasena.Name = "LContrasena"
        Me.LContrasena.Size = New System.Drawing.Size(101, 18)
        Me.LContrasena.TabIndex = 39
        Me.LContrasena.Text = "Contraseña:"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(487, 177)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(71, 18)
        Me.LUsuario.TabIndex = 38
        Me.LUsuario.Text = "Usuario:"
        '
        'BCambiarImagen
        '
        Me.BCambiarImagen.BackColor = System.Drawing.Color.DarkRed
        Me.BCambiarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCambiarImagen.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCambiarImagen.ForeColor = System.Drawing.Color.White
        Me.BCambiarImagen.Location = New System.Drawing.Point(991, 253)
        Me.BCambiarImagen.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCambiarImagen.Name = "BCambiarImagen"
        Me.BCambiarImagen.Size = New System.Drawing.Size(138, 25)
        Me.BCambiarImagen.TabIndex = 35
        Me.BCambiarImagen.Text = "Cambiar Imagen"
        Me.BCambiarImagen.UseVisualStyleBackColor = False
        Me.BCambiarImagen.Visible = False
        '
        'CBSexo
        '
        Me.CBSexo.Enabled = False
        Me.CBSexo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Items.AddRange(New Object() {"Seleccione un valor", "Masculino", "Femenino", "Otros"})
        Me.CBSexo.Location = New System.Drawing.Point(615, 138)
        Me.CBSexo.Name = "CBSexo"
        Me.CBSexo.Size = New System.Drawing.Size(169, 24)
        Me.CBSexo.TabIndex = 16
        '
        'RRolSuper
        '
        Me.RRolSuper.AutoSize = True
        Me.RRolSuper.BackColor = System.Drawing.Color.Transparent
        Me.RRolSuper.Enabled = False
        Me.RRolSuper.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRolSuper.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RRolSuper.Location = New System.Drawing.Point(615, 104)
        Me.RRolSuper.Name = "RRolSuper"
        Me.RRolSuper.Size = New System.Drawing.Size(175, 21)
        Me.RRolSuper.TabIndex = 19
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
        Me.RRolAdmin.Location = New System.Drawing.Point(615, 83)
        Me.RRolAdmin.Name = "RRolAdmin"
        Me.RRolAdmin.Size = New System.Drawing.Size(128, 21)
        Me.RRolAdmin.TabIndex = 18
        Me.RRolAdmin.Text = "Administrador"
        Me.RRolAdmin.UseVisualStyleBackColor = False
        '
        'RRolVendedor
        '
        Me.RRolVendedor.AutoSize = True
        Me.RRolVendedor.BackColor = System.Drawing.Color.Transparent
        Me.RRolVendedor.Enabled = False
        Me.RRolVendedor.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRolVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RRolVendedor.Location = New System.Drawing.Point(615, 62)
        Me.RRolVendedor.Name = "RRolVendedor"
        Me.RRolVendedor.Size = New System.Drawing.Size(96, 21)
        Me.RRolVendedor.TabIndex = 17
        Me.RRolVendedor.Text = "Vendedor"
        Me.RRolVendedor.UseVisualStyleBackColor = False
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.Color.White
        Me.LSexo.Location = New System.Drawing.Point(487, 139)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(53, 18)
        Me.LSexo.TabIndex = 30
        Me.LSexo.Text = "Sexo:"
        '
        'LRolRB
        '
        Me.LRolRB.AutoSize = True
        Me.LRolRB.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRolRB.ForeColor = System.Drawing.Color.White
        Me.LRolRB.Location = New System.Drawing.Point(487, 80)
        Me.LRolRB.Name = "LRolRB"
        Me.LRolRB.Size = New System.Drawing.Size(38, 18)
        Me.LRolRB.TabIndex = 31
        Me.LRolRB.Text = "Rol:"
        '
        'LFechaIng
        '
        Me.LFechaIng.AutoSize = True
        Me.LFechaIng.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaIng.ForeColor = System.Drawing.Color.White
        Me.LFechaIng.Location = New System.Drawing.Point(487, 242)
        Me.LFechaIng.Name = "LFechaIng"
        Me.LFechaIng.Size = New System.Drawing.Size(120, 18)
        Me.LFechaIng.TabIndex = 32
        Me.LFechaIng.Text = "Fecha Ingreso:"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Enabled = False
        Me.FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngreso.Location = New System.Drawing.Point(615, 237)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(151, 28)
        Me.FechaIngreso.TabIndex = 20
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.DarkRed
        Me.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BNuevo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNuevo.ForeColor = System.Drawing.Color.White
        Me.BNuevo.Location = New System.Drawing.Point(1016, 17)
        Me.BNuevo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(129, 32)
        Me.BNuevo.TabIndex = 7
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'PBImagen
        '
        Me.PBImagen.BackColor = System.Drawing.Color.White
        Me.PBImagen.Image = Global.pcgamer.My.Resources.Resources.usuario
        Me.PBImagen.Location = New System.Drawing.Point(953, 69)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(192, 169)
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
        Me.BCancelar.Location = New System.Drawing.Point(769, 17)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(95, 31)
        Me.BCancelar.TabIndex = 4
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        Me.BCancelar.Visible = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(902, 17)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(95, 31)
        Me.BAgregar.TabIndex = 6
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
        Me.BGuardar.Location = New System.Drawing.Point(889, 17)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(95, 31)
        Me.BGuardar.TabIndex = 5
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
        Me.BEditar.Location = New System.Drawing.Point(659, 17)
        Me.BEditar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(94, 31)
        Me.BEditar.TabIndex = 3
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Apellido y Nombre", "DNI"})
        Me.CBBuscar.Location = New System.Drawing.Point(442, 17)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(203, 28)
        Me.CBBuscar.TabIndex = 2
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
        Me.BAlta.Location = New System.Drawing.Point(997, 390)
        Me.BAlta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(107, 42)
        Me.BAlta.TabIndex = 22
        Me.BAlta.Text = "Alta "
        Me.BAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAlta.UseVisualStyleBackColor = False
        Me.BAlta.Visible = False
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
        Me.BEliminar.Location = New System.Drawing.Point(997, 390)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(132, 42)
        Me.BEliminar.TabIndex = 23
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail.ForeColor = System.Drawing.Color.White
        Me.LEmail.Location = New System.Drawing.Point(48, 240)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(54, 18)
        Me.LEmail.TabIndex = 27
        Me.LEmail.Text = "Email:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.White
        Me.LTelefono.Location = New System.Drawing.Point(48, 203)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 18)
        Me.LTelefono.TabIndex = 26
        Me.LTelefono.Text = "Telefono:"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.ForeColor = System.Drawing.Color.White
        Me.LDNI.Location = New System.Drawing.Point(48, 132)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(42, 18)
        Me.LDNI.TabIndex = 24
        Me.LDNI.Text = "DNI:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDomicilio.ForeColor = System.Drawing.Color.White
        Me.LDomicilio.Location = New System.Drawing.Point(48, 166)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(81, 18)
        Me.LDomicilio.TabIndex = 25
        Me.LDomicilio.Text = "Domicilio:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(46, 98)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(83, 18)
        Me.LNombre.TabIndex = 23
        Me.LNombre.Text = "Nombres:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(46, 63)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(79, 18)
        Me.LApellido.TabIndex = 22
        Me.LApellido.Text = "Apellidos:"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(58, 20)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 21
        Me.LBuscar.Text = "Buscar:"
        '
        'TEmail
        '
        Me.TEmail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEmail.Location = New System.Drawing.Point(138, 237)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.ReadOnly = True
        Me.TEmail.Size = New System.Drawing.Size(282, 23)
        Me.TEmail.TabIndex = 13
        '
        'TDNI
        '
        Me.TDNI.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDNI.Location = New System.Drawing.Point(138, 132)
        Me.TDNI.MaxLength = 8
        Me.TDNI.Name = "TDNI"
        Me.TDNI.ReadOnly = True
        Me.TDNI.Size = New System.Drawing.Size(282, 23)
        Me.TDNI.TabIndex = 10
        '
        'TTelefono
        '
        Me.TTelefono.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(138, 202)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.ReadOnly = True
        Me.TTelefono.Size = New System.Drawing.Size(282, 23)
        Me.TTelefono.TabIndex = 12
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(138, 98)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.ReadOnly = True
        Me.TNombre.Size = New System.Drawing.Size(282, 23)
        Me.TNombre.TabIndex = 9
        '
        'TDomicilio
        '
        Me.TDomicilio.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDomicilio.Location = New System.Drawing.Point(138, 167)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.ReadOnly = True
        Me.TDomicilio.Size = New System.Drawing.Size(282, 23)
        Me.TDomicilio.TabIndex = 11
        '
        'TApellido
        '
        Me.TApellido.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido.Location = New System.Drawing.Point(138, 63)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.ReadOnly = True
        Me.TApellido.Size = New System.Drawing.Size(282, 23)
        Me.TApellido.TabIndex = 8
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(139, 17)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(281, 28)
        Me.TBuscar.TabIndex = 0
        '
        'DataGridUsuario
        '
        Me.DataGridUsuario.AllowUserToAddRows = False
        Me.DataGridUsuario.AllowUserToDeleteRows = False
        Me.DataGridUsuario.AllowUserToResizeColumns = False
        Me.DataGridUsuario.AllowUserToResizeRows = False
        Me.DataGridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridUsuario.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridUsuario.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridUsuario.Location = New System.Drawing.Point(1, 317)
        Me.DataGridUsuario.MultiSelect = False
        Me.DataGridUsuario.Name = "DataGridUsuario"
        Me.DataGridUsuario.ReadOnly = True
        Me.DataGridUsuario.RowTemplate.Height = 24
        Me.DataGridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUsuario.Size = New System.Drawing.Size(964, 207)
        Me.DataGridUsuario.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(945, 648)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(0, 18)
        Me.LApeyNom.TabIndex = 36
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.Color.White
        Me.LRol.Location = New System.Drawing.Point(741, 646)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(190, 20)
        Me.LRol.TabIndex = 35
        Me.LRol.Text = "SuperAdministrador:"
        '
        'FormularioSuperUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.superadmin_background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormularioSuperUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Gestionar Usuario"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBOk, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LRolRB As Label
    Friend WithEvents LFechaIng As Label
    Friend WithEvents FechaIngreso As DateTimePicker
    Friend WithEvents BAgregar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CBSexo As ComboBox
    Friend WithEvents LSexo As Label
    Friend WithEvents BCambiarImagen As Button
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
    Friend WithEvents BGenerarUsuario As Button
    Friend WithEvents PBOk As PictureBox
    Friend WithEvents LContrasena As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents TContrasena As TextBox
End Class
