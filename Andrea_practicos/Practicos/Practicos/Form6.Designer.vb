<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RBmujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LNac = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.RBmujer)
        Me.Panel1.Controls.Add(Me.RBHombre)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.BFoto)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.LSaldo)
        Me.Panel1.Controls.Add(Me.LSexo)
        Me.Panel1.Controls.Add(Me.LNac)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Location = New System.Drawing.Point(71, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 316)
        Me.Panel1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(201, 130)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 22)
        Me.DateTimePicker1.TabIndex = 13
        '
        'RBmujer
        '
        Me.RBmujer.AutoSize = True
        Me.RBmujer.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmujer.Location = New System.Drawing.Point(221, 170)
        Me.RBmujer.Margin = New System.Windows.Forms.Padding(4)
        Me.RBmujer.Name = "RBmujer"
        Me.RBmujer.Size = New System.Drawing.Size(69, 28)
        Me.RBmujer.TabIndex = 12
        Me.RBmujer.TabStop = True
        Me.RBmujer.Text = "Mujer"
        Me.RBmujer.UseVisualStyleBackColor = True
        '
        'RBHombre
        '
        Me.RBHombre.AutoSize = True
        Me.RBHombre.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBHombre.Location = New System.Drawing.Point(115, 167)
        Me.RBHombre.Margin = New System.Windows.Forms.Padding(4)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(84, 28)
        Me.RBHombre.TabIndex = 11
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.Practicos.My.Resources.Resources.guardar_min
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(129, 266)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(144, 47)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BFoto
        '
        Me.BFoto.Location = New System.Drawing.Point(21, 234)
        Me.BFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(100, 25)
        Me.BFoto.TabIndex = 9
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(129, 234)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(212, 22)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 202)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(212, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 84)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 27)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 22)
        Me.TextBox1.TabIndex = 5
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSaldo.Location = New System.Drawing.Point(17, 202)
        Me.LSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(70, 31)
        Me.LSaldo.TabIndex = 4
        Me.LSaldo.Text = "Saldo"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.Location = New System.Drawing.Point(15, 167)
        Me.LSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(63, 31)
        Me.LSexo.TabIndex = 3
        Me.LSexo.Text = "Sexo"
        '
        'LNac
        '
        Me.LNac.AutoSize = True
        Me.LNac.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LNac.Location = New System.Drawing.Point(4, 124)
        Me.LNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNac.Name = "LNac"
        Me.LNac.Size = New System.Drawing.Size(191, 31)
        Me.LNac.TabIndex = 2
        Me.LNac.Text = "Fecha de nacimiento"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.Location = New System.Drawing.Point(17, 84)
        Me.LApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(89, 31)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(17, 27)
        Me.LNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(84, 31)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practicos.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(458, 95)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CApellido, Me.CNombre, Me.CFecha, Me.CSexo, Me.CEliminar, Me.CSaldo, Me.CFoto, Me.CRuta})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 382)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1040, 116)
        Me.DataGridView1.TabIndex = 2
        '
        'CApellido
        '
        Me.CApellido.HeaderText = "Apellido"
        Me.CApellido.Name = "CApellido"
        '
        'CNombre
        '
        Me.CNombre.HeaderText = "Nombre"
        Me.CNombre.Name = "CNombre"
        '
        'CFecha
        '
        Me.CFecha.HeaderText = "Fecha de nacimiento"
        Me.CFecha.Name = "CFecha"
        '
        'CSexo
        '
        Me.CSexo.HeaderText = "Sexo"
        Me.CSexo.Name = "CSexo"
        '
        'CEliminar
        '
        Me.CEliminar.HeaderText = "Eliminar"
        Me.CEliminar.Name = "CEliminar"
        Me.CEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CEliminar.Text = "Eliminar"
        '
        'CSaldo
        '
        Me.CSaldo.HeaderText = "Saldo"
        Me.CSaldo.Name = "CSaldo"
        '
        'CFoto
        '
        Me.CFoto.HeaderText = "Foto"
        Me.CFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.CFoto.Name = "CFoto"
        Me.CFoto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CRuta
        '
        Me.CRuta.HeaderText = "Ruta"
        Me.CRuta.Name = "CRuta"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practicos.My.Resources.Resources.descarga
        Me.ClientSize = New System.Drawing.Size(1085, 512)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LSaldo As System.Windows.Forms.Label
    Friend WithEvents LSexo As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BFoto As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents RBHombre As System.Windows.Forms.RadioButton
    Friend WithEvents RBmujer As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LNac As System.Windows.Forms.Label
    Friend WithEvents CApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFoto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CRuta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
