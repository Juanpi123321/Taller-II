<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioAdministrador))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BInformes = New System.Windows.Forms.Button()
        Me.BStock = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PBInformes = New System.Windows.Forms.PictureBox()
        Me.PBStock = New System.Windows.Forms.PictureBox()
        Me.PBClientes = New System.Windows.Forms.PictureBox()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(990, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 1
        Me.PBLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BInformes)
        Me.Panel1.Controls.Add(Me.BStock)
        Me.Panel1.Controls.Add(Me.BClientes)
        Me.Panel1.Controls.Add(Me.PBInformes)
        Me.Panel1.Controls.Add(Me.PBStock)
        Me.Panel1.Controls.Add(Me.PBClientes)
        Me.Panel1.Location = New System.Drawing.Point(318, 191)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 277)
        Me.Panel1.TabIndex = 2
        '
        'BInformes
        '
        Me.BInformes.BackColor = System.Drawing.Color.DarkRed
        Me.BInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BInformes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BInformes.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BInformes.ForeColor = System.Drawing.Color.White
        Me.BInformes.Location = New System.Drawing.Point(412, 203)
        Me.BInformes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BInformes.Name = "BInformes"
        Me.BInformes.Size = New System.Drawing.Size(180, 32)
        Me.BInformes.TabIndex = 2
        Me.BInformes.Text = "&3-Informes"
        Me.BInformes.UseVisualStyleBackColor = False
        '
        'BStock
        '
        Me.BStock.BackColor = System.Drawing.Color.DarkRed
        Me.BStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BStock.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BStock.ForeColor = System.Drawing.Color.White
        Me.BStock.Location = New System.Drawing.Point(212, 203)
        Me.BStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BStock.Name = "BStock"
        Me.BStock.Size = New System.Drawing.Size(180, 32)
        Me.BStock.TabIndex = 1
        Me.BStock.Text = "&2-Gestionar Productos"
        Me.BStock.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.DarkRed
        Me.BClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BClientes.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.ForeColor = System.Drawing.Color.White
        Me.BClientes.Location = New System.Drawing.Point(11, 203)
        Me.BClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(180, 32)
        Me.BClientes.TabIndex = 0
        Me.BClientes.Text = "&1-Gestionar Clientes"
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PBInformes
        '
        Me.PBInformes.Image = Global.pcgamer.My.Resources.Resources.informes
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
        Me.PBStock.Image = Global.pcgamer.My.Resources.Resources.people_work_metaphor_separated_white_29812042
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
        Me.PBClientes.Image = Global.pcgamer.My.Resources.Resources.Client_Service
        Me.PBClientes.Location = New System.Drawing.Point(11, 20)
        Me.PBClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBClientes.Name = "PBClientes"
        Me.PBClientes.Size = New System.Drawing.Size(180, 154)
        Me.PBClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBClientes.TabIndex = 0
        Me.PBClientes.TabStop = False
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
        Me.BCerrarSesion.TabIndex = 5
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(440, 72)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(371, 48)
        Me.LTitulo.TabIndex = 24
        Me.LTitulo.Text = "ADMINISTRADOR"
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(975, 646)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(153, 18)
        Me.LApeyNom.TabIndex = 28
        Me.LApeyNom.Text = "Gallardo Juan Pablo"
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LRol.Location = New System.Drawing.Point(830, 644)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(139, 20)
        Me.LRol.TabIndex = 27
        Me.LRol.Text = "Administrador:"
        '
        'FormularioAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.LApeyNom)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.BCerrarSesion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "FormularioAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Administrador"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BStock As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents PBStock As PictureBox
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents BInformes As Button
    Friend WithEvents PBInformes As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LRol As Label
End Class
