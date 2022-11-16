<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.n1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.n2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.n3 = New System.Windows.Forms.Label()
        Me.btnJogar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.win = New System.Windows.Forms.Label()
        Me.lost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.valorSaldo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.padrao = New System.Windows.Forms.Label()
        Me.imgWinLost = New System.Windows.Forms.PictureBox()
        Me.imgResultado = New System.Windows.Forms.PictureBox()
        Me.bg = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imgWinLost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(285, 87)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(226, 36)
        Me.title.TabIndex = 0
        Me.title.Text = "Jogo 7 da Sorte"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.n1)
        Me.Panel1.Location = New System.Drawing.Point(249, 223)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 80)
        Me.Panel1.TabIndex = 1
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n1.Location = New System.Drawing.Point(13, 13)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(51, 54)
        Me.n1.TabIndex = 0
        Me.n1.Text = "0"
        Me.n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.n2)
        Me.Panel2.Location = New System.Drawing.Point(357, 223)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 80)
        Me.Panel2.TabIndex = 2
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n2.Location = New System.Drawing.Point(15, 13)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(51, 54)
        Me.n2.TabIndex = 1
        Me.n2.Text = "0"
        Me.n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.n3)
        Me.Panel3.Location = New System.Drawing.Point(461, 223)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(81, 80)
        Me.Panel3.TabIndex = 3
        '
        'n3
        '
        Me.n3.AutoSize = True
        Me.n3.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n3.Location = New System.Drawing.Point(14, 13)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(51, 54)
        Me.n3.TabIndex = 1
        Me.n3.Text = "0"
        Me.n3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnJogar
        '
        Me.btnJogar.BackColor = System.Drawing.Color.Red
        Me.btnJogar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJogar.Location = New System.Drawing.Point(581, 205)
        Me.btnJogar.Name = "btnJogar"
        Me.btnJogar.Size = New System.Drawing.Size(87, 49)
        Me.btnJogar.TabIndex = 1
        Me.btnJogar.Text = "Jogar"
        Me.btnJogar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Red
        Me.btnSair.Location = New System.Drawing.Point(715, 405)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(73, 33)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'win
        '
        Me.win.AutoSize = True
        Me.win.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.win.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.win.Location = New System.Drawing.Point(136, 362)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(27, 27)
        Me.win.TabIndex = 7
        Me.win.Text = "0"
        '
        'lost
        '
        Me.lost.AutoSize = True
        Me.lost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lost.Location = New System.Drawing.Point(136, 405)
        Me.lost.Name = "lost"
        Me.lost.Size = New System.Drawing.Size(27, 27)
        Me.lost.TabIndex = 8
        Me.lost.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ganhou:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Perdeu:"
        '
        'valorSaldo
        '
        Me.valorSaldo.AutoSize = True
        Me.valorSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorSaldo.Location = New System.Drawing.Point(737, 85)
        Me.valorSaldo.Margin = New System.Windows.Forms.Padding(0)
        Me.valorSaldo.Name = "valorSaldo"
        Me.valorSaldo.Size = New System.Drawing.Size(51, 25)
        Me.valorSaldo.TabIndex = 12
        Me.valorSaldo.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(595, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Saldo atual: R$"
        '
        'padrao
        '
        Me.padrao.AutoSize = True
        Me.padrao.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.padrao.Location = New System.Drawing.Point(311, 164)
        Me.padrao.Name = "padrao"
        Me.padrao.Size = New System.Drawing.Size(185, 23)
        Me.padrao.TabIndex = 14
        Me.padrao.Text = "Valor da aposta: R$1"
        '
        'imgWinLost
        '
        Me.imgWinLost.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.imgWinLost.Location = New System.Drawing.Point(15, 145)
        Me.imgWinLost.Name = "imgWinLost"
        Me.imgWinLost.Size = New System.Drawing.Size(171, 127)
        Me.imgWinLost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgWinLost.TabIndex = 11
        Me.imgWinLost.TabStop = False
        '
        'imgResultado
        '
        Me.imgResultado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.imgResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgResultado.Location = New System.Drawing.Point(228, 326)
        Me.imgResultado.Name = "imgResultado"
        Me.imgResultado.Size = New System.Drawing.Size(332, 123)
        Me.imgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgResultado.TabIndex = 5
        Me.imgResultado.TabStop = False
        '
        'bg
        '
        Me.bg.BackColor = System.Drawing.Color.Transparent
        Me.bg.ImageLocation = "C:\Users\Lucas\source\repos\Jogo7SorteSl\maquina.png"
        Me.bg.Location = New System.Drawing.Point(86, -29)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(669, 497)
        Me.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bg.TabIndex = 6
        Me.bg.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.Jogo7Sorte.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.padrao)
        Me.Controls.Add(Me.valorSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.imgWinLost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lost)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.imgResultado)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnJogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.bg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Jogo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imgWinLost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents n1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents n2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents n3 As Label
    Friend WithEvents btnJogar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents imgResultado As PictureBox
    Friend WithEvents bg As PictureBox
    Friend WithEvents win As Label
    Friend WithEvents lost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imgWinLost As PictureBox
    Friend WithEvents valorSaldo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents padrao As Label
End Class
