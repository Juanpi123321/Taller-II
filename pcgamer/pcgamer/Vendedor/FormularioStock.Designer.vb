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
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.BGenerarFactura = New System.Windows.Forms.Button()
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
        Me.DataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codpro, Me.nombre, Me.stock, Me.precio, Me.categoria})
        Me.DataGridStock.Location = New System.Drawing.Point(3, 272)
        Me.DataGridStock.Name = "DataGridStock"
        Me.DataGridStock.RowTemplate.Height = 24
        Me.DataGridStock.Size = New System.Drawing.Size(701, 142)
        Me.DataGridStock.TabIndex = 4
        '
        'codpro
        '
        Me.codpro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codpro.HeaderText = "CodProd"
        Me.codpro.Name = "codpro"
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'stock
        '
        Me.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'precio
        '
        Me.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'categoria
        '
        Me.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        '
        'PBImagen
        '
        Me.PBImagen.BackgroundImage = Global.pcgamer.My.Resources.Resources.gabinete2
        Me.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagen.Location = New System.Drawing.Point(521, 63)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(183, 171)
        Me.PBImagen.TabIndex = 1
        Me.PBImagen.TabStop = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(15, 63)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(85, 20)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'LProcesador
        '
        Me.LProcesador.AutoSize = True
        Me.LProcesador.Location = New System.Drawing.Point(15, 101)
        Me.LProcesador.Name = "LProcesador"
        Me.LProcesador.Size = New System.Drawing.Size(110, 20)
        Me.LProcesador.TabIndex = 2
        Me.LProcesador.Text = "Procesador:"
        '
        'LPlacaMadre
        '
        Me.LPlacaMadre.AutoSize = True
        Me.LPlacaMadre.Location = New System.Drawing.Point(15, 142)
        Me.LPlacaMadre.Name = "LPlacaMadre"
        Me.LPlacaMadre.Size = New System.Drawing.Size(119, 20)
        Me.LPlacaMadre.TabIndex = 2
        Me.LPlacaMadre.Text = "Placa Madre:"
        '
        'LRam
        '
        Me.LRam.AutoSize = True
        Me.LRam.Location = New System.Drawing.Point(15, 184)
        Me.LRam.Name = "LRam"
        Me.LRam.Size = New System.Drawing.Size(56, 20)
        Me.LRam.TabIndex = 2
        Me.LRam.Text = "Ram:"
        '
        'LPlacaVideo
        '
        Me.LPlacaVideo.AutoSize = True
        Me.LPlacaVideo.Location = New System.Drawing.Point(268, 101)
        Me.LPlacaVideo.Name = "LPlacaVideo"
        Me.LPlacaVideo.Size = New System.Drawing.Size(115, 20)
        Me.LPlacaVideo.TabIndex = 2
        Me.LPlacaVideo.Text = "Placa Video:"
        '
        'LDiscoRigido
        '
        Me.LDiscoRigido.AutoSize = True
        Me.LDiscoRigido.Location = New System.Drawing.Point(268, 147)
        Me.LDiscoRigido.Name = "LDiscoRigido"
        Me.LDiscoRigido.Size = New System.Drawing.Size(123, 20)
        Me.LDiscoRigido.TabIndex = 2
        Me.LDiscoRigido.Text = "Disco Rigido:"
        '
        'LGabinete
        '
        Me.LGabinete.AutoSize = True
        Me.LGabinete.Location = New System.Drawing.Point(268, 189)
        Me.LGabinete.Name = "LGabinete"
        Me.LGabinete.Size = New System.Drawing.Size(94, 20)
        Me.LGabinete.TabIndex = 2
        Me.LGabinete.Text = "Gabinete:"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(18, 227)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(65, 20)
        Me.LStock.TabIndex = 2
        Me.LStock.Text = "Stock:"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(268, 227)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(68, 20)
        Me.LPrecio.TabIndex = 2
        Me.LPrecio.Text = "Precio:"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(268, 63)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(99, 20)
        Me.LCategoria.TabIndex = 2
        Me.LCategoria.Text = "Categoria:"
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(99, 16)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(229, 28)
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
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.DarkRed
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBuscar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Location = New System.Drawing.Point(473, 16)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(38, 32)
        Me.BBuscar.TabIndex = 3
        Me.BBuscar.Text = "Poner icono buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Nombre", "Categoria", "Id_producto", "Procesador", "Placa Madre", "Ram", "Placa Video", "Disco Rigido", "Gabinete "})
        Me.CBBuscar.Location = New System.Drawing.Point(345, 16)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(121, 28)
        Me.CBBuscar.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(148, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "******"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(148, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "******"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(148, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "******"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(148, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 20)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "******"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(148, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "******"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.BGenerarFactura)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CBBuscar)
        Me.Panel1.Controls.Add(Me.BBuscar)
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
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(174, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 414)
        Me.Panel1.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(408, 227)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 20)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "******"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(408, 184)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 20)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "******"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(408, 142)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "******"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(408, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "******"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(408, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 20)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "******"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(336, 26)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(280, 40)
        Me.LTitulo.TabIndex = 13
        Me.LTitulo.Text = "Consultar Stock"
        '
        'BGenerarFactura
        '
        Me.BGenerarFactura.BackColor = System.Drawing.Color.DarkRed
        Me.BGenerarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BGenerarFactura.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGenerarFactura.ForeColor = System.Drawing.Color.White
        Me.BGenerarFactura.Location = New System.Drawing.Point(545, 16)
        Me.BGenerarFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BGenerarFactura.Name = "BGenerarFactura"
        Me.BGenerarFactura.Size = New System.Drawing.Size(159, 32)
        Me.BGenerarFactura.TabIndex = 3
        Me.BGenerarFactura.Text = "Generar Factura"
        Me.BGenerarFactura.UseVisualStyleBackColor = False
        '
        'FormularioStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 593)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioStock"
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
    Friend WithEvents codpro As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
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
    Friend WithEvents BBuscar As Button
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BGenerarFactura As Button
End Class
