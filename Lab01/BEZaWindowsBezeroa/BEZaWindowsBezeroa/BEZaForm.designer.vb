<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEZaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BEZaForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBEZ = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSinBEZ = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConBEZ = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordaindu beharreko(totala)"
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Location = New System.Drawing.Point(296, 69)
        Me.txtPrecioProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(226, 23)
        Me.txtPrecioProd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(528, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BEZ mota:"
        '
        'cbBEZ
        '
        Me.cbBEZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBEZ.FormattingEnabled = True
        Me.cbBEZ.Items.AddRange(New Object() {"orokorra", "murriztua", "produktuena"})
        Me.cbBEZ.Location = New System.Drawing.Point(296, 127)
        Me.cbBEZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbBEZ.Name = "cbBEZ"
        Me.cbBEZ.Size = New System.Drawing.Size(226, 25)
        Me.cbBEZ.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Totala BEZik gabe:"
        '
        'txtSinBEZ
        '
        Me.txtSinBEZ.Location = New System.Drawing.Point(296, 211)
        Me.txtSinBEZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSinBEZ.Name = "txtSinBEZ"
        Me.txtSinBEZ.Size = New System.Drawing.Size(226, 23)
        Me.txtSinBEZ.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BEZ-a:"
        '
        'txtConBEZ
        '
        Me.txtConBEZ.Location = New System.Drawing.Point(296, 291)
        Me.txtConBEZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConBEZ.Name = "txtConBEZ"
        Me.txtConBEZ.Size = New System.Drawing.Size(226, 23)
        Me.txtConBEZ.TabIndex = 9
        '
        'BEZaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(645, 407)
        Me.Controls.Add(Me.txtConBEZ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSinBEZ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbBEZ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecioProd)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BEZaForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBEZ As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSinBEZ As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConBEZ As TextBox
End Class
