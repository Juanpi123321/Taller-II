<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioEstadisticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioEstadisticas))
        Me.BFormaPago = New System.Windows.Forms.Button()
        Me.BProducto = New System.Windows.Forms.Button()
        Me.BVendedor = New System.Windows.Forms.Button()
        Me.PBFormaPago = New System.Windows.Forms.PictureBox()
        Me.PBProducto = New System.Windows.Forms.PictureBox()
        Me.PBVendedor = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        Me.PBProdxCategoria = New System.Windows.Forms.PictureBox()
        Me.BProdxCategoria = New System.Windows.Forms.Button()
        Me.PBTendencias = New System.Windows.Forms.PictureBox()
        Me.BTendencias = New System.Windows.Forms.Button()
        CType(Me.PBFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBProdxCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTendencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BFormaPago
        '
        Me.BFormaPago.BackColor = System.Drawing.Color.DarkRed
        Me.BFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BFormaPago.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFormaPago.ForeColor = System.Drawing.Color.White
        Me.BFormaPago.Location = New System.Drawing.Point(70, 413)
        Me.BFormaPago.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BFormaPago.Name = "BFormaPago"
        Me.BFormaPago.Size = New System.Drawing.Size(183, 56)
        Me.BFormaPago.TabIndex = 4
        Me.BFormaPago.Text = "&1-Ventas Forma Pago"
        Me.BFormaPago.UseVisualStyleBackColor = False
        '
        'BProducto
        '
        Me.BProducto.BackColor = System.Drawing.Color.DarkRed
        Me.BProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BProducto.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProducto.ForeColor = System.Drawing.Color.White
        Me.BProducto.Location = New System.Drawing.Point(299, 413)
        Me.BProducto.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BProducto.Name = "BProducto"
        Me.BProducto.Size = New System.Drawing.Size(183, 56)
        Me.BProducto.TabIndex = 4
        Me.BProducto.Text = "&2-Ventas por Producto"
        Me.BProducto.UseVisualStyleBackColor = False
        '
        'BVendedor
        '
        Me.BVendedor.BackColor = System.Drawing.Color.DarkRed
        Me.BVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BVendedor.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVendedor.ForeColor = System.Drawing.Color.White
        Me.BVendedor.Location = New System.Drawing.Point(533, 413)
        Me.BVendedor.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BVendedor.Name = "BVendedor"
        Me.BVendedor.Size = New System.Drawing.Size(183, 56)
        Me.BVendedor.TabIndex = 4
        Me.BVendedor.Text = "&3-Ventas por Vendedor"
        Me.BVendedor.UseVisualStyleBackColor = False
        '
        'PBFormaPago
        '
        Me.PBFormaPago.Image = Global.pcgamer.My.Resources.Resources.pago
        Me.PBFormaPago.Location = New System.Drawing.Point(70, 176)
        Me.PBFormaPago.Name = "PBFormaPago"
        Me.PBFormaPago.Size = New System.Drawing.Size(183, 177)
        Me.PBFormaPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFormaPago.TabIndex = 5
        Me.PBFormaPago.TabStop = False
        '
        'PBProducto
        '
        Me.PBProducto.Image = Global.pcgamer.My.Resources.Resources.ventasxprod
        Me.PBProducto.Location = New System.Drawing.Point(299, 176)
        Me.PBProducto.Name = "PBProducto"
        Me.PBProducto.Size = New System.Drawing.Size(183, 177)
        Me.PBProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBProducto.TabIndex = 6
        Me.PBProducto.TabStop = False
        '
        'PBVendedor
        '
        Me.PBVendedor.Image = Global.pcgamer.My.Resources.Resources.ventasxvendedor
        Me.PBVendedor.Location = New System.Drawing.Point(533, 176)
        Me.PBVendedor.Name = "PBVendedor"
        Me.PBVendedor.Size = New System.Drawing.Size(183, 177)
        Me.PBVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBVendedor.TabIndex = 7
        Me.PBVendedor.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(427, 74)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(388, 40)
        Me.LTitulo.TabIndex = 33
        Me.LTitulo.Text = "Estadisticas de Ventas"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 34
        Me.PBLogo.TabStop = False
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(957, 646)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(0, 18)
        Me.LApeyNom.TabIndex = 36
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LRol.Location = New System.Drawing.Point(817, 644)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(139, 20)
        Me.LRol.TabIndex = 35
        Me.LRol.Text = "Administrador:"
        '
        'PBProdxCategoria
        '
        Me.PBProdxCategoria.Image = Global.pcgamer.My.Resources.Resources.almacen1
        Me.PBProdxCategoria.Location = New System.Drawing.Point(761, 176)
        Me.PBProdxCategoria.Name = "PBProdxCategoria"
        Me.PBProdxCategoria.Size = New System.Drawing.Size(183, 177)
        Me.PBProdxCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBProdxCategoria.TabIndex = 38
        Me.PBProdxCategoria.TabStop = False
        '
        'BProdxCategoria
        '
        Me.BProdxCategoria.BackColor = System.Drawing.Color.DarkRed
        Me.BProdxCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BProdxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BProdxCategoria.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProdxCategoria.ForeColor = System.Drawing.Color.White
        Me.BProdxCategoria.Location = New System.Drawing.Point(761, 413)
        Me.BProdxCategoria.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BProdxCategoria.Name = "BProdxCategoria"
        Me.BProdxCategoria.Size = New System.Drawing.Size(183, 56)
        Me.BProdxCategoria.TabIndex = 37
        Me.BProdxCategoria.Text = "&4-Prod por Categoria"
        Me.BProdxCategoria.UseVisualStyleBackColor = False
        '
        'PBTendencias
        '
        Me.PBTendencias.Image = Global.pcgamer.My.Resources.Resources.Tendencia__Ilustración
        Me.PBTendencias.Location = New System.Drawing.Point(990, 176)
        Me.PBTendencias.Name = "PBTendencias"
        Me.PBTendencias.Size = New System.Drawing.Size(183, 177)
        Me.PBTendencias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBTendencias.TabIndex = 40
        Me.PBTendencias.TabStop = False
        '
        'BTendencias
        '
        Me.BTendencias.BackColor = System.Drawing.Color.DarkRed
        Me.BTendencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTendencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTendencias.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTendencias.ForeColor = System.Drawing.Color.White
        Me.BTendencias.Location = New System.Drawing.Point(990, 413)
        Me.BTendencias.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BTendencias.Name = "BTendencias"
        Me.BTendencias.Size = New System.Drawing.Size(183, 56)
        Me.BTendencias.TabIndex = 39
        Me.BTendencias.Text = "&5-Tendencias de Productos"
        Me.BTendencias.UseVisualStyleBackColor = False
        '
        'FormularioEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.PBTendencias)
        Me.Controls.Add(Me.BTendencias)
        Me.Controls.Add(Me.PBProdxCategoria)
        Me.Controls.Add(Me.BProdxCategoria)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.PBVendedor)
        Me.Controls.Add(Me.PBProducto)
        Me.Controls.Add(Me.PBFormaPago)
        Me.Controls.Add(Me.BVendedor)
        Me.Controls.Add(Me.BProducto)
        Me.Controls.Add(Me.BFormaPago)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormularioEstadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario de Estadisticas de Ventas"
        CType(Me.PBFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBProdxCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTendencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BFormaPago As Button
    Friend WithEvents BProducto As Button
    Friend WithEvents BVendedor As Button
    Friend WithEvents PBFormaPago As PictureBox
    Friend WithEvents PBProducto As PictureBox
    Friend WithEvents PBVendedor As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
    Friend WithEvents PBProdxCategoria As PictureBox
    Friend WithEvents BProdxCategoria As Button
    Friend WithEvents PBTendencias As PictureBox
    Friend WithEvents BTendencias As Button
End Class
