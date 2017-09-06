<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMProductos
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TCProducto = New System.Windows.Forms.TabControl()
        Me.TPlistdoprod = New System.Windows.Forms.TabPage()
        Me.GBBuscarprod = New System.Windows.Forms.GroupBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.CBtipo2 = New System.Windows.Forms.ComboBox()
        Me.TId2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LIdProd2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TPProd = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BActualizar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BAgregarProd = New System.Windows.Forms.Button()
        Me.BImagen = New System.Windows.Forms.Button()
        Me.LStock = New System.Windows.Forms.Label()
        Me.CBtipoprod = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TSabor4 = New System.Windows.Forms.TextBox()
        Me.TSabor1 = New System.Windows.Forms.TextBox()
        Me.TSabor2 = New System.Windows.Forms.TextBox()
        Me.TSabor3 = New System.Windows.Forms.TextBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.Tid = New System.Windows.Forms.TextBox()
        Me.LSabor4 = New System.Windows.Forms.Label()
        Me.LSabor1 = New System.Windows.Forms.Label()
        Me.LSabor3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LSabor2 = New System.Windows.Forms.Label()
        Me.LIdProducto = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TCProducto.SuspendLayout()
        Me.TPlistdoprod.SuspendLayout()
        Me.GBBuscarprod.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPProd.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCProducto
        '
        Me.TCProducto.Controls.Add(Me.TPlistdoprod)
        Me.TCProducto.Controls.Add(Me.TPProd)
        Me.TCProducto.Location = New System.Drawing.Point(22, 107)
        Me.TCProducto.Name = "TCProducto"
        Me.TCProducto.SelectedIndex = 0
        Me.TCProducto.Size = New System.Drawing.Size(794, 433)
        Me.TCProducto.TabIndex = 0
        '
        'TPlistdoprod
        '
        Me.TPlistdoprod.Controls.Add(Me.GBBuscarprod)
        Me.TPlistdoprod.Controls.Add(Me.DataGridView2)
        Me.TPlistdoprod.Location = New System.Drawing.Point(4, 22)
        Me.TPlistdoprod.Name = "TPlistdoprod"
        Me.TPlistdoprod.Padding = New System.Windows.Forms.Padding(3)
        Me.TPlistdoprod.Size = New System.Drawing.Size(786, 407)
        Me.TPlistdoprod.TabIndex = 0
        Me.TPlistdoprod.Text = "Listado"
        Me.TPlistdoprod.UseVisualStyleBackColor = True
        '
        'GBBuscarprod
        '
        Me.GBBuscarprod.Controls.Add(Me.BBuscar)
        Me.GBBuscarprod.Controls.Add(Me.CBtipo2)
        Me.GBBuscarprod.Controls.Add(Me.TId2)
        Me.GBBuscarprod.Controls.Add(Me.Label2)
        Me.GBBuscarprod.Controls.Add(Me.LIdProd2)
        Me.GBBuscarprod.Location = New System.Drawing.Point(130, 32)
        Me.GBBuscarprod.Name = "GBBuscarprod"
        Me.GBBuscarprod.Size = New System.Drawing.Size(537, 100)
        Me.GBBuscarprod.TabIndex = 1
        Me.GBBuscarprod.TabStop = False
        Me.GBBuscarprod.Text = "Buscar Productos"
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(297, 65)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(121, 29)
        Me.BBuscar.TabIndex = 4
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'CBtipo2
        '
        Me.CBtipo2.FormattingEnabled = True
        Me.CBtipo2.Location = New System.Drawing.Point(297, 26)
        Me.CBtipo2.Name = "CBtipo2"
        Me.CBtipo2.Size = New System.Drawing.Size(121, 21)
        Me.CBtipo2.TabIndex = 3
        '
        'TId2
        '
        Me.TId2.Location = New System.Drawing.Point(85, 27)
        Me.TId2.Name = "TId2"
        Me.TId2.Size = New System.Drawing.Size(132, 20)
        Me.TId2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Producto"
        '
        'LIdProd2
        '
        Me.LIdProd2.AutoSize = True
        Me.LIdProd2.Location = New System.Drawing.Point(23, 30)
        Me.LIdProd2.Name = "LIdProd2"
        Me.LIdProd2.Size = New System.Drawing.Size(64, 13)
        Me.LIdProd2.TabIndex = 0
        Me.LIdProd2.Text = "ID Producto"
        '
        'DataGridView2
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.Location = New System.Drawing.Point(6, 153)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(768, 196)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Tipo Producto"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sabor1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sabor2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sabor3"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sabor4"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TPProd
        '
        Me.TPProd.Controls.Add(Me.GroupBox2)
        Me.TPProd.Controls.Add(Me.DataGridView1)
        Me.TPProd.Controls.Add(Me.GroupBox1)
        Me.TPProd.Location = New System.Drawing.Point(4, 22)
        Me.TPProd.Name = "TPProd"
        Me.TPProd.Padding = New System.Windows.Forms.Padding(3)
        Me.TPProd.Size = New System.Drawing.Size(786, 407)
        Me.TPProd.TabIndex = 1
        Me.TPProd.Text = "Gestion Productos"
        Me.TPProd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BActualizar)
        Me.GroupBox2.Controls.Add(Me.BEliminar)
        Me.GroupBox2.Controls.Add(Me.BEditar)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BActualizar
        '
        Me.BActualizar.Location = New System.Drawing.Point(630, 15)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.Size = New System.Drawing.Size(81, 29)
        Me.BActualizar.TabIndex = 2
        Me.BActualizar.Text = "Actualizar"
        Me.BActualizar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(543, 15)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(81, 29)
        Me.BEliminar.TabIndex = 1
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(445, 15)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(81, 29)
        Me.BEditar.TabIndex = 0
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.Location = New System.Drawing.Point(3, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(758, 60)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sabor1"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sabor2"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sabor3"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sabor4"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "Imagen"
        Me.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BAgregarProd)
        Me.GroupBox1.Controls.Add(Me.BImagen)
        Me.GroupBox1.Controls.Add(Me.LStock)
        Me.GroupBox1.Controls.Add(Me.CBtipoprod)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TSabor4)
        Me.GroupBox1.Controls.Add(Me.TSabor1)
        Me.GroupBox1.Controls.Add(Me.TSabor2)
        Me.GroupBox1.Controls.Add(Me.TSabor3)
        Me.GroupBox1.Controls.Add(Me.TStock)
        Me.GroupBox1.Controls.Add(Me.Tid)
        Me.GroupBox1.Controls.Add(Me.LSabor4)
        Me.GroupBox1.Controls.Add(Me.LSabor1)
        Me.GroupBox1.Controls.Add(Me.LSabor3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LSabor2)
        Me.GroupBox1.Controls.Add(Me.LIdProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Producto"
        '
        'BAgregarProd
        '
        Me.BAgregarProd.Location = New System.Drawing.Point(577, 118)
        Me.BAgregarProd.Name = "BAgregarProd"
        Me.BAgregarProd.Size = New System.Drawing.Size(140, 41)
        Me.BAgregarProd.TabIndex = 5
        Me.BAgregarProd.Text = "Agregar producto"
        Me.BAgregarProd.UseVisualStyleBackColor = True
        '
        'BImagen
        '
        Me.BImagen.Location = New System.Drawing.Point(474, 82)
        Me.BImagen.Name = "BImagen"
        Me.BImagen.Size = New System.Drawing.Size(100, 24)
        Me.BImagen.TabIndex = 5
        Me.BImagen.Text = "Imagen"
        Me.BImagen.UseVisualStyleBackColor = True
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(429, 41)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(35, 13)
        Me.LStock.TabIndex = 4
        Me.LStock.Text = "Stock"
        '
        'CBtipoprod
        '
        Me.CBtipoprod.FormattingEnabled = True
        Me.CBtipoprod.Items.AddRange(New Object() {"Kilos", "medio kilos", "palito"})
        Me.CBtipoprod.Location = New System.Drawing.Point(292, 37)
        Me.CBtipoprod.Name = "CBtipoprod"
        Me.CBtipoprod.Size = New System.Drawing.Size(121, 21)
        Me.CBtipoprod.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(580, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TSabor4
        '
        Me.TSabor4.Location = New System.Drawing.Point(292, 115)
        Me.TSabor4.Name = "TSabor4"
        Me.TSabor4.Size = New System.Drawing.Size(121, 20)
        Me.TSabor4.TabIndex = 1
        '
        'TSabor1
        '
        Me.TSabor1.Location = New System.Drawing.Point(74, 75)
        Me.TSabor1.Name = "TSabor1"
        Me.TSabor1.Size = New System.Drawing.Size(100, 20)
        Me.TSabor1.TabIndex = 1
        '
        'TSabor2
        '
        Me.TSabor2.Location = New System.Drawing.Point(292, 79)
        Me.TSabor2.Name = "TSabor2"
        Me.TSabor2.Size = New System.Drawing.Size(121, 20)
        Me.TSabor2.TabIndex = 1
        '
        'TSabor3
        '
        Me.TSabor3.Location = New System.Drawing.Point(74, 118)
        Me.TSabor3.Name = "TSabor3"
        Me.TSabor3.Size = New System.Drawing.Size(100, 20)
        Me.TSabor3.TabIndex = 1
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(474, 37)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(100, 20)
        Me.TStock.TabIndex = 1
        '
        'Tid
        '
        Me.Tid.Location = New System.Drawing.Point(74, 38)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(100, 20)
        Me.Tid.TabIndex = 1
        '
        'LSabor4
        '
        Me.LSabor4.AutoSize = True
        Me.LSabor4.Location = New System.Drawing.Point(223, 125)
        Me.LSabor4.Name = "LSabor4"
        Me.LSabor4.Size = New System.Drawing.Size(41, 13)
        Me.LSabor4.TabIndex = 0
        Me.LSabor4.Text = "Sabor4"
        '
        'LSabor1
        '
        Me.LSabor1.AutoSize = True
        Me.LSabor1.Location = New System.Drawing.Point(9, 78)
        Me.LSabor1.Name = "LSabor1"
        Me.LSabor1.Size = New System.Drawing.Size(41, 13)
        Me.LSabor1.TabIndex = 0
        Me.LSabor1.Text = "Sabor1"
        '
        'LSabor3
        '
        Me.LSabor3.AutoSize = True
        Me.LSabor3.Location = New System.Drawing.Point(11, 118)
        Me.LSabor3.Name = "LSabor3"
        Me.LSabor3.Size = New System.Drawing.Size(41, 13)
        Me.LSabor3.TabIndex = 0
        Me.LSabor3.Text = "Sabor3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo producto"
        '
        'LSabor2
        '
        Me.LSabor2.AutoSize = True
        Me.LSabor2.Location = New System.Drawing.Point(223, 82)
        Me.LSabor2.Name = "LSabor2"
        Me.LSabor2.Size = New System.Drawing.Size(41, 13)
        Me.LSabor2.TabIndex = 0
        Me.LSabor2.Text = "Sabor2"
        '
        'LIdProducto
        '
        Me.LIdProducto.AutoSize = True
        Me.LIdProducto.Location = New System.Drawing.Point(9, 41)
        Me.LIdProducto.Name = "LIdProducto"
        Me.LIdProducto.Size = New System.Drawing.Size(59, 13)
        Me.LIdProducto.TabIndex = 0
        Me.LIdProducto.Text = "IdProducto"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(285, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Productos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto.My.Resources.Resources.encabezado
        Me.PictureBox2.Location = New System.Drawing.Point(621, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'ABMProductos
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 473)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TCProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ABMProductos"
        Me.Text = "ABMProductos"
        Me.TCProducto.ResumeLayout(False)
        Me.TPlistdoprod.ResumeLayout(False)
        Me.GBBuscarprod.ResumeLayout(False)
        Me.GBBuscarprod.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPProd.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCProducto As System.Windows.Forms.TabControl
    Friend WithEvents TPlistdoprod As System.Windows.Forms.TabPage
    Friend WithEvents TPProd As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BActualizar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents TSabor1 As System.Windows.Forms.TextBox
    Friend WithEvents TSabor2 As System.Windows.Forms.TextBox
    Friend WithEvents TSabor3 As System.Windows.Forms.TextBox
    Friend WithEvents Tid As System.Windows.Forms.TextBox
    Friend WithEvents LSabor4 As System.Windows.Forms.Label
    Friend WithEvents LSabor1 As System.Windows.Forms.Label
    Friend WithEvents LSabor3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LSabor2 As System.Windows.Forms.Label
    Friend WithEvents LIdProducto As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TSabor4 As System.Windows.Forms.TextBox
    Friend WithEvents CBtipoprod As System.Windows.Forms.ComboBox
    Friend WithEvents BAgregarProd As System.Windows.Forms.Button
    Friend WithEvents BImagen As System.Windows.Forms.Button
    Friend WithEvents LStock As System.Windows.Forms.Label
    Friend WithEvents TStock As System.Windows.Forms.TextBox
    Friend WithEvents GBBuscarprod As System.Windows.Forms.GroupBox
    Friend WithEvents BBuscar As System.Windows.Forms.Button
    Friend WithEvents CBtipo2 As System.Windows.Forms.ComboBox
    Friend WithEvents TId2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LIdProd2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
