Public Class Menu


    Private Sub CadastrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClientesToolStripMenuItem.Click
        FrmUsuarioCadastro.Show()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using frm = New FrmLogin
            frm.ShowDialog()
            If Not pAcessoPermitido Then
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub ConsultarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarClientesToolStripMenuItem.Click
        FrmConsultarUsuarios.Show()
    End Sub

    Private Sub CadastrarNovoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarNovoClienteToolStripMenuItem.Click
        FrmCadastroClientes.Show()
    End Sub

    Private Sub ConsultarClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarClientesToolStripMenuItem1.Click
        FrmConsultarClientes.Show()
    End Sub
End Class
