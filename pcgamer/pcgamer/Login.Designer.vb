<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LContrasena = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TContrasena = New System.Windows.Forms.TextBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(19, 20)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(215, 25)
        Me.LUsuario.TabIndex = 1
        Me.LUsuario.Text = "Nombre de Usuario:"
        '
        'LContrasena
        '
        Me.LContrasena.AutoSize = True
        Me.LContrasena.Location = New System.Drawing.Point(19, 117)
        Me.LContrasena.Name = "LContrasena"
        Me.LContrasena.Size = New System.Drawing.Size(136, 25)
        Me.LContrasena.TabIndex = 3
        Me.LContrasena.Text = "Contraseña:"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(24, 69)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(229, 32)
        Me.TUsuario.TabIndex = 2
        '
        'TContrasena
        '
        Me.TContrasena.Location = New System.Drawing.Point(24, 166)
        Me.TContrasena.Name = "TContrasena"
        Me.TContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TContrasena.Size = New System.Drawing.Size(229, 32)
        Me.TContrasena.TabIndex = 4
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(213, 151)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(409, 40)
        Me.LTitulo.TabIndex = 6
        Me.LTitulo.Text = "Bienvenido a Pc-Gamer"
        '
        'BIngresar
        '
        Me.BIngresar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BIngresar.BackColor = System.Drawing.Color.DarkRed
        Me.BIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BIngresar.ForeColor = System.Drawing.Color.White
        Me.BIngresar.Location = New System.Drawing.Point(668, 317)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(152, 55)
        Me.BIngresar.TabIndex = 5
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TUsuario)
        Me.Panel1.Controls.Add(Me.LUsuario)
        Me.Panel1.Controls.Add(Me.LContrasena)
        Me.Panel1.Controls.Add(Me.TContrasena)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(281, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 221)
        Me.Panel1.TabIndex = 0
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo_grande1
        Me.PBLogo.Location = New System.Drawing.Point(668, 122)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(159, 137)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 5
        Me.PBLogo.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.asus_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 673)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.LTitulo)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(150, 40)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login Pc-Gamer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsuario As Label
    Friend WithEvents LContrasena As Label
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents TContrasena As TextBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents BIngresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBLogo As PictureBox
End Class
