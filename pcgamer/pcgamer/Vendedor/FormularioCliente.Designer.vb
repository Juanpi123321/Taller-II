﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioCliente))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDomicilio = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LObligatorio = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDomicilio = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabCliente = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridCliente = New System.Windows.Forms.DataGridView()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.Id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCliente.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PBLogo.TabIndex = 1
        Me.PBLogo.TabStop = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(22, 23)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(96, 20)
        Me.LNombre.TabIndex = 7
        Me.LNombre.Text = "*Nombre:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(23, 91)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(62, 20)
        Me.LDni.TabIndex = 9
        Me.LDni.Text = "*DNI:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(22, 57)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(97, 20)
        Me.LApellido.TabIndex = 8
        Me.LApellido.Text = "*Apellido:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(23, 159)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(87, 20)
        Me.LTelefono.TabIndex = 11
        Me.LTelefono.Text = "Telefono:"
        '
        'LDomicilio
        '
        Me.LDomicilio.AutoSize = True
        Me.LDomicilio.Location = New System.Drawing.Point(23, 125)
        Me.LDomicilio.Name = "LDomicilio"
        Me.LDomicilio.Size = New System.Drawing.Size(107, 20)
        Me.LDomicilio.TabIndex = 10
        Me.LDomicilio.Text = "*Domicilio:"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Black
        Me.LTitulo.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(327, 39)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(293, 40)
        Me.LTitulo.TabIndex = 12
        Me.LTitulo.Text = "Registrar Cliente"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(139, 20)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(193, 28)
        Me.TNombre.TabIndex = 0
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(139, 54)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(193, 28)
        Me.TApellido.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TEmail)
        Me.Panel1.Controls.Add(Me.LEmail)
        Me.Panel1.Controls.Add(Me.LObligatorio)
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.TDomicilio)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LDomicilio)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(125, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 249)
        Me.Panel1.TabIndex = 8
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(138, 190)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(193, 28)
        Me.TEmail.TabIndex = 13
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(23, 193)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(76, 20)
        Me.LEmail.TabIndex = 14
        Me.LEmail.Text = "*Email:"
        '
        'LObligatorio
        '
        Me.LObligatorio.AutoSize = True
        Me.LObligatorio.Font = New System.Drawing.Font("Verdana", 4.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LObligatorio.Location = New System.Drawing.Point(304, 232)
        Me.LObligatorio.Name = "LObligatorio"
        Me.LObligatorio.Size = New System.Drawing.Size(47, 8)
        Me.LObligatorio.TabIndex = 12
        Me.LObligatorio.Text = "*Obligatorio"
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(138, 156)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(193, 28)
        Me.TTelefono.TabIndex = 4
        '
        'TDomicilio
        '
        Me.TDomicilio.Location = New System.Drawing.Point(138, 122)
        Me.TDomicilio.Name = "TDomicilio"
        Me.TDomicilio.Size = New System.Drawing.Size(193, 28)
        Me.TDomicilio.TabIndex = 3
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(139, 88)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(193, 28)
        Me.TDni.TabIndex = 2
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.BLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLimpiar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiar.ForeColor = System.Drawing.Color.White
        Me.BLimpiar.Location = New System.Drawing.Point(125, 346)
        Me.BLimpiar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(166, 32)
        Me.BLimpiar.TabIndex = 5
        Me.BLimpiar.Text = "Limpiar Registro"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.White
        Me.BAgregar.Location = New System.Drawing.Point(324, 346)
        Me.BAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(166, 32)
        Me.BAgregar.TabIndex = 13
        Me.BAgregar.Text = "Agregar Cliente"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TabCliente
        '
        Me.TabCliente.Controls.Add(Me.TabPage1)
        Me.TabCliente.Controls.Add(Me.TabPage2)
        Me.TabCliente.Location = New System.Drawing.Point(106, 82)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.SelectedIndex = 0
        Me.TabCliente.Size = New System.Drawing.Size(707, 453)
        Me.TabCliente.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.BAgregar)
        Me.TabPage1.Controls.Add(Me.BLimpiar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(699, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.BBuscar)
        Me.TabPage2.Controls.Add(Me.LBuscar)
        Me.TabPage2.Controls.Add(Me.TBuscar)
        Me.TabPage2.Controls.Add(Me.DataGridCliente)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(699, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar"
        '
        'DataGridCliente
        '
        Me.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_cliente, Me.apellidos, Me.nombres, Me.dni, Me.fecha_ingreso})
        Me.DataGridCliente.Location = New System.Drawing.Point(7, 268)
        Me.DataGridCliente.Name = "DataGridCliente"
        Me.DataGridCliente.RowTemplate.Height = 24
        Me.DataGridCliente.Size = New System.Drawing.Size(686, 150)
        Me.DataGridCliente.TabIndex = 0
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.DarkRed
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBuscar.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Location = New System.Drawing.Point(382, 63)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(101, 32)
        Me.BBuscar.TabIndex = 9
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.ForeColor = System.Drawing.Color.White
        Me.LBuscar.Location = New System.Drawing.Point(49, 67)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(109, 20)
        Me.LBuscar.TabIndex = 10
        Me.LBuscar.Text = "Buscar por:"
        '
        'TBuscar
        '
        Me.TBuscar.Location = New System.Drawing.Point(166, 64)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(193, 28)
        Me.TBuscar.TabIndex = 8
        '
        'Id_cliente
        '
        Me.Id_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Id_cliente.HeaderText = "Id_cliente"
        Me.Id_cliente.Name = "Id_cliente"
        Me.Id_cliente.Width = 125
        '
        'apellidos
        '
        Me.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        '
        'nombres
        '
        Me.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        '
        'dni
        '
        Me.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fecha_ingreso.HeaderText = "Fecha Ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        '
        'FormularioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pcgamer.My.Resources.Resources.hyperx_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 593)
        Me.Controls.Add(Me.TabCliente)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PBLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormularioCliente"
        Me.Text = "Formulario Cliente"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCliente.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDomicilio As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDomicilio As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents BLimpiar As Button
    Friend WithEvents LObligatorio As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TEmail As TextBox
    Friend WithEvents LEmail As Label
    Friend WithEvents TabCliente As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridCliente As DataGridView
    Friend WithEvents BBuscar As Button
    Friend WithEvents LBuscar As Label
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents Id_cliente As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DataGridViewTextBoxColumn
End Class
