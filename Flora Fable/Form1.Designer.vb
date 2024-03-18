<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctPacchettoComune = New System.Windows.Forms.PictureBox()
        Me.pctPacchettoRaro = New System.Windows.Forms.PictureBox()
        Me.pctPacchettoSuperRaro = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPesca = New System.Windows.Forms.Button()
        Me.prova = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pctPacchettoComune, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPacchettoRaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPacchettoSuperRaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PACCHETTI DEL GIORNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(798, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GUARDA CHE FORTUNA, QUESTI SONO I POSSIBILI PREMI DEL GIORNO"
        '
        'pctPacchettoComune
        '
        Me.pctPacchettoComune.Image = CType(resources.GetObject("pctPacchettoComune.Image"), System.Drawing.Image)
        Me.pctPacchettoComune.Location = New System.Drawing.Point(73, 114)
        Me.pctPacchettoComune.Name = "pctPacchettoComune"
        Me.pctPacchettoComune.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoComune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoComune.TabIndex = 2
        Me.pctPacchettoComune.TabStop = False
        '
        'pctPacchettoRaro
        '
        Me.pctPacchettoRaro.Image = CType(resources.GetObject("pctPacchettoRaro.Image"), System.Drawing.Image)
        Me.pctPacchettoRaro.Location = New System.Drawing.Point(360, 114)
        Me.pctPacchettoRaro.Name = "pctPacchettoRaro"
        Me.pctPacchettoRaro.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoRaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoRaro.TabIndex = 3
        Me.pctPacchettoRaro.TabStop = False
        '
        'pctPacchettoSuperRaro
        '
        Me.pctPacchettoSuperRaro.Image = CType(resources.GetObject("pctPacchettoSuperRaro.Image"), System.Drawing.Image)
        Me.pctPacchettoSuperRaro.Location = New System.Drawing.Point(648, 114)
        Me.pctPacchettoSuperRaro.Name = "pctPacchettoSuperRaro"
        Me.pctPacchettoSuperRaro.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoSuperRaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoSuperRaro.TabIndex = 4
        Me.pctPacchettoSuperRaro.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PACCHETTO COMUNE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PACCHETTO RARO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(647, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PACCHETTO SUPER RARO"
        '
        'btnPesca
        '
        Me.btnPesca.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesca.Location = New System.Drawing.Point(313, 421)
        Me.btnPesca.Name = "btnPesca"
        Me.btnPesca.Size = New System.Drawing.Size(262, 61)
        Me.btnPesca.TabIndex = 8
        Me.btnPesca.Text = "PESCA"
        Me.btnPesca.UseVisualStyleBackColor = True
        '
        'prova
        '
        Me.prova.AutoSize = True
        Me.prova.Location = New System.Drawing.Point(698, 451)
        Me.prova.Name = "prova"
        Me.prova.Size = New System.Drawing.Size(0, 13)
        Me.prova.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 506)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.prova)
        Me.Controls.Add(Me.btnPesca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pctPacchettoSuperRaro)
        Me.Controls.Add(Me.pctPacchettoRaro)
        Me.Controls.Add(Me.pctPacchettoComune)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctPacchettoComune, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPacchettoRaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPacchettoSuperRaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pctPacchettoComune As PictureBox
    Friend WithEvents pctPacchettoRaro As PictureBox
    Friend WithEvents pctPacchettoSuperRaro As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPesca As Button
    Friend WithEvents prova As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
