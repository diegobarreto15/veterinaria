<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Me.btnCancelarPersona = New System.Windows.Forms.Button()
        Me.btnAddTel = New System.Windows.Forms.Button()
        Me.lstvPersonas = New System.Windows.Forms.ListView()
        Me.lblListPersonas = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxTel = New System.Windows.Forms.TextBox()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.tbxCedula = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelarPersona
        '
        Me.btnCancelarPersona.Location = New System.Drawing.Point(213, 323)
        Me.btnCancelarPersona.Name = "btnCancelarPersona"
        Me.btnCancelarPersona.Size = New System.Drawing.Size(105, 23)
        Me.btnCancelarPersona.TabIndex = 27
        Me.btnCancelarPersona.Text = "CANCELAR"
        Me.btnCancelarPersona.UseVisualStyleBackColor = True
        '
        'btnAddTel
        '
        Me.btnAddTel.Location = New System.Drawing.Point(458, 188)
        Me.btnAddTel.Name = "btnAddTel"
        Me.btnAddTel.Size = New System.Drawing.Size(49, 40)
        Me.btnAddTel.TabIndex = 26
        Me.btnAddTel.Text = "+"
        Me.btnAddTel.UseVisualStyleBackColor = True
        '
        'lstvPersonas
        '
        Me.lstvPersonas.HideSelection = False
        Me.lstvPersonas.Location = New System.Drawing.Point(523, 139)
        Me.lstvPersonas.Name = "lstvPersonas"
        Me.lstvPersonas.Size = New System.Drawing.Size(194, 183)
        Me.lstvPersonas.TabIndex = 25
        Me.lstvPersonas.UseCompatibleStateImageBehavior = False
        '
        'lblListPersonas
        '
        Me.lblListPersonas.AutoSize = True
        Me.lblListPersonas.Location = New System.Drawing.Point(520, 103)
        Me.lblListPersonas.Name = "lblListPersonas"
        Me.lblListPersonas.Size = New System.Drawing.Size(102, 13)
        Me.lblListPersonas.TabIndex = 24
        Me.lblListPersonas.Text = "Listado de personas"
        Me.lblListPersonas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(390, 323)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(105, 23)
        Me.btnCrear.TabIndex = 23
        Me.btnCrear.Text = "Crear persona"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(324, 139)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(114, 20)
        Me.tbxName.TabIndex = 22
        '
        'tbxTel
        '
        Me.tbxTel.Location = New System.Drawing.Point(324, 201)
        Me.tbxTel.Name = "tbxTel"
        Me.tbxTel.Size = New System.Drawing.Size(114, 20)
        Me.tbxTel.TabIndex = 21
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Location = New System.Drawing.Point(324, 252)
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(114, 20)
        Me.tbxDireccion.TabIndex = 20
        '
        'tbxCedula
        '
        Me.tbxCedula.Location = New System.Drawing.Point(324, 87)
        Me.tbxCedula.Name = "tbxCedula"
        Me.tbxCedula.Size = New System.Drawing.Size(114, 20)
        Me.tbxCedula.TabIndex = 19
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblDireccion.Location = New System.Drawing.Point(239, 255)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(58, 15)
        Me.lblDireccion.TabIndex = 18
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(239, 201)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefono.TabIndex = 17
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblName.Location = New System.Drawing.Point(239, 146)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 15)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(239, 90)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(46, 15)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cedula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "MODIFICAR PERSONAS"
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarPersona)
        Me.Controls.Add(Me.btnAddTel)
        Me.Controls.Add(Me.lstvPersonas)
        Me.Controls.Add(Me.lblListPersonas)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.tbxTel)
        Me.Controls.Add(Me.tbxDireccion)
        Me.Controls.Add(Me.tbxCedula)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarPersona"
        Me.Text = "Modificar personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarPersona As Button
    Friend WithEvents btnAddTel As Button
    Friend WithEvents lstvPersonas As ListView
    Friend WithEvents lblListPersonas As Label
    Friend WithEvents btnCrear As Button
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxTel As TextBox
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents tbxCedula As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
End Class
