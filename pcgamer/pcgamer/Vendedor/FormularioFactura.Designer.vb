<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFactura))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.TTotal = New System.Windows.Forms.Label()
        Me.DataGridFactura = New System.Windows.Forms.DataGridView()
        Me.Id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadmedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.punitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LFactura4 = New System.Windows.Forms.Label()
        Me.LFactura6 = New System.Windows.Forms.Label()
        Me.LFactura5 = New System.Windows.Forms.Label()
        Me.LFactura3 = New System.Windows.Forms.Label()
        Me.LFactura1 = New System.Windows.Forms.Label()
        Me.TFechaHora = New System.Windows.Forms.Label()
        Me.LFactura7 = New System.Windows.Forms.Label()
        Me.LFactura2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBFormaPago = New System.Windows.Forms.ComboBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.Label()
        Me.TDomicilio = New System.Windows.Forms.Label()
        Me.TDNI = New System.Windows.Forms.Label()
        Me.TCliente = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LEmpresa5 = New System.Windows.Forms.Label()
        Me.LEmpresa4 = New System.Windows.Forms.Label()
        Me.LEmpresa3 = New System.Windows.Forms.Label()
        Me.LEmpresa2 = New System.Windows.Forms.Label()
        Me.LEmpresa1 = New System.Windows.Forms.Label()
        Me.PBEmpresa = New System.Windows.Forms.PictureBox()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 2
        Me.PBLogo.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(494, 14)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(284, 40)
        Me.LTitulo.TabIndex = 13
        Me.LTitulo.Text = "Generar Factura"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LTotal)
        Me.Panel1.Controls.Add(Me.TTotal)
        Me.Panel1.Controls.Add(Me.DataGridFactura)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(223, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 520)
        Me.Panel1.TabIndex = 14
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.BackColor = System.Drawing.Color.White
        Me.LTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTotal.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(528, 476)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(113, 31)
        Me.LTotal.TabIndex = 15
        Me.LTotal.Text = "TOTAL $"
        '
        'TTotal
        '
        Me.TTotal.AutoSize = True
        Me.TTotal.BackColor = System.Drawing.Color.White
        Me.TTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTotal.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTotal.Location = New System.Drawing.Point(635, 476)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(30, 31)
        Me.TTotal.TabIndex = 16
        Me.TTotal.Text = "0"
        '
        'DataGridFactura
        '
        Me.DataGridFactura.AllowUserToAddRows = False
        Me.DataGridFactura.AllowUserToDeleteRows = False
        Me.DataGridFactura.AllowUserToResizeColumns = False
        Me.DataGridFactura.AllowUserToResizeRows = False
        Me.DataGridFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFactura.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_producto, Me.cantidad, Me.unidadmedida, Me.descripcion, Me.punitario, Me.importe, Me.stock})
        Me.DataGridFactura.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridFactura.Location = New System.Drawing.Point(3, 309)
        Me.DataGridFactura.MultiSelect = False
        Me.DataGridFactura.Name = "DataGridFactura"
        Me.DataGridFactura.RowTemplate.Height = 24
        Me.DataGridFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFactura.Size = New System.Drawing.Size(785, 152)
        Me.DataGridFactura.TabIndex = 0
        '
        'Id_producto
        '
        Me.Id_producto.HeaderText = "Id_producto"
        Me.Id_producto.Name = "Id_producto"
        Me.Id_producto.Visible = False
        '
        'cantidad
        '
        Me.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.MaxInputLength = 3
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cantidad.Width = 123
        '
        'unidadmedida
        '
        Me.unidadmedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.unidadmedida.DefaultCellStyle = DataGridViewCellStyle2
        Me.unidadmedida.HeaderText = "Unidad de medida"
        Me.unidadmedida.Name = "unidadmedida"
        Me.unidadmedida.ReadOnly = True
        Me.unidadmedida.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'punitario
        '
        Me.punitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.punitario.DefaultCellStyle = DataGridViewCellStyle4
        Me.punitario.HeaderText = "P. Unitario"
        Me.punitario.MaxInputLength = 99999
        Me.punitario.Name = "punitario"
        Me.punitario.ReadOnly = True
        Me.punitario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.punitario.Width = 126
        '
        'importe
        '
        Me.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.importe.DefaultCellStyle = DataGridViewCellStyle5
        Me.importe.HeaderText = "Importe"
        Me.importe.MaxInputLength = 9999999
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.importe.Width = 115
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LFactura4)
        Me.GroupBox2.Controls.Add(Me.LFactura6)
        Me.GroupBox2.Controls.Add(Me.LFactura5)
        Me.GroupBox2.Controls.Add(Me.LFactura3)
        Me.GroupBox2.Controls.Add(Me.LFactura1)
        Me.GroupBox2.Controls.Add(Me.TFechaHora)
        Me.GroupBox2.Controls.Add(Me.LFactura7)
        Me.GroupBox2.Controls.Add(Me.LFactura2)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(440, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(348, 153)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura"
        '
        'LFactura4
        '
        Me.LFactura4.AutoSize = True
        Me.LFactura4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura4.Location = New System.Drawing.Point(39, 64)
        Me.LFactura4.Name = "LFactura4"
        Me.LFactura4.Size = New System.Drawing.Size(306, 17)
        Me.LFactura4.TabIndex = 4
        Me.LFactura4.Text = "F960EBCF-1D89-406B-8AB7-D3FC43D07"
        '
        'LFactura6
        '
        Me.LFactura6.AutoSize = True
        Me.LFactura6.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura6.Location = New System.Drawing.Point(156, 100)
        Me.LFactura6.Name = "LFactura6"
        Me.LFactura6.Size = New System.Drawing.Size(188, 17)
        Me.LFactura6.TabIndex = 3
        Me.LFactura6.Text = "20001000000100005868"
        '
        'LFactura5
        '
        Me.LFactura5.AutoSize = True
        Me.LFactura5.Location = New System.Drawing.Point(71, 81)
        Me.LFactura5.Name = "LFactura5"
        Me.LFactura5.Size = New System.Drawing.Size(277, 18)
        Me.LFactura5.TabIndex = 3
        Me.LFactura5.Text = "Nro de Serie del Certificado de CSD:"
        '
        'LFactura3
        '
        Me.LFactura3.AutoSize = True
        Me.LFactura3.Location = New System.Drawing.Point(253, 46)
        Me.LFactura3.Name = "LFactura3"
        Me.LFactura3.Size = New System.Drawing.Size(95, 18)
        Me.LFactura3.TabIndex = 3
        Me.LFactura3.Text = "Folio Fiscal:"
        '
        'LFactura1
        '
        Me.LFactura1.AutoSize = True
        Me.LFactura1.Location = New System.Drawing.Point(243, 10)
        Me.LFactura1.Name = "LFactura1"
        Me.LFactura1.Size = New System.Drawing.Size(102, 18)
        Me.LFactura1.TabIndex = 1
        Me.LFactura1.Text = "Nro Factura:"
        '
        'TFechaHora
        '
        Me.TFechaHora.AutoSize = True
        Me.TFechaHora.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFechaHora.Location = New System.Drawing.Point(181, 135)
        Me.TFechaHora.Name = "TFechaHora"
        Me.TFechaHora.Size = New System.Drawing.Size(15, 17)
        Me.TFechaHora.TabIndex = 0
        Me.TFechaHora.Text = "-"
        '
        'LFactura7
        '
        Me.LFactura7.AutoSize = True
        Me.LFactura7.Location = New System.Drawing.Point(151, 117)
        Me.LFactura7.Name = "LFactura7"
        Me.LFactura7.Size = New System.Drawing.Size(197, 18)
        Me.LFactura7.TabIndex = 0
        Me.LFactura7.Text = "Fecha y hora de emision:"
        '
        'LFactura2
        '
        Me.LFactura2.AutoSize = True
        Me.LFactura2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura2.Location = New System.Drawing.Point(281, 28)
        Me.LFactura2.Name = "LFactura2"
        Me.LFactura2.Size = New System.Drawing.Size(63, 18)
        Me.LFactura2.TabIndex = 0
        Me.LFactura2.Text = "000XX"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBFormaPago)
        Me.GroupBox3.Controls.Add(Me.BEliminar)
        Me.GroupBox3.Controls.Add(Me.BAgregar)
        Me.GroupBox3.Controls.Add(Me.BBuscarCliente)
        Me.GroupBox3.Controls.Add(Me.LApeyNom)
        Me.GroupBox3.Controls.Add(Me.LVendedor)
        Me.GroupBox3.Controls.Add(Me.LTelefono)
        Me.GroupBox3.Controls.Add(Me.LDomicilio)
        Me.GroupBox3.Controls.Add(Me.LDNI)
        Me.GroupBox3.Controls.Add(Me.TTelefono)
        Me.GroupBox3.Controls.Add(Me.TDomicilio)
        Me.GroupBox3.Controls.Add(Me.TDNI)
        Me.GroupBox3.Controls.Add(Me.TCliente)
        Me.GroupBox3.Controls.Add(Me.LCliente)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(782, 145)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'CBFormaPago
        '
        Me.CBFormaPago.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFormaPago.FormattingEnabled = True
        Me.CBFormaPago.Location = New System.Drawing.Point(437, 90)
        Me.CBFormaPago.Name = "CBFormaPago"
        Me.CBFormaPago.Size = New System.Drawing.Size(168, 24)
        Me.CBFormaPago.TabIndex = 13
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.DarkRed
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEliminar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.Color.White
        Me.BEliminar.Image = Global.pcgamer.My.Resources.Resources.carrito_eliminar
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.Location = New System.Drawing.Point(639, 90)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(137, 49)
        Me.BEliminar.TabIndex = 4
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Image = Global.pcgamer.My.Resources.Resources.carrito_agregar
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.Location = New System.Drawing.Point(639, 22)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(137, 49)
        Me.BAgregar.TabIndex = 3
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.BackColor = System.Drawing.Color.DarkRed
        Me.BBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBuscarCliente.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BBuscarCliente.Location = New System.Drawing.Point(437, 22)
        Me.BBuscarCliente.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(126, 32)
        Me.BBuscarCliente.TabIndex = 5
        Me.BBuscarCliente.Text = "Buscar Cliente"
        Me.BBuscarCliente.UseVisualStyleBackColor = False
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.Location = New System.Drawing.Point(141, 109)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(15, 18)
        Me.LApeyNom.TabIndex = 7
        Me.LApeyNom.Text = "-"
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Location = New System.Drawing.Point(6, 106)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(85, 18)
        Me.LVendedor.TabIndex = 8
        Me.LVendedor.Text = "Vendedor:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(6, 76)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 18)
        Me.LTelefono.TabIndex = 9
        Me.LTelefono.Text = "Telefono:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Location = New System.Drawing.Point(6, 58)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(81, 18)
        Me.LDomicilio.TabIndex = 10
        Me.LDomicilio.Text = "Domicilio:"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Location = New System.Drawing.Point(6, 40)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(114, 18)
        Me.LDNI.TabIndex = 11
        Me.LDNI.Text = "DNI Receptor:"
        '
        'TTelefono
        '
        Me.TTelefono.AutoSize = True
        Me.TTelefono.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelefono.Location = New System.Drawing.Point(141, 76)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(0, 18)
        Me.TTelefono.TabIndex = 0
        '
        'TDomicilio
        '
        Me.TDomicilio.AutoSize = True
        Me.TDomicilio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDomicilio.Location = New System.Drawing.Point(141, 58)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.Size = New System.Drawing.Size(0, 18)
        Me.TDomicilio.TabIndex = 0
        '
        'TDNI
        '
        Me.TDNI.AutoSize = True
        Me.TDNI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDNI.Location = New System.Drawing.Point(141, 40)
        Me.TDNI.Name = "TDNI"
        Me.TDNI.Size = New System.Drawing.Size(0, 18)
        Me.TDNI.TabIndex = 0
        '
        'TCliente
        '
        Me.TCliente.AutoSize = True
        Me.TCliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCliente.Location = New System.Drawing.Point(141, 22)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(0, 18)
        Me.TCliente.TabIndex = 0
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.Location = New System.Drawing.Point(6, 22)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(87, 18)
        Me.LCliente.TabIndex = 12
        Me.LCliente.Text = "Receptor: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LEmpresa5)
        Me.GroupBox1.Controls.Add(Me.LEmpresa4)
        Me.GroupBox1.Controls.Add(Me.LEmpresa3)
        Me.GroupBox1.Controls.Add(Me.LEmpresa2)
        Me.GroupBox1.Controls.Add(Me.LEmpresa1)
        Me.GroupBox1.Controls.Add(Me.PBEmpresa)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 153)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pc-Gamer"
        '
        'LEmpresa5
        '
        Me.LEmpresa5.AutoSize = True
        Me.LEmpresa5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa5.Location = New System.Drawing.Point(121, 101)
        Me.LEmpresa5.Name = "LEmpresa5"
        Me.LEmpresa5.Size = New System.Drawing.Size(239, 18)
        Me.LEmpresa5.TabIndex = 15
        Me.LEmpresa5.Text = "E-mail: pcgamer@hotmail.com"
        '
        'LEmpresa4
        '
        Me.LEmpresa4.AutoSize = True
        Me.LEmpresa4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa4.Location = New System.Drawing.Point(120, 81)
        Me.LEmpresa4.Name = "LEmpresa4"
        Me.LEmpresa4.Size = New System.Drawing.Size(209, 18)
        Me.LEmpresa4.TabIndex = 16
        Me.LEmpresa4.Text = "Telefonos: (379) 4221129"
        '
        'LEmpresa3
        '
        Me.LEmpresa3.AutoSize = True
        Me.LEmpresa3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa3.Location = New System.Drawing.Point(120, 61)
        Me.LEmpresa3.Name = "LEmpresa3"
        Me.LEmpresa3.Size = New System.Drawing.Size(268, 18)
        Me.LEmpresa3.TabIndex = 17
        Me.LEmpresa3.Text = "CP (3400) - Corrientes - Argentina"
        '
        'LEmpresa2
        '
        Me.LEmpresa2.AutoSize = True
        Me.LEmpresa2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa2.Location = New System.Drawing.Point(120, 42)
        Me.LEmpresa2.Name = "LEmpresa2"
        Me.LEmpresa2.Size = New System.Drawing.Size(123, 18)
        Me.LEmpresa2.TabIndex = 18
        Me.LEmpresa2.Text = "9 de Julio 1449"
        '
        'LEmpresa1
        '
        Me.LEmpresa1.AutoSize = True
        Me.LEmpresa1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa1.Location = New System.Drawing.Point(120, 22)
        Me.LEmpresa1.Name = "LEmpresa1"
        Me.LEmpresa1.Size = New System.Drawing.Size(142, 18)
        Me.LEmpresa1.TabIndex = 19
        Me.LEmpresa1.Text = "Pc-Gamer S.R.L."
        '
        'PBEmpresa
        '
        Me.PBEmpresa.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo_grande2
        Me.PBEmpresa.Location = New System.Drawing.Point(3, 22)
        Me.PBEmpresa.Name = "PBEmpresa"
        Me.PBEmpresa.Size = New System.Drawing.Size(100, 95)
        Me.PBEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEmpresa.TabIndex = 0
        Me.PBEmpresa.TabStop = False
        '
        'BImprimir
        '
        Me.BImprimir.BackColor = System.Drawing.Color.DarkRed
        Me.BImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BImprimir.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimir.ForeColor = System.Drawing.Color.White
        Me.BImprimir.Image = Global.pcgamer.My.Resources.Resources.factura_icono
        Me.BImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BImprimir.Location = New System.Drawing.Point(870, 612)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(137, 49)
        Me.BImprimir.TabIndex = 6
        Me.BImprimir.Text = "Imprimir"
        Me.BImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BImprimir.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCancelar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Image = Global.pcgamer.My.Resources.Resources.cancelar_icono1
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancelar.Location = New System.Drawing.Point(718, 612)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(137, 49)
        Me.BCancelar.TabIndex = 7
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'FormularioFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BImprimir)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormularioFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Factura"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridFactura As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PBEmpresa As PictureBox
    Friend WithEvents LEmpresa5 As Label
    Friend WithEvents LEmpresa4 As Label
    Friend WithEvents LEmpresa3 As Label
    Friend WithEvents LEmpresa2 As Label
    Friend WithEvents LEmpresa1 As Label
    Friend WithEvents LFactura1 As Label
    Friend WithEvents LFactura7 As Label
    Friend WithEvents LFactura2 As Label
    Friend WithEvents LFactura4 As Label
    Friend WithEvents LFactura6 As Label
    Friend WithEvents LFactura5 As Label
    Friend WithEvents LFactura3 As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDomicilio As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LVendedor As Label
    Friend WithEvents TTelefono As Label
    Friend WithEvents TDomicilio As Label
    Friend WithEvents TDNI As Label
    Friend WithEvents TCliente As Label
    Friend WithEvents TFechaHora As Label
    Friend WithEvents BBuscarCliente As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BImprimir As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents LTotal As Label
    Friend WithEvents TTotal As Label
    Friend WithEvents CBFormaPago As ComboBox
    Friend WithEvents Id_producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents unidadmedida As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents punitario As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
