<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_empleado
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
        Me.Date_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.BAgregar_ven = New System.Windows.Forms.Button()
        Me.Tsueldo_vend = New System.Windows.Forms.TextBox()
        Me.Ttel_vend = New System.Windows.Forms.TextBox()
        Me.Tdir_vend = New System.Windows.Forms.TextBox()
        Me.Tape_vend = New System.Windows.Forms.TextBox()
        Me.Tnom_vend = New System.Windows.Forms.TextBox()
        Me.Tcuil_vend = New System.Windows.Forms.TextBox()
        Me.Tid_vend = New System.Windows.Forms.TextBox()
        Me.LSueldo = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDir_vend = New System.Windows.Forms.Label()
        Me.Lape_vend = New System.Windows.Forms.Label()
        Me.LNom_vend = New System.Windows.Forms.Label()
        Me.LCuil_vend = New System.Windows.Forms.Label()
        Me.Lid_vend = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BBuscar_ven = New System.Windows.Forms.Button()
        Me.Lape = New System.Windows.Forms.Label()
        Me.Lcuil1 = New System.Windows.Forms.Label()
        Me.Tcuil1_vend = New System.Windows.Forms.TextBox()
        Me.Tape1_vend = New System.Windows.Forms.TextBox()
        Me.DGVVendedor = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BActu = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_ingreso
        '
        Me.Date_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_ingreso.Location = New System.Drawing.Point(321, 124)
        Me.Date_ingreso.Name = "Date_ingreso"
        Me.Date_ingreso.Size = New System.Drawing.Size(100, 20)
        Me.Date_ingreso.TabIndex = 3
        '
        'BAgregar_ven
        '
        Me.BAgregar_ven.Location = New System.Drawing.Point(509, 133)
        Me.BAgregar_ven.Name = "BAgregar_ven"
        Me.BAgregar_ven.Size = New System.Drawing.Size(121, 33)
        Me.BAgregar_ven.TabIndex = 2
        Me.BAgregar_ven.Text = "Agregar Vendedor"
        Me.BAgregar_ven.UseVisualStyleBackColor = True
        '
        'Tsueldo_vend
        '
        Me.Tsueldo_vend.Location = New System.Drawing.Point(102, 117)
        Me.Tsueldo_vend.Name = "Tsueldo_vend"
        Me.Tsueldo_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tsueldo_vend.TabIndex = 1
        '
        'Ttel_vend
        '
        Me.Ttel_vend.Location = New System.Drawing.Point(488, 88)
        Me.Ttel_vend.Name = "Ttel_vend"
        Me.Ttel_vend.Size = New System.Drawing.Size(161, 20)
        Me.Ttel_vend.TabIndex = 1
        '
        'Tdir_vend
        '
        Me.Tdir_vend.Location = New System.Drawing.Point(293, 85)
        Me.Tdir_vend.Name = "Tdir_vend"
        Me.Tdir_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tdir_vend.TabIndex = 1
        '
        'Tape_vend
        '
        Me.Tape_vend.Location = New System.Drawing.Point(102, 81)
        Me.Tape_vend.Name = "Tape_vend"
        Me.Tape_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tape_vend.TabIndex = 1
        '
        'Tnom_vend
        '
        Me.Tnom_vend.Location = New System.Drawing.Point(488, 37)
        Me.Tnom_vend.Name = "Tnom_vend"
        Me.Tnom_vend.Size = New System.Drawing.Size(161, 20)
        Me.Tnom_vend.TabIndex = 1
        '
        'Tcuil_vend
        '
        Me.Tcuil_vend.Location = New System.Drawing.Point(293, 37)
        Me.Tcuil_vend.Name = "Tcuil_vend"
        Me.Tcuil_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tcuil_vend.TabIndex = 1
        '
        'Tid_vend
        '
        Me.Tid_vend.Location = New System.Drawing.Point(102, 37)
        Me.Tid_vend.Name = "Tid_vend"
        Me.Tid_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tid_vend.TabIndex = 1
        '
        'LSueldo
        '
        Me.LSueldo.AutoSize = True
        Me.LSueldo.Location = New System.Drawing.Point(29, 124)
        Me.LSueldo.Name = "LSueldo"
        Me.LSueldo.Size = New System.Drawing.Size(40, 13)
        Me.LSueldo.TabIndex = 0
        Me.LSueldo.Text = "Sueldo"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(226, 124)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(89, 13)
        Me.LFecha.TabIndex = 0
        Me.LFecha.Text = "Fecha de ingreso"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(226, 88)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 0
        Me.LTelefono.Text = "Telefono"
        '
        'LDir_vend
        '
        Me.LDir_vend.AutoSize = True
        Me.LDir_vend.Location = New System.Drawing.Point(410, 92)
        Me.LDir_vend.Name = "LDir_vend"
        Me.LDir_vend.Size = New System.Drawing.Size(52, 13)
        Me.LDir_vend.TabIndex = 0
        Me.LDir_vend.Text = "Dirección"
        '
        'Lape_vend
        '
        Me.Lape_vend.AutoSize = True
        Me.Lape_vend.Location = New System.Drawing.Point(25, 84)
        Me.Lape_vend.Name = "Lape_vend"
        Me.Lape_vend.Size = New System.Drawing.Size(44, 13)
        Me.Lape_vend.TabIndex = 0
        Me.Lape_vend.Text = "Apellido"
        '
        'LNom_vend
        '
        Me.LNom_vend.AutoSize = True
        Me.LNom_vend.Location = New System.Drawing.Point(410, 37)
        Me.LNom_vend.Name = "LNom_vend"
        Me.LNom_vend.Size = New System.Drawing.Size(44, 13)
        Me.LNom_vend.TabIndex = 0
        Me.LNom_vend.Text = "Nombre"
        '
        'LCuil_vend
        '
        Me.LCuil_vend.AutoSize = True
        Me.LCuil_vend.Location = New System.Drawing.Point(226, 37)
        Me.LCuil_vend.Name = "LCuil_vend"
        Me.LCuil_vend.Size = New System.Drawing.Size(24, 13)
        Me.LCuil_vend.TabIndex = 0
        Me.LCuil_vend.Text = "Cuil"
        '
        'Lid_vend
        '
        Me.Lid_vend.AutoSize = True
        Me.Lid_vend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lid_vend.Location = New System.Drawing.Point(25, 38)
        Me.Lid_vend.Name = "Lid_vend"
        Me.Lid_vend.Size = New System.Drawing.Size(21, 16)
        Me.Lid_vend.TabIndex = 0
        Me.Lid_vend.Text = "Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BBuscar_ven)
        Me.GroupBox2.Controls.Add(Me.Lape)
        Me.GroupBox2.Controls.Add(Me.Lcuil1)
        Me.GroupBox2.Controls.Add(Me.Tcuil1_vend)
        Me.GroupBox2.Controls.Add(Me.Tape1_vend)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(110, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 115)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Vendedor   "
        '
        'BBuscar_ven
        '
        Me.BBuscar_ven.Location = New System.Drawing.Point(416, 80)
        Me.BBuscar_ven.Name = "BBuscar_ven"
        Me.BBuscar_ven.Size = New System.Drawing.Size(75, 23)
        Me.BBuscar_ven.TabIndex = 2
        Me.BBuscar_ven.Text = "Buscar"
        Me.BBuscar_ven.UseVisualStyleBackColor = True
        '
        'Lape
        '
        Me.Lape.AutoSize = True
        Me.Lape.Location = New System.Drawing.Point(269, 42)
        Me.Lape.Name = "Lape"
        Me.Lape.Size = New System.Drawing.Size(44, 13)
        Me.Lape.TabIndex = 0
        Me.Lape.Text = "Apellido"
        '
        'Lcuil1
        '
        Me.Lcuil1.AutoSize = True
        Me.Lcuil1.Location = New System.Drawing.Point(32, 34)
        Me.Lcuil1.Name = "Lcuil1"
        Me.Lcuil1.Size = New System.Drawing.Size(24, 13)
        Me.Lcuil1.TabIndex = 0
        Me.Lcuil1.Text = "Cuil"
        '
        'Tcuil1_vend
        '
        Me.Tcuil1_vend.Location = New System.Drawing.Point(138, 35)
        Me.Tcuil1_vend.Name = "Tcuil1_vend"
        Me.Tcuil1_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tcuil1_vend.TabIndex = 1
        '
        'Tape1_vend
        '
        Me.Tape1_vend.Location = New System.Drawing.Point(391, 35)
        Me.Tape1_vend.Name = "Tape1_vend"
        Me.Tape1_vend.Size = New System.Drawing.Size(100, 20)
        Me.Tape1_vend.TabIndex = 1
        '
        'DGVVendedor
        '
        Me.DGVVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVendedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGVVendedor.Location = New System.Drawing.Point(6, 237)
        Me.DGVVendedor.Name = "DGVVendedor"
        Me.DGVVendedor.Size = New System.Drawing.Size(750, 113)
        Me.DGVVendedor.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cuil"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Telefono"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha de ingreso"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sueldo"
        Me.Column7.Name = "Column7"
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(20, 24)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(81, 29)
        Me.BEditar.TabIndex = 4
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BActu
        '
        Me.BActu.Location = New System.Drawing.Point(121, 24)
        Me.BActu.Name = "BActu"
        Me.BActu.Size = New System.Drawing.Size(81, 29)
        Me.BActu.TabIndex = 4
        Me.BActu.Text = "Actualizar"
        Me.BActu.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(224, 24)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(81, 29)
        Me.BEliminar.TabIndex = 4
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BEditar)
        Me.GroupBox3.Controls.Add(Me.BEliminar)
        Me.GroupBox3.Controls.Add(Me.BActu)
        Me.GroupBox3.Location = New System.Drawing.Point(203, 356)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 63)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(38, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(770, 465)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(762, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(756, 196)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cuil"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de ingreso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Sueldo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGVVendedor)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(762, 439)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestion Cliente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BAgregar_ven)
        Me.GroupBox4.Controls.Add(Me.Lid_vend)
        Me.GroupBox4.Controls.Add(Me.Date_ingreso)
        Me.GroupBox4.Controls.Add(Me.Ttel_vend)
        Me.GroupBox4.Controls.Add(Me.Tcuil_vend)
        Me.GroupBox4.Controls.Add(Me.LFecha)
        Me.GroupBox4.Controls.Add(Me.LSueldo)
        Me.GroupBox4.Controls.Add(Me.Tsueldo_vend)
        Me.GroupBox4.Controls.Add(Me.LDir_vend)
        Me.GroupBox4.Controls.Add(Me.Tdir_vend)
        Me.GroupBox4.Controls.Add(Me.LNom_vend)
        Me.GroupBox4.Controls.Add(Me.Tnom_vend)
        Me.GroupBox4.Controls.Add(Me.LTelefono)
        Me.GroupBox4.Controls.Add(Me.Tape_vend)
        Me.GroupBox4.Controls.Add(Me.LCuil_vend)
        Me.GroupBox4.Controls.Add(Me.Lape_vend)
        Me.GroupBox4.Controls.Add(Me.Tid_vend)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(723, 172)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Agregar Vendedor  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(310, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 40)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Vendedores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.encabezado
        Me.PictureBox1.Location = New System.Drawing.Point(639, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Agregar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Agregar_empleado"
        Me.Text = "Agregar_Vendedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents LNom_vend As System.Windows.Forms.Label
    Friend WithEvents LCuil_vend As System.Windows.Forms.Label
    Friend WithEvents Lid_vend As System.Windows.Forms.Label
    Friend WithEvents BAgregar_ven As System.Windows.Forms.Button
    Friend WithEvents Tsueldo_vend As System.Windows.Forms.TextBox
    Friend WithEvents Ttel_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tdir_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tape_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tnom_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tcuil_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tid_vend As System.Windows.Forms.TextBox
    Friend WithEvents LSueldo As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents LTelefono As System.Windows.Forms.Label
    Friend WithEvents LDir_vend As System.Windows.Forms.Label
    Friend WithEvents Lape_vend As System.Windows.Forms.Label
    Friend WithEvents BBuscar_ven As System.Windows.Forms.Button
    Friend WithEvents Lape As System.Windows.Forms.Label
    Friend WithEvents Lcuil1 As System.Windows.Forms.Label
    Friend WithEvents Tcuil1_vend As System.Windows.Forms.TextBox
    Friend WithEvents Tape1_vend As System.Windows.Forms.TextBox
    Friend WithEvents Date_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents BActu As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
