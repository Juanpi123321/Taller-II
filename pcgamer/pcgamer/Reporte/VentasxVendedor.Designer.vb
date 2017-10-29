<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasxVendedor
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
        Me.VentasxVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New pcgamer.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VentasxVendedorTableAdapter = New pcgamer.DataSet1TableAdapters.VentasxVendedorTableAdapter()
        Me.VentasFormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasFormaPagoTableAdapter = New pcgamer.DataSet1TableAdapters.VentasFormaPagoTableAdapter()
        CType(Me.VentasxVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasxVendedorBindingSource
        '
        Me.VentasxVendedorBindingSource.DataMember = "VentasxVendedor"
        Me.VentasxVendedorBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pcgamer.VentasxVendedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(731, 673)
        Me.ReportViewer1.TabIndex = 0
        '
        'VentasxVendedorTableAdapter
        '
        Me.VentasxVendedorTableAdapter.ClearBeforeFill = True
        '
        'VentasFormaPagoBindingSource
        '
        Me.VentasFormaPagoBindingSource.DataMember = "VentasFormaPago"
        Me.VentasFormaPagoBindingSource.DataSource = Me.DataSet1
        '
        'VentasFormaPagoTableAdapter
        '
        Me.VentasFormaPagoTableAdapter.ClearBeforeFill = True
        '
        'VentasxVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 673)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VentasxVendedor"
        Me.Text = "VentasxVendedor"
        CType(Me.VentasxVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VentasxVendedorBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents VentasxVendedorTableAdapter As DataSet1TableAdapters.VentasxVendedorTableAdapter
    Friend WithEvents VentasFormaPagoBindingSource As BindingSource
    Friend WithEvents VentasFormaPagoTableAdapter As DataSet1TableAdapters.VentasFormaPagoTableAdapter
End Class
