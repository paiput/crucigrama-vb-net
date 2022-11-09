<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crucigrama
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
        Me.ButtonValidar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonValidar
        '
        Me.ButtonValidar.Location = New System.Drawing.Point(372, 12)
        Me.ButtonValidar.Name = "ButtonValidar"
        Me.ButtonValidar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonValidar.TabIndex = 0
        Me.ButtonValidar.Text = "VALIDAR"
        Me.ButtonValidar.UseVisualStyleBackColor = True
        '
        'Crucigrama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 317)
        Me.Controls.Add(Me.ButtonValidar)
        Me.Name = "Crucigrama"
        Me.Text = "CRUCIGRAMA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonValidar As System.Windows.Forms.Button

End Class
