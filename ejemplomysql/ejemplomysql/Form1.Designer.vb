<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MostrarDatos = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MostrarDatos
        '
        Me.MostrarDatos.Location = New System.Drawing.Point(126, 43)
        Me.MostrarDatos.Name = "MostrarDatos"
        Me.MostrarDatos.Size = New System.Drawing.Size(324, 61)
        Me.MostrarDatos.TabIndex = 0
        Me.MostrarDatos.Text = "Mostrar Datos"
        Me.MostrarDatos.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Location = New System.Drawing.Point(34, 142)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(502, 163)
        Me.Datos.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 342)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.MostrarDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MostrarDatos As System.Windows.Forms.Button
    Friend WithEvents Datos As System.Windows.Forms.DataGridView

End Class
