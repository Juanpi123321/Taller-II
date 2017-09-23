<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioStock))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.DataGridStock = New System.Windows.Forms.DataGridView()
        Me.codpro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LProcesador = New System.Windows.Forms.Label()
        Me.LPlacaMadre = New System.Windows.Forms.Label()
        Me.LRam = New System.Windows.Forms.Label()
        Me.LPlacaVideo = New System.Windows.Forms.Label()
        Me.LDiscoRigido = New System.Windows.Forms.Label()
        Me.LGabinete = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.TNombre = New System.Windows.Forms.Label()
        Me.TProcesador = New System.Windows.Forms.Label()
        Me.TPlacaMadre = New System.Windows.Forms.Label()
        Me.TRam = New System.Windows.Forms.Label()
        Me.TStock = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TPrecio = New System.Windows.Forms.Label()
        Me.TGabinete = New System.Windows.Forms.Label()
        Me.BAgregarFactura = New System.Windows.Forms.Button()
        Me.TDiscoRigido = New System.Windows.Forms.Label()
        Me.TPlacaVideo = New System.Windows.Forms.Label()
        Me.TCategoria = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(794, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 2
        Me.PBLogo.TabStop = False
        '
        'DataGridStock
        '
        Me.DataGridStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codpro, Me.nombre, Me.stock, Me.precio, Me.categoria})
        Me.DataGridStock.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridStock.Location = New System.Drawing.Point(3, 272)
        Me.DataGridStock.Name = "DataGridStock"
        Me.DataGridStock.ReadOnly = True
        Me.DataGridStock.RowTemplate.Height = 24
        Me.DataGridStock.Size = New System.Drawing.Size(880, 244)
        Me.DataGridStock.TabIndex = 4
        '
        'codpro
        '
        Me.codpro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.codpro.DefaultCellStyle = DataGridViewCellStyle1
        Me.codpro.HeaderText = "CodProd"
        Me.codpro.Name = "codpro"
        Me.codpro.ReadOnly = True
        Me.codpro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codpro.Width = 109
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'stock
        '
        Me.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.stock.DefaultCellStyle = DataGridViewCellStyle3
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stock.Width = 86
        '
        'precio
        '
        Me.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.precio.HeaderText = "Precio  $"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precio.Width = 93
        '
        'categoria
        '
        Me.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.categoria.DefaultCellStyle = DataGridViewCellStyle5
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PBImagen
        '
        Me.PBImagen.BackgroundImage = Global.pcgamer.My.Resources.Resources.gabinete2
        Me.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagen.Location = New System.Drawing.Point(700, 63)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(183, 188)
        Me.PBImagen.TabIndex = 1
        Me.PBImagen.TabStop = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(15, 63)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(85, 20)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'LProcesador
        '
        Me.LProcesador.AutoSize = True
        Me.LProcesador.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProcesador.Location = New System.Drawing.Point(15, 101)
        Me.LProcesador.Name = "LProcesador"
        Me.LProcesador.Size = New System.Drawing.Size(110, 20)
        Me.LProcesador.TabIndex = 2
        Me.LProcesador.Text = "Procesador:"
        '
        'LPlacaMadre
        '
        Me.LPlacaMadre.AutoSize = True
        Me.LPlacaMadre.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPlacaMadre.Location = New System.Drawing.Point(15, 142)
        Me.LPlacaMadre.Name = "LPlacaMadre"
        Me.LPlacaMadre.Size = New System.Drawing.Size(119, 20)
        Me.LPlacaMadre.TabIndex = 2
        Me.LPlacaMadre.Text = "Placa Madre:"
        '
        'LRam
        '
        Me.LRam.AutoSize = True
        Me.LRam.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRam.Location = New System.Drawing.Point(15, 184)
        Me.LRam.Name = "LRam"
        Me.LRam.Size = New System.Drawing.Size(56, 20)
        Me.LRam.TabIndex = 2
        Me.LRam.Text = "Ram:"
        '
        'LPlacaVideo
        '
        Me.LPlacaVideo.AutoSize = True
        Me.LPlacaVideo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPlacaVideo.Location = New System.Drawing.Point(378, 101)
        Me.LPlacaVideo.Name = "LPlacaVideo"
        Me.LPlacaVideo.Size = New System.Drawing.Size(115, 20)
        Me.LPlacaVideo.TabIndex = 2
        Me.LPlacaVideo.Text = "Placa Video:"
        '
        'LDiscoRigido
        '
        Me.LDiscoRigido.AutoSize = True
        Me.LDiscoRigido.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiscoRigido.Location = New System.Drawing.Point(378, 147)
        Me.LDiscoRigido.Name = "LDiscoRigido"
        Me.LDiscoRigido.Size = New System.Drawing.Size(123, 20)
        Me.LDiscoRigido.TabIndex = 2
        Me.LDiscoRigido.Text = "Disco Rigido:"
        '
        'LGabinete
        '
        Me.LGabinete.AutoSize = True
        Me.LGabinete.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGabinete.Location = New System.Drawing.Point(378, 189)
        Me.LGabinete.Name = "LGabinete"
        Me.LGabinete.Size = New System.Drawing.Size(94, 20)
        Me.LGabinete.TabIndex = 2
        Me.LGabinete.Text = "Gabinete:"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(18, 227)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(65, 20)
        Me.LStock.TabIndex = 2
        Me.LStock.Text = "Stock:"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.Location = New System.Drawing.Point(378, 227)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(68, 20)
        Me.LPrecio.TabIndex = 2
        Me.LPrecio.Text = "Precio:"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(378, 63)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(99, 20)
        Me.LCategoria.TabIndex = 2
        Me.LCategoria.Text = "Categoria:"
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(99, 16)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(252, 28)
        Me.TBuscar.TabIndex = 0
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.BackColor = System.Drawing.Color.Black
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(18, 19)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 14
        Me.LBuscar.Text = "Buscar:"
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Nombre", "Categoria", "Id_producto", "Procesador", "Placa Madre", "Ram", "Placa Video", "Disco Rigido", "Gabinete "})
        Me.CBBuscar.Location = New System.Drawing.Point(382, 17)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(196, 28)
        Me.CBBuscar.TabIndex = 1
        '
        'TNombre
        '
        Me.TNombre.AutoSize = True
        Me.TNombre.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(136, 69)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(123, 14)
        Me.TNombre.TabIndex = 17
        Me.TNombre.Text = "     ************"
        '
        'TProcesador
        '
        Me.TProcesador.AutoSize = True
        Me.TProcesador.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TProcesador.Location = New System.Drawing.Point(136, 107)
        Me.TProcesador.Name = "TProcesador"
        Me.TProcesador.Size = New System.Drawing.Size(123, 14)
        Me.TProcesador.TabIndex = 17
        Me.TProcesador.Text = "     ************"
        '
        'TPlacaMadre
        '
        Me.TPlacaMadre.AutoSize = True
        Me.TPlacaMadre.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlacaMadre.Location = New System.Drawing.Point(136, 148)
        Me.TPlacaMadre.Name = "TPlacaMadre"
        Me.TPlacaMadre.Size = New System.Drawing.Size(123, 14)
        Me.TPlacaMadre.TabIndex = 17
        Me.TPlacaMadre.Text = "     ************"
        '
        'TRam
        '
        Me.TRam.AutoSize = True
        Me.TRam.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRam.Location = New System.Drawing.Point(136, 190)
        Me.TRam.Name = "TRam"
        Me.TRam.Size = New System.Drawing.Size(123, 14)
        Me.TRam.TabIndex = 17
        Me.TRam.Text = "     ************"
        '
        'TStock
        '
        Me.TStock.AutoSize = True
        Me.TStock.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStock.Location = New System.Drawing.Point(136, 233)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(123, 14)
        Me.TStock.TabIndex = 17
        Me.TStock.Text = "     ************"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TPrecio)
        Me.Panel1.Controls.Add(Me.TStock)
        Me.Panel1.Controls.Add(Me.TGabinete)
        Me.Panel1.Controls.Add(Me.BAgregarFactura)
        Me.Panel1.Controls.Add(Me.TDiscoRigido)
        Me.Panel1.Controls.Add(Me.TRam)
        Me.Panel1.Controls.Add(Me.TPlacaVideo)
        Me.Panel1.Controls.Add(Me.TPlacaMadre)
        Me.Panel1.Controls.Add(Me.TCategoria)
        Me.Panel1.Controls.Add(Me.TProcesador)
        Me.Panel1.Controls.Add(Me.TNombre)
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
        Me.Panel1.Location = New System.Drawing.Point(78, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 518)
        Me.Panel1.TabIndex = 3
        '
        'TPrecio
        '
        Me.TPrecio.AutoSize = True
        Me.TPrecio.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecio.Location = New System.Drawing.Point(497, 233)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(123, 14)
        Me.TPrecio.TabIndex = 17
        Me.TPrecio.Text = "     ************"
        '
        'TGabinete
        '
        Me.TGabinete.AutoSize = True
        Me.TGabinete.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGabinete.Location = New System.Drawing.Point(497, 190)
        Me.TGabinete.Name = "TGabinete"
        Me.TGabinete.Size = New System.Drawing.Size(123, 14)
        Me.TGabinete.TabIndex = 17
        Me.TGabinete.Text = "     ************"
        '
        'BAgregarFactura
        '
        Me.BAgregarFactura.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregarFactura.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarFactura.ForeColor = System.Drawing.Color.White
        Me.BAgregarFactura.Location = New System.Drawing.Point(689, 16)
        Me.BAgregarFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregarFactura.Name = "BAgregarFactura"
        Me.BAgregarFactura.Size = New System.Drawing.Size(174, 32)
        Me.BAgregarFactura.TabIndex = 3
        Me.BAgregarFactura.Text = "Agregar a Factura"
        Me.BAgregarFactura.UseVisualStyleBackColor = False
        '
        'TDiscoRigido
        '
        Me.TDiscoRigido.AutoSize = True
        Me.TDiscoRigido.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDiscoRigido.Location = New System.Drawing.Point(497, 148)
        Me.TDiscoRigido.Name = "TDiscoRigido"
        Me.TDiscoRigido.Size = New System.Drawing.Size(123, 14)
        Me.TDiscoRigido.TabIndex = 17
        Me.TDiscoRigido.Text = "     ************"
        '
        'TPlacaVideo
        '
        Me.TPlacaVideo.AutoSize = True
        Me.TPlacaVideo.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPlacaVideo.Location = New System.Drawing.Point(497, 107)
        Me.TPlacaVideo.Name = "TPlacaVideo"
        Me.TPlacaVideo.Size = New System.Drawing.Size(123, 14)
        Me.TPlacaVideo.TabIndex = 17
        Me.TPlacaVideo.Text = "     ************"
        '
        'TCategoria
        '
        Me.TCategoria.AutoSize = True
        Me.TCategoria.Font = New System.Drawing.Font("Verdana", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCategoria.Location = New System.Drawing.Point(497, 69)
        Me.TCategoria.Name = "TCategoria"
        Me.TCategoria.Size = New System.Drawing.Size(123, 14)
        Me.TCategoria.TabIndex = 17
        Me.TCategoria.Text = "     ************"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(376, 51)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(280, 40)
        Me.LTitulo.TabIndex = 13
        Me.LTitulo.Text = "Consultar Stock"
        '
        'FormularioStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 673)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(150, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Stock"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents DataGridStock As DataGridView
    Friend WithEvents PBImagen As PictureBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LProcesador As Label
    Friend WithEvents LPlacaMadre As Label
    Friend WithEvents LRam As Label
    Friend WithEvents LPlacaVideo As Label
    Friend WithEvents LDiscoRigido As Label
    Friend WithEvents LGabinete As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents LBuscar As Label
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents TNombre As Label
    Friend WithEvents TProcesador As Label
    Friend WithEvents TPlacaMadre As Label
    Friend WithEvents TRam As Label
    Friend WithEvents TStock As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents TPrecio As Label
    Friend WithEvents TGabinete As Label
    Friend WithEvents TDiscoRigido As Label
    Friend WithEvents TPlacaVideo As Label
    Friend WithEvents TCategoria As Label
    Friend WithEvents BAgregarFactura As Button
    Friend WithEvents codpro As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
End Class
