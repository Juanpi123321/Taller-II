<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario5
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
        Me.LNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TFoto = New System.Windows.Forms.TextBox()
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LFechaNac = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LNombre.Font = New System.Drawing.Font("Papyrus", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(3, 12)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(125, 44)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Controls.Add(Me.BFoto)
        Me.Panel1.Controls.Add(Me.RBMujer)
        Me.Panel1.Controls.Add(Me.RBHombre)
        Me.Panel1.Controls.Add(Me.FechaNac)
        Me.Panel1.Controls.Add(Me.TFoto)
        Me.Panel1.Controls.Add(Me.TSaldo)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LSaldo)
        Me.Panel1.Controls.Add(Me.LSexo)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LFechaNac)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Location = New System.Drawing.Point(48, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 327)
        Me.Panel1.TabIndex = 2
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.Practicos.My.Resources.Resources.guardar2_min
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(158, 269)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(123, 44)
        Me.BAgregar.TabIndex = 9
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BFoto
        '
        Me.BFoto.Location = New System.Drawing.Point(20, 239)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(75, 23)
        Me.BFoto.TabIndex = 7
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Font = New System.Drawing.Font("Papyrus", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMujer.ForeColor = System.Drawing.Color.White
        Me.RBMujer.Location = New System.Drawing.Point(254, 155)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(68, 26)
        Me.RBMujer.TabIndex = 5
        Me.RBMujer.TabStop = True
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'RBHombre
        '
        Me.RBHombre.AutoSize = True
        Me.RBHombre.Checked = True
        Me.RBHombre.Font = New System.Drawing.Font("Papyrus", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBHombre.ForeColor = System.Drawing.Color.White
        Me.RBHombre.Location = New System.Drawing.Point(158, 155)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(84, 26)
        Me.RBHombre.TabIndex = 4
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = True
        '
        'FechaNac
        '
        Me.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNac.Location = New System.Drawing.Point(268, 110)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(92, 22)
        Me.FechaNac.TabIndex = 3
        Me.FechaNac.Value = New Date(2014, 5, 12, 11, 25, 0, 0)
        '
        'TFoto
        '
        Me.TFoto.Location = New System.Drawing.Point(127, 241)
        Me.TFoto.Name = "TFoto"
        Me.TFoto.Size = New System.Drawing.Size(254, 22)
        Me.TFoto.TabIndex = 8
        '
        'TSaldo
        '
        Me.TSaldo.Location = New System.Drawing.Point(127, 200)
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.Size = New System.Drawing.Size(254, 22)
        Me.TSaldo.TabIndex = 6
        Me.TSaldo.Text = "0"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(127, 68)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(254, 22)
        Me.TApellido.TabIndex = 1
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(127, 24)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(254, 22)
        Me.TNombre.TabIndex = 0
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LSaldo.Font = New System.Drawing.Font("Papyrus", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSaldo.ForeColor = System.Drawing.Color.White
        Me.LSaldo.Location = New System.Drawing.Point(3, 188)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(103, 44)
        Me.LSaldo.TabIndex = 0
        Me.LSaldo.Text = "Saldo:"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LSexo.Font = New System.Drawing.Font("Papyrus", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.Color.White
        Me.LSexo.Location = New System.Drawing.Point(3, 144)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(94, 44)
        Me.LSexo.TabIndex = 0
        Me.LSexo.Text = "Sexo:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LApellido.Font = New System.Drawing.Font("Papyrus", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(3, 56)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(130, 44)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido:"
        '
        'LFechaNac
        '
        Me.LFechaNac.AutoSize = True
        Me.LFechaNac.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LFechaNac.Font = New System.Drawing.Font("Papyrus", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaNac.ForeColor = System.Drawing.Color.White
        Me.LFechaNac.Location = New System.Drawing.Point(3, 100)
        Me.LFechaNac.Name = "LFechaNac"
        Me.LFechaNac.Size = New System.Drawing.Size(244, 44)
        Me.LFechaNac.TabIndex = 0
        Me.LFechaNac.Text = "Fecha Nacimiento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Practicos.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(487, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 327)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Fecha_Nacimiento, Me.Sexo, Me.Eliminar, Me.Saldo, Me.Foto, Me.Ruta})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 395)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(846, 204)
        Me.DataGridView1.TabIndex = 4
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Fecha_Nacimiento
        '
        Me.Fecha_Nacimiento.HeaderText = "Fecha Nacimiento"
        Me.Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.Name = "Foto"
        '
        'Ruta
        '
        Me.Ruta.HeaderText = "Ruta"
        Me.Ruta.Name = "Ruta"
        '
        'Formulario5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practicos.My.Resources.Resources.imagen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(870, 627)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Formulario5"
        Me.Text = "Formulario con DataGrid"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LNombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BAgregar As Button
    Friend WithEvents BFoto As Button
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents FechaNac As DateTimePicker
    Friend WithEvents TFoto As TextBox
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LSaldo As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LFechaNac As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
End Class
