<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(197, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPersonasToolStripMenuItem, Me.MascotasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearPersonasToolStripMenuItem
        '
        Me.CrearPersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPersonaToolStripMenuItem})
        Me.CrearPersonasToolStripMenuItem.Name = "CrearPersonasToolStripMenuItem"
        Me.CrearPersonasToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CrearPersonasToolStripMenuItem.Text = "Crear personas"
        '
        'AltaPersonaToolStripMenuItem
        '
        Me.AltaPersonaToolStripMenuItem.Name = "AltaPersonaToolStripMenuItem"
        Me.AltaPersonaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AltaPersonaToolStripMenuItem.Text = "Alta persona"
        '
        'MascotasToolStripMenuItem
        '
        Me.MascotasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaMascotasToolStripMenuItem})
        Me.MascotasToolStripMenuItem.Name = "MascotasToolStripMenuItem"
        Me.MascotasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MascotasToolStripMenuItem.Text = "Mascotas"
        '
        'AltaMascotasToolStripMenuItem
        '
        Me.AltaMascotasToolStripMenuItem.Name = "AltaMascotasToolStripMenuItem"
        Me.AltaMascotasToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AltaMascotasToolStripMenuItem.Text = "Alta mascotas"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "                                                                                 " &
    "                                                            "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CrearPersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaMascotasToolStripMenuItem As ToolStripMenuItem
End Class
