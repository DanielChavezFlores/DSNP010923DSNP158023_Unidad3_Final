<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impuesto
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
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Entrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.InicioI = New System.Windows.Forms.Button()
        Me.erpEntrada = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.erpEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Navy
        Me.Calcular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Calcular.Location = New System.Drawing.Point(21, 266)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(126, 72)
        Me.Calcular.TabIndex = 0
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Entrada
        '
        Me.Entrada.Location = New System.Drawing.Point(121, 93)
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Size = New System.Drawing.Size(193, 20)
        Me.Entrada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Calculo de impuesto de una actividad economica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "El impuesto a pagar es:"
        '
        'Resultado
        '
        Me.Resultado.Enabled = False
        Me.Resultado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(214, 165)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 26)
        Me.Resultado.TabIndex = 5
        '
        'InicioI
        '
        Me.InicioI.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InicioI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioI.ForeColor = System.Drawing.Color.White
        Me.InicioI.Location = New System.Drawing.Point(188, 266)
        Me.InicioI.Name = "InicioI"
        Me.InicioI.Size = New System.Drawing.Size(126, 72)
        Me.InicioI.TabIndex = 6
        Me.InicioI.Text = "Volver al inicio"
        Me.InicioI.UseVisualStyleBackColor = False
        '
        'erpEntrada
        '
        Me.erpEntrada.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(121, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Impuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(392, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InicioI)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Entrada)
        Me.Controls.Add(Me.Calcular)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Impuesto"
        Me.Text = "Impuesto"
        CType(Me.erpEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calcular As Button
    Friend WithEvents Entrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Resultado As TextBox
    Friend WithEvents InicioI As Button
    Friend WithEvents erpEntrada As ErrorProvider
    Friend WithEvents Button1 As Button
End Class
