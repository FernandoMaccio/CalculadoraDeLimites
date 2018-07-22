<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularTipo1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1A = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt1B = New System.Windows.Forms.TextBox()
        Me.txt1X = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lim f(x)="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x ->"
        '
        'txt1A
        '
        Me.txt1A.Location = New System.Drawing.Point(78, 38)
        Me.txt1A.Name = "txt1A"
        Me.txt1A.Size = New System.Drawing.Size(20, 20)
        Me.txt1A.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(104, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "x +"
        '
        'txt1B
        '
        Me.txt1B.Location = New System.Drawing.Point(135, 38)
        Me.txt1B.Name = "txt1B"
        Me.txt1B.Size = New System.Drawing.Size(20, 20)
        Me.txt1B.TabIndex = 4
        '
        'txt1X
        '
        Me.txt1X.Location = New System.Drawing.Point(43, 67)
        Me.txt1X.Name = "txt1X"
        Me.txt1X.Size = New System.Drawing.Size(20, 20)
        Me.txt1X.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(12, 93)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "<---"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'CalcularTipo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 123)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txt1X)
        Me.Controls.Add(Me.txt1B)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt1A)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CalcularTipo1"
        Me.Text = "CalcularTipo1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1A As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt1B As TextBox
    Friend WithEvents txt1X As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnBack As Button
End Class
