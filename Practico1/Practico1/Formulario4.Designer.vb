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
        Me.components = New System.ComponentModel.Container()
        Me.TDesde = New System.Windows.Forms.TextBox()
        Me.THasta = New System.Windows.Forms.TextBox()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.BGenerar = New System.Windows.Forms.Button()
        Me.LLista = New System.Windows.Forms.Label()
        Me.LBFuncion = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BPares = New System.Windows.Forms.Button()
        Me.BImpares = New System.Windows.Forms.Button()
        Me.BPrimos = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TDesde
        '
        Me.TDesde.Location = New System.Drawing.Point(129, 90)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(156, 22)
        Me.TDesde.TabIndex = 0
        '
        'THasta
        '
        Me.THasta.Location = New System.Drawing.Point(129, 161)
        Me.THasta.Name = "THasta"
        Me.THasta.Size = New System.Drawing.Size(156, 22)
        Me.THasta.TabIndex = 1
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
        Me.BGenerar.Location = New System.Drawing.Point(129, 205)
        Me.BGenerar.Name = "BGenerar"
        Me.BGenerar.Size = New System.Drawing.Size(133, 23)
        Me.BGenerar.TabIndex = 2
        Me.BGenerar.Text = "Generar Funcion"
        Me.BGenerar.UseVisualStyleBackColor = True
        '
        'LLista
        '
        Me.LLista.AutoSize = True
        Me.LLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.Location = New System.Drawing.Point(241, 26)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(202, 29)
        Me.LLista.TabIndex = 4
        Me.LLista.Text = "Lista de Numeros"
        '
        'LBFuncion
        '
        Me.LBFuncion.FormattingEnabled = True
        Me.LBFuncion.ItemHeight = 16
        Me.LBFuncion.Location = New System.Drawing.Point(342, 90)
        Me.LBFuncion.Name = "LBFuncion"
        Me.LBFuncion.Size = New System.Drawing.Size(423, 228)
        Me.LBFuncion.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BPares
        '
        Me.BPares.Location = New System.Drawing.Point(129, 256)
        Me.BPares.Name = "BPares"
        Me.BPares.Size = New System.Drawing.Size(133, 23)
        Me.BPares.TabIndex = 6
        Me.BPares.Text = "Numeros Pares"
        Me.BPares.UseVisualStyleBackColor = True
        '
        'BImpares
        '
        Me.BImpares.Location = New System.Drawing.Point(129, 285)
        Me.BImpares.Name = "BImpares"
        Me.BImpares.Size = New System.Drawing.Size(133, 23)
        Me.BImpares.TabIndex = 7
        Me.BImpares.Text = "Numeros Impares"
        Me.BImpares.UseVisualStyleBackColor = True
        '
        'BPrimos
        '
        Me.BPrimos.Location = New System.Drawing.Point(129, 314)
        Me.BPrimos.Name = "BPrimos"
        Me.BPrimos.Size = New System.Drawing.Size(133, 23)
        Me.BPrimos.TabIndex = 8
        Me.BPrimos.Text = "Numeros Primos"
        Me.BPrimos.UseVisualStyleBackColor = True
        '
        'Formulario4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 374)
        Me.Controls.Add(Me.BPrimos)
        Me.Controls.Add(Me.BImpares)
        Me.Controls.Add(Me.BPares)
        Me.Controls.Add(Me.LBFuncion)
        Me.Controls.Add(Me.LLista)
        Me.Controls.Add(Me.BGenerar)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.THasta)
        Me.Controls.Add(Me.TDesde)
        Me.Name = "Formulario4"
        Me.Text = "Formulario4"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BPrimos As Button
    Friend WithEvents BImpares As Button
    Friend WithEvents BPares As Button
End Class
