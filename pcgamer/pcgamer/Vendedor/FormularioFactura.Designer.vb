<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFactura))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LEmpresa5 = New System.Windows.Forms.Label()
        Me.LEmpresa4 = New System.Windows.Forms.Label()
        Me.LEmpresa3 = New System.Windows.Forms.Label()
        Me.LEmpresa2 = New System.Windows.Forms.Label()
        Me.LEmpresa1 = New System.Windows.Forms.Label()
        Me.PBEmpresa = New System.Windows.Forms.PictureBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo
        Me.PBLogo.Location = New System.Drawing.Point(794, 14)
        Me.PBLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(198, 34)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 2
        Me.PBLogo.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(358, 14)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(284, 40)
        Me.LTitulo.TabIndex = 13
        Me.LTitulo.Text = "Generar Factura"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(113, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 462)
        Me.Panel1.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(785, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(470, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(318, 163)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(399, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 89)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LEmpresa5)
        Me.GroupBox1.Controls.Add(Me.LEmpresa4)
        Me.GroupBox1.Controls.Add(Me.LEmpresa3)
        Me.GroupBox1.Controls.Add(Me.LEmpresa2)
        Me.GroupBox1.Controls.Add(Me.LEmpresa1)
        Me.GroupBox1.Controls.Add(Me.PBEmpresa)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pc-Gamer"
        '
        'LEmpresa5
        '
        Me.LEmpresa5.AutoSize = True
        Me.LEmpresa5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa5.Location = New System.Drawing.Point(120, 99)
        Me.LEmpresa5.Name = "LEmpresa5"
        Me.LEmpresa5.Size = New System.Drawing.Size(239, 18)
        Me.LEmpresa5.TabIndex = 1
        Me.LEmpresa5.Text = "E-mail: pcgamer@hotmail.com"
        '
        'LEmpresa4
        '
        Me.LEmpresa4.AutoSize = True
        Me.LEmpresa4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa4.Location = New System.Drawing.Point(120, 81)
        Me.LEmpresa4.Name = "LEmpresa4"
        Me.LEmpresa4.Size = New System.Drawing.Size(209, 18)
        Me.LEmpresa4.TabIndex = 1
        Me.LEmpresa4.Text = "Telefonos: (379) 4221129"
        '
        'LEmpresa3
        '
        Me.LEmpresa3.AutoSize = True
        Me.LEmpresa3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa3.Location = New System.Drawing.Point(120, 60)
        Me.LEmpresa3.Name = "LEmpresa3"
        Me.LEmpresa3.Size = New System.Drawing.Size(268, 18)
        Me.LEmpresa3.TabIndex = 1
        Me.LEmpresa3.Text = "CP (3400) - Corrientes - Argentina"
        '
        'LEmpresa2
        '
        Me.LEmpresa2.AutoSize = True
        Me.LEmpresa2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa2.Location = New System.Drawing.Point(120, 42)
        Me.LEmpresa2.Name = "LEmpresa2"
        Me.LEmpresa2.Size = New System.Drawing.Size(123, 18)
        Me.LEmpresa2.TabIndex = 1
        Me.LEmpresa2.Text = "9 de Julio 1449"
        '
        'LEmpresa1
        '
        Me.LEmpresa1.AutoSize = True
        Me.LEmpresa1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmpresa1.Location = New System.Drawing.Point(120, 22)
        Me.LEmpresa1.Name = "LEmpresa1"
        Me.LEmpresa1.Size = New System.Drawing.Size(142, 18)
        Me.LEmpresa1.TabIndex = 1
        Me.LEmpresa1.Text = "Pc-Gamer S.R.L."
        '
        'PBEmpresa
        '
        Me.PBEmpresa.Image = Global.pcgamer.My.Resources.Resources.pcgamer_logo_grande2
        Me.PBEmpresa.Location = New System.Drawing.Point(3, 22)
        Me.PBEmpresa.Name = "PBEmpresa"
        Me.PBEmpresa.Size = New System.Drawing.Size(100, 95)
        Me.PBEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEmpresa.TabIndex = 0
        Me.PBEmpresa.TabStop = False
        '
        'FormularioFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioFactura"
        Me.Text = "Formulario Factura"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PBEmpresa As PictureBox
    Friend WithEvents LEmpresa5 As Label
    Friend WithEvents LEmpresa4 As Label
    Friend WithEvents LEmpresa3 As Label
    Friend WithEvents LEmpresa2 As Label
    Friend WithEvents LEmpresa1 As Label
    Friend WithEvents Label6 As Label
End Class
