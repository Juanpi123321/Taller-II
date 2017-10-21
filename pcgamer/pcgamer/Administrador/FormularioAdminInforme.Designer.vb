<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAdminInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioAdminInforme))
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBlogo2 = New System.Windows.Forms.PictureBox()
        Me.PBLogo3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BVer = New System.Windows.Forms.Button()
        Me.CBHasta = New System.Windows.Forms.ComboBox()
        Me.CBDesde = New System.Windows.Forms.ComboBox()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.BVerDetalle = New System.Windows.Forms.Button()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBlogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(956, 644)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(0, 18)
        Me.LApeyNom.TabIndex = 34
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
        Me.LRol.TabIndex = 33
        Me.LRol.Text = "Administrador:"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(372, 74)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(419, 40)
        Me.LTitulo.TabIndex = 31
        Me.LTitulo.Text = "Informes de Facturacion"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 32
        Me.PBLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PBlogo2)
        Me.Panel1.Controls.Add(Me.PBLogo3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BVerDetalle)
        Me.Panel1.Controls.Add(Me.CBBuscar)
        Me.Panel1.Controls.Add(Me.LBuscar)
        Me.Panel1.Controls.Add(Me.TBuscar)
        Me.Panel1.Controls.Add(Me.DataGridFacturas)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(19, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 482)
        Me.Panel1.TabIndex = 35
        '
        'PBlogo2
        '
        Me.PBlogo2.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo_grande3
        Me.PBlogo2.Location = New System.Drawing.Point(996, 291)
        Me.PBlogo2.Name = "PBlogo2"
        Me.PBlogo2.Size = New System.Drawing.Size(129, 125)
        Me.PBlogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBlogo2.TabIndex = 42
        Me.PBlogo2.TabStop = False
        '
        'PBLogo3
        '
        Me.PBLogo3.Image = Global.pcgamer.My.Resources.Resources.pc_gamer_logo_factura
        Me.PBLogo3.Location = New System.Drawing.Point(155, 81)
        Me.PBLogo3.Name = "PBLogo3"
        Me.PBLogo3.Size = New System.Drawing.Size(365, 77)
        Me.PBLogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo3.TabIndex = 21
        Me.PBLogo3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BVer)
        Me.GroupBox1.Controls.Add(Me.CBHasta)
        Me.GroupBox1.Controls.Add(Me.CBDesde)
        Me.GroupBox1.Controls.Add(Me.LHasta)
        Me.GroupBox1.Controls.Add(Me.LDesde)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(620, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 69)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'BVer
        '
        Me.BVer.BackColor = System.Drawing.Color.DarkRed
        Me.BVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BVer.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVer.ForeColor = System.Drawing.Color.White
        Me.BVer.Location = New System.Drawing.Point(451, 23)
        Me.BVer.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BVer.Name = "BVer"
        Me.BVer.Size = New System.Drawing.Size(80, 32)
        Me.BVer.TabIndex = 21
        Me.BVer.Text = "Ver"
        Me.BVer.UseVisualStyleBackColor = False
        '
        'CBHasta
        '
        Me.CBHasta.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHasta.FormattingEnabled = True
        Me.CBHasta.Location = New System.Drawing.Point(297, 28)
        Me.CBHasta.Name = "CBHasta"
        Me.CBHasta.Size = New System.Drawing.Size(136, 24)
        Me.CBHasta.TabIndex = 1
        '
        'CBDesde
        '
        Me.CBDesde.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDesde.FormattingEnabled = True
        Me.CBDesde.Location = New System.Drawing.Point(77, 28)
        Me.CBDesde.Name = "CBDesde"
        Me.CBDesde.Size = New System.Drawing.Size(136, 24)
        Me.CBDesde.TabIndex = 1
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.Location = New System.Drawing.Point(237, 31)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(54, 17)
        Me.LHasta.TabIndex = 0
        Me.LHasta.Text = "Hasta:"
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.Location = New System.Drawing.Point(13, 31)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(58, 17)
        Me.LDesde.TabIndex = 0
        Me.LDesde.Text = "Desde:"
        '
        'BVerDetalle
        '
        Me.BVerDetalle.BackColor = System.Drawing.Color.DarkRed
        Me.BVerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BVerDetalle.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerDetalle.ForeColor = System.Drawing.Color.White
        Me.BVerDetalle.Location = New System.Drawing.Point(901, 114)
        Me.BVerDetalle.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BVerDetalle.Name = "BVerDetalle"
        Me.BVerDetalle.Size = New System.Drawing.Size(219, 32)
        Me.BVerDetalle.TabIndex = 3
        Me.BVerDetalle.Text = "Ver detalle factura"
        Me.BVerDetalle.UseVisualStyleBackColor = False
        Me.BVerDetalle.Visible = False
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Items.AddRange(New Object() {"Filtrar por", "Cliente", "Vendedor"})
        Me.CBBuscar.Location = New System.Drawing.Point(371, 17)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(186, 28)
        Me.CBBuscar.TabIndex = 2
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.BackColor = System.Drawing.Color.Black
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(18, 19)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(75, 20)
        Me.LBuscar.TabIndex = 19
        Me.LBuscar.Text = "Buscar:"
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(99, 16)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(250, 28)
        Me.TBuscar.TabIndex = 0
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AllowUserToAddRows = False
        Me.DataGridFacturas.AllowUserToDeleteRows = False
        Me.DataGridFacturas.AllowUserToResizeColumns = False
        Me.DataGridFacturas.AllowUserToResizeRows = False
        Me.DataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFacturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.GridColor = System.Drawing.SystemColors.GrayText
        Me.DataGridFacturas.Location = New System.Drawing.Point(8, 205)
        Me.DataGridFacturas.MultiSelect = False
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.ReadOnly = True
        Me.DataGridFacturas.RowTemplate.Height = 24
        Me.DataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFacturas.Size = New System.Drawing.Size(929, 274)
        Me.DataGridFacturas.TabIndex = 1
        '
        'FormularioAdminInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormularioAdminInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Informes"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBlogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BVerDetalle As Button
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents LBuscar As Label
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents DataGridFacturas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBHasta As ComboBox
    Friend WithEvents CBDesde As ComboBox
    Friend WithEvents LHasta As Label
    Friend WithEvents LDesde As Label
    Friend WithEvents BVer As Button
    Friend WithEvents PBLogo3 As PictureBox
    Friend WithEvents PBlogo2 As PictureBox
End Class
