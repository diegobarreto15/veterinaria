<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mascotas
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
        Me.btnCrearMasc = New System.Windows.Forms.Button()
        Me.tbxAñoNac = New System.Windows.Forms.TextBox()
        Me.tbxNombreMasc = New System.Windows.Forms.TextBox()
        Me.lblFechaNacMasc = New System.Windows.Forms.Label()
        Me.lblNombreMasc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxCIDueño = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCrearMasc
        '
        Me.btnCrearMasc.Location = New System.Drawing.Point(381, 168)
        Me.btnCrearMasc.Name = "btnCrearMasc"
        Me.btnCrearMasc.Size = New System.Drawing.Size(105, 23)
        Me.btnCrearMasc.TabIndex = 19
        Me.btnCrearMasc.Text = "Crear mascota"
        Me.btnCrearMasc.UseVisualStyleBackColor = True
        '
        'tbxAñoNac
        '
        Me.tbxAñoNac.Location = New System.Drawing.Point(381, 131)
        Me.tbxAñoNac.Name = "tbxAñoNac"
        Me.tbxAñoNac.Size = New System.Drawing.Size(114, 20)
        Me.tbxAñoNac.TabIndex = 18
        '
        'tbxNombreMasc
        '
        Me.tbxNombreMasc.Location = New System.Drawing.Point(381, 57)
        Me.tbxNombreMasc.Name = "tbxNombreMasc"
        Me.tbxNombreMasc.Size = New System.Drawing.Size(114, 20)
        Me.tbxNombreMasc.TabIndex = 15
        '
        'lblFechaNacMasc
        '
        Me.lblFechaNacMasc.AutoSize = True
        Me.lblFechaNacMasc.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblFechaNacMasc.Location = New System.Drawing.Point(271, 131)
        Me.lblFechaNacMasc.Name = "lblFechaNacMasc"
        Me.lblFechaNacMasc.Size = New System.Drawing.Size(104, 15)
        Me.lblFechaNacMasc.TabIndex = 12
        Me.lblFechaNacMasc.Text = "Año de nacimiento"
        '
        'lblNombreMasc
        '
        Me.lblNombreMasc.AutoSize = True
        Me.lblNombreMasc.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMasc.Location = New System.Drawing.Point(296, 60)
        Me.lblNombreMasc.Name = "lblNombreMasc"
        Me.lblNombreMasc.Size = New System.Drawing.Size(51, 15)
        Me.lblNombreMasc.TabIndex = 11
        Me.lblNombreMasc.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MASCOTAS"
        '
        'tbxCIDueño
        '
        Me.tbxCIDueño.Location = New System.Drawing.Point(381, 93)
        Me.tbxCIDueño.Name = "tbxCIDueño"
        Me.tbxCIDueño.Size = New System.Drawing.Size(114, 20)
        Me.tbxCIDueño.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(271, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cedula del dueño"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Datos mascotas"
        '
        'Mascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxCIDueño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCrearMasc)
        Me.Controls.Add(Me.tbxAñoNac)
        Me.Controls.Add(Me.tbxNombreMasc)
        Me.Controls.Add(Me.lblFechaNacMasc)
        Me.Controls.Add(Me.lblNombreMasc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mascotas"
        Me.Text = "Mascotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrearMasc As Button
    Friend WithEvents tbxAñoNac As TextBox
    Friend WithEvents tbxNombreMasc As TextBox
    Friend WithEvents lblFechaNacMasc As Label
    Friend WithEvents lblNombreMasc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxCIDueño As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
