<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovoClienteToolStripMenuItem, Me.ConsultarClientesToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CadastrarNovoClienteToolStripMenuItem
        '
        Me.CadastrarNovoClienteToolStripMenuItem.Name = "CadastrarNovoClienteToolStripMenuItem"
        Me.CadastrarNovoClienteToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CadastrarNovoClienteToolStripMenuItem.Text = "Cadastrar novo cliente"
        '
        'ConsultarClientesToolStripMenuItem1
        '
        Me.ConsultarClientesToolStripMenuItem1.Name = "ConsultarClientesToolStripMenuItem1"
        Me.ConsultarClientesToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ConsultarClientesToolStripMenuItem1.Text = "Consultar clientes"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarClientesToolStripMenuItem, Me.TrocarSenhaToolStripMenuItem, Me.ConsultarClientesToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CadastroToolStripMenuItem.Text = "Usuários"
        '
        'CadastrarClientesToolStripMenuItem
        '
        Me.CadastrarClientesToolStripMenuItem.Name = "CadastrarClientesToolStripMenuItem"
        Me.CadastrarClientesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CadastrarClientesToolStripMenuItem.Text = "Cadastrar Novo Usuário"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar Senha"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar Usuários"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaDeCadastro_VB.NET.My.Resources.Resources.Qual_a_tecnologia
        Me.ClientSize = New System.Drawing.Size(547, 362)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Cadastro"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarNovoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem1 As ToolStripMenuItem
End Class
