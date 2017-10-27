<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BVenta3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BVenta3))
        Me.BVenta1 = New System.Windows.Forms.Button()
        Me.BVenta2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BVenta1
        '
        Me.BVenta1.BackColor = System.Drawing.Color.DarkRed
        Me.BVenta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BVenta1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BVenta1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVenta1.ForeColor = System.Drawing.Color.White
        Me.BVenta1.Location = New System.Drawing.Point(208, 326)
        Me.BVenta1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BVenta1.Name = "BVenta1"
        Me.BVenta1.Size = New System.Drawing.Size(201, 32)
        Me.BVenta1.TabIndex = 4
        Me.BVenta1.Text = "Ventas por Cliente"
        Me.BVenta1.UseVisualStyleBackColor = False
        Me.BVenta1.Visible = False
        '
        'BVenta2
        '
        Me.BVenta2.BackColor = System.Drawing.Color.DarkRed
        Me.BVenta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BVenta2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BVenta2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVenta2.ForeColor = System.Drawing.Color.White
        Me.BVenta2.Location = New System.Drawing.Point(456, 326)
        Me.BVenta2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BVenta2.Name = "BVenta2"
        Me.BVenta2.Size = New System.Drawing.Size(201, 32)
        Me.BVenta2.TabIndex = 4
        Me.BVenta2.Text = "Ventas por Producto"
        Me.BVenta2.UseVisualStyleBackColor = False
        Me.BVenta2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(710, 326)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ventas por Vendedor"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'BVenta3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 673)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BVenta2)
        Me.Controls.Add(Me.BVenta1)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "BVenta3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario de Estadisticas de Ventas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVenta1 As Button
    Friend WithEvents BVenta2 As Button
    Friend WithEvents Button1 As Button
End Class
