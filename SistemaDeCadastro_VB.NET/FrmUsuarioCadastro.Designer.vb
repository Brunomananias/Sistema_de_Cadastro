<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioCadastro
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
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNascimento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSobrenome = New System.Windows.Forms.TextBox()
        Me.ChkAdministrador = New System.Windows.Forms.CheckBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCadastrar.Location = New System.Drawing.Point(245, 305)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(109, 32)
        Me.BtnCadastrar.TabIndex = 0
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(174, 116)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(100, 23)
        Me.TxtLogin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(174, 160)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(100, 23)
        Me.TxtNome.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Endereço"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(178, 234)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(285, 23)
        Me.TxtEndereco.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Senha"
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(338, 116)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(100, 23)
        Me.TxtSenha.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nascimento"
        '
        'TxtNascimento
        '
        Me.TxtNascimento.Location = New System.Drawing.Point(196, 198)
        Me.TxtNascimento.Name = "TxtNascimento"
        Me.TxtNascimento.Size = New System.Drawing.Size(105, 23)
        Me.TxtNascimento.TabIndex = 11
        Me.TxtNascimento.Text = "dd/mm/yyyy"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sobrenome"
        '
        'TxtSobrenome
        '
        Me.TxtSobrenome.Location = New System.Drawing.Point(360, 160)
        Me.TxtSobrenome.Name = "TxtSobrenome"
        Me.TxtSobrenome.Size = New System.Drawing.Size(121, 23)
        Me.TxtSobrenome.TabIndex = 13
        '
        'ChkAdministrador
        '
        Me.ChkAdministrador.AutoSize = True
        Me.ChkAdministrador.Location = New System.Drawing.Point(174, 280)
        Me.ChkAdministrador.Name = "ChkAdministrador"
        Me.ChkAdministrador.Size = New System.Drawing.Size(102, 19)
        Me.ChkAdministrador.TabIndex = 15
        Me.ChkAdministrador.Text = "Administrador"
        Me.ChkAdministrador.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblID.Location = New System.Drawing.Point(178, 74)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(71, 19)
        Me.LblID.TabIndex = 16
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Location = New System.Drawing.Point(360, 280)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(54, 19)
        Me.ChkAtivo.TabIndex = 17
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'FrmUsuarioCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(604, 361)
        Me.Controls.Add(Me.ChkAtivo)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.ChkAdministrador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSobrenome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNascimento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCadastrar)
        Me.Name = "FrmUsuarioCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCadastrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNascimento As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtSobrenome As TextBox
    Friend WithEvents ChkAdministrador As CheckBox
    Friend WithEvents LblID As Label
    Friend WithEvents ChkAtivo As CheckBox
End Class
