<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.CMastercard = New System.Windows.Forms.CheckBox()
        Me.CNaranja = New System.Windows.Forms.CheckBox()
        Me.Cvisa = New System.Windows.Forms.CheckBox()
        Me.TNombre1 = New System.Windows.Forms.TextBox()
        Me.TApellido1 = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LTarjeta = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNyA = New System.Windows.Forms.Label()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.TDni1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.CMastercard)
        Me.Panel1.Controls.Add(Me.CNaranja)
        Me.Panel1.Controls.Add(Me.Cvisa)
        Me.Panel1.Controls.Add(Me.TNombre1)
        Me.Panel1.Controls.Add(Me.TApellido1)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.LModificar)
        Me.Panel1.Controls.Add(Me.LTarjeta)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.LNyA)
        Me.Panel1.Location = New System.Drawing.Point(21, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 302)
        Me.Panel1.TabIndex = 0
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(84, 187)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TTelefono.TabIndex = 1
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(15, 194)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(53, 13)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "*Telefono"
        '
        'CMastercard
        '
        Me.CMastercard.AutoSize = True
        Me.CMastercard.Location = New System.Drawing.Point(111, 271)
        Me.CMastercard.Name = "CMastercard"
        Me.CMastercard.Size = New System.Drawing.Size(79, 17)
        Me.CMastercard.TabIndex = 1
        Me.CMastercard.Text = "Mastercard"
        Me.CMastercard.UseVisualStyleBackColor = True
        '
        'CNaranja
        '
        Me.CNaranja.AutoSize = True
        Me.CNaranja.Location = New System.Drawing.Point(111, 226)
        Me.CNaranja.Name = "CNaranja"
        Me.CNaranja.Size = New System.Drawing.Size(63, 17)
        Me.CNaranja.TabIndex = 2
        Me.CNaranja.Text = "Naranja"
        Me.CNaranja.UseVisualStyleBackColor = True
        '
        'Cvisa
        '
        Me.Cvisa.AutoSize = True
        Me.Cvisa.Location = New System.Drawing.Point(111, 248)
        Me.Cvisa.Name = "Cvisa"
        Me.Cvisa.Size = New System.Drawing.Size(46, 17)
        Me.Cvisa.TabIndex = 1
        Me.Cvisa.Text = "Visa"
        Me.Cvisa.UseVisualStyleBackColor = True
        '
        'TNombre1
        '
        Me.TNombre1.Location = New System.Drawing.Point(84, 153)
        Me.TNombre1.Name = "TNombre1"
        Me.TNombre1.Size = New System.Drawing.Size(100, 20)
        Me.TNombre1.TabIndex = 1
        '
        'TApellido1
        '
        Me.TApellido1.Location = New System.Drawing.Point(84, 111)
        Me.TApellido1.Name = "TApellido1"
        Me.TApellido1.Size = New System.Drawing.Size(100, 20)
        Me.TApellido1.TabIndex = 2
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(84, 72)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 20)
        Me.TDni.TabIndex = 1
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LModificar.ForeColor = System.Drawing.Color.Red
        Me.LModificar.Location = New System.Drawing.Point(128, 34)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(50, 13)
        Me.LModificar.TabIndex = 1
        Me.LModificar.Text = "Modificar"
        '
        'LTarjeta
        '
        Me.LTarjeta.AutoSize = True
        Me.LTarjeta.Location = New System.Drawing.Point(15, 226)
        Me.LTarjeta.Name = "LTarjeta"
        Me.LTarjeta.Size = New System.Drawing.Size(90, 13)
        Me.LTarjeta.TabIndex = 1
        Me.LTarjeta.Text = "Tarjeta de credito"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(15, 160)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(48, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "*Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(15, 111)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(48, 13)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "*Apellido"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(15, 75)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(27, 13)
        Me.LDni.TabIndex = 1
        Me.LDni.Text = "*Dni"
        '
        'LNyA
        '
        Me.LNyA.AutoSize = True
        Me.LNyA.Location = New System.Drawing.Point(15, 34)
        Me.LNyA.Name = "LNyA"
        Me.LNyA.Size = New System.Drawing.Size(96, 13)
        Me.LNyA.TabIndex = 1
        Me.LNyA.Text = "*Nombre y Apellido"
        '
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Checked = True
        Me.RBVaron.Location = New System.Drawing.Point(260, 142)
        Me.RBVaron.Name = "RBVaron"
        Me.RBVaron.Size = New System.Drawing.Size(53, 17)
        Me.RBVaron.TabIndex = 2
        Me.RBVaron.TabStop = True
        Me.RBVaron.Text = "Varon"
        Me.RBVaron.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Location = New System.Drawing.Point(320, 142)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(51, 17)
        Me.RBMujer.TabIndex = 3
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'TDni1
        '
        Me.TDni1.Location = New System.Drawing.Point(84, 72)
        Me.TDni1.Name = "TDni1"
        Me.TDni1.Size = New System.Drawing.Size(100, 20)
        Me.TDni1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nuevo Ciente"
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Image = Global.Practicos.My.Resources.Resources.salir_min
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(296, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Image = Global.Practicos.My.Resources.Resources.eliminar_min
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(132, 359)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(102, 46)
        Me.BEliminar.TabIndex = 12
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BGuardar.Image = Global.Practicos.My.Resources.Resources.guardar_min
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BGuardar.Location = New System.Drawing.Point(21, 359)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(105, 46)
        Me.BGuardar.TabIndex = 11
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practicos.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(271, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 417)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.RBVaron)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LTelefono As System.Windows.Forms.Label
    Friend WithEvents CMastercard As System.Windows.Forms.CheckBox
    Friend WithEvents CNaranja As System.Windows.Forms.CheckBox
    Friend WithEvents Cvisa As System.Windows.Forms.CheckBox
    Friend WithEvents TNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents TApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents LTarjeta As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents LDni As System.Windows.Forms.Label
    Friend WithEvents LNyA As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RBVaron As System.Windows.Forms.RadioButton
    Friend WithEvents RBMujer As System.Windows.Forms.RadioButton
    Friend WithEvents TDni1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
