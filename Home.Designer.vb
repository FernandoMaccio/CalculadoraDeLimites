<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.btnTipo1 = New System.Windows.Forms.Button()
        Me.btnTipo3 = New System.Windows.Forms.Button()
        Me.btnTipo2 = New System.Windows.Forms.Button()
        Me.btnTipo4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTipo1
        '
        Me.btnTipo1.Location = New System.Drawing.Point(12, 12)
        Me.btnTipo1.Name = "btnTipo1"
        Me.btnTipo1.Size = New System.Drawing.Size(96, 23)
        Me.btnTipo1.TabIndex = 0
        Me.btnTipo1.Text = "Tipo 1"
        Me.btnTipo1.UseVisualStyleBackColor = True
        '
        'btnTipo3
        '
        Me.btnTipo3.Location = New System.Drawing.Point(12, 70)
        Me.btnTipo3.Name = "btnTipo3"
        Me.btnTipo3.Size = New System.Drawing.Size(96, 23)
        Me.btnTipo3.TabIndex = 1
        Me.btnTipo3.Text = "Tipo 3"
        Me.btnTipo3.UseVisualStyleBackColor = True
        '
        'btnTipo2
        '
        Me.btnTipo2.Location = New System.Drawing.Point(12, 41)
        Me.btnTipo2.Name = "btnTipo2"
        Me.btnTipo2.Size = New System.Drawing.Size(96, 23)
        Me.btnTipo2.TabIndex = 2
        Me.btnTipo2.Text = "Tipo 2"
        Me.btnTipo2.UseVisualStyleBackColor = True
        '
        'btnTipo4
        '
        Me.btnTipo4.Location = New System.Drawing.Point(12, 99)
        Me.btnTipo4.Name = "btnTipo4"
        Me.btnTipo4.Size = New System.Drawing.Size(96, 23)
        Me.btnTipo4.TabIndex = 3
        Me.btnTipo4.Text = "Tipo 4 / Yapa"
        Me.btnTipo4.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 132)
        Me.Controls.Add(Me.btnTipo4)
        Me.Controls.Add(Me.btnTipo2)
        Me.Controls.Add(Me.btnTipo3)
        Me.Controls.Add(Me.btnTipo1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTipo1 As Button
    Friend WithEvents btnTipo3 As Button
    Friend WithEvents btnTipo2 As Button
    Friend WithEvents btnTipo4 As Button
End Class
