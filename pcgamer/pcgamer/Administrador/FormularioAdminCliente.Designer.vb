<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioAdminCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioAdminCliente))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.TabCliente = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PBLogo3 = New System.Windows.Forms.PictureBox()
        Me.PBlogo2 = New System.Windows.Forms.PictureBox()
        Me.BAgregarFactura = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.BAlta = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.LBEmail = New System.Windows.Forms.Label()
        Me.LBTelefono = New System.Windows.Forms.Label()
        Me.LBDNI = New System.Windows.Forms.Label()
        Me.LBDomicilio = New System.Windows.Forms.Label()
        Me.LBNombre = New System.Windows.Forms.Label()
        Me.LBApellido = New System.Windows.Forms.Label()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBDNI = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridCliente = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FechaReg = New System.Windows.Forms.DateTimePicker()
        Me.LFechaReg = New System.Windows.Forms.Label()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LObligatorio = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDomicilio = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCliente.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PBLogo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBlogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(469, 50)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(304, 40)
        Me.LTitulo.TabIndex = 19
        Me.LTitulo.Text = "Gestionar Cliente"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 19
        Me.PBLogo.TabStop = False
        '
        'TabCliente
        '
        Me.TabCliente.Controls.Add(Me.TabPage2)
        Me.TabCliente.Controls.Add(Me.TabPage1)
        Me.TabCliente.Location = New System.Drawing.Point(17, 119)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.SelectedIndex = 0
        Me.TabCliente.Size = New System.Drawing.Size(1164, 470)
        Me.TabCliente.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.PBLogo3)
        Me.TabPage2.Controls.Add(Me.PBlogo2)
        Me.TabPage2.Controls.Add(Me.BAgregarFactura)
        Me.TabPage2.Controls.Add(Me.BCancelar)
        Me.TabPage2.Controls.Add(Me.BGuardar)
        Me.TabPage2.Controls.Add(Me.BEditar)
        Me.TabPage2.Controls.Add(Me.CBBuscar)
        Me.TabPage2.Controls.Add(Me.BAlta)
        Me.TabPage2.Controls.Add(Me.BEliminar)
        Me.TabPage2.Controls.Add(Me.LBEmail)
        Me.TabPage2.Controls.Add(Me.LBTelefono)
        Me.TabPage2.Controls.Add(Me.LBDNI)
        Me.TabPage2.Controls.Add(Me.LBDomicilio)
        Me.TabPage2.Controls.Add(Me.LBNombre)
        Me.TabPage2.Controls.Add(Me.LBApellido)
        Me.TabPage2.Controls.Add(Me.LBuscar)
        Me.TabPage2.Controls.Add(Me.TBEmail)
        Me.TabPage2.Controls.Add(Me.TBDNI)
        Me.TabPage2.Controls.Add(Me.TBTelefono)
        Me.TabPage2.Controls.Add(Me.TBNombre)
        Me.TabPage2.Controls.Add(Me.TBDomicilio)
        Me.TabPage2.Controls.Add(Me.TBApellido)
        Me.TabPage2.Controls.Add(Me.TBuscar)
        Me.TabPage2.Controls.Add(Me.DataGridCliente)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1156, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar"
        '
        'PBLogo3
        '
        Me.PBLogo3.Image = Global.pcgamer.My.Resources.Resources.pcgamer_readers
        Me.PBLogo3.Location = New System.Drawing.Point(891, 76)
        Me.PBLogo3.Name = "PBLogo3"
        Me.PBLogo3.Size = New System.Drawing.Size(231, 101)
        Me.PBLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo3.TabIndex = 43
        Me.PBLogo3.TabStop = False
        '
        'PBlogo2
        '
        Me.PBlogo2.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo_grande3
        Me.PBlogo2.Location = New System.Drawing.Point(981, 265)
        Me.PBlogo2.Name = "PBlogo2"
        Me.PBlogo2.Size = New System.Drawing.Size(129, 125)
        Me.PBlogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBlogo2.TabIndex = 42
        Me.PBlogo2.TabStop = False
        Me.PBlogo2.Visible = False
        '
        'BAgregarFactura
        '
        Me.BAgregarFactura.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregarFactura.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarFactura.ForeColor = System.Drawing.Color.White
        Me.BAgregarFactura.Location = New System.Drawing.Point(971, 22)
        Me.BAgregarFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregarFactura.Name = "BAgregarFactura"
        Me.BAgregarFactura.Size = New System.Drawing.Size(174, 31)
        Me.BAgregarFactura.TabIndex = 19
        Me.BAgregarFactura.Text = "Agregar a Factura"
        Me.BAgregarFactura.UseVisualStyleBackColor = False
        Me.BAgregarFactura.Visible = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(799, 22)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(95, 31)
        Me.BCancelar.TabIndex = 3
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        Me.BCancelar.Visible = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.DarkRed
        Me.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(944, 22)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(95, 31)
        Me.BGuardar.TabIndex = 4
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
        Me.BEditar.Location = New System.Drawing.Point(641, 19)
        Me.BEditar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(94, 31)
        Me.BEditar.TabIndex = 2
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Apellido y Nombre", "DNI"})
        Me.CBBuscar.Location = New System.Drawing.Point(425, 19)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(203, 28)
        Me.CBBuscar.TabIndex = 1
        '
        'BAlta
        '
        Me.BAlta.BackColor = System.Drawing.Color.DarkRed
        Me.BAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAlta.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAlta.ForeColor = System.Drawing.Color.White
        Me.BAlta.Image = Global.pcgamer.My.Resources.Resources.ok_icono
        Me.BAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAlta.Location = New System.Drawing.Point(974, 265)
        Me.BAlta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(123, 48)
        Me.BAlta.TabIndex = 3
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
        Me.BEliminar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.Color.White
        Me.BEliminar.Image = Global.pcgamer.My.Resources.Resources.cancelar_icono1
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(969, 265)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(153, 48)
        Me.BEliminar.TabIndex = 5
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'LBEmail
        '
        Me.LBEmail.AutoSize = True
        Me.LBEmail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBEmail.ForeColor = System.Drawing.Color.White
        Me.LBEmail.Location = New System.Drawing.Point(481, 158)
        Me.LBEmail.Name = "LBEmail"
        Me.LBEmail.Size = New System.Drawing.Size(54, 18)
        Me.LBEmail.TabIndex = 18
        Me.LBEmail.Text = "Email:"
        '
        'LBTelefono
        '
        Me.LBTelefono.AutoSize = True
        Me.LBTelefono.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTelefono.ForeColor = System.Drawing.Color.White
        Me.LBTelefono.Location = New System.Drawing.Point(479, 118)
        Me.LBTelefono.Name = "LBTelefono"
        Me.LBTelefono.Size = New System.Drawing.Size(77, 18)
        Me.LBTelefono.TabIndex = 17
        Me.LBTelefono.Text = "Telefono:"
        '
        'LBDNI
        '
        Me.LBDNI.AutoSize = True
        Me.LBDNI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDNI.ForeColor = System.Drawing.Color.White
        Me.LBDNI.Location = New System.Drawing.Point(54, 154)
        Me.LBDNI.Name = "LBDNI"
        Me.LBDNI.Size = New System.Drawing.Size(42, 18)
        Me.LBDNI.TabIndex = 15
        Me.LBDNI.Text = "DNI:"
        '
        'LBDomicilio
        '
        Me.LBDomicilio.AutoSize = True
        Me.LBDomicilio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDomicilio.ForeColor = System.Drawing.Color.White
        Me.LBDomicilio.Location = New System.Drawing.Point(479, 77)
        Me.LBDomicilio.Name = "LBDomicilio"
        Me.LBDomicilio.Size = New System.Drawing.Size(74, 18)
        Me.LBDomicilio.TabIndex = 16
        Me.LBDomicilio.Text = "Domicilio"
        '
        'LBNombre
        '
        Me.LBNombre.AutoSize = True
        Me.LBNombre.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNombre.ForeColor = System.Drawing.Color.White
        Me.LBNombre.Location = New System.Drawing.Point(54, 116)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(83, 18)
        Me.LBNombre.TabIndex = 14
        Me.LBNombre.Text = "Nombres:"
        '
        'LBApellido
        '
        Me.LBApellido.AutoSize = True
        Me.LBApellido.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBApellido.ForeColor = System.Drawing.Color.White
        Me.LBApellido.Location = New System.Drawing.Point(54, 77)
        Me.LBApellido.Name = "LBApellido"
        Me.LBApellido.Size = New System.Drawing.Size(79, 18)
        Me.LBApellido.TabIndex = 13
        Me.LBApellido.Text = "Apellidos:"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(39, 22)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 10
        Me.LBuscar.Text = "Buscar:"
        '
        'TBEmail
        '
        Me.TBEmail.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEmail.Location = New System.Drawing.Point(577, 153)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(262, 23)
        Me.TBEmail.TabIndex = 12
        '
        'TBDNI
        '
        Me.TBDNI.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDNI.Location = New System.Drawing.Point(146, 154)
        Me.TBDNI.MaxLength = 8
        Me.TBDNI.Name = "TBDNI"
        Me.TBDNI.ReadOnly = True
        Me.TBDNI.Size = New System.Drawing.Size(255, 23)
        Me.TBDNI.TabIndex = 9
        '
        'TBTelefono
        '
        Me.TBTelefono.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTelefono.Location = New System.Drawing.Point(577, 115)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.ReadOnly = True
        Me.TBTelefono.Size = New System.Drawing.Size(262, 23)
        Me.TBTelefono.TabIndex = 11
        '
        'TBNombre
        '
        Me.TBNombre.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(146, 116)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.ReadOnly = True
        Me.TBNombre.Size = New System.Drawing.Size(255, 23)
        Me.TBNombre.TabIndex = 8
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDomicilio.Location = New System.Drawing.Point(577, 76)
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.ReadOnly = True
        Me.TBDomicilio.Size = New System.Drawing.Size(262, 23)
        Me.TBDomicilio.TabIndex = 10
        '
        'TBApellido
        '
        Me.TBApellido.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBApellido.Location = New System.Drawing.Point(146, 77)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.ReadOnly = True
        Me.TBApellido.Size = New System.Drawing.Size(255, 23)
        Me.TBApellido.TabIndex = 7
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(120, 19)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(281, 28)
        Me.TBuscar.TabIndex = 0
        '
        'DataGridCliente
        '
        Me.DataGridCliente.AllowUserToAddRows = False
        Me.DataGridCliente.AllowUserToDeleteRows = False
        Me.DataGridCliente.AllowUserToResizeColumns = False
        Me.DataGridCliente.AllowUserToResizeRows = False
        Me.DataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCliente.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridCliente.Location = New System.Drawing.Point(1, 234)
        Me.DataGridCliente.MultiSelect = False
        Me.DataGridCliente.Name = "DataGridCliente"
        Me.DataGridCliente.ReadOnly = True
        Me.DataGridCliente.RowTemplate.Height = 24
        Me.DataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridCliente.Size = New System.Drawing.Size(940, 202)
        Me.DataGridCliente.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.BAgregar)
        Me.TabPage1.Controls.Add(Me.BLimpiar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1156, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.FechaReg)
        Me.Panel1.Controls.Add(Me.LFechaReg)
        Me.Panel1.Controls.Add(Me.TEmail)
        Me.Panel1.Controls.Add(Me.LEmail)
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
        Me.Panel1.Location = New System.Drawing.Point(402, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 332)
        Me.Panel1.TabIndex = 21
        '
        'FechaReg
        '
        Me.FechaReg.Enabled = False
        Me.FechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaReg.Location = New System.Drawing.Point(138, 263)
        Me.FechaReg.Name = "FechaReg"
        Me.FechaReg.Size = New System.Drawing.Size(238, 28)
        Me.FechaReg.TabIndex = 28
        '
        'LFechaReg
        '
        Me.LFechaReg.AutoSize = True
        Me.LFechaReg.Location = New System.Drawing.Point(23, 263)
        Me.LFechaReg.Name = "LFechaReg"
        Me.LFechaReg.Size = New System.Drawing.Size(106, 20)
        Me.LFechaReg.TabIndex = 35
        Me.LFechaReg.Text = "Fecha Reg:"
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(138, 220)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(238, 28)
        Me.TEmail.TabIndex = 27
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(23, 223)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(76, 20)
        Me.LEmail.TabIndex = 34
        Me.LEmail.Text = "*Email:"
        '
        'LObligatorio
        '
        Me.LObligatorio.AutoSize = True
        Me.LObligatorio.Font = New System.Drawing.Font("Verdana", 4.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LObligatorio.Location = New System.Drawing.Point(345, 315)
        Me.LObligatorio.Name = "LObligatorio"
        Me.LObligatorio.Size = New System.Drawing.Size(47, 8)
        Me.LObligatorio.TabIndex = 36
        Me.LObligatorio.Text = "*Obligatorio"
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(138, 180)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(238, 28)
        Me.TTelefono.TabIndex = 26
        '
        'TDomicilio
        '
        Me.TDomicilio.Location = New System.Drawing.Point(138, 140)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.Size = New System.Drawing.Size(238, 28)
        Me.TDomicilio.TabIndex = 25
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(138, 100)
        Me.TDni.MaxLength = 8
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(238, 28)
        Me.TDni.TabIndex = 24
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(23, 103)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(62, 20)
        Me.LDni.TabIndex = 31
        Me.LDni.Text = "*DNI:"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(138, 60)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(238, 28)
        Me.TApellido.TabIndex = 23
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(23, 23)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(96, 20)
        Me.LNombre.TabIndex = 29
        Me.LNombre.Text = "*Nombre:"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(138, 20)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(238, 28)
        Me.TNombre.TabIndex = 22
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(23, 63)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(97, 20)
        Me.LApellido.TabIndex = 30
        Me.LApellido.Text = "*Apellido:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(23, 183)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(87, 20)
        Me.LTelefono.TabIndex = 33
        Me.LTelefono.Text = "Telefono:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Location = New System.Drawing.Point(23, 143)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(107, 20)
        Me.LDomicilio.TabIndex = 32
        Me.LDomicilio.Text = "*Domicilio:"
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(628, 370)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(166, 32)
        Me.BAgregar.TabIndex = 38
        Me.BAgregar.Text = "Agregar Cliente"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.BLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLimpiar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiar.ForeColor = System.Drawing.Color.White
        Me.BLimpiar.Location = New System.Drawing.Point(429, 370)
        Me.BLimpiar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(166, 32)
        Me.BLimpiar.TabIndex = 37
        Me.BLimpiar.Text = "Limpiar Registro"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(999, 646)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(150, 18)
        Me.LApeyNom.TabIndex = 30
        Me.LApeyNom.Text = "APELLIDO, Nombre"
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LRol.Location = New System.Drawing.Point(863, 644)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(139, 20)
        Me.LRol.TabIndex = 29
        Me.LRol.Text = "Administrador:"
        '
        'FormularioAdminCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.TabCliente)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormularioAdminCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Admin Cliente"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCliente.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PBLogo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBlogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTitulo As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents TabCliente As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FechaReg As DateTimePicker
    Friend WithEvents LFechaReg As Label
    Friend WithEvents TEmail As TextBox
    Friend WithEvents LEmail As Label
    Friend WithEvents LObligatorio As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDomicilio As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDomicilio As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEditar As Button
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents BEliminar As Button
    Friend WithEvents LBEmail As Label
    Friend WithEvents LBTelefono As Label
    Friend WithEvents LBDNI As Label
    Friend WithEvents LBDomicilio As Label
    Friend WithEvents LBNombre As Label
    Friend WithEvents LBApellido As Label
    Friend WithEvents LBuscar As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBDomicilio As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents DataGridCliente As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BAlta As Button
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
    Friend WithEvents BAgregarFactura As Button
    Friend WithEvents PBLogo3 As PictureBox
    Friend WithEvents PBlogo2 As PictureBox
End Class
