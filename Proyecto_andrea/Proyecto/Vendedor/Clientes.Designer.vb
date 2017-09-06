<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TApellido1 = New System.Windows.Forms.TextBox()
        Me.TCuil1 = New System.Windows.Forms.TextBox()
        Me.LApe = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCuil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDirec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TId = New System.Windows.Forms.TextBox()
        Me.LFechaReg = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LId = New System.Windows.Forms.Label()
        Me.LCuil = New System.Windows.Forms.Label()
        Me.Ttel = New System.Windows.Forms.TextBox()
        Me.TCuil = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.Tdireccion = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 458)
        Me.TabControl1.TabIndex = 11
        Me.TabControl1.Tag = "ddd"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(217, 356)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 51)
        Me.Panel1.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(151, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Seleccionar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(27, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 44)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Cargar Todos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BBuscarCliente)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TApellido1)
        Me.GroupBox4.Controls.Add(Me.TCuil1)
        Me.GroupBox4.Controls.Add(Me.LApe)
        Me.GroupBox4.Location = New System.Drawing.Point(148, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(495, 100)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar Cliente"
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.Location = New System.Drawing.Point(365, 71)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarCliente.TabIndex = 4
        Me.BBuscarCliente.Text = "Buscar"
        Me.BBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuil"
        '
        'TApellido1
        '
        Me.TApellido1.Location = New System.Drawing.Point(314, 34)
        Me.TApellido1.Name = "TApellido1"
        Me.TApellido1.Size = New System.Drawing.Size(126, 20)
        Me.TApellido1.TabIndex = 3
        '
        'TCuil1
        '
        Me.TCuil1.Location = New System.Drawing.Point(89, 34)
        Me.TCuil1.Name = "TCuil1"
        Me.TCuil1.Size = New System.Drawing.Size(126, 20)
        Me.TCuil1.TabIndex = 2
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Location = New System.Drawing.Point(249, 41)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(44, 13)
        Me.LApe.TabIndex = 1
        Me.LApe.Text = "Apellido"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.CCuil, Me.CNombre, Me.CApellido, Me.CDirec, Me.CTelefono, Me.CFecha})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 171)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Orden"
        Me.Column1.Name = "Column1"
        '
        'CCuil
        '
        Me.CCuil.HeaderText = "Cuil"
        Me.CCuil.Name = "CCuil"
        '
        'CNombre
        '
        Me.CNombre.HeaderText = "Nombre"
        Me.CNombre.Name = "CNombre"
        '
        'CApellido
        '
        Me.CApellido.HeaderText = "Apellido"
        Me.CApellido.Name = "CApellido"
        '
        'CDirec
        '
        Me.CDirec.HeaderText = "Dirección"
        Me.CDirec.Name = "CDirec"
        '
        'CTelefono
        '
        Me.CTelefono.HeaderText = "Telefono"
        Me.CTelefono.Name = "CTelefono"
        '
        'CFecha
        '
        Me.CFecha.HeaderText = "Fecha de registro"
        Me.CFecha.Name = "CFecha"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestion Clientes    "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView2.Location = New System.Drawing.Point(26, 241)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(746, 107)
        Me.DataGridView2.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de registro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TId)
        Me.GroupBox3.Controls.Add(Me.LFechaReg)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.LId)
        Me.GroupBox3.Controls.Add(Me.LCuil)
        Me.GroupBox3.Controls.Add(Me.Ttel)
        Me.GroupBox3.Controls.Add(Me.TCuil)
        Me.GroupBox3.Controls.Add(Me.LTelefono)
        Me.GroupBox3.Controls.Add(Me.Tdireccion)
        Me.GroupBox3.Controls.Add(Me.LNombre)
        Me.GroupBox3.Controls.Add(Me.TNombre)
        Me.GroupBox3.Controls.Add(Me.LDireccion)
        Me.GroupBox3.Controls.Add(Me.TApellido)
        Me.GroupBox3.Controls.Add(Me.LApellido)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 170)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registrar Clientes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TId
        '
        Me.TId.Location = New System.Drawing.Point(79, 41)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(100, 20)
        Me.TId.TabIndex = 14
        '
        'LFechaReg
        '
        Me.LFechaReg.AutoSize = True
        Me.LFechaReg.Location = New System.Drawing.Point(31, 122)
        Me.LFechaReg.Name = "LFechaReg"
        Me.LFechaReg.Size = New System.Drawing.Size(89, 13)
        Me.LFechaReg.TabIndex = 5
        Me.LFechaReg.Text = "Fecha de registro"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(164, 122)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'LId
        '
        Me.LId.AutoSize = True
        Me.LId.Location = New System.Drawing.Point(31, 41)
        Me.LId.Name = "LId"
        Me.LId.Size = New System.Drawing.Size(16, 13)
        Me.LId.TabIndex = 13
        Me.LId.Text = "Id"
        '
        'LCuil
        '
        Me.LCuil.AutoSize = True
        Me.LCuil.Location = New System.Drawing.Point(213, 41)
        Me.LCuil.Name = "LCuil"
        Me.LCuil.Size = New System.Drawing.Size(24, 13)
        Me.LCuil.TabIndex = 0
        Me.LCuil.Text = "Cuil"
        '
        'Ttel
        '
        Me.Ttel.Location = New System.Drawing.Point(516, 97)
        Me.Ttel.Name = "Ttel"
        Me.Ttel.Size = New System.Drawing.Size(100, 20)
        Me.Ttel.TabIndex = 10
        '
        'TCuil
        '
        Me.TCuil.Location = New System.Drawing.Point(271, 41)
        Me.TCuil.Name = "TCuil"
        Me.TCuil.Size = New System.Drawing.Size(100, 20)
        Me.TCuil.TabIndex = 6
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(418, 97)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 4
        Me.LTelefono.Text = "Telefono"
        '
        'Tdireccion
        '
        Me.Tdireccion.Location = New System.Drawing.Point(301, 93)
        Me.Tdireccion.Name = "Tdireccion"
        Me.Tdireccion.Size = New System.Drawing.Size(100, 20)
        Me.Tdireccion.TabIndex = 9
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(418, 44)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(516, 41)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 7
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Location = New System.Drawing.Point(213, 93)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LDireccion.TabIndex = 3
        Me.LDireccion.Text = "Dirección"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(103, 90)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 8
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(31, 90)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(185, 354)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 62)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 29)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents TCuil1 As System.Windows.Forms.TextBox
    Friend WithEvents LApe As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCuil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDirec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TId As System.Windows.Forms.TextBox
    Friend WithEvents LFechaReg As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LId As System.Windows.Forms.Label
    Friend WithEvents LCuil As System.Windows.Forms.Label
    Friend WithEvents Ttel As System.Windows.Forms.TextBox
    Friend WithEvents TCuil As System.Windows.Forms.TextBox
    Friend WithEvents LTelefono As System.Windows.Forms.Label
    Friend WithEvents Tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents LDireccion As System.Windows.Forms.Label
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
