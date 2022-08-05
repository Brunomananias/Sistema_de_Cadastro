Imports System.Data.SqlClient
Public Class FrmUsuarioCadastro
    Private Sub FrmUsuarioCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        If ValidarForm() Then
            CadastrarUsuario()
        End If
    End Sub

    Private Function ValidarForm()
        Dim Result As Boolean
        If TxtLogin.Text = "" Then
            MsgBox("Favor preencher o campo de login", vbExclamation, sistema)
            TxtLogin.Focus()
            Result = False
        ElseIf TxtSenha.Text = "" Then
            MsgBox("Favor preencher o campo de senha", vbExclamation, sistema)
            TxtSenha.Focus()
            Result = False
        ElseIf TxtNome.Text = "" Then
            MsgBox("Favor preencher o campo de nome", vbExclamation, sistema)
            TxtSenha.Focus()
            Result = False
        ElseIf TxtSobrenome.Text = "" Then
            MsgBox("Favor preencher o campo de sobrenome", vbExclamation, sistema)
            TxtSenha.Focus()
            Result = False
        ElseIf TxtNascimento.Text = "" Then
            MsgBox("Favor preencher o campo de nascimento", vbExclamation, sistema)
            TxtSenha.Focus()
            Result = False
        ElseIf TxtEndereco.Text = "" Then
            MsgBox("Favor preencher o campo de endereço", vbExclamation, sistema)
            TxtSenha.Focus()
            Result = False
        Else
            Result = True

        End If
        Return Result
    End Function
    Private Sub CadastrarUsuario()

        Try

            Dim sql = ""
            If CLng(0 & LblID.Text) = 0 Then
                sql = "INSERT INTO Usuarios (Login, Senha, Nome, Sobrenome, Nascimento, Endereco, Administrador, Ativo) 
                                    VALUES (@Login, @Senha, @Nome, @Sobrenome, @Nascimento, @Endereco, @Administrador, @Ativo)"
            Else
                sql = ("UPDATE Usuarios SET login=@login, senha=@senha, nome=@nome, sobrenome=@sobrenome, nascimento=@nascimento,
                                    endereco=@endereco, administrador=@administrador, ativo=@ativo WHERE ID" & LblID.Text)

            End If

            Using conexao As New SqlConnection(conn)
                conexao.Open()
                Using cmd As New SqlCommand(sql, conexao)
                    cmd.Parameters.AddWithValue("Login", TxtLogin.Text)
                    cmd.Parameters.AddWithValue("Senha", TxtSenha.Text)
                    cmd.Parameters.AddWithValue("Nome", TxtNome.Text)
                    cmd.Parameters.AddWithValue("Sobrenome", TxtSobrenome.Text)
                    cmd.Parameters.AddWithValue("Nascimento", TxtNascimento.Text)
                    cmd.Parameters.AddWithValue("Endereco", TxtEndereco.Text)
                    cmd.Parameters.AddWithValue("Administrador", IIf(ChkAdministrador.Checked, "S", "N"))
                    cmd.Parameters.AddWithValue("Ativo", IIf(ChkAtivo.Checked, "S", "N"))

                    cmd.ExecuteNonQuery()
                    MsgBox("Cadastrado com sucesso!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, sistema)

        End Try
    End Sub
End Class