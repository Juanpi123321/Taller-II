﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioVendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioVendedor))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BStock = New System.Windows.Forms.Button()
        Me.BCliente = New System.Windows.Forms.Button()
        Me.BFactura = New System.Windows.Forms.Button()
        Me.PBCliente = New System.Windows.Forms.PictureBox()
        Me.PBStock = New System.Windows.Forms.PictureBox()
        Me.PBFactura = New System.Windows.Forms.PictureBox()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LRol = New System.Windows.Forms.Label()
        Me.LApeyNom = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFactura, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BStock)
        Me.Panel1.Controls.Add(Me.BCliente)
        Me.Panel1.Controls.Add(Me.BFactura)
        Me.Panel1.Controls.Add(Me.PBCliente)
        Me.Panel1.Controls.Add(Me.PBStock)
        Me.Panel1.Controls.Add(Me.PBFactura)
        Me.Panel1.Location = New System.Drawing.Point(318, 191)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 277)
        Me.Panel1.TabIndex = 1
        '
        'BStock
        '
        Me.BStock.BackColor = System.Drawing.Color.DarkRed
        Me.BStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BStock.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BStock.ForeColor = System.Drawing.Color.White
        Me.BStock.Location = New System.Drawing.Point(412, 203)
        Me.BStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BStock.Name = "BStock"
        Me.BStock.Size = New System.Drawing.Size(180, 32)
        Me.BStock.TabIndex = 1
        Me.BStock.Text = "&3-Consultar Stock"
        Me.BStock.UseVisualStyleBackColor = False
        '
        'BCliente
        '
        Me.BCliente.BackColor = System.Drawing.Color.DarkRed
        Me.BCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCliente.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCliente.ForeColor = System.Drawing.Color.White
        Me.BCliente.Location = New System.Drawing.Point(212, 203)
        Me.BCliente.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BCliente.Name = "BCliente"
        Me.BCliente.Size = New System.Drawing.Size(180, 32)
        Me.BCliente.TabIndex = 1
        Me.BCliente.Text = "&2-Registrar/Consultar"
        Me.BCliente.UseVisualStyleBackColor = False
        '
        'BFactura
        '
        Me.BFactura.BackColor = System.Drawing.Color.DarkRed
        Me.BFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BFactura.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFactura.ForeColor = System.Drawing.Color.White
        Me.BFactura.Location = New System.Drawing.Point(11, 203)
        Me.BFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BFactura.Name = "BFactura"
        Me.BFactura.Size = New System.Drawing.Size(180, 32)
        Me.BFactura.TabIndex = 1
        Me.BFactura.Text = "&1-Generar Factura"
        Me.BFactura.UseVisualStyleBackColor = False
        '
        'PBCliente
        '
        Me.PBCliente.Image = Global.pcgamer.My.Resources.Resources.cliente
        Me.PBCliente.Location = New System.Drawing.Point(212, 20)
        Me.PBCliente.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBCliente.Name = "PBCliente"
        Me.PBCliente.Size = New System.Drawing.Size(180, 154)
        Me.PBCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCliente.TabIndex = 0
        Me.PBCliente.TabStop = False
        '
        'PBStock
        '
        Me.PBStock.Image = Global.pcgamer.My.Resources.Resources.stock
        Me.PBStock.Location = New System.Drawing.Point(412, 20)
        Me.PBStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBStock.Name = "PBStock"
        Me.PBStock.Size = New System.Drawing.Size(180, 154)
        Me.PBStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBStock.TabIndex = 0
        Me.PBStock.TabStop = False
        '
        'PBFactura
        '
        Me.PBFactura.Image = Global.pcgamer.My.Resources.Resources.factura4
        Me.PBFactura.Location = New System.Drawing.Point(11, 20)
        Me.PBFactura.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PBFactura.Name = "PBFactura"
        Me.PBFactura.Size = New System.Drawing.Size(180, 154)
        Me.PBFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFactura.TabIndex = 0
        Me.PBFactura.TabStop = False
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
        Me.BCerrarSesion.TabIndex = 1
        Me.BCerrarSesion.Text = "Cerrar Sesion"
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(542, 87)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(248, 48)
        Me.LTitulo.TabIndex = 24
        Me.LTitulo.Text = "VENDEDOR"
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRol.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LRol.Location = New System.Drawing.Point(857, 644)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(98, 20)
        Me.LRol.TabIndex = 25
        Me.LRol.Text = "Vendedor:"
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.BackColor = System.Drawing.Color.Transparent
        Me.LApeyNom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApeyNom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LApeyNom.Location = New System.Drawing.Point(961, 646)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(125, 18)
        Me.LApeyNom.TabIndex = 26
        Me.LApeyNom.Text = "Monzon Andrea"
        '
        'FormularioVendedor
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
        Me.Name = "FormularioVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario Vendedor"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BFactura As Button
    Friend WithEvents PBCliente As PictureBox
    Friend WithEvents PBStock As PictureBox
    Friend WithEvents PBFactura As PictureBox
    Friend WithEvents BStock As Button
    Friend WithEvents BCliente As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LTitulo As Label
    Friend WithEvents LRol As Label
    Friend WithEvents LApeyNom As Label
End Class
