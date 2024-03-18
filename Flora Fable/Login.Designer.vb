<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtBoxUser = New System.Windows.Forms.TextBox()
        Me.TxtBoxPsw = New System.Windows.Forms.TextBox()
        Me.Label01 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistrati = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblPsw = New System.Windows.Forms.Label()
        Me.BtnEsci = New System.Windows.Forms.Button()
        Me.BtnSalva = New System.Windows.Forms.Button()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.TimerAnimazioni = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TxtBoxUser
        '
        Me.TxtBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxUser.Location = New System.Drawing.Point(30, 200)
        Me.TxtBoxUser.Name = "TxtBoxUser"
        Me.TxtBoxUser.Size = New System.Drawing.Size(370, 31)
        Me.TxtBoxUser.TabIndex = 0
        '
        'TxtBoxPsw
        '
        Me.TxtBoxPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxPsw.Location = New System.Drawing.Point(30, 330)
        Me.TxtBoxPsw.Name = "TxtBoxPsw"
        Me.TxtBoxPsw.Size = New System.Drawing.Size(370, 31)
        Me.TxtBoxPsw.TabIndex = 1
        '
        'Label01
        '
        Me.Label01.AutoSize = True
        Me.Label01.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label01.Location = New System.Drawing.Point(84, 34)
        Me.Label01.Name = "Label01"
        Me.Label01.Size = New System.Drawing.Size(270, 25)
        Me.Label01.TabIndex = 2
        Me.Label01.Text = "ACCEDI AL TUO ALBUM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NON HAI ANCORA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UN ALBUM?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRegistrati
        '
        Me.BtnRegistrati.Location = New System.Drawing.Point(278, 607)
        Me.BtnRegistrati.Name = "BtnRegistrati"
        Me.BtnRegistrati.Size = New System.Drawing.Size(122, 41)
        Me.BtnRegistrati.TabIndex = 4
        Me.BtnRegistrati.Text = "REGISTRATI"
        Me.BtnRegistrati.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(150, 150)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(139, 25)
        Me.LblUser.TabIndex = 5
        Me.LblUser.Text = "USERNAME"
        '
        'LblPsw
        '
        Me.LblPsw.AutoSize = True
        Me.LblPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPsw.Location = New System.Drawing.Point(150, 280)
        Me.LblPsw.Name = "LblPsw"
        Me.LblPsw.Size = New System.Drawing.Size(142, 25)
        Me.LblPsw.TabIndex = 6
        Me.LblPsw.Text = "PASSWORD"
        '
        'BtnEsci
        '
        Me.BtnEsci.Location = New System.Drawing.Point(12, 607)
        Me.BtnEsci.Name = "BtnEsci"
        Me.BtnEsci.Size = New System.Drawing.Size(122, 41)
        Me.BtnEsci.TabIndex = 7
        Me.BtnEsci.Text = "ESCI"
        Me.BtnEsci.UseVisualStyleBackColor = True
        '
        'BtnSalva
        '
        Me.BtnSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalva.Location = New System.Drawing.Point(150, 430)
        Me.BtnSalva.Name = "BtnSalva"
        Me.BtnSalva.Size = New System.Drawing.Size(146, 55)
        Me.BtnSalva.TabIndex = 8
        Me.BtnSalva.Text = "ACCEDI"
        Me.BtnSalva.UseVisualStyleBackColor = True
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(170, 150)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(88, 25)
        Me.LblEmail.TabIndex = 10
        Me.LblEmail.Text = "E-MAIL"
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxEmail.Location = New System.Drawing.Point(30, 200)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(370, 31)
        Me.TxtBoxEmail.TabIndex = 9
        '
        'TimerAnimazioni
        '
        Me.TimerAnimazioni.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 661)
        Me.Controls.Add(Me.BtnSalva)
        Me.Controls.Add(Me.BtnEsci)
        Me.Controls.Add(Me.LblPsw)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.BtnRegistrati)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label01)
        Me.Controls.Add(Me.TxtBoxPsw)
        Me.Controls.Add(Me.TxtBoxUser)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxPsw As System.Windows.Forms.TextBox
    Friend WithEvents Label01 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRegistrati As System.Windows.Forms.Button
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents LblPsw As System.Windows.Forms.Label
    Friend WithEvents BtnEsci As System.Windows.Forms.Button
    Friend WithEvents BtnSalva As System.Windows.Forms.Button
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TimerAnimazioni As System.Windows.Forms.Timer

End Class
