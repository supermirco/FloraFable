<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pacchetti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pacchetti))
        Me.btnPesca = New System.Windows.Forms.Button()
        Me.btnApri = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prova = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pctPacchettoSuperRaro = New System.Windows.Forms.PictureBox()
        Me.pctPacchettoRaro = New System.Windows.Forms.PictureBox()
        Me.pctPacchettoComune = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPacchettoSuperRaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPacchettoRaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPacchettoComune, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPesca
        '
        Me.btnPesca.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesca.Location = New System.Drawing.Point(472, 459)
        Me.btnPesca.Name = "btnPesca"
        Me.btnPesca.Size = New System.Drawing.Size(262, 61)
        Me.btnPesca.TabIndex = 42
        Me.btnPesca.Text = "PESCA"
        Me.btnPesca.UseVisualStyleBackColor = True
        '
        'btnApri
        '
        Me.btnApri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApri.Location = New System.Drawing.Point(553, 473)
        Me.btnApri.Name = "btnApri"
        Me.btnApri.Size = New System.Drawing.Size(122, 41)
        Me.btnApri.TabIndex = 45
        Me.btnApri.Text = "APRI"
        Me.btnApri.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'prova
        '
        Me.prova.AutoSize = True
        Me.prova.Location = New System.Drawing.Point(806, 452)
        Me.prova.Name = "prova"
        Me.prova.Size = New System.Drawing.Size(0, 13)
        Me.prova.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(806, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "PACCHETTO SUPER RARO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(529, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "PACCHETTO RARO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "PACCHETTO COMUNE"
        '
        'pctPacchettoSuperRaro
        '
        Me.pctPacchettoSuperRaro.Image = CType(resources.GetObject("pctPacchettoSuperRaro.Image"), System.Drawing.Image)
        Me.pctPacchettoSuperRaro.Location = New System.Drawing.Point(809, 115)
        Me.pctPacchettoSuperRaro.Name = "pctPacchettoSuperRaro"
        Me.pctPacchettoSuperRaro.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoSuperRaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoSuperRaro.TabIndex = 38
        Me.pctPacchettoSuperRaro.TabStop = False
        '
        'pctPacchettoRaro
        '
        Me.pctPacchettoRaro.Image = CType(resources.GetObject("pctPacchettoRaro.Image"), System.Drawing.Image)
        Me.pctPacchettoRaro.Location = New System.Drawing.Point(511, 115)
        Me.pctPacchettoRaro.Name = "pctPacchettoRaro"
        Me.pctPacchettoRaro.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoRaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoRaro.TabIndex = 37
        Me.pctPacchettoRaro.TabStop = False
        '
        'pctPacchettoComune
        '
        Me.pctPacchettoComune.Image = CType(resources.GetObject("pctPacchettoComune.Image"), System.Drawing.Image)
        Me.pctPacchettoComune.Location = New System.Drawing.Point(203, 115)
        Me.pctPacchettoComune.Name = "pctPacchettoComune"
        Me.pctPacchettoComune.Size = New System.Drawing.Size(182, 262)
        Me.pctPacchettoComune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPacchettoComune.TabIndex = 36
        Me.pctPacchettoComune.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(798, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "GUARDA CHE FORTUNA, QUESTI SONO I POSSIBILI PREMI DEL GIORNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 39)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "PACCHETTI DEL GIORNO"
        '
        'pacchetti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 517)
        Me.Controls.Add(Me.btnPesca)
        Me.Controls.Add(Me.btnApri)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.prova)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pctPacchettoSuperRaro)
        Me.Controls.Add(Me.pctPacchettoRaro)
        Me.Controls.Add(Me.pctPacchettoComune)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pacchetti"
        Me.Text = "pacchetti"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPacchettoSuperRaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPacchettoRaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPacchettoComune, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPesca As Button
    Friend WithEvents btnApri As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents prova As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pctPacchettoSuperRaro As PictureBox
    Friend WithEvents pctPacchettoRaro As PictureBox
    Friend WithEvents pctPacchettoComune As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
