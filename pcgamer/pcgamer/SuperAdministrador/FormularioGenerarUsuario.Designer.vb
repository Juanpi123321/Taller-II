<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioGenerarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioGenerarUsuario))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LContrasena = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TContrasena = New System.Windows.Forms.TextBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(71, 9)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(397, 25)
        Me.LTitulo.TabIndex = 5
        Me.LTitulo.Text = "Su Usuario y Contraseña son los siguientes:"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(88, 52)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(72, 20)
        Me.LUsuario.TabIndex = 1
        Me.LUsuario.Text = "Usuario:"
        '
        'LContrasena
        '
        Me.LContrasena.AutoSize = True
        Me.LContrasena.Location = New System.Drawing.Point(88, 87)
        Me.LContrasena.Name = "LContrasena"
        Me.LContrasena.Size = New System.Drawing.Size(100, 20)
        Me.LContrasena.TabIndex = 2
        Me.LContrasena.Text = "Contraseña:"
        '
        'TUsuario
        '
        Me.TUsuario.BackColor = System.Drawing.Color.White
        Me.TUsuario.Location = New System.Drawing.Point(222, 47)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.ReadOnly = True
        Me.TUsuario.Size = New System.Drawing.Size(209, 27)
        Me.TUsuario.TabIndex = 3
        '
        'TContrasena
        '
        Me.TContrasena.BackColor = System.Drawing.Color.White
        Me.TContrasena.Location = New System.Drawing.Point(222, 85)
        Me.TContrasena.Name = "TContrasena"
        Me.TContrasena.ReadOnly = True
        Me.TContrasena.Size = New System.Drawing.Size(209, 27)
        Me.TContrasena.TabIndex = 4
        '
        'BAceptar
        '
        Me.BAceptar.BackColor = System.Drawing.Color.DarkRed
        Me.BAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAceptar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAceptar.ForeColor = System.Drawing.Color.White
        Me.BAceptar.Location = New System.Drawing.Point(437, 117)
        Me.BAceptar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(95, 31)
        Me.BAceptar.TabIndex = 0
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = False
        '
        'FormularioGenerarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(545, 158)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TContrasena)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LContrasena)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(580, 200)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormularioGenerarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Generar Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents LContrasena As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents TContrasena As TextBox
    Friend WithEvents BAceptar As Button
End Class
