<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LLista = New System.Windows.Forms.Label()
        Me.BPares = New System.Windows.Forms.Button()
        Me.BImpares = New System.Windows.Forms.Button()
        Me.BPrimos = New System.Windows.Forms.Button()
        Me.BPrueba = New System.Windows.Forms.Button()
        Me.TPrueba = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(319, 82)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(336, 200)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(71, 85)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(38, 14)
        Me.LDesde.TabIndex = 3
        Me.LDesde.Text = "Desde"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(74, 133)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(35, 14)
        Me.LHasta.TabIndex = 4
        Me.LHasta.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar Funcion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LLista
        '
        Me.LLista.AutoSize = True
        Me.LLista.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.Location = New System.Drawing.Point(221, 35)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(171, 22)
        Me.LLista.TabIndex = 6
        Me.LLista.Text = "Lista de numeros"
        '
        'BPares
        '
        Me.BPares.Location = New System.Drawing.Point(64, 216)
        Me.BPares.Name = "BPares"
        Me.BPares.Size = New System.Drawing.Size(113, 25)
        Me.BPares.TabIndex = 7
        Me.BPares.Text = "Numeros pares"
        Me.BPares.UseVisualStyleBackColor = True
        '
        'BImpares
        '
        Me.BImpares.Location = New System.Drawing.Point(64, 246)
        Me.BImpares.Name = "BImpares"
        Me.BImpares.Size = New System.Drawing.Size(113, 25)
        Me.BImpares.TabIndex = 8
        Me.BImpares.Text = "Numeros impares"
        Me.BImpares.UseVisualStyleBackColor = True
        '
        'BPrimos
        '
        Me.BPrimos.Location = New System.Drawing.Point(64, 278)
        Me.BPrimos.Name = "BPrimos"
        Me.BPrimos.Size = New System.Drawing.Size(113, 25)
        Me.BPrimos.TabIndex = 9
        Me.BPrimos.Text = "Numeros primos"
        Me.BPrimos.UseVisualStyleBackColor = True
        '
        'BPrueba
        '
        Me.BPrueba.Location = New System.Drawing.Point(319, 311)
        Me.BPrueba.Name = "BPrueba"
        Me.BPrueba.Size = New System.Drawing.Size(113, 25)
        Me.BPrueba.TabIndex = 10
        Me.BPrueba.Text = "Prueba funcion mod"
        Me.BPrueba.UseVisualStyleBackColor = True
        '
        'TPrueba
        '
        Me.TPrueba.Location = New System.Drawing.Point(199, 315)
        Me.TPrueba.Name = "TPrueba"
        Me.TPrueba.Size = New System.Drawing.Size(100, 20)
        Me.TPrueba.TabIndex = 11
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 384)
        Me.Controls.Add(Me.TPrueba)
        Me.Controls.Add(Me.BPrueba)
        Me.Controls.Add(Me.BPrimos)
        Me.Controls.Add(Me.BImpares)
        Me.Controls.Add(Me.BPares)
        Me.Controls.Add(Me.LLista)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LDesde As System.Windows.Forms.Label
    Friend WithEvents LHasta As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LLista As System.Windows.Forms.Label
    Friend WithEvents BPares As System.Windows.Forms.Button
    Friend WithEvents BImpares As System.Windows.Forms.Button
    Friend WithEvents BPrimos As System.Windows.Forms.Button
    Friend WithEvents BPrueba As System.Windows.Forms.Button
    Friend WithEvents TPrueba As System.Windows.Forms.TextBox
End Class
