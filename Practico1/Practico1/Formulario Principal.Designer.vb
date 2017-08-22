<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Principal
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
        Me.BPractico1 = New System.Windows.Forms.Button()
        Me.BPractico2 = New System.Windows.Forms.Button()
        Me.BPractico4 = New System.Windows.Forms.Button()
        Me.BPractico3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BPractico1
        '
        Me.BPractico1.Location = New System.Drawing.Point(108, 207)
        Me.BPractico1.Name = "BPractico1"
        Me.BPractico1.Size = New System.Drawing.Size(92, 32)
        Me.BPractico1.TabIndex = 0
        Me.BPractico1.Text = "Practico 1"
        Me.BPractico1.UseVisualStyleBackColor = True
        '
        'BPractico2
        '
        Me.BPractico2.Location = New System.Drawing.Point(222, 207)
        Me.BPractico2.Name = "BPractico2"
        Me.BPractico2.Size = New System.Drawing.Size(92, 32)
        Me.BPractico2.TabIndex = 0
        Me.BPractico2.Text = "Practico 2"
        Me.BPractico2.UseVisualStyleBackColor = True
        '
        'BPractico4
        '
        Me.BPractico4.Location = New System.Drawing.Point(453, 207)
        Me.BPractico4.Name = "BPractico4"
        Me.BPractico4.Size = New System.Drawing.Size(92, 32)
        Me.BPractico4.TabIndex = 0
        Me.BPractico4.Text = "Practico 4"
        Me.BPractico4.UseVisualStyleBackColor = True
        '
        'BPractico3
        '
        Me.BPractico3.Location = New System.Drawing.Point(338, 207)
        Me.BPractico3.Name = "BPractico3"
        Me.BPractico3.Size = New System.Drawing.Size(92, 32)
        Me.BPractico3.TabIndex = 0
        Me.BPractico3.Text = "Practico 3"
        Me.BPractico3.UseVisualStyleBackColor = True
        '
        'Formulario_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 281)
        Me.Controls.Add(Me.BPractico3)
        Me.Controls.Add(Me.BPractico4)
        Me.Controls.Add(Me.BPractico2)
        Me.Controls.Add(Me.BPractico1)
        Me.Name = "Formulario_Principal"
        Me.Text = "Formulario_Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BPractico1 As Button
    Friend WithEvents BPractico2 As Button
    Friend WithEvents BPractico4 As Button
    Friend WithEvents BPractico3 As Button
End Class
