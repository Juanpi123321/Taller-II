<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Bquitar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BVender = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LCuilCliente = New System.Windows.Forms.Label()
        Me.Lidcliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LapeVend = New System.Windows.Forms.Label()
        Me.LNomVend = New System.Windows.Forms.Label()
        Me.LCuilVendedor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LFechaFac = New System.Windows.Forms.Label()
        Me.LordenFactura = New System.Windows.Forms.Label()
        Me.Lnum = New System.Windows.Forms.Label()
        Me.LFactura = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(24, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 545)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LTotal)
        Me.Panel4.Location = New System.Drawing.Point(614, 466)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(113, 50)
        Me.Panel4.TabIndex = 6
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Location = New System.Drawing.Point(3, 17)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(43, 13)
        Me.LTotal.TabIndex = 0
        Me.LTotal.Text = "Total: $"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Bquitar)
        Me.Panel3.Controls.Add(Me.BCancelar)
        Me.Panel3.Controls.Add(Me.BVender)
        Me.Panel3.Controls.Add(Me.BAgregar)
        Me.Panel3.Controls.Add(Me.BEditar)
        Me.Panel3.Location = New System.Drawing.Point(46, 466)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(525, 50)
        Me.Panel3.TabIndex = 5
        '
        'Bquitar
        '
        Me.Bquitar.Location = New System.Drawing.Point(208, 8)
        Me.Bquitar.Name = "Bquitar"
        Me.Bquitar.Size = New System.Drawing.Size(84, 37)
        Me.Bquitar.TabIndex = 0
        Me.Bquitar.Text = "Quitar Producto"
        Me.Bquitar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(302, 8)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(84, 37)
        Me.BCancelar.TabIndex = 0
        Me.BCancelar.Text = "Cancelar Venta"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BVender
        '
        Me.BVender.Location = New System.Drawing.Point(397, 8)
        Me.BVender.Name = "BVender"
        Me.BVender.Size = New System.Drawing.Size(75, 37)
        Me.BVender.TabIndex = 0
        Me.BVender.Text = "Vender"
        Me.BVender.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(28, 8)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(84, 37)
        Me.BAgregar.TabIndex = 0
        Me.BAgregar.Text = "Agregar Producto"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(118, 8)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(84, 37)
        Me.BEditar.TabIndex = 0
        Me.BEditar.Text = "Editar "
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(717, 110)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Orden"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sabor1"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sabor2"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
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
        Me.Column7.HeaderText = "Cantidad"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Precio"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column10
        '
        Me.Column10.HeaderText = "SubTotal"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 70
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(133, 304)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(411, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 119)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Producto    "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(203, 35)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Producto:  "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.BBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.LCuilCliente)
        Me.GroupBox2.Controls.Add(Me.Lidcliente)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 119)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente   "
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(280, 65)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 46)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Nuevo Cliente"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.Location = New System.Drawing.Point(280, 19)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BBuscarCliente.TabIndex = 5
        Me.BBuscarCliente.Text = "Buscar"
        Me.BBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre y apellido"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(119, 58)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(119, 24)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(117, 20)
        Me.TextBox4.TabIndex = 2
        '
        'LCuilCliente
        '
        Me.LCuilCliente.AutoSize = True
        Me.LCuilCliente.Location = New System.Drawing.Point(30, 65)
        Me.LCuilCliente.Name = "LCuilCliente"
        Me.LCuilCliente.Size = New System.Drawing.Size(24, 13)
        Me.LCuilCliente.TabIndex = 1
        Me.LCuilCliente.Text = "Cuil"
        '
        'Lidcliente
        '
        Me.Lidcliente.AutoSize = True
        Me.Lidcliente.Location = New System.Drawing.Point(38, 24)
        Me.Lidcliente.Name = "Lidcliente"
        Me.Lidcliente.Size = New System.Drawing.Size(16, 13)
        Me.Lidcliente.TabIndex = 0
        Me.Lidcliente.Text = "Id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LapeVend)
        Me.GroupBox1.Controls.Add(Me.LNomVend)
        Me.GroupBox1.Controls.Add(Me.LCuilVendedor)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Vendedor   "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(497, 23)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(266, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'LapeVend
        '
        Me.LapeVend.AutoSize = True
        Me.LapeVend.Location = New System.Drawing.Point(423, 26)
        Me.LapeVend.Name = "LapeVend"
        Me.LapeVend.Size = New System.Drawing.Size(50, 13)
        Me.LapeVend.TabIndex = 2
        Me.LapeVend.Text = "Apellido: "
        '
        'LNomVend
        '
        Me.LNomVend.AutoSize = True
        Me.LNomVend.Location = New System.Drawing.Point(206, 26)
        Me.LNomVend.Name = "LNomVend"
        Me.LNomVend.Size = New System.Drawing.Size(47, 13)
        Me.LNomVend.TabIndex = 1
        Me.LNomVend.Text = "Nombre:"
        '
        'LCuilVendedor
        '
        Me.LCuilVendedor.AutoSize = True
        Me.LCuilVendedor.Location = New System.Drawing.Point(13, 26)
        Me.LCuilVendedor.Name = "LCuilVendedor"
        Me.LCuilVendedor.Size = New System.Drawing.Size(27, 13)
        Me.LCuilVendedor.TabIndex = 0
        Me.LCuilVendedor.Text = "Cuil:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.LFechaFac)
        Me.Panel2.Controls.Add(Me.LordenFactura)
        Me.Panel2.Controls.Add(Me.Lnum)
        Me.Panel2.Controls.Add(Me.LFactura)
        Me.Panel2.Location = New System.Drawing.Point(13, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 123)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.encabezado1
        Me.PictureBox1.Location = New System.Drawing.Point(16, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(615, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(84, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'LFechaFac
        '
        Me.LFechaFac.AutoSize = True
        Me.LFechaFac.Location = New System.Drawing.Point(553, 88)
        Me.LFechaFac.Name = "LFechaFac"
        Me.LFechaFac.Size = New System.Drawing.Size(43, 13)
        Me.LFechaFac.TabIndex = 3
        Me.LFechaFac.Text = "Fecha: "
        '
        'LordenFactura
        '
        Me.LordenFactura.AutoSize = True
        Me.LordenFactura.Location = New System.Drawing.Point(656, 56)
        Me.LordenFactura.Name = "LordenFactura"
        Me.LordenFactura.Size = New System.Drawing.Size(31, 13)
        Me.LordenFactura.TabIndex = 2
        Me.LordenFactura.Text = "0000"
        '
        'Lnum
        '
        Me.Lnum.AutoSize = True
        Me.Lnum.Location = New System.Drawing.Point(584, 56)
        Me.Lnum.Name = "Lnum"
        Me.Lnum.Size = New System.Drawing.Size(19, 13)
        Me.Lnum.TabIndex = 1
        Me.Lnum.Text = "N°"
        '
        'LFactura
        '
        Me.LFactura.AutoSize = True
        Me.LFactura.Location = New System.Drawing.Point(617, 20)
        Me.LFactura.Name = "LFactura"
        Me.LFactura.Size = New System.Drawing.Size(43, 13)
        Me.LFactura.TabIndex = 0
        Me.LFactura.Text = "Factura"
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LTotal As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Bquitar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BVender As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LFechaFac As System.Windows.Forms.Label
    Friend WithEvents LordenFactura As System.Windows.Forms.Label
    Friend WithEvents Lnum As System.Windows.Forms.Label
    Friend WithEvents LFactura As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LCuilCliente As System.Windows.Forms.Label
    Friend WithEvents Lidcliente As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LapeVend As System.Windows.Forms.Label
    Friend WithEvents LNomVend As System.Windows.Forms.Label
    Friend WithEvents LCuilVendedor As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
