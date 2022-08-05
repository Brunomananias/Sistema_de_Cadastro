<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControleDeAcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovoUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsúariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoltarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(78, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(437, 224)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControleDeAcessoToolStripMenuItem, Me.VoltarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControleDeAcessoToolStripMenuItem
        '
        Me.ControleDeAcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovoUsuárioToolStripMenuItem, Me.TrocarSenhaToolStripMenuItem, Me.ConsultarUsúariosToolStripMenuItem})
        Me.ControleDeAcessoToolStripMenuItem.Name = "ControleDeAcessoToolStripMenuItem"
        Me.ControleDeAcessoToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ControleDeAcessoToolStripMenuItem.Text = "Controle de Acesso"
        '
        'CadastrarNovoUsuárioToolStripMenuItem
        '
        Me.CadastrarNovoUsuárioToolStripMenuItem.Name = "CadastrarNovoUsuárioToolStripMenuItem"
        Me.CadastrarNovoUsuárioToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar Novo Usuário"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar Senha"
        '
        'ConsultarUsúariosToolStripMenuItem
        '
        Me.ConsultarUsúariosToolStripMenuItem.Name = "ConsultarUsúariosToolStripMenuItem"
        Me.ConsultarUsúariosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConsultarUsúariosToolStripMenuItem.Text = "Consultar Usúarios"
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.VoltarToolStripMenuItem.Text = "Voltar "
        '
        'FrmConsultarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 338)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmConsultarUsuarios"
        Me.Text = "FrmConsultarUsuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ControleDeAcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarNovoUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarUsúariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
End Class
