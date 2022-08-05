<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRG = New System.Windows.Forms.TextBox()
        Me.TxtCPF = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.ChkFem = New System.Windows.Forms.CheckBox()
        Me.ChkMasc = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCEP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCel = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-MAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço"
        '
        'TxtRG
        '
        Me.TxtRG.Location = New System.Drawing.Point(108, 84)
        Me.TxtRG.Name = "TxtRG"
        Me.TxtRG.Size = New System.Drawing.Size(100, 23)
        Me.TxtRG.TabIndex = 5
        '
        'TxtCPF
        '
        Me.TxtCPF.Location = New System.Drawing.Point(248, 85)
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.Size = New System.Drawing.Size(100, 23)
        Me.TxtCPF.TabIndex = 6
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(109, 55)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(254, 23)
        Me.TxtNome.TabIndex = 7
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(107, 113)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(241, 23)
        Me.TxtEndereco.TabIndex = 8
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(421, 55)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(211, 23)
        Me.TxtEmail.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(85, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID"
        '
        'LblID
        '
        Me.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblID.Location = New System.Drawing.Point(109, 29)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(63, 23)
        Me.LblID.TabIndex = 11
        Me.LblID.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCadastrar)
        Me.GroupBox1.Controls.Add(Me.ChkFem)
        Me.GroupBox1.Controls.Add(Me.ChkMasc)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtCEP)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtCel)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtBairro)
        Me.GroupBox1.Controls.Add(Me.TxtCidade)
        Me.GroupBox1.Controls.Add(Me.TxtEstado)
        Me.GroupBox1.Controls.Add(Me.TxtComplemento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtEndereco)
        Me.GroupBox1.Controls.Add(Me.LblID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCPF)
        Me.GroupBox1.Controls.Add(Me.TxtRG)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 330)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Cliente"
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Location = New System.Drawing.Point(281, 281)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(82, 37)
        Me.BtnCadastrar.TabIndex = 31
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'ChkFem
        '
        Me.ChkFem.AutoSize = True
        Me.ChkFem.Location = New System.Drawing.Point(500, 87)
        Me.ChkFem.Name = "ChkFem"
        Me.ChkFem.Size = New System.Drawing.Size(76, 19)
        Me.ChkFem.TabIndex = 30
        Me.ChkFem.Text = "Feminino"
        Me.ChkFem.UseVisualStyleBackColor = True
        '
        'ChkMasc
        '
        Me.ChkMasc.AutoSize = True
        Me.ChkMasc.Location = New System.Drawing.Point(413, 87)
        Me.ChkMasc.Name = "ChkMasc"
        Me.ChkMasc.Size = New System.Drawing.Size(81, 19)
        Me.ChkMasc.TabIndex = 29
        Me.ChkMasc.Text = "Masculino"
        Me.ChkMasc.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(375, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Sexo"
        '
        'TxtCEP
        '
        Me.TxtCEP.Location = New System.Drawing.Point(401, 142)
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(121, 23)
        Me.TxtCEP.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(367, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "CEP"
        '
        'TxtCel
        '
        Me.TxtCel.Location = New System.Drawing.Point(314, 200)
        Me.TxtCel.Name = "TxtCel"
        Me.TxtCel.Size = New System.Drawing.Size(127, 23)
        Me.TxtCel.TabIndex = 25
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(137, 200)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(121, 23)
        Me.TxtTel.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Telefone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Celular"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(87, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Cidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(536, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Estado"
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(411, 113)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(117, 23)
        Me.TxtBairro.TabIndex = 19
        '
        'TxtCidade
        '
        Me.TxtCidade.Location = New System.Drawing.Point(137, 171)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(141, 23)
        Me.TxtCidade.TabIndex = 17
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(583, 112)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(49, 23)
        Me.TxtEstado.TabIndex = 16
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Location = New System.Drawing.Point(137, 142)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(211, 23)
        Me.TxtComplemento.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(367, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Bairro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Complemento"
        '
        'FrmCadastroClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 377)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCadastroClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRG As TextBox
    Friend WithEvents TxtCPF As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCadastrar As Button
    Friend WithEvents ChkFem As CheckBox
    Friend WithEvents ChkMasc As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCEP As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCel As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
