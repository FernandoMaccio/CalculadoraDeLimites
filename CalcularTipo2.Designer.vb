<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularTipo2
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
        Me.txt2X = New System.Windows.Forms.TextBox()
        Me.txt2B = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt2A = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt2C = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt2X
        '
        Me.txt2X.Location = New System.Drawing.Point(43, 38)
        Me.txt2X.Name = "txt2X"
        Me.txt2X.Size = New System.Drawing.Size(20, 20)
        Me.txt2X.TabIndex = 11
        '
        'txt2B
        '
        Me.txt2B.Location = New System.Drawing.Point(135, 9)
        Me.txt2B.Name = "txt2B"
        Me.txt2B.Size = New System.Drawing.Size(20, 20)
        Me.txt2B.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(104, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "x +"
        '
        'txt2A
        '
        Me.txt2A.Location = New System.Drawing.Point(78, 9)
        Me.txt2A.Name = "txt2A"
        Me.txt2A.Size = New System.Drawing.Size(20, 20)
        Me.txt2A.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x ->"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lim f(x)="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "_____________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(86, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "x² -"
        '
        'txt2C
        '
        Me.txt2C.Location = New System.Drawing.Point(126, 56)
        Me.txt2C.Name = "txt2C"
        Me.txt2C.Size = New System.Drawing.Size(20, 20)
        Me.txt2C.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(80, 92)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'CalcularTipo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(166, 124)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txt2C)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt2X)
        Me.Controls.Add(Me.txt2B)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt2A)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Name = "CalcularTipo2"
        Me.Text = "CalcularTipo2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt2X As TextBox
    Friend WithEvents txt2B As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt2A As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt2C As TextBox
    Friend WithEvents btnCalcular As Button
End Class
