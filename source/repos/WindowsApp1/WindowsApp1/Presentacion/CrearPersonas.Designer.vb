<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearPersonas
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
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.tbxCedula = New System.Windows.Forms.TextBox()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.tbxTel = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.lblListPersonas = New System.Windows.Forms.Label()
        Me.lstvPersonas = New System.Windows.Forms.ListView()
        Me.btnAddTel = New System.Windows.Forms.Button()
        Me.btnCancelarPersona = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREAR PERSONAS"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(279, 60)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(46, 15)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Cedula:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblName.Location = New System.Drawing.Point(279, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblTelefono.Location = New System.Drawing.Point(279, 171)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!)
        Me.lblDireccion.Location = New System.Drawing.Point(279, 225)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(58, 15)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección:"
        '
        'tbxCedula
        '
        Me.tbxCedula.Location = New System.Drawing.Point(364, 57)
        Me.tbxCedula.Name = "tbxCedula"
        Me.tbxCedula.Size = New System.Drawing.Size(114, 20)
        Me.tbxCedula.TabIndex = 5
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Location = New System.Drawing.Point(364, 222)
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(114, 20)
        Me.tbxDireccion.TabIndex = 6
        '
        'tbxTel
        '
        Me.tbxTel.Location = New System.Drawing.Point(364, 171)
        Me.tbxTel.Name = "tbxTel"
        Me.tbxTel.Size = New System.Drawing.Size(114, 20)
        Me.tbxTel.TabIndex = 7
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(364, 109)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(114, 20)
        Me.tbxName.TabIndex = 8
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(430, 293)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(105, 23)
        Me.btnCrear.TabIndex = 9
        Me.btnCrear.Text = "Crear persona"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'lblListPersonas
        '
        Me.lblListPersonas.AutoSize = True
        Me.lblListPersonas.Location = New System.Drawing.Point(560, 93)
        Me.lblListPersonas.Name = "lblListPersonas"
        Me.lblListPersonas.Size = New System.Drawing.Size(102, 13)
        Me.lblListPersonas.TabIndex = 10
        Me.lblListPersonas.Text = "Listado de telefonos"
        Me.lblListPersonas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstvPersonas
        '
        Me.lstvPersonas.HideSelection = False
        Me.lstvPersonas.Location = New System.Drawing.Point(563, 109)
        Me.lstvPersonas.Name = "lstvPersonas"
        Me.lstvPersonas.Size = New System.Drawing.Size(99, 133)
        Me.lstvPersonas.TabIndex = 11
        Me.lstvPersonas.UseCompatibleStateImageBehavior = False
        Me.lstvPersonas.View = System.Windows.Forms.View.List
        '
        'btnAddTel
        '
        Me.btnAddTel.Location = New System.Drawing.Point(498, 158)
        Me.btnAddTel.Name = "btnAddTel"
        Me.btnAddTel.Size = New System.Drawing.Size(49, 40)
        Me.btnAddTel.TabIndex = 12
        Me.btnAddTel.Text = "+"
        Me.btnAddTel.UseVisualStyleBackColor = True
        '
        'btnCancelarPersona
        '
        Me.btnCancelarPersona.Location = New System.Drawing.Point(253, 293)
        Me.btnCancelarPersona.Name = "btnCancelarPersona"
        Me.btnCancelarPersona.Size = New System.Drawing.Size(105, 23)
        Me.btnCancelarPersona.TabIndex = 13
        Me.btnCancelarPersona.Text = "CANCELAR"
        Me.btnCancelarPersona.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(563, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(65, 26)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CrearPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "CrearPersonas"
        Me.Text = "Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents tbxCedula As TextBox
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents tbxTel As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents lblListPersonas As Label
    Friend WithEvents lstvPersonas As ListView
    Friend WithEvents btnAddTel As Button
    Friend WithEvents btnCancelarPersona As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBuscar As Button
End Class
