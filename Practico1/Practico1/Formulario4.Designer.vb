<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario4
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
        Me.TDesde = New System.Windows.Forms.TextBox()
        Me.THasta = New System.Windows.Forms.TextBox()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.BGenerar = New System.Windows.Forms.Button()
        Me.LLista = New System.Windows.Forms.Label()
        Me.LBFuncion = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TDesde
        '
        Me.TDesde.Location = New System.Drawing.Point(129, 90)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(100, 22)
        Me.TDesde.TabIndex = 0
        '
        'THasta
        '
        Me.THasta.Location = New System.Drawing.Point(129, 161)
        Me.THasta.Name = "THasta"
        Me.THasta.Size = New System.Drawing.Size(100, 22)
        Me.THasta.TabIndex = 0
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(26, 94)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(49, 17)
        Me.LDesde.TabIndex = 1
        Me.LDesde.Text = "Desde"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(26, 166)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(45, 17)
        Me.LHasta.TabIndex = 1
        Me.LHasta.Text = "Hasta"
        '
        'BGenerar
        '
        Me.BGenerar.Location = New System.Drawing.Point(286, 90)
        Me.BGenerar.Name = "BGenerar"
        Me.BGenerar.Size = New System.Drawing.Size(128, 22)
        Me.BGenerar.TabIndex = 2
        Me.BGenerar.Text = "Generar Funcion"
        Me.BGenerar.UseVisualStyleBackColor = True
        '
        'LLista
        '
        Me.LLista.AutoSize = True
        Me.LLista.Location = New System.Drawing.Point(561, 56)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(119, 17)
        Me.LLista.TabIndex = 4
        Me.LLista.Text = "Lista de Numeros"
        '
        'LBFuncion
        '
        Me.LBFuncion.FormattingEnabled = True
        Me.LBFuncion.ItemHeight = 16
        Me.LBFuncion.Location = New System.Drawing.Point(471, 94)
        Me.LBFuncion.Name = "LBFuncion"
        Me.LBFuncion.Size = New System.Drawing.Size(295, 228)
        Me.LBFuncion.TabIndex = 5
        '
        'Formulario4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 355)
        Me.Controls.Add(Me.LBFuncion)
        Me.Controls.Add(Me.LLista)
        Me.Controls.Add(Me.BGenerar)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.THasta)
        Me.Controls.Add(Me.TDesde)
        Me.Name = "Formulario4"
        Me.Text = "Formulario4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TDesde As TextBox
    Friend WithEvents THasta As TextBox
    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents BGenerar As Button
    Friend WithEvents LLista As Label
    Friend WithEvents LBFuncion As ListBox
End Class
