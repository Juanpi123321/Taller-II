<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioSuperAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioSuperAdmin))
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BRoles = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PBInformes = New System.Windows.Forms.PictureBox()
        Me.PBStock = New System.Windows.Forms.PictureBox()
        Me.PBClientes = New System.Windows.Forms.PictureBox()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PBInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.DarkRed
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCerrarSesion.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BCerrarSesion.Location = New System.Drawing.Point(1023, 72)
        Me.BCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(166, 32)
        Me.BCerrarSesion.TabIndex = 8
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BBackup)
        Me.Panel1.Controls.Add(Me.BRoles)
        Me.Panel1.Controls.Add(Me.BUsuarios)
        Me.Panel1.Controls.Add(Me.PBInformes)
        Me.Panel1.Controls.Add(Me.PBStock)
        Me.Panel1.Controls.Add(Me.PBClientes)
        Me.Panel1.Location = New System.Drawing.Point(316, 240)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 268)
        Me.Panel1.TabIndex = 7
        '
        'BBackup
        '
        Me.BBackup.BackColor = System.Drawing.Color.DarkRed
        Me.BBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBackup.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBackup.ForeColor = System.Drawing.Color.White
        Me.BBackup.Location = New System.Drawing.Point(412, 203)
        Me.BBackup.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(180, 32)
        Me.BBackup.TabIndex = 2
        Me.BBackup.Text = "&3-Backup"
        Me.BBackup.UseVisualStyleBackColor = False
        '
        'BRoles
        '
        Me.BRoles.BackColor = System.Drawing.Color.DarkRed
        Me.BRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BRoles.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRoles.ForeColor = System.Drawing.Color.White
        Me.BRoles.Location = New System.Drawing.Point(212, 203)
        Me.BRoles.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BRoles.Name = "BRoles"
        Me.BRoles.Size = New System.Drawing.Size(180, 32)
        Me.BRoles.TabIndex = 1
        Me.BRoles.Text = "&2-Roles y Permisos"
        Me.BRoles.UseVisualStyleBackColor = False
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.DarkRed
        Me.BUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BUsuarios.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUsuarios.ForeColor = System.Drawing.Color.White
        Me.BUsuarios.Location = New System.Drawing.Point(11, 203)
        Me.BUsuarios.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(180, 32)
        Me.BUsuarios.TabIndex = 0
        Me.BUsuarios.Text = "&1-Gestionar Usuarios"
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PBInformes
        '
        Me.PBInformes.Image = Global.pcgamer.My.Resources.Resources.database_backup_icons2
        Me.PBInformes.Location = New System.Drawing.Point(412, 20)
        Me.PBInformes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBInformes.Name = "PBInformes"
        Me.PBInformes.Size = New System.Drawing.Size(180, 154)
        Me.PBInformes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBInformes.TabIndex = 0
        Me.PBInformes.TabStop = False
        '
        'PBStock
        '
        Me.PBStock.Image = Global.pcgamer.My.Resources.Resources.candado_3d_8714068
        Me.PBStock.Location = New System.Drawing.Point(212, 20)
        Me.PBStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBStock.Name = "PBStock"
        Me.PBStock.Size = New System.Drawing.Size(180, 154)
        Me.PBStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBStock.TabIndex = 0
        Me.PBStock.TabStop = False
        '
        'PBClientes
        '
        Me.PBClientes.BackColor = System.Drawing.Color.White
        Me.PBClientes.Image = Global.pcgamer.My.Resources.Resources.c69234e64fceb53934dd5c54b822075c
        Me.PBClientes.Location = New System.Drawing.Point(11, 20)
        Me.PBClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBClientes.Name = "PBClientes"
        Me.PBClientes.Size = New System.Drawing.Size(180, 154)
        Me.PBClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBClientes.TabIndex = 0
        Me.PBClientes.TabStop = False
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 6
        Me.PBLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.pcgamer.My.Resources.Resources.super_admin
        Me.PictureBox1.Location = New System.Drawing.Point(-18, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(366, 81)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(519, 48)
        Me.LTitulo.TabIndex = 23
        Me.LTitulo.Text = "SUPER-ADMINISTRADOR"
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(889, 646)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(0, 18)
        Me.LApeyNom.TabIndex = 28
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.Color.White
        Me.LRol.Location = New System.Drawing.Point(685, 644)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(190, 20)
        Me.LRol.TabIndex = 27
        Me.LRol.Text = "SuperAdministrador:"
        '
        'FormularioSuperAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.superadmin_background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BCerrarSesion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "FormularioSuperAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Super Admininistrador"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BBackup As Button
    Friend WithEvents BRoles As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents PBInformes As PictureBox
    Friend WithEvents PBStock As PictureBox
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
End Class
