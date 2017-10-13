<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAdminStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioAdminStock))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BAgregarFactura = New System.Windows.Forms.Button()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.TGabinete = New System.Windows.Forms.ComboBox()
        Me.TDiscoRigido = New System.Windows.Forms.ComboBox()
        Me.TPlacaVideo = New System.Windows.Forms.ComboBox()
        Me.TProcesador = New System.Windows.Forms.ComboBox()
        Me.TPlacaMadre = New System.Windows.Forms.ComboBox()
        Me.TRam = New System.Windows.Forms.ComboBox()
        Me.TCategoria = New System.Windows.Forms.ComboBox()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BCancelarAgregar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LGabinete = New System.Windows.Forms.Label()
        Me.LDiscoRigido = New System.Windows.Forms.Label()
        Me.LPlacaVideo = New System.Windows.Forms.Label()
        Me.LRam = New System.Windows.Forms.Label()
        Me.LPlacaMadre = New System.Windows.Forms.Label()
        Me.LProcesador = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.DataGridStock = New System.Windows.Forms.DataGridView()
        Me.BBaja = New System.Windows.Forms.Button()
        Me.BAlta = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(376, 51)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(352, 40)
        Me.LTitulo.TabIndex = 22
        Me.LTitulo.Text = "Gestionar Productos"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(872, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 14
        Me.PBLogo.TabStop = False
        Me.PBLogo.Tag = "21"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BAgregarFactura)
        Me.Panel1.Controls.Add(Me.TStock)
        Me.Panel1.Controls.Add(Me.TGabinete)
        Me.Panel1.Controls.Add(Me.TDiscoRigido)
        Me.Panel1.Controls.Add(Me.TPlacaVideo)
        Me.Panel1.Controls.Add(Me.TProcesador)
        Me.Panel1.Controls.Add(Me.TPlacaMadre)
        Me.Panel1.Controls.Add(Me.TRam)
        Me.Panel1.Controls.Add(Me.TCategoria)
        Me.Panel1.Controls.Add(Me.TPrecio)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BGuardar)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.BCancelarAgregar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.CBBuscar)
        Me.Panel1.Controls.Add(Me.LBuscar)
        Me.Panel1.Controls.Add(Me.TBuscar)
        Me.Panel1.Controls.Add(Me.LCategoria)
        Me.Panel1.Controls.Add(Me.LPrecio)
        Me.Panel1.Controls.Add(Me.LStock)
        Me.Panel1.Controls.Add(Me.LGabinete)
        Me.Panel1.Controls.Add(Me.LDiscoRigido)
        Me.Panel1.Controls.Add(Me.LPlacaVideo)
        Me.Panel1.Controls.Add(Me.LRam)
        Me.Panel1.Controls.Add(Me.LPlacaMadre)
        Me.Panel1.Controls.Add(Me.LProcesador)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.PBImagen)
        Me.Panel1.Controls.Add(Me.DataGridStock)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(48, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 464)
        Me.Panel1.TabIndex = 18
        '
        'BAgregarFactura
        '
        Me.BAgregarFactura.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregarFactura.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarFactura.ForeColor = System.Drawing.Color.White
        Me.BAgregarFactura.Location = New System.Drawing.Point(807, 15)
        Me.BAgregarFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregarFactura.Name = "BAgregarFactura"
        Me.BAgregarFactura.Size = New System.Drawing.Size(174, 32)
        Me.BAgregarFactura.TabIndex = 48
        Me.BAgregarFactura.Text = "Agregar a Factura"
        Me.BAgregarFactura.UseVisualStyleBackColor = False
        Me.BAgregarFactura.Visible = False
        '
        'TStock
        '
        Me.TStock.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStock.Location = New System.Drawing.Point(113, 224)
        Me.TStock.MaxLength = 3
        Me.TStock.Name = "TStock"
        Me.TStock.ReadOnly = True
        Me.TStock.Size = New System.Drawing.Size(272, 22)
        Me.TStock.TabIndex = 47
        '
        'TGabinete
        '
        Me.TGabinete.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGabinete.FormattingEnabled = True
        Me.TGabinete.Location = New System.Drawing.Point(497, 183)
        Me.TGabinete.Name = "TGabinete"
        Me.TGabinete.Size = New System.Drawing.Size(285, 22)
        Me.TGabinete.TabIndex = 46
        '
        'TDiscoRigido
        '
        Me.TDiscoRigido.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDiscoRigido.FormattingEnabled = True
        Me.TDiscoRigido.Location = New System.Drawing.Point(497, 144)
        Me.TDiscoRigido.Name = "TDiscoRigido"
        Me.TDiscoRigido.Size = New System.Drawing.Size(285, 22)
        Me.TDiscoRigido.TabIndex = 45
        '
        'TPlacaVideo
        '
        Me.TPlacaVideo.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlacaVideo.FormattingEnabled = True
        Me.TPlacaVideo.Location = New System.Drawing.Point(497, 102)
        Me.TPlacaVideo.Name = "TPlacaVideo"
        Me.TPlacaVideo.Size = New System.Drawing.Size(285, 22)
        Me.TPlacaVideo.TabIndex = 44
        '
        'TProcesador
        '
        Me.TProcesador.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TProcesador.FormattingEnabled = True
        Me.TProcesador.Location = New System.Drawing.Point(113, 102)
        Me.TProcesador.Name = "TProcesador"
        Me.TProcesador.Size = New System.Drawing.Size(272, 22)
        Me.TProcesador.TabIndex = 42
        '
        'TPlacaMadre
        '
        Me.TPlacaMadre.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlacaMadre.FormattingEnabled = True
        Me.TPlacaMadre.Location = New System.Drawing.Point(113, 144)
        Me.TPlacaMadre.Name = "TPlacaMadre"
        Me.TPlacaMadre.Size = New System.Drawing.Size(272, 22)
        Me.TPlacaMadre.TabIndex = 42
        '
        'TRam
        '
        Me.TRam.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRam.FormattingEnabled = True
        Me.TRam.Location = New System.Drawing.Point(113, 183)
        Me.TRam.Name = "TRam"
        Me.TRam.Size = New System.Drawing.Size(272, 22)
        Me.TRam.TabIndex = 42
        '
        'TCategoria
        '
        Me.TCategoria.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCategoria.FormattingEnabled = True
        Me.TCategoria.Location = New System.Drawing.Point(497, 64)
        Me.TCategoria.Name = "TCategoria"
        Me.TCategoria.Size = New System.Drawing.Size(285, 22)
        Me.TCategoria.TabIndex = 13
        '
        'TPrecio
        '
        Me.TPrecio.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecio.Location = New System.Drawing.Point(497, 224)
        Me.TPrecio.MaxLength = 8
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.ReadOnly = True
        Me.TPrecio.Size = New System.Drawing.Size(285, 22)
        Me.TPrecio.TabIndex = 17
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(113, 66)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.ReadOnly = True
        Me.TNombre.Size = New System.Drawing.Size(272, 22)
        Me.TNombre.TabIndex = 8
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Image = Global.pcgamer.My.Resources.Resources.cancelar_icono1
        Me.BCancelar.Location = New System.Drawing.Point(736, 6)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(54, 48)
        Me.BCancelar.TabIndex = 36
        Me.BCancelar.UseVisualStyleBackColor = False
        Me.BCancelar.Visible = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.DarkRed
        Me.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGuardar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Image = Global.pcgamer.My.Resources.Resources.ok_icono
        Me.BGuardar.Location = New System.Drawing.Point(824, 7)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(52, 47)
        Me.BGuardar.TabIndex = 4
        Me.BGuardar.UseVisualStyleBackColor = False
        Me.BGuardar.Visible = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.DarkRed
        Me.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BNuevo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNuevo.ForeColor = System.Drawing.Color.White
        Me.BNuevo.Location = New System.Drawing.Point(681, 15)
        Me.BNuevo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(118, 32)
        Me.BNuevo.TabIndex = 35
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(864, 17)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(97, 32)
        Me.BAgregar.TabIndex = 40
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        Me.BAgregar.Visible = False
        '
        'BCancelarAgregar
        '
        Me.BCancelarAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BCancelarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCancelarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelarAgregar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarAgregar.ForeColor = System.Drawing.Color.White
        Me.BCancelarAgregar.Location = New System.Drawing.Point(741, 17)
        Me.BCancelarAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCancelarAgregar.Name = "BCancelarAgregar"
        Me.BCancelarAgregar.Size = New System.Drawing.Size(96, 32)
        Me.BCancelarAgregar.TabIndex = 34
        Me.BCancelarAgregar.Text = "Cancelar"
        Me.BCancelarAgregar.UseVisualStyleBackColor = False
        Me.BCancelarAgregar.Visible = False
        '
        'BEditar
        '
        Me.BEditar.BackColor = System.Drawing.Color.DarkRed
        Me.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEditar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditar.ForeColor = System.Drawing.Color.White
        Me.BEditar.Location = New System.Drawing.Point(564, 15)
        Me.BEditar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(101, 32)
        Me.BEditar.TabIndex = 33
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Nombre Producto", "Categoria", "Procesador", "Placa Madre", "Ram", "Placa Video", "Disco Rigido", "Gabinete "})
        Me.CBBuscar.Location = New System.Drawing.Point(371, 17)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(186, 28)
        Me.CBBuscar.TabIndex = 1
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.BackColor = System.Drawing.Color.Black
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(18, 19)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 21
        Me.LBuscar.Text = "Buscar:"
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(99, 16)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(250, 28)
        Me.TBuscar.TabIndex = 0
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(391, 68)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(81, 17)
        Me.LCategoria.TabIndex = 28
        Me.LCategoria.Text = "Categoria:"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.Location = New System.Drawing.Point(391, 226)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(69, 17)
        Me.LPrecio.TabIndex = 32
        Me.LPrecio.Text = "Precio: $"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(19, 224)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(54, 17)
        Me.LStock.TabIndex = 27
        Me.LStock.Text = "Stock:"
        '
        'LGabinete
        '
        Me.LGabinete.AutoSize = True
        Me.LGabinete.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGabinete.Location = New System.Drawing.Point(391, 186)
        Me.LGabinete.Name = "LGabinete"
        Me.LGabinete.Size = New System.Drawing.Size(76, 17)
        Me.LGabinete.TabIndex = 31
        Me.LGabinete.Text = "Gabinete:"
        '
        'LDiscoRigido
        '
        Me.LDiscoRigido.AutoSize = True
        Me.LDiscoRigido.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiscoRigido.Location = New System.Drawing.Point(391, 144)
        Me.LDiscoRigido.Name = "LDiscoRigido"
        Me.LDiscoRigido.Size = New System.Drawing.Size(100, 17)
        Me.LDiscoRigido.TabIndex = 30
        Me.LDiscoRigido.Text = "Disco Rigido:"
        '
        'LPlacaVideo
        '
        Me.LPlacaVideo.AutoSize = True
        Me.LPlacaVideo.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPlacaVideo.Location = New System.Drawing.Point(391, 105)
        Me.LPlacaVideo.Name = "LPlacaVideo"
        Me.LPlacaVideo.Size = New System.Drawing.Size(92, 17)
        Me.LPlacaVideo.TabIndex = 29
        Me.LPlacaVideo.Text = "Placa Video:"
        '
        'LRam
        '
        Me.LRam.AutoSize = True
        Me.LRam.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRam.Location = New System.Drawing.Point(19, 186)
        Me.LRam.Name = "LRam"
        Me.LRam.Size = New System.Drawing.Size(45, 17)
        Me.LRam.TabIndex = 26
        Me.LRam.Text = "Ram:"
        '
        'LPlacaMadre
        '
        Me.LPlacaMadre.AutoSize = True
        Me.LPlacaMadre.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPlacaMadre.Location = New System.Drawing.Point(15, 144)
        Me.LPlacaMadre.Name = "LPlacaMadre"
        Me.LPlacaMadre.Size = New System.Drawing.Size(95, 17)
        Me.LPlacaMadre.TabIndex = 25
        Me.LPlacaMadre.Text = "Placa Madre:"
        '
        'LProcesador
        '
        Me.LProcesador.AutoSize = True
        Me.LProcesador.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProcesador.Location = New System.Drawing.Point(15, 103)
        Me.LProcesador.Name = "LProcesador"
        Me.LProcesador.Size = New System.Drawing.Size(92, 17)
        Me.LProcesador.TabIndex = 24
        Me.LProcesador.Text = "Procesador:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(15, 65)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(69, 17)
        Me.LNombre.TabIndex = 23
        Me.LNombre.Text = "Nombre:"
        '
        'PBImagen
        '
        Me.PBImagen.BackgroundImage = Global.pcgamer.My.Resources.Resources.gabinete2
        Me.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagen.Location = New System.Drawing.Point(793, 62)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(183, 188)
        Me.PBImagen.TabIndex = 1
        Me.PBImagen.TabStop = False
        '
        'DataGridStock
        '
        Me.DataGridStock.AllowUserToAddRows = False
        Me.DataGridStock.AllowUserToDeleteRows = False
        Me.DataGridStock.AllowUserToResizeColumns = False
        Me.DataGridStock.AllowUserToResizeRows = False
        Me.DataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridStock.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridStock.Location = New System.Drawing.Point(3, 272)
        Me.DataGridStock.MultiSelect = False
        Me.DataGridStock.Name = "DataGridStock"
        Me.DataGridStock.ReadOnly = True
        Me.DataGridStock.RowTemplate.Height = 24
        Me.DataGridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridStock.Size = New System.Drawing.Size(978, 189)
        Me.DataGridStock.TabIndex = 22
        '
        'BBaja
        '
        Me.BBaja.BackColor = System.Drawing.Color.DarkRed
        Me.BBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBaja.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBaja.ForeColor = System.Drawing.Color.White
        Me.BBaja.Image = Global.pcgamer.My.Resources.Resources.cancelar_icono1
        Me.BBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBaja.Location = New System.Drawing.Point(864, 587)
        Me.BBaja.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BBaja.Name = "BBaja"
        Me.BBaja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BBaja.Size = New System.Drawing.Size(164, 48)
        Me.BBaja.TabIndex = 42
        Me.BBaja.Text = "Baja Prod"
        Me.BBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBaja.UseVisualStyleBackColor = False
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
        Me.BAlta.Location = New System.Drawing.Point(864, 587)
        Me.BAlta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(164, 48)
        Me.BAlta.TabIndex = 41
        Me.BAlta.Text = "Alta Prod"
        Me.BAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAlta.UseVisualStyleBackColor = False
        Me.BAlta.Visible = False
        '
        'FormularioAdminStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.BAlta)
        Me.Controls.Add(Me.BBaja)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(150, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioAdminStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "20"
        Me.Text = "Formulario Admin Stock"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BEditar As Button
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents LBuscar As Label
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LGabinete As Label
    Friend WithEvents LDiscoRigido As Label
    Friend WithEvents LPlacaVideo As Label
    Friend WithEvents LRam As Label
    Friend WithEvents LPlacaMadre As Label
    Friend WithEvents LProcesador As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents PBImagen As PictureBox
    Friend WithEvents BNuevo As Button
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BBaja As Button
    Friend WithEvents BAlta As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents BCancelarAgregar As Button
    Friend WithEvents TCategoria As ComboBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents TGabinete As ComboBox
    Friend WithEvents TDiscoRigido As ComboBox
    Friend WithEvents TPlacaVideo As ComboBox
    Friend WithEvents TRam As ComboBox
    Friend WithEvents DataGridStock As DataGridView
    Friend WithEvents TProcesador As ComboBox
    Friend WithEvents TPlacaMadre As ComboBox
    Friend WithEvents BAgregarFactura As Button
End Class
