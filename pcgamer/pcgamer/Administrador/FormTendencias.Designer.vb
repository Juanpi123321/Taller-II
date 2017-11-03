<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTendencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTendencias))
        Me.LTendenciaSemana = New System.Windows.Forms.Label()
        Me.LTendenciaMes = New System.Windows.Forms.Label()
        Me.BTendenciaSemana = New System.Windows.Forms.Button()
        Me.BTendenciaMes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LTendenciaSemana
        '
        Me.LTendenciaSemana.AutoSize = True
        Me.LTendenciaSemana.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LTendenciaSemana.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTendenciaSemana.ForeColor = System.Drawing.Color.White
        Me.LTendenciaSemana.Location = New System.Drawing.Point(126, 42)
        Me.LTendenciaSemana.Name = "LTendenciaSemana"
        Me.LTendenciaSemana.Size = New System.Drawing.Size(300, 29)
        Me.LTendenciaSemana.TabIndex = 0
        Me.LTendenciaSemana.Text = "Tendencia de la Semana"
        '
        'LTendenciaMes
        '
        Me.LTendenciaMes.AutoSize = True
        Me.LTendenciaMes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LTendenciaMes.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTendenciaMes.ForeColor = System.Drawing.Color.White
        Me.LTendenciaMes.Location = New System.Drawing.Point(152, 151)
        Me.LTendenciaMes.Name = "LTendenciaMes"
        Me.LTendenciaMes.Size = New System.Drawing.Size(229, 29)
        Me.LTendenciaMes.TabIndex = 1
        Me.LTendenciaMes.Text = "Tendencia del Mes"
        '
        'BTendenciaSemana
        '
        Me.BTendenciaSemana.BackColor = System.Drawing.Color.DarkRed
        Me.BTendenciaSemana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTendenciaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTendenciaSemana.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTendenciaSemana.ForeColor = System.Drawing.Color.White
        Me.BTendenciaSemana.Location = New System.Drawing.Point(208, 91)
        Me.BTendenciaSemana.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BTendenciaSemana.Name = "BTendenciaSemana"
        Me.BTendenciaSemana.Size = New System.Drawing.Size(122, 36)
        Me.BTendenciaSemana.TabIndex = 2
        Me.BTendenciaSemana.Text = "Ver"
        Me.BTendenciaSemana.UseVisualStyleBackColor = False
        '
        'BTendenciaMes
        '
        Me.BTendenciaMes.BackColor = System.Drawing.Color.DarkRed
        Me.BTendenciaMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTendenciaMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTendenciaMes.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTendenciaMes.ForeColor = System.Drawing.Color.White
        Me.BTendenciaMes.Location = New System.Drawing.Point(208, 200)
        Me.BTendenciaMes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BTendenciaMes.Name = "BTendenciaMes"
        Me.BTendenciaMes.Size = New System.Drawing.Size(122, 36)
        Me.BTendenciaMes.TabIndex = 3
        Me.BTendenciaMes.Text = "Ver"
        Me.BTendenciaMes.UseVisualStyleBackColor = False
        '
        'FormTendencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.ClientSize = New System.Drawing.Size(537, 291)
        Me.Controls.Add(Me.BTendenciaMes)
        Me.Controls.Add(Me.BTendenciaSemana)
        Me.Controls.Add(Me.LTendenciaMes)
        Me.Controls.Add(Me.LTendenciaSemana)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(600, 250)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTendencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Formulario de Tendencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTendenciaSemana As Label
    Friend WithEvents LTendenciaMes As Label
    Friend WithEvents BTendenciaSemana As Button
    Friend WithEvents BTendenciaMes As Button
End Class
